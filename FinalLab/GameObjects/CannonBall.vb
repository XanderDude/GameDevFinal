Public Class CannonBall
    Inherits GameObject

    Property Damage As Integer
    
    Dim _game As frmFinalLab

    Sub New(game As frmFinalLab, vecPosition As Vector2D)
        Me._game = game
        Me.Position = vecPosition

        Me.bmpSprite = Image.FromFile("Images/cball.jpg")
    End Sub

    Public Overrides Sub Update()
        Dim dblSpeed As Double = 3.5

        ' Continue flying
        Position.Y -= dblSpeed
    End Sub
End Class