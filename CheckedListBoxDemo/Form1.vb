Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        CheckedListBox1.CheckOnClick = True

        Dim itemList As New List(Of Item) From {
            New Item() With {.Text = "One", .TextBox = TextBox1},
            New Item() With {.Text = "Two", .TextBox = TextBox2},
            New Item() With {.Text = "Three", .TextBox = TextBox3},
            New Item() With {.Text = "Four", .TextBox = TextBox4}
        }

        CheckedListBox1.DataSource = itemList

    End Sub

    Private Sub CheckedListBox1_ItemCheck(sender As Object, e As ItemCheckEventArgs) _
        Handles CheckedListBox1.ItemCheck

        Dim currentItem = CType(CheckedListBox1.SelectedItem, Item)

        If e.NewValue = CheckState.Checked Then
            currentItem.TextBox.Text = currentItem.Text
        Else
            currentItem.TextBox.Text = ""
        End If
    End Sub
End Class

Public Class Item
    Public Property Text() As String
    Public Property TextBox() As TextBox
    Public Overrides Function ToString() As String
        Return Text
    End Function
End Class
