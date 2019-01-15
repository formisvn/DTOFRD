<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class XacThucEmail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(XacThucEmail))
        Me.lab_thongbao = New System.Windows.Forms.Label
        Me.txtmaso = New System.Windows.Forms.MaskedTextBox
        Me.cmdChapnhan = New System.Windows.Forms.Button
        Me.txtms = New System.Windows.Forms.Label
        Me.txtngayxacthuc = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lab_thongbao
        '
        Me.lab_thongbao.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_thongbao.Location = New System.Drawing.Point(22, 9)
        Me.lab_thongbao.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lab_thongbao.Name = "lab_thongbao"
        Me.lab_thongbao.Size = New System.Drawing.Size(367, 72)
        Me.lab_thongbao.TabIndex = 23
        Me.lab_thongbao.Text = "Một mã xác thực Email đã được gửi về email, vui lòng kiểm tra email và nhập mã xá" & _
            "c thực vào ô bên dưới."
        '
        'txtmaso
        '
        Me.txtmaso.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmaso.Location = New System.Drawing.Point(98, 84)
        Me.txtmaso.Mask = "99999"
        Me.txtmaso.Name = "txtmaso"
        Me.txtmaso.Size = New System.Drawing.Size(206, 40)
        Me.txtmaso.TabIndex = 24
        Me.txtmaso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdChapnhan
        '
        Me.cmdChapnhan.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdChapnhan.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdChapnhan.Image = CType(resources.GetObject("cmdChapnhan.Image"), System.Drawing.Image)
        Me.cmdChapnhan.Location = New System.Drawing.Point(98, 134)
        Me.cmdChapnhan.Name = "cmdChapnhan"
        Me.cmdChapnhan.Size = New System.Drawing.Size(206, 41)
        Me.cmdChapnhan.TabIndex = 25
        Me.cmdChapnhan.Text = "Xác thực"
        Me.cmdChapnhan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdChapnhan.UseVisualStyleBackColor = True
        '
        'txtms
        '
        Me.txtms.AutoSize = True
        Me.txtms.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtms.Location = New System.Drawing.Point(17, 53)
        Me.txtms.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtms.Name = "txtms"
        Me.txtms.Size = New System.Drawing.Size(0, 16)
        Me.txtms.TabIndex = 26
        Me.txtms.Visible = False
        '
        'txtngayxacthuc
        '
        Me.txtngayxacthuc.AutoSize = True
        Me.txtngayxacthuc.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtngayxacthuc.Location = New System.Drawing.Point(36, 86)
        Me.txtngayxacthuc.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txtngayxacthuc.Name = "txtngayxacthuc"
        Me.txtngayxacthuc.Size = New System.Drawing.Size(0, 16)
        Me.txtngayxacthuc.TabIndex = 27
        Me.txtngayxacthuc.Visible = False
        '
        'XacThucEmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(400, 188)
        Me.Controls.Add(Me.txtngayxacthuc)
        Me.Controls.Add(Me.txtms)
        Me.Controls.Add(Me.cmdChapnhan)
        Me.Controls.Add(Me.txtmaso)
        Me.Controls.Add(Me.lab_thongbao)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "XacThucEmail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Xác thực Email"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lab_thongbao As System.Windows.Forms.Label
    Friend WithEvents txtmaso As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmdChapnhan As System.Windows.Forms.Button
    Friend WithEvents txtms As System.Windows.Forms.Label
    Friend WithEvents txtngayxacthuc As System.Windows.Forms.Label
End Class
