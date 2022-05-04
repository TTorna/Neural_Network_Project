Public Class ModificarRubro
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Interfaz_Admin.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim obj = New Usuario

        If CBAccionRubro.SelectedItem = "Poner nuevo rubro" Then
            If obj.ModificarRubro(0, TxtId.Text, TxtTipo.Text, TxtDesc.Text) Then
                MsgBox("Se aplico correctamente")
            Else
                MsgBox("No se pudo aplicar correctamente")
            End If
        Else
            If obj.ModificarRubro(1, TxtId.Text, TxtTipo.Text, TxtDesc.Text) Then
                MsgBox("Se aplico correctamente")
            Else
                MsgBox("No se pudo aplicar correctamente")
            End If
        End If
    End Sub
End Class