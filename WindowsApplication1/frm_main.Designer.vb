<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_main))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ملفToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.مشترياتToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.موردينToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAddProduct = New System.Windows.Forms.ToolStripMenuItem()
        Me.اضافةمنتججديدToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnManageProduct = New System.Windows.Forms.ToolStripMenuItem()
        Me.العملاءToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnManageCustomers = New System.Windows.Forms.ToolStripMenuItem()
        Me.المبيعاتToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnManageOrders = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSearchInOrders = New System.Windows.Forms.ToolStripMenuItem()
        Me.مبيعاتاليومToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.فلترةالمبيعاتToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.مساعدةToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.المصروفاتToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.اضافةمصاريفToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.تعديلالمصروفاتToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.المستخدمونToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.تسجيلالخروجToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lblComputer = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lblDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsproduct = New System.Windows.Forms.ToolStripButton()
        Me.tsCustomers = New System.Windows.Forms.ToolStripButton()
        Me.tsOrders = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.MenuStrip1.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ملفToolStripMenuItem, Me.مشترياتToolStripMenuItem, Me.موردينToolStripMenuItem, Me.btnAddProduct, Me.العملاءToolStripMenuItem, Me.المبيعاتToolStripMenuItem, Me.مساعدةToolStripMenuItem, Me.المصروفاتToolStripMenuItem, Me.المستخدمونToolStripMenuItem, Me.تسجيلالخروجToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(995, 29)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ملفToolStripMenuItem
        '
        Me.ملفToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnExit})
        Me.ملفToolStripMenuItem.Name = "ملفToolStripMenuItem"
        Me.ملفToolStripMenuItem.Size = New System.Drawing.Size(48, 25)
        Me.ملفToolStripMenuItem.Text = "ملف"
        '
        'btnExit
        '
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(126, 26)
        Me.btnExit.Text = "الخروج"
        '
        'مشترياتToolStripMenuItem
        '
        Me.مشترياتToolStripMenuItem.Name = "مشترياتToolStripMenuItem"
        Me.مشترياتToolStripMenuItem.Size = New System.Drawing.Size(76, 25)
        Me.مشترياتToolStripMenuItem.Text = "مشتريات"
        '
        'موردينToolStripMenuItem
        '
        Me.موردينToolStripMenuItem.Name = "موردينToolStripMenuItem"
        Me.موردينToolStripMenuItem.Size = New System.Drawing.Size(67, 25)
        Me.موردينToolStripMenuItem.Text = "موردين"
        '
        'btnAddProduct
        '
        Me.btnAddProduct.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.اضافةمنتججديدToolStripMenuItem, Me.btnManageProduct})
        Me.btnAddProduct.Name = "btnAddProduct"
        Me.btnAddProduct.Size = New System.Drawing.Size(75, 25)
        Me.btnAddProduct.Text = "المنتجات"
        '
        'اضافةمنتججديدToolStripMenuItem
        '
        Me.اضافةمنتججديدToolStripMenuItem.Name = "اضافةمنتججديدToolStripMenuItem"
        Me.اضافةمنتججديدToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.اضافةمنتججديدToolStripMenuItem.Text = "اضافة منتج جديد"
        '
        'btnManageProduct
        '
        Me.btnManageProduct.Name = "btnManageProduct"
        Me.btnManageProduct.Size = New System.Drawing.Size(180, 26)
        Me.btnManageProduct.Text = "ادارة المنتجات"
        '
        'العملاءToolStripMenuItem
        '
        Me.العملاءToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnManageCustomers})
        Me.العملاءToolStripMenuItem.Name = "العملاءToolStripMenuItem"
        Me.العملاءToolStripMenuItem.Size = New System.Drawing.Size(63, 25)
        Me.العملاءToolStripMenuItem.Text = "العملاء"
        '
        'btnManageCustomers
        '
        Me.btnManageCustomers.Name = "btnManageCustomers"
        Me.btnManageCustomers.Size = New System.Drawing.Size(154, 26)
        Me.btnManageCustomers.Text = "ادارة العملاء"
        '
        'المبيعاتToolStripMenuItem
        '
        Me.المبيعاتToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnManageOrders, Me.btnSearchInOrders, Me.مبيعاتاليومToolStripMenuItem, Me.فلترةالمبيعاتToolStripMenuItem})
        Me.المبيعاتToolStripMenuItem.Name = "المبيعاتToolStripMenuItem"
        Me.المبيعاتToolStripMenuItem.Size = New System.Drawing.Size(72, 25)
        Me.المبيعاتToolStripMenuItem.Text = "المبيعات"
        '
        'btnManageOrders
        '
        Me.btnManageOrders.Name = "btnManageOrders"
        Me.btnManageOrders.Size = New System.Drawing.Size(207, 26)
        Me.btnManageOrders.Text = "ادارة المبيعات"
        '
        'btnSearchInOrders
        '
        Me.btnSearchInOrders.Name = "btnSearchInOrders"
        Me.btnSearchInOrders.Size = New System.Drawing.Size(207, 26)
        Me.btnSearchInOrders.Text = "البحث داخل المبيعات"
        '
        'مبيعاتاليومToolStripMenuItem
        '
        Me.مبيعاتاليومToolStripMenuItem.Name = "مبيعاتاليومToolStripMenuItem"
        Me.مبيعاتاليومToolStripMenuItem.Size = New System.Drawing.Size(207, 26)
        Me.مبيعاتاليومToolStripMenuItem.Text = "مبيعات اليوم"
        '
        'فلترةالمبيعاتToolStripMenuItem
        '
        Me.فلترةالمبيعاتToolStripMenuItem.Name = "فلترةالمبيعاتToolStripMenuItem"
        Me.فلترةالمبيعاتToolStripMenuItem.Size = New System.Drawing.Size(207, 26)
        Me.فلترةالمبيعاتToolStripMenuItem.Text = "فلترة المبيعات"
        '
        'مساعدةToolStripMenuItem
        '
        Me.مساعدةToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAbout})
        Me.مساعدةToolStripMenuItem.Name = "مساعدةToolStripMenuItem"
        Me.مساعدةToolStripMenuItem.Size = New System.Drawing.Size(64, 25)
        Me.مساعدةToolStripMenuItem.Text = "مساعدة"
        '
        'btnAbout
        '
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(161, 26)
        Me.btnAbout.Text = "حول البرنامج"
        '
        'المصروفاتToolStripMenuItem
        '
        Me.المصروفاتToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.اضافةمصاريفToolStripMenuItem, Me.تعديلالمصروفاتToolStripMenuItem})
        Me.المصروفاتToolStripMenuItem.Name = "المصروفاتToolStripMenuItem"
        Me.المصروفاتToolStripMenuItem.Size = New System.Drawing.Size(93, 25)
        Me.المصروفاتToolStripMenuItem.Text = "المصروفات"
        '
        'اضافةمصاريفToolStripMenuItem
        '
        Me.اضافةمصاريفToolStripMenuItem.Name = "اضافةمصاريفToolStripMenuItem"
        Me.اضافةمصاريفToolStripMenuItem.Size = New System.Drawing.Size(196, 26)
        Me.اضافةمصاريفToolStripMenuItem.Text = "اضافة مصاريف"
        '
        'تعديلالمصروفاتToolStripMenuItem
        '
        Me.تعديلالمصروفاتToolStripMenuItem.Name = "تعديلالمصروفاتToolStripMenuItem"
        Me.تعديلالمصروفاتToolStripMenuItem.Size = New System.Drawing.Size(196, 26)
        Me.تعديلالمصروفاتToolStripMenuItem.Text = "عرض المصروفات"
        '
        'المستخدمونToolStripMenuItem
        '
        Me.المستخدمونToolStripMenuItem.Name = "المستخدمونToolStripMenuItem"
        Me.المستخدمونToolStripMenuItem.Size = New System.Drawing.Size(93, 25)
        Me.المستخدمونToolStripMenuItem.Text = "المستخدمون"
        '
        'تسجيلالخروجToolStripMenuItem
        '
        Me.تسجيلالخروجToolStripMenuItem.Name = "تسجيلالخروجToolStripMenuItem"
        Me.تسجيلالخروجToolStripMenuItem.Size = New System.Drawing.Size(113, 25)
        Me.تسجيلالخروجToolStripMenuItem.Text = "تسجيل الخروج"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblComputer, Me.lblTime, Me.lblDate})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 512)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(995, 25)
        Me.StatusStrip1.TabIndex = 12
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblComputer
        '
        Me.lblComputer.Name = "lblComputer"
        Me.lblComputer.Size = New System.Drawing.Size(99, 20)
        Me.lblComputer.Text = "اسم الحاسوب:"
        '
        'lblTime
        '
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(95, 20)
        Me.lblTime.Text = "الوقت الحالي:"
        '
        'lblDate
        '
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(95, 20)
        Me.lblDate.Text = "التاريخ الحالي:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.ToolStrip1.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsproduct, Me.tsCustomers, Me.tsOrders, Me.ToolStripButton2, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 29)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(995, 39)
        Me.ToolStrip1.TabIndex = 13
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsproduct
        '
        Me.tsproduct.Image = CType(resources.GetObject("tsproduct.Image"), System.Drawing.Image)
        Me.tsproduct.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsproduct.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsproduct.Name = "tsproduct"
        Me.tsproduct.Size = New System.Drawing.Size(125, 36)
        Me.tsproduct.Text = "ادارة المنتجات"
        '
        'tsCustomers
        '
        Me.tsCustomers.Image = CType(resources.GetObject("tsCustomers.Image"), System.Drawing.Image)
        Me.tsCustomers.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsCustomers.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsCustomers.Name = "tsCustomers"
        Me.tsCustomers.Size = New System.Drawing.Size(114, 36)
        Me.tsCustomers.Text = "ادارة العملاء"
        '
        'tsOrders
        '
        Me.tsOrders.Image = CType(resources.GetObject("tsOrders.Image"), System.Drawing.Image)
        Me.tsOrders.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.tsOrders.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsOrders.Name = "tsOrders"
        Me.tsOrders.Size = New System.Drawing.Size(122, 36)
        Me.tsOrders.Text = "ادارة المبيعات"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(144, 36)
        Me.ToolStripButton2.Text = "المنتجات المتوفرة"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(127, 36)
        Me.ToolStripButton1.Text = "اغلاق البرنامج"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'frm_main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(995, 537)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Tahoma", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.MaximizeBox = False
        Me.Name = "frm_main"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "برنامج ادارة المبيعات"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ملفToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnAddProduct As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents اضافةمنتججديدToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnManageProduct As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents العملاءToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnManageCustomers As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents المبيعاتToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnManageOrders As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnSearchInOrders As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents مساعدةToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblComputer As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblDate As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents tsproduct As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsCustomers As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsOrders As System.Windows.Forms.ToolStripButton
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents المستخدمونToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents تسجيلالخروجToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents مشترياتToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents موردينToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents مبيعاتاليومToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents فلترةالمبيعاتToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents المصروفاتToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents اضافةمصاريفToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents تعديلالمصروفاتToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
