Imports SpreadsheetLight

Public Class ExcelOperations
    Public Shared Sub SimpleExportRaw(pFileName As String, pSheetName As String, pDataTable As DataTable, pColumnHeaders As Boolean)

        Using doc As New SLDocument()
            doc.SelectWorksheet(pSheetName)
            doc.ImportDataTable(1, SLConvert.ToColumnIndex("A"), pDataTable, pColumnHeaders)

            Dim style As New SLStyle()
            style.FormatCode = "MM/dd//yyyy"
            doc.SetColumnStyle(11, style)

            style.Font.Bold = True
            doc.SetRowStyle(1, 1, style)

            Dim stats = doc.GetWorksheetStatistics()

            doc.AutoFitColumn(1, stats.EndColumnIndex)

            doc.RenameWorksheet(SLDocument.DefaultFirstSheetName, pSheetName)

            doc.SaveAs(pFileName)
        End Using

    End Sub
End Class
