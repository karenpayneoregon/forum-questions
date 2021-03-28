Imports System.ComponentModel
Imports System.Reflection.Emit

Module Module1

    Sub Main()
        Console.WriteLine("List")
        For Each item As String In ListExample()
            Console.WriteLine(item)
        Next

        Console.WriteLine()

        Console.WriteLine("ArrayList")
        For Each aItem As Object In ArrayListExample()
            Console.WriteLine(aItem)
        Next

        Console.ReadLine()

    End Sub

    Function ListExample() As List(Of String)
        Return New List(Of String) From {"Karen", "Anne", "Mike"}
    End Function
    Function ArrayListExample() As ArrayList
        Return New ArrayList From {"Karen", "Anne", "Mike"}
    End Function

End Module

