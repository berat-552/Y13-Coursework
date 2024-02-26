Public Class Menu
    Private Sub btnShowNewStaffForm_Click(sender As Object, e As EventArgs) Handles btnShowNewStaffForm.Click
        'Open New Staff Form
        NewStaff.Show()
    End Sub

    Private Sub btnShowAddContactsForm_Click(sender As Object, e As EventArgs) Handles btnShowAddContactsForm.Click
        'Open New Contacts Form
        NewContact.Show()
    End Sub

    Private Sub btnShowStockControl_Click(sender As Object, e As EventArgs) Handles btnShowStockControl.Click
        StockControlMenu.Show() 'Open Stock Control Menu form
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Display the name of logged user
        lblUsername.Text = username
    End Sub

    Private Sub btnShowPayrollForm_Click(sender As Object, e As EventArgs) Handles btnShowPayrollForm.Click
        Payroll.Show() 'Open Payroll form
    End Sub

    Private Sub btnShowEditStaffDetailsForm_Click(sender As Object, e As EventArgs) Handles btnShowEditStaffDetailsForm.Click
        EditStaff.Show() 'Open Edit Staff Details Form
    End Sub

    Private Sub btnShowEditContactDetailsForm_Click(sender As Object, e As EventArgs) Handles btnShowEditContactDetailsForm.Click
        EditContact.Show() 'Open Edit Contact Details Form
    End Sub

    Private Sub btnShowSearchStaffMembersForm_Click(sender As Object, e As EventArgs) Handles btnShowSearchStaffMembersForm.Click
        SearchStaff.Show() 'Open Search Staff Form
    End Sub

    Private Sub btnShowMakeOrderForm_Click(sender As Object, e As EventArgs) Handles btnShowMakeOrderForm.Click
        MakeOrder.Show()
    End Sub
End Class