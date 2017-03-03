Public Interface IGameObject
    ReadOnly Property Position As Vector2D
    ReadOnly Property Size As Vector2D
    ReadOnly Property Acell As Vector2D
    Property DeleteMe As Boolean
    Sub Update()
    Function Collide(testObject As IGameObject) As Boolean
End Interface