# About

Read data from SQL-Server to a DataTable then in turn sets a DataGridView.DataSource to the DataTable. There is a button to export the DataTable to Excel using the following code shown below. Note there is code to perform formatting of cells.

- To run perform a NuGet restore packages
- Run script.sql
- Build/run
- There is a file named Customers.xlsx in the root of the project which was generated with code provided.

# Important

**DO NOT** generate the excel file, open it then try another export while the Exel file is open as this will generate a runtime exception.

# NuGet packages used

:heavy_check_mark: [SpreadsheetLight](https://www.nuget.org/packages/SpreadsheetLight/) current version
[DocumentFormat.OpenXml](https://www.nuget.org/packages/DocumentFormat.OpenXml/) version 2.11.3

# Excel operation

```csharp
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
```