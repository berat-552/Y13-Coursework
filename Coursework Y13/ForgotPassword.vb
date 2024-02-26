Imports System.IO

Public Class ForgotPassword
    Private Users(100) As User
    Private numUser As Integer = 0
    Private Sub ForgotPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim file As StreamReader

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
                user.SecurityQuestion = parts(5)
                user.SecurityAnswer = parts(6)
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

    Private Sub btnGetSecurityQuestion_Click(sender As Object, e As EventArgs) Handles btnGetSecurityQuestion.Click

        'validate input fields
        If IsTextboxEmpty(txtUsername) Then
            MessageBox.Show("Please Provide a username to get a security question.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'Loop through each user in the array
        For Each user As User In Users
            If txtUsername.Text = user.Username Then
                'display security question to user
                lblSecurityQuestion.Text = $"Security Question: {user.SecurityQuestion}"
                Exit For ' Exit the loop once a match is found.
            Else
                MessageBox.Show("Incorrect Username", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        Next
    End Sub
    'accepts user as parameter
    Private Sub updatePasswordInTextFile(userToUpdate As User)
        'Read all lines from the file
        Dim lines As String() = File.ReadAllLines("AllUsers.txt")

        'Loop through each line and update the password if the username matches
        For i As Integer = 0 To lines.Length - 1
            Dim parts() As String = lines(i).Split(","c)
            'Check if comma separated values exist 
            If parts.Length > 0 AndAlso parts(2) = userToUpdate.Username Then
                'Update the password in the line
                parts(3) = userToUpdate.Password

                'Update the line in the array
                lines(i) = String.Join(",", parts)
                Exit For 'Exit the loop once a match is found
            End If
        Next

        'Write the updated lines back to the file
        File.WriteAllLines("AllUsers.txt", lines)
    End Sub

    Private Sub btnResetPassword_Click(sender As Object, e As EventArgs) Handles btnResetPassword.Click

        'validate input fields
        If IsTextboxEmpty(txtSecurityAnswer) Or IsTextboxEmpty(txtUsername) Then
            MessageBox.Show("Please Provide a username to start resetting password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'Loop through each user in the array
        For index As Integer = 0 To numUser - 1
            Dim user As User = Users(index)

            'Check if the security answer matches
            If txtSecurityAnswer.Text.ToLower() = user.SecurityAnswer AndAlso txtUsername.Text = user.Username Then
                'Prompt the user to enter a new password
                Dim newPassword As String = InputBox("Enter a new password:", "Password Reset")

                'Check if the user canceled or closed the InputBox
                If String.IsNullOrWhiteSpace(newPassword) Then
                    MessageBox.Show("Password reset cancelled.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return 'Exit the loop once the process is canceled
                End If

                'Update the user's password
                user.Password = newPassword

                'Update the password in the text file (pass user into function)
                updatePasswordInTextFile(user)

                MessageBox.Show("Password reset successful. You can now log in with your new password.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Close() 'close form after successful password reset
                Exit Sub 'Exit the loop once a match is found
            End If
        Next

        'If the loop completes without finding a match
        MessageBox.Show("Invalid username or security answer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class