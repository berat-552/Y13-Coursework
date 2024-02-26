<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotPassword
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnGetSecurityQuestion = New System.Windows.Forms.Button()
        Me.txtSecurityAnswer = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblSecurityQuestion = New System.Windows.Forms.Label()
        Me.btnResetPassword = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnCancel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCancel.Location = New System.Drawing.Point(86, 287)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(179, 27)
        Me.btnCancel.TabIndex = 25
        Me.btnCancel.Text = "Close"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnClear.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnClear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnClear.Location = New System.Drawing.Point(86, 254)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(179, 27)
        Me.btnClear.TabIndex = 24
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnGetSecurityQuestion
        '
        Me.btnGetSecurityQuestion.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnGetSecurityQuestion.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnGetSecurityQuestion.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnGetSecurityQuestion.Location = New System.Drawing.Point(88, 152)
        Me.btnGetSecurityQuestion.Name = "btnGetSecurityQuestion"
        Me.btnGetSecurityQuestion.Size = New System.Drawing.Size(180, 30)
        Me.btnGetSecurityQuestion.TabIndex = 23
        Me.btnGetSecurityQuestion.Text = "Get Security Question"
        Me.btnGetSecurityQuestion.UseVisualStyleBackColor = True
        '
        'txtSecurityAnswer
        '
        Me.txtSecurityAnswer.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtSecurityAnswer.Location = New System.Drawing.Point(456, 126)
        Me.txtSecurityAnswer.Name = "txtSecurityAnswer"
        Me.txtSecurityAnswer.Size = New System.Drawing.Size(190, 23)
        Me.txtSecurityAnswer.TabIndex = 21
        '
        'txtUsername
        '
        Me.txtUsername.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtUsername.Location = New System.Drawing.Point(88, 123)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(177, 23)
        Me.txtUsername.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(5, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 16)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Username"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(197, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(300, 19)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Please enter Username to reset Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(317, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 18)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Security Answer"
        '
        'lblSecurityQuestion
        '
        Me.lblSecurityQuestion.AutoSize = True
        Me.lblSecurityQuestion.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblSecurityQuestion.Location = New System.Drawing.Point(23, 66)
        Me.lblSecurityQuestion.Name = "lblSecurityQuestion"
        Me.lblSecurityQuestion.Size = New System.Drawing.Size(147, 18)
        Me.lblSecurityQuestion.TabIndex = 26
        Me.lblSecurityQuestion.Text = "Security Question:"
        '
        'btnResetPassword
        '
        Me.btnResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnResetPassword.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnResetPassword.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnResetPassword.Location = New System.Drawing.Point(86, 221)
        Me.btnResetPassword.Name = "btnResetPassword"
        Me.btnResetPassword.Size = New System.Drawing.Size(179, 27)
        Me.btnResetPassword.TabIndex = 27
        Me.btnResetPassword.Text = "Reset Password"
        Me.btnResetPassword.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Coursework_Y13.My.Resources.Resources.logo1
        Me.PictureBox1.Location = New System.Drawing.Point(547, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(99, 95)
        Me.PictureBox1.TabIndex = 28
        Me.PictureBox1.TabStop = False
        '
        'ForgotPassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(671, 339)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnResetPassword)
        Me.Controls.Add(Me.lblSecurityQuestion)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnGetSecurityQuestion)
        Me.Controls.Add(Me.txtSecurityAnswer)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ForgotPassword"
        Me.Text = "ForgotPassword"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCancel As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnGetSecurityQuestion As Button
    Friend WithEvents txtSecurityAnswer As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblSecurityQuestion As Label
    Friend WithEvents btnResetPassword As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
