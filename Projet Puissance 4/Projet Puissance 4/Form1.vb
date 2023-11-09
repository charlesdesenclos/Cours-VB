Public Class Form1

    Dim Joueur1 As String
    Dim Joueur2 As String
    Dim ScoreJoueur_1 As Integer
    Dim ScoreJoueur_2 As Integer

    Private Const TailleDeLaColonne As Integer = 1141 / 7 ' 7 colonnes dans la grille
    Private Const TailleDeLaRangée As Integer = 728 / 6 ' 6 lignes dans la grille

    Dim NombrePartie As Integer
    Dim PartieIllimite As Boolean
    Dim NombrePartieActuel As Integer = 1

    Dim grille(6, 7) As Integer ' Représente la grille, 0 pour vide, 1 pour jaune, 2 pour rouge
    Dim joueurActif As Integer = 1 ' 1 pour le joueur jaune, 2 pour le joueur rouge

    Private Function GetClickedColumn(clickedPictureBox As PictureBox) As Integer
        'Récupére la colonne en fonction de la position X du clic


        Dim colonne As Integer = (clickedPictureBox.Location.X - PictureBox_grille.Location.X) \ TailleDeLaColonne
        Return colonne
    End Function

    Private Function GetEmptyRow(colonne As Integer) As Integer
        For rangée As Integer = 5 To 0 Step -1
            If grille(rangée, colonne) = 0 Then
                Return rangée
            End If
        Next
        Return -1 ' Retourne -1 si la colonne est pleine
    End Function

    Private Sub AfficherJeton(rangée As Integer, colonne As Integer)
        'Affiche les jetons en fonctions de la position
        Dim pictureBoxJeton As New PictureBox()
        pictureBoxJeton.Size = New Size(TailleDeLaColonne, TailleDeLaRangée)
        pictureBoxJeton.Location = New Point(colonne * TailleDeLaColonne, rangée * TailleDeLaRangée)

        If joueurActif = 1 Then
            pictureBoxJeton.SizeMode = PictureBoxSizeMode.StretchImage
            pictureBoxJeton.Image = My.Resources.Pion_Jaune
            pictureBoxJeton.BackColor = Color.Transparent
            pictureBoxJeton.Size = New Size(158, 123)
            PictureBox_joueur_1 = pictureBoxJeton

        Else
            pictureBoxJeton.SizeMode = PictureBoxSizeMode.StretchImage
            pictureBoxJeton.Image = My.Resources.Pion_Rouge
            pictureBoxJeton.BackColor = Color.Transparent
            pictureBoxJeton.Size = New Size(158, 123)
            PictureBox_joueur_2 = pictureBoxJeton
        End If

        PictureBox_grille.Controls.Add(pictureBoxJeton)
    End Sub

    Private Function CheckMatchNul() As Boolean
        ' Parcourt la grille pour vérifier s'il y a un match nul

        For i As Integer = 0 To 5
            For j As Integer = 0 To 6
                If grille(i, j) = 0 Then
                    ' S'il y a au moins un emplacement vide, le jeu n'est pas un match nul
                    Return False
                End If
            Next
        Next

        ' Si aucun emplacement vide n'est trouvé, c'est un match nul
        MessageBox.Show("Match nul!")
        EffacerGrille() ' Réinitialise la grille
        Return True
    End Function


    Private Function CheckVictoire(rangée As Integer, colonne As Integer) As Boolean
        Dim couleurActuelle As Integer = grille(rangée, colonne)

        ' Vérification horizontale
        If CheckDirection(rangée, colonne, 0, 1, couleurActuelle) Then Return True

        If CheckDirection(rangée, colonne, 0, -1, couleurActuelle) Then Return True

        ' Vérification verticale
        If CheckDirection(rangée, colonne, 1, 0, couleurActuelle) Then Return True

        ' Vérification diagonale ascendante
        If CheckDirection(rangée, colonne, -1, 1, couleurActuelle) Then Return True

        ' Vérification diagonale descendante
        If CheckDirection(rangée, colonne, 1, 1, couleurActuelle) Then Return True

        If CheckDirection(rangée, colonne, 1, -1, couleurActuelle) Then Return True

        Return False
    End Function

    Private Function CheckDirection(rangée As Integer, colonne As Integer, deltaRangée As Integer, deltaColonne As Integer, couleurActuelle As Integer) As Boolean
        For i As Integer = 1 To 3 ' Vérifiez 4 pions consécutifs
            Dim nouvelleRangée As Integer = rangée + i * deltaRangée
            Dim nouvelleColonne As Integer = colonne + i * deltaColonne

            If nouvelleRangée < 0 Or nouvelleRangée >= 6 Or nouvelleColonne < 0 Or nouvelleColonne >= 7 Then
                Exit For ' Sortir de la boucle si on dépasse les limites de la grille
            End If

            If grille(nouvelleRangée, nouvelleColonne) <> couleurActuelle Then
                Exit For ' Sortir de la boucle si on trouve une couleur différente
            End If

            If i = 3 Then
                ' On a trouvé 4 pions consécutifs de la même couleur dans cette direction
                If (joueurActif = 1) Then
                    MessageBox.Show("Joueur " & Joueur1 & " a gagné!")
                    ScoreJoueur_1 += 1
                    Label_Score_Joueur_1.Text = "Score : " + ScoreJoueur_1.ToString
                    NombrePartieActuel += 1
                    joueurActif = 2
                ElseIf (joueurActif = 2) Then
                    MessageBox.Show("Joueur " & Joueur2 & " a gagné!")
                    ScoreJoueur_2 += 1
                    Label_partie_gagne_joueur_2.Text = "Score : " + ScoreJoueur_2.ToString
                    NombrePartieActuel += 1
                    joueurActif = 1
                End If
                Return True
            End If
        Next

        Return False
    End Function


    Private Sub EffacerGrille()
        Dim pionsARemover As New List(Of PictureBox)

        ' Parcourt tous les contrôles PictureBox dans la grille
        For Each ctrl As Control In PictureBox_grille.Controls
            If TypeOf ctrl Is PictureBox Then
                ' Vérifie si le PictureBox représente un pion rouge ou jaune
                If ctrl.BackColor = Color.Transparent Then
                    ' Ajoute le PictureBox à la liste des pions à supprimer
                    pionsARemover.Add(DirectCast(ctrl, PictureBox))
                End If
            End If
        Next

        ' Supprime tous les pions de la liste
        For Each pion As PictureBox In pionsARemover
            PictureBox_grille.Controls.Remove(pion)
        Next

        ' Supprime tous les pions de la grille
        PictureBox_grille.Controls.Clear()

        ' Réinitialise le tableau grille à zéro
        For i As Integer = 0 To 5
            For j As Integer = 0 To 6
                grille(i, j) = 0
            Next
        Next
    End Sub

    Private Function ChoisirPremierJoueur() As Integer
        Dim random As New Random()
        Return random.Next(1, 3) ' Retourne 1 ou 2 aléatoirement
    End Function




    Private Sub Button_commencer_Click(sender As Object, e As EventArgs) Handles Button_commencer.Click
        If TextBox_Joueur_1.Text <> "" And TextBox_joueur_2.Text <> "" And RadioButton_choisir.Checked Or RadioButton_Illimites.Checked Then
            Joueur1 = TextBox_Joueur_1.Text
            Joueur2 = TextBox_joueur_2.Text

            If RadioButton_choisir.Checked Then
                NombrePartie = TextBox_Nombre_de_partie.Text
            End If

            ' Choisir aléatoirement le premier joueur
            joueurActif = ChoisirPremierJoueur()

            TextBox_Joueur_1.Visible = False
            TextBox_joueur_2.Visible = False
            Label_joueur_1.Visible = False
            Label_joueur_2.Visible = False
            PictureBox_grille.Visible = True
            Button_commencer.Visible = False
            GroupBox_nombre_de_partie.Visible = False
            Label_Joueur_actif.Visible = True

            GroupBox_affiche_info.Visible = True
            Label_affiche_joueur_1.Text = "Joueur 1 : " + Joueur1
            Label_affiche_joueur_2.Text = "Joueur 2 : " + Joueur2

            Label_Score_Joueur_1.Text = "Score : " + ScoreJoueur_1.ToString
            Label_partie_gagne_joueur_2.Text = "Score : " + ScoreJoueur_2.ToString

            If joueurActif = 1 Then
                Label_Joueur_actif.Text = "Joueur actif : " + Joueur1
            ElseIf joueurActif = 2 Then
                Label_Joueur_actif.Text = "Joueur actif : " + Joueur2
            End If
        End If

        If PartieIllimite = True Then
            Button_stop.Visible = True
        End If


    End Sub

    Private Sub Button_accueil_Click(sender As Object, e As EventArgs) Handles Button_jouer.Click
        TextBox_Joueur_1.Visible = True
        TextBox_joueur_2.Visible = True
        Label_joueur_1.Visible = True
        Label_joueur_2.Visible = True
        Button_commencer.Visible = True
        Button_jouer.Visible = False
        GroupBox_nombre_de_partie.Visible = True
    End Sub

    Private Sub PictureBox_grille_Click(sender As Object, e As EventArgs) Handles PictureBox_grille.Click
        'Récupère les coordonnées X et Y de la pictureBox
        Dim clicGlobal As Point = PictureBox_grille.PointToClient(Cursor.Position)
        Dim clicX As Integer = clicGlobal.X
        Dim clicY As Integer = clicGlobal.Y

        ' Calculez la colonne en fonction de la position X du clic
        Dim colonneClic As Integer = clicX \ TailleDeLaColonne

        Dim rangéeVide As Integer = GetEmptyRow(colonneClic)

        If joueurActif = 1 Then
            Label_Joueur_actif.Text = "Joueur actif : " + Joueur1
        ElseIf joueurActif = 2 Then
            Label_Joueur_actif.Text = "Joueur actif : " + Joueur2
        End If

        If rangéeVide <> -1 Then
            grille(rangéeVide, colonneClic) = joueurActif
            AfficherJeton(rangéeVide, colonneClic)
            If CheckVictoire(rangéeVide, colonneClic) Then

                EffacerGrille()
                ' Réinitialiser la grille et recommencer
            ElseIf CheckMatchNul() Then
                EffacerGrille()
                ' Réinitialiser la grille et recommencer
            Else
                joueurActif = If(joueurActif = 1, 2, 1)
            End If


        End If
        If RadioButton_choisir.Checked Then
            If NombrePartieActuel > NombrePartie Then
                TextBox_Joueur_1.Visible = False
                TextBox_joueur_2.Visible = False
                Label_joueur_1.Visible = False
                Label_joueur_2.Visible = False
                PictureBox_grille.Visible = False
                Button_commencer.Visible = False
                GroupBox_nombre_de_partie.Visible = False
                Label_Joueur_actif.Visible = False
                Button_jouer.Visible = True
                GroupBox_affiche_info.Visible = False

                MessageBox.Show("Partie fini !")
            End If
        End If



    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_choisir.CheckedChanged
        TextBox_Nombre_de_partie.Visible = True
    End Sub

    Private Sub RadioButton_Illimites_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_Illimites.CheckedChanged
        PartieIllimite = True
        TextBox_Nombre_de_partie.Visible = False
    End Sub

    Private Sub Button_stop_Click(sender As Object, e As EventArgs) Handles Button_stop.Click
        TextBox_Joueur_1.Visible = False
        TextBox_joueur_2.Visible = False
        Label_joueur_1.Visible = False
        Label_joueur_2.Visible = False
        PictureBox_grille.Visible = False
        Button_commencer.Visible = False
        GroupBox_nombre_de_partie.Visible = False
        Label_Joueur_actif.Visible = False
        Button_jouer.Visible = True
        GroupBox_affiche_info.Visible = False

        EffacerGrille()
    End Sub

    Private Sub Button_regle_Click(sender As Object, e As EventArgs) Handles Button_regle.Click
        MessageBox.Show("1. Objectif du jeu : Le but du Puissance 4 est d'aligner quatre de ses propres pions de manière consécutive, horizontalement, verticalement ou en diagonale, avant l'adversaire.

2. La grille : Le jeu se déroule sur une grille verticale composée de 7 colonnes et 6 rangées, créant ainsi 42 emplacements au total.

3. Joueurs : Le jeu se joue généralement à deux joueurs. Chaque joueur a une couleur spécifique, souvent le jaune et le rouge.

4. Tour de jeu : Les joueurs jouent à tour de rôle en plaçant un de leurs pions de leur couleur dans l'une des colonnes de la grille. Le pion tombe ensuite en bas de la colonne jusqu'à ce qu'il atteigne la première case vide ou le bas de la colonne.

5. Alignement : Le joueur qui parvient à aligner quatre de ses pions de manière consécutive dans n'importe quelle direction (horizontale, verticale ou diagonale) remporte la partie.

6. Match nul : Si la grille est remplie et aucun joueur n'a aligné quatre pions, la partie est déclarée nulle.

7. Fin de partie : La partie se termine dès qu'un joueur aligne quatre pions ou lorsque la partie est déclarée nulle.

8. Parties multiples : Les joueurs peuvent choisir de jouer plusieurs parties, et le joueur avec le plus grand nombre de victoires à la fin des parties déterminées est déclaré vainqueur.

9. Stratégie : Puissance 4 implique une stratégie pour bloquer les tentatives de l'adversaire tout en travaillant à ses propres alignements. Les joueurs doivent anticiper les mouvements de l'adversaire pour maximiser leurs chances de gagner.")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
    End Sub
End Class
