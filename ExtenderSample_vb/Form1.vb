Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim resilt = ControlExtender1.GetSomeProperty(Button1)
        Console.WriteLine()
    End Sub
End Class
