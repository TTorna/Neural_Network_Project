Imports System.Web.Mail
Public Class ActualizadorDeUsuario

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub BttRecuperar_Click(sender As Object, e As EventArgs) Handles BttRecuperar.Click
        Dim vUsuario = New Usuario()

        If vUsuario.Act_Usuario(TxtMailRperar.Text, TxtNomRperar.Text, TxtApelRperar.Text, TBNum.Text) Then
            Dim smtp As New System.Net.Mail.SmtpClient
            Dim correo As New System.Net.Mail.MailMessage
            'Dim adjunto As System.Net.Mail.Attachment
            Dim Contra As String = vUsuario.Contraseña

            With smtp
                .Port = 25
                .Host = "smtp.elrincondelprogramador.net"
                .Credentials = New System.Net.NetworkCredential("usuario-smtp", "clave-smtp")
                .EnableSsl = False
            End With
            'adjunto = New System.Net.Mail.Attachment("C:\Temp\Adjunto.pdf")
            With correo
                .From = New System.Net.Mail.MailAddress("duckteen7@gmail.com")
                .To.Add(TxtMailRperar.Text)
                .Subject = "Recuperacion de Contraseña, 'BDC'"
                .Body = "<strong> Su contraseña es: '" + Contra + "'</strong>"
                .IsBodyHtml = True
                .Priority = System.Net.Mail.MailPriority.Normal
                '.Attachments.Add(adjunto)
            End With

            Try
                smtp.Send(correo)
                MessageBox.Show("Su mensaje de correo ha sido enviado.",
                            "Correo enviado",
                             MessageBoxButtons.OK)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message,
                            "Error al enviar correo",
                             MessageBoxButtons.OK)
            End Try

            MsgBox("Su contraseña se a enviado al mail: " + TxtMailRperar.Text)

            Me.Hide()
            Form1.Show()
        Else
            MsgBox("No existe ese usuario, Revise que los datos sean validos.")
        End If
    End Sub
End Class