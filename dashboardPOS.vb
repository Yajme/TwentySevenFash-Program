Imports System.Data.SqlClient
Imports System.Windows.Documents
Imports FontAwesome.Sharp


Public Class dashboardPOS
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\TwentySevenFash-Program\TwentySevenFash.mdf;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader
    Private Count_control As Integer = 0
    Dim newButton As Button
    Dim total As Double
    Dim transcID As Integer

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click


    End Sub

    Private Sub dashboardPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadItems()

    End Sub

    Private Sub LoadItems()
        con.Open()
        cmd = New SqlCommand("select * from items", con)

        Dim sda As New SqlDataAdapter(cmd)
        Dim table As New DataTable
        sda.Fill(table)
        Count_control = table.Rows.Count()
        Dim buttonName(Count_control) As String
        Dim count As Integer = 0



        Do
            newButton = New Button()

            With newButton
                .BackColor = Color.White
                .Size = New Size(162, 123)
                .Name = "btnItem" + count.ToString()
                .Tag = table.Rows(count)("ID").ToString()
                .Text = table.Rows(count)("ItemName").ToString()
            End With


            FlowLayoutPanel1.Controls.Add(newButton)



            buttonName(count) = newButton.Name

            AddHandler newButton.Click, AddressOf DynamicButton_click

            count += 1
        Loop Until count = Count_control

        con.Close()
    End Sub

    Public Sub DynamicButton_click(ByVal sender As Object, ByVal e As EventArgs)
        con.Open()

        cmd = New SqlCommand("select * from Items where ID= @ID", con)
        cmd.Parameters.Add("@ID", SqlDbType.Int).Value = sender.tag.ToString
        dr = cmd.ExecuteReader

        While dr.Read
            total += CDbl(dr.Item("price").ToString)
            DataGridView1.Rows.Add(dr.Item("Id").ToString, dr.Item("ItemName").ToString, Format(CDbl(dr.Item("Price").ToString), "#,##0.00"))
        End While
        dr.Close()
        con.Close()
        lblTotal.Text = Format(total, "#,##.00")
    End Sub

    Private Sub IconButton2_Click(sender As Object, e As EventArgs) Handles IconButton2.Click
        DataGridView1.Rows.Clear()
        lblTotal.Text = "0.00"
        total = 0
    End Sub

    Private Sub IconButton4_Click(sender As Object, e As EventArgs) Handles IconButton4.Click
        cmd = New SqlCommand("insert into Sales values(@ID,@Expenses,@Sales,@Profit,@Numberofsoldshirts)")
        cmd.Parameters.Add("@ID", transcID)
        cmd.Parameters.Add("@Expenses")
        cmd.Parameters.Add("@Expenses")
        cmd.Parameters.Add("@Expenses")
        cmd.Parameters.Add("@Expenses")

    End Sub
End Class