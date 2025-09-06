<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeletePilots
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
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnDeletePilot = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboPilots = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(274, 88)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(218, 68)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnDeletePilot
        '
        Me.btnDeletePilot.Location = New System.Drawing.Point(20, 88)
        Me.btnDeletePilot.Name = "btnDeletePilot"
        Me.btnDeletePilot.Size = New System.Drawing.Size(218, 68)
        Me.btnDeletePilot.TabIndex = 6
        Me.btnDeletePilot.Text = "Delete Pilot"
        Me.btnDeletePilot.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 17)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Pilot To Delete:"
        '
        'cboPilots
        '
        Me.cboPilots.FormattingEnabled = True
        Me.cboPilots.Location = New System.Drawing.Point(162, 21)
        Me.cboPilots.Name = "cboPilots"
        Me.cboPilots.Size = New System.Drawing.Size(230, 24)
        Me.cboPilots.TabIndex = 4
        '
        'frmDeletePilots
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 178)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDeletePilot)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboPilots)
        Me.Name = "frmDeletePilots"
        Me.Text = "frmDeletePilots"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnDeletePilot As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cboPilots As ComboBox
End Class
