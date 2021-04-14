Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.AutoGenerateColumns = False

        DataGridView1.DataSource = Operations.Read()
    End Sub
End Class