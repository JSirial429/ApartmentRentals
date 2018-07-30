'Affirmation of Authorship
'Name: Jorge Sirias
'Date :  6/6/2018
'I affirm that this program was created by Me. It Is solely my work And does Not include any work done by anyone Else.



Public Class frmApartmentRentals


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Clear label display during initial run time
        lblAvailableOutput.Text = String.Empty
        lblRentedOutput.Text = String.Empty
        lblTotalOutput.Text = String.Empty

        'Add to combo box during runtime
        With cboStatusCount

            .Items.Add("RENTED")
            .Items.Add("AVAILABLE")

        End With

    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click

        Me.Close()

    End Sub

    Private Sub mnuAvailable_Click(sender As Object, e As EventArgs) Handles mnuAvailable.Click

        If blnEmptyArray = False Then

            'Display Modal
            frmApartmentAvailable.ShowDialog()

        Else

            MessageBox.Show("There is no available listings to show!")

        End If


    End Sub

    Private Sub mnuRented_Click(sender As Object, e As EventArgs) Handles mnuRented.Click

        If blnEmptyArray = False Then

            'Display Modal
            frmApartmentRented.ShowDialog()

        Else

            MessageBox.Show("There is no available listings to show!")

        End If


    End Sub

    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click

        MessageBox.Show("Application Name: Apartment Rentals
                         Version: 1.0")

    End Sub

    Private Sub mnuReset_Click(sender As Object, e As EventArgs) Handles mnuReset.Click

        'Set boolean to true when clearing array
        blnEmptyArray = True

        'Set the array to zero elements
        ReDim apartments(0)


        'Clear all label outputs and listbox 
        lstApartments.Items.Clear()
        total = 0
        apartmentsAvailble = 0
        apartmentsRented = 0

        'Display zero output
        lblTotalOutput.Text = "$" + CStr(total)
        lblAvailableOutput.Text = "$" + CStr(apartmentsAvailble)
        lblRentedOutput.Text = "$" + CStr(apartmentsRented)


    End Sub

    Private Sub frmApartmentRentals_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated



        'Clear listbox when focusing on form after every event for more accurate representation
        lstApartments.Items.Clear()

        'START OF IF STATEMENT(Experimental)
        If blnEmptyArray = False Then
            'Display Array at initial time 
            For Each strApartments As String In apartments

                lstApartments.Items.Add(strApartments)

            Next
            'End If

            'Calculate total to be displayed on screen
            CalculateTotal()
            lblTotalOutput.Text = "$" + CStr(total)

            'Display rented and available amounts in form
            lblRentedOutput.Text = "$" + CStr(apartmentsRented)
            lblAvailableOutput.Text = "$" + CStr(apartmentsAvailble)
        End If

    End Sub

    Private Sub cboStatusCount_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStatusCount.SelectedIndexChanged

        If cboStatusCount.SelectedItem.Equals("AVAILABLE") Then

            CountArray("AVAILABLE")

        ElseIf cboStatusCount.SelectedItem.Equals("RENTED") Then

            CountArray("RENTED")

        Else

            MessageBox.Show("Please choose either AVAILABLE or RENTED.", "Contains?")

        End If

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        'local varaible that holds the index to be deleted
        Dim intIndex As Integer

        intIndex = lstApartments.SelectedIndex

        If intIndex <= -1 Then

            MessageBox.Show("No apartment selected. Please choose one and try again.")

        Else

            MessageBox.Show("You have selected to remove an apartment listing!")
            'call procedure to update array 
            RemoveIndex(intIndex)

        End If

    End Sub

End Class
