Imports System.Globalization

Public Class Form2

    Public Delegate Sub OnListBoxSelectDelegate(month As String)
    Public Shared Event ListBoxSelectionChanged As OnListBoxSelectDelegate

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MonthsListBox.DisplayMember = "MonthName"
        MonthsListBox.DataSource = Enumerable.Range(1, 12).
            Select(Function(index)
                       Return New With {Key .MonthName =
                        DateTimeFormatInfo.CurrentInfo.GetMonthName(index)}
                   End Function).ToList()

    End Sub
    Private Sub SendToParentFormButton_Click(sender As Object, e As EventArgs) _
        Handles SendToParentFormButton.Click

        If MonthsListBox.SelectedIndex > -1 Then
            RaiseEvent ListBoxSelectionChanged(MonthsListBox.Text)
        End If
    End Sub
End Class
