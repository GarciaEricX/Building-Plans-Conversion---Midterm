Public Class Form1
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click

        Dim decInputValue As Decimal
        Dim decConversionValue As Decimal

        Dim decInchToMetersFactor As Decimal = 0.0254D
        Dim decMetersToInchFactor As Decimal = 39.37D

        Dim strNegError = "The measurement must be greater than zero."
        Dim strError = "Please enter a positive number."
        Dim strErrorInputMessage = ""

        If IsNumeric(txtInput.Text) Then

            decInputValue = Convert.ToDecimal(txtInput.Text)

            If decInputValue > 0 Then

                If radInchToMeter.Checked Then

                    decConversionValue = decInputValue * decInchToMetersFactor
                    lblConversion.Text = decInputValue & " inches is " & decConversionValue & " meters"
                    lblConversion.Visible = True

                ElseIf radMeterToInch.Checked Then

                    decConversionValue = decInputValue * decMetersToInchFactor
                    lblConversion.Text = decInputValue & " meters is " & decConversionValue & " inches"
                    lblConversion.Visible = True

                End If

            Else

                strErrorInputMessage = strNegError
                MsgBox(strErrorInputMessage)

            End If

        Else

            strErrorInputMessage = strError
            MsgBox(strErrorInputMessage)

        End If


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        lblConversion.Text = ""

        lblConversion.Visible = False
        radInchToMeter.Checked = True
        radMeterToInch.Checked = False

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub
End Class
