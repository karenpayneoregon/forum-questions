Imports System.ComponentModel
Imports System.Windows.Forms

<ProvideProperty("SomeProperty", GetType(Control))>
Public Class ControlExtender
    Inherits Component
    Implements IExtenderProvider
    Private controls As New Hashtable
    Public Function CanExtend(extendee As Object) As Boolean Implements IExtenderProvider.CanExtend
        Return TypeOf extendee Is Control
    End Function

    Public Function GetSomeProperty(control As Control) As String
        If controls.ContainsKey(control) Then
            Return DirectCast(controls(control), String)
        End If

        Return Nothing
    End Function
    Public Sub SetSomeProperty(control As Control, value As String)
        If (String.IsNullOrEmpty(value)) Then
            controls.Remove(control)
        Else
            controls(control) = value
        End If
    End Sub
End Class