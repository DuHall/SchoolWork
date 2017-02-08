
Imports System
Imports System.Net
Imports System.IO
Imports Newtonsoft.Json


Public Class frmMain


    Dim dblEuroCurrency As Double = FormatCurrency(0.00)
    Dim dblYenCurrency As Double = FormatCurrency(0.00)
    Dim dblCanCurrency As Double = FormatCurrency(0.00)


    Dim mouse_move As System.Drawing.Point

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        pnlCustRates.Visible = False
        pnlCustRatesTop.Visible = False

        If My.Computer.Network.Ping("www.Google.com") Then
            lblInternet.Text = "Online"
            lblInternet.ForeColor = Color.ForestGreen
        Else
            lblInternet.Text = "Offline"
            lblInternet.ForeColor = Color.Red
        End If

        dblEuroCurrency = 0.937
        dblYenCurrency = 111.95
        dblCanCurrency = 1.31


    End Sub

#Region "Main Window setup controls"
    ''Setup mouse down movement
    Private Sub pnlTopControl_MouseDown(sender As Object, e As MouseEventArgs) Handles pnlTopControl.MouseDown
        mouse_move = New Point(-e.X, -e.Y)
    End Sub

    ''Setup Mouse Control
    Private Sub pnlTopControl_MouseMove(sender As Object, e As MouseEventArgs) Handles pnlTopControl.MouseMove
            If (e.Button = Windows.Forms.MouseButtons.Left) Then
                Dim mposition As Point
                mposition = Control.MousePosition
                mposition.Offset(mouse_move.X, mouse_move.Y)
                Me.Location = mposition
            End If
        End Sub

    ''Exit button for main window
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
            Application.Exit()
        End Sub

#End Region

#Region "Rate Conversion controls"
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        getConversionTotal()
    End Sub

    Private Sub getConversionTotal()
        ''Set Variable to equal the USD textbox input
        Dim dblUSCurrency As Double = txtUSD.Text

        ''Set the total for each currency value
        txtUSD.Text = FormatCurrency(dblUSCurrency)
        '' Set Variables for totals
        Dim dblEuroTotal As Double
        Dim dblYenTotal As Double
        Dim dblCanadaTotal As Double

        ''Calculate currency conversion
        dblEuroTotal = dblUSCurrency * dblEuroCurrency
        dblYenTotal = dblUSCurrency * dblYenCurrency
        dblCanadaTotal = dblUSCurrency * dblCanCurrency

        ''Format into a proper currency value
        lblEuroTotal.Text = FormatCurrency(dblEuroTotal,,, TriState.True, TriState.True)
        lblYenTotal.Text = FormatCurrency(dblYenTotal,,, TriState.True, TriState.True)
        lblCanadaTotal.Text = FormatCurrency(dblCanadaTotal,,, TriState.True, TriState.True)
    End Sub

#End Region

#Region "Setup the different conversion types"

    ''If user is connected to the internet an API is used to stream Live daily currency results, else it goes with default value.
    Private Sub btnRealtimeConversion_Click(sender As Object, e As EventArgs) Handles btnRealtimeConversion.Click
        ''Initialize API
        Dim sURL As String
        sURL = "http://api.fixer.io/latest?base=USD"

        Dim wrGETURL As WebRequest
        wrGETURL = WebRequest.Create(sURL)

        ''GET information into application
        Dim objStream As Stream
        objStream = wrGETURL.GetResponse.GetResponseStream()

        Dim objReader As New StreamReader(objStream)
        Dim sLine As String = ""
        Dim i As Integer = 0

        ''Stream results
        Dim responseFromServer As String = objReader.ReadToEnd()

        Console.WriteLine(responseFromServer)
        ''Convert the results from JSON API string
        Dim result = JsonConvert.DeserializeObject(responseFromServer)
        Console.WriteLine(result)

        ''If the results is empty then set realtime conversion to default values
        If lblInternet.Text = "Offline" Then
            dblEuroCurrency = 0.937
            dblYenCurrency = 111.95
            dblCanCurrency = 1.31
        Else
            dblEuroCurrency = result("rates")("EUR")
            dblYenCurrency = result("rates")("JPY")
            dblCanCurrency = result("rates")("CAD")
        End If

    End Sub

    Private Sub btnExitCustRates_Click(sender As Object, e As EventArgs) Handles btnExitCustRates.Click
        pnlCustRatesTop.Visible = False
        pnlCustRates.Visible = False

    End Sub

    Private Sub btnCustConvert_Click(sender As Object, e As EventArgs) Handles btnCustConvert.Click
        pnlCustRates.Visible = True
        pnlCustRatesTop.Visible = True

    End Sub

    Private Sub btnSaveCustRate_Click(sender As Object, e As EventArgs) Handles btnSaveCustRate.Click
        If txtEuroCust.Text = "" Then
            txtEuroCust.Focus()
            txtEuroCust.BackColor = Color.LightYellow
            lblSaved.Text = "Value cannot be blank"
            lblSaved.ForeColor = Color.Red
            Exit Sub
        ElseIf txtYenCust.Text = "" Then
            txtYenCust.BackColor = Color.LightYellow
            lblSaved.Text = "Value cannot be blank"
            lblSaved.ForeColor = Color.Red
            Exit Sub
        ElseIf txtCanCust.Text = "" Then
            txtCanCust.BackColor = Color.LightYellow
            lblSaved.Text = "Value cannot be blank"
            lblSaved.ForeColor = Color.Red
            Exit Sub
        Else
            dblEuroCurrency = txtEuroCust.Text
            dblYenCurrency = txtYenCust.Text
            dblCanCurrency = txtCanCust.Text

            lblSaved.Text = "save successful"
            lblSaved.ForeColor = Color.ForestGreen
        End If


    End Sub

    Private Sub btnCloseCustRate_Click(sender As Object, e As EventArgs) Handles btnCloseCustRate.Click
        pnlCustRates.Visible = False
        pnlCustRatesTop.Visible = False
    End Sub

    Private Sub txtEuroCust_TextChanged(sender As Object, e As EventArgs) Handles txtEuroCust.TextChanged
        Dim timeStamp As DateTime = DateTime.Now
        txtEuroDateTime.Text = timeStamp
    End Sub

    Private Sub txtYenCust_TextChanged(sender As Object, e As EventArgs) Handles txtYenCust.TextChanged
        Dim timeStamp As DateTime = DateTime.Now
        txtYenDateTime.Text = timeStamp
    End Sub

    Private Sub txtCanCust_TextChanged(sender As Object, e As EventArgs) Handles txtCanCust.TextChanged
        Dim timeStamp As DateTime = DateTime.Now
        txtCanDateTime.Text = timeStamp
    End Sub

    Private Sub btnCustClear_Click(sender As Object, e As EventArgs) Handles btnCustClear.Click

        txtYenCust.Text = FormatCurrency(0.00)
        txtEuroCust.Text = FormatCurrency(0.00)
        txtCanCust.Text = FormatCurrency(0.00)
        txtYenDateTime.Text = ""
        txtEuroDateTime.Text = ""
        txtCanDateTime.Text = ""
    End Sub
#End Region

End Class
