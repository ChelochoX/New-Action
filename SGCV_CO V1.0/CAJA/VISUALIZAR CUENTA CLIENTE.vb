Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System
Imports System.IO
Imports System.Diagnostics

Public Class VISUALIZAR_CUENTA_CLIENTE

    Dim DaCliente As New SqlClient.SqlDataAdapter
    Dim codigo_pimpre As Integer
    Dim NUM_CUOTA, COD_CUENTA, MONTO As Integer
    Dim AUX_FECHAVENC As Date

    Dim DaDetCuenta_Cliente, DaSegCobranza, DaInteres, DaHistorial_PagoCC, DaCabCuenta_Cliente As New SqlClient.SqlDataAdapter
    Dim DsDetCuenta_Cliente, DsSegCobranza, DsInteres, DsHistorial_PagoCC, DsCabCuenta_Cliente As New Data.DataSet

    Function codigo_prod_(ByVal a As String) As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COD_CLIENTE FROM TP_CLIENTE WHERE NOM_APE LIKE '" & a & "'"
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

    Function cedula_cliente_(ByVal a As String) As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT CI FROM TP_CLIENTE WHERE NOM_APE LIKE '" & a & "'"
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

    Private Sub lstnombre_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstnombre.Click

        Dim CLIENTE_ As String
        Dim codigo_cliente As Integer
        CLIENTE_ = Trim(Me.lstnombre.Text)
        codigo_cliente = codigo_prod_(Trim(CLIENTE_))
        codigo_pimpre = codigo_cliente
        Me.txtCedula_Cliente.Text = cedula_cliente_(CLIENTE_)
        Dim PAGADO As String
        Dim dias_cuota As Integer
        Dim pendiente As String
        pendiente = "PENDIENTE"
        '************************************
        'VERIFICA VALORES PARA INTERES MORATORIO
        Dim MONTO_INTERES, DIAS_DE_GRACIA As Integer

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
            If (codigo_cliente) = Me.DsDetCuenta_Cliente.Tables("VF_DETALLE_CUENTACLIENTE").Rows(Me.BindingContext(Me.DsDetCuenta_Cliente, "VF_DETALLE_CUENTACLIENTE").Position).Item("COD_CLIENTE") Then

                AUX_FECHAVENC = Me.DsDetCuenta_Cliente.Tables("VF_DETALLE_CUENTACLIENTE").Rows(Me.BindingContext(Me.DsDetCuenta_Cliente, "VF_DETALLE_CUENTACLIENTE").Position).Item("FECHA_VENCIMIENTO")
                PAGADO = Trim(Me.DsDetCuenta_Cliente.Tables("VF_DETALLE_CUENTACLIENTE").Rows(Me.BindingContext(Me.DsDetCuenta_Cliente, "VF_DETALLE_CUENTACLIENTE").Position).Item("ESTADO_CUOTA"))
                NUM_CUOTA = Me.DsDetCuenta_Cliente.Tables("VF_DETALLE_CUENTACLIENTE").Rows(Me.BindingContext(Me.DsDetCuenta_Cliente, "VF_DETALLE_CUENTACLIENTE").Position).Item("CUOTA")
                COD_CUENTA = Me.DsDetCuenta_Cliente.Tables("VF_DETALLE_CUENTACLIENTE").Rows(Me.BindingContext(Me.DsDetCuenta_Cliente, "VF_DETALLE_CUENTACLIENTE").Position).Item("COD_CABECERA_CUENTACLI")
                MONTO = Me.DsDetCuenta_Cliente.Tables("VF_DETALLE_CUENTACLIENTE").Rows(Me.BindingContext(Me.DsDetCuenta_Cliente, "VF_DETALLE_CUENTACLIENTE").Position).Item("MONTO_CUOTA")
                dias_cuota = DateDiff(DateInterval.Day, Today, AUX_FECHAVENC)

                'SI LA CUOTA NO FUE ABONADA SE MODIFICA LOS DIAS DE VENCIMIENTO***
                If PAGADO = pendiente Then
                    actualizar_diasVencimiento(dias_cuota, codigo_cliente, NUM_CUOTA, COD_CUENTA)

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
                            actualizar_diasMoraVencimiento(para_InteresMora, codigo_cliente, NUM_CUOTA, COD_CUENTA)
                        Else
                            If DIAS_DE_GRACIA <= 5 Then
                                actualizar_diasMoraVencimiento(0, codigo_cliente, NUM_CUOTA, COD_CUENTA)
                            End If
                        End If
                    Else
                        actualizar_diasMoraVencimiento(0, codigo_cliente, NUM_CUOTA, COD_CUENTA)
                    End If

                End If
            End If
        Next
        ''************************************************************************
        'ACTUALIZAR CABECERA DE CUENTA DE CLIENTE****
        Dim Cabecera_CuentaCliente, Sumatoria_porCuenta, Sumatoria_porMora As Integer

        For i = 0 To Me.BindingContext(Me.DsCabCuenta_Cliente, "VF_CABECERA_CUENTACLIENTE").Count - 1
            Me.BindingContext(Me.DsCabCuenta_Cliente, "VF_CABECERA_CUENTACLIENTE").Position = i
            If (codigo_cliente) = Me.DsCabCuenta_Cliente.Tables("VF_CABECERA_CUENTACLIENTE").Rows(Me.BindingContext(Me.DsCabCuenta_Cliente, "VF_CABECERA_CUENTACLIENTE").Position).Item("COD_CLIENTE") Then
                Cabecera_CuentaCliente = CInt(Me.DsCabCuenta_Cliente.Tables("VF_CABECERA_CUENTACLIENTE").Rows(Me.BindingContext(Me.DsCabCuenta_Cliente, "VF_CABECERA_CUENTACLIENTE").Position).Item("COD_CABECERA_CUENTACLI"))

                Sumatoria_porCuenta = Sumatoria_PorCuentaCliente(codigo_cliente, Cabecera_CuentaCliente, "PENDIENTE")
                Sumatoria_porMora = Sumatoria_PorMoraCliente(codigo_cliente, Cabecera_CuentaCliente, "PENDIENTE")
                Actualizar_Cuenta_Cliente((Sumatoria_porCuenta + Sumatoria_porMora), codigo_cliente, Cabecera_CuentaCliente)

            End If
        Next

        'CUENTA ACTUAL
        Me.txtCuentaActual.Text = Puntos(Math.Round(Cuenta_Actual_Cliente(codigo_cliente) + Cuenta_Mora_Cliente(codigo_cliente))) & " " & "GS"

        If Me.rbPagados.Checked = True Then
            Try
                conectar()
                Dim sel1 As String
                SQLconexion.Open()
                sel1 = "SELECT * FROM VF_HISTORIAL_PAGO_CUENTACLIENTE WHERE COD_CLIENTE = " & codigo_cliente & " AND ESTADO_CUOTA = '" & "PAGADO" & "' ORDER BY COD_HISTORIAL_PAGOCUENTACLI ASC"
                cmm = New SqlClient.SqlCommand(sel1, SQLconexion)
                'crear adapter
                DaHistorial_PagoCC = New SqlClient.SqlDataAdapter(cmm)
                'crear dataset
                DsHistorial_PagoCC = New Data.DataSet
                DaHistorial_PagoCC.Fill(Me.DsHistorial_PagoCC, "VF_HISTORIAL_PAGO_CUENTACLIENTE")
                'asignar dataset al datagrid
                Me.dg_Historial_PagoCC.DataSource = Me.DsHistorial_PagoCC
                Me.dg_Historial_PagoCC.DataMember = "VF_HISTORIAL_PAGO_CUENTACLIENTE"

                Me.DaHistorial_PagoCC.Update(Me.DsHistorial_PagoCC, "VF_HISTORIAL_PAGO_CUENTACLIENTE")
                SQLconexion.Close()

            Catch ex As Exception
                MsgBox(ex.Message())
                SQLconexion.Close()
            End Try

            Try
                conectar()
                Dim sel As String
                SQLconexion.Open()
                sel = "SELECT * FROM CP_SEGUIM_COBRANZA WHERE COD_CLIENTE = " & codigo_cliente & " ORDER BY FECHA_SEGUIMIENTO DESC"
                cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                'crear adapter
                DaSegCobranza = New SqlClient.SqlDataAdapter(cmm)
                'crear dataset
                DsSegCobranza = New Data.DataSet
                DaSegCobranza.Fill(Me.DsSegCobranza, "CP_SEGUIM_COBRANZA")
                'asignar dataset al datagrid
                Me.dgDetallesCobranza.DataSource = Me.DsSegCobranza
                Me.dgDetallesCobranza.DataMember = "CP_SEGUIM_COBRANZA"

                Me.DaSegCobranza.Update(Me.DsSegCobranza, "CP_SEGUIM_COBRANZA")
                SQLconexion.Close()

            Catch ex As Exception
                MsgBox(ex.Message())
                SQLconexion.Close()
            End Try

            Me.dg_Historial_PagoCC.Show()
            Me.dg_CuentaCliente.Hide()
        Else
            If Me.rbPendientes.Checked = True Then
                Try
                    conectar()
                    Dim sel As String
                    SQLconexion.Open()
                    sel = "SELECT * FROM VF_DETALLE_CUENTACLIENTE WHERE COD_CLIENTE = " & codigo_cliente & " AND ESTADO_CUOTA = '" & "PENDIENTE" & "'"
                    cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                    'crear adapter
                    DaDetCuenta_Cliente = New SqlClient.SqlDataAdapter(cmm)
                    'crear dataset
                    DsDetCuenta_Cliente = New Data.DataSet
                    DaDetCuenta_Cliente.Fill(Me.DsDetCuenta_Cliente, "VF_DETALLE_CUENTACLIENTE")
                    'asignar dataset al datagrid
                    Me.dg_CuentaCliente.DataSource = Me.DsDetCuenta_Cliente
                    Me.dg_CuentaCliente.DataMember = "VF_DETALLE_CUENTACLIENTE"

                    Me.DaDetCuenta_Cliente.Update(Me.DsDetCuenta_Cliente, "VF_DETALLE_CUENTACLIENTE")
                    SQLconexion.Close()

                Catch ex As Exception
                    MsgBox(ex.Message())
                    SQLconexion.Close()
                End Try

                Try
                    conectar()
                    Dim sel As String
                    SQLconexion.Open()
                    sel = "SELECT * FROM CP_SEGUIM_COBRANZA WHERE COD_CLIENTE = " & codigo_cliente & " ORDER BY FECHA_SEGUIMIENTO DESC"
                    cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                    'crear adapter
                    DaSegCobranza = New SqlClient.SqlDataAdapter(cmm)
                    'crear dataset
                    DsSegCobranza = New Data.DataSet
                    DaSegCobranza.Fill(Me.DsSegCobranza, "CP_SEGUIM_COBRANZA")
                    'asignar dataset al datagrid
                    Me.dgDetallesCobranza.DataSource = Me.DsSegCobranza
                    Me.dgDetallesCobranza.DataMember = "CP_SEGUIM_COBRANZA"

                    Me.DaSegCobranza.Update(Me.DsSegCobranza, "CP_SEGUIM_COBRANZA")
                    SQLconexion.Close()

                Catch ex As Exception
                    MsgBox(ex.Message())
                    SQLconexion.Close()
                End Try

                Me.dg_Historial_PagoCC.Hide()
                Me.dg_CuentaCliente.Show()

            End If
        End If

    End Sub
    Function Cuenta_Actual_Cliente(ByVal a As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COALESCE(SUM(MONTO_CUOTA),0) FROM VF_DETALLE_CUENTACLIENTE " & _
            "WHERE COD_CLIENTE = " & a & " AND ESTADO_CUOTA = '" & "PENDIENTE" & "'"
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

    Function Cuenta_Mora_Cliente(ByVal a As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COALESCE(SUM(INTERES_MORATORIO),0) FROM VF_DETALLE_CUENTACLIENTE " & _
            "WHERE COD_CLIENTE = " & a & " AND ESTADO_CUOTA = '" & "PENDIENTE" & "'"
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
    Function nombre_(ByVal a As String) As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT NOMBRE FROM TP_CLIENTE WHERE CI LIKE '" & a & "'"
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
    Function apellidos_(ByVal a As String) As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT APELLIDO FROM TP_CLIENTE WHERE CI LIKE '" & a & "'"
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
    Private Sub txtCedula_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCliente.TextChanged

        If Me.rbCedula.Checked = True Then
            Try
                conectar()
                SQLconexion.Open()
                Dim sel As String
                sel = "SELECT * FROM TP_CLIENTE WHERE CI LIKE '%" & Trim(Me.txtCliente.Text) & "%'"
                cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                'crear adapter
                DaCliente = New SqlClient.SqlDataAdapter(cmm)
                'crear dataset
                Dim dt As New DataTable("TP_CLIENTE")
                DaCliente.Fill(dt)
                SQLconexion.Close()

                With lstnombre
                    .DataSource = dt
                    .DisplayMember = "CLIENTE"
                    .ValueMember = "NOM_APE"
                End With
            Catch ex As Exception
                MsgBox(ex.Message())
                SQLconexion.Close()
            End Try
        Else
            If Me.rbRuc.Checked = True Then
                Try
                    conectar()
                    SQLconexion.Open()
                    Dim sel As String
                    sel = "SELECT * FROM TP_CLIENTE WHERE RUC LIKE '%" & Trim(Me.txtCliente.Text) & "%'"
                    cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                    'crear adapter
                    DaCliente = New SqlClient.SqlDataAdapter(cmm)
                    'crear dataset
                    Dim dt As New DataTable("TP_CLIENTE")
                    DaCliente.Fill(dt)
                    SQLconexion.Close()

                    With lstnombre
                        .DataSource = dt
                        .DisplayMember = "CLIENTE"
                        .ValueMember = "NOM_APE"
                    End With
                Catch ex As Exception
                    MsgBox(ex.Message())
                    SQLconexion.Close()
                End Try

            Else
                If Me.rbNombreApellido.Checked = True Then
                    Try
                        conectar()
                        SQLconexion.Open()
                        Dim sel As String
                        sel = "SELECT * FROM TP_CLIENTE WHERE NOM_APE LIKE '%" & Trim(Me.txtCliente.Text) & "%'"
                        cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                        'crear adapter
                        DaCliente = New SqlClient.SqlDataAdapter(cmm)
                        'crear dataset
                        Dim dt As New DataTable("TP_CLIENTE")
                        DaCliente.Fill(dt)
                        SQLconexion.Close()

                        With lstnombre
                            .DataSource = dt
                            .DisplayMember = "CLIENTE"
                            .ValueMember = "NOM_APE"
                        End With
                    Catch ex As Exception
                        MsgBox(ex.Message())
                        SQLconexion.Close()
                    End Try


                End If
            End If
        End If

    End Sub

    Private Sub rbCedula_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbCedula.Click
        Me.txtCliente.Focus()
    End Sub

    Private Sub rbRuc_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbRuc.Click
        Me.txtCliente.Focus()
    End Sub

    Private Sub rbNombreApellido_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbNombreApellido.Click
        Me.txtCliente.Focus()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        Dim instance As New Printing.PrinterSettings
        Dim impresosaPredt As String = instance.PrinterName

        Try
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter("CUENTA_CLIENTE", SQLconexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@COD_CLIENTE", codigo_pimpre)
            da.Fill(dt)

            Dim ds As New Data.DataSet
            ds.Tables.Add(dt)

            Dim info As New CUENTA_CLIENTE

            info.SetDataSource(ds)
            info.SetParameterValue("@COD_CLIENTE", codigo_pimpre)
            SetDBLogonForReport(iconexion, info)
            Me.CrystalReportViewer1.ReportSource = info
            info.PrintOptions.PrinterName = impresosaPredt
            info.PrintToPrinter(1, False, 0, 0)

        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try
    End Sub

    Sub Cargar_Dataset()
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
            SQLconexion.Close()
        End Try

        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM VF_CABECERA_CUENTACLIENTE"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaCabCuenta_Cliente = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DaCabCuenta_Cliente.Fill(Me.DsCabCuenta_Cliente, "VF_CABECERA_CUENTACLIENTE")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
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

        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM VF_HISTORIAL_PAGO_CUENTACLIENTE"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaHistorial_PagoCC = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DaHistorial_PagoCC.Fill(Me.DsHistorial_PagoCC, "VF_HISTORIAL_PAGO_CUENTACLIENTE")
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

    'SUMATORIA CUENTA DE CLIENTE POR CABECERA ******
    Function Sumatoria_PorCuentaCliente(ByVal a As Integer, ByVal b As Integer, ByVal c As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COALESCE(SUM(MONTO_CUOTA),0) FROM VF_DETALLE_CUENTACLIENTE WHERE COD_CLIENTE = " & a & " AND COD_CABECERA_CUENTACLI = " & b & " AND ESTADO_CUOTA = '" & c & "'"
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

    'SUMATORIA CUENTA DE CLIENTE POR CABECERA ******
    Function Sumatoria_PorMoraCliente(ByVal a As Integer, ByVal b As Integer, ByVal c As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COALESCE(SUM(INTERES_MORATORIO),0) FROM VF_DETALLE_CUENTACLIENTE WHERE COD_CLIENTE = " & a & " AND COD_CABECERA_CUENTACLI = " & b & " AND ESTADO_CUOTA = '" & c & "'"
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

    'ACTUALIZA LA CABECERA CUENTA DE CLIENTE ******
    Function Actualizar_Cuenta_Cliente(ByVal a As Integer, ByVal b As Integer, ByVal c As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "UPDATE VF_CABECERA_CUENTACLIENTE SET MONTO_CUENTA = " & a & " WHERE COD_CLIENTE = " & b & " AND COD_CABECERA_CUENTACLI = " & c & ""
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

    Private Sub VISUALIZAR_CUENTA_CLIENTE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Cargar_Dataset()

        iconexion.DatabaseName = bbdd
        iconexion.UserID = usuario_
        iconexion.Password = contrasena_
        iconexion.ServerName = servidor

        iconexion.Type = ConnectionInfoType.SQL

        Me.dg_Historial_PagoCC.Hide()
        Me.dg_CuentaCliente.Show()

    End Sub

    Private Sub dgDetallesCobranza_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgDetallesCobranza.Click
        If Me.dgDetallesCobranza.CurrentRowIndex < 0 Then

        Else
            Me.txtFecha_Seguimiento.Text = Me.dgDetallesCobranza.Item(Me.dgDetallesCobranza.CurrentRowIndex, 0)
            Me.txtCobrador.Text = Me.dgDetallesCobranza.Item(Me.dgDetallesCobranza.CurrentRowIndex, 1)
            Me.txtMontoCompromiso.Text = Me.dgDetallesCobranza.Item(Me.dgDetallesCobranza.CurrentRowIndex, 2)
            Me.txtObservacion.Text = Me.dgDetallesCobranza.Item(Me.dgDetallesCobranza.CurrentRowIndex, 3)
        End If
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click

        Me.txtCuentaActual.Text = 0
        Me.txtCobrador.Clear()
        Me.txtFecha_Seguimiento.Clear()
        Me.txtMontoCompromiso.Clear()
        Me.txtObservacion.Clear()
        Me.txtCliente.Clear()

        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM TP_CLIENTE WHERE CI ='" & "001100110" & "'"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaCliente = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            Dim dt As New DataTable("TP_CLIENTE")
            DaCliente.Fill(dt)
            SQLconexion.Close()

            With lstnombre
                .DataSource = dt
                .DisplayMember = "CLIENTE"
                .ValueMember = "NOM_APE"
            End With
        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

        Try
            conectar()
            Dim sel As String
            SQLconexion.Open()
            sel = "SELECT * FROM VF_DETALLE_CUENTACLIENTE WHERE COD_CLIENTE = " & -1 & " AND ESTADO_CUOTA <> '" & "ñoñoxixi" & "'"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaDetCuenta_Cliente = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsDetCuenta_Cliente = New Data.DataSet
            DaDetCuenta_Cliente.Fill(Me.DsDetCuenta_Cliente, "VF_DETALLE_CUENTACLIENTE")
            'asignar dataset al datagrid
            Me.dg_CuentaCliente.DataSource = Me.DsDetCuenta_Cliente
            Me.dg_CuentaCliente.DataMember = "VF_DETALLE_CUENTACLIENTE"

            Me.DaDetCuenta_Cliente.Update(Me.DsDetCuenta_Cliente, "VF_DETALLE_CUENTACLIENTE")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

        Try
            conectar()
            Dim sel As String
            SQLconexion.Open()
            sel = "SELECT * FROM CP_SEGUIM_COBRANZA WHERE COD_CLIENTE = " & -1 & ""
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaSegCobranza = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsSegCobranza = New Data.DataSet
            DaSegCobranza.Fill(Me.DsSegCobranza, "CP_SEGUIM_COBRANZA")
            'asignar dataset al datagrid
            Me.dgDetallesCobranza.DataSource = Me.DsSegCobranza
            Me.dgDetallesCobranza.DataMember = "CP_SEGUIM_COBRANZA"

            Me.DaSegCobranza.Update(Me.DsSegCobranza, "CP_SEGUIM_COBRANZA")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub

    Private Sub dg_CuentaCliente_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg_CuentaCliente.DoubleClick
        If Me.dg_CuentaCliente.CurrentRowIndex < 0 Then

        Else
            Valor_ParaReporteFactura = Me.dg_CuentaCliente.Item(Me.dg_CuentaCliente.CurrentRowIndex, 1)
            Dim FRM_VER_DOCUMENTOS_FACTURACION As New VER_DOCUMENTO_FACTURACION
            FRM_VER_DOCUMENTOS_FACTURACION.Show()
        End If
    End Sub


End Class