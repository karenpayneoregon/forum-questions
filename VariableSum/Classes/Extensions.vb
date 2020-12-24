Imports System.Linq.Expressions
Imports System.Reflection

Namespace Classes

    Public Module Extensions
        ''' <summary>
        ''' Source
        ''' https://stackoverflow.com/questions/17490080/how-to-do-a-sum-using-dynamic-linq/17490348
        ''' </summary>
        ''' <param name="source"></param>
        ''' <param name="member"></param>
        ''' <returns></returns>
        <Runtime.CompilerServices.Extension>
        Public Function Sum(source As IQueryable, member As String) As Object
            If source Is Nothing Then
                Throw New ArgumentNullException(NameOf(source))
            End If

            If member Is Nothing Then
                Throw New ArgumentNullException(NameOf(member))
            End If

            ' The most common variant of Queryable.Sum() expects a lambda.
            ' Since we just have a string to a property, we need to create a
            ' lambda from the string in order to pass it to the sum method.

            ' Lets create a ((TSource s) => s.Price ). First up, the parameter "s":
            Dim parameter As ParameterExpression = Expression.Parameter(source.ElementType, "s")

            ' Followed by accessing the Price property of "s" (s.Price):
            Dim [property] As PropertyInfo = source.ElementType.GetProperty(member)
            Dim getter As MemberExpression = Expression.MakeMemberAccess(parameter, [property])

            ' And finally, we create a lambda from that. First specifying on what
            ' to execute when the lambda is called, and finally the parameters of the lambda.
            Dim selector As Expression = Expression.Lambda(getter, parameter)

            ' There are a lot of Queryable.Sum() overloads with different
            ' return types  (double, int, decimal, double?, int?, etc...).
            ' We're going to find one that matches the type of our property.
            Dim sumMethod As MethodInfo = GetType(Queryable).GetMethods().First(
                Function(m) m.Name = "Sum" AndAlso m.ReturnType = [property].PropertyType AndAlso m.IsGenericMethod)

            ' Now that we have the correct method, we need to know how to call the method.
            ' Note that the Queryable.Sum<TSource>(source, selector) has a generic type,
            ' which we haven't resolved yet. Good thing is that we can use copy the one from
            ' our initial source expression.
            Dim genericSumMethod = sumMethod.MakeGenericMethod({source.ElementType})

            ' TSource, source and selector are now all resolved. We now know how to call
            ' the sum-method. We're not going to call it here, we just express how we're going
            ' call it.
            Dim callExpression = Expression.Call(Nothing, genericSumMethod, {source.Expression, Expression.Quote(selector)})

            ' Pass it down to the query provider. This can be a simple LinqToObject-data source,
            ' but also a more complex datasource (such as LinqToSql). Anyway, it knows what to
            ' do.
            Return source.Provider.Execute(callExpression)

        End Function

    End Module
End Namespace