<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_ORDERS
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_ORDERS))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BUYTYPE = New System.Windows.Forms.ComboBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txt_Date = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDes = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.txtTel = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtFullName = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtCustId = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtD = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_b = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txt_d = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnRemovAll = New System.Windows.Forms.Button()
        Me.btnRemov = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.txtAmount = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtQty = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtLabel = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvProduct = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Snow
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BUYTYPE)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.txt_Date)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtDes)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(9, 8)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(424, 182)
        Me.Panel1.TabIndex = 0
        '
        'BUYTYPE
        '
        Me.BUYTYPE.FormattingEnabled = True
        Me.BUYTYPE.Items.AddRange(New Object() {"نقدي", "اجل"})
        Me.BUYTYPE.Location = New System.Drawing.Point(11, 141)
        Me.BUYTYPE.Margin = New System.Windows.Forms.Padding(4)
        Me.BUYTYPE.Name = "BUYTYPE"
        Me.BUYTYPE.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BUYTYPE.Size = New System.Drawing.Size(289, 31)
        Me.BUYTYPE.TabIndex = 11
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(302, 144)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label19.Size = New System.Drawing.Size(97, 23)
        Me.Label19.TabIndex = 10
        Me.Label19.Text = "نوع الفاتورة:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(11, 105)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(289, 30)
        Me.TextBox1.TabIndex = 9
        '
        'txt_Date
        '
        Me.txt_Date.Location = New System.Drawing.Point(11, 70)
        Me.txt_Date.Name = "txt_Date"
        Me.txt_Date.ReadOnly = True
        Me.txt_Date.Size = New System.Drawing.Size(289, 30)
        Me.txt_Date.TabIndex = 8
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(302, 108)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 23)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "البائع:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(302, 76)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 23)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "تاريخ الفاتورة:"
        '
        'txtDes
        '
        Me.txtDes.Location = New System.Drawing.Point(11, 35)
        Me.txtDes.Name = "txtDes"
        Me.txtDes.Size = New System.Drawing.Size(289, 30)
        Me.txtDes.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(302, 38)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(111, 23)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "وصف الفاتورة:"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Location = New System.Drawing.Point(276, -1)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 31)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "معلومات الفاتورة"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Snow
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Button5)
        Me.Panel2.Controls.Add(Me.txtTel)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.txtFullName)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.txtCustId)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(433, 8)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(436, 182)
        Me.Panel2.TabIndex = 0
        '
        'Button5
        '
        Me.Button5.BackColor = System.Drawing.SystemColors.Window
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(24, 45)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(39, 29)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "..."
        Me.Button5.UseVisualStyleBackColor = False
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(24, 119)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.ReadOnly = True
        Me.txtTel.Size = New System.Drawing.Size(289, 30)
        Me.txtTel.TabIndex = 9
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(319, 119)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 23)
        Me.Label14.TabIndex = 8
        Me.Label14.Text = "الهاتف:"
        '
        'txtFullName
        '
        Me.txtFullName.Location = New System.Drawing.Point(24, 83)
        Me.txtFullName.Name = "txtFullName"
        Me.txtFullName.ReadOnly = True
        Me.txtFullName.Size = New System.Drawing.Size(289, 30)
        Me.txtFullName.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(319, 86)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(83, 23)
        Me.Label13.TabIndex = 6
        Me.Label13.Text = "اسم العميل:"
        '
        'txtCustId
        '
        Me.txtCustId.Location = New System.Drawing.Point(69, 44)
        Me.txtCustId.Name = "txtCustId"
        Me.txtCustId.ReadOnly = True
        Me.txtCustId.Size = New System.Drawing.Size(244, 30)
        Me.txtCustId.TabIndex = 5
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(319, 47)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 23)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "المعرف:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Location = New System.Drawing.Point(288, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 31)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "معلومات العميل"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Snow
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.txtD)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.txt_b)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.txt_d)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.txt_total)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.btnClose)
        Me.Panel3.Controls.Add(Me.btnRemovAll)
        Me.Panel3.Controls.Add(Me.btnRemov)
        Me.Panel3.Controls.Add(Me.btnSave)
        Me.Panel3.Controls.Add(Me.txtAmount)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.txtPrice)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.txtQty)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.txtLabel)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.txtID)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.dgvProduct)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Location = New System.Drawing.Point(9, 190)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(860, 478)
        Me.Panel3.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Location = New System.Drawing.Point(485, 366)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(79, 95)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "تفريغ"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txtD
        '
        Me.txtD.Location = New System.Drawing.Point(252, 410)
        Me.txtD.Name = "txtD"
        Me.txtD.Size = New System.Drawing.Size(161, 30)
        Me.txtD.TabIndex = 23
        Me.txtD.Text = "0"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(420, 413)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(58, 23)
        Me.Label18.TabIndex = 22
        Me.Label18.Text = "الخصم:"
        '
        'txt_b
        '
        Me.txt_b.Location = New System.Drawing.Point(14, 410)
        Me.txt_b.Name = "txt_b"
        Me.txt_b.ReadOnly = True
        Me.txt_b.Size = New System.Drawing.Size(161, 30)
        Me.txt_b.TabIndex = 21
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(181, 413)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(54, 23)
        Me.Label17.TabIndex = 20
        Me.Label17.Text = "الباقي:"
        '
        'txt_d
        '
        Me.txt_d.Location = New System.Drawing.Point(14, 374)
        Me.txt_d.Name = "txt_d"
        Me.txt_d.Size = New System.Drawing.Size(161, 30)
        Me.txt_d.TabIndex = 19
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(181, 377)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(67, 23)
        Me.Label16.TabIndex = 18
        Me.Label16.Text = "المدفوع:"
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(252, 374)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.ReadOnly = True
        Me.txt_total.Size = New System.Drawing.Size(161, 30)
        Me.txt_total.TabIndex = 17
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(419, 377)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(71, 23)
        Me.Label15.TabIndex = 16
        Me.Label15.Text = "الاجمالي:"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClose.Location = New System.Drawing.Point(570, 416)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(121, 45)
        Me.btnClose.TabIndex = 15
        Me.btnClose.Text = "اغلاق"
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnRemovAll
        '
        Me.btnRemovAll.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnRemovAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRemovAll.Location = New System.Drawing.Point(697, 416)
        Me.btnRemovAll.Name = "btnRemovAll"
        Me.btnRemovAll.Size = New System.Drawing.Size(151, 45)
        Me.btnRemovAll.TabIndex = 14
        Me.btnRemovAll.Text = "حذف كافة المنتجات"
        Me.btnRemovAll.UseVisualStyleBackColor = False
        '
        'btnRemov
        '
        Me.btnRemov.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnRemov.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRemov.Location = New System.Drawing.Point(570, 366)
        Me.btnRemov.Name = "btnRemov"
        Me.btnRemov.Size = New System.Drawing.Size(121, 45)
        Me.btnRemov.TabIndex = 13
        Me.btnRemov.Text = "حذف المنتج"
        Me.btnRemov.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSave.Location = New System.Drawing.Point(697, 366)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(151, 45)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "حفظ الفاتورة"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'txtAmount
        '
        Me.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAmount.Location = New System.Drawing.Point(24, 74)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.ReadOnly = True
        Me.txtAmount.Size = New System.Drawing.Size(134, 30)
        Me.txtAmount.TabIndex = 11
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Location = New System.Drawing.Point(24, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(134, 31)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "المبلغ"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPrice
        '
        Me.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrice.Location = New System.Drawing.Point(158, 74)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.ReadOnly = True
        Me.txtPrice.Size = New System.Drawing.Size(131, 30)
        Me.txtPrice.TabIndex = 9
        Me.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label7.Location = New System.Drawing.Point(158, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 31)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "السعر"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtQty
        '
        Me.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQty.Location = New System.Drawing.Point(289, 74)
        Me.txtQty.Name = "txtQty"
        Me.txtQty.Size = New System.Drawing.Size(124, 30)
        Me.txtQty.TabIndex = 7
        Me.txtQty.Text = "1"
        Me.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label6.Location = New System.Drawing.Point(289, 43)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 31)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "الكمية"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtLabel
        '
        Me.txtLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLabel.Location = New System.Drawing.Point(413, 74)
        Me.txtLabel.Name = "txtLabel"
        Me.txtLabel.ReadOnly = True
        Me.txtLabel.Size = New System.Drawing.Size(266, 30)
        Me.txtLabel.TabIndex = 5
        Me.txtLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Location = New System.Drawing.Point(413, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(266, 31)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "اسم المنتج"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtID
        '
        Me.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtID.Location = New System.Drawing.Point(679, 74)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(152, 30)
        Me.txtID.TabIndex = 3
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label4.Location = New System.Drawing.Point(679, 43)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 31)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "الكود"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgvProduct
        '
        Me.dgvProduct.AllowUserToAddRows = False
        Me.dgvProduct.AllowUserToDeleteRows = False
        Me.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProduct.ColumnHeadersVisible = False
        Me.dgvProduct.Location = New System.Drawing.Point(24, 110)
        Me.dgvProduct.Name = "dgvProduct"
        Me.dgvProduct.ReadOnly = True
        Me.dgvProduct.RowHeadersVisible = False
        Me.dgvProduct.RowTemplate.Height = 26
        Me.dgvProduct.Size = New System.Drawing.Size(807, 241)
        Me.dgvProduct.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Location = New System.Drawing.Point(697, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 38)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "المنتجات"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'FRM_ORDERS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 23.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 678)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FRM_ORDERS"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "شاشة المبيعات"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dgvProduct As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtDes As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtFullName As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtCustId As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnRemovAll As System.Windows.Forms.Button
    Friend WithEvents btnRemov As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents txtAmount As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtPrice As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtQty As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtLabel As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_b As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txt_d As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents txtD As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txt_Date As System.Windows.Forms.TextBox
    Friend WithEvents BUYTYPE As System.Windows.Forms.ComboBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
