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
            Using cmd As SqlCommand = New SqlCommand("SELECT * FROM Sales", con)
                Using sda As New SqlDataAdapter()
                    sda.SelectCommand = cmd
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        dgvHistory.DataSource = dt
                        With dgvHistory
                            .AllowUserToAddRows = False
                            .AllowUserToDeleteRows = False
                            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                            .RowHeadersVisible = False
                        End With
                    End Using
                End Using
            End Using
        End Using

    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click

        Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\TwentySevenFash-Program\TwentySevenFash.mdf;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand("SELECT * FROM Sales WHERE DateofTransaction = '" & dtpDate.Text & "'", con)
                Using sda As New SqlDataAdapter(cmd)
                    sda.SelectCommand = cmd
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        dgvHistory.DataSource = dt

                        Dim totalR As Double
                        Dim totalE As Double
                        Dim totalP As Double
                        Dim totalN As Integer

                        For i As Integer = 0 To dgvHistory.RowCount - 1
                            totalR += dgvHistory.Rows(i).Cells(2).Value
                            totalE += dgvHistory.Rows(i).Cells(3).Value
                            totalP += dgvHistory.Rows(i).Cells(4).Value
                            totalN += dgvHistory.Rows(i).Cells(5).Value
                        Next

                        lblDate.Text = "Date: " & dtpDate.Text
                        lblRevenue.Text = totalR
                        lblExpenses.Text = totalE
                        lblProfit.Text = totalP
                        lblSoldItems.Text = totalN

                    End Using
                End Using
            End Using
        End Using
    End Sub

    Private Sub dgvHistory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvHistory.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        BindData()
    End Sub
End Class