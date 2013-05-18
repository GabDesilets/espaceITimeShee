Imports System.Windows.Forms
'Module principale de l'application
Module App
    Public amenu As adminMenu
    Public Const STUDENT As Integer = 1
    Public Const SUPER_USER As Integer = 2
    Public Sub Main()
        Dim db = New MySqlDB("Data Source=localhost;Database=sitemeut_espace-i2;User ID=root;Password=toor;")

        ListeHeures.db = db
        FrmHeure.db = db
        LoginForm.db = db
        TicketForm.db = db
        TicketList.db = db

        Dim uid = LoginForm.Prompt()
        If Not uid = 0 Then
            amenu = New adminMenu(uid)
            Application.Run(amenu)
        End If
    End Sub
End Module
