Module UserModule
    'Declare public Structure for User
    Public Structure User
        Public UserId As Integer
        Public Name As String
        Public Username As String
        Public Password As String
        Public Type As String
        Public SecurityQuestion As String
        Public SecurityAnswer As String
    End Structure

    'Array to hold all users
    Public Users(0 To 20) As User

    'current user index
    Public numUser As Integer = 0

    'initialise string username variable
    Public username As String = ""
End Module
