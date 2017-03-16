Public Class Ship
    Inherits GameObject

    Dim _maxLives As Integer = -1
    Public ReadOnly Property MaxHealth As Integer
        Get
            Return _maxLives
        End Get
    End Property

    Dim _lives As Integer = -1
    Public ReadOnly Property Lives As Integer
        Get
            Return _lives
        End Get
    End Property

    Protected gGame As Game

    Sub New(gGame As Game, maxLives As Integer, lives As Integer)
        Me.gGame = gGame
        _maxLives = maxLives
        _lives = lives
    End Sub

    Friend Sub Damage(Optional lives As Integer = 1)
        _lives -= lives
        If (_lives < 0) Then
            Kill()
        End If
    End Sub

    Friend Sub Kill()
        'Spawn Explosion object
        gGame.Spawn(New Explosion(gGame, Position.Clone()))

        ' Delete the ship
        Delete()
    End Sub

    Public Overrides Sub Update()
        Throw New NotImplementedException
    End Sub
End Class