<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddFlight
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cboFutureFlights = New System.Windows.Forms.ComboBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnAddFlight = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cboFutureFlights)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(432, 98)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bookable Flights"
        '
        'cboFutureFlights
        '
        Me.cboFutureFlights.FormattingEnabled = True
        Me.cboFutureFlights.Location = New System.Drawing.Point(18, 38)
        Me.cboFutureFlights.Name = "cboFutureFlights"
        Me.cboFutureFlights.Size = New System.Drawing.Size(324, 24)
        Me.cboFutureFlights.TabIndex = 0
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(257, 117)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(187, 57)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnAddFlight
        '
        Me.btnAddFlight.Location = New System.Drawing.Point(10, 117)
        Me.btnAddFlight.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddFlight.Name = "btnAddFlight"
        Me.btnAddFlight.Size = New System.Drawing.Size(188, 57)
        Me.btnAddFlight.TabIndex = 12
        Me.btnAddFlight.Text = "Add Flight"
        Me.btnAddFlight.UseVisualStyleBackColor = True
        '
        'frmAddFlight
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 187)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAddFlight)
        Me.Name = "frmAddFlight"
        Me.Text = "frmAddFlight"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cboFutureFlights As ComboBox
    Friend WithEvents btnExit As Button
    Friend WithEvents btnAddFlight As Button
End Class
