Imports System.IO

Public Class MakeOrder
    'List to hold all products
    Private allProducts As List(Of Product)
    Dim totalPrice As Double = 0.0

    'Function to find a product by name in the list of products
    Private Function FindProductByName(productName As String)
        'Search for the product with the specified name in the list of products
        For Each product In allProducts
            If product.FoodItem = productName Then
                'Return the found product
                Return product
            End If
        Next

        'If no matching product is found, return Nothing
        Return Nothing
    End Function

    Private Sub MakeOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim allProductNames = GetAllProductNames()

        'load all product names into combo box
        For Each product In allProductNames
            comFoodItems.Items.Add(product)
        Next

        'default quantity
        numericUpDownQuantity.Value = 1

        'load products into list
        allProducts = LoadAllProducts()
    End Sub

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        If comFoodItems.Text = "" Then
            MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'validation - minimum quantity = 1, value must be integer
        If numericUpDownQuantity.Value < 1 Or Not Integer.TryParse(numericUpDownQuantity.Value.ToString(), Nothing) Then
            MessageBox.Show("Please enter a valid quantity", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'Get the selected product name from the combo box
        Dim selectedProduct = comFoodItems.SelectedItem.ToString()
        'Check if a product is selected
        If Not String.IsNullOrEmpty(selectedProduct) Then
            'Find the selected product in the list
            Dim productDetails = FindProductByName(selectedProduct)

            'Check if the product was found
            If productDetails IsNot Nothing Then
                'Check if there is enough stock for the requested quantity
                If productDetails.Quantity >= numericUpDownQuantity.Value Then

                    Dim productTotalPrice As Double = productDetails.Price * numericUpDownQuantity.Value

                    totalPrice += productTotalPrice

                    txtTotal.Text = totalPrice.ToString("C")

                    'Add product details to the rich text box
                    Dim productInfo = $"{productDetails.FoodItem},{numericUpDownQuantity.Value * productDetails.Price:C},(Quantity: {numericUpDownQuantity.Value})"
                    richTxtOrderItems.AppendText(productInfo & vbCrLf) ' Insert product info and new line
                Else
                    MessageBox.Show($"Insufficient stock for {productDetails.FoodItem}. Available quantity: {productDetails.Quantity}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                MessageBox.Show("Selected product not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub


    Private Sub btnSendOrder_Click(sender As Object, e As EventArgs) Handles btnSendOrder.Click

        'Prompt user to enter table number
        Dim tableNumber = InputBox("Please enter table number")

        If String.IsNullOrWhiteSpace(tableNumber) Then
            MessageBox.Show("Please enter table number to proceed with order", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'Check if there are items in the order
        If richTxtOrderItems.Lines.Length = 0 Then
            MessageBox.Show("No items in the order.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim orderDate As Date = Date.Now

        'Read all lines from the AllProducts.txt file
        Dim allProductLines As String() = File.ReadAllLines("AllProducts.txt")

        'Loop through each line in rich text box
        For Each line As String In richTxtOrderItems.Lines
            'Split the line into product name and quantity
            Dim parts() As String = line.Split(",")
            If parts.Length = 2 Then
                'Trim spaces and get product name and quantity
                Dim productName As String = parts(0).Trim()
                Dim quantity As Integer = 0

                'Try to parse the quantity
                If Integer.TryParse(parts(1).Trim(), quantity) Then
                    'Find the line in the AllProducts.txt file that contains the product name
                    Dim productLine As String = allProductLines.FirstOrDefault(Function(pl) pl.Contains(productName & ","))

                    'Update the quantity if the product is found
                    If productLine IsNot Nothing Then
                        'Split the line into values
                        Dim values() As String = productLine.Split(",")

                        'Get the existing quantity from the third value in the line
                        Dim existingQuantity As Integer = 0
                        If Integer.TryParse(values(2).Trim(), existingQuantity) Then
                            'Calculate the new quantity
                            Dim newQuantity As Integer = existingQuantity - quantity

                            'Update the quantity in the line
                            values(2) = newQuantity.ToString()

                            'Join the values back into a line
                            allProductLines(allProductLines.ToList().IndexOf(productLine)) = String.Join(",", values)
                        End If
                    Else
                        MessageBox.Show($"Product not found: {productName}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Else
                    MessageBox.Show($"Invalid quantity for product: {productName}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Next

        'Create a SaveFileDialog to prompt the user for the file location and name
        Using saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
            saveFileDialog.DefaultExt = "txt"
            saveFileDialog.Title = "Save Order Details"
            saveFileDialog.FileName = $"Order-Table-{tableNumber}.txt"

            'Show the SaveFileDialog to the user
            If saveFileDialog.ShowDialog() = DialogResult.OK Then
                'Open or create the selected file for writing
                Using writer As New StreamWriter(saveFileDialog.FileName, True)
                    'Write order details to the file
                    writer.WriteLine($"Order Date: {orderDate}")
                    writer.WriteLine($"Table Number: {tableNumber}")
                    writer.WriteLine($"Total: {totalPrice:C}")
                    writer.WriteLine("Ordered Items:")
                    For Each line As String In richTxtOrderItems.Lines
                        writer.WriteLine($"- {line}")
                    Next
                    writer.WriteLine("-----")
                End Using

                'Write the updated lines back to the AllProducts.txt file
                File.WriteAllLines("AllProducts.txt", allProductLines)

                'Notify the user that the order details have been saved
                MessageBox.Show($"Order details saved to {saveFileDialog.FileName}", "Order Saved", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                'handle cancellation of saving text file
                MessageBox.Show($"Order cancelled by user", "Order Cancellation", MessageBoxButtons.OK, MessageBoxIcon.Error)
                richTxtOrderItems.Clear()
                Return
            End If
        End Using

        'Clear the rich text box after processing the order
        richTxtOrderItems.Clear()
        txtTotal.Text = ""

        'reload the products into the allProducts list to retrieve the latest data
        allProducts = LoadAllProducts()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearInputFields(Me)
        richTxtOrderItems.Clear()
        numericUpDownQuantity.Value = 1
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Close()
    End Sub
End Class