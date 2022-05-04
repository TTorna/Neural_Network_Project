Public Class Form1

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BttSesion.Click

        If TxtMail.Text = Form2.Mail And TxtNom.Text = Form2.Nombre And TxtApel.Text = Form2.Apellido And TxtCtñ.Text = Form2.Contraseña Then
            Me.Hide()
            Form4.Show()

        Else
            MsgBox("Datos incorrectos, por favor introduzca los correctos")

        End If

    End Sub

End Class
