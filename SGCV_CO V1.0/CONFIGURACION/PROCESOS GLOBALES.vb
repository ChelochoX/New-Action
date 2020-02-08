
Module PROCESOS_GLOBALES

    'ACTUALIZAR ESTADO DE CONECTADO***************************
    Function verificar_empresa() As Integer
        Try
            Dim cmm As New SqlClient.SqlCommand
            Dim conexion As New SqlClient.SqlConnection
            conexion.ConnectionString = conexionbd
            Dim sel As String

            sel = "SELECT COUNT(*) FROM CONFIG_EMPRESA"
            cmm = New SqlClient.SqlCommand(sel, conexion)
            conexion.Open()
            Dim t As Integer = CInt(cmm.ExecuteScalar())
            conexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Function

End Module
