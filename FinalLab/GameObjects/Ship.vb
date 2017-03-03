Public Class Ship
    Inherits GameObject

    Dim _maxHealth As Integer = -1
    Public ReadOnly Property MaxHealth As Integer
        Get
            Return _maxHealth
        End Get
    End Property

    Dim _health As Integer = -1
    Public ReadOnly Property Health As Integer
        Get
            Return _health
        End Get
    End Property

    Sub New(health As Integer, maxHeath As Integer)
        _maxHealth = maxHeath
        _health = health
    End Sub

    Public Sub Shoot(position As Vector2D)

    End Sub

    Public Sub Shoot(direction As Double)

    End Sub

    Friend Sub Damage(damage As Integer)
        _health -= damage
        If (_health < 0) Then
            Kill()
        End If
    End Sub

    Friend Sub Kill()
        ' Todo: Spawn explosion object

        ' Delete the ship
        Delete()
    End Sub
End Class