Public Class Lst_Tinh2
    Dim tabTinh As DataTable = New Dulieu.TinhDataTable



    Private Sub dmmh_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress

    End Sub

    Private Sub dmmh_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dinhdangmh()
        Me.loadmh()
        If mlang = "vi" Then
            Me.lab_tukhoa.Text = "Từ khóa"
            Me.Text = "Danh mục (ESC - Thoát)"
        Else
            Me.lab_tukhoa.Text = "Keyword"
            Me.Text = "LIST OF PROVINCES (ESC - Exit)"
        End If
    End Sub
    Private Sub dinhdangmh()
        Me.LstV_dm.Columns.Add(IIf(mlang = "vi", "Mã", "Code"), 90, HorizontalAlignment.Center)
        Me.LstV_dm.Columns.Add(IIf(mlang = "vi", "Tên tỉnh", "Province name"), 400, HorizontalAlignment.Left)
    End Sub
    Private Sub loadmh()
        tabTinh.Rows.Clear()
        Dim cls As New cls_chuyendoi
        tabTinh.ReadXml(Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\")) + "\Data\tinh.xml")
        For Each r As DataRow In tabTinh.Rows
            r("tentinh_en") = cls.chuyensangkhongdau(r("tentinh"))
        Next
        Me.hienthi()
    End Sub
    Private Sub hienthi()
        Me.LstV_dm.Items.Clear()
        Dim dem As Byte = 1
        Dim dsrong As Boolean = True
        Try
            Dim lstitem As ListViewItem
            For Each r As DataRow In tabTinh.Select("tentinh like '*" & Me.txtten.Text & "*' or tentinh_en like '*" & Me.txtten.Text & "*' or matinh = '" & Val(Me.txtten.Text) & "'")
                Try
                    If dem = 1 Then
                        mmatinh = r("matinh").ToString
                        mtentinh = r("tentinh").ToString
                        dem = 0
                    End If

                    lstitem = New ListViewItem(r("matinh").ToString)
                    lstitem.SubItems.Add(r("tentinh").ToString)
                    lstitem.SubItems.Add("0")
                    lstitem.ImageIndex = 0
                    dsrong = False
                    Me.LstV_dm.Items.Add(lstitem)
                    'het                  
                Catch ex As Exception
                End Try
            Next
        Catch ex As Exception
        Finally
            If mlang = "vi" Then
                Me.lab_thongbao_en.Visible = False
                Me.Lab_ThongBao.Visible = dsrong
            Else
                Me.Lab_ThongBao.Visible = False
                Me.lab_thongbao_en.Visible = dsrong
            End If
        End Try
    End Sub

    Private Sub LstV_dm_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LstV_dm.DoubleClick
        For Each item As ListViewItem In Me.LstV_dm.SelectedItems
            mmatinh = item.SubItems(0).Text
            mtentinh = item.SubItems(1).Text
        Next
        Me.Close()
    End Sub

    Private Sub LstV_dm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LstV_dm.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.LstV_dm_DoubleClick(sender, e)
        Else
            If e.KeyChar = Chr(27) Then
                mmatinh = Nothing
                mtentinh = Nothing
                Me.Close()
            End If
        End If

    End Sub

    Private Sub LstV_dm_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LstV_dm.SelectedIndexChanged

    End Sub

    Private Sub txtten_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtten.KeyDown
        If e.KeyData = Keys.Down Then
            Me.LstV_dm.Focus()
        End If
    End Sub

    Private Sub txtten_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtten.KeyPress
        If e.KeyChar = Chr(27) Then
            mmatinh = Nothing
            mtentinh = Nothing
            Me.Close()
        End If
    End Sub

    Private Sub txtten_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtten.LostFocus
        Me.Timer1.Enabled = False
    End Sub

    Private Sub txtten_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtten.TextChanged
        Me.Timer1.Enabled = False
        Me.Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.hienthi()
        Me.Timer1.Enabled = False
    End Sub

    Private Sub Lst_Benh_Scroll(ByVal sender As Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles Me.Scroll

    End Sub

    Private Sub dmmh_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown

    End Sub
End Class
