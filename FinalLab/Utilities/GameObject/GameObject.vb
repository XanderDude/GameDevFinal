Option Strict On
Option Explicit On

Public MustInherit Class GameObject
    Implements IGameObject
    
    Private dim vetPosition As Vector2D
    Private dim boolDeleteMe As Boolean
    Protected dim grabObjectBuffer As Graphics
    Protected dim bmpSprite As Bitmap

    Public Property Position As Vector2D Implements IGameObject.Position
        Get
            Return vetPosition
        End Get
        Protected Set
            vetPosition = value
        End Set
    End Property
    Public ReadOnly Property Size As Vector2D Implements IGameObject.Size
        Get
            Return New Vector2D(bmpSprite.Width, bmpSprite.Height)
        End Get
    End Property
    Protected ReadOnly Property Sprite As Bitmap Implements IGameObject.Sprite
        Get
            Return bmpSprite
        End Get
    End Property
    Public Overridable Property DeleteMe As Boolean Implements IGameObject.DeleteMe
        Get
            Return boolDeleteMe
        End Get
        Protected Set
            boolDeleteMe = value
        End Set
    End Property

    Public MustOverride Sub Update() Implements IGameObject.Update
    Public Overridable Function Collide(goTestObject As IGameObject) As Boolean Implements IGameObject.Collide
        ' test rectangle collision
        Dim recFirsObject As Rectangle = New Rectangle(
            New Drawing.Point(CInt(Math.Round(Position.X)),
            CInt(Math.Round(Position.Y))), 
            New Size(CInt(Math.Round(Size.X)), CInt(Math.Round(Size.Y))))

        Dim recSecondObject As Rectangle = New Rectangle(
            New Drawing.Point(CInt(Math.Round(Position.X)), cint(Math.Round(Position.Y))), 
            New Size(CInt(Math.Round(Size.X)), CInt(Math.Round(Size.Y))))

        Dim vetSecondObjectOffset As Vector2D = New Vector2D(
                        Position.X - goTestObject.Position.X,
                        Position.Y - goTestObject.Position.Y)

        If (recFirsObject.IntersectsWith(recSecondObject)) Then
            ' Okay now test pixel collision
            Dim bmpFirstObject As Bitmap = bmpSprite
            Dim bmpSecondObject As Bitmap = goTestObject.Sprite

            ' Check if the first object is hitting the second object
            For x As Short = 0 To CShort(bmpFirstObject.Width - 1)
                For y As Short = 0 To CShort(bmpFirstObject.Height - 1)
                    ' Check if the pixel could even be hitting the second object's pixel
                    If (x + vetSecondObjectOffset.X < 0 Or x + vetSecondObjectOffset.X > bmpSecondObject.Width - 1) Then
                        Continue For
                    End If
                    If (y + vetSecondObjectOffset.Y < 0 Or y + vetSecondObjectOffset.Y > bmpSecondObject.Height - 1) Then
                        Continue For
                    End If

                    ' Get the colors of the two pixels that are colliding
                    Dim pxlFirstPixel = bmpFirstObject.GetPixel(x, y)
                    Dim pxlSecondPixel = bmpSecondObject.GetPixel(CInt(Math.Round(x + vetSecondObjectOffset.X)), CInt(Math.Round(y + vetSecondObjectOffset.Y)))

                    ' Continue if any of the pixels are the alpha color
                    If (pxlFirstPixel = GlobalVariables.AplhaColor) Then
                        Continue For
                    End If
                    If (pxlSecondPixel = GlobalVariables.AplhaColor) Then
                        Continue For
                    End If

                    ' Okay it collides, all tests are done.
                    Return True
                Next
            Next
        End If

        Return False
    End Function
    Public Overridable Sub Draw(grabBuffer As Graphics) Implements IGameObject.Draw
        grabBuffer.DrawImageUnscaled(bmpSprite, CInt(Position.X), CInt(Position.Y), CInt(Size.X), CInt(Size.Y))
    End Sub
    Public Overridable Sub Delete() Implements IGameObject.Delete
        DeleteMe = True
    End Sub
End Class