Public Class frmAddAttendantstoFlights
    Private Sub btnAddFlight_Click(sender As Object, e As EventArgs) Handles btnAddFlight.Click

        Dim intAttendantID As Integer
            Dim intFlightID As Integer

            Dim strSelect As String
            Dim strInsert As String

            Dim cmdSelect As OleDb.OleDbCommand ' select command object
            Dim cmdInsert As OleDb.OleDbCommand ' insert command object
            Dim drSourceTable As OleDb.OleDbDataReader ' data reader for pulling info
            Dim intNextPrimaryKey As Integer ' holds next highest PK value
            Dim intRowsAffected As Integer  ' how many rows were affected when sql executed
            Dim result = MessageBox.Show(Me, "Are you sure you want to Add This Flight?", "Confirm Addition", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

            If OpenDatabaseConnectionSQLServer() = False Then

                ' No, warn the user ...
                MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                    "The application will now close.",
                                    Me.Text + " Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)

            ' and close the form/application
            Me.Close()
            ' this will figure out which button was selected. Cancel and No does nothing, Yes will allow deletion
            ' always ask before deleting!!!!
            result = MessageBox.Show("Are you sure you want to Add Flight: " & cboFlights.Text & "to" & cboAttendants.Text & "?", "Confirm Deletion", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)


            Select Case result
                Case DialogResult.Cancel
                    MessageBox.Show("Action Canceled")
                Case DialogResult.No
                    MessageBox.Show("Action Canceled")
                Case DialogResult.Yes
                    Try
                        strSelect = "SELECT MAX(intAttendantFlightID) + 1 AS intNextPrimaryKey " &
                            " FROM TAttendantFlights"

                        ' Execute command
                        cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
                        drSourceTable = cmdSelect.ExecuteReader

                        ' Read result( highest ID )
                        drSourceTable.Read()

                        ' Null? (empty table)
                        If drSourceTable.IsDBNull(0) = True Then

                            ' Yes, start numbering at 1
                            intNextPrimaryKey = 1

                        Else

                            ' No, get the next highest ID
                            intNextPrimaryKey = CInt(drSourceTable("intNextPrimaryKey"))

                        End If
                        ' build insert statement (columns must match DB columns in name and the # of columns)

                        intAttendantID = cboAttendants.SelectedIndex + 1
                        intFlightID = cboFlights.SelectedIndex + 1

                        strInsert = "INSERT INTO TAttendantFlights (intAttendantFlightID, intFlightID, intAttendantID)" &
                        "VALUES (" & intNextPrimaryKey & "','" & intFlightID & "','" & intAttendantID & "')"


                        ' If not 0 insert successful
                        If intRowsAffected > 0 Then
                            MessageBox.Show("Flight has been booked")    ' let user know success
                            ' close new player form
                        End If

                        ' Clean up
                        drSourceTable.Close()
                        ' close the database connection
                        CloseDatabaseConnection()

                    Catch excError As Exception

                        ' Log and display error message
                        MessageBox.Show(excError.Message)

                    End Try
            End Select
        End If
    End Sub

    Private Sub frmAddAttendantstoFlights_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strSelect As String = ""
        Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
        Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to
        Dim dt As DataTable = New DataTable ' this is the table we will load from our reader
        Dim dtf As DataTable = New DataTable
        Try

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

            strSelect = "SELECT TF.intFlightID, CONVERT(VARCHAR,TF.dtmFlightDate) + ' ' + TA.strAirportCity AS AirportInfo " &
                        "FROM TFlights AS TF " &
                        "JOIN TAirports AS TA " &
                        "ON TA.intAirportID = TF.intFromAirportID " &
                        "JOIN TPlanes AS TPA " &
                        "ON TPA.intPlaneID = TF.intPlaneID " &
                        "WHERE dtmTimeofDeparture > '11/16/2023'"

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            ' load table from data reader
            dtf.Load(drSourceTable)

            ' Add the item to the combo box. We need the player ID associated with the name so 
            ' when we click on the name we can then use the ID to pull the rest of the players data.
            ' We are binding the column name to the combo box display and value members. 
            cboFlights.ValueMember = "intFlightID"
            cboFlights.DisplayMember = "AirportInfo"
            cboFlights.DataSource = dtf

            ' Select the first item in the list by default
            If cboFlights.Items.Count > 0 Then cboFlights.SelectedIndex = 0

            ' Clean up
            drSourceTable.Close()
            ' close the database connection
            CloseDatabaseConnection()
        Catch excError As Exception

            ' Log and display error message
            MessageBox.Show(excError.Message)

        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class