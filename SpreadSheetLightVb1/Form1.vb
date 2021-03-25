Public Class Form1
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        DataGridView1.DataSource = DataOperationsSqlServer.LoadCustomerRecordsUsingDataTable()
        AddHandler ExcelOperations1.OnErrorEvent, AddressOf OnExcelExportError
    End Sub

    Private Sub ExportToExcelButton_Click(sender As Object, e As EventArgs) Handles ExportToExcelButton.Click
        Dim dt = CType(DataGridView1.DataSource, DataTable)
        ExcelOperations.SimpleExportRaw("Customers.xlsx", "Customers", dt, True)
        MessageBox.Show("Exported")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ExcelOperations.CreateAndPopulate() Then
            MessageBox.Show("Done")
        Else
            MessageBox.Show("See console window for issues")
        End If
    End Sub

    Private Sub ExportSimpleButton_Click(sender As Object, e As EventArgs) Handles ExportSimpleButton.Click
        Dim dt = CType(DataGridView1.DataSource, DataTable)
        If ExcelOperations1.Import("DemoExport.xlsx", "Info_Table", dt, False) Then
            MessageBox.Show("Done")
        End If
    End Sub
    Private Sub OnExcelExportError(exception As Exception)
        MessageBox.Show(exception.Message)
    End Sub
End Class
