Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pb = FlowLayoutPanel1.Controls.OfType(Of MyPictureBox).FirstOrDefault(Function(pbox) pbox.PrimaryKey = 3)
        If pb IsNot Nothing Then
            Text = $"From button click event: {pb.PrimaryKey}"
        End If
    End Sub

    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        FlowLayoutPanel1.Controls.OfType(Of MyPictureBox).ToList().ForEach(
            Sub(pb)
                AddHandler pb.Click, AddressOf MyPictureBox_Click
            End Sub)
    End Sub

    Private Sub MyPictureBox_Click(sender As Object, e As EventArgs)
        Dim pb As MyPictureBox = CType(sender, MyPictureBox)

        Text = $"From Picture click event: {pb.PrimaryKey}"

        If pb.BorderStyle = BorderStyle.None Then
            pb.BorderStyle = BorderStyle.Fixed3D
        Else
            pb.BorderStyle = BorderStyle.None
        End If

    End Sub
End Class
