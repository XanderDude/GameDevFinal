Public Class Coin
    Inherits GameObject
    Private game As frmFinalLab = Nothing

    Private Dim ReadOnly ctCoinType As CoinType = CoinType.Unknown
    
    Public Sub New(game As frmFinalLab, ctCoinType As CoinType)
        me.game = game
        Me.ctCoinType = ctCoinType
    End Sub
    
    Public ReadOnly Property CoinType As CoinType
    get
        return ctCoinType
    End Get
    End Property

    Public Overrides Sub Update()
        If (Me.Collide(game.PlayerShip)) Then
            game.Money += ctCoinType.Value
            Me.Delete()
        End If
    End Sub
End Class