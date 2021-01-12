Imports SpreadSheetLightVb.Classes

Public Class Form1
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        DataGridView1.DataSource = DataOperationsSqlServer.LoadCustomerRecordsUsingDataTable()
    End Sub

    Private Sub ExportToExcelButton_Click(sender As Object, e As EventArgs) Handles ExportToExcelButton.Click
        Dim dt = CType(DataGridView1.DataSource, DataTable)
        ExcelOperations.SimpleExportRaw("Customers.xlsx", "Customers", dt, True)

    End Sub
End Class
