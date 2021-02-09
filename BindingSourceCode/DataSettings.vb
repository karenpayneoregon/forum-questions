Imports System.Windows.Forms

Public NotInheritable Class DataSettings

    Private Shared ReadOnly Lazy As New Lazy(Of DataSettings)(Function() New DataSettings())

    Public Shared ReadOnly Property Instance() As DataSettings
        Get
            Return Lazy.Value
        End Get
    End Property
    Public BindingSource As BindingSource
    Private Sub New()
        BindingSource = New BindingSource()
    End Sub
End Class

Public Class Test
    Public Sub Demo()
        DataSettings.Instance.BindingSource.Filter = ""

    End Sub

End Class
