Option Strict On
Option Explicit On

Public Class Background
    Inherits GameObject
    Private Const dblSCROLL_SPEED as Double = 0.5

    Private Dim gGame as frmFinalLab
    Private Dim dblScrollPosition as Double

    Public Sub New(gGame As frmFinalLab)
        Me.gGame = gGame
        Me.dblScrollPosition = 0

        Me.bmpSprite = CType(Image.FromFile("Images/background.jpg"), Bitmap)
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
        grabBuffer.DrawImageUnscaled(bmpSprite, 0, CInt(Math.Round(dblScrollPosition)), CInt(Size.X), CInt(Size.Y))

        ' Draw the sprite again at the top of the sprite so white space doesnt show
        grabBuffer.DrawImageUnscaled(bmpSprite, 0, CInt(Math.Round(dblScrollPosition - gGame.pnlGame.Height)), CInt(Size.X), CInt(Size.Y))
    End sub
End Class
