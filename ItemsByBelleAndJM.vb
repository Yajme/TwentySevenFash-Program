Imports System.Data.SqlClient

Public Class ItemsByBelleAndJM
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\TwentySevenFash-Program\TwentySevenFash.mdf;Integrated Security=True")
    Dim qry As String = ""
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (ComboBox1.SelectedItem = "ID") Then
            Dim cmd As New SqlCommand("select * from Items where ID = @id", con)
            con.Open()


        End If
    End Sub

    Private Sub ItemsByBelleAndJM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Bind()
    End Sub
    Private Sub Bind()

    End Sub
End Class