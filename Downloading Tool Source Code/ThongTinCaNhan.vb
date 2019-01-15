
Imports System.Web
Imports System.Net
Imports System.Xml
Public Class ThongTinCaNhan
    Dim tabTruong As DataTable = New Dulieu.TruongDataTable
    Dim WithEvents WC As New WebClient
    Dim luot_download As Byte = 1
    Dim tong_file_download As Byte = 5
    Dim frmtt As Tientrinh2
    Dim tmdich As String = Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\")) + "\Data"
    Dim loi As Boolean = False
    Dim first As Boolean = True
    Dim _ngaycap As Date
    Sub kiemtra()

        If Me.txthoten.Text.Trim.Length = 0 Then
            MsgBox(IIf(mlang = "vi", "Thiếu thông tin họ tên cá nhân tải dữ liệu", "Miss fullname info"), MsgBoxStyle.Exclamation, "Thông báo")
            Me.txthoten.Focus()
            loi = True
            Return
        End If
        If Me.txtcmnd.Text.Trim.Length = 0 Then
            MsgBox(IIf(mlang = "vi", "Thiếu thông tin số CMND", "Miss ID/Passport No. info"), MsgBoxStyle.Exclamation, "Thông báo")
            Me.txtcmnd.Focus()
            loi = True
            Return
        End If
        If Me.txtngaycap.Text.Trim.Length = 0 Then
            MsgBox(IIf(mlang = "vi", "Thiếu thông tin ngày cấp!", "Miss date of issue info"), MsgBoxStyle.Exclamation, "Thông báo")
            Me.txtngaycap.Focus()
            loi = True
            Return
        End If
        'Dim _mdate As String = ""
        'If IsDate(Me.txtngaycap.Text.Replace(".", "/")) Then
        '    _mdate = Me.txtngaycap.Text
        'Else
        '    _mdate = Me.txtngaycap.Text.Substring(3, 2) + "/" + Me.txtngaycap.Text.Substring(0, 2) + "/" + Me.txtngaycap.Text.Substring(6, 4)
        'End If
        _ngaycap = New Date(Me.txtngaycap.Text.Substring(6, 4), Me.txtngaycap.Text.Substring(3, 2), Me.txtngaycap.Text.Substring(0, 2))
        'MsgBox(ngaycap.ToString)
        If Not IsDate(_ngaycap) Then
            MsgBox(IIf(mlang = "vi", "Định dạng ngày không đúng!", "Value of date invalid"), MsgBoxStyle.Exclamation, "Thông báo")
            Me.txtngaycap.Focus()
            loi = True
            Return
        End If
        If Me.txtnoicap.Text.Trim.Length = 0 Then
            MsgBox(IIf(mlang = "vi", "Thiếu thông tin nơi cấp CMND!", "Miss place of issue info"), MsgBoxStyle.Exclamation, "Thông báo")
            Me.txtngaycap.Focus()
            loi = True
            Return
        End If
        If Me.txtgioitinh.Text.Trim.Length = 0 Then
            MsgBox(IIf(mlang = "vi", "Thiếu thông tin giới tính!", "Miss Sex info"), MsgBoxStyle.Exclamation, "Thông báo")
            Me.txtgioitinh.Focus()
            loi = True
            Return
        End If
        If Me.txttochuc.Text.Trim.Length = 0 Then
            MsgBox(IIf(mlang = "vi", "Thiếu thông tin tổ chức!", "Miss Organization info"), MsgBoxStyle.Exclamation, "Thông báo")
            Me.txttochuc.Focus()
            loi = True
            Return
        End If
        If Me.txtemail.Text.Trim.Length = 0 Then
            MsgBox(IIf(mlang = "vi", "Thiếu thông tin email!", "Miss Email info"), MsgBoxStyle.Exclamation, "Thông báo")
            Me.txtemail.Focus()
            loi = True
            Return
        End If
        If Not Me.txtemail.Text.Contains("@") Or Not Me.txtemail.Text.Contains(".") Then
            MsgBox(IIf(mlang = "vi", "Email chưa đúng định dạng!", "Email invalid"), MsgBoxStyle.Exclamation, "Thông báo")
            Me.txtemail.Focus()
            loi = True
            Return
        End If
        If Me.txtmucdich.Text.Trim.Length = 0 Then
            MsgBox(IIf(mlang = "vi", "Thiếu thông tin mục đích tải dữ liệu!", "Miss porpuse of downloading data info"), MsgBoxStyle.Exclamation, "Thông báo")
            Me.txtmucdich.Focus()
            loi = True
            Return
        End If
    End Sub
    Private Sub CmdNext1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdNext1.Click
        loi = False
        kiemtra()
        If Not loi Then
            'Kiểm tra Email 
            memail = ""
            mngayxacthuc = ""
            Try
                memail = GetSetting("app", "DownloadTool", "email")
                mngayxacthuc = GetSetting("app", "DownloadTool", "verifydate")
            Catch ex As Exception

            End Try
            If memail.Trim.Length = 0 Then
                Email_Verify()
            Else
                If memail <> Me.txtemail.Text Then
                    Email_Verify()
                Else
                    Try
                        If Date.Today.AddDays(-3) >= CDate(mngayxacthuc.Replace(".", "/")) Then
                            Email_Verify()
                        End If
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        Email_Verify()
                    End Try
                End If
            End If

            Dim f As New DieuKhoan
            f.Show()
            mhoten = Me.txthoten.Text
            msocmnd = Me.txtcmnd.Text
            mngaycap = Me.txtngaycap.Text
            mnoicap = Me.txtnoicap.Text
            mgioitinh = Me.txtgioitinh.Text
            mtochuc = Me.txttochuc.Text
            mdiachi = Me.txtdiachi.Text
            mdienthoai = Me.txtdienthoai.Text
            memail = Me.txtemail.Text
            mmucdichsd = Me.txtmucdich.Text
            Me.Close()
        End If
    End Sub
    Sub Email_Verify()
        mXacThucEmail = False
        Dim rd As New Random
        Dim maso As String = rd.Next(10000, 99999)
        Dim clsE As New Cls_Gmail
        clsE.NguoiNhan = Me.txtemail.Text
        clsE.username = "formisIIvn@gmail.com"
        clsE.password = "Fmvn2016"
        Dim thongtin As String = ""
        If mlang = "vi" Then
            thongtin += "  ------------- XÁC THỰC EMAIL -------------  " + Chr(13) + Chr(13)
            thongtin += "Để xác thực EMail ngươi dùng là hợp lệ, bạn vui lòng nhập mã số dưới đây vào ô xác thực trên công cụ tải về." + Chr(13)
            thongtin += "Mã số: " + maso + Chr(13)
        Else
            thongtin += "  ------------- VERIFY EMAIL -------------  " + Chr(13) + Chr(13)
            thongtin += "In order to verify your email, please get code from this email and input into Download Tool." + Chr(13)
            thongtin += "Verify code: " + maso + Chr(13)
        End If


        clsE.noidung = thongtin
        clsE.tenBC = memail
        clsE.TieuDe = IIf(mlang = "vi", "Xác thực Email người dùng", "Verify user email")
        Dim f3 As New Wait
        f3.Show()
        Application.DoEvents()
        clsE.SendMail1()
        f3.Close()
        first = False
        Dim f2 As New XacThucEmail
        f2.em = Me.txtemail.Text
        f2.txtngayxacthuc.Text = Date.Today.ToString.Substring(0, 10)
        f2.txtms.Text = maso

        f2.ShowDialog()
    End Sub
    Private Sub ThongTinCaNhan_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        Try
            If (Not mXacThucEmail) And (Not first) Then
                Me.Close()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ThongTinCaNhan_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyData = Keys.Enter Then
            SendKeys.Send("{Tab}")
        End If
    End Sub

    Private Sub ThongTinCaNhan_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim _defaultLang As String = ""
        Try
            _defaultLang = GetSetting("app", "DownloadTool", "language")
            If _defaultLang.Trim.Length <> 0 Then
                mlang = _defaultLang
            End If
        Catch ex As Exception
        End Try

        Try
            Me.Load_Language(mlang)
        Catch ex As Exception
        End Try
    End Sub
    Sub Load_tochuc()
        Me.txttochuc.Text = ""
        Dim tab_tochuc As DataTable = New Dulieu.tochucDataTable
        Dim tochuc_file As String = ""
        tochuc_file = Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\")) + "\Data\tochuc.xml"
        tab_tochuc.ReadXml(tochuc_file)
        'Dim f As New TestForm
        'f.Dulieu.DataSource = tab_tochuc
        'f.Show()
        Me.txttochuc.Items.Clear()
        For Each r As DataRow In tab_tochuc.Rows
            Me.txttochuc.Items.Add(r("tentc_" + mlang))
        Next
    End Sub
    Sub Load_Gioitinh()
        Me.txtgioitinh.Items.Clear()
        If mlang = "vi" Then
            Me.txtgioitinh.Items.Add("Nam")
            Me.txtgioitinh.Items.Add("Nữ")
            Me.txtgioitinh.Items.Add("Không xác định")
        Else
            Me.txtgioitinh.Items.Add("Male")
            Me.txtgioitinh.Items.Add("Female")
            Me.txtgioitinh.Items.Add("Unknown")
        End If
    End Sub
    Sub Load_Language(ByVal Lang As String)
        Dim lang_file As String = ""

        lang_file = Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\")) + "\Data\lang_" & Lang & ".xml"
        Dim tabLang As DataTable
        If Lang = "en" Then
            tabLang = New Dulieu.lang_enDataTable
            Me.Text = "VIET NAM FOREST DATABASE DOWNLOAD TOOL      Version " + mphienban
            Me.mnu_capnhat.Text = "Update"
            Me.mnu_capnhat_hanhchinh.Text = "Update The Administrative Informations"
            Me.mnu_phienban.Text = "About ..."
            Me.language.Text = "NGÔN NGỮ"
            Me.mnu_Vietnamese.Text = "Tiếng Việt"
            Me.mnu_EngLish.Text = "Tiếng Anh"

        Else
            Me.Text = "CÔNG CỤ TẢI DỮ LIỆU TÀI NGUYÊN RỪNG     phiên bản: " + mphienban
            tabLang = New Dulieu.lang_viDataTable
            Me.mnu_capnhat.Text = "Cập nhật"
            Me.mnu_capnhat_hanhchinh.Text = "Cập nhật thông tin hành chính"
            Me.mnu_phienban.Text = "Phiên bản ..."
            Me.language.Text = "LANGUAGE"
            Me.mnu_Vietnamese.Text = "Vietnamese"
            Me.mnu_EngLish.Text = "English"
        End If
        tabLang.ReadXml(lang_file)
        Dim r As DataRow = tabLang.Rows(0)
        Dim col_num As Byte = 0
        'Duyệt các control trong form 
        For Each c As DataColumn In tabLang.Columns
            For Each c2 As Control In Me.Controls
                If c2.Name = c.Caption Then
                    c2.Text = r(col_num).ToString
                End If
            Next
            For Each c2 As Control In Me.Group_1.Controls
                If c2.Name = c.Caption Then
                    c2.Text = r(col_num).ToString
                End If
            Next
            col_num += 1
        Next
        Me.Load_tochuc()
        Me.Load_Gioitinh()
    End Sub
    Private Sub cmdLuuThongTin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLuuThongTin.Click
        loi = False
        kiemtra()
        If Not loi Then
            Try
                SaveSetting("app", "DownloadTool", "hoten", Me.txthoten.Text)
                SaveSetting("app", "DownloadTool", "socmnd", Me.txtcmnd.Text)
                'Dim _mdate As String = ""
                'If IsDate(Me.txtngaycap.Text) Then
                '    _mdate = Me.txtngaycap.Text
                'Else
                '    _mdate = Me.txtngaycap.Text.Substring(3, 2) + "/" + Me.txtngaycap.Text.Substring(0, 2) + "/" + Me.txtngaycap.Text.Substring(6, 4)
                'End If

                _ngaycap = New Date(Me.txtngaycap.Text.Substring(6, 4), Me.txtngaycap.Text.Substring(3, 2), Me.txtngaycap.Text.Substring(0, 2))
                SaveSetting("app", "DownloadTool", "ngaycap", _ngaycap)
                SaveSetting("app", "DownloadTool", "noicap", Me.txtnoicap.Text)
                SaveSetting("app", "DownloadTool", "gioitinh", Me.txtgioitinh.Text)
                SaveSetting("app", "DownloadTool", "tochuc", Me.txttochuc.Text)
                SaveSetting("app", "DownloadTool", "diachi", Me.txtdiachi.Text)
                SaveSetting("app", "DownloadTool", "dienthoai", Me.txtdienthoai.Text)
                SaveSetting("app", "DownloadTool", "mucdich", Me.txtmucdich.Text)

                MsgBox(IIf(mlang = "vi", "Lưu thành công thông tin người dùng!", "User information was saved successfully"), MsgBoxStyle.Exclamation, "Thông báo")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If

    End Sub
    Sub luu_regedit(ByVal str As String)
        SaveSetting("app", "DownloadTool", "Info", str)
    End Sub
    Private Sub CmdNapthongtin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdNapthongtin.Click
        Try
            Me.txthoten.Text = GetSetting("app", "DownloadTool", "hoten")
            Me.txtcmnd.Text = GetSetting("app", "DownloadTool", "socmnd")
            Dim _luudate As String = GetSetting("app", "DownloadTool", "ngaycap")
            Me.txtngaycap.Text = _luudate.Replace(".", "/")
            Me.txtnoicap.Text = GetSetting("app", "DownloadTool", "noicap")
            Me.txtgioitinh.Text = GetSetting("app", "DownloadTool", "gioitinh")
            Me.txttochuc.Text = GetSetting("app", "DownloadTool", "tochuc")
            Me.txtdiachi.Text = GetSetting("app", "DownloadTool", "diachi")
            Me.txtdienthoai.Text = GetSetting("app", "DownloadTool", "dienthoai")
            Me.txtemail.Text = GetSetting("app", "DownloadTool", "email")
            Me.txtmucdich.Text = GetSetting("app", "DownloadTool", "mucdich")
        Catch ex As Exception
            MsgBox(IIf(mlang = "vi", "Chưa có thông tin!", "There are no information to save"), MsgBoxStyle.Exclamation, "Thông báo")
        End Try
    End Sub

    Private Sub mnu_capnhat_hanhchinh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_capnhat_hanhchinh.Click
        Try
            frmtt = New Tientrinh2
            frmtt.Show()
            frmtt.tieude.Text = IIf(mlang = "vi", "Thực hiện cập nhật dữ liệu các trường chỉ số!", "Updating ...").ToUpper
            frmtt.ProgressBar_main.Value = luot_download / tong_file_download * 100
            Application.DoEvents()
            WC.DownloadFileAsync(New Uri("http://formis.co.nf/download/danhmuctruong.xml"), tmdich + "\danhmuctruong.xml")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub WC_DownloadProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs) Handles WC.DownloadProgressChanged
        'Hiện tiến trình tải về
        frmtt.ProgressBar_client.Value = e.ProgressPercentage
        frmtt.phantram_client.Text = frmtt.ProgressBar_client.Value.ToString + " %"
        frmtt.tieude_client.Text = IIf(mlang = "vi", "Đang tải về: ", "Downloading ...") + Format((e.BytesReceived / 1024), "###,###,##0") + " KB"
    End Sub
    Private Sub WC_DownloadFileCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs) Handles WC.DownloadFileCompleted
        Select Case luot_download
            Case 1
                luot_download = 2
                frmtt.ProgressBar_main.Value = luot_download / tong_file_download * 100
                frmtt.tieude.Text = IIf(mlang = "vi", "Thực hiện cập nhật dữ liệu các bộ dữ liệu chia sẻ!", "Updating ...").ToUpper
                WC.DownloadFileAsync(New Uri("http://formis.co.nf/download/datasharing.xml"), tmdich + "\datasharing.xml")
            Case 2
                luot_download = 3
                frmtt.ProgressBar_main.Value = luot_download / tong_file_download * 100
                frmtt.tieude.Text = IIf(mlang = "vi", "Thực hiện cập nhật dữ liệu danh mục các tỉnh/thành phố!", "Updating ...").ToUpper
                WC.DownloadFileAsync(New Uri("http://formis.co.nf/download/tinh.xml"), tmdich + "\tinh.xml")
            Case 3
                luot_download = 4
                frmtt.ProgressBar_main.Value = luot_download / tong_file_download * 100
                frmtt.tieude.Text = IIf(mlang = "vi", "Thực hiện cập nhật dữ liệu danh mục các huyện!", "Updating ...").ToUpper
                WC.DownloadFileAsync(New Uri("http://formis.co.nf/download/huyen.xml"), tmdich + "\huyen.xml")
            Case 4
                luot_download = 5
                frmtt.ProgressBar_main.Value = luot_download / tong_file_download * 100
                frmtt.tieude.Text = IIf(mlang = "vi", "Thực hiện cập nhật dữ liệu danh mục các xã!", "Updating ...").ToUpper
                WC.DownloadFileAsync(New Uri("http://formis.co.nf/download/xa.xml"), tmdich + "\xa.xml")
            Case Else
                luot_download = 1
                MsgBox("Cập nhật dữ liệu hành chính và bộ dữ liệu tải về thành công!", MsgBoxStyle.Exclamation, "Thông báo")
                frmtt.Close()
        End Select
        frmtt.phantram_main.Text = frmtt.ProgressBar_main.Value.ToString + " %"
    End Sub

    Private Sub mnu_phienban_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_phienban.Click
        Dim f As New Splash
        f.Show()
    End Sub

    Private Sub mnu_EngLish_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_EngLish.Click
        Dim tb As MsgBoxResult = MsgBox("Do you want to set English is default language?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Notification")
        If tb = MsgBoxResult.Yes Then
            SaveSetting("app", "DownloadTool", "language", "en")
        End If
        mlang = "en"
        Me.Load_Language(mlang)
    End Sub

    Private Sub mnu_Vietnamese_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnu_Vietnamese.Click
        Dim tb As MsgBoxResult = MsgBox("Bạn có muốn chọn Tiếng Việt làm ngôn ngữ mặc định không?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Thông báo")
        If tb = MsgBoxResult.Yes Then
            SaveSetting("app", "DownloadTool", "language", "vi")
        End If
        mlang = "vi"
        Me.Load_Language(mlang)
    End Sub

    Private Sub language_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles language.Click

    End Sub
End Class
