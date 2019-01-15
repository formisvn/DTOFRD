<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Group_1 = New System.Windows.Forms.GroupBox
        Me.CmdNext1 = New DevComponents.DotNetBar.ButtonX
        Me.txtmucdich = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtgioitinh = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txttochuc = New System.Windows.Forms.ComboBox
        Me.txtemail = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txthoten = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtdienthoai = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Tab = New System.Windows.Forms.TabControl
        Me.Tab_1 = New System.Windows.Forms.TabPage
        Me.Tab_2 = New System.Windows.Forms.TabPage
        Me.txtdieukhoan = New DevComponents.DotNetBar.Controls.TextBoxX
        Me.Tab_3 = New System.Windows.Forms.TabPage
        Me.CmdNext2 = New DevComponents.DotNetBar.ButtonX
        Me.chk_dongy = New DevComponents.DotNetBar.Controls.CheckBoxX
        Me.Group_2 = New System.Windows.Forms.GroupBox
        Me.Group_3 = New System.Windows.Forms.GroupBox
        Me.ButtonX2 = New DevComponents.DotNetBar.ButtonX
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txttenxa = New System.Windows.Forms.Label
        Me.txtmatinh = New System.Windows.Forms.TextBox
        Me.txttenhuyen = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtmaxa = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtmahuyen = New System.Windows.Forms.TextBox
        Me.txttentinh = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Lst_mh = New System.Windows.Forms.ListView
        Me.tentruong = New System.Windows.Forms.ColumnHeader
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.CmdThayDoi = New System.Windows.Forms.Button
        Me.txtFilename = New System.Windows.Forms.TextBox
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.Group_1.SuspendLayout()
        Me.Tab.SuspendLayout()
        Me.Tab_1.SuspendLayout()
        Me.Tab_2.SuspendLayout()
        Me.Tab_3.SuspendLayout()
        Me.Group_2.SuspendLayout()
        Me.Group_3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(360, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "NHẬP THÔNG TIN CÁ NHÂN/TỔ CHỨC CẦN TẢI DỮ LIỆU"
        '
        'Group_1
        '
        Me.Group_1.Controls.Add(Me.CmdNext1)
        Me.Group_1.Controls.Add(Me.txtmucdich)
        Me.Group_1.Controls.Add(Me.Label4)
        Me.Group_1.Controls.Add(Me.txtgioitinh)
        Me.Group_1.Controls.Add(Me.Label2)
        Me.Group_1.Controls.Add(Me.txttochuc)
        Me.Group_1.Controls.Add(Me.txtemail)
        Me.Group_1.Controls.Add(Me.Label3)
        Me.Group_1.Controls.Add(Me.txthoten)
        Me.Group_1.Controls.Add(Me.Label5)
        Me.Group_1.Controls.Add(Me.txtdienthoai)
        Me.Group_1.Controls.Add(Me.Label6)
        Me.Group_1.Controls.Add(Me.Label8)
        Me.Group_1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Group_1.ForeColor = System.Drawing.Color.Black
        Me.Group_1.Location = New System.Drawing.Point(6, 6)
        Me.Group_1.Name = "Group_1"
        Me.Group_1.Size = New System.Drawing.Size(782, 447)
        Me.Group_1.TabIndex = 1
        Me.Group_1.TabStop = False
        Me.Group_1.Text = "NHẬP THÔNG TIN CÁ NHÂN/TỔ CHỨC CẦN TẢI DỮ LIỆU"
        '
        'CmdNext1
        '
        Me.CmdNext1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.CmdNext1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CmdNext1.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.CmdNext1.Image = CType(resources.GetObject("CmdNext1.Image"), System.Drawing.Image)
        Me.CmdNext1.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.CmdNext1.Location = New System.Drawing.Point(606, 368)
        Me.CmdNext1.Name = "CmdNext1"
        Me.CmdNext1.Size = New System.Drawing.Size(137, 38)
        Me.CmdNext1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CmdNext1.TabIndex = 38
        Me.CmdNext1.Text = "&Chấp nhận"
        '
        'txtmucdich
        '
        Me.txtmucdich.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmucdich.Location = New System.Drawing.Point(97, 222)
        Me.txtmucdich.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmucdich.Multiline = True
        Me.txtmucdich.Name = "txtmucdich"
        Me.txtmucdich.Size = New System.Drawing.Size(646, 141)
        Me.txtmucdich.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(15, 211)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 69)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Mục đích tải dữ liệu"
        '
        'txtgioitinh
        '
        Me.txtgioitinh.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtgioitinh.FormattingEnabled = True
        Me.txtgioitinh.Items.AddRange(New Object() {"Nam", "Nữ"})
        Me.txtgioitinh.Location = New System.Drawing.Point(97, 60)
        Me.txtgioitinh.Name = "txtgioitinh"
        Me.txtgioitinh.Size = New System.Drawing.Size(86, 24)
        Me.txtgioitinh.TabIndex = 34
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Navy
        Me.Label2.Location = New System.Drawing.Point(15, 63)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 16)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Giới tính"
        '
        'txttochuc
        '
        Me.txttochuc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txttochuc.FormattingEnabled = True
        Me.txttochuc.Items.AddRange(New Object() {"Central FPD", "Government forest agencies (Departments, units under VNFOREST, DARDs)", "Regional Sub-FPDs (4 regions)", "Provincial and districts Sub-FPDs", "Universities, Insitutions", "Projects under MARD/ VNFOREST and other ministries", "Other agencies and organisations: Foreign government organizations, NGOs etc."})
        Me.txttochuc.Location = New System.Drawing.Point(97, 90)
        Me.txttochuc.Name = "txttochuc"
        Me.txttochuc.Size = New System.Drawing.Size(311, 24)
        Me.txttochuc.TabIndex = 32
        '
        'txtemail
        '
        Me.txtemail.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(97, 178)
        Me.txtemail.Margin = New System.Windows.Forms.Padding(2)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(311, 23)
        Me.txtemail.TabIndex = 30
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(15, 182)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 16)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "Email"
        '
        'txthoten
        '
        Me.txthoten.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthoten.Location = New System.Drawing.Point(97, 32)
        Me.txthoten.Margin = New System.Windows.Forms.Padding(2)
        Me.txthoten.Name = "txthoten"
        Me.txthoten.Size = New System.Drawing.Size(311, 23)
        Me.txthoten.TabIndex = 25
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(15, 93)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 16)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Tổ chức"
        '
        'txtdienthoai
        '
        Me.txtdienthoai.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdienthoai.Location = New System.Drawing.Point(97, 148)
        Me.txtdienthoai.Margin = New System.Windows.Forms.Padding(2)
        Me.txtdienthoai.Name = "txtdienthoai"
        Me.txtdienthoai.Size = New System.Drawing.Size(311, 23)
        Me.txtdienthoai.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Navy
        Me.Label6.Location = New System.Drawing.Point(15, 152)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 16)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Điện thoại"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Navy
        Me.Label8.Location = New System.Drawing.Point(15, 33)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 16)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Họ tên"
        '
        'Tab
        '
        Me.Tab.Controls.Add(Me.Tab_1)
        Me.Tab.Controls.Add(Me.Tab_2)
        Me.Tab.Controls.Add(Me.Tab_3)
        Me.Tab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab.Location = New System.Drawing.Point(0, 0)
        Me.Tab.Name = "Tab"
        Me.Tab.SelectedIndex = 0
        Me.Tab.Size = New System.Drawing.Size(806, 499)
        Me.Tab.TabIndex = 2
        '
        'Tab_1
        '
        Me.Tab_1.Controls.Add(Me.Group_1)
        Me.Tab_1.Location = New System.Drawing.Point(4, 25)
        Me.Tab_1.Name = "Tab_1"
        Me.Tab_1.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_1.Size = New System.Drawing.Size(798, 470)
        Me.Tab_1.TabIndex = 0
        Me.Tab_1.Text = "Khai báo thông tin cá nhân/Tổ chức"
        Me.Tab_1.UseVisualStyleBackColor = True
        '
        'Tab_2
        '
        Me.Tab_2.Controls.Add(Me.Group_2)
        Me.Tab_2.Location = New System.Drawing.Point(4, 25)
        Me.Tab_2.Name = "Tab_2"
        Me.Tab_2.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_2.Size = New System.Drawing.Size(798, 470)
        Me.Tab_2.TabIndex = 1
        Me.Tab_2.Text = "Điều khoản pháp lý"
        Me.Tab_2.UseVisualStyleBackColor = True
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
        Me.txtdieukhoan.Location = New System.Drawing.Point(6, 22)
        Me.txtdieukhoan.Multiline = True
        Me.txtdieukhoan.Name = "txtdieukhoan"
        Me.txtdieukhoan.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtdieukhoan.Size = New System.Drawing.Size(772, 384)
        Me.txtdieukhoan.TabIndex = 1
        Me.txtdieukhoan.Text = resources.GetString("txtdieukhoan.Text")
        '
        'Tab_3
        '
        Me.Tab_3.Controls.Add(Me.Group_3)
        Me.Tab_3.Location = New System.Drawing.Point(4, 25)
        Me.Tab_3.Name = "Tab_3"
        Me.Tab_3.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_3.Size = New System.Drawing.Size(798, 470)
        Me.Tab_3.TabIndex = 2
        Me.Tab_3.Text = "Tải về"
        Me.Tab_3.UseVisualStyleBackColor = True
        '
        'CmdNext2
        '
        Me.CmdNext2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.CmdNext2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdNext2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.CmdNext2.Image = CType(resources.GetObject("CmdNext2.Image"), System.Drawing.Image)
        Me.CmdNext2.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.CmdNext2.Location = New System.Drawing.Point(674, 412)
        Me.CmdNext2.Name = "CmdNext2"
        Me.CmdNext2.Size = New System.Drawing.Size(104, 38)
        Me.CmdNext2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.CmdNext2.TabIndex = 39
        Me.CmdNext2.Text = "&Tải về"
        '
        'chk_dongy
        '
        Me.chk_dongy.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chk_dongy.AutoSize = True
        '
        '
        '
        Me.chk_dongy.BackgroundStyle.Class = ""
        Me.chk_dongy.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.chk_dongy.Location = New System.Drawing.Point(6, 423)
        Me.chk_dongy.Name = "chk_dongy"
        Me.chk_dongy.Size = New System.Drawing.Size(414, 18)
        Me.chk_dongy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.chk_dongy.TabIndex = 40
        Me.chk_dongy.Text = "Tôi đã đọc và đồng ý với các điều khoản về bản quyền ở trên"
        '
        'Group_2
        '
        Me.Group_2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Group_2.Controls.Add(Me.CmdNext2)
        Me.Group_2.Controls.Add(Me.txtdieukhoan)
        Me.Group_2.Controls.Add(Me.chk_dongy)
        Me.Group_2.Enabled = False
        Me.Group_2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Group_2.Location = New System.Drawing.Point(6, 6)
        Me.Group_2.Name = "Group_2"
        Me.Group_2.Size = New System.Drawing.Size(784, 456)
        Me.Group_2.TabIndex = 3
        Me.Group_2.TabStop = False
        Me.Group_2.Text = "Đọc các điều khoản về bản quyền của dữ liệu"
        '
        'Group_3
        '
        Me.Group_3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Group_3.Controls.Add(Me.GroupBox3)
        Me.Group_3.Controls.Add(Me.GroupBox4)
        Me.Group_3.Controls.Add(Me.GroupBox2)
        Me.Group_3.Controls.Add(Me.ButtonX2)
        Me.Group_3.Enabled = False
        Me.Group_3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Group_3.Location = New System.Drawing.Point(6, 6)
        Me.Group_3.Name = "Group_3"
        Me.Group_3.Size = New System.Drawing.Size(784, 456)
        Me.Group_3.TabIndex = 4
        Me.Group_3.TabStop = False
        Me.Group_3.Text = "Vui lòng đọc các điều khoản về bản quyền của dữ liệu"
        '
        'ButtonX2
        '
        Me.ButtonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.ButtonX2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground
        Me.ButtonX2.Image = CType(resources.GetObject("ButtonX2.Image"), System.Drawing.Image)
        Me.ButtonX2.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.ButtonX2.Location = New System.Drawing.Point(657, 412)
        Me.ButtonX2.Name = "ButtonX2"
        Me.ButtonX2.Size = New System.Drawing.Size(104, 38)
        Me.ButtonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ButtonX2.TabIndex = 39
        Me.ButtonX2.Text = "&Tải về"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.ComboBox1)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txttenxa)
        Me.GroupBox2.Controls.Add(Me.txtmatinh)
        Me.GroupBox2.Controls.Add(Me.txttenhuyen)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtmaxa)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtmahuyen)
        Me.GroupBox2.Controls.Add(Me.txttentinh)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(6, 22)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(422, 322)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Chọn đơn vị hành chính cần xuất dữ liệu"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Forest resource data of 2017", "Forest resource data of 2016", "NFIS original (collected/integrated 2014-2016, FPD)", "4 cycle data (NFI 1990 – 2010)", "Dynamic forest resource data (date when the copy has taken)", "Admin boundaries (MONRE)", "Protected areas (DONC)"})
        Me.ComboBox1.Location = New System.Drawing.Point(105, 33)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(311, 24)
        Me.ComboBox1.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 37)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 16)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Chọn dữ liệu"
        '
        'txttenxa
        '
        Me.txttenxa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txttenxa.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttenxa.Location = New System.Drawing.Point(163, 128)
        Me.txttenxa.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txttenxa.Name = "txttenxa"
        Me.txttenxa.Size = New System.Drawing.Size(253, 23)
        Me.txttenxa.TabIndex = 18
        Me.txttenxa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtmatinh
        '
        Me.txtmatinh.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmatinh.Location = New System.Drawing.Point(105, 67)
        Me.txtmatinh.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmatinh.Name = "txtmatinh"
        Me.txtmatinh.Size = New System.Drawing.Size(54, 23)
        Me.txtmatinh.TabIndex = 0
        '
        'txttenhuyen
        '
        Me.txttenhuyen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txttenhuyen.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttenhuyen.Location = New System.Drawing.Point(163, 98)
        Me.txttenhuyen.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txttenhuyen.Name = "txttenhuyen"
        Me.txttenhuyen.Size = New System.Drawing.Size(253, 23)
        Me.txttenhuyen.TabIndex = 16
        Me.txttenhuyen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(23, 99)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 16)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Chọn huyện"
        '
        'txtmaxa
        '
        Me.txtmaxa.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmaxa.Location = New System.Drawing.Point(105, 128)
        Me.txtmaxa.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmaxa.Name = "txtmaxa"
        Me.txtmaxa.Size = New System.Drawing.Size(54, 23)
        Me.txtmaxa.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(23, 132)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 16)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "Chọn xã"
        '
        'txtmahuyen
        '
        Me.txtmahuyen.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmahuyen.Location = New System.Drawing.Point(105, 98)
        Me.txtmahuyen.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmahuyen.Name = "txtmahuyen"
        Me.txtmahuyen.Size = New System.Drawing.Size(54, 23)
        Me.txtmahuyen.TabIndex = 1
        '
        'txttentinh
        '
        Me.txttentinh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.txttentinh.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttentinh.Location = New System.Drawing.Point(163, 67)
        Me.txttentinh.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.txttentinh.Name = "txttentinh"
        Me.txttentinh.Size = New System.Drawing.Size(253, 23)
        Me.txttentinh.TabIndex = 17
        Me.txttentinh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(23, 68)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(62, 16)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Chọn tỉnh"
        '
        'GroupBox4
        '
        Me.GroupBox4.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox4.Controls.Add(Me.Lst_mh)
        Me.GroupBox4.Controls.Add(Me.ListView1)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(443, 22)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(318, 322)
        Me.GroupBox4.TabIndex = 41
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Lựa chọn chỉ số"
        '
        'Lst_mh
        '
        Me.Lst_mh.CheckBoxes = True
        Me.Lst_mh.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.tentruong})
        Me.Lst_mh.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Lst_mh.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(5, Byte))
        Me.Lst_mh.FullRowSelect = True
        Me.Lst_mh.GridLines = True
        Me.Lst_mh.Location = New System.Drawing.Point(3, 18)
        Me.Lst_mh.Name = "Lst_mh"
        Me.Lst_mh.Size = New System.Drawing.Size(312, 301)
        Me.Lst_mh.TabIndex = 1
        Me.Lst_mh.UseCompatibleStateImageBehavior = False
        Me.Lst_mh.View = System.Windows.Forms.View.Details
        '
        'tentruong
        '
        Me.tentruong.Text = "Tên trường chỉ số"
        Me.tentruong.Width = 250
        '
        'ListView1
        '
        Me.ListView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListView1.Location = New System.Drawing.Point(3, 18)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(312, 301)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.CmdThayDoi)
        Me.GroupBox3.Controls.Add(Me.txtFilename)
        Me.GroupBox3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(1, 305)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(760, 62)
        Me.GroupBox3.TabIndex = 42
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Đường dẫn Shapefile"
        '
        'CmdThayDoi
        '
        Me.CmdThayDoi.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CmdThayDoi.ForeColor = System.Drawing.Color.Black
        Me.CmdThayDoi.Image = CType(resources.GetObject("CmdThayDoi.Image"), System.Drawing.Image)
        Me.CmdThayDoi.Location = New System.Drawing.Point(641, 23)
        Me.CmdThayDoi.Name = "CmdThayDoi"
        Me.CmdThayDoi.Size = New System.Drawing.Size(110, 24)
        Me.CmdThayDoi.TabIndex = 8
        Me.CmdThayDoi.Text = "Lưu thành"
        Me.CmdThayDoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'txtFilename
        '
        Me.txtFilename.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFilename.Location = New System.Drawing.Point(17, 24)
        Me.txtFilename.Name = "txtFilename"
        Me.txtFilename.ReadOnly = True
        Me.txtFilename.Size = New System.Drawing.Size(618, 23)
        Me.txtFilename.TabIndex = 7
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 499)
        Me.Controls.Add(Me.Tab)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CÔNG CỤ TẢI DỬ LIỆU TỪ MÁY CHỦ TRUNG TÂM"
        Me.Group_1.ResumeLayout(False)
        Me.Group_1.PerformLayout()
        Me.Tab.ResumeLayout(False)
        Me.Tab_1.ResumeLayout(False)
        Me.Tab_2.ResumeLayout(False)
        Me.Tab_3.ResumeLayout(False)
        Me.Group_2.ResumeLayout(False)
        Me.Group_2.PerformLayout()
        Me.Group_3.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Group_1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtgioitinh As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txttochuc As System.Windows.Forms.ComboBox
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txthoten As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtdienthoai As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Tab As System.Windows.Forms.TabControl
    Friend WithEvents Tab_1 As System.Windows.Forms.TabPage
    Friend WithEvents Tab_2 As System.Windows.Forms.TabPage
    Friend WithEvents Tab_3 As System.Windows.Forms.TabPage
    Friend WithEvents txtmucdich As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CmdNext1 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents txtdieukhoan As DevComponents.DotNetBar.Controls.TextBoxX
    Friend WithEvents chk_dongy As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents CmdNext2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents Group_2 As System.Windows.Forms.GroupBox
    Friend WithEvents Group_3 As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonX2 As DevComponents.DotNetBar.ButtonX
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Lst_mh As System.Windows.Forms.ListView
    Friend WithEvents tentruong As System.Windows.Forms.ColumnHeader
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txttenxa As System.Windows.Forms.Label
    Friend WithEvents txtmatinh As System.Windows.Forms.TextBox
    Friend WithEvents txttenhuyen As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtmaxa As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtmahuyen As System.Windows.Forms.TextBox
    Friend WithEvents txttentinh As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents CmdThayDoi As System.Windows.Forms.Button
    Friend WithEvents txtFilename As System.Windows.Forms.TextBox
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog

End Class
