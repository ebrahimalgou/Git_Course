Imports System.Data.OleDb
Public Class FRM_MANAGE_COUSTEMR


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
        dgvCostemrs.Columns(1).HeaderText = "اسم العميل"
        dgvCostemrs.Columns(2).HeaderText = "رقم الهاتف"
        dgvCostemrs.Columns(3).HeaderText = "رصيد الحساب"
    End Sub

    Private Sub FRM_MANAGE_COUSTEMR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FilDGV()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try
            cmdb = New OleDbCommandBuilder(adapter)
            adapter.Update(dtCostemrs)
            MsgBox("تم حفظ التعديلات", MsgBoxStyle.Information, "ادارة العملاء")
            FilDGV()
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

   
End Class