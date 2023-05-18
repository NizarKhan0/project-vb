<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Receipt
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
        Me.Title = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.outName = New System.Windows.Forms.Label()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.PhoneNumber = New System.Windows.Forms.Label()
        Me.lblIC = New System.Windows.Forms.Label()
        Me.IC = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Email = New System.Windows.Forms.Label()
        Me.lblPackage = New System.Windows.Forms.Label()
        Me.lblAddOn = New System.Windows.Forms.Label()
        Me.lblAdult = New System.Windows.Forms.Label()
        Me.lblChild = New System.Windows.Forms.Label()
        Me.lblSenior = New System.Windows.Forms.Label()
        Me.lblAddOnNum = New System.Windows.Forms.Label()
        Me.lblAddPrice = New System.Windows.Forms.Label()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Package = New System.Windows.Forms.Label()
        Me.AddOn = New System.Windows.Forms.Label()
        Me.DateBook = New System.Windows.Forms.Label()
        Me.Adult = New System.Windows.Forms.Label()
        Me.Child = New System.Windows.Forms.Label()
        Me.Senior = New System.Windows.Forms.Label()
        Me.Add = New System.Windows.Forms.Label()
        Me.AddPrice = New System.Windows.Forms.Label()
        Me.btnHome = New System.Windows.Forms.Button()
        Me.Total = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Kano regular", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.Location = New System.Drawing.Point(141, 37)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(238, 33)
        Me.Title.TabIndex = 0
        Me.Title.Text = "Booking Receipt"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(29, 109)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(57, 17)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name : "
        '
        'outName
        '
        Me.outName.AutoSize = True
        Me.outName.Location = New System.Drawing.Point(174, 109)
        Me.outName.Name = "outName"
        Me.outName.Size = New System.Drawing.Size(55, 17)
        Me.outName.TabIndex = 2
        Me.outName.Text = "(Name)"
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Location = New System.Drawing.Point(29, 136)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(115, 17)
        Me.lblPhoneNumber.TabIndex = 3
        Me.lblPhoneNumber.Text = "Phone Number : "
        '
        'PhoneNumber
        '
        Me.PhoneNumber.AutoSize = True
        Me.PhoneNumber.Location = New System.Drawing.Point(174, 136)
        Me.PhoneNumber.Name = "PhoneNumber"
        Me.PhoneNumber.Size = New System.Drawing.Size(113, 17)
        Me.PhoneNumber.TabIndex = 4
        Me.PhoneNumber.Text = "(Phone Number)"
        '
        'lblIC
        '
        Me.lblIC.AutoSize = True
        Me.lblIC.Location = New System.Drawing.Point(29, 163)
        Me.lblIC.Name = "lblIC"
        Me.lblIC.Size = New System.Drawing.Size(82, 17)
        Me.lblIC.TabIndex = 5
        Me.lblIC.Text = "IC Number :"
        '
        'IC
        '
        Me.IC.AutoSize = True
        Me.IC.Location = New System.Drawing.Point(174, 163)
        Me.IC.Name = "IC"
        Me.IC.Size = New System.Drawing.Size(84, 17)
        Me.IC.TabIndex = 6
        Me.IC.Text = "(IC Number)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 190)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(106, 17)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Email Address :"
        '
        'Email
        '
        Me.Email.AutoSize = True
        Me.Email.Location = New System.Drawing.Point(174, 190)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(52, 17)
        Me.Email.TabIndex = 8
        Me.Email.Text = "(Email)"
        '
        'lblPackage
        '
        Me.lblPackage.AutoSize = True
        Me.lblPackage.Location = New System.Drawing.Point(29, 217)
        Me.lblPackage.Name = "lblPackage"
        Me.lblPackage.Size = New System.Drawing.Size(71, 17)
        Me.lblPackage.TabIndex = 9
        Me.lblPackage.Text = "Package :"
        '
        'lblAddOn
        '
        Me.lblAddOn.AutoSize = True
        Me.lblAddOn.Location = New System.Drawing.Point(29, 246)
        Me.lblAddOn.Name = "lblAddOn"
        Me.lblAddOn.Size = New System.Drawing.Size(69, 17)
        Me.lblAddOn.TabIndex = 10
        Me.lblAddOn.Text = "Add-On : "
        '
        'lblAdult
        '
        Me.lblAdult.AutoSize = True
        Me.lblAdult.Location = New System.Drawing.Point(29, 301)
        Me.lblAdult.Name = "lblAdult"
        Me.lblAdult.Size = New System.Drawing.Size(122, 17)
        Me.lblAdult.TabIndex = 11
        Me.lblAdult.Text = "Number of Adult : "
        '
        'lblChild
        '
        Me.lblChild.AutoSize = True
        Me.lblChild.Location = New System.Drawing.Point(29, 328)
        Me.lblChild.Name = "lblChild"
        Me.lblChild.Size = New System.Drawing.Size(142, 17)
        Me.lblChild.TabIndex = 12
        Me.lblChild.Text = "Number of Children : "
        '
        'lblSenior
        '
        Me.lblSenior.AutoSize = True
        Me.lblSenior.Location = New System.Drawing.Point(29, 356)
        Me.lblSenior.Name = "lblSenior"
        Me.lblSenior.Size = New System.Drawing.Size(131, 17)
        Me.lblSenior.TabIndex = 13
        Me.lblSenior.Text = "Number of Senior : "
        '
        'lblAddOnNum
        '
        Me.lblAddOnNum.AutoSize = True
        Me.lblAddOnNum.Location = New System.Drawing.Point(29, 382)
        Me.lblAddOnNum.Name = "lblAddOnNum"
        Me.lblAddOnNum.Size = New System.Drawing.Size(109, 17)
        Me.lblAddOnNum.TabIndex = 14
        Me.lblAddOnNum.Text = "Add-On added :"
        '
        'lblAddPrice
        '
        Me.lblAddPrice.AutoSize = True
        Me.lblAddPrice.Location = New System.Drawing.Point(29, 408)
        Me.lblAddPrice.Name = "lblAddPrice"
        Me.lblAddPrice.Size = New System.Drawing.Size(98, 17)
        Me.lblAddPrice.TabIndex = 15
        Me.lblAddPrice.Text = "Add-on Price :"
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(144, 505)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(221, 17)
        Me.lblMessage.TabIndex = 16
        Me.lblMessage.Text = "Have a Nice Trip In Tioman Island"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(29, 274)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(101, 17)
        Me.lblDate.TabIndex = 17
        Me.lblDate.Text = "Booking Date :"
        '
        'Package
        '
        Me.Package.AutoSize = True
        Me.Package.Location = New System.Drawing.Point(174, 217)
        Me.Package.Name = "Package"
        Me.Package.Size = New System.Drawing.Size(73, 17)
        Me.Package.TabIndex = 18
        Me.Package.Text = "(Package)"
        '
        'AddOn
        '
        Me.AddOn.AutoSize = True
        Me.AddOn.Location = New System.Drawing.Point(174, 246)
        Me.AddOn.Name = "AddOn"
        Me.AddOn.Size = New System.Drawing.Size(67, 17)
        Me.AddOn.TabIndex = 19
        Me.AddOn.Text = "(Add-On)"
        '
        'DateBook
        '
        Me.DateBook.AutoSize = True
        Me.DateBook.Location = New System.Drawing.Point(174, 274)
        Me.DateBook.Name = "DateBook"
        Me.DateBook.Size = New System.Drawing.Size(48, 17)
        Me.DateBook.TabIndex = 20
        Me.DateBook.Text = "(Date)"
        '
        'Adult
        '
        Me.Adult.AutoSize = True
        Me.Adult.Location = New System.Drawing.Point(174, 301)
        Me.Adult.Name = "Adult"
        Me.Adult.Size = New System.Drawing.Size(50, 17)
        Me.Adult.TabIndex = 21
        Me.Adult.Text = "(Adult)"
        '
        'Child
        '
        Me.Child.AutoSize = True
        Me.Child.Location = New System.Drawing.Point(174, 328)
        Me.Child.Name = "Child"
        Me.Child.Size = New System.Drawing.Size(49, 17)
        Me.Child.TabIndex = 22
        Me.Child.Text = "(Child)"
        '
        'Senior
        '
        Me.Senior.AutoSize = True
        Me.Senior.Location = New System.Drawing.Point(174, 356)
        Me.Senior.Name = "Senior"
        Me.Senior.Size = New System.Drawing.Size(59, 17)
        Me.Senior.TabIndex = 23
        Me.Senior.Text = "(Senior)"
        '
        'Add
        '
        Me.Add.AutoSize = True
        Me.Add.Location = New System.Drawing.Point(174, 382)
        Me.Add.Name = "Add"
        Me.Add.Size = New System.Drawing.Size(43, 17)
        Me.Add.TabIndex = 24
        Me.Add.Text = "(Add)"
        '
        'AddPrice
        '
        Me.AddPrice.AutoSize = True
        Me.AddPrice.Location = New System.Drawing.Point(174, 408)
        Me.AddPrice.Name = "AddPrice"
        Me.AddPrice.Size = New System.Drawing.Size(50, 17)
        Me.AddPrice.TabIndex = 25
        Me.AddPrice.Text = "(Total)"
        '
        'btnHome
        '
        Me.btnHome.Location = New System.Drawing.Point(443, 518)
        Me.btnHome.Name = "btnHome"
        Me.btnHome.Size = New System.Drawing.Size(103, 34)
        Me.btnHome.TabIndex = 26
        Me.btnHome.Text = "Home"
        Me.btnHome.UseVisualStyleBackColor = True
        '
        'Total
        '
        Me.Total.AutoSize = True
        Me.Total.Location = New System.Drawing.Point(174, 434)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(50, 17)
        Me.Total.TabIndex = 28
        Me.Total.Text = "(Total)"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(29, 434)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(52, 17)
        Me.lblTotal.TabIndex = 27
        Me.lblTotal.Text = "Total : "
        '
        'Receipt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 564)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnHome)
        Me.Controls.Add(Me.AddPrice)
        Me.Controls.Add(Me.Add)
        Me.Controls.Add(Me.Senior)
        Me.Controls.Add(Me.Child)
        Me.Controls.Add(Me.Adult)
        Me.Controls.Add(Me.DateBook)
        Me.Controls.Add(Me.AddOn)
        Me.Controls.Add(Me.Package)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.lblAddPrice)
        Me.Controls.Add(Me.lblAddOnNum)
        Me.Controls.Add(Me.lblSenior)
        Me.Controls.Add(Me.lblChild)
        Me.Controls.Add(Me.lblAdult)
        Me.Controls.Add(Me.lblAddOn)
        Me.Controls.Add(Me.lblPackage)
        Me.Controls.Add(Me.Email)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.IC)
        Me.Controls.Add(Me.lblIC)
        Me.Controls.Add(Me.PhoneNumber)
        Me.Controls.Add(Me.lblPhoneNumber)
        Me.Controls.Add(Me.outName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.Title)
        Me.Name = "Receipt"
        Me.Text = "Receipt"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Title As Label
    Friend WithEvents lblName As Label
    Friend WithEvents outName As Label
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents PhoneNumber As Label
    Friend WithEvents lblIC As Label
    Friend WithEvents IC As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Email As Label
    Friend WithEvents lblPackage As Label
    Friend WithEvents lblAddOn As Label
    Friend WithEvents lblAdult As Label
    Friend WithEvents lblChild As Label
    Friend WithEvents lblSenior As Label
    Friend WithEvents lblAddOnNum As Label
    Friend WithEvents lblAddPrice As Label
    Friend WithEvents lblMessage As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents Package As Label
    Friend WithEvents AddOn As Label
    Friend WithEvents DateBook As Label
    Friend WithEvents Adult As Label
    Friend WithEvents Child As Label
    Friend WithEvents Senior As Label
    Friend WithEvents Add As Label
    Friend WithEvents AddPrice As Label
    Friend WithEvents btnHome As Button
    Friend WithEvents Total As Label
    Friend WithEvents lblTotal As Label
End Class
