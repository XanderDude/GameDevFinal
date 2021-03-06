﻿Public class IntSquare
    private dim intX As Integer
    private dim intY As Integer
    private dim intHeight As Integer
    private dim intWidth As Integer
    
    Public Sub New()
        Me.X = 0
        Me.Y = 0
        Me.Height = 0
        Me.Width = 0
    End Sub
    Public Sub New(intX As Integer, intY As Integer, intHeight As Integer, intWidth As Integer)
        Me.X = intX
        Me.Y = intY
        Me.Height = intHeight
        Me.Width = intWidth
    End Sub
    Public Sub New(pntPosition As Point, pntSize As Point)
        Me.Position = pntPosition
        Me.Size = pntSize
    End Sub

    Public Property X As Integer
        get
            return intX
        End Get
        Set
            intX = value
        End Set
    End Property
    Public Property Y As Integer
        get
            return intY
        End Get
        Set
            intY = value
        End Set
    End Property
    Public Property Height As Integer
        get
            return intHeight
        End Get
        Set
            intHeight = value
        End Set
    End Property
    Public Property Width As Integer
        get
            return intWidth
        End Get
        Set
            intWidth = value
        End Set
    End Property
    Public Property Position As Point
        Get
            Return New Point(X, Y)
        End Get
        Set
            X = value.X
            Y = value.Y
        End Set
    End Property
    Public Property Size As Point
        Get
            Return New Point(Height, Width)
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

    Public Shared Operator =(ByVal first As IntSquare, ByVal second As IntSquare)
        If (first Is Nothing And second Is Nothing) Then
            Return True
        End If

        If ReferenceEquals(first, second) Then
            Return True
        End If

        Return first.X = second.X And first.Y = second.Y And
            first.Height = second.Height And first.Width = second.Width
    End Operator
    Public Shared Operator <>(ByVal first As IntSquare, ByVal second As IntSquare)
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

    Public Shared Widening Operator CType(square As FloatSquare) As IntSquare
        Return New IntSquare(CInt(square.X), CInt(square.Y), CInt(square.Height), CInt(square.Width))
    End Operator
End class