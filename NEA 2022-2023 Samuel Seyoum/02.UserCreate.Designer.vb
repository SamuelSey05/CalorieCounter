<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserCreate
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblFName = New System.Windows.Forms.Label()
        Me.txtbxFName = New System.Windows.Forms.TextBox()
        Me.txtbxSName = New System.Windows.Forms.TextBox()
        Me.lblSName = New System.Windows.Forms.Label()
        Me.txtbxUName = New System.Windows.Forms.TextBox()
        Me.lblUName = New System.Windows.Forms.Label()
        Me.txtbxPass = New System.Windows.Forms.TextBox()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.txtbxCPAss = New System.Windows.Forms.TextBox()
        Me.lblCPass = New System.Windows.Forms.Label()
        Me.btnContinue = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblMatch = New System.Windows.Forms.Label()
        Me.lblEmpty = New System.Windows.Forms.Label()
        Me.lblRequirements = New System.Windows.Forms.Label()
        Me.lblNotEnough = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(130, 27)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(180, 36)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Create user"
        '
        'lblFName
        '
        Me.lblFName.AutoSize = True
        Me.lblFName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFName.Location = New System.Drawing.Point(112, 138)
        Me.lblFName.Name = "lblFName"
        Me.lblFName.Size = New System.Drawing.Size(73, 16)
        Me.lblFName.TabIndex = 1
        Me.lblFName.Text = "First name:"
        '
        'txtbxFName
        '
        Me.txtbxFName.Location = New System.Drawing.Point(243, 134)
        Me.txtbxFName.Name = "txtbxFName"
        Me.txtbxFName.Size = New System.Drawing.Size(100, 20)
        Me.txtbxFName.TabIndex = 0
        '
        'txtbxSName
        '
        Me.txtbxSName.Location = New System.Drawing.Point(243, 179)
        Me.txtbxSName.Name = "txtbxSName"
        Me.txtbxSName.Size = New System.Drawing.Size(100, 20)
        Me.txtbxSName.TabIndex = 1
        '
        'lblSName
        '
        Me.lblSName.AutoSize = True
        Me.lblSName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSName.Location = New System.Drawing.Point(112, 179)
        Me.lblSName.Name = "lblSName"
        Me.lblSName.Size = New System.Drawing.Size(63, 16)
        Me.lblSName.TabIndex = 3
        Me.lblSName.Text = "Surname:"
        '
        'txtbxUName
        '
        Me.txtbxUName.Location = New System.Drawing.Point(243, 224)
        Me.txtbxUName.Name = "txtbxUName"
        Me.txtbxUName.Size = New System.Drawing.Size(100, 20)
        Me.txtbxUName.TabIndex = 2
        '
        'lblUName
        '
        Me.lblUName.AutoSize = True
        Me.lblUName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUName.Location = New System.Drawing.Point(112, 224)
        Me.lblUName.Name = "lblUName"
        Me.lblUName.Size = New System.Drawing.Size(70, 16)
        Me.lblUName.TabIndex = 5
        Me.lblUName.Text = "Username:"
        '
        'txtbxPass
        '
        Me.txtbxPass.Location = New System.Drawing.Point(243, 266)
        Me.txtbxPass.Name = "txtbxPass"
        Me.txtbxPass.Size = New System.Drawing.Size(100, 20)
        Me.txtbxPass.TabIndex = 3
        Me.txtbxPass.UseSystemPasswordChar = True
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.Location = New System.Drawing.Point(112, 266)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(68, 16)
        Me.lblPass.TabIndex = 7
        Me.lblPass.Text = "Password:"
        '
        'txtbxCPAss
        '
        Me.txtbxCPAss.Location = New System.Drawing.Point(243, 308)
        Me.txtbxCPAss.Name = "txtbxCPAss"
        Me.txtbxCPAss.Size = New System.Drawing.Size(100, 20)
        Me.txtbxCPAss.TabIndex = 4
        Me.txtbxCPAss.UseSystemPasswordChar = True
        '
        'lblCPass
        '
        Me.lblCPass.AutoSize = True
        Me.lblCPass.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCPass.Location = New System.Drawing.Point(112, 308)
        Me.lblCPass.Name = "lblCPass"
        Me.lblCPass.Size = New System.Drawing.Size(116, 16)
        Me.lblCPass.TabIndex = 9
        Me.lblCPass.Text = "Confirm Password:"
        '
        'btnContinue
        '
        Me.btnContinue.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnContinue.Location = New System.Drawing.Point(175, 393)
        Me.btnContinue.Name = "btnContinue"
        Me.btnContinue.Size = New System.Drawing.Size(104, 48)
        Me.btnContinue.TabIndex = 5
        Me.btnContinue.Text = "Continue"
        Me.btnContinue.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(12, 27)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(84, 36)
        Me.btnBack.TabIndex = 6
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblMatch
        '
        Me.lblMatch.AutoSize = True
        Me.lblMatch.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMatch.ForeColor = System.Drawing.Color.Red
        Me.lblMatch.Location = New System.Drawing.Point(360, 281)
        Me.lblMatch.Name = "lblMatch"
        Me.lblMatch.Size = New System.Drawing.Size(83, 32)
        Me.lblMatch.TabIndex = 13
        Me.lblMatch.Text = "*Passwords " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "do not match"
        Me.lblMatch.Visible = False
        '
        'lblEmpty
        '
        Me.lblEmpty.AutoSize = True
        Me.lblEmpty.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpty.ForeColor = System.Drawing.Color.Red
        Me.lblEmpty.Location = New System.Drawing.Point(172, 91)
        Me.lblEmpty.Name = "lblEmpty"
        Me.lblEmpty.Size = New System.Drawing.Size(120, 16)
        Me.lblEmpty.TabIndex = 14
        Me.lblEmpty.Text = "Fill out empty fields"
        Me.lblEmpty.Visible = False
        '
        'lblRequirements
        '
        Me.lblRequirements.AutoSize = True
        Me.lblRequirements.Location = New System.Drawing.Point(112, 342)
        Me.lblRequirements.Name = "lblRequirements"
        Me.lblRequirements.Size = New System.Drawing.Size(222, 39)
        Me.lblRequirements.TabIndex = 15
        Me.lblRequirements.Text = "*Password must contain at least 8 characters," & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " 1 upper case, 1 lower case, 1 num" &
    "ber " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and 1 special character"
        '
        'lblNotEnough
        '
        Me.lblNotEnough.AutoSize = True
        Me.lblNotEnough.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotEnough.ForeColor = System.Drawing.Color.Red
        Me.lblNotEnough.Location = New System.Drawing.Point(360, 281)
        Me.lblNotEnough.Name = "lblNotEnough"
        Me.lblNotEnough.Size = New System.Drawing.Size(137, 32)
        Me.lblNotEnough.TabIndex = 16
        Me.lblNotEnough.Text = "*Password does " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "not meet requirements"
        Me.lblNotEnough.Visible = False
        '
        'UserCreate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(503, 469)
        Me.Controls.Add(Me.lblNotEnough)
        Me.Controls.Add(Me.lblRequirements)
        Me.Controls.Add(Me.lblEmpty)
        Me.Controls.Add(Me.lblMatch)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnContinue)
        Me.Controls.Add(Me.txtbxCPAss)
        Me.Controls.Add(Me.lblCPass)
        Me.Controls.Add(Me.txtbxPass)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.txtbxUName)
        Me.Controls.Add(Me.lblUName)
        Me.Controls.Add(Me.txtbxSName)
        Me.Controls.Add(Me.lblSName)
        Me.Controls.Add(Me.txtbxFName)
        Me.Controls.Add(Me.lblFName)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "UserCreate"
        Me.Text = "User Creation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblFName As Label
    Friend WithEvents txtbxFName As TextBox
    Friend WithEvents txtbxSName As TextBox
    Friend WithEvents lblSName As Label
    Friend WithEvents txtbxUName As TextBox
    Friend WithEvents lblUName As Label
    Friend WithEvents txtbxPass As TextBox
    Friend WithEvents lblPass As Label
    Friend WithEvents txtbxCPAss As TextBox
    Friend WithEvents lblCPass As Label
    Friend WithEvents btnContinue As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents lblMatch As Label
    Friend WithEvents lblEmpty As Label
    Friend WithEvents lblRequirements As Label
    Friend WithEvents lblNotEnough As Label
End Class
