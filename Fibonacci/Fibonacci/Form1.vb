Imports System.Windows.Forms
Public Class Form1
    Dim compteur As Double = 0
    Function Fibo(ByRef valeur As Integer) As Integer

        compteur = compteur + 1

        If valeur = 1 Or valeur = 0 Then
            Return valeur
        ElseIf valeur >= 2 Then
            Return Fibo(valeur - 2) + Fibo(valeur - 1)
        End If
    End Function
    Private Sub Button_Fibonacci_Click(sender As Object, e As EventArgs) Handles Button_Fibonacci.Click
        Dim nombre, resultat As Integer
        nombre = TextBox_nombre.Text
        compteur = 0
        resultat = Fibo(nombre)

        Label_Result.Text = resultat
        Label_nbr_appele.Text = compteur
    End Sub

    Private Sub Button_ajout_Click(sender As Object, e As EventArgs) Handles Button_ajout.Click
        If (TextBox_ajout_personnage.Text <> "") Then
            If (ListBox_personnage.Items.Contains(TextBox_ajout_personnage.Text)) Then
                MessageBox.Show("Le personnage existe déja")
            Else
                ListBox_personnage.Items.Add(TextBox_ajout_personnage.Text)
            End If
        Else
            MessageBox.Show("Aucun personnage écrit")
        End If
        Label_compteur_list.Text = ListBox_personnage.Items.Count
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label_compteur_list.Text = ListBox_personnage.Items.Count
    End Sub

    Private Sub ListBox_personnage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox_personnage.SelectedIndexChanged
        TextBox_ajout_personnage.Text = ListBox_personnage.Text
        Label_compteur_list.Text = ListBox_personnage.Items.Count
    End Sub

    Private Sub Button_RAZ_Click(sender As Object, e As EventArgs) Handles Button_RAZ.Click
        ListBox_personnage.Items.Clear()
        Label_compteur_list.Text = ListBox_personnage.Items.Count
    End Sub

    Private Sub Button_enlever_Click(sender As Object, e As EventArgs) Handles Button_enlever.Click
        ListBox_personnage.Items.Remove(ListBox_personnage.Text)
        Label_compteur_list.Text = ListBox_personnage.Items.Count
    End Sub

    Private Sub Button_Ajout_CheckBox_Click(sender As Object, e As EventArgs) Handles Button_Ajout_CheckBox.Click
        CheckedListBox_tintin.Items.Add(TextBox_ajout_checkBox.Text)
    End Sub

    Private Sub CheckedListBox_tintin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox_tintin.SelectedIndexChanged
        TextBox_ajout_checkBox.Text = CheckedListBox_tintin.Text
    End Sub
End Class
