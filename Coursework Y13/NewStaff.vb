Imports System.IO
Public Class NewStaff

    Private Sub NewStaff_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Add titles to combo box on Load Event
        comTitle.Items.Add("Mr")
        comTitle.Items.Add("Mrs")
        comTitle.Items.Add("Miss")
        comTitle.Items.Add("Ms")

        ' Set the initial Staff ID
        Dim maxID As Integer = GetMaxID("AllStaff.txt")
        txtStaffID.Text = maxID + 1
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Declare variable of Staff structure
        Dim NewStaff As Staff

        'Validate all fields
        'Will display error message even if one textbox is empty
        If IsTextboxEmpty(txtStaffID) Or IsTextboxEmpty(txtFirstName) Or IsTextboxEmpty(txtSurname) Or IsTextboxEmpty(txtTown) Or IsTextboxEmpty(txtStreet) Or
           IsTextboxEmpty(txtPostcode) Then
            MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'Validate combo box
        If comTitle.Text = "" Then
            MessageBox.Show("Please select title", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Validate for valid postcode
        If txtPostcode.Text.Length < 7 Then
            MessageBox.Show("Please enter a valid postcode", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'Transfer data from textboxes into NewStaff
        NewStaff.StaffId = txtStaffID.Text
        NewStaff.FirstName = txtFirstName.Text
        NewStaff.Surname = txtSurname.Text
        NewStaff.Title = comTitle.Text
        NewStaff.Town = txtTown.Text
        NewStaff.Street = txtStreet.Text
        NewStaff.Postcode = txtPostcode.Text.ToUpper() 'Capitalise postcode
        NewStaff.NationalInsurance = txtNationalInsurance.Text.ToUpper()

        'Append staff data to AllStaff.txt
        Dim newStf As StreamWriter
        newStf = My.Computer.FileSystem.OpenTextFileWriter(Dir$("AllStaff.txt"), True)
        newStf.WriteLine($"{NewStaff.StaffId},{NewStaff.FirstName},{NewStaff.Surname},{NewStaff.Title},{NewStaff.Town},{NewStaff.Street},{NewStaff.Postcode},{NewStaff.NationalInsurance}")

        'Close textfile
        newStf.Close()

        'Display success message
        MessageBox.Show("New Staff Member '" & NewStaff.FirstName & " " & NewStaff.Surname & "' has been saved")

        'Reset input fields on save
        ClearInputFields(Me)

        'Get new incremented id based on the maxID found in textfile + 1
        Dim maxID As Integer = GetMaxID("AllStaff.txt")
        txtStaffID.Text = maxID + 1

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearInputFields(Me)
        'Call the ID function to prevent staffID textbox from being cleared
        Dim maxID As Integer = GetMaxID("AllStaff.txt")
        txtStaffID.Text = maxID + 1
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Close form
        Close()
    End Sub

    Private Sub btnAddContacts_Click(sender As Object, e As EventArgs) Handles btnAddContacts.Click
        'Create an instance of the NewContact form
        Dim newContactForm As New NewContact()

        'Display the NewContact form
        newContactForm.Show()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        EditStaff.Show() 'show edit staff form
    End Sub
End Class