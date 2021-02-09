Imports System.IO
Imports System.Net
Imports Newtonsoft.Json

Module Module1

	Sub Main()


		MainAsync(New String() {"Hello", "Karen"}).
				  GetAwaiter().
				  GetResult()


		Dim results = Task.WhenAll(
			ExampleOne,
			ExampleTwo).
				Result


		For Each result In results
			Console.WriteLine(result)
		Next

		Console.ReadLine()
	End Sub

	Public Async Function MainAsync(ByVal args() As String) As Task

        Await Task.Delay(30)
        Console.WriteLine($"{args(0)} {args(1)}")

    End Function
    Async Function ExampleOne() As Task(Of Integer)

        Await Task.Delay(500)

		Using webClient As New WebClient

			webClient.Headers.Add("User-Agent", "AWNHD Weather Broadcast Engine/v1.0 (website; email")

			Dim json As String = webClient.DownloadString("https://api.weather.gov/alerts/active?area=OR")

			Dim results As Root = JsonConvert.DeserializeObject(Of Root)(json)

			Console.WriteLine($"Title: {results.title}")

			For Each feature As Feature In results.features

				Console.WriteLine($"Event: {feature.properties.event} " &
								  $"Type: {feature.properties.Type.Replace("wx:", "")}")

				Console.WriteLine($"   Description: {feature.properties.description}")

				Console.WriteLine(New String("-"c, 30))

				Console.WriteLine($"{vbTab}Affected zones")

				For Each affectedZone As String In feature.properties.affectedZones
					Console.WriteLine($"{vbTab}{vbTab}{affectedZone}")
				Next

				Console.WriteLine()

				Console.WriteLine($"{vbTab}geocode.SAME")

				For Each s As String In feature.properties.geocode.SAME
					Console.WriteLine($"{vbTab}{vbTab}{s}")
				Next

				Console.WriteLine()

			Next

		End Using

		Return 40

    End Function

    Async Function ExampleTwo() As Task(Of Integer)
        Await Task.Delay(5000)

        Return 60

    End Function
End Module

Public Class Geocode
	Public Property UGC() As List(Of String)
	Public Property SAME() As List(Of String)
End Class

Public Class Reference
	<JsonProperty("@id")>
	Public Property Id() As String
	Public Property identifier() As String
	Public Property sender() As String
	Public Property sent() As DateTime
End Class

Public Class Parameters
	Public Property NWSheadline() As List(Of String)
	Public Property VTEC() As List(Of String)
	Public Property PIL() As List(Of String)
	Public Property BLOCKCHANNEL() As List(Of String)
	Public Property eventEndingTime() As List(Of DateTime)
	Public Property HazardType() As List(Of String)
	<JsonProperty("EAS-ORG")>
	Public Property EASORG() As List(Of String)
End Class

Public Class Properties
	<JsonProperty("@id")>
	Public Property Id() As String
	<JsonProperty("@type")>
	Public Property Type() As String
	Public Property areaDesc() As String
	Public Property geocode() As Geocode
	Public Property affectedZones() As List(Of String)
	Public Property references() As List(Of Reference)
	Public Property sent() As DateTime
	Public Property effective() As DateTime
	Public Property onset() As DateTime
	Public Property expires() As DateTime
	Public Property ends() As DateTime
	Public Property status() As String
	Public Property messageType() As String
	Public Property category() As String
	Public Property severity() As String
	Public Property certainty() As String
	Public Property urgency() As String
	Public Property [event]() As String
	Public Property sender() As String
	Public Property senderName() As String
	Public Property headline() As String
	Public Property description() As String
	Public Property instruction() As String
	Public Property response() As String
	Public Property parameters() As Parameters
End Class

Public Class Feature
	Public Property id() As String
	Public Property type() As String
	Public Property geometry() As Object
	Public Property properties() As Properties
End Class

Public Class Root
	<JsonProperty("@context")>
	Public Property Context() As List(Of Object)
	Public Property type() As String
	Public Property features() As List(Of Feature)
	Public Property title() As String
	Public Property updated() As DateTime
End Class
