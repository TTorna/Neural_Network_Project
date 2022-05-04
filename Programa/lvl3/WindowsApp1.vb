Public Class Form1
    Private Arrastrar As Boolean = False
    Private MouseDownX As Integer
    Private MouseDownY As Integer

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Label5.Visible = False
        LinkLabel2.Visible = False
        Me.Hide()
        PerfilUser.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BttSesion.Click
        Dim vUsuario = New Usuario()
        If vUsuario.LoguearAdmin(TxtMail.Text, TxtNom.Text, TxtApel.Text, TxtCtñ.Text) = 0 Then
            If vUsuario.Loguear(TxtMail.Text, TxtNom.Text, TxtApel.Text, TxtCtñ.Text) = 0 Then
                MsgBox("Datos incorrectos, por favor introduzca los correctos")
                Label5.Visible = True
                LinkLabel2.Visible = True
            Else
                MsgBox("los datos se ingresaron correctamente", MsgBoxStyle.Information, "Insertar Datos")
                Me.Hide()
                Interfaz_Intermedia.Show()
            End If
        Else
            MsgBox("los datos se ingresaron correctamente", MsgBoxStyle.Information, "Insertar Datos")
            Me.Hide()
            Interfaz_Admin.Show()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
    Private Sub F_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseDown
        If e.Button = MouseButtons.Left Then
            Arrastrar = True
            MouseDownX = e.X
            MouseDownY = e.Y
        End If
    End Sub

    Private Sub F_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = MouseButtons.Left Then
            Arrastrar = False
        End If
    End Sub

    Private Sub F_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles MyBase.MouseMove
        If Arrastrar = True Then
            Dim temp As Point = New Point()
            temp.X = Me.Location.X + (e.X - MouseDownX)
            temp.Y = Me.Location.Y + (e.Y - MouseDownY)
            Me.Location = temp
            temp = Nothing
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Label5.Visible = False
        LinkLabel2.Visible = False
        Me.Hide()
        ActualizadorDeUsuario.Show()
    End Sub
End Class
