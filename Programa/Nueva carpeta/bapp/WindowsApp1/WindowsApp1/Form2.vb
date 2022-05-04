Public Class Form2

    Public Mail As String
    Public Nombre As String
    Public Apellido As String
    Public Contraseña As String = "1"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BttRegistrar.Click
        Dim vUsuario = New Usuario()

        If Len(TBNum.Text) <> 12 Then
            MsgBox("introdusca un numero celular con 12 digitos")
        Else
            If vUsuario.Registrar(TxtMailR.Text, TxtNomR.Text, TxtApelR.Text, TBNum.Text, TxtCtñR.Text) Then
                Me.Hide()
                Form1.Show()
            Else
                MsgBox("No se pudo registrar, intentelo devuelta en un rato.")
            End If
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        PerfilUser.Show()
    End Sub
End Class