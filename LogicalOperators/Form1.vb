Public Class Form1
    Private Sub btnGrade_Click(sender As Object, e As EventArgs) Handles btnGrade.Click

        Dim iScore As Integer

        'Checks to see that only number is entered
        If IsNumeric(txtExam.Text) = True Then
            iScore = CInt(txtExam.Text) 'Cint is used to convert the entry into integer
        Else
            MsgBox("You must enter a number")
            Exit Sub
        End If

        'Ensure an acceptable range is entered
        If iScore < 0 Or iScore > 100 Then
            MsgBox("This is not a valid score, enter a number between 0 and 100")
            Exit Sub
        End If

        'Validation is done
        If iScore <= 20 Then
            MsgBox("Grade F")
        ElseIf iScore > 20 And iScore <= 30 Then
            MsgBox("Grade E")
        ElseIf iScore > 30 And iScore <= 40 Then
            MsgBox("Grade D")
        ElseIf iScore > 40 And iScore <= 50 Then
            MsgBox("Grade C")
        ElseIf iScore > 50 And iScore <= 70 Then
            MsgBox("Grade B")
        Else
            MsgBox("Grade A")
        End If

        MsgBox("All done")

    End Sub
End Class
