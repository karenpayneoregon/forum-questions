Public Class Form1
    Private Sub CalulateButton_Click(sender As Object, e As EventArgs) Handles CalulateButton.Click
        Dim value1 As Integer
        Dim value2 As Integer

        If Integer.TryParse(TextBox1.Text, value1) AndAlso Integer.TryParse(TextBox2.Text, value2) Then
            Label1.Text = $"{Math.Round(value1) / value2}"
        End If
    End Sub
End Class
