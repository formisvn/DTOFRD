<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TaiVe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TaiVe))
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.Group_3 = New System.Windows.Forms.GroupBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.CmdHuy = New DevComponents.DotNetBar.ButtonX
        Me.Group_shapefile = New System.Windows.Forms.GroupBox
        Me.CmdThayDoi = New System.Windows.Forms.Button
        Me.txtFilename = New System.Windows.Forms.TextBox
        Me.Group_chiso = New System.Windows.Forms.GroupBox
        Me.chk_all = New System.Windows.Forms.CheckBox
        Me.Lst_mh = New System.Windows.Forms.ListView
        Me.tentruong = New System.Windows.Forms.ColumnHeader
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.group_hanhchinh = New System.Windows.Forms.GroupBox
        Me.txtwfs = New System.Windows.Forms.TextBox
        Me.Group_nam = New System.Windows.Forms.GroupBox
        Me.chk_2010 = New System.Windows.Forms.RadioButton
        Me.chk_2005 = New System.Windows.Forms.RadioButton
        Me.chk_2000 = New System.Windows.Forms.RadioButton
        Me.chk_1995 = New System.Windows.Forms.RadioButton
        Me.chk_1990 = New System.Windows.Forms.RadioButton
        Me.com_chondl = New System.Windows.Forms.ComboBox
        Me.lab_chonDL = New System.Windows.Forms.Label
        Me.txttocdo = New System.Windows.Forms.Label
        Me.txttenxa = New System.Windows.Forms.Label
        Me.txtmatinh = New System.Windows.Forms.TextBox
        Me.txttenhuyen = New System.Windows.Forms.Label
        Me.txttinhtrang = New System.Windows.Forms.Label
        Me.lab_huyen = New System.Windows.Forms.Label
        Me.txtmaxa = New System.Windows.Forms.TextBox
        Me.lab_xa = New System.Windows.Forms.Label
        Me.txtmahuyen = New System.Windows.Forms.TextBox
        Me.txttentinh = New System.Windows.Forms.Label
        Me.lab_tinh = New System.Windows.Forms.Label
        Me.cmdTaiVe = New DevComponents.DotNetBar.ButtonX
        Me.CmdCSVFile = New DevComponents.DotNetBar.ButtonItem
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Group_3.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Group_shapefile.SuspendLayout()
        Me.Group_chiso.SuspendLayout()
        Me.group_hanhchinh.SuspendLayout()
        Me.Group_nam.SuspendLayout()
        Me.SuspendLayout()
        '
        'Group_3
        '
        Me.Group_3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Group_3.Controls.Add(Me.PictureBox2)
        Me.Group_3.Controls.Add(Me.CmdHuy)
        Me.Group_3.Controls.Add(Me.Group_shapefile)
        Me.Group_3.Controls.Add(Me.Group_chiso)
        Me.Group_3.Controls.Add(Me.group_hanhchinh)
        Me.Group_3.Controls.Add(Me.cmdTaiVe)
        Me.Group_3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Group_3.Location = New System.Drawing.Point(10, 12)
        Me.Group_3.Name = "Group_3"
        Me.Group_3.Size = New System.Drawing.Size(784, 475)
        Me.Group_3.TabIndex = 5
        Me.Group_3.TabStop = False
        Me.Group_3.Text = "Nhập các thông tin dữ liệu cần tải về"
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(0, 432)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(59, 40)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 53
        Me.PictureBox2.TabStop = False
        '
        'CmdHuy
        '
        Me.CmdHuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.CmdHuy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdHuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.CmdHuy.Enabled = False
        Me.CmdHuy.Image = CType(resources.GetObject("CmdHuy.Image"), System.Drawing.Image)
        Me.CmdHuy.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.CmdHuy.Location = New System.Drawing.Point(488, 431)
        Me.CmdHuy.Name = "CmdHuy"
        Me.CmdHuy.Size = New System.Drawing.Size(142, 38)
        Me.CmdHuy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CmdHuy.TabIndex = 52
        Me.CmdHuy.Text = "&Hủy"
        '
        'Group_shapefile
        '
        Me.Group_shapefile.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Group_shapefile.Controls.Add(Me.CmdThayDoi)
        Me.Group_shapefile.Controls.Add(Me.txtFilename)
        Me.Group_shapefile.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Group_shapefile.Location = New System.Drawing.Point(6, 367)
        Me.Group_shapefile.Name = "Group_shapefile"
        Me.Group_shapefile.Size = New System.Drawing.Size(767, 62)
        Me.Group_shapefile.TabIndex = 42
        Me.Group_shapefile.TabStop = False
        Me.Group_shapefile.Text = "Chọn tên file lưu thành"
        '
        'CmdThayDoi
        '
        Me.CmdThayDoi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdThayDoi.ForeColor = System.Drawing.Color.Black
        Me.CmdThayDoi.Image = CType(resources.GetObject("CmdThayDoi.Image"), System.Drawing.Image)
        Me.CmdThayDoi.Location = New System.Drawing.Point(648, 23)
        Me.CmdThayDoi.Name = "CmdThayDoi"
        Me.CmdThayDoi.Size = New System.Drawing.Size(110, 24)
        Me.CmdThayDoi.TabIndex = 8
        Me.CmdThayDoi.Text = "Chọn tên file"
        Me.CmdThayDoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'txtFilename
        '
        Me.txtFilename.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFilename.Location = New System.Drawing.Point(17, 24)
        Me.txtFilename.Name = "txtFilename"
        Me.txtFilename.ReadOnly = True
        Me.txtFilename.Size = New System.Drawing.Size(625, 23)
        Me.txtFilename.TabIndex = 7
        '
        'Group_chiso
        '
        Me.Group_chiso.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Group_chiso.Controls.Add(Me.chk_all)
        Me.Group_chiso.Controls.Add(Me.Lst_mh)
        Me.Group_chiso.Controls.Add(Me.ListView1)
        Me.Group_chiso.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Group_chiso.Location = New System.Drawing.Point(455, 22)
        Me.Group_chiso.Name = "Group_chiso"
        Me.Group_chiso.Size = New System.Drawing.Size(318, 341)
        Me.Group_chiso.TabIndex = 41
        Me.Group_chiso.TabStop = False
        Me.Group_chiso.Text = "Lựa chọn chỉ số"
        '
        'chk_all
        '
        Me.chk_all.AutoSize = True
        Me.chk_all.BackColor = System.Drawing.Color.White
        Me.chk_all.Checked = True
        Me.chk_all.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_all.ForeColor = System.Drawing.Color.Blue
        Me.chk_all.Location = New System.Drawing.Point(10, 22)
        Me.chk_all.Name = "chk_all"
        Me.chk_all.Size = New System.Drawing.Size(102, 20)
        Me.chk_all.TabIndex = 2
        Me.chk_all.Text = "Chọn tất cả"
        Me.chk_all.UseVisualStyleBackColor = False
        '
        'Lst_mh
        '
        Me.Lst_mh.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lst_mh.CheckBoxes = True
        Me.Lst_mh.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.tentruong})
        Me.Lst_mh.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(5, Byte))
        Me.Lst_mh.FullRowSelect = True
        Me.Lst_mh.GridLines = True
        Me.Lst_mh.Location = New System.Drawing.Point(6, 43)
        Me.Lst_mh.Name = "Lst_mh"
        Me.Lst_mh.Size = New System.Drawing.Size(306, 292)
        Me.Lst_mh.TabIndex = 1
        Me.Lst_mh.UseCompatibleStateImageBehavior = False
        Me.Lst_mh.View = System.Windows.Forms.View.Details
        '
        'tentruong
        '
        Me.tentruong.Text = "Lựa chọn trường chỉ số"
        Me.tentruong.Width = 250
        '
        'ListView1
        '
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Location = New System.Drawing.Point(3, 19)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(312, 319)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'group_hanhchinh
        '
        Me.group_hanhchinh.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.group_hanhchinh.Controls.Add(Me.txtwfs)
        Me.group_hanhchinh.Controls.Add(Me.Group_nam)
        Me.group_hanhchinh.Controls.Add(Me.com_chondl)
        Me.group_hanhchinh.Controls.Add(Me.lab_chonDL)
        Me.group_hanhchinh.Controls.Add(Me.txttocdo)
        Me.group_hanhchinh.Controls.Add(Me.txttenxa)
        Me.group_hanhchinh.Controls.Add(Me.txtmatinh)
        Me.group_hanhchinh.Controls.Add(Me.txttenhuyen)
        Me.group_hanhchinh.Controls.Add(Me.txttinhtrang)
        Me.group_hanhchinh.Controls.Add(Me.lab_huyen)
        Me.group_hanhchinh.Controls.Add(Me.txtmaxa)
        Me.group_hanhchinh.Controls.Add(Me.lab_xa)
        Me.group_hanhchinh.Controls.Add(Me.txtmahuyen)
        Me.group_hanhchinh.Controls.Add(Me.txttentinh)
        Me.group_hanhchinh.Controls.Add(Me.lab_tinh)
        Me.group_hanhchinh.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.group_hanhchinh.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.group_hanhchinh.Location = New System.Drawing.Point(6, 22)
        Me.group_hanhchinh.Name = "group_hanhchinh"
        Me.group_hanhchinh.Size = New System.Drawing.Size(443, 341)
        Me.group_hanhchinh.TabIndex = 40
        Me.group_hanhchinh.TabStop = False
        Me.group_hanhchinh.Text = "Chọn đơn vị hành chính cần xuất dữ liệu"
        '
        'txtwfs
        '
        Me.txtwfs.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtwfs.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtwfs.Location = New System.Drawing.Point(17, 162)
        Me.txtwfs.Margin = New System.Windows.Forms.Padding(2)
        Me.txtwfs.Multiline = True
        Me.txtwfs.Name = "txtwfs"
        Me.txtwfs.Size = New System.Drawing.Size(420, 81)
        Me.txtwfs.TabIndex = 53
        Me.txtwfs.Visible = False
        '
        'Group_nam
        '
        Me.Group_nam.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Group_nam.Controls.Add(Me.chk_2010)
        Me.Group_nam.Controls.Add(Me.chk_2005)
        Me.Group_nam.Controls.Add(Me.chk_2000)
        Me.Group_nam.Controls.Add(Me.chk_1995)
        Me.Group_nam.Controls.Add(Me.chk_1990)
        Me.Group_nam.ForeColor = System.Drawing.Color.Navy
        Me.Group_nam.Location = New System.Drawing.Point(99, 57)
        Me.Group_nam.Name = "Group_nam"
        Me.Group_nam.Size = New System.Drawing.Size(338, 56)
        Me.Group_nam.TabIndex = 52
        Me.Group_nam.TabStop = False
        Me.Group_nam.Text = "Chọn dữ liệu tại thời điểm"
        Me.Group_nam.Visible = False
        '
        'chk_2010
        '
        Me.chk_2010.AutoSize = True
        Me.chk_2010.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chk_2010.Location = New System.Drawing.Point(259, 22)
        Me.chk_2010.Name = "chk_2010"
        Me.chk_2010.Size = New System.Drawing.Size(54, 20)
        Me.chk_2010.TabIndex = 4
        Me.chk_2010.TabStop = True
        Me.chk_2010.Text = "2010"
        Me.chk_2010.UseVisualStyleBackColor = True
        '
        'chk_2005
        '
        Me.chk_2005.AutoSize = True
        Me.chk_2005.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chk_2005.Location = New System.Drawing.Point(199, 22)
        Me.chk_2005.Name = "chk_2005"
        Me.chk_2005.Size = New System.Drawing.Size(54, 20)
        Me.chk_2005.TabIndex = 3
        Me.chk_2005.TabStop = True
        Me.chk_2005.Text = "2005"
        Me.chk_2005.UseVisualStyleBackColor = True
        '
        'chk_2000
        '
        Me.chk_2000.AutoSize = True
        Me.chk_2000.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chk_2000.Location = New System.Drawing.Point(139, 22)
        Me.chk_2000.Name = "chk_2000"
        Me.chk_2000.Size = New System.Drawing.Size(54, 20)
        Me.chk_2000.TabIndex = 2
        Me.chk_2000.TabStop = True
        Me.chk_2000.Text = "2000"
        Me.chk_2000.UseVisualStyleBackColor = True
        '
        'chk_1995
        '
        Me.chk_1995.AutoSize = True
        Me.chk_1995.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chk_1995.Location = New System.Drawing.Point(79, 22)
        Me.chk_1995.Name = "chk_1995"
        Me.chk_1995.Size = New System.Drawing.Size(54, 20)
        Me.chk_1995.TabIndex = 1
        Me.chk_1995.TabStop = True
        Me.chk_1995.Text = "1995"
        Me.chk_1995.UseVisualStyleBackColor = True
        '
        'chk_1990
        '
        Me.chk_1990.AutoSize = True
        Me.chk_1990.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chk_1990.Location = New System.Drawing.Point(19, 22)
        Me.chk_1990.Name = "chk_1990"
        Me.chk_1990.Size = New System.Drawing.Size(54, 20)
        Me.chk_1990.TabIndex = 0
        Me.chk_1990.TabStop = True
        Me.chk_1990.Text = "1990"
        Me.chk_1990.UseVisualStyleBackColor = True
        '
        'com_chondl
        '
        Me.com_chondl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.com_chondl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.com_chondl.FormattingEnabled = True
        Me.com_chondl.Items.AddRange(New Object() {"Dữ liệu tài nguyên rừng năm 2017", "Dữ liệu tài nguyên rừng năm 2016", "Dữ liệu điều tra kiểm kê rừng gốc (thu  và tích hợp 2014-2016, Cục Kiểm lâm)", "Dữ liệu 4 chu kỳ (NFI 1990 - 2010)"})
        Me.com_chondl.Location = New System.Drawing.Point(99, 25)
        Me.com_chondl.Name = "com_chondl"
        Me.com_chondl.Size = New System.Drawing.Size(338, 24)
        Me.com_chondl.TabIndex = 23
        '
        'lab_chonDL
        '
        Me.lab_chonDL.AutoSize = True
        Me.lab_chonDL.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_chonDL.Location = New System.Drawing.Point(17, 29)
        Me.lab_chonDL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lab_chonDL.Name = "lab_chonDL"
        Me.lab_chonDL.Size = New System.Drawing.Size(80, 16)
        Me.lab_chonDL.TabIndex = 22
        Me.lab_chonDL.Text = "Chọn dữ liệu"
        '
        'txttocdo
        '
        Me.txttocdo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txttocdo.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttocdo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txttocdo.Location = New System.Drawing.Point(5, 296)
        Me.txttocdo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txttocdo.Name = "txttocdo"
        Me.txttocdo.Size = New System.Drawing.Size(432, 37)
        Me.txttocdo.TabIndex = 51
        Me.txttocdo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txttenxa
        '
        Me.txttenxa.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txttenxa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txttenxa.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttenxa.Location = New System.Drawing.Point(157, 118)
        Me.txttenxa.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txttenxa.Name = "txttenxa"
        Me.txttenxa.Size = New System.Drawing.Size(280, 23)
        Me.txttenxa.TabIndex = 18
        Me.txttenxa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtmatinh
        '
        Me.txtmatinh.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmatinh.Location = New System.Drawing.Point(99, 57)
        Me.txtmatinh.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmatinh.Name = "txtmatinh"
        Me.txtmatinh.Size = New System.Drawing.Size(54, 23)
        Me.txtmatinh.TabIndex = 0
        '
        'txttenhuyen
        '
        Me.txttenhuyen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txttenhuyen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txttenhuyen.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttenhuyen.Location = New System.Drawing.Point(157, 88)
        Me.txttenhuyen.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txttenhuyen.Name = "txttenhuyen"
        Me.txttenhuyen.Size = New System.Drawing.Size(280, 23)
        Me.txttenhuyen.TabIndex = 16
        Me.txttenhuyen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txttinhtrang
        '
        Me.txttinhtrang.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txttinhtrang.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttinhtrang.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txttinhtrang.Location = New System.Drawing.Point(5, 259)
        Me.txttinhtrang.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txttinhtrang.Name = "txttinhtrang"
        Me.txttinhtrang.Size = New System.Drawing.Size(432, 37)
        Me.txttinhtrang.TabIndex = 50
        Me.txttinhtrang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lab_huyen
        '
        Me.lab_huyen.AutoSize = True
        Me.lab_huyen.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_huyen.Location = New System.Drawing.Point(17, 89)
        Me.lab_huyen.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lab_huyen.Name = "lab_huyen"
        Me.lab_huyen.Size = New System.Drawing.Size(75, 16)
        Me.lab_huyen.TabIndex = 13
        Me.lab_huyen.Text = "Chọn huyện"
        '
        'txtmaxa
        '
        Me.txtmaxa.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmaxa.Location = New System.Drawing.Point(99, 118)
        Me.txtmaxa.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmaxa.Name = "txtmaxa"
        Me.txtmaxa.Size = New System.Drawing.Size(54, 23)
        Me.txtmaxa.TabIndex = 2
        '
        'lab_xa
        '
        Me.lab_xa.AutoSize = True
        Me.lab_xa.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_xa.Location = New System.Drawing.Point(17, 122)
        Me.lab_xa.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lab_xa.Name = "lab_xa"
        Me.lab_xa.Size = New System.Drawing.Size(54, 16)
        Me.lab_xa.TabIndex = 15
        Me.lab_xa.Text = "Chọn xã"
        '
        'txtmahuyen
        '
        Me.txtmahuyen.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmahuyen.Location = New System.Drawing.Point(99, 88)
        Me.txtmahuyen.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmahuyen.Name = "txtmahuyen"
        Me.txtmahuyen.Size = New System.Drawing.Size(54, 23)
        Me.txtmahuyen.TabIndex = 1
        '
        'txttentinh
        '
        Me.txttentinh.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txttentinh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txttentinh.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttentinh.Location = New System.Drawing.Point(157, 57)
        Me.txttentinh.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txttentinh.Name = "txttentinh"
        Me.txttentinh.Size = New System.Drawing.Size(280, 23)
        Me.txttentinh.TabIndex = 17
        Me.txttentinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lab_tinh
        '
        Me.lab_tinh.AutoSize = True
        Me.lab_tinh.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lab_tinh.Location = New System.Drawing.Point(17, 58)
        Me.lab_tinh.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lab_tinh.Name = "lab_tinh"
        Me.lab_tinh.Size = New System.Drawing.Size(62, 16)
        Me.lab_tinh.TabIndex = 14
        Me.lab_tinh.Text = "Chọn tỉnh"
        '
        'cmdTaiVe
        '
        Me.cmdTaiVe.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.cmdTaiVe.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmdTaiVe.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.cmdTaiVe.Image = CType(resources.GetObject("cmdTaiVe.Image"), System.Drawing.Image)
        Me.cmdTaiVe.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.cmdTaiVe.Location = New System.Drawing.Point(636, 431)
        Me.cmdTaiVe.Name = "cmdTaiVe"
        Me.cmdTaiVe.Size = New System.Drawing.Size(138, 38)
        Me.cmdTaiVe.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cmdTaiVe.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.CmdCSVFile})
        Me.cmdTaiVe.TabIndex = 39
        Me.cmdTaiVe.Text = "&Tải về"
        '
        'CmdCSVFile
        '
        Me.CmdCSVFile.GlobalItem = False
        Me.CmdCSVFile.Name = "CmdCSVFile"
        Me.CmdCSVFile.Text = "File CSV"
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'Timer2
        '
        Me.Timer2.Interval = 3000
        '
        'TaiVe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 499)
        Me.Controls.Add(Me.Group_3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Name = "TaiVe"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CÔNG CỤ TẢI DỬ LIỆU TẢI NGUYÊN RỪNG"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Group_3.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Group_shapefile.ResumeLayout(False)
        Me.Group_shapefile.PerformLayout()
        Me.Group_chiso.ResumeLayout(False)
        Me.Group_chiso.PerformLayout()
        Me.group_hanhchinh.ResumeLayout(False)
        Me.group_hanhchinh.PerformLayout()
        Me.Group_nam.ResumeLayout(False)
        Me.Group_nam.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Group_3 As System.Windows.Forms.GroupBox
    Friend WithEvents Group_shapefile As System.Windows.Forms.GroupBox
    Friend WithEvents CmdThayDoi As System.Windows.Forms.Button
    Friend WithEvents txtFilename As System.Windows.Forms.TextBox
    Friend WithEvents Group_chiso As System.Windows.Forms.GroupBox
    Friend WithEvents Lst_mh As System.Windows.Forms.ListView
    Friend WithEvents tentruong As System.Windows.Forms.ColumnHeader
    Friend WithEvents group_hanhchinh As System.Windows.Forms.GroupBox
    Friend WithEvents com_chondl As System.Windows.Forms.ComboBox
    Friend WithEvents lab_chonDL As System.Windows.Forms.Label
    Friend WithEvents txttenxa As System.Windows.Forms.Label
    Friend WithEvents txtmatinh As System.Windows.Forms.TextBox
    Friend WithEvents txttenhuyen As System.Windows.Forms.Label
    Friend WithEvents lab_huyen As System.Windows.Forms.Label
    Friend WithEvents txtmaxa As System.Windows.Forms.TextBox
    Friend WithEvents lab_xa As System.Windows.Forms.Label
    Friend WithEvents txtmahuyen As System.Windows.Forms.TextBox
    Friend WithEvents txttentinh As System.Windows.Forms.Label
    Friend WithEvents lab_tinh As System.Windows.Forms.Label
    Friend WithEvents cmdTaiVe As DevComponents.DotNetBar.ButtonX
    Friend WithEvents chk_all As System.Windows.Forms.CheckBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents txttinhtrang As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents txttocdo As System.Windows.Forms.Label
    Friend WithEvents CmdHuy As DevComponents.DotNetBar.ButtonX
    Friend WithEvents CmdCSVFile As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Group_nam As System.Windows.Forms.GroupBox
    Friend WithEvents chk_2010 As System.Windows.Forms.RadioButton
    Friend WithEvents chk_2005 As System.Windows.Forms.RadioButton
    Friend WithEvents chk_2000 As System.Windows.Forms.RadioButton
    Friend WithEvents chk_1995 As System.Windows.Forms.RadioButton
    Friend WithEvents chk_1990 As System.Windows.Forms.RadioButton
    Friend WithEvents txtwfs As System.Windows.Forms.TextBox

End Class
