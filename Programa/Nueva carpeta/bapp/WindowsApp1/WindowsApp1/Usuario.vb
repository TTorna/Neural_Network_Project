Public Class Usuario
    Public Mail As String
    Public Nombre As String
    Public Apellido As String
    Public Numero_telefonico As Integer
    Public Contraseña As String
    Public Perfil As String = PerfilUser.Seleccion
    Private Accion As String
    Public IdIndicador() As Integer
    Public Activo As String
    Public config As String
    Dim obj = New Datos()

    Public Sub New()

    End Sub

    Public Property _Accion As String
        Get
            Return Accion
        End Get
        Set(value As String)
            Accion = value
        End Set
    End Property

    'Public Sub Elegir_Indicadores()

    'End Sub

    'Public Sub Elegir_Activo()

    'End Sub

    Public Sub Configurar_Indicador()

    End Sub


    Public Sub Usuario()

    End Sub

    Public Function Loguear(vMail As String, vNombre As String, vApellido As String, vContraseña As String) As Boolean
        Return obj.Validar(vMail, vNombre, vApellido, "", vContraseña, 1)
    End Function

    Public Function Registrar(vMail As String, vNombre As String, vApellido As String, vNumero As String, vContraseña As String) As Boolean
        Return obj.Datos.Validar(vMail, vNombre, vApellido, vNumero, vContraseña, 0)
    End Function

    Public Function Act_Usuario(vMail As String, vNombre As String, vApellido As String, vNumero As String) As Boolean
        Contraseña = obj.devolucion
        Return obj.validar(vMail, vNombre, vApellido, vNumero, "", 2)
    End Function

    Private Function Validar() As Boolean

        Return 0
    End Function

End Class
