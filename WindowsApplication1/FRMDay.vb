Imports System.Data.OleDb

Public Class FRMDay
    Dim con As New OleDbConnection("provider=Microsoft.ACE.oledb.12.0; data source= radwan.accdb;")
    Dim cmdb As New OleDbCommandBuilder
    Dim adapter As OleDbDataAdapter
    Dim dtday As New DataTable
    Sub FilDGV()
        dtday.Rows.Clear()
        adapter = New OleDbDataAdapter("select ID,OrderDate, Salesman , total , dd , bb from SQL1 where Day(OrderDate)=" & Now.Day & "", con)
        adapter.Fill(dtday)
        dgvday.DataSource = dtday
        Dim tot As Double = 0
        Dim dd As Double = 0
        Dim bb As Double = 0
        For i As Integer = 0 To dgvday.Rows.Count - 1
            tot = tot + dgvday.Rows(i).Cells(3).Value
            dd = dd + dgvday.Rows(i).Cells(4).Value
            bb = bb + dgvday.Rows(i).Cells(5).Value
        Next
        txttotal.Text = tot
        txtbb.Text = bb
        txtdd.Text = dd
    End Sub
   
    Private Sub FRMDay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FilDGV()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class