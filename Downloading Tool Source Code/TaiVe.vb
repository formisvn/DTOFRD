Imports RestSharp
Imports Newtonsoft.Json
Imports System.Web
Imports System.Net
Imports System.Threading

Public Class TaiVe
    Dim tabTruong As DataTable = New Dulieu.TruongDataTable
    Dim WithEvents WC As New WebClient
    Private _geoservername As String = ""
    Private _truongchiso As Boolean = False
    Private trd As Thread
    Dim tongdungluongtaive As String = ""
    Dim dungluongtruoc As Long = 0
    Dim dungluongsau As Long = 0
    Dim mfiletype As String = "SHAPE-ZIP"
    Private Sub txtmatinh_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmatinh.TextChanged
        Me.txttentinh.Text = ""
        Me.txttenhuyen.Text = ""
        Me.txttenxa.Text = ""
    End Sub

    Private Sub txtmahuyen_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmahuyen.TextChanged
        Me.txttenhuyen.Text = ""
        Me.txttenxa.Text = ""
    End Sub

    Private Sub txtmaxa_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmaxa.TextChanged
        Me.txttenxa.Text = ""
    End Sub

    Private Sub txtmaxa_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtmaxa.Validated
        laytenxa()
    End Sub
    Public Sub laytenxa()
        If Me.txtmaxa.Text.Trim.Length > 0 Then
            Dim cls As New Cls_DMXa
            cls.mahuyen = Me.txtmahuyen.Text
            Me.txttenxa.Text = cls.laytenxa(Me.txtmaxa.Text, Me.txtmahuyen.Text)
            Application.DoEvents()
            If Me.txttenxa.Text.Trim.Length = 0 Then
                Dim frm As New Lst_Xa2
                frm._Mahuyen = Me.txtmahuyen.Text
                frm.TopMost = True
                frm.txtten.Text = Me.txtmaxa.Text
                frm.ShowDialog()
                Me.txtmaxa.Text = mmaxa
                Me.txttenxa.Text = mtenxa
            End If
        End If
    End Sub
    Public Sub laytenhuyen()
        If Me.txtmahuyen.Text.Trim.Length > 0 Then
            Dim cls As New Cls_DMHuyen
            Me.txttenhuyen.Text = cls.laytenhuyen(Me.txtmahuyen.Text, Me.txtmatinh.Text)
            Application.DoEvents()
            If Me.txttenhuyen.Text.Trim.Length = 0 Then
                Dim frm As New Lst_Huyen2
                frm.TopMost = True
                frm.txtmatinh.Text = Me.txtmatinh.Text
                If Me.txtmatinh.Text.Trim.Length = 0 Then
                    frm.txtten.Text = Me.txtmahuyen.Text

                End If
                frm.ShowDialog()
                Me.txtmahuyen.Text = mmahuyen
                Me.txttenhuyen.Text = mtenhuyen
            End If
        End If
    End Sub
    Public Sub laytentinh()
        If Me.txtmatinh.Text.Trim.Length > 0 Then
            Dim cls As New Cls_DMTinh
            Me.txttentinh.Text = cls.laytentinh(Me.txtmatinh.Text)
            Application.DoEvents()
            If Me.txttentinh.Text.Trim.Length = 0 Then
                Dim frm As New Lst_Tinh2
                frm.TopMost = True
                frm.txtten.Text = Me.txtmatinh.Text
                frm.ShowDialog()
                Me.txtmatinh.Text = mmatinh
                Me.txttentinh.Text = mtentinh
            End If
        End If
    End Sub

    Private Sub txtmahuyen_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtmahuyen.Validated
        laytenhuyen()
    End Sub

    Private Sub txtmatinh_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtmatinh.Validated
        laytentinh()
    End Sub



    Private Sub CmdThayDoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TaiVe_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{tab}")
        End If
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Load_Language()
        tabTruong.Rows.Clear()
        tabTruong.ReadXml(Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\")) + "\Data\danhmuctruong.xml")
        Dim lstitem As ListViewItem
        Dim tongso As Integer = tabTruong.Rows.Count
        If mlang = "vi" Then
            Me.Lst_mh.Columns(0).Text = "Lựa chọn trường chỉ số"
        Else
            Me.Lst_mh.Columns(0).Text = "Select downloading parameters fields"
        End If
        For Each r As DataRow In tabTruong.Rows
            Try
                lstitem = New ListViewItem(r(IIf(mlang = "vi", "column_name_vi", "column_name_en")).ToString)
                lstitem.Tag = r("column_name").ToString
                lstitem.Checked = True
                lstitem.ImageIndex = 0
                Me.Lst_mh.Items.Add(lstitem)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Next
    End Sub
    Sub Load_dulieu()
        Me.com_chondl.Text = ""
        Dim tab_dt As DataTable = New Dulieu.DatasharingDataTable
        Dim tochuc_file As String = ""
        tochuc_file = Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\")) + "\Data\datasharing.xml"
        tab_dt.ReadXml(tochuc_file)
        Me.com_chondl.Items.Clear()
        For Each r As DataRow In tab_dt.Rows
            Me.com_chondl.Items.Add(r("tendt_" + mlang))
        Next
    End Sub
    Sub Load_Language()
        Dim taive_file As String = ""
        taive_file = Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\")) + "\Data\taive_" & mlang & ".xml"
        Dim tabTaive As DataTable
        If mlang = "en" Then
            Me.Text = "VIET NAM FOREST DATABASE DOWNLOAD TOOL      Version " + mphienban
            tabTaive = New Dulieu.taive_enDataTable
        Else
            Me.Text = "CÔNG CỤ TẢI DỮ LIỆU TÀI NGUYÊN RỪNG     phiên bản: " + mphienban
            tabTaive = New Dulieu.taive_viDataTable
        End If
        tabTaive.ReadXml(taive_file)
        Dim r As DataRow = tabTaive.Rows(0)
        Dim col_num As Byte = 0
        'Duyệt các control trong form 
        For Each c As DataColumn In tabTaive.Columns
            For Each c2 As Control In Me.Controls
                If c2.Name = c.Caption Then
                    c2.Text = r(col_num).ToString
                End If
            Next
            For Each c2 As Control In Me.Group_3.Controls
                If c2.Name = c.Caption Then
                    c2.Text = r(col_num).ToString
                End If
            Next
            For Each c3 As Control In Me.group_hanhchinh.Controls
                If c3.Name = c.Caption Then
                    c3.Text = r(col_num).ToString
                End If
            Next
            For Each c4 As Control In Me.Group_chiso.Controls
                If c4.Name = c.Caption Then
                    c4.Text = r(col_num).ToString
                End If
            Next
            For Each c5 As Control In Me.Group_shapefile.Controls
                If c5.Name = c.Caption Then
                    c5.Text = r(col_num).ToString
                End If
            Next

            col_num += 1
        Next
        Me.Load_dulieu()
        'Me.Load_Gioitinh()
    End Sub
    Private Sub ButtonX2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTaiVe.Click
        'Kiểm tra các điều kiện trước khi thực hiện tải về
        If _geoservername.Trim.Length = 0 Then
            'Nếu chưa chọn bộ dữ liệu cần tải về thì thông báo và hủy quá trình tải về
            MsgBox(IIf(mlang = "vi", "Chọn bộ dữ liệu cần tải về từ máy chủ!", "Choose the forest database that you want to download"), MsgBoxStyle.Exclamation, "Thông báo")
            Me.com_chondl.Focus()
            Return
        End If
        If _geoservername = "dulieu4ck" And (Not Me.chk_1990.Checked) And (Not Me.chk_1995.Checked) And (Not Me.chk_2000.Checked) And (Not Me.chk_2005.Checked) And (Not Me.chk_2010.Checked) Then
            MsgBox(IIf(mlang = "vi", "Chọn dữ liệu năm của 4 chu kỳ", "select year of 4 circles data"), MsgBoxStyle.Exclamation, "Thông báo")
            Return
        End If
        If Me.txtFilename.Text.Trim.Length = 0 Then
            'Nếu chưa chọn Shapefile cần lưu thì thông báo và hủy quá trình tải về
            MsgBox(IIf(mlang = "vi", "Chọn đường dẫn lưu thành Shapefile!", "Choose name of Shapefile."), MsgBoxStyle.Exclamation, "Thông báo")
            Return
        End If
        'If IO.File.Exists(IIf(mfiletype = "csv", Me.txtFilename.Text.Replace(".zip", ".csv"), Me.txtFilename.Text)) Then
        '    'Nếu File lưu thành đã tồn tại trên máy thì thông báo cho người dùng, hỏi người dùng có ghi đè không (chọn Yes hoặc No)
        '    Dim tb As MsgBoxResult = MsgBox(IIf(mlang = "vi", "File này đã tồn tại, bạn có muốn ghi đè không?", "file already exists, do you want to overwrite it?"), MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Thông báo")
        '    If tb = MsgBoxResult.No Then
        '        'Nếu chọn No thì hủy quá trình tải, cho người dùng chọn lại tên khác.
        '        Return
        '    End If
        'End If

        'Tùy chọn đơn vị hành chính
        Dim dk_hanhchinh As String = ""
        If _geoservername.Substring(0, 9) <> "dulieu4ck" Then
            If Me.txtmaxa.Text.Trim.Length > 0 Then
                'Nếu chọn xã thì điều kiện sẽ theo mã xã
                dk_hanhchinh = "&cql_filter=maxa=" + Me.txtmaxa.Text.Trim
            Else
                '/Nếu không chọn xã
                If Me.txtmahuyen.Text.Trim.Length > 0 Then
                    'Nếu chọn huyện thì theo mã huyện
                    dk_hanhchinh = "&cql_filter=mahuyen=" + Me.txtmahuyen.Text.Trim
                Else
                    'Nếu không chọn huyện
                    If Me.txtmatinh.Text.Trim.Length > 0 Then
                        'Nếu chọn tỉnh sẽ theo mã tỉnh
                        dk_hanhchinh = "&cql_filter=matinh=" + Me.txtmatinh.Text.Trim
                    Else
                        'Nếu không chọn đơn vị hành chính thì báo lổi
                        MsgBox(IIf(mlang = "vi", "Bạn cần phải chọn một đơn vị hành chính cần tải dữ liệu về!", "Please select an administrative unit to download the data"), MsgBoxStyle.Exclamation, "Thông báo")
                        Return
                    End If
                End If
            End If

        End If
        Try
            'Nếu các điều kiện trước khi tải hợp lệ thì tiến hành:
            'Khó nút tải về (người dùng không thể bấm thêm trong quá trình đang tải dữ liệu)
            Me.cmdTaiVe.Enabled = False
            'Khóa nút thay đổi tên Shapefile lưu thành (người dùng không được thay đổi tên file trong quá trình tải dữ liệu)
            Me.CmdThayDoi.Enabled = False
            'Bật nút Hủy quá trình tải về
            Me.CmdHuy.Enabled = True
        Catch ex As Exception
            'Nếu gặp lổi, bật các nút lệnh về trạng thái ban đầu
            Me.cmdTaiVe.Enabled = True
            Me.CmdThayDoi.Enabled = True
            Me.CmdHuy.Enabled = False
            'Thông báo lổi
            MsgBox(IIf(mlang = "vi", "Gặp lổi trong quá trình tải dữ liệu, kiểm tra lại đường truyền Internet hoặc liên hệ với người quản trị!", "Downloading was unsuccessfully, check internet connection or contact to administrator"), MsgBoxStyle.Exclamation, "Thông báo")
        End Try
        'Các trường chỉ số được tải về
        Dim cactruong As String = ""
        'nếu bộ cơ sở dữ liệu cho phép tải các trường chỉ số
        If _truongchiso Then
            If mfiletype = "csv" Then
                'Nếu tải file CSV thì bỏ trường GEOM đi
                cactruong = "&propertyName="
                Dim _first As Boolean = True
                For Each i As ListViewItem In Me.Lst_mh.CheckedItems
                    'Các trước phía sau GEOM được lấy từ danh sách chọn
                    If _first Then
                        'Nếu là trường đầu tiên thì không có dấu phẩy ngăn cách các trường
                        cactruong += i.Tag
                        'Hết dòng đầu tiên
                        _first = False
                    Else
                        'Trường thứ 2 trở đi phải có dấu phẩy để ngăn cách các trường với nhau
                        cactruong += "," + i.Tag
                    End If
                Next
            Else
                'Nếu tải Shapefile thì đầu tiên phải là trường GEOM 
                cactruong = "&propertyName=geom"
                'Các trước phía sau GEOM được lấy từ danh sách chọn
                For Each i As ListViewItem In Me.Lst_mh.CheckedItems
                    cactruong += "," + i.Tag
                Next
            End If

        End If

        Dim download_link As String = "http://maps.vnforest.gov.vn:802/geoserver/download/ows?service=WFS&version=1.0.0" & cactruong & "&outputFormat=" & mfiletype & "&format_options=CHARSET:UTF-8&request=GetFeature&typeName=download:" & _geoservername & dk_hanhchinh
        'Me.txtwfs.Text = download_link
        If mlang = "vi" Then
            Me.txttinhtrang.Text = "Đang chuẩn bị cho quá trình tải về ..." + Chr(13) + "Quá trình này có thể mất vài giây hoặc vài phút tùy vào lượng dữ liệu bạn muốn tải về."
        Else
            Me.txttinhtrang.Text = "Prepare to downloading ..." + Chr(13) + "It takes about 1 minute or more depend on data capacity."
        End If
        Me.txttocdo.Text = ""
        Me.Timer1.Enabled = True
        Me.Timer2.Enabled = True
        'Thực hiện tải vè theo link
        WC.DownloadFileAsync(New Uri(download_link.Trim), IIf(mfiletype = "csv", Me.txtFilename.Text.Replace("zip", "csv"), Me.txtFilename.Text))
    End Sub
    Private Sub WC_DownloadFileCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs) Handles WC.DownloadFileCompleted
        'Khi quá trình tải hoàn thành
        If Me.txttinhtrang.Text <> IIf(mlang = "vi", "Hủy quá trình tải về!", "Downloading process was canceled") Then
            'Nếu không phải do người dùng bấm nút hủy tải về thì thực hiện gửi email về mail người quản trị
            Dim clsE As New Cls_Gmail
            clsE.NguoiNhan = "nxdaiqt@gmail.com"
            clsE.username = "formisIIvn@gmail.com"
            clsE.password = "Fmvn2016"
            Dim thongtin As String = ""
            thongtin += "  ------------- THÔNG TIN CÁ NHÂN -------------  " + Chr(13) + Chr(13)
            thongtin += "Họ tên: " + mhoten + Chr(13)
            thongtin += "Số CMND: " + msocmnd + " cấp ngày: " + mngaycap + " Nơi cấp: " + mnoicap + Chr(13)
            thongtin += "Giới tính: " + mgioitinh + Chr(13)
            thongtin += "Tổ chức: " + mtochuc + Chr(13)
            thongtin += "Địa chỉ: " + mdiachi + Chr(13)
            thongtin += "Điện thoại: " + mdienthoai + Chr(13)
            thongtin += "Email: " + memail + Chr(13)
            thongtin += "Mục đích sử dụng dữ liệu: " + mmucdichsd + Chr(13) + Chr(13)

            thongtin += "  ------------- DỮ LIỆU TẢI VỀ -------------  " + Chr(13) + Chr(13)
            thongtin += "Bộ dữ liệu: " + Me.com_chondl.Text.ToUpper + Chr(13)
            thongtin += "Đơn vị hành chính: " + Me.txttentinh.Text
            If Me.txttenhuyen.Text.Trim.Length > 0 Then
                thongtin += " - " + Me.txttenhuyen.Text
            End If
            If Me.txttenxa.Text.Trim.Length > 0 Then
                thongtin += " - " + Me.txttenxa.Text
            End If
            thongtin += Chr(13) + "Tổng dung lượng tải về: " + tongdungluongtaive
            clsE.noidung = thongtin
            clsE.tenBC = memail
            clsE.TieuDe = "Thông báo tải dữ liệu từ máy chủ trung tâm"
            Me.txttinhtrang.Text = IIf(mlang = "vi", "Chuẩn bị hoàn tất quá trình tải về .....", "Downloading process's going to be successfully during a few seconds ...")
            Application.DoEvents()
            clsE.SendMail1()
            SendLog(mhoten + Chr(13), msocmnd, mngaycap, mnoicap, mgioitinh, mtochuc, mdiachi, memail, mdienthoai, mmucdichsd, 1, DateTime.Now, Me.com_chondl.Text.ToUpper)
            Me.txttinhtrang.Text = IIf(mlang = "vi", "Đã tải về thành công: ", "Forestry data was downloaded successfully: ") + tongdungluongtaive
        End If
        'Trả các tình trạng của điều khiển về trạng thái ban đầu
        Me.Timer1.Enabled = False
        Me.Timer2.Enabled = False
        Me.cmdTaiVe.Enabled = True
        Me.CmdThayDoi.Enabled = True
        Me.CmdHuy.Enabled = False
    End Sub
    Private Sub SendLog(ByVal FullName As String, ByVal IdNumber As String, _
                        ByVal IssueDate As String, ByVal Issuer As String, ByVal gender As String, ByVal Organization As String, _
                        ByVal Address As String, ByVal Email As String, ByVal Mobile As String, ByVal Purpose As String, _
                        ByVal Status As Integer, ByVal DateRequest As Date, ByVal DataSet As String)

        Dim wc As WebClient
        wc = New WebClient
        'MsgBox(IssueDate)
        Dim phancachngay As String = IssueDate.Trim.Substring(2, 1)
        'MsgBox("1")
        Dim downloader As New Cls_DataDownloader
        'MsgBox("2")s
        downloader.fullName = FullName
        'MsgBox("3")
        downloader.idNumber = IdNumber
        'MsgBox("4")
        downloader.issueDate = IssueDate.Replace(".", "/")
        'MsgBox(downloader.issueDate)
        downloader.issuer = Issuer
        'MsgBox(phancachngay)
        downloader.gender = gender
        downloader.organization = Organization
        downloader.address = Address
        downloader.email = Email
        downloader.mobile = Mobile
        downloader.purpose = Purpose
        downloader.status = 1
        downloader.dateRequest = DateRequest
        downloader.dataset = DataSet

        Dim serializeSetting As New JsonSerializerSettings
   
        'serializeSetting.DateFormatString = "dd" + phancachngay + "MM" + phancachngay + "yyyy"
        serializeSetting.DateFormatString = "dd/MM/yyyy"
        Dim jsonData As String = JsonConvert.SerializeObject(downloader, serializeSetting)
        Console.WriteLine(jsonData)
        Try
            Dim restClient As New RestClient("http://statics.vnforest.gov.vn/")
            Dim restRequest As New RestRequest("data_downloader", Method.POST)
            restRequest.AddHeader("Content-Type", "application/json")
            restRequest.AddHeader("Accept", "application/json")
            restRequest.AddJsonBody(jsonData)
            restRequest.RequestFormat = DataFormat.Json
            restClient.Execute(restRequest)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub WC_DownloadProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs) Handles WC.DownloadProgressChanged
        'Trong quá trình tải về
        'Hủy lệnh nháy thông báo
        Timer1.Enabled = False
        'hiện tổng dụng lượng đã được tải về đến thời điểm hiện tại
        dungluongsau = e.BytesReceived / 1024
        Me.txttinhtrang.Text = IIf(mlang = "vi", "Đang tải về: ", "Downloading: ") + Format((e.BytesReceived / 1024), "###,###,##0") + " KB"
        tongdungluongtaive = Format((e.BytesReceived / 1024), "###,###,##0") + " KB"
    End Sub
    Private Sub chk_all_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_all.CheckedChanged
        For Each i As ListViewItem In Me.Lst_mh.Items
            i.Checked = Me.chk_all.Checked
        Next
    End Sub

    Private Sub CmdThayDoi_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdThayDoi.Click
        Me.SaveFileDialog1.ShowDialog()
        If Me.SaveFileDialog1.FileName.Trim.Length > 0 Then
            Me.txtFilename.Text = Me.SaveFileDialog1.FileName + IIf(Microsoft.VisualBasic.Right(Me.SaveFileDialog1.FileName, 3) = "zip", "", ".zip")
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles com_chondl.SelectedIndexChanged
        Dim tabDT As DataTable = New Dulieu.DatasharingDataTable
        tabDT.ReadXml(Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\")) + "\Data\Datasharing.xml")
        For Each r As DataRow In tabDT.Select(IIf(mlang = "vi", "tendt_vi='", "tendt_en='") & Me.com_chondl.Text & "'")
            _geoservername = r("geoservername")
            _truongchiso = IIf(r("chiso") = 1, True, False)
            Me.txtmatinh.Visible = IIf(r("tinh") = 1, True, False)
            Me.txttentinh.Visible = IIf(r("tinh") = 1, True, False)
            Me.lab_tinh.Visible = IIf(r("tinh") = 1, True, False)
            Me.txtmahuyen.Visible = IIf(r("huyen") = 1, True, False)
            Me.txttenhuyen.Visible = IIf(r("huyen") = 1, True, False)
            Me.lab_huyen.Visible = IIf(r("huyen") = 1, True, False)
            Me.txtmaxa.Visible = IIf(r("xa") = 1, True, False)
            Me.txttenxa.Visible = IIf(r("xa") = 1, True, False)
            Me.lab_xa.Visible = IIf(r("xa") = 1, True, False)
            Me.Group_chiso.Visible = _truongchiso
            Me.Group_nam.Visible = IIf(r("geoservername") = "dulieu4ck", True, False)
        Next
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.txttinhtrang.BackColor = Color.Aqua Then
            Me.txttinhtrang.BackColor = Color.Chartreuse
        Else
            Me.txttinhtrang.BackColor = Color.Aqua
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        'Tính toán dung lượng tải về mỗi 3 giây 1 lần
        If dungluongtruoc > 0 Then
            Dim tocdo As Long = ((dungluongsau - dungluongtruoc) / 3)
            Dim tt As String = ""
            If tocdo < 200 Then
                tt = IIf(mlang = "vi", " - Kém", " - bad")
            Else
                If tocdo <= 500 Then
                    tt = IIf(mlang = "vi", " - Trung bình", " - Average")
                ElseIf tocdo > 500 Then
                    tt = IIf(mlang = "vi", " - Tốt", " - Good")
                End If
            End If
            Me.txttocdo.Text = IIf(mlang = "vi", "Tốc độ tải về:", "Downloading speed:") + tocdo.ToString + " KB/s" + tt

        End If
        dungluongtruoc = dungluongsau
    End Sub

    Private Sub CmdHuy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdHuy.Click
        WC.CancelAsync()
        Me.txttinhtrang.Text = IIf(mlang = "vi", "Hủy quá trình tải về!", "Downloading processing was canceled")
        Me.txttocdo.Text = ""
    End Sub

    Private Sub CmdCSVFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCSVFile.Click
        mfiletype = "csv"
        Me.ButtonX2_Click(sender, e)
        mfiletype = "SHAPE-ZIP"
    End Sub


 
    Private Sub chk_1990_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_1990.CheckedChanged
        If Me.chk_1990.Checked Then
            _geoservername += Me.chk_1990.Text
        End If
    End Sub

    Private Sub chk_1995_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_1995.CheckedChanged
        If Me.chk_1995.Checked Then
            _geoservername += Me.chk_1995.Text
        End If
    End Sub

    Private Sub chk_2000_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_2000.CheckedChanged
        If Me.chk_2000.Checked Then
            _geoservername += Me.chk_2000.Text
        End If
    End Sub

    Private Sub chk_2005_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_2005.CheckedChanged
        If Me.chk_2005.Checked Then
            _geoservername += Me.chk_2005.Text
        End If
    End Sub

    Private Sub chk_2010_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_2010.CheckedChanged
        If Me.chk_2010.Checked Then
            _geoservername += Me.chk_2010.Text
        End If
    End Sub
End Class
