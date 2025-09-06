Public Class frmAddPilotsToFlights
    Private Sub btnAddFlight_Click(sender As Object, e As EventArgs) Handles btnAddFlight.Click
        Dim intPilotID As Integer
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

        End If


        Select Case result
            Case DialogResult.Cancel
                MessageBox.Show("Action Canceled")
            Case DialogResult.No
                MessageBox.Show("Action Canceled")
            Case DialogResult.Yes

                strSelect = "SELECT MAX(intPilotFlightID) + 1 AS intNextPrimaryKey " &
                        " FROM TPilotFlights"

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

                intPilotID = cboPilots.SelectedIndex + 1
                intFlightID = cboFlights.SelectedIndex + 1

                strInsert = "INSERT INTO TPilotFlights (intPilotFlightID, intFlightID, intPilotID)" &
                    "VALUES (" & intNextPrimaryKey & "," & intFlightID & "," & intPilotID & ")"

                MessageBox.Show(strInsert)

                ' use insert command with sql string and connection object
                cmdInsert = New OleDb.OleDbCommand(strInsert, m_conAdministrator)

                ' execute query to insert data
                intRowsAffected = cmdInsert.ExecuteNonQuery()

                ' If not 0 insert successful
                If intRowsAffected > 0 Then
                    MessageBox.Show("Flight has been booked")    ' let user know success
                    ' close new player form
                End If

                CloseDatabaseConnection()       ' close connection if insert didn't work
                Close()
        End Select
    End Sub

    Private Sub frmAddPilotsToFlights_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand("uspListPilots", m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            ' load table from data reader
            dt.Load(drSourceTable)

            ' Add the item to the combo box. We need the player ID associated with the name so 
            ' when we click on the name we can then use the ID to pull the rest of the players data.
            ' We are binding the column name to the combo box display and value members. 
            cboPilots.ValueMember = "intPilotID"
            cboPilots.DisplayMember = "PilotName"
            cboPilots.DataSource = dt

            ' Select the first item in the list by default
            If cboPilots.Items.Count > 0 Then cboPilots.SelectedIndex = 0

            strSelect = "SELECT TF.intFlightID, CONVERT(VARCHAR,TF.dtmFlightDate) + ' ' + TA.strAirportCity AS AirportInfo " &
                        "FROM TFlights AS TF " &
                        "JOIN TAirports AS TA " &
                        "ON TA.intAirportID = TF.intFromAirportID " &
                        "WHERE TF.dtmFlightDate > '03/25/2023' "

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