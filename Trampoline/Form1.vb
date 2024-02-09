Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim partyDetails As partyDetails
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) 

        partyDetails.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If custName.Text = "" Then
            MessageBox.Show("Please fill in your name ")
            Return
        End If
        If custAdress.Text = "" Then
            MessageBox.Show("Please fill in your Address ")
            Return
        End If
        If custPostcode.Text = "" Then
            MessageBox.Show("Please fill in your Postcode ")
            Return
        End If
        If custPhone.Text = "" Then
            MessageBox.Show("Please fill in your Phone number ")
            Return
        Else
            partyDetails.Show()
        End If
    End Sub
End Class
