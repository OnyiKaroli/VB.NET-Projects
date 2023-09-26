Public Class Form1
    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click

        Dim stAge As String
        Dim iAge As Integer

        Do While IsNumeric(stAge) = False
            stAge = InputBox("Please enter your age in years.")
        Loop
        iAge = CInt(stAge)
        MsgBox("Hello, you are " & iAge)

    End Sub
End Class
