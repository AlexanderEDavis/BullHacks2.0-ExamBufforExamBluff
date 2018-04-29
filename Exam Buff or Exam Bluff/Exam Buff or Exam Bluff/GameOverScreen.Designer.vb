<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameOverScreen
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
        Me.lblGameOver = New System.Windows.Forms.Label()
        Me.lblFinalScore = New System.Windows.Forms.Label()
        Me.lblPlayAgain = New System.Windows.Forms.Label()
        Me.btnYes = New System.Windows.Forms.Button()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblGameOver
        '
        Me.lblGameOver.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblGameOver.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.lblGameOver.Location = New System.Drawing.Point(0, 0)
        Me.lblGameOver.Name = "lblGameOver"
        Me.lblGameOver.Size = New System.Drawing.Size(465, 52)
        Me.lblGameOver.TabIndex = 0
        Me.lblGameOver.Text = "Game Over"
        Me.lblGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFinalScore
        '
        Me.lblFinalScore.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblFinalScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.lblFinalScore.Location = New System.Drawing.Point(0, 52)
        Me.lblFinalScore.Name = "lblFinalScore"
        Me.lblFinalScore.Size = New System.Drawing.Size(465, 52)
        Me.lblFinalScore.TabIndex = 0
        Me.lblFinalScore.Text = "You scored ***SCORE*** out of ***TOTAL***"
        Me.lblFinalScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblPlayAgain
        '
        Me.lblPlayAgain.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPlayAgain.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!)
        Me.lblPlayAgain.Location = New System.Drawing.Point(0, 104)
        Me.lblPlayAgain.Name = "lblPlayAgain"
        Me.lblPlayAgain.Size = New System.Drawing.Size(465, 36)
        Me.lblPlayAgain.TabIndex = 1
        Me.lblPlayAgain.Text = "Would you like to play again?"
        Me.lblPlayAgain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnYes
        '
        Me.btnYes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnYes.Location = New System.Drawing.Point(100, 160)
        Me.btnYes.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(122, 42)
        Me.btnYes.TabIndex = 2
        Me.btnYes.Text = "Yes"
        '
        'btnNo
        '
        Me.btnNo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnNo.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnNo.Location = New System.Drawing.Point(234, 160)
        Me.btnNo.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnNo.Name = "btnNo"
        Me.btnNo.Size = New System.Drawing.Size(122, 42)
        Me.btnNo.TabIndex = 3
        Me.btnNo.Text = "No"
        '
        'GameOverScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 216)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.lblPlayAgain)
        Me.Controls.Add(Me.lblFinalScore)
        Me.Controls.Add(Me.lblGameOver)
        Me.Name = "GameOverScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Game Over"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblGameOver As Label
    Friend WithEvents lblFinalScore As Label
    Friend WithEvents lblPlayAgain As Label
    Friend WithEvents btnYes As Button
    Friend WithEvents btnNo As Button
End Class
