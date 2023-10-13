Imports System.Net.Security
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Button_Calculer_Click(sender As Object, e As EventArgs) Handles Button_Calculer.Click
        Dim nbr As Long
        Dim i As Integer
        Dim result_premier_nbr As Long
        Dim result_premier_nbr_impairs As Long
        Dim result_premier_nbr_pairs As Long


        result_premier_nbr = 0


        If (TextBox_nbr.Text <> "") Then
            nbr = TextBox_nbr.Text


            For i = 0 To nbr

                result_premier_nbr = result_premier_nbr + i



            Next
            For i = 1 To nbr


                result_premier_nbr_impairs = result_premier_nbr_impairs + i
                i = i + 1
            Next
            For i = 0 To nbr


                result_premier_nbr_pairs = result_premier_nbr_pairs + i
                i = i + 1
            Next

            Label_premiers_nbr.Text = result_premier_nbr
            Label_premiers_nbr_impairs.Text = result_premier_nbr_impairs
            Label_premiers_nbr_pairs.Text = result_premier_nbr_pairs
        Else
            MsgBox("Il manque une valeur dans une zone.")
        End If

    End Sub

    Private Sub Button_RAZ_Click(sender As Object, e As EventArgs) Handles Button_RAZ.Click
        Dim nbr As Char
        Dim result_premier_nbr As Char
        Dim result_premier_nbr_impairs As Char
        Dim result_premier_nbr_pairs As Char

        nbr = ""
        result_premier_nbr = ""
        result_premier_nbr_impairs = ""
        result_premier_nbr_pairs = ""

        TextBox_nbr.Text = nbr
        Label_premiers_nbr.Text = result_premier_nbr
        Label_premiers_nbr_impairs.Text = result_premier_nbr_impairs
        Label_premiers_nbr_pairs.Text = result_premier_nbr_pairs
    End Sub


    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_nbr.KeyPress

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
End Class
