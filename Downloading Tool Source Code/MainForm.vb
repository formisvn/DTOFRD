
Imports System.Web
Imports System.Net
Public Class MainForm
    Dim tabTruong As DataTable = New Dulieu.TruongDataTable


    Private Sub Next1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdNext1.Click
        Dim f As New MainForm
        f.Show()


        If Me.txthoten.Text.Trim.Length = 0 Then
            MsgBox("Thiếu thông tin họ tên cá nhân tải dữ liệu", MsgBoxStyle.Exclamation, "Thông báo")
            Me.txthoten.Focus()
            Return
        End If
        If Me.txtgioitinh.Text.Trim.Length = 0 Then
            MsgBox("Thiếu thông tin giới tính!", MsgBoxStyle.Exclamation, "Thông báo")
            Me.txtgioitinh.Focus()
            Return
        End If
        If Me.txttochuc.Text.Trim.Length = 0 Then
            MsgBox("Thiếu thông tin tổ chức!", MsgBoxStyle.Exclamation, "Thông báo")
            Me.txttochuc.Focus()
            Return
        End If
        If Me.txtemail.Text.Trim.Length = 0 Then
            MsgBox("Thiếu thông tin email!", MsgBoxStyle.Exclamation, "Thông báo")
            Me.txtemail.Focus()
            Return
        End If
        If Me.txtmucdich.Text.Trim.Length = 0 Then
            MsgBox("Thiếu thông tin mục đích tải dữ liệu!", MsgBoxStyle.Exclamation, "Thông báo")
            Me.txtmucdich.Focus()
            Return
        End If
        Me.Tab.SelectTab(1)
        Me.Group_2.Enabled = True
    End Sub

    Private Sub CmdNext2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdNext2.Click
        If Not Me.chk_dongy.Checked Then
            MsgBox("Bạn chưa đồng ý với các điều khoản về bản quyền!", MsgBoxStyle.Exclamation, "Thông báo")
            Return
        End If
        Me.Tab.SelectTab(2)
        Me.Group_3.Enabled = True
    End Sub

    Private Sub chk_dongy_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_dongy.CheckedChanged
        Me.Group_3.Enabled = (Me.chk_dongy.Checked)
    End Sub

    Private Sub CmdThayDoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdThayDoi.Click
        Me.SaveFileDialog1.ShowDialog()
        If Me.SaveFileDialog1.FileName.Trim.Length > 0 Then
            Me.txtFilename.Text = Me.SaveFileDialog1.FileName + ".shp"
        End If
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        
        For Each r As DataRow In tabTruong.Rows
            tabTruong.Rows.Clear()
            tabTruong.ReadXml(Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\")) + "\Data\danhmuctruong.xml")
            Dim lstitem As ListViewItem
            Dim tongso As Integer = tabTruong.Rows.Count
            Try
                lstitem = New ListViewItem(r("column_name_vn").ToString)
                lstitem.Tag = r("column_name").ToString
                lstitem.ImageIndex = 0
                Me.Lst_mh.Items.Add(lstitem)
            Catch ex As Exception
            End Try
        Next
    End Sub
End Class
