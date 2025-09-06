Public Class frmAddPilots
    Private Sub btnAddPilot_Click(sender As Object, e As EventArgs) Handles btnAddPilot.Click
        Dim strFirstName As String = ""
        Dim strLastName As String = ""
        Dim strPilotID As String = ""
        Dim intPilotRole As Integer
        Dim strUserID As String = ""
        Dim strPassword As String = ""

        Dim blnValidated As Boolean
        blnValidated = True

        Call Validate_Input(strFirstName, strLastName, strPilotID, intPilotRole, blnValidated)

        If blnValidated = True Then
            Call Add_Pilot(strFirstName, strLastName, strPilotID, intPilotRole)
        End If
    End Sub

    Private Sub Validate_Input(ByRef strFirstName As String, ByRef strLastName As String, ByRef strPilotID As String, ByRef intPilotRole As Integer, ByRef blnValidated As Boolean)

        Call Validate_FirstName(strFirstName, blnValidated)
        If blnValidated = True Then
            Validate_LastName(strLastName, blnValidated)
        End If
        If blnValidated = True Then
            Validate_PilotID(strPilotID, blnValidated)
        End If
        If blnValidated = True Then
            Validate_PilotRole(intPilotRole, blnValidated)
        End If
    End Sub

    Private Sub Validate_FirstName(ByRef strFirstName As String, ByRef blnValidated As Boolean)
        strFirstName = txtFirstName.Text
        If strFirstName = "" Then
            MessageBox.Show("First Name Is Required")
            txtFirstName.Focus()
            blnValidated = False
        End If
    End Sub

    Private Sub Validate_LastName(ByRef strLastName As String, ByRef blnValidated As Boolean)
        strLastName = txtLastName.Text
        If strLastName = "" Then
            MessageBox.Show("Last Name Is Required")
            txtLastName.Focus()
            blnValidated = False
        End If
    End Sub

    Private Sub Validate_PilotID(ByRef strPilotID As String, ByRef blnValidated As Boolean)
        strPilotID = txtPilotID.Text
        If strPilotID = "" Then
            MessageBox.Show("PilotID Is Required")
            txtLastName.Focus()
            blnValidated = False
        End If
    End Sub

    Private Sub Validate_PilotRole(ByRef intPilotRole As Integer, ByRef blnValidated As Boolean)
        intPilotRole = cboPilotRole.SelectedValue
        If intPilotRole = -1 Then
            MessageBox.Show("Pilot Role Is Required")
            cboPilotRole.Focus()
            blnValidated = False
        End If
    End Sub

    Private Sub Add_Pilot(strFirstName, strLastName, strPilotID, intPilotRole)
        ' variables for new player data and select and insert statements
        Dim strSelect As String
        Dim strInsert As String

        Dim cmdSelect As OleDb.OleDbCommand ' select command object
        Dim cmdInsert As OleDb.OleDbCommand ' insert command object
        Dim drSourceTable As OleDb.OleDbDataReader ' data reader for pulling info
        Dim intNextPrimaryKeyPilot As Integer ' holds next highest PK value
        Dim intRowsAffected As Integer  ' how many rows were affected when sql executed

        Dim dtmDateHire As Date
        Dim dtmTerminationDate As Date
        Dim dtmDateCertification As Date

        dtmDateHire = dtmDateofHire.Value
        dtmTerminationDate = dtmDateofTermination.Value
        dtmDateCertification = dtmDateofCertification.Value
        Try


            If OpenDatabaseConnectionSQLServer() = False Then

                ' No, warn the user ...
                MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                    "The application will now close.",
                                    Me.Text + " Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)

                ' and close the form/application
                Me.Close()

            End If

            strSelect = "SELECT MAX(intPilotID) + 1 AS intNextPrimaryKey " &
                            " FROM TPilots"

            ' Execute command
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader

            ' Read result( highest ID )
            drSourceTable.Read()

            ' Null? (empty table)
            If drSourceTable.IsDBNull(0) = True Then

                ' Yes, start numbering at 1
                intNextPrimaryKeyPilot = 1

            Else

                ' No, get the next highest ID
                intNextPrimaryKeyPilot = CInt(drSourceTable("intNextPrimaryKey"))

            End If

            ' build insert statement (columns must match DB columns in name and the # of columns)

            strInsert = "INSERT INTO TPilots (intPilotID, strFirstName, strLastName, dtmDateofHire, dtmDateofTermination, dtmDateofLicense, intPilotRoleID)" &
                " VALUES (" & intNextPrimaryKeyPilot & ",'" & strFirstName & "','" & strLastName & "','" & dtmDateHire & "','" & dtmTerminationDate & "','" & dtmDateCertification & "', " & intPilotRole & ")"

            MessageBox.Show(strInsert)

            ' use insert command with sql string and connection object
            cmdInsert = New OleDb.OleDbCommand(strInsert, m_conAdministrator)

            ' execute query to insert data
            intRowsAffected = cmdInsert.ExecuteNonQuery()

            ' If not 0 insert successful
            If intRowsAffected > 0 Then
                MessageBox.Show("Pilot has been added")    ' let user know success
                ' close new player form
            End If

            CloseDatabaseConnection()       ' close connection if insert didn't work
            Close()



        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Call Customer_ID_Storage_Add(intNextPrimaryKeyPilot)

        Dim frmManagePilots As New frmManagePilots

        frmManagePilots.ShowDialog()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub frmAddPilots_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
        '  On the event Form Load, we are going to populate the comboboxes of City, State, and Race from 
        '  the database
        '


        Try

            Dim strSelect As String = ""
            Dim cmdSelect As OleDb.OleDbCommand ' this will be used for our Select statement
            Dim drSourceTable As OleDb.OleDbDataReader ' this will be where our data is retrieved to
            Dim dts As DataTable = New DataTable ' this is the table we will load from our reader for State

            ' open the DB
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
            strSelect = "SELECT intPilotRoleID, strPilotRole FROM TPilotRoles"

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader
            dts.Load(drSourceTable)


            'load the State result set into the combobox.  For VB, we do this by binding the data to the combobox


            cboPilotRole.ValueMember = "intPilotRoleID"
            cboPilotRole.DisplayMember = "strPilotRole"
            cboPilotRole.DataSource = dts


            ' Clean up
            drSourceTable.Close()

            ' close the database connection
            CloseDatabaseConnection()
        Catch ex As Exception

            ' Log and display error message
            MessageBox.Show(ex.Message)

        End Try
    End Sub
End Class