<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lst_Huyen2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Lst_Huyen2))
        Me.LstV_dm = New System.Windows.Forms.ListView
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.txtten = New System.Windows.Forms.TextBox
        Me.lab_tukhoa = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Lab_ThongBao = New System.Windows.Forms.Label
        Me.txtmatinh = New System.Windows.Forms.TextBox
        Me.lab_thongbao_en = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'LstV_dm
        '
        Me.LstV_dm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LstV_dm.Dock = System.Windows.Forms.DockStyle.Top
        Me.LstV_dm.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LstV_dm.FullRowSelect = True
        Me.LstV_dm.GridLines = True
        Me.LstV_dm.Location = New System.Drawing.Point(0, 0)
        Me.LstV_dm.Name = "LstV_dm"
        Me.LstV_dm.Size = New System.Drawing.Size(550, 372)
        Me.LstV_dm.SmallImageList = Me.ImageList1
        Me.LstV_dm.TabIndex = 3
        Me.LstV_dm.UseCompatibleStateImageBehavior = False
        Me.LstV_dm.View = System.Windows.Forms.View.Details
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "ksirtet.ico")
        '
        'txtten
        '
        Me.txtten.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtten.Location = New System.Drawing.Point(71, 376)
        Me.txtten.Name = "txtten"
        Me.txtten.Size = New System.Drawing.Size(479, 24)
        Me.txtten.TabIndex = 4
        '
        'lab_tukhoa
        '
        Me.lab_tukhoa.AutoSize = True
        Me.lab_tukhoa.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_tukhoa.ForeColor = System.Drawing.Color.Red
        Me.lab_tukhoa.Location = New System.Drawing.Point(8, 381)
        Me.lab_tukhoa.Name = "lab_tukhoa"
        Me.lab_tukhoa.Size = New System.Drawing.Size(57, 14)
        Me.lab_tukhoa.TabIndex = 5
        Me.lab_tukhoa.Text = "Từ khóa"
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'Lab_ThongBao
        '
        Me.Lab_ThongBao.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lab_ThongBao.ForeColor = System.Drawing.Color.Red
        Me.Lab_ThongBao.Location = New System.Drawing.Point(58, 130)
        Me.Lab_ThongBao.Name = "Lab_ThongBao"
        Me.Lab_ThongBao.Size = New System.Drawing.Size(434, 143)
        Me.Lab_ThongBao.TabIndex = 6
        Me.Lab_ThongBao.Text = "KHÔNG TÌM THẤY BẤT KỲ BẢN GHI NÀO THỎA MÃN ĐIỀU KIỆN" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Thử lại bằng cách gõ từ k" & _
            "hóa tìm kiếm vào ô bên dưới" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Bấm ESC để thoát khỏi danh mục)"
        Me.Lab_ThongBao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtmatinh
        '
        Me.txtmatinh.Font = New System.Drawing.Font("Verdana", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmatinh.Location = New System.Drawing.Point(10, 11)
        Me.txtmatinh.Name = "txtmatinh"
        Me.txtmatinh.Size = New System.Drawing.Size(41, 24)
        Me.txtmatinh.TabIndex = 7
        Me.txtmatinh.Visible = False
        '
        'lab_thongbao_en
        '
        Me.lab_thongbao_en.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_thongbao_en.ForeColor = System.Drawing.Color.Red
        Me.lab_thongbao_en.Location = New System.Drawing.Point(58, 130)
        Me.lab_thongbao_en.Name = "lab_thongbao_en"
        Me.lab_thongbao_en.Size = New System.Drawing.Size(434, 143)
        Me.lab_thongbao_en.TabIndex = 8
        Me.lab_thongbao_en.Text = "RECORD NOT FOUND" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Try again by entering keyword into below textbox" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Press ES" & _
            "C to exit)"
        Me.lab_thongbao_en.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lst_Huyen2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(550, 403)
        Me.Controls.Add(Me.lab_thongbao_en)
        Me.Controls.Add(Me.txtmatinh)
        Me.Controls.Add(Me.Lab_ThongBao)
        Me.Controls.Add(Me.lab_tukhoa)
        Me.Controls.Add(Me.txtten)
        Me.Controls.Add(Me.LstV_dm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Lst_Huyen2"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DANH MỤC (ESC - Thoát)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LstV_dm As System.Windows.Forms.ListView
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents txtten As System.Windows.Forms.TextBox
    Friend WithEvents lab_tukhoa As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Lab_ThongBao As System.Windows.Forms.Label
    Friend WithEvents txtmatinh As System.Windows.Forms.TextBox
    Friend WithEvents lab_thongbao_en As System.Windows.Forms.Label
End Class
