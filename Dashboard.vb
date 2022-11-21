Imports System.Data.SqlClient
Imports System.Security.Cryptography.X509Certificates
Imports FontAwesome.Sharp


Public Class Dashboard
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\TwentySevenFash-Program\TwentySevenFash.mdf;Integrated Security=True")
    Dim cmd As SqlCommand


    Public Property wlcm As String

    Public Shared dashboardmain
    Private Sub changeMenu(frm As Form)

        PanelContainer.Controls.Clear()
        frm.TopMost = True
        frm.TopLevel = False
        frm.Dock = DockStyle.Fill
        PanelContainer.Controls.Add(frm)
        frm.Show()
    End Sub
    Private Sub btnHome_Click(sender As Object, e As EventArgs) Handles btnHome.Click
        changeMenu(dashboardHome)

    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click
        changeMenu(dashboardSales)
    End Sub

    Private Sub btnPOS_Click(sender As Object, e As EventArgs) Handles btnPOS.Click
        changeMenu(loadingScreen)
        changeMenu(dashboardPOS)

    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        changeMenu(dashboardInventory)
        'ItemsByBelleAndJM.Show()
    End Sub
    Private Sub historyBtn(sender As Object, e As EventArgs) Handles hitoryBtn.Click
        changeMenu(History)
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        changeMenu(loadingScreen)
        changeMenu(dashboardHome)

        wlcmLabel.Text = "Welcome! " & vbNewLine & dashboardmain
        loginName.Text = dashboardmain
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = DateString
        lblTime.Text = TimeString
    End Sub

    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim confirmation As String = MsgBox("Are you sure to logout?", MsgBoxStyle.YesNo, "Logout confirmation")
        If confirmation = vbYes Then
            Me.Hide() 'hides dashboard form
            Login.Show() ' shows login form
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dim confirmation As String = MsgBox("Are you sure to Exit?", MsgBoxStyle.YesNo, "Exit Confirmation")
        If confirmation = vbYes Then
            End 'ends program
        End If
    End Sub

    Private Sub HistoryToolStripMenuItem_Click(sender As Object, e As EventArgs)
        History.Show()
    End Sub

    Private Sub SignUpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SignUpToolStripMenuItem.Click
        signup.Show()
    End Sub

    Private Sub MenuStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles MenuStrip1.ItemClicked

    End Sub

    Private Sub PanelContainer_Paint(sender As Object, e As PaintEventArgs) Handles PanelContainer.Paint

    End Sub
End Class