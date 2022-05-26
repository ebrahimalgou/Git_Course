
Imports System.Data.OleDb
Public Class frm_Use

    Dim con As New OleDbConnection("provider=Microsoft.ACE.oledb.12.0; data source= radwan.accdb;")
    Dim cmd As New OleDbCommand
    Dim adapter As OleDbDataAdapter
    Dim dtUse As New DataTable
    Sub FilDGV()

        dtUse.Rows.Clear()
        adapter = New OleDbDataAdapter("select * from Users", con)
        adapter.Fill(dtUse)
        DGVUse.DataSource = dtUse

        DGVUse.Columns(0).HeaderText = "اسم المستخدم"
        DGVUse.Columns(1).HeaderText = "كلمة المرور"
        DGVUse.Columns(2).HeaderText = "الصفه"
    End Sub

    Private Sub frm_Use_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FilDGV()
    End Sub

    Private Sub btnADD_Click(sender As Object, e As EventArgs) Handles btnADD.Click
        Dim frm As New frm_ADD_Use

        frm.Text = "اضافة حساب جديد"
        frm.btnSave.Text = "حفظ"
        frm.state = "Add"
        frm.ShowDialog()
        FilDGV()
        frm.txtName.Focus()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim frm As New frm_ADD_Use

        frm.Text = "تعديل حساب :" & DGVUse.CurrentRow.Cells(0).Value
        frm.txtName.Text = DGVUse.CurrentRow.Cells(0).Value
        frm.txtPass.Text = DGVUse.CurrentRow.Cells(1).Value
        frm.Cval.Text = DGVUse.CurrentRow.Cells(2).Value
        frm.NameUse = DGVUse.CurrentRow.Cells(0).Value.ToString
        frm.state = "Edit"

        frm.btnSave.Text = "تعديل"

        frm.ShowDialog()
        FilDGV()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim d As MsgBoxResult
            d = MessageBox.Show("هل تريد حذف الحساب الحالي؟", "delete  record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If d = vbYes Then

                cmd = New OleDbCommand("Delete from Users where NameUse ='" & DGVUse.CurrentRow.Cells(0).Value & "'", con)
                con.Open()
                cmd.ExecuteNonQuery()
                MsgBox("تمت حذف الحساب", MsgBoxStyle.Information, "ادارة الحسابات")
            End If
            FilDGV()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
End Class


