Public Class ExampleForm
    Private Property SelectedPictureBox() As PictureBox
    Private Sub ExampleForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Controls.OfType(Of ButtonPictureBox).ToList().ForEach(
            Sub(box)
                AddHandler box.Click, AddressOf AllButton_Click
            End Sub)
    End Sub

    Private Sub AllButton_Click(sender As Object, e As EventArgs)
        SelectedPictureBox = CType(sender, ButtonPictureBox).PictureBox
    End Sub

    Private Sub GetSelectedButton_Click(sender As Object, e As EventArgs) Handles GetSelectedButton.Click
        If SelectedPictureBox IsNot Nothing Then
            MessageBox.Show(SelectedPictureBox.Name)
        Else
            MessageBox.Show("Please select an image")
        End If
    End Sub
End Class