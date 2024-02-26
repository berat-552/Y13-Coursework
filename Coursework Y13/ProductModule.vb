Imports System.IO

Module ProductModule
    'Declare public structure for Product
    Public Structure Product
        Public ItemId As Integer
        Public FoodItem As String
        Public Quantity As Integer
        Public ReOrderLevel As Integer
        Public ReOrderQuantity As Integer
        Public Supplier As String
        Public SupplierPhoneNumber As String
        Public Description As String
        Public Price As Double
    End Structure

    'Declare List to hold Products
    Public Products As New List(Of Product)

    'Used to point to current product in array
    Public NumProduct As Integer = 0

    Public Sub createReOrderList()
        'Read all lines from the file
        Dim allLines As String() = File.ReadAllLines("AllProducts.txt")
        Dim productsToReOrder As New List(Of String)()

        'Process each line
        For Each line As String In allLines
            'Split the line into fields using comma as the delimiter
            Dim fields As String() = line.Split(","c)

            'Parse relevant data
            Dim itemId As Integer = Integer.Parse(fields(0))
            Dim productName As String = fields(1)
            Dim quantityInStock As Integer = Integer.Parse(fields(2))
            Dim reorderLevel As Integer = Integer.Parse(fields(3))
            Dim reorderQuantity As Integer = Integer.Parse(fields(4))
            Dim supplier As String = fields(5)
            Dim supplierPhoneNumber As String = fields(6)

            'Compare quantity with reorder level
            If quantityInStock < reorderLevel Then
                'Add product details to the list
                productsToReOrder.Add($"Product Name: {productName}, Reorder Quantity: {reorderQuantity}, Supplier: {supplier}, Supplier Phone: {supplierPhoneNumber}")
                productsToReOrder.Add("") 'add empty line in between
            End If
        Next

        'If there is sufficient stock cancel creation of re-order list
        If productsToReOrder.Count = 0 Then
            MessageBox.Show("No products to re-order, sufficient stock!", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim currentDate As String = Date.Now.ToString("yyyy-MM-dd")

        Dim saveFileDialog As New SaveFileDialog With {
            .Title = $"Create Re-Order-List",
            .Filter = "Text Files|*.txt|All Files|*.*",
            .FileName = $"ReOrderList-{currentDate}"
        }

        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            'Write the list of products to be re-ordered to file
            File.WriteAllLines(saveFileDialog.FileName, productsToReOrder)

            MessageBox.Show("Re-Order-List created successfully", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            'handle cancellation
            MessageBox.Show("Cancelled creation of Re-Order-List", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
    End Sub
End Module
