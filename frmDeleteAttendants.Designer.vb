<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeleteAttendants
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
        Me.btnDeleteAttendant = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboAttendants = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(277, 84)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(218, 68)
        Me.btnExit.TabIndex = 11
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnDeleteAttendant
        '
        Me.btnDeleteAttendant.Location = New System.Drawing.Point(23, 84)
        Me.btnDeleteAttendant.Name = "btnDeleteAttendant"
        Me.btnDeleteAttendant.Size = New System.Drawing.Size(218, 68)
        Me.btnDeleteAttendant.TabIndex = 10
        Me.btnDeleteAttendant.Text = "Delete Attendant"
        Me.btnDeleteAttendant.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Attendant To Delete:"
        '
        'cboAttendants
        '
        Me.cboAttendants.FormattingEnabled = True
        Me.cboAttendants.Location = New System.Drawing.Point(165, 17)
        Me.cboAttendants.Name = "cboAttendants"
        Me.cboAttendants.Size = New System.Drawing.Size(230, 24)
        Me.cboAttendants.TabIndex = 8
        '
        'frmDeleteAttendants
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 174)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDeleteAttendant)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboAttendants)
        Me.Name = "frmDeleteAttendants"
        Me.Text = "frmDeleteAttendants"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnDeleteAttendant As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents cboAttendants As ComboBox
End Class
