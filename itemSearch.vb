Imports System.Data.SqlClient

Public Class itemSearch
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\TwentySevenFash-Program\TwentySevenFash.mdf;Integrated Security=True")
    Dim cmd As New SqlCommand("select * from items")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (ComboBox1.Text = "ID") Then
            Dim cmd As New SqlCommand("select * from Items where ID = @id", con)
            Dim cmd2 As New SqlCommand("select * from Items where Id = '" + txtSearch.Text + "'", con)
            con.Open()
            Dim sda As New SqlDataAdapter(cmd2)
            Dim ds As New DataSet()
            sda.Fill(ds)
            dgvItems.DataSource = ds.Tables(0)
            con.Close()
        ElseIf (ComboBox1.Text = "Product Name") Then
            Dim cmd As New SqlCommand("select * from Items where ID = @id", con)
            Dim cmd2 As New SqlCommand("select * from Items where ItemName = '" + txtSearch.Text + "'", con)
            con.Open()
            Dim sda As New SqlDataAdapter(cmd2)
            Dim ds As New DataSet()
            sda.Fill(ds)
            dgvItems.DataSource = ds.Tables(0)
            con.Close()
        ElseIf (ComboBox1.Text = "Brand") Then
            Dim cmd As New SqlCommand("select * from Items where ID = @id", con)
            Dim cmd2 As New SqlCommand("select * from Items where Brand ='" + txtSearch.Text + "'", con)
            con.Open()
            Dim sda As New SqlDataAdapter(cmd2)
            Dim ds As New DataSet()
            sda.Fill(ds)
            dgvItems.DataSource = ds.Tables(0)
            con.Close()
        ElseIf (ComboBox1.Text = "Size") Then
            Dim cmd As New SqlCommand("select * from Items where ID = @id", con)
            Dim cmd2 As New SqlCommand("select * from Items where Size = '" + txtSearch.Text + "'", con)
            con.Open()
            Dim sda As New SqlDataAdapter(cmd2)
            Dim ds As New DataSet()
            sda.Fill(ds)
            dgvItems.DataSource = ds.Tables(0)
            con.Close()

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
                        dgvItems.DataSource = dt
                        With dgvItems
                            .AllowUserToAddRows = False
                            .AllowUserToDeleteRows = False
                            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                            .RowHeadersVisible = False
                        End With


                    End Using
                End Using
            End Using
        End Using
    End Sub
End Class