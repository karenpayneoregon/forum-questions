Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MyUserControl.ChangeLabel()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MyUserControl.Button1.PerformClick()
    End Sub

    Private Sub OpenForm2Button_Click(sender As Object, e As EventArgs) Handles OpenForm2Button.Click
        Dim form = New Form2
        form.UserControl11.ChangeLabel()
        form.ShowDialog()
    End Sub
End Class
