Imports System.Net.Mail

Public Class Cls_Gmail
    Public Smtp As New SmtpClient()
    Public mail As New MailMessage()
    Public NguoiNhan As String
    Public tenBC As String
    Public TieuDe As String
    Public noidung As String
    Public filename As String = ""
    Public filename2 As String = ""
    Public username As String
    Public password As String
    Sub SendMail1()
        mail = New MailMessage()
        mail.From = New MailAddress(username, tenBC)
        mail.To.Add(NguoiNhan)
        If filename.Trim.Length > 0 Then
            Dim attachment As System.Net.Mail.Attachment
            attachment = New System.Net.Mail.Attachment(filename)
            mail.Attachments.Add(attachment)
        End If
        If filename2.Trim.Length > 0 Then
            Dim attachment As System.Net.Mail.Attachment
            attachment = New System.Net.Mail.Attachment(filename2)
            mail.Attachments.Add(attachment)
        End If
        mail.Subject = TieuDe
        mail.Body = noidung
        Try
            Smtp.EnableSsl = True
            Smtp.Credentials = New Net.NetworkCredential(username, password)
            Smtp.Port = 587
            Smtp.Host = "smtp.gmail.com"
            Smtp.Send(mail)
        Catch ex As Exception
        End Try
    End Sub
    Sub SendMail()
        Dim Mail As New MailMessage
        Dim SMTP As New SmtpClient("smtp.gmail.com")

        Mail.Subject = "Security Update"
        Mail.From = New MailAddress(username)
        SMTP.Credentials = New System.Net.NetworkCredential(username, password) '<-- Password Here

        Mail.To.Add(NguoiNhan) 'I used ByVal here for address

        Mail.Body = "Test mail" 'Message Here

        SMTP.EnableSsl = True
        SMTP.Port = "587"
        SMTP.Send(Mail)
    End Sub

End Class
