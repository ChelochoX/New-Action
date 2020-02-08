Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System
Imports System.IO
Imports System.Diagnostics

Public Class GESTIONAR_COBRO

    Dim DaDetCC As New SqlClient.SqlDataAdapter
    Dim DsDetCC As New Data.DataSet
    Dim FORMA_PAGO As String
    Dim DaBanco, DaDetRec, DaDetCuenta_Cliente, DaInteres As New SqlClient.SqlDataAdapter
    Dim DsBanco, DsDetRec, DsDetCuenta_Cliente, DsInteres As New Data.DataSet

    Dim CUOTA, DIAS_AVENCER, MONTO_CUOTA, CODIGO_CLIENTE As Integer
    Dim VALOR_DOCUMENTO, TIPO_DOCUMENTO As String
    Dim contador_cabRecibo, b, IMPORTE_TOTAL_RECIBO, IMPORTE_TOTAL_FACTURA As Integer
    Dim FECHA_VENCIMIENTO, FECHA_FACTURACION As Date
    Dim NUM_RECIBO, secuencia_ticket, aux_num_recibo, paraMontoDetRecibo As String
    Dim IDENTIFICADOR_CONTADO, IDENTIFICADOR_CREDITO, CONTADOR_CHEQUE, CODIGO_FACTURA, SUMATORIA_TOTAL, SUMATORIA_TOTAL1 As Integer
    Dim SUMARECIBO_TOTAL_DETMOVCAJA, SUMAFACTURA_TOTAL_DETMOVCAJA, paraCODCAJA, MONTO_APERTURA As Integer
    Dim identificador_unclick, identificador_dobleclick As Integer
    Dim CODIGO_CLIENTE_, CABECERA_CUENTACLI, INTERES_MORATORIO, INTERES_MORATORIO1 As Integer
    Dim Contador_Historial_PagoCC, contador_detalleCaja As Integer
    Dim VALOR_CODCHEQUE As Integer
    Dim PARA_PAGOCUOTAS, PARA_PAGOINTERES, AUX_PAGO, AUX_PAGO1 As Integer
    Dim DetallesCheque As String

    Sub Cargar_Datos()
        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM TP_BANCO"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaBanco = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsBanco = New Data.DataSet
            DaBanco.Fill(Me.DsBanco, "TP_BANCO")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM VF_DETALLE_CUENTACLIENTE"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaDetCuenta_Cliente = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DaDetCuenta_Cliente.Fill(Me.DsDetCuenta_Cliente, "VF_DETALLE_CUENTACLIENTE")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
        End Try

        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM TP_INTERES"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaInteres = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DaInteres.Fill(Me.DsInteres, "TP_INTERES")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub

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

    Function Contador_Historial_Pago_CC() As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COALESCE(MAX(COD_HISTORIAL_PAGOCUENTACLI),0) FROM VF_HISTORIAL_PAGO_CUENTACLIENTE"
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

    Function paraDias_EnMora(ByVal a As String, ByVal b As Integer, ByVal c As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COALESCE(DIAS_A_VENCER,0) FROM VF_DETALLE_CUENTACLIENTE " & _
            "WHERE DOCUMENTO_FACTURACION = '" & a & "' AND CUOTA = " & b & " AND COD_CLIENTE = " & c & ""
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
    Private Sub GESTIONAR_COBRO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Cargar_Datos()

        Me.cbBanco.DataSource = Me.DsBanco.Tables("TP_BANCO")
        Me.cbBanco.DisplayMember = "NOMBRE"
        Me.GroupBox1.Enabled = False
        b = 0
        IDENTIFICADOR_CONTADO = 0
        IDENTIFICADOR_CREDITO = 0

        Dim Estado_Caja As Integer
        Estado_Caja = EstadoCaja("HABILITADO", Today)
        Contador_MovCaja_Apertura = Estado_Caja

        identificador_unclick = 0
        identificador_dobleclick = 0

        iconexion.DatabaseName = bbdd
        iconexion.UserID = usuario_
        iconexion.Password = contrasena_
        iconexion.ServerName = servidor

        iconexion.Type = ConnectionInfoType.SQL

        OPERADOR = usuario_

        Me.txtClienteCI.Focus()

    End Sub

    Function BUSQUEDA_IDENTIFICADOR(ByVal A As String) As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT IDENTIFICADOR FROM VF_CABECERA_FACTURA WHERE COD_CLIENTE = " & A & ""
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

    Function CodigoCli(ByVal a As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COD_CLIENTE FROM TP_CLIENTE WHERE CI = '" & a & "'"
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

    Function Cuenta_Cliente_(ByVal a As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COD_CABECERA_CUENTACLI FROM VF_CABECERA_CUENTACLIENTE WHERE COD_CLIENTE = " & a & ""
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

    Sub VER_DATOS_CLIENTE_CONTADO()
        Dim cedula As String
        cedula = Trim(Me.txtClienteCI.Text)
        Dim cod_cliente_ As Integer
        cod_cliente_ = CodigoCli(cedula)

        Try
            Dim sel As String
            sel = "SELECT * FROM VF_DETALLE_CUENTACLIENTE WHERE COD_CLIENTE = " & cod_cliente_ & " AND TIPO_DOCUMENTO = '" & "CONTADO" & "' AND ESTADO_CUOTA = '" & "PENDIENTE" & "' ORDER BY DIAS_A_VENCER ASC"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'limpiar el dataset
            Me.DsDetCC.Clear()
            'crear adapter
            DaDetCC = New SqlClient.SqlDataAdapter(cmm)
            DaDetCC.Fill(Me.DsDetCC, "VF_DETALLE_CUENTACLIENTE")
            'asignar dataset al datagrid
            Me.dgDetalleCuentCli.DataSource = Me.DsDetCC
            Me.dgDetalleCuentCli.DataMember = "VF_DETALLE_CUENTACLIENTE"

            DaDetCC.Update(Me.DsDetCC, "VF_DETALLE_CUENTACLIENTE")

        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Sub

    Sub VER_DATOS_CLIENTE_CONTADO_()
        Dim cedula As String
        cedula = 0
        Dim cod_cliente_ As Integer
        cod_cliente_ = CodigoCli(cedula)

        Try
            Dim sel As String
            sel = "SELECT * FROM VF_DETALLE_CUENTACLIENTE WHERE COD_CLIENTE = " & cod_cliente_ & " AND TIPO_DOCUMENTO = '" & "CONTADO" & "' AND ESTADO_CUOTA = '" & "PENDIENTE" & "' ORDER BY DIAS_A_VENCER ASC"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'limpiar el dataset
            Me.DsDetCC.Clear()
            'crear adapter
            DaDetCC = New SqlClient.SqlDataAdapter(cmm)
            DaDetCC.Fill(Me.DsDetCC, "VF_DETALLE_CUENTACLIENTE")
            'asignar dataset al datagrid
            Me.dgDetalleCuentCli.DataSource = Me.DsDetCC
            Me.dgDetalleCuentCli.DataMember = "VF_DETALLE_CUENTACLIENTE"

            DaDetCC.Update(Me.DsDetCC, "VF_DETALLE_CUENTACLIENTE")

        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Sub

    Sub VER_DATOS_CLIENTE_CREDITO()
        Dim cedula As String
        cedula = Trim(Me.txtClienteCI.Text)
        Dim cod_cliente_ As Integer
        cod_cliente_ = CodigoCli(cedula)

        Try
            Dim sel As String
            sel = "SELECT * FROM VF_DETALLE_CUENTACLIENTE WHERE COD_CLIENTE = " & cod_cliente_ & " AND TIPO_DOCUMENTO = '" & "CREDITO" & "' AND ESTADO_CUOTA = '" & "PENDIENTE" & "' ORDER BY DIAS_A_VENCER ASC"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'limpiar el dataset
            Me.DsDetCC.Clear()
            'crear adapter
            DaDetCC = New SqlClient.SqlDataAdapter(cmm)
            DaDetCC.Fill(Me.DsDetCC, "VF_DETALLE_CUENTACLIENTE")
            'asignar dataset al datagrid
            Me.dgDetalleCuentCli.DataSource = Me.DsDetCC
            Me.dgDetalleCuentCli.DataMember = "VF_DETALLE_CUENTACLIENTE"

            DaDetCC.Update(Me.DsDetCC, "VF_DETALLE_CUENTACLIENTE")

        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Sub

    Sub VER_DATOS_CLIENTE_CREDITO_()
        Dim cedula As String
        cedula = 0
        Dim cod_cliente_ As Integer
        cod_cliente_ = CodigoCli(cedula)

        Try
            Dim sel As String
            sel = "SELECT * FROM VF_DETALLE_CUENTACLIENTE WHERE COD_CLIENTE = " & cod_cliente_ & " AND TIPO_DOCUMENTO = '" & "CREDITO" & "' AND ESTADO_CUOTA = '" & "PENDIENTE" & "' ORDER BY DIAS_A_VENCER ASC"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'limpiar el dataset
            Me.DsDetCC.Clear()
            'crear adapter
            DaDetCC = New SqlClient.SqlDataAdapter(cmm)
            DaDetCC.Fill(Me.DsDetCC, "VF_DETALLE_CUENTACLIENTE")
            'asignar dataset al datagrid
            Me.dgDetalleCuentCli.DataSource = Me.DsDetCC
            Me.dgDetalleCuentCli.DataMember = "VF_DETALLE_CUENTACLIENTE"

            DaDetCC.Update(Me.DsDetCC, "VF_DETALLE_CUENTACLIENTE")

        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Sub
    Function BUSQUEDA_CODCLIENTE(ByVal a As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COD_CLIENTE FROM VF_DETALLE_CUENTACLIENTE WHERE DOCUMENTO_FACTURACION = '" & a & "'"
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
    Function BUSQUEDA_CODFACTURA(ByVal a As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COD_FACTURA FROM VF_CABECERA_FACTURA WHERE COD_CLIENTE = " & a & ""
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

    Private Sub dgDetalleCuentCli_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgDetalleCuentCli.Click

        Dim Cantidad_Cuota As Integer
        Dim auxiliar_cadena As String

        If Me.dgDetalleCuentCli.CurrentRowIndex < 0 Then

        Else
            VALOR_DOCUMENTO = Trim(Me.dgDetalleCuentCli.Item(Me.dgDetalleCuentCli.CurrentRowIndex, 0))
            CUOTA = Trim(Me.dgDetalleCuentCli.Item(Me.dgDetalleCuentCli.CurrentRowIndex, 1))
            DIAS_AVENCER = Trim(Me.dgDetalleCuentCli.Item(Me.dgDetalleCuentCli.CurrentRowIndex, 2))
            MONTO_CUOTA = Trim(Me.dgDetalleCuentCli.Item(Me.dgDetalleCuentCli.CurrentRowIndex, 3))
            FECHA_VENCIMIENTO = Trim(Me.dgDetalleCuentCli.Item(Me.dgDetalleCuentCli.CurrentRowIndex, 4))
            CODIGO_CLIENTE_ = CInt(Me.dgDetalleCuentCli.Item(Me.dgDetalleCuentCli.CurrentRowIndex, 5))
            CABECERA_CUENTACLI = CInt(Me.dgDetalleCuentCli.Item(Me.dgDetalleCuentCli.CurrentRowIndex, 6))

            CODIGO_CLIENTE = BUSQUEDA_CODCLIENTE(VALOR_DOCUMENTO)
            IDENTIFICADOR2 = BUSQUEDA_IDENTIFICADOR(CODIGO_CLIENTE)
            CODIGO_FACTURA = BUSQUEDA_CODFACTURA(CODIGO_CLIENTE)

            'NUM_RECIBO = ""
            identificador_unclick = 1

            Cantidad_Cuota = Cantidad_CuotaCliente(CODIGO_CLIENTE, VALOR_DOCUMENTO)
            paraMontoDetRecibo = CStr(CUOTA & "/" & Cantidad_Cuota)

            '*ACTUALIZAR CABECERA CUENTA CLIENE******************
            Dim para_ActualizarCabecera As Integer
            para_ActualizarCabecera = Auxiliar_ActualizarCabecera(VALOR_DOCUMENTO, CODIGO_CLIENTE_, "PENDIENTE")

            Try
                conectar()
                Dim sel As String
                sel = "UPDATE VF_CABECERA_CUENTACLIENTE SET MONTO_CUENTA = " & para_ActualizarCabecera & "" & _
                "WHERE COD_CABECERA_CUENTACLI = " & CABECERA_CUENTACLI & ""
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

    End Sub

    Function Auxiliar_ActualizarCabecera(ByVal a As String, ByVal b As Integer, ByVal c As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT SUM(MONTO_CUOTA) FROM VF_DETALLE_CUENTACLIENTE WHERE DOCUMENTO_FACTURACION = '" & a & "' AND COD_CLIENTE = " & b & " AND ESTADO_CUOTA = '" & c & "'"
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

    Function Registro_en_DetalleRecibo(ByVal a As Integer, ByVal b As String, ByVal c As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM CP_DETALLE_RECIBO WHERE COD_CABECERA_RECIBO = " & a & " AND FACTURA_NUMERO = '" & b & "' AND CUOTA_NUMERO = '" & c & "'"
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

    Function Contador_Recibo() As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM CP_CABECERA_RECIBO"
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
    Function Contador_Detalle_() As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM CP_DETALLE_RECIBO"
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
    Function VERIFICAR_REGDETALLERECIBO(ByVal a As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM CP_DETALLE_RECIBO WHERE COD_CABECERA_RECIBO = " & a & ""
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

    Private Sub cbBanco_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbBanco.SelectedIndexChanged
        Me.txtNombre_Banco.Text = Trim(Me.DsBanco.Tables("TP_BANCO").Rows(Me.cbBanco.SelectedIndex).Item(1).ToString)
        Me.txtChequeNum.Focus()
    End Sub

    Private Sub rbEfectivo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbEfectivo.CheckedChanged
        FORMA_PAGO = "EFECTIVO"
        Me.txtMontoPagoCuotas.Focus()
    End Sub

    Private Sub rbCheque_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCheque.CheckedChanged
        FORMA_PAGO = "CHEQUE"
        Me.txtMontoPagoCuotas.Focus()
    End Sub

    Function Cantidad_Registros_MovCaja(ByVal a As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT count(*) FROM CP_DETALLE_MOVIMIENTO_CAJA WHERE COD_CABECERA_MOVIMIENTO_CAJA = " & a & ""
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

    Function IMPORTE_TOTALRECIBO(ByVal a As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT IMPORTE_TOTAL FROM CP_CABECERA_RECIBO WHERE COD_CABECERA_RECIBO = " & a & ""
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

    Function SUMATORIATOTAL(ByVal a As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COALESCE(SUM(IMPORTE_CUOTA),0) FROM CP_DETALLE_RECIBO WHERE COD_CABECERA_RECIBO = " & a & ""
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

    Private Sub btnRealizarPago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRealizarPago.Click

        If identificador_dobleclick = 1 Then
            Dim VERIFICAR_PARA_PAGO As Integer

            If FORMA_PAGO = "EFECTIVO" Then
                If Me.txtMontoPagoCuotas.Text = "" Then
                    MessageBox.Show("IMPORTE EFECTIVO NO PUEDE SER VACIO", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtMontoPagoCuotas.Focus()
                Else
                    If Me.txtMontoPagoCuotas.Text = 0 Then
                        MessageBox.Show("IMPORTE EFECTIVO NO PUEDE SER CERO", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.txtMontoPagoCuotas.Focus()
                    Else
                        VERIFICAR_PARA_PAGO = 1
                    End If
                End If
            Else
                If FORMA_PAGO = "CHEQUE" Then
                    If Me.txtMontoPagoCuotas.Text = "" Then
                        MessageBox.Show("IMPORTE CHEQUE NO PUEDE SER VACIO", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.txtMontoPagoCuotas.Focus()
                    Else
                        If Me.txtMontoPagoCuotas.Text = 0 Then
                            MessageBox.Show("IMPORTE CHEQUE NO PUEDE SER VACIO", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.txtMontoPagoCuotas.Focus()
                        Else
                            VERIFICAR_PARA_PAGO = 1
                        End If
                    End If
                End If
            End If

            If VERIFICAR_PARA_PAGO = 1 Then
                If Me.rbEfectivo.Checked = True Then
                    PARA_PAGOCUOTAS = CInt(Me.txtMontoPagoCuotas.Text)
                    DetallesCheque = ""
                Else
                    If Me.rbCheque.Checked = True Then
                        PARA_PAGOCUOTAS = CInt(Me.txtMontoPagoCuotas.Text)
                        DetallesCheque = "ENTIDAD:" & "  " & Trim(Me.txtNombre_Banco.Text) & "// " & "N° CHEQUE:" & "  " & Trim(Me.txtChequeNum.Text)
                    End If
                End If

                If TIPO_DOCUMENTO = "CONTADO" Then
                    '*ACTUALIZAR ESTADO DE CUOTA CUENTA CLIENTE***
                    Try
                        conectar()
                        Dim sel As String
                        sel = "UPDATE VF_DETALLE_CUENTACLIENTE SET ESTADO_CUOTA = '" & "PAGADO" & "'," & _
                        "FECHA_PAGO = '" & Today & "'" & _
                        " WHERE DOCUMENTO_FACTURACION = '" & VALOR_DOCUMENTO & "' AND " & _
                        "CUOTA = " & CUOTA & " AND COD_CLIENTE = " & CODIGO_CLIENTE & ""
                        cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                        SQLconexion.Open()
                        Dim t As Integer = CInt(cmm.ExecuteScalar())
                        cmm.Dispose()
                        SQLconexion.Close()

                    Catch ex As Exception
                        MsgBox(ex.Message())
                        SQLconexion.Close()
                    End Try

                    Try
                        conectar()
                        Dim sel As String
                        sel = "UPDATE VF_CABECERA_CUENTACLIENTE SET MONTO_CUENTA = " & 0 & "" & _
                       " WHERE COD_CABECERA_CUENTACLI = " & CABECERA_CUENTACLI & ""
                        cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                        SQLconexion.Open()
                        Dim t As Integer = CInt(cmm.ExecuteScalar())
                        cmm.Dispose()
                        SQLconexion.Close()

                    Catch ex As Exception
                        MsgBox(ex.Message())
                        SQLconexion.Close()
                    End Try

                    'ACTUALIZAR HISTORIAL DE PAGOS EN CUENTA CLIENTE *****
                    Contador_Historial_PagoCC = Contador_Historial_Pago_CC() + 1
                    Try
                        SQLconexion.Open()
                        Dim sqlbuilder As New System.Text.StringBuilder
                        With sqlbuilder
                            .Append("INSERT INTO VF_HISTORIAL_PAGO_CUENTACLIENTE")
                            .Append(" VALUES ('")
                            .Append(Contador_Historial_PagoCC & "','")
                            .Append(CABECERA_CUENTACLI & "','")
                            .Append(VALOR_DOCUMENTO & "','")
                            .Append(FECHA_FACTURACION & "','")
                            .Append(CUOTA & "','")
                            .Append(DIAS_AVENCER & "','")
                            .Append(MONTO_CUOTA & "','")
                            .Append(FECHA_VENCIMIENTO & "','")
                            .Append(CODIGO_CLIENTE_ & "','")
                            .Append("PAGADO" & "','")
                            .Append(TIPO_DOCUMENTO & "','")
                            .Append(Today & "','")
                            .Append(0 & "','")
                            .Append(0 & "')")

                        End With
                        cmm = New SqlClient.SqlCommand(sqlbuilder.ToString, SQLconexion)
                        cmm.ExecuteNonQuery()
                        SQLconexion.Close()
                        cmm.Dispose()
                        SQLconexion.Dispose()

                    Catch ex As SqlClient.SqlException
                        MsgBox(ex.Message())
                        SQLconexion.Close()
                    End Try
                    '*********************************************************************
                Else
                    If TIPO_DOCUMENTO = "CREDITO" Then
                        carga_dataset_detalleRecibo()
                        '*ACTUALIZAR ESTADO DE CUENTA CLIENTE DE RECIBOS PAGADOS***

                        Dim i As Integer
                        Dim cuota_, valor_doc, auxiliar_cadena As String
                        Dim importe_cu, importe_interes, auxiliar_monto, para_Cuota As Integer

                        For i = 0 To Me.BindingContext(Me.DsDetRec, "CP_DETALLE_RECIBO").Count - 1
                            Me.BindingContext(Me.DsDetRec, "CP_DETALLE_RECIBO").Position = i
                            If (contador_cabRecibo) = CInt(Me.DsDetRec.Tables("CP_DETALLE_RECIBO").Rows(Me.BindingContext(Me.DsDetRec, "CP_DETALLE_RECIBO").Position).Item("COD_CABECERA_RECIBO").ToString) Then

                                valor_doc = Trim(Me.DsDetRec.Tables("CP_DETALLE_RECIBO").Rows(Me.BindingContext(Me.DsDetRec, "CP_DETALLE_RECIBO").Position).Item("FACTURA_NUMERO").ToString)
                                auxiliar_cadena = Trim(Me.DsDetRec.Tables("CP_DETALLE_RECIBO").Rows(Me.BindingContext(Me.DsDetRec, "CP_DETALLE_RECIBO").Position).Item("CUOTA_NUMERO").ToString)
                                cuota_ = auxiliar_cadena.Substring(0, 1)
                                auxiliar_monto = CInt(Me.DsDetRec.Tables("CP_DETALLE_RECIBO").Rows(Me.BindingContext(Me.DsDetRec, "CP_DETALLE_RECIBO").Position).Item("IMPORTE_CUOTA").ToString)
                                INTERES_MORATORIO = paraInteresMora(contador_cabRecibo, "INTERES MORATORIO CUOTA", auxiliar_cadena)
                                importe_cu = auxiliar_monto
                                importe_interes = INTERES_MORATORIO
                                para_Cuota = CInt(cuota_)

                                If valor_doc <> "INTERES MORATORIO CUOTA" Then
                                    'VERIFICAR PAGOS PARA ACTUALIZAR PAGOS DE CLIENTE****
                                    If PARA_PAGOCUOTAS >= importe_cu Then

                                        'ACTUALIZAR MONTO DE PAGO AL REALIZAR PRIMER PAGO
                                        PARA_PAGOCUOTAS = PARA_PAGOCUOTAS - importe_cu
                                        Try
                                            conectar()
                                            Dim sel As String
                                            sel = "UPDATE VF_DETALLE_CUENTACLIENTE SET ESTADO_CUOTA = '" & "PAGADO" & "',MONTO_CUOTA = " & 0 & "," & _
                                            "FECHA_PAGO = '" & Today & "' " & _
                                            "WHERE DOCUMENTO_FACTURACION = '" & valor_doc & "' AND " & _
                                            "CUOTA = " & para_Cuota & " AND COD_CLIENTE = " & CODIGO_CLIENTE & ""
                                            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                                            SQLconexion.Open()
                                            Dim t As Integer = CInt(cmm.ExecuteScalar())
                                            cmm.Dispose()
                                            SQLconexion.Close()

                                        Catch ex As Exception
                                            MsgBox(ex.Message())
                                            SQLconexion.Close()
                                        End Try

                                        'ACTUALIZAR HISTORIAL DE PAGOS EN CUENTA CLIENTE *****
                                        Contador_Historial_PagoCC = Contador_Historial_Pago_CC() + 1
                                        Dim Dias_EnMora As Integer
                                        Dias_EnMora = paraDias_EnMora(valor_doc, para_Cuota, CODIGO_CLIENTE)
                                        Try
                                            SQLconexion.Open()
                                            Dim sqlbuilder As New System.Text.StringBuilder
                                            With sqlbuilder
                                                .Append("INSERT INTO VF_HISTORIAL_PAGO_CUENTACLIENTE")
                                                .Append(" VALUES ('")
                                                .Append(Contador_Historial_PagoCC & "','")
                                                .Append(CABECERA_CUENTACLI & "','")
                                                .Append(valor_doc & "','")
                                                .Append(FECHA_FACTURACION & "','")
                                                .Append(para_Cuota & "','")
                                                .Append(Dias_EnMora & "','")
                                                .Append(importe_cu & "','")
                                                .Append(FECHA_VENCIMIENTO & "','")
                                                .Append(CODIGO_CLIENTE_ & "','")
                                                .Append("PAGADO" & "','")
                                                .Append(TIPO_DOCUMENTO & "','")
                                                .Append(Today & "','")
                                                .Append(INTERES_MORATORIO & "','")
                                                .Append(contador_cabRecibo & "')")

                                            End With
                                            cmm = New SqlClient.SqlCommand(sqlbuilder.ToString, SQLconexion)
                                            cmm.ExecuteNonQuery()
                                            SQLconexion.Close()
                                            cmm.Dispose()
                                            SQLconexion.Dispose()

                                        Catch ex As SqlClient.SqlException
                                            MsgBox(ex.Message())
                                            SQLconexion.Close()
                                        End Try

                                    Else
                                        'ACTUALIZA DETALLE DE RECIBO SI PAGO FUE PARCIAL
                                        AUX_PAGO1 = importe_cu - PARA_PAGOCUOTAS
                                        Try
                                            conectar()
                                            Dim sel As String
                                            sel = "UPDATE CP_DETALLE_RECIBO SET IMPORTE_CUOTA = " & PARA_PAGOCUOTAS & " " & _
                                            "WHERE FACTURA_NUMERO = '" & valor_doc & "' AND " & _
                                            "CUOTA_NUMERO = '" & auxiliar_cadena & "' AND COD_CABECERA_RECIBO = " & contador_cabRecibo & ""
                                            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                                            SQLconexion.Open()
                                            Dim t As Integer = CInt(cmm.ExecuteScalar())
                                            cmm.Dispose()
                                            SQLconexion.Close()

                                        Catch ex As Exception
                                            MsgBox(ex.Message())
                                            SQLconexion.Close()
                                        End Try
                                        'ACTUALIZA ESTADO DE CUENTA POR EL PAGO PARCIAL****
                                        Try
                                            conectar()
                                            Dim sel As String
                                            sel = "UPDATE VF_DETALLE_CUENTACLIENTE SET ESTADO_CUOTA = '" & "PENDIENTE" & "'," & _
                                            "FECHA_PAGO = '" & Today & "',MONTO_CUOTA = " & AUX_PAGO1 & " " & _
                                            "WHERE DOCUMENTO_FACTURACION = '" & valor_doc & "' AND " & _
                                            "CUOTA = " & para_Cuota & " AND COD_CLIENTE = " & CODIGO_CLIENTE & ""
                                            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                                            SQLconexion.Open()
                                            Dim t As Integer = CInt(cmm.ExecuteScalar())
                                            cmm.Dispose()
                                            SQLconexion.Close()

                                        Catch ex As Exception
                                            MsgBox(ex.Message())
                                            SQLconexion.Close()
                                        End Try

                                        'ACTUALIZAR HISTORIAL DE PAGOS EN CUENTA CLIENTE *****
                                        Contador_Historial_PagoCC = Contador_Historial_Pago_CC() + 1
                                        Dim Dias_EnMora As Integer
                                        Dias_EnMora = paraDias_EnMora(valor_doc, para_Cuota, CODIGO_CLIENTE)
                                        Try
                                            SQLconexion.Open()
                                            Dim sqlbuilder As New System.Text.StringBuilder
                                            With sqlbuilder
                                                .Append("INSERT INTO VF_HISTORIAL_PAGO_CUENTACLIENTE")
                                                .Append(" VALUES ('")
                                                .Append(Contador_Historial_PagoCC & "','")
                                                .Append(CABECERA_CUENTACLI & "','")
                                                .Append(valor_doc & "','")
                                                .Append(FECHA_FACTURACION & "','")
                                                .Append(CUOTA & "','")
                                                .Append(Dias_EnMora & "','")
                                                .Append(PARA_PAGOCUOTAS & "','")
                                                .Append(FECHA_VENCIMIENTO & "','")
                                                .Append(CODIGO_CLIENTE_ & "','")
                                                .Append("PAGADO" & "','")
                                                .Append(TIPO_DOCUMENTO & "','")
                                                .Append(Today & "','")
                                                .Append(INTERES_MORATORIO & "','")
                                                .Append(contador_cabRecibo & "')")

                                            End With
                                            cmm = New SqlClient.SqlCommand(sqlbuilder.ToString, SQLconexion)
                                            cmm.ExecuteNonQuery()
                                            SQLconexion.Close()
                                            cmm.Dispose()
                                            SQLconexion.Dispose()

                                        Catch ex As SqlClient.SqlException
                                            MsgBox(ex.Message())
                                            SQLconexion.Close()
                                        End Try
                                    End If
                                End If
                            End If
                        Next

                        '*ACTUALIZAR MONTO CABECERA RECIBO***
                        SUMATORIA_TOTAL = SUMATORIATOTAL(contador_cabRecibo)
                        SUMATORIA_TOTAL1 = SUMATORIATOTAL(contador_cabRecibo) - CInt(Me.txtDescuentoInteres.Text)
                        Try
                            conectar()
                            Dim sel As String
                            sel = "UPDATE CP_CABECERA_RECIBO SET IMPORTE_TOTAL = " & SUMATORIA_TOTAL1 & ", DESCUENTOS_ESPECIALES = " & CInt(Me.txtDescuentoInteres.Text) & "" & _
                            " WHERE COD_CABECERA_RECIBO = " & contador_cabRecibo & ""
                            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                            SQLconexion.Open()
                            Dim t As Integer = CInt(cmm.ExecuteScalar())
                            cmm.Dispose()
                            SQLconexion.Close()

                        Catch ex As Exception
                            MsgBox(ex.Message())
                            SQLconexion.Close()
                        End Try

                        '*ACTUALIZAR CABECERA CUENTA CLIENTE******************
                        Dim CuentaCliente_SegunCabecera As Integer
                        CuentaCliente_SegunCabecera = Seleccionar_CuentaSegunCAb(CABECERA_CUENTACLI)
                        Dim CALCULOAUX As Integer
                        CALCULOAUX = CuentaCliente_SegunCabecera - SUMATORIA_TOTAL
                        Try
                            conectar()
                            Dim sel As String
                            sel = "UPDATE VF_CABECERA_CUENTACLIENTE SET MONTO_CUENTA = " & CALCULOAUX & "" & _
                            "WHERE COD_CABECERA_CUENTACLI = " & CABECERA_CUENTACLI & ""
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

                'contador para detalle en caja***
                contador_detalleCaja = ContadorDetalleEnCaja_(Contador_MovCaja_Apertura) + 1
                'SELECCIONAR CABECERA DE LA CUENTA DE CLIENTE
                Dim paraCodigoCabeceraCC As Integer = CabeceraCC(VALOR_DOCUMENTO)
                'SELECCIONAR CODIGO DE FACTURA, SI NO HAY CODIGO ES 0
                Dim paraCodigoFactura As Integer = CodigoFactura(paraCodigoCabeceraCC)

                If IDENTIFICADOR_CONTADO = 1 Then
                    IMPORTE_TOTAL_FACTURA = MONTO_CUOTA
                    Try
                        SQLconexion.Open()
                        Dim sqlbuilder As New System.Text.StringBuilder
                        With sqlbuilder
                            .Append("INSERT INTO CP_DETALLE_CAJA")
                            .Append(" VALUES ('")
                            .Append(contador_detalleCaja & "','")
                            .Append(Contador_MovCaja_Apertura & "','")
                            .Append(0 & "','")
                            .Append(paraCodigoFactura & "','")
                            .Append("" & "','")
                            .Append(0 & "','")
                            .Append(VALOR_DOCUMENTO & "','")
                            .Append(IMPORTE_TOTAL_FACTURA & "','")
                            .Append(FORMA_PAGO & "','")
                            .Append(DetallesCheque & "')")
                        End With

                        cmm = New SqlClient.SqlCommand(sqlbuilder.ToString, SQLconexion)
                        cmm.ExecuteNonQuery()
                        SQLconexion.Close()
                        cmm.Dispose()
                        SQLconexion.Dispose()

                    Catch ex As SqlClient.SqlException
                        MsgBox(ex.Message())
                        SQLconexion.Close()
                    End Try
                Else
                    If IDENTIFICADOR_CREDITO = 1 Then
                        IMPORTE_TOTAL_RECIBO = IMPORTE_TOTALRECIBO(contador_cabRecibo)
                        Try
                            SQLconexion.Open()
                            Dim sqlbuilder As New System.Text.StringBuilder
                            With sqlbuilder
                                .Append("INSERT INTO CP_DETALLE_CAJA")
                                .Append(" VALUES ('")
                                .Append(contador_detalleCaja & "','")
                                .Append(Contador_MovCaja_Apertura & "','")
                                .Append(contador_cabRecibo & "','")
                                .Append(0 & "','")
                                .Append(Trim(NUM_RECIBO) & "','")
                                .Append(IMPORTE_TOTAL_RECIBO & "','")
                                .Append("" & "','")
                                .Append(0 & "','")
                                .Append(FORMA_PAGO & "','")
                                .Append(DetallesCheque & "')")
                            End With

                            cmm = New SqlClient.SqlCommand(sqlbuilder.ToString, SQLconexion)
                            cmm.ExecuteNonQuery()
                            SQLconexion.Close()
                            cmm.Dispose()
                            SQLconexion.Dispose()

                        Catch ex As SqlClient.SqlException
                            MsgBox(ex.Message())
                            SQLconexion.Close()
                        End Try
                    End If
                End If

                If TIPO_DOCUMENTO = "CONTADO" Then
                    If IDENTIFICADOR2 = "T" Then
                        Try
                            conectar()
                            Dim dt As New DataTable
                            Dim da As New SqlDataAdapter("REPORTE_FACTURACION_FACTURA", SQLconexion)
                            da.SelectCommand.CommandType = CommandType.StoredProcedure
                            da.SelectCommand.Parameters.AddWithValue("@NUMERO_FACTURA", 0)
                            da.Fill(dt)

                            Dim ds As New Data.DataSet
                            ds.Tables.Add(dt)

                            Dim info As New REPORTE_TICKET
                            info.SetDataSource(ds)
                            info.SetParameterValue("@NUMERO_FACTURA", 0)
                            info.SetDatabaseLogon("clezcano", "Cesar1983")
                            Me.CrystalReportViewer1.ReportSource = info
                        Catch ex As Exception
                            MessageBox.Show(ex.ToString)
                            SQLconexion.Close()
                        End Try
                    Else
                        If IDENTIFICADOR2 = "F" Then
                            Try
                                conectar()
                                Dim dt As New DataTable
                                Dim da As New SqlDataAdapter("REPORTE_FACTURACION_FACTURA", SQLconexion)
                                da.SelectCommand.CommandType = CommandType.StoredProcedure
                                da.SelectCommand.Parameters.AddWithValue("@NUMERO_FACTURA", 0)
                                da.Fill(dt)

                                Dim ds As New Data.DataSet
                                ds.Tables.Add(dt)

                                Dim info As New REPORTE_FACTURA
                                info.SetDataSource(ds)
                                info.SetParameterValue("@NUMERO_FACTURA", 0)
                                info.SetDatabaseLogon("clezcano", "Cesar1983")
                                Me.CrystalReportViewer1.ReportSource = info

                            Catch ex As Exception
                                MessageBox.Show(ex.ToString)
                                SQLconexion.Close()
                            End Try
                        End If
                    End If
                Else
                    If CUOTA = 0 Then
                        Try
                            conectar()
                            Dim dt As New DataTable
                            Dim da As New SqlDataAdapter("PAGO_RECIBO", SQLconexion)
                            da.SelectCommand.CommandType = CommandType.StoredProcedure
                            da.SelectCommand.Parameters.AddWithValue("@NUMERO_RECIBO", 0)
                            da.Fill(dt)

                            Dim ds As New Data.DataSet
                            ds.Tables.Add(dt)

                            Dim info As New RECIBO_DE_DINERO_ENTREGA
                            info.SetDataSource(ds)
                            info.SetParameterValue("@NUMERO_RECIBO", 0)
                            info.SetDatabaseLogon("clezcano", "Cesar1983")
                            Me.CrystalReportViewer1.ReportSource = info

                        Catch ex As Exception
                            MessageBox.Show(ex.ToString)
                            SQLconexion.Close()
                        End Try
                    Else
                        Try
                            conectar()
                            Dim dt As New DataTable
                            Dim da As New SqlDataAdapter("PAGO_RECIBO", SQLconexion)
                            da.SelectCommand.CommandType = CommandType.StoredProcedure
                            da.SelectCommand.Parameters.AddWithValue("@NUMERO_RECIBO", 0)
                            da.Fill(dt)

                            Dim ds As New Data.DataSet
                            ds.Tables.Add(dt)

                            Dim info As New RECIBO_DE_DINERO
                            info.SetDataSource(ds)
                            info.SetParameterValue("@NUMERO_RECIBO", 0)
                            info.SetDatabaseLogon("clezcano", "Cesar1983")
                            Me.CrystalReportViewer1.ReportSource = info

                        Catch ex As Exception
                            MessageBox.Show(ex.ToString)
                            SQLconexion.Close()
                        End Try
                    End If
                End If
                If Me.rbContado.Checked = True Then
                    VER_DATOS_CLIENTE_CONTADO_()
                Else
                    If Me.rbCredito.Checked = True Then
                        VER_DATOS_CLIENTE_CREDITO_()
                    End If
                End If

                b = 0
                Me.txtMontoPagoCuotas.Clear()
                Me.txtImportedeCuotas.Text = 0
                Me.txtImportedeInteres.Text = 0
                Me.txtSaldodeCuotas.Text = 0
                Me.txtSaldodeInteres.Text = 0
                Me.txtDescuentoCuota.Text = 0
                Me.txtDescuentoInteres.Text = 0
                Me.txtChequeNum.Clear()
                Me.txtClienteCI.Clear()
                Me.txtNombre_Banco.Clear()
                Me.txtSaldodeCuotas.Clear()
                Me.txtDescuentoCuota.Text = 0
                Me.txtMontoPagoInteres.Text = 0
                Me.CrystalReportViewer1.ReportSource = Nothing
            End If

            identificador_dobleclick = 0
            Me.txtClienteCI.Focus()
        End If

    End Sub

    Function CabeceraCC(ByVal a As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COD_CABECERA_CUENTACLI FROM VF_DETALLE_CUENTACLIENTE WHERE DOCUMENTO_FACTURACION = '" & a & "'"
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

    Function CodigoFactura(ByVal a As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COALESCE(COD_FACTURA,0) FROM VF_CABECERA_CUENTACLIENTE WHERE COD_CABECERA_CUENTACLI = " & a & ""
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

    Function ContadorDetalleEnCaja_(ByVal a As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM CP_DETALLE_CAJA WHERE COD_CAB_CAJA = " & a & ""
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

    Function Seleccionar_CuentaSegunCAb(ByVal a As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT MONTO_CUENTA FROM VF_CABECERA_CUENTACLIENTE WHERE COD_CABECERA_CUENTACLI = " & a & ""
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

    Function CONTADORCHEQUE() As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM CP_CHEQUE "
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

    Function codigo_prod_(ByVal a As String) As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COD_CLIENTE FROM TP_CLIENTE WHERE CI = '" & a & "'"
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

    'ACTUALIZA LOS DIAS DE FECHA DE VENCIMIENTO DE LAS CUOTAS******
    Function actualizar_diasVencimiento(ByVal a As Integer, ByVal b As Integer, ByVal c As Integer, ByVal d As Integer) As Integer
        Try
            Dim sel As String

            sel = "UPDATE VF_DETALLE_CUENTACLIENTE SET DIAS_A_VENCER = " & a & " WHERE COD_CLIENTE = " & b & " AND CUOTA =" & c & " AND COD_CABECERA_CUENTACLI= " & d & ""
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)

            SQLconexion.Open()
            Dim t As Integer = CInt(cmm.ExecuteScalar())
            SQLconexion.Close()
            Return t

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Function

    'ACTUALIZA LOS DIAS DE FECHA DE VENCIMIENTO DE LAS CUOTAS******
    Function actualizar_diasMoraVencimiento(ByVal a As Integer, ByVal b As Integer, ByVal c As Integer, ByVal d As Integer) As Integer
        Try
            Dim sel As String

            sel = "UPDATE VF_DETALLE_CUENTACLIENTE SET INTERES_MORATORIO = " & a & " WHERE COD_CLIENTE = " & b & " AND CUOTA =" & c & " AND COD_CABECERA_CUENTACLI= " & d & ""
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)

            SQLconexion.Open()
            Dim t As Integer = CInt(cmm.ExecuteScalar())
            SQLconexion.Close()
            Return t

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Function


    Private Sub btnBuscarDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarDatos.Click

        DsDetRec.Clear()
        DsDetCuenta_Cliente.Clear()
        DsInteres.Clear()

        Cargar_Datos()
        Dim NUM_CUOTA, COD_CUENTA, MONTO, dias_cuota As Integer
        Dim AUX_FECHAVENC As Date
        Dim PAGADO, pendiente As String
        Dim MONTO_INTERES, DIAS_DE_GRACIA As Integer
        pendiente = "PENDIENTE"
        CODIGO_CLIENTE = codigo_prod_(Trim(Me.txtClienteCI.Text))

        'VERIFICA VALORES PARA INTERES MORATORIO
        For j = 0 To Me.BindingContext(Me.DsInteres, "TP_INTERES").Count - 1
            Me.BindingContext(Me.DsInteres, "TP_INTERES").Position = j
            If "INTERES MORATORIO" = Me.DsInteres.Tables("TP_INTERES").Rows(Me.BindingContext(Me.DsInteres, "TP_INTERES").Position).Item("CONCEPTO") Then
                MONTO_INTERES = Me.DsInteres.Tables("TP_INTERES").Rows(Me.BindingContext(Me.DsInteres, "TP_INTERES").Position).Item("MONTO_INTERES")
                DIAS_DE_GRACIA = Me.DsInteres.Tables("TP_INTERES").Rows(Me.BindingContext(Me.DsInteres, "TP_INTERES").Position).Item("DIAS_DE_GRACIA")
            End If
        Next

        'ACTUALIZA LAS FECHAS DE VENCIMIENTO DE LAS CUOTAS********************************
        Dim i As Integer
        For i = 0 To Me.BindingContext(Me.DsDetCuenta_Cliente, "VF_DETALLE_CUENTACLIENTE").Count - 1
            Me.BindingContext(Me.DsDetCuenta_Cliente, "VF_DETALLE_CUENTACLIENTE").Position = i
            If (CODIGO_CLIENTE) = Me.DsDetCuenta_Cliente.Tables("VF_DETALLE_CUENTACLIENTE").Rows(Me.BindingContext(Me.DsDetCuenta_Cliente, "VF_DETALLE_CUENTACLIENTE").Position).Item("COD_CLIENTE") Then

                AUX_FECHAVENC = Me.DsDetCuenta_Cliente.Tables("VF_DETALLE_CUENTACLIENTE").Rows(Me.BindingContext(Me.DsDetCuenta_Cliente, "VF_DETALLE_CUENTACLIENTE").Position).Item("FECHA_VENCIMIENTO")
                PAGADO = Trim(Me.DsDetCuenta_Cliente.Tables("VF_DETALLE_CUENTACLIENTE").Rows(Me.BindingContext(Me.DsDetCuenta_Cliente, "VF_DETALLE_CUENTACLIENTE").Position).Item("ESTADO_CUOTA"))
                NUM_CUOTA = Me.DsDetCuenta_Cliente.Tables("VF_DETALLE_CUENTACLIENTE").Rows(Me.BindingContext(Me.DsDetCuenta_Cliente, "VF_DETALLE_CUENTACLIENTE").Position).Item("CUOTA")
                COD_CUENTA = Me.DsDetCuenta_Cliente.Tables("VF_DETALLE_CUENTACLIENTE").Rows(Me.BindingContext(Me.DsDetCuenta_Cliente, "VF_DETALLE_CUENTACLIENTE").Position).Item("COD_CABECERA_CUENTACLI")
                MONTO = Me.DsDetCuenta_Cliente.Tables("VF_DETALLE_CUENTACLIENTE").Rows(Me.BindingContext(Me.DsDetCuenta_Cliente, "VF_DETALLE_CUENTACLIENTE").Position).Item("MONTO_CUOTA")
                dias_cuota = DateDiff(DateInterval.Day, Today, AUX_FECHAVENC)

                'SI LA CUOTA NO FUE ABONADA SE MODIFICA LOS DIAS DE VENCIMIENTO***
                If PAGADO = pendiente Then
                    actualizar_diasVencimiento(dias_cuota, CODIGO_CLIENTE, NUM_CUOTA, COD_CUENTA)

                    'CALCULAR INTERES MORATORIO EN CASO DE ATRASO
                    If dias_cuota < 0 Then
                        Dim AUX_DIAS_CUOTA As Integer
                        Dim CALCULO_AUXILIAR, CALCULO_AUXILIAR1 As Double
                        Dim para_InteresMora As Integer

                        AUX_DIAS_CUOTA = dias_cuota * -1
                        If AUX_DIAS_CUOTA > DIAS_DE_GRACIA Then
                            CALCULO_AUXILIAR1 = MONTO_INTERES / 100
                            CALCULO_AUXILIAR = (MONTO * CALCULO_AUXILIAR1) / 30
                            para_InteresMora = CInt(CALCULO_AUXILIAR) * AUX_DIAS_CUOTA
                            actualizar_diasMoraVencimiento(para_InteresMora, CODIGO_CLIENTE, NUM_CUOTA, COD_CUENTA)
                        Else
                            If DIAS_DE_GRACIA <= 5 Then
                                actualizar_diasMoraVencimiento(0, CODIGO_CLIENTE, NUM_CUOTA, COD_CUENTA)
                            End If
                        End If
                    Else
                        actualizar_diasMoraVencimiento(0, CODIGO_CLIENTE, NUM_CUOTA, COD_CUENTA)
                    End If
                End If
            End If
        Next
        '*********************************************************************************************************
        If Me.rbContado.Checked = True Then
            VER_DATOS_CLIENTE_CONTADO()
        Else
            If Me.rbCredito.Checked = True Then
                VER_DATOS_CLIENTE_CREDITO()
            End If
        End If

    End Sub

    Sub carga_dataset_detalleRecibo()
        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM CP_DETALLE_RECIBO"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaDetRec = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsDetRec = New Data.DataSet
            DaDetRec.Fill(Me.DsDetRec, "CP_DETALLE_RECIBO")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnBorrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrar.Click

        If VERIFICAR_REGDETALLERECIBO(contador_cabRecibo) = 0 Then
            MessageBox.Show("NO HAY REGISTROS PARA ELIMINAR", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                conectar()
                Dim sel As String
                sel = "DELETE FROM CP_DETALLE_RECIBO " & _
                "WHERE FACTURA_NUMERO = '" & VALOR_DOCUMENTO & "' AND " & _
                "CUOTA_NUMERO = '" & paraMontoDetRecibo & "' AND COD_CABECERA_RECIBO = " & contador_cabRecibo & ""
                cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                SQLconexion.Open()
                Dim t As Integer = CInt(cmm.ExecuteScalar())
                cmm.Dispose()
                SQLconexion.Close()

            Catch ex As Exception
                MsgBox(ex.Message())
                SQLconexion.Close()
            End Try
            ''ELIMINAR INTERES MORATORIO****
            Try
                conectar()
                Dim sel As String
                sel = "DELETE FROM CP_DETALLE_RECIBO " & _
                "WHERE FACTURA_NUMERO = '" & "INTERES MORATORIO CUOTA" & "' AND " & _
                "CUOTA_NUMERO = '" & paraMontoDetRecibo & "' AND COD_CABECERA_RECIBO = " & contador_cabRecibo & ""
                cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                SQLconexion.Open()
                Dim t As Integer = CInt(cmm.ExecuteScalar())
                cmm.Dispose()
                SQLconexion.Close()

            Catch ex As Exception
                MsgBox(ex.Message())
                SQLconexion.Close()
            End Try

            '**VER DETALLES DE REPORTE DE RECIBO
            Try
                conectar()
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter("PAGO_RECIBO", SQLconexion)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@NUMERO_RECIBO", NUM_RECIBO)
                da.Fill(dt)

                Dim ds As New Data.DataSet
                ds.Tables.Add(dt)

                Dim info As New RECIBO_DE_DINERO
                info.SetDataSource(ds)
                info.SetParameterValue("@NUMERO_RECIBO", NUM_RECIBO)
                SetDBLogonForReport(iconexion, info)
                Me.CrystalReportViewer1.ReportSource = info
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                SQLconexion.Close()
            End Try
        End If
    End Sub

    Private Sub btnCancelarOperacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelarOperacion.Click
        Try
            conectar()
            Dim sel As String
            sel = "DELETE FROM CP_CABECERA_RECIBO WHERE COD_CABECERA_RECIBO = " & contador_cabRecibo & ""
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As Integer = CInt(cmm.ExecuteScalar())
            cmm.Dispose()
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
        Try
            conectar()
            Dim sel As String
            sel = "DELETE FROM CP_DETALLE_RECIBO WHERE COD_CABECERA_RECIBO = " & contador_cabRecibo & ""
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As Integer = CInt(cmm.ExecuteScalar())
            cmm.Dispose()
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

        b = 0
        Me.txtSaldodeCuotas.Clear()
        Me.txtMontoPagoCuotas.Text = 0
        Me.txtMontoPagoInteres.Text = 0
        Me.txtImportedeCuotas.Text = 0
        Me.txtImportedeInteres.Text = 0
        Me.txtSaldodeCuotas.Text = 0
        Me.txtSaldodeInteres.Text = 0
        Me.txtDescuentoCuota.Text = 0
        Me.txtDescuentoInteres.Text = 0
        Me.txtChequeNum.Clear()
        Me.txtClienteCI.Clear()
        Me.txtNombre_Banco.Clear()
        Me.txtDescuentoCuota.Text = 0
        Me.txtMontoPagoInteres.Text = 0
        Me.CrystalReportViewer1.ReportSource = Nothing

        If Me.rbContado.Checked = True Then
            VER_DATOS_CLIENTE_CONTADO_()
        Else
            If Me.rbCredito.Checked = True Then
                VER_DATOS_CLIENTE_CREDITO_()
            End If
        End If

        Me.txtClienteCI.Focus()

    End Sub

    Function factura_esCredito(ByVal a As String) As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT TIPO_FACTURA FROM VF_CABECERA_FACTURA WHERE NUMERO_FACTURA = '" & a & "'"
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

    Private Sub btnImprimirFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirFactura.Click

        If VALOR_DOCUMENTO = "" Then
            MessageBox.Show("SELECCIONAR DOCUMENTO RELACIONADO HACIENDO 1 CLICK SOBRE LA GRILLA DE DATOS", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim instance As New Printing.PrinterSettings
            Dim impresosaPredt As String = instance.PrinterName

            If IDENTIFICADOR2 = "T" Then
                Try
                    Dim dt As New DataTable
                    Dim da As New SqlDataAdapter("REPORTE_FACTURACION_FACTURA", SQLconexion)
                    da.SelectCommand.CommandType = CommandType.StoredProcedure
                    da.SelectCommand.Parameters.AddWithValue("@NUMERO_FACTURA", VALOR_DOCUMENTO)
                    da.Fill(dt)

                    Dim ds As New Data.DataSet
                    ds.Tables.Add(dt)

                    Dim info As New REPORTE_TICKET
                    info.SetDataSource(ds)
                    info.SetParameterValue("@NUMERO_FACTURA", VALOR_DOCUMENTO)
                    SetDBLogonForReport(iconexion, info)
                    Me.CrystalReportViewer1.ReportSource = info
                    ' info.PrintOptions.PrinterName = impresosaPredt
                    ' info.PrintToPrinter(1, False, 0, 0)

                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                    SQLconexion.Close()
                End Try
            Else

                If IDENTIFICADOR2 = "F" Then

                    Try
                        Dim dt As New DataTable
                        Dim da As New SqlDataAdapter("REPORTE_FACTURACION_FACTURA", SQLconexion)
                        da.SelectCommand.CommandType = CommandType.StoredProcedure
                        da.SelectCommand.Parameters.AddWithValue("@NUMERO_FACTURA", VALOR_DOCUMENTO)
                        da.Fill(dt)

                        Dim ds As New Data.DataSet
                        ds.Tables.Add(dt)

                        Dim info As New REPORTE_FACTURA
                        info.SetDataSource(ds)
                        info.SetParameterValue("@NUMERO_FACTURA", VALOR_DOCUMENTO)
                        SetDBLogonForReport(iconexion, info)
                        Me.CrystalReportViewer1.ReportSource = info
                        ' info.PrintOptions.PrinterName = impresosaPredt
                        'info.PrintToPrinter(1, False, 0, 0)

                    Catch ex As Exception
                        MessageBox.Show(ex.ToString)
                        SQLconexion.Close()
                    End Try

                End If
            End If

            Dim tipo_factura_ As Integer
            Dim para_TipoFactura As String
            para_TipoFactura = factura_esCredito(VALOR_DOCUMENTO)
            If para_TipoFactura = "CONTADO" Then
                tipo_factura_ = 0
            Else
                tipo_factura_ = 1
            End If

            If tipo_factura_ = 1 Then
                Try
                    Dim dt As New DataTable
                    Dim da As New SqlDataAdapter("REPORTE_FACTURACION_FACTURA", SQLconexion)
                    da.SelectCommand.CommandType = CommandType.StoredProcedure
                    da.SelectCommand.Parameters.AddWithValue("@NUMERO_FACTURA", VALOR_DOCUMENTO)
                    da.Fill(dt)

                    Dim ds As New Data.DataSet
                    ds.Tables.Add(dt)

                    Dim info As New REPORTE_FACTURA_CREDITO
                    info.SetDataSource(ds)
                    info.SetParameterValue("@NUMERO_FACTURA", VALOR_DOCUMENTO)
                    SetDBLogonForReport(iconexion, info)
                    'Me.CrystalReportViewer1.ReportSource = info
                    info.PrintOptions.PrinterName = impresosaPredt
                    info.PrintToPrinter(1, False, 0, 0)

                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                    SQLconexion.Close()
                End Try
            Else
                Try
                    Dim dt As New DataTable
                    Dim da As New SqlDataAdapter("REPORTE_FACTURACION_FACTURA", SQLconexion)
                    da.SelectCommand.CommandType = CommandType.StoredProcedure
                    da.SelectCommand.Parameters.AddWithValue("@NUMERO_FACTURA", VALOR_DOCUMENTO)
                    da.Fill(dt)

                    Dim ds As New Data.DataSet
                    ds.Tables.Add(dt)

                    Dim info As New REPORTE_FACTURA_CONTADO
                    info.SetDataSource(ds)
                    info.SetParameterValue("@NUMERO_FACTURA", VALOR_DOCUMENTO)
                    SetDBLogonForReport(iconexion, info)
                    ' Me.CrystalReportViewer1.ReportSource = info
                    info.PrintOptions.PrinterName = impresosaPredt
                    info.PrintToPrinter(1, False, 0, 0)

                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                    SQLconexion.Close()
                End Try
            End If
        End If
    End Sub

    Private Sub btnImprimirRecibo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirRecibo.Click

        Dim instance As New Printing.PrinterSettings
        Dim impresosaPredt As String = instance.PrinterName

        If NUM_RECIBO = "" Then

        Else
            If CUOTA = 0 Then
                Try
                    conectar()
                    Dim dt As New DataTable
                    Dim da As New SqlDataAdapter("PAGO_RECIBO", SQLconexion)
                    da.SelectCommand.CommandType = CommandType.StoredProcedure
                    da.SelectCommand.Parameters.AddWithValue("@NUMERO_RECIBO", NUM_RECIBO)
                    da.Fill(dt)

                    Dim ds As New Data.DataSet
                    ds.Tables.Add(dt)

                    Dim info As New RECIBO_DE_DINERO_ENTREGA
                    info.SetDataSource(ds)
                    info.SetParameterValue("@NUMERO_RECIBO", NUM_RECIBO)
                    SetDBLogonForReport(iconexion, info)
                    Me.CrystalReportViewer1.ReportSource = info

                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                    SQLconexion.Close()
                End Try

                Try
                    conectar()
                    Dim dt As New DataTable
                    Dim da As New SqlDataAdapter("PAGO_RECIBO", SQLconexion)
                    da.SelectCommand.CommandType = CommandType.StoredProcedure
                    da.SelectCommand.Parameters.AddWithValue("@NUMERO_RECIBO", NUM_RECIBO)
                    da.Fill(dt)

                    Dim ds As New Data.DataSet
                    ds.Tables.Add(dt)

                    Dim info As New RECIBO_DE_DINERO_IMPRESION_ENTREGA
                    info.SetDataSource(ds)
                    info.SetParameterValue("@NUMERO_RECIBO", NUM_RECIBO)
                    SetDBLogonForReport(iconexion, info)
                    info.PrintOptions.PrinterName = impresosaPredt
                    info.PrintToPrinter(1, False, 0, 0)

                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                    SQLconexion.Close()
                End Try

                Try
                    conectar()
                    Dim dt As New DataTable
                    Dim da As New SqlDataAdapter("PAGO_RECIBO", SQLconexion)
                    da.SelectCommand.CommandType = CommandType.StoredProcedure
                    da.SelectCommand.Parameters.AddWithValue("@NUMERO_RECIBO", NUM_RECIBO)
                    da.Fill(dt)

                    Dim ds As New Data.DataSet
                    ds.Tables.Add(dt)

                    Dim info As New RECIBO_DE_DINERO_IMPRESION_DUPLICADO_ENTREGA_
                    info.SetDataSource(ds)
                    info.SetParameterValue("@NUMERO_RECIBO", NUM_RECIBO)
                    SetDBLogonForReport(iconexion, info)
                    info.PrintOptions.PrinterName = impresosaPredt
                    info.PrintToPrinter(1, False, 0, 0)

                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                    SQLconexion.Close()
                End Try

            Else

                Try
                    conectar()
                    Dim dt As New DataTable
                    Dim da As New SqlDataAdapter("PAGO_RECIBO", SQLconexion)
                    da.SelectCommand.CommandType = CommandType.StoredProcedure
                    da.SelectCommand.Parameters.AddWithValue("@NUMERO_RECIBO", NUM_RECIBO)
                    da.Fill(dt)

                    Dim ds As New Data.DataSet
                    ds.Tables.Add(dt)

                    Dim info As New RECIBO_DE_DINERO_
                    info.SetDataSource(ds)
                    info.SetParameterValue("@NUMERO_RECIBO", NUM_RECIBO)
                    SetDBLogonForReport(iconexion, info)
                    Me.CrystalReportViewer1.ReportSource = info

                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                    SQLconexion.Close()
                End Try

                Try
                    conectar()
                    Dim dt As New DataTable
                    Dim da As New SqlDataAdapter("PAGO_RECIBO", SQLconexion)
                    da.SelectCommand.CommandType = CommandType.StoredProcedure
                    da.SelectCommand.Parameters.AddWithValue("@NUMERO_RECIBO", NUM_RECIBO)
                    da.Fill(dt)

                    Dim ds As New Data.DataSet
                    ds.Tables.Add(dt)

                    Dim info As New RECIBO_DE_DINERO_IMPRESION
                    info.SetDataSource(ds)
                    info.SetParameterValue("@NUMERO_RECIBO", NUM_RECIBO)
                    SetDBLogonForReport(iconexion, info)
                    info.PrintOptions.PrinterName = impresosaPredt
                    info.PrintToPrinter(1, False, 0, 0)

                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                    SQLconexion.Close()
                End Try

                Try
                    conectar()
                    Dim dt As New DataTable
                    Dim da As New SqlDataAdapter("PAGO_RECIBO", SQLconexion)
                    da.SelectCommand.CommandType = CommandType.StoredProcedure
                    da.SelectCommand.Parameters.AddWithValue("@NUMERO_RECIBO", NUM_RECIBO)
                    da.Fill(dt)

                    Dim ds As New Data.DataSet
                    ds.Tables.Add(dt)

                    Dim info As New RECIBO_DE_DINERO_IMPRESION_DUPLICADO
                    info.SetDataSource(ds)
                    info.SetParameterValue("@NUMERO_RECIBO", NUM_RECIBO)
                    SetDBLogonForReport(iconexion, info)
                    info.PrintOptions.PrinterName = impresosaPredt
                    info.PrintToPrinter(1, False, 0, 0)

                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                    SQLconexion.Close()
                End Try
            End If
        End If

    End Sub

    Function EsConGarante(ByVal A As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM TP_CLIENTE_GARANTE WHERE COD_CLIENTE = " & A & ""
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

    Private Sub btnImprimirPagare_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirPagare.Click

        If VALOR_DOCUMENTO = "" Then
            MessageBox.Show("SELECCIONAR DOCUMENTO RELACIONADO HACIENDO 1 CLICK SOBRE LA GRILLA DE DATOS", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim instance As New Printing.PrinterSettings
            Dim impresosaPredt As String = instance.PrinterName

            If EsConGarante(CODIGO_CLIENTE) = 0 Then
                Try
                    Dim dt As New DataTable
                    Dim da As New SqlDataAdapter("PAGARE_A_LA_ORDEN", SQLconexion)
                    da.SelectCommand.CommandType = CommandType.StoredProcedure
                    da.SelectCommand.Parameters.AddWithValue("@NUMERO_TICKET", VALOR_DOCUMENTO)
                    da.Fill(dt)

                    Dim ds As New Data.DataSet
                    ds.Tables.Add(dt)

                    Dim info As New REPORTE_PAGARE_A_LA_ORDEN

                    info.SetDataSource(ds)
                    info.SetParameterValue("@NUMERO_TICKET", VALOR_DOCUMENTO)
                    SetDBLogonForReport(iconexion, info)
                    Me.CrystalReportViewer1.ReportSource = info
                    info.PrintOptions.PrinterName = impresosaPredt
                    info.PrintToPrinter(1, False, 0, 0)

                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                    SQLconexion.Close()
                End Try
            Else
                Try
                    Dim dt As New DataTable
                    Dim da As New SqlDataAdapter("PAGARE_A_LA_ORDEN", SQLconexion)
                    da.SelectCommand.CommandType = CommandType.StoredProcedure
                    da.SelectCommand.Parameters.AddWithValue("@NUMERO_TICKET", VALOR_DOCUMENTO)
                    da.Fill(dt)

                    Dim ds As New Data.DataSet
                    ds.Tables.Add(dt)

                    Dim info As New REPORTE_PAGARE_A_LA_ORDEN_CON_GARANTE

                    info.SetDataSource(ds)
                    info.SetParameterValue("@NUMERO_TICKET", VALOR_DOCUMENTO)
                    SetDBLogonForReport(iconexion, info)
                    Me.CrystalReportViewer1.ReportSource = info
                    info.PrintOptions.PrinterName = impresosaPredt
                    info.PrintToPrinter(1, False, 0, 0)

                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                    SQLconexion.Close()
                End Try
            End If


        End If

    End Sub

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

    Private Sub dgDetalleCuentCli_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgDetalleCuentCli.DoubleClick

        If Me.dgDetalleCuentCli.CurrentRowIndex < 0 Then

        Else
            VALOR_DOCUMENTO = Trim(Me.dgDetalleCuentCli.Item(Me.dgDetalleCuentCli.CurrentRowIndex, 0))
            CUOTA = Trim(Me.dgDetalleCuentCli.Item(Me.dgDetalleCuentCli.CurrentRowIndex, 1))
            DIAS_AVENCER = Trim(Me.dgDetalleCuentCli.Item(Me.dgDetalleCuentCli.CurrentRowIndex, 2))
            MONTO_CUOTA = Trim(Me.dgDetalleCuentCli.Item(Me.dgDetalleCuentCli.CurrentRowIndex, 3))
            FECHA_VENCIMIENTO = Trim(Me.dgDetalleCuentCli.Item(Me.dgDetalleCuentCli.CurrentRowIndex, 4))
            CODIGO_CLIENTE_ = CInt(Me.dgDetalleCuentCli.Item(Me.dgDetalleCuentCli.CurrentRowIndex, 5))
            CABECERA_CUENTACLI = CInt(Me.dgDetalleCuentCli.Item(Me.dgDetalleCuentCli.CurrentRowIndex, 6))
            INTERES_MORATORIO = CInt(Me.dgDetalleCuentCli.Item(Me.dgDetalleCuentCli.CurrentRowIndex, 7))
            TIPO_DOCUMENTO = Trim(Me.dgDetalleCuentCli.Item(Me.dgDetalleCuentCli.CurrentRowIndex, 8))
            FECHA_FACTURACION = Trim(Me.dgDetalleCuentCli.Item(Me.dgDetalleCuentCli.CurrentRowIndex, 9))

            CODIGO_CLIENTE = BUSQUEDA_CODCLIENTE(VALOR_DOCUMENTO)
            IDENTIFICADOR2 = BUSQUEDA_IDENTIFICADOR(CODIGO_CLIENTE)
            CODIGO_FACTURA = BUSQUEDA_CODFACTURA(CODIGO_CLIENTE)
            '***********************************************************************
            identificador_dobleclick = 1

            If TIPO_DOCUMENTO = "CONTADO" Then
                IDENTIFICADOR_CONTADO = 1

                If IDENTIFICADOR2 = "T" Then
                    Try
                        Dim dt As New DataTable
                        Dim da As New SqlDataAdapter("REPORTE_FACTURACION_FACTURA", SQLconexion)
                        da.SelectCommand.CommandType = CommandType.StoredProcedure
                        da.SelectCommand.Parameters.AddWithValue("@NUMERO_FACTURA", VALOR_DOCUMENTO)
                        'da.SelectCommand.Parameters.AddWithValue("@NUMERO_CODIGO", CODIGO_CLIENTE_)
                        da.Fill(dt)

                        Dim ds As New Data.DataSet
                        ds.Tables.Add(dt)

                        Dim info As New REPORTE_TICKET
                        info.SetDataSource(ds)
                        info.SetParameterValue("@NUMERO_FACTURA", VALOR_DOCUMENTO)
                        'info.SetParameterValue("@NUMERO_CODIGO", CODIGO_CLIENTE_)
                        SetDBLogonForReport(iconexion, info)
                        Me.CrystalReportViewer1.ReportSource = info

                    Catch ex As Exception
                        MessageBox.Show(ex.ToString)
                        SQLconexion.Close()
                    End Try
                Else
                    If IDENTIFICADOR2 = "F" Then
                        Try
                            Dim dt As New DataTable
                            Dim da As New SqlDataAdapter("REPORTE_FACTURACION_FACTURA", SQLconexion)
                            da.SelectCommand.CommandType = CommandType.StoredProcedure
                            da.SelectCommand.Parameters.AddWithValue("@NUMERO_FACTURA", VALOR_DOCUMENTO)
                            'da.SelectCommand.Parameters.AddWithValue("@NUMERO_CODIGO", CODIGO_CLIENTE_)
                            da.Fill(dt)

                            Dim ds As New Data.DataSet
                            ds.Tables.Add(dt)

                            Dim info As New REPORTE_FACTURA
                            info.SetDataSource(ds)
                            info.SetParameterValue("@NUMERO_FACTURA", VALOR_DOCUMENTO)
                            'info.SetParameterValue("@NUMERO_CODIGO", CODIGO_CLIENTE_)
                            SetDBLogonForReport(iconexion, info)
                            Me.CrystalReportViewer1.ReportSource = info

                        Catch ex As Exception
                            MessageBox.Show(ex.ToString)
                            SQLconexion.Close()
                        End Try
                    End If
                End If
            End If

            If TIPO_DOCUMENTO = "CREDITO" Then
                IDENTIFICADOR_CREDITO = 1
                If b = 0 Then
                    contador_cabRecibo = Contador_Recibo() + 1
                    b = 1
                    secuencia_ticket = CStr(contador_cabRecibo)
                    NUM_RECIBO = secuencia_ticket.PadLeft(7, "0")
                    aux_num_recibo = NUM_RECIBO
                    Try
                        SQLconexion.Open()
                        Dim sqlbuilder As New System.Text.StringBuilder
                        With sqlbuilder
                            .Append("INSERT INTO CP_CABECERA_RECIBO")
                            .Append(" VALUES ('")
                            .Append(contador_cabRecibo & "','")
                            .Append(CODIGO_CLIENTE & "','")
                            .Append(Trim(NUM_RECIBO) & "','")
                            .Append(CDate(Today) & "','")
                            .Append(0 & "','")
                            .Append(OPERADOR & "','")
                            .Append(0 & "')")

                        End With
                        cmm = New SqlClient.SqlCommand(sqlbuilder.ToString, SQLconexion)
                        cmm.ExecuteNonQuery()
                        SQLconexion.Close()
                        cmm.Dispose()
                        SQLconexion.Dispose()

                    Catch ex As SqlClient.SqlException
                        MsgBox(ex.Message())
                        SQLconexion.Close()
                    End Try
                End If

                'INSERTAR EN DETALLE RECIBO
                Dim Monto_Deuda As Integer
                Monto_Deuda = MONTO_CUOTA + INTERES_MORATORIO

                If Registro_en_DetalleRecibo(contador_cabRecibo, VALOR_DOCUMENTO, CUOTA) = 1 Then
                    MessageBox.Show("DATOS SELECCIONADOS YA FUERON INGRESADOS", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    Dim Contador_Detalle, Cantidad_Cuota As Integer
                    Dim paraMontoDetRecibo As String
                    Cantidad_Cuota = Cantidad_CuotaCliente(CODIGO_CLIENTE, VALOR_DOCUMENTO)
                    paraMontoDetRecibo = CStr(CUOTA & "/" & Cantidad_Cuota)
                    Contador_Detalle = Contador_Detalle_() + 1
                    Try
                        SQLconexion.Open()
                        Dim sqlbuilder As New System.Text.StringBuilder
                        With sqlbuilder
                            .Append("INSERT INTO CP_DETALLE_RECIBO")
                            .Append(" VALUES ('")
                            .Append(Contador_Detalle & "','")
                            .Append(contador_cabRecibo & "','")
                            .Append(Trim(VALOR_DOCUMENTO) & "','")
                            .Append(FECHA_VENCIMIENTO & "','")
                            .Append(MONTO_CUOTA & "','")
                            .Append(paraMontoDetRecibo & "')")
                        End With

                        cmm = New SqlClient.SqlCommand(sqlbuilder.ToString, SQLconexion)
                        cmm.ExecuteNonQuery()
                        SQLconexion.Close()
                        cmm.Dispose()
                        SQLconexion.Dispose()

                    Catch ex As SqlClient.SqlException
                        MsgBox(ex.Message())
                        SQLconexion.Close()
                    End Try
                    '*******************************************************************
                    If INTERES_MORATORIO > 0 Then
                        Dim CONCEPTO As String
                        CONCEPTO = "INTERES MORATORIO "
                        Contador_Detalle = Contador_Detalle_() + 1
                        Try
                            SQLconexion.Open()
                            Dim sqlbuilder As New System.Text.StringBuilder
                            With sqlbuilder
                                .Append("INSERT INTO CP_DETALLE_RECIBO")
                                .Append(" VALUES ('")
                                .Append(Contador_Detalle & "','")
                                .Append(contador_cabRecibo & "','")
                                .Append(Trim("INTERES MORATORIO CUOTA") & "','")
                                .Append(FECHA_VENCIMIENTO & "','")
                                .Append(INTERES_MORATORIO & "','")
                                .Append(paraMontoDetRecibo & "')")
                            End With

                            cmm = New SqlClient.SqlCommand(sqlbuilder.ToString, SQLconexion)
                            cmm.ExecuteNonQuery()
                            SQLconexion.Close()
                            cmm.Dispose()
                            SQLconexion.Dispose()

                        Catch ex As SqlClient.SqlException
                            MsgBox(ex.Message())
                            SQLconexion.Close()
                        End Try
                    End If

                End If

                If CUOTA = 0 Then
                    Try
                        conectar()
                        Dim dt As New DataTable
                        Dim da As New SqlDataAdapter("PAGO_RECIBO", SQLconexion)
                        da.SelectCommand.CommandType = CommandType.StoredProcedure
                        da.SelectCommand.Parameters.AddWithValue("@NUMERO_RECIBO", NUM_RECIBO)
                        da.Fill(dt)

                        Dim ds As New Data.DataSet
                        ds.Tables.Add(dt)

                        Dim info As New RECIBO_DE_DINERO_ENTREGA
                        info.SetDataSource(ds)
                        info.SetParameterValue("@NUMERO_RECIBO", NUM_RECIBO)
                        SetDBLogonForReport(iconexion, info)
                        Me.CrystalReportViewer1.ReportSource = info

                    Catch ex As Exception
                        MessageBox.Show(ex.ToString)
                        SQLconexion.Close()
                    End Try
                Else
                    Try
                        conectar()
                        Dim dt As New DataTable
                        Dim da As New SqlDataAdapter("PAGO_RECIBO", SQLconexion)
                        da.SelectCommand.CommandType = CommandType.StoredProcedure
                        da.SelectCommand.Parameters.AddWithValue("@NUMERO_RECIBO", NUM_RECIBO)
                        da.Fill(dt)

                        Dim ds As New Data.DataSet
                        ds.Tables.Add(dt)

                        Dim info As New RECIBO_DE_DINERO
                        info.SetDataSource(ds)
                        info.SetParameterValue("@NUMERO_RECIBO", NUM_RECIBO)
                        SetDBLogonForReport(iconexion, info)
                        Me.CrystalReportViewer1.ReportSource = info

                    Catch ex As Exception
                        MessageBox.Show(ex.ToString)
                        SQLconexion.Close()
                    End Try
                End If

                'VISUALIZAR MONTOS DE CUOTAS E INTERESES
                Me.txtImportedeCuotas.Text = CStr(Puntos(ImportedeCuotas_(contador_cabRecibo, "INTERES MORATORIO CUOTA")))
                Me.txtImportedeInteres.Text = CStr(Puntos(ImportedeInteres_(contador_cabRecibo, "INTERES MORATORIO CUOTA")))

            End If
        End If
    End Sub

    'IMPORTE DE CUOTAS**
    Function ImportedeCuotas_(ByVal a As Integer, ByVal b As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COALESCE(SUM(IMPORTE_CUOTA),0) FROM CP_DETALLE_RECIBO WHERE FACTURA_NUMERO <> '" & b & "' AND COD_CABECERA_RECIBO = " & a & ""
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

    'IMPORTE DE INTERES***
    Function ImportedeInteres_(ByVal a As Integer, ByVal b As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COALESCE(SUM(IMPORTE_CUOTA),0) FROM CP_DETALLE_RECIBO WHERE FACTURA_NUMERO = '" & b & "' AND COD_CABECERA_RECIBO = " & a & ""
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

    Private Sub txtMontoPagoCuotas_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMontoPagoCuotas.Leave
        Dim texto As String
        Dim pasar As Integer = 0
        If Not IsNumeric(txtMontoPagoCuotas.Text) Then
            Beep()
            MsgBox("Se debe ingresar solo números")
            Me.txtMontoPagoCuotas.Focus()
        Else
            texto = Me.txtMontoPagoCuotas.Text
            texto = Replace(texto, ".", "")
            texto = Replace(texto, ",", "")
            texto = Replace(texto, "/", "")
            texto = Replace(texto, "-", "")
            pasar = 1
        End If
        If pasar = 1 Then
            If Me.txtMontoPagoCuotas.Text = "" Then
                Me.txtMontoPagoCuotas.Text = 0
                Dim reeplazo As Integer
                reeplazo = CInt(Me.txtMontoPagoCuotas.Text)
                Me.txtMontoPagoCuotas.Text = CStr(Puntos(reeplazo))
            Else
                If Me.txtMontoPagoCuotas.Text >= 0 Then
                    Dim reeplazo As Integer
                    reeplazo = CInt(Me.txtMontoPagoCuotas.Text)
                    Me.txtMontoPagoCuotas.Text = CStr(Puntos(reeplazo))

                    If CUOTA = 0 Then
                        If CInt(Me.txtMontoPagoCuotas.Text) < MONTO_CUOTA Then
                            MessageBox.Show("PARA CONTADO O ENTREGA INICIAL,IMPORTE NO PUEDE SER MENOR A MONTO DE FACTURA", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.txtMontoPagoCuotas.Focus()
                        Else
                            Dim SALDO As Integer
                            SALDO = CInt(Me.txtMontoPagoCuotas.Text) - MONTO_CUOTA
                            Me.txtSaldodeCuotas.Text = CStr(Puntos(SALDO))
                        End If
                    Else
                        If CInt(Me.txtMontoPagoCuotas.Text) < CInt(Me.txtImportedeCuotas.Text) Then
                            Dim SALDO As Integer
                            SALDO = CInt(Me.txtImportedeCuotas.Text) - CInt(Me.txtMontoPagoCuotas.Text)
                            Me.txtSaldodeCuotas.Text = CStr(Puntos(SALDO))
                        Else
                            Dim SALDO, descuento As Integer
                            SALDO = CInt(Me.txtMontoPagoCuotas.Text) - CInt(Me.txtImportedeCuotas.Text)
                            Me.txtSaldodeCuotas.Text = CStr(Puntos(SALDO))
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtMontoPagoInteres_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMontoPagoInteres.Leave
        Dim texto As String
        Dim pasar As Integer = 0
        If Not IsNumeric(txtMontoPagoInteres.Text) Then
            Beep()
            MsgBox("Se debe ingresar solo números")
            Me.txtMontoPagoInteres.Focus()
        Else
            texto = Me.txtMontoPagoInteres.Text
            texto = Replace(texto, ".", "")
            texto = Replace(texto, ",", "")
            texto = Replace(texto, "/", "")
            texto = Replace(texto, "-", "")
            pasar = 1
        End If
        If pasar = 1 Then
            If Me.txtMontoPagoInteres.Text = "" Then
                Me.txtMontoPagoInteres.Text = 0
                Dim reeplazo As Integer
                reeplazo = CInt(Me.txtMontoPagoInteres.Text)
                Me.txtMontoPagoInteres.Text = CStr(Puntos(reeplazo))
            Else
                If Me.txtMontoPagoInteres.Text >= 0 Then
                    Dim reeplazo As Integer
                    reeplazo = CInt(Me.txtMontoPagoInteres.Text)
                    Me.txtMontoPagoInteres.Text = CStr(Puntos(reeplazo))

                    If CUOTA = 0 Then
                    Else
                        If CInt(Me.txtMontoPagoInteres.Text) < CInt(Me.txtImportedeInteres.Text) Then
                            Dim SALDO As Integer
                            SALDO = CInt(Me.txtImportedeInteres.Text) - CInt(Me.txtMontoPagoInteres.Text)
                            Me.txtSaldodeInteres.Text = CStr(Puntos(SALDO))
                        Else
                            Dim SALDO, descuento As Integer
                            SALDO = CInt(Me.txtMontoPagoInteres.Text) - CInt(Me.txtImportedeInteres.Text)
                            Me.txtSaldodeInteres.Text = CStr(Puntos(SALDO))
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub txtDescuentoCuota_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescuentoCuota.Leave
        Dim texto As String
        Dim pasar As Integer = 0
        If Not IsNumeric(txtDescuentoCuota.Text) Then
            Beep()
            MsgBox("Se debe ingresar solo números")
            Me.txtDescuentoCuota.Focus()
        Else
            texto = Me.txtDescuentoCuota.Text
            texto = Replace(texto, ".", "")
            texto = Replace(texto, ",", "")
            texto = Replace(texto, "/", "")
            texto = Replace(texto, "-", "")
            pasar = 1
        End If

        Dim descuento As Integer = CInt(Me.txtDescuentoCuota.Text)
        If pasar = 1 Then
            If Me.txtDescuentoCuota.Text = "" Then
                Me.txtDescuentoCuota.Text = 0
                Dim reeplazo As Integer
                reeplazo = CInt(Me.txtDescuentoCuota.Text)
                Me.txtDescuentoCuota.Text = CStr(Puntos(reeplazo))
            Else
                If Me.txtDescuentoCuota.Text > 0 Then
                    Dim reeplazo As Integer
                    reeplazo = CInt(Me.txtDescuentoCuota.Text)
                    Me.txtDescuentoCuota.Text = CStr(Puntos(reeplazo))

                    If CUOTA = 0 Then
                    Else
                        Dim SALDO As Integer
                        SALDO = CInt(Me.txtSaldodeCuotas.Text)
                        Me.txtSaldodeCuotas.Text = SALDO - CInt(Me.txtDescuentoCuota.Text)
                        End If
                    End If
                End If
            End If
    End Sub

    Private Sub txtDescuentoInteres_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDescuentoInteres.Leave
        Dim texto As String
        Dim pasar As Integer = 0
        If Not IsNumeric(txtDescuentoInteres.Text) Then
            Beep()
            MsgBox("Se debe ingresar solo números")
            Me.txtDescuentoCuota.Focus()
        Else
            texto = Me.txtDescuentoInteres.Text
            texto = Replace(texto, ".", "")
            texto = Replace(texto, ",", "")
            texto = Replace(texto, "/", "")
            texto = Replace(texto, "-", "")
            pasar = 1
        End If

        Dim descuento As Integer = CInt(Me.txtDescuentoInteres.Text)
        If pasar = 1 Then
            If Me.txtDescuentoInteres.Text = "" Then
                Me.txtDescuentoInteres.Text = 0
                Dim reeplazo As Integer
                reeplazo = CInt(Me.txtDescuentoInteres.Text)
                Me.txtDescuentoInteres.Text = CStr(Puntos(reeplazo))
            Else
                If Me.txtDescuentoInteres.Text > 0 Then
                    Dim reeplazo As Integer
                    reeplazo = CInt(Me.txtDescuentoInteres.Text)
                    Me.txtDescuentoInteres.Text = CStr(Puntos(reeplazo))

                    If CUOTA = 0 Then
                    Else
                        Dim SALDO As Integer
                        SALDO = CInt(Me.txtSaldodeInteres.Text)
                        Me.txtSaldodeInteres.Text = SALDO - CInt(Me.txtDescuentoInteres.Text)
                    End If
                End If
            End If
        End If
    End Sub

End Class