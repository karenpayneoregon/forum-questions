Imports System.IO

Module Program
    Sub Main(args As String())
        Power()
        Curl()
        Console.ReadLine()
    End Sub
    Sub Curl()

        Dim fileName = Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.MyDocuments), "ipCurl.txt")


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
    Sub Power()

        Dim fileName = Path.Combine(Environment.GetFolderPath(
            Environment.SpecialFolder.MyDocuments), "ipPower.txt")

        Dim start As New ProcessStartInfo With {
                    .FileName = "powershell.exe",
                    .UseShellExecute = False,
                    .RedirectStandardOutput = True,
                    .Arguments = "Invoke-RestMethod ipinfo.io/ip"
                }

        Using process As Process = Process.Start(start)
            Using reader As StreamReader = process.StandardOutput
                Dim ipAddressResult As String = reader.ReadToEnd()
                File.WriteAllText(fileName, ipAddressResult)
            End Using

            process.WaitForExit()

        End Using
    End Sub
End Module
