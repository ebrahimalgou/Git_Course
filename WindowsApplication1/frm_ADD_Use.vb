Imports System.Data.OleDb
Public Class frm_ADD_Use



    Public NameUse As String
    Public state As String = "Add"
    Dim con As New OleDbConnection("provider=Microsoft.ACE.oledb.12.0; data source= radwan.accdb;")
    Dim cmd As New OleDbCommand
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.txtName.Focus()
        Try
            Dim strQury As String = ""


            If state = "Add" Then
                strQury = "insert into Users ([NameUse],[Password],[val]) values (@Name ,@Pass ,@Val)"

            Else

                strQury = "Update Users set [NameUse] = @Name , [Password] = @Pass , val = @Val Where [NameUse] = '" & Me.NameUse & "'"


            End If
            cmd = New OleDbCommand(strQury, con)
            cmd.Parameters.Add(New OleDbParameter("@Name", OleDbType.VarChar)).Value = txtName.Text
            cmd.Parameters.Add(New OleDbParameter("@Pass", OleDbType.VarChar)).Value = txtPass.Text
            cmd.Parameters.Add(New OleDbParameter("@Val", OleDbType.VarChar)).Value = Cval.Text.ToString
            con.Open()
            cmd.ExecuteNonQuery()
            MsgBox("تمت العمليه بنجاح", MsgBoxStyle.Information, "ادارة الحسابات")

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

    Private Sub frm_ADD_Use_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
