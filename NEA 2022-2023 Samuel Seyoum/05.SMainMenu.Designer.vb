<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class SMainMenu
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
        Me.btnFoodLog = New System.Windows.Forms.Button()
        Me.lblMainMenu = New System.Windows.Forms.Label()
        Me.btnHistory = New System.Windows.Forms.Button()
        Me.btnUserEdit = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnFoodLog
        '
        Me.btnFoodLog.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFoodLog.Location = New System.Drawing.Point(32, 135)
        Me.btnFoodLog.Name = "btnFoodLog"
        Me.btnFoodLog.Size = New System.Drawing.Size(97, 43)
        Me.btnFoodLog.TabIndex = 0
        Me.btnFoodLog.Text = "Log Food"
        Me.btnFoodLog.UseVisualStyleBackColor = True
        '
        'lblMainMenu
        '
        Me.lblMainMenu.AutoSize = True
        Me.lblMainMenu.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMainMenu.Location = New System.Drawing.Point(133, 19)
        Me.lblMainMenu.Name = "lblMainMenu"
        Me.lblMainMenu.Size = New System.Drawing.Size(173, 36)
        Me.lblMainMenu.TabIndex = 1
        Me.lblMainMenu.Text = "Main Menu"
        '
        'btnHistory
        '
        Me.btnHistory.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHistory.Location = New System.Drawing.Point(327, 135)
        Me.btnHistory.Name = "btnHistory"
        Me.btnHistory.Size = New System.Drawing.Size(97, 43)
        Me.btnHistory.TabIndex = 2
        Me.btnHistory.Text = "View History"
        Me.btnHistory.UseVisualStyleBackColor = True
        '
        'btnUserEdit
        '
        Me.btnUserEdit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserEdit.Location = New System.Drawing.Point(173, 135)
        Me.btnUserEdit.Name = "btnUserEdit"
        Me.btnUserEdit.Size = New System.Drawing.Size(97, 43)
        Me.btnUserEdit.TabIndex = 1
        Me.btnUserEdit.Text = "Edit User Details"
        Me.btnUserEdit.UseVisualStyleBackColor = True
        '
        'btnLogOut
        '
        Me.btnLogOut.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.Location = New System.Drawing.Point(341, 12)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(97, 43)
        Me.btnLogOut.TabIndex = 3
        Me.btnLogOut.Text = "Log Out"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'SMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(459, 211)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.btnUserEdit)
        Me.Controls.Add(Me.btnHistory)
        Me.Controls.Add(Me.lblMainMenu)
        Me.Controls.Add(Me.btnFoodLog)
        Me.Name = "SMainMenu"
        Me.Text = "Main Menu - Student"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnFoodLog As Button
    Friend WithEvents lblMainMenu As Label
    Friend WithEvents btnHistory As Button
    Friend WithEvents btnUserEdit As Button
    Friend WithEvents btnLogOut As Button
End Class
