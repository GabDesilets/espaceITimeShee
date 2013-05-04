Public Class adminMenu
    Dim userId As Integer
    Public Sub New(ByVal uid As Integer)
        InitializeComponent()
        userId = uid
    End Sub

    Private Sub adminMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        panBtnExit.Controls.Add(exitButton.createExitBtn(Me))
    End Sub

    Private Sub goToListHeures() Handles bHoursList.Click
        Hide()
        Dim frootloops = New ListeHeures(userId)
        frootloops.Show()
    End Sub

    Private Sub goToTicketsList() Handles bTicketsList.Click
        Hide()

        Dim frootloops = New TicketList()
        frootloops.Show()
    End Sub
End Class