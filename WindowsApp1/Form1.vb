Imports System.Net

Public Class Form1
    Private siteAddress As String =
                "https://www.investing.com/equities/wrldcal-teleco-earnings"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Using client As New WebClient()
            client.Headers.Add("user-agent", "karen payne")
            Dim htmlCode As String = client.DownloadString(siteAddress)
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Using client As New WebClient()
            client.Headers.Add("user-agent", "karen payne")
            ServicePointManager.SecurityProtocol = CType(3072, SecurityProtocolType)
            ServicePointManager.DefaultConnectionLimit = 9999
            Dim htmlCode As String = client.DownloadString(siteAddress)
        End Using
    End Sub
End Class
