Public Class frmFinalLab
    Dim game As Game

    Public sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        game = game.GetGame()
    End Sub

    Private Sub frmFinalLab_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmFinalLab_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'game.Keyboard.PressKey()
    End Sub
End Class
