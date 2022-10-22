Imports System.Data
Imports System.Data.SqlClient
Imports System.Transactions

Public Class Login
    Dim con As SqlConnection
    Dim cmd As SqlCommand

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click


        If txtUsername.Text = "" Then
            MsgBox("Enter Username")
            txtUsername.Focus()

        End If
        If txtPassword.Text = "" Then
            MsgBox("Enter Password")
            txtPassword.Focus()
        End If

        Try
            con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\TwentySevenFash-Program\TwentySevenFash.mdf;Integrated Security=True")
            con.Open()
            cmd = New SqlCommand("select * from users where username= @username and password= @password", con)


            cmd.Parameters.Add("@username", SqlDbType.VarChar).Value = txtUsername.Text
            cmd.Parameters.Add("@password", SqlDbType.VarChar).Value = txtPassword.Text

            Dim sda As New SqlDataAdapter(cmd)

            Dim table As New DataTable()

            sda.Fill(table)
            If table.Rows.Count() <= 0 Then
                MsgBox("Enter Valid username and password", MsgBoxStyle.OkOnly, "Error")
            End If
            If table.Rows(0)("USERTYPE") = "admin" Then
                Dim dashboardmain As New Dashboard
                Dashboard.dashboardmain = txtUsername.Text
                Dashboard.Show()
                Me.Hide()

            End If
            txtPassword.Text = ""
            txtUsername.Text = ""
        Catch ex As Exception

        End Try
    End Sub

    Private Sub lblForgotPwd_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles lblForgotPwd.LinkClicked

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
