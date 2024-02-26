Imports System.IO

Public Class SearchStaff
    Private currentIndex As Integer = 0
    Private staffMembers As List(Of String)
    Private contacts As List(Of String)

    'method to show staff details based on the current index
    Private Sub ShowStaffDetails(index As Integer)
        'Ensure the index is within the valid range
        If index >= 0 AndAlso index < staffMembers.Count Then
            'Split the details into individual fields
            Dim detailsArray As String() = staffMembers(index).Split(","c)
            'Update the textboxes with the staff details
            txtStaffID.Text = detailsArray(0).Trim()
            txtFullName.Text = $"{detailsArray(1).Trim()} {detailsArray(2).Trim()}"
            txtTitle.Text = detailsArray(3).Trim()
            txtStreet.Text = detailsArray(4).Trim()
            txtTown.Text = detailsArray(5).Trim()
            txtPostcode.Text = detailsArray(6).Trim()
            txtNationalInsurance.Text = detailsArray(7).Trim()

            ' Retrieve and display contact details based on staff ID
            Dim staffID As String = detailsArray(0).Trim()
            Dim contactID As String = GetContactDetails(staffID)

        End If
    End Sub

    Private Function GetContactDetails(staffID As String)
        'Reset contact details textboxes
        txtContactID.Text = ""
        txtContactMethod.Text = ""
        txtContactDetails.Text = ""

        'Find the contact details based on staff ID in the contacts list
        For Each contact As String In contacts
            Dim contactArray As String() = contact.Split(","c)
            If contactArray.Length > 1 AndAlso staffID = contactArray(1).Trim() Then
                txtContactID.Text = contactArray(1).Trim()

                'Update the corresponding textbox with the contact details
                Select Case contactArray(2).Trim().ToLower()
                    Case "e-mail", "phone", "home telephone"
                        txtContactMethod.Text = contactArray(2).Trim()
                        txtContactDetails.Text = contactArray(3).Trim()
                End Select

                'Exit the loop since you found a match
                Return ""
            End If
        Next

        'Return an empty string if not found
        Return ""
    End Function

    Private Sub SearchStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Read all lines from the file into the list
        staffMembers = File.ReadAllLines("AllStaff.txt").ToList()
        contacts = File.ReadAllLines("AllContacts.txt").ToList()

        'Initialize the form with the first staff member
        ShowStaffDetails(0)
    End Sub

    '#### LINEAR SEARCH ####
    Private Function LinearSearch()
        'Reset the found flag
        Dim found As Boolean = False

        Dim staffToSearch = txtEnterFirstName.Text.Trim()

        'Iterate through each line in the list
        For Each staffMember As String In staffMembers
            'Split the details into individual fields 
            Dim detailsArray As String() = staffMember.Split(","c)

            'Check if the first name matches
            If detailsArray.Length > 1 AndAlso staffToSearch = detailsArray(1).Trim().ToLower() Then
                'Set the found flag to true
                found = True

                'Update other controls with the staff details
                txtStaffID.Text = detailsArray(0).Trim()
                txtFullName.Text = $"{detailsArray(1).Trim()} {detailsArray(2).Trim()}"
                txtTitle.Text = detailsArray(3).Trim()
                txtStreet.Text = detailsArray(4).Trim()
                txtTown.Text = detailsArray(5).Trim()
                txtPostcode.Text = detailsArray(6).Trim()
                txtNationalInsurance.Text = detailsArray(7).Trim()

                Return detailsArray(0).Trim()
                Exit For
            End If
        Next

        'Reset input fields if not found
        If Not found Then
            txtStaffID.Text = ""
            txtFullName.Text = ""
            txtTitle.Text = ""
            txtStreet.Text = ""
            txtTown.Text = ""
            txtPostcode.Text = ""
            txtNationalInsurance.Text = ""
        End If

        'Return an empty string when no match is found
        Return ""
    End Function

    Private Sub ClearContactDetails()
        'Reset contact details textboxes
        txtContactID.Text = ""
        txtContactMethod.Text = ""
        txtContactDetails.Text = ""
    End Sub

    Private Sub txtEnterFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtEnterFirstName.TextChanged
        Dim staffID As String = LinearSearch() 'perform linear search each time user types

        'Check if a valid staff member is found
        If Not String.IsNullOrEmpty(staffID) Then
            'Update contact details based on the current staff member's ID
            GetContactDetails(staffID)
        Else
            'Clear contact details textboxes if there is no valid staff member
            ClearContactDetails()
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'Increment the current index to move to the next staff member
        currentIndex += 1
        'If the index exceeds the number of staff members, reset to the first staff member
        If currentIndex >= staffMembers.Count Then
            currentIndex = 0
        End If
        'Invoke the method to show the staff details based on the current index
        ShowStaffDetails(currentIndex)
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        'Decrement the current index to move to the previous staff member
        currentIndex -= 1
        'If the index is less than zero, set it to the last staff member
        If currentIndex < 0 Then
            currentIndex = staffMembers.Count - 1
        End If
        'Invoke the method to show the staff details based on the current index
        ShowStaffDetails(currentIndex)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub

    '------------------------

    ' Dictionary to store contact details for each staff member
    Private contactDetailsDictionary As New Dictionary(Of String, List(Of String))

    Private Function GetListOfContactDetailsOfStaff(staffID As String) As List(Of String)
        ' Check if the contact details are already stored in the dictionary
        If contactDetailsDictionary.ContainsKey(staffID) Then
            ' Return the stored contact details
            Return contactDetailsDictionary(staffID)
        End If

        ' If not found, create a new list to store contact details for the staff ID
        Dim contactDetailsList As New List(Of String)

        ' Find the contact details based on staff ID in the contacts list
        For Each contact As String In contacts
            Dim contactArray As String() = contact.Split(","c)
            If contactArray.Length > 1 AndAlso staffID = contactArray(1).Trim() Then
                ' Add the contact details to the list
                contactDetailsList.Add(contact.Trim())
            End If
        Next

        ' Store the contact details in the dictionary
        contactDetailsDictionary(staffID) = contactDetailsList

        ' Return the contact details list
        Return contactDetailsList
    End Function

    ' Method to show contact details based on the current index
    Private Sub ShowContactDetails(contactDetailsList As List(Of String), index As Integer)
        ' Ensure the index is within the valid range
        If index >= 0 AndAlso index < contactDetailsList.Count Then
            ' Split the details into individual fields
            Dim contactArray As String() = contactDetailsList(index).Split(","c)

            ' Update the textboxes with the contact details
            txtContactID.Text = contactArray(1).Trim()

            ' Update the corresponding textbox with the contact details
            Select Case contactArray(2).Trim().ToLower()
                Case "e-mail", "phone", "home telephone"
                    txtContactMethod.Text = contactArray(2).Trim()
                    txtContactDetails.Text = contactArray(3).Trim()
            End Select
        End If
    End Sub

    Private Sub btnNextContact_Click(sender As Object, e As EventArgs) Handles btnNextContact.Click
        ' Get the staff ID based on the current index
        Dim staffID As String = txtStaffID.Text.Trim()

        ' Get the contact details list for the staff ID
        Dim contactDetailsList As List(Of String) = GetListOfContactDetailsOfStaff(staffID)

        ' Increment the current index for contact details
        currentIndex += 1

        ' If the index exceeds the number of contact details, reset to the first contact
        If currentIndex >= contactDetailsList.Count Then
            currentIndex = 0
        End If

        ' Show the contact details based on the current index
        ShowContactDetails(contactDetailsList, currentIndex)
    End Sub

    Private Sub btnPreviousContact_Click(sender As Object, e As EventArgs) Handles btnPreviousContact.Click
        ' Get the staff ID based on the current index
        Dim staffID As String = txtStaffID.Text.Trim()

        ' Get the contact details list for the staff ID
        Dim contactDetailsList As List(Of String) = GetListOfContactDetailsOfStaff(staffID)

        ' Decrement the current index for contact details
        currentIndex -= 1

        ' If the index is less than zero, set it to the last contact
        If currentIndex < 0 Then
            currentIndex = contactDetailsList.Count - 1
        End If

        ' Show the contact details based on the current index
        ShowContactDetails(contactDetailsList, currentIndex)
    End Sub
End Class
