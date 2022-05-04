Public Class IndicadorTecnico
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sql As String
        Dim conex As New BaseDeDatadosConexion
        Try
            sql = "SELECT * FROM User"
            conex.EjecutarSql(sql)
            conex.Dispose()
            MsgBox("los datos se ingresaron correctamente", MsgBoxStyle.Information, "Insertar Datos")
        Catch ex As Exception
            MsgBox("Error" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
        End Try
    End Sub

    Private Sub CBBanderines_CheckedChanged(sender As Object, e As EventArgs) Handles CBBanderines.CheckedChanged
        ComboBox1.Enabled = Not ComboBox1.Enabled
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        ComboBox2.Enabled = Not ComboBox2.Enabled
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        ComboBox3.Enabled = Not ComboBox3.Enabled
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        ComboBox4.Enabled = Not ComboBox4.Enabled
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Form4.Show()
    End Sub
End Class