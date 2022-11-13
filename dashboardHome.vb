Imports System.Data.SqlClient
Imports FastReport.DataVisualization.Charting

Public Class dashboardHome
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\TwentySevenFash-Program\TwentySevenFash.mdf;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader


    Private Sub dashboardHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadChart()
    End Sub

    Private Sub TodayDate()




    End Sub
    Private Sub LoadChart()
        Try
            con.Open()
            cmd = New SqlCommand("select * from Sales", con)
            Dim sda As New SqlDataAdapter(cmd)
            Dim table As New DataTable
            sda.Fill(table)

            Dim count As Integer = 0
            Dim count_control As Integer = table.Rows.Count()
            While count < count_control

                Me.Chart1.Series("Sales").Points.AddXY(table.Rows(count)("dateoftransaction").ToString, table.Rows(count)("sales").ToString)

                count += 1
            End While






            con.Close()
        Catch ex As Exception
            con.Close()
            MsgBox("Error " + ex.Message, MsgBoxStyle.Critical, "error")
        End Try



    End Sub

End Class