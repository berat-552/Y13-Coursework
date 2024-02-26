Public Class NewProduct
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Declare variable of Product structure
        Dim NewProduct As Product

        'Validate fields
        If IsTextboxEmpty(txtItemID) Or IsTextboxEmpty(txtProductName) Or IsTextboxEmpty(txtQuantityInStock) Or IsTextboxEmpty(txtDescription) Then
            MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'validate phone number
        If txtSupplierPhoneNumber.Text.Length <> 11 Then
            MessageBox.Show("Phone number must be 11 characters.", "Phone Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'Transfer data to Product Structure
        NewProduct.ItemId = txtItemID.Text
        'Capitalise first letter of food item
        NewProduct.FoodItem = txtProductName.Text.Substring(0, 1).ToUpper() + txtProductName.Text.Substring(1)
        NewProduct.Quantity = txtQuantityInStock.Text
        NewProduct.ReOrderLevel = txtReOrderLevel.Text
        NewProduct.ReOrderQuantity = txtReOrderQuantity.Text
        'Capitalise first letter of supplier name item
        NewProduct.Supplier = txtSupplier.Text.Substring(0, 1).ToUpper() + txtSupplier.Text.Substring(1)
        NewProduct.SupplierPhoneNumber = txtSupplierPhoneNumber.Text
        NewProduct.Description = txtDescription.Text

        'Append data to AllProducts.txt
        Dim newItem As IO.StreamWriter
        newItem = My.Computer.FileSystem.OpenTextFileWriter(Dir$("AllProducts.txt"), True)
        newItem.WriteLine(NewProduct.ItemId & "," & NewProduct.FoodItem & "," & NewProduct.Quantity & "," & NewProduct.ReOrderLevel & "," & NewProduct.ReOrderQuantity & "," & NewProduct.Supplier & "," & NewProduct.SupplierPhoneNumber & "," & NewProduct.Description)

        'Close textfile
        newItem.Close()

        'Display success message
        MessageBox.Show("New Product '" & NewProduct.FoodItem & "' has been saved")

        'Reset input fields on save
        ClearInputFields(Me)

        'Generate new Id in textbox
        Dim maxID As Integer = GetMaxID("AllProducts.txt")
        txtItemID.Text = maxID + 1

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ClearInputFields(Me) 'Clear input fields
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close() 'Close the form
    End Sub

    'Load Id on Load event
    Private Sub NewProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the initial Item ID
        Dim maxID As Integer = GetMaxID("AllProducts.txt")
        txtItemID.Text = maxID + 1
    End Sub
End Class