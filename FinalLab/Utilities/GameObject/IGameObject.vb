Public Interface IGameObject
    ReadOnly Property Sprite As Bitmap
    
    ReadOnly Property Position As Vector2D
    ReadOnly Property Size As Vector2D
    ReadOnly Property DeleteMe As Boolean
    
    Function Collide(testObject As IGameObject) As Boolean
    Sub Update()
    Sub Draw(grabBuffer As Graphics)
    Sub Delete()
End Interface