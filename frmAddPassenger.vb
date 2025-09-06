Public Class frmAddPassenger


    Private Sub frmAddPassenger_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            strSelect = "SELECT intStateID, strState FROM TStates"

            ' Retrieve all the records 
            cmdSelect = New OleDb.OleDbCommand(strSelect, m_conAdministrator)
            drSourceTable = cmdSelect.ExecuteReader
            dts.Load(drSourceTable)


            'load the State result set into the combobox.  For VB, we do this by binding the data to the combobox


            cboStates.ValueMember = "intStateID"
            cboStates.DisplayMember = "strState"
            cboStates.DataSource = dts


            ' Clean up
            drSourceTable.Close()

            ' close the database connection
            CloseDatabaseConnection()

        Catch ex As Exception

            ' Log and display error message
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Private Sub btnAddPassenger_Click(sender As Object, e As EventArgs) Handles btnAddPassenger.Click
        Dim strFirstName As String
        Dim strLastName As String
        Dim strAddress As String
        Dim strCity As String
        Dim intState As Integer
        Dim strPhoneNumber As String
        Dim strZip As String
        Dim strEmail As String

        Dim blnValidated As Boolean = True

        Validate_Input(strFirstName, strLastName, strAddress, strCity, intState, strPhoneNumber, strZip, strEmail, blnValidated)

        If blnValidated = True Then
            Add_Passenger(strFirstName, strLastName, strAddress, strCity, intState, strPhoneNumber, strZip, strEmail)
        End If
    End Sub

    Private Sub Validate_Input(ByRef strFirstName As String, ByRef strLastName As String, ByRef strAddress As String, ByRef strCity As String, ByRef intState As Integer, ByRef strPhoneNumber As String, ByRef strZip As String, ByRef strEmail As String, ByRef blnValidated As Boolean)
        Call Validate_FirstName(strFirstName, blnValidated)
        If blnValidated = True Then
            Validate_LastName(strLastName, blnValidated)
        End If
        If blnValidated = True Then
            Validate_Address(strAddress, blnValidated)
        End If
        If blnValidated = True Then
            Validate_State(intState, blnValidated)
        End If
        If blnValidated = True Then
            Validate_City(strCity, blnValidated)
        End If
        If blnValidated = True Then
            Validate_PhoneNumber(strPhoneNumber, blnValidated)
        End If
        If blnValidated = True Then
            Validate_ZIP(strZip, blnValidated)
        End If
        If blnValidated = True Then
            Validate_Email(strEmail, blnValidated)
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

    Private Sub Validate_Address(ByRef strAddress As String, ByRef blnValidated As Boolean)
        strAddress = txtAddress.Text
        If strAddress = "" Then
            MessageBox.Show("Address Is Required")
            txtAddress.Focus()
            blnValidated = False
        End If
    End Sub

    Private Sub Validate_State(ByRef intState As Integer, ByRef blnValidated As Boolean)
        intState = cboStates.SelectedValue
        If intState = -1 Then
            MessageBox.Show("State Is Required")
            cboStates.Focus()
            blnValidated = False
        End If
    End Sub

    Private Sub Validate_City(ByRef strCity As String, ByRef blnValidated As Boolean)
        strCity = txtCity.Text
        If strCity = "" Then
            MessageBox.Show("City Is Required")
            txtCity.Focus()
            blnValidated = False
        End If
    End Sub

    Private Sub Validate_ZIP(ByRef strZIP As String, ByRef blnValidated As Boolean)
        strZIP = txtZip.Text
        If strZIP = "" Then
            MessageBox.Show("ZIP Is Required")
            txtZip.Focus()
            blnValidated = False
        End If
    End Sub

    Private Sub Validate_PhoneNumber(ByRef strPhoneNumber As String, ByRef blnValidated As Boolean)
        strPhoneNumber = txtPhoneNumber.Text
        If strPhoneNumber = "" Then
            MessageBox.Show("Phone Number Is Required")
            txtPhoneNumber.Focus()
            blnValidated = False
        End If
    End Sub

    Private Sub Validate_Email(ByRef strEmail As String, ByRef blnValidated As Boolean)
        strEmail = txtEmail.Text
        If strEmail = "" Then
            MessageBox.Show("Email Is Required")
            txtEmail.Focus()
            blnValidated = False
        End If
    End Sub
    Private Sub Add_Passenger(strFirstName, strLastName, strAddress, strCity, intState, strPhoneNumber, strZip, strEmail)
        ' variables for new player data and select and insert statements
        Dim strSelect As String
        Dim strInsert As String

        Dim cmdSelect As OleDb.OleDbCommand ' select command object
        Dim cmdInsert As OleDb.OleDbCommand ' insert command object
        Dim drSourceTable As OleDb.OleDbDataReader ' data reader for pulling info
        Dim intNextPrimaryKey As Integer ' holds next highest PK value
        Dim intRowsAffected As Integer  ' how many rows were affected when sql executed

        Try


            ' validate data is entered


            ' put values into strings
            strFirstName = txtFirstName.Text
            strLastName = txtLastName.Text
            strAddress = txtAddress.Text
            strCity = txtCity.Text
            intState = cboStates.SelectedValue
            strZip = txtZip.Text
            strPhoneNumber = txtPhoneNumber.Text
            strEmail = txtEmail.Text



            If OpenDatabaseConnectionSQLServer() = False Then

                ' No, warn the user ...
                MessageBox.Show(Me, "Database connection error." & vbNewLine &
                                    "The application will now close.",
                                    Me.Text + " Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error)

                ' and close the form/application
                Me.Close()

            End If

            strSelect = "SELECT MAX(intPassengerID) + 1 AS intNextPrimaryKey " &
                            " FROM TPassengers"

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

            strInsert = "INSERT INTO TPassengers (intPassengerID, strFirstName, strLastName, strAddress, strCity, intStateID, strZip, strPhoneNumber, strEmail)" &
                " VALUES (" & intNextPrimaryKey & ",'" & strFirstName & "','" & strLastName & "','" & strAddress & "','" & strCity & "'," & intState & ",'" & strZip & "','" & strPhoneNumber & "','" & strEmail & "')"

            MessageBox.Show(strInsert)

            ' use insert command with sql string and connection object
            cmdInsert = New OleDb.OleDbCommand(strInsert, m_conAdministrator)

            ' execute query to insert data
            intRowsAffected = cmdInsert.ExecuteNonQuery()

            ' If not 0 insert successful
            If intRowsAffected > 0 Then
                MessageBox.Show("Student has been added")    ' let user know success
                ' close new player form
            End If


            CloseDatabaseConnection()       ' close connection if insert didn't work
            Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class