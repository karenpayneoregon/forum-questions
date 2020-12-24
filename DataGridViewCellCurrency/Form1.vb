Public Class Form1
    Private ReadOnly _bindingSource As New BindingSource
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dt As New DataTable

        dt.Columns.Add(New DataColumn() With {.ColumnName = "Value1", .DataType = GetType(Decimal)})
        dt.Columns.Add(New DataColumn() With {.ColumnName = "Value2", .DataType = GetType(Decimal)})

        dt.Rows.Add(New Object() {12.99D, 12.99D})
        dt.Rows.Add(New Object() {1112D, 1112D})
        dt.Rows.Add(New Object() {99.87D, 99.87D})

        _bindingSource.DataSource = dt

        Dim b As New Binding("Text", _bindingSource, "Value1") With {
            .DataSourceUpdateMode = DataSourceUpdateMode.OnPropertyChanged
        }

        AddHandler b.Format, AddressOf FormatValue1

        Value1TextBox.DataBindings.Add(b)

        Value1Column.DefaultCellStyle.Format = "###.##\ Euro"
        DataGridView1.DataSource = _bindingSource

    End Sub

    Private Sub FormatValue1(sender As Object, e As ConvertEventArgs)
        Dim value As Decimal = 0
        If Decimal.TryParse(e.Value.ToString(), value) Then
            e.Value = $"{e.Value} Euro"
        End If
    End Sub
    Private Sub DataGridView1_EditingControlShowing(
        sender As Object, e As DataGridViewEditingControlShowingEventArgs) _
        Handles DataGridView1.EditingControlShowing

        If DataGridView1.CurrentCell.ColumnIndex = 0 Then
            e.CellStyle.Format = "N2"
            e.Control.Text = DataGridView1.CurrentCell.Value.ToString()
        End If

    End Sub
End Class
