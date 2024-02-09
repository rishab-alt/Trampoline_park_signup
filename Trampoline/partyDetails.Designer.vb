<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class partyDetails
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.numberPeople = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.HaveSocks = New System.Windows.Forms.ComboBox()
        Me.helBalloon = New System.Windows.Forms.Label()
        Me.HatBanner = New System.Windows.Forms.TextBox()
        Me.Balloonchoice = New System.Windows.Forms.TextBox()
        Me.cakerequired = New System.Windows.Forms.ComboBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.result = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(151, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(343, 32)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Welcome to Trampoline Park"
        '
        'numberPeople
        '
        Me.numberPeople.FormattingEnabled = True
        Me.numberPeople.Location = New System.Drawing.Point(186, 51)
        Me.numberPeople.Name = "numberPeople"
        Me.numberPeople.Size = New System.Drawing.Size(121, 23)
        Me.numberPeople.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(76, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 15)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Number of people"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(90, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 15)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Brought socks? "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 15)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Custom hat + banner?"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(95, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 15)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Cake required?"
        '
        'HaveSocks
        '
        Me.HaveSocks.FormattingEnabled = True
        Me.HaveSocks.Location = New System.Drawing.Point(186, 80)
        Me.HaveSocks.Name = "HaveSocks"
        Me.HaveSocks.Size = New System.Drawing.Size(121, 23)
        Me.HaveSocks.TabIndex = 16
        '
        'helBalloon
        '
        Me.helBalloon.AutoSize = True
        Me.helBalloon.Location = New System.Drawing.Point(123, 139)
        Me.helBalloon.Name = "helBalloon"
        Me.helBalloon.Size = New System.Drawing.Size(57, 15)
        Me.helBalloon.TabIndex = 19
        Me.helBalloon.Text = "Balloons?"
        '
        'HatBanner
        '
        Me.HatBanner.Location = New System.Drawing.Point(186, 109)
        Me.HatBanner.Name = "HatBanner"
        Me.HatBanner.Size = New System.Drawing.Size(121, 23)
        Me.HatBanner.TabIndex = 21
        '
        'Balloonchoice
        '
        Me.Balloonchoice.Location = New System.Drawing.Point(186, 138)
        Me.Balloonchoice.Name = "Balloonchoice"
        Me.Balloonchoice.PlaceholderText = "Max 250"
        Me.Balloonchoice.Size = New System.Drawing.Size(121, 23)
        Me.Balloonchoice.TabIndex = 22
        '
        'cakerequired
        '
        Me.cakerequired.FormattingEnabled = True
        Me.cakerequired.Location = New System.Drawing.Point(186, 168)
        Me.cakerequired.Name = "cakerequired"
        Me.cakerequired.Size = New System.Drawing.Size(121, 23)
        Me.cakerequired.TabIndex = 23
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(204, 207)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 24
        Me.Button2.Text = "Continue "
        Me.Button2.UseVisualStyleBackColor = True
        '
        'result
        '
        Me.result.AutoSize = True
        Me.result.Location = New System.Drawing.Point(370, 80)
        Me.result.Name = "result"
        Me.result.Size = New System.Drawing.Size(102, 15)
        Me.result.TabIndex = 25
        Me.result.Text = "Result Shows here"
        '
        'partyDetails
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 291)
        Me.Controls.Add(Me.result)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.cakerequired)
        Me.Controls.Add(Me.Balloonchoice)
        Me.Controls.Add(Me.HatBanner)
        Me.Controls.Add(Me.helBalloon)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.HaveSocks)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.numberPeople)
        Me.Controls.Add(Me.Label5)
        Me.Name = "partyDetails"
        Me.Text = "partyDetails"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents numberPeople As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents HaveSocks As ComboBox
    Friend WithEvents helBalloon As Label
    Friend WithEvents HatBanner As TextBox
    Friend WithEvents Balloonchoice As TextBox
    Friend WithEvents cakerequired As ComboBox
    Friend WithEvents Button2 As Button
    Friend WithEvents result As Label
End Class
