Public Class Coin
    Inherits GameObject
    Private game As Game = Nothing

    Public ReadOnly CoinType As CoinType = CoinType.Unknown

    Private _animatedSprite As AnimatedSprite
    Public Sub New()
        game = Game.GetGame()
    End Sub

    Public Overrides Sub Update()
        If (Me.Collide(game.PlayerShip)) Then
            game.intMoney += CoinType.Value
            Me.Delete()
        End If
    End Sub

    Public Sub New(coinType As CoinType)
        Me.CoinType = coinType

        _animatedSprite.ChangeSprite(coinType.SpriteName)
    End Sub
End Class