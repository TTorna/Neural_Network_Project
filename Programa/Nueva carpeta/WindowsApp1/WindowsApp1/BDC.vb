Public Class BDC
    Public Pesos(100) As Double
    Public Umbrales(7) As Double

    Public Sub LevantarPesos()
        Dim i As Integer = 0
        Dim j As Integer = 0
        Dim PesosRuta As String = "F:\Programacion\pesos.txt"
        Dim UmbralesRuta As String = "F:\Programacion\umbrales.txt"

        Dim MiArPesos As New System.IO.StreamReader(PesosRuta)

        While MiArPesos.Peek() <> -1
            Pesos(i) = MiArPesos.ReadLine()
            'Console.WriteLine(pesos(i))
            i += 1
        End While

        MiArPesos.Close()

        Dim MiArUmbrales As New System.IO.StreamReader(UmbralesRuta)

        While MiArUmbrales.Peek() <> -1
            Umbrales(j) = MiArUmbrales.ReadLine()
            'Console.WriteLine(pesos(i))
            j += 1
        End While

        MiArUmbrales.Close()
    End Sub
End Class
