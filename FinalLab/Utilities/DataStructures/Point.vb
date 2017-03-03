Public Class Point
    Property X As Integer
    Property Y As Integer

    Public Sub New()
        Me.X = 0
        Me.Y = 0
    End Sub
    Public Sub New(x As Integer, y As Integer)
        Me.X = x
        Me.Y = y
    End Sub

    Public Overrides Function Equals(obj As Object) As Boolean
        Return Me = obj
    End Function
    Public Overrides Function GetHashCode() As Integer
        Dim hash As Integer = 17

        hash = hash * 23 + X.GetHashCode()
        hash = hash * 23 + Y.GetHashCode()

        Return hash
    End Function
    Public Overrides Function ToString() As String
        Return $"({X},{Y})"
    End Function

    Public Shared Operator *(ByVal first As Point, ByVal second As Point) As Point
        Return New Point(first.X * second.X, first.Y * second.Y)
    End Operator
    Public Shared Operator *(ByVal first As Point, ByVal second As Integer) As Point
        Return New Point(first.X * second, first.Y * second)
    End Operator
    Public Shared Operator *(ByVal first As Point, ByVal second As Double) As Point
        Return New Point(first.X * second, first.Y * second)
    End Operator
    Public Shared Operator /(ByVal first As Point, ByVal second As Point) As Point
        Return New Point(first.X / second.X, first.Y / second.Y)
    End Operator
    Public Shared Operator /(ByVal first As Point, ByVal second As Integer) As Point
        Return New Point(first.X / second, first.Y / second)
    End Operator
    Public Shared Operator /(ByVal first As Point, ByVal second As Double) As Point
        Return New Point(first.X / second, first.Y / second)
    End Operator
    Public Shared Operator +(ByVal first As Point, ByVal second As Point) As Point
        Return New Point(first.X + second.X, first.Y + second.Y)
    End Operator
    Public Shared Operator -(ByVal first As Point, ByVal second As Point) As Point
        Return New Point(first.X - second.X, first.Y - second.Y)
    End Operator
    Public Shared Operator ^(ByVal first As Point, ByVal second As Point) As Point
        Return New Point(first.X ^ second.X, first.Y ^ second.Y)
    End Operator
    Public Shared Operator ^(ByVal first As Point, ByVal second As Integer) As Point
        Return New Point(first.X ^ second, first.Y ^ second)
    End Operator
    Public Shared Operator ^(ByVal first As Point, ByVal second As Double) As Point
        Return New Point(first.X ^ second, first.Y ^ second)
    End Operator
    Public Shared Operator Mod(ByVal first As Point, ByVal second As Point) As Point
        Return New Point(first.X Mod second.X, first.Y Mod second.Y)
    End Operator
    Public Shared Operator Mod(first As Point, ByVal second As Integer) As Point
        Return New Point(first.X Mod second, first.Y Mod second)
    End Operator
    Public Shared Operator Mod(first As Point, ByVal second As Double) As Point
        Return New Point(first.X Mod second, first.Y Mod second)
    End Operator

    Public Shared Operator =(ByVal first As Point, ByVal second As Point)
        If (first Is Nothing And second Is Nothing) Then
            Return True
        End If

        If ReferenceEquals(first, second) Then
            Return True
        End If

        Return first.X = second.X & first.Y = second.Y
    End Operator
    Public Shared Operator <>(ByVal first As Point, ByVal second As Point)
        If (first Is Nothing Or second Is Nothing) Then
            If (first Is Nothing And second Is Nothing) Then
                Return False
            Else
                Return True
            End If
        End If

        Return first.X <> second.X & first.Y <> second.Y
    End Operator

    Public Shared Widening Operator CType(vector As Vector2D) As Point
        Return New Point(vector.X, vector.Y)
    End Operator
End Class