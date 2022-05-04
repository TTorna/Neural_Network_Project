Public Class Historial
    Private Sub BttSesion_Click(sender As Object, e As EventArgs) Handles BttSesion.Click
        Dim ObjHistorial = New Usuario()
        Dim dia As String = TxtDia.Text
        Dim resultado As Double = ObjHistorial.Pedir_Historial(dia)
        Dim resultadoText As String = ObjHistorial.UltimoResultadoHistorial

        If resultado <> 0 Then
            MsgBox("El resultado de la Ultima prediccion del " + dia + " es: " + resultadoText)
        Else
            MsgBox("No hay predicciones ese dia hechas por usted.")
        End If

        TxtDia.Text = ""
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Interfaz_Intermedia.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class