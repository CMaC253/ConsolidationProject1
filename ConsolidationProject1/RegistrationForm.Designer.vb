<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrationForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.customerNameTextBox = New System.Windows.Forms.TextBox()
        Me.customerPhoneTextBox = New System.Windows.Forms.TextBox()
        Me.dateTextBox = New System.Windows.Forms.TextBox()
        Me.threePMbutton = New System.Windows.Forms.Button()
        Me.fivePMbutton = New System.Windows.Forms.Button()
        Me.sevenPMbutton = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.gardenTourTextBox = New System.Windows.Forms.TextBox()
        Me.kitchenTourTextBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.numAdultsTextBox = New System.Windows.Forms.TextBox()
        Me.numChildrenTextBox = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.calculateChargeButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.registrationSummaryTextBox = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 29)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(273, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Good Night Tours"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 68)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(335, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "To register, please fill in all the boxes:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(76, 125)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Your Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(76, 169)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Your Phone:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(40, 212)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(128, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Date (mm/dd/yy):"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(40, 291)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(141, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Select a Time Slot:"
        '
        'customerNameTextBox
        '
        Me.customerNameTextBox.Location = New System.Drawing.Point(180, 120)
        Me.customerNameTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.customerNameTextBox.Name = "customerNameTextBox"
        Me.customerNameTextBox.Size = New System.Drawing.Size(210, 26)
        Me.customerNameTextBox.TabIndex = 6
        '
        'customerPhoneTextBox
        '
        Me.customerPhoneTextBox.Location = New System.Drawing.Point(180, 165)
        Me.customerPhoneTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.customerPhoneTextBox.Name = "customerPhoneTextBox"
        Me.customerPhoneTextBox.Size = New System.Drawing.Size(210, 26)
        Me.customerPhoneTextBox.TabIndex = 7
        '
        'dateTextBox
        '
        Me.dateTextBox.Location = New System.Drawing.Point(180, 205)
        Me.dateTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.dateTextBox.Name = "dateTextBox"
        Me.dateTextBox.Size = New System.Drawing.Size(210, 26)
        Me.dateTextBox.TabIndex = 8
        '
        'threePMbutton
        '
        Me.threePMbutton.Location = New System.Drawing.Point(195, 274)
        Me.threePMbutton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.threePMbutton.Name = "threePMbutton"
        Me.threePMbutton.Size = New System.Drawing.Size(74, 37)
        Me.threePMbutton.TabIndex = 9
        Me.threePMbutton.Text = "3:00pm"
        Me.threePMbutton.UseVisualStyleBackColor = True
        '
        'fivePMbutton
        '
        Me.fivePMbutton.Location = New System.Drawing.Point(278, 274)
        Me.fivePMbutton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.fivePMbutton.Name = "fivePMbutton"
        Me.fivePMbutton.Size = New System.Drawing.Size(74, 37)
        Me.fivePMbutton.TabIndex = 10
        Me.fivePMbutton.Text = "5:00pm"
        Me.fivePMbutton.UseVisualStyleBackColor = True
        '
        'sevenPMbutton
        '
        Me.sevenPMbutton.Location = New System.Drawing.Point(360, 274)
        Me.sevenPMbutton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.sevenPMbutton.Name = "sevenPMbutton"
        Me.sevenPMbutton.Size = New System.Drawing.Size(74, 37)
        Me.sevenPMbutton.TabIndex = 11
        Me.sevenPMbutton.Text = "7:00pm"
        Me.sevenPMbutton.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(45, 369)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(162, 20)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "Garden Tour ($1.00)?"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(45, 406)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(161, 20)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Kitchen Tour ($2.00)?"
        '
        'gardenTourTextBox
        '
        Me.gardenTourTextBox.Location = New System.Drawing.Point(218, 365)
        Me.gardenTourTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.gardenTourTextBox.Name = "gardenTourTextBox"
        Me.gardenTourTextBox.Size = New System.Drawing.Size(110, 26)
        Me.gardenTourTextBox.TabIndex = 14
        '
        'kitchenTourTextBox
        '
        Me.kitchenTourTextBox.Location = New System.Drawing.Point(218, 402)
        Me.kitchenTourTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.kitchenTourTextBox.Name = "kitchenTourTextBox"
        Me.kitchenTourTextBox.Size = New System.Drawing.Size(110, 26)
        Me.kitchenTourTextBox.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(378, 365)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(61, 20)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Yes/No"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(376, 406)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 20)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Yes/No"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(50, 495)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(136, 20)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Number of Adults:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(50, 538)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(149, 20)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Number of Children:"
        '
        'numAdultsTextBox
        '
        Me.numAdultsTextBox.Location = New System.Drawing.Point(218, 495)
        Me.numAdultsTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.numAdultsTextBox.Name = "numAdultsTextBox"
        Me.numAdultsTextBox.Size = New System.Drawing.Size(110, 26)
        Me.numAdultsTextBox.TabIndex = 20
        '
        'numChildrenTextBox
        '
        Me.numChildrenTextBox.Location = New System.Drawing.Point(218, 534)
        Me.numChildrenTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.numChildrenTextBox.Name = "numChildrenTextBox"
        Me.numChildrenTextBox.Size = New System.Drawing.Size(110, 26)
        Me.numChildrenTextBox.TabIndex = 21
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(356, 506)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(253, 20)
        Me.Label13.TabIndex = 22
        Me.Label13.Text = "A group of 4+ qualifies for 25% off!"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(356, 534)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(166, 20)
        Me.Label14.TabIndex = 23
        Me.Label14.Text = "Children are half price."
        '
        'calculateChargeButton
        '
        Me.calculateChargeButton.Location = New System.Drawing.Point(81, 588)
        Me.calculateChargeButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.calculateChargeButton.Name = "calculateChargeButton"
        Me.calculateChargeButton.Size = New System.Drawing.Size(282, 38)
        Me.calculateChargeButton.TabIndex = 24
        Me.calculateChargeButton.Text = "Calculate Charge"
        Me.calculateChargeButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.Location = New System.Drawing.Point(442, 588)
        Me.exitButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(110, 38)
        Me.exitButton.TabIndex = 25
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'registrationSummaryTextBox
        '
        Me.registrationSummaryTextBox.Location = New System.Drawing.Point(45, 688)
        Me.registrationSummaryTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.registrationSummaryTextBox.Multiline = True
        Me.registrationSummaryTextBox.Name = "registrationSummaryTextBox"
        Me.registrationSummaryTextBox.ReadOnly = True
        Me.registrationSummaryTextBox.Size = New System.Drawing.Size(524, 293)
        Me.registrationSummaryTextBox.TabIndex = 26
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(39, 652)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(276, 29)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "Registration Summary:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 1012)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.registrationSummaryTextBox)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.calculateChargeButton)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.numChildrenTextBox)
        Me.Controls.Add(Me.numAdultsTextBox)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.kitchenTourTextBox)
        Me.Controls.Add(Me.gardenTourTextBox)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.sevenPMbutton)
        Me.Controls.Add(Me.fivePMbutton)
        Me.Controls.Add(Me.threePMbutton)
        Me.Controls.Add(Me.dateTextBox)
        Me.Controls.Add(Me.customerPhoneTextBox)
        Me.Controls.Add(Me.customerNameTextBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Registration Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents customerNameTextBox As TextBox
    Friend WithEvents customerPhoneTextBox As TextBox
    Friend WithEvents dateTextBox As TextBox
    Friend WithEvents threePMbutton As Button
    Friend WithEvents fivePMbutton As Button
    Friend WithEvents sevenPMbutton As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents gardenTourTextBox As TextBox
    Friend WithEvents kitchenTourTextBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents numAdultsTextBox As TextBox
    Friend WithEvents numChildrenTextBox As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents calculateChargeButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents registrationSummaryTextBox As TextBox
    Friend WithEvents Label15 As Label
End Class
