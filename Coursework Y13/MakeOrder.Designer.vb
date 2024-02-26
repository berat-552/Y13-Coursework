<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MakeOrder
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
        Me.comFoodItems = New System.Windows.Forms.ComboBox()
        Me.numericUpDownQuantity = New System.Windows.Forms.NumericUpDown()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.richTxtOrderItems = New System.Windows.Forms.RichTextBox()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSendOrder = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.numericUpDownQuantity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'comFoodItems
        '
        Me.comFoodItems.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.comFoodItems.FormattingEnabled = True
        Me.comFoodItems.Location = New System.Drawing.Point(30, 42)
        Me.comFoodItems.Name = "comFoodItems"
        Me.comFoodItems.Size = New System.Drawing.Size(198, 26)
        Me.comFoodItems.TabIndex = 4
        '
        'numericUpDownQuantity
        '
        Me.numericUpDownQuantity.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.numericUpDownQuantity.Location = New System.Drawing.Point(313, 43)
        Me.numericUpDownQuantity.Name = "numericUpDownQuantity"
        Me.numericUpDownQuantity.Size = New System.Drawing.Size(120, 26)
        Me.numericUpDownQuantity.TabIndex = 5
        '
        'btnAddItem
        '
        Me.btnAddItem.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnAddItem.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnAddItem.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAddItem.Location = New System.Drawing.Point(30, 92)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(198, 27)
        Me.btnAddItem.TabIndex = 6
        Me.btnAddItem.Text = "Add Item"
        Me.btnAddItem.UseVisualStyleBackColor = True
        '
        'richTxtOrderItems
        '
        Me.richTxtOrderItems.Enabled = False
        Me.richTxtOrderItems.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.richTxtOrderItems.Location = New System.Drawing.Point(30, 205)
        Me.richTxtOrderItems.Name = "richTxtOrderItems"
        Me.richTxtOrderItems.Size = New System.Drawing.Size(438, 212)
        Me.richTxtOrderItems.TabIndex = 7
        Me.richTxtOrderItems.Text = ""
        '
        'txtTotal
        '
        Me.txtTotal.Enabled = False
        Me.txtTotal.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtTotal.Location = New System.Drawing.Point(527, 205)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(198, 23)
        Me.txtTotal.TabIndex = 8
        '
        'btnCancel
        '
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCancel.Location = New System.Drawing.Point(527, 342)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(198, 27)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClear.Location = New System.Drawing.Point(527, 308)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(198, 27)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSendOrder
        '
        Me.btnSendOrder.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnSendOrder.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSendOrder.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnSendOrder.Location = New System.Drawing.Point(527, 275)
        Me.btnSendOrder.Name = "btnSendOrder"
        Me.btnSendOrder.Size = New System.Drawing.Size(198, 27)
        Me.btnSendOrder.TabIndex = 11
        Me.btnSendOrder.Text = "Send Order"
        Me.btnSendOrder.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Coursework_Y13.My.Resources.Resources.logo1
        Me.PictureBox1.Location = New System.Drawing.Point(644, 24)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(99, 95)
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(313, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 19)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Take Order"
        '
        'MakeOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSendOrder)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.richTxtOrderItems)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.numericUpDownQuantity)
        Me.Controls.Add(Me.comFoodItems)
        Me.Name = "MakeOrder"
        Me.Text = "MakeOrder"
        CType(Me.numericUpDownQuantity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents comFoodItems As ComboBox
    Friend WithEvents numericUpDownQuantity As NumericUpDown
    Friend WithEvents btnAddItem As Button
    Friend WithEvents richTxtOrderItems As RichTextBox
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSendOrder As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
End Class
