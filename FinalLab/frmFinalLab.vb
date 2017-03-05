Public Class frmFinalLab
    Dim game As Game
    Dim grabBuffer As Graphics
    
    Public sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        game = new Game()
    End Sub

    Private Sub frmFinalLab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grabBuffer = pnlGame.CreateGraphics()
    End Sub
    
    Private Sub frmFinalLab_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown

    End Sub

    Private Sub mnuStory_Click(sender As Object, e As EventArgs) Handles mnuStory.Click
        dim frmForm as Form = new frmStory()
        frmForm.ShowDialog()
    End Sub
End Class
