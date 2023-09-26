Public Class Form1
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click

        Dim iCount As Integer

        Do While iCount <= 5
            iCount = iCount + 1
            MsgBox("Hello " & iCount)
        Loop

        MsgBox("All done")

    End Sub
End Class
