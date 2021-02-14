Public Class UserControl1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ChangeLabel()
    End Sub
    Public Sub ChangeLabel()
        Label1.Text = Now.ToString("hh\:mm\:ss\:fff")
    End Sub
End Class
