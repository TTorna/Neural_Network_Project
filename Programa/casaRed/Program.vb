
Imports System
Module Program

    Sub Main(args As String())

        Dim TotalEntradas As Integer = 12
        Dim TotalSalidas As Integer = 1
        Dim TotalCapas As Integer = 3
        Dim neuronasporcapa As Integer() = New Integer(TotalCapas) {}
        neuronasporcapa(0) = TotalEntradas
        neuronasporcapa(1) = 7
        neuronasporcapa(2) = 3
        neuronasporcapa(3) = TotalSalidas
        Dim objP As Perceptron = New Perceptron(TotalEntradas, TotalSalidas, TotalCapas, neuronasporcapa)
        Dim MaximosRegistros As Integer = 1199 'total registros -2
        Dim entrada As Double()() = New Double(MaximosRegistros)() {}
        Dim salidas As Double()() = New Double(MaximosRegistros)() {}
        Const urlArchivo As String = "F:\Pendrive\Proyecto\Set de datos\Completo\Bola de Cristal_Tornamira, Tomas Agustin_ET24.csv"
        Dim ConjuntoEntradas As Integer = LeeDatosArchivo(urlArchivo, entrada, salidas)

        Dim alpha As Double = 0.3

        For epoca As Integer = 0 To 120000
            If epoca Mod 4000 = 0 Then Console.WriteLine("Iteracion: " & epoca)

            For entra As Integer = 0 To ConjuntoEntradas - 1
                objP.Procesa(entrada(entra))
                objP.Entrena(alpha, entrada(entra), salidas(entra))
            Next

        Next

        Dim MiAr As New System.IO.StreamWriter("F:\casaRed\pesos.txt")
        Dim miAr2 As New System.IO.StreamWriter("F:\casaRed\umbrales.txt")

        For capa As Integer = 0 To TotalCapas - 1
            Console.WriteLine("Pesos de capa:  " + Str(capa + 1) + " a " + Str(capa + 2))
            For inicial As Integer = 0 To neuronasporcapa(0) - 1

                For final As Integer = 0 To neuronasporcapa(1) - 1
                    If (objP.Muestra(capa, inicial, final)) <> 0 Then
                        Console.WriteLine("Neurona " + Str(inicial + 1) + " a Neurona " + Str(final + 1))
                        Console.WriteLine(objP.Muestra(capa, inicial, final))
                        MiAr.WriteLine(objP.Muestra(capa, inicial, final))
                        Console.WriteLine("")

                    End If
                Next

            Next

        Next
        MiAr.Close()
        For capa As Integer = 0 To TotalCapas - 1
            For inicial As Integer = 0 To neuronasporcapa(0) - 1


                If (objP.Muestra2(capa, inicial)) <> 0 Then

                        miAr2.WriteLine(objP.Muestra2(capa, inicial))


                    End If


            Next

        Next
        miAr2.Close()
        Console.ReadKey()
    End Sub
    Private Function LeeDatosArchivo(urlArchivo As String, entrada()() As Double, salida()() As Double) As Integer
        Dim archivo = New System.IO.StreamReader(urlArchivo)
        archivo.ReadLine() REM La línea de título de cada columna de datos
        Dim leelinea As String = ""
        Dim limValores As Integer = 0


        While archivo.Peek() <> -1
            leelinea = archivo.ReadLine()

            Dim valEntrada1 As Double = TraerNumeroCadena(leelinea, ";", 1)
            Dim valEntrada2 As Double = TraerNumeroCadena(leelinea, ";", 2)
            Dim valEntrada3 As Double = TraerNumeroCadena(leelinea, ";", 3)
            Dim valEntrada4 As Double = TraerNumeroCadena(leelinea, ";", 4)
            Dim valEntrada5 As Double = TraerNumeroCadena(leelinea, ";", 5)
            Dim valEntrada6 As Double = TraerNumeroCadena(leelinea, ";", 6)
            Dim valEntrada7 As Double = TraerNumeroCadena(leelinea, ";", 7)
            Dim valEntrada8 As Double = TraerNumeroCadena(leelinea, ";", 8)
            Dim valEntrada9 As Double = TraerNumeroCadena(leelinea, ";", 9)
            Dim valEntrada10 As Double = TraerNumeroCadena(leelinea, ";", 10)
            Dim valEntrada11 As Double = TraerNumeroCadena(leelinea, ";", 11)
            Dim valEntrada12 As Double = TraerNumeroCadena(leelinea, ";", 12)
            Dim valSalida As Double = TraerNumeroCadena(leelinea, ";", 13)

            entrada(limValores) = New Double() {valEntrada1, valEntrada2, valEntrada3, valEntrada4, valEntrada5, valEntrada6, valEntrada7, valEntrada8, valEntrada9, valEntrada10, valEntrada11, valEntrada12}
            salida(limValores) = New Double() {valSalida}

            limValores += 1
        End While
        archivo.Close()
        Return limValores
    End Function

    Private Function TraerNumeroCadena(linea As String, delimitador As Char, numeroToken As Integer) As Double
        Dim numero As String = ""
        Dim numTrae As Integer = 0

        For Each t As Char In linea
            If t <> delimitador Then
                numero = numero & t
            Else
                numTrae = numTrae + 1
                If numTrae = numeroToken Then
                    numero = numero.Trim()
                    If numero = "" Then Return 0
                    Return Val(numero)
                End If
                numero = ""
            End If
        Next
        numero = numero.Trim()
        If numero = "" Then Return 0
        Return Val(numero)


    End Function

End Module