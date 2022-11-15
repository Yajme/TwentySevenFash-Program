<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class History
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(History))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvHistory = New System.Windows.Forms.DataGridView()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.dtpDate = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblProfit = New System.Windows.Forms.Label()
        Me.lblExpenses = New System.Windows.Forms.Label()
        Me.lblRevenue = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgvHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Impact", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(39, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 34)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "History of Sales"
        '
        'dgvHistory
        '
        Me.dgvHistory.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHistory.Location = New System.Drawing.Point(39, 141)
        Me.dgvHistory.Name = "dgvHistory"
        Me.dgvHistory.RowTemplate.Height = 25
        Me.dgvHistory.Size = New System.Drawing.Size(644, 414)
        Me.dgvHistory.TabIndex = 1
        '
        'btnFilter
        '
        Me.btnFilter.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnFilter.Location = New System.Drawing.Point(337, 110)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(113, 23)
        Me.btnFilter.TabIndex = 6
        Me.btnFilter.Text = "Load Records"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'dtpDate
        '
        Me.dtpDate.Checked = False
        Me.dtpDate.Location = New System.Drawing.Point(131, 110)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(200, 23)
        Me.dtpDate.TabIndex = 7
        Me.dtpDate.Value = New Date(2022, 11, 15, 9, 49, 25, 0)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.lblProfit)
        Me.Panel1.Controls.Add(Me.lblExpenses)
        Me.Panel1.Controls.Add(Me.lblRevenue)
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel1.Location = New System.Drawing.Point(707, 141)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(295, 414)
        Me.Panel1.TabIndex = 9
        '
        'lblProfit
        '
        Me.lblProfit.AutoSize = True
        Me.lblProfit.BackColor = System.Drawing.Color.Transparent
        Me.lblProfit.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblProfit.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblProfit.Location = New System.Drawing.Point(25, 175)
        Me.lblProfit.Name = "lblProfit"
        Me.lblProfit.Size = New System.Drawing.Size(141, 32)
        Me.lblProfit.TabIndex = 12
        Me.lblProfit.Text = "[total profit]"
        '
        'lblExpenses
        '
        Me.lblExpenses.AutoSize = True
        Me.lblExpenses.BackColor = System.Drawing.Color.Transparent
        Me.lblExpenses.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblExpenses.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblExpenses.Location = New System.Drawing.Point(25, 126)
        Me.lblExpenses.Name = "lblExpenses"
        Me.lblExpenses.Size = New System.Drawing.Size(181, 32)
        Me.lblExpenses.TabIndex = 11
        Me.lblExpenses.Text = "[total expenses]"
        '
        'lblRevenue
        '
        Me.lblRevenue.AutoSize = True
        Me.lblRevenue.BackColor = System.Drawing.Color.Transparent
        Me.lblRevenue.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblRevenue.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblRevenue.Location = New System.Drawing.Point(25, 81)
        Me.lblRevenue.Name = "lblRevenue"
        Me.lblRevenue.Size = New System.Drawing.Size(170, 32)
        Me.lblRevenue.TabIndex = 10
        Me.lblRevenue.Text = "[total revenue]"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.BackColor = System.Drawing.Color.Transparent
        Me.lblDate.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblDate.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblDate.Location = New System.Drawing.Point(25, 33)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(75, 32)
        Me.lblDate.TabIndex = 9
        Me.lblDate.Text = "[date]"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Location = New System.Drawing.Point(39, 110)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 21)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Select Date:"
        '
        'History
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1035, 588)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.dtpDate)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.dgvHistory)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "History"
        Me.Text = "Twenty Seven Fash | History"
        CType(Me.dgvHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout

End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvHistory As DataGridView
    Friend WithEvents btnFilter As Button
    Friend WithEvents dtpDate As DateTimePicker
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblProfit As Label
    Friend WithEvents lblExpenses As Label
    Friend WithEvents lblRevenue As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents Label2 As Label
End Class
