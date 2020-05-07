Module modCellPhoneCalculations

    Const decTaxRate As Decimal = 0.06

    Const decVoiceMailCost As Decimal = 25D
    Const decTextMsgCost As Decimal = 10D

    Const decModel100Cost As Decimal = 29.95D
    Const decModel110Cost As Decimal = 49.95D
    Const decModel200Cost As Decimal = 99.95D

    Const decPlan800Cost As Decimal = 45D
    Const decPlan1500Cost As Decimal = 65D
    Const decPlanUnlimitedCost As Decimal = 99D


    Public Function CalcPhone(ByVal intNumber As Single, ByVal intModelNumber As Integer) As Decimal

        Dim decCost As Decimal


        'Cost based on model provided
        If intModelNumber = "100" Then

            '100?
            decCost = intNumber * decModel100Cost

        ElseIf intModelNumber = "110" Then

            '110?
            decCost = intNumber * decModel110Cost

        ElseIf intModelNumber = "200" Then

            '200?
            decCost = intNumber * decModel200Cost

        End If

        Return decCost

    End Function

    Public Function CalcOptions(ByVal blnVoiceMailSelected As Boolean, ByVal blnTextMsgSelected As Boolean, intNumber As Integer) As Decimal

        Dim decValue As Decimal = 0D

        ' Voice Mail checked?
        If blnVoiceMailSelected = True Then

            'Yes
            decValue += (decVoiceMailCost * intNumber)

        End If

        ' Text Msg checked? 
        If blnTextMsgSelected = True Then

            'Yes
            decValue += (decTextMsgCost * intNumber)

        End If

        Return decValue

    End Function

    Public Function CalcPackageCharge(ByVal intPlan As Integer) As Decimal

        Dim decValue As Decimal = 0D

        Select Case intPlan

            Case 300
                '300?
                decValue = decPlan800Cost

            Case 800
                '800?
                decValue = decPlan1500Cost

            Case 1500
                '1500?
                decValue = decPlanUnlimitedCost

        End Select

        Return decValue

    End Function


    Public Function CalcTax(ByVal decPhoneCost As Decimal) As Decimal

        Dim decTax As Decimal

        'Calculate the tax
        decTax = decPhoneCost * decTaxRate

        Return decTax

    End Function


End Module
