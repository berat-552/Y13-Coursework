Public Class StockControlMenu
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Close() 'Close form
    End Sub

    Private Sub btnEnterProduct_Click(sender As Object, e As EventArgs) Handles btnEnterProduct.Click
        NewProduct.Show() 'Open New Product form
    End Sub

    Private Sub btnAllProducts_Click(sender As Object, e As EventArgs) Handles btnAllProducts.Click
        ViewProducts.Show() 'Open View Products form
    End Sub

    Private Sub btnCreateReOrderList_Click(sender As Object, e As EventArgs) Handles btnCreateReOrderList.Click
        'Display a confirmation dialog
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to create a reorder list?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        'Check the user's response, if it's Yes, invoke the create re-order-list function
        If result = DialogResult.Yes Then
            createReOrderList()

        Else
            'Exit subroutine
            MessageBox.Show("Cancelled creation of re-order list", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If
    End Sub

    Private Sub btnAddNewStockbtnAddNewStockbtnAddNewStock_Click(sender As Object, e As EventArgs) Handles btnAddNewStockbtnAddNewStockbtnAddNewStock.Click
        AddNewStock.Show() 'open add new stock form
    End Sub
End Class