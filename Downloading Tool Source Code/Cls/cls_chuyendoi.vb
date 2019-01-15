Public Class cls_chuyendoi
    Function chuyensangkhongdau(ByVal mystr As String) As String
        Dim myChar() As String = {"aàáảãạăằắẳẵặâầấẩẫậ", "AÀÁẢÃẠĂẰẮẲẴẶÂẦẤẨẪẬ", "ÒÒÓỎÕỌÔỒỐỔỖỘƠỜỚỞỠỢ", "EÈÉẺẼẸÊỀẾỂỄỆ", "UÙÚỦŨỤƯỪỨỬỮỰ", "IÌÍỈĨỊ", "YỲÝỶỸỴ", "Đ", "oòóỏõọôồốổỗộơờớởỡợ", "eèéẻẽẹêềếểễệ", "uùúủũụưừứửữự", "iìíỉĩị", "yỳýỷỹỵ", "đ"}
        Dim myChar1() As String = {"a", "A", "O", "E", "U", "I", "Y", "Đ", "o", "e", "u", "i", "y", "d"}
        Dim str As String = mystr
        Dim strReturn As String = ""
        For i As Int32 = 0 To str.Length - 1
            Dim iStr As String = str.Substring(i, 1)
            Dim rStr As String = iStr

            For j As Int32 = 0 To myChar.Length - 1
                If myChar(j).IndexOf(iStr) >= 0 Then
                    rStr = myChar1(j)
                    Exit For
                End If
            Next
            strReturn += rStr
        Next
        Return strReturn
    End Function
End Class
