Imports System.Data.SqlClient
Imports System.Windows.Controls

Public Class dashboardInventory
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\TwentySevenFash-Program\TwentySevenFash.mdf;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim cmdd As New SqlCommand("select * from items")
    Dim dr As SqlDataReader
    Private Sub dashboardInventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadItems()
    End Sub


    Private Sub LoadItems()
        con.Open()
        cmd = New SqlCommand("select * from items", con)
        dr = cmd.ExecuteReader
        DataGridView1.Rows.Clear()

        While dr.Read
            DataGridView1.Rows.Add(dr.Item("ID"), dr.Item("ItemName"), dr.Item("Brand"), dr.Item("Size"), dr.Item("price"))
        End While
        dr.Close()
        con.Close()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim colName As String = DataGridView1.Columns(e.ColumnIndex).Name
        If colName = "colEdit" Then
            With inventoryAdd
                .lblTitle.Text = "Update Item"
                .txtID.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
                .txtItemName.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
                .txtBrand.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString
                .cmbSize.SelectedItem = DataGridView1.Rows(e.RowIndex).Cells(3).Value.ToString
                .txtPrice.Text = DataGridView1.Rows(e.RowIndex).Cells(4).Value.ToString
                .btnUpdate.Enabled = True
                .btnAddItem.Visible = False
                .ShowDialog()
            End With
            LoadItems()
        ElseIf colName = "ColDelete" Then
            If MsgBox("Are you Sure to Delete this record?", vbYesNo + vbQuestion, "Confirmation") = vbYes Then
                con.Open()
                cmd = New SqlCommand("delete from Items where ID= @ID", con)
                cmd.Parameters.Add("ID", SqlDbType.Int).Value = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
                cmd.ExecuteNonQuery()
                con.Close()
                MsgBox("Record Successfully deleted", vbInformation, "Confirmation")
                LoadItems()
            End If
        End If


    End Sub

    Private Sub IconButton3_Click(sender As Object, e As EventArgs) Handles IconButton3.Click

        With inventoryAdd
            .lblTitle.Text = "Add Items"
            .btnUpdate.Visible = False
            .btnAddItem.Enabled = True
            .ShowDialog()
        End With
        loaditems()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        loaditems()
    End Sub



    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        DataGridView1.Rows.Clear()

        If (ComboBox1.Text = "ID") Then
            Try
                Dim cmdd As New SqlCommand("select * from Items where ID = @ID", con)
                cmdd.Parameters.Add("@ID", SqlDbType.Int).Value = txtSearch.Text
                con.Open()
                dr = cmdd.ExecuteReader
                While dr.Read
                    DataGridView1.Rows.Add(dr.Item("ID"), dr.Item("ItemName"), dr.Item("Brand"), dr.Item("Size"), dr.Item("Price"))
                End While
                dr.Close()
                con.Close()
            Catch ex As Exception
                con.Close()
                MsgBox(ex.Message + " error")
            End Try

        ElseIf (ComboBox1.Text = "Product Name") Then
            Try
                Dim cmdd As New SqlCommand("select * from Items where ItemName= @ItemName", con)
                cmdd.Parameters.Add("@ItemName", SqlDbType.VarChar).Value = txtSearch.Text
                con.Open()
                dr = cmdd.ExecuteReader
                While dr.Read
                    DataGridView1.Rows.Add(dr.Item("ID"), dr.Item("ItemName"), dr.Item("Brand"), dr.Item("Size"), dr.Item("Price"))
                End While
                dr.Close()
                con.Close()
            Catch ex As Exception
                con.Close()
                MsgBox(ex.Message + " error")
            End Try
        ElseIf (ComboBox1.Text = "Brand") Then
            Try
                Dim cmdd As New SqlCommand("select * from Items where Brand= @Brand", con)
                cmdd.Parameters.Add("@Brand", SqlDbType.VarChar).Value = txtSearch.Text
                con.Open()
                dr = cmdd.ExecuteReader
                While dr.Read
                    DataGridView1.Rows.Add(dr.Item("ID"), dr.Item("ItemName"), dr.Item("Brand"), dr.Item("Size"), dr.Item("Price"))
                End While
                dr.Close()
                con.Close()
            Catch ex As Exception
                con.Close()
                MsgBox(ex.Message + " error")
            End Try
        ElseIf (ComboBox1.Text = "Size") Then
            Try
                Dim cmdd As New SqlCommand("select * from Items where Size= @size", con)
                cmdd.Parameters.Add("@size", SqlDbType.VarChar).Value = txtSearch.Text
                con.Open()
                dr = cmdd.ExecuteReader
                While dr.Read
                    DataGridView1.Rows.Add(dr.Item("ID"), dr.Item("ItemName"), dr.Item("Brand"), dr.Item("Size"), dr.Item("Price"))
                End While
                dr.Close()
                con.Close()
            Catch ex As Exception
                con.Close()
                MsgBox(ex.Message + " error")
            End Try
        End If
    End Sub
End Class