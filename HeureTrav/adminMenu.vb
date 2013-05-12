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
        Dim listHeures = New ListeHeures(userId)
        listHeures.Show()
    End Sub

    Private Sub goToTicketsList() Handles bTicketsList.Click
        Hide()
        Dim ticketList = New TicketList()
        ticketList.Show()
    End Sub

    Private Sub gotToStatistic() Handles bStats.Click
        Hide()
        Dim statsForm = New StatsForm()
        statsForm.Show()
    End Sub

    
    Private Sub bGenLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bGenLog.Click
        Dim clsLog As LogFile.ClsLog
        clsLog = New LogFile.ClsLog
        clsLog.dirName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\Journal d'activite"
        clsLog.fileName = "\logFileGabTest.txt"
        clsLog.writeLog("I like trains")
    End Sub
End Class