Public Class Tientrinh2

    Private Sub Tientrinh_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        huy_TT = True
    End Sub

    Private Sub Tientrinh_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        huy_TT = False
        Me.Left_top()
    End Sub
    Public Sub Left_top()
        'Me.Left = Screen.PrimaryScreen.WorkingArea.Right - Me.Width - 2
        'Me.Top = 2
    End Sub

    Private Sub Img_Left_Top_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Img_Left_Top.Click
        Me.Left_top()
    End Sub

    Private Sub link_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Me.Left_top()
        System.Diagnostics.Process.Start("http://www.itechviet.com")
    End Sub
End Class