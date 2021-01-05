Option Infer On

Imports NodaTime

Friend Class Program
    Shared Sub Main()
        Dim startDate As LocalDate = New LocalDate(2021, 1, 13)
        Console.WriteLine(startDate.ToDateTimeUnspecified())
        Console.WriteLine(startDate.PlusMonths(3))
        Console.WriteLine($"{#1/13/2021#.AddMonths(3)}")
        Console.ReadLine()
    End Sub

End Class
