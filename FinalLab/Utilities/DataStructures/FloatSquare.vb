Public Class FloatSquare
    private dim dblX As Double
    private dim dblY As Double
    private dim dblHeight As Double
    private dim dblWidth As Double
    
    Public Sub New()
        Me.X = 0
        Me.Y = 0
        Me.Height = 0
        Me.Width = 0
    End Sub
    Public Sub New(dblX As Double, dblY As Double, dblHeight As Double, dblWidth As Double)
        Me.X = dblx
        Me.Y = dbly
        Me.Height = dblHeight
        Me.Width = dblWidth
    End Sub
    Public Sub New(vetPosition As Vector2D, vetSize As Vector2D)
        Me.Position = vetPosition
        Me.Size = vetSize
    End Sub
    Public Sub New(pntPosition As Point, pntSize As Point)
        Me.Position = pntPosition
        Me.Size = pntSize
    End Sub

    Public Property X As Double
        get
            return dblX
        End Get
        Set
            dblX = value
        End Set
    End Property
    Public Property Y As Double
        get
            return dblY
        End Get
        Set
            dblY = value
        End Set
    End Property
    Public Property Height As Double
        get
            return dblHeight
        End Get
        Set
            dblHeight = value
        End Set
    End Property
    Public Property Width As Double
        get
            return dblWidth
        End Get
        Set
            dblWidth = value
        End Set
    End Property
    Public Property Position As Vector2D
        Get
            Return New Vector2D(X, Y)
        End Get
        Set
            X = value.X
            Y = value.Y
        End Set
    End Property
    Public Property Size As Vector2D
        Get
            Return New Vector2D(Height, Width)
        End Get
        Set
            Height = value.X
            Width = value.Y
        End Set
    End Property

    Public Overrides Function Equals(obj As Object) As Boolean
        Return Me = obj
    End Function
    Public Overrides Function GetHashCode() As Integer
        Dim hash As Integer = 17

        hash = hash * 23 + X.GetHashCode()
        hash = hash * 23 + Y.GetHashCode()
        hash = hash * 23 + Height.GetHashCode()
        hash = hash * 23 + Width.GetHashCode()

        Return hash
    End Function
    Public Overrides Function ToString() As String
        Return $"({X},{Y},{Height},{Width})"
    End Function

    Public Shared Operator =(ByVal first As FloatSquare, ByVal second As FloatSquare)
        If (first Is Nothing And second Is Nothing) Then
            Return True
        End If

        If ReferenceEquals(first, second) Then
            Return True
        End If

        Return first.X = second.X And first.Y = second.Y And
            first.Height = second.Height And first.Width = second.Width
    End Operator
    Public Shared Operator <>(ByVal first As FloatSquare, ByVal second As FloatSquare)
        If (first Is Nothing Or second Is Nothing) Then
            If (first Is Nothing And second Is Nothing) Then
                Return False
            Else
                Return True
            End If
        End If

        Return first.X <> second.X And first.Y <> second.Y And
            first.Height <> second.Height And first.Width <> second.Width
    End Operator

    Public Shared Widening Operator CType(square As IntSquare) As FloatSquare
        Return New FloatSquare(square.X, square.Y, square.Height, square.Width)
    End Operator
End Class