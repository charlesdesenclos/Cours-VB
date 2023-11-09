<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button_commencer = New System.Windows.Forms.Button()
        Me.TextBox_Joueur_1 = New System.Windows.Forms.TextBox()
        Me.TextBox_joueur_2 = New System.Windows.Forms.TextBox()
        Me.Label_joueur_1 = New System.Windows.Forms.Label()
        Me.Label_joueur_2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label_affiche_joueur_1 = New System.Windows.Forms.Label()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.GroupBox_affiche_info = New System.Windows.Forms.GroupBox()
        Me.Button_regle = New System.Windows.Forms.Button()
        Me.Button_stop = New System.Windows.Forms.Button()
        Me.Label_partie_gagne_joueur_2 = New System.Windows.Forms.Label()
        Me.Label_Score_Joueur_1 = New System.Windows.Forms.Label()
        Me.Label_affiche_joueur_2 = New System.Windows.Forms.Label()
        Me.Button_jouer = New System.Windows.Forms.Button()
        Me.RadioButton_Illimites = New System.Windows.Forms.RadioButton()
        Me.GroupBox_nombre_de_partie = New System.Windows.Forms.GroupBox()
        Me.TextBox_Nombre_de_partie = New System.Windows.Forms.TextBox()
        Me.RadioButton_choisir = New System.Windows.Forms.RadioButton()
        Me.Label_Joueur_actif = New System.Windows.Forms.Label()
        Me.PictureBox_puissance_4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_grille = New System.Windows.Forms.PictureBox()
        Me.PictureBox_joueur_1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox_joueur_2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox_affiche_info.SuspendLayout()
        Me.GroupBox_nombre_de_partie.SuspendLayout()
        CType(Me.PictureBox_puissance_4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_grille, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_joueur_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_joueur_2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_commencer
        '
        Me.Button_commencer.Font = New System.Drawing.Font("Gameplay", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_commencer.Location = New System.Drawing.Point(575, 453)
        Me.Button_commencer.Name = "Button_commencer"
        Me.Button_commencer.Size = New System.Drawing.Size(284, 96)
        Me.Button_commencer.TabIndex = 0
        Me.Button_commencer.Text = "Commencer"
        Me.Button_commencer.UseVisualStyleBackColor = True
        Me.Button_commencer.Visible = False
        '
        'TextBox_Joueur_1
        '
        Me.TextBox_Joueur_1.Font = New System.Drawing.Font("Gameplay", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Joueur_1.Location = New System.Drawing.Point(375, 335)
        Me.TextBox_Joueur_1.Name = "TextBox_Joueur_1"
        Me.TextBox_Joueur_1.Size = New System.Drawing.Size(166, 30)
        Me.TextBox_Joueur_1.TabIndex = 1
        Me.TextBox_Joueur_1.Visible = False
        '
        'TextBox_joueur_2
        '
        Me.TextBox_joueur_2.Font = New System.Drawing.Font("Gameplay", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_joueur_2.Location = New System.Drawing.Point(819, 337)
        Me.TextBox_joueur_2.Name = "TextBox_joueur_2"
        Me.TextBox_joueur_2.Size = New System.Drawing.Size(166, 30)
        Me.TextBox_joueur_2.TabIndex = 2
        Me.TextBox_joueur_2.Visible = False
        '
        'Label_joueur_1
        '
        Me.Label_joueur_1.AutoSize = True
        Me.Label_joueur_1.Font = New System.Drawing.Font("Gameplay", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_joueur_1.Location = New System.Drawing.Point(369, 251)
        Me.Label_joueur_1.Name = "Label_joueur_1"
        Me.Label_joueur_1.Size = New System.Drawing.Size(175, 33)
        Me.Label_joueur_1.TabIndex = 4
        Me.Label_joueur_1.Text = "Joueur 1 :"
        Me.Label_joueur_1.Visible = False
        '
        'Label_joueur_2
        '
        Me.Label_joueur_2.AutoSize = True
        Me.Label_joueur_2.Font = New System.Drawing.Font("Gameplay", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_joueur_2.Location = New System.Drawing.Point(833, 251)
        Me.Label_joueur_2.Name = "Label_joueur_2"
        Me.Label_joueur_2.Size = New System.Drawing.Size(184, 33)
        Me.Label_joueur_2.TabIndex = 5
        Me.Label_joueur_2.Text = "Joueur 2 :"
        Me.Label_joueur_2.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Gameplay", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(520, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(500, 76)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Puissance 4"
        '
        'Label_affiche_joueur_1
        '
        Me.Label_affiche_joueur_1.AutoSize = True
        Me.Label_affiche_joueur_1.Font = New System.Drawing.Font("Gameplay", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_affiche_joueur_1.Location = New System.Drawing.Point(9, 58)
        Me.Label_affiche_joueur_1.Name = "Label_affiche_joueur_1"
        Me.Label_affiche_joueur_1.Size = New System.Drawing.Size(136, 26)
        Me.Label_affiche_joueur_1.TabIndex = 9
        Me.Label_affiche_joueur_1.Text = "Joueur 1 :"
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 974)
        Me.Splitter1.TabIndex = 10
        Me.Splitter1.TabStop = False
        '
        'GroupBox_affiche_info
        '
        Me.GroupBox_affiche_info.Controls.Add(Me.PictureBox_joueur_2)
        Me.GroupBox_affiche_info.Controls.Add(Me.PictureBox_joueur_1)
        Me.GroupBox_affiche_info.Controls.Add(Me.Button_regle)
        Me.GroupBox_affiche_info.Controls.Add(Me.Button_stop)
        Me.GroupBox_affiche_info.Controls.Add(Me.Label_partie_gagne_joueur_2)
        Me.GroupBox_affiche_info.Controls.Add(Me.Label_Score_Joueur_1)
        Me.GroupBox_affiche_info.Controls.Add(Me.Label_affiche_joueur_2)
        Me.GroupBox_affiche_info.Controls.Add(Me.Label_affiche_joueur_1)
        Me.GroupBox_affiche_info.Font = New System.Drawing.Font("Gameplay", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_affiche_info.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox_affiche_info.Name = "GroupBox_affiche_info"
        Me.GroupBox_affiche_info.Size = New System.Drawing.Size(302, 974)
        Me.GroupBox_affiche_info.TabIndex = 11
        Me.GroupBox_affiche_info.TabStop = False
        Me.GroupBox_affiche_info.Text = "Information"
        Me.GroupBox_affiche_info.Visible = False
        '
        'Button_regle
        '
        Me.Button_regle.Location = New System.Drawing.Point(73, 865)
        Me.Button_regle.Name = "Button_regle"
        Me.Button_regle.Size = New System.Drawing.Size(134, 34)
        Me.Button_regle.TabIndex = 14
        Me.Button_regle.Text = "Regle"
        Me.Button_regle.UseVisualStyleBackColor = True
        '
        'Button_stop
        '
        Me.Button_stop.Location = New System.Drawing.Point(73, 922)
        Me.Button_stop.Name = "Button_stop"
        Me.Button_stop.Size = New System.Drawing.Size(134, 40)
        Me.Button_stop.TabIndex = 13
        Me.Button_stop.Text = "STOP"
        Me.Button_stop.UseVisualStyleBackColor = True
        Me.Button_stop.Visible = False
        '
        'Label_partie_gagne_joueur_2
        '
        Me.Label_partie_gagne_joueur_2.AutoSize = True
        Me.Label_partie_gagne_joueur_2.Font = New System.Drawing.Font("Gameplay", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_partie_gagne_joueur_2.Location = New System.Drawing.Point(12, 512)
        Me.Label_partie_gagne_joueur_2.Name = "Label_partie_gagne_joueur_2"
        Me.Label_partie_gagne_joueur_2.Size = New System.Drawing.Size(178, 24)
        Me.Label_partie_gagne_joueur_2.TabIndex = 12
        Me.Label_partie_gagne_joueur_2.Text = "Partie gagne :"
        '
        'Label_Score_Joueur_1
        '
        Me.Label_Score_Joueur_1.AutoSize = True
        Me.Label_Score_Joueur_1.Font = New System.Drawing.Font("Gameplay", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Score_Joueur_1.ImageAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.Label_Score_Joueur_1.Location = New System.Drawing.Point(12, 221)
        Me.Label_Score_Joueur_1.Name = "Label_Score_Joueur_1"
        Me.Label_Score_Joueur_1.Size = New System.Drawing.Size(178, 24)
        Me.Label_Score_Joueur_1.TabIndex = 11
        Me.Label_Score_Joueur_1.Text = "Partie gagne :"
        '
        'Label_affiche_joueur_2
        '
        Me.Label_affiche_joueur_2.AutoSize = True
        Me.Label_affiche_joueur_2.Font = New System.Drawing.Font("Gameplay", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_affiche_joueur_2.Location = New System.Drawing.Point(10, 344)
        Me.Label_affiche_joueur_2.Name = "Label_affiche_joueur_2"
        Me.Label_affiche_joueur_2.Size = New System.Drawing.Size(136, 26)
        Me.Label_affiche_joueur_2.TabIndex = 10
        Me.Label_affiche_joueur_2.Text = "Joueur 1 :"
        '
        'Button_jouer
        '
        Me.Button_jouer.Font = New System.Drawing.Font("Gameplay", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_jouer.Location = New System.Drawing.Point(479, 396)
        Me.Button_jouer.Name = "Button_jouer"
        Me.Button_jouer.Size = New System.Drawing.Size(439, 150)
        Me.Button_jouer.TabIndex = 12
        Me.Button_jouer.Text = "Jouer"
        Me.Button_jouer.UseVisualStyleBackColor = True
        '
        'RadioButton_Illimites
        '
        Me.RadioButton_Illimites.AutoSize = True
        Me.RadioButton_Illimites.Font = New System.Drawing.Font("Gameplay", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_Illimites.Location = New System.Drawing.Point(6, 49)
        Me.RadioButton_Illimites.Name = "RadioButton_Illimites"
        Me.RadioButton_Illimites.Size = New System.Drawing.Size(113, 23)
        Me.RadioButton_Illimites.TabIndex = 14
        Me.RadioButton_Illimites.TabStop = True
        Me.RadioButton_Illimites.Text = "Illimites"
        Me.RadioButton_Illimites.UseVisualStyleBackColor = True
        '
        'GroupBox_nombre_de_partie
        '
        Me.GroupBox_nombre_de_partie.Controls.Add(Me.TextBox_Nombre_de_partie)
        Me.GroupBox_nombre_de_partie.Controls.Add(Me.RadioButton_choisir)
        Me.GroupBox_nombre_de_partie.Controls.Add(Me.RadioButton_Illimites)
        Me.GroupBox_nombre_de_partie.Font = New System.Drawing.Font("Gameplay", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox_nombre_de_partie.Location = New System.Drawing.Point(1073, 266)
        Me.GroupBox_nombre_de_partie.Name = "GroupBox_nombre_de_partie"
        Me.GroupBox_nombre_de_partie.Size = New System.Drawing.Size(269, 201)
        Me.GroupBox_nombre_de_partie.TabIndex = 15
        Me.GroupBox_nombre_de_partie.TabStop = False
        Me.GroupBox_nombre_de_partie.Text = "NOMBRE DE PARTIE :"
        Me.GroupBox_nombre_de_partie.Visible = False
        '
        'TextBox_Nombre_de_partie
        '
        Me.TextBox_Nombre_de_partie.Font = New System.Drawing.Font("Gameplay", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Nombre_de_partie.Location = New System.Drawing.Point(49, 130)
        Me.TextBox_Nombre_de_partie.Name = "TextBox_Nombre_de_partie"
        Me.TextBox_Nombre_de_partie.Size = New System.Drawing.Size(166, 30)
        Me.TextBox_Nombre_de_partie.TabIndex = 16
        Me.TextBox_Nombre_de_partie.Visible = False
        '
        'RadioButton_choisir
        '
        Me.RadioButton_choisir.AutoSize = True
        Me.RadioButton_choisir.Font = New System.Drawing.Font("Gameplay", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton_choisir.Location = New System.Drawing.Point(6, 78)
        Me.RadioButton_choisir.Name = "RadioButton_choisir"
        Me.RadioButton_choisir.Size = New System.Drawing.Size(95, 23)
        Me.RadioButton_choisir.TabIndex = 15
        Me.RadioButton_choisir.TabStop = True
        Me.RadioButton_choisir.Text = "Choisir"
        Me.RadioButton_choisir.UseVisualStyleBackColor = True
        '
        'Label_Joueur_actif
        '
        Me.Label_Joueur_actif.AutoSize = True
        Me.Label_Joueur_actif.Font = New System.Drawing.Font("Gameplay", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Joueur_actif.Location = New System.Drawing.Point(302, 199)
        Me.Label_Joueur_actif.Name = "Label_Joueur_actif"
        Me.Label_Joueur_actif.Size = New System.Drawing.Size(267, 35)
        Me.Label_Joueur_actif.TabIndex = 15
        Me.Label_Joueur_actif.Text = "Joueur actif :"
        Me.Label_Joueur_actif.Visible = False
        '
        'PictureBox_puissance_4
        '
        Me.PictureBox_puissance_4.Image = Global.Projet_Puissance_4.My.Resources.Resources.Titre
        Me.PictureBox_puissance_4.Location = New System.Drawing.Point(423, 0)
        Me.PictureBox_puissance_4.Name = "PictureBox_puissance_4"
        Me.PictureBox_puissance_4.Size = New System.Drawing.Size(646, 220)
        Me.PictureBox_puissance_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox_puissance_4.TabIndex = 16
        Me.PictureBox_puissance_4.TabStop = False
        '
        'PictureBox_grille
        '
        Me.PictureBox_grille.Image = Global.Projet_Puissance_4.My.Resources.Resources.Grille_Puissance
        Me.PictureBox_grille.Location = New System.Drawing.Point(308, 246)
        Me.PictureBox_grille.Name = "PictureBox_grille"
        Me.PictureBox_grille.Size = New System.Drawing.Size(1141, 728)
        Me.PictureBox_grille.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_grille.TabIndex = 7
        Me.PictureBox_grille.TabStop = False
        Me.PictureBox_grille.Visible = False
        '
        'PictureBox_joueur_1
        '
        Me.PictureBox_joueur_1.Image = Global.Projet_Puissance_4.My.Resources.Resources.Pion_Jaune
        Me.PictureBox_joueur_1.Location = New System.Drawing.Point(15, 104)
        Me.PictureBox_joueur_1.Name = "PictureBox_joueur_1"
        Me.PictureBox_joueur_1.Size = New System.Drawing.Size(142, 103)
        Me.PictureBox_joueur_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_joueur_1.TabIndex = 15
        Me.PictureBox_joueur_1.TabStop = False
        '
        'PictureBox_joueur_2
        '
        Me.PictureBox_joueur_2.Image = Global.Projet_Puissance_4.My.Resources.Resources.Pion_Rouge
        Me.PictureBox_joueur_2.Location = New System.Drawing.Point(16, 396)
        Me.PictureBox_joueur_2.Name = "PictureBox_joueur_2"
        Me.PictureBox_joueur_2.Size = New System.Drawing.Size(142, 103)
        Me.PictureBox_joueur_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_joueur_2.TabIndex = 16
        Me.PictureBox_joueur_2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1448, 974)
        Me.Controls.Add(Me.Label_Joueur_actif)
        Me.Controls.Add(Me.PictureBox_puissance_4)
        Me.Controls.Add(Me.PictureBox_grille)
        Me.Controls.Add(Me.Button_jouer)
        Me.Controls.Add(Me.GroupBox_affiche_info)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label_joueur_2)
        Me.Controls.Add(Me.Label_joueur_1)
        Me.Controls.Add(Me.TextBox_joueur_2)
        Me.Controls.Add(Me.TextBox_Joueur_1)
        Me.Controls.Add(Me.Button_commencer)
        Me.Controls.Add(Me.GroupBox_nombre_de_partie)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "Puissance 4"
        Me.GroupBox_affiche_info.ResumeLayout(False)
        Me.GroupBox_affiche_info.PerformLayout()
        Me.GroupBox_nombre_de_partie.ResumeLayout(False)
        Me.GroupBox_nombre_de_partie.PerformLayout()
        CType(Me.PictureBox_puissance_4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_grille, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_joueur_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_joueur_2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_commencer As Button
    Friend WithEvents TextBox_Joueur_1 As TextBox
    Friend WithEvents TextBox_joueur_2 As TextBox
    Friend WithEvents Label_joueur_1 As Label
    Friend WithEvents Label_joueur_2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label_affiche_joueur_1 As Label
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents Label_affiche_joueur_2 As Label
    Friend WithEvents Label_partie_gagne_joueur_2 As Label
    Friend WithEvents Label_Score_Joueur_1 As Label
    Friend WithEvents PictureBox_grille As PictureBox
    Public WithEvents GroupBox_affiche_info As GroupBox
    Friend WithEvents Button_jouer As Button
    Friend WithEvents RadioButton_Illimites As RadioButton
    Friend WithEvents GroupBox_nombre_de_partie As GroupBox
    Friend WithEvents RadioButton_choisir As RadioButton
    Friend WithEvents TextBox_Nombre_de_partie As TextBox
    Friend WithEvents Button_stop As Button
    Friend WithEvents Button_regle As Button
    Friend WithEvents Label_Joueur_actif As Label
    Friend WithEvents PictureBox_puissance_4 As PictureBox
    Friend WithEvents PictureBox_joueur_2 As PictureBox
    Friend WithEvents PictureBox_joueur_1 As PictureBox
End Class
