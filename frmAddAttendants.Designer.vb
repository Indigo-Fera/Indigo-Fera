<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddAttendants
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
        Me.btnAddAttendant = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dtmDateofTermination = New System.Windows.Forms.DateTimePicker()
        Me.dtmDateofHire = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtAttendantID = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(310, 414)
        Me.btnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(139, 57)
        Me.btnExit.TabIndex = 23
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnAddAttendant
        '
        Me.btnAddAttendant.Location = New System.Drawing.Point(105, 414)
        Me.btnAddAttendant.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAddAttendant.Name = "btnAddAttendant"
        Me.btnAddAttendant.Size = New System.Drawing.Size(139, 57)
        Me.btnAddAttendant.TabIndex = 22
        Me.btnAddAttendant.Text = "Add Attendant"
        Me.btnAddAttendant.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtmDateofTermination)
        Me.GroupBox1.Controls.Add(Me.dtmDateofHire)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.txtUserID)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtAttendantID)
        Me.GroupBox1.Controls.Add(Me.txtLastName)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtFirstName)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(538, 395)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'dtmDateofTermination
        '
        Me.dtmDateofTermination.Location = New System.Drawing.Point(172, 228)
        Me.dtmDateofTermination.Name = "dtmDateofTermination"
        Me.dtmDateofTermination.Size = New System.Drawing.Size(253, 22)
        Me.dtmDateofTermination.TabIndex = 51
        '
        'dtmDateofHire
        '
        Me.dtmDateofHire.Location = New System.Drawing.Point(172, 181)
        Me.dtmDateofHire.Name = "dtmDateofHire"
        Me.dtmDateofHire.Size = New System.Drawing.Size(253, 22)
        Me.dtmDateofHire.TabIndex = 50
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 228)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 17)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Termination Date: "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 181)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 17)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Date of Hire: "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(38, 339)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(77, 17)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Password: "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(38, 285)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 17)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "User ID; "
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(172, 334)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(204, 22)
        Me.txtPassword.TabIndex = 45
        '
        'txtUserID
        '
        Me.txtUserID.Location = New System.Drawing.Point(172, 281)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(204, 22)
        Me.txtUserID.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 139)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 17)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Attendant ID: "
        '
        'txtAttendantID
        '
        Me.txtAttendantID.Location = New System.Drawing.Point(172, 131)
        Me.txtAttendantID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAttendantID.Name = "txtAttendantID"
        Me.txtAttendantID.Size = New System.Drawing.Size(132, 22)
        Me.txtAttendantID.TabIndex = 24
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
        'frmAddAttendants
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(566, 482)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAddAttendant)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmAddAttendants"
        Me.Text = "frmAddAttendants"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnAddAttendant As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dtmDateofTermination As DateTimePicker
    Friend WithEvents dtmDateofHire As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUserID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAttendantID As TextBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents Label1 As Label
End Class
