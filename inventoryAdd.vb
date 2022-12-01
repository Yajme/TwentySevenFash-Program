Imports System.Data.SqlClient

Public Class inventoryAdd
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\TwentySevenFash-Program\TwentySevenFash.mdf;Integrated Security=True")
    Dim cmd As SqlCommand
    Dim dr As SqlDataReader

    Private Sub IconPictureBox1_Click(sender As Object, e As EventArgs) Handles IconPictureBox1.Click
        Me.Dispose()
    End Sub



    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        Dim confirmation As String = MsgBox("Are you sure to Add Item?", MsgBoxStyle.YesNo, "Confirmation")
        If confirmation = vbYes Then
            Try
                cmd = New SqlCommand("insert into items values(@ID, @ItemName, @Brand, @Size, @NormalPrice, @SellingPrice)", con)
                cmd.Parameters.AddWithValue("@ID", txtID.Text)
                cmd.Parameters.AddWithValue("@ItemName", txtItemName.Text)
                cmd.Parameters.AddWithValue("Brand", txtBrand.Text)
                cmd.Parameters.AddWithValue("Size", cmbSize.SelectedItem)
                cmd.Parameters.AddWithValue("Price", txtNPrice.Text)
                cmd.Parameters.AddWithValue("SellingPrice", txtSPrice.Text)

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()

                MsgBox("Product Added", MsgBoxStyle.OkOnly, "New Product")

            Catch ex As Exception
                MsgBox("Database error", MsgBoxStyle.Critical)
            End Try
        End If




    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim confirmation As String = MsgBox("Are you sure to Update Item?", MsgBoxStyle.YesNo, "Confirmation")
        If confirmation = vbYes Then
            Try
                cmd = New SqlCommand("update items set ItemName=@ItemName, Brand=@Brand, Size=@Size, NormalPrice=@NormalPrice, SellingPrice=@SellingPrice where Id=@ID", con)
                cmd.Parameters.AddWithValue("@ID", txtID.Text)
                cmd.Parameters.AddWithValue("@ItemName", txtItemName.Text)
                cmd.Parameters.AddWithValue("Brand", txtBrand.Text)
                cmd.Parameters.AddWithValue("Size", cmbSize.SelectedItem)
                cmd.Parameters.AddWithValue("NormalPrice", txtNPrice.Text)
                cmd.Parameters.AddWithValue("SellingPrice", txtSPrice.Text)

                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()

                MsgBox("Product Updated", MsgBoxStyle.OkOnly, "Product Update")

            Catch ex As Exception
                MsgBox("Database error " + ex.Message, MsgBoxStyle.Critical)
            End Try
        End If
    End Sub
End Class