Imports System.Data.SqlClient
Imports FontAwesome.Sharp


Public Class Dashboard
    Dim con As New SqlConnection("Data Source=LAPTOP-5ILOR9MQ;Initial Catalog=TwentySevenFash;Integrated Security=True")
    Dim cmd As SqlCommand

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

    End Sub

    Private Sub btnSales_Click(sender As Object, e As EventArgs) Handles btnSales.Click

    End Sub

    Private Sub btnPOS_Click(sender As Object, e As EventArgs) Handles btnPOS.Click
        changeMenu(dashboardPOS)
    End Sub

    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblDate.Text = DateString
        lblTime.Text = TimeString
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class