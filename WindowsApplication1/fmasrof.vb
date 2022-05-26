Imports System.Data.OleDb

Public Class fmasrof


    Public state As String = "Add"
    Dim con As New OleDbConnection("provider=Microsoft.ACE.oledb.12.0; data source= radwan.accdb;")
    Dim cmd As New OleDbCommand
    Private Sub fmasrof_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_Date.Text = DateTime.Now
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.txtDes.Focus()
        Try


            cmd = New OleDbCommand("insert into msrof ([Salesman],[Date],[Des],[mony]) values (@Salesman ,@Date ,@Des,@mony)", con)
            cmd.Parameters.Add(New OleDbParameter("@Salesman", OleDbType.VarChar)).Value = txtUse.Text
            cmd.Parameters.Add(New OleDbParameter("@Date", OleDbType.VarChar)).Value = txt_Date.Text()
            cmd.Parameters.Add(New OleDbParameter("@Des", OleDbType.VarChar)).Value = txtDes.Text
            cmd.Parameters.Add(New OleDbParameter("@mony", OleDbType.Decimal)).Value = txtmony.Text
            con.Open()
            cmd.ExecuteNonQuery()
            MsgBox("تمت العمليه بنجاح", MsgBoxStyle.Information, "ادارة المصروفات")

        Catch ex As Exception

            MsgBox(ex.Message)
        Finally
            con.Close()
            Me.Close()
        End Try
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

End Class