<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Pay
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.txt_note = New System.Windows.Forms.RichTextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_edit = New System.Windows.Forms.Button()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_phone = New System.Windows.Forms.TextBox()
        Me.txt_company = New System.Windows.Forms.TextBox()
        Me.txt_address = New System.Windows.Forms.TextBox()
        Me.txt_code = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_diff = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_credit = New System.Windows.Forms.TextBox()
        Me.txt_debit = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_search)
        Me.GroupBox1.Controls.Add(Me.btn_new)
        Me.GroupBox1.Controls.Add(Me.txt_note)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.btn_delete)
        Me.GroupBox1.Controls.Add(Me.btn_save)
        Me.GroupBox1.Controls.Add(Me.btn_edit)
        Me.GroupBox1.Controls.Add(Me.txt_name)
        Me.GroupBox1.Controls.Add(Me.txt_phone)
        Me.GroupBox1.Controls.Add(Me.txt_company)
        Me.GroupBox1.Controls.Add(Me.txt_address)
        Me.GroupBox1.Controls.Add(Me.txt_code)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(901, 422)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "البيانات الأساسية"
        '
        'btn_search
        '
        Me.btn_search.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btn_search.Location = New System.Drawing.Point(209, 305)
        Me.btn_search.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btn_search.Size = New System.Drawing.Size(215, 48)
        Me.btn_search.TabIndex = 21
        Me.btn_search.Text = "بحث"
        Me.btn_search.UseVisualStyleBackColor = False
        '
        'btn_new
        '
        Me.btn_new.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btn_new.Location = New System.Drawing.Point(656, 305)
        Me.btn_new.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btn_new.Size = New System.Drawing.Size(171, 104)
        Me.btn_new.TabIndex = 15
        Me.btn_new.Text = "إضافة"
        Me.btn_new.UseVisualStyleBackColor = False
        '
        'txt_note
        '
        Me.txt_note.Location = New System.Drawing.Point(43, 130)
        Me.txt_note.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_note.Name = "txt_note"
        Me.txt_note.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_note.Size = New System.Drawing.Size(314, 41)
        Me.txt_note.TabIndex = 20
        Me.txt_note.Text = ""
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.Location = New System.Drawing.Point(10, 305)
        Me.Button2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Button2.Name = "Button2"
        Me.Button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button2.Size = New System.Drawing.Size(171, 104)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "رجوع"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btn_delete.Location = New System.Drawing.Point(209, 361)
        Me.btn_delete.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btn_delete.Size = New System.Drawing.Size(215, 48)
        Me.btn_delete.TabIndex = 17
        Me.btn_delete.Text = "حذف"
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_save
        '
        Me.btn_save.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btn_save.Location = New System.Drawing.Point(434, 305)
        Me.btn_save.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btn_save.Size = New System.Drawing.Size(212, 48)
        Me.btn_save.TabIndex = 18
        Me.btn_save.Text = "حفظ"
        Me.btn_save.UseVisualStyleBackColor = False
        '
        'btn_edit
        '
        Me.btn_edit.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btn_edit.Location = New System.Drawing.Point(434, 361)
        Me.btn_edit.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.btn_edit.Name = "btn_edit"
        Me.btn_edit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btn_edit.Size = New System.Drawing.Size(212, 48)
        Me.btn_edit.TabIndex = 19
        Me.btn_edit.Text = "تعديل"
        Me.btn_edit.UseVisualStyleBackColor = False
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(43, 23)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_name.Size = New System.Drawing.Size(314, 30)
        Me.txt_name.TabIndex = 15
        Me.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_phone
        '
        Me.txt_phone.Location = New System.Drawing.Point(43, 75)
        Me.txt_phone.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_phone.Name = "txt_phone"
        Me.txt_phone.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_phone.Size = New System.Drawing.Size(314, 30)
        Me.txt_phone.TabIndex = 14
        Me.txt_phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_company
        '
        Me.txt_company.Location = New System.Drawing.Point(479, 130)
        Me.txt_company.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_company.Name = "txt_company"
        Me.txt_company.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_company.Size = New System.Drawing.Size(198, 30)
        Me.txt_company.TabIndex = 11
        Me.txt_company.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_address
        '
        Me.txt_address.Location = New System.Drawing.Point(479, 75)
        Me.txt_address.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_address.Name = "txt_address"
        Me.txt_address.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_address.Size = New System.Drawing.Size(198, 30)
        Me.txt_address.TabIndex = 10
        Me.txt_address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_code
        '
        Me.txt_code.Location = New System.Drawing.Point(479, 23)
        Me.txt_code.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_code.Name = "txt_code"
        Me.txt_code.ReadOnly = True
        Me.txt_code.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_code.Size = New System.Drawing.Size(198, 30)
        Me.txt_code.TabIndex = 9
        Me.txt_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(377, 133)
        Me.Label7.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label7.Size = New System.Drawing.Size(72, 22)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "ملاحظات"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(720, 133)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(82, 22)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "اسم الشركة"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(377, 26)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label4.Size = New System.Drawing.Size(79, 22)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "اسم المورد"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(377, 78)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(79, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "رقم الهاتف"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(702, 78)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(100, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "عنوان الشركة"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(723, 26)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(79, 22)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "رقم المورد"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_diff)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txt_credit)
        Me.GroupBox2.Controls.Add(Me.txt_debit)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(10, 179)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox2.Size = New System.Drawing.Size(881, 107)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "حركة الحساب"
        '
        'txt_diff
        '
        Me.txt_diff.Location = New System.Drawing.Point(30, 50)
        Me.txt_diff.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_diff.Name = "txt_diff"
        Me.txt_diff.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_diff.Size = New System.Drawing.Size(263, 30)
        Me.txt_diff.TabIndex = 14
        Me.txt_diff.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(132, 22)
        Me.Label8.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label8.Size = New System.Drawing.Size(45, 22)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "الفرق"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(412, 22)
        Me.Label9.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label9.Size = New System.Drawing.Size(49, 22)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "المدين"
        '
        'txt_credit
        '
        Me.txt_credit.Location = New System.Drawing.Point(327, 50)
        Me.txt_credit.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_credit.Name = "txt_credit"
        Me.txt_credit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_credit.Size = New System.Drawing.Size(252, 30)
        Me.txt_credit.TabIndex = 12
        Me.txt_credit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txt_debit
        '
        Me.txt_debit.Location = New System.Drawing.Point(622, 50)
        Me.txt_debit.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.txt_debit.Name = "txt_debit"
        Me.txt_debit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txt_debit.Size = New System.Drawing.Size(243, 30)
        Me.txt_debit.TabIndex = 13
        Me.txt_debit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(740, 22)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(45, 22)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "الدائن"
        '
        'FRM_Pay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 439)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "FRM_Pay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "الموردون"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_note As System.Windows.Forms.RichTextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_edit As System.Windows.Forms.Button
    Friend WithEvents btn_new As System.Windows.Forms.Button
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_phone As System.Windows.Forms.TextBox
    Friend WithEvents txt_company As System.Windows.Forms.TextBox
    Friend WithEvents txt_address As System.Windows.Forms.TextBox
    Friend WithEvents txt_code As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_diff As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_credit As System.Windows.Forms.TextBox
    Friend WithEvents txt_debit As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_search As System.Windows.Forms.Button
End Class
