<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.bookDate = New System.Windows.Forms.DateTimePicker()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.txtContact = New System.Windows.Forms.TextBox()
        Me.txtIC = New System.Windows.Forms.TextBox()
        Me.lblIC = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblPackage = New System.Windows.Forms.Label()
        Me.lblAdd = New System.Windows.Forms.Label()
        Me.lblAdult = New System.Windows.Forms.Label()
        Me.cboAdult = New System.Windows.Forms.ComboBox()
        Me.cboChild = New System.Windows.Forms.ComboBox()
        Me.cboSenior = New System.Windows.Forms.ComboBox()
        Me.lblSenior = New System.Windows.Forms.Label()
        Me.lblChild = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.btnProceed = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BackToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstPackage = New System.Windows.Forms.ListBox()
        Me.lstAddOn = New System.Windows.Forms.ListBox()
        Me.lblAddOn = New System.Windows.Forms.Label()
        Me.txtAdd = New System.Windows.Forms.TextBox()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.Font = New System.Drawing.Font("Kano regular", 28.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.Location = New System.Drawing.Point(43, 47)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(463, 48)
        Me.Title.TabIndex = 1
        Me.Title.Text = "Booking Confirmation"
        '
        'bookDate
        '
        Me.bookDate.Location = New System.Drawing.Point(410, 576)
        Me.bookDate.Name = "bookDate"
        Me.bookDate.Size = New System.Drawing.Size(200, 22)
        Me.bookDate.TabIndex = 2
        Me.bookDate.Value = New Date(2022, 1, 22, 0, 0, 0, 0)
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(48, 127)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(53, 17)
        Me.lblName.TabIndex = 3
        Me.lblName.Text = "Name :"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(51, 147)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(418, 22)
        Me.txtName.TabIndex = 4
        '
        'lblContact
        '
        Me.lblContact.AutoSize = True
        Me.lblContact.Location = New System.Drawing.Point(533, 128)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(111, 17)
        Me.lblContact.TabIndex = 5
        Me.lblContact.Text = "Phone Number :"
        '
        'txtContact
        '
        Me.txtContact.Location = New System.Drawing.Point(536, 147)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(174, 22)
        Me.txtContact.TabIndex = 6
        '
        'txtIC
        '
        Me.txtIC.Location = New System.Drawing.Point(51, 210)
        Me.txtIC.Name = "txtIC"
        Me.txtIC.Size = New System.Drawing.Size(184, 22)
        Me.txtIC.TabIndex = 7
        '
        'lblIC
        '
        Me.lblIC.AutoSize = True
        Me.lblIC.Location = New System.Drawing.Point(51, 187)
        Me.lblIC.Name = "lblIC"
        Me.lblIC.Size = New System.Drawing.Size(82, 17)
        Me.lblIC.TabIndex = 8
        Me.lblIC.Text = "IC Number :"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(298, 187)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(106, 17)
        Me.lblEmail.TabIndex = 9
        Me.lblEmail.Text = "Email Address :"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(301, 209)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(194, 22)
        Me.txtEmail.TabIndex = 10
        '
        'lblPackage
        '
        Me.lblPackage.AutoSize = True
        Me.lblPackage.Location = New System.Drawing.Point(51, 268)
        Me.lblPackage.Name = "lblPackage"
        Me.lblPackage.Size = New System.Drawing.Size(71, 17)
        Me.lblPackage.TabIndex = 11
        Me.lblPackage.Text = "Package :"
        '
        'lblAdd
        '
        Me.lblAdd.AutoSize = True
        Me.lblAdd.Location = New System.Drawing.Point(51, 434)
        Me.lblAdd.Name = "lblAdd"
        Me.lblAdd.Size = New System.Drawing.Size(69, 17)
        Me.lblAdd.TabIndex = 13
        Me.lblAdd.Text = "Add-ons :"
        '
        'lblAdult
        '
        Me.lblAdult.Location = New System.Drawing.Point(57, 551)
        Me.lblAdult.Name = "lblAdult"
        Me.lblAdult.Size = New System.Drawing.Size(100, 23)
        Me.lblAdult.TabIndex = 15
        Me.lblAdult.Text = "Adult"
        '
        'cboAdult
        '
        Me.cboAdult.FormattingEnabled = True
        Me.cboAdult.Location = New System.Drawing.Point(54, 578)
        Me.cboAdult.Name = "cboAdult"
        Me.cboAdult.Size = New System.Drawing.Size(121, 24)
        Me.cboAdult.TabIndex = 16
        '
        'cboChild
        '
        Me.cboChild.FormattingEnabled = True
        Me.cboChild.Location = New System.Drawing.Point(54, 640)
        Me.cboChild.Name = "cboChild"
        Me.cboChild.Size = New System.Drawing.Size(121, 24)
        Me.cboChild.TabIndex = 17
        '
        'cboSenior
        '
        Me.cboSenior.FormattingEnabled = True
        Me.cboSenior.Location = New System.Drawing.Point(210, 574)
        Me.cboSenior.Name = "cboSenior"
        Me.cboSenior.Size = New System.Drawing.Size(121, 24)
        Me.cboSenior.TabIndex = 18
        '
        'lblSenior
        '
        Me.lblSenior.Location = New System.Drawing.Point(213, 550)
        Me.lblSenior.Name = "lblSenior"
        Me.lblSenior.Size = New System.Drawing.Size(100, 23)
        Me.lblSenior.TabIndex = 19
        Me.lblSenior.Text = "Senior"
        '
        'lblChild
        '
        Me.lblChild.Location = New System.Drawing.Point(56, 616)
        Me.lblChild.Name = "lblChild"
        Me.lblChild.Size = New System.Drawing.Size(100, 23)
        Me.lblChild.TabIndex = 20
        Me.lblChild.Text = "Child"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(410, 552)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(93, 17)
        Me.lblDate.TabIndex = 21
        Me.lblDate.Text = "Booking Date"
        '
        'btnProceed
        '
        Me.btnProceed.Location = New System.Drawing.Point(684, 651)
        Me.btnProceed.Name = "btnProceed"
        Me.btnProceed.Size = New System.Drawing.Size(119, 38)
        Me.btnProceed.TabIndex = 22
        Me.btnProceed.Text = "Proceed"
        Me.btnProceed.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(815, 28)
        Me.MenuStrip1.TabIndex = 23
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BackToolStripMenuItem
        '
        Me.BackToolStripMenuItem.Name = "BackToolStripMenuItem"
        Me.BackToolStripMenuItem.Size = New System.Drawing.Size(54, 24)
        Me.BackToolStripMenuItem.Text = "Back"
        '
        'lstPackage
        '
        Me.lstPackage.FormattingEnabled = True
        Me.lstPackage.ItemHeight = 16
        Me.lstPackage.Location = New System.Drawing.Point(51, 288)
        Me.lstPackage.Name = "lstPackage"
        Me.lstPackage.Size = New System.Drawing.Size(421, 132)
        Me.lstPackage.TabIndex = 24
        '
        'lstAddOn
        '
        Me.lstAddOn.FormattingEnabled = True
        Me.lstAddOn.ItemHeight = 16
        Me.lstAddOn.Location = New System.Drawing.Point(55, 455)
        Me.lstAddOn.Name = "lstAddOn"
        Me.lstAddOn.Size = New System.Drawing.Size(417, 68)
        Me.lstAddOn.TabIndex = 25
        '
        'lblAddOn
        '
        Me.lblAddOn.AutoSize = True
        Me.lblAddOn.Location = New System.Drawing.Point(213, 616)
        Me.lblAddOn.Name = "lblAddOn"
        Me.lblAddOn.Size = New System.Drawing.Size(49, 17)
        Me.lblAddOn.TabIndex = 26
        Me.lblAddOn.Text = "Added"
        '
        'txtAdd
        '
        Me.txtAdd.Location = New System.Drawing.Point(210, 640)
        Me.txtAdd.Name = "txtAdd"
        Me.txtAdd.Size = New System.Drawing.Size(100, 22)
        Me.txtAdd.TabIndex = 27
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(815, 701)
        Me.Controls.Add(Me.txtAdd)
        Me.Controls.Add(Me.lblAddOn)
        Me.Controls.Add(Me.lstAddOn)
        Me.Controls.Add(Me.lstPackage)
        Me.Controls.Add(Me.btnProceed)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblChild)
        Me.Controls.Add(Me.lblSenior)
        Me.Controls.Add(Me.cboSenior)
        Me.Controls.Add(Me.cboChild)
        Me.Controls.Add(Me.cboAdult)
        Me.Controls.Add(Me.lblAdult)
        Me.Controls.Add(Me.lblAdd)
        Me.Controls.Add(Me.lblPackage)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblIC)
        Me.Controls.Add(Me.txtIC)
        Me.Controls.Add(Me.txtContact)
        Me.Controls.Add(Me.lblContact)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.bookDate)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form3"
        Me.Text = "Booking Confirmation"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Title As Label
    Friend WithEvents bookDate As DateTimePicker
    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblContact As Label
    Friend WithEvents txtContact As TextBox
    Friend WithEvents txtIC As TextBox
    Friend WithEvents lblIC As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblPackage As Label
    Friend WithEvents lblAdd As Label
    Friend WithEvents lblAdult As Label
    Friend WithEvents cboAdult As ComboBox
    Friend WithEvents cboChild As ComboBox
    Friend WithEvents cboSenior As ComboBox
    Friend WithEvents lblSenior As Label
    Friend WithEvents lblChild As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents btnProceed As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BackToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lstPackage As ListBox
    Friend WithEvents lstAddOn As ListBox
    Friend WithEvents lblAddOn As Label
    Friend WithEvents txtAdd As TextBox
End Class
