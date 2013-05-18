'Classe pour centraliser le bouton pour quitter l'application
'Permet d'eviter de reecrire plusieurs fois pour rien la sortie de l'application
Public Class exitButton
    Shared Function createExitBtn(ByVal target As Form) As Button
        ' Create a Button object 
        Dim exitBtn As New Button
        ' Set Button properties
        exitBtn.Size = New Size(122, 40)
        exitBtn.Text = "Quitter"
        exitBtn.Name = "exitBtn"
        exitBtn.Font = New Font("Microsoft Sans Serif", 10)
        exitBtn.Image = My.Resources.door_out
        exitBtn.ImageAlign = ContentAlignment.BottomRight
        AddHandler exitBtn.Click, Sub() System.Environment.Exit(0)

        Return exitBtn
    End Function
End Class
