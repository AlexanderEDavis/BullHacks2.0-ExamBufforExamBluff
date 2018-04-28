<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WelcomeScreen
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblNamePrompt = New System.Windows.Forms.Label()
        Me.txtNameEntry = New System.Windows.Forms.TextBox()
        Me.btnNameConfirm = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(139, 73)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(376, 36)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Exam Buff... or Exam Bluff?"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblNamePrompt
        '
        Me.lblNamePrompt.AutoSize = True
        Me.lblNamePrompt.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNamePrompt.Location = New System.Drawing.Point(158, 177)
        Me.lblNamePrompt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNamePrompt.Name = "lblNamePrompt"
        Me.lblNamePrompt.Size = New System.Drawing.Size(327, 36)
        Me.lblNamePrompt.TabIndex = 1
        Me.lblNamePrompt.Text = "Please enter your name"
        Me.lblNamePrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNameEntry
        '
        Me.txtNameEntry.Location = New System.Drawing.Point(237, 243)
        Me.txtNameEntry.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNameEntry.Name = "txtNameEntry"
        Me.txtNameEntry.Size = New System.Drawing.Size(154, 22)
        Me.txtNameEntry.TabIndex = 2
        '
        'btnNameConfirm
        '
        Me.btnNameConfirm.Location = New System.Drawing.Point(264, 305)
        Me.btnNameConfirm.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnNameConfirm.Name = "btnNameConfirm"
        Me.btnNameConfirm.Size = New System.Drawing.Size(104, 41)
        Me.btnNameConfirm.TabIndex = 3
        Me.btnNameConfirm.Text = "OK"
        Me.btnNameConfirm.UseVisualStyleBackColor = True
        '
        'WelcomeScreen
        '
        Me.AcceptButton = Me.btnNameConfirm
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 430)
        Me.Controls.Add(Me.btnNameConfirm)
        Me.Controls.Add(Me.txtNameEntry)
        Me.Controls.Add(Me.lblNamePrompt)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "WelcomeScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Exam Buff... or Exam Bluff?"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblNamePrompt As Label
    Friend WithEvents txtNameEntry As TextBox
    Friend WithEvents btnNameConfirm As Button
End Class
