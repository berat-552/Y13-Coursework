Public Class ViewProducts
    Private sortedAlphabetically As Boolean = False ' Initialize the flag
    Private originalProducts As List(Of Product) ' Store the original unsorted products
    Public updateID As Integer
    'accepts index parameter
    Private Function loadProductDetails(index As Integer)
        ' Update the textboxes with product details at the specified index
        txtItemID.Text = Products(index).ItemId
        txtProductName.Text = Products(index).FoodItem
        txtQuantityInStock.Text = Products(index).Quantity
        txtReOrderLevel.Text = Products(index).ReOrderLevel
        txtReOrderQuantity.Text = Products(index).ReOrderQuantity
        txtSupplier.Text = Products(index).Supplier
        txtSupplierPhoneNumber.Text = Products(index).SupplierPhoneNumber
        txtDescription.Text = Products(index).Description

        Return 0
    End Function
    Private Sub ViewProducts_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblSortType.Text = "Sorted: Default"

        ' Load products into originalProducts
        originalProducts = New List(Of Product)

        'Load products into Products array
        Dim file As IO.StreamReader
        Dim line As String
        Dim parts(0 To 7) As String

        file = My.Computer.FileSystem.OpenTextFileReader(Dir$("AllProducts.txt"))

        Do
            line = file.ReadLine()

            'splits each readline into parts and puts in array
            parts = line.Split(",")

            'Transfer data to Products Array
            ' Create a new Product instance and set its properties
            Dim product As New Product
            product.ItemId = Integer.Parse(parts(0))
            product.FoodItem = parts(1)
            product.Quantity = Integer.Parse(parts(2))
            product.ReOrderLevel = Integer.Parse(parts(3))
            product.ReOrderQuantity = Integer.Parse(parts(4))
            product.Supplier = parts(5)
            product.SupplierPhoneNumber = parts(6)
            product.Description = parts(7)

            ' Add the newProduct to the Products list
            originalProducts.Add(product)
            'increment count to point to next item
            NumProduct += 1

        Loop Until (file.EndOfStream)

        file.Close()

        'Reset count to 0 to prevent bug which stops cycle on next button
        NumProduct = 0

        ' Create a fresh copy of the original products to work with
        Products = New List(Of Product)(originalProducts)

        'Get details for first product at index 0
        loadProductDetails(0)
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        ' Check if there are more products to display
        If NumProduct < Products.Count - 1 Then
            ' Increment the count and load the next product details
            NumProduct += 1
            'load product with current value of numProduct
            loadProductDetails(NumProduct)

        Else
            ' Handle the case when there are no more products
            MessageBox.Show("No more products to display.")
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        ' Check if there's a previous product to display
        If NumProduct > 0 Then
            ' Decrement the count and load the previous product details
            NumProduct -= 1
            loadProductDetails(NumProduct)
        Else
            ' Handle the case when you're already at the first product
            MessageBox.Show("This is the first product.")
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close() 'Close form
    End Sub

    Private Sub btnSubmitChanges_Click(sender As Object, e As EventArgs) Handles btnSubmitChanges.Click
        'validate fields
        If IsTextboxEmpty(txtProductName) Or IsTextboxEmpty(txtItemID) Or IsTextboxEmpty(txtQuantityInStock) Or IsTextboxEmpty(txtReOrderLevel) Or IsTextboxEmpty(txtReOrderQuantity) Or IsTextboxEmpty(txtDescription) Or IsTextboxEmpty(txtSupplier) Or IsTextboxEmpty(txtSupplierPhoneNumber) Then
            MessageBox.Show("Please fill in all fields before attempting to submit changes.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If NumProduct >= 0 AndAlso NumProduct < Products.Count Then

            'Update the product's properties with the values from textboxes
            Dim updatedProduct As Product = Products(NumProduct)

            'Use Integer.TryParse to handle parsing errors
            If Integer.TryParse(txtItemID.Text, updatedProduct.ItemId) AndAlso
           Integer.TryParse(txtQuantityInStock.Text, updatedProduct.Quantity) AndAlso
           Integer.TryParse(txtReOrderLevel.Text, updatedProduct.ReOrderLevel) AndAlso
           Integer.TryParse(txtReOrderQuantity.Text, updatedProduct.ReOrderQuantity) Then
                'Only update the other properties if parsing succeeds
                updatedProduct.FoodItem = txtProductName.Text
                updatedProduct.Supplier = txtSupplier.Text
                updatedProduct.SupplierPhoneNumber = txtSupplierPhoneNumber.Text
                updatedProduct.Description = txtDescription.Text

                'Replace the old product with the updated product in the list
                Products(updateID) = updatedProduct

                'Sort the Products list based on ItemId after changes are applied 
                Products.Sort(Function(product1, product2) product1.ItemId.CompareTo(product2.ItemId))

                MessageBox.Show("Changes applied successfully, click Save to save changes.")
            Else
                MessageBox.Show("Please enter valid numeric values for Item ID, Quantity in Stock, Reorder Level, and Reorder Quantity.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("No product to apply changes to. Adding a new product...", "Product Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        sortedAlphabetically = False

    End Sub

    Private Sub btnSaveChanges_Click(sender As Object, e As EventArgs) Handles btnSaveChanges.Click

        If IsTextboxEmpty(txtProductName) Or IsTextboxEmpty(txtItemID) Or IsTextboxEmpty(txtQuantityInStock) Or IsTextboxEmpty(txtReOrderLevel) Or IsTextboxEmpty(txtReOrderQuantity) Or IsTextboxEmpty(txtDescription) Or IsTextboxEmpty(txtSupplier) Or IsTextboxEmpty(txtSupplierPhoneNumber) Then
            MessageBox.Show("Please fill in all fields before attempting to save changes.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If sortedAlphabetically Then
            MessageBox.Show("Products are sorted alphabetically. Changes not saved.", "Saving Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'Open the text file for writing
            Using file As New IO.StreamWriter("AllProducts.txt")
                For Each product As Product In Products
                    'Write each product's details back to the file
                    file.WriteLine($"{product.ItemId},{product.FoodItem},{product.Quantity},{product.ReOrderLevel},{product.ReOrderQuantity},{product.Supplier},{product.SupplierPhoneNumber},{product.Description}")
                Next
            End Using

            'Success message
            MessageBox.Show("Product changes saved successfully.")
        End If
    End Sub

    Private Sub btnSortAlphabetically_Click(sender As Object, e As EventArgs) Handles btnSortAlphabetically.Click

        If sortedAlphabetically Then
            'Revert to the original unsorted order
            Products = New List(Of Product)(originalProducts)
            sortedAlphabetically = False
            lblSortType.Text = "Sorted: Default"
            'Reset NumProduct to 0 when switching back to default sorting (avoid bugs)
            NumProduct = 0
        Else
            'Reset NumProduct to 0 when switching to alphabetical sorting (avoid bugs)
            NumProduct = 0
            BubbleSort(Products)
            sortedAlphabetically = True
            lblSortType.Text = "Sorted: A-Z"
        End If

        ' Load the product details for the first product in the current list
        loadProductDetails(0)

    End Sub

    Private Sub txtSearchProduct_TextChanged(sender As Object, e As EventArgs) Handles txtSearchProduct.TextChanged

        'Get the product name to search
        Dim productNameToSearch As String = txtSearchProduct.Text.Trim()

        'Perform binary search
        Dim index As Integer = BinarySearch(Products, productNameToSearch, sortedAlphabetically)

        updateID = index

        If sortedAlphabetically Then
            lblSortType.Text = "Sorted: A-Z"
        Else
            lblSortType.Text = "Sorted: Default"
        End If

        If index <> -1 Then
            'Product found, load its details
            loadProductDetails(index)
        Else
            'Product not found - empty textboxes
            txtProductName.Text = "N/A"
            txtItemID.Text = "N/A"
            txtQuantityInStock.Text = "N/A"
            txtReOrderLevel.Text = "N/A"
            txtReOrderQuantity.Text = "N/A"
            txtDescription.Text = "N/A"
            txtSupplier.Text = "N/A"
            txtSupplierPhoneNumber.Text = "N/A"
        End If
    End Sub
End Class