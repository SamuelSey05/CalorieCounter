<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WeekView
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
        Me.DataSet1 = New System.Data.DataSet()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblFats = New System.Windows.Forms.Label()
        Me.lblProtein = New System.Windows.Forms.Label()
        Me.lblCarbs = New System.Windows.Forms.Label()
        Me.lblCals = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.chrtWeek = New System.Windows.Forms.DataVisualization.Charting.Chart()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chrtWeek, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "NewDataSet"
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(12, 12)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(84, 36)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblFats
        '
        Me.lblFats.AutoSize = True
        Me.lblFats.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFats.Location = New System.Drawing.Point(368, 126)
        Me.lblFats.Name = "lblFats"
        Me.lblFats.Size = New System.Drawing.Size(107, 16)
        Me.lblFats.TabIndex = 55
        Me.lblFats.Text = "Average fats: 78g"
        '
        'lblProtein
        '
        Me.lblProtein.AutoSize = True
        Me.lblProtein.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProtein.Location = New System.Drawing.Point(368, 170)
        Me.lblProtein.Name = "lblProtein"
        Me.lblProtein.Size = New System.Drawing.Size(139, 16)
        Me.lblProtein.TabIndex = 54
        Me.lblProtein.Text = "Average proteins: 180g"
        '
        'lblCarbs
        '
        Me.lblCarbs.AutoSize = True
        Me.lblCarbs.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCarbs.Location = New System.Drawing.Point(169, 170)
        Me.lblCarbs.Name = "lblCarbs"
        Me.lblCarbs.Size = New System.Drawing.Size(179, 16)
        Me.lblCarbs.TabIndex = 53
        Me.lblCarbs.Text = "Average carbohydrates: 285g "
        '
        'lblCals
        '
        Me.lblCals.AutoSize = True
        Me.lblCals.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCals.Location = New System.Drawing.Point(169, 126)
        Me.lblCals.Name = "lblCals"
        Me.lblCals.Size = New System.Drawing.Size(117, 16)
        Me.lblCals.TabIndex = 52
        Me.lblCals.Text = "Average cals: 2806"
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(511, 69)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(82, 30)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = "-->"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrev
        '
        Me.btnPrev.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrev.Location = New System.Drawing.Point(63, 67)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(82, 30)
        Me.btnPrev.TabIndex = 0
        Me.btnPrev.Text = "<--"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(183, 71)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(293, 24)
        Me.lblDate.TabIndex = 49
        Me.lblDate.Text = "DD/MM/YYYY - DD/MM/YYYY"
        '
        'chrtWeek
        '
        ChartArea1.Name = "ChartArea1"
        Me.chrtWeek.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.chrtWeek.Legends.Add(Legend1)
        Me.chrtWeek.Location = New System.Drawing.Point(37, 225)
        Me.chrtWeek.Name = "chrtWeek"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Date]
        Series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.[Double]
        Me.chrtWeek.Series.Add(Series1)
        Me.chrtWeek.Size = New System.Drawing.Size(593, 196)
        Me.chrtWeek.TabIndex = 57
        Me.chrtWeek.Text = "Chart1"
        '
        'WeekView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(693, 433)
        Me.Controls.Add(Me.chrtWeek)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblFats)
        Me.Controls.Add(Me.lblProtein)
        Me.Controls.Add(Me.lblCarbs)
        Me.Controls.Add(Me.lblCals)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.lblDate)
        Me.Name = "WeekView"
        Me.Text = "[STUDENT USER]"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chrtWeek, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSet1 As DataSet
    Friend WithEvents btnBack As Button
    Friend WithEvents lblFats As Label
    Friend WithEvents lblProtein As Label
    Friend WithEvents lblCarbs As Label
    Friend WithEvents lblCals As Label
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrev As Button
    Friend WithEvents lblDate As Label
    Friend WithEvents chrtWeek As DataVisualization.Charting.Chart
End Class
