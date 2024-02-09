<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.custName = New System.Windows.Forms.TextBox()
        Me.custAdress = New System.Windows.Forms.TextBox()
        Me.custPostcode = New System.Windows.Forms.TextBox()
        Me.custPhone = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'custName
        '
        Me.custName.Location = New System.Drawing.Point(181, 86)
        Me.custName.Name = "custName"
        Me.custName.Size = New System.Drawing.Size(100, 23)
        Me.custName.TabIndex = 0
        '
        'custAdress
        '
        Me.custAdress.Location = New System.Drawing.Point(181, 125)
        Me.custAdress.Name = "custAdress"
        Me.custAdress.Size = New System.Drawing.Size(100, 23)
        Me.custAdress.TabIndex = 1
        '
        'custPostcode
        '
        Me.custPostcode.Location = New System.Drawing.Point(181, 170)
        Me.custPostcode.Name = "custPostcode"
        Me.custPostcode.Size = New System.Drawing.Size(100, 23)
        Me.custPostcode.TabIndex = 2
        '
        'custPhone
        '
        Me.custPhone.Location = New System.Drawing.Point(181, 215)
        Me.custPhone.Name = "custPhone"
        Me.custPhone.Size = New System.Drawing.Size(100, 23)
        Me.custPhone.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(117, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Name "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(117, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(117, 173)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Postcode"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(85, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Phone Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(25, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(343, 32)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Welcome to Trampoline Park"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(190, 257)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Continue "
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 314)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.custPhone)
        Me.Controls.Add(Me.custPostcode)
        Me.Controls.Add(Me.custAdress)
        Me.Controls.Add(Me.custName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents custName As TextBox
    Friend WithEvents custAdress As TextBox
    Friend WithEvents custPostcode As TextBox
    Friend WithEvents custPhone As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button2 As Button
End Class
