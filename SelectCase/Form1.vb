Public Class Form1
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click

        Dim iTemp As Integer
        iTemp = CInt(txtTemp.Text)

        Select Case iTemp
            Case Is = 0
                MsgBox("Freezing")
            Case Is < 0
                MsgBox("Sub zero")
            Case 1 To 10
                MsgBox("Cold")
            Case 11 To 20
                MsgBox("Warm")
            Case Else
                MsgBox("Hot")
        End Select


    End Sub
End Class
