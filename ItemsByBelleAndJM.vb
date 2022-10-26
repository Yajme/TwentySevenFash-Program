Imports System.Data.SqlClient

Public Class ItemsByBelleAndJM
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\TwentySevenFash-Program\TwentySevenFash.mdf;Integrated Security=True")
    Dim cmd As New SqlCommand("select * from items")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (ComboBox1.SelectedItem = "ID") Then
            Dim cmd As New SqlCommand("select * from Items where ID = @id", con)
            con.Open()


        End If
    End Sub

    Private Sub ItemsByBelleAndJM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindData()
    End Sub
    Private Sub BindData()
        Using con As SqlConnection = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\TwentySevenFash-Program\TwentySevenFash.mdf;Integrated Security=True")
            Using cmd As SqlCommand = New SqlCommand("select * from items", con)
                Using sda As New SqlDataAdapter()
                    sda.SelectCommand = cmd
                    Using dt As New DataTable()
                        sda.Fill(dt)
                        DataGridView1.DataSource = dt
                    End Using
                End Using
                End Using
            End Using
    End Sub
End Class