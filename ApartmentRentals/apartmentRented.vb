'Affirmation of Authorship
'Name: Jorge Sirias
'Date :  6/6/2018
'I affirm that this program was created by Me. It Is solely my work And does Not include any work done by anyone Else.

Public Class frmApartmentRented
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        'Hide Form
        Me.Hide()

    End Sub

    Private Sub frmApartmentRented_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Clear form for better representation of listing 
        lstRented.Items.Clear()

        'Iterate through array and display any apartment that are available in the list box control 
        For Each strApartments As String In apartments

            If strApartments.Contains("RENTED") Then

                lstRented.Items.Add(strApartments)

            End If

        Next

    End Sub

    Private Sub btnMakeAvailable_Click(sender As Object, e As EventArgs) Handles btnMakeAvailable.Click

        'Local variable to hold the selected item from listbox
        Dim strAvailable As String

        strAvailable = lstRented.SelectedItem

        If strAvailable = String.Empty Then

            MessageBox.Show("Please make a selection." + vbNewLine + "If listing is empty please close this window and try again later.")

        Else

            'Call Procedure to make apartment rented
            makeAvailable(strAvailable)

            'Hide Form
            Me.Close()

        End If

    End Sub

End Class