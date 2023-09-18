<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PasswordEdit
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblOPass = New System.Windows.Forms.Label()
        Me.txtbxOPass = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtbxNPass = New System.Windows.Forms.TextBox()
        Me.lblNPass = New System.Windows.Forms.Label()
        Me.txtbxCNPass = New System.Windows.Forms.TextBox()
        Me.lblCNPass = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.lblNotEnough = New System.Windows.Forms.Label()
        Me.lblMatch = New System.Windows.Forms.Label()
        Me.lblCurrent = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(201, 33)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(216, 36)
        Me.lblTitle.TabIndex = 2
        Me.lblTitle.Text = "Edit Password"
        '
        'lblOPass
        '
        Me.lblOPass.AutoSize = True
        Me.lblOPass.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOPass.Location = New System.Drawing.Point(158, 157)
        Me.lblOPass.Name = "lblOPass"
        Me.lblOPass.Size = New System.Drawing.Size(112, 16)
        Me.lblOPass.TabIndex = 3
        Me.lblOPass.Text = "Current password:"
        '
        'txtbxOPass
        '
        Me.txtbxOPass.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxOPass.Location = New System.Drawing.Point(336, 154)
        Me.txtbxOPass.Name = "txtbxOPass"
        Me.txtbxOPass.Size = New System.Drawing.Size(100, 22)
        Me.txtbxOPass.TabIndex = 0
        Me.txtbxOPass.UseSystemPasswordChar = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(38, 33)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(80, 36)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'txtbxNPass
        '
        Me.txtbxNPass.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxNPass.Location = New System.Drawing.Point(336, 198)
        Me.txtbxNPass.Name = "txtbxNPass"
        Me.txtbxNPass.Size = New System.Drawing.Size(100, 22)
        Me.txtbxNPass.TabIndex = 1
        Me.txtbxNPass.UseSystemPasswordChar = True
        '
        'lblNPass
        '
        Me.lblNPass.AutoSize = True
        Me.lblNPass.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNPass.Location = New System.Drawing.Point(158, 201)
        Me.lblNPass.Name = "lblNPass"
        Me.lblNPass.Size = New System.Drawing.Size(95, 16)
        Me.lblNPass.TabIndex = 6
        Me.lblNPass.Text = "New password:"
        '
        'txtbxCNPass
        '
        Me.txtbxCNPass.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbxCNPass.Location = New System.Drawing.Point(336, 247)
        Me.txtbxCNPass.Name = "txtbxCNPass"
        Me.txtbxCNPass.Size = New System.Drawing.Size(100, 22)
        Me.txtbxCNPass.TabIndex = 2
        Me.txtbxCNPass.UseSystemPasswordChar = True
        '
        'lblCNPass
        '
        Me.lblCNPass.AutoSize = True
        Me.lblCNPass.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCNPass.Location = New System.Drawing.Point(158, 250)
        Me.lblCNPass.Name = "lblCNPass"
        Me.lblCNPass.Size = New System.Drawing.Size(141, 16)
        Me.lblCNPass.TabIndex = 8
        Me.lblCNPass.Text = "Confirm new password:"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(261, 317)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(89, 40)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'lblNotEnough
        '
        Me.lblNotEnough.AutoSize = True
        Me.lblNotEnough.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotEnough.ForeColor = System.Drawing.Color.Red
        Me.lblNotEnough.Location = New System.Drawing.Point(475, 213)
        Me.lblNotEnough.Name = "lblNotEnough"
        Me.lblNotEnough.Size = New System.Drawing.Size(137, 32)
        Me.lblNotEnough.TabIndex = 17
        Me.lblNotEnough.Text = "*Password does " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "not meet requirements"
        Me.lblNotEnough.Visible = False
        '
        'lblMatch
        '
        Me.lblMatch.AutoSize = True
        Me.lblMatch.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMatch.ForeColor = System.Drawing.Color.Red
        Me.lblMatch.Location = New System.Drawing.Point(495, 213)
        Me.lblMatch.Name = "lblMatch"
        Me.lblMatch.Size = New System.Drawing.Size(83, 32)
        Me.lblMatch.TabIndex = 18
        Me.lblMatch.Text = "*Passwords " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "do not match"
        Me.lblMatch.Visible = False
        '
        'lblCurrent
        '
        Me.lblCurrent.AutoSize = True
        Me.lblCurrent.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCurrent.ForeColor = System.Drawing.Color.Red
        Me.lblCurrent.Location = New System.Drawing.Point(475, 157)
        Me.lblCurrent.Name = "lblCurrent"
        Me.lblCurrent.Size = New System.Drawing.Size(108, 32)
        Me.lblCurrent.TabIndex = 19
        Me.lblCurrent.Text = "*Does not match " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "current password"
        Me.lblCurrent.Visible = False
        '
        'PasswordEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(652, 387)
        Me.Controls.Add(Me.lblCurrent)
        Me.Controls.Add(Me.lblMatch)
        Me.Controls.Add(Me.lblNotEnough)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtbxCNPass)
        Me.Controls.Add(Me.lblCNPass)
        Me.Controls.Add(Me.txtbxNPass)
        Me.Controls.Add(Me.lblNPass)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtbxOPass)
        Me.Controls.Add(Me.lblOPass)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "PasswordEdit"
        Me.Text = "PasswordEdit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents lblOPass As Label
    Friend WithEvents txtbxOPass As TextBox
    Friend WithEvents btnBack As Button
    Friend WithEvents txtbxNPass As TextBox
    Friend WithEvents lblNPass As Label
    Friend WithEvents txtbxCNPass As TextBox
    Friend WithEvents lblCNPass As Label
    Friend WithEvents btnOK As Button
    Friend WithEvents lblNotEnough As Label
    Friend WithEvents lblMatch As Label
    Friend WithEvents lblCurrent As Label
End Class
