

Namespace Classes
	''' <summary>
	''' Class to work against, specifically
	''' Weight and Height properties
	''' </summary>
	Public Class Sample
		Public Property Weight() As Double
		Public Property Height() As Double
		Public Property Group() As Integer
	End Class
	Public Class Mocked
		''' <summary>
		''' Mock up a list for use in Operations.Example1
		''' </summary>
		''' <returns></returns>
		Public Shared Function SampleList() As List(Of Sample)
			Return New List(Of Sample) From {
				New Sample() With {.Group = 1, .Height = 12.4D, .Weight = 100.3D},
				New Sample() With {.Group = 1, .Height = 22.4D, .Weight = 10.4D}
			}
		End Function
	End Class
	Public Class Operations
		Public Shared Sub Example1()

			Dim heightResults = Mocked.SampleList().AsQueryable().Sum("Height")
			Dim weightResults = Mocked.SampleList().AsQueryable().Sum("Weight")

			Debug.WriteLine($"Height sum: {heightResults}")
			Debug.WriteLine($"Weight sum: {weightResults}")

		End Sub

	End Class
End Namespace