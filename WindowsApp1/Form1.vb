Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CurrencyFormattedLabel1.SetDoubleValue("Total", 123.99, 23, 34.22)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CurrencyFormattedLabel1.SetDoubleValue(123.99, 23.76, 34.22)
    End Sub
End Class
