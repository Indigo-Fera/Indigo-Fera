<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddPilots
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
        Me.btnAddPilot = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtmDateofCertification = New System.Windows.Forms.DateTimePicker()
        Me.dtmDateofTermination = New System.Windows.Forms.DateTimePicker()
        Me.dtmDateofHire = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboPilotRole = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPilotID = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(300, 404)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(139, 57)
        Me.btnExit.TabIndex = 20
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnAddPilot
        '
        Me.btnAddPilot.Location = New System.Drawing.Point(95, 404)
        Me.btnAddPilot.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddPilot.Name = "btnAddPilot"
        Me.btnAddPilot.Size = New System.Drawing.Size(139, 57)
        Me.btnAddPilot.TabIndex = 19
        Me.btnAddPilot.Text = "Add Pilot"
        Me.btnAddPilot.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtmDateofCertification)
        Me.GroupBox1.Controls.Add(Me.dtmDateofTermination)
        Me.GroupBox1.Controls.Add(Me.dtmDateofHire)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cboPilotRole)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtPilotID)
        Me.GroupBox1.Controls.Add(Me.txtLastName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtFirstName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(538, 395)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'dtmDateofCertification
        '
        Me.dtmDateofCertification.Location = New System.Drawing.Point(172, 284)
        Me.dtmDateofCertification.Name = "dtmDateofCertification"
        Me.dtmDateofCertification.Size = New System.Drawing.Size(253, 22)
        Me.dtmDateofCertification.TabIndex = 39
        '
        'dtmDateofTermination
        '
        Me.dtmDateofTermination.Location = New System.Drawing.Point(172, 233)
        Me.dtmDateofTermination.Name = "dtmDateofTermination"
        Me.dtmDateofTermination.Size = New System.Drawing.Size(253, 22)
        Me.dtmDateofTermination.TabIndex = 38
        '
        'dtmDateofHire
        '
        Me.dtmDateofHire.Location = New System.Drawing.Point(172, 186)
        Me.dtmDateofHire.Name = "dtmDateofHire"
        Me.dtmDateofHire.Size = New System.Drawing.Size(253, 22)
        Me.dtmDateofHire.TabIndex = 37
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 284)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(140, 17)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "Date of Certification: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 233)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(125, 17)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "Termination Date: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 186)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 17)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Date of Hire: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(43, 343)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 17)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Pilot Role: "
        '
        'cboPilotRole
        '
        Me.cboPilotRole.FormattingEnabled = True
        Me.cboPilotRole.Location = New System.Drawing.Point(172, 337)
        Me.cboPilotRole.Name = "cboPilotRole"
        Me.cboPilotRole.Size = New System.Drawing.Size(132, 24)
        Me.cboPilotRole.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 139)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 17)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Pilot ID: "
        '
        'txtPilotID
        '
        Me.txtPilotID.Location = New System.Drawing.Point(172, 131)
        Me.txtPilotID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPilotID.Name = "txtPilotID"
        Me.txtPilotID.Size = New System.Drawing.Size(132, 22)
        Me.txtPilotID.TabIndex = 24
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(172, 85)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(132, 22)
        Me.txtLastName.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 93)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Last Name:"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(172, 33)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(132, 22)
        Me.txtFirstName.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 41)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "First Name:"
        '
        'frmAddPilots
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 472)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAddPilot)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAddPilots"
        Me.Text = "frmAddPilots"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnAddPilot As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtmDateofCertification As DateTimePicker
    Friend WithEvents dtmDateofTermination As DateTimePicker
    Friend WithEvents dtmDateofHire As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cboPilotRole As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtPilotID As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label1 As Label
End Class
