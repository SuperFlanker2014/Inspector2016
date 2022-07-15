using System;
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace DBManager
{
	public class SqlScriptHelper
	{
        private static readonly List<string> lst = new List<string>();
        private static readonly Regex _NonWhiteRegex = new Regex(@"\S+", RegexOptions.ExplicitCapture | RegexOptions.Compiled | RegexOptions.Multiline);
        private static readonly Regex _GoRegex = new Regex(@"^\s*(g|G)(o|O)\s*$", RegexOptions.ExplicitCapture | RegexOptions.Compiled | RegexOptions.Multiline);

        public static List<string> Errors
        {
            get
            {
                return lst;
            }
        }

        private SqlScriptHelper()
        {
        }

		public static void ExecuteScript(SqlConnection connection, string script)
		{
            CheckParameters(script, connection);

            SqlTransaction transaction;
            try
            {
                connection.Open();
                transaction = connection.BeginTransaction("db_update");
            }
            catch (Exception ex)
            {
                lst.Add(ex.Message);
                return;
            }

			SqlCommand command = new SqlCommand();

			command.Connection = connection;
			command.Transaction = transaction;
			InternalExecuteScript(command, script);

            if (lst.Count > 0)
                transaction.Rollback();
            else
                transaction.Commit();
		}

        private static void CheckParameters(string script, SqlConnection connection)
        {
            if (connection == null)
                throw new ArgumentNullException("connection");
            if (script == null)
                throw new ArgumentNullException("script");
        }

        private static void InternalExecuteScript(SqlCommand command, string script)
        {
            if (command == null || command.Connection == null)
            {
                throw new ArgumentNullException();
            }
            string[] commands = _GoRegex.Split(script);

            bool isNeedCloseConnection;
            if (command.Connection.State == ConnectionState.Closed)
            {
                command.Connection.Open();
                isNeedCloseConnection = true;
            }
            else
            {
                isNeedCloseConnection = false;
            }
            try
            {
                foreach (string commandText in commands)
                {
                    if (!_NonWhiteRegex.IsMatch(commandText))
                    {
                        continue;
                    }

                    command.CommandText = commandText;

                    if (command.CommandText.Contains("sp_configure") ||
                        command.CommandText.Contains("RECONFIGURE"))
                    {
                        SqlConnection cn = new SqlConnection(command.Connection.ConnectionString);
                        cn.Open();
                        SqlCommand cmd = new SqlCommand(commandText, cn);
                        cmd.ExecuteNonQuery();
                        cn.Close();
                    }
                    else
                    {
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                lst.Add(ex.Message);
            }
            catch (Exception ex)
            {
                lst.Add(ex.Message);
            }
            finally
            {
                if (isNeedCloseConnection)
                {
                    command.Connection.Close();
                }
            }
        }
	}
}
