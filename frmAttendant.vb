Public Class frmAttendant
    Private Sub btnSelectAttendant_Click(sender As Object, e As EventArgs) Handles btnSelectAttendant.Click
        Dim intSelectedAttendant As Integer

        intSelectedAttendant = cboAttendants.SelectedIndex + 1
        Call Attendant_ID_Storage_Select(intSelectedAttendant)
        Dim frmAttendants As New frmAttendantMainMenu

        frmAttendants.ShowDialog()
    End Sub

    Private Sub frmSelectAttendant_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strSelect As String = ""
        Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
        Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to
        Dim dt As DataTable = New DataTable ' this is the table we will load from our reader

        Try
            ' loop through the textboxes and clear them in case they have data in them after a delete
            For Each cntrl As Control In Controls
                If TypeOf cntrl Is TextBox Then
                    cntrl.Text = String.Empty
                End If
            Next

            ' open the DB this is in module
            If OpenDatabaseConnectionSQLServer() = False Then

                ' No, warn the user ...
                MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                "The application will now close.",
                                Me.Text + " Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error)

                ' and close the form/application
                Me.Close()

            End If

            ' Build the select statement
            strSelect = "SELECT intAttendantID, strFirstName + ' ' + strLastName as AttendantName FROM TAttendants"

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            ' load table from data reader
            dt.Load(drSourceTable)

            ' Add the item to the combo box. We need the player ID associated with the name so 
            ' when we click on the name we can then use the ID to pull the rest of the players data.
            ' We are binding the column name to the combo box display and value members. 
            cboAttendants.ValueMember = "intAttendantID"
            cboAttendants.DisplayMember = "AttendantName"
            cboAttendants.DataSource = dt

            ' Select the first item in the list by default
            If cboAttendants.Items.Count > 0 Then cboAttendants.SelectedIndex = 0

            ' Clean up
            drSourceTable.Close()

            ' close the database connection
            CloseDatabaseConnection()

        Catch excError As Exception

            ' Log and display error message
            MessageBox.Show(excError.Message)

        End Try
    End Sub
End Class