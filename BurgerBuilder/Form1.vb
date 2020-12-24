Imports BurgerBuilder.Classes

Public Class Form1
    Private Sub BuildBurgerButton_Click(sender As Object, e As EventArgs) Handles BuildBurgerButton.Click

        Dim burger As Burger = New Classes.BurgerBuilder(14).
                AddPepperoni().
                AddLettuce().
                AddTomato().
                Build()

    End Sub
End Class
