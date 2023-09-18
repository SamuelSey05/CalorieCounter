<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCustomFoods
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
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtbxServe = New System.Windows.Forms.TextBox()
        Me.lblServe = New System.Windows.Forms.Label()
        Me.txtbxProteins = New System.Windows.Forms.TextBox()
        Me.lblProteins = New System.Windows.Forms.Label()
        Me.txtbxFats = New System.Windows.Forms.TextBox()
        Me.lblFats = New System.Windows.Forms.Label()
        Me.txtbxCarbs = New System.Windows.Forms.TextBox()
        Me.lblCarbs = New System.Windows.Forms.Label()
        Me.txtbxName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblG = New System.Windows.Forms.Label()
        Me.lblG2 = New System.Windows.Forms.Label()
        Me.lblG3 = New System.Windows.Forms.Label()
        Me.lblCals = New System.Windows.Forms.Label()
        Me.lblCalorie = New System.Windows.Forms.Label()
        Me.lblVCarbs = New System.Windows.Forms.Label()
        Me.lblVFats = New System.Windows.Forms.Label()
        Me.lblVProteins = New System.Windows.Forms.Label()
        Me.lblEmpty = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCreate
        '
        Me.btnCreate.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.Location = New System.Drawing.Point(201, 336)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(96, 46)
        Me.btnCreate.TabIndex = 5
        Me.btnCreate.Text = "Create"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(24, 34)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(89, 45)
        Me.btnBack.TabIndex = 6
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'txtbxServe
        '
        Me.txtbxServe.Location = New System.Drawing.Point(259, 292)
        Me.txtbxServe.Name = "txtbxServe"
        Me.txtbxServe.Size = New System.Drawing.Size(100, 20)
        Me.txtbxServe.TabIndex = 4
        '
        'lblServe
        '
        Me.lblServe.AutoSize = True
        Me.lblServe.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblServe.Location = New System.Drawing.Point(68, 289)
        Me.lblServe.Name = "lblServe"
        Me.lblServe.Size = New System.Drawing.Size(81, 16)
        Me.lblServe.TabIndex = 29
        Me.lblServe.Text = "Serving size:"
        '
        'txtbxProteins
        '
        Me.txtbxProteins.Location = New System.Drawing.Point(259, 218)
        Me.txtbxProteins.Name = "txtbxProteins"
        Me.txtbxProteins.Size = New System.Drawing.Size(100, 20)
        Me.txtbxProteins.TabIndex = 3
        '
        'lblProteins
        '
        Me.lblProteins.AutoSize = True
        Me.lblProteins.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProteins.Location = New System.Drawing.Point(68, 219)
        Me.lblProteins.Name = "lblProteins"
        Me.lblProteins.Size = New System.Drawing.Size(115, 16)
        Me.lblProteins.TabIndex = 27
        Me.lblProteins.Text = "Proteins per serve:"
        '
        'txtbxFats
        '
        Me.txtbxFats.Location = New System.Drawing.Point(259, 183)
        Me.txtbxFats.Name = "txtbxFats"
        Me.txtbxFats.Size = New System.Drawing.Size(100, 20)
        Me.txtbxFats.TabIndex = 2
        '
        'lblFats
        '
        Me.lblFats.AutoSize = True
        Me.lblFats.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFats.Location = New System.Drawing.Point(68, 181)
        Me.lblFats.Name = "lblFats"
        Me.lblFats.Size = New System.Drawing.Size(93, 16)
        Me.lblFats.TabIndex = 37
        Me.lblFats.Text = "Fats per serve:"
        '
        'txtbxCarbs
        '
        Me.txtbxCarbs.Location = New System.Drawing.Point(259, 148)
        Me.txtbxCarbs.Name = "txtbxCarbs"
        Me.txtbxCarbs.Size = New System.Drawing.Size(100, 20)
        Me.txtbxCarbs.TabIndex = 1
        '
        'lblCarbs
        '
        Me.lblCarbs.AutoSize = True
        Me.lblCarbs.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarbs.Location = New System.Drawing.Point(68, 145)
        Me.lblCarbs.Name = "lblCarbs"
        Me.lblCarbs.Size = New System.Drawing.Size(151, 16)
        Me.lblCarbs.TabIndex = 35
        Me.lblCarbs.Text = "Carbohydrates per serve:"
        '
        'txtbxName
        '
        Me.txtbxName.Location = New System.Drawing.Point(259, 103)
        Me.txtbxName.Name = "txtbxName"
        Me.txtbxName.Size = New System.Drawing.Size(154, 20)
        Me.txtbxName.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(68, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 16)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Name:"
        '
        'lblUnits
        '
        Me.lblUnits.AutoSize = True
        Me.lblUnits.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnits.Location = New System.Drawing.Point(381, 292)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(14, 16)
        Me.lblUnits.TabIndex = 39
        Me.lblUnits.Text = "g"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(164, 32)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(179, 36)
        Me.lblTitle.TabIndex = 41
        Me.lblTitle.Text = "Create food"
        '
        'lblG
        '
        Me.lblG.AutoSize = True
        Me.lblG.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblG.Location = New System.Drawing.Point(365, 152)
        Me.lblG.Name = "lblG"
        Me.lblG.Size = New System.Drawing.Size(14, 16)
        Me.lblG.TabIndex = 42
        Me.lblG.Text = "g"
        '
        'lblG2
        '
        Me.lblG2.AutoSize = True
        Me.lblG2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblG2.Location = New System.Drawing.Point(365, 184)
        Me.lblG2.Name = "lblG2"
        Me.lblG2.Size = New System.Drawing.Size(14, 16)
        Me.lblG2.TabIndex = 43
        Me.lblG2.Text = "g"
        '
        'lblG3
        '
        Me.lblG3.AutoSize = True
        Me.lblG3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblG3.Location = New System.Drawing.Point(365, 222)
        Me.lblG3.Name = "lblG3"
        Me.lblG3.Size = New System.Drawing.Size(14, 16)
        Me.lblG3.TabIndex = 44
        Me.lblG3.Text = "g"
        '
        'lblCals
        '
        Me.lblCals.AutoSize = True
        Me.lblCals.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCals.Location = New System.Drawing.Point(256, 257)
        Me.lblCals.Name = "lblCals"
        Me.lblCals.Size = New System.Drawing.Size(120, 16)
        Me.lblCals.TabIndex = 45
        Me.lblCals.Text = "[TOTAL CALS] cals"
        '
        'lblCalorie
        '
        Me.lblCalorie.AutoSize = True
        Me.lblCalorie.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalorie.Location = New System.Drawing.Point(68, 254)
        Me.lblCalorie.Name = "lblCalorie"
        Me.lblCalorie.Size = New System.Drawing.Size(114, 16)
        Me.lblCalorie.TabIndex = 46
        Me.lblCalorie.Text = "Calories per serve:"
        '
        'lblVCarbs
        '
        Me.lblVCarbs.AutoSize = True
        Me.lblVCarbs.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVCarbs.ForeColor = System.Drawing.Color.Red
        Me.lblVCarbs.Location = New System.Drawing.Point(418, 152)
        Me.lblVCarbs.Name = "lblVCarbs"
        Me.lblVCarbs.Size = New System.Drawing.Size(125, 16)
        Me.lblVCarbs.TabIndex = 47
        Me.lblVCarbs.Text = "Enter a valid number"
        Me.lblVCarbs.Visible = False
        '
        'lblVFats
        '
        Me.lblVFats.AutoSize = True
        Me.lblVFats.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVFats.ForeColor = System.Drawing.Color.Red
        Me.lblVFats.Location = New System.Drawing.Point(418, 187)
        Me.lblVFats.Name = "lblVFats"
        Me.lblVFats.Size = New System.Drawing.Size(125, 16)
        Me.lblVFats.TabIndex = 48
        Me.lblVFats.Text = "Enter a valid number"
        Me.lblVFats.Visible = False
        '
        'lblVProteins
        '
        Me.lblVProteins.AutoSize = True
        Me.lblVProteins.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVProteins.ForeColor = System.Drawing.Color.Red
        Me.lblVProteins.Location = New System.Drawing.Point(418, 222)
        Me.lblVProteins.Name = "lblVProteins"
        Me.lblVProteins.Size = New System.Drawing.Size(125, 16)
        Me.lblVProteins.TabIndex = 49
        Me.lblVProteins.Text = "Enter a valid number"
        Me.lblVProteins.Visible = False
        '
        'lblEmpty
        '
        Me.lblEmpty.AutoSize = True
        Me.lblEmpty.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpty.ForeColor = System.Drawing.Color.Red
        Me.lblEmpty.Location = New System.Drawing.Point(198, 73)
        Me.lblEmpty.Name = "lblEmpty"
        Me.lblEmpty.Size = New System.Drawing.Size(120, 16)
        Me.lblEmpty.TabIndex = 50
        Me.lblEmpty.Text = "Fill out empty fields"
        Me.lblEmpty.Visible = False
        '
        'AddCustomFoods
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 398)
        Me.Controls.Add(Me.lblEmpty)
        Me.Controls.Add(Me.lblVProteins)
        Me.Controls.Add(Me.lblVFats)
        Me.Controls.Add(Me.lblVCarbs)
        Me.Controls.Add(Me.lblCalorie)
        Me.Controls.Add(Me.lblCals)
        Me.Controls.Add(Me.lblG3)
        Me.Controls.Add(Me.lblG2)
        Me.Controls.Add(Me.lblG)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.txtbxFats)
        Me.Controls.Add(Me.lblFats)
        Me.Controls.Add(Me.txtbxCarbs)
        Me.Controls.Add(Me.lblCarbs)
        Me.Controls.Add(Me.txtbxName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtbxServe)
        Me.Controls.Add(Me.lblServe)
        Me.Controls.Add(Me.txtbxProteins)
        Me.Controls.Add(Me.lblProteins)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnCreate)
        Me.Name = "AddCustomFoods"
        Me.Text = "Create custom food"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCreate As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents txtbxServe As TextBox
    Friend WithEvents lblServe As Label
    Friend WithEvents txtbxProteins As TextBox
    Friend WithEvents lblProteins As Label
    Friend WithEvents txtbxFats As TextBox
    Friend WithEvents lblFats As Label
    Friend WithEvents txtbxCarbs As TextBox
    Friend WithEvents lblCarbs As Label
    Friend WithEvents txtbxName As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblUnits As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblG As Label
    Friend WithEvents lblG2 As Label
    Friend WithEvents lblG3 As Label
    Friend WithEvents lblCals As Label
    Friend WithEvents lblCalorie As Label
    Friend WithEvents lblVCarbs As Label
    Friend WithEvents lblVFats As Label
    Friend WithEvents lblVProteins As Label
    Friend WithEvents lblEmpty As Label
End Class
