Imports System.Data.SqlClient

Public Class dashboardSales
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\TwentySevenFash-Program\TwentySevenFash.mdf;Integrated Security=True")
    Dim add As New SqlCommand("INSERT INTO sales (Profit) VALUES (@Profit)", con)
    Dim cmd As SqlCommand
    Dim cmdd As SqlCommand

    Dim dr As SqlDataReader
    Dim addi As SqlDataReader

    Private Sub dashboardSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_items()
    End Sub

    Private Sub load_items()
        con.Open()

        Dim count As New SqlCommand("Select count(*) from Sales", con)

        Dim count1 = Convert.ToInt32(count.ExecuteScalar)
        Dim val1 As Integer
        Dim val2 As Integer

        Dim expenses As Double
        Dim revenue As Double
        Dim soldshirts As Double
        Dim profit As Double

        val1 = 1
        val2 = 0

        While val1 <= count1
            Dim doman As String = "Select DateofTransaction,Id,Revenue,Expenses,Profit,SoldItems from Sales where Id=" & val1
            cmdd = New SqlCommand(doman, con)
            cmdd.Parameters.AddWithValue("Id", val1)
            addi = cmdd.ExecuteReader()
            If (addi.Read()) Then
                expenses = expenses + Val(addi("Expenses"))
                revenue = revenue + Val(addi("Revenue"))
                soldshirts = soldshirts + Val(addi("SoldItems"))
                profit = revenue - expenses

            End If
            add.Parameters.AddWithValue("@Profit", ntcmLabel.Text)
            expdLabel.Text = "PHP " & expenses
            rvnLabel.Text = "PHP " & revenue
            sldLabel.Text = soldshirts
            ntcmLabel.Text = "PHP " & profit
            val1 = val1 + 1
            addi.Close()
            If (revenue > expenses) Then
                Label5.Text = "The Business is"
                Label6.Text = "making money!"
            ElseIf (expenses > revenue) Then
                Label5.Text = "The business is"
                Label6.Text = "losing money!"

            End If
        End While

        con.Close()
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles BtnRefresh.Click
        load_items()
    End Sub
End Class