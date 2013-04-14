Imports MySql.Data.MySqlClient
Public Class FrmHeure
    Public db As MySqlDB = New MySqlDB("Data Source=localhost;Database=sitemeut_espace-i2;User ID=root;Password=toor;")

    Private Sub FrmHeure_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtp_date.Value = DateTime.Now
        Dim dCats = getCategories()

        cbCategories.DataSource = New BindingSource(dCats, Nothing)
        cbCategories.DisplayMember = "Value"
        cbCategories.ValueMember = "Key"
        ' AddHandler  cbCategories.SelectedIndexChanged += New EventHandler(AddressOf cbCategories_SelectedIndexChanged)
     
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
        If _run_validation() Then
            Dim categorieId As String
            Dim dataToInsert As New Dictionary(Of String, String)
            Dim d As String = Format(dtp_date.Value, "yyyy-MM-dd")

            categorieId = DirectCast(cbCategories.SelectedItem, KeyValuePair(Of Integer, String)).Key.ToString()

            If Not tb_comment.Text = Nothing Then
                tb_comment.Text = ""
            End If

            dataToInsert.Add("comment", tb_comment.Text)
            dataToInsert.Add("work_day", d)
            dataToInsert.Add("categorie_id", categorieId)

            Dim workedHours(,) As Integer = New Integer(,) {
                {CInt(worked_hour_from.Text), CInt(worked_min_from.Text)},
                {CInt(worked_hour_to.Text), CInt(worked_min_to.Text)}}

            saveTime(dataToInsert, workedHours)
            resetForm()
        Else
            Exit Sub
        End If
    End Sub

   
    Private Sub resetForm()
        For Each ctrl As Control In grBWorkHour.Controls
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
                CType(ctrl, RadioButton).Checked = False
            End If
            'Clearing selected ListBox
            If TypeOf ctrl Is ListBox Then
                CType(ctrl, ListBox).ClearSelected()
            End If
            'Clearing selected CheckBox
            If TypeOf ctrl Is CheckBox Then
                CType(ctrl, CheckBox).Checked = False
            End If
            'Clearing selected combobox
            If TypeOf ctrl Is ComboBox Then
                CType(ctrl, ComboBox).SelectedIndex = 0
            End If

            If TypeOf ctrl Is DateTimePicker Then
                CType(ctrl, DateTimePicker).Value = DateTime.Now
            End If
        Next
    End Sub

    Private Function _run_validation() As Boolean
        For Each ctrl As Control In grBWorkHour.Controls
            If TypeOf ctrl Is TextBox And IsNothing(ctrl.Text) And ctrl.Name.ToString IsNot "tb_comment" Then
                errProv.SetError(ctrl, "Ce champ ne peut pas etre vide")
                Return False
            End If
        Next

        Return True
    End Function

    Private Sub worked_from_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles worked_hour_from.KeyPress, worked_hour_to.KeyPress, worked_min_from.KeyPress, worked_min_to.KeyPress
        e.Handled = Not (IsNumeric(e.KeyChar) Or Asc(e.KeyChar) = 46 Or Asc(e.KeyChar) = 8)
    End Sub

    Private Sub worked_hour_from_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles worked_hour_from.KeyUp, worked_hour_to.KeyUp, worked_min_from.KeyUp, worked_min_to.KeyUp
        Dim ctrl As Control = CType(sender, Control)

        If ctrl.Text.ToString.Length > 1 Then
            grBWorkHour.SelectNextControl(ctrl, True, True, True, True)
        End If
    End Sub

    Private Sub cbCategories_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCategories.SelectedIndexChanged
        ' might aswell comment everything...

        ' Dim _key As Integer = DirectCast(cbCategories.SelectedItem, KeyValuePair(Of Integer, String)).Key
        ' Dim _value As String = DirectCast(cbCategories.SelectedItem, KeyValuePair(Of Integer, String)).Value
        ' MessageBox.Show([String].Format("Use selection of dictionary is:" & vbLf & "Key: {0}" & vbLf & "Value: {1}", _key, _value))
    End Sub

    Private Sub btn_return_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_return.Click
        Me.Close()
        ListeHeures.Show()
    End Sub
End Class