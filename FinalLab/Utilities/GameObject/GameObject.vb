﻿Imports FinalLab

Public MustInherit Class GameObject
    Implements IGameObject

    Private _sprite As Sprite
    Public ReadOnly Property Sprite As Sprite
        Get
            Return _sprite
        End Get
    End Property

    Private _position As Vector2D
    Public Property Position As Vector2D Implements IGameObject.Position
        Get
            Return _position
        End Get
        Protected Set(value As Vector2D)
            _position = value
        End Set
    End Property

    Private _size As Vector2D
    Public Property Size As Vector2D Implements IGameObject.Size
        Get
            Return _size
        End Get
        Protected Set(value As Vector2D)
            _size = value
        End Set
    End Property

    Private _acell As Vector2D
    Public Property Acell As Vector2D Implements IGameObject.Acell
        Get
            Return _acell
        End Get
        Protected Set(value As Vector2D)
            _acell = value
        End Set
    End Property

    Private _deleteMe As Boolean
    Public Property DeleteMe As Boolean Implements IGameObject.DeleteMe
        Get
            Return _deleteMe
        End Get
        Protected Set(value As Boolean)
            _deleteMe = value
        End Set
    End Property

    Protected grabObjectBuffer As Graphics
    Protected bmpSprite As Bitmap

    Public MustOverride Sub Update() Implements IGameObject.Update

    Public Function Collide(testObject As IGameObject) As Boolean Implements IGameObject.Collide
        Return False
    End Function

    Public Sub Draw(grabBuffer As Graphics) Implements IGameObject.Draw
        Dim intDrawX As Integer = Math.Round(Position.X + (Size.X / 2.0F))
        Dim intDrawY As Integer = Math.Round(Position.Y + (Size.Y / 2.0F))

        grabBuffer.DrawImage(bmpSprite, intDrawX, intDrawY)
    End Sub

    Public Sub Delete()
        DeleteMe = True
    End Sub
End Class