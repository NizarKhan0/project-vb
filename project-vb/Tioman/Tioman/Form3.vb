Imports System.IO
Public Class Form3
    Dim adult, child, senior, addCount As Integer
    Dim countA, countB, countC, totalCountA, totalCountB, totalCountC As Integer
    Dim book As New Date
    Dim priceAdult, priceChild, priceSenior, priceAdd, packagePrice, total As Double
    Dim totalAllA, totalAllB, totalAllC, totalAddA, totalAddB, totalAddC, totalPackA, totalPackB, totalPackC As Double


    Dim bookingFile As StreamWriter
    Dim reportFile As StreamWriter
    Dim savedFile As StreamWriter
    Dim readReportFile As StreamReader
    Dim readSavedFile As StreamReader
    Private Sub btnProceed_Click(sender As Object, e As EventArgs) Handles btnProceed.Click
        If txtName.Text = "" Or txtIC.Text = "" Or txtEmail.Text = "" Or txtContact.Text = "" Then
            MessageBox.Show("Please complete the form!")
        Else
            adult = Val(cboAdult.SelectedItem)
            child = Val(cboChild.SelectedItem)
            senior = Val(cboSenior.SelectedItem)

            book = bookDate.Value

            priceAdult = Form2.priceAdult
            priceChild = Form2.priceChild
            priceSenior = Form2.priceSenior
            priceAdd = Form2.priceAdd

            addCount = Val(txtAdd.Text)
            packagePrice = getPackagePrice(priceAdult, priceChild, priceSenior, adult, child, senior)
            priceAdd = getAddPrice(priceAdd, addCount)
            total = getTotal(packagePrice, priceAdd)

            Receipt.outName.Text = txtName.Text
            Receipt.PhoneNumber.Text = txtContact.Text
            Receipt.IC.Text = txtIC.Text
            Receipt.Email.Text = txtEmail.Text
            Receipt.Package.Text = lstPackage.Items(0)
            Receipt.AddOn.Text = lstAddOn.Items(0)
            Receipt.DateBook.Text = Format(book, "short date")
            Receipt.Adult.Text = adult
            Receipt.Child.Text = child
            Receipt.Senior.Text = senior
            Receipt.Add.Text = addCount
            Receipt.AddPrice.Text = Format(priceAdd, "RM#,##0.00")
            Receipt.Total.Text = Format(total, "RM#,##0.00")

            Try
                bookingFile = File.CreateText("Booking " & txtName.Text & ".txt")
                bookingFile.WriteLine(txtName.Text)
                bookingFile.WriteLine(txtContact.Text)
                bookingFile.WriteLine(txtIC.Text)
                bookingFile.WriteLine(txtEmail.Text)
                bookingFile.WriteLine(lstPackage.Items(0))
                bookingFile.WriteLine(lstAddOn.Items(0))
                bookingFile.WriteLine(Format(book, "Short Date"))
                bookingFile.WriteLine(adult)
                bookingFile.WriteLine(child)
                bookingFile.WriteLine(senior)
                bookingFile.WriteLine(txtAdd.Text)
                bookingFile.WriteLine(priceAdd.ToString)
                bookingFile.WriteLine(total.ToString)
                bookingFile.Close()
            Catch ex As Exception
                MessageBox.Show("File cannot be created!", "Alert")
            End Try

            Try
                If Form2.cboPackage.SelectedIndex = 0 Then
                    If File.Exists("Saved Booking Report A.txt") = False Then
                        totalCountA += 1
                        totalPackA += packagePrice
                        totalAddA += priceAdd
                        totalAllA += total
                        savedFile = File.CreateText("Saved Booking Report A.txt")
                        reportFile = File.CreateText("Report Package A.txt")
                        reportFile.WriteLine(totalCountA)
                        reportFile.WriteLine(totalPackA)
                        reportFile.WriteLine(totalAddA)
                        reportFile.WriteLine(totalAllA)
                        reportFile.Close()
                        readReportFile = File.OpenText("Report Package A.txt")
                        savedFile.WriteLine(readReportFile.ReadLine)
                        savedFile.WriteLine(readReportFile.ReadLine)
                        savedFile.WriteLine(readReportFile.ReadLine)
                        savedFile.WriteLine(readReportFile.ReadLine)
                        savedFile.Close()
                        readReportFile.Close()
                    Else
                        readSavedFile = File.OpenText("Saved Booking Report A.txt")

                        totalCountA = Val(readSavedFile.ReadLine) + 1
                        totalPackA = Val(readSavedFile.ReadLine) + packagePrice
                        totalAddA = Val(readSavedFile.ReadLine) + priceAdd
                        totalAllA = Val(readSavedFile.ReadLine) + total
                        readSavedFile.Close()

                        savedFile = File.CreateText("Saved Booking Report A.txt")
                        reportFile = File.CreateText("Report Package A.txt")
                        reportFile.WriteLine(totalCountA)
                        reportFile.WriteLine(totalPackA)
                        reportFile.WriteLine(totalAddA)
                        reportFile.WriteLine(totalAllA)
                        reportFile.Close()
                        readReportFile = File.OpenText("Report Package A.txt")
                        savedFile.WriteLine(readReportFile.ReadLine)
                        savedFile.WriteLine(readReportFile.ReadLine)
                        savedFile.WriteLine(readReportFile.ReadLine)
                        savedFile.WriteLine(readReportFile.ReadLine)
                        savedFile.Close()
                        readReportFile.Close()
                    End If
                ElseIf Form2.cboPackage.SelectedIndex = 1 Then
                    If File.Exists("Saved Booking Report B.txt") = False Then
                        totalCountB += 1
                        totalPackB += packagePrice
                        totalAddB += priceAdd
                        totalAllB += total
                        savedFile = File.CreateText("Saved booking Report B.txt")
                        reportFile = File.CreateText("Report Package B.txt")
                        reportFile.WriteLine(totalCountB)
                        reportFile.WriteLine(totalPackB)
                        reportFile.WriteLine(totalAddB)
                        reportFile.WriteLine(totalAllB)
                        reportFile.Close()
                        readReportFile = File.OpenText("Report Package B.txt")
                        savedFile.WriteLine(readReportFile.ReadLine)
                        savedFile.WriteLine(readReportFile.ReadLine)
                        savedFile.WriteLine(readReportFile.ReadLine)
                        savedFile.WriteLine(readReportFile.ReadLine)
                        savedFile.Close()
                        readReportFile.Close()
                    Else
                        readSavedFile = File.OpenText("Saved Booking Report B.txt")

                        totalCountB = Val(readSavedFile.ReadLine) + 1
                        totalPackB = Val(readSavedFile.ReadLine) + packagePrice
                        totalAddB = Val(readSavedFile.ReadLine) + priceAdd
                        totalAllB = Val(readSavedFile.ReadLine) + total
                        readSavedFile.Close()

                        savedFile = File.CreateText("Saved Booking Report B.txt")
                        reportFile = File.CreateText("Report Package B.txt")
                        reportFile.WriteLine(totalCountB)
                        reportFile.WriteLine(totalPackB)
                        reportFile.WriteLine(totalAddB)
                        reportFile.WriteLine(totalAllB)
                        reportFile.Close()
                        readReportFile = File.OpenText("Report Package B.txt")
                        savedFile.WriteLine(readReportFile.ReadLine)
                        savedFile.WriteLine(readReportFile.ReadLine)
                        savedFile.WriteLine(readReportFile.ReadLine)
                        savedFile.WriteLine(readReportFile.ReadLine)
                        savedFile.Close()
                        readReportFile.Close()
                    End If
                ElseIf Form2.cboPackage.SelectedIndex = 2 Then
                    If File.Exists("Saved Booking Report C.txt") = False Then
                        totalCountC += 1
                        totalPackC += packagePrice
                        totalAddC += priceAdd
                        totalAllC += total
                        savedFile = File.CreateText("Saved Booking Report C.txt")
                        reportFile = File.CreateText("Report Package C.txt")
                        reportFile.WriteLine(totalCountC)
                        reportFile.WriteLine(totalPackC)
                        reportFile.WriteLine(totalAddC)
                        reportFile.WriteLine(totalAllC)
                        reportFile.Close()
                        readReportFile = File.OpenText("Report Package C.txt")
                        savedFile.WriteLine(readReportFile.ReadLine)
                        savedFile.WriteLine(readReportFile.ReadLine)
                        savedFile.WriteLine(readReportFile.ReadLine)
                        savedFile.WriteLine(readReportFile.ReadLine)
                        savedFile.Close()
                        readReportFile.Close()
                    Else
                        readSavedFile = File.OpenText("Saved Booking Report C.txt")

                        totalCountC = Val(readSavedFile.ReadLine) + 1
                        totalPackC = Val(readSavedFile.ReadLine) + packagePrice
                        totalAddC = Val(readSavedFile.ReadLine) + priceAdd
                        totalAllC = Val(readSavedFile.ReadLine) + total
                        readSavedFile.Close()

                        savedFile = File.CreateText("Saved Booking Report C.txt")
                        reportFile = File.CreateText("Report Package C.txt")
                        reportFile.WriteLine(totalCountC)
                        reportFile.WriteLine(totalPackC)
                        reportFile.WriteLine(totalAddC)
                        reportFile.WriteLine(totalAllC)
                        reportFile.Close()
                        readReportFile = File.OpenText("Report Package C.txt")
                        savedFile.WriteLine(readReportFile.ReadLine)
                        savedFile.WriteLine(readReportFile.ReadLine)
                        savedFile.WriteLine(readReportFile.ReadLine)
                        savedFile.WriteLine(readReportFile.ReadLine)
                        savedFile.Close()
                        readReportFile.Close()
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("File cannot be Created!", "Alert")
            End Try

            Receipt.Show()
        End If
    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim i As Integer = 0
        For index = 0 To 10
            cboAdult.Items.Add(i)
            cboChild.Items.Add(i)
            cboSenior.Items.Add(i)
            i += 1
        Next
    End Sub
    Private Function getTotal(ByVal packagePrice, ByVal addPrice) As Double
        Dim total As Double
        total = packagePrice + addPrice
        Return total
    End Function

    Private Function getPackagePrice(ByVal adultPrice, ByVal childPrice, ByVal seniorPrice, ByVal adult, ByVal child, ByVal senior) As Double
        Dim priceTotal As Double

        priceAdult = adult * priceAdult
        priceChild = child * priceChild
        priceSenior = senior * priceSenior

        priceTotal = priceAdult + priceChild + priceSenior
        Return priceTotal
    End Function

    Private Function getAddPrice(ByVal priceAdd, ByVal addCount) As Double
        Dim addTotal As Double
        addTotal = priceAdd * addCount
        Return addTotal
    End Function

End Class