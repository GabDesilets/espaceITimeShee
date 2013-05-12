Imports MySql.Data.MySqlClient
Public Class StatsForm
    Public dateOfFirstDay As DateTime = getFirstOfWeek(DateTime.Now)
    Public dateOflastDay As DateTime = getLastOfWeek(DateTime.Now)
    Public Sub New()
        InitializeComponent()
        AddHandler FormClosed, Sub() amenu.Show()
    End Sub

    Public Sub FillAutocomplete()
        txtSQuery.AutoCompleteCustomSource.Clear()
        Using r = db.Query("SELECT CONCAT_WS(' ',prenom,nom) as name FROM etudiant")
            While r.Read()
                txtSQuery.AutoCompleteCustomSource.Add(r.GetString(0))
            End While
            r.Close()
        End Using

    End Sub

    Private Sub StatsForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim dfrom, dto As String
        dateFrom.Value = dateOfFirstDay
        dateTo.Value = dateOflastDay
        dfrom = Format(dateFrom.Value, "yyyy-MM-dd")
        dto = Format(dateTo.Value, "yyyy-MM-dd")
        FillAutocomplete()
        fillStats(dfrom, dto)


    End Sub

    Public Sub SearchKey(ByVal s As Object, ByVal e As KeyEventArgs) Handles txtSQuery.KeyUp
        If e.KeyCode = 13 Then
            SearchBtn()
        End If
    End Sub

    Public Sub SearchBtn() Handles bSAct.Click
        Dim dfrom, dto As String
        dfrom = Format(dateFrom.Value, "yyyy-MM-dd")
        dto = Format(dateTo.Value, "yyyy-MM-dd")

        fillStats(dfrom, dto)
    End Sub

    Public Sub fillStats(ByVal dateFrom As String, ByVal dateTo As String)
        Dim dbloc As MySqlDB = New MySqlDB("Data Source=localhost;Database=sitemeut_espace-i2;User ID=root;Password=toor;")

        Dim userProgHoursByCat = mOperations.getProgrammationHours(dateFrom, dateTo)
        Dim userSuppHoursByCat = mOperations.geSupportHours(dateFrom, dateTo)
        Dim userTickets = mOperations.getTicketNumbers(dateFrom, dateTo)
        Dim userTicketTime = mOperations.getTicketTimeAverage(dateFrom, dateTo)

        Dim query = "SELECT temps_travail.etu_id,temps_travail.categorie_id, CONCAT_WS(' ',etudiant.prenom,etudiant.nom) as name " &
                   " FROM(temps_travail)" &
                   " JOIN etudiant on etudiant.id = temps_travail.etu_id" &
                   " WHERE work_day BETWEEN @0 AND @1 AND ADMIN >= 1 "

        Dim r As MySqlDataReader
        lvStatsStudent.Items.Clear()

        If Not txtSQuery.Text = "" Then
            query &= " AND etudiant.nom LIKE CONCAT('%', @2, '%') OR etudiant.prenom LIKE CONCAT('%', @2, '%') OR CONCAT(etudiant.nom,' ', etudiant.prenom) LIKE CONCAT('%', @2, '%') OR CONCAT(etudiant.prenom, ' ', etudiant.nom) LIKE CONCAT('%', @2, '%') "
            query &= " GROUP BY temps_travail.etu_id "
            r = dbloc.Query(query,
             dateFrom,
             dateTo,
             txtSQuery.Text
         )
        Else
            query &= " GROUP BY temps_travail.etu_id "
            r = dbloc.Query(query,
                             dateFrom,
                             dateTo
                         )
        End If
        Dim i As ListViewItem

        Dim rowArr As New Dictionary(Of String, Integer)
        Do While r.Read()
            If Not userProgHoursByCat.ContainsKey(CInt(r("etu_id"))) Then
                userProgHoursByCat.Add(CInt(r("etu_id")), 0)
            End If
            If Not userSuppHoursByCat.ContainsKey(CInt(r("etu_id"))) Then
                userSuppHoursByCat.Add(CInt(r("etu_id")), 0)
            End If
            If Not userTickets.ContainsKey(CInt(r("etu_id"))) Then
                userTickets.Add(CInt(r("etu_id")), 0)
            End If
            If Not userTicketTime.ContainsKey(CInt(r("etu_id"))) Then
                userTicketTime.Add(CInt(r("etu_id")), 0)
            End If

            Dim total = userProgHoursByCat.Item(CInt(r("etu_id"))) + userSuppHoursByCat.Item(CInt(r("etu_id")))

            i = New ListViewItem(New String() {
                CStr(r("name")),
                CStr(userProgHoursByCat.Item(CInt(r("etu_id")))),
                CStr(userSuppHoursByCat.Item(CInt(r("etu_id")))),
                CStr(CStr(total)),
                CStr(userTickets.Item(CInt(r("etu_id")))),
                CStr(userTicketTime.Item(CInt(r("etu_id"))))
            })

            lvStatsStudent.Items.Add(i)
        Loop

        r.Close()
    End Sub
    Private Sub dateFrom_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dateFrom.ValueChanged, dateTo.ValueChanged
        Dim dfrom, dto As String
        dfrom = Format(dateFrom.Value, "yyyy-MM-dd")
        dto = Format(dateTo.Value, "yyyy-MM-dd")

        fillStats(dfrom, dto)
    End Sub
    Private Sub btn_return_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_return.Click
        Me.Hide()
        amenu.Show()
    End Sub

End Class
