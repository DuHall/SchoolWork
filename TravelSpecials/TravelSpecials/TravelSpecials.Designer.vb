<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TravelSpecials
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TravelSpecials))
        Me.msMainMenu = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnBookTrip = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblNumCost = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnGrtBarReef = New System.Windows.Forms.Button()
        Me.btnBoraBora = New System.Windows.Forms.Button()
        Me.btnMachuPicchu = New System.Windows.Forms.Button()
        Me.btnAlaska = New System.Windows.Forms.Button()
        Me.lblSelectDest = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.msMainMenu.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'msMainMenu
        '
        Me.msMainMenu.AllowDrop = True
        Me.msMainMenu.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.msMainMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.msMainMenu.Location = New System.Drawing.Point(0, 0)
        Me.msMainMenu.Name = "msMainMenu"
        Me.msMainMenu.Size = New System.Drawing.Size(784, 24)
        Me.msMainMenu.TabIndex = 0
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.BackColor = System.Drawing.Color.SlateGray
        Me.ExitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.DarkGray
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(600, 487)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(97, 24)
        Me.LinkLabel1.TabIndex = 11
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Travel Info"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.Transparent
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.ForeColor = System.Drawing.Color.Black
        Me.lblTotal.Location = New System.Drawing.Point(3, 23)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(109, 24)
        Me.lblTotal.TabIndex = 10
        Me.lblTotal.Text = "Total Price: "
        '
        'btnBookTrip
        '
        Me.btnBookTrip.BackColor = System.Drawing.Color.DarkGreen
        Me.btnBookTrip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btnBookTrip.FlatAppearance.BorderSize = 0
        Me.btnBookTrip.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnBookTrip.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBookTrip.Location = New System.Drawing.Point(5, 61)
        Me.btnBookTrip.Name = "btnBookTrip"
        Me.btnBookTrip.Size = New System.Drawing.Size(171, 52)
        Me.btnBookTrip.TabIndex = 10
        Me.btnBookTrip.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.Controls.Add(Me.lblNumCost)
        Me.Panel1.Controls.Add(Me.btnBookTrip)
        Me.Panel1.Controls.Add(Me.lblTotal)
        Me.Panel1.Location = New System.Drawing.Point(604, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(180, 116)
        Me.Panel1.TabIndex = 13
        '
        'lblNumCost
        '
        Me.lblNumCost.AutoSize = True
        Me.lblNumCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumCost.ForeColor = System.Drawing.Color.Black
        Me.lblNumCost.Location = New System.Drawing.Point(120, 21)
        Me.lblNumCost.Name = "lblNumCost"
        Me.lblNumCost.Size = New System.Drawing.Size(58, 29)
        Me.lblNumCost.TabIndex = 12
        Me.lblNumCost.Text = "0.00"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Window
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.btnGrtBarReef)
        Me.Panel2.Controls.Add(Me.btnBoraBora)
        Me.Panel2.Controls.Add(Me.btnMachuPicchu)
        Me.Panel2.Controls.Add(Me.btnAlaska)
        Me.Panel2.Controls.Add(Me.lblSelectDest)
        Me.Panel2.Location = New System.Drawing.Point(0, 24)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(225, 538)
        Me.Panel2.TabIndex = 14
        '
        'btnGrtBarReef
        '
        Me.btnGrtBarReef.BackgroundImage = CType(resources.GetObject("btnGrtBarReef.BackgroundImage"), System.Drawing.Image)
        Me.btnGrtBarReef.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnGrtBarReef.Location = New System.Drawing.Point(25, 293)
        Me.btnGrtBarReef.Name = "btnGrtBarReef"
        Me.btnGrtBarReef.Size = New System.Drawing.Size(173, 60)
        Me.btnGrtBarReef.TabIndex = 14
        Me.btnGrtBarReef.Text = "Great Barrier Reef"
        Me.btnGrtBarReef.UseVisualStyleBackColor = True
        '
        'btnBoraBora
        '
        Me.btnBoraBora.BackgroundImage = CType(resources.GetObject("btnBoraBora.BackgroundImage"), System.Drawing.Image)
        Me.btnBoraBora.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnBoraBora.Location = New System.Drawing.Point(25, 223)
        Me.btnBoraBora.Name = "btnBoraBora"
        Me.btnBoraBora.Size = New System.Drawing.Size(173, 60)
        Me.btnBoraBora.TabIndex = 13
        Me.btnBoraBora.Text = "Bora Bora"
        Me.btnBoraBora.UseVisualStyleBackColor = True
        '
        'btnMachuPicchu
        '
        Me.btnMachuPicchu.BackgroundImage = CType(resources.GetObject("btnMachuPicchu.BackgroundImage"), System.Drawing.Image)
        Me.btnMachuPicchu.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnMachuPicchu.Location = New System.Drawing.Point(25, 157)
        Me.btnMachuPicchu.Name = "btnMachuPicchu"
        Me.btnMachuPicchu.Size = New System.Drawing.Size(173, 60)
        Me.btnMachuPicchu.TabIndex = 12
        Me.btnMachuPicchu.Text = "Machu Picchu"
        Me.btnMachuPicchu.UseVisualStyleBackColor = True
        '
        'btnAlaska
        '
        Me.btnAlaska.BackgroundImage = CType(resources.GetObject("btnAlaska.BackgroundImage"), System.Drawing.Image)
        Me.btnAlaska.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.btnAlaska.Location = New System.Drawing.Point(25, 89)
        Me.btnAlaska.Name = "btnAlaska"
        Me.btnAlaska.Size = New System.Drawing.Size(173, 60)
        Me.btnAlaska.TabIndex = 11
        Me.btnAlaska.Text = "Alaska"
        Me.btnAlaska.UseVisualStyleBackColor = True
        '
        'lblSelectDest
        '
        Me.lblSelectDest.AutoSize = True
        Me.lblSelectDest.BackColor = System.Drawing.Color.Transparent
        Me.lblSelectDest.Font = New System.Drawing.Font("Book Antiqua", 10.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectDest.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblSelectDest.Location = New System.Drawing.Point(4, 49)
        Me.lblSelectDest.Name = "lblSelectDest"
        Me.lblSelectDest.Size = New System.Drawing.Size(217, 18)
        Me.lblSelectDest.TabIndex = 10
        Me.lblSelectDest.Text = "Currently Available Destinations"
        '
        'Button1
        '
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Location = New System.Drawing.Point(25, 360)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(173, 60)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Angkor Thom"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Location = New System.Drawing.Point(25, 427)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(173, 60)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Fiji"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TravelSpecials
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(784, 562)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.msMainMenu)
        Me.MainMenuStrip = Me.msMainMenu
        Me.Name = "TravelSpecials"
        Me.Text = "Travel Specials"
        Me.msMainMenu.ResumeLayout(False)
        Me.msMainMenu.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents msMainMenu As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnBookTrip As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblNumCost As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnGrtBarReef As Button
    Friend WithEvents btnBoraBora As Button
    Friend WithEvents btnMachuPicchu As Button
    Friend WithEvents btnAlaska As Button
    Friend WithEvents lblSelectDest As Label
End Class
