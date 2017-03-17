Option Strict On
Option Explicit On

Public Class Coin
    Inherits GameObject

    Private Dim ReadOnly ctCoinType As CoinType = CoinType.Unknown
    Private Dim gGame As frmFinalLab = Nothing
    
    Public Sub New(gGame As frmFinalLab, ctCoinType As CoinType)
        me.gGame = gGame
        Me.ctCoinType = ctCoinType
    End Sub
    
    Public ReadOnly Property CoinType As CoinType
    get
        return ctCoinType
    End Get
    End Property

    Public Overrides Sub Update()
        If (Me.Collide(gGame.PlayerShip)) Then
            gGame.Money += ctCoinType.Value
            Me.Delete()
        End If
    End Sub
End Class