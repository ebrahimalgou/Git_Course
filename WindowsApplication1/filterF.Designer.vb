<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class filterF
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtbb = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtdd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvday = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Salsman = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ofDate = New System.Windows.Forms.DateTimePicker()
        Me.toDate = New System.Windows.Forms.DateTimePicker()
        CType(Me.dgvday, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(29, 533)
        Me.Button1.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(177, 46)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "خروج"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(245, 543)
        Me.txttotal.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.ReadOnly = True
        Me.txttotal.Size = New System.Drawing.Size(169, 30)
        Me.txttotal.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(417, 546)
        Me.Label3.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 22)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "الاجمالي"
        '
        'txtbb
        '
        Me.txtbb.Location = New System.Drawing.Point(510, 543)
        Me.txtbb.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.txtbb.Name = "txtbb"
        Me.txtbb.ReadOnly = True
        Me.txtbb.Size = New System.Drawing.Size(147, 30)
        Me.txtbb.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(661, 546)
        Me.Label2.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 22)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "الباقي"
        '
        'txtdd
        '
        Me.txtdd.Location = New System.Drawing.Point(733, 543)
        Me.txtdd.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.txtdd.Name = "txtdd"
        Me.txtdd.ReadOnly = True
        Me.txtdd.Size = New System.Drawing.Size(147, 30)
        Me.txtdd.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(889, 546)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 22)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "المدفوع"
        '
        'dgvday
        '
        Me.dgvday.AllowUserToAddRows = False
        Me.dgvday.AllowUserToDeleteRows = False
        Me.dgvday.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvday.BackgroundColor = System.Drawing.Color.LightSeaGreen
        Me.dgvday.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvday.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.dgvday.Location = New System.Drawing.Point(17, 67)
        Me.dgvday.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.dgvday.Name = "dgvday"
        Me.dgvday.ReadOnly = True
        Me.dgvday.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.dgvday.RowHeadersVisible = False
        Me.dgvday.RowTemplate.Height = 26
        Me.dgvday.Size = New System.Drawing.Size(958, 462)
        Me.dgvday.TabIndex = 8
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "ID"
        Me.Column1.HeaderText = "رقم الفاتورة"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "OrderDate"
        Me.Column2.HeaderText = "تاريخ الفاتورة"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "Salesman"
        Me.Column3.HeaderText = "البائع"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "total"
        Me.Column4.HeaderText = "الاجمالي"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "dd"
        Me.Column5.HeaderText = "المدفوع"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'Column6
        '
        Me.Column6.DataPropertyName = "bb"
        Me.Column6.HeaderText = "الباقي"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Salsman
        '
        Me.Salsman.FormattingEnabled = True
        Me.Salsman.Location = New System.Drawing.Point(755, 19)
        Me.Salsman.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Salsman.Name = "Salsman"
        Me.Salsman.Size = New System.Drawing.Size(143, 30)
        Me.Salsman.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(898, 22)
        Me.Label4.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 22)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = ":البائع"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(636, 22)
        Me.Label5.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 22)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = ":التاريخ من"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(410, 22)
        Me.Label6.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(36, 22)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = ":الي"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button2.Location = New System.Drawing.Point(38, 15)
        Me.Button2.Margin = New System.Windows.Forms.Padding(8, 6, 8, 6)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(138, 40)
        Me.Button2.TabIndex = 22
        Me.Button2.Text = "بحث"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ofDate
        '
        Me.ofDate.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ofDate.Location = New System.Drawing.Point(457, 19)
        Me.ofDate.Name = "ofDate"
        Me.ofDate.Size = New System.Drawing.Size(182, 30)
        Me.ofDate.TabIndex = 23
        Me.ofDate.Value = New Date(2022, 2, 21, 0, 0, 0, 0)
        '
        'toDate
        '
        Me.toDate.Location = New System.Drawing.Point(229, 19)
        Me.toDate.Name = "toDate"
        Me.toDate.Size = New System.Drawing.Size(182, 30)
        Me.toDate.TabIndex = 24
        Me.toDate.Value = New Date(2022, 2, 21, 0, 0, 0, 0)
        '
        'filterF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1002, 584)
        Me.Controls.Add(Me.toDate)
        Me.Controls.Add(Me.ofDate)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Salsman)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtbb)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtdd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvday)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "filterF"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ShowIcon = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "فلترة المبيعات"
        CType(Me.dgvday, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtbb As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtdd As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvday As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Salsman As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ofDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents toDate As System.Windows.Forms.DateTimePicker
End Class
