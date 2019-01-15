Public Class Lst_Huyen2
    Private tabHuyen As DataTable = New Dulieu.huyenDataTable

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
            Me.Text = "LIST OF DISTRICTS (ESC - Exit)"
        End If
    End Sub
    Private Sub dinhdangmh()
        Me.LstV_dm.Columns.Add(IIf(mlang = "vi", "Mã", "Code"), 90, HorizontalAlignment.Center)
        Me.LstV_dm.Columns.Add(IIf(mlang = "vi", "Tên huyện", "District name"), 400, HorizontalAlignment.Left)
    End Sub
    Private Sub loadmh()
        tabHuyen.Rows.Clear()
        Dim cls As New cls_chuyendoi
        tabHuyen.ReadXml(Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\")) + "\Data\huyen.xml")
        For Each r As DataRow In tabHuyen.Rows
            r("tenhuyen_en") = cls.chuyensangkhongdau(r("tenhuyen"))
        Next
        Me.hienthi()
    End Sub
    Private Sub hienthi()
        Me.LstV_dm.Items.Clear()
        Dim dem As Byte = 1
        Dim dsrong As Boolean = True
        Try
            Dim lstitem As ListViewItem
            Dim dk As String = ""
            dk = "(tenhuyen like '*" & Me.txtten.Text & "*' or tenhuyen_en like '*" & Me.txtten.Text & "*' or mahuyen = '" & Val(Me.txtten.Text) & "')"
            If Me.txtmatinh.Text.Trim.Length > 0 Then
                dk += " and matinh='" & Me.txtmatinh.Text & "'"
            End If
            For Each r As DataRow In tabHuyen.Select(dk)
                Try
                    If dem = 1 Then
                        mmahuyen = r("mahuyen").ToString
                        mtenhuyen = r("tenhuyen").ToString
                        dem = 0
                    End If

                    lstitem = New ListViewItem(r("mahuyen").ToString)
                    lstitem.SubItems.Add(r("tenhuyen").ToString)
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
            mmahuyen = item.SubItems(0).Text
            mtenhuyen = item.SubItems(1).Text
        Next
        Me.Close()
    End Sub

    Private Sub LstV_dm_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LstV_dm.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.LstV_dm_DoubleClick(sender, e)
        Else
            If e.KeyChar = Chr(27) Then
                mmahuyen = Nothing
                mtenhuyen = Nothing
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
            mmahuyen = Nothing
            mtenhuyen = Nothing
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
