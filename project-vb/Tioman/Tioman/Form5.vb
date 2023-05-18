Imports System.IO
Public Class Form5
    Dim custInfo As StreamReader
    Dim bookingReport As StreamReader

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim name, IC, email, Phone, Package, addOn, bookDate, adultCount, childCount, seniorCount, addCount, addPrice, totalPrice As String
        Dim fileName As String

        CustomerFileDialog.Filter = "TEXT FILE | *.txt"
        If CustomerFileDialog.ShowDialog = DialogResult.OK Then
            fileName = CustomerFileDialog.FileName
        End If
        lstReport.Items.Clear()
        Try
            custInfo = File.OpenText(fileName)
            name = custInfo.ReadLine
            Phone = custInfo.ReadLine
            IC = custInfo.ReadLine
            email = custInfo.ReadLine
            Package = custInfo.ReadLine
            addOn = custInfo.ReadLine
            bookDate = custInfo.ReadLine
            adultCount = custInfo.ReadLine
            childCount = custInfo.ReadLine
            seniorCount = custInfo.ReadLine
            addCount = custInfo.ReadLine
            addPrice = custInfo.ReadLine
            totalPrice = custInfo.ReadLine
            custInfo.Close()

            getCustReport(name, IC, email, Phone, Package, addOn, bookDate, adultCount, childCount, seniorCount, addCount, addPrice, totalPrice)
        Catch ex As Exception
            MessageBox.Show("File does not exist!", "Alert")
        End Try
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Me.Hide()
        Form2.Show()
        lstReport.Items.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim custA, custB, custC As Integer
        Dim packPriceA, packPriceB, packPriceC, addPriceA, addPriceB, addPriceC, totalPackA, totalPackB, totalPackC, totalPackageAll, totalAddAll, totalAll As Double
        Dim highest, lowest As String

        Try
            bookingReport = File.OpenText("Report Package A.txt")
            custA = bookingReport.ReadLine
            packPriceA = bookingReport.ReadLine
            addPriceA = bookingReport.ReadLine
            totalPackA = bookingReport.ReadLine
            bookingReport.Close()
        Catch ex As Exception
            MessageBox.Show("File does not exist!")
        End Try

        Try
            bookingReport = File.OpenText("Report Package B.txt")
            custB = bookingReport.ReadLine
            packPriceB = bookingReport.ReadLine
            addPriceB = bookingReport.ReadLine
            totalPackB = bookingReport.ReadLine
            bookingReport.Close()
        Catch ex As Exception
            MessageBox.Show("File does not exist!")
        End Try

        Try
            bookingReport = File.OpenText("Report Package C.txt")
            custC = bookingReport.ReadLine
            packPriceC = bookingReport.ReadLine
            addPriceC = bookingReport.ReadLine
            totalPackC = bookingReport.ReadLine
            bookingReport.Close()
        Catch ex As Exception
            MessageBox.Show("File does not exist!")
        End Try

        totalPackageAll = getTotalPackage(packPriceA, packPriceB, packPriceC)
        totalAddAll = getTotaladd(addPriceA, addPriceB, addPriceC)
        highest = getHighest(custA, custB, custC)
        lowest = getLowest(custA, custB, custC)
        totalAll = getDueTotal(totalPackageAll, totalAddAll)

        getBookingReport(custA, custB, custC, highest, lowest, packPriceA, packPriceB, packPriceC, addPriceA, addPriceB, addPriceC, totalPackageAll, totalAddAll, totalAll)

    End Sub

    Private Function getTotalPackage(ByVal packA, ByVal packB, ByVal packC) As Double
        Dim total As Double
        total = packA + packB + packC
        Return total
    End Function

    Private Function getTotaladd(ByVal packA, ByVal packB, ByVal packC) As Double
        Dim total As Double
        total = packA + packB + packC
        Return total
    End Function

    Private Function getHighest(ByVal packA, ByVal packB, ByVal packC) As String
        Dim highest As String

        If packA > packB And packA > packC Then
            highest = "Package 1 (Visitor)"
        ElseIf packB > packA And packb > packC Then
            highest = "Package 2 (Explorer)"
        ElseIf packC > packA And packC > packB Then
            highest = "Package 3 (Traveller)"
        ElseIf packA = packB And packB = packC Then
            highest = "Package 1 (Visitor) , Package 2 (Explorer) & Package 3 (Traveller)"
        ElseIf packA = packB Or packB = packA Then
            highest = "Package 1 (Visitor) & Package 2 (Explorer)"
        ElseIf packA = packC Or packA = packC Then
            highest = "Package 1 (Visitor) & Package 3 (Traveller)"
        ElseIf packC = packB Or packB = packC Then
            highest = "Package 2 (Explorer) & Package 3 (Traveller)"
        End If

        Return highest
    End Function

    Private Function getLowest(ByVal packA, ByVal packB, ByVal packC) As String
        Dim lowest As String

        If packA < packB And packA < packC Then
            lowest = "Package 1 (Visitor)"
        ElseIf packB < packA And packA < packC Then
            lowest = "Package 2 (Explorer)"
        ElseIf packC < packA And packC < packB Then
            lowest = "Package 3 (Traveller)"
        ElseIf packA = packB And packB = packC Then
            lowest = "Package 1 (Visitor) , Package 2 (Explorer) & Package 3 (Traveller)"
        ElseIf packA = packB Or packB = packA Then
            lowest = "Package 1 (Visitor) & Package 2 (Explorer)"
        ElseIf packA = packC Or packA = packC Then
            lowest = "Package 1 (Visitor) & Package 3 (Traveller)"
        ElseIf packC = packB Or packB = packC Then
            lowest = "Package 2 (Explorer) & Package 3 (Traveller)"
        End If

        Return lowest
    End Function

    Private Function getDueTotal(ByVal totalPackAll, ByVal totalAddAll) As Double
        Dim totalDue As Double

        totalDue = totalPackAll + totalAddAll
        Return totalDue
    End Function
    Private Sub getCustReport(ByRef name, ByRef IC, ByRef email, ByRef Phone, ByRef Package, ByRef addOn, ByRef bookDate, ByRef adultCount, ByRef childCount, ByRef seniorCount, ByRef addCount, ByRef addPrice, ByRef totalPrice)
        lstReport.Items.Clear()
        lstReport.Items.Add("Name: " & name)
        lstReport.Items.Add("Phone Number: " & Phone)
        lstReport.Items.Add("IC: " & IC)
        lstReport.Items.Add("Email Address: " & email)
        lstReport.Items.Add("Package Picked: " & Package)
        lstReport.Items.Add(addOn)
        lstReport.Items.Add("Date booked: " & bookDate)
        lstReport.Items.Add("Adult: " & adultCount)
        lstReport.Items.Add("Child: " & childCount)
        lstReport.Items.Add("Senior: " & seniorCount)
        lstReport.Items.Add("Add-On added: " & addCount)
        lstReport.Items.Add("Add-On Total: " & Format(Val(addPrice), "RM#,##0.00"))
        lstReport.Items.Add("Total Price: " & Format(Val(totalPrice), "RM#,##0.00"))
    End Sub

    Private Sub getBookingReport(ByRef custA, ByRef custB, ByRef custC, ByRef highest, ByRef lowest, ByRef packPriceA, ByRef packPriceB, ByRef packPriceC, ByRef addPriceA, ByRef addPriceB, ByRef addPriceC, ByRef totalPackageAll, ByRef totalAddAll, ByRef totalAll)
        lstReport.Items.Clear()
        lstReport.Items.Add("Total customer for package 1: " & custA)
        lstReport.Items.Add("Total customer for package 2: " & custB)
        lstReport.Items.Add("Total customer for package 3: " & custC)
        lstReport.Items.Add("Most package that was chosen by the customer: " & highest)
        lstReport.Items.Add("Least package that was chosen by the customer: " & lowest)
        lstReport.Items.Add("Total package price for package 1: " & Format(Val(packPriceA), "RM#,##0.00"))
        lstReport.Items.Add("Total package price for package 2: " & Format(Val(packPriceB), "RM#,##0.00"))
        lstReport.Items.Add("Total package price for package 3: " & Format(Val(packPriceC), "RM#,##0.00"))
        lstReport.Items.Add("Total add-on price for package 1: " & Format(Val(addPriceA), "RM#,##0.00"))
        lstReport.Items.Add("Total add-on price for package 2: " & Format(Val(addPriceB), "RM#,##0.00"))
        lstReport.Items.Add("Total add-on price for package 3: " & Format(Val(addPriceC), "RM#,##0.00"))
        lstReport.Items.Add("Total package price for all package: " & Format(Val(totalPackageAll), "RM#,##0.00"))
        lstReport.Items.Add("Total add-on price for all package: " & Format(Val(totalAddAll), "RM#,##0.00"))
        lstReport.Items.Add("Total due price for all package: " & Format(Val(totalAll), "RM#,##0.00"))
    End Sub
End Class