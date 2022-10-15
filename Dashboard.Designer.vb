<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Me.components = New System.ComponentModel.Container()
        Me.SidePanel = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnInventory = New FontAwesome.Sharp.IconButton()
        Me.btnSales = New FontAwesome.Sharp.IconButton()
        Me.btnPOS = New FontAwesome.Sharp.IconButton()
        Me.btnHome = New FontAwesome.Sharp.IconButton()
        Me.PanelContainer = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.SidePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'SidePanel
        '
        Me.SidePanel.Controls.Add(Me.Panel2)
        Me.SidePanel.Controls.Add(Me.btnInventory)
        Me.SidePanel.Controls.Add(Me.btnSales)
        Me.SidePanel.Controls.Add(Me.btnPOS)
        Me.SidePanel.Controls.Add(Me.btnHome)
        Me.SidePanel.Location = New System.Drawing.Point(1, 0)
        Me.SidePanel.Name = "SidePanel"
        Me.SidePanel.Size = New System.Drawing.Size(280, 724)
        Me.SidePanel.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(286, 143)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1041, 562)
        Me.Panel2.TabIndex = 1
        '
        'btnInventory
        '
        Me.btnInventory.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnInventory.IconColor = System.Drawing.Color.Black
        Me.btnInventory.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnInventory.Location = New System.Drawing.Point(0, 526)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(280, 132)
        Me.btnInventory.TabIndex = 3
        Me.btnInventory.Text = "Inventory"
        Me.btnInventory.UseVisualStyleBackColor = True
        '
        'btnSales
        '
        Me.btnSales.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnSales.IconColor = System.Drawing.Color.Black
        Me.btnSales.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnSales.Location = New System.Drawing.Point(0, 398)
        Me.btnSales.Name = "btnSales"
        Me.btnSales.Size = New System.Drawing.Size(280, 132)
        Me.btnSales.TabIndex = 2
        Me.btnSales.Text = "Sales"
        Me.btnSales.UseVisualStyleBackColor = True
        '
        'btnPOS
        '
        Me.btnPOS.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnPOS.IconColor = System.Drawing.Color.Black
        Me.btnPOS.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnPOS.Location = New System.Drawing.Point(0, 270)
        Me.btnPOS.Name = "btnPOS"
        Me.btnPOS.Size = New System.Drawing.Size(280, 132)
        Me.btnPOS.TabIndex = 1
        Me.btnPOS.Text = "POS"
        Me.btnPOS.UseVisualStyleBackColor = True
        '
        'btnHome
        '
        Me.btnHome.IconChar = FontAwesome.Sharp.IconChar.None
        Me.btnHome.IconColor = System.Drawing.Color.Black
        Me.btnHome.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.btnHome.Location = New System.Drawing.Point(0, 143)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(280, 132)
        Me.btnHome.TabIndex = 0
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'PanelContainer
        '
        Me.PanelContainer.Location = New System.Drawing.Point(287, 143)
        Me.PanelContainer.Name = "PanelContainer"
        Me.PanelContainer.Size = New System.Drawing.Size(1041, 575)
        Me.PanelContainer.TabIndex = 1
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(1177, 47)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(101, 20)
        Me.lblDate.TabIndex = 2
        Me.lblDate.Text = "MM/DD/YYYY"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(1177, 84)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(63, 20)
        Me.lblTime.TabIndex = 3
        Me.lblTime.Text = "00:00:00"
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1340, 717)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.PanelContainer)
        Me.Controls.Add(Me.SidePanel)
        Me.MaximumSize = New System.Drawing.Size(1358, 764)
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.SidePanel.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SidePanel As Panel
    Friend WithEvents btnInventory As FontAwesome.Sharp.IconButton
    Friend WithEvents btnSales As FontAwesome.Sharp.IconButton
    Friend WithEvents btnPOS As FontAwesome.Sharp.IconButton
    Friend WithEvents btnHome As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PanelContainer As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTime As Label
End Class
