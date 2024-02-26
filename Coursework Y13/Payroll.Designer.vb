<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Payroll
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.comName = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnSaveSlip = New System.Windows.Forms.Button()
        Me.txtTax = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNI = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtHrsWorked = New System.Windows.Forms.TextBox()
        Me.txtGrossWages = New System.Windows.Forms.TextBox()
        Me.txtTotalDeductions = New System.Windows.Forms.TextBox()
        Me.txtNetPay = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'comName
        '
        Me.comName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.comName.FormattingEnabled = True
        Me.comName.Location = New System.Drawing.Point(88, 157)
        Me.comName.Name = "comName"
        Me.comName.Size = New System.Drawing.Size(198, 24)
        Me.comName.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 162)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Name"
        '
        'btnCalculate
        '
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCalculate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCalculate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCalculate.Location = New System.Drawing.Point(88, 206)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(198, 27)
        Me.btnCalculate.TabIndex = 15
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnSaveSlip
        '
        Me.btnSaveSlip.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSaveSlip.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSaveSlip.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSaveSlip.Location = New System.Drawing.Point(88, 239)
        Me.btnSaveSlip.Name = "btnSaveSlip"
        Me.btnSaveSlip.Size = New System.Drawing.Size(198, 27)
        Me.btnSaveSlip.TabIndex = 16
        Me.btnSaveSlip.Text = "Save Slip"
        Me.btnSaveSlip.UseVisualStyleBackColor = True
        '
        'txtTax
        '
        Me.txtTax.Enabled = False
        Me.txtTax.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtTax.Location = New System.Drawing.Point(88, 375)
        Me.txtTax.Name = "txtTax"
        Me.txtTax.Size = New System.Drawing.Size(196, 23)
        Me.txtTax.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 376)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 16)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Tax"
        '
        'txtNI
        '
        Me.txtNI.Enabled = False
        Me.txtNI.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtNI.Location = New System.Drawing.Point(88, 332)
        Me.txtNI.MaxLength = 9
        Me.txtNI.Name = "txtNI"
        Me.txtNI.Size = New System.Drawing.Size(196, 23)
        Me.txtNI.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 332)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 16)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "NI"
        '
        'txtHrsWorked
        '
        Me.txtHrsWorked.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtHrsWorked.Location = New System.Drawing.Point(468, 156)
        Me.txtHrsWorked.Name = "txtHrsWorked"
        Me.txtHrsWorked.Size = New System.Drawing.Size(196, 23)
        Me.txtHrsWorked.TabIndex = 21
        '
        'txtGrossWages
        '
        Me.txtGrossWages.Enabled = False
        Me.txtGrossWages.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtGrossWages.Location = New System.Drawing.Point(468, 308)
        Me.txtGrossWages.Name = "txtGrossWages"
        Me.txtGrossWages.Size = New System.Drawing.Size(196, 23)
        Me.txtGrossWages.TabIndex = 22
        '
        'txtTotalDeductions
        '
        Me.txtTotalDeductions.Enabled = False
        Me.txtTotalDeductions.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtTotalDeductions.Location = New System.Drawing.Point(468, 343)
        Me.txtTotalDeductions.Name = "txtTotalDeductions"
        Me.txtTotalDeductions.Size = New System.Drawing.Size(196, 23)
        Me.txtTotalDeductions.TabIndex = 23
        '
        'txtNetPay
        '
        Me.txtNetPay.Enabled = False
        Me.txtNetPay.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtNetPay.Location = New System.Drawing.Point(468, 375)
        Me.txtNetPay.Name = "txtNetPay"
        Me.txtNetPay.Size = New System.Drawing.Size(196, 23)
        Me.txtNetPay.TabIndex = 24
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(354, 311)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 16)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Gross Wages"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(351, 350)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(102, 16)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Total Deductions"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(354, 375)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 16)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Net Pay"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(348, 159)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 16)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Hours Worked"
        '
        'btnClear
        '
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClear.Location = New System.Drawing.Point(88, 272)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(198, 27)
        Me.btnClear.TabIndex = 29
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(173, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(355, 19)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Please enter details to produce a monthly payslip"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Coursework_Y13.My.Resources.Resources.logo1
        Me.PictureBox1.Location = New System.Drawing.Point(565, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(99, 95)
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'Payroll
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(699, 430)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNetPay)
        Me.Controls.Add(Me.txtTotalDeductions)
        Me.Controls.Add(Me.txtGrossWages)
        Me.Controls.Add(Me.txtHrsWorked)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtNI)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtTax)
        Me.Controls.Add(Me.btnSaveSlip)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.comName)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "Payroll"
        Me.Text = "Payroll"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents comName As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnSaveSlip As Button
    Friend WithEvents txtTax As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNI As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtHrsWorked As TextBox
    Friend WithEvents txtGrossWages As TextBox
    Friend WithEvents txtTotalDeductions As TextBox
    Friend WithEvents txtNetPay As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents btnClear As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
