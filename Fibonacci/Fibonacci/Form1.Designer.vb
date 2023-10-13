<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBox_nombre = New System.Windows.Forms.TextBox()
        Me.Button_Fibonacci = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label_Result = New System.Windows.Forms.Label()
        Me.Label_nombre = New System.Windows.Forms.Label()
        Me.Label_nbr_appele = New System.Windows.Forms.Label()
        Me.ListBox_personnage = New System.Windows.Forms.ListBox()
        Me.Button_ajout = New System.Windows.Forms.Button()
        Me.Button_enlever = New System.Windows.Forms.Button()
        Me.Button_RAZ = New System.Windows.Forms.Button()
        Me.TextBox_ajout_personnage = New System.Windows.Forms.TextBox()
        Me.Label_compteur_list = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CheckedListBox_tintin = New System.Windows.Forms.CheckedListBox()
        Me.Button_RAZ_CheckBox = New System.Windows.Forms.Button()
        Me.Button_enlever_checkbox = New System.Windows.Forms.Button()
        Me.Button_Ajout_CheckBox = New System.Windows.Forms.Button()
        Me.TextBox_ajout_checkBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TextBox_nombre
        '
        Me.TextBox_nombre.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_nombre.Location = New System.Drawing.Point(135, 185)
        Me.TextBox_nombre.Name = "TextBox_nombre"
        Me.TextBox_nombre.Size = New System.Drawing.Size(175, 31)
        Me.TextBox_nombre.TabIndex = 0
        '
        'Button_Fibonacci
        '
        Me.Button_Fibonacci.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Fibonacci.Location = New System.Drawing.Point(443, 179)
        Me.Button_Fibonacci.Name = "Button_Fibonacci"
        Me.Button_Fibonacci.Size = New System.Drawing.Size(139, 42)
        Me.Button_Fibonacci.TabIndex = 1
        Me.Button_Fibonacci.Text = "Fibonacci"
        Me.Button_Fibonacci.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(135, 312)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Resultat"
        '
        'Label_Result
        '
        Me.Label_Result.AutoSize = True
        Me.Label_Result.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Result.Location = New System.Drawing.Point(288, 312)
        Me.Label_Result.Name = "Label_Result"
        Me.Label_Result.Size = New System.Drawing.Size(0, 25)
        Me.Label_Result.TabIndex = 3
        '
        'Label_nombre
        '
        Me.Label_nombre.AutoSize = True
        Me.Label_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_nombre.Location = New System.Drawing.Point(140, 393)
        Me.Label_nombre.Name = "Label_nombre"
        Me.Label_nombre.Size = New System.Drawing.Size(174, 25)
        Me.Label_nombre.TabIndex = 4
        Me.Label_nombre.Text = "Nombre d'appele"
        '
        'Label_nbr_appele
        '
        Me.Label_nbr_appele.AutoSize = True
        Me.Label_nbr_appele.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_nbr_appele.Location = New System.Drawing.Point(349, 393)
        Me.Label_nbr_appele.Name = "Label_nbr_appele"
        Me.Label_nbr_appele.Size = New System.Drawing.Size(0, 25)
        Me.Label_nbr_appele.TabIndex = 5
        '
        'ListBox_personnage
        '
        Me.ListBox_personnage.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox_personnage.FormattingEnabled = True
        Me.ListBox_personnage.ItemHeight = 25
        Me.ListBox_personnage.Items.AddRange(New Object() {"Perso 1", "Perso 2", "Perso 3", "Perso 4"})
        Me.ListBox_personnage.Location = New System.Drawing.Point(664, 12)
        Me.ListBox_personnage.Name = "ListBox_personnage"
        Me.ListBox_personnage.Size = New System.Drawing.Size(338, 79)
        Me.ListBox_personnage.TabIndex = 6
        '
        'Button_ajout
        '
        Me.Button_ajout.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_ajout.Location = New System.Drawing.Point(664, 115)
        Me.Button_ajout.Name = "Button_ajout"
        Me.Button_ajout.Size = New System.Drawing.Size(130, 41)
        Me.Button_ajout.TabIndex = 7
        Me.Button_ajout.Text = "Ajout"
        Me.Button_ajout.UseVisualStyleBackColor = True
        '
        'Button_enlever
        '
        Me.Button_enlever.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_enlever.Location = New System.Drawing.Point(872, 115)
        Me.Button_enlever.Name = "Button_enlever"
        Me.Button_enlever.Size = New System.Drawing.Size(130, 41)
        Me.Button_enlever.TabIndex = 8
        Me.Button_enlever.Text = "Enlever"
        Me.Button_enlever.UseVisualStyleBackColor = True
        '
        'Button_RAZ
        '
        Me.Button_RAZ.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_RAZ.Location = New System.Drawing.Point(664, 199)
        Me.Button_RAZ.Name = "Button_RAZ"
        Me.Button_RAZ.Size = New System.Drawing.Size(130, 41)
        Me.Button_RAZ.TabIndex = 9
        Me.Button_RAZ.Text = "RAZ"
        Me.Button_RAZ.UseVisualStyleBackColor = True
        '
        'TextBox_ajout_personnage
        '
        Me.TextBox_ajout_personnage.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_ajout_personnage.Location = New System.Drawing.Point(664, 292)
        Me.TextBox_ajout_personnage.Name = "TextBox_ajout_personnage"
        Me.TextBox_ajout_personnage.Size = New System.Drawing.Size(213, 31)
        Me.TextBox_ajout_personnage.TabIndex = 10
        '
        'Label_compteur_list
        '
        Me.Label_compteur_list.AutoSize = True
        Me.Label_compteur_list.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_compteur_list.Location = New System.Drawing.Point(524, 53)
        Me.Label_compteur_list.Name = "Label_compteur_list"
        Me.Label_compteur_list.Size = New System.Drawing.Size(0, 25)
        Me.Label_compteur_list.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(120, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(365, 25)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Nombre dans d'élèment dans la liste "
        '
        'CheckedListBox_tintin
        '
        Me.CheckedListBox_tintin.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckedListBox_tintin.FormattingEnabled = True
        Me.CheckedListBox_tintin.Items.AddRange(New Object() {"Tintin", "Milou", "Haddock", "Dupont", "Dupond", "Castafiore"})
        Me.CheckedListBox_tintin.Location = New System.Drawing.Point(1167, 12)
        Me.CheckedListBox_tintin.Name = "CheckedListBox_tintin"
        Me.CheckedListBox_tintin.Size = New System.Drawing.Size(164, 82)
        Me.CheckedListBox_tintin.TabIndex = 13
        '
        'Button_RAZ_CheckBox
        '
        Me.Button_RAZ_CheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_RAZ_CheckBox.Location = New System.Drawing.Point(1077, 228)
        Me.Button_RAZ_CheckBox.Name = "Button_RAZ_CheckBox"
        Me.Button_RAZ_CheckBox.Size = New System.Drawing.Size(130, 41)
        Me.Button_RAZ_CheckBox.TabIndex = 16
        Me.Button_RAZ_CheckBox.Text = "RAZ"
        Me.Button_RAZ_CheckBox.UseVisualStyleBackColor = True
        '
        'Button_enlever_checkbox
        '
        Me.Button_enlever_checkbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_enlever_checkbox.Location = New System.Drawing.Point(1285, 144)
        Me.Button_enlever_checkbox.Name = "Button_enlever_checkbox"
        Me.Button_enlever_checkbox.Size = New System.Drawing.Size(130, 41)
        Me.Button_enlever_checkbox.TabIndex = 15
        Me.Button_enlever_checkbox.Text = "Enlever"
        Me.Button_enlever_checkbox.UseVisualStyleBackColor = True
        '
        'Button_Ajout_CheckBox
        '
        Me.Button_Ajout_CheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Ajout_CheckBox.Location = New System.Drawing.Point(1077, 144)
        Me.Button_Ajout_CheckBox.Name = "Button_Ajout_CheckBox"
        Me.Button_Ajout_CheckBox.Size = New System.Drawing.Size(130, 41)
        Me.Button_Ajout_CheckBox.TabIndex = 14
        Me.Button_Ajout_CheckBox.Text = "Ajout"
        Me.Button_Ajout_CheckBox.UseVisualStyleBackColor = True
        '
        'TextBox_ajout_checkBox
        '
        Me.TextBox_ajout_checkBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_ajout_checkBox.Location = New System.Drawing.Point(1077, 292)
        Me.TextBox_ajout_checkBox.Name = "TextBox_ajout_checkBox"
        Me.TextBox_ajout_checkBox.Size = New System.Drawing.Size(213, 31)
        Me.TextBox_ajout_checkBox.TabIndex = 17
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1476, 444)
        Me.Controls.Add(Me.TextBox_ajout_checkBox)
        Me.Controls.Add(Me.Button_RAZ_CheckBox)
        Me.Controls.Add(Me.Button_enlever_checkbox)
        Me.Controls.Add(Me.Button_Ajout_CheckBox)
        Me.Controls.Add(Me.CheckedListBox_tintin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label_compteur_list)
        Me.Controls.Add(Me.TextBox_ajout_personnage)
        Me.Controls.Add(Me.Button_RAZ)
        Me.Controls.Add(Me.Button_enlever)
        Me.Controls.Add(Me.Button_ajout)
        Me.Controls.Add(Me.ListBox_personnage)
        Me.Controls.Add(Me.Label_nbr_appele)
        Me.Controls.Add(Me.Label_nombre)
        Me.Controls.Add(Me.Label_Result)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button_Fibonacci)
        Me.Controls.Add(Me.TextBox_nombre)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox_nombre As TextBox
    Friend WithEvents Button_Fibonacci As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label_Result As Label
    Friend WithEvents Label_nombre As Label
    Friend WithEvents Label_nbr_appele As Label
    Friend WithEvents ListBox_personnage As ListBox
    Friend WithEvents Button_ajout As Button
    Friend WithEvents Button_enlever As Button
    Friend WithEvents Button_RAZ As Button
    Friend WithEvents TextBox_ajout_personnage As TextBox
    Friend WithEvents Label_compteur_list As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents CheckedListBox_tintin As CheckedListBox
    Friend WithEvents Button_RAZ_CheckBox As Button
    Friend WithEvents Button_enlever_checkbox As Button
    Friend WithEvents Button_Ajout_CheckBox As Button
    Friend WithEvents TextBox_ajout_checkBox As TextBox
End Class
