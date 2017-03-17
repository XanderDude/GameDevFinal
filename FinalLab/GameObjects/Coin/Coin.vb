Public Class Coin
    Inherits GameObject
    Private game As frmFinalLab = Nothing

    Public ReadOnly CoinType As CoinType = CoinType.Unknown

    Private _animatedSprite As AnimatedSprite
    Public Sub New(game As frmFinalLab)
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
End Class