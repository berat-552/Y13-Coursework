<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StockControlMenu
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
        Me.btnEnterProduct = New System.Windows.Forms.Button()
        Me.btnAllProducts = New System.Windows.Forms.Button()
        Me.btnAddNewStockbtnAddNewStockbtnAddNewStock = New System.Windows.Forms.Button()
        Me.btnCreateReOrderList = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEnterProduct
        '
        Me.btnEnterProduct.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnEnterProduct.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnEnterProduct.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnEnterProduct.Location = New System.Drawing.Point(41, 162)
        Me.btnEnterProduct.Name = "btnEnterProduct"
        Me.btnEnterProduct.Size = New System.Drawing.Size(198, 27)
        Me.btnEnterProduct.TabIndex = 9
        Me.btnEnterProduct.Text = "Enter New Product"
        Me.btnEnterProduct.UseVisualStyleBackColor = True
        '
        'btnAllProducts
        '
        Me.btnAllProducts.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnAllProducts.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAllProducts.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAllProducts.Location = New System.Drawing.Point(41, 195)
        Me.btnAllProducts.Name = "btnAllProducts"
        Me.btnAllProducts.Size = New System.Drawing.Size(198, 27)
        Me.btnAllProducts.TabIndex = 10
        Me.btnAllProducts.Text = "All Products"
        Me.btnAllProducts.UseVisualStyleBackColor = True
        '
        'btnAddNewStockbtnAddNewStockbtnAddNewStock
        '
        Me.btnAddNewStockbtnAddNewStockbtnAddNewStock.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnAddNewStockbtnAddNewStockbtnAddNewStock.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAddNewStockbtnAddNewStockbtnAddNewStock.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAddNewStockbtnAddNewStockbtnAddNewStock.Location = New System.Drawing.Point(41, 228)
        Me.btnAddNewStockbtnAddNewStockbtnAddNewStock.Name = "btnAddNewStockbtnAddNewStockbtnAddNewStock"
        Me.btnAddNewStockbtnAddNewStockbtnAddNewStock.Size = New System.Drawing.Size(198, 27)
        Me.btnAddNewStockbtnAddNewStockbtnAddNewStock.TabIndex = 11
        Me.btnAddNewStockbtnAddNewStockbtnAddNewStock.Text = "Add New Stock"
        Me.btnAddNewStockbtnAddNewStockbtnAddNewStock.UseVisualStyleBackColor = True
        '
        'btnCreateReOrderList
        '
        Me.btnCreateReOrderList.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCreateReOrderList.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCreateReOrderList.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCreateReOrderList.Location = New System.Drawing.Point(41, 261)
        Me.btnCreateReOrderList.Name = "btnCreateReOrderList"
        Me.btnCreateReOrderList.Size = New System.Drawing.Size(198, 27)
        Me.btnCreateReOrderList.TabIndex = 12
        Me.btnCreateReOrderList.Text = "Create Re-Order list"
        Me.btnCreateReOrderList.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(67, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 19)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Stock Control Menu"
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClose.Location = New System.Drawing.Point(41, 347)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(198, 27)
        Me.btnClose.TabIndex = 14
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Coursework_Y13.My.Resources.Resources.logo1
        Me.PictureBox1.Location = New System.Drawing.Point(94, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(99, 95)
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'StockControlMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(271, 384)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCreateReOrderList)
        Me.Controls.Add(Me.btnAddNewStockbtnAddNewStockbtnAddNewStock)
        Me.Controls.Add(Me.btnAllProducts)
        Me.Controls.Add(Me.btnEnterProduct)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Name = "StockControlMenu"
        Me.Text = "StockControlMenu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEnterProduct As Button
    Friend WithEvents btnAllProducts As Button
    Friend WithEvents btnAddNewStockbtnAddNewStockbtnAddNewStock As Button
    Friend WithEvents btnCreateReOrderList As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
