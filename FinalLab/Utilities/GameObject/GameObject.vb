Option Strict On
Option Explicit On

Public MustInherit Class GameObject
    Implements IGameObject
    
    Private dim vetPosition As Vector2D
    Protected dim bmpSprite As Bitmap
    Protected dim grabObjectBuffer As Graphics
    Private dim boolDeleteMe As Boolean
    
    Public Property Position As Vector2D Implements IGameObject.Position
        Get
            Return vetPosition
        End Get
        Protected Set
            vetPosition = value
        End Set
    End Property
    Public ReadOnly Property Size As Point Implements IGameObject.Size
        Get
            Return New Point(bmpSprite.Width, bmpSprite.Height)
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

        ' Get the pixel rectangle of each object
        Dim recFirsObject As Rectangle = New Rectangle(
            New Drawing.Point(
                CInt(Math.Round(Position.X)), 
                CInt(Math.Round(Position.Y))), 
            New Size(Size.X, Size.Y))

        Dim recSecondObject As Rectangle = New Rectangle(
            New Drawing.Point(
                CInt(Math.Round(goTestObject.Position.X)), 
                cint(Math.Round(goTestObject.Position.Y))), 
            new Size(goTestObject.Size.X, goTestObject.Size.Y))

        ' Get the offset the second object is from the second
        Dim pntDistanceFromFirstObjectToSecond As Point = New Point(
                        recSecondObject.X - recFirsObject.X,
                        recSecondObject.Y - recFirsObject.Y)

        ' Do Rectangle hit detection
        If (recFirsObject.IntersectsWith(recSecondObject)) Then
            ' Somewhere along I broke the pixel hit detection :(
            return true
            
            ' Okay now test pixel collision
            Dim bmpFirstObject As Bitmap = bmpSprite
            Dim bmpSecondObject As Bitmap = goTestObject.Sprite

            ' Check if the first object is hitting the second object
            For x As Short = 0 To CShort(bmpFirstObject.Width - 1)
                For y As Short = 0 To CShort(bmpFirstObject.Height - 1)
                    ' Check if the pixel could even be hitting the second object's pixel
                    If (x + pntDistanceFromFirstObjectToSecond.X < 0 Or x + pntDistanceFromFirstObjectToSecond.X > bmpSecondObject.Width - 1) Then
                        Continue For
                    End If
                    If (y + pntDistanceFromFirstObjectToSecond.Y < 0 Or y + pntDistanceFromFirstObjectToSecond.Y > bmpSecondObject.Height - 1) Then
                        Continue For
                    End If

                    ' Get the colors of the two pixels that are colliding
                    Dim pxlFirstPixel = bmpFirstObject.GetPixel(x, y)
                    Dim pxlSecondPixel = bmpSecondObject.GetPixel(x + pntDistanceFromFirstObjectToSecond.X, y + pntDistanceFromFirstObjectToSecond.Y)

                    ' Continue if any of the pixels are the alpha color
                    If (pxlFirstPixel = GlobalVariables.AplhaColor OR pxlSecondPixel.A = 0) Then
                        Continue For
                    End If
                    If (pxlSecondPixel = GlobalVariables.AplhaColor OR pxlSecondPixel.A = 0) Then
                        Continue For
                    End If

                    ' Okay it collides, all tests are done.
                    Return True
                Next
            Next
        End If

        Return False
    End Function
    Public Overridable Sub Draw() Implements IGameObject.Draw
        grabObjectBuffer.DrawImageUnscaled(bmpSprite, CInt(Position.X), CInt(Position.Y), Size.X, Size.Y)
    End Sub
    Public Overridable Sub Delete() Implements IGameObject.Delete
        DeleteMe = True
    End Sub
End Class