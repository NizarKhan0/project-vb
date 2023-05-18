<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lblGreetings = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CustomerFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.lstReport = New System.Windows.Forms.ListBox()
        Me.btnLogOut = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(178, 492)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(124, 39)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Booking Report"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(48, 492)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(124, 39)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Customer Info"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'lblGreetings
        '
        Me.lblGreetings.AutoSize = True
        Me.lblGreetings.Font = New System.Drawing.Font("Montserrat Medium", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGreetings.Location = New System.Drawing.Point(45, 36)
        Me.lblGreetings.Name = "lblGreetings"
        Me.lblGreetings.Size = New System.Drawing.Size(235, 19)
        Me.lblGreetings.TabIndex = 3
        Me.lblGreetings.Text = "-Welcome to the Report Page-"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat Medium", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 71)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(224, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Please choose your directory."
        '
        'CustomerFileDialog
        '
        Me.CustomerFileDialog.FileName = "OpenFileDialog1"
        '
        'lstReport
        '
        Me.lstReport.FormattingEnabled = True
        Me.lstReport.HorizontalScrollbar = True
        Me.lstReport.ItemHeight = 16
        Me.lstReport.Location = New System.Drawing.Point(48, 107)
        Me.lstReport.Name = "lstReport"
        Me.lstReport.Size = New System.Drawing.Size(442, 372)
        Me.lstReport.TabIndex = 5
        '
        'btnLogOut
        '
        Me.btnLogOut.AutoSize = True
        Me.btnLogOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogOut.Location = New System.Drawing.Point(608, -2)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(61, 19)
        Me.btnLogOut.TabIndex = 6
        Me.btnLogOut.Text = "Log Out"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(670, 577)
        Me.Controls.Add(Me.btnLogOut)
        Me.Controls.Add(Me.lstReport)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblGreetings)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Name = "Form5"
        Me.Text = "Booking Report"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents lblGreetings As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CustomerFileDialog As OpenFileDialog
    Friend WithEvents lstReport As ListBox
    Friend WithEvents btnLogOut As Label
End Class
