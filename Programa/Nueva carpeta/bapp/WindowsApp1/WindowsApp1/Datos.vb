Public Class Datos
    Public devolucion As String
    Private Sub New_Config()

    End Sub

    Public Function Validar(vMail As String, vNombre As String, vApellido As String, vNumero As String, vContraseña As String, Opcion As Integer) As Boolean
        Dim sql As String
        Dim conex As New BaseDeDatadosConexion
        If Opcion = 1 Then
            Try
                sql = "Use BDC; Call Login('" + vMail + "', '" + vNombre + "', '" + vApellido + "', '" + vContraseña + "');"
                conex.EjecutarSql(sql)
                Dim Respuesta As Boolean
                Respuesta = conex.micomando.ExecuteScalar()
                conex.Dispose()

                Return Respuesta

            Catch ex As Exception
                MsgBox("Error" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
                Return 0
            End Try
        Else
            If Opcion = 0 Then
                Try
                    sql = "Use BDC; Call Register( '" + vMail + "', '" + vNombre + "', '" + vApellido + "', '" + vNumero + "', '" + PerfilUser.Seleccion + "', '" + vContraseña + "');"

                    conex.EjecutarSql(sql)
                    MsgBox("los datos se ingresaron correctamente", MsgBoxStyle.Information, "Insertar Datos")
                    conex.Dispose()
                    Return 1
                Catch ex As Exception
                    MsgBox("Error" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
                    Return 0
                End Try
            Else
                Try
                    sql = "Use BDC; Call Act_Usuario('" + vMail + "', '" + vNombre + "', '" + vApellido + "', '" + vNumero + "');"
                    conex.EjecutarSql(sql)

                    Dim Respuesta As String
                    Respuesta = conex.micomando.ExecuteScalar()
                    conex.Dispose()

                    If Respuesta = "" Then
                        Return 0
                    Else
                        devolucion = Respuesta
                        Return 1
                    End If

                Catch ex As Exception
                    'MsgBox("Error" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
                    Return 0
                End Try
            End If
        End If
            Return 0
    End Function

End Class
