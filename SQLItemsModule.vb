Imports System.Data.SqlClient

Module SQLItemsModule
    Public connectionstring As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\TwentySevenFash-Program\TwentySevenFash.mdf;Integrated Security=True"
    Public con As New SqlConnection(connectionstring)


End Module
