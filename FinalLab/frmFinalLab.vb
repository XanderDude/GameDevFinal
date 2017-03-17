Option Strict On
Option Explicit On

Imports System.Threading

Public Class frmFinalLab
    private Dim rndRandom As Random
    Private Dim goGameObjects As List(Of IGameObject)
    private Dim psPlayerShip As PlayerShip
    private Dim intMoney as Integer
    private dim intScore as Integer
    Private Dim bgBackGround as Background
    private Dim dtNextBolderSpawn As Date
    private Dim grabBuffer As Graphics

    ' Note: Pause and Running is different.
    ' Paused is the tracker for when the user presses P or pauses the game some other way
    ' Running is the tracker for between the user starts and end the game
    Dim boolIsGamePaused As Boolean
    Dim boolIsGameRunning As Boolean

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        goGameObjects = New List(Of IGameObject)
        bgBackGround = new Background(me)

        dtNextBolderSpawn = Date.MinValue
        rndRandom = New Random()
        boolIsGamePaused = False
        boolIsGameRunning = False
        intScore = 0
    End Sub
    
    Public ReadOnly Property GameObjects As List(Of IGameObject)
        Get
            Return goGameObjects
        End Get
    End Property
    Public Property PlayerShip As PlayerShip
        Get
            Return psPlayerShip
        End Get
        Private Set
            psPlayerShip = PlayerShip
        End Set
    End Property
    Public Property Money As Integer
        get
            return intMoney
        End Get
        Set
            intMoney = value
        End Set
    End Property
    Public Property Score as Integer
        set
            intScore = value
            if intScore < 0
                intScore = 0
            End If
        End Set
        Get
            return intScore
        End Get
    End Property
    Friend ReadOnly Property Random As Random
        Get
            Return rndRandom
        End Get
    End Property

    Public sub StartGame()
        ' Stop the game first so we don't run into any bugs
        ' (So runing start twice would just reset the game)
        EndGame()
        
        ' Set the clickable menu to disabled
        mnuStart.Enabled = false

        ' Unpause the game
        boolIsGamePaused = false

        ' Spawn the player ship
        psPlayerShip = New PlayerShip(Me)
        Spawn(psPlayerShip)

        ' Set this to true
        boolIsGameRunning = true

        ' Set the output text to this
        OutputMessage("Game Started.")
    End sub
    Public sub EndGame()
        ' Set game started to false
        boolIsGameRunning = false

        ' Remove player ship
        psPlayerShip = Nothing

        ' Remove all game objects
        for each goGameObject as GameObject in goGameObjects
            goGameObject.Delete()
        Next
        
        ' Set the clickable menu to enabled
        mnuStart.Enabled = true

        ' Clear the output text
        OutputMessage("")
    end Sub
    Public sub PauseGame()
        If boolIsGameRunning 
            boolIsGamePaused = true
        End If
    End sub
    Public sub UnpauseGame()
        If boolIsGameRunning
            boolIsGamePaused = false
        End If
    End sub

    Public sub LoopGame
        ' Get the graphics.. This is tempary until we fix the flickering
        Dim grabTemp = pnlGame.CreateGraphics()
        
        While boolIsGameRunning
            ' Do form events
            Application.DoEvents()
        
            ' Run game if its not paused
            If (Not boolIsGamePaused) Then
            Update()
            Draw(grabTemp)
            End If

            ' Sleep for 1 ms
            Thread.Sleep(1)
        End While
    End sub

    Public Overloads Sub Update()
        ' Update other game objects
        for i as Integer = 0 to goGameObjects.Count() - 1
            Dim goGameObject as IGameObject = goGameObjects(i)

            If Not goGameObject.DeleteMe Then
                goGameObject.Update()
            End If
        Next
        
        ' Remove game objects
        goGameObjects.RemoveAll(Function(goGameObject As IGameObject) goGameObject.DeleteMe)

        ' Spawn Bolders
        Dim intMinBolderSpawnTime As Integer = 200
        Dim intMaxBolderSpawnTime As Integer = 2000

        If (dtNextBolderSpawn < Now()) Then
            Dim intSpawnX = rndRandom.Next(0, 500)

            Spawn(New Bolder(Me, New Vector2D(intSpawnX, 0)))

            Dim intBolderSpawnTimeInMiliseconds = rndRandom.Next(intMaxBolderSpawnTime, intMaxBolderSpawnTime)
            dtNextBolderSpawn = DateTime.Now().AddMilliseconds(intBolderSpawnTimeInMiliseconds)
        End If

        ' Update the background
        bgBackGround.Update()
    End Sub

    Public Sub Draw(grabBuffer As Graphics)
        Try
            ' Clear the graphics
            grabBuffer.Clear(Color.White)

            ' Draw the background
            bgBackGround.Draw(grabBuffer)
            
            ' Draw the game objects
            For Each gameObject As GameObject In goGameObjects
                gameObject.Draw(grabBuffer)
            Next
        Catch ex As Exception
        End Try
    End Sub

    Public Sub Spawn(goSpawnObject As IGameObject)
        gameObjects.Add(goSpawnObject)
    End Sub
    Public sub OutputMessage(strMessage As string)
        lblOutput.Text = strMessage
    End sub
    
    Private Sub frmFinalLab_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grabBuffer = pnlGame.CreateGraphics()
    End Sub

    Private Sub frmFinalLab_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Const dblSHIP_MOVE_SPEED As Double = 5
        
        ' Do player movement stuff
        If Not boolIsGamePaused and boolIsGameRunning
            Select Case e.KeyData
                Case Keys.Up OR Keys.W
                    PlayerShip.Position.Y -= dblSHIP_MOVE_SPEED
                Case Keys.Down OR keys.S
                    PlayerShip.Position.Y += dblSHIP_MOVE_SPEED
                Case Keys.Left OR keys.A
                    PlayerShip.Position.X -= dblSHIP_MOVE_SPEED
                Case Keys.Right OR Keys.D
                    PlayerShip.Position.X += dblSHIP_MOVE_SPEED
                Case Keys.Space Or Keys.Enter
                    PlayerShip.AtemptShoot()
                Case Keys.P
                    boolIsGamePaused = Not boolIsGamePaused
            End Select

            ' Make sure the player doesn't reach the bounderies
            If PlayerShip.Position.X < 0 Then
                PlayerShip.Position.X = 0
            End If
            If PlayerShip.Position.X > pnlGame.Width - PlayerShip.Size.X Then
                PlayerShip.Position.X = pnlGame.Width - PlayerShip.Size.X
            End If
            If PlayerShip.Position.Y < 0 Then
                PlayerShip.Position.Y = 0
            End If
            If PlayerShip.Position.Y > pnlGame.Height - PlayerShip.Size.Y Then
                PlayerShip.Position.Y = pnlGame.Height - PlayerShip.Size.Y
            End If
        End If
    End Sub

    Private Sub mnuStory_Click(sender As Object, e As EventArgs) Handles mnuStory.Click
        ' Create story form
        Dim frmForm As Form = New frmStory()

        ' Show story form dialog
        frmForm.ShowDialog()
    End Sub

    Private Sub mnuStart_Click(sender As Object, e As EventArgs) Handles mnuStart.Click
        StartGame()
        LoopGame()
    End Sub
End Class
