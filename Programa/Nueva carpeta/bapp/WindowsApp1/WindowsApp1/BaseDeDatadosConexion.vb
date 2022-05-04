Imports MySql.Data.MySqlClient
Public Class BaseDeDatadosConexion
    Private miconexion As New MySqlConnection
    Public micomando As New MySqlCommand
    Public Sub New()
        Try
            miconexion.ConnectionString = "Server = localhost;Uid=root;pwd=et24"
            miconexion.Open()
            micomando.Connection = miconexion
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Public Sub EjecutarSql(SentenciaSQL As String)
        micomando.CommandText = SentenciaSQL
        micomando.ExecuteNonQuery()
    End Sub

    Public Sub Dispose()
        miconexion.Close()
        miconexion.Dispose()
        micomando.Dispose()
    End Sub
End Class
