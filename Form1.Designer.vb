<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnCustomer = New System.Windows.Forms.Button()
        Me.btnPilots = New System.Windows.Forms.Button()
        Me.btnAttendant = New System.Windows.Forms.Button()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCustomer
        '
        Me.btnCustomer.Location = New System.Drawing.Point(23, 18)
        Me.btnCustomer.Name = "btnCustomer"
        Me.btnCustomer.Size = New System.Drawing.Size(181, 82)
        Me.btnCustomer.TabIndex = 0
        Me.btnCustomer.Text = "Customer"
        Me.btnCustomer.UseVisualStyleBackColor = True
        '
        'btnPilots
        '
        Me.btnPilots.Location = New System.Drawing.Point(348, 18)
        Me.btnPilots.Name = "btnPilots"
        Me.btnPilots.Size = New System.Drawing.Size(181, 82)
        Me.btnPilots.TabIndex = 1
        Me.btnPilots.Text = "Pilot"
        Me.btnPilots.UseVisualStyleBackColor = True
        '
        'btnAttendant
        '
        Me.btnAttendant.Location = New System.Drawing.Point(23, 158)
        Me.btnAttendant.Name = "btnAttendant"
        Me.btnAttendant.Size = New System.Drawing.Size(181, 82)
        Me.btnAttendant.TabIndex = 2
        Me.btnAttendant.Text = "Attendant"
        Me.btnAttendant.UseVisualStyleBackColor = True
        '
        'btnAdmin
        '
        Me.btnAdmin.Location = New System.Drawing.Point(348, 158)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(181, 82)
        Me.btnAdmin.TabIndex = 3
        Me.btnAdmin.Text = "Administrator"
        Me.btnAdmin.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 263)
        Me.Controls.Add(Me.btnAdmin)
        Me.Controls.Add(Me.btnAttendant)
        Me.Controls.Add(Me.btnPilots)
        Me.Controls.Add(Me.btnCustomer)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCustomer As Button
    Friend WithEvents btnPilots As Button
    Friend WithEvents btnAttendant As Button
    Friend WithEvents btnAdmin As Button
End Class
