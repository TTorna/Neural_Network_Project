Public Class Calculo
    Public Entrada1Activo As Double
    Public Entrada2Banderin As Double
    Public Entrada3Canales As Double
    Public Entrada4MACD As Double
    Public Entrada5Fibbonacci As Double
    Public Entrada6 As Double
    Public Entrada7 As Double
    Public Entrada8Pasivo_Activo As Double
    Public Entrada9Moderado_Conservador_Agresivo As Double
    Public Entrada10 As Double
    Public Entrada11 As Double
    Public Entrada12 As Double
    Public ResultadoFinal As Double
    Private Link As String
    Public IA As String

    Private W As Double(,,)
    Private U As Double(,)
    Private A As Double(,)
    Private TotalCapas As Integer
    Private neuronasporcapa As Integer()
    Private TotalEntradas As Integer
    Dim cont1 As Integer = 0
    Dim cont2 As Integer = 0
    Dim ObjBdc = New BDC()

    Public Function Informar() As String

    End Function

    Public Function predecir() As Double
        Dim PesosUmbrales As New BDC
        PesosUmbrales.LevantarPesos()

        Dim W As Double(,,)
        Dim U As Double(,)
        Dim A As Double(,)
        Dim cont1 As Integer = 0
        Dim cont2 As Integer = 0
        Dim resultado As Double

        Dim TotalEntradas As Integer = 12
        Dim TotalSalidas As Integer = 1
        Dim TotalCapas As Integer = 3
        Dim neuronasporcapa As Integer() = New Integer(TotalCapas) {}
        neuronasporcapa(0) = TotalEntradas
        neuronasporcapa(1) = 5
        neuronasporcapa(2) = 2
        neuronasporcapa(3) = TotalSalidas
        'Dim objP As Perceptron = New Perceptron(TotalEntradas, TotalSalidas, TotalCapas, neuronasporcapa)
        Dim MaximosRegistros As Integer = 0
        Dim entrada As Double()() = New Double(MaximosRegistros)() {}

        entrada(0) = New Double() {Entrada1Activo, Entrada2Banderin, Entrada3Canales, Entrada4MACD, Entrada5Fibbonacci, Entrada6, Entrada7, Entrada8Pasivo_Activo, Entrada9Moderado_Conservador_Agresivo, Entrada10, Entrada11, Entrada12}

        W = New Double(TotalCapas, 11, 11) {}
        U = New Double(TotalCapas, 11) {}
        A = New Double(TotalCapas, 11) {}

        For capa As Integer = 1 To TotalCapas

            For p As Integer = 0 To neuronasporcapa(capa) - 1
                U(capa, p) = PesosUmbrales.Umbrales(cont1)
                cont1 += 1
            Next
        Next

        For capa As Integer = 0 To TotalCapas - 1

            For p As Integer = 0 To neuronasporcapa(capa) - 1

                For k As Integer = 0 To neuronasporcapa(capa + 1) - 1
                    W(capa, p, k) = PesosUmbrales.Pesos(cont2)
                    cont2 += 1
                Next
            Next
        Next

        For copia As Integer = 0 To TotalEntradas - 1
            A(0, copia) = entrada(0)(copia)
        Next

        For capa As Integer = 1 To TotalCapas

            For neurona As Integer = 0 To neuronasporcapa(capa) - 1
                A(capa, neurona) = 0

                For entra As Integer = 0 To neuronasporcapa(capa - 1) - 1
                    A(capa, neurona) += A(capa - 1, entra) * W(capa - 1, entra, neurona) + 1 * U(capa, neurona)
                Next

                A(capa, neurona) = 1 / (1 + Math.Exp(-A(capa, neurona)))

                If capa = TotalCapas Then

                    resultado = A(capa, neurona)

                End If

            Next
        Next

        'Dim conex As New BaseDeDatadosConexion
        'Dim sql As String

        'sql = "CALL dt.insertar_prediccion('" + cuenta + "'," + Str(resultado) + "," + Str(Magnitud) + "," + Str(Intervalo) + "," + Str(Escala) + "," + Str(Profundidad) + "," + Str(Efecto) + "," + Str(BI) + "," + Str(NumZona) + ");"
        'conex.EjecutarSql(sql)
        'conex.Dispose()

        Return resultado
    End Function

    Public Sub RecopilarDator(vEntrada1 As Double, vEntrada2 As Double, vEntrada3 As Double, vEntrada4 As Double, vEntrada5 As Double, vEntrada6 As Double, vEntrada7 As Double)
        Entrada1Activo = vEntrada1
        Entrada2Banderin = vEntrada2
        Entrada3Canales = vEntrada3
        Entrada4MACD = vEntrada4
        Entrada5Fibbonacci = vEntrada5
        Entrada8Pasivo_Activo = vEntrada6
        Entrada9Moderado_Conservador_Agresivo = vEntrada7

        If Entrada1Activo = 0 Then
            Entrada6 = 125
            Entrada7 = 1
            Entrada10 = 1
            Entrada11 = 0
            Entrada12 = 0

        Else
            If Entrada1Activo = 1 Then
                Entrada6 = 100
                Entrada7 = 1
                Entrada10 = 1
                Entrada11 = 0
                Entrada12 = 0
            Else
                If Entrada1Activo = 2 Then
                    Entrada6 = 95
                    Entrada7 = 1
                    Entrada10 = 1
                    Entrada11 = 0
                    Entrada12 = 0
                Else
                    If Entrada1Activo = 3 Then
                        Entrada6 = 115
                        Entrada7 = 1
                        Entrada10 = 1
                        Entrada11 = 0
                        Entrada12 = 0
                    End If
                End If
            End If
        End If
    End Sub

    Private Function Validar() As Boolean

    End Function

End Class
