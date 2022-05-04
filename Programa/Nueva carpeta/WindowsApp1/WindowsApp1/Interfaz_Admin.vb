Public Class Interfaz_Admin
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub BttSesion_Click(sender As Object, e As EventArgs) Handles BttSesion.Click
        Me.Hide()
        ModificarActivo.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        ModificarRubro.Show()
    End Sub
End Class