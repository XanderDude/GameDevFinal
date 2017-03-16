<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFinalLab
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFinalLab))
        Me.pnlGame = New System.Windows.Forms.Panel()
        Me.pnlPauseMenu = New System.Windows.Forms.Panel()
        Me.btnPauseMClose = New System.Windows.Forms.Button()
        Me.btnPauseMMainMenu = New System.Windows.Forms.Button()
        Me.btnPauseMResume = New System.Windows.Forms.Button()
        Me.lblPauseMenu = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.pnlGameInfo = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblGameScreenTitle = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.picHeart1 = New System.Windows.Forms.Label()
        Me.picHeart3 = New System.Windows.Forms.Label()
        Me.picHeart2 = New System.Windows.Forms.Label()
        Me.pnlMainMenu = New System.Windows.Forms.Panel()
        Me.btnMMStory = New System.Windows.Forms.Button()
        Me.btnMMClose = New System.Windows.Forms.Button()
        Me.btnMMHow2Play = New System.Windows.Forms.Button()
        Me.btnMMPlay = New System.Windows.Forms.Button()
        Me.lblCredits = New System.Windows.Forms.Label()
        Me.lblMMTitle = New System.Windows.Forms.Label()
        Me.btnPauseMenuHow2Play = New System.Windows.Forms.Button()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.wmpPlayer = New AxWMPLib.AxWindowsMediaPlayer()
        Me.pnlGame.SuspendLayout()
        Me.pnlPauseMenu.SuspendLayout()
        Me.pnlGameInfo.SuspendLayout()
        Me.pnlMainMenu.SuspendLayout()
        CType(Me.wmpPlayer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pnlGame
        '
        Me.pnlGame.BackColor = System.Drawing.Color.LightSeaGreen
        Me.pnlGame.Controls.Add(Me.pnlPauseMenu)
        Me.pnlGame.Location = New System.Drawing.Point(1, 79)
        Me.pnlGame.Name = "pnlGame"
        Me.pnlGame.Size = New System.Drawing.Size(580, 580)
        Me.pnlGame.TabIndex = 0
        '
        'pnlPauseMenu
        '
        Me.pnlPauseMenu.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.pnlPauseMenu.Controls.Add(Me.btnPauseMenuHow2Play)
        Me.pnlPauseMenu.Controls.Add(Me.btnPauseMClose)
        Me.pnlPauseMenu.Controls.Add(Me.btnPauseMMainMenu)
        Me.pnlPauseMenu.Controls.Add(Me.btnPauseMResume)
        Me.pnlPauseMenu.Controls.Add(Me.lblPauseMenu)
        Me.pnlPauseMenu.Location = New System.Drawing.Point(207, 197)
        Me.pnlPauseMenu.Margin = New System.Windows.Forms.Padding(5)
        Me.pnlPauseMenu.Name = "pnlPauseMenu"
        Me.pnlPauseMenu.Size = New System.Drawing.Size(200, 237)
        Me.pnlPauseMenu.TabIndex = 1
        '
        'btnPauseMClose
        '
        Me.btnPauseMClose.BackColor = System.Drawing.Color.Khaki
        Me.btnPauseMClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPauseMClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPauseMClose.Location = New System.Drawing.Point(51, 172)
        Me.btnPauseMClose.Name = "btnPauseMClose"
        Me.btnPauseMClose.Size = New System.Drawing.Size(100, 30)
        Me.btnPauseMClose.TabIndex = 3
        Me.btnPauseMClose.Text = "Close Game"
        Me.btnPauseMClose.UseVisualStyleBackColor = False
        '
        'btnPauseMMainMenu
        '
        Me.btnPauseMMainMenu.BackColor = System.Drawing.Color.Khaki
        Me.btnPauseMMainMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPauseMMainMenu.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPauseMMainMenu.Location = New System.Drawing.Point(51, 100)
        Me.btnPauseMMainMenu.Name = "btnPauseMMainMenu"
        Me.btnPauseMMainMenu.Size = New System.Drawing.Size(100, 30)
        Me.btnPauseMMainMenu.TabIndex = 2
        Me.btnPauseMMainMenu.Text = "Main Menu"
        Me.btnPauseMMainMenu.UseVisualStyleBackColor = False
        '
        'btnPauseMResume
        '
        Me.btnPauseMResume.BackColor = System.Drawing.Color.Khaki
        Me.btnPauseMResume.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPauseMResume.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPauseMResume.Location = New System.Drawing.Point(51, 64)
        Me.btnPauseMResume.Name = "btnPauseMResume"
        Me.btnPauseMResume.Size = New System.Drawing.Size(100, 30)
        Me.btnPauseMResume.TabIndex = 1
        Me.btnPauseMResume.Text = "Resume"
        Me.btnPauseMResume.UseVisualStyleBackColor = False
        '
        'lblPauseMenu
        '
        Me.lblPauseMenu.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.lblPauseMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPauseMenu.ForeColor = System.Drawing.Color.White
        Me.lblPauseMenu.Location = New System.Drawing.Point(32, 15)
        Me.lblPauseMenu.Name = "lblPauseMenu"
        Me.lblPauseMenu.Size = New System.Drawing.Size(140, 36)
        Me.lblPauseMenu.TabIndex = 0
        Me.lblPauseMenu.Text = "Game Paused"
        Me.lblPauseMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOutput
        '
        Me.lblOutput.BackColor = System.Drawing.Color.CadetBlue
        Me.lblOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOutput.Location = New System.Drawing.Point(12, 836)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(500, 23)
        Me.lblOutput.TabIndex = 1
        Me.lblOutput.Text = "Output"
        '
        'pnlGameInfo
        '
        Me.pnlGameInfo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlGameInfo.Controls.Add(Me.Label3)
        Me.pnlGameInfo.Controls.Add(Me.lblGameScreenTitle)
        Me.pnlGameInfo.Controls.Add(Me.Label2)
        Me.pnlGameInfo.Controls.Add(Me.lblInfo)
        Me.pnlGameInfo.Controls.Add(Me.Label1)
        Me.pnlGameInfo.Controls.Add(Me.lblScore)
        Me.pnlGameInfo.Controls.Add(Me.picHeart1)
        Me.pnlGameInfo.Controls.Add(Me.picHeart3)
        Me.pnlGameInfo.Controls.Add(Me.picHeart2)
        Me.pnlGameInfo.Location = New System.Drawing.Point(1, 3)
        Me.pnlGameInfo.Name = "pnlGameInfo"
        Me.pnlGameInfo.Size = New System.Drawing.Size(580, 70)
        Me.pnlGameInfo.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label3.BackColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(555, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "6"
        '
        'lblGameScreenTitle
        '
        Me.lblGameScreenTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameScreenTitle.Location = New System.Drawing.Point(221, 18)
        Me.lblGameScreenTitle.Name = "lblGameScreenTitle"
        Me.lblGameScreenTitle.Size = New System.Drawing.Size(147, 33)
        Me.lblGameScreenTitle.TabIndex = 9
        Me.lblGameScreenTitle.Text = "Game Title"
        '
        'Label2
        '
        Me.Label2.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label2.BackColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(533, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "5"
        '
        'lblInfo
        '
        Me.lblInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfo.Location = New System.Drawing.Point(23, 18)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(81, 33)
        Me.lblInfo.TabIndex = 1
        Me.lblInfo.Text = "P: pause"
        Me.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.Label1.BackColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(511, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "4"
        '
        'lblScore
        '
        Me.lblScore.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(439, 0)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(138, 40)
        Me.lblScore.TabIndex = 5
        Me.lblScore.Text = "Score: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "0"
        Me.lblScore.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'picHeart1
        '
        Me.picHeart1.BackColor = System.Drawing.Color.Red
        Me.picHeart1.Location = New System.Drawing.Point(445, 53)
        Me.picHeart1.Name = "picHeart1"
        Me.picHeart1.Size = New System.Drawing.Size(16, 16)
        Me.picHeart1.TabIndex = 2
        Me.picHeart1.Text = "1"
        '
        'picHeart3
        '
        Me.picHeart3.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.picHeart3.BackColor = System.Drawing.Color.Red
        Me.picHeart3.Location = New System.Drawing.Point(489, 53)
        Me.picHeart3.Name = "picHeart3"
        Me.picHeart3.Size = New System.Drawing.Size(16, 16)
        Me.picHeart3.TabIndex = 4
        Me.picHeart3.Text = "3"
        '
        'picHeart2
        '
        Me.picHeart2.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.picHeart2.BackColor = System.Drawing.Color.Red
        Me.picHeart2.Location = New System.Drawing.Point(467, 53)
        Me.picHeart2.Name = "picHeart2"
        Me.picHeart2.Size = New System.Drawing.Size(16, 16)
        Me.picHeart2.TabIndex = 3
        Me.picHeart2.Text = "2"
        '
        'pnlMainMenu
        '
        Me.pnlMainMenu.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.pnlMainMenu.Controls.Add(Me.wmpPlayer)
        Me.pnlMainMenu.Controls.Add(Me.btnMMStory)
        Me.pnlMainMenu.Controls.Add(Me.btnMMClose)
        Me.pnlMainMenu.Controls.Add(Me.btnMMHow2Play)
        Me.pnlMainMenu.Controls.Add(Me.btnMMPlay)
        Me.pnlMainMenu.Controls.Add(Me.lblCredits)
        Me.pnlMainMenu.Controls.Add(Me.lblMMTitle)
        Me.pnlMainMenu.Location = New System.Drawing.Point(1, -1)
        Me.pnlMainMenu.Name = "pnlMainMenu"
        Me.pnlMainMenu.Size = New System.Drawing.Size(580, 660)
        Me.pnlMainMenu.TabIndex = 2
        '
        'btnMMStory
        '
        Me.btnMMStory.BackColor = System.Drawing.Color.Khaki
        Me.btnMMStory.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMMStory.ForeColor = System.Drawing.Color.Black
        Me.btnMMStory.Location = New System.Drawing.Point(242, 294)
        Me.btnMMStory.Name = "btnMMStory"
        Me.btnMMStory.Size = New System.Drawing.Size(100, 30)
        Me.btnMMStory.TabIndex = 5
        Me.btnMMStory.Text = "Story"
        Me.btnMMStory.UseVisualStyleBackColor = False
        '
        'btnMMClose
        '
        Me.btnMMClose.BackColor = System.Drawing.Color.Khaki
        Me.btnMMClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMMClose.ForeColor = System.Drawing.Color.Black
        Me.btnMMClose.Location = New System.Drawing.Point(242, 339)
        Me.btnMMClose.Name = "btnMMClose"
        Me.btnMMClose.Size = New System.Drawing.Size(100, 30)
        Me.btnMMClose.TabIndex = 4
        Me.btnMMClose.Text = "Close"
        Me.btnMMClose.UseVisualStyleBackColor = False
        '
        'btnMMHow2Play
        '
        Me.btnMMHow2Play.BackColor = System.Drawing.Color.Khaki
        Me.btnMMHow2Play.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMMHow2Play.ForeColor = System.Drawing.Color.Black
        Me.btnMMHow2Play.Location = New System.Drawing.Point(242, 249)
        Me.btnMMHow2Play.Name = "btnMMHow2Play"
        Me.btnMMHow2Play.Size = New System.Drawing.Size(100, 30)
        Me.btnMMHow2Play.TabIndex = 3
        Me.btnMMHow2Play.Text = "How to Play"
        Me.btnMMHow2Play.UseVisualStyleBackColor = False
        '
        'btnMMPlay
        '
        Me.btnMMPlay.BackColor = System.Drawing.Color.Khaki
        Me.btnMMPlay.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMMPlay.ForeColor = System.Drawing.Color.Black
        Me.btnMMPlay.Location = New System.Drawing.Point(242, 206)
        Me.btnMMPlay.Name = "btnMMPlay"
        Me.btnMMPlay.Size = New System.Drawing.Size(100, 30)
        Me.btnMMPlay.TabIndex = 2
        Me.btnMMPlay.Text = "Play"
        Me.btnMMPlay.UseVisualStyleBackColor = False
        '
        'lblCredits
        '
        Me.lblCredits.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCredits.Location = New System.Drawing.Point(3, 570)
        Me.lblCredits.Name = "lblCredits"
        Me.lblCredits.Size = New System.Drawing.Size(210, 102)
        Me.lblCredits.TabIndex = 1
        Me.lblCredits.Text = "Developed and Programmed by" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sarah" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Alex Easter" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Gary"
        '
        'lblMMTitle
        '
        Me.lblMMTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMMTitle.ForeColor = System.Drawing.Color.Khaki
        Me.lblMMTitle.Location = New System.Drawing.Point(184, 53)
        Me.lblMMTitle.Name = "lblMMTitle"
        Me.lblMMTitle.Size = New System.Drawing.Size(224, 69)
        Me.lblMMTitle.TabIndex = 0
        Me.lblMMTitle.Text = "Game Title"
        Me.lblMMTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnPauseMenuHow2Play
        '
        Me.btnPauseMenuHow2Play.BackColor = System.Drawing.Color.Khaki
        Me.btnPauseMenuHow2Play.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPauseMenuHow2Play.ForeColor = System.Drawing.Color.Black
        Me.btnPauseMenuHow2Play.Location = New System.Drawing.Point(51, 136)
        Me.btnPauseMenuHow2Play.Name = "btnPauseMenuHow2Play"
        Me.btnPauseMenuHow2Play.Size = New System.Drawing.Size(100, 30)
        Me.btnPauseMenuHow2Play.TabIndex = 6
        Me.btnPauseMenuHow2Play.Text = "How to Play"
        Me.btnPauseMenuHow2Play.UseVisualStyleBackColor = False
        '
        'wmpPlayer
        '
        Me.wmpPlayer.Enabled = True
        Me.wmpPlayer.Location = New System.Drawing.Point(224, 426)
        Me.wmpPlayer.Name = "wmpPlayer"
        Me.wmpPlayer.OcxState = CType(resources.GetObject("wmpPlayer.OcxState"), System.Windows.Forms.AxHost.State)
        Me.wmpPlayer.Size = New System.Drawing.Size(134, 53)
        Me.wmpPlayer.TabIndex = 5
        '
        'frmFinalLab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 661)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.pnlMainMenu)
        Me.Controls.Add(Me.pnlGame)
        Me.Controls.Add(Me.pnlGameInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.Name = "frmFinalLab"
        Me.Text = "Final Lab"
        Me.pnlGame.ResumeLayout(False)
        Me.pnlPauseMenu.ResumeLayout(False)
        Me.pnlGameInfo.ResumeLayout(False)
        Me.pnlMainMenu.ResumeLayout(False)
        CType(Me.wmpPlayer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlGame As Panel
    Friend WithEvents lblOutput As Label
    Friend WithEvents pnlPauseMenu As Panel
    Friend WithEvents btnPauseMClose As Button
    Friend WithEvents btnPauseMMainMenu As Button
    Friend WithEvents btnPauseMResume As Button
    Friend WithEvents lblPauseMenu As Label
    Friend WithEvents pnlGameInfo As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents lblGameScreenTitle As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblInfo As Label
    Friend WithEvents Label1 As Label
    Public WithEvents lblScore As Label
    Friend WithEvents picHeart1 As Label
    Friend WithEvents picHeart3 As Label
    Friend WithEvents picHeart2 As Label
    Friend WithEvents pnlMainMenu As Panel
    Friend WithEvents btnMMStory As Button
    Friend WithEvents btnMMClose As Button
    Friend WithEvents btnMMHow2Play As Button
    Friend WithEvents btnMMPlay As Button
    Friend WithEvents lblCredits As Label
    Friend WithEvents lblMMTitle As Label
    Friend WithEvents btnPauseMenuHow2Play As Button
    Friend WithEvents wmpPlayer As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
