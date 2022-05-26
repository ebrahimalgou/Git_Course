Imports System.Data.OleDb

Public Class FRM_ORDERS

    Public state As String = "add"
    Public IDOrder As Integer
    Dim con As New OleDbConnection("provider=Microsoft.ACE.oledb.12.0; data source= radwan.accdb;")
    Dim cmd As New OleDbCommand
    Public dt As New DataTable
    Dim Qty_in As Integer = 0
    Dim denge As Decimal = 0.0


    Sub clcs()
        txtDes.Clear()
        txt_Date.Text = DateTime.Now
        BUYTYPE.SelectedIndex = 0
        txtCustId.Clear()
        txtFullName.Clear()
        txtTel.Clear()
        dt.Rows.Clear()
        txt_total.Clear()
        txt_b.Clear()
        txt_d.Clear()
        txtD.Text = 0
    End Sub
    Sub resizeDGV()
        dgvProduct.Columns(0).Width = 150
        dgvProduct.Columns(1).Width = 266
        dgvProduct.Columns(2).Width = 124
        dgvProduct.Columns(3).Width = 131
        dgvProduct.Columns(4).Width = 133
        dgvProduct.Columns(5).Visible = False
    End Sub
    Sub setDataSRC()
        dt.Columns.Add("الكود")
        dt.Columns.Add("اسم المنتج")
        dt.Columns.Add("الكمية")
        dt.Columns.Add("السعر")
        dt.Columns.Add("الاجمالي")
        dt.Columns.Add("كمية المنتج في المخزن")

        dgvProduct.DataSource = dt

    End Sub
    Sub clear()
        txtID.Clear()
        txtLabel.Clear()
        txtQty.Text = 1
        txtPrice.Clear()
        txtAmount.Clear()
        txtID.Focus()
    End Sub
    Sub calculAmount()
        txtAmount.Text = Val(txtQty.Text) * Val(txtPrice.Text)
    End Sub
    Dim tot1 As Double = 0
    Sub total()
        Dim tot As Double = 0

        For i As Integer = 0 To dgvProduct.Rows.Count - 1
            tot = tot + dgvProduct.Rows(i).Cells(4).Value
            tot1 = tot1 + dgvProduct.Rows(i).Cells(4).Value

        Next
        txt_total.Text = tot
    End Sub
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    Private Sub FRM_ORDERS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        clcs()


        If state = "add" Then
            setDataSRC()
        End If
        resizeDGV()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim frm As New FRM_COSTEMRS_LIST

        frm.ShowDialog()
        txtCustId.Text = frm.dgvCostemrs.CurrentRow.Cells(0).Value
        txtFullName.Text = frm.dgvCostemrs.CurrentRow.Cells(1).Value
        txtTel.Text = frm.dgvCostemrs.CurrentRow.Cells(2).Value
        denge = frm.dgvCostemrs.CurrentRow.Cells(3).Value


    End Sub
    Private Sub txtID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtID.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then
                cmd = New OleDbCommand("select NameProduct , Price, Qty from Product  where code =" & txtID.Text, con)
                con.Open()
                Dim dr As OleDb.OleDbDataReader = cmd.ExecuteReader
                dr.Read()
                If dr.HasRows Then
                    txtLabel.Text = dr(0)
                    txtPrice.Text = dr(1)
                    Qty_in = dr(2)

                    txtQty.Focus()
                Else
                    MsgBox("المنتج غير موجود", MsgBoxStyle.Exclamation, "تنبيه")
                    clear()

                End If
                dr.Close()
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            con.Close()
        End Try
    End Sub
    Private Sub txtPrice_TextChanged(sender As Object, e As EventArgs) Handles txtQty.TextChanged, txtPrice.TextChanged
        Try
            calculAmount()
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub btnRemov_Click(sender As Object, e As EventArgs) Handles btnRemov.Click
        Try
            dgvProduct.Rows.RemoveAt(dgvProduct.CurrentRow.Index)
            total()
        Catch ex As Exception
            Exit Sub

        End Try
    End Sub
    Private Sub btnRemovAll_Click(sender As Object, e As EventArgs) Handles btnRemovAll.Click
        dt.Rows.Clear()
        Me.dgvProduct.DataSource = dt
        total()
    End Sub
    Private Sub dgvProduct_DoubleClick(sender As Object, e As EventArgs) Handles dgvProduct.DoubleClick
        Try

            txtID.Text = Me.dgvProduct.CurrentRow.Cells(0).Value
            txtLabel.Text = Me.dgvProduct.CurrentRow.Cells(1).Value
            txtQty.Text = Me.dgvProduct.CurrentRow.Cells(2).Value
            txtPrice.Text = Me.dgvProduct.CurrentRow.Cells(3).Value
            txtAmount.Text = Me.dgvProduct.CurrentRow.Cells(4).Value
            dgvProduct.Rows.RemoveAt(dgvProduct.CurrentRow.Index)
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Private Sub txtQty_KeyDown(sender As Object, e As KeyEventArgs) Handles txtQty.KeyDown

        If e.KeyCode = Keys.Enter Then
            For i As Integer = 0 To dgvProduct.Rows.Count - 1
                If dgvProduct.Rows(i).Cells(0).Value = txtID.Text Then
                    MsgBox("هذا المنتج موجود مسبقا", MsgBoxStyle.Critical, "تنبية")
                    clear()
                    Exit Sub
                End If
            Next
            Dim row As DataRow = dt.NewRow
            row(0) = txtID.Text
            row(1) = txtLabel.Text
            row(2) = txtQty.Text
            row(3) = txtPrice.Text
            row(4) = txtAmount.Text
            row(5) = Qty_in

            dt.Rows.Add(row)
            Me.dgvProduct.DataSource = dt
            clear()
            Qty_in = 0

            total()


        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If state = "add" Then

            Dim strQury As String = "insert into  Orders (OrderDate, Salesman, Des, IDCustomres,total , dd,bb,dess,TypeOrder) values (@OrderDate ,@Salesman ,@Des, @IDCustomres,@tot,@dd,@bb,@dess,@TypeOrder)"
            cmd = New OleDbCommand(strQury, con)
            cmd.Parameters.Add(New OleDbParameter("@OrderDate", OleDbType.VarChar)).Value = txt_Date.Text
            cmd.Parameters.Add(New OleDbParameter("@Salesman", OleDbType.VarChar)).Value = TextBox1.Text
            cmd.Parameters.Add(New OleDbParameter("@Des", OleDbType.VarChar)).Value = txtDes.Text
            cmd.Parameters.Add(New OleDbParameter("@IDCustomres", OleDbType.Integer)).Value = txtCustId.Text
            cmd.Parameters.Add(New OleDbParameter("@tot", OleDbType.Currency)).Value = txt_total.Text
            cmd.Parameters.Add(New OleDbParameter("@dd", OleDbType.Currency)).Value = txt_d.Text
            cmd.Parameters.Add(New OleDbParameter("@bb", OleDbType.Currency)).Value = txt_b.Text
            cmd.Parameters.Add(New OleDbParameter("@dess", OleDbType.Currency)).Value = txtD.Text
            cmd.Parameters.Add(New OleDbParameter("@TypeOrder", OleDbType.VarChar)).Value = BUYTYPE.SelectedItem.ToString

            con.Open()
            cmd.ExecuteNonQuery()

            cmd = New OleDbCommand("select max(id) from Orders ", con)
            Dim dr As OleDbDataReader = cmd.ExecuteReader
            dr.Read()
            Dim ID_Order As Integer = dr(0)
            dr.Close()


            strQury = "insert into Order_Detils (ID_Product ,NameProduct , ID_Order, Qty ,price, Amount,Qty_in) values (@ID_Product,@NameProduct, @ID_Order, @Qty , @price ,@Amount,@Qty_in) "
            Dim NameProduct As String
            Dim ID_Product, Qty, Qtyin As Integer
            Dim Price, Amount As Double
            For i As Integer = 0 To dgvProduct.RowCount - 1
                ID_Product = dgvProduct.Rows(i).Cells(0).Value
                NameProduct = dgvProduct.Rows(i).Cells(1).Value

                Qty = dgvProduct.Rows(i).Cells(2).Value
                Price = dgvProduct.Rows(i).Cells(3).Value
                Amount = dgvProduct.Rows(i).Cells(4).Value
                Qtyin = dgvProduct.Rows(i).Cells(5).Value
                cmd = New OleDbCommand(strQury, con)
                cmd.Parameters.Add(New OleDbParameter("@ID_Product", OleDbType.Integer)).Value = ID_Product
                cmd.Parameters.Add(New OleDbParameter("@NameProduct", OleDbType.VarChar)).Value = NameProduct
                cmd.Parameters.Add(New OleDbParameter("@ID_Order", OleDbType.Integer)).Value = ID_Order
                cmd.Parameters.Add(New OleDbParameter("@Qty", OleDbType.Integer)).Value = Qty
                cmd.Parameters.Add(New OleDbParameter("@price", OleDbType.Currency)).Value = Price
                cmd.Parameters.Add(New OleDbParameter("@Amount", OleDbType.Currency)).Value = Amount
                cmd.Parameters.Add(New OleDbParameter("@Qty_in", OleDbType.Integer)).Value = Qtyin
                cmd.ExecuteNonQuery()
            Next
            con.Close()

            '=========== اضافة الكمية ==============================
            For M As Integer = 0 To dgvProduct.Rows.Count - 1
                Dim NEW_QTY As Integer
                NEW_QTY = Val(dgvProduct.Rows(M).Cells(5).Value) - Val(dgvProduct.Rows(M).Cells(2).Value)
                Dim CMD_1 As New OleDb.OleDbCommand
                CMD_1.Connection = con
                CMD_1.CommandText = " UPDATE  Product SET Qty = " & NEW_QTY & "  WHERE NameProduct = '" & dgvProduct.Rows(M).Cells(1).Value & "'"
                con.Open()

                CMD_1.ExecuteNonQuery()

                con.Close()

            Next
            '=====================اضافة المبلغ في حساب دين العميل===============
            If BUYTYPE.SelectedIndex = 1 Then
                Dim denges As Decimal
                denges = denge + Val(txt_b.Text)
                Dim CMD_1 As New OleDb.OleDbCommand
                CMD_1.Connection = con
                CMD_1.CommandText = " UPDATE  Customers SET Denge = " & denges & "  WHERE ID = " & txtCustId.Text & ""
                con.Open()

                CMD_1.ExecuteNonQuery()

                con.Close()
            End If




            MsgBox("تمت الحفظ", MsgBoxStyle.Information, "حفظ الفاتورة")

            print_sale(ID_Order)

            Dim cr As New Corder
            cr.SetDataSource(dt_print)
            FRM_Print.CrystalReportViewer1.ReportSource = cr
            FRM_Print.CrystalReportViewer1.Refresh()
            FRM_Print.CrystalReportViewer1.PrintReport()
            FRM_Print.Show()
            clcs()




        ElseIf state = "Edit" Then
            Dim strQury As String = "Update  Orders set   OrderDate=@OrderDate , Salesman=@Salesman  , Des = @Des , IDCustomres=@IDCustomres , total=@tot , dd=@dd, bb=@bb  , dess=@dess where ID =" & Me.IDOrder
            cmd = New OleDbCommand(strQury, con)
            cmd.Parameters.Add(New OleDbParameter("@OrderDate", OleDbType.VarChar)).Value = txt_Date.Text
            cmd.Parameters.Add(New OleDbParameter("@Salesman", OleDbType.VarChar)).Value = TextBox1.Text
            cmd.Parameters.Add(New OleDbParameter("@Des", OleDbType.VarChar)).Value = txtDes.Text
            cmd.Parameters.Add(New OleDbParameter("@IDCustomres", OleDbType.Integer)).Value = txtCustId.Text
            cmd.Parameters.Add(New OleDbParameter("@tot", OleDbType.Currency)).Value = txt_total.Text
            cmd.Parameters.Add(New OleDbParameter("@dd", OleDbType.Currency)).Value = txt_d.Text
            cmd.Parameters.Add(New OleDbParameter("@bb", OleDbType.Currency)).Value = txt_b.Text
            cmd.Parameters.Add(New OleDbParameter("@dess", OleDbType.Currency)).Value = txtD.Text
            con.Open()
            cmd.ExecuteNonQuery()

            cmd = New OleDbCommand("delete from Order_Detils where ID_Order=" & IDOrder, con)
            cmd.ExecuteNonQuery()


            strQury = "insert into Order_Detils (ID_Product ,NameProduct, ID_Order, Qty ,price, Amount) values (@ID_Product,@NameProduct, @ID_Order, @Qty , @price ,@Amount) "

            Dim NameProduct As String
            Dim ID_Product, Qty As Integer
            Dim Price, Amount As Double
            For i As Integer = 0 To dgvProduct.RowCount - 1
                ID_Product = dgvProduct.Rows(i).Cells(0).Value
                NameProduct = dgvProduct.Rows(i).Cells(1).Value

                Qty = dgvProduct.Rows(i).Cells(2).Value
                Price = dgvProduct.Rows(i).Cells(3).Value
                Amount = dgvProduct.Rows(i).Cells(4).Value
                Qty_in = dgvProduct.Rows(i).Cells(5).Value
                cmd = New OleDbCommand(strQury, con)


                cmd.Parameters.Add(New OleDbParameter("@ID_Product", OleDbType.Integer)).Value = ID_Product
                cmd.Parameters.Add(New OleDbParameter("@NameProduct", OleDbType.VarChar)).Value = NameProduct
                cmd.Parameters.Add(New OleDbParameter("@ID_Order", OleDbType.Integer)).Value = IDOrder
                cmd.Parameters.Add(New OleDbParameter("@Qty", OleDbType.Integer)).Value = Qty
                cmd.Parameters.Add(New OleDbParameter("@price", OleDbType.Currency)).Value = Price
                cmd.Parameters.Add(New OleDbParameter("@Amount", OleDbType.Currency)).Value = Amount

                cmd.ExecuteNonQuery()
            Next
            con.Close()
            MsgBox("تمت عملية التعديل بنجاح", MsgBoxStyle.Information, "تعديل الفاتورة")

            print_sale(IDOrder)
            Dim cr As New Corder
            cr.SetDataSource(dt_print)
            FRM_Print.CrystalReportViewer1.ReportSource = cr
            FRM_Print.CrystalReportViewer1.Refresh()
            FRM_Print.CrystalReportViewer1.PrintReport()
            FRM_Print.Show()


        End If
    End Sub

   
   

    
    Private Sub txt_d_TextChanged(sender As Object, e As EventArgs) Handles txt_d.TextChanged
        txt_b.Text = Val(txt_total.Text) - Val(txt_d.Text)
    End Sub

   
   
   

    

    

    

    Private Sub txtD_TextChanged(sender As Object, e As EventArgs) Handles txtD.TextChanged
        If txtD.Text = Nothing Then
            txt_total.Text = tot1
        ElseIf txtD.Text = 0 Then
            txt_total.Text = tot1

        Else
            txt_total.Text = Val(tot1) - Val(txtD.Text)
        End If
    End Sub

    
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        clcs()

    End Sub

    
End Class