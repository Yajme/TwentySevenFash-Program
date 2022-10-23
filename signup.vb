Imports FontAwesome.Sharp
Imports System.Data.SqlClient


Public Class signup
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\TwentySevenFash-Program\TwentySevenFash_log.mdf;Integrated Security=True")
    Dim cmd As SqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        Dim fn As String = txtFN.Text
        Dim ln As String = txtLN.Text
        Dim password As String = txtPass.Text

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim comm As String = "INSERT INTO Customers (username) VALUES (@FName, @LName, @UName, @Pass);"

        Dim insertCmd As New SqlCommand(comm, con)
        insertCmd.Parameters.Add("@FName", SqlDbType.NVarChar, 50)
        insertCmd.Parameters.Add("@LName", SqlDbType.NVarChar, 50)
        insertCmd.Parameters.Add("@UName", SqlDbType.NVarChar, 50)
        insertCmd.Parameters.Add("@Pass", SqlDbType.NVarChar, 50)



        insertCmd.Parameters("@FName").Value = txtFN.Text
        insertCmd.Parameters("@LName").Value = txtLN.Text
        insertCmd.Parameters("@UName").Value = txtUserN.Text
        insertCmd.Parameters("@Pass").Value = txtPass.Text


        Dim bSuccess As Boolean
        bSuccess = True

        Try
            con.Open()
            insertCmd.ExecuteScalar()
            con.Close()

        Catch ex As Exception
            bSuccess = False
            MsgBox("Failed")
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try

        If bSuccess = True Then
            MsgBox("Sucess")
        End If





    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        txtFN.Text = ""
        txtLN.Text = ""
        txtPass.Text = ""
        txtUserN.Text = ""
    End Sub

    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged


    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtUserN.TextChanged

    End Sub
End Class