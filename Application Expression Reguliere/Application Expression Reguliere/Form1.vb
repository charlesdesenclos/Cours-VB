Imports System.Text.RegularExpressions

Public Class Form1
    Dim pattern As String
    Private Sub Button_Verification_Click(sender As Object, e As EventArgs) Handles Button_Verification.Click
        Dim expression As String
        Dim Exp_Reguliere = New Regex(TextBox_expression.Text)

        expression = TextBox_saisie.Text

        If expression <> "" Then
            If (Exp_Reguliere.IsMatch(expression)) Then
                TextBox_Resultat.Text = "Vrai"
            Else
                TextBox_Resultat.Text = "Faux"
            End If
        End If


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load

        pattern = "^[+-]?[0-9]+$"

        'pattern = "^[A-Z]"
        TextBox_expression.Text = pattern
    End Sub
End Class
