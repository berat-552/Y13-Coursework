Imports System.IO

Public Class EditStaff
    'function to get all staff names from the file
    Private Function GetAllStaffIds() As List(Of String)
        'Read all staff details from the file
        Dim allStaffDetails As List(Of String) = File.ReadAllLines("AllStaff.txt").ToList()

        'Extract and return the staff ids
        Return allStaffDetails.Select(Function(line) line.Split(","c)(0)).ToList()
    End Function

    Private Function GetAllStaffNames() As List(Of String)
        'Read all staff details from the file
        Dim allStaffDetails As List(Of String) = File.ReadAllLines("AllStaff.txt").ToList()

        'Extract and return the concatenated staff names
        Return allStaffDetails.Select(Function(line) $"{line.Split(","c)(1)} {line.Split(","c)(2)}").ToList()
    End Function

    Private Sub EditStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Add titles to combo box on Load Event
        comTitle.Items.Add("Mr")
        comTitle.Items.Add("Mrs")
        comTitle.Items.Add("Miss")
        comTitle.Items.Add("Ms")

        Dim allStaffIds = GetAllStaffIds()
        Dim allStaffNames = GetAllStaffNames()
        'Use a single loop to iterate through the lists in parallel
        For i As Integer = 0 To Math.Min(allStaffIds.Count - 1, allStaffNames.Count - 1)
            comStaffId.Items.Add($"{allStaffIds(i)}-{allStaffNames(i)}")
        Next
    End Sub

    Private Sub comStaffName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comStaffId.SelectedIndexChanged

        'Check if a staff id is selected
        If comStaffId.SelectedIndex <> -1 Then
            'Get the selected staff Id and split it at the "-" character
            Dim selectedStaffIDParts As String() = comStaffId.SelectedItem.ToString().Split("-"c)

            'Check if the split was successful and has at least two parts
            If selectedStaffIDParts.Length >= 2 Then

                Dim selectedStaffID As String = selectedStaffIDParts(0).Trim()

                'Read all staff details from the file
                Dim allStaffDetails As List(Of String) = File.ReadAllLines("AllStaff.txt").ToList()

                'Find the details for the selected staff name
                Dim staffDetails As String = allStaffDetails.Find(Function(line) line.StartsWith(selectedStaffID))

                'Check if staff details were found
                If staffDetails IsNot Nothing Then
                    'Split the details into individual fields 
                    Dim detailsArray As String() = staffDetails.Split(","c)

                    'Populate the textboxes with the corresponding details
                    txtFirstName.Text = detailsArray(1).Trim()
                    txtSurname.Text = detailsArray(2).Trim()
                    comTitle.Text = detailsArray(3).Trim()

                    txtTown.Text = detailsArray(4).Trim()
                    txtStreet.Text = detailsArray(5).Trim()
                    txtPostcode.Text = detailsArray(6).Trim()
                    txtNationalInsurance.Text = detailsArray(7).Trim()
                Else
                    'Handle the case where staff details were not found
                    MessageBox.Show("Staff details not found for selected name.")
                    Return
                End If
            Else
                'Handle the case where the split was not successful
                MessageBox.Show("Invalid format for selected staff ID.")
            End If
        End If
    End Sub

    Private Sub btnUpdateStaffDetails_Click(sender As Object, e As EventArgs) Handles btnUpdateStaffDetails.Click

        'Validate input fields
        If IsTextboxEmpty(txtFirstName) Or IsTextboxEmpty(txtSurname) Or IsTextboxEmpty(txtStreet) Or IsTextboxEmpty(txtPostcode) Or IsTextboxEmpty(txtTown) Then
            MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If comStaffId.Text = "" Then
            MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        'Check if a staff id is selected
        If comStaffId.SelectedIndex <> -1 Then
            'Get the selected staff id
            Dim selectedStaffId As String = comStaffId.SelectedItem.ToString()

            'Split the selected item using the "-" character
            Dim parts As String() = selectedStaffId.Split("-"c)

            'Access first element which is the ID (selectedItem split = ID - Name)
            'Trim empty spaces
            selectedStaffId = parts(0).Trim()

            'Read all staff details from the file
            Dim allStaffDetails As List(Of String) = File.ReadAllLines("AllStaff.txt").ToList()

            'Find the index of the line with the selected staff name
            Dim staffIndex As Integer = allStaffDetails.FindIndex(Function(line) line.StartsWith(selectedStaffId))

            'Check if staff details were found
            If staffIndex <> -1 Then
                'Update the details for the selected staff
                allStaffDetails(staffIndex) = $"{selectedStaffId},{txtFirstName.Text},{txtSurname.Text},{comTitle.Text},{txtTown.Text},{txtStreet.Text},{txtPostcode.Text},{txtNationalInsurance.Text}"

                'Write the updated details back to the file
                File.WriteAllLines("AllStaff.txt", allStaffDetails)

                'Provide feedback to the user
                MessageBox.Show("Staff details updated successfully.")
            Else
                'Handle the case where staff details were not found
                MessageBox.Show("Staff details not found for selected name.")
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class