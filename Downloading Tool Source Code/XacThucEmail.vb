Public Class XacThucEmail
    Public em As String = ""
    Dim dem As Byte = 0
    Private Sub XacThucEmail_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If mlang = "vi" Then
            Me.Text = "Xác thực email"
            Me.cmdChapnhan.Text = "Xác thực"
            Me.lab_thongbao.Text = "Một mã xác thực Email đã được gửi về email [" & em & "], kiểm tra email và nhập mã xác thực vào ô bên dưới. Nếu không tìm thấy trong Hộp thư chính vui lòng kiểm tra trong Hộp thư rác"
        Else
            Me.Text = "Email confirmation"
            Me.cmdChapnhan.Text = "Confirm"
            Me.lab_thongbao.Text = "One verify code was sent to email [" & em & "], get code and input into Download Tool verify windows. your are able to check Spam Box if it's not appeared in Inbox"
        End If
    End Sub

    Private Sub cmdChapnhan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChapnhan.Click
        mXacThucEmail = (Me.txtmaso.Text = Me.txtms.Text)
        If Not mXacThucEmail Then
            dem += 1
            MsgBox(IIf(mlang = "vi", "Sai mã số xác thực Email, kiểm tra lại!", "Verify Code invalid, check again ..."), MsgBoxStyle.Exclamation, "Thông báo")
            If dem = 5 Then
                Me.Close()
            End If
        Else
            SaveSetting("app", "DownloadTool", "email", em)
            SaveSetting("app", "DownloadTool", "verifydate", Me.txtngayxacthuc.Text)
            Me.Close()
        End If
    End Sub
End Class