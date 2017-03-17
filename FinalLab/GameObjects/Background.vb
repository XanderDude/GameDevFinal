Public Class Background
    Inherits GameObject
    Private Const dblSCROLL_SPEED as Double = 0.5

    Private Dim gGame as frmFinalLab
    Private Dim dblScrollPosition as Double

    Public Sub New(gGame As frmFinalLab)
        Me.gGame = gGame
        Me.dblScrollPosition = 0

        Me.bmpSprite = Image.FromFile("Images/background.jpg")
    End Sub

    Public Overrides Sub Update()
        dblScrollPosition += dblSCROLL_SPEED

        ' If the scroll has reached the size of the screen, it's time to send it back to the beggining
        if dblScrollPosition > gGame.pnlGame.Height
            dblScrollPosition = dblScrollPosition - gGame.pnlGame.Height
        End If
    End Sub

    Public Overloads sub Draw(grabBuffer As Graphics)
        ' Draw the sprite
        grabBuffer.DrawImageUnscaled(bmpSprite, 0, dblScrollPosition, CSng(Size.X), CSng(Size.Y))
        
        ' Draw the sprite again at the top of the sprite so white space doesnt show
        grabBuffer.DrawImageUnscaled(bmpSprite, 0, dblScrollPosition - gGame.pnlGame.Height, CSng(Size.X), CSng(Size.Y))
    End sub
End Class
