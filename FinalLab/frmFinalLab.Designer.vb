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
        Me.pnlGame = New System.Windows.Forms.Panel()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuMenu = New System.Windows.Forms.MenuStrip()
        Me.mnuStart = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStory = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMenu.SuspendLayout
        Me.SuspendLayout
        '
        'pnlGame
        '
        Me.pnlGame.Location = New System.Drawing.Point(12, 33)
        Me.pnlGame.Name = "pnlGame"
        Me.pnlGame.Size = New System.Drawing.Size(500, 800)
        Me.pnlGame.TabIndex = 0
        '
        'lblOutput
        '
        Me.lblOutput.BackColor = System.Drawing.Color.CadetBlue
        Me.lblOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblOutput.Location = New System.Drawing.Point(12, 836)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(500, 23)
        Me.lblOutput.TabIndex = 1
        Me.lblOutput.Text = "Output"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 24)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(522, 24)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuMenu
        '
        Me.mnuMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuStart, Me.mnuStory})
        Me.mnuMenu.Location = New System.Drawing.Point(0, 0)
        Me.mnuMenu.Name = "mnuMenu"
        Me.mnuMenu.Size = New System.Drawing.Size(522, 24)
        Me.mnuMenu.TabIndex = 3
        Me.mnuMenu.Text = "MenuStrip"
        '
        'mnuStart
        '
        Me.mnuStart.Name = "mnuStart"
        Me.mnuStart.Size = New System.Drawing.Size(43, 20)
        Me.mnuStart.Text = "Start"
        '
        'mnuStory
        '
        Me.mnuStory.Name = "mnuStory"
        Me.mnuStory.Size = New System.Drawing.Size(46, 20)
        Me.mnuStory.Text = "Story"
        '
        'frmFinalLab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 865)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.pnlGame)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.mnuMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = true
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = false
        Me.Name = "frmFinalLab"
        Me.Text = "Final Lab"
        Me.mnuMenu.ResumeLayout(false)
        Me.mnuMenu.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents pnlGame As Panel
    Friend WithEvents lblOutput As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuMenu As MenuStrip
    Friend WithEvents mnuStory As ToolStripMenuItem
    Friend WithEvents mnuStart As ToolStripMenuItem
End Class
