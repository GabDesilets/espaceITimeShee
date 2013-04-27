Imports System.Windows.Forms

Module App
    Public Sub Main()
        Dim db = New MySqlDB("Data Source=localhost;Database=sitemeut_espace-i2;User ID=root;Password=toor;")

        ListeHeures.db = db
        FrmHeure.db = db
        LoginForm.db = db
	TicketForm.db = db
	TicketList.db = db

        Dim uid = LoginForm.Prompt()

        If Not uid = 0 Then
            Dim lh = New ListeHeures(uid)
            Dim fh = New FrmHeure(uid)

            ' This is needed to keep your current architecture. FrmHeure.* and ListeHeures.* in opposite
            ' forms was just broken. (calling .Show() on the _class_ WTF?)
            ' If you want something proper, you'll have to make something that looks like LoginForm's .Prompt()
            ' in FrmHeure, so ListeHeures can call it
            lh.other = fh
            fh.other = lh

            Application.Run(lh)
        End If
    End Sub
End Module
