<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuitDialog
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(QuitDialog))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.btnEndGame = New System.Windows.Forms.Button()
        Me.btnResume = New System.Windows.Forms.Button()
        Me.lblQuitCheck = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.btnEndGame, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btnResume, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(73, 136)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(195, 36)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'btnEndGame
        '
        Me.btnEndGame.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnEndGame.Location = New System.Drawing.Point(4, 4)
        Me.btnEndGame.Margin = New System.Windows.Forms.Padding(4)
        Me.btnEndGame.Name = "btnEndGame"
        Me.btnEndGame.Size = New System.Drawing.Size(89, 28)
        Me.btnEndGame.TabIndex = 0
        Me.btnEndGame.Text = "Yes"
        '
        'btnResume
        '
        Me.btnResume.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnResume.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnResume.Location = New System.Drawing.Point(101, 4)
        Me.btnResume.Margin = New System.Windows.Forms.Padding(4)
        Me.btnResume.Name = "btnResume"
        Me.btnResume.Size = New System.Drawing.Size(89, 28)
        Me.btnResume.TabIndex = 1
        Me.btnResume.Text = "No"
        '
        'lblQuitCheck
        '
        Me.lblQuitCheck.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblQuitCheck.Location = New System.Drawing.Point(0, 0)
        Me.lblQuitCheck.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblQuitCheck.Name = "lblQuitCheck"
        Me.lblQuitCheck.Size = New System.Drawing.Size(284, 136)
        Me.lblQuitCheck.TabIndex = 1
        Me.lblQuitCheck.Text = "Are you sure you wish to end the game?"
        Me.lblQuitCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'QuitDialog
        '
        Me.AcceptButton = Me.btnEndGame
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnResume
        Me.ClientSize = New System.Drawing.Size(284, 187)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.lblQuitCheck)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "QuitDialog"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Are You Sure?"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents btnEndGame As System.Windows.Forms.Button
    Friend WithEvents btnResume As System.Windows.Forms.Button
    Friend WithEvents lblQuitCheck As Label
End Class
