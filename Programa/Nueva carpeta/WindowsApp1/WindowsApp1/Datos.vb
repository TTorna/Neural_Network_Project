Public Class Datos
    Public devolucion As String
    Public devolucion_Act_Pas As String
    Public Prediccion_Historial As String

    Private Sub New_Config()

    End Sub

    Public Function ModificarRubro(Accion As Integer, IdRubro As Integer, tipo As Integer, Descripcion As String) As Boolean
        Dim sql As String
        Dim conex As New BaseDeDatadosConexion
        Try
            sql = "Use BDC; Call Actualizar_Rubro(" + Str(Accion) + ", " + Str(IdRubro) + ", " + Str(tipo) + ", '" + Descripcion + "');"
            conex.EjecutarSql(sql)
            conex.Dispose()

            Return 1
        Catch ex As Exception
            'MsgBox("Error" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
            Return 0
        End Try
    End Function
    Public Function ModificarActivo(Accion As Integer, IdActivo As Integer, Nombre As String, Link As String, Rubro As Integer) As Boolean
        Dim sql As String
        Dim conex As New BaseDeDatadosConexion
        Try
            sql = "Use BDC; Call Actualizar_Activo(" + Str(Accion) + ", " + Str(IdActivo) + ", '" + Nombre + "', '" + Link + "', " + Str(Rubro) + ");"
            conex.EjecutarSql(sql)
            conex.Dispose()

            Return 1
        Catch ex As Exception
            'MsgBox("Error" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
            Return 0
        End Try
    End Function

    Public Function VPredictor(Mail As String, Resultado As String, ind1 As Double, ind2 As Double, ind3 As Double, ind4 As Double, ind5 As Double, ind6 As Double, ind7 As Double, ind8 As Double, ind9 As Double, ind10 As Double, ind11 As Double, ind12 As Double) As Boolean
        Dim sql As String
        Dim conex As New BaseDeDatadosConexion
        Try
            sql = "Use BDC; Call Predictor_Completo('" + Mail + "', '" + Resultado + "', " + Str(ind1) + ", " + Str(ind2) + ", " + Str(ind3) + ", " + Str(ind4) + ", " + Str(ind5) + ", " + Str(ind6) + ", " + Str(ind7) + ", " + Str(ind8) + ", " + Str(ind9) + ", " + Str(ind10) + ", " + Str(ind11) + ", " + Str(ind12) + ");"
            conex.EjecutarSql(sql)
            conex.Dispose()

            Return 1
        Catch ex As Exception
            'MsgBox("Error" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
            Return 0
        End Try
    End Function

    Public Function Validar(vMail As String, vNombre As String, vApellido As String, vNumero As String, vPerfil As Integer, vContraseña As String, Opcion As Integer) As Boolean
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
                    sql = "Use BDC; Call Register( '" + vMail + "', '" + vNombre + "', '" + vApellido + "', '" + vNumero + "', " + Str(vPerfil) + ", '" + vContraseña + "');"

                    conex.EjecutarSql(sql)
                    MsgBox("los datos se ingresaron correctamente", MsgBoxStyle.Information, "Insertar Datos")
                    conex.Dispose()
                    Return 1
                Catch ex As Exception
                    MsgBox("Error" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
                    Return 0
                End Try
            Else
                If Opcion = 2 Then
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
                Else
                    If Opcion = 3 Then
                        Try
                            sql = "Use BDC; Call Act_Pas_Usuario('" + vMail + "', '" + vNombre + "', '" + vApellido + "', '" + vNumero + "');"
                            conex.EjecutarSql(sql)

                            Dim Respuesta As String
                            Respuesta = conex.micomando.ExecuteScalar()
                            conex.Dispose()

                            If Respuesta = "" Then
                                Return 0
                            Else
                                devolucion_Act_Pas = Respuesta
                                Return 1
                            End If

                        Catch ex As Exception
                            'MsgBox("Error" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
                            Return 0
                        End Try
                    Else
                        If Opcion = 4 Then
                            Try
                                sql = "Use BDC; Call ValidacionMail('" + vMail + "');"
                                conex.EjecutarSql(sql)

                                Dim Respuesta As String
                                Respuesta = conex.micomando.ExecuteScalar()
                                conex.Dispose()

                                If Respuesta = 0 Then
                                    Return 0
                                Else
                                    Return 1
                                End If

                            Catch ex As Exception
                                'MsgBox("Error" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
                                Return 0
                            End Try
                        Else
                            If Opcion = 5 Then
                                Try
                                    sql = "Use BDC; Call Pedir_Historial('" + vNombre + "', '" + vMail + "');"
                                    conex.EjecutarSql(sql)

                                    Dim Respuesta As String
                                    Respuesta = conex.micomando.ExecuteScalar()
                                    conex.Dispose()

                                    Prediccion_Historial = Respuesta

                                    Return 1
                                Catch ex As Exception
                                    'MsgBox("Error" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
                                    Return 0
                                End Try
                            Else
                                Try
                                    sql = "Use BDC; Call loginAdmin('" + vMail + "', '" + vNombre + "', '" + vApellido + "', '" + vContraseña + "');"
                                    conex.EjecutarSql(sql)

                                    Dim Respuesta As Boolean
                                    Respuesta = conex.micomando.ExecuteScalar()
                                    conex.Dispose()

                                    Return Respuesta
                                Catch ex As Exception
                                    'MsgBox("Error" & vbCrLf & ex.Message, MsgBoxStyle.Critical, "Insertar Datos")
                                    Return 0
                                End Try
                            End If
                        End If
                        End If
                    End If
            End If
        End If

        Return 0
    End Function

End Class
