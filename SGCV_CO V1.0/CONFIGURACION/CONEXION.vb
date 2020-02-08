Module CONEXION
    Public Sub conectar()
        'usuario_ = "clezcano"
        usuario_ = "sa"
        contrasena_ = "Cesar1983"
        servidor = "DESKTOP-H4K2D1O"
        'servidor = "DESKTOP-6MM02FV"
        bbdd = "NEW ACTION"
        'bbdd = "TU VENDEDOR V1.1.0"
        conexionbd = "server ='" & servidor & "';database ='" & bbdd & "' ; user id ='" & usuario_ & "'; password ='" & contrasena_ & "'"
        SQLconexion.ConnectionString = conexionbd

    End Sub
End Module
