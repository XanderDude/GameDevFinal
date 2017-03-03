Public Class GuiButton
    Implements IGui

    Public Property Position As Point Implements IGui.Position
    Public Property Size As Point Implements IGui.Size

    Public Sub Update() Implements IGui.Update
        Throw New NotImplementedException()
    End Sub
    Public Sub Draw() Implements IGui.Draw
        Throw New NotImplementedException()
    End Sub
End Class