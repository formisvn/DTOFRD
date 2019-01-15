Public Class Splash

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Picture_vi.Click
        Me.Close()
    End Sub

    Private Sub Splash_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lab_phienban.Text = "Phiên bản: " + mphienban
    End Sub
End Class