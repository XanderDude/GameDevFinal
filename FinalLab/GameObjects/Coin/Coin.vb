Public Class Coin
    Inherits GameObject
    Private game As Game = Nothing

    Public ReadOnly CoinType As CoinType = CoinType.Unknown

    Private _animatedSprite As AnimatedSprite
    Public Sub New(game As Game)
        me.game = game
    End Sub

    Public Overrides Sub Update()
        If (Me.Collide(game.PlayerShip)) Then
            game.Money += CoinType.Value
            Me.Delete()
        End If
    End Sub

    Public Sub New(coinType As CoinType)
        Me.CoinType = coinType

        _animatedSprite.ChangeSprite(coinType.SpriteName)
    End Sub

    Public Overrides Function Collide(testObject As IGameObject) As Boolean
        Throw New NotImplementedException
    End Function
End Class