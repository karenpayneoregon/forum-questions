
Imports CreateDynamicControls_vb.Classes
Imports CreateDynamicControls_vb.Controls

Public Class Form1
    ''' <summary>
    ''' Initialization for creating buttons
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Shown(sender As Object, e As EventArgs) Handles Me.Shown

        ' configure
        Dim initialSetting As New ButtonInitialization With
                {
                    .ParentControl = FlowLayoutPanel1,
                    .Top = 20,
                    .Left = 10,
                    .Width = 100,
                    .MaxButtonCount = 6
                }


        ButtonOperations.Initialize(initialSetting)

    End Sub
    ''' <summary>
    ''' Creates 6 buttons in a while loop
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CreateButtonsWhileLoopButton1_Click(sender As Object, e As EventArgs) Handles CreateButtonsWhileLoopButton1.Click

        While ButtonOperations.CurrentButtonCount < ButtonOperations.MaxButtonCount
            ButtonOperations.CreateButton(If(ButtonTextButton.Text.IsNullOrWhiteSpace(), "(empty)", ButtonTextButton.Text))
            AddHandler ButtonOperations.ButtonsList.Last().Click, AddressOf UniversalButton1ClickEvent
        End While

    End Sub
    ''' <summary>
    ''' Create six months with month names
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CreateButtonsWhileLoopButton2_Click(sender As Object, e As EventArgs) Handles CreateButtonsWhileLoopButton2.Click

        If ButtonOperations.CanCreateMoreButtons Then

            Dim sixMonths = Helpers.MonthNames(6)

            For Each monthName As String In sixMonths
                ButtonOperations.CreateButton(If(Helpers.CurrentMonthName = monthName, $"[{monthName}]", monthName))
                AddHandler ButtonOperations.ButtonsList.Last().Click, AddressOf UniversalButton1ClickEvent
            Next

        End If


    End Sub

    Private Sub CreateOneButtonButton_Click(sender As Object, e As EventArgs) Handles CreateOneButtonButton.Click

        If ButtonOperations.CanCreateMoreButtons Then

            ButtonOperations.CreateButton(
                If(ButtonTextButton.Text.IsNullOrWhiteSpace(), "(empty)", ButtonTextButton.Text),
                If(StashTextBox.Text.IsNullOrWhiteSpace(), "(no stash)", StashTextBox.Text))

            AddHandler ButtonOperations.ButtonsList.Last().Click, AddressOf UniversalButton1ClickEvent
        End If

    End Sub
    ''' <summary>
    ''' Click event for all created buttons
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Public Sub UniversalButton1ClickEvent(sender As Object, e As EventArgs)

        Dim button = CType(sender, DataButton)

        If button.Stash.IsNullOrWhiteSpace() Then
            MessageBox.Show($"{button.Identifier}, {button.Text}, {button.Name}")
        Else
            MessageBox.Show($"{button.Identifier}, {button.Text}, {button.Name}, {button.Stash}")
        End If


    End Sub
    ''' <summary>
    ''' Show current buttons created
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ListButtonsButton_Click(sender As Object, e As EventArgs) Handles ListButtonsButton.Click

        ListBox1.DataSource = ButtonOperations.ButtonNames

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ButtonOperations.RemoveAllButtons()
        ListBox1.DataSource = Nothing
    End Sub
End Class