# About

A common question in developer forums is how to create dynamic buttons without consideration for the Click event.

This project uses a custom button with several custom properties to assist with working with logic in the button click event like storing a primary key from a database table to retrieve data.

:yellow_circle:  `.NET Framework` is used and will work with `.NET Core Framework` too Only reason for not using .NET Core is this way both Frameworks can use this code.

| Class/module |  Definition
| :---- | :---- |
| [ButtonInitialization](https://github.com/karenpayneoregon/forum-questions/blob/master/CreateDynamicControls_vb/Classes/ButtonInitialization.vb) class | Used to initialize code in ButtonOperations init 
| [ButtonOperations](https://github.com/karenpayneoregon/forum-questions/blob/master/CreateDynamicControls_vb/Classes/ButtonOperations.vb) class | Responsible for creating buttons 
| [Helpers](https://github.com/karenpayneoregon/forum-questions/blob/master/CreateDynamicControls_vb/Classes/Helpers.vb) | Utility methods 
| [StringExtensions](https://github.com/karenpayneoregon/forum-questions/blob/master/CreateDynamicControls_vb/Classes/StringExtensions.vb) module | String extension methods 


## Example screen

![image](assets/buttonForm.png)


## Custom Button

Has several useful properties

```csharp
Namespace Controls
    Public Class DataButton
        Inherits Button
        ''' <summary>
        ''' Useful for assigning a key from a database table primary key etc
        ''' </summary>
        ''' <returns></returns>
        Public Property Identifier() As Integer
        ''' <summary>
        ''' Useful for storing whatever such as a comment
        ''' </summary>
        ''' <returns></returns>
        Public Property Stash() As String
    End Class
End Namespace
```
