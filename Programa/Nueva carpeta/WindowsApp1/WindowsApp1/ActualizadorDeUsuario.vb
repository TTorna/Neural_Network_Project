Imports System.Net
Imports System.Net.Mail
Public Class ActualizadorDeUsuario

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Public Sub enviarEmail(destino As String, ByVal subject As String, ByVal body As String)
        Dim Email As New MailMessage()

        Try

            'Declaramos nuestro objeto servidor SMTP
            Dim SMTPServer As New SmtpClient

            Email.From = New MailAddress("duckteen7@gmail.com")
            Email.To.Add(New MailAddress(destino))
            Email.Subject = subject
            Email.Body = body

            'Especificamos cual es nuestro servidor SMTP
            SMTPServer.Host = "smtp.gmail.com"
            'Puerto SMTP de nuestro server
            SMTPServer.Port = 587
            'Credenciales de acceso de la cuenta de envio
            SMTPServer.Credentials = New System.Net.NetworkCredential("usuario_correo", "clave_correo")
            'Si nuestro servidor de correo admite SSL
            SMTPServer.EnableSsl = True
            'Enviamos el correo
            SMTPServer.Send(Email)

            'Destruimos el objeto de correo
            Email.Dispose()

            MessageBox.Show("Correo enviado.", "Mail Sender", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception
            MessageBox.Show("Ocurrio un error al enviar el correo: " & ex.Message, "Mail Sender", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub BttRecuperar_Click(sender As Object, e As EventArgs) Handles BttRecuperar.Click
        Dim vUsuario = New Usuario()

        If vUsuario.Act_Usuario(TxtMailRperar.Text, TxtNomRperar.Text, TxtApelRperar.Text, TBNum.Text) Then


            'variables para almacenar el email destino, asunto
            'y mensaje a enviar
            Dim correo As String = TxtMailRperar.Text.Trim
            Dim asunto As String = "Recuperacion de Contraseña, 'BDC'"
            Dim Contra As String = vUsuario.Contraseña
            Dim mensaje As String = "Su contraseña es: '" + Contra + "'."

            'ErrorProvider1.Clear()

            'Validamos los datos del mensaje que no esten vacios
            'usamos para ello el Error Provider de .NET para mostrar
            'en una forma mas elegante los mensajes de error
            'If String.IsNullOrEmpty(correo) Then
            '    ErrorProvider1.SetError(TxtMailRperar, "Falta el correo del destinatario")
            '    Exit Sub
            'End If

            'If String.IsNullOrEmpty(asunto) Then
            '    ErrorProvider1.SetError(txtAsunto, "Falta el asunto del correo")
            '    Exit Sub
            'End If

            'If String.IsNullOrEmpty(mensaje) Then
            '    ErrorProvider1.SetError(txtMensaje, "Falta el mensaje del correo")
            '    Exit Sub
            'End If

            enviarEmail(correo, asunto, mensaje)

            MsgBox("Su contraseña se a enviado al mail: " + TxtMailRperar.Text)

            MsgBox("Como no tenemos en propiedad un dominio le diremos su clave aqui: '" + Contra + "'.")

            Me.Hide()
            Form1.Show()
        Else
            MsgBox("No existe ese usuario, Revise que los datos sean validos.")
        End If
    End Sub
End Class