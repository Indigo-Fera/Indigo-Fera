<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddAttendantstoFlights
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
        Me.btnAddFlight = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboAttendants = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboFlights = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(268, 124)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(218, 68)
        Me.btnExit.TabIndex = 19
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnAddFlight
        '
        Me.btnAddFlight.Location = New System.Drawing.Point(14, 124)
        Me.btnAddFlight.Name = "btnAddFlight"
        Me.btnAddFlight.Size = New System.Drawing.Size(218, 68)
        Me.btnAddFlight.TabIndex = 18
        Me.btnAddFlight.Text = "Add Flight"
        Me.btnAddFlight.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(84, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 17)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Attendants: "
        '
        'cboAttendants
        '
        Me.cboAttendants.FormattingEnabled = True
        Me.cboAttendants.Location = New System.Drawing.Point(195, 12)
        Me.cboAttendants.Name = "cboAttendants"
        Me.cboAttendants.Size = New System.Drawing.Size(230, 24)
        Me.cboAttendants.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(84, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Flights:"
        '
        'cboFlights
        '
        Me.cboFlights.FormattingEnabled = True
        Me.cboFlights.Location = New System.Drawing.Point(195, 64)
        Me.cboFlights.Name = "cboFlights"
        Me.cboFlights.Size = New System.Drawing.Size(230, 24)
        Me.cboFlights.TabIndex = 14
        '
        'frmAddAttendantstoFlights
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 201)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAddFlight)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboAttendants)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboFlights)
        Me.Name = "frmAddAttendantstoFlights"
        Me.Text = "frmAddAttendantstoFlights"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnAddFlight As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cboAttendants As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboFlights As ComboBox
End Class
