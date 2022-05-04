Public Class Form3
    Dim contador As Integer = 0
    Dim Respuesta(2) As String

    Private Sub TBResp_TextChanged(sender As Object, e As EventArgs) Handles TBResp.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        contador = contador + 1
        If contador = 1 Then
            LbPreg.Text = "Cual es el capital aproximado que esta dispuesto a invertir?"
            LbPreg.Font = New Font(LbPreg.Font.Name, 13)
            TBResp.Text = ""
            Label4.Text = ""
            Respuesta(1) = TBResp.Text
        Else
            Respuesta(2) = TBResp.Text
            Me.Hide()
            Form1.Show()
        End If

    End Sub

    Private Sub LbPreg_Click(sender As Object, e As EventArgs) Handles LbPreg.Click

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class