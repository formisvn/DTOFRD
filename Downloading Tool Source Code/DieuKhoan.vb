
Imports System.Web
Imports System.Net
Public Class DieuKhoan
    Dim tabTruong As DataTable = New Dulieu.TruongDataTable

    Private Sub chk_dongy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_dongy.CheckedChanged
        Me.CmdNext2.Enabled = Me.chk_dongy.Checked
    End Sub

    Private Sub DieuKhoan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.load_language()
    End Sub

    Private Sub CmdNext2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdNext2.Click
        Dim f As New TaiVe
        f.Show()
        Me.Close()
    End Sub
    Sub load_language()
        If mlang = "en" Then
            Me.Text = "VIET NAM FOREST DATABASE DOWNLOAD TOOL      Version " + mphienban
            Me.chk_dongy.Text = "I have read and agree to the above Data License Agreement"
            Me.CmdNext2.Text = "Next"
            Me.Group_Banquyen_en.Visible = True
            Me.Group_banquyen_vi.Visible = False

        Else
            Me.Text = "CÔNG CỤ TẢI DỮ LIỆU TÀI NGUYÊN RỪNG     phiên bản: " + mphienban
            Me.chk_dongy.Text = "Tôi đã đọc và đồng ý với các điều khoản về bản quyền ở trên"
            Me.CmdNext2.Text = "Tiếp tục"
            Me.Group_Banquyen_en.Visible = False
            Me.Group_banquyen_vi.Visible = True
        End If
    End Sub
End Class
