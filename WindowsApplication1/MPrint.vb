Imports System.Data.OleDb

Module MPrint
    Public dt_print As New DataTable
    Dim con As New OleDbConnection("provider=Microsoft.ACE.oledb.12.0; data source= radwan.accdb;")
    Public Sub print_sale(ByVal ID As Integer)
        Dim cmd As New OleDbCommand("select * from SQL1 where ID =@id", con)
        cmd.Parameters.Add(New OleDbParameter("@id", OleDbType.Integer)).Value = ID
        con.Open()
        dt_print.Load(cmd.ExecuteReader)
        con.Close()

    End Sub
End Module
