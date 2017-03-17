Imports FinalLab

Public MustInherit Class GameObject
    Implements IGameObject
    
    Private vetPosition As Vector2D
    Private boolDeleteMe As Boolean
    Protected grabObjectBuffer As Graphics
    Protected bmpSprite As Bitmap

    Public Property Position As Vector2D Implements IGameObject.Position
        Get
            Return vetPosition
        End Get
        Protected Set(value As Vector2D)
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
    Public Property DeleteMe As Boolean Implements IGameObject.DeleteMe
        Get
            Return boolDeleteMe
        End Get
        Protected Set(value As Boolean)
            boolDeleteMe = value
        End Set
    End Property

    Public MustOverride Sub Update() Implements IGameObject.Update

    Public Function Collide(testObject As IGameObject) As Boolean Implements IGameObject.Collide
        Dim colAplhaColor = Color.FromArgb(255, 0, 250, 249)

        ' test rectangle collision
        Dim recFirsObject As Rectangle = New Rectangle(New Drawing.Point(Position.X, Position.Y), New Size(Size.X, Size.Y))
        Dim recSecondObject As Rectangle = New Rectangle(New Drawing.Point(Position.X, Position.Y), New Size(Size.X, Size.Y))
        Dim vetSecondObjectOffset As Vector2D = New Vector2D(
                        Position.X - testObject.Position.X,
                        Position.Y - testObject.Position.Y)

        If (recFirsObject.IntersectsWith(recSecondObject)) Then
            ' Okay now test pixel collision
            Dim bmpFirstObject As Bitmap = bmpSprite
            Dim bmpSecondObject As Bitmap = testObject.Sprite

            ' Check if the first object is hitting the second object
            For x As Short = 0 To bmpFirstObject.Width - 1
                For y As Short = 0 To bmpFirstObject.Height - 1
                    ' Check if the pixel could even be hitting the second object's pixel
                    If (x + vetSecondObjectOffset.X < 0 Or x + vetSecondObjectOffset.X > bmpSecondObject.Width - 1) Then
                        Continue For
                    End If
                    If (y + vetSecondObjectOffset.Y < 0 Or y + vetSecondObjectOffset.Y > bmpSecondObject.Height - 1) Then
                        Continue For
                    End If

                    ' Get the colors of the two pixels that are colliding
                    Dim pxlFirstPixel = bmpFirstObject.GetPixel(x, y)
                    Dim pxlSecondPixel = bmpSecondObject.GetPixel(x + vetSecondObjectOffset.X, y + vetSecondObjectOffset.Y)

                    ' Continue if any of the pixels are the alpha color
                    If (pxlFirstPixel = colAplhaColor) Then
                        Continue For
                    End If
                    If (pxlSecondPixel = colAplhaColor) Then
                        Continue For
                    End If

                    ' Okay it collides, all tests are done.
                    Return True
                Next
            Next
        End If

        Return False
    End Function

    Public Sub Draw(grabBuffer As Graphics) Implements IGameObject.Draw
        grabBuffer.DrawImageUnscaled(bmpSprite, CSng(Position.X), CSng(Position.Y), CSng(Size.X), CSng(Size.Y))
    End Sub

    Public Sub Delete() Implements IGameObject.Delete
        DeleteMe = True
    End Sub
End Class