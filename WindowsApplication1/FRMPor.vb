Imports System.Data.OleDb

Public Class FRMPor
    Dim con As New OleDbConnection("provider=Microsoft.ACE.oledb.12.0; data source= radwan.accdb;")
    Dim ARABIC As New ClassConvertNo
    Sub fill_Importer()
        IMPORTERNAME.Items.Clear()
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter("select * from importers", con)
        da.Fill(dt)
        For i = 0 To dt.Rows.Count - 1
            IMPORTERNAME.Items.Add(dt.Rows(i).Item("imp_name"))
        Next
    End Sub

    Sub SHOW_DETAILES(CODE_)
        dgvProduct.Rows.Clear()
        '=========== ربط رأس الفاتورة =============
        Dim DT As New DataTable
        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM BUYBILL WHERE BUYCODE ='" & CODE_ & "'", con)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("يرجى التأكد من رقم الفاتورة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim DR = DT.Rows(0)
            BUYCODE.Text = DR!BUYCODE
            BUYTYPE.Text = DR!BUYTYPE
            IMPORTERNAME.Text = DR!IMPORTERNAME
            BUYDATE.Value = DR!BUYDATE
            BUYUSER.Text = DR!BUYUSER
            NOTES.Text = DR!NOTES
            TOTAL.Text = DR!TOTAL
            DISCOUND.Text = DR!DISCOUND
            TOTALQTY.Text = DR!TOTALQTY
            TOTALARABIC.Text = DR!TOTALARABIC
            Dim DS As New DataSet
            '=========== ربط تفاصيل الفاتورة =============
            DA = New OleDb.OleDbDataAdapter("SELECT * FROM BUY_DET WHERE BUYCODE = '" & CODE_ & "'", con)
            DS = New DataSet
            DA.Fill(DS)
            DT = DS.Tables(0)
            For I = 0 To DT.Rows.Count - 1
                dgvProduct.Rows.Add()
                dgvProduct.Rows(I).Cells(0).Value = DT.Rows(I).Item("ITEMCODE")
                dgvProduct.Rows(I).Cells(1).Value = DT.Rows(I).Item("ITEMNAME")
                dgvProduct.Rows(I).Cells(2).Value = DT.Rows(I).Item("PRICE")
                dgvProduct.Rows(I).Cells(3).Value = DT.Rows(I).Item("QTY")
                dgvProduct.Rows(I).Cells(4).Value = DT.Rows(I).Item("DISCOUND")
                dgvProduct.Rows(I).Cells(5).Value = DT.Rows(I).Item("TOTAL")
                dgvProduct.Rows(I).Cells(6).Value = DT.Rows(I).Item("QTY_IN")

            Next

            btndel.Enabled = True
            BTNEDIT.Enabled = True
            BTNSAVE.Enabled = False


        End If


    End Sub


    Sub calc()
        For i = 0 To dgvProduct.Rows.Count - 1
            dgvProduct.Rows(i).Cells(5).Value = Val(dgvProduct.Rows(i).Cells(2).Value) * Val(dgvProduct.Rows(i).Cells(3).Value)

        Next
        Dim TOTAL_, DISCOUND_, QTY As Double
        For i = 0 To dgvProduct.Rows.Count - 1
            TOTAL_ = Val(TOTAL_) + Val(dgvProduct.Rows(i).Cells(5).Value)
            DISCOUND_ = Val(DISCOUND_) + Val(dgvProduct.Rows(i).Cells(4).Value)
            QTY = Val(QTY) + Val(dgvProduct.Rows(i).Cells(3).Value)
            TOTAL.Text = Val(TOTAL_) - Val(DISCOUND_)
            DISCOUND.Text = Val(DISCOUND_)
            TOTALQTY.Text = Val(QTY)
            If Val(TOTAL.Text) > 0 Then
                TOTALARABIC.Text = ARABIC.ConvertToArabic(TOTAL.Text)
            Else

                TOTALARABIC.Text = ""

            End If

        Next
    End Sub

    Sub clc()
        '===========تنظيف مربع النص 
        For i = 0 To GroupBox1.Controls.Count - 1
            If TypeOf GroupBox1.Controls(i) Is TextBox Then
                GroupBox1.Controls(i).Text = ""

            End If
            If TypeOf GroupBox1.Controls(i) Is DateTimePicker Then
                GroupBox1.Controls(i).Text = Date.Now
            End If

        Next
        
        TOTAL.Text = ""
        TOTALARABIC.Text = ""
        TOTALQTY.Text = ""
        DISCOUND.Text = ""
        BUYCODE.Text = code_gen("BUYBILL", "ID") + 1
        BUYTYPE.SelectedIndex = 1
        dgvProduct.Rows.Clear()
        btndel.Enabled = False
        btnedit.Enabled = False
        btnsave.Enabled = True
        IMPORTERNAME.Text = ""
        TXT_BARCODE.Select()
        TXT_BARCODE.Text = ""
        fill_Importer()
        Label4.Visible = True


    End Sub

    Private Sub FRMPor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clc()

    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        clc()

    End Sub


    
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        '============قيود الادخال =============
        If IMPORTERNAME.SelectedIndex < 0 Then
            MessageBox.Show("يرجي ادخال اسم المورد", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            IMPORTERNAME.Select()
            Exit Sub
        End If
        If BUYTYPE.SelectedIndex < 0 Then
            MessageBox.Show("يرجي اختيار نوع الفتورة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            BUYTYPE.Select()
            Exit Sub
        End If
        If dgvProduct.Rows.Count = 0 Then
            MessageBox.Show("لاتوجد اصناف لحفظها", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        '=====================حفظ راس الفتورة===================
        Dim dt As New DataTable
        Dim da As New OleDbDataAdapter("select * from BUYBILL where BUYCODE='" & BUYCODE.Text & "'", con)
        da.Fill(dt)
        If dt.Rows.Count > 0 Then
            BUYCODE.Text = code_gen("BUYBILL", "ID") + 1
        Else
            Dim dr = dt.NewRow
            dr!BUYCODE = BUYCODE.Text
            dr!BUYTYPE = BUYTYPE.Text
            dr!IMPORTERNAME = IMPORTERNAME.Text
            dr!NOTES = NOTES.Text
            dr!BUYDATE = BUYDATE.Text
            dr!TOTAL = Convert.ToDecimal(TOTAL.Text)
            dr!DISCOUND = Convert.ToDecimal(DISCOUND.Text)
            dr!TOTALARABIC = TOTALARABIC.Text
            dr!TOTALQTY = Val(TOTALQTY.Text)
            dr!BUYUSER = BUYUSER.Text
            dr!State = True
            dt.Rows.Add(dr)
            Dim save As New OleDbCommandBuilder(da)
            da.Update(dt)

            '======= حفظ تفاصيل الفاتورة ===============

            da = New OleDb.OleDbDataAdapter("SELECT * FROM BUY_DET", con)
            da.Fill(dt)
            For I = 0 To dgvProduct.Rows.Count - 1
                Dim DR1 = dt.NewRow
                DR1!BUYCODE = BUYCODE.Text
                DR1!ITEMCODE = dgvProduct.Rows(I).Cells(0).Value
                DR1!ITEMNAME = dgvProduct.Rows(I).Cells(1).Value

                DR1!QTY = dgvProduct.Rows(I).Cells(3).Value
                DR1!PRICE = Convert.ToDecimal(dgvProduct.Rows(I).Cells(2).Value)
                DR1!DISCOUND = Val(dgvProduct.Rows(I).Cells(4).Value)
                DR1!TOTAL = dgvProduct.Rows(I).Cells(5).Value
                DR1!QTY_IN = dgvProduct.Rows(I).Cells(6).Value

                dt.Rows.Add(DR1)
                Dim CMD_ As New OleDb.OleDbCommandBuilder(da)
                da.Update(dt)
            Next
            '==============حساب المتوسط=================
            For M As Integer = 0 To dgvProduct.Rows.Count - 1
                Dim Price, Pricen, Pricem As Double
                Dim QTYs As Integer

                Price = Val(dgvProduct.Rows(M).Cells(6).Value) * Val(dgvProduct.Rows(M).Cells(7).Value)
                Pricen = Val(dgvProduct.Rows(M).Cells(3).Value) * Val(dgvProduct.Rows(M).Cells(2).Value)
                QTYs = Val(dgvProduct.Rows(M).Cells(3).Value) + Val(dgvProduct.Rows(M).Cells(6).Value)
                Pricem = (Price + Pricen) / QTYs
                Dim CMD_1 As New OleDb.OleDbCommand
                CMD_1.Connection = con
                CMD_1.CommandText = " UPDATE  Product SET Price_m = " & Pricem & "  WHERE NameProduct = '" & dgvProduct.Rows(M).Cells(1).Value & "'"
                con.Open()

                CMD_1.ExecuteNonQuery()

                con.Close()

            Next


            '=========== اضافة الكمية ==============================
            For M As Integer = 0 To dgvProduct.Rows.Count - 1
                Dim NEW_QTY As Integer
                NEW_QTY = Val(dgvProduct.Rows(M).Cells(3).Value) + Val(dgvProduct.Rows(M).Cells(6).Value)
                Dim CMD_1 As New OleDb.OleDbCommand
                CMD_1.Connection = con
                CMD_1.CommandText = " UPDATE  Product SET Qty = " & NEW_QTY & "  WHERE NameProduct = '" & dgvProduct.Rows(M).Cells(1).Value & "'"
                con.Open()
               
                CMD_1.ExecuteNonQuery()

                con.Close()

            Next

            MessageBox.Show("تمت عملية حفظ المشتريات بنجاح", "رسالة تاكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub
    Private Sub TXT_BARCODE_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_BARCODE.KeyDown
        If e.KeyCode = Keys.Enter Then
            TXT_BARCODE_Leave(sender, e)
        End If
    End Sub

    Private Sub TXT_BARCODE_Leave(sender As Object, e As EventArgs) Handles TXT_BARCODE.Leave
        'طريقة الادخال بالباركود
        Dim BAR_ As Integer
        If TXT_BARCODE.Text <> Nothing Then
            Dim dt As New DataTable
            Dim da As New OleDb.OleDbDataAdapter("SELECT * FROM [Product]  WHERE [Code] LIKE'" & TXT_BARCODE.Text & "'", con)
            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                For i = 0 To dgvProduct.Rows.Count - 1
                    If dgvProduct.Rows(i).Cells(0).Value = dt.Rows(0).Item("Code") Then
                        dgvProduct.Rows(i).Cells(3).Value = dgvProduct.Rows(i).Cells(3).Value + 1
                        calc()
                        TXT_BARCODE.Clear()
                        Exit Sub

                    End If
                Next
                '==========اضافة سجل للداتا جرد فيو

                dgvProduct.Rows.Add()
                BAR_ = dgvProduct.Rows.Count - 1
                dgvProduct(0, BAR_).Value = dt.Rows(0).Item("Code")
                dgvProduct(1, BAR_).Value = dt.Rows(0).Item("NameProduct")
                dgvProduct(6, BAR_).Value = dt.Rows(0).Item("Qty")
                dgvProduct(2, BAR_).Value = dt.Rows(0).Item("Price")
                dgvProduct(3, BAR_).Value = 1
                dgvProduct(7, BAR_).Value = dt.Rows(0).Item("Price_m")
                calc()

            End If
        End If
        TXT_BARCODE.Clear()
        calc()
    End Sub
    
    

    Private Sub dgvProduct_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProduct.CellEndEdit
        calc()
    End Sub

    Private Sub dgvProduct_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProduct.CellContentClick
        calc()
    End Sub

   
    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        '========قيود الادخال 
        If IMPORTERNAME.SelectedIndex < 0 Then
            MessageBox.Show("يرجى إدخال اسم المورد", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            IMPORTERNAME.Select()
            Exit Sub
        End If
        If BUYTYPE.SelectedIndex < 0 Then
            MessageBox.Show("يرجى إدخال نوع الفاتورة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            BUYTYPE.Select()
            Exit Sub
        End If
        If dgvProduct.Rows.Count = 0 Then
            MessageBox.Show("لا توجد أصناف لحفظها", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        For I As Integer = 0 To dgvProduct.Rows.Count - 1
            If dgvProduct.Rows(I).Cells(3).Value = 0 Then
                MessageBox.Show("يرجى التحقق من الكميات", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub

            End If
        Next

        '=======================تعديل رأس الفاتورة ===================
        If MessageBox.Show("هل ترغب في تعديل فاتورة المشتريات ؟", "رسالة تنبيه", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = Windows.Forms.DialogResult.No Then Exit Sub

        Dim DT As New DataTable
        Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM BUYBILL where BUYCODE ='" & BUYCODE.Text & "'", con)
        DA.Fill(DT)
        If DT.Rows.Count = 0 Then
            MessageBox.Show("يرجى التحقق من رقم الفاتورة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Dim DR = DT.Rows(0)
            DR!BUYCODE = BUYCODE.Text
            DR!BUYTYPE = BUYTYPE.Text
            DR!BUYDATE = BUYDATE.Value
            DR!IMPORTERNAME = IMPORTERNAME.Text
            DR!BUYUSER = BUYUSER.Text
            DR!NOTES = NOTES.Text
            DR!DISCOUND = Convert.ToDouble(DISCOUND.Text)
            DR!TOTAL = Convert.ToDouble(TOTAL.Text)
            DR!TOTALARABIC = TOTALARABIC.Text
            DR!TOTALQTY = Val(TOTALQTY.Text)
            DR!STATE = True

            Dim SAVE As New OleDb.OleDbCommandBuilder(DA)
            DA.Update(DT)
        End If
        '================ حذف تفاصيل الفاتورة أولاً ثم إضافتها ==========
        Dim CMD_DEL As New OleDb.OleDbCommand
        CMD_DEL.Connection = con
        CMD_DEL.CommandText = "DELETE FROM BUY_DET WHERE BUYCODE ='" & BUYCODE.Text & "'"
        con.Open()
        CMD_DEL.ExecuteNonQuery()
        con.Close()
        '======================================================================
        '======= تعديل تفاصيل الفاتورة ===============

        DA = New OleDb.OleDbDataAdapter("SELECT * FROM BUY_DET", con)
        DA.Fill(DT)
        For I = 0 To dgvProduct.Rows.Count - 1
            Dim DR1 = DT.NewRow
            DR1!BUYCODE = BUYCODE.Text
            DR1!ITEMCODE = dgvProduct.Rows(I).Cells(0).Value
            DR1!ITEMNAME = dgvProduct.Rows(I).Cells(1).Value
            DR1!QTY = dgvProduct.Rows(I).Cells(3).Value
            DR1!PRICE = Val(dgvProduct.Rows(I).Cells(2).Value)
            DR1!DISCOUND = Val(dgvProduct.Rows(I).Cells(4).Value)
            DR1!TOTAL = dgvProduct.Rows(I).Cells(5).Value
            DR1!QTY_IN = dgvProduct.Rows(I).Cells(6).Value
            DT.Rows.Add(DR1)
            Dim CMD_ As New OleDb.OleDbCommandBuilder(DA)
            DA.Update(DT)
        Next

        '=========== اضافة الكمية ==============================
        For M As Integer = 0 To dgvProduct.Rows.Count - 1
            Dim NEW_QTY As Integer
            NEW_QTY = Val(dgvProduct.Rows(M).Cells(3).Value) + Val(dgvProduct.Rows(M).Cells(6).Value)
            Dim CMD_1 As New OleDb.OleDbCommand
            CMD_1.Connection = con
            CMD_1.CommandText = " UPDATE  Product SET QTY = " & NEW_QTY & "  WHERE NameProduct = '" & dgvProduct.Rows(M).Cells(1).Value & "'"
            con.Open()
            CMD_1.ExecuteNonQuery()

            con.Close()

        Next
        MessageBox.Show("تمت عملية تعديل فاتورة المشتريات بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
        clc()
    End Sub

    Private Sub btnsch_Click(sender As Object, e As EventArgs) Handles btnsch.Click

        Dim frm As New FRMSBUYBILL

        frm.ShowDialog()
        SHOW_DETAILES(frm.DataGridView1.CurrentRow.Cells(0).Value)

    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()



    End Sub

    Private Sub btndel_Click(sender As Object, e As EventArgs) Handles btndel.Click
        Dim MSG_ = MessageBox.Show("هل ترغب في حذف الفاتورة نهائيا أو نقلها للأرشيف ؟", "رسالة تنبيه", MessageBoxButtons.YesNoCancel)
        '=========== حذف الفاتورة نهائياً =====================
        If MSG_ = Windows.Forms.DialogResult.Yes Then
            Dim DT As New DataTable
            Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM BUYBILL WHERE BUYCODE = '" & BUYCODE.Text & "'", con)
            DA.Fill(DT)
            If DT.Rows.Count = 0 Then
                MessageBox.Show("يرجى التحقق من رقم الفاتورة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim DR = DT.Rows(0)
                DR.Delete()
                Dim SAVE As New OleDb.OleDbCommandBuilder(DA)
                DA.Update(DT)
                '=========== اضافة الكمية ==============================
                For M As Integer = 0 To dgvProduct.Rows.Count - 1
                    Dim NEW_QTY As Integer
                    NEW_QTY = Val(dgvProduct.Rows(M).Cells(3).Value) - Val(dgvProduct.Rows(M).Cells(6).Value)
                    Dim CMD_1 As New OleDb.OleDbCommand
                    CMD_1.Connection = con
                    CMD_1.CommandText = " UPDATE  Product SET QTY = " & NEW_QTY & "  WHERE NameProduct = '" & dgvProduct.Rows(M).Cells(1).Value & "'"
                    con.Open()
                   
                    CMD_1.ExecuteNonQuery()

                    con.Close()


                Next

                MessageBox.Show("تمت عملية حذف فاتورة المشتريات بنجاح", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
                clc()

            End If

            '============= نقل الفاتورة للأرشيف ==================
        ElseIf MSG_ = Windows.Forms.DialogResult.No Then
            Dim DT As New DataTable
            Dim DA As New OleDb.OleDbDataAdapter("SELECT * FROM BUYBILL WHERE BUYCODE = '" & BUYCODE.Text & "'", con)
            DA.Fill(DT)
            If DT.Rows.Count = 0 Then
                MessageBox.Show("يرجى التحقق من رقم الفاتورة", "رسالة تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Dim DR = DT.Rows(0)
                DR!STATE = False
                Dim SAVE As New OleDb.OleDbCommandBuilder(DA)
                DA.Update(DT)

                '=========== اضافة الكمية ==============================
                For M As Integer = 0 To dgvProduct.Rows.Count - 1
                    Dim NEW_QTY As Integer
                    NEW_QTY = Val(dgvProduct.Rows(M).Cells(3).Value) - Val(dgvProduct.Rows(M).Cells(6).Value)
                    Dim CMD_1 As New OleDb.OleDbCommand
                    CMD_1.Connection = con
                    CMD_1.CommandText = " UPDATE  Product SET qty = " & NEW_QTY & "  WHERE NameProduct = '" & dgvProduct.Rows(M).Cells(1).Value & "'"
                    con.Open()

                    CMD_1.ExecuteNonQuery()

                    con.Close()


                Next
                MessageBox.Show("تمت نقل  فاتورة المشتريات إلى الأرشيف", "رسالة تأكيد", MessageBoxButtons.OK, MessageBoxIcon.Information)
                clc()
            End If


        End If
    End Sub

    
End Class