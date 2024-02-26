<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddNewStock
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtProductID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNewQuantity = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.comProductName = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnUpdateStock = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.txtCurrentQuantity = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(46, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Product Name"
        '
        'txtProductID
        '
        Me.txtProductID.Enabled = False
        Me.txtProductID.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtProductID.Location = New System.Drawing.Point(191, 135)
        Me.txtProductID.Name = "txtProductID"
        Me.txtProductID.Size = New System.Drawing.Size(196, 23)
        Me.txtProductID.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(48, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Product ID"
        '
        'txtNewQuantity
        '
        Me.txtNewQuantity.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtNewQuantity.Location = New System.Drawing.Point(191, 195)
        Me.txtNewQuantity.Name = "txtNewQuantity"
        Me.txtNewQuantity.Size = New System.Drawing.Size(196, 23)
        Me.txtNewQuantity.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(46, 198)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "New Quantity"
        '
        'comProductName
        '
        Me.comProductName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.comProductName.FormattingEnabled = True
        Me.comProductName.Location = New System.Drawing.Point(189, 88)
        Me.comProductName.Name = "comProductName"
        Me.comProductName.Size = New System.Drawing.Size(198, 24)
        Me.comProductName.TabIndex = 27
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(91, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(256, 19)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Select Product and enter new stock"
        '
        'btnUpdateStock
        '
        Me.btnUpdateStock.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnUpdateStock.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnUpdateStock.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnUpdateStock.Location = New System.Drawing.Point(189, 239)
        Me.btnUpdateStock.Name = "btnUpdateStock"
        Me.btnUpdateStock.Size = New System.Drawing.Size(198, 27)
        Me.btnUpdateStock.TabIndex = 29
        Me.btnUpdateStock.Text = "Update Stock"
        Me.btnUpdateStock.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClose.Location = New System.Drawing.Point(189, 272)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(198, 27)
        Me.btnClose.TabIndex = 30
        Me.btnClose.Text = "Cancel"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'txtCurrentQuantity
        '
        Me.txtCurrentQuantity.Enabled = False
        Me.txtCurrentQuantity.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtCurrentQuantity.Location = New System.Drawing.Point(191, 166)
        Me.txtCurrentQuantity.Name = "txtCurrentQuantity"
        Me.txtCurrentQuantity.Size = New System.Drawing.Size(196, 23)
        Me.txtCurrentQuantity.TabIndex = 31
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(46, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 16)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Current Quantity"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Coursework_Y13.My.Resources.Resources.logo1
        Me.PictureBox1.Location = New System.Drawing.Point(425, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(99, 95)
        Me.PictureBox1.TabIndex = 33
        Me.PictureBox1.TabStop = False
        '
        'AddNewStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(536, 311)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCurrentQuantity)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnUpdateStock)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.comProductName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNewQuantity)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtProductID)
        Me.Controls.Add(Me.Label2)
        Me.Name = "AddNewStock"
        Me.Text = "AddNewStock"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents txtProductID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNewQuantity As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents comProductName As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnUpdateStock As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents txtCurrentQuantity As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
