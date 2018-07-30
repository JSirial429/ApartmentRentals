'Affirmation of Authorship
'Name: Jorge Sirias
'Date :  6/6/2018
'I affirm that this program was created by Me. It Is solely my work And does Not include any work done by anyone Else.

Module modApartmentRentals

    'Constant variables for apartment cost
    Const dblBUILDING_A As Double = 500
    Const dblBUILDING_B As Double = 750
    Const dblBUILDING_C As Double = 1000

    'An array of apartment listing
    Public apartments() As String = {"BldA-Unit 101(AVAILABLE)", "BldA-Unit 201(AVAILABLE)", "BldA-Unit 301(AVAILABLE)",
                   "BldB-Unit 101(AVAILABLE)", "BldB-Unit 201(AVAILABLE)", "BldB-Unit 301(AVAILABLE)", "BldC-Unit 101(AVAILABLE)",
                   "BldC-Unit 201(AVAILABLE)", "BldC-Unit 301(AVAILABLE)"}

    'global variable that holds total
    Public total As Double = 0

    'Variables used in the processing of calculating total 
    Public apartmentsAvailble As Double
    Public apartmentsRented As Double

    'Cclass variable that states whether an array is empty or not
    Public blnEmptyArray As Boolean = False

    Public Sub CalculateTotal()

        ''Variables used in the processing of calculating total 
        'Dim apartmentsAvailble As Double
        'Dim apartmentsRented As Double

        'Counter variables
        Dim availableBldACount As Integer = 0
        Dim availableBldBCount As Integer = 0
        Dim availableBldCCount As Integer = 0

        Dim rentedBldACOunt As Integer = 0
        Dim rentedBldBCOunt As Integer = 0
        Dim rentedBldCCOunt As Integer = 0



        'For loop that counts the number of avaible or rented apartment
        For intCount = 0 To apartments.Count - 1

            If apartments(intCount).Contains("BldA") And apartments(intCount).Contains("AVAILABLE") Then

                availableBldACount = availableBldACount + 1

            ElseIf apartments(intCount).Contains("BldA") And apartments(intCount).Contains("RENTED") Then

                rentedBldACOunt = rentedBldACOunt + 1

            ElseIf apartments(intCount).Contains("BldB") And apartments(intCount).Contains("AVAILABLE") Then

                availableBldBCount = availableBldBCount + 1

            ElseIf apartments(intCount).Contains("BldB") And apartments(intCount).Contains("RENTED") Then

                rentedBldBCOunt = rentedBldBCOunt + 1

            ElseIf apartments(intCount).Contains("BldC") And apartments(intCount).Contains("AVAILABLE") Then

                availableBldCCount = availableBldCCount + 1

            ElseIf apartments(intCount).Contains("BldC") And apartments(intCount).Contains("RENTED") Then

                rentedBldCCOunt = rentedBldCCOunt + 1

            End If

        Next



        'Calaculate available apartments
        availableBldACount = availableBldACount * dblBUILDING_A
        availableBldBCount = availableBldBCount * dblBUILDING_B
        availableBldCCount = availableBldCCount * dblBUILDING_C

        apartmentsAvailble = (availableBldACount + availableBldBCount + availableBldCCount) * -1

        'Calculate rented apartments
        rentedBldACOunt = rentedBldACOunt * dblBUILDING_A
        rentedBldBCOunt = rentedBldBCOunt * dblBUILDING_B
        rentedBldCCOunt = rentedBldCCOunt * dblBUILDING_C

        apartmentsRented = rentedBldACOunt + rentedBldBCOunt + rentedBldCCOunt

        'Calculating total
        total = apartmentsRented + apartmentsAvailble

    End Sub

    Public Sub CountArray(ByVal strName As String)

        'Local counter variable
        Dim intcounter As Integer = 0

        If blnEmptyArray = False Then

            If strName = "AVAILABLE" Then

                For intCount = 0 To apartments.Count - 1

                    If apartments(intCount).Contains("AVAILABLE") Then

                        intcounter = intcounter + 1

                    End If

                Next

                If intcounter > 0 Then

                    MessageBox.Show("Contains AVAILABLE Count= " + CStr(intcounter), "Contains?")

                Else

                    MessageBox.Show("Listing does not contain any apartments available.", "Contains?")

                End If


            ElseIf strName = "RENTED" Then

                For intCount = 0 To apartments.Count - 1

                    If apartments(intCount).Contains("RENTED") Then

                        intcounter = intcounter + 1

                    End If

                Next

                If intcounter > 0 Then

                    MessageBox.Show("Contains RENTED Count= " + CStr(intcounter), "Contains?")

                Else

                    MessageBox.Show("Listing does not contain any apartments that are rented.", "Contains?")

                End If

            Else

                MessageBox.Show("Please choose either AVAILABLE or RENTED.", "Contains?")

            End If

        Else

            MessageBox.Show("There is no apartment listing to account for!")

        End If

    End Sub

    Public Sub RemoveIndex(ByVal intIndex As Integer)

        'Local array that copies elements from the original array
        Dim copyArray(apartments.Length - 1) As String

        'Local variable that holds the element of an array
        Dim strElement As String

        'Copying original array into local array
        apartments.CopyTo(copyArray, 0)

        'Redim array to include all elements before the index that needs to be removed
        ReDim Preserve apartments(intIndex - 1)

        ReDim Preserve apartments(copyArray.Length - 2)

        'For loop that will iterate through the redimmed array while adding elements from 
        'the copy array at index + 1 position
        For intCount = intIndex To apartments.Length - 1

            strElement = copyArray(intCount + 1)
            apartments(intCount) = strElement

        Next



    End Sub

    Public Sub makeRented(ByVal strValue As String)

        'Local varaible to hold substring of apartment listing minus available status
        Dim strApartment As String

        strApartment = strValue.Substring(0, 13)

        'Iterates to the array to find an exact match as the parameter and then substitue the 
        'element in the array with 
        For intCount = 0 To apartments.Length - 1

            If apartments(intCount).Contains(strValue) Then

                apartments(intCount) = strApartment + "(RENTED)"

            End If

        Next

    End Sub

    Public Sub makeAvailable(ByVal strValue As String)

        'Local varaible to hold substring of apartment listing minus available status
        Dim strApartment As String

        strApartment = strValue.Substring(0, 13)

        'Iterates to the array to find an exact match as the parameter and then substitue the 
        'element in the array with 
        For intCount = 0 To apartments.Length - 1

            If apartments(intCount).Contains(strValue) Then

                apartments(intCount) = strApartment + "(AVAILABLE)"

            End If

        Next

    End Sub

End Module
