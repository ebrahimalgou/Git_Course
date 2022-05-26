Imports System.Data.OleDb
Public Class FrM_ADD_PRODUCTS
    Public ID_Product As Integer
    Public state As String = "Add"
    Dim con As New OleDbConnection("provider=Microsoft.ACE.oledb.12.0; data source= radwan.accdb;")
    Dim cmd As New OleDbCommand
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        txtName.Focus()
        Try
            Dim strQury As String = ""


            If state = "Add" Then
                strQury = "insert into  Product (NameProduct,Qty,Price,Price_m ) values (@Name ,@Qty ,@Price,@Price_m)"
                
            Else

                strQury = " update Product set  NameProduct = @Name , Qty = @Qty, Price = @Price Where Code = " & ID_Product

            End If
            cmd = New OleDbCommand(strQury, con)
            cmd.Parameters.Add(New OleDbParameter("@Name", OleDbType.VarChar)).Value = txtName.Text
            cmd.Parameters.Add(New OleDbParameter("@Qty", OleDbType.Integer)).Value = txtQty.Text
            cmd.Parameters.Add(New OleDbParameter("@Price", OleDbType.Currency)).Value = txtPrice.Text
            cmd.Parameters.Add(New OleDbParameter("@Price_m", OleDbType.Currency)).Value = txtPrice_m.Text
            con.Open()
            cmd.ExecuteNonQuery()
            MsgBox("تمت العمليه بنجاح", MsgBoxStyle.Information, "ادارة المنتجات")
           
        Catch ex As Exception

            MsgBox(ex.Message)
        Finally
            con.Close()
            Me.Close()
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

    Private Sub FrM_ADD_PRODUCTS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtName.Focus()

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

   
   
End Class