﻿Public Class Perceptron
    Private W As Double(,,)
    Private U As Double(,)
    Private A As Double(,)
    Private WN As Double(,,)
    Private UN As Double(,)
    Private TotalCapas As Integer
    Private neuronasporcapa As Integer()
    Private TotalEntradas As Integer
    Private TotalSalidas As Integer

    Public Sub New(ByVal TotalEntradas As Integer, ByVal TotalSalidas As Integer, ByVal TotalCapas As Integer, ByVal neuronasporcapa As Integer())
        Me.TotalEntradas = TotalEntradas
        Me.TotalSalidas = TotalSalidas
        Me.TotalCapas = TotalCapas
        Dim maxNeuronas As Integer = 0
        Me.neuronasporcapa = New Integer(TotalCapas) {}

        For capa As Integer = 0 To TotalCapas
            Me.neuronasporcapa(capa) = neuronasporcapa(capa)
            If neuronasporcapa(capa) > maxNeuronas Then maxNeuronas = neuronasporcapa(capa) - 1
        Next

        W = New Double(TotalCapas, maxNeuronas, maxNeuronas) {}
        U = New Double(TotalCapas, maxNeuronas) {}
        WN = New Double(TotalCapas, maxNeuronas, maxNeuronas) {}
        UN = New Double(TotalCapas, maxNeuronas) {}
        A = New Double(TotalCapas, maxNeuronas) {}
        Dim azar As Random = New Random()

        For capa As Integer = 1 To TotalCapas-1

            For i As Integer = 0 To neuronasporcapa(capa) - 1
                U(capa, i) = azar.NextDouble()
            Next
        Next

        For capa As Integer = 0 To TotalCapas - 1

            For i As Integer = 0 To neuronasporcapa(capa) - 1

                For j As Integer = 0 To neuronasporcapa(capa + 1) - 1
                    W(capa, i, j) = azar.NextDouble()
                Next
            Next
        Next
    End Sub

    Public Sub Procesa(E As Double())
        For copia As Integer = 0 To TotalEntradas - 1
            'Console.WriteLine(" A: " + Str(A(0, copia)))
            A(0, copia) = E(copia)
        Next


        For capa As Integer = 1 To TotalCapas

            For cont As Integer = 0 To neuronasporcapa(capa) - 1
                A(capa, cont) = 0

                For entra As Integer = 0 To neuronasporcapa(capa - 1) - 1
                    A(capa, cont) += A(capa - 1, entra) * W(capa - 1, entra, cont)
                Next

                A(capa, cont) += U(capa, cont)
                A(capa, cont) = 1 / (1 + Math.Exp(-A(capa, cont)))
            Next
        Next
    End Sub

    Public Function Muestra(capa As Integer, inicial As Integer, final As Integer) As Double
        Dim resultado As Double = WN(capa, inicial, final)
        Return resultado
    End Function
    Public Function Muestra2(capa As Integer, inicial As Integer) As Double
        Dim resultado As Double = UN(capa, inicial)
        Return resultado
    End Function


    Public Sub Entrena(ByVal alpha As Double, ByVal E As Double(), ByVal S As Double())
        For j As Integer = 0 To neuronasporcapa(2) - 1

            For i As Integer = 0 To neuronasporcapa(3) - 1
                Dim Yi As Double = A(3, i)
                Dim dE3 As Double = A(2, j) * (Yi - S(i)) * Yi * (1 - Yi)
                WN(2, j, i) = W(2, j, i) - alpha * dE3
            Next
        Next

        For j As Integer = 0 To neuronasporcapa(1) - 1

            For k As Integer = 0 To neuronasporcapa(2) - 1
                Dim acum As Double = 0

                For i As Integer = 0 To neuronasporcapa(3) - 1
                    Dim Yi As Double = A(3, i)
                    acum += W(2, k, i) * (Yi - S(i)) * Yi * (1 - Yi)
                Next

                Dim dE2 As Double = A(1, j) * A(2, k) * (1 - A(2, k)) * acum
                WN(1, j, k) = W(1, j, k) - alpha * dE2
            Next
        Next

        For j As Integer = 0 To neuronasporcapa(0) - 1

            For k As Integer = 0 To neuronasporcapa(1) - 1
                Dim acumular As Double = 0

                For p As Integer = 0 To neuronasporcapa(2) - 1
                    Dim acum As Double = 0

                    For i As Integer = 0 To neuronasporcapa(3) - 1
                        Dim Yi As Double = A(3, i)
                        acum += W(2, p, i) * (Yi - S(i)) * Yi * (1 - Yi)
                    Next

                    acumular += W(1, k, p) * A(2, p) * (1 - A(2, p)) * acum
                Next

                Dim dE1 As Double = E(j) * A(1, k) * (1 - A(1, k)) * acumular
                WN(0, j, k) = W(0, j, k) - alpha * dE1
            Next
        Next

        For i As Integer = 0 To neuronasporcapa(3) - 1
            Dim Yi As Double = A(3, i)
            Dim dE4 As Double = (Yi - S(i)) * Yi * (1 - Yi)
            UN(3, i) = U(3, i) - alpha * dE4
        Next

        For k As Integer = 0 To neuronasporcapa(2) - 1
            Dim acum As Double = 0

            For i As Integer = 0 To neuronasporcapa(3) - 1
                Dim Yi As Double = A(3, i)
                acum += W(2, k, i) * (Yi - S(i)) * Yi * (1 - Yi)
            Next

            Dim dE3 As Double = A(2, k) * (1 - A(2, k)) * acum
            UN(2, k) = U(2, k) - alpha * dE3
        Next

        For k As Integer = 0 To neuronasporcapa(1) - 1
            Dim acumular As Double = 0

            For p As Integer = 0 To neuronasporcapa(2) - 1
                Dim acum As Double = 0

                For i As Integer = 0 To neuronasporcapa(3) - 1
                    Dim Yi As Double = A(3, i)
                    acum += W(2, p, i) * (Yi - S(i)) * Yi * (1 - Yi)
                Next

                acumular += W(1, k, p) * A(2, p) * (1 - A(2, p)) * acum
            Next

            Dim dE2 As Double = A(1, k) * (1 - A(1, k)) * acumular
            UN(1, k) = U(1, k) - alpha * dE2
        Next

        For capa As Integer = 1 To TotalCapas

            For i As Integer = 0 To neuronasporcapa(capa) - 1
                U(capa, i) = UN(capa, i)
            Next
        Next

        For capa As Integer = 0 To TotalCapas - 1

            For i As Integer = 0 To neuronasporcapa(capa) - 1

                For j As Integer = 0 To neuronasporcapa(capa + 1) - 1
                    W(capa, i, j) = WN(capa, i, j)
                Next
            Next
        Next
    End Sub
End Class
