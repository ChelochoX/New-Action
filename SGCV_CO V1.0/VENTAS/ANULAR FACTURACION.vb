
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System
Imports System.IO
Imports System.Diagnostics

Public Class ANULAR_FACTURACION

    Dim busqueda As Integer
    Dim FECHA_INICIAL, FECHA_FINAL As Date
    Dim DaFactura, DaFactura1, DaStock, DaDetalle As New SqlClient.SqlDataAdapter
    Dim DsFactura, DsStock, DsDetalle As New Data.DataSet
    Dim valor As String
    Dim SUMARECIBO_TOTAL_DETMOVCAJA, SUMAFACTURA_TOTAL_DETMOVCAJA, paraCODCAJA, MONTO_APERTURA As Integer
    Dim deposito_, cod_factura As Integer
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


    Private Sub ANULAR_FACTURACION_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        busqueda = 0

        Dim Estado_Caja As Integer
        Estado_Caja = EstadoCaja("HABILITADO", Today)
        Contador_MovCaja_Apertura = Estado_Caja

        Cargar_Datos()

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
            sel = "SELECT * FROM VF_CABECERA_FACTURA WHERE FECHA BETWEEN '" & FECHA_INICIAL & "' AND '" & FECHA_FINAL & "'"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaFactura1 = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            Dim dt1 As New DataTable("VF_CABECERA_FACTURA")
            DaFactura1.Fill(dt1)
            SQLconexion.Close()
            With ltsDetallesBusqueda
                .DataSource = dt1
                .DisplayMember = "DOCUMENTO"
                .ValueMember = "NUMERO_FACTURA"
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

    Function paraCodigoFactura(ByVal A As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COD_FACTURA FROM VF_CABECERA_FACTURA WHERE NUMERO_FACTURA = '" & A & "'"
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


    Private Sub ltsDetallesBusqueda_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ltsDetallesBusqueda.Click

        valor = Trim(Me.ltsDetallesBusqueda.Text)
        deposito_ = paraDeposito(valor)
        IDENTIFICADOR2 = BUSQUEDA_IDENTIFICADOR(valor)
        cod_factura = paraCodigoFactura(valor)

        If IDENTIFICADOR2 = "T" Then
            Try
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter("REPORTE_FACTURACION_FACTURA", SQLconexion)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@NUMERO_FACTURA", valor)
                da.Fill(dt)

                Dim ds As New Data.DataSet
                ds.Tables.Add(dt)

                Dim info As New REPORTE_TICKET
                info.SetDataSource(ds)
                info.SetParameterValue("@NUMERO_FACTURA", valor)
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
                    da.SelectCommand.Parameters.AddWithValue("@NUMERO_FACTURA", valor)
                    da.Fill(dt)

                    Dim ds As New Data.DataSet
                    ds.Tables.Add(dt)

                    Dim info As New REPORTE_FACTURA
                    info.SetDataSource(ds)
                    info.SetParameterValue("@NUMERO_FACTURA", valor)
                    SetDBLogonForReport(iconexion, info)
                    Me.CrystalReportViewer1.ReportSource = info

                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                    SQLconexion.Close()
                End Try
            End If
        End If
        Me.txtObs_Anulacion.Focus()

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Function Contador_AnularFactura() As Integer
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
            SQLconexion.Close()
        End Try

    End Function

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
            SQLconexion.Close()
        End Try

    End Function
    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        If CONTROL_ANULACION(valor) = 1 Then
            MessageBox.Show("DOCUMENTO YA FUE ANULADO", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtObs_Anulacion.Clear()
        Else
            Try
                Dim contador As Integer
                contador = Contador_AnularFactura() + 1
                SQLconexion.Open()
                Dim sqlbuilder As New System.Text.StringBuilder
                With sqlbuilder
                    .Append("INSERT INTO ANULAR_DOCUMENTOS")
                    .Append(" VALUES ('")
                    .Append(contador & "','")
                    .Append(cod_factura & "','")
                    .Append(0 & "','")
                    .Append(valor & "','")
                    .Append("FACTURA" & "','")
                    .Append(Today & "','")
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
            Dim paraCodigo, paraCodigoCliente As Integer
            Dim paraTipoFactura As String
            paraCodigo = Codigo_CabCuentaCli(valor)
            paraCodigoCliente = Codigo_Cliente(valor)
            paraTipoFactura = Tipo_Factura(valor)

             Try
                conectar()
                Dim sel As String
                sel = "DELETE FROM VF_DETALLE_CUENTACLIENTE " & _
                "WHERE COD_CABECERA_CUENTACLI = " & paraCodigo & ""
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
                sel = "DELETE VF_CABECERA_CUENTACLIENTE " & _
                "WHERE COD_CABECERA_CUENTACLI = " & paraCodigo & ""
                cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                SQLconexion.Open()
                Dim t As Integer = CInt(cmm.ExecuteScalar())
                cmm.Dispose()
                SQLconexion.Close()

            Catch ex As Exception
                MsgBox(ex.Message())
                SQLconexion.Close()
            End Try

             If paraTipoFactura = "CONTADO" Then
                Try
                    conectar()
                    Dim sel As String
                    sel = "DELETE FROM CP_DETALLE_CAJA " & _
                    "WHERE FACTURA_NUMERO = '" & valor & "' AND " & _
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

                'ACTUALIZA HISTORIAL DE PAGO EN CUENTA CLIENTE
                Try
                    conectar()
                    Dim sel As String
                    sel = "DELETE FROM VF_HISTORIAL_PAGO_CUENTACLIENTE " & _
                    "WHERE DOCUMENTO_FACTURACION = '" & valor & "'"
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
            '****************************************************************************
            Dim i, j As Integer
            Dim codigo_D, codigo_S, deposito_S As String
            Dim cantidad_D, cantidad_S As Integer
            deposito = paraDepositoNom(deposito_)

            For i = 0 To Me.BindingContext(Me.DsDetalle, "VF_DETALLE_FACTURA").Count - 1
                Me.BindingContext(Me.DsDetalle, "VF_DETALLE_FACTURA").Position = i

                codigo_D = Trim(Me.DsDetalle.Tables("VF_DETALLE_FACTURA").Rows(Me.BindingContext(Me.DsDetalle, "VF_DETALLE_FACTURA").Position).Item("CODIGO").ToString)
                cantidad_D = CInt(Me.DsDetalle.Tables("VF_DETALLE_FACTURA").Rows(Me.BindingContext(Me.DsDetalle, "VF_DETALLE_FACTURA").Position).Item("CANTIDAD").ToString)

                For j = 0 To Me.BindingContext(Me.DsStock, "SC_STOCK").Count - 1
                    Me.BindingContext(Me.DsStock, "SC_STOCK").Position = j

                    codigo_S = Trim(Me.DsStock.Tables("SC_STOCK").Rows(Me.BindingContext(Me.DsStock, "SC_STOCK").Position).Item("CODIGO_PRODUCTO").ToString)
                    cantidad_S = CInt(Me.DsStock.Tables("SC_STOCK").Rows(Me.BindingContext(Me.DsStock, "SC_STOCK").Position).Item("CANTIDAD").ToString)
                    deposito_S = Trim(Me.DsStock.Tables("SC_STOCK").Rows(Me.BindingContext(Me.DsStock, "SC_STOCK").Position).Item("DEPOSITO").ToString)

                    If deposito = deposito_S Then
                        If codigo_D = codigo_S Then
                            Dim calculo As Integer
                            calculo = cantidad_S + cantidad_D

                            Try
                                Dim sel As String
                                sel = "UPDATE SC_STOCK SET CANTIDAD = " & calculo & "" & _
                                "WHERE DEPOSITO LIKE '" & deposito_S & "' AND CODIGO_PRODUCTO LIKE '" & codigo_S & "'"
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
            Next

            MessageBox.Show("DOCUMENTO ANULADO CORRECTAMENTE", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

        Me.CrystalReportViewer1.ReportSource = Nothing

    End Sub

    Function paraDepositoNom(ByVal A As Integer) As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT NOMBRE FROM TP_DEPOSITO WHERE COD_DEPOSITO = " & A & ""
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

    Function Tipo_Factura(ByVal a As String) As String
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
    Function Codigo_CabCuentaCli(ByVal a As String) As Integer
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
            SQLconexion.Close()
        End Try
    End Function
    Function Codigo_Cliente(ByVal a As String) As Integer
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

    Private Sub btnLimpiarBusqueda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiarBusqueda.Click
        Me.txtObs_Anulacion.Clear()
        Me.CrystalReportViewer1.ReportSource = Nothing

    End Sub
End Class