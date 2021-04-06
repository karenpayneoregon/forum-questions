Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ShowChildForm.Click
        Dim childForm As New Form2

        AddHandler Form2.ListBoxSelectionChanged, AddressOf AddMonth

        childForm.ShowDialog()

        RemoveHandler Form2.ListBoxSelectionChanged, AddressOf AddMonth
    End Sub

    Private Sub AddMonth(monthName As String)
        If MonthsListBox.FindStringExact(monthName, 0) = -1 Then
            MonthsListBox.Items.Add(monthName)
            MonthsListBox.SelectedIndex = MonthsListBox.Items.Count - 1
        End If
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        MonthsListBox.Sorted = True
    End Sub

    Private Sub GetCurrentMonthButton_Click(sender As Object, e As EventArgs) Handles GetCurrentMonthButton.Click
        If MonthsListBox.SelectedIndex > -1 Then
            MessageBox.Show($"{MonthsListBox.SelectedIndex} -> {MonthsListBox.Text}")
        End If
    End Sub
End Class
