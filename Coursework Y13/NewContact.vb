Imports System.IO
Imports System.Text.RegularExpressions

Public Class NewContact

    Public Function GetAllStaffIds() As List(Of Integer)
        'Declare new dynamic list that can grow dynamically
        Dim staffIds As New List(Of Integer)

        'Read the lines from the text file
        Dim lines() As String = File.ReadAllLines("AllStaff.txt")

        'Process each line to extract staff IDs
        For Each line As String In lines
            Dim parts() As String = line.Split(","c)

            'Ensure there are enough parts and that the first part (index 0) is a valid integer
            If parts.Length > 0 Then
                Dim staffId As Integer
                If Integer.TryParse(parts(0), staffId) Then
                    staffIds.Add(staffId)
                End If
            End If
        Next

        Return staffIds
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear input fields
        ClearInputFields(Me)

        'Call the ID function to prevent contactID textbox from being cleared
        Dim maxId As Integer = GetMaxID("AllContacts.txt")
        txtContactID.Text = maxId + 1
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Close form
        Close()
    End Sub

    Private Sub NewContact_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim allStaffIds = GetAllStaffIds()
        Dim allStaffNames = GetAllStaffNames()

        Dim maxId As Integer = GetMaxID("AllContacts.txt")
        txtContactID.Text = maxId + 1 'Increment ContactId 
        'Add contact methods on Load Event
        comContactMethods.Items.Add("E-Mail")
        comContactMethods.Items.Add("Phone")
        comContactMethods.Items.Add("Home Telephone")

        'Load all the staffIds into combo box in the format "S[StaffId]-[StaffName]"
        For i As Integer = 0 To Math.Min(allStaffIds.Count - 1, allStaffNames.Count - 1)
            comStaffID.Items.Add($"S{allStaffIds(i)}-{allStaffNames(i)}")
        Next
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Declare variable of Contact Structure
        Dim newContact As Contact

        'Validate all fields
        'Will display error message even if one textbox is empty
        If IsTextboxEmpty(txtContactDetails) Or IsTextboxEmpty(txtContactID) Then
            MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        '#### Validate combo boxes ####
        If comContactMethods.Text = "" Then
            MessageBox.Show("Please select a contact method", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If comStaffID.Text = "" Then
            MessageBox.Show("Please select a Staff ID", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        '#### Validate contact methods ####

        If comContactMethods.Text = "Phone" Or comContactMethods.Text = "Home Telephone" Then
            If txtContactDetails.Text.Length < 11 Then
                MessageBox.Show("Phone number must be 11 characters", "Invalid Phone Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        End If

        If comContactMethods.Text = "E-Mail" Then
            Dim email As String = txtContactDetails.Text
            Dim emailPattern As String = "^\S+@\S+\.\S+$"

            'Make an instance of regular expression using email pattern
            Dim regex As New Regex(emailPattern)
            'if email does not match the pattern, throw error
            If Not regex.IsMatch(email) Then
                MessageBox.Show("Invalid E-Mail, please enter a valid email address", "Invalid Email Address Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        End If

        'Transfer data from textboxes into newContact
        newContact.ContactId = txtContactID.Text
        'Slice (e.g. "S1-Full Name" -> "1")
        newContact.StaffId = comStaffID.Text.Substring(1, comStaffID.Text.IndexOf("-") - 1)
        newContact.ContactType = comContactMethods.Text
        newContact.ContactDetails = txtContactDetails.Text

        'Append data to AllContacts.txt
        Dim newContactDetails As StreamWriter
        newContactDetails = My.Computer.FileSystem.OpenTextFileWriter(Dir$("AllContacts.txt"), True)
        newContactDetails.WriteLine($"{newContact.ContactId},{newContact.StaffId},{newContact.ContactType},{newContact.ContactDetails}")

        'Close textfile
        newContactDetails.Close()

        'Reset input fields
        ClearInputFields(Me)

        'Display new incremented contact id
        Dim maxId As Integer = GetMaxID("AllContacts.txt")
        txtContactID.Text = maxId + 1

        'Display success message
        MessageBox.Show("New Contact information has been saved")

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        EditContact.Show() 'show edit contacts form
    End Sub
End Class