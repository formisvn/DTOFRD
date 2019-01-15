<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TestForm))
        Me.Dulieu = New System.Windows.Forms.DataGridView
        Me.mnu_phai = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnu_XuatExcel = New System.Windows.Forms.ToolStripMenuItem
        Me.Mnu_Thongtin = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnu_ThongtinLo = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.mnu_Excel2 = New System.Windows.Forms.ToolStripMenuItem
        Me.Mnu_ThongTin2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.Mnu_XemThongTin2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.Mnu_Excel3 = New System.Windows.Forms.ToolStripMenuItem
        Me.txtmenu = New System.Windows.Forms.Label
        Me.Mnu_XoaDienBien = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnu_xoadb = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.Mnu_LoMoi = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.mnu_logockocokiemke = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        CType(Me.Dulieu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mnu_phai.SuspendLayout()
        Me.Mnu_Thongtin.SuspendLayout()
        Me.Mnu_ThongTin2.SuspendLayout()
        Me.Mnu_XoaDienBien.SuspendLayout()
        Me.Mnu_LoMoi.SuspendLayout()
        Me.SuspendLayout()
        '
        'Dulieu
        '
        Me.Dulieu.AllowUserToAddRows = False
        Me.Dulieu.AllowUserToDeleteRows = False
        Me.Dulieu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dulieu.ContextMenuStrip = Me.mnu_phai
        Me.Dulieu.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Dulieu.Location = New System.Drawing.Point(0, 0)
        Me.Dulieu.Margin = New System.Windows.Forms.Padding(2)
        Me.Dulieu.Name = "Dulieu"
        Me.Dulieu.ReadOnly = True
        Me.Dulieu.RowTemplate.Height = 24
        Me.Dulieu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Dulieu.Size = New System.Drawing.Size(796, 376)
        Me.Dulieu.TabIndex = 0
        '
        'mnu_phai
        '
        Me.mnu_phai.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnu_phai.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_XuatExcel})
        Me.mnu_phai.Name = "mnu_phai"
        Me.mnu_phai.Size = New System.Drawing.Size(146, 26)
        '
        'mnu_XuatExcel
        '
        Me.mnu_XuatExcel.Image = CType(resources.GetObject("mnu_XuatExcel.Image"), System.Drawing.Image)
        Me.mnu_XuatExcel.Name = "mnu_XuatExcel"
        Me.mnu_XuatExcel.Size = New System.Drawing.Size(145, 22)
        Me.mnu_XuatExcel.Text = "Xuất ra excel"
        '
        'Mnu_Thongtin
        '
        Me.Mnu_Thongtin.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mnu_Thongtin.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_ThongtinLo, Me.ToolStripSeparator1, Me.mnu_Excel2})
        Me.Mnu_Thongtin.Name = "mnu_phai"
        Me.Mnu_Thongtin.Size = New System.Drawing.Size(200, 54)
        '
        'mnu_ThongtinLo
        '
        Me.mnu_ThongtinLo.Image = CType(resources.GetObject("mnu_ThongtinLo.Image"), System.Drawing.Image)
        Me.mnu_ThongtinLo.Name = "mnu_ThongtinLo"
        Me.mnu_ThongtinLo.Size = New System.Drawing.Size(199, 22)
        Me.mnu_ThongtinLo.Text = "Xem Thông tin lô rừng"
        Me.mnu_ThongtinLo.Visible = False
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(196, 6)
        Me.ToolStripSeparator1.Visible = False
        '
        'mnu_Excel2
        '
        Me.mnu_Excel2.Image = CType(resources.GetObject("mnu_Excel2.Image"), System.Drawing.Image)
        Me.mnu_Excel2.Name = "mnu_Excel2"
        Me.mnu_Excel2.Size = New System.Drawing.Size(199, 22)
        Me.mnu_Excel2.Text = "Xuất ra excel"
        '
        'Mnu_ThongTin2
        '
        Me.Mnu_ThongTin2.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mnu_ThongTin2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Mnu_XemThongTin2, Me.ToolStripSeparator2, Me.Mnu_Excel3})
        Me.Mnu_ThongTin2.Name = "mnu_phai"
        Me.Mnu_ThongTin2.Size = New System.Drawing.Size(200, 54)
        '
        'Mnu_XemThongTin2
        '
        Me.Mnu_XemThongTin2.Image = CType(resources.GetObject("Mnu_XemThongTin2.Image"), System.Drawing.Image)
        Me.Mnu_XemThongTin2.Name = "Mnu_XemThongTin2"
        Me.Mnu_XemThongTin2.Size = New System.Drawing.Size(199, 22)
        Me.Mnu_XemThongTin2.Text = "Xem Thông tin lô rừng"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(196, 6)
        '
        'Mnu_Excel3
        '
        Me.Mnu_Excel3.Image = CType(resources.GetObject("Mnu_Excel3.Image"), System.Drawing.Image)
        Me.Mnu_Excel3.Name = "Mnu_Excel3"
        Me.Mnu_Excel3.Size = New System.Drawing.Size(199, 22)
        Me.Mnu_Excel3.Text = "Xuất ra excel"
        '
        'txtmenu
        '
        Me.txtmenu.AutoSize = True
        Me.txtmenu.Location = New System.Drawing.Point(421, 104)
        Me.txtmenu.Name = "txtmenu"
        Me.txtmenu.Size = New System.Drawing.Size(0, 13)
        Me.txtmenu.TabIndex = 3
        Me.txtmenu.Visible = False
        '
        'Mnu_XoaDienBien
        '
        Me.Mnu_XoaDienBien.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mnu_XoaDienBien.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_xoadb, Me.ToolStripSeparator3, Me.ToolStripMenuItem2})
        Me.Mnu_XoaDienBien.Name = "mnu_phai"
        Me.Mnu_XoaDienBien.Size = New System.Drawing.Size(233, 54)
        '
        'mnu_xoadb
        '
        Me.mnu_xoadb.Image = CType(resources.GetObject("mnu_xoadb.Image"), System.Drawing.Image)
        Me.mnu_xoadb.Name = "mnu_xoadb"
        Me.mnu_xoadb.Size = New System.Drawing.Size(232, 22)
        Me.mnu_xoadb.Text = "Xóa các diễn biến đang chọn"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(229, 6)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Image = CType(resources.GetObject("ToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(232, 22)
        Me.ToolStripMenuItem2.Text = "Xuất ra excel"
        '
        'Mnu_LoMoi
        '
        Me.Mnu_LoMoi.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mnu_LoMoi.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnu_logockocokiemke, Me.ToolStripSeparator4, Me.ToolStripMenuItem3})
        Me.Mnu_LoMoi.Name = "mnu_phai"
        Me.Mnu_LoMoi.Size = New System.Drawing.Size(283, 76)
        '
        'mnu_logockocokiemke
        '
        Me.mnu_logockocokiemke.Image = CType(resources.GetObject("mnu_logockocokiemke.Image"), System.Drawing.Image)
        Me.mnu_logockocokiemke.Name = "mnu_logockocokiemke"
        Me.mnu_logockocokiemke.Size = New System.Drawing.Size(282, 22)
        Me.mnu_logockocokiemke.Text = "Tìm Lô gốc không có lịch sử 1-1-2014"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(279, 6)
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Image = CType(resources.GetObject("ToolStripMenuItem3.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(282, 22)
        Me.ToolStripMenuItem3.Text = "Xuất ra excel"
        '
        'TestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(796, 376)
        Me.Controls.Add(Me.txtmenu)
        Me.Controls.Add(Me.Dulieu)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "TestForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TestForm"
        CType(Me.Dulieu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mnu_phai.ResumeLayout(False)
        Me.Mnu_Thongtin.ResumeLayout(False)
        Me.Mnu_ThongTin2.ResumeLayout(False)
        Me.Mnu_XoaDienBien.ResumeLayout(False)
        Me.Mnu_LoMoi.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Dulieu As System.Windows.Forms.DataGridView
    Friend WithEvents mnu_phai As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnu_XuatExcel As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Mnu_Thongtin As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnu_ThongtinLo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnu_Excel2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Mnu_ThongTin2 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents Mnu_XemThongTin2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Mnu_Excel3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtmenu As System.Windows.Forms.Label
    Friend WithEvents Mnu_XoaDienBien As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnu_xoadb As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Mnu_LoMoi As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents mnu_logockocokiemke As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
End Class
