Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CheckedListBox1.CheckOnClick = True

        Dim itemList As New List(Of Item) From {
            New Item() With {.Text = "One", .TextBoxName = "TextBox1"},
            New Item() With {.Text = "Two", .TextBoxName = "TextBox2"},
            New Item() With {.Text = "Three", .TextBoxName = "TextBox3"},
            New Item() With {.Text = "Four", .TextBoxName = "TextBox4"}
        }

        CheckedListBox1.DataSource = itemList

    End Sub

    Private Sub CheckedListBox1_ItemCheck(sender As Object, e As ItemCheckEventArgs) _
        Handles CheckedListBox1.ItemCheck

        Dim currentItem = CType(CheckedListBox1.SelectedItem, Item)

        Dim TargetTextBox As TextBox = CType(Controls(currentItem.TextBoxName), TextBox)

        If e.NewValue = CheckState.Checked Then
            TargetTextBox.Text = currentItem.Text
        Else
            TargetTextBox.Text = ""
        End If
    End Sub
End Class

Public Class Item
    Public Property Text() As String
    Public Property TextBoxName() As String
    Public Overrides Function ToString() As String
        Return Text
    End Function
End Class
