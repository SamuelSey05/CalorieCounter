<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtbxPass = New System.Windows.Forms.TextBox()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.txtbxUName = New System.Windows.Forms.TextBox()
        Me.lblUName = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblIncorrect = New System.Windows.Forms.Label()
        Me.lblEmpty = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(12, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(84, 36)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'txtbxPass
        '
        Me.txtbxPass.Location = New System.Drawing.Point(264, 162)
        Me.txtbxPass.Name = "txtbxPass"
        Me.txtbxPass.Size = New System.Drawing.Size(100, 20)
        Me.txtbxPass.TabIndex = 1
        Me.txtbxPass.UseSystemPasswordChar = True
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPass.Location = New System.Drawing.Point(133, 162)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(68, 16)
        Me.lblPass.TabIndex = 52
        Me.lblPass.Text = "Password:"
        '
        'txtbxUName
        '
        Me.txtbxUName.Location = New System.Drawing.Point(264, 112)
        Me.txtbxUName.Name = "txtbxUName"
        Me.txtbxUName.Size = New System.Drawing.Size(100, 20)
        Me.txtbxUName.TabIndex = 0
        '
        'lblUName
        '
        Me.lblUName.AutoSize = True
        Me.lblUName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUName.Location = New System.Drawing.Point(133, 112)
        Me.lblUName.Name = "lblUName"
        Me.lblUName.Size = New System.Drawing.Size(70, 16)
        Me.lblUName.TabIndex = 54
        Me.lblUName.Text = "Username:"
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(193, 210)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(96, 46)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "Log in"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(77, 51)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(342, 27)
        Me.lblTitle.TabIndex = 57
        Me.lblTitle.Text = "Enter username and password"
        '
        'lblIncorrect
        '
        Me.lblIncorrect.AutoSize = True
        Me.lblIncorrect.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIncorrect.ForeColor = System.Drawing.Color.Red
        Me.lblIncorrect.Location = New System.Drawing.Point(149, 84)
        Me.lblIncorrect.Name = "lblIncorrect"
        Me.lblIncorrect.Size = New System.Drawing.Size(193, 16)
        Me.lblIncorrect.TabIndex = 58
        Me.lblIncorrect.Text = "Username/password is incorrect"
        Me.lblIncorrect.Visible = False
        '
        'lblEmpty
        '
        Me.lblEmpty.AutoSize = True
        Me.lblEmpty.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpty.ForeColor = System.Drawing.Color.Red
        Me.lblEmpty.Location = New System.Drawing.Point(190, 84)
        Me.lblEmpty.Name = "lblEmpty"
        Me.lblEmpty.Size = New System.Drawing.Size(120, 16)
        Me.lblEmpty.TabIndex = 59
        Me.lblEmpty.Text = "Fill out empty fields"
        Me.lblEmpty.Visible = False
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(488, 272)
        Me.Controls.Add(Me.lblEmpty)
        Me.Controls.Add(Me.lblIncorrect)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtbxUName)
        Me.Controls.Add(Me.lblUName)
        Me.Controls.Add(Me.txtbxPass)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.btnBack)
        Me.Name = "Login"
        Me.Text = "Log in"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents txtbxPass As TextBox
    Friend WithEvents lblPass As Label
    Friend WithEvents txtbxUName As TextBox
    Friend WithEvents lblUName As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblIncorrect As Label
    Friend WithEvents lblEmpty As Label
End Class
