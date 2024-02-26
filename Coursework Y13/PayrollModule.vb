Module PayrollModule
    'Declare structure for Payroll
    Public Structure Payroll
        Public PayrollId As Integer
        Public NationalInsurance As String
        Public Name As String
        Public Tax As Double
        Public HrsWorked As Double
        Public GrossWages As Double
        Public TotalDeductions As Double
        Public NetPay As Double
    End Structure
End Module
