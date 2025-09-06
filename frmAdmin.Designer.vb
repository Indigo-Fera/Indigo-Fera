<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmin
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
        Me.btnStats = New System.Windows.Forms.Button()
        Me.btnManageAttendants = New System.Windows.Forms.Button()
        Me.btnManagePilots = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnStats
        '
        Me.btnStats.Location = New System.Drawing.Point(119, 92)
        Me.btnStats.Name = "btnStats"
        Me.btnStats.Size = New System.Drawing.Size(208, 74)
        Me.btnStats.TabIndex = 6
        Me.btnStats.Text = "FlyMe2TheMoon Stats"
        Me.btnStats.UseVisualStyleBackColor = True
        '
        'btnManageAttendants
        '
        Me.btnManageAttendants.Location = New System.Drawing.Point(237, 12)
        Me.btnManageAttendants.Name = "btnManageAttendants"
        Me.btnManageAttendants.Size = New System.Drawing.Size(208, 74)
        Me.btnManageAttendants.TabIndex = 5
        Me.btnManageAttendants.Text = "Manage Attendants"
        Me.btnManageAttendants.UseVisualStyleBackColor = True
        '
        'btnManagePilots
        '
        Me.btnManagePilots.Location = New System.Drawing.Point(12, 12)
        Me.btnManagePilots.Name = "btnManagePilots"
        Me.btnManagePilots.Size = New System.Drawing.Size(208, 74)
        Me.btnManagePilots.TabIndex = 4
        Me.btnManagePilots.Text = "Manage Pilots"
        Me.btnManagePilots.UseVisualStyleBackColor = True
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 176)
        Me.Controls.Add(Me.btnStats)
        Me.Controls.Add(Me.btnManageAttendants)
        Me.Controls.Add(Me.btnManagePilots)
        Me.Name = "frmAdmin"
        Me.Text = "frmAdmin"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnStats As Button
    Friend WithEvents btnManageAttendants As Button
    Friend WithEvents btnManagePilots As Button
End Class
