'Classe qui gere les heures travailler et calcule le nombre total
'Puisque la classe contient seulement un Constructeur et une methode readOnly
'Dans un futur elle pourrait etre supprimer et remplacer par une simple fonction dans un module
Public Class hoursManagement
    Public hourFrom, hourTo, minFrom, minTo As Integer

    Public Sub New(Optional ByVal _hourFrom As Integer = 0, Optional ByVal _hourTo As Integer = 0, Optional ByVal _minFrom As Integer = 0, Optional ByVal _minTo As Integer = 0)
        hourFrom = _hourFrom
        hourTo = _hourTo
        minFrom = _minFrom
        minTo = _minTo
    End Sub

    'Formule pour calculer le temps travailler entre les 2 periode
    ' Si ex: DE 12:10 A 13:00 l'ecart est 50min , mais il faut avant 
    ' tout faire ceci : minute A - minute DE (00-10) donc -10
    ' Ensuite le maximum de minutes sur 1 heure - la valeur absolue obtenu precedement
    ' donc 60-10 et finalement le total de tout ca diviser par 60
    ' Pour avoir combien le total des minutes vaut sur une heure
    Public ReadOnly Property workedHours As Decimal
        Get
            Dim minTot, hourTot As Decimal

            If minTo < minFrom Then
                minTot = (60 - Math.Abs(minTo - minFrom)) / 60D
                hourTot = (hourTo - hourFrom) - 1
            Else
                minTot = (minTo - minFrom) / 60D
                hourTot = hourTo - hourFrom
            End If

            Return hourTot + minTot
        End Get
    End Property

End Class
