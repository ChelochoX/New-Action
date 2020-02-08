
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System
Imports System.IO
Imports System.Diagnostics

Public Class VISUALIZAR_FACTURACIONES


    Dim busqueda As Integer
    Dim FECHA_INICIAL, FECHA_FINAL As Date
    Dim DaFactura, DaFactura1, DaStock, DaDetalle As New SqlClient.SqlDataAdapter
    Dim DsFactura, DsStock, DsDetalle As New Data.DataSet
    Dim valor As String
    Dim SUMARECIBO_TOTAL_DETMOVCAJA, SUMAFACTURA_TOTAL_DETMOVCAJA, paraCODCAJA, MONTO_APERTURA As Integer
    Dim deposito_ As Integer
    Dim deposito As String

    Function EstadoCaja(ByVal a As String, ByVal b As Date) As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COD_CAB_CAJA FROM CP_CABECERA_CAJA WHERE ESTADO = '" & a & "' AND FECHA_APERTURA = '" & b & "'"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As String = CStr(cmm.ExecuteScalar())
            cmm.Dispose()
            SQLconexion.Close()

            Return t
        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Function

    Function Recuperar_CabMovCaja(ByVal a As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "Select C.COD_CABECERA_MOVIMIENTO_CAJA FROM CP_ESTADO_CAJA E INNER JOIN CP_CAJA J ON " & _
            "E.COD_ESTADOCAJA = J.COD_ESTADOCAJA INNER JOIN CP_CABECERA_MOVIMIENTO_CAJA C " & _
            "ON J.COD_CAJA = C.COD_CAJA WHERE E.ESTADO = " & a & ""
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As Integer = CInt(cmm.ExecuteScalar())
            cmm.Dispose()
            SQLconexion.Close()

            Return t
        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Function

    Sub Cargar_Datos()
        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM SC_STOCK"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaStock = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsStock = New Data.DataSet
            DaStock.Fill(Me.DsStock, "SC_STOCK")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM VF_DETALLE_FACTURA"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaDetalle = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsDetalle = New Data.DataSet
            DaDetalle.Fill(Me.DsDetalle, "VF_DETALLE_FACTURA")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

    End Sub
    Sub SetDBLogonForReport(ByVal myConnectionInfo As ConnectionInfo, ByVal myReportDocument As ReportDocument)
        Dim myTables As Tables = myReportDocument.Database.Tables
        For Each myTable As CrystalDecisions.CrystalReports.Engine.Table In myTables
            Dim myTableLogonInfo As TableLogOnInfo = myTable.LogOnInfo
            myTableLogonInfo.ConnectionInfo = myConnectionInfo
            myTable.ApplyLogOnInfo(myTableLogonInfo)
        Next
    End Sub

    Private Sub VISUALIZAR_FACTURACIONES_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        busqueda = 0
        Dim Estado_Caja As Integer
        Estado_Caja = EstadoCaja("HABILITADO", Today)
        Contador_MovCaja_Apertura = Estado_Caja

        Cargar_Datos()

        iconexion.DatabaseName = bbdd
        iconexion.UserID = usuario_
        iconexion.Password = contrasena_
        'iconexion.ServerName = "DESKTOP-NQ5MUBD\SQLEXPRESS"
        iconexion.ServerName = servidor
        iconexion.Type = ConnectionInfoType.SQL

    End Sub

    Private Sub btnBuscar_Facturacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar_Facturacion.Click
        Try
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter("REPORTE_FACTURACIONES_POR_FECHA", SQLconexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@FECHA_INICIAL", FECHA_INICIAL)
            da.SelectCommand.Parameters.AddWithValue("@FECHA_FINAL", FECHA_FINAL)
            da.Fill(dt)

            Dim ds As New Data.DataSet
            ds.Tables.Add(dt)

            Dim info As New REPORTE_FACTURACIONES_POR_FECHA
            info.SetDataSource(ds)
            info.SetParameterValue("@FECHA_INICIAL", FECHA_INICIAL)
            info.SetParameterValue("@FECHA_FINAL", FECHA_FINAL)
            SetDBLogonForReport(iconexion, info)
            Me.CrystalReportViewer1.ReportSource = info

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            SQLconexion.Close()
        End Try
    End Sub

    Private Sub DateTimePicker1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateTimePicker1.Leave
        Dim fecha1 As Date
        fecha1 = Me.DateTimePicker1.Value.Date.AddDays(0)
        FECHA_INICIAL = fecha1
    End Sub

    Private Sub DateTimePicker2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateTimePicker2.Leave
        Dim fecha1 As Date
        fecha1 = Me.DateTimePicker2.Value.Date.AddDays(1)
        FECHA_FINAL = fecha1
    End Sub

    Function BUSQUEDA_IDENTIFICADOR(ByVal A As String) As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT IDENTIFICADOR FROM VF_CABECERA_FACTURA WHERE NUMERO_FACTURA = '" & A & "'"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As String = CStr(cmm.ExecuteScalar())
            cmm.Dispose()
            SQLconexion.Close()

            Return t
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try

    End Function

    Function paraDeposito(ByVal A As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COD_DEPOSITO FROM VF_CABECERA_FACTURA WHERE NUMERO_FACTURA = '" & A & "'"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As Integer = CInt(cmm.ExecuteScalar())
            cmm.Dispose()
            SQLconexion.Close()

            Return t
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try

    End Function

    Function Definir_Vendedor_arca(ByVal A As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT VENTA_ARCA FROM VF_CABECERA_FACTURA WHERE NUMERO_FACTURA = '" & A & "'"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As Integer = CInt(cmm.ExecuteScalar())
            cmm.Dispose()
            SQLconexion.Close()

            Return t
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try

    End Function

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    Private Sub btnLimpiarBusqueda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiarBusqueda.Click
       
        Me.CrystalReportViewer1.ReportSource = Nothing
    End Sub
End Class