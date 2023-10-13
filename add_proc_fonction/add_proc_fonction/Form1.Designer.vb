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
        Me.TextBox_nombre1 = New System.Windows.Forms.TextBox()
        Me.Button_ADD_fct = New System.Windows.Forms.Button()
        Me.TextBox_nombre2 = New System.Windows.Forms.TextBox()
        Me.Label_nombre1 = New System.Windows.Forms.Label()
        Me.Label_nombre2 = New System.Windows.Forms.Label()
        Me.Button_add_proc = New System.Windows.Forms.Button()
        Me.Label_result = New System.Windows.Forms.Label()
        Me.Label_affich_res = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox_nombre1
        '
        Me.TextBox_nombre1.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox_nombre1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_nombre1.Location = New System.Drawing.Point(179, 90)
        Me.TextBox_nombre1.Name = "TextBox_nombre1"
        Me.TextBox_nombre1.Size = New System.Drawing.Size(100, 31)
        Me.TextBox_nombre1.TabIndex = 0
        '
        'Button_ADD_fct
        '
        Me.Button_ADD_fct.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_ADD_fct.Location = New System.Drawing.Point(192, 267)
        Me.Button_ADD_fct.Name = "Button_ADD_fct"
        Me.Button_ADD_fct.Size = New System.Drawing.Size(108, 62)
        Me.Button_ADD_fct.TabIndex = 2
        Me.Button_ADD_fct.Text = "ADD fct"
        Me.Button_ADD_fct.UseVisualStyleBackColor = True
        '
        'TextBox_nombre2
        '
        Me.TextBox_nombre2.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox_nombre2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_nombre2.Location = New System.Drawing.Point(179, 162)
        Me.TextBox_nombre2.Name = "TextBox_nombre2"
        Me.TextBox_nombre2.Size = New System.Drawing.Size(100, 31)
        Me.TextBox_nombre2.TabIndex = 4
        '
        'Label_nombre1
        '
        Me.Label_nombre1.AutoSize = True
        Me.Label_nombre1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_nombre1.Location = New System.Drawing.Point(57, 96)
        Me.Label_nombre1.Name = "Label_nombre1"
        Me.Label_nombre1.Size = New System.Drawing.Size(105, 25)
        Me.Label_nombre1.TabIndex = 5
        Me.Label_nombre1.Text = "Nombre 1"
        '
        'Label_nombre2
        '
        Me.Label_nombre2.AutoSize = True
        Me.Label_nombre2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_nombre2.Location = New System.Drawing.Point(57, 162)
        Me.Label_nombre2.Name = "Label_nombre2"
        Me.Label_nombre2.Size = New System.Drawing.Size(105, 25)
        Me.Label_nombre2.TabIndex = 6
        Me.Label_nombre2.Text = "Nombre 2"
        '
        'Button_add_proc
        '
        Me.Button_add_proc.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_add_proc.Location = New System.Drawing.Point(403, 267)
        Me.Button_add_proc.Name = "Button_add_proc"
        Me.Button_add_proc.Size = New System.Drawing.Size(108, 62)
        Me.Button_add_proc.TabIndex = 7
        Me.Button_add_proc.Text = "ADD Proc"
        Me.Button_add_proc.UseVisualStyleBackColor = True
        '
        'Label_result
        '
        Me.Label_result.AutoSize = True
        Me.Label_result.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_result.Location = New System.Drawing.Point(540, 131)
        Me.Label_result.Name = "Label_result"
        Me.Label_result.Size = New System.Drawing.Size(0, 25)
        Me.Label_result.TabIndex = 8
        '
        'Label_affich_res
        '
        Me.Label_affich_res.AutoSize = True
        Me.Label_affich_res.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_affich_res.Location = New System.Drawing.Point(359, 131)
        Me.Label_affich_res.Name = "Label_affich_res"
        Me.Label_affich_res.Size = New System.Drawing.Size(91, 25)
        Me.Label_affich_res.TabIndex = 9
        Me.Label_affich_res.Text = "Resultat"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label_affich_res)
        Me.Controls.Add(Me.Label_result)
        Me.Controls.Add(Me.Button_add_proc)
        Me.Controls.Add(Me.Label_nombre2)
        Me.Controls.Add(Me.Label_nombre1)
        Me.Controls.Add(Me.TextBox_nombre2)
        Me.Controls.Add(Me.Button_ADD_fct)
        Me.Controls.Add(Me.TextBox_nombre1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox_nombre1 As TextBox
    Friend WithEvents Button_ADD_fct As Button
    Friend WithEvents TextBox_nombre2 As TextBox
    Friend WithEvents Label_nombre1 As Label
    Friend WithEvents Label_nombre2 As Label
    Friend WithEvents Button_add_proc As Button
    Friend WithEvents Label_result As Label
    Friend WithEvents Label_affich_res As Label
End Class
