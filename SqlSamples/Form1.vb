Imports SqlSamples.Classes

Public Class Form1
    Private Sub InsertButton_Click(sender As Object, e As EventArgs) Handles InsertButton.Click

        If CompanyNameComoboBox.SelectedIndex > -1 Then
            Dim primaryKey = Operations.InsertItem(CompanyNameComoboBox.Text)
            If Operations.HasException Then
                MessageBox.Show($"Adding record failed{vbTab}{Operations.LastException.Message}")
                Exit Sub
            End If
        End If

    End Sub
End Class
