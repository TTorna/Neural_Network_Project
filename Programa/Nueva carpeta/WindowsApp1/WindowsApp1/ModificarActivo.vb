Public Class ModificarActivo
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Interfaz_Admin.Show()
    End Sub

    Private Sub CBAccionRubro_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBAccionRubro.SelectedIndexChanged
        Dim obj = New Usuario

        If CBAccionRubro.SelectedItem = "Poner nuevo activo" Then
            TxtGrafico.Enabled = True
            TxtRubro.Enabled = True
        Else
            TxtGrafico.Enabled = False
            TxtRubro.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim obj = New Usuario

        If CBAccionRubro.SelectedItem = "Poner nuevo activo" Then
            If obj.ModificarActivo(0, TxtId.Text, TxtNombre.Text, TxtGrafico.Text, TxtRubro.Text) Then
                MsgBox("Se aplico correctamente")
            Else
                MsgBox("No se pudo aplicar correctamente")
            End If
        Else
            If obj.ModificarActivo(1, TxtId.Text, TxtNombre.Text, "", 0) Then
                MsgBox("Se aplico correctamente")
            Else
                MsgBox("No se pudo aplicar correctamente")
            End If
        End If
    End Sub
End Class