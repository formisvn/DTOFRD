<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Wait
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
        Me.lab_thongbao = New System.Windows.Forms.Label
        Me.ProgressBar = New System.Windows.Forms.ProgressBar
        Me.SuspendLayout()
        '
        'lab_thongbao
        '
        Me.lab_thongbao.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_thongbao.Location = New System.Drawing.Point(11, 9)
        Me.lab_thongbao.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lab_thongbao.Name = "lab_thongbao"
        Me.lab_thongbao.Size = New System.Drawing.Size(290, 76)
        Me.lab_thongbao.TabIndex = 24
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(14, 100)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(275, 23)
        Me.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar.TabIndex = 25
        Me.ProgressBar.UseWaitCursor = True
        '
        'Wait
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(312, 133)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.lab_thongbao)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Wait"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cửa sổ chờ"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lab_thongbao As System.Windows.Forms.Label
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar
End Class
