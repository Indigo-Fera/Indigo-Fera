<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManageAttendants
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
        Me.btnAddAttendantstoFlights = New System.Windows.Forms.Button()
        Me.btnDeleteAttendants = New System.Windows.Forms.Button()
        Me.btnAddAttendants = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAddAttendantstoFlights
        '
        Me.btnAddAttendantstoFlights.Location = New System.Drawing.Point(196, 12)
        Me.btnAddAttendantstoFlights.Name = "btnAddAttendantstoFlights"
        Me.btnAddAttendantstoFlights.Size = New System.Drawing.Size(161, 77)
        Me.btnAddAttendantstoFlights.TabIndex = 8
        Me.btnAddAttendantstoFlights.Text = "Add Attendants To Flights"
        Me.btnAddAttendantstoFlights.UseVisualStyleBackColor = True
        '
        'btnDeleteAttendants
        '
        Me.btnDeleteAttendants.Location = New System.Drawing.Point(12, 12)
        Me.btnDeleteAttendants.Name = "btnDeleteAttendants"
        Me.btnDeleteAttendants.Size = New System.Drawing.Size(161, 77)
        Me.btnDeleteAttendants.TabIndex = 7
        Me.btnDeleteAttendants.Text = "Delete Attendants"
        Me.btnDeleteAttendants.UseVisualStyleBackColor = True
        '
        'btnAddAttendants
        '
        Me.btnAddAttendants.Location = New System.Drawing.Point(107, 108)
        Me.btnAddAttendants.Name = "btnAddAttendants"
        Me.btnAddAttendants.Size = New System.Drawing.Size(161, 77)
        Me.btnAddAttendants.TabIndex = 6
        Me.btnAddAttendants.Text = "Add Attendants"
        Me.btnAddAttendants.UseVisualStyleBackColor = True
        '
        'frmManageAttendants
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 196)
        Me.Controls.Add(Me.btnAddAttendantstoFlights)
        Me.Controls.Add(Me.btnDeleteAttendants)
        Me.Controls.Add(Me.btnAddAttendants)
        Me.Name = "frmManageAttendants"
        Me.Text = "frmManageAttendants"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAddAttendantstoFlights As Button
    Friend WithEvents btnDeleteAttendants As Button
    Friend WithEvents btnAddAttendants As Button
End Class
