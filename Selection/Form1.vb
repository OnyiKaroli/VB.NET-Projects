Public Class Form1
    Private Sub btnGreet_Click(sender As Object, e As EventArgs) Handles btnGreet.Click

        Dim stCountry As String
        stCountry = txtCountry.Text

        If stCountry = "Australia" Then
            MsgBox("G' day mate")
        ElseIf stCountry = "Kenya" Then
            MsgBox("Jambo Ndugu")
        Else msgbox("Hello There")
        End If

    End Sub
End Class
