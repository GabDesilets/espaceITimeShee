Public Class LoginForm
	Public Shared db As MySqlDB

	Public Shared Function Prompt() As Integer
		Dim d = New LoginForm()

		d.ShowDialog()

        Return d.uid
    End Function

    Private uid As Integer

    Public Sub New()
        InitializeComponent()
        LError.Hide()
        uid = 0
    End Sub

    Private Sub Login(sender As System.Object, e As System.EventArgs) Handles BLogin.Click
        Dim r = db.Query(
         "SELECT id FROM etudiant WHERE login = @0 AND password = @1 LIMIT 1",
         TUser.Text,
         TPass.Text
         )

        Try
            If r.HasRows Then
                r.Read()
                uid = CInt(r("id"))
                Close()
            Else
                LError.Show()
            End If
        Finally
            r.Close()
        End Try
    End Sub
End Class