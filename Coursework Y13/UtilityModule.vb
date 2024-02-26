Imports System.IO

Module UtilityModule

    '##### RE-USABLE CODE #####

    'Accepts the current Form as parameter to clear input fields
    Public Sub ClearInputFields(form As Form)
        For Each control As Control In form.Controls
            If TypeOf control Is TextBox Then
                DirectCast(control, TextBox).Text = String.Empty
            ElseIf TypeOf control Is ComboBox Then
                DirectCast(control, ComboBox).Text = String.Empty
            End If
        Next
    End Sub

    'Function that handles validation, accepts a textbox parameter
    Public Function IsTextboxEmpty(textbox As TextBox) As Boolean
        Return String.IsNullOrWhiteSpace(textbox.Text) 'Returns a boolean value - true/false (true if textbox is empty)
    End Function

    'Gets Max Id within a textfile, filename is accepted as parameter
    Public Function GetMaxID(filename As String) As Integer
        Dim maxID As Integer = 0

        'Check if the file exists
        If File.Exists(filename) Then
            ' Read all lines from the text file
            Dim lines As String() = File.ReadAllLines(filename)

            'Loop through the lines and find the maximum ID
            For Each line As String In lines
                Dim parts As String() = line.Split(","c)
                If parts.Length > 0 Then 'checks if there are elements in the parts array. handles errors in case the line is empty or does not contain data.
                    Dim id As Integer
                    If Integer.TryParse(parts(0), id) Then
                        If id > maxID Then
                            maxID = id
                        End If
                    End If
                End If
            Next
        End If
        'return value to use
        Return maxID
    End Function

    Public Function GetAllStaffNames() As List(Of String)
        'Declare new dynamic list that can grow dynamically
        Dim staffNames As New List(Of String)

        'Read the lines from the text file
        Dim lines() As String = File.ReadAllLines("AllStaff.txt")

        'Process each line to extract staff IDs
        For Each line As String In lines
            Dim parts() As String = line.Split(","c)

            'Ensure there are enough parts and that the first part (index 0) is a valid string
            If parts.Length > 2 Then
                Dim firstName As String = parts(1).Trim() ' Remove leading/trailing spaces
                Dim lastName As String = parts(2).Trim() ' Remove leading/trailing spaces
                Dim fullName As String = firstName & " " & lastName 'concatenate first name and last name
                staffNames.Add(fullName)
            End If
        Next

        Return staffNames
    End Function

    '#### Separate logic of quick sort into 3 functions (Swap, Partition and QuickSort) ####
    Public Function QuickSort(unsortedArray As List(Of String), start As Integer, last As Integer) As List(Of String)
        'Check if there are elements to sort
        If start < last Then
            'Partition the array and get the pivot position
            Dim PivotPosition As Integer = Partition(unsortedArray, start, last)

            'Recursively sort the two sub-arrays
            QuickSort(unsortedArray, start, PivotPosition - 1)
            QuickSort(unsortedArray, PivotPosition + 1, last)
        End If

        'Return the sorted array (sorted if it reached this point)
        Return unsortedArray
    End Function

    Public Function Partition(arr As List(Of String), start As Integer, last As Integer) As Integer
        'Choose the last element as the pivot
        Dim Pivot As String = arr(last)
        'Initialize the index of the smaller element
        Dim i As Integer = start - 1

        'Traverse the array
        For j As Integer = start To last - 1
            'If the current element is smaller than or equal to the pivot
            If String.Compare(arr(j), Pivot) <= 0 Then
                'Swap elements at i and j
                i += 1
                Swap(arr, i, j)
            End If
        Next

        'Swap the pivot element with the element at (i + 1)
        Swap(arr, i + 1, last)
        'Return the position of the pivot element
        Return i + 1
    End Function

    Public Sub Swap(arr As List(Of String), index1 As Integer, index2 As Integer)
        'Swap elements at index1 and index2
        Dim temp As String = arr(index1)
        arr(index1) = arr(index2)
        arr(index2) = temp
    End Sub
    '###################

    'Custom bubble sort function for sorting Products by FoodItem
    Public Sub BubbleSort(Products As List(Of Product))
        'Get the number of products in the list
        Dim n As Integer = Products.Count

        'Outer loop: Traverse through each element in the list
        For i As Integer = 0 To n - 2

            'Inner loop: Compare adjacent elements and swap if necessary
            For j As Integer = 0 To n - i - 2
                'Compare the FoodItem property of adjacent products
                If String.Compare(Products(j).FoodItem, Products(j + 1).FoodItem) > 0 Then
                    'Swap Products(j) and Products(j + 1)
                    Dim temp As Product = Products(j)
                    Products(j) = Products(j + 1)
                    Products(j + 1) = temp
                End If
            Next
        Next
    End Sub

    'Custom binary search function for searching Products by FoodItem
    'Pass boolean by reference to modify the variable value
    Public Function BinarySearch(Products As List(Of Product), productName As String, ByRef sortedAlphabetically As Boolean) As Integer
        'Ensure the list is sorted alphabetically before performing binary search
        If Not sortedAlphabetically Then
            BubbleSort(Products)
            sortedAlphabetically = True
        End If

        'Binary search implementation
        Dim left As Integer = 0
        Dim right As Integer = Products.Count - 1

        While left <= right
            Dim mid As Integer = left + (right - left) \ 2
            'compare two strings - the midpoint and user's search (case insensitive)
            Dim comparisonResult As Integer = String.Compare(Products(mid).FoodItem.ToLower(), productName.ToLower())

            If comparisonResult = 0 Then
                'Product found
                Return mid
            ElseIf comparisonResult < 0 Then
                'Search in the right half
                left = mid + 1
            Else
                'Search in the left half
                right = mid - 1
            End If
        End While

        'Product not found
        Return -1
    End Function


    'function to get all contact ids from the file
    Public Function GetAllContactIds() As List(Of String)
        'Read all staff details from the file
        Dim allStaffDetails As List(Of String) = File.ReadAllLines("AllContacts.txt").ToList()

        'Extract and return the staff ids at index 0
        Return allStaffDetails.Select(Function(line) line.Split(","c)(0)).ToList()
    End Function

    Public Function GetStaffName(contactId As String) As String
        'Read all user details from the file
        Dim allUserDetails As List(Of String) = File.ReadAllLines("AllStaff.txt").ToList()

        'Find the details for the selected contact ID
        Dim userDetails As String = allUserDetails.Find(Function(line) line.StartsWith(contactId))

        'Check if user details were found
        If userDetails IsNot Nothing Then
            'Split the details into individual fields (assuming comma-separated values)
            Dim detailsArray As String() = userDetails.Split(","c)

            'concatenate name
            Dim staffName As String = $"{detailsArray(1).Trim()} {detailsArray(2).Trim()}"

            'Return the name
            Return staffName
        Else
            'Handle the case where user details were not found
            Return "Staff details not found"
        End If
    End Function

    'function to get all product names from the file
    Public Function GetAllProductNames() As List(Of String)
        'Read all staff details from the file
        Dim allProducts As List(Of String) = File.ReadAllLines("AllProducts.txt").ToList()

        'Extract and return the product names
        Return allProducts.Select(Function(line) line.Split(","c)(1)).ToList()
    End Function
End Module
