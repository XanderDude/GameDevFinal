Public Class Bullet
    Inherits GameObject

    Property Damage As Integer

    Dim _shooter As Ship
    Dim _game As Game

    Sub New(game As Game, shooter As Ship, vecPosition As Vector2D)
        Me._game = game
        Me._shooter = shooter
        Me.Position = vecPosition
        Me.Size = New Vector2D(16, 16)

        Me.bmpSprite = Bitmap.FromFile("Images/bullet.jpg")
    End Sub

    Public Overrides Sub Update()
        Dim dblSpeed As Double = 3.5

        ' Continue flying
        Position.Y -= dblSpeed

        ' Check for colision
        For Each enemyShip In _game.EnemyShips
            If (Me.Collide(enemyShip)) Then
                enemyShip.Damage(Damage)
                Me.Delete()
            End If
        Next
    End Sub
End Class