Public Class Cls_DMXa
    Public mahuyen As String
    Dim tabXa As DataTable = New Dulieu.xaDataTable
    Public Function laytenxa(ByVal maxa As String, ByVal mahuyen As String) As String
        Dim tenxa As String = ""
        Try
            tabXa.ReadXml(Application.ExecutablePath.Substring(0, Application.ExecutablePath.LastIndexOf("\")) + "\Data\xa.xml")
            For Each r As DataRow In tabXa.Select("maxa='" & maxa.ToString & "' and mahuyen='" & mahuyen.ToString & "'")
                tenxa = r("tenxa")
            Next
        Catch ex As Exception

        End Try

        Return tenxa
    End Function

End Class
