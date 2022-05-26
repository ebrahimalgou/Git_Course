Imports System.Data.OleDb


Public Class frm_main
    Dim con As New OleDbConnection("provider=Microsoft.ACE.oledb.12.0; data source= radwan.accdb;")
    Dim dt As New DataTable
    Dim da As New OleDbDataAdapter
    Dim cmdb As New OleDbCommandBuilder
    Public val As String
    Public Uname As String

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblComputer.Text &= Environment.MachineName
        lblDate.Text &= Now.ToShortDateString
        For Each ctr As Control In Me.Controls
            If TypeOf ctr Is MdiClient Then
                ctr.BackgroundImage = My.Resources._1900851

            End If
        Next
    End Sub

    
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = Now.ToLongTimeString
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub اضافةمنتججديدToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles اضافةمنتججديدToolStripMenuItem.Click
        If val = "مدير" Then
            Dim frm As New FrM_ADD_PRODUCTS
            frm.MdiParent = Me
            frm.Show()
            frm.txtName.Focus()
        ElseIf val = "موظف" Then
            Dim frm As New FrM_ADD_PRODUCTS
            frm.MdiParent = Me
            frm.Show()
            frm.txtName.Focus()
        Else
            MsgBox("ليس لديك صلاحية", MsgBoxStyle.Information, "الصلاحيات")

        End If

    End Sub

    Private Sub btnManageProduct_Click(sender As Object, e As EventArgs) Handles btnManageProduct.Click
        If val = "مدير" Then
            Dim frm As New FRM_MANAGE_PRODUCTES
            frm.MdiParent = Me
            frm.Show()
        ElseIf val = "موظف" Then
            Dim frm As New FRM_MANAGE_PRODUCTES
            frm.MdiParent = Me
            frm.Show()
        Else
            MsgBox("ليس لديك صلاحية", MsgBoxStyle.Information, "الصلاحيات")

        End If

    End Sub

    Private Sub tsproduct_Click(sender As Object, e As EventArgs) Handles tsproduct.Click

        If val = "مدير" Then
            Dim frm As New FRM_MANAGE_PRODUCTES
            frm.MdiParent = Me
            frm.Show()
        ElseIf val = "موظف" Then
            Dim frm As New FRM_MANAGE_PRODUCTES
            frm.MdiParent = Me
            frm.Show()
        Else
            MsgBox("ليس لديك صلاحية", MsgBoxStyle.Information, "الصلاحيات")

        End If
        

    End Sub

    Private Sub btnManageCustomers_Click(sender As Object, e As EventArgs) Handles btnManageCustomers.Click
        If val = "مدير" Then
            Dim frm As New FRM_MANAGE_COUSTEMR
            frm.MdiParent = Me
            frm.Show()
        ElseIf val = "موظف" Then
            Dim frm As New FRM_MANAGE_COUSTEMR
            frm.MdiParent = Me
            frm.Show()
        Else
            MsgBox("ليس لديك صلاحية", MsgBoxStyle.Information, "الصلاحيات")

        End If
    End Sub

    Private Sub tsCustomers_Click(sender As Object, e As EventArgs) Handles tsCustomers.Click
        If val = "مدير" Then
            Dim frm As New FRM_MANAGE_COUSTEMR
            frm.MdiParent = Me
            frm.Show()
        ElseIf val = "موظف" Then
            Dim frm As New FRM_MANAGE_COUSTEMR
            frm.MdiParent = Me
            frm.Show()
        Else
            MsgBox("ليس لديك صلاحية", MsgBoxStyle.Information, "الصلاحيات")

        End If

    End Sub

    Private Sub btnManageOrders_Click(sender As Object, e As EventArgs) Handles btnManageOrders.Click
        Dim frm As New FRM_ORDERS
        frm.MdiParent = Me
        frm.TextBox1.Text = Uname
        frm.Show()
    End Sub

    Private Sub tsOrders_Click(sender As Object, e As EventArgs) Handles tsOrders.Click
        Dim frm As New FRM_ORDERS
        frm.MdiParent = Me
        frm.TextBox1.Text = Uname
        frm.Show()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        End

    End Sub

   Private Sub btnSearchInOrders_Click(sender As Object, e As EventArgs) Handles btnSearchInOrders.Click
        Dim frm As New FRM_MANAGE_ORDERS
        frm.MdiParent = Me
        frm.Uname = Uname
        frm.Show()
    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs) Handles btnAbout.Click
        MsgBox("الاصدار 1.0.0", MsgBoxStyle.Information, "الاصدار")

    End Sub

   
    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Dim f As New CRProduct
        Dim rpt As New CR_Product
        f.CrystalReportViewer1.ReportSource = rpt
        f.CrystalReportViewer1.RefreshReport()
        f.Show()
    End Sub

    Private Sub المستخدمونToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles المستخدمونToolStripMenuItem.Click
        If val = "مدير" Then
            Dim frm As New frm_Use
            frm.Show()
        Else
            MsgBox("ليس لديك صلاحية", MsgBoxStyle.Information, "الصلاحيات")

        End If
    End Sub

    

    Private Sub تسجيلالخروجToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تسجيلالخروجToolStripMenuItem.Click
        Dim frm As New begin
        frm.Show()
        Me.Close()
    End Sub

   
    Private Sub مشترياتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles مشترياتToolStripMenuItem.Click
        If val = "مدير" Then
            Dim frm As New FRMPor
            'frm.MdiParent = Me
            frm.Show()
        ElseIf val = "موظف" Then
            Dim frm As New FRM_MANAGE_COUSTEMR
            'frm.MdiParent = Me
            frm.Show()
        Else
            MsgBox("ليس لديك صلاحية", MsgBoxStyle.Information, "الصلاحيات")

        End If
    End Sub

    Private Sub موردينToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles موردينToolStripMenuItem.Click
        If val = "مدير" Then
            Dim frm As New FRM_Pay
            frm.MdiParent = Me
            frm.Show()
        ElseIf val = "موظف" Then
            Dim frm As New FRM_MANAGE_COUSTEMR
            frm.MdiParent = Me
            frm.Show()
        Else
            MsgBox("ليس لديك صلاحية", MsgBoxStyle.Information, "الصلاحيات")

        End If
    End Sub

    Private Sub مبيعاتاليومToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles مبيعاتاليومToolStripMenuItem.Click
        If val = "مدير" Then
            FRMDay.Show()
        ElseIf val = "موظف" Then
            FRMDay.Show()
        Else
            MsgBox("ليس لديك صلاحية", MsgBoxStyle.Information, "الصلاحيات")

        End If

    End Sub

    Private Sub فلترةالمبيعاتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles فلترةالمبيعاتToolStripMenuItem.Click

        If val = "مدير" Then
            filterF.Show()
        ElseIf val = "موظف" Then
            filterF.Show()
        Else
            MsgBox("ليس لديك صلاحية", MsgBoxStyle.Information, "الصلاحيات")

        End If
    End Sub

    Private Sub اضافةمصاريفToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles اضافةمصاريفToolStripMenuItem.Click
        If val = "مدير" Then
            Dim frm As New fmasrof

            frm.MdiParent = Me
            frm.txtUse.Text = Uname
            frm.Show()
        ElseIf val = "موظف" Then
            Dim frm As New fmasrof

            frm.MdiParent = Me
            frm.txtUse.Text = Uname
            frm.Show()
        Else
            MsgBox("ليس لديك صلاحية", MsgBoxStyle.Information, "الصلاحيات")

        End If
    End Sub

    Private Sub تعديلالمصروفاتToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles تعديلالمصروفاتToolStripMenuItem.Click
        If val = "مدير" Then
            Dim frm As New filtermasrof
            frm.MdiParent = Me
            frm.Show()
        End If
    End Sub

   
    
End Class