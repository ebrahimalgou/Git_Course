<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class filtermasrof
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
        Me.dgvCostemrs = New System.Windows.Forms.DataGridView()
        CType(Me.dgvCostemrs, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCostemrs
        '
        Me.dgvCostemrs.AllowUserToAddRows = False
        Me.dgvCostemrs.AllowUserToDeleteRows = False
        Me.dgvCostemrs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvCostemrs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCostemrs.Location = New System.Drawing.Point(3, 1)
        Me.dgvCostemrs.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.dgvCostemrs.Name = "dgvCostemrs"
        Me.dgvCostemrs.ReadOnly = True
        Me.dgvCostemrs.RowTemplate.Height = 26
        Me.dgvCostemrs.Size = New System.Drawing.Size(620, 383)
        Me.dgvCostemrs.TabIndex = 2
        '
        'filtermasrof
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 384)
        Me.Controls.Add(Me.dgvCostemrs)
        Me.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5, 4, 5, 4)
        Me.Name = "filtermasrof"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ادارة المصاريف"
        CType(Me.dgvCostemrs, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvCostemrs As System.Windows.Forms.DataGridView
End Class
