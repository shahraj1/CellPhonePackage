Public Class FFamily

    Private Sub FFamily_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        radModel100.Checked = True
        radPlan800.Checked = True

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click


        'Check if the Number of Phone is Valid/Numeric and not Empty
        If IsNumeric(txtNumPhones.Text) Then

            'Yes, Valid
            Dim intPhones As Integer
            intPhones = txtNumPhones.Text

            Dim intModelNumber As Integer
            Dim intPlanNumber As Integer
            Dim decPhoneSubtotal As Decimal
            Dim decPhoneTotal As Decimal
            Dim decTax As Decimal
            Dim decOptionCost As Decimal
            Dim decPackageCharge As Decimal
            Dim decTotalMonthly As Decimal
            Dim blnVoiceMailChecked As Boolean = chkVoiceMail.Checked
            Dim blnTextMsgChecked As Boolean = chkTextMessaging.Checked

            'Model Number
            intModelNumber = GetModelNumber()

            'Price 
            decPhoneSubtotal = modCellPhoneCalculations.CalcPhone(1, intModelNumber)

            'Tax
            decTax = modCellPhoneCalculations.CalcTax(decPhoneTotal)

            'Calculate TOtal
            decPhoneTotal = decTax + decPhoneSubtotal

            'Get the cost
            decOptionCost = modCellPhoneCalculations.CalcOptions(blnVoiceMailChecked, blnTextMsgChecked, intPhones)

            'Get the charge for selected Package per month
            intPlanNumber = GetPlanNumber()
            decPackageCharge = modCellPhoneCalculations.CalcPackageCharge(intPlanNumber)

            'Calculate Total Price for the month
            decTotalMonthly = decPackageCharge + decOptionCost

            'Display the charges
            txtPhoneSubTotal.Text = FormatCurrency(decPhoneSubtotal)
            txtTax.Text = FormatCurrency(decTax)
            txtPhone.Text = FormatCurrency(decPhoneTotal)
            txtOptions.Text = FormatCurrency(decOptionCost)
            txtPackageCharge.Text = FormatCurrency(decPackageCharge)
            txtTotalMonthlyCharge.Text = FormatCurrency(decTotalMonthly)


        ElseIf txtNumPhones.Text = "" Then

            MessageBox.Show("Please enter a valid number for Number of Phones")
            txtNumPhones.Focus()

        ElseIf IsNumeric(txtNumPhones.Text) = False Then

            'No, Not Valid 
            'Display Error Message
            MessageBox.Show("Number of Phone has to be a number. Number default to 1", _
                            "ERROR!", _
                            MessageBoxButtons.OK, _
                            MessageBoxIcon.Error)
            txtNumPhones.Text = "1"
            txtNumPhones.Focus()

        End If

    End Sub

    Private Function GetModelNumber() As Integer

        Dim intModelNumber As Integer

        If radModel100.Checked = True Then

            intModelNumber = 100

        ElseIf radModel110.Checked = True Then

            intModelNumber = 110

        ElseIf radModel200.Checked = True Then

            intModelNumber = 200

        End If

        Return intModelNumber

    End Function


    Private Function GetPlanNumber() As Integer

        Dim intPlanNumber As Integer

        If radPlan800.Checked = True Then

            intPlanNumber = 300

        ElseIf radPlan1500.Checked = True Then

            intPlanNumber = 800

        ElseIf radPlanUnlimited.Checked = True Then

            intPlanNumber = 1500

        End If

        Return intPlanNumber

    End Function


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub


End Class