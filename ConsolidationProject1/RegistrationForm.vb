'MIS 322
'Colin McDonald
'CP1-1
'4/24/2019

Option Explicit On : Option Strict On

Public Class RegistrationForm

    Const GARDENTOURPRICE As Double = 1.0
    Const KITCHENTOURPRICE As Double = 2.0
    Const DISCOUNTPERCENT As Double = 0.25
    Dim timeSlot As String

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        'Close form
        Me.Close()
    End Sub '-----------------------------------------------------------------------------



    Private Sub CalculateChargeButton_Click(sender As Object, e As EventArgs) _
                                            Handles calculateChargeButton.Click

        Dim customerName, customerPhone, customerDate As String
        Dim gardenTour, kitchenTour As String
        Dim numberAdults, numberChildren As Integer
        Dim grossCharge, discountAmount, pricePerPerson As Double
        Dim amountDue As Double = 0

        'Clear the summary text box
        registrationSummaryTextBox.Text = ""


        'Check that all text boxes have input, in general 
        'And that a time slot is chosen
        If customerNameTextBox.Text = "" _
            Or customerPhoneTextBox.Text = "" _
            Or dateTextBox.Text = "" _
            Or gardenTourTextBox.Text = "" _
            Or kitchenTourTextBox.Text = "" _
            Or numAdultsTextBox.Text = "" _
            Or numChildrenTextBox.Text = "" _
            Or timeSlot = "" Then
            MessageBox.Show("Please make sure the entire form is filled and that " &
                            "a time is selected", "Form Completion Error")
            registrationSummaryTextBox.Text = ""
            Exit Sub
        End If

        'After the first check allocate the proper string values
        customerName = customerNameTextBox.Text
        customerPhone = customerPhoneTextBox.Text
        customerDate = dateTextBox.Text

        'Check if garden tour and kitchen tour are yes or no and nothing else
        If gardenTourTextBox.Text.ToUpper = "YES" Or
           gardenTourTextBox.Text.ToUpper = "NO" Then
            gardenTour = gardenTourTextBox.Text
        Else
            MessageBox.Show("Please select yes or no in both tour text boxes",
                            "Tour Text Box Completion Error ")
            registrationSummaryTextBox.Text = ""
            Exit Sub
        End If

        If kitchenTourTextBox.Text.ToUpper = "YES" Or
           kitchenTourTextBox.Text.ToUpper = "NO" Then
            kitchenTour = kitchenTourTextBox.Text
        Else
            MessageBox.Show("Please select yes or no in both tour text boxes",
                            "Tour Text Box Completion Error")
            registrationSummaryTextBox.Text = ""
            Exit Sub
        End If

        'Check if number of Adults/Children are numbers
        'That are not less than 0
        Try
            numberAdults = Convert.ToInt32(numAdultsTextBox.Text)
            numberChildren = Convert.ToInt32(numChildrenTextBox.Text)
            'If adult/children is less than 0  exit sub
            If numberAdults < 0 Or numberChildren < 0 Then
                MessageBox.Show("The number of adults and children cannot be less than 0",
                                "Invalid Number Error")
                registrationSummaryTextBox.Text = ""
                Exit Sub
            End If
        Catch fe As FormatException
            MessageBox.Show("Please enter a whole number", "Non-Integer Error")
            registrationSummaryTextBox.Text = ""
            Exit Sub
        Catch ex As Exception
            MessageBox.Show("Unexpected Error" & ex.Message, "Unexpected Error")
            registrationSummaryTextBox.Text = ""
            Exit Sub
        End Try

        'Time to go through the business rules.
        'If both garden tour or kitchen tour throw an error
        If gardenTour.ToLower = "no" _
        And kitchenTour.ToLower = "no" Then
            MessageBox.Show("Please select the garden tour, or the kitchen tour " _
                            & "or both", "Tour Selection Error")
            registrationSummaryTextBox.Text = ""
            Exit Sub
        End If

        'Two checks to see if garden/kitchen tours are marked yes then add
        'tour price to the price per person
        If gardenTour.ToLower = "yes" Then
            pricePerPerson += GARDENTOURPRICE
        End If
        If kitchenTour.ToLower = "yes" Then
            pricePerPerson += KITCHENTOURPRICE
        End If

        'If the combo of adults and children are more than 17 throw an error
        If numberAdults + numberChildren > 17 Then
            MessageBox.Show("There can be no more than 17 people per tour",
                             "Attendee Total Error")
            registrationSummaryTextBox.Text = ""
            Exit Sub
        End If

        'If children is greater than 9 throw an error
        If numberChildren > 9 Then
            MessageBox.Show("There can be no more than 9 children per tour",
                 "Child Total Error")
            registrationSummaryTextBox.Text = ""
            Exit Sub
        End If

        'If there is 2+ children and no adults throw an error
        If numberChildren >= 2 And numberAdults < 1 Then
            MessageBox.Show("There must be at lease 1 adult with two or more children",
                            "Child Total Error")
            registrationSummaryTextBox.Text = ""
            Exit Sub
        End If

        'gross charge is calculated regardless of the dicount
        grossCharge = (pricePerPerson * numberAdults) +
                      (pricePerPerson * 0.5 * numberChildren)


        'If attendees is 4+ then use discount if not then 0 out discount then 
        'calculate amount due.
        If (numberAdults + numberChildren) >= 4 Then
            discountAmount = grossCharge * DISCOUNTPERCENT
            amountDue = grossCharge - discountAmount
        Else
            discountAmount = 0
            amountDue = grossCharge - discountAmount
        End If


        'This is where we include all the messages.
        registrationSummaryTextBox.Text =
            "Name: " & customerName.ToString() & vbNewLine
        registrationSummaryTextBox.Text &=
            "Phone: " & customerPhone.ToString() & vbNewLine
        registrationSummaryTextBox.Text &=
            "Date: " & customerDate.ToString() & vbNewLine
        registrationSummaryTextBox.Text &=
            "Time: " & timeSlot.ToString() & vbNewLine
        registrationSummaryTextBox.Text &=
             "Garden Tour: " & gardenTour.ToString() & vbNewLine
        registrationSummaryTextBox.Text &=
            "Kitchen Tour: " & kitchenTour.ToString() & vbNewLine
        registrationSummaryTextBox.Text &=
            "# of Adults: " & numberAdults.ToString() & vbNewLine
        registrationSummaryTextBox.Text &=
            "# of Children: " & numberChildren.ToString() & vbNewLine
        registrationSummaryTextBox.Text &=
            "Gross Charge: " & grossCharge.ToString("C2") & vbNewLine
        registrationSummaryTextBox.Text &=
            "Discount Amount: " & discountAmount.ToString("C2") & vbNewLine
        registrationSummaryTextBox.Text &=
            "Amount Due: " & amountDue.ToString("C2")

    End Sub '-----------------------------------------------------------------------------

    Private Sub SevenPMbutton_Click(sender As Object, e As EventArgs) Handles sevenPMbutton.Click

        timeSlot = "7:00pm"
        threePMbutton.BackColor = Color.White
        fivePMbutton.BackColor = Color.White
        sevenPMbutton.BackColor = Color.Coral

    End Sub '-----------------------------------------------------------------------------

    Private Sub FivePMbutton_Click(sender As Object, e As EventArgs) Handles fivePMbutton.Click

        timeSlot = "5:00pm"
        threePMbutton.BackColor = Color.White
        fivePMbutton.BackColor = Color.Coral
        sevenPMbutton.BackColor = Color.White

    End Sub '-----------------------------------------------------------------------------

    Private Sub ThreePMbutton_Click(sender As Object, e As EventArgs) Handles threePMbutton.Click

        timeSlot = "3:00pm"
        threePMbutton.BackColor = Color.Coral
        fivePMbutton.BackColor = Color.White
        sevenPMbutton.BackColor = Color.White

    End Sub '-----------------------------------------------------------------------------


End Class
