Imports SpreadsheetLight

Public Class ExcelOperations

    ''' <summary>
    ''' Export a DataTable to Excel
    ''' </summary>
    ''' <param name="pFileName">path and file name to save too, path is optional</param>
    ''' <param name="pSheetName">Name of sheet</param>
    ''' <param name="pDataTable">Populated DataTable</param>
    ''' <param name="pColumnHeaders">True for column names as first row, false no column names</param>
    Public Shared Sub SimpleExportRaw(pFileName As String, pSheetName As String, pDataTable As DataTable, pColumnHeaders As Boolean)

        Using doc As New SLDocument()

            doc.SelectWorksheet(pSheetName)

            doc.ImportDataTable(1, SLConvert.ToColumnIndex("A"), pDataTable, pColumnHeaders)


            Dim style As New SLStyle With {.FormatCode = "MM/dd//yyyy"}

            ' Format modified date column
            doc.SetColumnStyle(11, style)

            style.Font.Bold = True
            doc.SetRowStyle(1, 1, style)

            Dim stats = doc.GetWorksheetStatistics()

            ' auto fit all columns
            doc.AutoFitColumn(1, stats.EndColumnIndex)

            ' original default name is Sheet1, let's change it to the name in pSheetName
            doc.RenameWorksheet(SLDocument.DefaultFirstSheetName, pSheetName)

            doc.SaveAs(pFileName)

        End Using

    End Sub
    ''' <summary>
    ''' Mocked code sample to load a list
    ''' The try-catch is mainly here to ensure we don't happen
    ''' to run this code with the file open from a prior run
    '''
    ''' Option Strict On
    ''' Option Infer On
    ''' 
    ''' </summary>
    ''' <returns></returns>
    Public Shared Function CreateAndPopulate() As Boolean

        Dim success = True
        Try
            Using doc As New SLDocument()

                Dim style As New SLStyle

                style.Font.Bold = True
                doc.SetRowStyle(1, 1, style)

                doc.SetCellValue("A1", "Last name")
                doc.SetCellValue("B1", "First name")

                Dim people = PeopleData.List()

                Dim rowIndex = 0

                For Each person In people
                    doc.SetCellValue($"A{rowIndex + 2}", people(rowIndex).LastName)
                    doc.SetCellValue($"B{rowIndex + 2}", people(rowIndex).FirstName)
                    rowIndex += 1
                Next


                Dim stats = doc.GetWorksheetStatistics()

                doc.AutoFitColumn(1, stats.EndColumnIndex)
                doc.RenameWorksheet(SLDocument.DefaultFirstSheetName, "People")

                doc.SaveAs("PeopleData.xlsx")

            End Using
        Catch ex As Exception
            Console.WriteLine($"{ex.Message}")
            success = False
        End Try

        Return success

    End Function
End Class