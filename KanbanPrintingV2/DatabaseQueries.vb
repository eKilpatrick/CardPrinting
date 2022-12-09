Module DatabaseQueries
    Public Function GetKanbanInfo(PN As String, Location As String)
        Dim dal As New DALControl
        Dim query As String
        If PN <> Nothing Then
            query = "SELECT KANBAN_ID, REPL_STRATEGY, BIN_SIZE FROM SFM_RCH.VIEW_KANBAN_PK18_REPORT WHERE PN = '" & PN & "' AND SUPPLY_AREA LIKE '%" & Location & "%' ORDER BY SUPPLY_AREA"
        Else
            query = "SELECT KANBAN_ID, REPL_STRATEGY, BIN_SIZE FROM SFM_RCH.VIEW_KANBAN_PK18_REPORT WHERE SUPPLY_AREA LIKE '%" & Location & "%' ORDER BY SUPPLY_AREA"
        End If
        dal.RunQuery(query)

        If dal.SQLDataset01.Tables(0).Rows.Count <> 0 Then
            Return dal.SQLDataset01.Tables(0).Rows
        Else
            Return Nothing
        End If
    End Function

    Public Function GetDescription(PN As String)
        Try
            Dim dal As New DALControl
            Dim query = "SELECT MM_DESCR FROM SFM_RCH.PROD_ORDER_COMP_T WHERE MM = '" & PN & "'"
            dal.RunQuery(query)

            If dal.SQLDataset01.Tables(0).Rows.Count <> 0 Then
                Return dal.SQLDataset01.Tables(0).Rows(0).Item(0)
            Else
                Dim dal2 As New DALControl
                Dim query2 = "SELECT MM_TEXT FROM SFM_RCH.PROD_ORDER_COMP_PICKING WHERE MM = '" & PN & "'"
                dal2.RunQuery(query2)
                If dal2.SQLDataset01.Tables(0).Rows.Count <> 0 Then
                    Return dal2.SQLDataset01.Tables(0).Rows(0).Item(0)
                Else
                    Dim dal3 As New DALControl
                    Dim query3 = "SELECT MM_DESCR FROM SFM_RCH.PROD_ORDER_COMP_ARCHIVES WHERE MM = '" & PN & "'"
                    dal3.RunQuery(query3)
                    If dal3.SQLDataset01.Tables(0).Rows.Count <> 0 Then
                        Return dal3.SQLDataset01.Tables(0).Rows(0).Item(0)
                    Else
                        Dim dal4 As New DALControl
                        Dim query4 = "SELECT MM_DESCR FROM SFM_RCH.PROD_ORDER_COMP_T_BU WHERE MM = '" & PN & "'"
                        dal4.RunQuery(query4)
                        If dal4.SQLDataset01.Tables(0).Rows.Count <> 0 Then
                            Return dal4.SQLDataset01.Tables(0).Rows(0).Item(0)
                        Else
                            Dim description = InputBox("Description not found in the database for part: " & PN & ". Please look it up on LS24 in SAP and provide a description")
                            If description IsNot Nothing Then
                                Return description
                            Else
                                Return "Unknown description"
                            End If
                        End If
                    End If
                End If
            End If
        Catch ex As Exception
            Dim description = InputBox("Description not found in the database for part: " & PN & ". Please look it up on LS24 in SAP and provide a description")
            If description IsNot Nothing Then
                Return description
            Else
                Return "Unknown description"
            End If
        End Try
    End Function
End Module
