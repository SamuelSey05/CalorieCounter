<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DayView
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
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblFats = New System.Windows.Forms.Label()
        Me.lblProtein = New System.Windows.Forms.Label()
        Me.lblCarbs = New System.Windows.Forms.Label()
        Me.lblCals = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.txtbxFoods = New System.Windows.Forms.TextBox()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.dgvFoods = New System.Windows.Forms.DataGridView()
        Me.chrtCals = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.dgvFoods, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chrtCals, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(12, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(84, 36)
        Me.btnBack.TabIndex = 4
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblFats
        '
        Me.lblFats.AutoSize = True
        Me.lblFats.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFats.Location = New System.Drawing.Point(266, 111)
        Me.lblFats.Name = "lblFats"
        Me.lblFats.Size = New System.Drawing.Size(62, 16)
        Me.lblFats.TabIndex = 57
        Me.lblFats.Text = "Fats: 78g"
        '
        'lblProtein
        '
        Me.lblProtein.AutoSize = True
        Me.lblProtein.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProtein.Location = New System.Drawing.Point(266, 155)
        Me.lblProtein.Name = "lblProtein"
        Me.lblProtein.Size = New System.Drawing.Size(91, 16)
        Me.lblProtein.TabIndex = 56
        Me.lblProtein.Text = "Proteins: 180g"
        '
        'lblCarbs
        '
        Me.lblCarbs.AutoSize = True
        Me.lblCarbs.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarbs.Location = New System.Drawing.Point(104, 155)
        Me.lblCarbs.Name = "lblCarbs"
        Me.lblCarbs.Size = New System.Drawing.Size(131, 16)
        Me.lblCarbs.TabIndex = 55
        Me.lblCarbs.Text = "Carbohydrates: 285g "
        '
        'lblCals
        '
        Me.lblCals.AutoSize = True
        Me.lblCals.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCals.Location = New System.Drawing.Point(104, 111)
        Me.lblCals.Name = "lblCals"
        Me.lblCals.Size = New System.Drawing.Size(69, 16)
        Me.lblCals.TabIndex = 54
        Me.lblCals.Text = "Cals: 2806"
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(509, 43)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(82, 30)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = "-->"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrev.Location = New System.Drawing.Point(182, 43)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(82, 30)
        Me.btnPrev.TabIndex = 0
        Me.btnPrev.Text = "<--"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'txtbxFoods
        '
        Me.txtbxFoods.Location = New System.Drawing.Point(45, 184)
        Me.txtbxFoods.Name = "txtbxFoods"
        Me.txtbxFoods.Size = New System.Drawing.Size(368, 20)
        Me.txtbxFoods.TabIndex = 2
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(320, 45)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(142, 24)
        Me.lblDate.TabIndex = 51
        Me.lblDate.Text = "DD/MM/YYYY"
        '
        'dgvFoods
        '
        Me.dgvFoods.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFoods.Location = New System.Drawing.Point(45, 201)
        Me.dgvFoods.Name = "dgvFoods"
        Me.dgvFoods.Size = New System.Drawing.Size(368, 150)
        Me.dgvFoods.TabIndex = 3
        '
        'chrtCals
        '
        Me.chrtCals.BackColor = System.Drawing.Color.Transparent
        Me.chrtCals.BorderlineColor = System.Drawing.Color.Transparent
        ChartArea1.Name = "ChartArea1"
        Me.chrtCals.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chrtCals.Legends.Add(Legend1)
        Me.chrtCals.Location = New System.Drawing.Point(435, 111)
        Me.chrtCals.Name = "chrtCals"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.chrtCals.Series.Add(Series1)
        Me.chrtCals.Size = New System.Drawing.Size(300, 300)
        Me.chrtCals.TabIndex = 59
        '
        'DayView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 439)
        Me.Controls.Add(Me.chrtCals)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblFats)
        Me.Controls.Add(Me.lblProtein)
        Me.Controls.Add(Me.lblCarbs)
        Me.Controls.Add(Me.lblCals)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.txtbxFoods)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.dgvFoods)
        Me.Name = "DayView"
        Me.Text = "DayView"
        CType(Me.dgvFoods, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chrtCals, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents lblFats As Label
    Friend WithEvents lblProtein As Label
    Friend WithEvents lblCarbs As Label
    Friend WithEvents lblCals As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrev As Button
    Friend WithEvents txtbxFoods As TextBox
    Friend WithEvents lblDate As Label
    Friend WithEvents dgvFoods As DataGridView
    Friend WithEvents chrtCals As DataVisualization.Charting.Chart
End Class
