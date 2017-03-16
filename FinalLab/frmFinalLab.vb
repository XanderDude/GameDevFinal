Option Explicit On
Option Strict On

Imports System.Threading

Public Class frmFinalLab
    Dim game As Game
    Dim grabBuffer As Graphics
    Dim boolGamePaused As Boolean = False
    Dim boolIsRunning As Boolean = False
    Dim cstrSongPath As String = Application.StartupPath


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        game = New Game()
    End Sub

    Private Sub frmFinalLab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grabBuffer = pnlGame.CreateGraphics()
        cstrSongPath = cstrSongPath.Substring(0, cstrSongPath.Length - "Debug".Length) & "Sounds\CS161-FinalMenuLoop.wav"

        pnlMainMenu.Visible = True
        pnlPauseMenu.Visible = False

        pnlMainMenu.BringToFront()
        pnlMainMenu.Left = 0
        pnlMainMenu.Top = 0

        wmpPlayer.URL = "Sound\CS161-FinalMenuLoop.wav"
        wmpPlayer.Ctlcontrols.play()



    End Sub
    Private Sub frmFinalLab_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Const dblMOVE_SPEED As Double = 5

        Select Case e.KeyData
            Case Keys.Up
                game.PlayerShip.Position.Y -= dblMOVE_SPEED
            Case Keys.Down
                game.PlayerShip.Position.Y += dblMOVE_SPEED
            Case Keys.Left
                game.PlayerShip.Position.X -= dblMOVE_SPEED
            Case Keys.Right
                game.PlayerShip.Position.X += dblMOVE_SPEED
            Case Keys.Space
                game.PlayerShip.AtemptShoot()
            Case Keys.P
                boolGamePaused = Not boolGamePaused
                pnlPauseMenu.Visible = Not pnlPauseMenu.Visible
        End Select
    End Sub

    Private Sub pnlGame_Paint(sender As Object, e As PaintEventArgs) Handles pnlGame.Paint
        ' Draw the game
        game.Draw(e.Graphics)
    End Sub


    Private Sub btnMMStory_Click(sender As Object, e As EventArgs) Handles btnMMStory.Click
        'Opens a new form explaining the story
        Dim frmForm As Form = New frmStory()
        My.Computer.Audio.Play("Sound\GUIButtonClicked.wav")
        frmForm.ShowDialog()
    End Sub
    Private Sub btnMMHow2Play_Click(sender As Object, e As EventArgs) Handles btnMMHow2Play.Click
        'Opens a new form explaning the controls and mechanics
        Dim frmForm As Form = New frmHowToPlay()
        My.Computer.Audio.Play("Sound\GUIButtonClicked.wav")
        frmForm.ShowDialog()
    End Sub

    Private Sub btnMMPlay_Click(sender As Object, e As EventArgs) Handles btnMMPlay.Click
        Dim grabTemp = pnlGame.CreateGraphics()

        boolIsRunning = True
        pnlMainMenu.Visible = False
        My.Computer.Audio.Play("Sound\GUIButtonClicked.wav")
        wmpPlayer.URL = "Sound\CS161Final_GameLoop1.wav"
        wmpPlayer.Ctlcontrols.play()

        While boolIsRunning
            Application.DoEvents()

            If (Not boolGamePaused) Then
                game.Update()
                game.Draw(grabTemp)
            End If

            Thread.Sleep(1)
        End While
    End Sub

    Private Sub btnPauseMResume_Click(sender As Object, e As EventArgs) Handles btnPauseMResume.Click
        'Resumes game
        My.Computer.Audio.Play("Sound\GUIButtonClicked.wav")
        boolGamePaused = False
        pnlPauseMenu.Visible = False
    End Sub

    Private Sub btnPauseMMainMenu_Click(sender As Object, e As EventArgs) Handles btnPauseMMainMenu.Click
        'Returns to main menu
        boolGamePaused = False
        boolIsRunning = False
        pnlPauseMenu.Visible = False
        pnlMainMenu.Visible = True
        My.Computer.Audio.Play("Sound\GUIButtonClicked.wav")
        wmpPlayer.Ctlcontrols.stop()
        wmpPlayer.URL = "Sound\CS161-FinalMenuLoop.wav"
    End Sub

    Private Sub btnPauseMClose_Click(sender As Object, e As EventArgs) Handles btnPauseMClose.Click
        'Closes program
        My.Computer.Audio.Play("Sound\GUIButtonClicked.wav")
        Close()
    End Sub

    Private Sub btnMMClose_Click(sender As Object, e As EventArgs) Handles btnMMClose.Click
        'Closes program
        My.Computer.Audio.Play("Sound\GUIButtonClicked.wav")
        Close()
    End Sub

    Private Sub btnPauseMenuHow2Play_Click(sender As Object, e As EventArgs) Handles btnPauseMenuHow2Play.Click
        'Opens a new form explaning the controls and mechanics
        Dim frmForm As Form = New frmHowToPlay()
        My.Computer.Audio.Play("Sound\GUIButtonClicked.wav")
        frmForm.ShowDialog()
    End Sub
End Class
