<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tientrinh2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tientrinh2))
        Me.ProgressBar_main = New System.Windows.Forms.ProgressBar
        Me.tieude = New System.Windows.Forms.Label
        Me.phantram_main = New System.Windows.Forms.Label
        Me.Img_Left_Top = New System.Windows.Forms.PictureBox
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.ProgressBar_client = New System.Windows.Forms.ProgressBar
        Me.phantram_client = New System.Windows.Forms.Label
        Me.tieude_main = New System.Windows.Forms.Label
        Me.tieude_client = New System.Windows.Forms.Label
        Me.txtdungluongfile = New System.Windows.Forms.Label
        CType(Me.Img_Left_Top, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgressBar_main
        '
        Me.ProgressBar_main.Location = New System.Drawing.Point(15, 127)
        Me.ProgressBar_main.Name = "ProgressBar_main"
        Me.ProgressBar_main.Size = New System.Drawing.Size(414, 16)
        Me.ProgressBar_main.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar_main.TabIndex = 0
        '
        'tieude
        '
        Me.tieude.AutoSize = True
        Me.tieude.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tieude.ForeColor = System.Drawing.Color.Red
        Me.tieude.Location = New System.Drawing.Point(15, 34)
        Me.tieude.Name = "tieude"
        Me.tieude.Size = New System.Drawing.Size(0, 14)
        Me.tieude.TabIndex = 1
        '
        'phantram_main
        '
        Me.phantram_main.AutoSize = True
        Me.phantram_main.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phantram_main.ForeColor = System.Drawing.Color.Red
        Me.phantram_main.Location = New System.Drawing.Point(434, 129)
        Me.phantram_main.Name = "phantram_main"
        Me.phantram_main.Size = New System.Drawing.Size(0, 14)
        Me.phantram_main.TabIndex = 2
        '
        'Img_Left_Top
        '
        Me.Img_Left_Top.Image = CType(resources.GetObject("Img_Left_Top.Image"), System.Drawing.Image)
        Me.Img_Left_Top.Location = New System.Drawing.Point(404, 22)
        Me.Img_Left_Top.Name = "Img_Left_Top"
        Me.Img_Left_Top.Size = New System.Drawing.Size(36, 34)
        Me.Img_Left_Top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Img_Left_Top.TabIndex = 3
        Me.Img_Left_Top.TabStop = False
        Me.ToolTip.SetToolTip(Me.Img_Left_Top, "Dời cửa sổ lên góc trên bên phải")
        '
        'ToolTip
        '
        Me.ToolTip.AutoPopDelay = 10000
        Me.ToolTip.InitialDelay = 500
        Me.ToolTip.ReshowDelay = 100
        Me.ToolTip.ShowAlways = True
        Me.ToolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip.ToolTipTitle = "Chức năng"
        '
        'ProgressBar_client
        '
        Me.ProgressBar_client.Location = New System.Drawing.Point(15, 80)
        Me.ProgressBar_client.Name = "ProgressBar_client"
        Me.ProgressBar_client.Size = New System.Drawing.Size(414, 16)
        Me.ProgressBar_client.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar_client.TabIndex = 7
        '
        'phantram_client
        '
        Me.phantram_client.AutoSize = True
        Me.phantram_client.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.phantram_client.ForeColor = System.Drawing.Color.Red
        Me.phantram_client.Location = New System.Drawing.Point(434, 80)
        Me.phantram_client.Name = "phantram_client"
        Me.phantram_client.Size = New System.Drawing.Size(0, 14)
        Me.phantram_client.TabIndex = 8
        '
        'tieude_main
        '
        Me.tieude_main.AutoSize = True
        Me.tieude_main.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tieude_main.ForeColor = System.Drawing.Color.Red
        Me.tieude_main.Location = New System.Drawing.Point(15, 156)
        Me.tieude_main.Name = "tieude_main"
        Me.tieude_main.Size = New System.Drawing.Size(0, 14)
        Me.tieude_main.TabIndex = 9
        '
        'tieude_client
        '
        Me.tieude_client.AutoSize = True
        Me.tieude_client.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tieude_client.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tieude_client.Location = New System.Drawing.Point(15, 62)
        Me.tieude_client.Name = "tieude_client"
        Me.tieude_client.Size = New System.Drawing.Size(0, 14)
        Me.tieude_client.TabIndex = 10
        '
        'txtdungluongfile
        '
        Me.txtdungluongfile.AutoSize = True
        Me.txtdungluongfile.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdungluongfile.ForeColor = System.Drawing.Color.Red
        Me.txtdungluongfile.Location = New System.Drawing.Point(199, 106)
        Me.txtdungluongfile.Name = "txtdungluongfile"
        Me.txtdungluongfile.Size = New System.Drawing.Size(0, 14)
        Me.txtdungluongfile.TabIndex = 11
        '
        'Tientrinh2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(490, 180)
        Me.Controls.Add(Me.txtdungluongfile)
        Me.Controls.Add(Me.tieude_client)
        Me.Controls.Add(Me.tieude_main)
        Me.Controls.Add(Me.phantram_client)
        Me.Controls.Add(Me.ProgressBar_client)
        Me.Controls.Add(Me.Img_Left_Top)
        Me.Controls.Add(Me.phantram_main)
        Me.Controls.Add(Me.tieude)
        Me.Controls.Add(Me.ProgressBar_main)
        Me.Cursor = System.Windows.Forms.Cursors.AppStarting
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Tientrinh2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TIẾN TRÌNH"
        Me.TopMost = True
        CType(Me.Img_Left_Top, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProgressBar_main As System.Windows.Forms.ProgressBar
    Friend WithEvents tieude As System.Windows.Forms.Label
    Friend WithEvents phantram_main As System.Windows.Forms.Label
    Friend WithEvents Img_Left_Top As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ProgressBar_client As System.Windows.Forms.ProgressBar
    Friend WithEvents phantram_client As System.Windows.Forms.Label
    Friend WithEvents tieude_main As System.Windows.Forms.Label
    Friend WithEvents tieude_client As System.Windows.Forms.Label
    Friend WithEvents txtdungluongfile As System.Windows.Forms.Label
End Class
