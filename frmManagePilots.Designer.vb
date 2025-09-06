<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmManagePilots
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
        Me.btnAddPilotstoFlights = New System.Windows.Forms.Button()
        Me.btnDeletePilots = New System.Windows.Forms.Button()
        Me.btnAddPilots = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnAddPilotstoFlights
        '
        Me.btnAddPilotstoFlights.Location = New System.Drawing.Point(196, 12)
        Me.btnAddPilotstoFlights.Name = "btnAddPilotstoFlights"
        Me.btnAddPilotstoFlights.Size = New System.Drawing.Size(161, 77)
        Me.btnAddPilotstoFlights.TabIndex = 5
        Me.btnAddPilotstoFlights.Text = "Add Pilots To Flights"
        Me.btnAddPilotstoFlights.UseVisualStyleBackColor = True
        '
        'btnDeletePilots
        '
        Me.btnDeletePilots.Location = New System.Drawing.Point(12, 12)
        Me.btnDeletePilots.Name = "btnDeletePilots"
        Me.btnDeletePilots.Size = New System.Drawing.Size(161, 77)
        Me.btnDeletePilots.TabIndex = 4
        Me.btnDeletePilots.Text = "Delete Pilots"
        Me.btnDeletePilots.UseVisualStyleBackColor = True
        '
        'btnAddPilots
        '
        Me.btnAddPilots.Location = New System.Drawing.Point(107, 108)
        Me.btnAddPilots.Name = "btnAddPilots"
        Me.btnAddPilots.Size = New System.Drawing.Size(161, 77)
        Me.btnAddPilots.TabIndex = 3
        Me.btnAddPilots.Text = "Add Pilots"
        Me.btnAddPilots.UseVisualStyleBackColor = True
        '
        'frmManagePilots
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 191)
        Me.Controls.Add(Me.btnAddPilotstoFlights)
        Me.Controls.Add(Me.btnDeletePilots)
        Me.Controls.Add(Me.btnAddPilots)
        Me.Name = "frmManagePilots"
        Me.Text = "frmManagePilots"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnAddPilotstoFlights As Button
    Friend WithEvents btnDeletePilots As Button
    Friend WithEvents btnAddPilots As Button
End Class
