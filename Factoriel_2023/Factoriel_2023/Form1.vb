Public Class Form1
    Function Facto(ByRef valeur As Integer) As Integer
        If valeur = 1 Then
            Return 1

        Else
            Return valeur * Facto(valeur - 1)

        End If
    End Function

    Private Sub Button_Factoriel_Click(sender As Object, e As EventArgs) Handles Button_Factoriel.Click
        Dim nombre, resultat As Integer
        nombre = TextBox_fac.Text
        resultat = Facto(nombre)

        Label_resultat.Text = resultat

    End Sub
End Class
