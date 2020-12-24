Imports FullScreenForm.Extensions

Public Class frmMainForm
    Private Sub cmdCloseForm_Click(sender As Object, ByVal e As EventArgs) Handles cmdCloseForm.Click
        Close()
    End Sub
    Private Sub cmdChange_Click(sender As Object, e As EventArgs) Handles cmdChange.Click

        If cmdChange.Text = "Full" Then

            cmdChange.Text = "Normal"
            cmdMake.Text = "Normal"

            FullScreen(chkTaskbar.Checked)

            If chkTaskbar.Checked Then
                Me.FullScreen(True)
            End If
        Else
            cmdChange.Text = "Full"
            cmdMake.Text = "Full"
            NormalMode()
        End If

    End Sub
    Private Sub cmdMsgBox_Click(sender As Object, e As EventArgs) Handles cmdMsgBox.Click

        MessageBox.Show("Hello")
    End Sub
    Private Sub cmdShowChildForm_Click(sender As Object, e As EventArgs) Handles cmdShowChildForm.Click
        Dim f As New frmChildForm
        Dim TopMostSetting As Boolean = Me.TopMost

        Try
            TopMost = False
            f.ShowDialog()
        Finally
            f.Dispose()
            TopMost = TopMostSetting
        End Try
    End Sub
    Public Sub MakeFullScreen()
        SetVisibleCore(False)
        FormBorderStyle = FormBorderStyle.None
        WindowState = FormWindowState.Maximized
        SetVisibleCore(True)
    End Sub
    Private Sub cmdMake_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMake.Click
        If cmdMake.Text = "Full" Then
            cmdMake.Text = "Normal"
            cmdChange.Text = "Normal"
            MakeFullScreen()
        Else
            cmdMake.Text = "Full"
            cmdChange.Text = "Full"
            NormalMode()
        End If
    End Sub
    Private Sub cmdDetect_Click(sender As Object, e As EventArgs) Handles cmdDetect.Click
        MessageBox.Show(WindowState.ToString)
    End Sub
    Private Sub frmMainForm_StyleChanged(sender As Object, e As EventArgs) Handles Me.StyleChanged
        ListBox1.Items.Add(WindowState.ToString)
        ListBox1.SelectedIndex = ListBox1.Items.Count - 1
    End Sub
End Class
