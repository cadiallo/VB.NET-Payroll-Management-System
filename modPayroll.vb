Module modPayroll

    Public dblDailyGrossPay As Double
    Public dblDailyNetPay As Double

    Public Function Calculate_FICA(ByVal dblGrossPay As Double, ByVal dblYTDGrossPay As Double) As Double
        Dim dblSocialSecurity As Double
        Dim dblMedicare As Double

        dblSocialSecurity = Calculate_Social_Security(dblYTDGrossPay, dblGrossPay)
        dblMedicare = Calculate_Medicare(dblGrossPay)

        Return dblSocialSecurity + dblMedicare

    End Function

    Public Function Calculate_Social_Security(ByVal dblYTDGrossPay As Double, ByVal dblGrossPay As Double) As Double
        Dim dblSocialSecurity As Double

        If dblYTDGrossPay > 125000 Then
            dblSocialSecurity = 0
        Else
            dblSocialSecurity = dblGrossPay * 0.062
        End If

        Return dblSocialSecurity

    End Function

    Public Function Calculate_Medicare(ByVal dblGrossPay As Double) As Double

        Return dblGrossPay * 0.0145

    End Function

    Public Function Calculate_FederalTax(ByVal dblGrossPay As Double) As Double
        Dim dblFederalTax As Double

        If dblGrossPay <= 50 Then
            dblFederalTax = 0
        Else
            If dblGrossPay <= 500 Then
                dblFederalTax = (dblGrossPay - 50) * 0.1
            Else
                If dblGrossPay <= 2500 Then
                    dblFederalTax = (dblGrossPay - 500) * 0.15 + 45
                Else
                    If dblGrossPay <= 5000 Then
                        dblFederalTax = (dblGrossPay - 2500) * 0.2 + 345
                    Else
                        dblFederalTax = (dblGrossPay - 5000) * 0.25 + 845
                    End If
                End If
            End If
        End If

        Return dblFederalTax
    End Function

    Public Function Calculate_NetPay(ByVal dblGrossPay As Double, ByVal dblFICA As Double, ByVal dblStateTax As Double, ByVal dblFederalTax As Double) As Double

        Return dblGrossPay - dblFICA - dblStateTax - dblFederalTax

    End Function

    Public Function Calculate_DailyGossPay(ByVal dblDailyGrossPay As Double, ByVal dblGrossPay As Double) As Double

        Return dblDailyGrossPay + dblGrossPay

    End Function

    Public Function Calculate_DailyNetPay(ByVal dblDailyNetPay As Double, ByVal dblNetPay As Double) As Double

        Return dblDailyNetPay + dblNetPay

    End Function

End Module
