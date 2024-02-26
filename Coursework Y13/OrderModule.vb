Imports System.IO

Module OrderModule

    Public Structure Order
        Public OrderId As Integer
        Public TableNumber As Integer
        Public Price As Double
        Public OrderDate As Integer
    End Structure

    Public Structure OrderItems
        Public Order_ItemId As Integer
        Public ItemId As Integer 'foreign key
        Public StockId As Integer 'foreign key
        Public OrderId As Integer 'foreign key
    End Structure

    'Function to load all products from the text file
    Public Function LoadAllProducts()
        'Read all product details from the file
        Dim allProducts As List(Of String) = File.ReadAllLines("AllProducts.txt").ToList()

        'Create a list to store Product instances
        Dim productList As New List(Of Product)

        'Iterate through each line in allProducts and create Product instances
        For Each line As String In allProducts
            Dim parts As String() = line.Split(","c)

            'Create a new Product instance and initialize its fields
            Dim product As New Product With {
            .ItemId = Integer.Parse(parts(0)),
            .FoodItem = parts(1),
            .Quantity = Integer.Parse(parts(2)),
            .ReOrderLevel = Integer.Parse(parts(3)),
            .ReOrderQuantity = Integer.Parse(parts(4)),
            .Supplier = parts(5),
            .SupplierPhoneNumber = parts(6),
            .Description = parts(7),
            .Price = parts(8)
        }

            'Add the new Product to the list
            productList.Add(product)
        Next

        'Return the list of Product instances
        Return productList
    End Function

End Module
