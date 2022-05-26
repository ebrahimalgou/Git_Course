Imports System.Data.OleDb


Public Class FRM_Pay
    Dim con As New OleDbConnection("provider=Microsoft.ACE.oledb.12.0; data source= radwan.accdb;")
    Dim cmd As New OleDbCommand


    Sub show_deitales(id_)
        Try
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter("select * from importers where imp_code = '" & id_ & "'  ", con)
            da.Fill(dt)

            If dt.Rows.Count = 0 Then
                MessageBox.Show("المورد غير موجود يرجى التأكد", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                Dim show_ As Integer = BindingContext(dt).Position
                txt_code.Text = dt.Rows(show_).Item("imp_code")
                txt_name.Text = dt.Rows(show_).Item("imp_name")
                txt_phone.Text = dt.Rows(show_).Item("imp_phone")
                txt_address.Text = dt.Rows(show_).Item("imp_address")
                txt_note.Text = dt.Rows(show_).Item("notes")
                txt_debit.Text = dt.Rows(show_).Item("debit")
                txt_credit.Text = dt.Rows(show_).Item("credit")
                txt_company.Text = dt.Rows(show_).Item("company")
                btn_edit.Enabled = True
                btn_delete.Enabled = True
                btn_save.Enabled = False
            End If
        Catch ex As Exception


        End Try
    End Sub

    Sub clc()
        '===========تنظيف مربع النص 
        For i = 0 To GroupBox1.Controls.Count - 1
            If TypeOf GroupBox1.Controls(i) Is TextBox Then
                GroupBox1.Controls(i).Text = ""
            End If
        Next
        For i = 0 To GroupBox1.Controls.Count - 1
            If TypeOf GroupBox1.Controls(i) Is TextBox Then
                GroupBox1.Controls(i).Text = ""
            End If
        Next
        '========ترقيم تلقائي
        txt_code.Text = code_gen("importers", "id") + 1

        txt_name.Select()
        txt_address.Focus()
        txt_note.Clear()
        btn_edit.Enabled = False
        btn_delete.Enabled = False
        txt_credit.Text = "0.00"
        txt_debit.Text = "0.00"
        txt_diff.Text = "0.00"
    End Sub








    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        clc()

    End Sub

    Private Sub FRM_Pay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clc()
    End Sub



    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        '=========قيود الأدخال=======
        If txt_name.Text = "" Then
            MessageBox.Show("يرجى ادخال اسم المورد", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_name.Select()
            Exit Sub
        End If
        If txt_phone.Text = "" Then
            MessageBox.Show("يرجى ادخال رقم المورد", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_phone.Select()
            Exit Sub
        End If

        '=============كود الحفظ==============
        Dim dt As New DataTable
        Dim da As New OleDb.OleDbDataAdapter("select * from importers where imp_name ='" & txt_name.Text & "' or imp_phone ='" & txt_phone.Text & "' ", con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            MessageBox.Show("هذا المورد موجود مسبقاً", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            dt.Rows.Add()
            Dim add_ As Integer = dt.Rows.Count - 1
            dt.Rows(add_).Item("imp_code") = txt_code.Text
            dt.Rows(add_).Item("imp_name") = txt_name.Text
            dt.Rows(add_).Item("imp_phone") = txt_phone.Text
            dt.Rows(add_).Item("imp_address") = txt_address.Text
            dt.Rows(add_).Item("notes") = txt_note.Text
            dt.Rows(add_).Item("company") = txt_company.Text
            dt.Rows(add_).Item("debit") = txt_debit.Text
            dt.Rows(add_).Item("credit") = txt_credit.Text
            dt.Rows(add_).Item("states") = True
            Dim save As New OleDb.OleDbCommandBuilder(da)
            da.Update(dt)
            dt.AcceptChanges()
            MessageBox.Show("تم حفظ المورد الجديد بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
            clc()

        End If
    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click
        '=========قيود الأدخال=======
        If txt_name.Text = "" Then
            MessageBox.Show("يرجى ادخال اسم المورد", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_name.Select()
            Exit Sub
        End If
        If txt_phone.Text = "" Then
            MessageBox.Show("يرجى ادخال رقم المورد", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txt_phone.Select()
            Exit Sub
        End If

        '=============كود التعديل==============
        Dim dt As New DataTable
        Dim da As New OleDb.OleDbDataAdapter("Select * from importers where [imp_name] ='" & txt_name.Text & "'", con)
        da.Fill(dt)
        If dt.Rows.Count = 0 Then
            MessageBox.Show("المورد غير موجود يرجى التأكد", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim update As Integer = BindingContext(dt).Position
            dt.Rows(update).Item("imp_code") = txt_code.Text
            dt.Rows(update).Item("imp_name") = txt_name.Text
            dt.Rows(update).Item("imp_phone") = txt_phone.Text
            dt.Rows(update).Item("imp_address") = txt_address.Text
            dt.Rows(update).Item("notes") = txt_note.Text
            dt.Rows(update).Item("company") = txt_company.Text
            dt.Rows(update).Item("debit") = txt_debit.Text
            dt.Rows(update).Item("credit") = txt_credit.Text
            dt.Rows(update).Item("states") = True
            Dim save As New OleDb.OleDbCommandBuilder(da)
            da.Update(dt)
            dt.AcceptChanges()
            MessageBox.Show("تم تعديل بيانات المورد بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
            clc()

        End If

       
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        If MessageBox.Show("هل ترغب في حذف بيانات هذا المورد", "رسالة تنبيه", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.No Then Exit Sub
        '=============كود الحذف==============
        Dim dt As New DataTable
        Dim da As New OleDb.OleDbDataAdapter("select * from importers where imp_name ='" & txt_name.Text & "' ", con)
        da.Fill(dt)
        If dt.Rows.Count = 0 Then
            MessageBox.Show("المورد غير موجود يرجى التأكد", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            Dim cmd As New OleDb.OleDbCommand("update importers set states=@state where imp_name='" & txt_name.Text & "' ", con)
            cmd.Parameters.Add("@state", OleDb.OleDbType.Boolean).Value = False
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()
           
            MessageBox.Show("تمت عملية حذف بيانات المورد بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
            
            clc()

        End If
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click

        Dim frm As New FrmSearch

        frm.ShowDialog()
        txt_code.Text = frm.DataGridView1.CurrentRow.Cells(0).Value
        txt_name.Text = frm.DataGridView1.CurrentRow.Cells(1).Value
        txt_phone.Text = frm.DataGridView1.CurrentRow.Cells(4).Value
        txt_address.Text = frm.DataGridView1.CurrentRow.Cells(3).Value
        txt_note.Text = frm.DataGridView1.CurrentRow.Cells(2).Value()
        txt_company.Text = frm.DataGridView1.CurrentRow.Cells(5).Value()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

   
  
   
End Class