<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuestionScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QuestionScreen))
        Me.lblQuestion = New System.Windows.Forms.Label()
        Me.lblGameScore = New System.Windows.Forms.Label()
        Me.btnEndGame = New System.Windows.Forms.Button()
        Me.btnAnswer1 = New System.Windows.Forms.Button()
        Me.btnAnswer2 = New System.Windows.Forms.Button()
        Me.btnAnswer4 = New System.Windows.Forms.Button()
        Me.btnAnswer3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblQuestion
        '
        Me.lblQuestion.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblQuestion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuestion.Location = New System.Drawing.Point(0, 0)
        Me.lblQuestion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblQuestion.Name = "lblQuestion"
        Me.lblQuestion.Size = New System.Drawing.Size(582, 91)
        Me.lblQuestion.TabIndex = 2
        Me.lblQuestion.Text = "***NO.*** ***QUESTION***"
        Me.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblGameScore
        '
        Me.lblGameScore.AutoSize = True
        Me.lblGameScore.Location = New System.Drawing.Point(440, 336)
        Me.lblGameScore.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGameScore.Name = "lblGameScore"
        Me.lblGameScore.Size = New System.Drawing.Size(131, 17)
        Me.lblGameScore.TabIndex = 5
        Me.lblGameScore.Text = "Score: ***SCORE***"
        '
        'btnEndGame
        '
        Me.btnEndGame.Location = New System.Drawing.Point(11, 327)
        Me.btnEndGame.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEndGame.Name = "btnEndGame"
        Me.btnEndGame.Size = New System.Drawing.Size(95, 35)
        Me.btnEndGame.TabIndex = 6
        Me.btnEndGame.Text = "End Game"
        Me.btnEndGame.UseVisualStyleBackColor = True
        '
        'btnAnswer1
        '
        Me.btnAnswer1.Location = New System.Drawing.Point(11, 93)
        Me.btnAnswer1.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAnswer1.Name = "btnAnswer1"
        Me.btnAnswer1.Size = New System.Drawing.Size(276, 102)
        Me.btnAnswer1.TabIndex = 6
        Me.btnAnswer1.Text = "***ANSWER 1***"
        Me.btnAnswer1.UseVisualStyleBackColor = True
        '
        'btnAnswer2
        '
        Me.btnAnswer2.Location = New System.Drawing.Point(295, 93)
        Me.btnAnswer2.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAnswer2.Name = "btnAnswer2"
        Me.btnAnswer2.Size = New System.Drawing.Size(276, 102)
        Me.btnAnswer2.TabIndex = 6
        Me.btnAnswer2.Text = "***ANSWER 2***"
        Me.btnAnswer2.UseVisualStyleBackColor = True
        '
        'btnAnswer4
        '
        Me.btnAnswer4.Location = New System.Drawing.Point(295, 203)
        Me.btnAnswer4.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAnswer4.Name = "btnAnswer4"
        Me.btnAnswer4.Size = New System.Drawing.Size(276, 102)
        Me.btnAnswer4.TabIndex = 6
        Me.btnAnswer4.Text = "***ANSWER 4***"
        Me.btnAnswer4.UseVisualStyleBackColor = True
        '
        'btnAnswer3
        '
        Me.btnAnswer3.Location = New System.Drawing.Point(11, 203)
        Me.btnAnswer3.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAnswer3.Name = "btnAnswer3"
        Me.btnAnswer3.Size = New System.Drawing.Size(276, 102)
        Me.btnAnswer3.TabIndex = 6
        Me.btnAnswer3.Text = "***ANSWER 3***"
        Me.btnAnswer3.UseVisualStyleBackColor = True
        '
        'QuestionScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(582, 371)
        Me.Controls.Add(Me.btnAnswer3)
        Me.Controls.Add(Me.btnAnswer4)
        Me.Controls.Add(Me.btnAnswer2)
        Me.Controls.Add(Me.btnAnswer1)
        Me.Controls.Add(Me.btnEndGame)
        Me.Controls.Add(Me.lblGameScore)
        Me.Controls.Add(Me.lblQuestion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "QuestionScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Exam Buff or Exam Bluff"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblQuestion As Label
    Friend WithEvents lblGameScore As Label
    Friend WithEvents btnEndGame As Button
    Friend WithEvents btnAnswer1 As Button
    Friend WithEvents btnAnswer2 As Button
    Friend WithEvents btnAnswer4 As Button
    Friend WithEvents btnAnswer3 As Button
End Class
