Imports System.ComponentModel
Imports System.Runtime.CompilerServices

Namespace Classes
    Public Module ControlExtensions

        <Extension>
        Public Sub InvokeIfRequired(Of T As ISynchronizeInvoke)(ByVal control As T, action As Action(Of T))

            If control.InvokeRequired Then
                control.Invoke(New Action(Sub() action(control)), Nothing)
            Else
                action(control)
            End If
        End Sub

    End Module
End NameSpace