<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStory
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
        Me.lblStory = New System.Windows.Forms.Label()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'lblStory
        '
        Me.lblStory.Font = New System.Drawing.Font("Microsoft Sans Serif", 15!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.lblStory.Location = New System.Drawing.Point(12, 9)
        Me.lblStory.Name = "lblStory"
        Me.lblStory.Size = New System.Drawing.Size(596, 243)
        Me.lblStory.TabIndex = 2
        Me.lblStory.Text = "You angered some angry pirates. Now they hate you. Doge rocks and shoot the pirat"& _ 
    "e ships before they steal your precious booty!"
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(503, 255)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(105, 23)
        Me.btnOk.TabIndex = 3
        Me.btnOk.Text = "Ok"
        Me.btnOk.UseVisualStyleBackColor = true
        '
        'frmStory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 286)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lblStory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = false
        Me.Name = "frmStory"
        Me.Text = "Story"
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents lblStory As Label
    Friend WithEvents btnOk As Button
End Class
