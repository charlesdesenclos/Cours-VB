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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button_Calculer = New System.Windows.Forms.Button()
        Me.Button_RAZ = New System.Windows.Forms.Button()
        Me.TextBox_nbr = New System.Windows.Forms.TextBox()
        Me.Label_premiers_nbr = New System.Windows.Forms.Label()
        Me.Label_premiers_nbr_impairs = New System.Windows.Forms.Label()
        Me.Label_premiers_nbr_pairs = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 228)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(293, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Somme des N premiers Nombres"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 277)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(358, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Somme des N premiers Nombres impairs"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(49, 332)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(338, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Somme des N premiers Nombres pairs"
        '
        'Button_Calculer
        '
        Me.Button_Calculer.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button_Calculer.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Calculer.Location = New System.Drawing.Point(53, 143)
        Me.Button_Calculer.Name = "Button_Calculer"
        Me.Button_Calculer.Size = New System.Drawing.Size(209, 56)
        Me.Button_Calculer.TabIndex = 3
        Me.Button_Calculer.Text = "Calculer"
        Me.Button_Calculer.UseVisualStyleBackColor = False
        '
        'Button_RAZ
        '
        Me.Button_RAZ.BackColor = System.Drawing.Color.IndianRed
        Me.Button_RAZ.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_RAZ.Location = New System.Drawing.Point(367, 143)
        Me.Button_RAZ.Name = "Button_RAZ"
        Me.Button_RAZ.Size = New System.Drawing.Size(209, 56)
        Me.Button_RAZ.TabIndex = 4
        Me.Button_RAZ.Text = "RAZ"
        Me.Button_RAZ.UseVisualStyleBackColor = False
        '
        'TextBox_nbr
        '
        Me.TextBox_nbr.Location = New System.Drawing.Point(52, 44)
        Me.TextBox_nbr.Multiline = True
        Me.TextBox_nbr.Name = "TextBox_nbr"
        Me.TextBox_nbr.Size = New System.Drawing.Size(209, 47)
        Me.TextBox_nbr.TabIndex = 5
        '
        'Label_premiers_nbr
        '
        Me.Label_premiers_nbr.AutoSize = True
        Me.Label_premiers_nbr.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label_premiers_nbr.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_premiers_nbr.Location = New System.Drawing.Point(424, 226)
        Me.Label_premiers_nbr.Name = "Label_premiers_nbr"
        Me.Label_premiers_nbr.Size = New System.Drawing.Size(0, 25)
        Me.Label_premiers_nbr.TabIndex = 6
        '
        'Label_premiers_nbr_impairs
        '
        Me.Label_premiers_nbr_impairs.AutoSize = True
        Me.Label_premiers_nbr_impairs.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label_premiers_nbr_impairs.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_premiers_nbr_impairs.Location = New System.Drawing.Point(424, 277)
        Me.Label_premiers_nbr_impairs.Name = "Label_premiers_nbr_impairs"
        Me.Label_premiers_nbr_impairs.Size = New System.Drawing.Size(0, 25)
        Me.Label_premiers_nbr_impairs.TabIndex = 7
        '
        'Label_premiers_nbr_pairs
        '
        Me.Label_premiers_nbr_pairs.AutoSize = True
        Me.Label_premiers_nbr_pairs.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label_premiers_nbr_pairs.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_premiers_nbr_pairs.Location = New System.Drawing.Point(424, 331)
        Me.Label_premiers_nbr_pairs.Name = "Label_premiers_nbr_pairs"
        Me.Label_premiers_nbr_pairs.Size = New System.Drawing.Size(0, 25)
        Me.Label_premiers_nbr_pairs.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label_premiers_nbr_pairs)
        Me.Controls.Add(Me.Label_premiers_nbr_impairs)
        Me.Controls.Add(Me.Label_premiers_nbr)
        Me.Controls.Add(Me.TextBox_nbr)
        Me.Controls.Add(Me.Button_RAZ)
        Me.Controls.Add(Me.Button_Calculer)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Calcul des sommes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button_Calculer As Button
    Friend WithEvents Button_RAZ As Button
    Friend WithEvents TextBox_nbr As TextBox
    Friend WithEvents Label_premiers_nbr As Label
    Friend WithEvents Label_premiers_nbr_impairs As Label
    Friend WithEvents Label_premiers_nbr_pairs As Label
End Class
