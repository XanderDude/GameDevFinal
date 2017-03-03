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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.lblStory = New System.Windows.Forms.Label()
        Me.SuspendLayout
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(500, 800)
        Me.Panel1.TabIndex = 0
        '
        'lblInfo
        '
        Me.lblInfo.Location = New System.Drawing.Point(518, 100)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(100, 23)
        Me.lblInfo.TabIndex = 1
        Me.lblInfo.Text = "Info"
        '
        'lblOutput
        '
        Me.lblOutput.BackColor = System.Drawing.Color.CadetBlue
        Me.lblOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblOutput.Location = New System.Drawing.Point(9, 826)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(503, 23)
        Me.lblOutput.TabIndex = 1
        Me.lblOutput.Text = "Output"
        '
        'lblStory
        '
        Me.lblStory.Location = New System.Drawing.Point(518, 12)
        Me.lblStory.Name = "lblStory"
        Me.lblStory.Size = New System.Drawing.Size(110, 88)
        Me.lblStory.TabIndex = 1
        Me.lblStory.Text = "Story"
        '
        'frmFinalLab
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 858)
        Me.Controls.Add(Me.lblStory)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmFinalLab"
        Me.Text = "Final Lab"
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblInfo As Label
    Friend WithEvents lblOutput As Label
    Friend WithEvents lblStory As Label
End Class
