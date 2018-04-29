<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GameEndScreen
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
        Me.btnYes = New System.Windows.Forms.Button()
        Me.btnNo = New System.Windows.Forms.Button()
        Me.lblEndPlayAgain = New System.Windows.Forms.Label()
        Me.lblFinalScore = New System.Windows.Forms.Label()
        Me.lblAllQuestionsAnswered = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnYes
        '
        Me.btnYes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnYes.Location = New System.Drawing.Point(100, 160)
        Me.btnYes.Margin = New System.Windows.Forms.Padding(6, 6, 6, 6)
        Me.btnYes.Name = "btnYes"
        Me.btnYes.Size = New System.Drawing.Size(122, 42)
        Me.btnYes.TabIndex = 7
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
        Me.btnNo.TabIndex = 8
        Me.btnNo.Text = "No"
        '
        'lblEndPlayAgain
        '
        Me.lblEndPlayAgain.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblEndPlayAgain.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEndPlayAgain.Location = New System.Drawing.Point(0, 104)
        Me.lblEndPlayAgain.Name = "lblEndPlayAgain"
        Me.lblEndPlayAgain.Size = New System.Drawing.Size(465, 36)
        Me.lblEndPlayAgain.TabIndex = 6
        Me.lblEndPlayAgain.Text = "Would you like to play again?"
        Me.lblEndPlayAgain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFinalScore
        '
        Me.lblFinalScore.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblFinalScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalScore.Location = New System.Drawing.Point(0, 52)
        Me.lblFinalScore.Name = "lblFinalScore"
        Me.lblFinalScore.Size = New System.Drawing.Size(465, 52)
        Me.lblFinalScore.TabIndex = 4
        Me.lblFinalScore.Text = "You scored ***SCORE*** out of ***TOTAL***"
        Me.lblFinalScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAllQuestionsAnswered
        '
        Me.lblAllQuestionsAnswered.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblAllQuestionsAnswered.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAllQuestionsAnswered.Location = New System.Drawing.Point(0, 0)
        Me.lblAllQuestionsAnswered.Name = "lblAllQuestionsAnswered"
        Me.lblAllQuestionsAnswered.Size = New System.Drawing.Size(465, 52)
        Me.lblAllQuestionsAnswered.TabIndex = 5
        Me.lblAllQuestionsAnswered.Text = "You've answered all the questions"
        Me.lblAllQuestionsAnswered.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GameEndScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 24.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 216)
        Me.Controls.Add(Me.btnYes)
        Me.Controls.Add(Me.btnNo)
        Me.Controls.Add(Me.lblEndPlayAgain)
        Me.Controls.Add(Me.lblFinalScore)
        Me.Controls.Add(Me.lblAllQuestionsAnswered)
        Me.Name = "GameEndScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Game Over"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnYes As Button
    Friend WithEvents btnNo As Button
    Friend WithEvents lblEndPlayAgain As Label
    Friend WithEvents lblFinalScore As Label
    Friend WithEvents lblAllQuestionsAnswered As Label
End Class
