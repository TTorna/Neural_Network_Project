Public Class IndicadorTecnico
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CBBanderin.SelectedItem <> "" And CBCanales.SelectedItem <> "" And CBMACD.SelectedItem <> "" And CBFibo.SelectedItem <> "" Then
            Dim neuronasporcapa As Integer() = New Integer(3) {}
            neuronasporcapa(0) = 12
            neuronasporcapa(1) = 5
            neuronasporcapa(2) = 2
            neuronasporcapa(3) = 1
            Dim ObjPredictor = New Calculo()
            Dim ObjPerfil = New Usuario()

            Dim ActivoNom = Form4.CBPerso.SelectedItem
            Dim Activo As Double
            If ActivoNom = "BTC/USD" Then Activo = 1
            If ActivoNom = "BNB/USD" Then Activo = 0
            If ActivoNom = "ETH/USD" Then Activo = 2
            If ActivoNom = "XRP/USD" Then Activo = 3

            Dim BanderinNom = CBBanderin.SelectedItem
            Dim Banderin As Double
            If BanderinNom = "Alcista" Then Banderin = 1
            If BanderinNom = "No hay" Then Banderin = 0
            If BanderinNom = "Bajista" Then Banderin = -1

            Dim CanalesNom = CBCanales.SelectedItem
            Dim Canales As Double
            If CanalesNom = "Alcista" Then Canales = 1
            If CanalesNom = "No hay" Then Canales = 0
            If CanalesNom = "Bajista" Then Canales = -1
            If CanalesNom = "Lateral" Then Canales = 2

            Dim MACDNom = CBMACD.SelectedItem
            Dim MACD As Double
            If MACDNom = "Alcista" Then MACD = 1
            If MACDNom = "No hay" Then MACD = 0
            If MACDNom = "Bajista" Then MACD = -1

            Dim FiboNom = CBFibo.SelectedItem
            Dim Fibo As Double
            If FiboNom = "Alcista" Then Fibo = 1
            If FiboNom = "No hay" Then Fibo = 0
            If FiboNom = "Bajista" Then Fibo = -1

            ObjPerfil.Usuario(Form1.TxtMail.Text, Form1.TxtNom.Text, Form1.TxtApel.Text, Form1.TxtCtñ.Text)
            Dim PerfilNom = ObjPerfil.PerfilDevo
            Dim Perfil As Double
            If PerfilNom = "Activo" Then Perfil = 1
            If PerfilNom = "Pasivo" Then Perfil = 0

            Dim CMANom = Form4.CBPerfil.SelectedItem
            Dim CMA As Double
            If CMANom = "Agresivo" Then CMA = 1
            If CMANom = "Moderado" Then CMA = 0
            If CMANom = "Conservador" Then CMA = -1

            ObjPredictor.RecopilarDator(Activo, Banderin, Canales, MACD, Fibo, Perfil, CMA)

            Dim resultadoCalculo As Double = ObjPredictor.predecir() '12, 4, neuronasporcapa)
            Dim resultadoFinal As String
            If resultadoCalculo >= 0.09 And resultadoCalculo <= 0.11 Then
                resultadoFinal = "Bajara demasiado"
            Else
                If resultadoCalculo >= 0.19 And resultadoCalculo <= 0.21 Then
                    resultadoFinal = "Bajara Mucho"
                Else
                    If resultadoCalculo >= 0.29 And resultadoCalculo <= 0.31 Then
                        resultadoFinal = "Bajara"
                    Else
                        If resultadoCalculo >= 0.39 And resultadoCalculo <= 0.41 Then
                            resultadoFinal = "Posible Bajada"
                        Else
                            If resultadoCalculo >= 0.49 And resultadoCalculo <= 0.51 Then
                                resultadoFinal = "Lateralizara"
                            Else
                                If resultadoCalculo >= 0.59 And resultadoCalculo <= 0.61 Then
                                    resultadoFinal = "Posible Subida"
                                Else
                                    If resultadoCalculo >= 0.69 And resultadoCalculo <= 0.71 Then
                                        resultadoFinal = "Subira"
                                    Else
                                        If resultadoCalculo >= 0.79 And resultadoCalculo <= 0.81 Then
                                            resultadoFinal = "Subira Mucho"
                                        Else
                                            If resultadoCalculo >= 0.89 And resultadoCalculo >= 0.91 Then
                                                resultadoFinal = "Subira demasiado"
                                            Else
                                                resultadoFinal = "El resultado no es preciso"
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If

            MsgBox("La bola de cristal dice que: " + resultadoFinal)
            MsgBox("Resultado double real: " + Str(resultadoCalculo))
            If ObjPerfil.Predictor(resultadoFinal, ObjPredictor.Entrada1Activo, ObjPredictor.Entrada2Banderin, ObjPredictor.Entrada3Canales, ObjPredictor.Entrada4MACD, ObjPredictor.Entrada5Fibbonacci, ObjPredictor.Entrada6, ObjPredictor.Entrada7, ObjPredictor.Entrada8Pasivo_Activo, ObjPredictor.Entrada9Moderado_Conservador_Agresivo, ObjPredictor.Entrada10, ObjPredictor.Entrada11, ObjPredictor.Entrada12) Then
                MsgBox("Se ha guardado en la base de datos")
            Else
                MsgBox("No se ha guardado en la base de datos")
            End If
            MsgBox("Gracias por usar 'la bola de cristal', vuelva pronto.")

            Me.Close()
        Else
            MsgBox("Por favor, Introduzca todos los indicadores tecnicos.")
        End If
    End Sub

    Private Sub CBBanderines_CheckedChanged(sender As Object, e As EventArgs) Handles CBBanderines.CheckedChanged
        CBBanderin.Enabled = Not CBBanderin.Enabled
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        CBCanales.Enabled = Not CBCanales.Enabled
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        CBMACD.Enabled = Not CBMACD.Enabled
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        CBFibo.Enabled = Not CBFibo.Enabled
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.Hide()
        Form4.Show()
    End Sub
End Class