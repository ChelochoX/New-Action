Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System
Imports System.IO
Imports System.Diagnostics

Public Class GESTIONAR_TRASLADO_DE_PRODUCTOS

    Dim fecha As Date
    Dim DaDetalle_Sal, DaDeposito, DaProducto, DaStock, DaRotacion As New SqlClient.SqlDataAdapter
    Dim DsDetalle_Sal, DsDeposito, DsProducto, DsStock, DsRotacion As New Data.DataSet
    Dim contador_rotacion_prod As Integer

    Dim band_cabecera, contador_cab_salida_ As Integer
    Dim articulo, codigo_prod As String
    Dim deposito As String
    Dim paraImpresion, contador_stock, codigo_deposito, paraCod_Producto As Integer


    Sub Cargar_Datos()
        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM TP_DEPOSITO"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaDeposito = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsDeposito = New Data.DataSet
            DaDeposito.Fill(Me.DsDeposito, "TP_DEPOSITO")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM TP_PRODUCTO"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaProducto = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsProducto = New Data.DataSet
            DaProducto.Fill(Me.DsProducto, "TP_PRODUCTO")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub

    Function Contador_Rotacion() As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM SC_CAB_ROTACION_MERCADERIAS"
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
            sel = "SELECT COUNT(*) FROM SC_DET_ROTACION_MERCADERIAS"
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

    Sub SetDBLogonForReport(ByVal myConnectionInfo As ConnectionInfo, ByVal myReportDocument As ReportDocument)
        Dim myTables As Tables = myReportDocument.Database.Tables
        For Each myTable As CrystalDecisions.CrystalReports.Engine.Table In myTables
            Dim myTableLogonInfo As TableLogOnInfo = myTable.LogOnInfo
            myTableLogonInfo.ConnectionInfo = myConnectionInfo
            myTable.ApplyLogOnInfo(myTableLogonInfo)
        Next
    End Sub

    Private Sub GESTIONAR_TRASLADO_DE_PRODUCTOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        fecha = CDate(Today)
        Me.txtFecha.Text = UCase(Date.Today.ToLongDateString.ToString)

        Cargar_Datos()

        iconexion.DatabaseName = bbdd
        iconexion.UserID = usuario_
        iconexion.Password = contrasena_
        iconexion.ServerName = servidor

        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM TP_DEPOSITO"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaDeposito = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            Dim dt As New DataTable("TP_DEPOSITO")
            DaDeposito.Fill(dt)
            SQLconexion.Close()

            With lstDeposito
                .DataSource = dt
                .DisplayMember = "DEPOSITO"
                .ValueMember = "NOMBRE"
            End With
        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

        iconexion.DatabaseName = bbdd
        iconexion.UserID = usuario_
        iconexion.Password = contrasena_
        iconexion.ServerName = servidor

        iconexion.Type = ConnectionInfoType.SQL

    End Sub

    Private Sub rbIngresar_Producto_otroDeposito_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbIngresar_Producto_otroDeposito.Click
        Me.lstDeposito.Focus()
    End Sub

    Private Sub rbIngresar_Producto_Usado_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.lstDeposito.Focus()
    End Sub

    Private Sub rbSacar_Producto_otroDeposito_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbSacar_Producto_otroDeposito.Click
        Me.lstDeposito.Focus()
    End Sub

    Private Sub lstDeposito_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstDeposito.Click
        Me.txtResponsable1.Focus()
        Me.txtDeposito.Text = Trim(Me.lstDeposito.Text)
        codigo_deposito = Codigo_Dep(Trim(Me.txtDeposito.Text))
    End Sub

    Function Codigo_Dep(ByVal a As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COD_DEPOSITO FROM TP_DEPOSITO WHERE NOMBRE LIKE '" & a & "'"
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

    Private Sub txtBusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusqueda.TextChanged
        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM TP_PRODUCTO WHERE NOMBRE LIKE '%" & Trim(Me.txtBusqueda.Text) & "%'"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaProducto = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            Dim dt As New DataTable("TP_PRODUCTO")
            DaProducto.Fill(dt)
            SQLconexion.Close()

            With lstProducto
                .DataSource = dt
                .DisplayMember = "PRODUCTO"
                .ValueMember = "NOMBRE"
            End With
        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub

    Private Sub txtResponsable1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtResponsable1.Leave
        Me.txtResponsable_1.Text = Me.txtResponsable1.Text
    End Sub

    Private Sub txtResponsable2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtResponsable2.Leave
        Me.txtResponsable_2.Text = Me.txtResponsable2.Text
    End Sub

    Private Sub lstProducto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstProducto.Click
        Me.txtCantidad.Focus()
        articulo = Me.lstProducto.Text
        paraCod_Producto = ParaCod_Producto_(Trim(articulo))
    End Sub

    Function ParaCod_Producto_(ByVal a As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COD_PRODUCTO FROM TP_PRODUCTO WHERE NOMBRE LIKE '" & a & "'"
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

    Private Sub btnIngresarMercaderia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresarMercaderia.Click
        If Me.txtDeposito.Text = "" Then
            MessageBox.Show("DEBE SELECCIONAR UN DEPOSITO", "SGCV_CO V1.0", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If Me.txtResponsable_1.Text = "" Then
                MessageBox.Show("DEBE SELECCIONAR RESPONSABLE DE ENTREGA", "SGCV_CO V1.0", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If Me.txtResponsable_2.Text = "" Then
                    MessageBox.Show("DEBE SELECCIONAR RESPONSABLE DE RECIBE", "SGCV_CO V1.0", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    If Me.txtCantidad.Text = "" Then
                        MessageBox.Show("DEBE INGRESAR CANTIDAD DE PRODUCTO", "SGCV_CO V1.0", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.txtCantidad.Focus()
                    Else
                        If band_cabecera = 0 Then
                            band_cabecera = 1
                            contador_cab_salida_ = Contador_Rotacion() + 1
                            Try
                                SQLconexion.Open()
                                Dim sqlbuilder As New System.Text.StringBuilder
                                With sqlbuilder
                                    .Append("INSERT INTO SC_CAB_ROTACION_MERCADERIAS")
                                    .Append(" VALUES ('")
                                    .Append(contador_cab_salida_ & "','")
                                    .Append(Trim(Me.txtDeposito.Text) & "','")
                                    .Append(CDate(fecha) & "','")
                                    .Append(Trim(Me.txtResponsable_1.Text) & "','")
                                    .Append(Trim(Me.txtResponsable_2.Text) & "','")
                                    .Append(Trim(Me.txtObservacion.Text) & "','")
                                    .Append(CInt(0) & "')")

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

                        If existe_producto(articulo, contador_cab_salida_) <> 0 Then
                            MessageBox.Show("PRODUCTO YA FUE INGRESADO", "SGCV_CO V1.0", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.lstProducto.Focus()
                        Else
                            Dim Contador_Detalle As Integer
                            Contador_Detalle = Contador_Detalle_() + 1
                            codigo_prod = codigo_prod_(articulo)
                            Try
                                SQLconexion.Open()
                                Dim sqlbuilder As New System.Text.StringBuilder
                                With sqlbuilder
                                    .Append("INSERT INTO SC_DET_ROTACION_MERCADERIAS")
                                    .Append(" VALUES ('")
                                    .Append(Contador_Detalle & "','")
                                    .Append(contador_cab_salida_ & "','")
                                    .Append(codigo_prod & "','")
                                    .Append(articulo & "','")
                                    .Append(CInt(Me.txtCantidad.Text) & "')")

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

                            Visualizar_Detalle(contador_cab_salida_)
                            Me.txtTotal_Producto.Text = CStr(Puntos(sum_cantidad(contador_cab_salida_)))
                            Me.txtCantidad.Clear()
                            Me.txtBusqueda.Focus()
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Sub Visualizar_Detalle(ByVal a As Integer)
        Try
            conectar()
            Dim sel As String
            SQLconexion.Open()
            sel = "SELECT * FROM SC_DET_ROTACION_MERCADERIAS WHERE COD_CAB_ROTACION = " & a & ""
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaDetalle_Sal = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsDetalle_Sal = New Data.DataSet
            DaDetalle_Sal.Fill(Me.DsDetalle_Sal, "SC_DET_ROTACION_MERCADERIAS")
            'asignar dataset al datagrid
            Me.dg_detalle.DataSource = Me.DsDetalle_Sal
            Me.dg_detalle.DataMember = "SC_DET_ROTACION_MERCADERIAS"

            Me.DaDetalle_Sal.Update(Me.DsDetalle_Sal, "SC_DET_ROTACION_MERCADERIAS")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub

    Function sum_cantidad(ByVal a As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COALESCE(SUM(CANTIDAD),0) FROM SC_DET_ROTACION_MERCADERIAS WHERE COD_CAB_ROTACION = " & a & ""
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

    Function codigo_prod_(ByVal a As String) As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT CODIGO FROM TP_PRODUCTO WHERE NOMBRE LIKE '" & a & "'"
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

    Function existe_producto(ByVal a As String, ByVal b As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM SC_DET_ROTACION_MERCADERIAS WHERE NOMBRE_PRODUCTO = '" & a & "' AND COD_CAB_ROTACION = " & b & ""
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

    Function actuaizar_cantidadtotalprod(ByVal a As Integer, ByVal b As Integer)
        Try
            conectar()
            Dim sel As String
            sel = "UPDATE SC_CAB_ROTACION_MERCADERIAS SET TOTAL_PRODUCTOS = " & a & " WHERE COD_CAB_ROTACION = " & b & ""
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As Integer = CInt(cmm.ExecuteScalar())
            cmm.Dispose()
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Function

    Private Sub btnGuardar_Operacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar_Operacion.Click

        Dim DaRotacion As New SqlClient.SqlDataAdapter
        'Dim DsRotacion As New Data.DataSet
        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM SC_DET_ROTACION_MERCADERIAS"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaRotacion = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsRotacion = New Data.DataSet
            DaRotacion.Fill(Me.DsRotacion, "SC_DET_ROTACION_MERCADERIAS")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

        deposito = Trim(Me.txtDeposito.Text)

        If Me.rbIngresar_Producto_otroDeposito.Checked = True Then

            If Me.txtResponsable_1.Text = "" Then
                MessageBox.Show("DEFINIR RESPONSABLE DE ENTREGA", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtResponsable_1.Focus()
            Else
                If Me.txtResponsable_2.Text = "" Then
                    MessageBox.Show("DEFINIR RESPONSABLE DE RECEPCION", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtResponsable_2.Focus()
                Else
                    If Me.txtTotal_Producto.Text = 0 Then
                        MessageBox.Show("DEFINIR CANTIDAD DE PRODUCTO", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.txtCantidad.Focus()
                    Else
                        Dim i As Integer
                        Dim codigo_D, codigo_S, deposito_S, nombre_D As String
                        Dim cantidad_D, cantidad_S As Integer

                        For i = 0 To Me.BindingContext(Me.DsRotacion, "SC_DET_ROTACION_MERCADERIAS").Count - 1
                            Me.BindingContext(Me.DsRotacion, "SC_DET_ROTACION_MERCADERIAS").Position = i

                            If contador_cab_salida_ = CInt(Me.DsRotacion.Tables("SC_DET_ROTACION_MERCADERIAS").Rows(Me.BindingContext(Me.DsRotacion, "SC_DET_ROTACION_MERCADERIAS").Position).Item("COD_CAB_ROTACION")) Then
                                codigo_D = Trim(Me.DsRotacion.Tables("SC_DET_ROTACION_MERCADERIAS").Rows(Me.BindingContext(Me.DsRotacion, "SC_DET_ROTACION_MERCADERIAS").Position).Item("CODIGO_PRODUCTO").ToString)
                                cantidad_D = CInt(Me.DsRotacion.Tables("SC_DET_ROTACION_MERCADERIAS").Rows(Me.BindingContext(Me.DsRotacion, "SC_DET_ROTACION_MERCADERIAS").Position).Item("CANTIDAD").ToString)
                                nombre_D = Trim(Me.DsRotacion.Tables("SC_DET_ROTACION_MERCADERIAS").Rows(Me.BindingContext(Me.DsRotacion, "SC_DET_ROTACION_MERCADERIAS").Position).Item("NOMBRE_PRODUCTO").ToString)

                                If Existe_enStock(codigo_D, deposito) = 0 Then
                                    contador_stock = Contador_enStock() + 1
                                    Try
                                        SQLconexion.Open()
                                        Dim sqlbuilder As New System.Text.StringBuilder
                                        With sqlbuilder
                                            .Append("INSERT INTO SC_STOCK")
                                            .Append(" VALUES ('")
                                            .Append(contador_stock & "','")
                                            .Append(CInt(paraCod_Producto) & "','")
                                            .Append(CInt(codigo_deposito) & "','")
                                            .Append(Trim(deposito) & "','")
                                            .Append(Trim(codigo_D) & "','")
                                            .Append(Trim(nombre_D) & "','")
                                            .Append(CInt(cantidad_D) & "')")

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
                                    cantidad_S = Cantidad_ExisteStock(codigo_D, deposito)
                                    Dim calculo As Integer
                                    calculo = cantidad_S + cantidad_D

                                    Try
                                        Dim sel As String
                                        sel = "UPDATE SC_STOCK SET CANTIDAD = " & calculo & "" & _
                                        "WHERE DEPOSITO LIKE '" & deposito & "' AND CODIGO_PRODUCTO LIKE '" & codigo_D & "'"
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
                    End If
                End If
            End If

        Else
            If Me.rbSacar_Producto_otroDeposito.Checked = True Then

                If Me.txtResponsable_1.Text = "" Then
                    MessageBox.Show("DEFINIR RESPONSABLE DE ENTREGA", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtResponsable_1.Focus()
                Else
                    If Me.txtResponsable_2.Text = "" Then
                        MessageBox.Show("DEFINIR RESPONSABLE DE RECEPCION", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.txtResponsable_2.Focus()
                    Else
                        If Me.txtTotal_Producto.Text = 0 Then
                            MessageBox.Show("DEFINIR CANTIDAD DE PRODUCTO", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.txtCantidad.Focus()
                        Else
                            Dim i As Integer
                            Dim codigo_D, codigo_S, deposito_S, nombre_D As String
                            Dim cantidad_D, cantidad_S As Integer

                            For i = 0 To Me.BindingContext(Me.DsRotacion, "SC_DET_ROTACION_MERCADERIAS").Count - 1
                                Me.BindingContext(Me.DsRotacion, "SC_DET_ROTACION_MERCADERIAS").Position = i

                                If contador_cab_salida_ = CInt(Me.DsRotacion.Tables("SC_DET_ROTACION_MERCADERIAS").Rows(Me.BindingContext(Me.DsRotacion, "SC_DET_ROTACION_MERCADERIAS").Position).Item("COD_CAB_ROTACION")) Then
                                    codigo_D = Trim(Me.DsRotacion.Tables("SC_DET_ROTACION_MERCADERIAS").Rows(Me.BindingContext(Me.DsRotacion, "SC_DET_ROTACION_MERCADERIAS").Position).Item("CODIGO_PRODUCTO").ToString)
                                    cantidad_D = CInt(Me.DsRotacion.Tables("SC_DET_ROTACION_MERCADERIAS").Rows(Me.BindingContext(Me.DsRotacion, "SC_DET_ROTACION_MERCADERIAS").Position).Item("CANTIDAD").ToString)
                                    nombre_D = Trim(Me.DsRotacion.Tables("SC_DET_ROTACION_MERCADERIAS").Rows(Me.BindingContext(Me.DsRotacion, "SC_DET_ROTACION_MERCADERIAS").Position).Item("NOMBRE_PRODUCTO").ToString)

                                    cantidad_S = Cantidad_ExisteStock(codigo_D, deposito)
                                    Dim calculo As Integer
                                    calculo = cantidad_S - cantidad_D

                                    Try
                                        Dim sel As String
                                        sel = "UPDATE SC_STOCK SET CANTIDAD = " & calculo & "" & _
                                        "WHERE DEPOSITO LIKE '" & deposito & "' AND CODIGO_PRODUCTO LIKE '" & codigo_D & "'"
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
                            Next
                        End If
                    End If
                End If
            End If
        End If
        '*****************************************************
        Try
            conectar()
            Dim sel As String
            sel = "UPDATE SC_CAB_ROTACION_MERCADERIAS SET OBSERVACION = '" & Trim(Me.txtObservacion.Text) & "'" & _
            "WHERE COD_CAB_ROTACION = " & contador_cab_salida_ & ""
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As Integer = CInt(cmm.ExecuteScalar())
            cmm.Dispose()
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

        actuaizar_cantidadtotalprod(CInt(Me.txtTotal_Producto.Text), contador_cab_salida_)
        Visualizar_Detalle(contador_cab_salida_ + 1)

        Me.txtResponsable1.Clear()
        Me.txtResponsable2.Clear()
        Me.txtCantidad.Clear()
        Me.txtResponsable_1.Clear()
        Me.txtResponsable_2.Clear()
        Me.txtObservacion.Clear()
        Me.txtDeposito.Clear()
        Me.txtTotal_Producto.Clear()
        Me.txtBusqueda.Clear()
        Me.rbIngresar_Producto_otroDeposito.Checked = False
        Me.rbSacar_Producto_otroDeposito.Checked = False
        band_cabecera = 0

        paraImpresion = contador_cab_salida_

        MessageBox.Show("TRASLADO DE PRODUCTO PROCESADO", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        contador_cab_salida_ = Contador_Rotacion() + 1

    End Sub

    Private Sub btnCancelar_Operacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar_Operacion.Click

        ELIMINAR_CABECERA(contador_cab_salida_)
        ELIMINAR_DETALLE(contador_cab_salida_)

        Me.txtResponsable1.Clear()
        Me.txtResponsable2.Clear()
        Me.txtCantidad.Clear()
        Me.txtResponsable_1.Clear()
        Me.txtResponsable_2.Clear()
        Me.txtObservacion.Clear()
        Me.txtDeposito.Clear()
        Me.txtTotal_Producto.Clear()
        Me.txtBusqueda.Clear()
        Me.rbIngresar_Producto_otroDeposito.Checked = False
        Me.rbSacar_Producto_otroDeposito.Checked = False
        band_cabecera = 0

        Visualizar_Detalle(contador_cab_salida_)
        Me.txtTotal_Producto.Text = CStr(Puntos(sum_cantidad(contador_cab_salida_)))

    End Sub

    Function Contador_enStock() As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM SC_STOCK "
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

    Function Cantidad_ExisteStock(ByVal a As String, ByVal b As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT CANTIDAD FROM SC_STOCK WHERE CODIGO_PRODUCTO = '" & a & "' AND DEPOSITO = '" & b & "'"
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

    Function Existe_enStock(ByVal a As String, ByVal b As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM SC_STOCK WHERE CODIGO_PRODUCTO = '" & a & "' AND DEPOSITO = '" & b & "'"
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

    Function ELIMINAR_CABECERA(ByVal a As Integer)
        Try
            conectar()
            Dim sel As String
            sel = "DELETE FROM SC_CAB_ROTACION_MERCADERIAS WHERE COD_CAB_ROTACION = " & a & ""
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As String = CStr(cmm.ExecuteScalar())
            cmm.Dispose()
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Function

    Function ELIMINAR_DETALLE(ByVal a As String)
        Try
            conectar()
            Dim sel As String
            sel = "DELETE FROM SC_DET_ROTACION_MERCADERIAS WHERE COD_CAB_ROTACION = " & a & ""
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As String = CStr(cmm.ExecuteScalar())
            cmm.Dispose()
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Function

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Function Cantidad_enStock(ByVal a As String, ByVal b As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT CANTIDAD FROM SC_STOCK WHERE DEPOSITO LIKE '" & a & "' AND NOMBRE_PRODUCTO LIKE '" & b & "'"
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

    Private Sub txtCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCantidad_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidad.Leave
        Dim cantidad_enS As Integer
        deposito = Trim(Me.lstDeposito.Text)
        cantidad_enS = Cantidad_enStock(deposito, articulo)

        If Me.rbSacar_Producto_otroDeposito.Checked = True Then
            If Me.txtCantidad.Text = "" Then
            Else
                If CInt(Me.txtCantidad.Text) > cantidad_enS Then
                    MessageBox.Show("CANTIDAD INSUFICIENTE EN STOCK", "SGCV V2.0", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtCantidad.Focus()
                End If
            End If
        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        Dim instance As New Printing.PrinterSettings
        Dim impresosaPredt As String = instance.PrinterName

        Try
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter("TRASLADO_MERCADERIAS", SQLconexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@ROTACION", paraImpresion)
            da.Fill(dt)

            Dim ds As New Data.DataSet
            ds.Tables.Add(dt)

            Dim info As New TRASLADO_DE_MERCADERIAS
            info.SetDataSource(ds)
            info.SetParameterValue("@ROTACION", paraImpresion)
            SetDBLogonForReport(iconexion, info)
            info.PrintOptions.PrinterName = impresosaPredt
            info.PrintToPrinter(1, False, 0, 0)

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            SQLconexion.Close()
        End Try
    End Sub

    Private Sub lstProducto_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lstProducto.KeyPress
        Me.txtCantidad.Focus()
        articulo = Me.lstProducto.Text
        paraCod_Producto = ParaCod_Producto_(Trim(articulo))
    End Sub
End Class