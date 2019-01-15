Public Class Cls_DMTinh
    Dim tabTinh As DataTable = New Dulieu.TinhDataTable
    Public Function laytentinh(ByVal matinh As String) As String

        Dim tentinh As String = ""
        Try
            tabTinh.ReadXml(Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\")) + "\Data\tinh.xml")
            For Each i As DataRow In tabTinh.Select("matinh='" & matinh & "'")
                tentinh = i("tentinh")
            Next
        Catch ex As Exception

        End Try
        Return tentinh
    End Function
End Class
