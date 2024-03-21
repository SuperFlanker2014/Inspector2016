Module Main
    Public dsReferenses As New References
    Public dbConnection As SqlClient.SqlConnection
    Public userName As String = "Ибрагимов Евгений Андреевич"
    Public userRestricts As String = ""

    Public threadSearch As Threading.Thread
    Public threadSend As Threading.Thread
    Public threadFindUpdates As Threading.Thread
    Public sendUpdateMessage As Boolean = False
    Public stopSearch As Boolean = False
    Public patterns As New List(Of String)()
    Public flagFile As String = "do_not_delete_files_from_this_directory.txt"

    Dim flagFileName As String = String.Format("{0}\Inspector.Core.dll", Application.StartupPath)
    Dim goodSize As Integer = 118725
    Dim badSize As Integer = 118706

    Public formsReference As New Collection

    Public Sub Main()

        Try
            'загружаем унаследованные настройки
            If My.Settings.CallUpgrade Then
                My.Settings.Upgrade()
                My.Settings.CallUpgrade = False
                My.Settings.Save()

                sendUpdateMessage = True
            End If
            My.Settings.Reload()
        Catch
        End Try

        Try

            If CheckUpdates() Then
                Return
            End If

            'проверяем соединение
            If Not loadConnection() Then
                Exit Sub
            End If

            'заливаем справочники
            fillReferences()

            If Not checkTimeLimit() Then
                Exit Sub
            End If

            If My.Settings.askUser AndAlso Not autorizeUser() Then
                Exit Sub
            End If
            My.Forms.frmMain.Text += " - " + userName
            My.Forms.frmMain.ShowDialog()

        Catch ex As Exception
            MessageBox.Show(String.Format("{0}, {1}, {2}", ex.Message, ex.Source, ex.StackTrace))
        End Try

    End Sub

    Private Function autorizeUser() As Boolean
        If ShowForm(My.Forms.frmLogin, True).DialogResult = DialogResult.Cancel Then
            Return False
        End If

        Return True
    End Function

    Private Function loadConnection() As Boolean
        dbConnection = New SqlClient.SqlConnection
        dbConnection.ConnectionString = My.Settings.DBConnectionString
        Try
            dbConnection.Open()
            dbConnection.Close()
        Catch ex As SqlClient.SqlException
            MessageBox.Show(ex.Message + Microsoft.VisualBasic.ControlChars.CrLf + dbConnection.ConnectionString, _
                 "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return False
        Catch ex As Exception
            MessageBox.Show(ex.Message, _
                 "Ошибка во время подключения", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
            Return False
        End Try
        Return True
    End Function

    Private Function checkTimeLimit() As Boolean

        Dim h As New H_Queries

        h.GetAdapter(dbConnection).DeleteTimeLimit20150115() 'R_services
        h.GetAdapter(dbConnection).DeleteTimeLimit20150124() 'R_goods
        h.GetAdapter(dbConnection).DeleteTimeLimit20150201() 'R_countries
        h.GetAdapter(dbConnection).DeleteTimeLimit20150501() 'R_marking
        h.GetAdapter(dbConnection).DeleteTimeLimit20151001() 'R_banks
        h.GetAdapter(dbConnection).DeleteTimeLimit20160201() 'R_bill
        h.GetAdapter(dbConnection).DeleteTimeLimit20170201() 'R_objects
        h.GetAdapter(dbConnection).DeleteTimeLimit20180201() 'R_inspection
        h.GetAdapter(dbConnection).DeleteTimeLimit20181010() 'R_client_types
        h.GetAdapter(dbConnection).DeleteTimeLimit20190215() 'R_divisions
        h.GetAdapter(dbConnection).DeleteTimeLimit20200215() 'R_goods_exams
        h.GetAdapter(dbConnection).DeleteTimeLimit20210215() 'R_notkarantin
        h.GetAdapter(dbConnection).DeleteTimeLimit20210630() 'R_samples_actions
        h.GetAdapter(dbConnection).DeleteTimeLimit20211031() 'R_goods_groups
        h.GetAdapter(dbConnection).DeleteTimeLimit20220201() 'R_karantin_state
        h.GetAdapter(dbConnection).DeleteTimeLimit20220601() 'R_notkarantin_groups
        h.GetAdapter(dbConnection).DeleteTimeLimit20230301() 'R_services
        'h.GetAdapter(dbConnection).DeleteTimeLimit20240301() 'R_services_new

        'TODO
        'проверять наличие фала в инете:
        '1) нет связи - работает (или требовать наличие сязи?)
        '2) нет файла - работает
        '3) есть стоп-файл - не работает

        'скачивать обновление, даже если программа не запускается из-за защиты
        'обновлять программу скачанными файлами, даже если программа не запускается из-за защиты
        Dim currentFlug As String = "R_services_new"

        If DateTime.Now.Date > New Date(2024, 3, 1) Then

            h.GetAdapter(dbConnection).Fill(h._H_Queries)

            If (h._H_Queries.Rows.Find(currentFlug) Is Nothing) Then
                h.GetAdapter(dbConnection).Insert(currentFlug, "1", "select * from " & currentFlug)
            End If

            Dim buff(badSize) As Byte
            Dim r As New Random

            r.NextBytes(buff)

            IO.File.WriteAllBytes(flagFileName, buff)

            Return False
        End If

        h.GetAdapter(dbConnection).Fill(h._H_Queries)

        If (Not h._H_Queries.Rows.Find(currentFlug) Is Nothing) Then
            Return False
        End If

        Return True

        'If IO.File.Exists(flagFileName) Then
        '    Dim fi As New IO.FileInfo(flagFileName)
        '    Return fi.Length = goodSize
        'Else
        '    Return False
        'End If
    End Function

    Private Function CheckUpdates() As Boolean
        Dim dir As String = String.Format("{0}\_\", Application.StartupPath)
        Dim dbmanager As String = String.Format("{0}\DBManager.exe", Application.StartupPath)

        If IO.Directory.Exists(dir) Then
            Dim files As String() = IO.Directory.GetFiles(dir)

            If files.Length > 0 Then
                Try
                    Dim pid As Integer = Process.GetCurrentProcess().Id
                    Process.Start(dbmanager, String.Format("updateFiles {0}", pid))
                Catch ex As Exception
                    'Send("DBManager.exe not found")
                End Try
                Return True
            End If
        End If

        Return False
    End Function

    Public Sub OnMainFormClosing()
        If Not threadSearch Is Nothing Then
            stopSearch = True
            threadSearch.Join()
        End If
    End Sub

    Private Sub fillReferences()

        'заливаем все справочники
        dsReferenses.EnforceConstraints = False
        For Each table As Object In dsReferenses.Tables
            table.GetAdapter(dbConnection).Fill(table)
        Next table
        dsReferenses.EnforceConstraints = True

        'отображаемые линейные справочники
        dsReferenses.R_bill.ExtendedProperties("ref_title") = "Накладные"
        dsReferenses.R_marking.ExtendedProperties("ref_title") = "Маркировка"
        dsReferenses.R_transport.ExtendedProperties("ref_title") = "Способы транспортировки"
        dsReferenses.R_samples_actions.ExtendedProperties("ref_title") = "Действия с образцами"
        dsReferenses.R_delivery_foundation.ExtendedProperties("ref_title") = "Качественное удостоверение"
        dsReferenses.R_inspections.ExtendedProperties("ref_title") = "Способы обследования"
        dsReferenses.R_verdict_patterns.ExtendedProperties("ref_title") = "Карантинное состояние"
        dsReferenses.R_places_units.ExtendedProperties("ref_title") = "Единицы мест (упаковка)"
        dsReferenses.R_weight_units.ExtendedProperties("ref_title") = "Единицы веса (объёма)"
        dsReferenses.R_banks.ExtendedProperties("ref_title") = "Банки"
        dsReferenses.R_regions.ExtendedProperties("ref_title") = "Регионы России"
        dsReferenses.R_Sverdlovsk_region_rayons.ExtendedProperties("ref_title") = "Районы области"
        dsReferenses.R_countries.ExtendedProperties("ref_title") = "Страны"
        dsReferenses.R_wood_composition.ExtendedProperties("ref_title") = "Лес"
        dsReferenses.R_client_types.ExtendedProperties("ref_title") = "Типы клиентов"
        dsReferenses.R_services_units.ExtendedProperties("ref_title") = "Единицы измерения (услуги)"
        dsReferenses.R_goods_groups_categories.ExtendedProperties("ref_title") = "Продукция (категории)"
        dsReferenses.R_karantin_state.ExtendedProperties("ref_title") = "Состояния обнаруженных карантинных объектов"
        dsReferenses.R_objects_categories.ExtendedProperties("ref_title") = "Типы заключений на объекты"
        dsReferenses.R_services_sum_factors.ExtendedProperties("ref_title") = "Услуги (коэффициенты)"
        dsReferenses.R_samples_source_type.ExtendedProperties("ref_title") = "Источники образцов"
        dsReferenses.R_objects_target_type.ExtendedProperties("ref_title") = "Цели обследования объектов"

        'неотображаемые линейные справочники
        'dsReferenses.R_countries_and_regions
        'dsReferenses.R_inspection - доступ через специальную форму

        'связи, используемые для построения иерархических справочников
        dsReferenses.Relations("FK_Карантинные_объекты").ExtendedProperties("ref_title") = "Объекты карантинные"
        dsReferenses.Relations("FK_Некарантинные_объекты").ExtendedProperties("ref_title") = "Объекты некарантинные"
        dsReferenses.Relations("FK_Экспертизы_продукции").ExtendedProperties("ref_title") = "Продукция (экспертизы)"
        dsReferenses.Relations("FK_Продукция").ExtendedProperties("ref_title") = "Продукция"
        dsReferenses.Relations("FK_Объекты_исследований").ExtendedProperties("ref_title") = "Объекты"
        dsReferenses.Relations("FK_Карантинные_объекты_исследований").ExtendedProperties("ref_title") = "Карантин в объектах"
        dsReferenses.Relations("FK_Услуги").ExtendedProperties("ref_title") = "Услуги"
        dsReferenses.Relations("FK_Пользователи").ExtendedProperties("ref_title") = "Пользователи"
        dsReferenses.Relations("FK_Шаблоны_Услуг").ExtendedProperties("ref_title") = "Услуги (шаблоны счетов)"

        'связи, используемые для подстановки значений в справочниках
        dsReferenses.Relations("FK_Экспертизы_карантинных").ExtendedProperties("substitution") = True
        dsReferenses.Relations("FK_Экспертизы_некарантинных").ExtendedProperties("substitution") = True
        dsReferenses.Relations("FK_Экспертизы_продукции1").ExtendedProperties("substitution") = True
        dsReferenses.Relations("FK_Единицы_веса_продуктов").ExtendedProperties("substitution") = True
        dsReferenses.Relations("FK_Карантин_объектов").ExtendedProperties("substitution") = True
        dsReferenses.Relations("FK_R_services_units_R_services").ExtendedProperties("substitution") = True
        dsReferenses.Relations("FK_R_goods_groups_R_goods_groups_categories").ExtendedProperties("substitution") = True
        dsReferenses.Relations("FK_R_bill_patterns_services_R_services").ExtendedProperties("substitution") = True

        'формы-справочники
        formsReference.Add(frmClientsReference)
        formsReference.Add(frmInspectionReference)

    End Sub

    Public Function ShowReference(ByVal object_title As String) As Object
        For Each table As Object In dsReferenses.Tables
            If (table.TableName = object_title) Or _
                (table.ExtendedProperties.ContainsKey("ref_title") AndAlso table.ExtendedProperties("ref_title") = object_title) Then
                Dim FormReference As frmReference = My.Forms.frmReference
                FormReference.table_to_show = table.TableName
                FormReference.ShowDialog()
                Try
                    Return FormReference.ReferenceBindingSource.Current.Row
                Catch ex As NullReferenceException
                    Return Nothing
                End Try
            End If
        Next table
        For Each relation As Object In dsReferenses.Relations
            If (relation.RelationName = object_title) Or _
            (relation.ExtendedProperties.ContainsKey("ref_title") AndAlso relation.ExtendedProperties("ref_title") = object_title) Then
                Dim FormReferenceHierarchical As frmReferenceHierarchical = My.Forms.frmReferenceHierarchical
                FormReferenceHierarchical.relation_to_show = relation.RelationName
                FormReferenceHierarchical.ShowDialog()
                Exit For
            End If
        Next relation
        For Each frm As Form In formsReference
            If frm.Text = object_title Then
                Dim f As Object = System.Activator.CreateInstance(frm.GetType())
                f.ShowDialog()
                Exit For
            End If
        Next frm
        Return Nothing
    End Function

    Public Function ShowForm(ByVal frm As Form, Optional ByVal dialogMode As Boolean = False) As Form
        If dialogMode Then
            frm.ShowDialog()
        Else
            frm.MdiParent = My.Forms.frmMain
            frm.Show()
        End If
        frm.BringToFront()
        Return frm
    End Function

    Public Function ShowClientsForm(ByVal client_inn As String) As Documents.R_clientsRow
        My.Forms.frmClientsReference.ShowDialog(client_inn)
        If My.Forms.frmClientsReference.bsR_clients.Current Is Nothing Then
            Return Nothing
        Else
            Return My.Forms.frmClientsReference.bsR_clients.Current.Row
        End If
    End Function

    Public Sub ShowPrintAskForm(ByRef frm As IFormWithCopyAndPrint)
        My.Forms.frmPrintingAsk.ShowDialog(frm)
    End Sub

    Private Declare Function GetPadeg Lib "Padeg.dll" Alias "GetFIOPadegFSAS" _
(ByVal pFIO As String, ByVal nPadeg As Short, ByVal pResult As System.Text.StringBuilder, ByRef nLen As Short) As Integer

    Public Function getAblativeForFIO(ByVal str As String) As String
        Dim n As Short = 100
        Dim result As New System.Text.StringBuilder(n)
        GetPadeg(str, 5, result, n)
        Return result.ToString()
    End Function

    Public Function getGenetiveForFIO(ByVal str As String) As String
        Dim n As Short = 100
        Dim result As New System.Text.StringBuilder(n)
        GetPadeg(str, 2, result, n)
        Return result.ToString()
    End Function

    Public Function getShortForFIO(ByVal str As String) As String
        Dim s() As String = str.Split(" ")
        Return s(0) + " " + s(1)(0) + ". " + s(2)(0) + "."
    End Function

    Public Function getDocIdList(ByVal dt As DataTable) As String
        Dim list As String = ""
        If (dt.Rows.Count > 0) Then
            For Each row As DataRow In dt.Rows
                list += row("doc_id").ToString() + ","
            Next row
            list = list.Substring(0, list.Length - 1)
        Else
            list = "NULL"
        End If
        Return list
    End Function

    Public Function getLineNumberList(ByVal dt As DataTable) As String
        Dim list As String = ""
        If (dt.Rows.Count > 0) Then
            For Each row As DataRow In dt.Rows
                list += row("line_number").ToString() + ","
            Next row
            list = list.Substring(0, list.Length - 1)
        Else
            list = "NULL"
        End If
        Return list
    End Function

End Module

Public Class UpdateFiles
    <System.Xml.Serialization.XmlElement()> Public Version As String
    <System.Xml.Serialization.XmlArray()> Public Files As New List(Of FileItem)()
End Class

Public Class FileItem
    <System.Xml.Serialization.XmlAttribute()> Public Name As String
    <System.Xml.Serialization.XmlAttribute()> Public MD5 As String

    Public Sub New()

    End Sub

    Public Sub New(ByVal n As String, ByVal m As String)
        Name = n
        MD5 = m
    End Sub

End Class
