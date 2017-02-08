Public Class frmMain




    Dim dblEuroCurrency As Double = 0.00
    Dim dblYenCurrency As Double = 0.00
    Dim dblCanCurrency As Double = 0.00


    Dim mouse_move As System.Drawing.Point

#Region "Window setup controls"

    Private Sub pnlTopControl_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlTopControl.MouseDown
        mouse_move = New Point(-e.X, -e.Y)
    End Sub

    Private Sub pnlTopControl_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlTopControl.MouseMove
        If (e.Button = Windows.Forms.MouseButtons.Left) Then
            Dim mposition As Point
            mposition = Control.MousePosition
            mposition.Offset(mouse_move.X, mouse_move.Y)
            Me.Location = mposition
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

#End Region

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim dblUSCurrency As Double = txtUSD.Text


        ''Set the total for each currency value
        txtUSD.Text = dblUSCurrency

        lblEuroTotal.Text = dblUSCurrency * dblEuroCurrency
        lblYenTotal.Text = dblUSCurrency * dblYenCurrency
        lblCanadaTotal.Text = dblUSCurrency * dblCanCurrency



    End Sub

    Private Sub btnRealtimeConversion_Click(sender As Object, e As EventArgs) Handles btnRealtimeConversion.Click
        dblEuroCurrency = 0.935
        dblYenCurrency = 112.203
        dblCanCurrency = 1.318
    End Sub

    Private Sub btnExitCustRates_Click(sender As Object, e As EventArgs) Handles btnExitCustRates.Click
        pnlCustRatesTop.Visible = False
    End Sub

    Private Sub btnCustConvert_Click(sender As Object, e As EventArgs) Handles btnCustConvert.Click
        pnlCustRates.Visible = True
        pnlCustRatesTop.Visible = True
    End Sub
End Class
