<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MapPreview
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
        Me.Group_Map = New System.Windows.Forms.GroupBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.WebBrowser = New System.Windows.Forms.WebBrowser
        Me.txtphantram = New System.Windows.Forms.Label
        Me.Group_Map.SuspendLayout()
        Me.SuspendLayout()
        '
        'Group_Map
        '
        Me.Group_Map.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Group_Map.Controls.Add(Me.TextBox1)
        Me.Group_Map.Controls.Add(Me.WebBrowser)
        Me.Group_Map.Controls.Add(Me.txtphantram)
        Me.Group_Map.Location = New System.Drawing.Point(12, 12)
        Me.Group_Map.Name = "Group_Map"
        Me.Group_Map.Size = New System.Drawing.Size(725, 461)
        Me.Group_Map.TabIndex = 53
        Me.Group_Map.TabStop = False
        Me.Group_Map.Text = "Bản đồ"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(17, 137)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(361, 23)
        Me.TextBox1.TabIndex = 54
        Me.TextBox1.Visible = False
        '
        'WebBrowser
        '
        Me.WebBrowser.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.WebBrowser.Location = New System.Drawing.Point(6, 22)
        Me.WebBrowser.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser.Name = "WebBrowser"
        Me.WebBrowser.Size = New System.Drawing.Size(713, 433)
        Me.WebBrowser.TabIndex = 52
        '
        'txtphantram
        '
        Me.txtphantram.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtphantram.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtphantram.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtphantram.Location = New System.Drawing.Point(107, 390)
        Me.txtphantram.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtphantram.Name = "txtphantram"
        Me.txtphantram.Size = New System.Drawing.Size(451, 37)
        Me.txtphantram.TabIndex = 51
        Me.txtphantram.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MapPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 485)
        Me.Controls.Add(Me.Group_Map)
        Me.Name = "MapPreview"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MapPreview"
        Me.Group_Map.ResumeLayout(False)
        Me.Group_Map.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Group_Map As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents WebBrowser As System.Windows.Forms.WebBrowser
    Friend WithEvents txtphantram As System.Windows.Forms.Label
End Class
