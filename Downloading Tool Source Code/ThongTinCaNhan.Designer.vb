<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ThongTinCaNhan
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ThongTinCaNhan))
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.Group_1 = New System.Windows.Forms.GroupBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.CmdNapthongtin = New DevComponents.DotNetBar.ButtonX
        Me.cmdLuuThongTin = New DevComponents.DotNetBar.ButtonX
        Me.Label18 = New System.Windows.Forms.Label
        Me.lab_redpoint = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtdiachi = New System.Windows.Forms.TextBox
        Me.lab_diachi = New System.Windows.Forms.Label
        Me.txtnoicap = New System.Windows.Forms.TextBox
        Me.lab_noicap = New System.Windows.Forms.Label
        Me.lab_ngaycap = New System.Windows.Forms.Label
        Me.txtcmnd = New System.Windows.Forms.TextBox
        Me.lab_cmnd = New System.Windows.Forms.Label
        Me.CmdNext1 = New DevComponents.DotNetBar.ButtonX
        Me.txtmucdich = New System.Windows.Forms.TextBox
        Me.lab_mucdich = New System.Windows.Forms.Label
        Me.txtgioitinh = New System.Windows.Forms.ComboBox
        Me.lab_gioitinh = New System.Windows.Forms.Label
        Me.txttochuc = New System.Windows.Forms.ComboBox
        Me.txtemail = New System.Windows.Forms.TextBox
        Me.lab_email = New System.Windows.Forms.Label
        Me.txthoten = New System.Windows.Forms.TextBox
        Me.lab_tochuc = New System.Windows.Forms.Label
        Me.txtdienthoai = New System.Windows.Forms.TextBox
        Me.lab_dienthoai = New System.Windows.Forms.Label
        Me.lab_hoten = New System.Windows.Forms.Label
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.mnu_capnhat = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_capnhat_hanhchinh = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_phienban = New System.Windows.Forms.ToolStripMenuItem
        Me.language = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_EngLish = New System.Windows.Forms.ToolStripMenuItem
        Me.mnu_Vietnamese = New System.Windows.Forms.ToolStripMenuItem
        Me.Timer_danhmuctruong = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_datasharing = New System.Windows.Forms.Timer(Me.components)
        Me.Timer_tinh = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.txtngaycap = New DevComponents.Editors.DateTimeAdv.DateTimeInput
        Me.Group_1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.txtngaycap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Group_1
        '
        Me.Group_1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Group_1.Controls.Add(Me.txtngaycap)
        Me.Group_1.Controls.Add(Me.PictureBox2)
        Me.Group_1.Controls.Add(Me.CmdNapthongtin)
        Me.Group_1.Controls.Add(Me.cmdLuuThongTin)
        Me.Group_1.Controls.Add(Me.Label18)
        Me.Group_1.Controls.Add(Me.lab_redpoint)
        Me.Group_1.Controls.Add(Me.Label16)
        Me.Group_1.Controls.Add(Me.Label15)
        Me.Group_1.Controls.Add(Me.Label14)
        Me.Group_1.Controls.Add(Me.Label13)
        Me.Group_1.Controls.Add(Me.Label12)
        Me.Group_1.Controls.Add(Me.Label11)
        Me.Group_1.Controls.Add(Me.txtdiachi)
        Me.Group_1.Controls.Add(Me.lab_diachi)
        Me.Group_1.Controls.Add(Me.txtnoicap)
        Me.Group_1.Controls.Add(Me.lab_noicap)
        Me.Group_1.Controls.Add(Me.lab_ngaycap)
        Me.Group_1.Controls.Add(Me.txtcmnd)
        Me.Group_1.Controls.Add(Me.lab_cmnd)
        Me.Group_1.Controls.Add(Me.CmdNext1)
        Me.Group_1.Controls.Add(Me.txtmucdich)
        Me.Group_1.Controls.Add(Me.lab_mucdich)
        Me.Group_1.Controls.Add(Me.txtgioitinh)
        Me.Group_1.Controls.Add(Me.lab_gioitinh)
        Me.Group_1.Controls.Add(Me.txttochuc)
        Me.Group_1.Controls.Add(Me.txtemail)
        Me.Group_1.Controls.Add(Me.lab_email)
        Me.Group_1.Controls.Add(Me.txthoten)
        Me.Group_1.Controls.Add(Me.lab_tochuc)
        Me.Group_1.Controls.Add(Me.txtdienthoai)
        Me.Group_1.Controls.Add(Me.lab_dienthoai)
        Me.Group_1.Controls.Add(Me.lab_hoten)
        Me.Group_1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Group_1.ForeColor = System.Drawing.Color.Black
        Me.Group_1.Location = New System.Drawing.Point(12, 33)
        Me.Group_1.Name = "Group_1"
        Me.Group_1.Size = New System.Drawing.Size(782, 454)
        Me.Group_1.TabIndex = 0
        Me.Group_1.TabStop = False
        Me.Group_1.Text = "NHẬP THÔNG TIN CÁ NHÂN/TỔ CHỨC CẦN TẢI DỮ LIỆU"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(135, 405)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(50, 46)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 59
        Me.PictureBox2.TabStop = False
        '
        'CmdNapthongtin
        '
        Me.CmdNapthongtin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.CmdNapthongtin.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.CmdNapthongtin.Image = CType(resources.GetObject("CmdNapthongtin.Image"), System.Drawing.Image)
        Me.CmdNapthongtin.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.CmdNapthongtin.Location = New System.Drawing.Point(611, 203)
        Me.CmdNapthongtin.Name = "CmdNapthongtin"
        Me.CmdNapthongtin.Size = New System.Drawing.Size(145, 33)
        Me.CmdNapthongtin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CmdNapthongtin.TabIndex = 57
        Me.CmdNapthongtin.Text = "&Nạp thông tin"
        '
        'cmdLuuThongTin
        '
        Me.cmdLuuThongTin.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdLuuThongTin.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdLuuThongTin.Image = CType(resources.GetObject("cmdLuuThongTin.Image"), System.Drawing.Image)
        Me.cmdLuuThongTin.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.cmdLuuThongTin.Location = New System.Drawing.Point(464, 203)
        Me.cmdLuuThongTin.Name = "cmdLuuThongTin"
        Me.cmdLuuThongTin.Size = New System.Drawing.Size(145, 33)
        Me.cmdLuuThongTin.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmdLuuThongTin.TabIndex = 56
        Me.cmdLuuThongTin.Text = "&Lưu thông tin"
        '
        'Label18
        '
        Me.Label18.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(436, 426)
        Me.Label18.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(18, 19)
        Me.Label18.TabIndex = 55
        Me.Label18.Text = "*"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lab_redpoint
        '
        Me.lab_redpoint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lab_redpoint.AutoSize = True
        Me.lab_redpoint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_redpoint.ForeColor = System.Drawing.Color.Navy
        Me.lab_redpoint.Location = New System.Drawing.Point(279, 423)
        Me.lab_redpoint.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lab_redpoint.Name = "lab_redpoint"
        Me.lab_redpoint.Size = New System.Drawing.Size(247, 16)
        Me.lab_redpoint.TabIndex = 54
        Me.lab_redpoint.Text = "Các trường được đánh dấu      là bắt buộc"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.BackColor = System.Drawing.Color.Transparent
        Me.Label16.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(111, 248)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(18, 19)
        Me.Label16.TabIndex = 53
        Me.Label16.Text = "*"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(111, 217)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(18, 19)
        Me.Label15.TabIndex = 52
        Me.Label15.Text = "*"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(111, 127)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(18, 19)
        Me.Label14.TabIndex = 51
        Me.Label14.Text = "*"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(111, 95)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(18, 19)
        Me.Label13.TabIndex = 50
        Me.Label13.Text = "*"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(111, 68)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(18, 19)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "*"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(111, 39)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(18, 19)
        Me.Label11.TabIndex = 48
        Me.Label11.Text = "*"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtdiachi
        '
        Me.txtdiachi.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdiachi.Location = New System.Drawing.Point(135, 154)
        Me.txtdiachi.Margin = New System.Windows.Forms.Padding(2)
        Me.txtdiachi.MaxLength = 200
        Me.txtdiachi.Name = "txtdiachi"
        Me.txtdiachi.Size = New System.Drawing.Size(621, 23)
        Me.txtdiachi.TabIndex = 6
        '
        'lab_diachi
        '
        Me.lab_diachi.AutoSize = True
        Me.lab_diachi.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_diachi.ForeColor = System.Drawing.Color.Navy
        Me.lab_diachi.Location = New System.Drawing.Point(15, 157)
        Me.lab_diachi.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lab_diachi.Name = "lab_diachi"
        Me.lab_diachi.Size = New System.Drawing.Size(47, 16)
        Me.lab_diachi.TabIndex = 44
        Me.lab_diachi.Text = "Địa chỉ"
        '
        'txtnoicap
        '
        Me.txtnoicap.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtnoicap.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnoicap.Location = New System.Drawing.Point(574, 64)
        Me.txtnoicap.Margin = New System.Windows.Forms.Padding(2)
        Me.txtnoicap.MaxLength = 30
        Me.txtnoicap.Name = "txtnoicap"
        Me.txtnoicap.Size = New System.Drawing.Size(182, 23)
        Me.txtnoicap.TabIndex = 3
        '
        'lab_noicap
        '
        Me.lab_noicap.AutoSize = True
        Me.lab_noicap.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_noicap.ForeColor = System.Drawing.Color.Navy
        Me.lab_noicap.Location = New System.Drawing.Point(484, 67)
        Me.lab_noicap.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lab_noicap.Name = "lab_noicap"
        Me.lab_noicap.Size = New System.Drawing.Size(50, 16)
        Me.lab_noicap.TabIndex = 42
        Me.lab_noicap.Text = "Nơi cấp"
        '
        'lab_ngaycap
        '
        Me.lab_ngaycap.AutoSize = True
        Me.lab_ngaycap.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_ngaycap.ForeColor = System.Drawing.Color.Navy
        Me.lab_ngaycap.Location = New System.Drawing.Point(268, 67)
        Me.lab_ngaycap.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lab_ngaycap.Name = "lab_ngaycap"
        Me.lab_ngaycap.Size = New System.Drawing.Size(60, 16)
        Me.lab_ngaycap.TabIndex = 39
        Me.lab_ngaycap.Text = "Ngày cấp"
        '
        'txtcmnd
        '
        Me.txtcmnd.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcmnd.Location = New System.Drawing.Point(135, 64)
        Me.txtcmnd.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcmnd.MaxLength = 20
        Me.txtcmnd.Name = "txtcmnd"
        Me.txtcmnd.Size = New System.Drawing.Size(129, 23)
        Me.txtcmnd.TabIndex = 1
        '
        'lab_cmnd
        '
        Me.lab_cmnd.AutoSize = True
        Me.lab_cmnd.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_cmnd.ForeColor = System.Drawing.Color.Navy
        Me.lab_cmnd.Location = New System.Drawing.Point(15, 67)
        Me.lab_cmnd.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lab_cmnd.Name = "lab_cmnd"
        Me.lab_cmnd.Size = New System.Drawing.Size(61, 16)
        Me.lab_cmnd.TabIndex = 38
        Me.lab_cmnd.Text = "Số CMND"
        '
        'CmdNext1
        '
        Me.CmdNext1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.CmdNext1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdNext1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.CmdNext1.Image = CType(resources.GetObject("CmdNext1.Image"), System.Drawing.Image)
        Me.CmdNext1.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.CmdNext1.Location = New System.Drawing.Point(619, 410)
        Me.CmdNext1.Name = "CmdNext1"
        Me.CmdNext1.Size = New System.Drawing.Size(137, 38)
        Me.CmdNext1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CmdNext1.TabIndex = 10
        Me.CmdNext1.Text = "&Chấp nhận"
        '
        'txtmucdich
        '
        Me.txtmucdich.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmucdich.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmucdich.Location = New System.Drawing.Point(135, 244)
        Me.txtmucdich.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmucdich.MaxLength = 500
        Me.txtmucdich.Multiline = True
        Me.txtmucdich.Name = "txtmucdich"
        Me.txtmucdich.Size = New System.Drawing.Size(621, 160)
        Me.txtmucdich.TabIndex = 9
        '
        'lab_mucdich
        '
        Me.lab_mucdich.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_mucdich.ForeColor = System.Drawing.Color.Navy
        Me.lab_mucdich.Location = New System.Drawing.Point(15, 245)
        Me.lab_mucdich.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lab_mucdich.Name = "lab_mucdich"
        Me.lab_mucdich.Size = New System.Drawing.Size(98, 101)
        Me.lab_mucdich.TabIndex = 36
        Me.lab_mucdich.Text = "Mục đích sử dụng dữ liệu"
        '
        'txtgioitinh
        '
        Me.txtgioitinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtgioitinh.FormattingEnabled = True
        Me.txtgioitinh.Items.AddRange(New Object() {"Nam", "Nữ", "Không xác định"})
        Me.txtgioitinh.Location = New System.Drawing.Point(135, 92)
        Me.txtgioitinh.Name = "txtgioitinh"
        Me.txtgioitinh.Size = New System.Drawing.Size(93, 24)
        Me.txtgioitinh.TabIndex = 4
        '
        'lab_gioitinh
        '
        Me.lab_gioitinh.AutoSize = True
        Me.lab_gioitinh.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_gioitinh.ForeColor = System.Drawing.Color.Navy
        Me.lab_gioitinh.Location = New System.Drawing.Point(15, 95)
        Me.lab_gioitinh.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lab_gioitinh.Name = "lab_gioitinh"
        Me.lab_gioitinh.Size = New System.Drawing.Size(54, 16)
        Me.lab_gioitinh.TabIndex = 33
        Me.lab_gioitinh.Text = "Giới tính"
        '
        'txttochuc
        '
        Me.txttochuc.FormattingEnabled = True
        Me.txttochuc.Items.AddRange(New Object() {"Cục kiểm lâm", "Các cơ quan lâm nghiệp nhà nước (Vụ, các Vụ trực thuộc Tổng cục lâm nghiệp, Sở NN" & _
                        "&PTNT)", "Chi cục Kiểm lâm vùng (4 vùng)", "Chi cục Kiểm lâm tỉnh và Hạt Kiểm lâm huyện", "Các Trường đại học, Viện nghiên cứu", "Các dự án trực thuộc Bộ NN&PTNT/TCLN và các Bộ khác", "Các đơn vị, tổ chức khác: các tổ chức Chính phủ nước ngoài, các dự án phi Chính p" & _
                        "hủ", "Khác"})
        Me.txttochuc.Location = New System.Drawing.Point(135, 122)
        Me.txttochuc.Name = "txttochuc"
        Me.txttochuc.Size = New System.Drawing.Size(621, 24)
        Me.txttochuc.TabIndex = 5
        '
        'txtemail
        '
        Me.txtemail.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(135, 213)
        Me.txtemail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtemail.MaxLength = 100
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(311, 23)
        Me.txtemail.TabIndex = 8
        '
        'lab_email
        '
        Me.lab_email.AutoSize = True
        Me.lab_email.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_email.ForeColor = System.Drawing.Color.Navy
        Me.lab_email.Location = New System.Drawing.Point(15, 217)
        Me.lab_email.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lab_email.Name = "lab_email"
        Me.lab_email.Size = New System.Drawing.Size(39, 16)
        Me.lab_email.TabIndex = 31
        Me.lab_email.Text = "Email"
        '
        'txthoten
        '
        Me.txthoten.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthoten.Location = New System.Drawing.Point(135, 35)
        Me.txthoten.Margin = New System.Windows.Forms.Padding(2)
        Me.txthoten.MaxLength = 50
        Me.txthoten.Name = "txthoten"
        Me.txthoten.Size = New System.Drawing.Size(326, 23)
        Me.txthoten.TabIndex = 0
        '
        'lab_tochuc
        '
        Me.lab_tochuc.AutoSize = True
        Me.lab_tochuc.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_tochuc.ForeColor = System.Drawing.Color.Navy
        Me.lab_tochuc.Location = New System.Drawing.Point(15, 125)
        Me.lab_tochuc.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lab_tochuc.Name = "lab_tochuc"
        Me.lab_tochuc.Size = New System.Drawing.Size(54, 16)
        Me.lab_tochuc.TabIndex = 27
        Me.lab_tochuc.Text = "Tổ chức"
        '
        'txtdienthoai
        '
        Me.txtdienthoai.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdienthoai.Location = New System.Drawing.Point(135, 183)
        Me.txtdienthoai.Margin = New System.Windows.Forms.Padding(2)
        Me.txtdienthoai.MaxLength = 20
        Me.txtdienthoai.Name = "txtdienthoai"
        Me.txtdienthoai.Size = New System.Drawing.Size(311, 23)
        Me.txtdienthoai.TabIndex = 7
        '
        'lab_dienthoai
        '
        Me.lab_dienthoai.AutoSize = True
        Me.lab_dienthoai.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_dienthoai.ForeColor = System.Drawing.Color.Navy
        Me.lab_dienthoai.Location = New System.Drawing.Point(15, 187)
        Me.lab_dienthoai.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lab_dienthoai.Name = "lab_dienthoai"
        Me.lab_dienthoai.Size = New System.Drawing.Size(66, 16)
        Me.lab_dienthoai.TabIndex = 29
        Me.lab_dienthoai.Text = "Điện thoại"
        '
        'lab_hoten
        '
        Me.lab_hoten.AutoSize = True
        Me.lab_hoten.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_hoten.ForeColor = System.Drawing.Color.Navy
        Me.lab_hoten.Location = New System.Drawing.Point(15, 36)
        Me.lab_hoten.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lab_hoten.Name = "lab_hoten"
        Me.lab_hoten.Size = New System.Drawing.Size(45, 16)
        Me.lab_hoten.TabIndex = 28
        Me.lab_hoten.Text = "Họ tên"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_capnhat, Me.language})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(806, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnu_capnhat
        '
        Me.mnu_capnhat.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_capnhat_hanhchinh, Me.mnu_phienban})
        Me.mnu_capnhat.Name = "mnu_capnhat"
        Me.mnu_capnhat.Size = New System.Drawing.Size(67, 20)
        Me.mnu_capnhat.Text = "Cập nhật"
        '
        'mnu_capnhat_hanhchinh
        '
        Me.mnu_capnhat_hanhchinh.Image = CType(resources.GetObject("mnu_capnhat_hanhchinh.Image"), System.Drawing.Image)
        Me.mnu_capnhat_hanhchinh.Name = "mnu_capnhat_hanhchinh"
        Me.mnu_capnhat_hanhchinh.Size = New System.Drawing.Size(291, 22)
        Me.mnu_capnhat_hanhchinh.Text = "Cập nhật thông tin hành chính và dữ liệu"
        '
        'mnu_phienban
        '
        Me.mnu_phienban.Image = CType(resources.GetObject("mnu_phienban.Image"), System.Drawing.Image)
        Me.mnu_phienban.Name = "mnu_phienban"
        Me.mnu_phienban.Size = New System.Drawing.Size(291, 22)
        Me.mnu_phienban.Text = "Phiên bản"
        '
        'language
        '
        Me.language.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_EngLish, Me.mnu_Vietnamese})
        Me.language.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.language.ForeColor = System.Drawing.Color.Blue
        Me.language.Name = "language"
        Me.language.Size = New System.Drawing.Size(83, 20)
        Me.language.Text = "LANGUAGE"
        '
        'mnu_EngLish
        '
        Me.mnu_EngLish.Image = CType(resources.GetObject("mnu_EngLish.Image"), System.Drawing.Image)
        Me.mnu_EngLish.Name = "mnu_EngLish"
        Me.mnu_EngLish.Size = New System.Drawing.Size(152, 22)
        Me.mnu_EngLish.Text = "English"
        '
        'mnu_Vietnamese
        '
        Me.mnu_Vietnamese.Image = CType(resources.GetObject("mnu_Vietnamese.Image"), System.Drawing.Image)
        Me.mnu_Vietnamese.Name = "mnu_Vietnamese"
        Me.mnu_Vietnamese.Size = New System.Drawing.Size(152, 22)
        Me.mnu_Vietnamese.Text = "Vietnamese"
        '
        'Timer_danhmuctruong
        '
        Me.Timer_danhmuctruong.Interval = 5000
        '
        'Timer_datasharing
        '
        Me.Timer_datasharing.Interval = 5000
        '
        'Timer_tinh
        '
        Me.Timer_tinh.Interval = 5000
        '
        'Timer3
        '
        Me.Timer3.Interval = 5000
        '
        'Timer4
        '
        Me.Timer4.Interval = 5000
        '
        'txtngaycap
        '
        '
        '
        '
        Me.txtngaycap.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.txtngaycap.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtngaycap.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.txtngaycap.ButtonDropDown.Visible = True
        Me.txtngaycap.CustomFormat = "dd/MM/yyyy"
        Me.txtngaycap.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.txtngaycap.IsPopupCalendarOpen = False
        Me.txtngaycap.Location = New System.Drawing.Point(356, 64)
        '
        '
        '
        Me.txtngaycap.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.txtngaycap.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window
        Me.txtngaycap.MonthCalendar.BackgroundStyle.Class = ""
        Me.txtngaycap.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtngaycap.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.txtngaycap.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.txtngaycap.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.txtngaycap.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.txtngaycap.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.txtngaycap.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.txtngaycap.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.txtngaycap.MonthCalendar.CommandsBackgroundStyle.Class = ""
        Me.txtngaycap.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtngaycap.MonthCalendar.DisplayMonth = New Date(2018, 9, 1, 0, 0, 0, 0)
        Me.txtngaycap.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.txtngaycap.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.txtngaycap.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.txtngaycap.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.txtngaycap.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.txtngaycap.MonthCalendar.NavigationBackgroundStyle.Class = ""
        Me.txtngaycap.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.txtngaycap.MonthCalendar.TodayButtonVisible = True
        Me.txtngaycap.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.txtngaycap.Name = "txtngaycap"
        Me.txtngaycap.Size = New System.Drawing.Size(105, 23)
        Me.txtngaycap.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.txtngaycap.TabIndex = 2
        '
        'ThongTinCaNhan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 499)
        Me.Controls.Add(Me.Group_1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ThongTinCaNhan"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CÔNG CỤ TẢI DỬ LIỆU TẢI NGUYÊN RỪNG"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Group_1.ResumeLayout(False)
        Me.Group_1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.txtngaycap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Group_1 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdNext1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtmucdich As System.Windows.Forms.TextBox
    Friend WithEvents lab_mucdich As System.Windows.Forms.Label
    Friend WithEvents txtgioitinh As System.Windows.Forms.ComboBox
    Friend WithEvents lab_gioitinh As System.Windows.Forms.Label
    Friend WithEvents txttochuc As System.Windows.Forms.ComboBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents lab_email As System.Windows.Forms.Label
    Friend WithEvents txthoten As System.Windows.Forms.TextBox
    Friend WithEvents lab_tochuc As System.Windows.Forms.Label
    Friend WithEvents txtdienthoai As System.Windows.Forms.TextBox
    Friend WithEvents lab_dienthoai As System.Windows.Forms.Label
    Friend WithEvents lab_hoten As System.Windows.Forms.Label
    Friend WithEvents lab_ngaycap As System.Windows.Forms.Label
    Friend WithEvents txtcmnd As System.Windows.Forms.TextBox
    Friend WithEvents lab_cmnd As System.Windows.Forms.Label
    Friend WithEvents txtnoicap As System.Windows.Forms.TextBox
    Friend WithEvents lab_noicap As System.Windows.Forms.Label
    Friend WithEvents txtdiachi As System.Windows.Forms.TextBox
    Friend WithEvents lab_diachi As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lab_redpoint As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents CmdNapthongtin As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cmdLuuThongTin As DevComponents.DotNetBar.ButtonX
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents mnu_capnhat As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_capnhat_hanhchinh As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_phienban As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer_danhmuctruong As System.Windows.Forms.Timer
    Friend WithEvents Timer_datasharing As System.Windows.Forms.Timer
    Friend WithEvents Timer_tinh As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents Timer4 As System.Windows.Forms.Timer
    Friend WithEvents language As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_EngLish As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnu_Vietnamese As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents txtngaycap As DevComponents.Editors.DateTimeAdv.DateTimeInput

End Class
