Public Class ExampleForm
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckedListBox1.DataSource = SqlOperations.Categories
    End Sub

    Private Sub CheckCategoryButton_Click(sender As Object, e As EventArgs) Handles CheckCategoryButton.Click
        CheckedListBox1.SetCategory(CategoryToCheckTextBox.Text, StateCheckBox.Checked)
    End Sub

    Private Sub CheckAllButton_Click(sender As Object, e As EventArgs) Handles CheckAllButton.Click
        CType(CheckedListBox1.DataSource, List(Of Category)).
            ForEach(Sub(cat) CheckedListBox1.SetCategory(cat.Name, True))
    End Sub
End Class