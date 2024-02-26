<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditContact
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
        Me.comContactID = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnUpdateContactDetails = New System.Windows.Forms.Button()
        Me.txtContactDetails = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.comContactMethods = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtStaffName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtStaffID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnNextContact = New System.Windows.Forms.Button()
        Me.btnPreviousContact = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'comContactID
        '
        Me.comContactID.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.comContactID.FormattingEnabled = True
        Me.comContactID.Location = New System.Drawing.Point(160, 114)
        Me.comContactID.Name = "comContactID"
        Me.comContactID.Size = New System.Drawing.Size(198, 24)
        Me.comContactID.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(140, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 19)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Edit Contact Details"
        '
        'btnCancel
        '
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCancel.Location = New System.Drawing.Point(158, 382)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(198, 27)
        Me.btnCancel.TabIndex = 22
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnUpdateContactDetails
        '
        Me.btnUpdateContactDetails.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnUpdateContactDetails.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnUpdateContactDetails.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnUpdateContactDetails.Location = New System.Drawing.Point(158, 349)
        Me.btnUpdateContactDetails.Name = "btnUpdateContactDetails"
        Me.btnUpdateContactDetails.Size = New System.Drawing.Size(198, 27)
        Me.btnUpdateContactDetails.TabIndex = 20
        Me.btnUpdateContactDetails.Text = "Update Contact Details"
        Me.btnUpdateContactDetails.UseVisualStyleBackColor = True
        '
        'txtContactDetails
        '
        Me.txtContactDetails.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtContactDetails.Location = New System.Drawing.Point(160, 229)
        Me.txtContactDetails.Name = "txtContactDetails"
        Me.txtContactDetails.Size = New System.Drawing.Size(196, 23)
        Me.txtContactDetails.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(19, 234)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 18)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Contact Details"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(19, 211)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 18)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Contact Methods"
        '
        'comContactMethods
        '
        Me.comContactMethods.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.comContactMethods.FormattingEnabled = True
        Me.comContactMethods.Location = New System.Drawing.Point(160, 205)
        Me.comContactMethods.Name = "comContactMethods"
        Me.comContactMethods.Size = New System.Drawing.Size(196, 24)
        Me.comContactMethods.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(19, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 18)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Contact ID"
        '
        'txtStaffName
        '
        Me.txtStaffName.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtStaffName.Location = New System.Drawing.Point(160, 149)
        Me.txtStaffName.Name = "txtStaffName"
        Me.txtStaffName.Size = New System.Drawing.Size(198, 23)
        Me.txtStaffName.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(19, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 18)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Staff Name"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.Location = New System.Drawing.Point(19, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 18)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Staff ID"
        '
        'txtStaffID
        '
        Me.txtStaffID.Enabled = False
        Me.txtStaffID.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtStaffID.Location = New System.Drawing.Point(160, 178)
        Me.txtStaffID.Name = "txtStaffID"
        Me.txtStaffID.Size = New System.Drawing.Size(198, 23)
        Me.txtStaffID.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(96, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(232, 18)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "Select Contact ID and start editing"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Coursework_Y13.My.Resources.Resources.logo1
        Me.PictureBox1.Location = New System.Drawing.Point(373, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(99, 95)
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'btnNextContact
        '
        Me.btnNextContact.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnNextContact.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNextContact.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnNextContact.Location = New System.Drawing.Point(158, 280)
        Me.btnNextContact.Name = "btnNextContact"
        Me.btnNextContact.Size = New System.Drawing.Size(84, 43)
        Me.btnNextContact.TabIndex = 46
        Me.btnNextContact.Text = "Next Contact"
        Me.btnNextContact.UseVisualStyleBackColor = True
        '
        'btnPreviousContact
        '
        Me.btnPreviousContact.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnPreviousContact.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnPreviousContact.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnPreviousContact.Location = New System.Drawing.Point(264, 280)
        Me.btnPreviousContact.Name = "btnPreviousContact"
        Me.btnPreviousContact.Size = New System.Drawing.Size(94, 43)
        Me.btnPreviousContact.TabIndex = 47
        Me.btnPreviousContact.Text = "Previous Contact"
        Me.btnPreviousContact.UseVisualStyleBackColor = True
        '
        'EditContact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(484, 421)
        Me.Controls.Add(Me.btnPreviousContact)
        Me.Controls.Add(Me.btnNextContact)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtStaffID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtStaffName)
        Me.Controls.Add(Me.comContactID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnUpdateContactDetails)
        Me.Controls.Add(Me.txtContactDetails)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.comContactMethods)
        Me.Controls.Add(Me.Label2)
        Me.Name = "EditContact"
        Me.Text = "EditContact"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents comContactID As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnUpdateContactDetails As Button
    Friend WithEvents txtContactDetails As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents comContactMethods As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtStaffName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtStaffID As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnNextContact As Button
    Friend WithEvents btnPreviousContact As Button
End Class
