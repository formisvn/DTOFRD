Public Class Cls_DMHuyen
    Dim tabHuyen As DataTable = New Dulieu.huyenDataTable
    Public Function laytenhuyen(ByVal mahuyen As String, ByVal matinh As String) As String
        Dim tenhuyen As String = ""
        Try
            tabHuyen.ReadXml(Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\")) + "\Data\huyen.xml")
            For Each r As DataRow In tabHuyen.Select("matinh='" & matinh & "' and mahuyen='" & mahuyen.ToString & "'")
                tenhuyen = r("tenhuyen")
            Next
        Catch ex As Exception

        End Try

        Return tenhuyen
    End Function
End Class
