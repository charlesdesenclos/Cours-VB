Public Class Form1
    Sub addition_proc(ByVal A As Integer, ByVal B As Integer)
        Dim resultat As Integer
        resultat = A + B
        Label_result.Text = resultat
    End Sub

    Function addition_fct(ByVal X As Integer, ByVal Y As Integer) As Integer
        Dim resultat As Integer
        resultat = X + Y
        X = 0
        Y = 0
        Return resultat
    End Function

    Private Sub Button_ADD_fct_Click(sender As Object, e As EventArgs) Handles Button_ADD_fct.Click
        Dim nb1, nb2, result As Integer
        nb1 = TextBox_nombre1.Text
        nb2 = TextBox_nombre2.Text
        result = addition_fct(nb1, nb2)
        Label_result.Text = result
        TextBox_nombre1.Text = nb1
        TextBox_nombre2.Text = nb2
    End Sub

    Private Sub Button_add_proc_Click(sender As Object, e As EventArgs) Handles Button_add_proc.Click
        Dim nb1, nb2 As Integer
        nb1 = TextBox_nombre1.Text
        nb2 = TextBox_nombre2.Text
        addition_proc(nb1, nb2)


    End Sub
End Class
