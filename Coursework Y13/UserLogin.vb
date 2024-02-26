Public Class UserLogin
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        'Validate input fields
        If IsTextboxEmpty(txtUsername) Or IsTextboxEmpty(txtPassword) Then
            MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim found As Boolean = False

        'Loop through each user in the array
        For Each user As User In Users
            If txtUsername.Text = user.Username And txtPassword.Text = user.Password Then
                MessageBox.Show("Logged in as: " & user.Name, "Success", MessageBoxButtons.OK)
                found = True
                username = user.Name + " - " + user.Type 'move username to Users module
                If user.Type = "Admin" Then
                    Menu.Show() 'Open main Menu Form
                ElseIf user.Type = "Staff" Then
                    username = user.Name + " - " + user.Type
                    StaffMenu.Show() 'show staff menu for regular staff members
                End If
                Exit For ' Exit the loop once a match is found.
            End If
        Next

        'if user is not found display error message
        If Not found Then
            MessageBox.Show("Invalid Username or Password", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ClearInputFields(Me) 'Reset input fields
            Return
        End If
    End Sub

    Private Sub UserLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim file As IO.StreamReader

        ' File to read
        file = My.Computer.FileSystem.OpenTextFileReader(Dir$("AllUsers.txt"))

        'Continue looping until end of file
        While Not file.EndOfStream
            Dim line As String = file.ReadLine()
            Dim parts() As String = line.Split(","c)

            If parts.Length > 0 Then
                Dim user As New User()
                user.UserId = parts(0)
                user.Name = parts(1)
                user.Username = parts(2)
                user.Password = parts(3)
                user.Type = parts(4)

                'Add the user to the Users array.
                Users(numUser) = user
                'increment count to point to next user
                numUser += 1
            End If
        End While

        file.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearInputFields(Me)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close() 'Close form
    End Sub

    Private Sub LinkForgotPassword_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkForgotPassword.LinkClicked
        ForgotPassword.Show() 'show forgot password form
    End Sub
End Class

