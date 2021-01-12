Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Threading

Public Class Form1
    Private _cts As New CancellationTokenSource()
    Private Sub DirectoryCopy1(source As String, destination As String, copyChildren As Boolean)

        Dim dir As New DirectoryInfo(source)

        If Not dir.Exists Then
            Throw New DirectoryNotFoundException("Source directory does not exist or could not be found: " & source)
        End If

        Dim dirs() As DirectoryInfo = dir.GetDirectories()

        If Not Directory.Exists(destination) Then
            Directory.CreateDirectory(destination)
        End If

        Label1.Text = destination

        Dim files() As FileInfo = dir.GetFiles()

        For Each fileInfo As FileInfo In files

            Dim tempPath As String = Path.Combine(destination, fileInfo.Name)

            fileInfo.CopyTo(tempPath, False)

        Next

        If copyChildren Then

            For Each childFolder As DirectoryInfo In dirs
                Dim tempPath As String = Path.Combine(destination, childFolder.Name)
                DirectoryCopy1(childFolder.FullName, tempPath, copyChildren)
            Next

        End If
    End Sub
    Private Async Function DirectoryCopy2(source As String, destination As String, copyChildren As Boolean, ct As CancellationToken) As Task

        Try
            Await Task.Run(Async Function()

                               If ct.IsCancellationRequested Then
                                   ct.ThrowIfCancellationRequested()
                               End If

                               Dim dir As New DirectoryInfo(source)

                               If Not dir.Exists Then
                                   Throw New DirectoryNotFoundException(
                                       $"Source directory does not exist or could not be found: {source}")
                               End If

                               Dim dirs() As DirectoryInfo = dir.GetDirectories()

                               If Not Directory.Exists(destination) Then
                                   Directory.CreateDirectory(destination)
                               End If

                               Label1.InvokeIfRequired(Sub(label)
                                                           label.Text = destination
                                                       End Sub)


                               Dim files() As FileInfo = dir.GetFiles()

                               For Each fileInfo As FileInfo In files
                                   Dim tempPath As String = Path.Combine(destination, fileInfo.Name)

                                   If Not File.Exists(tempPath) Then
                                       Await CopyFileAsync(fileInfo.FullName, tempPath)
                                   End If

                               Next

                               ' If copying subdirectories, copy them and their contents to new location.
                               If copyChildren Then

                                   For Each childFolder As DirectoryInfo In dirs
                                       Dim tempPath As String = Path.Combine(destination, childFolder.Name)
                                       If Not Cancelled Then
                                           Await DirectoryCopy2(childFolder.FullName, tempPath, copyChildren, ct)
                                       End If

                                   Next
                               End If

                           End Function)

        Catch ex As Exception

            If TypeOf ex Is OperationCanceledException Then

                Cancelled = True

            End If

        End Try

    End Function

    Public Property Cancelled As Boolean

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If _cts.IsCancellationRequested = True Then
            _cts.Dispose()
            _cts = New CancellationTokenSource()
        End If

        Await DirectoryCopy2("C:\oed\Dotnetland\CallbacksVisualBasic", ".\temp", True, _cts.Token)

    End Sub

    Public Shared Async Function CopyFileAsync(source As String, destination As String) As Task
        Using sourceStream = New FileStream(source, FileMode.Open, FileAccess.Read, FileShare.Read, 4096, FileOptions.Asynchronous Or FileOptions.SequentialScan)
            Using destinationStream = New FileStream(destination, FileMode.CreateNew, FileAccess.Write, FileShare.None, 4096, FileOptions.Asynchronous Or FileOptions.SequentialScan)
                Await sourceStream.CopyToAsync(destinationStream)
            End Using
        End Using
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        _cts.Cancel()
    End Sub
End Class
Public Module ControlExtensions
    ''' <summary>
    ''' Protection against cross thread exceptions
    ''' </summary>
    ''' <typeparam name="T"></typeparam>
    ''' <param name="control"></param>
    ''' <param name="action"></param>
    ''' <returns></returns>
    <Extension>
    Public Function InvokeIfRequired(Of T As Control)(control As T, action As Action(Of T)) As IAsyncResult

        If control.InvokeRequired Then

            Try

                Return control.BeginInvoke(New Action(Of T, Action(Of T))(AddressOf InvokeIfRequired), New Object() {control, action})

            Catch ex As Exception

                Return Nothing

            End Try

        Else

            action(control)
            Return Nothing

        End If

    End Function
End Module
