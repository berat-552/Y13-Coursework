<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewProduct
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtItemID = New System.Windows.Forms.TextBox()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtQuantityInStock = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.txtReOrderLevel = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtReOrderQuantity = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSupplier = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSupplierPhoneNumber = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(90, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please enter new product details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(12, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ItemId"
        '
        'txtItemID
        '
        Me.txtItemID.Enabled = False
        Me.txtItemID.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtItemID.Location = New System.Drawing.Point(155, 44)
        Me.txtItemID.Name = "txtItemID"
        Me.txtItemID.Size = New System.Drawing.Size(196, 23)
        Me.txtItemID.TabIndex = 2
        '
        'txtProductName
        '
        Me.txtProductName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtProductName.Location = New System.Drawing.Point(155, 91)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(196, 23)
        Me.txtProductName.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(12, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Product Name"
        '
        'txtQuantityInStock
        '
        Me.txtQuantityInStock.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtQuantityInStock.Location = New System.Drawing.Point(155, 138)
        Me.txtQuantityInStock.Name = "txtQuantityInStock"
        Me.txtQuantityInStock.Size = New System.Drawing.Size(196, 23)
        Me.txtQuantityInStock.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(12, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Quantity in stock"
        '
        'txtDescription
        '
        Me.txtDescription.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtDescription.Location = New System.Drawing.Point(154, 386)
        Me.txtDescription.Multiline = True
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(195, 84)
        Me.txtDescription.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(12, 389)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Description"
        '
        'btnSave
        '
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSave.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSave.Location = New System.Drawing.Point(154, 490)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(198, 27)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnReset.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnReset.Location = New System.Drawing.Point(154, 523)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(198, 27)
        Me.btnReset.TabIndex = 10
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCancel.Location = New System.Drawing.Point(154, 556)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(198, 27)
        Me.btnCancel.TabIndex = 11
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'txtReOrderLevel
        '
        Me.txtReOrderLevel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtReOrderLevel.Location = New System.Drawing.Point(155, 189)
        Me.txtReOrderLevel.Name = "txtReOrderLevel"
        Me.txtReOrderLevel.Size = New System.Drawing.Size(196, 23)
        Me.txtReOrderLevel.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(12, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Re-Order Level"
        '
        'txtReOrderQuantity
        '
        Me.txtReOrderQuantity.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtReOrderQuantity.Location = New System.Drawing.Point(155, 240)
        Me.txtReOrderQuantity.Name = "txtReOrderQuantity"
        Me.txtReOrderQuantity.Size = New System.Drawing.Size(196, 23)
        Me.txtReOrderQuantity.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(12, 247)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Re-Order Quantity"
        '
        'txtSupplier
        '
        Me.txtSupplier.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtSupplier.Location = New System.Drawing.Point(155, 290)
        Me.txtSupplier.Name = "txtSupplier"
        Me.txtSupplier.Size = New System.Drawing.Size(196, 23)
        Me.txtSupplier.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(12, 297)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 16)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Supplier"
        '
        'txtSupplierPhoneNumber
        '
        Me.txtSupplierPhoneNumber.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtSupplierPhoneNumber.Location = New System.Drawing.Point(155, 342)
        Me.txtSupplierPhoneNumber.Name = "txtSupplierPhoneNumber"
        Me.txtSupplierPhoneNumber.Size = New System.Drawing.Size(196, 23)
        Me.txtSupplierPhoneNumber.TabIndex = 18
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(12, 345)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(142, 16)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Supplier Phone Number"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Coursework_Y13.My.Resources.Resources.logo1
        Me.PictureBox1.Location = New System.Drawing.Point(403, 19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(99, 95)
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'NewProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(524, 598)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtSupplierPhoneNumber)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtSupplier)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtReOrderQuantity)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtReOrderLevel)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDescription)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtQuantityInStock)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtProductName)
        Me.Controls.Add(Me.txtItemID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "NewProduct"
        Me.Text = "NewProduct"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtItemID As TextBox
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtQuantityInStock As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtDescription As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtReOrderLevel As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtReOrderQuantity As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSupplier As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtSupplierPhoneNumber As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
