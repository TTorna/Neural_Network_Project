Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql As String
        Dim conex As New BaseDeDatadosConexion
        Me.Hide()
        IndicadorTecnico.Show()
        Try
            sql = "Use BDC; Call IndicadoresValidacion();"
            conex.EjecutarSql(sql)
            Dim Respuesta As Integer
            Respuesta = conex.micomando.ExecuteScalar()
            If Respuesta = 0 Then
                MsgBox("En este momento 'La Bola De Cristal' esta en mantenimiento, por favor intente de nuevo en un rato.")
            Else
                Me.Hide()
                IndicadorTecnico.Show()
            End If
            conex.Dispose()



        Catch ex As Exception
            MsgBox("Error" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
        End Try

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class