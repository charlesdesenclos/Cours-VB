Imports System.Net.Security

Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim C As Long
        Dim A As Long
        Dim B As Long

        If (textbox_nbr1.Text <> "" And TextBox_br2.Text <> "") Then

            A = textbox_nbr1.Text
            B = TextBox_br2.Text



            C = A + B

            label_result.Text = C
        Else
            MsgBox("Il manque une valeur dans une zone.")

        End If

    End Sub
End Class
