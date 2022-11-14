<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dashboardHome
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
        Dim ChartArea1 As FastReport.DataVisualization.Charting.ChartArea = New FastReport.DataVisualization.Charting.ChartArea()
        Dim Legend1 As FastReport.DataVisualization.Charting.Legend = New FastReport.DataVisualization.Charting.Legend()
        Dim Series1 As FastReport.DataVisualization.Charting.Series = New FastReport.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(dashboardHome))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Chart1 = New FastReport.DataVisualization.Charting.Chart()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.prdtLabel = New System.Windows.Forms.Label()
        Me.saleLabel = New System.Windows.Forms.Label()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Impact", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(10, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 39)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "HOME"
        '
        'Chart1
        '
        Me.Chart1.BackColor = System.Drawing.Color.LightGray
        Me.Chart1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Chart1.BackImageAlignment = FastReport.DataVisualization.Charting.ChartImageAlignmentStyle.Center
        Me.Chart1.BackImageTransparentColor = System.Drawing.Color.Transparent
        Me.Chart1.BackImageWrapMode = FastReport.DataVisualization.Charting.ChartImageWrapMode.Scaled
        Me.Chart1.BackSecondaryColor = System.Drawing.Color.Transparent
        Me.Chart1.BorderlineColor = System.Drawing.Color.Black
        Me.Chart1.BorderlineWidth = 5
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(262, 75)
        Me.Chart1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Sales"
        Series1.YValuesPerPoint = 4
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(622, 329)
        Me.Chart1.TabIndex = 1
        Me.Chart1.Text = "Chart1"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.saleLabel)
        Me.Panel1.Controls.Add(Me.prdtLabel)
        Me.Panel1.Location = New System.Drawing.Point(21, 75)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(241, 329)
        Me.Panel1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(21, 28)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(863, 48)
        Me.Panel2.TabIndex = 3
        '
        'prdtLabel
        '
        Me.prdtLabel.AutoSize = True
        Me.prdtLabel.Font = New System.Drawing.Font("Tahoma", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.prdtLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.prdtLabel.Location = New System.Drawing.Point(19, 122)
        Me.prdtLabel.Name = "prdtLabel"
        Me.prdtLabel.Size = New System.Drawing.Size(184, 29)
        Me.prdtLabel.TabIndex = 0
        Me.prdtLabel.Text = "Product Name"
        '
        'saleLabel
        '
        Me.saleLabel.AutoSize = True
        Me.saleLabel.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.saleLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.saleLabel.Location = New System.Drawing.Point(19, 249)
        Me.saleLabel.Name = "saleLabel"
        Me.saleLabel.Size = New System.Drawing.Size(121, 50)
        Me.saleLabel.TabIndex = 1
        Me.saleLabel.Text = "PHP 10.00" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "5 Sold"
        '
        'dashboardHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(911, 431)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.Panel2)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "dashboardHome"
        Me.Text = "dashboardHome"
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Chart1 As FastReport.DataVisualization.Charting.Chart
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents saleLabel As Label
    Friend WithEvents prdtLabel As Label
End Class
