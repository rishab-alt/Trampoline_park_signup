Imports System.IO

Public Class PartyDetails
    Dim adminCost = 10
    Dim heliumBalloon = 50
    Dim partyBag = 3
    Dim socks_1 = 2.5
    Dim banner = 5
    Dim bannerLetters = 1
    Dim cakeSmall = 5
    Dim cakeMed = 20
    Dim cakeLarge = 35
    Dim balloon_max = 250

    Private Sub PartyDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitializeComboBoxes()
    End Sub

    Private Sub InitializeComboBoxes()
        numberPeople.Items.AddRange({"1", "2", "3", "4", "5", "6"})
        HaveSocks.Items.AddRange({"Yes", "No"})
        cakerequired.Items.AddRange({"Small", "Medium", "Large"})
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Balloonchoice.Text > balloon_max Then
            MessageBox.Show("Maximum Balloons Reached, Sorry!")
        Else
            Dim resultText As String = "Number of people is " & numberPeople.Text & vbCrLf &
                                       "Has socks: " & HaveSocks.Text & vbCrLf &
                                       "Admin fee is: " & adminCost & vbCrLf &
                                       "Number of balloons is: " & Balloonchoice.Text

            If cakerequired.SelectedItem IsNot Nothing Then
                Select Case cakerequired.SelectedItem.ToString()
                    Case "Small"
                        resultText &= vbCrLf & "Cake choice is: Small" & vbCrLf & "Cake price is " & cakeSmall
                    Case "Medium"
                        resultText &= vbCrLf & "Cake choice is: Medium" & vbCrLf & "Cake price is " & cakeMed
                    Case "Large"
                        resultText &= vbCrLf & "Cake choice is: Large" & vbCrLf & "Cake price is " & cakeLarge
                    Case Else
                        MessageBox.Show("Error: Selected cake size not recognized.")
                End Select
            Else
                MessageBox.Show("Error: No cake size selected.")
            End If

            result.Text = resultText

            ' Prompt user to select a file path
            Dim saveFileDialog As New SaveFileDialog()
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt"
            saveFileDialog.Title = "Save Party Details"
            saveFileDialog.ShowDialog()

            If Not String.IsNullOrEmpty(saveFileDialog.FileName) Then
                ' Save party details to file
                SavePartyDetails(saveFileDialog.FileName, resultText)
            End If
        End If
    End Sub

    Private Sub SavePartyDetails(filePath As String, partyDetails As String)
        Try
            Using writer As New StreamWriter(filePath)
                writer.WriteLine(partyDetails)
            End Using
            MessageBox.Show("Party details saved to file successfully." & vbCrLf & "File Path: " & filePath)
        Catch ex As Exception
            MessageBox.Show("Error saving party details to file: " & ex.Message)
        End Try
    End Sub
End Class
