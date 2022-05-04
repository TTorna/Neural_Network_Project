Public Class Usuario
    Public Mail As String = Form1.TxtMail.Text
    Public Nombre As String
    Public Apellido As String
    Public Contraseña As String
    Public PerfilDevo As String
    Public Perfil As String = PerfilUser.Seleccion
    Public UltimoResultadoHistorial As String
    Public IdIndicador() As Integer
    Public Activo As String
    Public config As String
    Dim obj = New Datos()

    Public Sub New()

    End Sub

    'Public Sub Elegir_Indicadores()

    'End Sub

    'Public Sub Elegir_Activo()

    'End Sub

    Public Sub Configurar_Indicador()

    End Sub

    Public Function Predictor(resultado As String, ind1 As Boolean, ind2 As Boolean, ind3 As Boolean, ind4 As Boolean, ind5 As Boolean, ind6 As Boolean, ind7 As Boolean, ind8 As Boolean, ind9 As Boolean, ind10 As Boolean, ind11 As Boolean, ind12 As Boolean) As Boolean
        Return obj.vpredictor(Mail, resultado, ind1, ind2, ind3, ind4, ind5, ind6, ind7, ind8, ind9, ind10, ind11, ind12)
    End Function

    Public Function Pedir_Historial(vDia As String) As Double
        obj.Validar(Mail, vDia, "", "", 0, "", 5)
        UltimoResultadoHistorial = obj.Prediccion_Historial
        If UltimoResultadoHistorial <> "" Then
            Return 1
        Else
            Return 0
        End If
    End Function

    Public Function Usuario(vMail As String, vNombre As String, vApellido As String, vNumero As String) As Boolean
        PerfilDevo = obj.devolucion_Act_Pas
        Return obj.Validar(vMail, vNombre, vApellido, vNumero, 0, "", 3)
    End Function

    Public Function Loguear(vMail As String, vNombre As String, vApellido As String, vContraseña As String) As Boolean
        Mail = vMail
        Nombre = vNombre
        Apellido = vApellido

        Return obj.Validar(vMail, vNombre, vApellido, "", 0, vContraseña, 1)
    End Function

    Public Function LoguearAdmin(vMail As String, vNombre As String, vApellido As String, vContraseña As String) As Boolean
        Return obj.Validar(vMail, vNombre, vApellido, "", 0, vContraseña, 6)
    End Function

    Public Function Registrar(vMail As String, vNombre As String, vApellido As String, vNumero As String, vContraseña As String) As Boolean
        Dim idPerfil As Integer
        If Perfil = "Activo" Then
            idPerfil = 1
        Else
            idPerfil = 2
        End If

        Return obj.Validar(vMail, vNombre, vApellido, vNumero, idPerfil, vContraseña, 0)
    End Function

    Public Function Act_Usuario(vMail As String, vNombre As String, vApellido As String, vNumero As String) As Boolean
        Contraseña = obj.devolucion
        Return obj.validar(vMail, vNombre, vApellido, vNumero, 0, "", 2)
    End Function

    Public Function Validar(vMail As String) As Boolean
        Return obj.validar(vMail, "", "", "", 0, "", 4)
    End Function

    Public Function ModificarRubro(Accion As Integer, IdRubro As Integer, tipo As Integer, Descripcion As String) As Boolean
        Return obj.Modificarrubro(Accion, IdRubro, tipo, Descripcion)
    End Function

    Public Function ModificarActivo(Accion As Integer, IdActivo As Integer, Nombre As String, Link As String, Rubro As Integer) As Boolean
        Return obj.ModificarActivo(Accion, IdActivo, Nombre, Link, Rubro)
    End Function

End Class
