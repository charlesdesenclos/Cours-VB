Public Class Form1
    Private Sub Button_telecharger_Click(sender As Object, e As EventArgs) Handles Button_telecharger.Click
        PictureBox_img.Image = My.Resources.bird_thumbnail

    End Sub

    Private Sub Button_Importer_Click(sender As Object, e As EventArgs) Handles Button_Importer.Click
        PictureBox_img.Image = My.Resources.images

    End Sub

    Private Sub Button_parcourir_Click(sender As Object, e As EventArgs) Handles Button_parcourir.Click
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            PictureBox_img.ImageLocation = OpenFileDialog1.FileName
        End If

    End Sub
End Class
