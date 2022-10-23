Public Class signup
    Private Sub Button1_Click(sender As Object, e As EventArgs)

        Dim fn As String = txtFN.Text
        Dim ln As String = txtLN.Text
        Dim password As String = txtPass.Text

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button1.Click


        txtFN.Text = String.Empty

        txtLN.Text = String.Empty

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