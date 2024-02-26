Imports System.IO

Public Class AddNewStock

    Private Sub AddNewStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim allProductNames = GetAllProductNames()

        'load all product names into combo box
        For Each product In allProductNames
            comProductName.Items.Add(product)
        Next
    End Sub

    Private Sub comProductName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comProductName.SelectedIndexChanged
        'Check if a product name is selected
        If comProductName.SelectedIndex <> -1 Then
            'Get the selected product name
            Dim selectedProductName As String = comProductName.SelectedItem.ToString()

            'Read all product details from the file
            Dim allProductDetails As List(Of String) = File.ReadAllLines("AllProducts.txt").ToList()

            'Find the details for the selected product name
            Dim productDetails As String = allProductDetails.Find(Function(line) line.Contains(selectedProductName))

            'Check if product details were found
            If productDetails IsNot Nothing Then
                'Split the details into individual fields
                Dim detailsArray As String() = productDetails.Split(","c)

                'Display the current quantity and item id in textboxes
                txtCurrentQuantity.Text = detailsArray(2).Trim()
                txtProductID.Text = detailsArray(0).Trim()
            Else
                'Handle the case where product details were not found
                MessageBox.Show("Product details not found for selected name.")
            End If
        End If
    End Sub

    Private Sub btnUpdateStock_Click(sender As Object, e As EventArgs) Handles btnUpdateStock.Click

        If IsTextboxEmpty(txtProductID) Or IsTextboxEmpty(txtCurrentQuantity) Or IsTextboxEmpty(txtNewQuantity) Then
            MessageBox.Show("Please fill in all fields before attempting to add new stock.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'Check if a product name is selected
        If comProductName.SelectedIndex <> -1 Then
            'Get the selected product name
            Dim selectedProductName As String = comProductName.SelectedItem.ToString()

            'Read all product details from the file
            Dim allProductDetails As List(Of String) = File.ReadAllLines("AllProducts.txt").ToList()

            'Find the index of the line with the selected product name
            Dim productIndex As Integer = allProductDetails.FindIndex(Function(line) line.Contains(selectedProductName))

            'Check if product details were found
            If productIndex <> -1 Then
                'Update the quantity for the selected product
                Dim newStockQuantity As Integer
                If Integer.TryParse(txtNewQuantity.Text, newStockQuantity) Then
                    'Update quantity at index 2 in the detailsArray
                    Dim detailsArray As String() = allProductDetails(productIndex).Split(","c)
                    detailsArray(2) = newStockQuantity.ToString()

                    'Join the details back into a comma-separated string
                    allProductDetails(productIndex) = String.Join(",", detailsArray)

                    'Write the updated details back to the file
                    File.WriteAllLines("AllProducts.txt", allProductDetails)

                    'Provide feedback to the user
                    MessageBox.Show($"Stock quantity for '{selectedProductName}' updated successfully!")

                    'update current quantity box to display new quantity
                    txtCurrentQuantity.Text = detailsArray(2)
                    txtNewQuantity.Text = ""
                Else
                    MessageBox.Show("Please enter a valid quantity, value must be an integer", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Else
                'Handle the case where product details were not found
                MessageBox.Show("Product details not found for the selected name.")
            End If
        End If
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close()
    End Sub
End Class