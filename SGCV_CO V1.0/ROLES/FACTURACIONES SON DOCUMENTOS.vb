Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System
Imports System.IO
Imports System.Diagnostics

Public Class FACTURACIONES_SON_DOCUMENTOS

    Dim DaCliente, DaDetalle, DaCuentasActivas, DaDocumento As New SqlClient.SqlDataAdapter
    Dim DsCliente, DsDetalle, DsCuentasActivas, DsDocumento As New Data.DataSet
    Dim cliente, cod_ As Integer
    Dim nombre As String
    Dim contador_CuentaCliente, cod_Cliente, b, borrar_CodCuenta As Integer
    Dim fecha As Date
    Dim FECHA_INICIAL, FECHA_FINAL As Date
    Dim band_1, band_2 As Integer
    Dim Contador_Ticket, borrar_CodCliente As Integer
    Dim busqueda_cliente As Integer
    Dim Codigo_Cliente_Reversa, Codigo_CuentaCli_Reversa As Integer
    Dim bandera_reversa, para_CantCuotas As Integer
    Dim Secuencia_Facturacion As String
    Dim cliente_ As String
    Dim codigo_cliente As Integer


    Sub Cargar_Datos()
        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM TP_CLIENTE"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaCliente = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsCliente = New Data.DataSet
            DaCliente.Fill(Me.DsCliente, "TP_CLIENTE")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM TP_DOCUMENTOS"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaDocumento = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsDocumento = New Data.DataSet
            DaDocumento.Fill(Me.DsDocumento, "TP_DOCUMENTOS")
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

    Private Sub FACTURACIONES_SON_DOCUMENTOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar_Datos()

        band_1 = 0
        band_2 = 0

        iconexion.DatabaseName = bbdd
        iconexion.UserID = usuario_
        iconexion.Password = contrasena_
        iconexion.ServerName = servidor

        iconexion.Type = ConnectionInfoType.SQL

        Me.rbSemanal.Enabled = False

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Function Cantidad_Registros_CC() As Integer
        Try
            Dim sel As String
            sel = "SELECT COALESCE(MAX(COD_CABECERA_CUENTACLI),0) FROM VF_CABECERA_CUENTACLIENTE"
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

    'INSERTAR CABECERA CUENTA CLIENTE!!**************
    Sub Insertar_Cabecera_CCliente(ByVal a As Integer, ByVal b As Integer, ByVal c As Date, ByVal d As Integer)
        Try
            Dim sel As String
            sel = "INSERT INTO VF_CABECERA_CUENTACLIENTE" & _
                "(COD_CABECERA_CUENTACLI,COD_CLIENTE,FECHA_INGRESO,MONTO_CUENTA) " & _
                "VALUES " & _
                "(@COD_CABECERA_CUENTACLI,@COD_CLIENTE,@FECHA_INGRESO,@MONTO_CUENTA) "

            cmm = New SqlClient.SqlCommand(sel, SQLconexion)

            cmm.Parameters.AddWithValue("@COD_CABECERA_CUENTACLI", a)
            cmm.Parameters.AddWithValue("@COD_CLIENTE", b)
            cmm.Parameters.AddWithValue("@FECHA_INGRESO", c)
            cmm.Parameters.AddWithValue("@MONTO_CUENTA", d)

            SQLconexion.Open()
            Dim t As Integer = CInt(cmm.ExecuteScalar())
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub

    'INSERTAR DETALLE CUENTA CLIENTE!!**************
    Sub Insertar_Detalle_CCliente(ByVal a As Integer, ByVal b As Integer, ByVal c As String, _
                                        ByVal d As Date, ByVal e As Integer, ByVal f As Integer, _
                                        ByVal g As Integer, ByVal h As Date, ByVal i As Integer, _
                                        ByVal j As String, ByVal k As String)
        Try
            Dim sel As String

            sel = "INSERT INTO VF_DETALLE_CUENTACLIENTE" & _
                "(COD_DETALLE_CUENTACLI,COD_CABECERA_CUENTACLI,DOCUMENTO_FACTURACION,FECHA_FACTURACION,CUOTA,DIAS_A_VENCER,MONTO_CUOTA,FECHA_VENCIMIENTO,COD_CLIENTE,ESTADO_CUOTA,TIPO_DOCUMENTO)" & _
                "VALUES " & _
                 "(@COD_DETALLE_CUENTACLI,@COD_CABECERA_CUENTACLI,@DOCUMENTO_FACTURACION,@FECHA_FACTURACION,@CUOTA,@DIAS_A_VENCER,@MONTO_CUOTA,@FECHA_VENCIMIENTO,@COD_CLIENTE,@ESTADO_CUOTA,@TIPO_DOCUMENTO)"

            cmm = New SqlClient.SqlCommand(sel, SQLconexion)

            cmm.Parameters.AddWithValue("@COD_DETALLE_CUENTACLI", a)
            cmm.Parameters.AddWithValue("@COD_CABECERA_CUENTACLI", b)
            cmm.Parameters.AddWithValue("@DOCUMENTO_FACTURACION", c)
            cmm.Parameters.AddWithValue("@FECHA_FACTURACION", d)
            cmm.Parameters.AddWithValue("@CUOTA", e)
            cmm.Parameters.AddWithValue("@DIAS_A_VENCER", f)
            cmm.Parameters.AddWithValue("@MONTO_CUOTA", g)
            cmm.Parameters.AddWithValue("@FECHA_VENCIMIENTO", h)
            cmm.Parameters.AddWithValue("@COD_CLIENTE", i)
            cmm.Parameters.AddWithValue("@ESTADO_CUOTA", j)
            cmm.Parameters.AddWithValue("@TIPO_DOCUMENTO", k)

            SQLconexion.Open()
            Dim t As Integer = CInt(cmm.ExecuteScalar())
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub

    Function Contador_Ticket_(ByVal a As String, ByVal b As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT SECUENCIA_FINAL_TICKET FROM TP_DOCUMENTOS WHERE TIPO_DOCUMENTO LIKE '" & a & "' AND ESTADO LIKE '" & b & "'"
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

    Private Sub btnGenerarCuota_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerarCuota.Click

        fecha = DateTime.Now

        If Me.txtMontoCuenta.Text = "" Then
            MessageBox.Show("NO ESTA PERMITIDO VALORES NULOS", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtMontoCuenta.Focus()
        Else
            If CInt(Me.txtMontoCuenta.Text) = 0 Then
                MessageBox.Show("CUENTA NO PUEDE SER CERO", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtMontoCuenta.Focus()
            Else
                If b = 0 Then
                    MessageBox.Show("DEFINIR FECHA DE VENCIMIENTO INICIAL", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtMontoCuenta.Focus()
                Else
                    If Me.rbMensual.Checked = True Then

                        If Contador_Ticket_("TICKET", "ACTIVO") = 0 Then
                            Contador_Ticket = 1
                            Dim secuencia_ticket As String = CStr(Contador_Ticket)
                            Secuencia_Facturacion = secuencia_ticket.PadLeft(7, "0")
                        Else
                            Contador_Ticket = Contador_Ticket_("TICKET", "ACTIVO") + 1
                            Dim secuencia_ticket As String = CStr(Contador_Ticket)
                            Secuencia_Facturacion = secuencia_ticket.PadLeft(7, "0")
                        End If

                        Dim divisor_cuota As Integer
                        divisor_cuota = CInt(Me.txtDivisor.Text)

                        Dim saldo As Integer
                        saldo = CInt(Me.txtMontoCuenta.Text)

                        If Cantidad_Registros_CC() = 0 Then
                            contador_CuentaCliente = 1
                        Else
                            contador_CuentaCliente = Cantidad_Registros_CC() + 1
                        End If

                        Insertar_Cabecera_CCliente(contador_CuentaCliente, codigo_cliente, fecha, CInt(Me.txtMontoCuenta.Text))

                        'PARA SABER CUANTO SERA LA CUOTA*********************************
                        Dim cuota, a, dias_cuota, conta, c, f, aux1 As Integer
                        Dim dValueDate, fecha_venc As Date
                        Dim bandera_entrega As Integer
                        Dim Tipo_Documento As String

                        Tipo_Documento = "CREDITO"

                        If CInt(Me.txtEntregaInicial.Text) > 0 Then
                            bandera_entrega = 0
                            divisor_cuota = divisor_cuota - 1
                            cuota = (saldo - CInt(Me.txtEntregaInicial.Text)) / divisor_cuota
                            divisor_cuota = divisor_cuota + 1
                        Else
                            cuota = saldo / divisor_cuota
                        End If

                        For a = 1 To divisor_cuota

                            If CInt(Me.txtEntregaInicial.Text) > 0 Then

                                If bandera_entrega = 0 Then
                                    bandera_entrega = 1

                                    dValueDate = Today
                                    fecha_venc = dValueDate.AddMonths(0)
                                    dias_cuota = DateDiff(DateInterval.Day, Today, fecha_venc)

                                    Insertar_Detalle_CCliente(a, contador_CuentaCliente, Trim(Secuencia_Facturacion), Today, _
                                       a, dias_cuota - 1, Math.Round(CInt(Me.txtEntregaInicial.Text)), fecha_venc, codigo_cliente, "PENDIENTE", "CREDITO")
                                Else
                                    dValueDate = fecha_VencimientoCredito
                                    fecha_venc = dValueDate.AddMonths(a - 1)
                                    dias_cuota = DateDiff(DateInterval.Day, Today, fecha_venc)

                                    Insertar_Detalle_CCliente(a, contador_CuentaCliente, Trim(Secuencia_Facturacion), Today, _
                                             a, dias_cuota - 1, Math.Round(cuota), fecha_venc, codigo_cliente, "PENDIENTE", "CREDITO")
                                End If
                            Else
                                dValueDate = fecha_VencimientoCredito
                                fecha_venc = dValueDate.AddMonths(a - 1)
                                dias_cuota = DateDiff(DateInterval.Day, Today, fecha_venc)

                                Insertar_Detalle_CCliente(a, contador_CuentaCliente, Trim(Secuencia_Facturacion), Today, _
                                         a, dias_cuota - 1, Math.Round(cuota), fecha_venc, codigo_cliente, "PENDIENTE", "CREDITO")
                            End If

                        Next
                        Dim ruc As String
                        ruc = "3845067-4"
                        Try
                            Dim sel As String
                            sel = "UPDATE TP_DOCUMENTOS SET SECUENCIA_FINAL_TICKET = " & Contador_Ticket & "" & _
                            "WHERE TIPO_DOCUMENTO LIKE '" & "TICKET" & "' AND ESTADO LIKE '" & "ACTIVO" & "' AND RUC_PROPIETARIO LIKE '" & ruc & "'"
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

                    '*****************************************************************
                    Me.txtBuscar_Datos.Clear()
                    Me.txtCliente.Clear()
                    Me.txtMontoCuenta.Text = 0
                    Me.txtDivisor.Clear()
                    Me.txtEntregaInicial.Text = 0
                    b = 0

                    Try
                        conectar()
                        Dim sel As String
                        sel = "SELECT * FROM TP_CLIENTE WHERE NOM_APE LIKE '%" & "ññ" & "%'"
                        cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                        'crear adapter
                        DaCliente = New SqlClient.SqlDataAdapter(cmm)
                        'crear dataset
                        DsCliente = New Data.DataSet
                        DaCliente.Fill(Me.DsCliente, "TP_CLIENTE")
                        'asignar dataset al datagrid
                        Me.dg_clientes.DataSource = Me.DsCliente
                        Me.dg_clientes.DataMember = "TP_CLIENTE"

                        DaDocumento.Update(Me.DsCliente, "TP_CLIENTE")
                        SQLconexion.Close()

                    Catch ex As Exception
                        MsgBox(ex.Message())
                        SQLconexion.Close()
                    End Try

                    Me.txtBuscar_Datos.Focus()
                    MessageBox.Show("CUOTA GENERADA EN CUENTA CLIENTE", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)

                End If
            End If
        End If
    End Sub

    Private Sub DateTimePicker1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateTimePicker1.Leave
        Dim fecha1 As Date
        fecha1 = Me.DateTimePicker1.Value.Date.AddDays(0)
        fecha_VencimientoCredito = fecha1
        b = 1
    End Sub

    Private Sub txtMontoCuenta_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMontoCuenta.Leave
        Dim texto As String
        Dim pasar As Integer = 0
        If Not IsNumeric(txtMontoCuenta.Text) Then
            Beep()
            MsgBox("Se debe ingresar solo números")
            Me.txtMontoCuenta.Focus()
        Else
            texto = Me.txtMontoCuenta.Text
            texto = Replace(texto, ".", "")
            texto = Replace(texto, ",", "")
            texto = Replace(texto, "/", "")
            texto = Replace(texto, "-", "")
            pasar = 1
        End If
        If pasar = 1 Then
            Dim Calculo As Integer
            Calculo = Me.txtMontoCuenta.Text
            Me.txtMontoCuenta.Text = Puntos(Calculo)
        End If
    End Sub

    Private Sub btnRevertir_Operacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRevertir_Operacion.Click

        If bandera_reversa = 0 Then
            MessageBox.Show("DEBE SELECCIONAR CUENTA DE CLIENTE PARA REVERSA", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.dgDeudas_Activas_Cliente.Focus()
        Else
            Try
                conectar()
                Dim sel As String
                sel = "DELETE FROM VF_DETALLE_CUENTACLIENTE " & _
                "WHERE COD_CABECERA_CUENTACLI = " & Codigo_CuentaCli_Reversa & ""
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
                sel = "DELETE FROM VF_CABECERA_CUENTACLIENTE " & _
                "WHERE COD_CABECERA_CUENTACLI = " & Codigo_CuentaCli_Reversa & ""
                cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                SQLconexion.Open()
                Dim t As Integer = CInt(cmm.ExecuteScalar())
                cmm.Dispose()
                SQLconexion.Close()

            Catch ex As Exception
                MsgBox(ex.Message())
                SQLconexion.Close()
            End Try

            MessageBox.Show("OPERACION REVERTIDA", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

    Function Contador_AnularCUENTACLIENTE() As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM ANULAR_CUENTA_CLIENTE"
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

    Private Sub rbCedula_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCedula.CheckedChanged
        Me.txtBuscar_Datos.Focus()
    End Sub

    Private Sub rbRuc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbRuc.CheckedChanged
        Me.txtBuscar_Datos.Focus()
    End Sub

    Private Sub rbNombreApellido_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNombreApellido.CheckedChanged
        Me.txtBuscar_Datos.Focus()
    End Sub

    Private Sub txtBuscar_Datos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar_Datos.TextChanged

        If Me.rbCedula.Checked = True Then
            Try
                conectar()
                Dim sel As String
                sel = "SELECT * FROM TP_CLIENTE WHERE CI LIKE '%" & Trim(Me.txtBuscar_Datos.Text) & "%'"
                cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                'crear adapter
                DaCliente = New SqlClient.SqlDataAdapter(cmm)
                'crear dataset
                DsCliente = New Data.DataSet
                DaCliente.Fill(Me.DsCliente, "TP_CLIENTE")
                'asignar dataset al datagrid
                Me.dg_clientes.DataSource = Me.DsCliente
                Me.dg_clientes.DataMember = "TP_CLIENTE"

                DaDocumento.Update(Me.DsCliente, "TP_CLIENTE")
                SQLconexion.Close()

            Catch ex As Exception
                MsgBox(ex.Message())
                SQLconexion.Close()
            End Try
        Else
            If Me.rbRuc.Checked = True Then
                Try
                    conectar()
                    Dim sel As String
                    sel = "SELECT * FROM TP_CLIENTE WHERE RUC LIKE '%" & Trim(Me.txtBuscar_Datos.Text) & "%'"
                    cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                    'crear adapter
                    DaCliente = New SqlClient.SqlDataAdapter(cmm)
                    'crear dataset
                    DsCliente = New Data.DataSet
                    DaCliente.Fill(Me.DsCliente, "TP_CLIENTE")
                    'asignar dataset al datagrid
                    Me.dg_clientes.DataSource = Me.DsCliente
                    Me.dg_clientes.DataMember = "TP_CLIENTE"

                    DaDocumento.Update(Me.DsCliente, "TP_CLIENTE")
                    SQLconexion.Close()

                Catch ex As Exception
                    MsgBox(ex.Message())
                    SQLconexion.Close()
                End Try

            Else
                If Me.rbNombreApellido.Checked = True Then
                    Try
                        conectar()
                        Dim sel As String
                        sel = "SELECT * FROM TP_CLIENTE WHERE NOM_APE LIKE '%" & Trim(Me.txtBuscar_Datos.Text) & "%'"
                        cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                        'crear adapter
                        DaCliente = New SqlClient.SqlDataAdapter(cmm)
                        'crear dataset
                        DsCliente = New Data.DataSet
                        DaCliente.Fill(Me.DsCliente, "TP_CLIENTE")
                        'asignar dataset al datagrid
                        Me.dg_clientes.DataSource = Me.DsCliente
                        Me.dg_clientes.DataMember = "TP_CLIENTE"

                        DaDocumento.Update(Me.DsCliente, "TP_CLIENTE")
                        SQLconexion.Close()

                    Catch ex As Exception
                        MsgBox(ex.Message())
                        SQLconexion.Close()
                    End Try
                Else
                    If Me.rbDireccion.Checked = True Then
                        Try
                            conectar()
                            Dim sel As String
                            sel = "SELECT * FROM TP_CLIENTE WHERE DIRECCION LIKE '%" & Trim(Me.txtBuscar_Datos.Text) & "%'"
                            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                            'crear adapter
                            DaCliente = New SqlClient.SqlDataAdapter(cmm)
                            'crear dataset
                            DsCliente = New Data.DataSet
                            DaCliente.Fill(Me.DsCliente, "TP_CLIENTE")
                            'asignar dataset al datagrid
                            Me.dg_clientes.DataSource = Me.DsCliente
                            Me.dg_clientes.DataMember = "TP_CLIENTE"

                            DaDocumento.Update(Me.DsCliente, "TP_CLIENTE")
                            SQLconexion.Close()

                        Catch ex As Exception
                            MsgBox(ex.Message())
                            SQLconexion.Close()
                        End Try
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub rbDireccion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDireccion.CheckedChanged
        Me.txtBuscar_Datos.Focus()
    End Sub

    Function acumulado_deuda(ByVal a As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COALESCE(SUM(MONTO_CUOTA),0) FROM VF_DETALLE_CUENTACLIENTE WHERE COD_CLIENTE = " & a & " AND ESTADO_CUOTA = '" & "PENDIENTE" & "'"
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

    Function acumulado_mora(ByVal a As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COALESCE(SUM(INTERES_MORATORIO),0) FROM VF_DETALLE_CUENTACLIENTE WHERE COD_CLIENTE = " & a & " AND ESTADO_CUOTA = '" & "PENDIENTE" & "'"
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

    Private Sub btnSalir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub dgDeudas_Activas_Cliente_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgDeudas_Activas_Cliente.Click
        If Me.dgDeudas_Activas_Cliente.CurrentRowIndex < 0 Then

        Else
            bandera_reversa = 1
            Codigo_Cliente_Reversa = Me.dgDeudas_Activas_Cliente.Item(Me.dgDeudas_Activas_Cliente.CurrentRowIndex, 2)
            Codigo_CuentaCli_Reversa = Me.dgDeudas_Activas_Cliente.Item(Me.dgDeudas_Activas_Cliente.CurrentRowIndex, 3)
            
        End If
    End Sub

    Private Sub rbMensual_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbMensual.Click
        Me.txtEntregaInicial.Focus()
    End Sub

    Private Sub rbSemanal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbSemanal.Click
        Me.txtDivisor.Focus()
    End Sub

    Private Sub btnLimpiar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        Me.txtBuscar_Datos.Clear()
        Me.txtCliente.Clear()
        Me.txtMontoCuenta.Clear()
        Try
            conectar()
            Dim sel As String
            sel = "SELECT * FROM TP_CLIENTE WHERE NOM_APE LIKE '%" & "ññ" & "%'"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaCliente = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsCliente = New Data.DataSet
            DaCliente.Fill(Me.DsCliente, "TP_CLIENTE")
            'asignar dataset al datagrid
            Me.dg_clientes.DataSource = Me.DsCliente
            Me.dg_clientes.DataMember = "TP_CLIENTE"

            DaDocumento.Update(Me.DsCliente, "TP_CLIENTE")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

            Me.txtBuscar_Datos.Focus()
    End Sub

    Private Sub dg_clientes_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg_clientes.Click

        cod_ = Me.dg_clientes.Item(Me.dg_clientes.CurrentRowIndex, 2)
        nombre = Me.dg_clientes.Item(Me.dg_clientes.CurrentRowIndex, 0)
        codigo_cliente = cod_
        Try
            conectar()
            Dim sel As String
            SQLconexion.Open()
            sel = "SELECT * FROM VF_CABECERA_CUENTACLIENTE WHERE COD_CLIENTE = " & codigo_cliente & " AND MONTO_CUENTA <> 0"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaCuentasActivas = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsCuentasActivas = New Data.DataSet
            DaCuentasActivas.Fill(Me.DsCuentasActivas, "VF_CABECERA_CUENTACLIENTE")
            'asignar dataset al datagrid
            Me.dgDeudas_Activas_Cliente.DataSource = Me.DsCuentasActivas
            Me.dgDeudas_Activas_Cliente.DataMember = "VF_CABECERA_CUENTACLIENTE"

            Me.DaCuentasActivas.Update(Me.DsCuentasActivas, "VF_CABECERA_CUENTACLIENTE")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

        Me.txtCliente.Text = Trim(nombre)
        Me.txtCuentaActual.Text = Puntos(acumulado_deuda(codigo_cliente) + acumulado_mora(codigo_cliente))

    End Sub

    Private Sub txtEntregaInicial_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEntregaInicial.Leave
        If Me.txtEntregaInicial.Text = "" Then
            Me.txtEntregaInicial.Text = CInt(0)
        End If
    End Sub
End Class