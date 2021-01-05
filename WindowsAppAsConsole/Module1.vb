Imports System.IO

Public Module Module1
    Public Sub Main()
        Dim fileName = Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.MyDocuments), "ip_Curl.txt")


        Dim start As New ProcessStartInfo With {
                .FileName = "curl.exe",
                .Arguments = "ipinfo.io/ip",
                .UseShellExecute = False,
                .RedirectStandardOutput = True,
                .CreateNoWindow = True
                }


        Using p As Process = Process.Start(start)
            Using reader As StreamReader = p.StandardOutput
                Dim ipAddressResult As String = reader.ReadToEnd()
                File.WriteAllText(fileName, ipAddressResult)
            End Using
        End Using

    End Sub
End Module
