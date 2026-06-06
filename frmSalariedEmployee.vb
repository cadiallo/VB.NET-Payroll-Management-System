Public Class frmSalariedEmployee
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim strFirstName As String
        Dim strLastName As String
        Dim strState As String
        Dim dblYearlyWage As Double
        Dim dblYTDGrossPay As Double

        Dim dblGrossPay As Double
        Dim dblFICA As Double
        Dim dblStateTax As Double
        Dim dblFederalTax As Double
        Dim dblNetPay As Double

        Dim blnValidated As Boolean = True

        Get_And_Validate_Infos(strFirstName, strLastName, strState, dblYearlyWage, dblYTDGrossPay, blnValidated)

        If blnValidated Then
            Calculate_Payroll_Totals(strState, dblYearlyWage, dblYTDGrossPay, dblGrossPay, dblFICA, dblStateTax, dblFederalTax, dblNetPay)
            Display_Payroll_Totals(dblGrossPay, dblFICA, dblStateTax, dblFederalTax, dblNetPay)
        End If
    End Sub

    Private Sub Get_And_Validate_Infos(ByRef strFirstName As String, ByRef strLastName As String, ByRef StrState As String, ByRef dblYearlyWage As Double, ByRef dblYTDGrossPay As Double, ByRef blnValidated As Boolean)
        Get_And_Validate_FirstName(strFirstName, blnValidated)
        If blnValidated Then
            Get_And_Validate_LastName(strLastName, blnValidated)
            If blnValidated Then
                Get_And_Validate_State(StrState, blnValidated)
                If blnValidated Then
                    Get_And_Validate_YearlyWage(dblYearlyWage, blnValidated)
                    If blnValidated Then
                        Get_And_Validate_YTDGrossPay(dblYTDGrossPay, blnValidated)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Get_And_Validate_FirstName(ByRef strFirstName As String, ByRef blnValidated As Boolean)
        If txtFirstName.Text = String.Empty Then
            MessageBox.Show("First Name Must Exist")
            blnValidated = False
            txtFirstName.Focus()
        End If
    End Sub

    Private Sub Get_And_Validate_LastName(ByRef strLastName As String, ByRef blnValidated As Boolean)
        If txtLastName.Text = String.Empty Then
            MessageBox.Show("Last Name Must Exist")
            blnValidated = False
            txtLastName.Focus()
        End If
    End Sub

    Private Sub Get_And_Validate_State(ByRef strState As String, ByRef blnValidated As Boolean)
        If cboState.Text = String.Empty Then
            MessageBox.Show("State Must Exist")
            blnValidated = False
            cboState.Focus()
        End If
    End Sub

    Private Sub Get_And_Validate_YearlyWage(ByRef dblYearlyWage As Double, ByRef blnValidated As Boolean)
        If Double.TryParse(txtYearlyWage.Text, dblYearlyWage) Then
            If txtYearlyWage.Text < 1 Then
                MessageBox.Show("Yearly Wage Must be Greater than 0")
                blnValidated = False
                txtYearlyWage.Focus()
            End If
        Else
            MessageBox.Show("Yearly Wage Must Exist and be Numeric")
            blnValidated = False
            txtYearlyWage.Focus()
        End If
    End Sub

    Private Sub Get_And_Validate_YTDGrossPay(ByRef dblYTDGrossPay As Double, ByRef blnValidated As Boolean)
        If Double.TryParse(txtYTDGrossPay.Text, dblYTDGrossPay) Then
            blnValidated = True
        Else
            MessageBox.Show("YTD Gross Pay Must Exist and be Numeric")
            blnValidated = False
            txtYTDGrossPay.Focus()
        End If
    End Sub

    Private Sub Calculate_Payroll_Totals(ByVal strState As String, ByVal dblYearlyWage As Double, ByVal dblYTDGrossPay As Double, ByRef dblGrossPay As Double, ByRef dblFICA As Double, ByRef dblStateTax As Double, ByRef dblFederalTax As Double, ByRef dblNetPay As Double)
        dblGrossPay = Calculate_GrossPay(dblYearlyWage)
        dblFICA = Calculate_FICA(dblGrossPay, dblYTDGrossPay)
        dblStateTax = Calculate_StateTax(strState, dblGrossPay)
        dblFederalTax = Calculate_FederalTax(dblGrossPay)
        dblNetPay = Calculate_NetPay(dblGrossPay, dblFICA, dblStateTax, dblFederalTax)
        dblDailyGrossPay = Calculate_DailyGossPay(dblDailyGrossPay, dblGrossPay)
        dblDailyNetPay = Calculate_DailyNetPay(dblDailyNetPay, dblNetPay)

    End Sub

    Private Function Calculate_GrossPay(ByVal dblYearlyWage As Double) As Double

        Return dblYearlyWage / 52

    End Function

    Private Function Calculate_StateTax(ByVal strState As String, ByVal dblGrossPay As Double) As Double
        Dim dblStateTax As Double

        If cboState.Text = "Indiana" Then
            dblStateTax = dblGrossPay * 0.055
        Else
            If cboState.Text = "Kentucky" Then
                dblStateTax = dblGrossPay * 0.06
            Else
                dblStateTax = dblGrossPay * 0.065
            End If
        End If

        Return dblStateTax
    End Function

    Private Sub Display_Payroll_Totals(ByVal dblGrossPay As Double, ByVal dblFICA As Double, ByVal dblStateTax As Double, ByVal dblFederalTax As Double, ByVal dblNetPay As Double)

        lblGrossPay.Text = dblGrossPay.ToString("c")
        lblFICA.Text = dblFICA.ToString("c")
        lblStateTax.Text = dblStateTax.ToString("c")
        lblFederalTax.Text = dblFederalTax.ToString("c")
        lblNetPay.Text = dblNetPay.ToString("c")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFirstName.Clear()
        txtLastName.Clear()
        cboState.ResetText()
        txtYearlyWage.Clear()
        txtYTDGrossPay.Clear()

        txtFirstName.Focus()

        lblGrossPay.ResetText()
        lblFICA.ResetText()
        lblStateTax.ResetText()
        lblFederalTax.ResetText()
        lblNetPay.ResetText()

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()

    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        txtFirstName.Clear()
        txtLastName.Clear()
        cboState.ResetText()
        txtYearlyWage.Clear()
        txtYTDGrossPay.Clear()

        txtFirstName.Focus()

        lblGrossPay.ResetText()
        lblFICA.ResetText()
        lblStateTax.ResetText()
        lblFederalTax.ResetText()
        lblNetPay.ResetText()
    End Sub
End Class