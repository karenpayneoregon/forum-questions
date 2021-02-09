Imports System.ComponentModel
Imports System.Net
Imports System.Net.Mail

Public Class MailOperations

    Public Shared MailSubject As String

    Public Shared Async Sub SendSingleMessage(
       userName As String,
       password As String,
       message As String,
       fromAddress As String,
       tooAddress As String,
       subject As String,
       billDate As DateTime)

        Dim Smtp_Server = New SmtpClient("", 0)
        Dim e_mail As New MailMessage()
        Smtp_Server.UseDefaultCredentials = False
        Smtp_Server.Credentials = New NetworkCredential(userName, password)
        'Smtp_Server.Port = 587
        Smtp_Server.Port = 465
        Smtp_Server.EnableSsl = True
        'Smtp_Server.Host = "smtp.mail.yahoo.com"
        Smtp_Server.Host = "smtp.gmail.com"
        e_mail = New MailMessage()
        e_mail.From = New MailAddress(fromAddress)
        e_mail.To.Add(tooAddress)

        If MailSubject = "Senttoall" Then
            e_mail.Subject = subject
        Else
            e_mail.Subject = $"RCDC Billing Statement for {billDate.ToString("MMMM yyyy")}"
        End If

        e_mail.IsBodyHtml = False
        e_mail.Body = message

        AddHandler Smtp_Server.SendCompleted, AddressOf MessageSendCompleted

        Dim token = New Object

        Await Task.Run(
            Sub()

                Task.Delay(1)
                Smtp_Server.SendAsync(e_mail, token)

            End Sub)

    End Sub

    Private Shared Sub MessageSendCompleted(sender As Object, eventArguments As AsyncCompletedEventArgs)

        Dim tempVar As Boolean = TypeOf eventArguments.UserState Is MailMessage

        Dim mailMessage As MailMessage = If(tempVar, CType(eventArguments.UserState, MailMessage), Nothing)

        If eventArguments.Error IsNot Nothing Then
            If TypeOf eventArguments.Error Is SmtpException Then
                Debug.WriteLine($"Smtp error: {eventArguments.Error.Message}")
            Else
                Debug.WriteLine($"General error: {eventArguments.Error.Message}")
            End If
        End If
    End Sub
End Class
