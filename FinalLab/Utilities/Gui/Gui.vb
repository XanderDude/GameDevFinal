Public Class Gui
    Implements IGui

    Dim backgroundImage As Bitmap

    Public Property Position As Point Implements IGui.Position

    Public Property Size As Point Implements IGui.Size

    Public MustOverride Sub Update() Implements IGui.Update
    Public Sub Draw() Implements IGui.Draw
        Throw New NotImplementedException()
    End Sub
End Class