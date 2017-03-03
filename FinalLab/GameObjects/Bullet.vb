Public Class Bullet
    Inherits GameObject

    Property Damage As Integer
    Property Speed As Vector2D

    Dim _shooter As Ship
    Dim _game As Game

    Sub New(game As Game, shooter As Ship, speed As Vector2D, damage As Integer)
        Me._game = game
        Me._shooter = shooter
        Me.Speed = speed
        Me.Damage = damage
    End Sub

    Public Overrides Sub Update()
        ' Continue flying
        Acell += Speed

        ' Check for colision
        For Each enemyShip In _game.EnemyShips
            If (Me.Collide(enemyShip)) Then
                enemyShip.Damage(Damage)
                Me.Delete()
            End If
        Next
    End Sub

    Public Overrides Function Collide(testObject As IGameObject) As Boolean
        Throw New NotImplementedException
    End Function
End Class