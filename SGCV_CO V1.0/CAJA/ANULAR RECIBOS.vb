
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System
Imports System.IO
Imports System.Diagnostics

Public Class ANULAR_RECIBOS

    Dim busqueda As Integer
    Dim FECHA_INICIAL, FECHA_FINAL As Date
    Dim DaDetalleRecibo, DaRecibo As New SqlClient.SqlDataAdapter
    Dim DSDetalleRecibo, DsRecibo As New Data.DataSet
    Dim valor As String
    Dim SUMARECIBO_TOTAL_DETMOVCAJA, SUMAFACTURA_TOTAL_DETMOVCAJA, paraCODCAJA, MONTO_APERTURA, DECUENTO_ESPECIAL As Integer
    Dim deposito_, codigo_recibo, paraCodigo, COD_RECIBO, INTERES_MORATORIO As Integer
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

    Sub SetDBLogonForReport(ByVal myConnectionInfo As ConnectionInfo, ByVal myReportDocument As ReportDocument)
        Dim myTables As Tables = myReportDocument.Database.Tables
        For Each myTable As CrystalDecisions.CrystalReports.Engine.Table In myTables
            Dim myTableLogonInfo As TableLogOnInfo = myTable.LogOnInfo
            myTableLogonInfo.ConnectionInfo = myConnectionInfo
            myTable.ApplyLogOnInfo(myTableLogonInfo)
        Next
    End Sub

    Sub Cargar_Datos()
        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM CP_DETALLE_RECIBO"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaDetalleRecibo = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsDetalleRecibo = New Data.DataSet
            DaDetalleRecibo.Fill(Me.DsDetalleRecibo, "CP_DETALLE_RECIBO")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

    End Sub


    Function paraInteresMora(ByVal a As Integer, ByVal b As String, ByVal c As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COALESCE(IMPORTE_CUOTA,0) FROM CP_DETALLE_RECIBO " & _
            "WHERE COD_CABECERA_RECIBO = " & a & " AND FACTURA_NUMERO = '" & b & "' AND CUOTA_NUMERO = '" & c & "'"
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

    Private Sub ANULAR_RECIBOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        busqueda = 0
        Dim Estado_Caja As Integer
        Estado_Caja = EstadoCaja("HABILITADO", Today)
        Contador_MovCaja_Apertura = Estado_Caja


        iconexion.DatabaseName = bbdd
        iconexion.UserID = usuario_
        iconexion.Password = contrasena_
        iconexion.ServerName = servidor
        iconexion.Type = ConnectionInfoType.SQL

    End Sub

    Private Sub btnBuscar_Facturacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar_Facturacion.Click
        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM CP_CABECERA_RECIBO WHERE FECHA BETWEEN '" & FECHA_INICIAL & "' AND '" & FECHA_FINAL & "'"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaRecibo = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            Dim dt1 As New DataTable("CP_CABECERA_RECIBO")
            DaRecibo.Fill(dt1)
            SQLconexion.Close()
            With ltsDetallesBusqueda
                .DataSource = dt1
                .DisplayMember = "DOCUMENTO"
                .ValueMember = "NUM_RECIBO"
                .Refresh()
            End With
        Catch ex As Exception
            MsgBox(ex.Message())
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

    Private Sub ltsDetallesBusqueda_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ltsDetallesBusqueda.Click

        valor = Trim(Me.ltsDetallesBusqueda.Text)
        paraCodigo = Codigo_CabRecibo(valor)
        codigo_recibo = paraCodigo

        Try
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter("PAGO_RECIBO", SQLconexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@NUMERO_RECIBO", valor)
            da.Fill(dt)

            Dim ds As New Data.DataSet
            ds.Tables.Add(dt)

            Dim info As New RECIBO_DE_DINERO_

            info.SetDataSource(ds)
            info.SetParameterValue("@NUMERO_RECIBO", valor)
            SetDBLogonForReport(iconexion, info)
            Me.CrystalReportViewer1.ReportSource = info

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            SQLconexion.Close()
        End Try
        Me.txtObs_Anulacion.Focus()


    End Sub

    Function CONTROL_ANULACION(ByVal A As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM ANULAR_DOCUMENTOS WHERE NUMERO_DOCUMENTO = '" & A & "' "
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

    Function Contador_AnularRecibo() As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM ANULAR_DOCUMENTOS"
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

    Function Codigo_CabRecibo(ByVal a As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COD_CABECERA_RECIBO FROM CP_CABECERA_RECIBO WHERE NUM_RECIBO = '" & a & "'"
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

    Function Codigo_Cliente(ByVal a As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COD_CLIENTE FROM CP_CABECERA_RECIBO WHERE NUM_RECIBO = '" & a & "'"
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

    'VERIFICAR CANTIDAD DE CUOTAS POR CUENTA DE CLIENTE**
    Function Cantidad_CuotaCliente(ByVal a As Integer, ByVal b As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT MAX(CUOTA) FROM VF_DETALLE_CUENTACLIENTE WHERE DOCUMENTO_FACTURACION = '" & b & "' AND COD_CLIENTE = " & a & ""
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

    'VERIFICAR SI HAY DESCUENTO ESPECIAL**
    Function VerDescuentoEsp(ByVal a As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT DESCUENTOS_ESPECIALES FROM CP_CABECERA_RECIBO WHERE COD_CABECERA_RECIBO = " & a & ""
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
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Cargar_Datos()

        If CONTROL_ANULACION(valor) = 1 Then
            MessageBox.Show("DOCUMENTO YA FUE ANULADO", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtObs_Anulacion.Clear()
        Else
            Try
                Dim contador As Integer
                contador = Contador_AnularRecibo() + 1
                SQLconexion.Open()
                Dim sqlbuilder As New System.Text.StringBuilder
                With sqlbuilder
                    .Append("INSERT INTO ANULAR_DOCUMENTOS")
                    .Append(" VALUES ('")
                    .Append(contador & "','")
                    .Append(0 & "','")
                    .Append(codigo_recibo & "','")
                    .Append(valor & "','")
                    .Append("RECIBO DE DINERO" & "','")
                    .Append(CDate(Today) & "','")
                    .Append(Trim(Me.txtObs_Anulacion.Text) & "')")

                End With
                cmm = New SqlClient.SqlCommand(sqlbuilder.ToString, SQLconexion)
                cmm.ExecuteNonQuery()
                SQLconexion.Close()
                cmm.Dispose()
                SQLconexion.Dispose()


                Me.txtObs_Anulacion.Clear()

            Catch ex As SqlClient.SqlException
                MsgBox(ex.Message())
                SQLconexion.Close()
            End Try
            '************************************************
            Dim paraCodigoCli As Integer
            paraCodigo = Codigo_CabRecibo(valor)
            paraCodigoCli = Codigo_Cliente(valor)
            Dim DOCUMENTO, CUOTA, paraMontoDetRecibo As String
            Dim MONTO, aux_Cuota As Integer
            Dim Cantidad_Cuota As Integer

            'RETORNAR LAS CUENTAS A SU ESTADO ORIGINAL
            Dim i As Integer
            For i = 0 To Me.BindingContext(Me.DsDetalleRecibo, "CP_DETALLE_RECIBO").Count - 1
                Me.BindingContext(Me.DsDetalleRecibo, "CP_DETALLE_RECIBO").Position = i
                If paraCodigo = CInt(Me.DSDetalleRecibo.Tables("CP_DETALLE_RECIBO").Rows(Me.BindingContext(Me.DSDetalleRecibo, "CP_DETALLE_RECIBO").Position).Item("COD_CABECERA_RECIBO").ToString) Then
                    DOCUMENTO = Trim(Me.DSDetalleRecibo.Tables("CP_DETALLE_RECIBO").Rows(Me.BindingContext(Me.DSDetalleRecibo, "CP_DETALLE_RECIBO").Position).Item("FACTURA_NUMERO").ToString)
                    MONTO = CInt(Me.DSDetalleRecibo.Tables("CP_DETALLE_RECIBO").Rows(Me.BindingContext(Me.DSDetalleRecibo, "CP_DETALLE_RECIBO").Position).Item("IMPORTE_CUOTA"))
                    CUOTA = Trim(Me.DSDetalleRecibo.Tables("CP_DETALLE_RECIBO").Rows(Me.BindingContext(Me.DSDetalleRecibo, "CP_DETALLE_RECIBO").Position).Item("CUOTA_NUMERO"))
                    COD_RECIBO = CInt(Me.DSDetalleRecibo.Tables("CP_DETALLE_RECIBO").Rows(Me.BindingContext(Me.DSDetalleRecibo, "CP_DETALLE_RECIBO").Position).Item("COD_CABECERA_RECIBO").ToString)
                    'INTERES_MORATORIO = paraInteresMora(paraCodigo, "INTERES MORATORIO CUOTA", CUOTA)
                    'DECUENTO_ESPECIAL = VerDescuentoEsp(paraCodigo)
                    DECUENTO_ESPECIAL = 0
                    INTERES_MORATORIO = 0

                    If DOCUMENTO <> "INTERES MORATORIO CUOTA" Then
                        Cantidad_Cuota = Cantidad_CuotaCliente(paraCodigoCli, DOCUMENTO)
                        paraMontoDetRecibo = Trim(CUOTA.Substring(0, 1))
                        aux_Cuota = Int(paraMontoDetRecibo)

                        'EXTRAE MONTO EN CUENTA SI HAY SALDO*******
                        Dim Monto_enCuenta, para_MontoCuota, Monto_enHistorial As Integer
                        Monto_enHistorial = Monto_enHistorialCliente(aux_Cuota, DOCUMENTO, paraCodigoCli, paraCodigo)
                        Monto_enCuenta = Monto_enCuentaCliente(aux_Cuota, DOCUMENTO, paraCodigoCli)
                        para_MontoCuota = ((Monto_enHistorial + DECUENTO_ESPECIAL) - INTERES_MORATORIO) + Monto_enCuenta
                        'ACTUALIZA CUENTA DE CLIENTE
                        Try
                            conectar()
                            Dim sel As String
                            sel = "UPDATE VF_DETALLE_CUENTACLIENTE SET ESTADO_CUOTA = '" & "PENDIENTE" & "',MONTO_CUOTA = " & para_MontoCuota & " " & _
                            "WHERE DOCUMENTO_FACTURACION = '" & DOCUMENTO & "' AND " & _
                            "CUOTA = " & aux_Cuota & " AND COD_CLIENTE = " & paraCodigoCli & ""
                            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                            SQLconexion.Open()
                            Dim t As Integer = CInt(cmm.ExecuteScalar())
                            cmm.Dispose()
                            SQLconexion.Close()

                        Catch ex As Exception
                            MsgBox(ex.Message())
                            SQLconexion.Close()
                        End Try
                        'ACTUALIZA HISTORIAL DE PAGO EN CUENTA CLIENTE
                        Try
                            conectar()
                            Dim sel As String
                            sel = "DELETE FROM VF_HISTORIAL_PAGO_CUENTACLIENTE " & _
                            "WHERE DOCUMENTO_FACTURACION = '" & DOCUMENTO & "' AND " & _
                            "CUOTA = " & aux_Cuota & " AND COD_CLIENTE = " & paraCodigoCli & " AND COD_RECIBO = " & COD_RECIBO & ""
                            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                            SQLconexion.Open()
                            Dim t As Integer = CInt(cmm.ExecuteScalar())
                            cmm.Dispose()
                            SQLconexion.Close()

                        Catch ex As Exception
                            MsgBox(ex.Message())
                            SQLconexion.Close()
                        End Try
                    End If
                End If
            Next

            Try
                conectar()
                Dim sel As String
                sel = "DELETE FROM CP_DETALLE_CAJA " & _
                "WHERE RECIBO_NUMERO = '" & valor & "' AND " & _
                "COD_CAB_CAJA = " & Contador_MovCaja_Apertura & ""
                cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                SQLconexion.Open()
                Dim t As Integer = CInt(cmm.ExecuteScalar())
                cmm.Dispose()
                SQLconexion.Close()

            Catch ex As Exception
                MsgBox(ex.Message())
                SQLconexion.Close()
            End Try

            Me.CrystalReportViewer1.ReportSource = Nothing
            MessageBox.Show("PROCESADO CORRECTAMENTE CORRECTAMENTE", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Function Monto_enCuentaCliente(ByVal a As Integer, ByVal b As String, ByVal c As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT MONTO_CUOTA FROM VF_DETALLE_CUENTACLIENTE WHERE CUOTA = " & a & " AND DOCUMENTO_FACTURACION = '" & b & "' AND COD_CLIENTE = " & c & ""
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

    Function Monto_enHistorialCliente(ByVal a As Integer, ByVal b As String, ByVal c As Integer, ByVal d As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT MONTO_CUOTA FROM VF_HISTORIAL_PAGO_CUENTACLIENTE WHERE CUOTA = " & a & " AND DOCUMENTO_FACTURACION = '" & b & "' AND COD_CLIENTE = " & c & " AND COD_RECIBO = " & d & ""
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

    Function MONTOAPERTURA(ByVal a As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT MONTO_APERTURA FROM CP_CAJA WHERE COD_CAJA = " & a & ""
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

    Function paraCodigoCaja(ByVal a As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COD_CAJA FROM CP_CABECERA_MOVIMIENTO_CAJA WHERE COD_CABECERA_MOVIMIENTO_CAJA = " & a & ""
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

    Function SUMARECIBO_DETMOVCAJA(ByVal a As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COALESCE(SUM(MONTO_RECIBO),0) FROM CP_DETALLE_CAJA WHERE COD_CAB_CAJA = " & a & ""
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

    Function SUMAFACTURA_DETMOVCAJA(ByVal a As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COALESCE(SUM(MONTO_FACTURA),0) FROM CP_DETALLE_CAJA WHERE COD_CAB_CAJA = " & a & ""
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

    Private Sub btnLimpiarBusqueda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiarBusqueda.Click
        Me.CrystalReportViewer1.ReportSource = Nothing
        Me.txtObs_Anulacion.Clear()
        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM CP_CABECERA_RECIBO WHERE COD_CABECERA_RECIBO =  " & 0 & ""
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaRecibo = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            Dim dt1 As New DataTable("CP_CABECERA_RECIBO")
            DaRecibo.Fill(dt1)
            SQLconexion.Close()
            With ltsDetallesBusqueda
                .DataSource = dt1
                .DisplayMember = "DOCUMENTO"
                .ValueMember = "NUM_RECIBO"
                .Refresh()
            End With
        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class