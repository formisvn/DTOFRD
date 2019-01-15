Public Class Wait

    Private Sub Wait_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If mlang = "vi" Then
            Me.Text = "Cửa sổ chờ"
            'Me.lab_thongbao.Text = "Đây là lần đầu bạn sử dụng Công cụ tải dữ liệu, hệ thống sẽ tiến hành xác thực Email bạn đăng ký."
            Me.lab_thongbao.Text += "Đang gửi Email xác thực vào Email bạn đăng ký, vui lòng chờ ..."
        Else
            Me.Text = "Wait for confirmation code..."
            'Me.lab_thongbao.Text = "This is the first time you use the Download Tool or over three days from day you verify your email, Your email will be verified."
            Me.lab_thongbao.Text = "One confirmatory code is sending to your registry email, please wait ..."
        End If
    End Sub
End Class