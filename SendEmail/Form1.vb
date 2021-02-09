Public Class Form1
    Private Sub SendButton_Click(sender As Object, e As EventArgs) Handles SendButton.Click

        MailOperations.MailSubject = ""

        MailOperations.SendSingleMessage(
            TextBox_SenderEADD.Text,
            TextBox_Password.Text,
            TextBox_Message.Text,
            TextBox_SenderEADD.Text,
            TextBox_Eadd.Text, TextBox_sendtoallsubject.Text,
            DateTimePicker1.Value)

    End Sub
End Class
