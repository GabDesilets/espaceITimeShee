Public Class adminMenu
    Dim userId As Integer
    Public Sub New(ByVal uid As Integer)
        InitializeComponent()
        userId = uid
    End Sub

    Private Sub adminMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        panBtnExit.Controls.Add(exitButton.createExitBtn(Me))

        'Si La personne n'est pas un super user elle ne peut pas generer le journal et visualiser les stats
        If mOperations.getAdminLevelByUid(userId) <= STUDENT Then
            bGenLog.Hide()
            bStats.Hide()
        End If

        Me.Text = "Menu"
    End Sub

    Private Sub goToListHeures() Handles bHoursList.Click
        Hide()
        Dim listHeures = New ListeHeures(userId)
        listHeures.Show()
    End Sub

    Private Sub goToTicketsList() Handles bTicketsList.Click
        Hide()
        Dim ticketList = New TicketList(userId)
        ticketList.Show()
    End Sub

    Private Sub gotToStatistic() Handles bStats.Click
        Hide()
        Dim statsForm = New StatsForm()
        statsForm.Show()
    End Sub

    
    Private Sub bGenLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bGenLog.Click
        Dim logs = LogHook.getLog()
        While logs.Read
            LogHook.writeLog(
                logs("changed_at").ToString & _
                vbTab & _
                logs("name").ToString & _
                logs("act").ToString.PadLeft(10, " "c) & _
                vbTab & _
                logs("description").ToString()
            )
        End While
        logs.Close()
    End Sub

End Class