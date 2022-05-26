Imports System.Data.OleDb
Public Class frm_login
    Dim con As New OleDbConnection("provider=Microsoft.ACE.oledb.12.0; data source= radwan.accdb;")
    Dim cmd As New OleDbCommand



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close() 'خرووج
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        cmd = New OleDbCommand("select * from Users where NameUse = @ID and Password = @Pass", con)
        cmd.Parameters.Add(New OleDbParameter("@ID", OleDbType.VarChar)).Value = txtID.Text
        cmd.Parameters.Add(New OleDbParameter("@Pass", OleDbType.VarChar)).Value = txtPass.Text
        If (con.State = ConnectionState.Open) Then
            con.Close()
        End If
        con.Open()

        Dim reader As OleDbDataReader = cmd.ExecuteReader
        reader.Read()
        If txtID.Text = Nothing Then
            MsgBox("يجب عليك ادخال اسم المستخدم", MsgBoxStyle.Information, "الدخول")
            txtID.Clear()
            txtPass.Clear()
            txtID.Focus()

        ElseIf txtPass.Text = Nothing Then
            MsgBox("يجب عليك ادخال كلمة المرور", MsgBoxStyle.Information, "الدخول")
            txtPass.Clear()
            txtPass.Focus()

        Else

            If reader.HasRows Then
                

                Dim frm As New frm_main
                frm.val = reader(2)
                frm.Uname = reader(0)
                frm.Show()
                Me.Close()
                begin.Close()



            Else
                MsgBox("خطاء في بيانات الدخول", MsgBoxStyle.Exclamation, "الدخول")
        End If

        End If
        reader.Close()
        con.Close()
    End Sub
    Private Sub txtID_KeyDown(sender As Object, e As KeyEventArgs) Handles txtID.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtPass.Focus()
        End If
    End Sub

    
    Private Sub frm_login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
