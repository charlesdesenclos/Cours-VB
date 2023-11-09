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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_expression = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_saisie = New System.Windows.Forms.TextBox()
        Me.Button_Verification = New System.Windows.Forms.Button()
        Me.Label_Resultat = New System.Windows.Forms.Label()
        Me.TextBox_Resultat = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe Print", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(144, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(439, 65)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Expressions Régulières"
        '
        'TextBox_expression
        '
        Me.TextBox_expression.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_expression.Location = New System.Drawing.Point(61, 113)
        Me.TextBox_expression.Name = "TextBox_expression"
        Me.TextBox_expression.Size = New System.Drawing.Size(656, 31)
        Me.TextBox_expression.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Saisie expression"
        '
        'TextBox_saisie
        '
        Me.TextBox_saisie.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_saisie.Location = New System.Drawing.Point(249, 157)
        Me.TextBox_saisie.Name = "TextBox_saisie"
        Me.TextBox_saisie.Size = New System.Drawing.Size(468, 31)
        Me.TextBox_saisie.TabIndex = 3
        '
        'Button_Verification
        '
        Me.Button_Verification.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Verification.Location = New System.Drawing.Point(551, 228)
        Me.Button_Verification.Name = "Button_Verification"
        Me.Button_Verification.Size = New System.Drawing.Size(166, 48)
        Me.Button_Verification.TabIndex = 4
        Me.Button_Verification.Text = "Vérification"
        Me.Button_Verification.UseVisualStyleBackColor = True
        '
        'Label_Resultat
        '
        Me.Label_Resultat.AutoSize = True
        Me.Label_Resultat.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_Resultat.Location = New System.Drawing.Point(56, 335)
        Me.Label_Resultat.Name = "Label_Resultat"
        Me.Label_Resultat.Size = New System.Drawing.Size(91, 25)
        Me.Label_Resultat.TabIndex = 5
        Me.Label_Resultat.Text = "Résultat"
        '
        'TextBox_Resultat
        '
        Me.TextBox_Resultat.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Resultat.Location = New System.Drawing.Point(249, 329)
        Me.TextBox_Resultat.Name = "TextBox_Resultat"
        Me.TextBox_Resultat.Size = New System.Drawing.Size(468, 31)
        Me.TextBox_Resultat.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox_Resultat)
        Me.Controls.Add(Me.Label_Resultat)
        Me.Controls.Add(Me.Button_Verification)
        Me.Controls.Add(Me.TextBox_saisie)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox_expression)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Calcul d'une expression régulière"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_expression As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_saisie As TextBox
    Friend WithEvents Button_Verification As Button
    Friend WithEvents Label_Resultat As Label
    Friend WithEvents TextBox_Resultat As TextBox
End Class
