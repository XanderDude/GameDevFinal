Option Strict On
Option Explicit On

Public Class Coin
    Inherits GameObject
    Private Const intScorePoints as Integer = 3
    Private Const dblMinXSpeed as Double = -0.5
    Private Const dblMaxXSpeed as Double = 0.5
    Private Const dblMinYSpeed as Double = 2
    Private Const dblMaxYSpeed as Double = 4

    Private Dim ReadOnly ctCoinType As CoinType = CoinType.Unknown
    Private Dim vetSpeed as Vector2D
    Private Dim gGame As frmFinalLab = Nothing
    
    Public Sub New(gGame As frmFinalLab, vetPosition As Vector2D, Optional ctCoinType As CoinType = Nothing)
        me.grabObjectBuffer = Graphics.FromImage(gGame.Buffer)

        me.gGame = gGame
        me.Position = vetPosition
        me.vetSpeed = new Vector2D(
            (gGame.Random.NextDouble() * (dblMaxXSpeed - dblMinXSpeed)) + dblMinXSpeed,
            (gGame.Random.NextDouble() * (dblMaxYSpeed - dblMinYSpeed)) + dblMinYSpeed)
        Me.ctCoinType = if(ctCoinType, CoinType.Random)
        me.bmpSprite = CType(Image.FromFile($"Images/{me.ctCoinType.SpriteName}.jpg"), Bitmap)
        me.bmpSprite.MakeTransparent(GlobalVariables.AplhaColor)
    End Sub
    
    Public ReadOnly Property CoinType As CoinType
    get
        return ctCoinType
    End Get
    End Property
    Public ReadOnly Property  Speed as Vector2D
    get
            Return vetSpeed
    End Get
    End Property
    
    Public Overrides Sub Update()
        Position += vetSpeed

        ' Check if the player ship hits the money
        If (Me.Collide(gGame.PlayerShip)) Then
            ' Give the player money
            gGame.Money += ctCoinType.Value
            ' Give the player some points
            gGame.Score += intScorePoints
            Me.Delete()

            ' Output money message
            gGame.OutputMessage($"You collected a {CoinType.Name} coin! You now have {gGame.Money} total money!")
        End If
    End Sub
End Class