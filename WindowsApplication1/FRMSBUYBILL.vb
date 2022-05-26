Imports System.Data.OleDb

Public Class FRMSBUYBILL

    Dim con As New OleDbConnection("provider=Microsoft.ACE.oledb.12.0; data source= radwan.accdb;")

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If ComboBox1.SelectedIndex = 0 Then
            Dim DT As New DataTable
            Dim DA As New OleDb.OleDbDataAdapter
            DT.Clear()
            DA = New OleDb.OleDbDataAdapter("SELECT * FROM BUYBILL WHERE  STATE = TRUE AND BUYCODE = '" & TextBox1.Text & "'", con)
            DA.Fill(DT)
            DataGridView1.DataSource = DT.DefaultView
        End If
        If ComboBox1.SelectedIndex = 1 Then
            Dim DT As New DataTable
            Dim DA As New OleDb.OleDbDataAdapter
            DT.Clear()
            DA = New OleDb.OleDbDataAdapter("SELECT * FROM BUYBILL WHERE  STATE = TRUE AND  IMPORTERNAME Like '%" & TextBox1.Text & "%'", con)
            DA.Fill(DT)
            DataGridView1.DataSource = DT.DefaultView
        End If
    End Sub

    Private Sub FRMSBUYBILL_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fill_dgv(DataGridView1, "SELECT * FROM BUYBILL")
        

    End Sub

    'Private Sub DataGridView1_Click(sender As Object, e As EventArgs) Handles DataGridView1.Click
    '    If DataGridView1(0, DataGridView1.CurrentRow.Index).Selected = True Then
    '        FRMPor.SHOW_DETAILES(DataGridView1.CurrentRow.Cells(1).Value)
    '        Me.Close()
    '    End If
    'End Sub
    'Private Sub DataGridView1_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles DataGridView1.RowsAdded
    '    For I As Integer = 0 To DataGridView1.Rows.Count - 1
    '        DataGridView1.Rows(I).Cells(0).Value = "عرض"
    '        Dim ROW As DataGridViewRow = DataGridView1.Rows(I)
    '    Next
    'End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        Me.Close()
    End Sub
End Class
