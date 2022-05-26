Imports System.Data.OleDb

Public Class FrmSearch

    Public con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=radwan.accdb")
    '=============   ==============
    Public Sub fill_dgv(sql As String)
        DataGridView1.DataSource = ""
        Dim dt As New DataTable
        Dim da As New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(dt)
        DataGridView1.AutoGenerateColumns = False
        DataGridView1.DataSource = dt.DefaultView
    End Sub
    Private Sub FrmSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fill_dgv("select * from importers where states = true order by imp_code")
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If RadioButton1.Checked = True Then
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter
            dt.Clear()
            da = New OleDb.OleDbDataAdapter("select * from importers where states = true and imp_name like '%" & TextBox1.Text & "%'", con)
            da.Fill(dt)
            DataGridView1.DataSource = dt.DefaultView
        End If

        If RadioButton2.Checked = True Then
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter
            dt.Clear()
            da = New OleDb.OleDbDataAdapter("select * from importers where states = true and imp_address like '%" & TextBox1.Text & "%'", con)
            da.Fill(dt)
            DataGridView1.DataSource = dt.DefaultView
        End If
    End Sub
   Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        Me.Close()
    End Sub
End Class