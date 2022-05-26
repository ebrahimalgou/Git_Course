Imports System.Data.OleDb

Public Class filterF
    Dim con As New OleDbConnection("provider=Microsoft.ACE.oledb.12.0; data source= radwan.accdb;")
    Dim cmdb As New OleDbCommandBuilder
    Dim adapter As OleDbDataAdapter
    Dim dtday As New DataTable

    Sub fill_Sals()
        Salsman.Items.Clear()
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter("select * from Users", con)
        da.Fill(dt)

        Salsman.Items.Add("كل البائعين")
        Salsman.SelectedIndex = 0
        For i = 0 To dt.Rows.Count - 1
            Salsman.Items.Add(dt.Rows(i).Item("NameUse"))
        Next
    End Sub

    Sub FilDGV(sql)
        dtday.Rows.Clear()
        adapter = New OleDbDataAdapter(sql, con)
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
    Private Sub filterF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FilDGV("select ID,OrderDate, Salesman , total , dd , bb from SQL1 ")
        fill_Sals()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (Salsman.SelectedIndex = 0) Then
            FilDGV("select ID,OrderDate, Salesman , total , dd , bb from SQL1 where OrderDate BETWEEN '" & ofDate.Value & "' AND '" & toDate.Value & "'")
        Else
            FilDGV("select ID,OrderDate, Salesman , total , dd , bb from SQL1 where Salesman='" & Salsman.SelectedItem & "' AND OrderDate BETWEEN '" & ofDate.Value & "' AND '" & toDate.Value & "'")
        End If
    End Sub
End Class