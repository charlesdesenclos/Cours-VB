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
        Me.button1 = New System.Windows.Forms.Button()
        Me.EventLog1 = New System.Diagnostics.EventLog()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_br2 = New System.Windows.Forms.TextBox()
        Me.textbox_nbr1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.label_result = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'button1
        '
        Me.button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.Location = New System.Drawing.Point(267, 192)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(185, 34)
        Me.button1.TabIndex = 2
        Me.button1.Text = "Calculer"
        Me.button1.UseVisualStyleBackColor = True
        '
        'EventLog1
        '
        Me.EventLog1.SynchronizingObject = Me
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(339, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(21, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "+"
        '
        'TextBox_br2
        '
        Me.TextBox_br2.Location = New System.Drawing.Point(366, 141)
        Me.TextBox_br2.Name = "TextBox_br2"
        Me.TextBox_br2.Size = New System.Drawing.Size(222, 20)
        Me.TextBox_br2.TabIndex = 4
        '
        'textbox_nbr1
        '
        Me.textbox_nbr1.AccessibleDescription = ""
        Me.textbox_nbr1.AccessibleName = ""
        Me.textbox_nbr1.Location = New System.Drawing.Point(114, 141)
        Me.textbox_nbr1.Name = "textbox_nbr1"
        Me.textbox_nbr1.Size = New System.Drawing.Size(219, 20)
        Me.textbox_nbr1.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AccessibleName = "En"
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(149, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Entrer un nombre entier"
        '
        'Label4
        '
        Me.Label4.AccessibleName = "En"
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(416, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Entrer un nombre entier"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(147, 327)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 25)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Résultat : "
        '
        'label_result
        '
        Me.label_result.AutoSize = True
        Me.label_result.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label_result.Location = New System.Drawing.Point(290, 327)
        Me.label_result.Name = "label_result"
        Me.label_result.Size = New System.Drawing.Size(0, 25)
        Me.label_result.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(718, 39)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Outils pour faire la somme de deux nombres :"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.label_result)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.textbox_nbr1)
        Me.Controls.Add(Me.TextBox_br2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.button1)
        Me.Name = "Form1"
        Me.Text = "Somme"
        CType(Me.EventLog1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents button1 As Button
    Friend WithEvents EventLog1 As EventLog
    Friend WithEvents textbox_nbr1 As TextBox
    Friend WithEvents TextBox_br2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents label_result As Label
    Friend WithEvents Label1 As Label
End Class
