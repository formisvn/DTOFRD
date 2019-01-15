<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Splash
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Splash))
        Me.Picture_vi = New System.Windows.Forms.PictureBox
        Me.lab_phienban = New System.Windows.Forms.Label
        CType(Me.Picture_vi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Picture_vi
        '
        Me.Picture_vi.Image = CType(resources.GetObject("Picture_vi.Image"), System.Drawing.Image)
        Me.Picture_vi.Location = New System.Drawing.Point(1, 0)
        Me.Picture_vi.Name = "Picture_vi"
        Me.Picture_vi.Size = New System.Drawing.Size(457, 320)
        Me.Picture_vi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.Picture_vi.TabIndex = 0
        Me.Picture_vi.TabStop = False
        '
        'lab_phienban
        '
        Me.lab_phienban.BackColor = System.Drawing.Color.Transparent
        Me.lab_phienban.Location = New System.Drawing.Point(343, 287)
        Me.lab_phienban.Name = "lab_phienban"
        Me.lab_phienban.Size = New System.Drawing.Size(100, 21)
        Me.lab_phienban.TabIndex = 1
        Me.lab_phienban.Text = "Phiên bản: 1.0.2"
        Me.lab_phienban.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Splash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(455, 317)
        Me.Controls.Add(Me.lab_phienban)
        Me.Controls.Add(Me.Picture_vi)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Splash"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Splash"
        CType(Me.Picture_vi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Picture_vi As System.Windows.Forms.PictureBox
    Friend WithEvents lab_phienban As System.Windows.Forms.Label
End Class
