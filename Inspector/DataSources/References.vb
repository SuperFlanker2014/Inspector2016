
Partial Public Class References
    Partial Public Class R_countriesDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.ReferencesTableAdapters.R_countriesTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
    Partial Public Class R_goodsDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.ReferencesTableAdapters.R_goodsTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
    Partial Public Class R_goods_groupsDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.ReferencesTableAdapters.R_goods_groupsTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
    Partial Public Class R_karantinDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.ReferencesTableAdapters.R_karantinTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
    Partial Public Class R_karantin_groupsDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.ReferencesTableAdapters.R_karantin_groupsTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
    Partial Public Class R_places_unitsDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.ReferencesTableAdapters.R_places_unitsTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
    Partial Public Class R_weight_unitsDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.ReferencesTableAdapters.R_weight_unitsTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
    Partial Public Class R_banksDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.ReferencesTableAdapters.R_banksTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
    Partial Public Class R_regionsDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.ReferencesTableAdapters.R_regionsTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
    Partial Public Class R_countries_and_regionsDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.ReferencesTableAdapters.R_countries_and_regionsTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
    Partial Public Class R_Sverdlovsk_region_rayonsDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.ReferencesTableAdapters.R_Sverdlovsk_region_rayonsTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
    Partial Public Class R_usersDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.ReferencesTableAdapters.R_usersTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
    Partial Public Class R_examinationsDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.ReferencesTableAdapters.R_examinationsTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
    Partial Public Class R_billDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.ReferencesTableAdapters.R_billTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
    Partial Public Class R_billsDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.ReferencesTableAdapters.R_billTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
    Partial Public Class R_markingDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.ReferencesTableAdapters.R_markingTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
    Partial Public Class R_transportDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.ReferencesTableAdapters.R_transportTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
    Partial Public Class R_samples_actionsDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.ReferencesTableAdapters.R_samples_actionsTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
    Partial Public Class R_delivery_foundationDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.ReferencesTableAdapters.R_delivery_foundationTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
    Partial Public Class R_inspectionsDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.ReferencesTableAdapters.R_inspectionsTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
    Partial Public Class R_verdict_patternsDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.ReferencesTableAdapters.R_verdict_patternsTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
    Partial Public Class R_notkarantinDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.ReferencesTableAdapters.R_notkarantinTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
    Partial Public Class R_notkarantin_groupsDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.ReferencesTableAdapters.R_notkarantin_groupsTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
    Partial Public Class R_goods_examsDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.ReferencesTableAdapters.R_goods_examsTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
    Partial Public Class R_wood_compositionDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.ReferencesTableAdapters.R_wood_compositionTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
    Partial Public Class R_client_typesDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.ReferencesTableAdapters.R_client_typesTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class

    Partial Public Class R_objectsDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.ReferencesTableAdapters.R_objectsTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
    Partial Public Class R_objects_groupsDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.ReferencesTableAdapters.R_objects_groupsTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
    Partial Public Class R_objects_groups_karantinDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.ReferencesTableAdapters.R_objects_groups_karantinTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
    Partial Public Class R_services_groupsDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.ReferencesTableAdapters.R_services_groupsTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
    Partial Public Class R_servicesDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.ReferencesTableAdapters.R_servicesTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
    Partial Public Class R_divisionsDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.ReferencesTableAdapters.R_divisionsTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
    Partial Public Class R_inspectionDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.ReferencesTableAdapters.R_inspectionTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
    Partial Public Class R_services_unitsDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.ReferencesTableAdapters.R_services_unitsTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
    Partial Public Class R_goods_groups_categoriesDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.ReferencesTableAdapters.R_goods_groups_categoriesTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
    Partial Public Class R_karantin_stateDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.ReferencesTableAdapters.R_karantin_stateTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
    Partial Public Class R_bill_patternsDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.ReferencesTableAdapters.R_bill_patternsTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
    Partial Public Class R_bill_patterns_servicesDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.ReferencesTableAdapters.R_bill_patterns_servicesTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
    Partial Public Class R_objects_categoriesDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.ReferencesTableAdapters.R_objects_categoriesTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
    Partial Public Class R_services_sum_factorsDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.ReferencesTableAdapters.R_services_sum_factorsTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
    Partial Public Class R_samples_source_typeDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.ReferencesTableAdapters.R_samples_source_typeTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
    Partial Public Class R_objects_target_typeDataTable
        Public Function GetAdapter(ByVal dbConnection As Data.SqlClient.SqlConnection)
            Dim p As New Inspector.ReferencesTableAdapters.R_objects_target_typeTableAdapter
            p.Connection = dbConnection
            Return p
        End Function
    End Class
End Class
