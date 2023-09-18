<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FoodLog
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
        Me.txtbxFoods = New System.Windows.Forms.TextBox()
        Me.dgvFoods = New System.Windows.Forms.DataGridView()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnCustomFood = New System.Windows.Forms.Button()
        CType(Me.dgvFoods, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtbxFoods
        '
        Me.txtbxFoods.Location = New System.Drawing.Point(52, 162)
        Me.txtbxFoods.Name = "txtbxFoods"
        Me.txtbxFoods.Size = New System.Drawing.Size(334, 20)
        Me.txtbxFoods.TabIndex = 0
        '
        'dgvFoods
        '
        Me.dgvFoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFoods.Location = New System.Drawing.Point(52, 179)
        Me.dgvFoods.Name = "dgvFoods"
        Me.dgvFoods.Size = New System.Drawing.Size(334, 150)
        Me.dgvFoods.TabIndex = 1
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(21, 22)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(85, 38)
        Me.btnBack.TabIndex = 3
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(72, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(350, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Select the food you would like to log:"
        '
        'btnCustomFood
        '
        Me.btnCustomFood.Location = New System.Drawing.Point(407, 233)
        Me.btnCustomFood.Name = "btnCustomFood"
        Me.btnCustomFood.Size = New System.Drawing.Size(95, 44)
        Me.btnCustomFood.TabIndex = 2
        Me.btnCustomFood.Text = "Custom foods"
        Me.btnCustomFood.UseVisualStyleBackColor = True
        '
        'FoodLog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 384)
        Me.Controls.Add(Me.btnCustomFood)
        Me.Controls.Add(Me.txtbxFoods)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.dgvFoods)
        Me.Name = "FoodLog"
        Me.Text = "Food Log"
        CType(Me.dgvFoods, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtbxFoods As TextBox
    Friend WithEvents dgvFoods As DataGridView
    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCustomFood As Button
End Class
