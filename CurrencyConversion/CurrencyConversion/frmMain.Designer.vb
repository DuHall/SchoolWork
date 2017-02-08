<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.pnlTopControl = New System.Windows.Forms.Panel()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCustConvert = New System.Windows.Forms.Button()
        Me.btnRealtimeConversion = New System.Windows.Forms.Button()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.lblEnterUSDolAmt = New System.Windows.Forms.Label()
        Me.txtUSD = New System.Windows.Forms.TextBox()
        Me.lblEuroAmt = New System.Windows.Forms.Label()
        Me.lblYenAmt = New System.Windows.Forms.Label()
        Me.lblCanadaAmt = New System.Windows.Forms.Label()
        Me.lblEuroTotal = New System.Windows.Forms.Label()
        Me.lblYenTotal = New System.Windows.Forms.Label()
        Me.lblCanadaTotal = New System.Windows.Forms.Label()
        Me.pnlCustRates = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblCustomRatesTitle = New System.Windows.Forms.Label()
        Me.pnlCustRatesTop = New System.Windows.Forms.Panel()
        Me.btnExitCustRates = New System.Windows.Forms.Button()
        Me.lblSetCustRates = New System.Windows.Forms.Label()
        Me.lblEuroCust = New System.Windows.Forms.Label()
        Me.lblYenCust = New System.Windows.Forms.Label()
        Me.lblCanRate = New System.Windows.Forms.Label()
        Me.txtEuroCust = New System.Windows.Forms.TextBox()
        Me.txtYenCust = New System.Windows.Forms.TextBox()
        Me.txtCanCust = New System.Windows.Forms.TextBox()
        Me.btnSaveCustRate = New System.Windows.Forms.Button()
        Me.pnlTopControl.SuspendLayout()
        Me.pnlCustRates.SuspendLayout()
        Me.pnlCustRatesTop.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTopControl
        '
        Me.pnlTopControl.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlTopControl.BackColor = System.Drawing.Color.SteelBlue
        Me.pnlTopControl.Controls.Add(Me.lblTitle)
        Me.pnlTopControl.Controls.Add(Me.btnExit)
        Me.pnlTopControl.Location = New System.Drawing.Point(0, 0)
        Me.pnlTopControl.Name = "pnlTopControl"
        Me.pnlTopControl.Size = New System.Drawing.Size(840, 28)
        Me.pnlTopControl.TabIndex = 0
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblTitle.Location = New System.Drawing.Point(344, 4)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(154, 17)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "US Currency Converter"
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.SteelBlue
        Me.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExit.Location = New System.Drawing.Point(804, -1)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(36, 29)
        Me.btnExit.TabIndex = 0
        Me.btnExit.Text = "X"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnCustConvert
        '
        Me.btnCustConvert.BackColor = System.Drawing.Color.SteelBlue
        Me.btnCustConvert.FlatAppearance.BorderSize = 0
        Me.btnCustConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCustConvert.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCustConvert.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCustConvert.Location = New System.Drawing.Point(508, 474)
        Me.btnCustConvert.Name = "btnCustConvert"
        Me.btnCustConvert.Size = New System.Drawing.Size(211, 28)
        Me.btnCustConvert.TabIndex = 5
        Me.btnCustConvert.Text = "Custom Rates"
        Me.btnCustConvert.UseVisualStyleBackColor = False
        '
        'btnRealtimeConversion
        '
        Me.btnRealtimeConversion.BackColor = System.Drawing.Color.SteelBlue
        Me.btnRealtimeConversion.FlatAppearance.BorderSize = 0
        Me.btnRealtimeConversion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRealtimeConversion.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRealtimeConversion.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRealtimeConversion.Location = New System.Drawing.Point(132, 474)
        Me.btnRealtimeConversion.Name = "btnRealtimeConversion"
        Me.btnRealtimeConversion.Size = New System.Drawing.Size(211, 28)
        Me.btnRealtimeConversion.TabIndex = 4
        Me.btnRealtimeConversion.Text = "Daily Rates"
        Me.btnRealtimeConversion.UseVisualStyleBackColor = False
        '
        'btnConvert
        '
        Me.btnConvert.BackColor = System.Drawing.Color.SteelBlue
        Me.btnConvert.FlatAppearance.BorderSize = 0
        Me.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConvert.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnConvert.Location = New System.Drawing.Point(320, 400)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(211, 54)
        Me.btnConvert.TabIndex = 6
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = False
        '
        'lblEnterUSDolAmt
        '
        Me.lblEnterUSDolAmt.AutoSize = True
        Me.lblEnterUSDolAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEnterUSDolAmt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblEnterUSDolAmt.Location = New System.Drawing.Point(344, 88)
        Me.lblEnterUSDolAmt.Name = "lblEnterUSDolAmt"
        Me.lblEnterUSDolAmt.Size = New System.Drawing.Size(158, 17)
        Me.lblEnterUSDolAmt.TabIndex = 8
        Me.lblEnterUSDolAmt.Text = "Enter US Dollar Amount"
        '
        'txtUSD
        '
        Me.txtUSD.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUSD.Location = New System.Drawing.Point(347, 124)
        Me.txtUSD.Name = "txtUSD"
        Me.txtUSD.Size = New System.Drawing.Size(151, 35)
        Me.txtUSD.TabIndex = 9
        '
        'lblEuroAmt
        '
        Me.lblEuroAmt.AutoSize = True
        Me.lblEuroAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEuroAmt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblEuroAmt.Location = New System.Drawing.Point(338, 216)
        Me.lblEuroAmt.Name = "lblEuroAmt"
        Me.lblEuroAmt.Size = New System.Drawing.Size(57, 22)
        Me.lblEuroAmt.TabIndex = 10
        Me.lblEuroAmt.Text = "Euros"
        '
        'lblYenAmt
        '
        Me.lblYenAmt.AutoSize = True
        Me.lblYenAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYenAmt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblYenAmt.Location = New System.Drawing.Point(353, 271)
        Me.lblYenAmt.Name = "lblYenAmt"
        Me.lblYenAmt.Size = New System.Drawing.Size(42, 22)
        Me.lblYenAmt.TabIndex = 11
        Me.lblYenAmt.Text = "Yen"
        '
        'lblCanadaAmt
        '
        Me.lblCanadaAmt.AutoSize = True
        Me.lblCanadaAmt.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCanadaAmt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCanadaAmt.Location = New System.Drawing.Point(308, 330)
        Me.lblCanadaAmt.Name = "lblCanadaAmt"
        Me.lblCanadaAmt.Size = New System.Drawing.Size(87, 22)
        Me.lblCanadaAmt.TabIndex = 12
        Me.lblCanadaAmt.Text = "Canadian"
        '
        'lblEuroTotal
        '
        Me.lblEuroTotal.AutoSize = True
        Me.lblEuroTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEuroTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblEuroTotal.Location = New System.Drawing.Point(415, 201)
        Me.lblEuroTotal.Name = "lblEuroTotal"
        Me.lblEuroTotal.Size = New System.Drawing.Size(83, 39)
        Me.lblEuroTotal.TabIndex = 13
        Me.lblEuroTotal.Text = "0.00"
        '
        'lblYenTotal
        '
        Me.lblYenTotal.AutoSize = True
        Me.lblYenTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYenTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblYenTotal.Location = New System.Drawing.Point(415, 261)
        Me.lblYenTotal.Name = "lblYenTotal"
        Me.lblYenTotal.Size = New System.Drawing.Size(83, 39)
        Me.lblYenTotal.TabIndex = 14
        Me.lblYenTotal.Text = "0.00"
        '
        'lblCanadaTotal
        '
        Me.lblCanadaTotal.AutoSize = True
        Me.lblCanadaTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCanadaTotal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblCanadaTotal.Location = New System.Drawing.Point(415, 319)
        Me.lblCanadaTotal.Name = "lblCanadaTotal"
        Me.lblCanadaTotal.Size = New System.Drawing.Size(83, 39)
        Me.lblCanadaTotal.TabIndex = 15
        Me.lblCanadaTotal.Text = "0.00"
        '
        'pnlCustRates
        '
        Me.pnlCustRates.Controls.Add(Me.btnSaveCustRate)
        Me.pnlCustRates.Controls.Add(Me.txtCanCust)
        Me.pnlCustRates.Controls.Add(Me.txtYenCust)
        Me.pnlCustRates.Controls.Add(Me.txtEuroCust)
        Me.pnlCustRates.Controls.Add(Me.lblCanRate)
        Me.pnlCustRates.Controls.Add(Me.lblYenCust)
        Me.pnlCustRates.Controls.Add(Me.lblEuroCust)
        Me.pnlCustRates.Controls.Add(Me.lblSetCustRates)
        Me.pnlCustRates.Location = New System.Drawing.Point(189, 107)
        Me.pnlCustRates.Name = "pnlCustRates"
        Me.pnlCustRates.Size = New System.Drawing.Size(457, 289)
        Me.pnlCustRates.TabIndex = 16
        Me.pnlCustRates.Visible = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.SteelBlue
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(574, -4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(36, 29)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "X"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblCustomRatesTitle
        '
        Me.lblCustomRatesTitle.AutoSize = True
        Me.lblCustomRatesTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomRatesTitle.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblCustomRatesTitle.Location = New System.Drawing.Point(3, 6)
        Me.lblCustomRatesTitle.Name = "lblCustomRatesTitle"
        Me.lblCustomRatesTitle.Size = New System.Drawing.Size(114, 17)
        Me.lblCustomRatesTitle.TabIndex = 7
        Me.lblCustomRatesTitle.Text = "Customize Rates"
        '
        'pnlCustRatesTop
        '
        Me.pnlCustRatesTop.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlCustRatesTop.BackColor = System.Drawing.Color.SteelBlue
        Me.pnlCustRatesTop.Controls.Add(Me.btnExitCustRates)
        Me.pnlCustRatesTop.Controls.Add(Me.lblCustomRatesTitle)
        Me.pnlCustRatesTop.Controls.Add(Me.Button1)
        Me.pnlCustRatesTop.Location = New System.Drawing.Point(189, 108)
        Me.pnlCustRatesTop.Name = "pnlCustRatesTop"
        Me.pnlCustRatesTop.Size = New System.Drawing.Size(457, 28)
        Me.pnlCustRatesTop.TabIndex = 8
        Me.pnlCustRatesTop.Visible = False
        '
        'btnExitCustRates
        '
        Me.btnExitCustRates.BackColor = System.Drawing.Color.SteelBlue
        Me.btnExitCustRates.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnExitCustRates.FlatAppearance.BorderSize = 0
        Me.btnExitCustRates.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExitCustRates.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExitCustRates.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnExitCustRates.Location = New System.Drawing.Point(421, -1)
        Me.btnExitCustRates.Name = "btnExitCustRates"
        Me.btnExitCustRates.Size = New System.Drawing.Size(36, 29)
        Me.btnExitCustRates.TabIndex = 8
        Me.btnExitCustRates.Text = "X"
        Me.btnExitCustRates.UseVisualStyleBackColor = False
        '
        'lblSetCustRates
        '
        Me.lblSetCustRates.AutoSize = True
        Me.lblSetCustRates.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSetCustRates.Location = New System.Drawing.Point(162, 55)
        Me.lblSetCustRates.Name = "lblSetCustRates"
        Me.lblSetCustRates.Size = New System.Drawing.Size(130, 18)
        Me.lblSetCustRates.TabIndex = 0
        Me.lblSetCustRates.Text = "Set Custom Rates"
        Me.lblSetCustRates.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblEuroCust
        '
        Me.lblEuroCust.AutoSize = True
        Me.lblEuroCust.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEuroCust.Location = New System.Drawing.Point(112, 109)
        Me.lblEuroCust.Name = "lblEuroCust"
        Me.lblEuroCust.Size = New System.Drawing.Size(82, 20)
        Me.lblEuroCust.TabIndex = 1
        Me.lblEuroCust.Text = "Euro Rate"
        '
        'lblYenCust
        '
        Me.lblYenCust.AutoSize = True
        Me.lblYenCust.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYenCust.Location = New System.Drawing.Point(116, 154)
        Me.lblYenCust.Name = "lblYenCust"
        Me.lblYenCust.Size = New System.Drawing.Size(77, 20)
        Me.lblYenCust.TabIndex = 2
        Me.lblYenCust.Text = "Yen Rate"
        '
        'lblCanRate
        '
        Me.lblCanRate.AutoSize = True
        Me.lblCanRate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCanRate.Location = New System.Drawing.Point(77, 203)
        Me.lblCanRate.Name = "lblCanRate"
        Me.lblCanRate.Size = New System.Drawing.Size(116, 20)
        Me.lblCanRate.TabIndex = 3
        Me.lblCanRate.Text = "Canadian Rate"
        '
        'txtEuroCust
        '
        Me.txtEuroCust.Location = New System.Drawing.Point(242, 109)
        Me.txtEuroCust.Name = "txtEuroCust"
        Me.txtEuroCust.Size = New System.Drawing.Size(100, 20)
        Me.txtEuroCust.TabIndex = 4
        '
        'txtYenCust
        '
        Me.txtYenCust.Location = New System.Drawing.Point(242, 154)
        Me.txtYenCust.Name = "txtYenCust"
        Me.txtYenCust.Size = New System.Drawing.Size(100, 20)
        Me.txtYenCust.TabIndex = 5
        '
        'txtCanCust
        '
        Me.txtCanCust.Location = New System.Drawing.Point(242, 203)
        Me.txtCanCust.Name = "txtCanCust"
        Me.txtCanCust.Size = New System.Drawing.Size(100, 20)
        Me.txtCanCust.TabIndex = 6
        '
        'btnSaveCustRate
        '
        Me.btnSaveCustRate.BackColor = System.Drawing.Color.SteelBlue
        Me.btnSaveCustRate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnSaveCustRate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSaveCustRate.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.btnSaveCustRate.Location = New System.Drawing.Point(267, 254)
        Me.btnSaveCustRate.Name = "btnSaveCustRate"
        Me.btnSaveCustRate.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveCustRate.TabIndex = 7
        Me.btnSaveCustRate.Text = "Save"
        Me.btnSaveCustRate.UseVisualStyleBackColor = False
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(839, 560)
        Me.Controls.Add(Me.pnlCustRatesTop)
        Me.Controls.Add(Me.pnlCustRates)
        Me.Controls.Add(Me.lblCanadaTotal)
        Me.Controls.Add(Me.lblYenTotal)
        Me.Controls.Add(Me.lblEuroTotal)
        Me.Controls.Add(Me.lblCanadaAmt)
        Me.Controls.Add(Me.lblYenAmt)
        Me.Controls.Add(Me.lblEuroAmt)
        Me.Controls.Add(Me.txtUSD)
        Me.Controls.Add(Me.lblEnterUSDolAmt)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.btnCustConvert)
        Me.Controls.Add(Me.btnRealtimeConversion)
        Me.Controls.Add(Me.pnlTopControl)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMain"
        Me.Text = "Form1"
        Me.pnlTopControl.ResumeLayout(False)
        Me.pnlTopControl.PerformLayout()
        Me.pnlCustRates.ResumeLayout(False)
        Me.pnlCustRates.PerformLayout()
        Me.pnlCustRatesTop.ResumeLayout(False)
        Me.pnlCustRatesTop.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pnlTopControl As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCustConvert As Button
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnRealtimeConversion As Button
    Friend WithEvents btnConvert As Button
    Friend WithEvents lblEnterUSDolAmt As Label
    Friend WithEvents txtUSD As TextBox
    Friend WithEvents lblEuroAmt As Label
    Friend WithEvents lblYenAmt As Label
    Friend WithEvents lblCanadaAmt As Label
    Friend WithEvents lblEuroTotal As Label
    Friend WithEvents lblYenTotal As Label
    Friend WithEvents lblCanadaTotal As Label
    Friend WithEvents pnlCustRates As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents lblCustomRatesTitle As Label
    Friend WithEvents pnlCustRatesTop As Panel
    Friend WithEvents btnExitCustRates As Button
    Friend WithEvents txtCanCust As TextBox
    Friend WithEvents txtYenCust As TextBox
    Friend WithEvents txtEuroCust As TextBox
    Friend WithEvents lblCanRate As Label
    Friend WithEvents lblYenCust As Label
    Friend WithEvents lblEuroCust As Label
    Friend WithEvents lblSetCustRates As Label
    Friend WithEvents btnSaveCustRate As Button
End Class
