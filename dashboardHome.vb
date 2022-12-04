Imports System.Data.SqlClient
Imports FastReport.DataVisualization.Charting

Public Class dashboardHome
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\TwentySevenFash-Program\TwentySevenFash.mdf;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim cmdd As SqlCommand
    Dim cmds As SqlCommand
    Dim dr As SqlDataReader
    Dim store As SqlDataReader
    Dim biggst As Integer



    Private Sub dashboardHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con.Open()


        Dim val1 As Integer
        Dim val2 As Integer
        Dim vald As Integer
        Dim topName As String
        Dim topProf As Double

        val1 = 1
        vald = 0
        val2 = 0
        Dim county As New SqlCommand("select count(*) from Sales", con)
        Dim count1 = Convert.ToInt16(county.ExecuteScalar) + 2

        While val1 <= count1
            Dim doman As String = "Select productID,produtName,totalSold,totalProfit from TopSeller where productID=" & val1
            cmdd = New SqlCommand(doman, con)
            cmdd.Parameters.AddWithValue("productID", val1)
            store = cmdd.ExecuteReader()
            If (store.Read()) Then
                vald = store("totalSold")
            End If



            If vald > val2 Then
                val2 = vald
                topName = store("produtName")
                topProf = store("totalProfit")

            End If

            val1 = val1 + 1
            store.Close()
        End While

        prdtLabel.Text = topName
        saleLabel.Text = "PHP " & topProf & vbNewLine & val2 & " Sold"

        con.Close()
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

                Me.Chart1.Series("Revenue").Points.AddXY(table.Rows(count)("dateoftransaction").ToString, table.Rows(count)("revenue").ToString)

                count += 1
            End While






            con.Close()
        Catch ex As Exception
            con.Close()
            MsgBox("Error " + ex.Message, MsgBoxStyle.Critical, "error")
        End Try



    End Sub

    Private Sub Chart1_Click(sender As Object, e As EventArgs) Handles Chart1.Click

    End Sub

    Private Sub prdtLabel_Click(sender As Object, e As EventArgs) Handles prdtLabel.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call dashboardHome_Load(sender, e)
        Chart1.Series("Revenue").Points.Clear()
        LoadChart()
    End Sub
End Class