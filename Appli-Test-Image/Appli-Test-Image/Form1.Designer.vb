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
        Me.Button_telecharger = New System.Windows.Forms.Button()
        Me.Button_Importer = New System.Windows.Forms.Button()
        Me.PictureBox_img = New System.Windows.Forms.PictureBox()
        Me.Button_parcourir = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.PictureBox_img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_telecharger
        '
        Me.Button_telecharger.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_telecharger.Location = New System.Drawing.Point(589, 159)
        Me.Button_telecharger.Name = "Button_telecharger"
        Me.Button_telecharger.Size = New System.Drawing.Size(135, 54)
        Me.Button_telecharger.TabIndex = 2
        Me.Button_telecharger.Text = "Téléchager"
        Me.Button_telecharger.UseVisualStyleBackColor = True
        '
        'Button_Importer
        '
        Me.Button_Importer.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Importer.Location = New System.Drawing.Point(589, 244)
        Me.Button_Importer.Name = "Button_Importer"
        Me.Button_Importer.Size = New System.Drawing.Size(135, 54)
        Me.Button_Importer.TabIndex = 3
        Me.Button_Importer.Text = "Importer"
        Me.Button_Importer.UseVisualStyleBackColor = True
        '
        'PictureBox_img
        '
        Me.PictureBox_img.Image = Global.Appli_Test_Image.My.Resources.Resources.images
        Me.PictureBox_img.Location = New System.Drawing.Point(170, 102)
        Me.PictureBox_img.Name = "PictureBox_img"
        Me.PictureBox_img.Size = New System.Drawing.Size(314, 275)
        Me.PictureBox_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox_img.TabIndex = 1
        Me.PictureBox_img.TabStop = False
        '
        'Button_parcourir
        '
        Me.Button_parcourir.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_parcourir.Location = New System.Drawing.Point(589, 323)
        Me.Button_parcourir.Name = "Button_parcourir"
        Me.Button_parcourir.Size = New System.Drawing.Size(135, 54)
        Me.Button_parcourir.TabIndex = 4
        Me.Button_parcourir.Text = "Parcourir"
        Me.Button_parcourir.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Filter = "images(*.jpg)|*.jpg"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Button_parcourir)
        Me.Controls.Add(Me.Button_Importer)
        Me.Controls.Add(Me.Button_telecharger)
        Me.Controls.Add(Me.PictureBox_img)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox_img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents PictureBox_img As PictureBox
    Friend WithEvents Button_telecharger As Button
    Friend WithEvents Button_Importer As Button
    Friend WithEvents Button_parcourir As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
