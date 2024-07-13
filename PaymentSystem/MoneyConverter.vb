Public Class MoneyConverter

    Public Shared Function ConvertMoneyToWords(ByVal amount As Decimal) As String
        Dim pesos As Integer = CInt(Math.Truncate(amount))
        Dim centavos As Integer = CInt((amount - pesos) * 100)

        Dim pesosText As String = Num2Text(pesos) & " Pesos"
        Dim centavosText As String = IIf(centavos > 0, " and " & Num2Text(centavos) & " Centavos", "")

        Dim result As String = pesosText & centavosText

        Return result.Trim()
    End Function

    Private Shared Function Num2Text(ByVal number As Integer) As String
        Dim units() As String = {"", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine"}
        Dim teens() As String = {"Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"}
        Dim tens() As String = {"", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"}
        Dim thousands() As String = {"", "Thousand", "Million", "Billion", "Trillion"}

        If number < 10 Then
            Return units(number)
        ElseIf number < 20 Then
            Return teens(number - 10)
        ElseIf number < 100 Then
            Return tens(number \ 10) & " " & Num2Text(number Mod 10)
        ElseIf number < 1000 Then
            Return units(number \ 100) & " Hundred " & Num2Text(number Mod 100)
        ElseIf number < 10000 Then
            Return tens(number \ 1000) & " Thousand " & IIf(number Mod 1000 > 0, Num2Text(number Mod 1000), "")
        Else
            Dim str As String = ""
            Dim i As Integer = 0
            While number > 0
                If number Mod 1000 <> 0 Then
                    str = Num2Text(number Mod 1000) & " " & thousands(i) & " " & str
                End If
                number \= 1000
                i += 1
            End While
            Return str.Trim()
        End If
    End Function

End Class
