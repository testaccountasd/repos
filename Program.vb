Imports System
Module Program
    Sub Main()
        Try
            Console.WriteLine(Factorial(-1))
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub
    Public Class NegativeNumberException
        Inherits Exception
        Sub New()
            MyBase.New("В качестве параметра передано отрицательное число")
        End Sub
    End Class
    Public Function Factorial(x As Integer) As Integer
        If x < 0 Then Throw New NegativeNumberException()
        If (x = 1) Then
            Return 1
        Else
            Return x * Factorial(x - 1)
        End If
    End Function
End Module
