Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Dim Calcul As String

    Dim TabCalcul() As String


    Dim val1 As String
    Dim result As String

    Private Sub PictureBox_touche_zero_Click(sender As Object, e As EventArgs) Handles PictureBox_touche_zero.Click
        TextBox_affiche.Text &= "0"
    End Sub

    Private Sub PictureBox_touche_deux_Click(sender As Object, e As EventArgs) Handles PictureBox_touche_deux.Click
        TextBox_affiche.Text &= "2"
    End Sub

    Private Sub PictureBox_touche_quatre_Click(sender As Object, e As EventArgs)
        TextBox_affiche.Text &= "4"
    End Sub

    Private Sub PictureBox_touche_cinq_Click(sender As Object, e As EventArgs) Handles PictureBox_touche_cinq.Click
        TextBox_affiche.Text &= "5"
    End Sub

    Private Sub PictureBox_touche_six_Click(sender As Object, e As EventArgs) Handles PictureBox_touche_six.Click
        TextBox_affiche.Text &= "6"
    End Sub

    Private Sub PictureBox_touche_7_Click(sender As Object, e As EventArgs) Handles PictureBox_touche_7.Click
        TextBox_affiche.Text &= "7"
    End Sub

    Private Sub PictureBox_touche_huit_Click(sender As Object, e As EventArgs) Handles PictureBox_touche_huit.Click
        TextBox_affiche.Text &= "8"
    End Sub

    Private Sub PictureBox_touche_neuf_Click(sender As Object, e As EventArgs) Handles PictureBox_touche_neuf.Click
        TextBox_affiche.Text &= "9"
    End Sub

    Private Sub PictureBox_touche_fois_Click(sender As Object, e As EventArgs) Handles PictureBox_touche_fois.Click
        TextBox_affiche.Text &= "*"
    End Sub

    Private Sub PictureBox_touc_diviser_Click(sender As Object, e As EventArgs) Handles PictureBox_touc_diviser.Click

        TextBox_affiche.Text &= "/"

    End Sub

    Private Sub PictureBox_touche_soustraction_Click(sender As Object, e As EventArgs) Handles PictureBox_touche_soustraction.Click
        TextBox_affiche.Text &= "-"

    End Sub

    Private Sub PictureBox_touche_addition_Click(sender As Object, e As EventArgs) Handles PictureBox_touche_addition.Click
        TextBox_affiche.Text &= "+"
    End Sub

    Private Sub PictureBox_touche_vigule_Click(sender As Object, e As EventArgs) Handles PictureBox_touche_vigule.Click
        TextBox_affiche.Text &= "."
    End Sub

    Private Sub PictureBox_touche_supprimer_valeur_Click(sender As Object, e As EventArgs) Handles PictureBox_touche_supprimer_valeur.Click

        If TextBox_affiche.Text.Length > 0 Then
            TextBox_affiche.Text = TextBox_affiche.Text.Substring(0, TextBox_affiche.Text.Length - 1)
        End If
    End Sub

    Private Sub PictureBox_touche_supprimer_Click(sender As Object, e As EventArgs) Handles PictureBox_touche_supprimer.Click
        TextBox_affiche.Text = " "
    End Sub

    Private Sub PictureBox_touche_trois_Click(sender As Object, e As EventArgs) Handles PictureBox_touche_trois.Click
        TextBox_affiche.Text &= "3"
    End Sub

    Private Sub PictureBox_touche_un_Click(sender As Object, e As EventArgs) Handles PictureBox_touche_un.Click
        TextBox_affiche.Text &= "1"
    End Sub



    Private Sub PictureBox_touche_egale_Click(sender As Object, e As EventArgs) Handles PictureBox_touche_egale.Click
        Try
            ' Obtenez le texte du TextBox.
            Dim expression As String = TextBox_affiche.Text

            ' Recherchez la position du pourcentage dans le texte.
            Dim percentIndex As Integer = expression.IndexOf("%")

            If percentIndex >= 0 Then
                ' Si un pourcentage est trouvé, extrayez la valeur précédente.
                Dim valueBeforePercent As Double
                If Double.TryParse(expression.Substring(0, percentIndex), valueBeforePercent) Then
                    ' Divisez la valeur précédente par 100.
                    valueBeforePercent /= 100

                    ' Remplacez la portion d'expression avec la nouvelle valeur.
                    expression = valueBeforePercent.ToString() & expression.Substring(percentIndex + 1)
                End If
            End If

            ' Utilisez la fonction Evaluate de DataTable pour évaluer l'expression modifiée.
            Dim result As Object = New DataTable().Compute(expression, Nothing)

            ' Affichez le résultat dans le TextBox.
            TextBox_affiche.Text = result.ToString()
            TextBox_affiche.ForeColor = Color.ForestGreen
            TextBox_result.Text = ""

        Catch ex As Exception
            ' Gérez les erreurs, par exemple, affichez un message d'erreur en cas de problème.
            TextBox_affiche.Text = "Erreur"
        End Try
    End Sub

    Private Sub PictureBox_touche_quatre_Click_1(sender As Object, e As EventArgs) Handles PictureBox_touche_quatre.Click
        TextBox_affiche.Text &= "4"
    End Sub

    Private Sub TextBox_affiche_TextChanged(sender As Object, e As EventArgs) Handles TextBox_affiche.TextChanged
        Try
            ' Utilisez la fonction Evaluate de DataTable pour évaluer l'expression.
            Dim result As Object = New DataTable().Compute(TextBox_affiche.Text, Nothing)

            ' Affichez le résultat dans un autre contrôle, par exemple, une étiquette (Label).
            TextBox_result.Text = result.ToString()
        Catch ex As Exception
            ' Gérez les erreurs, par exemple, effacez le résultat en cas de problème.
            TextBox_result.Text = ""
        End Try
    End Sub

    Private Sub PictureBox_pourcentage_Click(sender As Object, e As EventArgs) Handles PictureBox_pourcentage.Click
        TextBox_affiche.Text &= "%"
        TextBox_result.Text = TextBox_affiche.Text.Substring(0, TextBox_affiche.Text.Length - 1) / 100
    End Sub
End Class
