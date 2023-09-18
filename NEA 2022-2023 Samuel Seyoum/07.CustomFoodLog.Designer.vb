<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomFoodLog
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
        Me.btnNewFood = New System.Windows.Forms.Button()
        Me.txtbxFoods = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.dgvFoods = New System.Windows.Forms.DataGridView()
        CType(Me.dgvFoods, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNewFood
        '
        Me.btnNewFood.Location = New System.Drawing.Point(394, 233)
        Me.btnNewFood.Name = "btnNewFood"
        Me.btnNewFood.Size = New System.Drawing.Size(95, 44)
        Me.btnNewFood.TabIndex = 2
        Me.btnNewFood.Text = "Add custom food"
        Me.btnNewFood.UseVisualStyleBackColor = True
        '
        'txtbxFoods
        '
        Me.txtbxFoods.Location = New System.Drawing.Point(23, 159)
        Me.txtbxFoods.Name = "txtbxFoods"
        Me.txtbxFoods.Size = New System.Drawing.Size(345, 20)
        Me.txtbxFoods.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(423, 24)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Select the custom food you would like to log:"
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(23, 21)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(85, 38)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'dgvFoods
        '
        Me.dgvFoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFoods.Location = New System.Drawing.Point(23, 176)
        Me.dgvFoods.Name = "dgvFoods"
        Me.dgvFoods.Size = New System.Drawing.Size(345, 150)
        Me.dgvFoods.TabIndex = 1
        '
        'CustomFoodLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 365)
        Me.Controls.Add(Me.btnNewFood)
        Me.Controls.Add(Me.txtbxFoods)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.dgvFoods)
        Me.Name = "CustomFoodLog"
        Me.Text = "Custom Food"
        CType(Me.dgvFoods, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNewFood As Button
    Friend WithEvents txtbxFoods As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents dgvFoods As DataGridView
End Class
