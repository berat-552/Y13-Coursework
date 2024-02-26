<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StaffMenu
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnShowStockControl = New System.Windows.Forms.Button()
        Me.btnShowMakeOrderForm = New System.Windows.Forms.Button()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(192, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 18)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Staff Menu"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(161, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 23)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "John's Fishbar"
        '
        'btnShowStockControl
        '
        Me.btnShowStockControl.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnShowStockControl.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnShowStockControl.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnShowStockControl.Location = New System.Drawing.Point(136, 131)
        Me.btnShowStockControl.Name = "btnShowStockControl"
        Me.btnShowStockControl.Size = New System.Drawing.Size(191, 40)
        Me.btnShowStockControl.TabIndex = 20
        Me.btnShowStockControl.Text = "Stock Control"
        Me.btnShowStockControl.UseVisualStyleBackColor = True
        '
        'btnShowMakeOrderForm
        '
        Me.btnShowMakeOrderForm.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnShowMakeOrderForm.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnShowMakeOrderForm.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnShowMakeOrderForm.Location = New System.Drawing.Point(136, 177)
        Me.btnShowMakeOrderForm.Name = "btnShowMakeOrderForm"
        Me.btnShowMakeOrderForm.Size = New System.Drawing.Size(191, 40)
        Me.btnShowMakeOrderForm.TabIndex = 23
        Me.btnShowMakeOrderForm.Text = "Make Order"
        Me.btnShowMakeOrderForm.UseVisualStyleBackColor = True
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblUsername.Location = New System.Drawing.Point(103, 20)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(59, 18)
        Me.lblUsername.TabIndex = 25
        Me.lblUsername.Text = "Label4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(12, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 18)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Logged in as:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Coursework_Y13.My.Resources.Resources.logo1
        Me.PictureBox1.Location = New System.Drawing.Point(340, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(99, 95)
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'StaffMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(451, 325)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblUsername)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnShowMakeOrderForm)
        Me.Controls.Add(Me.btnShowStockControl)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "StaffMenu"
        Me.Text = "StaffMenu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnShowStockControl As Button
    Friend WithEvents btnShowMakeOrderForm As Button
    Friend WithEvents lblUsername As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
