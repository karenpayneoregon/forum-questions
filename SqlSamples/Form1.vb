Imports SqlSamples.Classes

Public Class Form1
    Private Async Sub LoadDataTableButton_Click(sender As Object, e As EventArgs) _
        Handles LoadDataTableButton.Click

        Dim dt = Await Operations.LoadCustomersAsync()

        DataGridView1.InvokeIfRequired(
            Sub(dgv)
                dgv.DataSource = dt
            End Sub)
    End Sub
End Class
