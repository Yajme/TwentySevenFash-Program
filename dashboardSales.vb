Imports System.Data.SqlClient

Public Class dashboardSales
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\TwentySevenFash-Program\TwentySevenFash.mdf;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim cmdd As SqlCommand

    Dim dr As SqlDataReader
    Dim addi As SqlDataReader

    Private Sub dashboardSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        con.Open()

        Dim val1 As Integer
        Dim val2 As Integer

        Dim expenses As Double

        val1 = 1
        val2 = 0

        While val1 <= 3
            Dim doman As String = "Select DateofTransaction,Id,Revenue,Expenses,Profit,SoldItems from Sales where Id=" & val1
            cmdd = New SqlCommand(doman, con)
            cmdd.Parameters.AddWithValue("Id", val1)
            addi = cmdd.ExecuteReader()
            If (addi.Read()) Then
                expenses = expenses + addi("Expenses")
            End If

            expdLabel.Text = "PHP" & expenses

            val1 = val1 + 1
            addi.Close()
        End While

        con.Close()

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class