Option Strict On
Option Explicit On

Public Interface IGameObject
    ReadOnly Property Sprite As Bitmap
    
    ReadOnly Property Position As Vector2D
    ReadOnly Property Size As Point
    ReadOnly Property DeleteMe As Boolean
    
    Function Collide(goTestObject As IGameObject) As Boolean
    Sub Update()
    Sub Draw(grabBuffer As Graphics)
    Sub Delete()
End Interface