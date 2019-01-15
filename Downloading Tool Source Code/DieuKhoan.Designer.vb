<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DieuKhoan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DieuKhoan))
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.Group_banquyen_vi = New System.Windows.Forms.GroupBox
        Me.txtdieukhoan = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.CmdNext2 = New DevComponents.DotNetBar.ButtonX
        Me.chk_dongy = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.Group_Banquyen_en = New System.Windows.Forms.GroupBox
        Me.TextBoxX1 = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.Group_banquyen_vi.SuspendLayout()
        Me.Group_Banquyen_en.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Group_banquyen_vi
        '
        Me.Group_banquyen_vi.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Group_banquyen_vi.Controls.Add(Me.txtdieukhoan)
        Me.Group_banquyen_vi.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Group_banquyen_vi.Location = New System.Drawing.Point(10, 12)
        Me.Group_banquyen_vi.Name = "Group_banquyen_vi"
        Me.Group_banquyen_vi.Size = New System.Drawing.Size(784, 441)
        Me.Group_banquyen_vi.TabIndex = 4
        Me.Group_banquyen_vi.TabStop = False
        Me.Group_banquyen_vi.Text = "Đọc các điều khoản về bản quyền của dữ liệu"
        Me.Group_banquyen_vi.Visible = False
        '
        'txtdieukhoan
        '
        Me.txtdieukhoan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.txtdieukhoan.Border.Class = "TextBoxBorder"
        Me.txtdieukhoan.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtdieukhoan.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdieukhoan.Location = New System.Drawing.Point(6, 21)
        Me.txtdieukhoan.Multiline = True
        Me.txtdieukhoan.Name = "txtdieukhoan"
        Me.txtdieukhoan.ReadOnly = True
        Me.txtdieukhoan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtdieukhoan.Size = New System.Drawing.Size(772, 413)
        Me.txtdieukhoan.TabIndex = 1
        Me.txtdieukhoan.Text = resources.GetString("txtdieukhoan.Text")
        '
        'CmdNext2
        '
        Me.CmdNext2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.CmdNext2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdNext2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.CmdNext2.Enabled = False
        Me.CmdNext2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdNext2.Image = CType(resources.GetObject("CmdNext2.Image"), System.Drawing.Image)
        Me.CmdNext2.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.CmdNext2.Location = New System.Drawing.Point(684, 458)
        Me.CmdNext2.Name = "CmdNext2"
        Me.CmdNext2.Size = New System.Drawing.Size(104, 38)
        Me.CmdNext2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CmdNext2.TabIndex = 0
        Me.CmdNext2.Text = "&Tiếp tục"
        '
        'chk_dongy
        '
        Me.chk_dongy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chk_dongy.AutoSize = True
        '
        '
        '
        Me.chk_dongy.BackgroundStyle.Class = ""
        Me.chk_dongy.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chk_dongy.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_dongy.Location = New System.Drawing.Point(291, 469)
        Me.chk_dongy.Name = "chk_dongy"
        Me.chk_dongy.Size = New System.Drawing.Size(375, 18)
        Me.chk_dongy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chk_dongy.TabIndex = 0
        Me.chk_dongy.Text = "Tôi đã đọc và đồng ý với các điều khoản về bản quyền ở trên"
        '
        'Group_Banquyen_en
        '
        Me.Group_Banquyen_en.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Group_Banquyen_en.Controls.Add(Me.TextBoxX1)
        Me.Group_Banquyen_en.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Group_Banquyen_en.Location = New System.Drawing.Point(12, 11)
        Me.Group_Banquyen_en.Name = "Group_Banquyen_en"
        Me.Group_Banquyen_en.Size = New System.Drawing.Size(784, 441)
        Me.Group_Banquyen_en.TabIndex = 5
        Me.Group_Banquyen_en.TabStop = False
        Me.Group_Banquyen_en.Text = "Data License Agreement"
        Me.Group_Banquyen_en.Visible = False
        '
        'TextBoxX1
        '
        Me.TextBoxX1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        '
        '
        '
        Me.TextBoxX1.Border.Class = "TextBoxBorder"
        Me.TextBoxX1.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.TextBoxX1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxX1.Location = New System.Drawing.Point(6, 22)
        Me.TextBoxX1.Multiline = True
        Me.TextBoxX1.Name = "TextBoxX1"
        Me.TextBoxX1.ReadOnly = True
        Me.TextBoxX1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBoxX1.Size = New System.Drawing.Size(772, 413)
        Me.TextBoxX1.TabIndex = 1
        Me.TextBoxX1.Text = resources.GetString("TextBoxX1.Text")
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(10, 452)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(57, 44)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 55
        Me.PictureBox2.TabStop = False
        '
        'DieuKhoan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 499)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.CmdNext2)
        Me.Controls.Add(Me.chk_dongy)
        Me.Controls.Add(Me.Group_Banquyen_en)
        Me.Controls.Add(Me.Group_banquyen_vi)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "DieuKhoan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CÔNG CỤ TẢI DỬ LIỆU TẢI NGUYÊN RỪNG"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Group_banquyen_vi.ResumeLayout(False)
        Me.Group_Banquyen_en.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Group_banquyen_vi As System.Windows.Forms.GroupBox
    Friend WithEvents CmdNext2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtdieukhoan As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents chk_dongy As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents Group_Banquyen_en As System.Windows.Forms.GroupBox
    Friend WithEvents TextBoxX1 As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox

End Class
