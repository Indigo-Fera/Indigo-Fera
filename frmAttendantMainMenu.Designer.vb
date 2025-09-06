<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAttendantMainMenu
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
        Me.btnFutureFlights = New System.Windows.Forms.Button()
        Me.btnPastFlights = New System.Windows.Forms.Button()
        Me.btnUpdateAttendant = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnFutureFlights
        '
        Me.btnFutureFlights.Location = New System.Drawing.Point(156, 140)
        Me.btnFutureFlights.Name = "btnFutureFlights"
        Me.btnFutureFlights.Size = New System.Drawing.Size(256, 80)
        Me.btnFutureFlights.TabIndex = 8
        Me.btnFutureFlights.Text = "Future Flights"
        Me.btnFutureFlights.UseVisualStyleBackColor = True
        '
        'btnPastFlights
        '
        Me.btnPastFlights.Location = New System.Drawing.Point(306, 12)
        Me.btnPastFlights.Name = "btnPastFlights"
        Me.btnPastFlights.Size = New System.Drawing.Size(256, 80)
        Me.btnPastFlights.TabIndex = 7
        Me.btnPastFlights.Text = "Past Flights"
        Me.btnPastFlights.UseVisualStyleBackColor = True
        '
        'btnUpdateAttendant
        '
        Me.btnUpdateAttendant.Location = New System.Drawing.Point(12, 12)
        Me.btnUpdateAttendant.Name = "btnUpdateAttendant"
        Me.btnUpdateAttendant.Size = New System.Drawing.Size(256, 80)
        Me.btnUpdateAttendant.TabIndex = 6
        Me.btnUpdateAttendant.Text = "Update Attendants"
        Me.btnUpdateAttendant.UseVisualStyleBackColor = True
        '
        'frmAttendantMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 230)
        Me.Controls.Add(Me.btnFutureFlights)
        Me.Controls.Add(Me.btnPastFlights)
        Me.Controls.Add(Me.btnUpdateAttendant)
        Me.Name = "frmAttendantMainMenu"
        Me.Text = "frmAttendantMainMenu"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnFutureFlights As Button
    Friend WithEvents btnPastFlights As Button
    Friend WithEvents btnUpdateAttendant As Button
End Class
