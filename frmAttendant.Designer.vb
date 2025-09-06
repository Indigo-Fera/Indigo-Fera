<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAttendant
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
        Me.cboAttendants = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSelectAttendant = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cboAttendants
        '
        Me.cboAttendants.FormattingEnabled = True
        Me.cboAttendants.Location = New System.Drawing.Point(179, 24)
        Me.cboAttendants.Name = "cboAttendants"
        Me.cboAttendants.Size = New System.Drawing.Size(219, 24)
        Me.cboAttendants.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Registered Attendants: "
        '
        'btnSelectAttendant
        '
        Me.btnSelectAttendant.Location = New System.Drawing.Point(115, 96)
        Me.btnSelectAttendant.Name = "btnSelectAttendant"
        Me.btnSelectAttendant.Size = New System.Drawing.Size(192, 64)
        Me.btnSelectAttendant.TabIndex = 11
        Me.btnSelectAttendant.Text = "Select Attendants"
        Me.btnSelectAttendant.UseVisualStyleBackColor = True
        '
        'frmAttendant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(407, 178)
        Me.Controls.Add(Me.cboAttendants)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSelectAttendant)
        Me.Name = "frmAttendant"
        Me.Text = "frmAttendant"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cboAttendants As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSelectAttendant As Button
End Class
