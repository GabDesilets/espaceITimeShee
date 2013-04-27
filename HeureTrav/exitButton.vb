Public Class exitButton
    Function createExitBtn() As Button
        ' Create a Button object 
        Dim exitBtn As New Button
        ' Set Button properties
        exitBtn.Size = New Size(122, 40)
        exitBtn.Text = "Quitter"
        exitBtn.Name = "exitBtn"
        exitBtn.Font = New Font("Microsoft Sans Serif", 10)
        exitBtn.Image = My.Resources.door_out
        exitBtn.ImageAlign = ContentAlignment.BottomRight
        AddHandler exitBtn.Click, AddressOf exitBtn_Click
       
        Return exitBtn
    End Function
    Private Sub exitBtn_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Application.Exit()
    End Sub
End Class
