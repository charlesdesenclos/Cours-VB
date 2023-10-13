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
        Me.TextBox_nbr_joueur_1 = New System.Windows.Forms.TextBox()
        Me.Nombre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_valider_joueur1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label_resul = New System.Windows.Forms.Label()
        Me.Label_test = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label_nbr_coup = New System.Windows.Forms.Label()
        Me.GroupBox_difficult = New System.Windows.Forms.GroupBox()
        Me.RadioButton_niv4 = New System.Windows.Forms.RadioButton()
        Me.RadioButton_niv3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton_niv2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton_niv1 = New System.Windows.Forms.RadioButton()
        Me.Button_quitter = New System.Windows.Forms.Button()
        Me.Button_recommencer = New System.Windows.Forms.Button()
        Me.GroupBox_difficult.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox_nbr_joueur_1
        '
        Me.TextBox_nbr_joueur_1.Location = New System.Drawing.Point(425, 187)
        Me.TextBox_nbr_joueur_1.Multiline = True
        Me.TextBox_nbr_joueur_1.Name = "TextBox_nbr_joueur_1"
        Me.TextBox_nbr_joueur_1.Size = New System.Drawing.Size(209, 55)
        Me.TextBox_nbr_joueur_1.TabIndex = 0
        '
        'Nombre
        '
        Me.Nombre.AutoSize = True
        Me.Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre.Location = New System.Drawing.Point(35, 196)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(321, 25)
        Me.Nombre.TabIndex = 2
        Me.Nombre.Text = "Nombre à saisir entre (1 à 100) :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(396, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 55)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Joueur "
        '
        'Button_valider_joueur1
        '
        Me.Button_valider_joueur1.BackColor = System.Drawing.Color.IndianRed
        Me.Button_valider_joueur1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_valider_joueur1.Location = New System.Drawing.Point(714, 184)
        Me.Button_valider_joueur1.Name = "Button_valider_joueur1"
        Me.Button_valider_joueur1.Size = New System.Drawing.Size(228, 57)
        Me.Button_valider_joueur1.TabIndex = 7
        Me.Button_valider_joueur1.Text = "Valider"
        Me.Button_valider_joueur1.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBox1.Location = New System.Drawing.Point(0, 280)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(970, 10)
        Me.TextBox1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(148, 306)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(208, 55)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Résultat"
        '
        'Label_resul
        '
        Me.Label_resul.AutoSize = True
        Me.Label_resul.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label_resul.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_resul.Location = New System.Drawing.Point(103, 423)
        Me.Label_resul.Name = "Label_resul"
        Me.Label_resul.Size = New System.Drawing.Size(0, 25)
        Me.Label_resul.TabIndex = 9
        '
        'Label_test
        '
        Me.Label_test.AutoSize = True
        Me.Label_test.Location = New System.Drawing.Point(40, 386)
        Me.Label_test.Name = "Label_test"
        Me.Label_test.Size = New System.Drawing.Size(0, 13)
        Me.Label_test.TabIndex = 10
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBox2.Location = New System.Drawing.Point(487, 280)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(10, 343)
        Me.TextBox2.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(533, 306)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(409, 55)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Nombre  de coup"
        '
        'Label_nbr_coup
        '
        Me.Label_nbr_coup.AutoSize = True
        Me.Label_nbr_coup.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_nbr_coup.Location = New System.Drawing.Point(524, 419)
        Me.Label_nbr_coup.Name = "Label_nbr_coup"
        Me.Label_nbr_coup.Size = New System.Drawing.Size(0, 25)
        Me.Label_nbr_coup.TabIndex = 14
        '
        'GroupBox_difficult
        '
        Me.GroupBox_difficult.Controls.Add(Me.RadioButton_niv4)
        Me.GroupBox_difficult.Controls.Add(Me.RadioButton_niv3)
        Me.GroupBox_difficult.Controls.Add(Me.RadioButton_niv2)
        Me.GroupBox_difficult.Controls.Add(Me.RadioButton_niv1)
        Me.GroupBox_difficult.Location = New System.Drawing.Point(18, 15)
        Me.GroupBox_difficult.Name = "GroupBox_difficult"
        Me.GroupBox_difficult.Size = New System.Drawing.Size(150, 131)
        Me.GroupBox_difficult.TabIndex = 15
        Me.GroupBox_difficult.TabStop = False
        Me.GroupBox_difficult.Text = "Difficulté :"
        '
        'RadioButton_niv4
        '
        Me.RadioButton_niv4.AutoSize = True
        Me.RadioButton_niv4.Location = New System.Drawing.Point(22, 88)
        Me.RadioButton_niv4.Name = "RadioButton_niv4"
        Me.RadioButton_niv4.Size = New System.Drawing.Size(68, 17)
        Me.RadioButton_niv4.TabIndex = 3
        Me.RadioButton_niv4.TabStop = True
        Me.RadioButton_niv4.Text = "Niveau 4"
        Me.RadioButton_niv4.UseVisualStyleBackColor = True
        '
        'RadioButton_niv3
        '
        Me.RadioButton_niv3.AutoSize = True
        Me.RadioButton_niv3.Location = New System.Drawing.Point(22, 65)
        Me.RadioButton_niv3.Name = "RadioButton_niv3"
        Me.RadioButton_niv3.Size = New System.Drawing.Size(68, 17)
        Me.RadioButton_niv3.TabIndex = 2
        Me.RadioButton_niv3.TabStop = True
        Me.RadioButton_niv3.Text = "Niveau 3"
        Me.RadioButton_niv3.UseVisualStyleBackColor = True
        '
        'RadioButton_niv2
        '
        Me.RadioButton_niv2.AutoSize = True
        Me.RadioButton_niv2.Location = New System.Drawing.Point(22, 42)
        Me.RadioButton_niv2.Name = "RadioButton_niv2"
        Me.RadioButton_niv2.Size = New System.Drawing.Size(68, 17)
        Me.RadioButton_niv2.TabIndex = 1
        Me.RadioButton_niv2.TabStop = True
        Me.RadioButton_niv2.Text = "Niveau 2"
        Me.RadioButton_niv2.UseVisualStyleBackColor = True
        '
        'RadioButton_niv1
        '
        Me.RadioButton_niv1.AutoSize = True
        Me.RadioButton_niv1.Location = New System.Drawing.Point(22, 19)
        Me.RadioButton_niv1.Name = "RadioButton_niv1"
        Me.RadioButton_niv1.Size = New System.Drawing.Size(68, 17)
        Me.RadioButton_niv1.TabIndex = 0
        Me.RadioButton_niv1.TabStop = True
        Me.RadioButton_niv1.Text = "Niveau 1"
        Me.RadioButton_niv1.UseVisualStyleBackColor = True
        '
        'Button_quitter
        '
        Me.Button_quitter.BackColor = System.Drawing.Color.OrangeRed
        Me.Button_quitter.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_quitter.Location = New System.Drawing.Point(742, 12)
        Me.Button_quitter.Name = "Button_quitter"
        Me.Button_quitter.Size = New System.Drawing.Size(228, 57)
        Me.Button_quitter.TabIndex = 16
        Me.Button_quitter.Text = "Quitter"
        Me.Button_quitter.UseVisualStyleBackColor = False
        '
        'Button_recommencer
        '
        Me.Button_recommencer.BackColor = System.Drawing.Color.Turquoise
        Me.Button_recommencer.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_recommencer.Location = New System.Drawing.Point(742, 75)
        Me.Button_recommencer.Name = "Button_recommencer"
        Me.Button_recommencer.Size = New System.Drawing.Size(228, 57)
        Me.Button_recommencer.TabIndex = 17
        Me.Button_recommencer.Text = "Recommencer"
        Me.Button_recommencer.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(970, 620)
        Me.Controls.Add(Me.Button_recommencer)
        Me.Controls.Add(Me.Button_quitter)
        Me.Controls.Add(Me.GroupBox_difficult)
        Me.Controls.Add(Me.Label_nbr_coup)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label_test)
        Me.Controls.Add(Me.Label_resul)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button_valider_joueur1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Nombre)
        Me.Controls.Add(Me.TextBox_nbr_joueur_1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox_difficult.ResumeLayout(False)
        Me.GroupBox_difficult.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox_nbr_joueur_1 As TextBox
    Friend WithEvents Nombre As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button_valider_joueur1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label_resul As Label
    Friend WithEvents Label_test As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label_nbr_coup As Label
    Friend WithEvents GroupBox_difficult As GroupBox
    Friend WithEvents RadioButton_niv4 As RadioButton
    Friend WithEvents RadioButton_niv3 As RadioButton
    Friend WithEvents RadioButton_niv2 As RadioButton
    Friend WithEvents RadioButton_niv1 As RadioButton
    Friend WithEvents Button_quitter As Button
    Friend WithEvents Button_recommencer As Button
End Class
