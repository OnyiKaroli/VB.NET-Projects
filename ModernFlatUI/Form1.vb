Public Class Form1
    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        With Form2
            .TopLevel = False
            Panel5.Controls.Add(Form2)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class
