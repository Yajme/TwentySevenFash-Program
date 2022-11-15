Imports System.Data.SqlClient

Public Class History
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\TwentySevenFash-Program\TwentySevenFash.mdf;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    Private Sub History_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindData()
    End Sub

    Private Sub BindData()
        Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\TwentySevenFash-Program\TwentySevenFash.mdf;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand("SELECT * FROM sales", con)
                Using sda As New SqlDataAdapter()
                    sda.SelectCommand = cmd
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        dgvHistory.DataSource = dt
                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub dtpDate_ValueChanged(sender As Object, e As EventArgs) Handles dtpDate.ValueChanged
        If dtpDate.Checked = True Then
            Dim cmd = New SqlCommand("SELECT * FROM Sales WHERE DateofTransaction LIKE '%" & dtpDate.Text & "%'", con)
        End If
    End Sub
End Class