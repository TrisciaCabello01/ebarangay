Public Class Form1

    Private Sub TimerOpForm_Tick(sender As Object, e As EventArgs) Handles TimerOpForm.Tick
        Form2.Show()
        Me.Hide()
    End Sub

End Class
