<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRMPor
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvProduct = New System.Windows.Forms.DataGridView()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btndel = New System.Windows.Forms.Button()
        Me.btnsch = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TOTALARABIC = New System.Windows.Forms.TextBox()
        Me.TOTALQTY = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.DISCOUND = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.TOTAL = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NOTES = New System.Windows.Forms.TextBox()
        Me.BUYDATE = New System.Windows.Forms.DateTimePicker()
        Me.BUYUSER = New System.Windows.Forms.TextBox()
        Me.IMPORTERNAME = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BUYTYPE = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BUYCODE = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TXT_BARCODE = New System.Windows.Forms.TextBox()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvProduct)
        Me.GroupBox3.Controls.Add(Me.btnexit)
        Me.GroupBox3.Controls.Add(Me.btnadd)
        Me.GroupBox3.Controls.Add(Me.btnsave)
        Me.GroupBox3.Controls.Add(Me.btnedit)
        Me.GroupBox3.Controls.Add(Me.btndel)
        Me.GroupBox3.Controls.Add(Me.btnsch)
        Me.GroupBox3.Location = New System.Drawing.Point(5, 226)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox3.Size = New System.Drawing.Size(1026, 374)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "تفاصيل البضاعة"
        '
        'dgvProduct
        '
        Me.dgvProduct.AllowUserToAddRows = False
        Me.dgvProduct.AllowUserToDeleteRows = False
        Me.dgvProduct.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvProduct.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProduct.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column3, Me.Column8})
        Me.dgvProduct.Location = New System.Drawing.Point(14, 28)
        Me.dgvProduct.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvProduct.Name = "dgvProduct"
        Me.dgvProduct.RowHeadersVisible = False
        Me.dgvProduct.RowTemplate.Height = 26
        Me.dgvProduct.Size = New System.Drawing.Size(969, 267)
        Me.dgvProduct.TabIndex = 12
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.Red
        Me.btnexit.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.btnexit.Location = New System.Drawing.Point(14, 303)
        Me.btnexit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnexit.Size = New System.Drawing.Size(154, 60)
        Me.btnexit.TabIndex = 11
        Me.btnexit.Text = "خروج"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnadd.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.btnadd.Location = New System.Drawing.Point(820, 303)
        Me.btnadd.Margin = New System.Windows.Forms.Padding(4)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnadd.Size = New System.Drawing.Size(163, 60)
        Me.btnadd.TabIndex = 10
        Me.btnadd.Text = "إضافة"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'btnsave
        '
        Me.btnsave.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnsave.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.btnsave.Location = New System.Drawing.Point(672, 303)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnsave.Size = New System.Drawing.Size(140, 60)
        Me.btnsave.TabIndex = 9
        Me.btnsave.Text = "حفظ"
        Me.btnsave.UseVisualStyleBackColor = False
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnedit.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.btnedit.Location = New System.Drawing.Point(520, 303)
        Me.btnedit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnedit.Size = New System.Drawing.Size(127, 60)
        Me.btnedit.TabIndex = 8
        Me.btnedit.Text = "تعديل"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'btndel
        '
        Me.btndel.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btndel.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.btndel.Location = New System.Drawing.Point(361, 303)
        Me.btndel.Margin = New System.Windows.Forms.Padding(4)
        Me.btndel.Name = "btndel"
        Me.btndel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btndel.Size = New System.Drawing.Size(125, 60)
        Me.btndel.TabIndex = 7
        Me.btndel.Text = "حذف"
        Me.btndel.UseVisualStyleBackColor = False
        '
        'btnsch
        '
        Me.btnsch.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnsch.Font = New System.Drawing.Font("Times New Roman", 14.0!)
        Me.btnsch.Location = New System.Drawing.Point(201, 303)
        Me.btnsch.Margin = New System.Windows.Forms.Padding(4)
        Me.btnsch.Name = "btnsch"
        Me.btnsch.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.btnsch.Size = New System.Drawing.Size(133, 60)
        Me.btnsch.TabIndex = 6
        Me.btnsch.Text = "بحث"
        Me.btnsch.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TOTALARABIC)
        Me.GroupBox4.Controls.Add(Me.TOTALQTY)
        Me.GroupBox4.Controls.Add(Me.Label19)
        Me.GroupBox4.Controls.Add(Me.DISCOUND)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.Label18)
        Me.GroupBox4.Controls.Add(Me.TOTAL)
        Me.GroupBox4.Location = New System.Drawing.Point(5, 601)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox4.Size = New System.Drawing.Size(1026, 117)
        Me.GroupBox4.TabIndex = 14
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "تفاصيل الفاتورة"
        '
        'TOTALARABIC
        '
        Me.TOTALARABIC.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.TOTALARABIC.Location = New System.Drawing.Point(8, 17)
        Me.TOTALARABIC.Margin = New System.Windows.Forms.Padding(4)
        Me.TOTALARABIC.Name = "TOTALARABIC"
        Me.TOTALARABIC.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TOTALARABIC.Size = New System.Drawing.Size(599, 32)
        Me.TOTALARABIC.TabIndex = 16
        '
        'TOTALQTY
        '
        Me.TOTALQTY.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TOTALQTY.Location = New System.Drawing.Point(279, 67)
        Me.TOTALQTY.Margin = New System.Windows.Forms.Padding(4)
        Me.TOTALQTY.Name = "TOTALQTY"
        Me.TOTALQTY.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TOTALQTY.Size = New System.Drawing.Size(241, 32)
        Me.TOTALQTY.TabIndex = 15
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(528, 72)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label19.Size = New System.Drawing.Size(96, 23)
        Me.Label19.TabIndex = 14
        Me.Label19.Text = "إجمالي الكمية" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'DISCOUND
        '
        Me.DISCOUND.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DISCOUND.Location = New System.Drawing.Point(672, 68)
        Me.DISCOUND.Margin = New System.Windows.Forms.Padding(4)
        Me.DISCOUND.Name = "DISCOUND"
        Me.DISCOUND.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DISCOUND.Size = New System.Drawing.Size(241, 32)
        Me.DISCOUND.TabIndex = 12
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(938, 72)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label17.Size = New System.Drawing.Size(63, 23)
        Me.Label17.TabIndex = 11
        Me.Label17.Text = "الخصم :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(932, 25)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label18.Size = New System.Drawing.Size(76, 23)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "الاجمالي :"
        '
        'TOTAL
        '
        Me.TOTAL.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TOTAL.Location = New System.Drawing.Point(672, 17)
        Me.TOTAL.Margin = New System.Windows.Forms.Padding(4)
        Me.TOTAL.Name = "TOTAL"
        Me.TOTAL.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TOTAL.Size = New System.Drawing.Size(238, 32)
        Me.TOTAL.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.NOTES)
        Me.GroupBox1.Controls.Add(Me.BUYDATE)
        Me.GroupBox1.Controls.Add(Me.BUYUSER)
        Me.GroupBox1.Controls.Add(Me.IMPORTERNAME)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.BUYTYPE)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.BUYCODE)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 1)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox1.Size = New System.Drawing.Size(1026, 145)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "البيانات الأساسية"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(201, 30)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(54, 19)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "المورد :"
        '
        'NOTES
        '
        Me.NOTES.Location = New System.Drawing.Point(267, 108)
        Me.NOTES.Margin = New System.Windows.Forms.Padding(4)
        Me.NOTES.Name = "NOTES"
        Me.NOTES.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.NOTES.Size = New System.Drawing.Size(620, 27)
        Me.NOTES.TabIndex = 13
        Me.NOTES.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BUYDATE
        '
        Me.BUYDATE.Location = New System.Drawing.Point(631, 61)
        Me.BUYDATE.Margin = New System.Windows.Forms.Padding(4)
        Me.BUYDATE.Name = "BUYDATE"
        Me.BUYDATE.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BUYDATE.Size = New System.Drawing.Size(256, 27)
        Me.BUYDATE.TabIndex = 12
        '
        'BUYUSER
        '
        Me.BUYUSER.Location = New System.Drawing.Point(14, 78)
        Me.BUYUSER.Margin = New System.Windows.Forms.Padding(4)
        Me.BUYUSER.Name = "BUYUSER"
        Me.BUYUSER.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BUYUSER.Size = New System.Drawing.Size(154, 27)
        Me.BUYUSER.TabIndex = 11
        Me.BUYUSER.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'IMPORTERNAME
        '
        Me.IMPORTERNAME.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.IMPORTERNAME.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.IMPORTERNAME.FormattingEnabled = True
        Me.IMPORTERNAME.Location = New System.Drawing.Point(14, 27)
        Me.IMPORTERNAME.Margin = New System.Windows.Forms.Padding(4)
        Me.IMPORTERNAME.Name = "IMPORTERNAME"
        Me.IMPORTERNAME.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.IMPORTERNAME.Size = New System.Drawing.Size(154, 27)
        Me.IMPORTERNAME.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(188, 78)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label6.Size = New System.Drawing.Size(63, 19)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "الموظف :"
        '
        'BUYTYPE
        '
        Me.BUYTYPE.FormattingEnabled = True
        Me.BUYTYPE.Items.AddRange(New Object() {"نقدي", "اجل"})
        Me.BUYTYPE.Location = New System.Drawing.Point(307, 53)
        Me.BUYTYPE.Margin = New System.Windows.Forms.Padding(4)
        Me.BUYTYPE.Name = "BUYTYPE"
        Me.BUYTYPE.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BUYTYPE.Size = New System.Drawing.Size(259, 27)
        Me.BUYTYPE.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(906, 24)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label1.Size = New System.Drawing.Size(81, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "رقم الفاتورة :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(400, 30)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label5.Size = New System.Drawing.Size(78, 19)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "نوع الفاتورة:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(906, 69)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(91, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "تاريخ الفاتورة :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(906, 112)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(70, 19)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ملاحظات :"
        '
        'BUYCODE
        '
        Me.BUYCODE.Location = New System.Drawing.Point(631, 22)
        Me.BUYCODE.Margin = New System.Windows.Forms.Padding(4)
        Me.BUYCODE.Name = "BUYCODE"
        Me.BUYCODE.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.BUYCODE.Size = New System.Drawing.Size(256, 27)
        Me.BUYCODE.TabIndex = 5
        Me.BUYCODE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.TXT_BARCODE)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 148)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.GroupBox2.Size = New System.Drawing.Size(1026, 79)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "طرق الادخال"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Button1.Location = New System.Drawing.Point(163, 23)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Button1.Size = New System.Drawing.Size(171, 43)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "ادراج اصناف"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(789, 26)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label10.Size = New System.Drawing.Size(115, 34)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "الباركود :"
        '
        'TXT_BARCODE
        '
        Me.TXT_BARCODE.Font = New System.Drawing.Font("Tahoma", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_BARCODE.Location = New System.Drawing.Point(342, 26)
        Me.TXT_BARCODE.Margin = New System.Windows.Forms.Padding(4)
        Me.TXT_BARCODE.Name = "TXT_BARCODE"
        Me.TXT_BARCODE.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TXT_BARCODE.Size = New System.Drawing.Size(400, 40)
        Me.TXT_BARCODE.TabIndex = 7
        Me.TXT_BARCODE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "ITEMCODE"
        Me.Column1.HeaderText = "رقم الصنف"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "ITEMNAME"
        Me.Column2.HeaderText = "اسم الصنف"
        Me.Column2.Name = "Column2"
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "PRICE"
        Me.Column4.HeaderText = "التكلفة"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "QTY"
        Me.Column5.HeaderText = "الكمية"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "DISCOUND"
        Me.Column6.HeaderText = "الخصم"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.DataPropertyName = "TOTAL"
        Me.Column7.HeaderText = "الاجمالي"
        Me.Column7.Name = "Column7"
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "QTY_IN"
        Me.Column3.HeaderText = "كمية المخزن"
        Me.Column3.Name = "Column3"
        Me.Column3.Visible = False
        '
        'Column8
        '
        Me.Column8.DataPropertyName = "Price_m"
        Me.Column8.HeaderText = "السعر المتوسط"
        Me.Column8.Name = "Column8"
        Me.Column8.Visible = False
        '
        'FRMPor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1046, 724)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Times New Roman", 10.0!)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FRMPor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "شاشة المشتريات"
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvProduct As System.Windows.Forms.DataGridView
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents btnadd As System.Windows.Forms.Button
    Friend WithEvents btnsave As System.Windows.Forms.Button
    Friend WithEvents btnedit As System.Windows.Forms.Button
    Friend WithEvents btndel As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TOTALQTY As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents DISCOUND As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TOTAL As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents NOTES As System.Windows.Forms.TextBox
    Friend WithEvents BUYDATE As System.Windows.Forms.DateTimePicker
    Friend WithEvents BUYUSER As System.Windows.Forms.TextBox
    Friend WithEvents IMPORTERNAME As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents BUYTYPE As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BUYCODE As System.Windows.Forms.TextBox
    Friend WithEvents TOTALARABIC As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TXT_BARCODE As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnsch As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
