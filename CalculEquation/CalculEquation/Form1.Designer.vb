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
        Me.LabelTitre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_A = New System.Windows.Forms.TextBox()
        Me.TextBox_B = New System.Windows.Forms.TextBox()
        Me.TextBox_C = New System.Windows.Forms.TextBox()
        Me.Button_Valider = New System.Windows.Forms.Button()
        Me.Label_Resultat = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label_Resultat2 = New System.Windows.Forms.Label()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label_X1 = New System.Windows.Forms.Label()
        Me.Label_X2 = New System.Windows.Forms.Label()
        Me.Label_X0 = New System.Windows.Forms.Label()
        Me.Label_REsult0 = New System.Windows.Forms.Label()
        Me.Label_Delta = New System.Windows.Forms.Label()
        Me.Label_Result_Delta = New System.Windows.Forms.Label()
        Me.Label_Solution = New System.Windows.Forms.Label()
        Me.Label_Canonique = New System.Windows.Forms.Label()
        Me.Label_Result_Canonique = New System.Windows.Forms.Label()
        Me.Button_Reset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelTitre
        '
        Me.LabelTitre.AutoSize = True
        Me.LabelTitre.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTitre.Location = New System.Drawing.Point(218, 40)
        Me.LabelTitre.Name = "LabelTitre"
        Me.LabelTitre.Size = New System.Drawing.Size(556, 33)
        Me.LabelTitre.TabIndex = 0
        Me.LabelTitre.Text = "Résoudre une équation du second degré :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(330, 178)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = " x^2 +"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(512, 178)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "x +"
        '
        'TextBox_A
        '
        Me.TextBox_A.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_A.Location = New System.Drawing.Point(224, 172)
        Me.TextBox_A.Name = "TextBox_A"
        Me.TextBox_A.Size = New System.Drawing.Size(100, 31)
        Me.TextBox_A.TabIndex = 4
        '
        'TextBox_B
        '
        Me.TextBox_B.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_B.Location = New System.Drawing.Point(406, 172)
        Me.TextBox_B.Name = "TextBox_B"
        Me.TextBox_B.Size = New System.Drawing.Size(100, 31)
        Me.TextBox_B.TabIndex = 5
        '
        'TextBox_C
        '
        Me.TextBox_C.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_C.Location = New System.Drawing.Point(574, 172)
        Me.TextBox_C.Name = "TextBox_C"
        Me.TextBox_C.Size = New System.Drawing.Size(100, 31)
        Me.TextBox_C.TabIndex = 6
        '
        'Button_Valider
        '
        Me.Button_Valider.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button_Valider.Location = New System.Drawing.Point(370, 257)
        Me.Button_Valider.Name = "Button_Valider"
        Me.Button_Valider.Size = New System.Drawing.Size(162, 80)
        Me.Button_Valider.TabIndex = 7
        Me.Button_Valider.Text = "Valider"
        Me.Button_Valider.UseVisualStyleBackColor = False
        '
        'Label_Resultat
        '
        Me.Label_Resultat.AutoSize = True
        Me.Label_Resultat.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Resultat.Location = New System.Drawing.Point(1027, 466)
        Me.Label_Resultat.Name = "Label_Resultat"
        Me.Label_Resultat.Size = New System.Drawing.Size(0, 24)
        Me.Label_Resultat.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1057, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 25)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Résultat :"
        '
        'Label_Resultat2
        '
        Me.Label_Resultat2.AutoSize = True
        Me.Label_Resultat2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Resultat2.Location = New System.Drawing.Point(1272, 466)
        Me.Label_Resultat2.Name = "Label_Resultat2"
        Me.Label_Resultat2.Size = New System.Drawing.Size(0, 24)
        Me.Label_Resultat2.TabIndex = 10
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBox2.Location = New System.Drawing.Point(865, 0)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(10, 677)
        Me.TextBox2.TabIndex = 12
        '
        'Label_X1
        '
        Me.Label_X1.AutoSize = True
        Me.Label_X1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_X1.Location = New System.Drawing.Point(930, 466)
        Me.Label_X1.Name = "Label_X1"
        Me.Label_X1.Size = New System.Drawing.Size(0, 24)
        Me.Label_X1.TabIndex = 13
        '
        'Label_X2
        '
        Me.Label_X2.AutoSize = True
        Me.Label_X2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_X2.Location = New System.Drawing.Point(1160, 466)
        Me.Label_X2.Name = "Label_X2"
        Me.Label_X2.Size = New System.Drawing.Size(0, 24)
        Me.Label_X2.TabIndex = 14
        '
        'Label_X0
        '
        Me.Label_X0.AutoSize = True
        Me.Label_X0.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_X0.Location = New System.Drawing.Point(953, 399)
        Me.Label_X0.Name = "Label_X0"
        Me.Label_X0.Size = New System.Drawing.Size(0, 24)
        Me.Label_X0.TabIndex = 16
        '
        'Label_REsult0
        '
        Me.Label_REsult0.AutoSize = True
        Me.Label_REsult0.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_REsult0.Location = New System.Drawing.Point(1084, 399)
        Me.Label_REsult0.Name = "Label_REsult0"
        Me.Label_REsult0.Size = New System.Drawing.Size(0, 24)
        Me.Label_REsult0.TabIndex = 15
        '
        'Label_Delta
        '
        Me.Label_Delta.AutoSize = True
        Me.Label_Delta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Delta.Location = New System.Drawing.Point(953, 200)
        Me.Label_Delta.Name = "Label_Delta"
        Me.Label_Delta.Size = New System.Drawing.Size(0, 24)
        Me.Label_Delta.TabIndex = 17
        '
        'Label_Result_Delta
        '
        Me.Label_Result_Delta.AutoSize = True
        Me.Label_Result_Delta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Result_Delta.Location = New System.Drawing.Point(1097, 200)
        Me.Label_Result_Delta.Name = "Label_Result_Delta"
        Me.Label_Result_Delta.Size = New System.Drawing.Size(0, 24)
        Me.Label_Result_Delta.TabIndex = 18
        '
        'Label_Solution
        '
        Me.Label_Solution.AutoSize = True
        Me.Label_Solution.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Solution.Location = New System.Drawing.Point(953, 269)
        Me.Label_Solution.Name = "Label_Solution"
        Me.Label_Solution.Size = New System.Drawing.Size(0, 24)
        Me.Label_Solution.TabIndex = 19
        '
        'Label_Canonique
        '
        Me.Label_Canonique.AutoSize = True
        Me.Label_Canonique.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Canonique.Location = New System.Drawing.Point(930, 581)
        Me.Label_Canonique.Name = "Label_Canonique"
        Me.Label_Canonique.Size = New System.Drawing.Size(0, 24)
        Me.Label_Canonique.TabIndex = 20
        '
        'Label_Result_Canonique
        '
        Me.Label_Result_Canonique.AutoSize = True
        Me.Label_Result_Canonique.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Result_Canonique.Location = New System.Drawing.Point(1170, 581)
        Me.Label_Result_Canonique.Name = "Label_Result_Canonique"
        Me.Label_Result_Canonique.Size = New System.Drawing.Size(0, 24)
        Me.Label_Result_Canonique.TabIndex = 21
        '
        'Button_Reset
        '
        Me.Button_Reset.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button_Reset.Location = New System.Drawing.Point(55, 547)
        Me.Button_Reset.Name = "Button_Reset"
        Me.Button_Reset.Size = New System.Drawing.Size(137, 58)
        Me.Button_Reset.TabIndex = 22
        Me.Button_Reset.Text = "Reset"
        Me.Button_Reset.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1394, 675)
        Me.Controls.Add(Me.Button_Reset)
        Me.Controls.Add(Me.Label_Result_Canonique)
        Me.Controls.Add(Me.Label_Canonique)
        Me.Controls.Add(Me.Label_Solution)
        Me.Controls.Add(Me.Label_Result_Delta)
        Me.Controls.Add(Me.Label_Delta)
        Me.Controls.Add(Me.Label_X0)
        Me.Controls.Add(Me.Label_REsult0)
        Me.Controls.Add(Me.Label_X2)
        Me.Controls.Add(Me.Label_X1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label_Resultat2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label_Resultat)
        Me.Controls.Add(Me.Button_Valider)
        Me.Controls.Add(Me.TextBox_C)
        Me.Controls.Add(Me.TextBox_B)
        Me.Controls.Add(Me.TextBox_A)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LabelTitre)
        Me.Name = "Form1"
        Me.Text = "Equation"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelTitre As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_A As TextBox
    Friend WithEvents TextBox_B As TextBox
    Friend WithEvents TextBox_C As TextBox
    Friend WithEvents Button_Valider As Button
    Friend WithEvents Label_Resultat As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label_Resultat2 As Label
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label_X1 As Label
    Friend WithEvents Label_X2 As Label
    Friend WithEvents Label_X0 As Label
    Friend WithEvents Label_REsult0 As Label
    Friend WithEvents Label_Delta As Label
    Friend WithEvents Label_Result_Delta As Label
    Friend WithEvents Label_Solution As Label
    Friend WithEvents Label_Canonique As Label
    Friend WithEvents Label_Result_Canonique As Label
    Friend WithEvents Button_Reset As Button
End Class
