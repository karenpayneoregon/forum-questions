Imports SortedSet_vb.Classes

''' <summary>
''' * In this code sample exceptions are written to the console for debug purposes.
'''   Another idea is to create a List(Of String), add exceptions to the list and
'''   when done processing display them all at once or a variation of this.
'''
''' * The DataGridView here is setup as read-only and is here to provide confirmation
'''   the operation worked as expected.
''' </summary>
Public Class Form1

    Private Sub CombineFilesButton_Click(sender As Object, e As EventArgs) Handles CombineFilesButton.Click

        DataGridView1.DataSource = Nothing
        ExportListButton.Enabled = False

        Dim products = FileOperations.Read()

        If products.Count > 0 Then
            DataGridView1.DataSource = products
            ExportListButton.Enabled = True
        End If

    End Sub

    Private Sub ExportListButton_Click(sender As Object, e As EventArgs) Handles ExportListButton.Click

        If DataGridView1.DataSource IsNot Nothing Then
            FileOperations.Export(CType(DataGridView1.DataSource, List(Of Product)))
        End If

    End Sub
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        AddHandler FileOperations.ExceptionHandler, AddressOf GeneralExceptionWhileReadingFile
        AddHandler FileOperations.MalformedLineExceptionHandler, AddressOf MalFormExceptionWhileReadingFile

        ExportListButton.Enabled = False
    End Sub

    Private Sub MalFormExceptionWhileReadingFile(exception As Microsoft.VisualBasic.FileIO.MalformedLineException, fileName As String)
        Console.WriteLine($"Read error on line {exception.LineNumber} with file {fileName}")
    End Sub

    Private Sub GeneralExceptionWhileReadingFile(exception As Exception, fileName As String)
        Console.WriteLine($"General error: {exception.Message}  with file {fileName}")
    End Sub
End Class
