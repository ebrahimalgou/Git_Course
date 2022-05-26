Imports System.Data.OleDb
Public Class FRM_COSTEMRS_LIST

    Dim con As New OleDbConnection("provider=Microsoft.ACE.oledb.12.0; data source= radwan.accdb;")
    Dim cmdb As New OleDbCommandBuilder
    Dim adapter As OleDbDataAdapter
    Dim dtCostemrs As New DataTable
    Sub FilDGV()
        dtCostemrs.Rows.Clear()
        adapter = New OleDbDataAdapter("select * from Customers", con)
        adapter.Fill(dtCostemrs)
        dgvCostemrs.DataSource = dtCostemrs
        dgvCostemrs.Columns(0).Visible = False
        
    End Sub
    Private Sub FRM_COSTEMRS_LIST_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FilDGV()
    End Sub

    Private Sub dgvCostemrs_DoubleClick(sender As Object, e As EventArgs) Handles dgvCostemrs.DoubleClick
        Me.Close()
    End Sub

   
    Private Sub dgvCostemrs_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCostemrs.CellContentClick

    End Sub
End Class