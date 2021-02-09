Imports System.IO

Public Class Form1
    Public Process As New Process()

    Public Sub ExecuteCommand(pCommandLineFile As String, Optional pArguments As String = "")

        Process.StartInfo.FileName = pCommandLineFile

        If Not String.IsNullOrWhiteSpace(pArguments) Then
            Process.StartInfo.Arguments = pArguments
        End If

        Process.StartInfo.CreateNoWindow = True
        Process.StartInfo.UseShellExecute = False
        Process.Start()

    End Sub
    Private Sub StartButton_Click(sender As Object, e As EventArgs) Handles StartButton.Click
        Dim fileName = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "TextFile1.txt")
        ExecuteCommand("Notepad.exe", fileName)
    End Sub
    Private Sub KillButton_Click(sender As Object, e As EventArgs) Handles KillButton.Click
        Process.Kill()
    End Sub
End Class
