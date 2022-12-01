Imports FontAwesome.Sharp
Imports System.Data.SqlClient


Public Class signup
    Dim con As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\TwentySevenFash-Program\TwentySevenFash.mdf;Integrated Security=True")
    Dim cmd As SqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs)

        Dim fn As String = txtID.Text
        Dim ln As String = txtType.Text
        Dim password As String = txtPass.Text

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Dim comm As New SqlCommand("INSERT INTO users (id, username, password, usertype) VALUES (@Id, @username,  @password, @type)", con)

        comm.Parameters.Add("@username", SqlDbType.VarChar).Value = txtUserN.Text
        comm.Parameters.Add("@password", SqlDbType.VarChar).Value = txtPass.Text
        comm.Parameters.Add("@type", SqlDbType.VarChar).Value = txtType.Text
        comm.Parameters.Add("@Id", SqlDbType.VarChar).Value = txtID.Text

        con.Open()

        If comm.ExecuteNonQuery() = 1 Then
            MsgBox("Succcess")
        Else
            MsgBox("Error")
        End If

        con.Close()
    End Sub

    Private Sub btnLogin_Click_1(sender As Object, e As EventArgs) Handles btnLogin.Click
        txtID.Text = ""
        txtType.Text = ""
        txtPass.Text = ""
        txtUserN.Text = ""
    End Sub
    Private Sub txtID_keys(sender As Object, e As KeyEventArgs) Handles txtType.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1_Click_1(Nothing, Nothing)
        Else
            Exit Sub
        End If

        e.SuppressKeyPress = True
    End Sub
    Private Sub txtType_keys(sender As Object, e As KeyEventArgs) Handles txtUserN.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1_Click_1(Nothing, Nothing)
        Else
            Exit Sub
        End If

        e.SuppressKeyPress = True
    End Sub

    Private Sub txtUserN_keys(sender As Object, e As KeyEventArgs) Handles txtPass.KeyDown
        If e.KeyCode = Keys.Enter Then
            Button1_Click_1(Nothing, Nothing)
        Else
            Exit Sub
        End If

        e.SuppressKeyPress = True
    End Sub
End Class