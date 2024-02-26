Public Class StaffMenu
    Private Sub StaffMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUsername.Text = username
    End Sub

    Private Sub btnShowStockControl_Click(sender As Object, e As EventArgs) Handles btnShowStockControl.Click
        StockControlMenu.Show()
    End Sub

    Private Sub btnShowMakeOrderForm_Click(sender As Object, e As EventArgs) Handles btnShowMakeOrderForm.Click
        MakeOrder.Show()
    End Sub
End Class