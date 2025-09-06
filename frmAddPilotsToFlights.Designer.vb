<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddPilotsToFlights
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
        Me.cboPilots = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboFlights = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(267, 124)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(218, 68)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnAddFlight
        '
        Me.btnAddFlight.Location = New System.Drawing.Point(13, 124)
        Me.btnAddFlight.Name = "btnAddFlight"
        Me.btnAddFlight.Size = New System.Drawing.Size(218, 68)
        Me.btnAddFlight.TabIndex = 12
        Me.btnAddFlight.Text = "Add Flight"
        Me.btnAddFlight.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(83, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 17)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Pilots:"
        '
        'cboPilots
        '
        Me.cboPilots.FormattingEnabled = True
        Me.cboPilots.Location = New System.Drawing.Point(194, 12)
        Me.cboPilots.Name = "cboPilots"
        Me.cboPilots.Size = New System.Drawing.Size(230, 24)
        Me.cboPilots.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(83, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Flights:"
        '
        'cboFlights
        '
        Me.cboFlights.FormattingEnabled = True
        Me.cboFlights.Location = New System.Drawing.Point(194, 64)
        Me.cboFlights.Name = "cboFlights"
        Me.cboFlights.Size = New System.Drawing.Size(230, 24)
        Me.cboFlights.TabIndex = 8
        '
        'frmAddPilotsToFlights
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(491, 201)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAddFlight)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cboPilots)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cboFlights)
        Me.Name = "frmAddPilotsToFlights"
        Me.Text = "frmAddPilotsToFlights"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnAddFlight As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents cboPilots As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cboFlights As ComboBox
End Class
