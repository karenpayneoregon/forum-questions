Public Class Form1
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Dim firstDayOfMonth = New DateTime(Now.Year, Now.Month, 1)
        DateTimePicker1.Value = firstDayOfMonth
        Dim lastDay = firstDayOfMonth.AddMonths(3).AddDays(-1)
        ThreeMonthsTextBox.Text = lastDay.ToShortDateString()

        Dim binding = New Binding("Value", DateTimePicker1, "Value")
        AddHandler binding.Format, AddressOf FormatDate
        DateTimePicker1.DataBindings.Add(binding)
    End Sub

    Private Sub FormatDate(sender As Object, e As ConvertEventArgs)
        Dim dateValue = DateTimePicker1.Value
        Dim firstDayOfMonth = New DateTime(dateValue.Year, dateValue.Month, 1)
        Dim lastDay = firstDayOfMonth.AddMonths(3).AddDays(-1)
        ThreeMonthsTextBox.Text = lastDay.ToShortDateString()
    End Sub
End Class
