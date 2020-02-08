Public Class ESTADO_DE_VENTAS

    Dim DaEstadoCuenta, DaCabecera_CC, DaDetalle_CC, DaCab_Factura As New SqlClient.SqlDataAdapter
    Dim DsEstadoCuenta, DsCabecera_CC, DsDetalle_CC, DsCab_Factura As New Data.DataSet
    Dim para_codigo_cliente, para_codigo_factura As Integer
    Dim bandera_entrega As Integer

    Public Sub ver_estado_cuenta_clientes()
        Try
            conectar()
            Dim sel As String
            SQLconexion.Open()
            sel = "SELECT * FROM VF_CABECERA_CUENTACLIENTE WHERE MONTO_CUENTA <> 0 ORDER BY FECHA_INGRESO ASC"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaEstadoCuenta = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsEstadoCuenta = New Data.DataSet
            DaEstadoCuenta.Fill(Me.DsEstadoCuenta, "VF_CABECERA_CUENTACLIENTE")
            'asignar dataset al datagrid
            Me.dg_EstadoCuentaCliente.DataSource = Me.DsEstadoCuenta
            Me.dg_EstadoCuentaCliente.DataMember = "VF_CABECERA_CUENTACLIENTE"

            DaEstadoCuenta.Update(Me.DsEstadoCuenta, "VF_CABECERA_CUENTACLIENTE")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()

        End Try
    End Sub

    Sub Cargar_Datos()
        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM VF_DETALLE_CUENTACLIENTE"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaDetalle_CC = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsDetalle_CC = New Data.DataSet
            DaDetalle_CC.Fill(Me.DsDetalle_CC, "VF_DETALLE_CUENTACLIENTE")
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
            DaCabecera_CC = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsCabecera_CC = New Data.DataSet
            DaCabecera_CC.Fill(Me.DsCabecera_CC, "VF_CABECERA_CUENTACLIENTE")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM VF_CABECERA_FACTURA"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaCab_Factura = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsCab_Factura = New Data.DataSet
            DaCab_Factura.Fill(Me.DsCab_Factura, "VF_CABECERA_FACTURA")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

    End Sub

    Function Cantidad_deCuotas(ByVal a As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(CUOTA) FROM VF_DETALLE_CUENTACLIENTE WHERE COD_CABECERA_CUENTACLI = " & a & ""
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

    Function para_codigo_cliente_(ByVal a As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COD_CABECERA_CUENTACLI FROM VF_CABECERA_CUENTACLIENTE WHERE COD_FACTURA = " & a & ""
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

    Sub BORRAR_DATOS()
        Try
            conectar()
            Dim sel As String
            sel = "DELETE FROM INF_DETALLES_ESTADO_VENTAS"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As String = CStr(cmm.ExecuteScalar())
            cmm.Dispose()
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
        End Try

    End Sub

    Private Sub ESTADO_DE_VENTAS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        BORRAR_DATOS()
        Cargar_Datos()

        bandera_entrega = 0

        'GENERA CALCULOS PARA VENTAS DE ARCA***
        Dim i, j As Integer
        Dim aux_codigo_factura, aux_codigo_cuenta_cli As Integer
        Dim venta_arca, venta_tuvendedor As Integer
        Dim sumatoria_arca_total, sumatoria_arca_cobrado, sumatoria_tuvendedor_total, sumatoria_tuvendedor_cobrado As Integer

        sumatoria_arca_cobrado = 0
        sumatoria_tuvendedor_cobrado = 0

        For j = 0 To Me.BindingContext(Me.DsCab_Factura, "VF_CABECERA_FACTURA").Count - 1
            Me.BindingContext(Me.DsCab_Factura, "VF_CABECERA_FACTURA").Position = j

            aux_codigo_factura = CInt(Me.DsCab_Factura.Tables("VF_CABECERA_FACTURA").Rows(Me.BindingContext(Me.DsCab_Factura, "VF_CABECERA_FACTURA").Position).Item("COD_FACTURA").ToString)
            venta_arca = CInt(Me.DsCab_Factura.Tables("VF_CABECERA_FACTURA").Rows(Me.BindingContext(Me.DsCab_Factura, "VF_CABECERA_FACTURA").Position).Item("VENTA_ARCA").ToString)
            venta_tuvendedor = CInt(Me.DsCab_Factura.Tables("VF_CABECERA_FACTURA").Rows(Me.BindingContext(Me.DsCab_Factura, "VF_CABECERA_FACTURA").Position).Item("VENTA_TUVENDEDOR").ToString)

            aux_codigo_cuenta_cli = para_codigo_cliente_(aux_codigo_factura)

            If venta_arca = 1 Then
                Dim para_sumatoria_total, para_sumatoria_pagada As Integer
                para_sumatoria_total = 0
                para_sumatoria_pagada = 0
                para_sumatoria_total = para_sumatoria_total_(aux_codigo_factura)
                para_sumatoria_pagada = para_sumatoria_pagada_(aux_codigo_cuenta_cli, aux_codigo_factura)
                sumatoria_arca_cobrado = sumatoria_arca_cobrado + (para_sumatoria_total - para_sumatoria_pagada)

            Else
                If venta_tuvendedor = 1 Then
                    Dim para_sumatoria_total, para_sumatoria_pagada As Integer
                    para_sumatoria_total = 0
                    para_sumatoria_pagada = 0
                    para_sumatoria_total = para_sumatoria_total_(aux_codigo_factura)
                    para_sumatoria_pagada = para_sumatoria_pagada_(aux_codigo_cuenta_cli, aux_codigo_factura)
                    sumatoria_tuvendedor_cobrado = sumatoria_tuvendedor_cobrado + (para_sumatoria_total - para_sumatoria_pagada)

                End If
            End If
        Next

        '***********************************************************
        sumatoria_arca_total = suma_total_arca_total()
        sumatoria_tuvendedor_total = suma_total_tuvendedor_total()
        '***********************************************************
        Me.txtARCAFacturado.Text = CStr(Puntos(sumatoria_arca_total))
        Me.txtARCACobrado.Text = CStr(Puntos(sumatoria_arca_cobrado))

        Me.txtTotal_hastaLaFecha.Text = CStr(Puntos(sumatoria_arca_total + sumatoria_tuvendedor_total))

        Me.txtTUVENDEDORFacturado.Text = CStr(Puntos(sumatoria_tuvendedor_total))
        Me.txtTUVENDEDORCobrado.Text = CStr(Puntos(sumatoria_tuvendedor_cobrado))

        ver_estado_cuenta_clientes()
        generar_comisiones()

    End Sub

    Function corresponde_nene_() As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COALESCE(SUM(COMI_NENE),0) FROM INF_DETALLES_ESTADO_VENTAS"
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

    Function corresponde_chelo_() As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COALESCE(SUM(COMI_CHELO),0) FROM INF_DETALLES_ESTADO_VENTAS"
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

    Function suma_total_arca_total() As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT SUM(F.TOTAL_MONTO) FROM VF_CABECERA_FACTURA F " & _
            "WHERE F.VENTA_ARCA = 1 AND F.COD_FACTURA NOT IN (SELECT A.COD_FACTURA FROM ANULAR_FACTURACION A)"
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

    Function suma_total_arca_cobrado(ByVal a As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COALESCE(SUM(MONTO_CUOTA),0) FROM VF_DETALLE_CUENTACLIENTE WHERE COD_CABECERA_CUENTACLI = " & a & " AND ESTADO_CUOTA = '" & "PAGADO" & "'"
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

    Function suma_total_tuvendedor_total() As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT SUM(F.TOTAL_MONTO) FROM VF_CABECERA_FACTURA F " & _
            "WHERE F.VENTA_TUVENDEDOR = 1 AND F.COD_FACTURA NOT IN (SELECT A.COD_FACTURA FROM ANULAR_FACTURACION A)"
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

    Function para_sumatoria_total_(ByVal a As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COALESCE(SUM(TOTAL_MONTO),0) FROM VF_CABECERA_FACTURA WHERE COD_FACTURA = " & a & ""
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

    Function para_sumatoria_pagada_(ByVal a As Integer, ByVal b As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COALESCE(SUM(MONTO_CUENTA),0) FROM VF_CABECERA_CUENTACLIENTE WHERE COD_CABECERA_CUENTACLI = " & a & " AND COD_FACTURA = " & b & ""
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



    Private Sub dg_EstadoCuentaCliente_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg_EstadoCuentaCliente.Click

        'para_codigo_cliente = Trim(Me.dg_EstadoCuentaCliente.Item(Me.dg_EstadoCuentaCliente.CurrentRowIndex, 3))
        'para_codigo_factura = Trim(Me.dg_EstadoCuentaCliente.Item(Me.dg_EstadoCuentaCliente.CurrentRowIndex, 4))

    End Sub

    Sub generar_comisiones()

        Dim entrega_inicial, venta_arca, venta_tuvendedor, cantidad_articulo As Integer
        Dim mi_comision, monto_venta_arca, monto_venta_tuvendedor, cantidad_cuotas, num_cuota, monto_decuota As Integer
        Dim estado_cuota As String
        Dim contador_estado As Integer
        contador_estado = 0
        Dim i, j, l As Integer
        Dim codigo_factura, codigo_cuenta_cli As Integer

        For j = 0 To Me.BindingContext(Me.DsCab_Factura, "VF_CABECERA_FACTURA").Count - 1
            Me.BindingContext(Me.DsCab_Factura, "VF_CABECERA_FACTURA").Position = j

            codigo_factura = CInt(Me.DsCab_Factura.Tables("VF_CABECERA_FACTURA").Rows(Me.BindingContext(Me.DsCab_Factura, "VF_CABECERA_FACTURA").Position).Item("COD_FACTURA").ToString)
            codigo_cuenta_cli = para_codigo_cliente_(codigo_factura)

            entrega_inicial = CInt(Me.DsCab_Factura.Tables("VF_CABECERA_FACTURA").Rows(Me.BindingContext(Me.DsCab_Factura, "VF_CABECERA_FACTURA").Position).Item("ENTREGA_INICIAL"))
            monto_venta_arca = CInt(Me.DsCab_Factura.Tables("VF_CABECERA_FACTURA").Rows(Me.BindingContext(Me.DsCab_Factura, "VF_CABECERA_FACTURA").Position).Item("MONTO_VENTA_ARCA"))
            monto_venta_tuvendedor = CInt(Me.DsCab_Factura.Tables("VF_CABECERA_FACTURA").Rows(Me.BindingContext(Me.DsCab_Factura, "VF_CABECERA_FACTURA").Position).Item("MONTO_VENTA_TUVENDEDOR"))
            venta_arca = CInt(Me.DsCab_Factura.Tables("VF_CABECERA_FACTURA").Rows(Me.BindingContext(Me.DsCab_Factura, "VF_CABECERA_FACTURA").Position).Item("VENTA_ARCA"))
            venta_tuvendedor = CInt(Me.DsCab_Factura.Tables("VF_CABECERA_FACTURA").Rows(Me.BindingContext(Me.DsCab_Factura, "VF_CABECERA_FACTURA").Position).Item("VENTA_TUVENDEDOR"))

            mi_comision = venta_tuvendedor - venta_arca
            cantidad_cuotas = Cantidad_deCuotas(codigo_cuenta_cli)


            If venta_arca = 1 Then

                For i = 0 To Me.BindingContext(Me.DsDetalle_CC, "VF_DETALLE_CUENTACLIENTE").Count - 1
                    Me.BindingContext(Me.DsDetalle_CC, "VF_DETALLE_CUENTACLIENTE").Position = i

                    If para_codigo_cliente = Trim(Me.DsDetalle_CC.Tables("VF_DETALLE_CUENTACLIENTE").Rows(Me.BindingContext(Me.DsDetalle_CC, "VF_DETALLE_CUENTACLIENTE").Position).Item("COD_CABECERA_CUENTACLI")) Then
                        num_cuota = CInt(Me.DsDetalle_CC.Tables("VF_DETALLE_CUENTACLIENTE").Rows(Me.BindingContext(Me.DsDetalle_CC, "VF_DETALLE_CUENTACLIENTE").Position).Item("CUOTA"))
                        estado_cuota = Trim(Me.DsDetalle_CC.Tables("VF_DETALLE_CUENTACLIENTE").Rows(Me.BindingContext(Me.DsDetalle_CC, "VF_DETALLE_CUENTACLIENTE").Position).Item("ESTADO_CUOTA"))
                        monto_decuota = CInt(Me.DsDetalle_CC.Tables("VF_DETALLE_CUENTACLIENTE").Rows(Me.BindingContext(Me.DsDetalle_CC, "VF_DETALLE_CUENTACLIENTE").Position).Item("MONTO_CUOTA"))

                        If estado_cuota = "PAGADO" Then
                            If entrega_inicial > 0 And entrega_inicial > 100000 Then
                                If num_cuota = 1 Then
                                    bandera_entrega = 1
                                    Dim aux_comi As Integer
                                    aux_comi = monto_decuota - 50000
                                    contador_estado = contador_estado + 1

                                    Insertar_Detalles_EstadoVenta(contador_estado, para_codigo_cliente, num_cuota, monto_decuota, 50000, aux_comi)
                                Else
                                    Dim divisor_comi As Integer
                                    If bandera_entrega = 1 Then
                                        divisor_comi = (mi_comision - 50000) / cantidad_cuotas
                                    Else
                                        divisor_comi = mi_comision / cantidad_cuotas
                                    End If
                                    divisor_comi = mi_comision / cantidad_cuotas
                                    Dim aux_comi As Integer
                                    aux_comi = monto_decuota - divisor_comi
                                    contador_estado = contador_estado + 1

                                    Insertar_Detalles_EstadoVenta(contador_estado, para_codigo_cliente, num_cuota, monto_decuota, divisor_comi, aux_comi)

                                End If
                            Else
                                Dim divisor_comi As Integer
                                divisor_comi = mi_comision / cantidad_cuotas
                                Dim aux_comi As Integer
                                aux_comi = monto_decuota - divisor_comi
                                contador_estado = contador_estado + 1

                                Insertar_Detalles_EstadoVenta(contador_estado, para_codigo_cliente, num_cuota, monto_decuota, divisor_comi, aux_comi)
                            End If

                        End If
                    End If
                Next

            Else
                If venta_tuvendedor = 1 Then

                    contador_estado = contador_estado + 1

                    Insertar_Detalles_EstadoVenta(contador_estado, para_codigo_cliente, num_cuota, monto_decuota, monto_decuota, 0)

                End If
            End If
        Next
    End Sub

    Sub Insertar_Detalles_EstadoVenta(ByVal a As Integer, ByVal b As Integer, ByVal c As Integer, ByVal d As Integer, ByVal e As Integer, ByVal f As Integer)
        Try
            Dim sel As String
            sel = "INSERT INTO INF_DETALLES_ESTADO_VENTAS" & _
                "(COD_ESTADO_VENTA,COD_CUENTA_CLI,CUOTA,MONTO,COMI_CHELO,COMI_NENE) " & _
                "VALUES " & _
                "(@COD_ESTADO_VENTA,@COD_CUENTA_CLI,@CUOTA,@MONTO,@COMI_CHELO,@COMI_NENE) "

            cmm = New SqlClient.SqlCommand(sel, SQLconexion)

            cmm.Parameters.AddWithValue("@COD_ESTADO_VENTA", a)
            cmm.Parameters.AddWithValue("@COD_CUENTA_CLI", b)
            cmm.Parameters.AddWithValue("@CUOTA", c)
            cmm.Parameters.AddWithValue("@MONTO", d)
            cmm.Parameters.AddWithValue("@COMI_CHELO", e)
            cmm.Parameters.AddWithValue("@COMI_NENE", f)

            SQLconexion.Open()
            Dim t As Integer = CInt(cmm.ExecuteScalar())
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class