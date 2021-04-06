Option Infer On

Imports CreateDynamicControls_vb.Controls

Namespace Classes

    Public Class ButtonOperations
        Public Shared Property ButtonsList() As List(Of DataButton)
        Public Shared Property MaxButtonCount() As Integer
        Public Shared ReadOnly Property CurrentButtonCount() As Integer
            Get
                Return ButtonsList.Count
            End Get
        End Property
        Public Shared ReadOnly Property CanCreateMoreButtons() As Boolean
            Get
                Return CurrentButtonCount < MaxButtonCount
            End Get
        End Property
        Public Shared Property Top() As Integer
        Public Shared Property Left() As Integer
        Public Shared Property BaseWidth() As Integer
        Public Shared Property BaseHeightPadding() As Integer
        Public Shared Property BaseName() As String = "Button"
        Public Shared Property ButtonEventHandler() As EventHandler
        Public Shared Property ParentControl() As Control
        Public Shared Index As Integer = 1

        ''' <summary>
        ''' Initialize global properties old school
        ''' </summary>
        ''' <param name="pControl">Control to place button</param>
        ''' <param name="pTop">Top</param>
        ''' <param name="pBaseHeightPadding">Padding between buttons</param>
        ''' <param name="pLeft">Left position</param>
        ''' <param name="pWidth">Width of button</param>
        Public Shared Sub Initialize(pControl As Control, pTop As Integer, pBaseHeightPadding As Integer, pLeft As Integer, pWidth As Integer, pMaxButtonCount As Integer)

            ParentControl = pControl
            Top = pTop
            BaseHeightPadding = pBaseHeightPadding
            Left = pLeft
            BaseWidth = pWidth
            ButtonsList = New List(Of DataButton)()
            MaxButtonCount = pMaxButtonCount

        End Sub
        ''' <summary>
        ''' Initialize using an instance of <see cref="ButtonInitialization"/> which generally clearer than using the above method
        ''' </summary>
        ''' <param name="sender"><see cref="ButtonInitialization"/></param>
        Public Shared Sub Initialize(sender As ButtonInitialization)
            Initialize(sender.ParentControl, sender.Top, sender.BaseHeightPadding, sender.Left, sender.Width, sender.MaxButtonCount)
        End Sub
        Public Shared Sub CreateButton(Optional text As String = "")

            Dim button = New DataButton() With {
                        .Name = $"{BaseName}{Index}",
                        .Text = text,
                        .Width = BaseWidth,
                        .Location = New Point(Left, Top),
                        .Parent = ParentControl,
                        .Visible = True,
                        .Identifier = Index
                    }


            ButtonsList.Add(button)

            ParentControl.Controls.Add(button)
            Top += BaseHeightPadding
            Index += 1

        End Sub
        Public Shared Sub CreateButton(Optional text As String = "", Optional stash As String = "No stash today")

            Dim button = New DataButton() With {
                    .Name = $"{BaseName}{Index}",
                    .Text = text,
                    .Width = BaseWidth,
                    .Location = New Point(Left, Top),
                    .Parent = ParentControl,
                    .Visible = True,
                    .Identifier = Index, .Stash = stash
                    }


            ButtonsList.Add(button)

            ParentControl.Controls.Add(button)
            Top += BaseHeightPadding
            Index += 1

        End Sub
        ''' <summary>
        ''' Get all button names
        ''' </summary>
        ''' <returns></returns>
        Public Shared ReadOnly Property ButtonNames() As List(Of String)
            Get
                Return ButtonsList.Select(Function(button)
                                              Return button.Name
                                          End Function).ToList()
            End Get
        End Property
        ''' <summary>
        ''' Remove all buttons from parent control <see cref="ParentControl"/> and <see cref="ButtonsList"/>
        ''' </summary>
        Public Shared Sub RemoveAllButtons()

            If ButtonsList.Count = 0 Then
                Return
            End If

            For index As Integer = 0 To ButtonsList.Count - 1
                ParentControl.Controls.Remove(ButtonsList(index))
            Next

            ButtonsList = New List(Of DataButton)()


        End Sub
        ''' <summary>
        ''' Remove a specific button, needs work on position for next new button
        ''' </summary>
        ''' <param name="buttonName"></param>
        Public Shared Sub RemoveButton(buttonName As String)
            Dim button = ButtonsList.FirstOrDefault(Function(b) b.Name = buttonName)
            If button IsNot Nothing Then
                ParentControl.Controls.Remove(button)
                ButtonsList.Remove(button)
            End If
        End Sub
    End Class
End Namespace