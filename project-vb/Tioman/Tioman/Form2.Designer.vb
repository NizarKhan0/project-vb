<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Title = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NightModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DayModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.cboPackage = New System.Windows.Forms.ComboBox()
        Me.lblPackage = New System.Windows.Forms.Label()
        Me.lblAdd = New System.Windows.Forms.Label()
        Me.lblDetail = New System.Windows.Forms.Label()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.registerBtn = New System.Windows.Forms.Label()
        Me.Clock = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cboAddOn = New System.Windows.Forms.ComboBox()
        Me.lblAddDesc = New System.Windows.Forms.Label()
        Me.LoginBtn = New System.Windows.Forms.Label()
        Me.Header = New System.Windows.Forms.PictureBox()
        Me.pic1 = New System.Windows.Forms.PictureBox()
        Me.picSnokerling = New System.Windows.Forms.PictureBox()
        Me.picScuba = New System.Windows.Forms.PictureBox()
        Me.picHiking = New System.Windows.Forms.PictureBox()
        Me.picCoral = New System.Windows.Forms.PictureBox()
        Me.picIsland = New System.Windows.Forms.PictureBox()
        Me.picKayaking = New System.Windows.Forms.PictureBox()
        Me.NightHeader = New System.Windows.Forms.PictureBox()
        Me.DisplayAd = New System.Windows.Forms.PictureBox()
        Me.DisplayAd3 = New System.Windows.Forms.PictureBox()
        Me.DisplayAd2 = New System.Windows.Forms.PictureBox()
        Me.DisplayAd1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.Header, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSnokerling, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picScuba, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHiking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCoral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picIsland, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picKayaking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NightHeader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DisplayAd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DisplayAd3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DisplayAd2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DisplayAd1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Title
        '
        Me.Title.AutoSize = True
        Me.Title.BackColor = System.Drawing.Color.Transparent
        Me.Title.Font = New System.Drawing.Font("Heart Warming", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Title.Location = New System.Drawing.Point(64, 149)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(945, 101)
        Me.Title.TabIndex = 0
        Me.Title.Text = "Travel to Tioman Island"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1125, 28)
        Me.MenuStrip1.TabIndex = 2
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NightModeToolStripMenuItem, Me.DayModeToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(46, 24)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NightModeToolStripMenuItem
        '
        Me.NightModeToolStripMenuItem.Name = "NightModeToolStripMenuItem"
        Me.NightModeToolStripMenuItem.Size = New System.Drawing.Size(172, 26)
        Me.NightModeToolStripMenuItem.Text = "Night Mode"
        '
        'DayModeToolStripMenuItem
        '
        Me.DayModeToolStripMenuItem.Name = "DayModeToolStripMenuItem"
        Me.DayModeToolStripMenuItem.Size = New System.Drawing.Size(172, 26)
        Me.DayModeToolStripMenuItem.Text = "Day Mode"
        Me.DayModeToolStripMenuItem.Visible = False
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(172, 26)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Font = New System.Drawing.Font("Montserrat Medium", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(29, 250)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(1028, 57)
        Me.lblDesc.TabIndex = 4
        Me.lblDesc.Text = resources.GetString("lblDesc.Text")
        '
        'cboPackage
        '
        Me.cboPackage.BackColor = System.Drawing.SystemColors.Window
        Me.cboPackage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cboPackage.FormattingEnabled = True
        Me.cboPackage.Location = New System.Drawing.Point(67, 367)
        Me.cboPackage.Name = "cboPackage"
        Me.cboPackage.Size = New System.Drawing.Size(225, 24)
        Me.cboPackage.TabIndex = 5
        Me.cboPackage.Text = "Please Select your Package :"
        '
        'lblPackage
        '
        Me.lblPackage.AutoSize = True
        Me.lblPackage.Location = New System.Drawing.Point(64, 341)
        Me.lblPackage.Name = "lblPackage"
        Me.lblPackage.Size = New System.Drawing.Size(63, 17)
        Me.lblPackage.TabIndex = 6
        Me.lblPackage.Text = "Package"
        '
        'lblAdd
        '
        Me.lblAdd.AutoSize = True
        Me.lblAdd.Location = New System.Drawing.Point(729, 348)
        Me.lblAdd.Name = "lblAdd"
        Me.lblAdd.Size = New System.Drawing.Size(112, 17)
        Me.lblAdd.TabIndex = 8
        Me.lblAdd.Text = "Add-on activities"
        '
        'lblDetail
        '
        Me.lblDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDetail.Font = New System.Drawing.Font("Montserrat SemiBold", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDetail.Location = New System.Drawing.Point(279, 411)
        Me.lblDetail.Name = "lblDetail"
        Me.lblDetail.Size = New System.Drawing.Size(422, 190)
        Me.lblDetail.TabIndex = 9
        Me.lblDetail.Text = "Please Select Your Package Above:"
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(1000, 652)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(113, 37)
        Me.btnNext.TabIndex = 11
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'registerBtn
        '
        Me.registerBtn.AutoSize = True
        Me.registerBtn.BackColor = System.Drawing.Color.White
        Me.registerBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.registerBtn.Location = New System.Drawing.Point(999, 4)
        Me.registerBtn.Name = "registerBtn"
        Me.registerBtn.Size = New System.Drawing.Size(125, 17)
        Me.registerBtn.TabIndex = 16
        Me.registerBtn.Text = "Staff Registeration"
        '
        'Clock
        '
        Me.Clock.AutoSize = True
        Me.Clock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Clock.Font = New System.Drawing.Font("Dubai", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clock.Location = New System.Drawing.Point(38, 646)
        Me.Clock.Name = "Clock"
        Me.Clock.Size = New System.Drawing.Size(60, 36)
        Me.Clock.TabIndex = 17
        Me.Clock.Text = "Clock"
        '
        'Timer1
        '
        '
        'cboAddOn
        '
        Me.cboAddOn.FormattingEnabled = True
        Me.cboAddOn.Location = New System.Drawing.Point(726, 372)
        Me.cboAddOn.Name = "cboAddOn"
        Me.cboAddOn.Size = New System.Drawing.Size(218, 24)
        Me.cboAddOn.TabIndex = 18
        Me.cboAddOn.Text = "Choose your add-on Activity"
        '
        'lblAddDesc
        '
        Me.lblAddDesc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAddDesc.Font = New System.Drawing.Font("Montserrat Light", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddDesc.Location = New System.Drawing.Point(726, 546)
        Me.lblAddDesc.Name = "lblAddDesc"
        Me.lblAddDesc.Size = New System.Drawing.Size(200, 55)
        Me.lblAddDesc.TabIndex = 20
        '
        'LoginBtn
        '
        Me.LoginBtn.AutoSize = True
        Me.LoginBtn.BackColor = System.Drawing.Color.White
        Me.LoginBtn.Location = New System.Drawing.Point(912, 4)
        Me.LoginBtn.Name = "LoginBtn"
        Me.LoginBtn.Size = New System.Drawing.Size(80, 17)
        Me.LoginBtn.TabIndex = 27
        Me.LoginBtn.Text = "Staff Log in"
        '
        'Header
        '
        Me.Header.Image = Global.Tioman.My.Resources.Resources.Block_B
        Me.Header.Location = New System.Drawing.Point(0, 27)
        Me.Header.Name = "Header"
        Me.Header.Size = New System.Drawing.Size(1125, 119)
        Me.Header.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Header.TabIndex = 3
        Me.Header.TabStop = False
        '
        'pic1
        '
        Me.pic1.Image = Global.Tioman.My.Resources.Resources._4d460b12ed70d1a8fc74d4830ff02cc6
        Me.pic1.Location = New System.Drawing.Point(726, 415)
        Me.pic1.Name = "pic1"
        Me.pic1.Size = New System.Drawing.Size(200, 128)
        Me.pic1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic1.TabIndex = 19
        Me.pic1.TabStop = False
        '
        'picSnokerling
        '
        Me.picSnokerling.Image = Global.Tioman.My.Resources.Resources.Tioman_Snorkeling_Tour
        Me.picSnokerling.Location = New System.Drawing.Point(726, 415)
        Me.picSnokerling.Name = "picSnokerling"
        Me.picSnokerling.Size = New System.Drawing.Size(200, 128)
        Me.picSnokerling.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSnokerling.TabIndex = 26
        Me.picSnokerling.TabStop = False
        '
        'picScuba
        '
        Me.picScuba.Image = Global.Tioman.My.Resources.Resources.diving
        Me.picScuba.Location = New System.Drawing.Point(726, 415)
        Me.picScuba.Name = "picScuba"
        Me.picScuba.Size = New System.Drawing.Size(200, 128)
        Me.picScuba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picScuba.TabIndex = 25
        Me.picScuba.TabStop = False
        '
        'picHiking
        '
        Me.picHiking.Image = Global.Tioman.My.Resources.Resources.Jungle_trekking_at_Tioman_Island
        Me.picHiking.Location = New System.Drawing.Point(726, 415)
        Me.picHiking.Name = "picHiking"
        Me.picHiking.Size = New System.Drawing.Size(200, 128)
        Me.picHiking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHiking.TabIndex = 24
        Me.picHiking.TabStop = False
        '
        'picCoral
        '
        Me.picCoral.Image = Global.Tioman.My.Resources.Resources.coral_island_pasir_panjang
        Me.picCoral.Location = New System.Drawing.Point(726, 415)
        Me.picCoral.Name = "picCoral"
        Me.picCoral.Size = New System.Drawing.Size(200, 128)
        Me.picCoral.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCoral.TabIndex = 23
        Me.picCoral.TabStop = False
        '
        'picIsland
        '
        Me.picIsland.Image = Global.Tioman.My.Resources.Resources.ccimage_shutterstock_346718522
        Me.picIsland.Location = New System.Drawing.Point(726, 415)
        Me.picIsland.Name = "picIsland"
        Me.picIsland.Size = New System.Drawing.Size(200, 128)
        Me.picIsland.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picIsland.TabIndex = 22
        Me.picIsland.TabStop = False
        '
        'picKayaking
        '
        Me.picKayaking.Image = Global.Tioman.My.Resources.Resources.kayaking_things_to_do_in_tioman_island1
        Me.picKayaking.Location = New System.Drawing.Point(726, 415)
        Me.picKayaking.Name = "picKayaking"
        Me.picKayaking.Size = New System.Drawing.Size(200, 128)
        Me.picKayaking.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picKayaking.TabIndex = 21
        Me.picKayaking.TabStop = False
        '
        'NightHeader
        '
        Me.NightHeader.Image = Global.Tioman.My.Resources.Resources._11_1
        Me.NightHeader.Location = New System.Drawing.Point(0, 27)
        Me.NightHeader.Name = "NightHeader"
        Me.NightHeader.Size = New System.Drawing.Size(1125, 119)
        Me.NightHeader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.NightHeader.TabIndex = 15
        Me.NightHeader.TabStop = False
        Me.NightHeader.Visible = False
        '
        'DisplayAd
        '
        Me.DisplayAd.Image = Global.Tioman.My.Resources.Resources._4d460b12ed70d1a8fc74d4830ff02cc6
        Me.DisplayAd.Location = New System.Drawing.Point(63, 411)
        Me.DisplayAd.Name = "DisplayAd"
        Me.DisplayAd.Size = New System.Drawing.Size(216, 190)
        Me.DisplayAd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DisplayAd.TabIndex = 14
        Me.DisplayAd.TabStop = False
        '
        'DisplayAd3
        '
        Me.DisplayAd3.Image = Global.Tioman.My.Resources.Resources.tioman
        Me.DisplayAd3.Location = New System.Drawing.Point(63, 411)
        Me.DisplayAd3.Name = "DisplayAd3"
        Me.DisplayAd3.Size = New System.Drawing.Size(216, 190)
        Me.DisplayAd3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DisplayAd3.TabIndex = 13
        Me.DisplayAd3.TabStop = False
        Me.DisplayAd3.Visible = False
        '
        'DisplayAd2
        '
        Me.DisplayAd2.Image = Global.Tioman.My.Resources.Resources.tioman_genting_highlands_tourism_bubble_on_hold_2
        Me.DisplayAd2.Location = New System.Drawing.Point(63, 411)
        Me.DisplayAd2.Name = "DisplayAd2"
        Me.DisplayAd2.Size = New System.Drawing.Size(216, 190)
        Me.DisplayAd2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DisplayAd2.TabIndex = 12
        Me.DisplayAd2.TabStop = False
        Me.DisplayAd2.Visible = False
        '
        'DisplayAd1
        '
        Me.DisplayAd1.Image = Global.Tioman.My.Resources.Resources.Coral_Island_Tioman_Malaysia_13
        Me.DisplayAd1.Location = New System.Drawing.Point(63, 411)
        Me.DisplayAd1.Name = "DisplayAd1"
        Me.DisplayAd1.Size = New System.Drawing.Size(216, 190)
        Me.DisplayAd1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.DisplayAd1.TabIndex = 10
        Me.DisplayAd1.TabStop = False
        Me.DisplayAd1.Visible = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCyan
        Me.ClientSize = New System.Drawing.Size(1125, 701)
        Me.Controls.Add(Me.LoginBtn)
        Me.Controls.Add(Me.Header)
        Me.Controls.Add(Me.pic1)
        Me.Controls.Add(Me.picSnokerling)
        Me.Controls.Add(Me.picScuba)
        Me.Controls.Add(Me.picHiking)
        Me.Controls.Add(Me.picCoral)
        Me.Controls.Add(Me.picIsland)
        Me.Controls.Add(Me.picKayaking)
        Me.Controls.Add(Me.lblAddDesc)
        Me.Controls.Add(Me.cboAddOn)
        Me.Controls.Add(Me.Clock)
        Me.Controls.Add(Me.registerBtn)
        Me.Controls.Add(Me.NightHeader)
        Me.Controls.Add(Me.DisplayAd)
        Me.Controls.Add(Me.DisplayAd3)
        Me.Controls.Add(Me.DisplayAd2)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.DisplayAd1)
        Me.Controls.Add(Me.lblDetail)
        Me.Controls.Add(Me.lblAdd)
        Me.Controls.Add(Me.lblPackage)
        Me.Controls.Add(Me.cboPackage)
        Me.Controls.Add(Me.lblDesc)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form2"
        Me.Text = "Main Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.Header, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSnokerling, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picScuba, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHiking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCoral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picIsland, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picKayaking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NightHeader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DisplayAd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DisplayAd3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DisplayAd2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DisplayAd1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Title As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Header As PictureBox
    Friend WithEvents lblDesc As Label
    Friend WithEvents cboPackage As ComboBox
    Friend WithEvents lblPackage As Label
    Friend WithEvents lblAdd As Label
    Friend WithEvents lblDetail As Label
    Friend WithEvents DisplayAd1 As PictureBox
    Friend WithEvents NightModeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnNext As Button
    Friend WithEvents DisplayAd2 As PictureBox
    Friend WithEvents DisplayAd3 As PictureBox
    Friend WithEvents DisplayAd As PictureBox
    Friend WithEvents NightHeader As PictureBox
    Friend WithEvents DayModeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents registerBtn As Label
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Clock As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents cboAddOn As ComboBox
    Friend WithEvents pic1 As PictureBox
    Friend WithEvents lblAddDesc As Label
    Friend WithEvents picKayaking As PictureBox
    Friend WithEvents picIsland As PictureBox
    Friend WithEvents picCoral As PictureBox
    Friend WithEvents picHiking As PictureBox
    Friend WithEvents picScuba As PictureBox
    Friend WithEvents picSnokerling As PictureBox
    Friend WithEvents LoginBtn As Label
End Class
