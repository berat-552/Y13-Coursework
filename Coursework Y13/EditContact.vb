Imports System.IO
Imports System.Text.RegularExpressions

Public Class EditContact
    Private currentIndex As Integer = 0
    Private Sub comContactID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comContactID.SelectedIndexChanged
        'Check if a contact ID is selected
        If comContactID.SelectedIndex <> -1 Then
            'Get the selected contact ID
            Dim selectedContactID As String = comContactID.SelectedItem.ToString()

            'Extract the contact ID from the selected item
            Dim contactId As String = selectedContactID.Split("-"c)(0).Trim()

            'Read all contact details from the file
            Dim allContactDetails As List(Of String) = File.ReadAllLines("AllContacts.txt").ToList()

            'Find the details for the selected contact ID
            Dim contactDetails As String = allContactDetails.Find(Function(line) line.StartsWith(contactId))

            'Check if contact details were found
            If contactDetails IsNot Nothing Then
                'Split the details into individual fields (assuming comma-separated values)
                Dim detailsArray As String() = contactDetails.Split(","c)
                txtStaffID.Text = detailsArray(1)
                txtContactDetails.Text = detailsArray(3)
                comContactMethods.Text = detailsArray(2)

                'Assuming staff ID is at index 1 in detailsArray
                Dim staffId As String = detailsArray(1).Trim()

                'Read all staff details from the file
                Dim allStaffDetails As List(Of String) = File.ReadAllLines("AllStaff.txt").ToList()

                'Find the index of the line with the selected staff ID
                Dim staffIndex As Integer = allStaffDetails.FindIndex(Function(line) line.StartsWith(staffId))

                'Check if staff details were found
                If staffIndex <> -1 Then
                    'Extract the staff name from the line
                    Dim staffName As String = allStaffDetails(staffIndex).Split(","c)(1).Trim() & " " & allStaffDetails(staffIndex).Split(","c)(2).Trim()
                    txtStaffName.Text = staffName
                Else

                    'Handle the case where staff details were Not found
                    MessageBox.Show("Staff details not found for selected ID.")
                End If
            Else
                'Handle the case where contact details were not found
                MessageBox.Show("Contact details not found for selected contact ID.")
            End If
        End If
    End Sub

    Private Sub EditContact_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Add contact methods on Load Event
        comContactMethods.Items.Add("E-Mail")
        comContactMethods.Items.Add("Phone")
        comContactMethods.Items.Add("Home Telephone")

        Dim allContactIds = GetAllContactIds()

        'Load all contact ids to the combo box
        For Each contactId In allContactIds
            'Get the corresponding staff ID and name based on the contact ID
            Dim staffIdAndName As String = GetStaffName(contactId)

            'Add the combined ID and name to the combo box
            comContactID.Items.Add($"{contactId}-{staffIdAndName}")
        Next
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub

    Private Sub btnUpdateContactDetails_Click(sender As Object, e As EventArgs) Handles btnUpdateContactDetails.Click

        'Validate input fields
        If IsTextboxEmpty(txtStaffName) Or IsTextboxEmpty(txtContactDetails) Then
            MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        If comContactID.Text = "" Then
            MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If txtStaffID.Text = "" Then
            MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If comContactMethods.SelectedItem = "Phone" AndAlso Not IsNumeric(comContactMethods.Text) Then
            MessageBox.Show("Please enter a valid phone number.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim email As String = txtContactDetails.Text
        Dim emailPattern As String = "^\S+@\S+\.\S+$"
        Dim regex As New Regex(emailPattern)

        If Not regex.IsMatch(email) Then
            MessageBox.Show("Invalid E-Mail, please enter a valid email address", "Invalid Email Address Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'Check if a contact id is selected
        If comContactID.SelectedIndex <> -1 Then

                'Get the selected contact ID
                Dim selectedContactID As String = comContactID.SelectedItem.ToString()

                'Extract the contact ID from the selected item
                Dim contactId As String = selectedContactID.Split("-"c)(0).Trim()

                'Read all contact details from the file
                Dim allContactDetails As List(Of String) = File.ReadAllLines("AllContacts.txt").ToList()

                'Find the index of the line with the selected contact ID
                Dim contactIndex As Integer = allContactDetails.FindIndex(Function(line) line.StartsWith(contactId))

                'Check if contact details were found
                If contactIndex <> -1 Then
                    'Split the details into individual fields (assuming comma-separated values)
                    Dim detailsArray As String() = allContactDetails(contactIndex).Split(","c)

                    Dim staffID As String = detailsArray(1).Trim()

                    'Update the corresponding staff ID
                    txtStaffID.Text = staffID

                    'Update the details for the selected contact
                    allContactDetails(contactIndex) = $"{contactId},{txtStaffID.Text},{comContactMethods.Text},{txtContactDetails.Text}"

                    'Write the updated details back to the file
                    File.WriteAllLines("AllContacts.txt", allContactDetails)

                    'Provide feedback to the user
                    MessageBox.Show("Contact details updated successfully.")
                Else
                    'Handle the case where contact details were not found
                    MessageBox.Show("Contact details not found for selected ID.")
                End If
            End If
    End Sub

    Private Sub btnNextContact_Click(sender As Object, e As EventArgs) Handles btnNextContact.Click
        ' Increment the current index for contact details
        currentIndex += 1

        ' Show the contact details based on the current index
        ShowCurrentContactDetails()
    End Sub

    '-----------------------------
    Private Sub btnPreviousContact_Click(sender As Object, e As EventArgs) Handles btnPreviousContact.Click
        ' Decrement the current index for contact details
        currentIndex -= 1

        ' Show the contact details based on the current index
        ShowCurrentContactDetails()
    End Sub

    ' Method to show contact details based on the current index
    Private Sub ShowContactDetails(contactDetailsList As List(Of String), index As Integer)
        ' Ensure the index is within the valid range
        If index >= 0 AndAlso index < contactDetailsList.Count Then
            ' Split the details into individual fields
            Dim contactArray As String() = contactDetailsList(index).Split(","c)

            ' Update the corresponding textbox with the contact details
            Select Case contactArray(2).Trim().ToLower()
                Case "e-mail", "phone", "home telephone"
                    comContactMethods.Text = contactArray(2).Trim()
                    txtContactDetails.Text = contactArray(3).Trim()
            End Select
        End If
    End Sub
    Private Function GetListOfContactDetailsOfStaff(staffID As String) As List(Of String)
        Dim contactDetailsFilePath As String = "AllContacts.txt"

        Dim allContactDetails As List(Of String) = File.ReadAllLines(contactDetailsFilePath).ToList()

        Dim staffContactDetails As New List(Of String)
        For Each contactDetail As String In allContactDetails
            Dim detailsArray As String() = contactDetail.Split(","c)
            If detailsArray.Length > 1 AndAlso detailsArray(1).Trim() = staffID Then
                staffContactDetails.Add(contactDetail)
            End If
        Next

        Return staffContactDetails
    End Function

    Private Sub ShowCurrentContactDetails()
        'Get the staff ID based on the current index
        Dim staffID As String = txtStaffID.Text.Trim()

        'Get the contact details list for the staff ID
        Dim contactDetailsList As List(Of String) = GetListOfContactDetailsOfStaff(staffID)

        'If the index exceeds the number of contact details, reset to the first or last contact
        If currentIndex >= contactDetailsList.Count Then
            currentIndex = 0
        ElseIf currentIndex < 0 Then
            currentIndex = contactDetailsList.Count - 1
        End If

        'Show the contact details based on the current index
        ShowContactDetails(contactDetailsList, currentIndex)
    End Sub
End Class