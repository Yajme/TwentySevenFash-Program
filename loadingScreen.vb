Public Class loadingScreen

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        Panel2.Width += 5
        If Panel2.Width >= 800 Then
            Timer1.Stop()

            Me.Hide()
        End If


    End Sub




End Class