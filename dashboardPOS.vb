Imports System.Data.SqlClient
Imports System.Windows.Documents
Imports FontAwesome.Sharp


Public Class dashboardPOS
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\TwentySevenFash-Program\TwentySevenFash.mdf;Integrated Security=True")
    Dim cmd As New SqlCommand("select * from items where ID= @ID, and ItemName= @ItemName, and Price= @Price", con)
    'SET A CLASS VARIABLE TO BE USED DURING THE FORM
    Private Count_control As Integer = 0
    Private Location_control As New Point(10, 50)
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click





    End Sub

    Private Sub dashboardPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim sda As New SqlDataAdapter(cmd)
        'Dim ItemTable As New DataTable()
        'sda.Fill(ItemTable)


        'ItemTable.Rows.Count() = 




    End Sub

    Private Sub newButton()




    End Sub
End Class