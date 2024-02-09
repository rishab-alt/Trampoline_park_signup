Public Class partyDetails
    Dim adminCost = 10
    Dim heliumBalloon = 50
    Dim partyBag = 3
    Dim socks_1 = 2.5
    Dim banner = 5
    Dim bannerLetters = 1
    Dim cakeSmall = 5
    Dim cakeMed = 20
    Dim cakeLarge = 35
    Dim customCake As Integer
    Dim partyDiscount As Integer
    Dim balloon_max = 250

    Private Sub partyDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        numberPeople.Items.Add("1")
        numberPeople.Items.Add("2")
        numberPeople.Items.Add("3")
        numberPeople.Items.Add("4")
        numberPeople.Items.Add("5")
        numberPeople.Items.Add("6")

        HaveSocks.Items.Add("Yes")
        HaveSocks.Items.Add("No")

        cakerequired.Items.Add("Small")
        cakerequired.Items.Add("Medium")
        cakerequired.Items.Add("Large ")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Balloonchoice.Text > balloon_max Then
            MessageBox.Show("Maximum Balloons Reached, Sorry!")
        Else
            If HaveSocks.Text = "Yes" Then
                result.Text = "Number of people is " & numberPeople.Text & vbCrLf &
                      "Has socks: Yes" & vbCrLf &
                      "Admin fee is: " & adminCost & vbCrLf &
                      "Number of balloons is: " & Balloonchoice.Text
            Else
                MessageBox.Show("Invalid")
            End If
        End If
        If cakerequired.SelectedItem IsNot Nothing Then
            If cakerequired.SelectedItem = "Small" Then
                MessageBox.Show("Cake price is " & cakeSmall)
                result.Text = "Number of people: " & numberPeople.Text & vbCrLf &
                              "Has socks: Yes" & vbCrLf &
                              "Admin fee is: " & adminCost & vbCrLf &
                              "Number of balloons: " & Balloonchoice.Text & vbCrLf &
                              "Cake choice is: Small"
            ElseIf cakerequired.SelectedItem = "Medium" Then
                MessageBox.Show("Cake price is " & cakeMed)
                result.Text = "Number of people: " & numberPeople.Text & vbCrLf &
                              "Has socks: Yes" & vbCrLf &
                              "Admin fee is: " & adminCost & vbCrLf &
                              "Number of balloons: " & Balloonchoice.Text & vbCrLf &
                              "Cake choice is: Medium"
            ElseIf cakerequired.SelectedItem = "Large" Then
                MessageBox.Show("Cake price is " & cakeLarge)
                result.Text = "Number of people: " & numberPeople.Text & vbCrLf &
                              "Has socks: Yes" & vbCrLf &
                              "Admin fee is: " & adminCost & vbCrLf &
                              "Number of balloons: " & Balloonchoice.Text & vbCrLf &
                              "Cake choice is: Large"
            Else
                MessageBox.Show("Error: Selected cake size not recognized.")
            End If
        Else
            MessageBox.Show("Error: No cake size selected.")
        End If
    End Sub
End Class