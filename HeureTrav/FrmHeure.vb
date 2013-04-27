﻿Imports MySql.Data.MySqlClient
Public Class FrmHeure
    Public Shared db As MySqlDB

    Public uid As Integer
    Public userName As String
    Public other As ListeHeures

    Public Sub New(ByVal u As Integer)
        InitializeComponent()
        uid = u
        userName = getUserNameById(uid)
    End Sub

    Public worksHours As hoursManagement = New hoursManagement()
    Private Sub FrmHeure_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtp_date.Value = DateTime.Now
        lbl_add_success.Hide()
        lbl_edit_success.Hide()
        grBWorkHour.Text = userName

        cbCategories.DataSource = New BindingSource(getCategories(), Nothing)
        cbCategories.DisplayMember = "Value"
        cbCategories.ValueMember = "Key"


        Dim exitButton As New exitButton
        Dim exitBtn = exitButton.createExitBtn()

        panBtnExit.Controls.Add(exitBtn)

    End Sub

    Private Sub setDayOfWeek()
        Dim myDate As Date = DateTime.Today
        Dim currentDay As Date = myDate.AddDays(DayOfWeek.Monday - myDate.DayOfWeek)
        Dim d As String

        For i = 1 To 7
            d = Format(currentDay, "yyyy-MM-dd")
            'test commit
            'Do something with current day
            currentDay = currentDay.AddDays(1)
        Next
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        Dim isFrom As Integer
        Dim rowId As String
        If Not _run_validation() Then
            Return
        End If

        If tb_comment.Text Is Nothing Then
            tb_comment.Text = ""
        End If
       
        rowId = lbl_hidden_row_id.Text

        isFrom = saveTime(
                Format(dtp_date.Value, "yyyy-MM-dd"),
                tb_comment.Text,
                DirectCast(cbCategories.SelectedItem, KeyValuePair(Of Integer, String)).Key.ToString(),
                New hoursManagement(
                    CInt(worked_hour_from.Text),
                    CInt(worked_hour_to.Text),
                    CInt(worked_min_from.Text),
                    CInt(worked_min_to.Text)
                    ),
                uid,
                rowId
                )

        If isFrom = fromAdd Then
            lbl_add_success.Show()
        Else
            lbl_edit_success.Show()
        End If

        resetForm()
    End Sub


    Private Sub resetForm()
        For Each ctrl As Control In grBWorkHour.Controls
            If TypeOf ctrl Is TextBox Then
                ctrl.Text = ""
            ElseIf TypeOf ctrl Is MaskedTextBox Then
                ctrl.Text = ""
            ElseIf TypeOf ctrl Is RadioButton Then
                CType(ctrl, RadioButton).Checked = False
            ElseIf TypeOf ctrl Is ListBox Then
                CType(ctrl, ListBox).ClearSelected()
            ElseIf TypeOf ctrl Is CheckBox Then
                CType(ctrl, CheckBox).Checked = False
            ElseIf TypeOf ctrl Is ComboBox Then
                CType(ctrl, ComboBox).SelectedIndex = 0
            ElseIf TypeOf ctrl Is DateTimePicker Then
                CType(ctrl, DateTimePicker).Value = DateTime.Now
            End If
        Next
    End Sub

    Private Function _run_validation() As Boolean
        Dim ok = True

        For Each ctrl As Control In grBWorkHour.Controls
            If TypeOf ctrl Is TextBox And ctrl.Text = "" And ctrl.Name.ToString IsNot "tb_comment" Then
                errProv.SetError(ctrl, "Ce champ ne peut pas etre vide")
                ok = False
            End If
        Next

        Return ok
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
        Dim dateOfFirstDay As DateTime = getFirstOfWeek(DateTime.Now)
        Dim dateOflastDay As DateTime = getLastOfWeek(DateTime.Now)

      
        Dim dtFrom As String = Format(dateOfFirstDay, "yyyy-MM-dd")
        Dim dtTo As String = Format(dateOflastDay, "yyyy-MM-dd")

        resetForm()
        Me.Hide()
        other.fillByWorkedDayBetweenDates(dtFrom, dtTo)
        other.Show()
    End Sub

    Private Sub lbl_edit_success_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_edit_success.Click, lbl_add_success.Click
        Dim labelToHide = CType(sender, Label)
        labelToHide.Hide()
    End Sub

   
End Class