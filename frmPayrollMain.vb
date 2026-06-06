Public Class frmPayrollMain

    '*********************************
    ' Cheikh A Diallo
    ' Final Project
    '*********************************

    Private Sub btnSalariedEmployee_Click(sender As Object, e As EventArgs) Handles btnSalariedEmployee.Click

        Dim frmSalariedEmployee As New frmSalariedEmployee

        frmSalariedEmployee.ShowDialog()

    End Sub

    Private Sub btnHourlyEmployee_Click(sender As Object, e As EventArgs) Handles btnHourlyEmployee.Click
        Dim frmHourlyEmployee As New frmHourlyEmployee

        frmHourlyEmployee.ShowDialog()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()

    End Sub

    Private Sub btnDailyTotals_Click(sender As Object, e As EventArgs) Handles btnDailyTotals.Click

        MessageBox.Show("The Daily Total of Gross Pay is " & dblDailyGrossPay.ToString("c") & vbCr & "The Daily Total of Net Pay is " & dblDailyNetPay.ToString("c"))

    End Sub

    Private Sub SalariedToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalariedToolStripMenuItem.Click
        Dim frmSalariedEmployee As New frmSalariedEmployee

        frmSalariedEmployee.ShowDialog()
    End Sub

    Private Sub HourlyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HourlyToolStripMenuItem.Click
        Dim frmHourlyEmployee As New frmHourlyEmployee

        frmHourlyEmployee.ShowDialog()
    End Sub

    Private Sub DailyTotalsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DailyTotalsToolStripMenuItem.Click
        MessageBox.Show("The Daily Total of Gross Pay is " & dblDailyGrossPay.ToString("c") & vbCr & "The Daily Total of Net Pay is " & dblDailyNetPay.ToString("c"))

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()

    End Sub
End Class