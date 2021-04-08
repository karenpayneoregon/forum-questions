Imports System.IO
Imports System.Text

Namespace Classes
    Public Class FileOperations

        Public Delegate Sub OnMalformedLineExceptionDelegate(exception As FileIO.MalformedLineException, FileName As String)
        Public Shared Event MalformedLineExceptionHandler As OnMalformedLineExceptionDelegate

        Public Delegate Sub OnExceptionDelegate(exception As Exception, FileName As String)
        Public Shared Event ExceptionHandler As OnExceptionDelegate

        ''' <summary>
        ''' Get all text files in the application folder
        ''' </summary>
        ''' <returns></returns>
        Private Shared Function GetFileNames() As List(Of String)
            Return Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*.txt").ToList()
        End Function

        ''' <summary>
        ''' Read each file, each line is added to a list that is distinct and sorted by product name
        ''' </summary>
        ''' <returns></returns>
        Public Shared Function Read() As List(Of Product)
            Dim files = GetFileNames()
            Dim productIdentifier As Integer = 0
            Dim categoryIdentifier As Integer = 0

            Dim products As New SortedSet(Of Product)(New ProductComparer())

            For Each file As String In files

                Using reader As New FileIO.TextFieldParser(file)

                    reader.TextFieldType = FileIO.FieldType.Delimited
                    reader.SetDelimiters(",")

                    Dim current As String()

                    While Not reader.EndOfData

                        Try

                            current = reader.ReadFields()

                            If Integer.TryParse(current(0), productIdentifier) AndAlso Integer.TryParse(current(2), categoryIdentifier) Then

                                products.Add(New Product() With {
                                                .Id = productIdentifier,
                                                .Name = current(1),
                                                .CategoryId = categoryIdentifier,
                                                .CategoryName = current(3)})
                            End If


                        Catch mex As FileIO.MalformedLineException
                            RaiseEvent MalformedLineExceptionHandler(mex, file)
                        Catch ex As Exception
                            RaiseEvent ExceptionHandler(ex, file)
                        End Try

                    End While

                End Using
            Next

            Return products.ToList()

        End Function
        ''' <summary>
        ''' Export Product list by read-only property Lines
        ''' </summary>
        ''' <param name="productList">List of <see cref="Product"/></param>
        ''' <param name="fileName">
        ''' File name and path if needed to save list too and if not specified will save to the file name set
        ''' </param>
        Public Shared Sub Export(productList As List(Of Product), Optional fileName As String = "AllProducts.txt")

            Dim sb As New StringBuilder
            For Each product As Product In productList
                sb.AppendLine(product.Lines)
            Next

            File.WriteAllText(fileName, sb.ToString())

        End Sub

    End Class
End Namespace