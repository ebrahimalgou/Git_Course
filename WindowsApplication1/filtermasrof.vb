Imports System.Data.OleDb

Public Class filtermasrof
    Dim con As New OleDbConnection("provider=Microsoft.ACE.oledb.12.0; data source= radwan.accdb;")
    Dim cmdb As New OleDbCommandBuilder
    Dim adapter As OleDbDataAdapter
    Dim dtCostemrs As New DataTable
    Sub FilDGV()

        dtCostemrs.Rows.Clear()
        adapter = New OleDbDataAdapter("select * from msrof", con)
        adapter.Fill(dtCostemrs)
        dgvCostemrs.DataSource = dtCostemrs
        dgvCostemrs.Columns(0).Visible = False
        dgvCostemrs.Columns(1).HeaderText = "اسم البائع"
        dgvCostemrs.Columns(2).HeaderText = "التاريخ"
        dgvCostemrs.Columns(3).HeaderText = "ملاحظات"
        dgvCostemrs.Columns(4).HeaderText = "المبلغ"

    End Sub
    Private Sub filtermasrof_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FilDGV()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs)
        Try
            cmdb = New OleDbCommandBuilder(adapter)
            adapter.Update(dtCostemrs)
            MsgBox("تم حفظ التعديلات", MsgBoxStyle.Information, "ادارة المصروفات")
            FilDGV()
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

   
End Class