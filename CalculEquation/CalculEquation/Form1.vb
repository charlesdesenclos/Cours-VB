Imports System.Net.Security
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Button_Valider_Click(sender As Object, e As EventArgs) Handles Button_Valider.Click
        If (TextBox_A.Text <> "") Then
            If (TextBox_B.Text <> "") Then
                If (TextBox_C.Text <> "") Then
                    Dim nbr_A As Double
                    Dim nbr_B As Double
                    Dim nbr_C As Double
                    Dim Delta As Double
                    Dim Res0 As Double
                    Dim Res1 As Double
                    Dim Res2 As Double
                    Dim ResPremier As Double
                    Dim ResSave As Double





                    nbr_A = TextBox_A.Text
                    nbr_B = TextBox_B.Text
                    nbr_C = TextBox_C.Text


                    ' Equation du premier degré
                    If nbr_A = 0 Then
                        Label_X1.Visible = False
                        Label_X2.Visible = False
                        Label_Resultat.Visible = False
                        Label_Resultat2.Visible = False
                        Label_REsult0.Visible = True
                        Label_X0.Visible = True
                        Label_Canonique.Visible = False
                        Label_Result_Canonique.Visible = False
                        ResPremier = -nbr_B / nbr_C
                        ResPremier = Math.Round(ResPremier, 2)
                        Label_REsult0.Text = ResPremier

                        Label_X0.Text = "Résultat = "

                        Label_Solution.Text = " Equation du premier degré"


                        'Equation du second degré
                    Else
                        Delta = nbr_B * nbr_B - 4 * nbr_A * nbr_C

                        Label_Delta.Text = "Delta = "
                        Label_Result_Delta.Text = Delta




                        If Delta = 0 Then
                            Label_X1.Visible = False
                            Label_X2.Visible = False
                            Label_Resultat.Visible = False
                            Label_Resultat2.Visible = False
                            Label_REsult0.Visible = True
                            Label_X0.Visible = True
                            Label_Canonique.Visible = True
                            Label_Result_Canonique.Visible = True
                            Res0 = -nbr_B / (2 * nbr_A)
                            Res0 = Math.Round(Res0, 2)
                            Label_REsult0.Text = Res0
                            Label_X0.Text = "X0 = "

                            Label_Solution.Text = " La solution possède une solution."

                            Label_Canonique.Text = "La forme canonique est : "
                            Res0 = Res0 * -1

                            Label_Result_Canonique.Text = Res0.ToString & "*(x" & If(Res0 >= 0, "+" & Res0.ToString(), Res0.ToString()) & ")^2"


                        ElseIf Delta > 0 Then
                            Label_X1.Visible = True
                            Label_X2.Visible = True
                            Label_Resultat.Visible = True
                            Label_Resultat2.Visible = True
                            Label_REsult0.Visible = False
                            Label_X0.Visible = False
                            Label_Canonique.Visible = True
                            Label_Result_Canonique.Visible = True
                            Res1 = (-nbr_B - Math.Sqrt(Delta)) / (2 * nbr_A)
                            Res2 = (-nbr_B + Math.Sqrt(Delta)) / (2 * nbr_A)

                            Res1 = Math.Round(Res1, 2)
                            Res2 = Math.Round(Res2, 2)

                            Label_Resultat.Text = Res1
                            Label_X1.Text = "X1 = "
                            Label_Resultat2.Text = Res2
                            Label_X2.Text = "X2 = "
                            Label_Solution.Text = " La solution possède deux solutions."

                            Label_Canonique.Text = "La forme canonique est : "
                            Res1 = Res1 * -1
                            ResSave = Res2 * -1


                            Label_Result_Canonique.Text = Res2.ToString() & "*(x" & If(Res1 >= 0, "+" & Res1.ToString(), "-" & Math.Abs(Res1).ToString()) & ")(x" & If(ResSave >= 0, "+" & ResSave.ToString(), "-" & Math.Abs(ResSave).ToString()) & ")"

                        ElseIf Delta < 0 Then
                            Label_X1.Visible = False
                            Label_X2.Visible = False
                            Label_Resultat.Visible = False
                            Label_Resultat2.Visible = False
                            Label_REsult0.Visible = False
                            Label_X0.Visible = False
                            Label_Canonique.Visible = True
                            Label_Result_Canonique.Visible = True
                            Label_Solution.Text = "Il n'existe aucune solution réelle"

                            Label_Canonique.Text = "La forme canonique n'existe pas"

                        End If

                    End If
                Else
                    MsgBox("Il manque une valeur dans la zone pour C.")
                End If
            Else
                MsgBox("Il manque une valeur dans la zone pour B.")
            End If
        Else

            MsgBox("Il manque une valeur dans la zone A.")
        End If





    End Sub


    Private Sub TextBox_A_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_A.KeyPress
        If (Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ControlChars.Tab) AndAlso
            (e.KeyChar <> "-" OrElse TextBox_A.SelectionStart <> 0) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox_B_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_B.KeyPress
        If (Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ControlChars.Tab) AndAlso
            (e.KeyChar <> "-" OrElse TextBox_B.SelectionStart <> 0) Then
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox_C_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox_C.KeyPress
        If (Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back AndAlso e.KeyChar <> ControlChars.Tab) AndAlso
            (e.KeyChar <> "-" OrElse TextBox_C.SelectionStart <> 0) Then
            e.Handled = True
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
    End Sub

    Private Sub Button_Reset_Click(sender As Object, e As EventArgs) Handles Button_Reset.Click
        TextBox_A.Text = ""
        TextBox2.Text = ""
        TextBox_C.Text = ""
        Label_X1.Visible = False
        Label_X2.Visible = False
        Label_Resultat.Visible = False
        Label_Resultat2.Visible = False
        Label_REsult0.Visible = False
        Label_X0.Visible = False
        Label_Canonique.Visible = True
        Label_Result_Canonique.Visible = True
    End Sub
End Class
