Imports System.Data.OleDb

Module Module1
    Dim con As New OleDbConnection("provider=Microsoft.ACE.oledb.12.0; data source= radwan.accdb;")
    Public Function code_gen(tbl_name, id_) As Integer

        code_gen = 0

        Dim dt As New DataTable
        Dim da As New OleDb.OleDbDataAdapter("select * from " & tbl_name & " order by " & id_ & " ", con)
        da.Fill(dt)
        If dt.Rows.Count <> 0 Then
            Dim i = dt.Rows.Count - 1
            code_gen = Val(dt.Rows(i).Item(id_))
        End If
    End Function

    Public Sub fill_dgv(dgv As DataGridView, sql As String)
        dgv.DataSource = ""
        Dim dt As New DataTable
        Dim da As New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(dt)
        dgv.AutoGenerateColumns = False
        dgv.DataSource = dt.DefaultView
    End Sub
End Module
