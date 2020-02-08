Imports CrystalDecisions.Shared

Module VARIABLES_GLOBALES
    Public cmm As New SqlClient.SqlCommand

    '** VARIABLES PARA CONEXION A LA BBDD ******
    Public conexionbd As String
    Public usuario_, contrasena_ As String
    Public usuario_AUX, contrasena_AUX As String
    Public servidor, servidor_AUX, bbdd As String
    Public SQLconexion As New SqlClient.SqlConnection

    Public b_CreditoContado As Integer
    Public Valor_Contado As Integer
    Public Valor_CreditoContado As Integer
    Public Valor_CreditoNormal As Integer
    Public b_CreditoNormal As Integer
    Public fecha_VencimientoCredito As Date
    Public b_abierto As Integer
    Public IDENTIFICADOR1, IDENTIFICADOR2 As String
    Public Contador_MovCaja_Apertura As Integer
    Public Contador_paraCaja As Integer
    '****VARIABLES DE USUARIOS CONECTADOS
    Public conectado01 As String
    Public cod_usuario01 As Integer

    Public OPERADOR As String
    Public Inicio_Sesion As Date
    Public sumatoria_monto_universal As Integer

    Public iconexion As ConnectionInfo = New ConnectionInfo()

    'PARA VERIFICAR TIPO DE COMPRA
    Public ARCA As Integer
    Public TU_VENDEDOR As Integer
    Public NEW_ACTION As Integer
    Public CODIGO_TITULAR As Integer

    'REPORTE PARA DOCUMENTO DE FACTURACION
    Public Valor_ParaReporteFactura As String

End Module
