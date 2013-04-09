Imports MySql.Data.MySqlClient
Public Class FrmHeure
    Public cn As MySqlConnection = New MySqlConnection("Data Source=localhost;Database=sitemeut_espace-i2;User ID=root;Password=toor;")
    Private Sub FrmHeure_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtp_date.Value = DateTime.Now
    End Sub

    Private Sub setDayOfWeek()
        Dim myDate As Date = DateTime.Today
        Dim dayDiff As Integer = myDate.DayOfWeek - DayOfWeek.Monday
        Dim currentDay As Date = myDate.AddDays(-dayDiff) 'Monday
        Dim d As String

        For i = 1 To 7
            d = Format(currentDay, "yyyy-MM-dd")
            'test commit
            'Do something with current day
            currentDay = currentDay.AddDays(1)
        Next
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        'TODO MAKE A REAL SAVE FUNCTION AND CALL HER HERE AND CHECK IF UPDATE OR REAL INSERT !!
        If _run_validation() Then
            tb_comment.Text = If(Not tb_comment.Text = Nothing, tb_comment.Text, "")
            Dim d As String = Format(dtp_date.Value, "yyyy-MM-dd")
            Dim Query As String
            Dim worked_hours As Decimal
            Dim workedHours(,) As Integer = New Integer(,) {
                {CInt(worked_hour_from.Text), CInt(worked_min_from.Text)},
                {CInt(worked_hour_to.Text), CInt(worked_min_to.Text)}}


            worked_hours = getWorkedHours(workedHours)
            Query = "INSERT INTO temps_travail VALUES(NULL," & 7 & ",'" & d & "'," & worked_hours & "," & workedHours(0, 0) & "," & workedHours(0, 1) & "," & workedHours(1, 0) & "," & workedHours(1, 1) & ",'" & tb_comment.Text & "')"
            cn.Open()
            Debug.WriteLine(Query)
            Dim cmd As MySqlCommand = New MySqlCommand(Query, cn)

            Dim i As Integer = cmd.ExecuteNonQuery()
            If (i > 0) Then
                MessageBox.Show("Record is Successfully Inserted")
                resetForm()
            Else
                MessageBox.Show("Record is not Inserted")
            End If
            cn.Close()
        Else
            Exit Sub
        End If


    End Sub

    Private Function getWorkedHours(ByVal hours(,) As Integer)
        Dim hourTot As Integer
        Dim minTot As Decimal

        If hours(1, 1) < hours(0, 1) Then
            minTot = (60 - Math.Abs(hours(1, 1) - hours(0, 1))) / 100
            hourTot = (hours(1, 0) - hours(0, 0)) - 1
        Else
            minTot = (hours(1, 1) - hours(0, 1)) / 100
            hourTot = hours(1, 0) - hours(0, 0)
        End If
        Return hourTot + minTot
    End Function
    Private Sub resetForm()
        For Each ctrl In grBWorkHour.Controls
            If TypeOf ctrl Is Label Then
                Continue For
            End If
            'Clearing text in the TextBox
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            End If
            'Clearing text in the TextBox
            If TypeOf ctrl Is MaskedTextBox Then
                ctrl.Text = ""
            End If
            'Clearing Selected RadioButton 
            If TypeOf ctrl Is RadioButton Then
                ctrl.ClearSelection()
            End If
            'Clearing selected ListBox
            If TypeOf ctrl Is ListBox Then
                ctrl.ClearSelection()
            End If
            'Clearing selected CheckBox
            If TypeOf ctrl Is CheckBox Then
                ctrl.Checked = False
            End If
            'Clearing selected combobox
            If TypeOf ctrl Is ComboBox Then
                ctrl.selectedIndex = 0
            End If

            If TypeOf ctrl Is DateTimePicker Then
                ctrl.value = DateTime.Now
            End If
        Next
    End Sub
    Private Function _run_validation()
        Dim allGood As Boolean = True
        For Each ctrl In grBWorkHour.Controls
            If TypeOf ctrl Is TextBox And ctrl.name.ToString IsNot "tb_comment" Then
                errProv.SetError(ctrl, "Ce champs ne peut pas etre vide")
                allGood = False
            End If
        Next
        Return allGood
    End Function

    Private Sub worked_from_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles worked_hour_from.KeyPress, worked_hour_to.KeyPress, worked_min_from.KeyPress, worked_min_to.KeyPress
        If IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8 Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    
    End Sub

    Private Sub worked_hour_from_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles worked_hour_from.KeyUp, worked_hour_to.KeyUp, worked_min_from.KeyUp, worked_min_to.KeyUp
        If sender.text.ToString.Length > 1 Then
            grBWorkHour.SelectNextControl(sender, True, True, True, True)
        End If
    End Sub

End Class