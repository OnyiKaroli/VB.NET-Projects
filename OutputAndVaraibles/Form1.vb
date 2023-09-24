Public Class Form1
    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        MsgBox("Hello there")

    End Sub

    Private Sub btnVariables_Click(sender As Object, e As EventArgs) Handles btnVariables.Click
        Dim stFirstName As String
        Dim stLastName As String

        stFirstName = "Karolih"
        stLastName = "Solutions"

        MsgBox("Hello and weclome " & stFirstName & " " & stLastName & " and hope you are well")

        stFirstName = "Tessie"
        stLastName = "Designs"

        MsgBox("Hello and weclome " & stFirstName & " " & stLastName & " and hope you are well")
    End Sub

    Private Sub btnDataTypes_Click(sender As Object, e As EventArgs) Handles btnDataTypes.Click
        Dim stMake As String
        Dim stModel As String
        Dim iDoors As Integer
        Dim stColor As String
        Dim bTaxxed As Boolean
        Dim iEngineSize As Integer
        Dim decPrice As Decimal
        Dim dtDateRegistered As Date

        stMake = "Ford"
        stModel = "Escort"
        iDoors = 5
        stColor = "red"
        bTaxxed = True
        iEngineSize = 1200
        decPrice = 999.99
        dtDateRegistered = #9/23/2023#

        MsgBox("The car is " & stMake & vbNewLine & stModel & vbNewLine &
               iDoors & vbNewLine & stColor & vbNewLine & bTaxxed & vbNewLine &
               iEngineSize & vbNewLine & decPrice & vbNewLine & dtDateRegistered)

    End Sub
End Class
