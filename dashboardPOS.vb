Imports System.Data.SqlClient
Imports System.Windows.Documents
Imports FontAwesome.Sharp


Public Class dashboardPOS
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\TwentySevenFash-Program\TwentySevenFash.mdf;Integrated Security=True")
    Dim cmd As SqlCommand
    'SET A CLASS VARIABLE TO BE USED DURING THE FORM
    Private Count_control As Integer = 0
    Private ButtonName As String = Nothing
    Private Location_control As New Point(10, 50)
    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click





    End Sub

    Private Sub dashboardPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        LoadItems()

    End Sub

    Private Sub LoadItems()
        con.Open()
        Dim cmd As New SqlCommand("select * from items", con)

        Dim sda As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        sda.Fill(table)
        Count_control = table.Rows.Count()

        Dim count As Integer = 0

        Do

            Dim newButton As Button
            newButton = New Button()

            With newButton
                .BackColor = Color.White
                .Size = New Size(162, 123)
                .Name = "btnItem" + Count_control.ToString
                .Text = table.Rows(count)("ItemName").ToString()
            End With

            FlowLayoutPanel1.Controls.Add(newButton)

            count += 1
        Loop Until count = Count_control


    End Sub

End Class