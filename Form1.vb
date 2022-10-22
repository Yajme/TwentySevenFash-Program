Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs)

        Dim fn As String = txtFN.Text
        Dim ln As String = txtLN.Text
        Dim password As String = txtPass.Text
        Dim mobile As Integer = Val(txtMN.Text)
        Dim email As String = txtEA.Text
        Dim birthday As String = txtBirth.Text
        Dim gender As String = txtGender.Text

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        txtBirth.Text = String.Empty
        txtEA.Text = String.Empty
        txtFN.Text = String.Empty
        txtGender.Text = String.Empty
        txtLN.Text = String.Empty
        txtMN.Text = String.Empty
        txtPass.Text = String.Empty



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

    End Sub

    Private Sub txtPass_TextChanged(sender As Object, e As EventArgs) Handles txtPass.TextChanged


    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
End Class