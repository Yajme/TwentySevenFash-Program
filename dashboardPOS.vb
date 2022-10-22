Imports System.Data.SqlClient
Imports FontAwesome.Sharp


Public Class dashboardPOS
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\TwentySevenFash-Program\TwentySevenFash.mdf;Integrated Security=True")
    Dim cmd As New SqlCommand("select * from items where ID= @ID, and ItemName= @ItemName, and Price= @Price", con)


End Class