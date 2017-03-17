Public Class Vector2D
    Public Shared ReadOnly Property Zero As Vector2D
        Get
            Return New Vector2D(0, 0)
        End Get
    End Property

    private dim dblX As Double
    private dim dblY As Double

    Public Sub New()
        Me.X = 0
        Me.Y = 0
    End Sub
    Public Sub New(x As Double, y As Double)
        Me.X = x
        Me.Y = y
    End Sub

    Public Property X as Double
        get
                Return dblX
        End Get
        Set
            dblX = value
        End Set
    End Property
    Public Property Y as Double
        get
                Return dblY
        End Get
        Set
            dblY = value
        End Set
    End Property

    Public Function Clone() As Vector2D
        Return New Vector2D(X, Y)
    End Function

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
    
    Public Shared Operator *(ByVal first As Vector2D, ByVal second As Vector2D) As Vector2D
        Return New Vector2D(first.X * second.X, first.Y * second.Y)
    End Operator
    Public Shared Operator *(ByVal first As Vector2D, ByVal second As Integer) As Vector2D
        Return New Vector2D(first.X * second, first.Y * second)
    End Operator
    Public Shared Operator *(ByVal first As Vector2D, ByVal second As Double) As Vector2D
        Return New Vector2D(first.X * second, first.Y * second)
    End Operator
    Public Shared Operator /(ByVal first As Vector2D, ByVal second As Vector2D) As Vector2D
        Return New Vector2D(first.X / second.X, first.Y / second.Y)
    End Operator
    Public Shared Operator /(ByVal first As Vector2D, ByVal second As Integer) As Vector2D
        Return New Vector2D(first.X / second, first.Y / second)
    End Operator
    Public Shared Operator /(ByVal first As Vector2D, ByVal second As Double) As Vector2D
        Return New Vector2D(first.X / second, first.Y / second)
    End Operator
    Public Shared Operator +(ByVal first As Vector2D, ByVal second As Vector2D) As Vector2D
        Return New Vector2D(first.X + second.X, first.Y + second.Y)
    End Operator
    Public Shared Operator -(ByVal first As Vector2D, ByVal second As Vector2D) As Vector2D
        Return New Vector2D(first.X - second.X, first.Y - second.Y)
    End Operator
    Public Shared Operator ^(ByVal first As Vector2D, ByVal second As Vector2D) As Vector2D
        Return New Vector2D(first.X ^ second.X, first.Y ^ second.Y)
    End Operator
    Public Shared Operator ^(ByVal first As Vector2D, ByVal second As Integer) As Vector2D
        Return New Vector2D(first.X ^ second, first.Y ^ second)
    End Operator
    Public Shared Operator ^(ByVal first As Vector2D, ByVal second As Double) As Vector2D
        Return New Vector2D(first.X ^ second, first.Y ^ second)
    End Operator
    Public Shared Operator Mod(ByVal first As Vector2D, ByVal second As Vector2D) As Vector2D
        Return New Vector2D(first.X Mod second.X, first.Y Mod second.Y)
    End Operator
    Public Shared Operator Mod(first As Vector2D, ByVal second As Integer) As Vector2D
        Return New Vector2D(first.X Mod second, first.Y Mod second)
    End Operator
    Public Shared Operator Mod(first As Vector2D, ByVal second As Double) As Vector2D
        Return New Vector2D(first.X Mod second, first.Y Mod second)
    End Operator

    Public Shared Operator =(ByVal first As Vector2D, ByVal second As Vector2D)
        If (first Is Nothing And second Is Nothing) Then
            Return True
        End If

        If ReferenceEquals(first, second) Then
            Return True
        End If

        Return (first.X = second.X) & (first.Y = second.Y)
    End Operator
    Public Shared Operator <>(ByVal first As Vector2D, ByVal second As Vector2D)
        If (first Is Nothing Or second Is Nothing) Then
            If (first Is Nothing And second Is Nothing) Then
                Return False
            Else
                Return True
            End If
        End If

        Return (first.X <> second.X) & (first.Y <> second.Y)
    End Operator

    Public Shared Widening Operator CType(point As Point) As Vector2D
        Return New Vector2D(point.X, point.Y)
    End Operator
End Class