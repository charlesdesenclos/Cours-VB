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
        Me.Button_Factoriel = New System.Windows.Forms.Button()
        Me.TextBox_fac = New System.Windows.Forms.TextBox()
        Me.Label_affiche_res = New System.Windows.Forms.Label()
        Me.Label_resultat = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button_Factoriel
        '
        Me.Button_Factoriel.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Factoriel.Location = New System.Drawing.Point(543, 162)
        Me.Button_Factoriel.Name = "Button_Factoriel"
        Me.Button_Factoriel.Size = New System.Drawing.Size(144, 71)
        Me.Button_Factoriel.TabIndex = 0
        Me.Button_Factoriel.Text = "Factoriel"
        Me.Button_Factoriel.UseVisualStyleBackColor = True
        '
        'TextBox_fac
        '
        Me.TextBox_fac.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox_fac.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_fac.Location = New System.Drawing.Point(77, 182)
        Me.TextBox_fac.Name = "TextBox_fac"
        Me.TextBox_fac.Size = New System.Drawing.Size(301, 31)
        Me.TextBox_fac.TabIndex = 1
        '
        'Label_affiche_res
        '
        Me.Label_affiche_res.AutoSize = True
        Me.Label_affiche_res.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_affiche_res.Location = New System.Drawing.Point(109, 336)
        Me.Label_affiche_res.Name = "Label_affiche_res"
        Me.Label_affiche_res.Size = New System.Drawing.Size(91, 25)
        Me.Label_affiche_res.TabIndex = 2
        Me.Label_affiche_res.Text = "Resultat"
        '
        'Label_resultat
        '
        Me.Label_resultat.AutoSize = True
        Me.Label_resultat.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_resultat.Location = New System.Drawing.Point(255, 347)
        Me.Label_resultat.Name = "Label_resultat"
        Me.Label_resultat.Size = New System.Drawing.Size(0, 25)
        Me.Label_resultat.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label_resultat)
        Me.Controls.Add(Me.Label_affiche_res)
        Me.Controls.Add(Me.TextBox_fac)
        Me.Controls.Add(Me.Button_Factoriel)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_Factoriel As Button
    Friend WithEvents TextBox_fac As TextBox
    Friend WithEvents Label_affiche_res As Label
    Friend WithEvents Label_resultat As Label
End Class
