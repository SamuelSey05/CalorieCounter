<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FoodEdit
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
        Dim btnDelete As System.Windows.Forms.Button
        Me.btnEAmount = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        btnDelete = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnDelete
        '
        btnDelete.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        btnDelete.Location = New System.Drawing.Point(95, 140)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New System.Drawing.Size(92, 48)
        btnDelete.TabIndex = 0
        btnDelete.Text = "Delete food"
        btnDelete.UseVisualStyleBackColor = True
        AddHandler btnDelete.Click, AddressOf Me.btnDelete_Click
        '
        'btnEAmount
        '
        Me.btnEAmount.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEAmount.Location = New System.Drawing.Point(302, 140)
        Me.btnEAmount.Name = "btnEAmount"
        Me.btnEAmount.Size = New System.Drawing.Size(90, 48)
        Me.btnEAmount.TabIndex = 1
        Me.btnEAmount.Text = "Edit amount"
        Me.btnEAmount.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(33, 23)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(80, 36)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(178, 51)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(139, 36)
        Me.lblTitle.TabIndex = 5
        Me.lblTitle.Text = "Edit food"
        '
        'FoodEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 236)
        Me.Controls.Add(Me.btnEAmount)
        Me.Controls.Add(btnDelete)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "FoodEdit"
        Me.Text = "Food Edit"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnEAmount As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents lblTitle As Label
End Class
