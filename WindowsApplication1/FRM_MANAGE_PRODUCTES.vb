Imports System.Data.OleDb
Public Class FRM_MANAGE_PRODUCTES
    Dim con As New OleDbConnection("provider=Microsoft.ACE.oledb.12.0; data source= radwan.accdb;")
    Dim cmd As New OleDbCommand
    Dim adapter As OleDbDataAdapter
    Dim dtProduct As New DataTable
    Dim dtP As New DataTable

    Sub FilDGV()
        dtProduct.Rows.Clear()
        adapter = New OleDbDataAdapter("select * from Product", con)
        adapter.Fill(dtProduct)

        'dtProduct.Columns.Add("متوسط سعر الشراء", GetType(Double))


        'Dim adp As OleDbDataAdapter
        'For i As Integer = 0 To dtProduct.Rows.Count - 1
        '    adp = New OleDb.OleDbDataAdapter("SELECT (Sum(QTY*PRICE)\Sum(QTY)) AS Expr1 FROM BUY_DET WHERE (((BUY_DET.[ITEMCODE])='" & dtProduct(i)(0).ToString & "'))", con)
        '    adp.Fill(dtP)
        '    dtProduct(i)(4) = dtP(0)(0)
        '    dtP.Rows.Clear()


        'Next
        dgvProduct.DataSource = dtProduct

    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub FRM_MANAGE_PRODUCTES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FilDGV()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Try
            Dim dtResult As DataTable = dtProduct.Copy
            Dim dv As DataView = dtResult.DefaultView
            dv.RowFilter = "Code + [NameProduct] + Qty + Price like '%" & txtSearch.Text & "%'"
            Me.dgvProduct.DataSource = dv

        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btnADD_Click(sender As Object, e As EventArgs) Handles btnADD.Click

        Dim frm As New FrM_ADD_PRODUCTS

        frm.Text = "اضافة منتج جديد"
        frm.btnSave.Text = "حفظ"
        frm.state = "Add"
        frm.ShowDialog()
        FilDGV()
        frm.txtName.Focus()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

        Dim frm As New FrM_ADD_PRODUCTS

        frm.Text = "تعديل منتج :" & dgvProduct.CurrentRow.Cells(1).Value
        frm.txtName.Text = dgvProduct.CurrentRow.Cells(1).Value
        frm.txtQty.Text = dgvProduct.CurrentRow.Cells(2).Value
        frm.txtPrice.Text = dgvProduct.CurrentRow.Cells(3).Value
        frm.ID_Product = dgvProduct.CurrentRow.Cells(0).Value
        frm.state = "Edit"

        frm.btnSave.Text = "تعديل"

        frm.ShowDialog()
        FilDGV()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim d As MsgBoxResult
            d = MessageBox.Show("هل تريد حذف السجل الحالي؟", "delete  record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If d = vbYes Then

                cmd = New OleDbCommand("Delete from Product where Code =" & dgvProduct.CurrentRow.Cells(0).Value, con)
                con.Open()
                cmd.ExecuteNonQuery()
                MsgBox("تمت حذف المنتج", MsgBoxStyle.Information, "ادارة المنتجات")
            End If
            FilDGV()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCR.Click
        Dim f As New CRProduct
        Dim rpt As New CR_Product
        f.CrystalReportViewer1.ReportSource = rpt
        f.CrystalReportViewer1.RefreshReport()
        f.Show()
    End Sub

  
End Class