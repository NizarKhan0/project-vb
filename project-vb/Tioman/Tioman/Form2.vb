Public Class Form2
    Public strData(,) = {{"Visitor", "Exploring Coral Island", "Island Hopping", "60", "45", "45"},
                        {"Explorer", "Scuba Diving", "Hiking", "90", "70", "60"},
                        {"Traveller", "Snorkeling", "Island Hopping", "80", "65", "65"}}

    Public strAdd(,) = {{"Snorkeling", "Scuba Diving", "Hiking", "Kayaking"},
                    {"Snorkeling", "Visiting Coral Island", "Kayaking", "Island Hoping"},
                    {"Scuba Diving", "Hiking", "Kayaking", "Visit Coral Island"}}

    Public priceAdult, priceChild, priceSenior, priceAdd As Double

    Public countPackageA As Integer
    Public countPackageB As Integer
    Public countPackageC As Integer

    Private Sub cboPackage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPackage.SelectedIndexChanged
        If (cboPackage.SelectedIndex = 0) Then
            DisplayAd2.Visible = True
            DisplayAd.Visible = False
            DisplayAd1.Visible = False
            DisplayAd3.Visible = False
            picSnokerling.Visible = False
            picScuba.Visible = False
            picCoral.Visible = False
            picHiking.Visible = False
            picIsland.Visible = False
            pic1.Visible = True
            picKayaking.Visible = False

            priceAdult = Val(strData(0, 3))
            priceChild = Val(strData(0, 4))
            priceSenior = Val(strData(0, 5))

            lblDetail.Text = "Package 1 : " & strData(0, 0) & vbNewLine &
                            "This 3 days and 2 night package will bring you to explore the beautiful of sea coral in Coral Island" & vbNewLine &
                            "You will also enjoy visiting other island nearby (Snorkeling not included)" & vbNewLine & vbNewLine &
                            "Ticket Price :" & vbNewLine &
                            "Adult : " & Format(priceAdult, "RM#,##0.00") & vbNewLine &
                            "Child : " & Format(priceChild, "RM#,##0.00") & vbNewLine &
                            "Senior : " & Format(priceSenior, "RM#,##0.00")

            cboAddOn.Items.Clear()
            cboAddOn.Items.Add("No Add-on")
            For j As Integer = 0 To 3
                cboAddOn.Items.Add(strAdd(0, j))
            Next

        ElseIf (cbopackage.SelectedIndex = 1) Then
            DisplayAd1.Visible = True
            DisplayAd.Visible = False
            DisplayAd2.Visible = False
            DisplayAd3.Visible = False
            picSnokerling.Visible = False
            picScuba.Visible = False
            picCoral.Visible = False
            picHiking.Visible = False
            picIsland.Visible = False
            pic1.Visible = True
            picKayaking.Visible = False

            priceAdult = Val(strData(1, 3))
            priceChild = Val(strData(1, 4))
            priceSenior = Val(strData(1, 5))

            lblDetail.Text = "Package 2 : " & strData(1, 0) & vbNewLine &
                            "This 3 days and 2 night package will let you explore undersea creature in scuba diving activity" & vbNewLine &
                            "You will also test your fitness in hiking activity to the summit of Mount Kajang" & vbNewLine & vbNewLine &
                            "Ticket Price :" & vbNewLine &
                            "Adult : " & Format(priceAdult, "RM#,##0.00") & vbNewLine &
                            "Child : " & Format(priceChild, "RM#,##0.00") & vbNewLine &
                            "Senior : " & Format(priceSenior, "RM#,##0.00")

            cboAddOn.Items.Clear()
            cboAddOn.Items.Add("No Add-on")
            For j As Integer = 0 To 3
                cboAddOn.Items.Add(strAdd(1, j))
            Next

        ElseIf (cboPackage.SelectedIndex = 2) Then
            DisplayAd3.Visible = True
            DisplayAd.Visible = False
            DisplayAd1.Visible = False
            DisplayAd2.Visible = False
            picSnokerling.Visible = False
            picScuba.Visible = False
            picCoral.Visible = False
            picHiking.Visible = False
            picIsland.Visible = False
            pic1.Visible = True
            picKayaking.Visible = False

            priceAdult = Val(strData(2, 3))
            priceChild = Val(strData(2, 4))
            priceSenior = Val(strData(2, 5))

            lblDetail.Text = "Package 3 : " & strData(2, 0) & vbNewLine &
                            "This 3 days and 2 night package will let you attract with the sea fish and swim together with them in snorkeling activity " & vbNewLine &
                            "You will also visit some other islands near Tioman Island" & vbNewLine & vbNewLine &
                            "Ticket Price :" & vbNewLine &
                            "Adult : " & Format(priceAdult, "RM#,##0.00") & vbNewLine &
                            "Child : " & Format(priceChild, "RM#,##0.00") & vbNewLine &
                            "Senior : " & Format(priceSenior, "RM#,##0.00")
            cboAddOn.Items.Clear()
            cboAddOn.Items.Add("No Add-on")
            For j As Integer = 0 To 3
                cboAddOn.Items.Add(strAdd(2, j))
            Next

        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i As Integer = 0 To 2
            cboPackage.Items.Add(strData(i, 0))
        Next

        picSnokerling.Visible = False
        picScuba.Visible = False
        picCoral.Visible = False
        picHiking.Visible = False
        picIsland.Visible = False
        pic1.Visible = True
        picKayaking.Visible = False

        Timer1.Enabled = True
    End Sub

    Private Sub NightModeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NightModeToolStripMenuItem.Click
        DayModeToolStripMenuItem.Visible = True
        NightModeToolStripMenuItem.Visible = False
        Header.Visible = False
        NightHeader.Visible = True

        Me.BackColor = Color.DimGray
        Title.ForeColor = Color.White
        lblDesc.ForeColor = Color.White
        lblDetail.ForeColor = Color.White
        lblPackage.ForeColor = Color.White
        lblAdd.ForeColor = Color.White
        Clock.ForeColor = Color.White
        lblAddDesc.ForeColor = Color.White
    End Sub

    Private Sub DayModeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DayModeToolStripMenuItem.Click
        DayModeToolStripMenuItem.Visible = False
        NightModeToolStripMenuItem.Visible = True
        Header.Visible = True
        NightHeader.Visible = False

        Me.BackColor = Color.LightCyan
        Title.ForeColor = Color.Black
        lblDesc.ForeColor = Color.Black
        lblDetail.ForeColor = Color.Black
        lblPackage.ForeColor = Color.Black
        lblAdd.ForeColor = Color.Black
        Clock.ForeColor = Color.Black
        lblAddDesc.ForeColor = Color.Black
    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles registerBtn.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        End
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If (cboPackage.SelectedIndex = 0) Then
            countPackageA += 1
        ElseIf (cboPackage.SelectedIndex = 1) Then
            countPackageB += 1
        ElseIf (cboPackage.SelectedIndex = 2) Then
            countPackageC += 1
        End If

        Form3.Show()
        Me.Hide()

        If (cboPackage.SelectedIndex = 0) Then
            Form3.lstPackage.Items.Clear()
            Form3.lstPackage.Items.Add("Package 1 :" & strData(0, 0))
            Form3.lstPackage.Items.Add("Activities included :" & strData(0, 1) & ", " & strData(0, 2))
            Form3.lstPackage.Items.Add("Price : ")
            Form3.lstPackage.Items.Add("Adult : " & Format(priceAdult, "RM#,##00.00"))
            Form3.lstPackage.Items.Add("Child : " & Format(priceChild, "RM#,##00.00"))
            Form3.lstPackage.Items.Add("Senior: " & Format(priceSenior, "RM#,##00.00"))

            Form3.lstAddOn.Items.Clear()
            If (cboAddOn.SelectedIndex = 1) Then
                priceAdd = 40
                Form3.lstAddOn.Items.Add("Add-on activity: " & strAdd(0, 0))
                Form3.lstAddOn.Items.Add("Price: " + Format(priceAdd, "RM#,##00.00"))
            ElseIf (cboAddOn.SelectedIndex = 2) Then
                priceAdd = 70
                Form3.lstAddOn.Items.Add("Add-on activity: " & strAdd(0, 1))
                Form3.lstAddOn.Items.Add("Price: " + Format(priceAdd, "RM#,##00.00"))
            ElseIf (cboAddOn.SelectedIndex = 3) Then
                priceAdd = 30
                Form3.lstAddOn.Items.Add("Add-on activity: " & strAdd(0, 2))
                Form3.lstAddOn.Items.Add("Price: " + Format(priceAdd, "RM#,##00.00"))
            ElseIf (cboAddOn.SelectedIndex = 4) Then
                priceAdd = 50
                Form3.lstAddOn.Items.Add("Add-on activity: " & strAdd(0, 0))
                Form3.lstAddOn.Items.Add("Price: " + Format(priceAdd, "RM#,##00.00"))
            Else
                Form3.lstAddOn.Items.Add("No add-on activity added.")
            End If
        ElseIf (cboPackage.SelectedIndex = 1) Then
            Form3.lstPackage.Items.Clear()
            Form3.lstPackage.Items.Add("Package 2 :" & strData(1, 0))
            Form3.lstPackage.Items.Add("Activities included :" & strData(1, 1) & ", " & strData(1, 2))
            Form3.lstPackage.Items.Add("Price : ")
            Form3.lstPackage.Items.Add("Adult : " & Format(priceAdult, "RM#,##00.00"))
            Form3.lstPackage.Items.Add("Child : " & Format(priceChild, "RM#,##00.00"))
            Form3.lstPackage.Items.Add("Senior: " & Format(priceSenior, "RM#,##00.00"))

            Form3.lstAddOn.Items.Clear()
            If (cboAddOn.SelectedIndex = 1) Then
                priceAdd = 40
                Form3.lstAddOn.Items.Add("Add-on activity: " & strAdd(1, 0))
                Form3.lstAddOn.Items.Add("Price: " + Format(priceAdd, "RM#,##00.00"))
            ElseIf (cboAddOn.SelectedIndex = 2) Then
                priceAdd = 50
                Form3.lstAddOn.Items.Add("Add-on activity: " & strAdd(1, 1))
                Form3.lstAddOn.Items.Add("Price: " + Format(priceAdd, "RM#,##00.00"))
            ElseIf (cboAddOn.SelectedIndex = 3) Then
                priceAdd = 50
                Form3.lstAddOn.Items.Add("Add-on activity: " & strAdd(1, 2))
                Form3.lstAddOn.Items.Add("Price: " + Format(priceAdd, "RM#,##00.00"))
            ElseIf (cboAddOn.SelectedIndex = 4) Then
                priceAdd = 60
                Form3.lstAddOn.Items.Add("Add-on activity: " & strAdd(1, 3))
                Form3.lstAddOn.Items.Add("Price: " + Format(priceAdd, "RM#,##00.00"))
            Else
                Form3.lstAddOn.Items.Add("No add-on activity added.")
            End If
        ElseIf (cboPackage.SelectedIndex = 2) Then
            Form3.lstPackage.Items.Clear()
            Form3.lstPackage.Items.Add("Package 3 :" & strData(2, 0))
            Form3.lstPackage.Items.Add("Activities included :" & strData(2, 1) & ", " & strData(2, 2))
            Form3.lstPackage.Items.Add("Price : ")
            Form3.lstPackage.Items.Add("Adult : " & Format(priceAdult, "RM#,##00.00"))
            Form3.lstPackage.Items.Add("Child : " & Format(priceChild, "RM#,##00.00"))
            Form3.lstPackage.Items.Add("Senior: " & Format(priceSenior, "RM#,##00.00"))

            Form3.lstAddOn.Items.Clear()
            If (cboAddOn.SelectedIndex = 1) Then
                priceAdd = 70
                Form3.lstAddOn.Items.Add("Add-on activity: " & strAdd(2, 0))
                Form3.lstAddOn.Items.Add("Price: " + Format(priceAdd, "RM#,##00.00"))
            ElseIf (cboAddOn.SelectedIndex = 2) Then
                priceAdd = 30
                Form3.lstAddOn.Items.Add("Add-on activity: " & strAdd(2, 1))
                Form3.lstAddOn.Items.Add("Price: " + Format(priceAdd, "RM#,##00.00"))
            ElseIf (cboAddOn.SelectedIndex = 3) Then
                priceAdd = 50
                Form3.lstAddOn.Items.Add("Add-on activity: " & strAdd(2, 2))
                Form3.lstAddOn.Items.Add("Price: " + Format(priceAdd, "RM#,##00.00"))
            ElseIf (cboAddOn.SelectedIndex = 4) Then
                priceAdd = 50
                Form3.lstAddOn.Items.Add("Add-on activity: " & strAdd(2, 3))
                Form3.lstAddOn.Items.Add("Price: " + Format(priceAdd, "RM#,##00.00"))
            Else
                Form3.lstAddOn.Items.Add("No add-on activity added.")
            End If

        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Clock.Text = Format(Now, "Long Time")
    End Sub

    Private Sub cboAddOn_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAddOn.SelectedIndexChanged
        If cboPackage.SelectedIndex = 0 Then
            If cboAddOn.SelectedIndex = 0 Then
                picSnokerling.Visible = True
                picScuba.Visible = False
                picCoral.Visible = False
                picHiking.Visible = False
                picIsland.Visible = False
                pic1.Visible = True
                picKayaking.Visible = False

                lblAddDesc.Text = "No Add-on" & vbNewLine & "RM 0.00"
            ElseIf cboAddOn.SelectedIndex = 1 Then
                picSnokerling.Visible = True
                picScuba.Visible = False
                picCoral.Visible = False
                picHiking.Visible = False
                picIsland.Visible = False
                pic1.Visible = False
                picKayaking.Visible = False

                lblAddDesc.Text = "Snorkeling" & vbNewLine & "RM 40.00"
            ElseIf cboAddOn.SelectedIndex = 2 Then
                picSnokerling.Visible = False
                picScuba.Visible = True
                picCoral.Visible = False
                picHiking.Visible = False
                picIsland.Visible = False
                pic1.Visible = False
                picKayaking.Visible = False

                lblAddDesc.Text = "Scuba Diving" & vbNewLine & "RM 70.00"
            ElseIf cboAddOn.SelectedIndex = 3 Then
                picSnokerling.Visible = False
                picScuba.Visible = False
                picCoral.Visible = False
                picHiking.Visible = True
                picIsland.Visible = False
                pic1.Visible = False
                picKayaking.Visible = False

                lblAddDesc.Text = "Hiking" & vbNewLine & "RM 30.00"
            ElseIf cboAddOn.SelectedIndex = 4 Then
                picSnokerling.Visible = False
                picScuba.Visible = False
                picCoral.Visible = False
                picHiking.Visible = False
                picIsland.Visible = False
                pic1.Visible = False
                picKayaking.Visible = True

                lblAddDesc.Text = "Kayaking" & vbNewLine & "RM 50.00"
            End If
        ElseIf cboPackage.SelectedIndex = 1 Then
            If cboAddOn.SelectedIndex = 0 Then
                picSnokerling.Visible = True
                picScuba.Visible = False
                picCoral.Visible = False
                picHiking.Visible = False
                picIsland.Visible = False
                pic1.Visible = True
                picKayaking.Visible = False

                lblAddDesc.Text = "No Add-on" & vbNewLine & "RM 0.00"
            ElseIf cboAddOn.SelectedIndex = 1 Then
                picSnokerling.Visible = True
                picScuba.Visible = False
                picCoral.Visible = False
                picHiking.Visible = False
                picIsland.Visible = False
                pic1.Visible = False
                picKayaking.Visible = False

                lblAddDesc.Text = "Snorkeling" & vbNewLine & "RM 40.00"
            ElseIf cboAddOn.SelectedIndex = 2 Then
                picSnokerling.Visible = False
                picScuba.Visible = False
                picCoral.Visible = True
                picHiking.Visible = False
                picIsland.Visible = False
                pic1.Visible = False
                picKayaking.Visible = False

                lblAddDesc.Text = "Visiting Coral Island" & vbNewLine & "RM 50.00"
            ElseIf cboAddOn.SelectedIndex = 3 Then
                picSnokerling.Visible = False
                picScuba.Visible = False
                picCoral.Visible = False
                picHiking.Visible = False
                picIsland.Visible = False
                pic1.Visible = False
                picKayaking.Visible = True

                lblAddDesc.Text = "Kayaking" & vbNewLine & "RM 50.00"
            ElseIf cboAddOn.SelectedIndex = 4 Then
                picSnokerling.Visible = False
                picScuba.Visible = False
                picCoral.Visible = False
                picHiking.Visible = False
                picIsland.Visible = True
                pic1.Visible = False
                picKayaking.Visible = False

                lblAddDesc.Text = "Island Hopping" & vbNewLine & "RM 60.00"
            End If
        ElseIf cboPackage.SelectedIndex = 2 Then
            If cboAddOn.SelectedIndex = 0 Then
                picSnokerling.Visible = True
                picScuba.Visible = False
                picCoral.Visible = False
                picHiking.Visible = False
                picIsland.Visible = False
                pic1.Visible = True
                picKayaking.Visible = False

                lblAddDesc.Text = "No Add-on" & vbNewLine & "RM 0.00"
            ElseIf cboAddOn.SelectedIndex = 1 Then
                picSnokerling.Visible = False
                picScuba.Visible = True
                picCoral.Visible = False
                picHiking.Visible = False
                picIsland.Visible = False
                pic1.Visible = False
                picKayaking.Visible = False

                lblAddDesc.Text = "Scuba Diving" & vbNewLine & "RM 70.00"
            ElseIf cboAddOn.SelectedIndex = 2 Then
                picSnokerling.Visible = False
                picScuba.Visible = False
                picCoral.Visible = False
                picHiking.Visible = True
                picIsland.Visible = False
                pic1.Visible = False
                picKayaking.Visible = False

                lblAddDesc.Text = "Hiking" & vbNewLine & "RM 30.00"
            ElseIf cboAddOn.SelectedIndex = 3 Then
                picSnokerling.Visible = False
                picScuba.Visible = False
                picCoral.Visible = False
                picHiking.Visible = False
                picIsland.Visible = False
                pic1.Visible = False
                picKayaking.Visible = True

                lblAddDesc.Text = "Kayaking" & vbNewLine & "RM 50.00"
            ElseIf cboAddOn.SelectedIndex = 4 Then
                picSnokerling.Visible = False
                picScuba.Visible = False
                picCoral.Visible = True
                picHiking.Visible = False
                picIsland.Visible = False
                pic1.Visible = False
                picKayaking.Visible = False

                lblAddDesc.Text = "Visiting Coral Island" & vbNewLine & "RM 50.00"
            End If
        End If
    End Sub

    Private Sub LoginBtn_Click_1(sender As Object, e As EventArgs) Handles LoginBtn.Click
        Log_in.Show()
    End Sub
End Class