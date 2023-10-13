Imports System.Net.Security
Public Class Form1

    Dim nbr_aleatoire As Integer
    Dim nbr_de_coup As Integer = 0
    Dim i As Integer = 0
    Dim a As Integer
    Dim nbr As Integer = 0
    Dim message_result As String



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Random As New Random()
        nbr_aleatoire = Random.Next(1, 100)

        'Label_test.Text = nbr_aleatoire

        RadioButton_niv2.Checked() = True


    End Sub



    Private Sub Button_valider_joueur1_Click(sender As Object, e As EventArgs) Handles Button_valider_joueur1.Click
        If (TextBox_nbr_joueur_1.Text <> "") Then
            If (TextBox_nbr_joueur_1.Text >= 1 And TextBox_nbr_joueur_1.Text <= 100) Then
                nbr = TextBox_nbr_joueur_1.Text

                i = i + 1
                Label_nbr_coup.Text = i

                If nbr_aleatoire = nbr Then
                    message_result = "Trouvé !"
                    Label_resul.Text = i.ToString + " : " + nbr.ToString + " " + "Trouvé ! " + vbCrLf
                    'Label_resul.Text = message_result
                ElseIf nbr_aleatoire > nbr Then
                    message_result = "Résultat trop petit !"
                    Label_resul.Text = i.ToString + " : " + nbr.ToString + " " + "est trop petit !" + vbCrLf
                    'Label_resul.Text = message_result
                ElseIf nbr_aleatoire < nbr Then
                    message_result = "Résultat trop grand !"
                    Label_resul.Text = i.ToString + " : " + nbr.ToString + " " + "est trop grand !" + vbCrLf
                    'Label_resul.Text = message_result
                End If



            Else
                MsgBox("La valeur dépasse la limite.")

            End If
        Else
            MsgBox("Il manque une valeur dans une zone.")

        End If

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_nbr_joueur_1.KeyPress

        If e.KeyChar = Chr(8) Then ' acceptation du <backspace>
            Return
        End If
        If e.KeyChar = "." Then ' acceptation du point
            Return
        End If
        If Not IsNumeric(e.KeyChar) Then 'refus de tout ce qui n'est pas numérique
            e.Handled = True
        End If
    End Sub

    Private Sub Button_quitter_Click(sender As Object, e As EventArgs) Handles Button_quitter.Click
        Me.Close()
    End Sub

    Private Sub Button_recommencer_Click(sender As Object, e As EventArgs) Handles Button_recommencer.Click

    End Sub
End Class
