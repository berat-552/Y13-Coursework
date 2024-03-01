Imports System.IO
Public Class Payroll
    'Declare constant for tax allowance
    Const TaxAllowanceMonth = 12570 / 12
    Const NIAllowanceMonth = (242 * 52) / 12
    Const NIRate As Double = 0.138

    Private Sub Payroll_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Store return data of function in allStaffNames variable
        Dim allStaffNames = GetAllStaffNames()
        'Sort the staffnames using a recursive quick-sort algorithm
        Dim sortedStaffNames = QuickSort(allStaffNames, 0, allStaffNames.Count - 1)

        'Add sorted staff names to the combo box on load event
        comName.Items.AddRange(sortedStaffNames.ToArray())
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim selectedEmployee As String = comName.SelectedItem()
        Dim totalHoursWorked As Double
        Dim hourlyRate As Double = 10.5
        Dim Tax As Double = 0
        Dim Ni As Double = 0


        'Validate input fields
        If IsTextboxEmpty(txtHrsWorked) Or IsTextboxEmpty(txtNI) Then
            MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If comName.Text = "" Then
            MessageBox.Show("Please select staff name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        'Validate NI
        If txtNI.Text.Length < 9 Then
            MessageBox.Show("National Insurance number must be 9 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'Check that the totalHoursWorked input is a valid number
        If Double.TryParse(txtHrsWorked.Text, totalHoursWorked) Then
            totalHoursWorked = txtHrsWorked.Text
        Else
            MessageBox.Show("Hours worked must be a valid number", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim taxRate As Double = 0.2
        Dim GrossWage = totalHoursWorked * hourlyRate

        'Calculate monthly tax
        If GrossWage < TaxAllowanceMonth Then
            Tax = 0
        Else
            Tax = (GrossWage - TaxAllowanceMonth) * taxRate
        End If

        If GrossWage < NIAllowanceMonth Then
            Ni = 0
        Else
            Ni = (GrossWage - NIAllowanceMonth) * NIRate
        End If

        Dim TotalDeductions = Tax + Ni

        Dim monthlyNetPay As Double = GrossWage - TotalDeductions

        'Assign values to textboxes in currency format
        txtGrossWages.Text = GrossWage.ToString("C")
        txtTax.Text = Tax.ToString("C")
        txtNetPay.Text = monthlyNetPay.ToString("C")
        txtTotalDeductions.Text = TotalDeductions.ToString("C")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearInputFields(Me) 'Clear input fields
    End Sub

    Private Sub btnSaveSlip_Click(sender As Object, e As EventArgs) Handles btnSaveSlip.Click

        'Create a random number generator
        Dim random As New Random()

        'Generate a random integer for the ID
        Dim randomID As Integer = random.Next(1000, 10000)

        If comName.SelectedItem = "" Then
            MessageBox.Show("Please fill in all fields before attempting to save slip.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If txtTax.Text = "" Then
            MessageBox.Show("Please fill in all fields before attempting to save slip.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'Create an instance of the Payroll structure
        'Assign values to the properties of the Payroll structure
        Dim Payslip As New PayrollModule.Payroll()
        Payslip.PayrollId = randomID
        Payslip.Name = comName.SelectedItem.ToString()
        Payslip.NationalInsurance = txtNI.Text
        Payslip.Tax = txtTax.Text
        Payslip.HrsWorked = txtHrsWorked.Text
        Payslip.GrossWages = txtGrossWages.Text
        Payslip.TotalDeductions = txtTotalDeductions.Text
        Payslip.NetPay = txtNetPay.Text
        Payslip.NationalInsurance = txtNI.Text

        'Validate input fields
        If IsTextboxEmpty(txtHrsWorked) Or IsTextboxEmpty(txtNI) Or IsTextboxEmpty(txtGrossWages) Or IsTextboxEmpty(txtNetPay) Or IsTextboxEmpty(txtTax) Or IsTextboxEmpty(txtTotalDeductions) Then
            MessageBox.Show("Please fill in all fields before attempting to save slip.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'Validate NI
        If txtNI.Text.Length < 9 Then
            MessageBox.Show("National Insurance number must be 9 characters.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim currentDate As String = Date.Now.ToString("yyyy-MM-dd")
        'Create a SaveFileDialog instance
        'Set the title and filter for the dialog
        'Set filename unique to employee name and date
        Dim saveFileDialog As New SaveFileDialog With {
            .Title = "Save Payroll Slip",
            .Filter = "Text Files|*.txt|All Files|*.*",
            .FileName = $"Payslip-{comName.SelectedItem}-{currentDate}"
        }

        ' Show the dialog and get the result
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Try
                'Get the selected file path
                Dim filePath As String = saveFileDialog.FileName

                'Get the current date and time
                Dim currentTime As String = Date.Now.ToString("yyyy-MM-dd HH:mm:ss")

                'Save the payroll slip text to the selected file
                Using writer As New StreamWriter(filePath)
                    writer.WriteLine($"====Pay Slip - {currentTime}====")
                    writer.WriteLine($"====NI:{Payslip.NationalInsurance}====")
                    writer.WriteLine($"====Employee Name: {Payslip.Name} - ID:{randomID}====")
                    writer.WriteLine($"====Gross Wage: £{Payslip.GrossWages}====")
                    writer.WriteLine($"====Tax: £{Payslip.Tax}====")
                    writer.WriteLine($"====Total Deductions: £{Payslip.TotalDeductions}====")
                    writer.WriteLine($"====Net Pay: £{Payslip.NetPay}====")
                End Using

                MessageBox.Show($"Payroll slip saved successfully to: {filePath}.", "Save Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception 'Error handling
                MessageBox.Show("An error occurred while saving the payroll slip: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub comName_SelectedIndexChanged(sender As Object, e As EventArgs) Handles comName.SelectedIndexChanged
        'Get the selected employee name
        Dim selectedStaffName As String = comName.SelectedItem.ToString()

        'Read the content of the AllStaff.txt file into a list
        Dim allStaffLines As List(Of String) = File.ReadAllLines("AllStaff.txt").ToList()

        'Iterate through each line to find the selected employee's information
        For Each line As String In allStaffLines
            Dim staffInfo As String() = line.Split(","c)

            'Check if the current line contains information for the selected employee 
            'Concatenate first name and second name to compare if its the correct staff member
            If staffInfo.Length > 6 AndAlso staffInfo(1) & " " & staffInfo(2) = selectedStaffName Then
                Dim nationalInsuranceNumber As String = staffInfo(7)
                txtNI.Text = nationalInsuranceNumber
                Exit For 'Exit the loop once the information is found
            End If
        Next
    End Sub
End Class