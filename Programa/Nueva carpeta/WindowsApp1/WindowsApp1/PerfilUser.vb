Public Class PerfilUser
    Public Seleccion

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CBPerso.SelectedItem <> "" Then
            Seleccion = CBPerso.SelectedItem
            Me.Hide()
            Form2.Show()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class