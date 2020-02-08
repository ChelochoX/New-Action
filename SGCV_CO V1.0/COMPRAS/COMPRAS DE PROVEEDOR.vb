Imports System.IO

Public Class COMPRAS_DE_PROVEEDOR

    Dim contador, b, c As Integer
    Dim DaProveedor, DaCabecera, DaDetalle, DaProducto, DaCabCompra, DaColor As New SqlClient.SqlDataAdapter
    Dim DsProveedor, DsCabecera, DsDetalle, DsCabCompra, DsColor As New Data.DataSet
    Dim FECHA_ As Date
    Dim proveedor, quitar_articulo As String
    Dim sumatoria_cantidad, sumatoria_monto, sumatoria_iva10, sumatoria_iva5 As Integer

    Dim precio_dolar, precio_gs, precio_aux As Integer
    Dim guarani, dolar As Integer
    Dim b_Gs, b_US, guardado, cotizacion As Integer
    Dim iva_prod, moneda As String
    Dim articulo, Color_Prod As String
    Dim Cantidad_quese_debeCargar_UM As Integer
    Dim contador_, provee, quitar_contador As Integer
    Dim verif_iva, bandera_foto As Integer
    Dim NombreArchivo, Nombre_Producto, CodigoProducto, producto As String
    Dim band_fecha As Integer

    Sub Cargar_Datos()
        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM TP_PROVEEDOR"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaProveedor = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsProveedor = New Data.DataSet
            DaProveedor.Fill(Me.DsProveedor, "TP_PROVEEDOR")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

    End Sub

    Sub Cargar_Datos1()
        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM SC_COMPRA_PROVEEDOR"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaCabCompra = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsCabCompra = New Data.DataSet
            DaCabCompra.Fill(Me.DsCabCompra, "SC_COMPRA_PROVEEDOR")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub

    Function Contador_Compra() As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM SC_COMPRA_PROVEEDOR"
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

    Sub Actualizar_IvaProd(ByVal a As String, ByVal b As String)
        Try
            Dim sel As String
            sel = "UPDATE TP_PRODUCTO SET IVA_PROD = '" & a & "'" & _
            "WHERE NOMBRE LIKE '" & b & "'"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As Integer = CInt(cmm.ExecuteScalar())
            cmm.Dispose()
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub

    Sub Limpiar_ListaProducto()
        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM TP_PRODUCTO WHERE NOMBRE LIKE '%" & "NDE SAPATURE" & "%'"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaProducto = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            Dim dt As New DataTable("TP_PRODUCTO")
            DaProducto.Fill(dt)
            SQLconexion.Close()

            With lstProducto
                .DataSource = dt
                .DisplayMember = "NOMBRE PRODUCTOS"
                .ValueMember = "NOMBRE"
            End With

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub
    Private Sub COMPRAS_DE_PROVEEDOR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LBUSUARIOONLINE.Text = usuario_AUX
        LBFECHAACTUAL.Text = Today.Date

        b = 0
        Cargar_Datos()

        If Contador_Compra() = 0 Then
            contador = 1
            Label12.Text = CStr(contador)
        Else
            contador = Contador_Compra() + 1
            Label12.Text = CStr(contador)
        End If

        Me.cbProveedor.DataSource = Me.DsProveedor.Tables("TP_PROVEEDOR")
        Me.cbProveedor.DisplayMember = "NOMBRE"
     
        guarani = 0
        dolar = 0
        b_Gs = 0
        b_US = 0
        guardado = 0
        provee = 0
        verif_iva = 0
        band_fecha = 0

    End Sub
    Function factura_compra(ByVal a As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM SC_COMPRA_PROVEEDOR WHERE FACTURA_COMPRA = '" & a & "'"
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

    Private Sub cbProveedor_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbProveedor.SelectedIndexChanged

        proveedor = Trim(Me.DsProveedor.Tables("TP_PROVEEDOR").Rows(Me.cbProveedor.SelectedIndex).Item(2).ToString)
        provee = 1
    End Sub

    Private Sub txtBusqueda_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBusqueda.Leave

        If b = 0 Then

            If provee = 0 Then
                MessageBox.Show("SELECCIONAR PROVEEDOR", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If band_fecha = 0 Then
                    MessageBox.Show("INGRESAR FECHA DE COMPRA", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DateTimePicker1.Focus()
                Else
                    If Me.txtFactura.Text = "" Then
                        MessageBox.Show("INGRESAR NUMERO DE FACTURA DE COMPRA", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.txtFactura.Focus()
                    Else
                        Try
                            b = 1
                            SQLconexion.Open()
                            Dim sqlbuilder As New System.Text.StringBuilder
                            With sqlbuilder
                                .Append("INSERT INTO SC_COMPRA_PROVEEDOR")
                                .Append(" VALUES ('")
                                .Append(CInt(contador) & "','")
                                .Append(FECHA_ & "','")
                                .Append(proveedor & "','")
                                .Append(Trim(Me.txtFactura.Text) & "','")
                                .Append(CInt(0) & "','")
                                .Append(CInt(0) & "','")
                                .Append(CInt(0) & "','")
                                .Append(CInt(0) & "','")
                                .Append(Trim("PENDIENTE") & "','")
                                .Append(Trim(moneda) & "')")
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

                        Cargar_Datos1()
                        Dim i As Integer
                        For i = 0 To Me.BindingContext(Me.DsCabCompra, "SC_COMPRA_PROVEEDOR").Count - 1
                            Me.BindingContext(Me.DsCabCompra, "SC_COMPRA_PROVEEDOR").Position = i

                            If contador = Trim(Me.DsCabCompra.Tables("SC_COMPRA_PROVEEDOR").Rows(Me.BindingContext(Me.DsCabCompra, "SC_COMPRA_PROVEEDOR").Position).Item("COD_COMPRA").ToString) Then

                                LBPROVEEDOR.Text = Trim(Me.DsCabCompra.Tables("SC_COMPRA_PROVEEDOR").Rows(Me.BindingContext(Me.DsCabCompra, "SC_COMPRA_PROVEEDOR").Position).Item("PROVEEDOR").ToString)
                                LBFACTURA.Text = Trim(Me.DsCabCompra.Tables("SC_COMPRA_PROVEEDOR").Rows(Me.BindingContext(Me.DsCabCompra, "SC_COMPRA_PROVEEDOR").Position).Item("FACTURA_COMPRA").ToString)
                                LBFECHA.Text = CDate(Me.DsCabCompra.Tables("SC_COMPRA_PROVEEDOR").Rows(Me.BindingContext(Me.DsCabCompra, "SC_COMPRA_PROVEEDOR").Position).Item("FECHA").ToString)
                                LBMONEDA.Text = Trim(Me.DsCabCompra.Tables("SC_COMPRA_PROVEEDOR").Rows(Me.BindingContext(Me.DsCabCompra, "SC_COMPRA_PROVEEDOR").Position).Item("MONEDA").ToString)
                                LBTOTAL_ARTICULO.Text = CStr(Puntos(Me.DsCabCompra.Tables("SC_COMPRA_PROVEEDOR").Rows(Me.BindingContext(Me.DsCabCompra, "SC_COMPRA_PROVEEDOR").Position).Item("TOTAL_ARTICULO")))
                                LBIVA5.Text = CStr(Puntos(Me.DsCabCompra.Tables("SC_COMPRA_PROVEEDOR").Rows(Me.BindingContext(Me.DsCabCompra, "SC_COMPRA_PROVEEDOR").Position).Item("TOTAL_IVA5")))
                                LBIVA10.Text = CStr(Puntos(Me.DsCabCompra.Tables("SC_COMPRA_PROVEEDOR").Rows(Me.BindingContext(Me.DsCabCompra, "SC_COMPRA_PROVEEDOR").Position).Item("TOTAL_IVA10")))
                                LBTOTAL_MONTO.Text = CStr(Puntos(Me.DsCabCompra.Tables("SC_COMPRA_PROVEEDOR").Rows(Me.BindingContext(Me.DsCabCompra, "SC_COMPRA_PROVEEDOR").Position).Item("TOTAL_GRAL")))

                            End If
                        Next

                    End If
                End If
            End If
            Me.txtFactura.Clear()
        End If

    End Sub

    Private Sub txtBusqueda_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBusqueda.TextChanged
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
                .DisplayMember = "NOMBRE PRODUCTOS"
                .ValueMember = "NOMBRE"
            End With

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub

    Private Sub lstProducto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstProducto.Click
        Me.txtCantidad.Focus()
    End Sub

    Private Sub lstProducto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstProducto.Leave
        Nombre_Producto = articulo
    End Sub

    Private Sub lstProducto_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstProducto.SelectedIndexChanged

        articulo = Me.lstProducto.Text
        CodigoProducto = Codigo_(Trim(articulo))

    End Sub

    Function Codigo_(ByVal a As String) As String
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
    Function Contador_Detalle(ByVal a As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COD_DETALLE_COMPRA FROM SC_DETALLE_COMPRA_PROV WHERE COD_COMPRA = " & a & " ORDER BY COD_DETALLE_COMPRA DESC"
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

    Function Articulo_Ingresado(ByVal a As String, ByVal b As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM SC_DETALLE_COMPRA_PROV WHERE PRODUCTO = '" & a & "' AND COD_COMPRA = " & b & ""
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

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click

        If verif_iva = 0 Then
            MessageBox.Show("DEBE ESTABLECER UN TIPO DE IMPUESTO", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtCantidad.Focus()
        Else
            If Me.txtCantidad.Text = "" Then
                MessageBox.Show("INGRESAR CANTIDAD ARTICULOS", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtCantidad.Focus()
            Else
                If Me.txtPrecio.Text = "" Then
                    MessageBox.Show("INGRESAR PRECIO ARTICULO", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtPrecio.Focus()
                Else
                    If Articulo_Ingresado(Trim(articulo), contador) = 1 Then
                        MessageBox.Show("ESTE ARTICULO YA FUE INGRESADO", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.txtBusqueda.Focus()
                    Else

                        contador_ = Contador_Detalle(contador) + 1
                        Dim Iva10, Iva5, Exenta, Monto As Integer

                        precio_gs = CInt(Me.txtPrecio.Text)

                        Monto = CInt(Me.txtCantidad.Text) * precio_gs
                        precio_dolar = 0
                        precio_aux = precio_gs

                        If Me.rbIva10.Checked = True Then
                            Dim calculo_iva10 As Integer
                            calculo_iva10 = (CInt(Me.txtCantidad.Text) * precio_gs) / 11
                            Iva10 = calculo_iva10
                            Iva5 = 0
                            Actualizar_IvaProd("10", Trim(articulo))
                        Else
                            If Me.rbIva5.Checked = True Then
                                Dim calculo_iva5 As Integer
                                calculo_iva5 = (CInt(Me.txtCantidad.Text) * precio_gs) / 21
                                Iva5 = calculo_iva5
                                Iva10 = 0
                                Actualizar_IvaProd("5", Trim(articulo))
                            Else
                                If Me.rbExenta.Checked = True Then
                                    Iva5 = 0
                                    Iva10 = 0
                                    Exenta = CInt(Me.txtCantidad.Text) * precio_gs
                                    Actualizar_IvaProd("0", Trim(articulo))
                                End If
                            End If
                        End If

                        Try
                            verif_iva = 0
                            Me.rbIva10.Checked = False
                            Me.rbIva5.Checked = False
                            Me.rbExenta.Checked = False

                            SQLconexion.Open()
                            Dim sqlbuilder As New System.Text.StringBuilder
                            With sqlbuilder
                                .Append("INSERT INTO SC_DETALLE_COMPRA_PROV")
                                .Append(" VALUES ('")
                                .Append(CInt(contador_) & "','")
                                .Append(CInt(contador) & "','")
                                .Append(Trim(articulo) & "','")
                                .Append(CInt(Me.txtCantidad.Text) & "','")
                                .Append(precio_aux & "','")
                                .Append(CInt(Iva5) & "','")
                                .Append(CInt(Iva10) & "','")
                                .Append(CInt(Exenta) & "','")
                                .Append(CInt(Monto) & "')")

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

                        Visualizar_Detalle(contador)

                        sumatoria_cantidad = sum_cantidad(contador)
                        sumatoria_monto = sum_monto(contador)
                        sumatoria_iva10 = sum_iva10(contador)
                        sumatoria_iva5 = sum_iva5(contador)

                        Try
                            Dim sel As String
                            sel = "UPDATE SC_COMPRA_PROVEEDOR SET TOTAL_GRAL = " & sumatoria_monto & ",TOTAL_IVA5 = " & sumatoria_iva5 & "" & _
                            ",TOTAL_IVA10 = " & sumatoria_iva10 & ",TOTAL_ARTICULO= " & sumatoria_cantidad & "" & _
                            "WHERE COD_COMPRA = " & contador & " "
                            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                            SQLconexion.Open()
                            Dim t As Integer = CInt(cmm.ExecuteScalar())
                            cmm.Dispose()
                            SQLconexion.Close()

                        Catch ex As Exception
                            MsgBox(ex.Message())
                            SQLconexion.Close()
                        End Try

                        Cargar_Datos1()
                        Dim i As Integer
                        For i = 0 To Me.BindingContext(Me.DsCabCompra, "SC_COMPRA_PROVEEDOR").Count - 1
                            Me.BindingContext(Me.DsCabCompra, "SC_COMPRA_PROVEEDOR").Position = i

                            If contador = Trim(Me.DsCabCompra.Tables("SC_COMPRA_PROVEEDOR").Rows(Me.BindingContext(Me.DsCabCompra, "SC_COMPRA_PROVEEDOR").Position).Item("COD_COMPRA").ToString) Then

                                LBPROVEEDOR.Text = Trim(Me.DsCabCompra.Tables("SC_COMPRA_PROVEEDOR").Rows(Me.BindingContext(Me.DsCabCompra, "SC_COMPRA_PROVEEDOR").Position).Item("PROVEEDOR").ToString)
                                LBFACTURA.Text = Trim(Me.DsCabCompra.Tables("SC_COMPRA_PROVEEDOR").Rows(Me.BindingContext(Me.DsCabCompra, "SC_COMPRA_PROVEEDOR").Position).Item("FACTURA_COMPRA").ToString)
                                LBFECHA.Text = CDate(Me.DsCabCompra.Tables("SC_COMPRA_PROVEEDOR").Rows(Me.BindingContext(Me.DsCabCompra, "SC_COMPRA_PROVEEDOR").Position).Item("FECHA").ToString)
                                LBMONEDA.Text = Trim(Me.DsCabCompra.Tables("SC_COMPRA_PROVEEDOR").Rows(Me.BindingContext(Me.DsCabCompra, "SC_COMPRA_PROVEEDOR").Position).Item("MONEDA").ToString)
                                LBTOTAL_ARTICULO.Text = CStr(Puntos(Me.DsCabCompra.Tables("SC_COMPRA_PROVEEDOR").Rows(Me.BindingContext(Me.DsCabCompra, "SC_COMPRA_PROVEEDOR").Position).Item("TOTAL_ARTICULO")))
                                LBIVA5.Text = CStr(Puntos(Me.DsCabCompra.Tables("SC_COMPRA_PROVEEDOR").Rows(Me.BindingContext(Me.DsCabCompra, "SC_COMPRA_PROVEEDOR").Position).Item("TOTAL_IVA5")))
                                LBIVA10.Text = CStr(Puntos(Me.DsCabCompra.Tables("SC_COMPRA_PROVEEDOR").Rows(Me.BindingContext(Me.DsCabCompra, "SC_COMPRA_PROVEEDOR").Position).Item("TOTAL_IVA10")))
                                LBTOTAL_MONTO.Text = CStr(Puntos(Me.DsCabCompra.Tables("SC_COMPRA_PROVEEDOR").Rows(Me.BindingContext(Me.DsCabCompra, "SC_COMPRA_PROVEEDOR").Position).Item("TOTAL_GRAL")))

                            End If
                        Next

                        Me.txtBusqueda.Clear()
                        Me.lstProducto.ClearSelected()
                        Me.txtCantidad.Clear()
                        Me.txtPrecio.Clear()
                        Me.txtBusqueda_por_Codigo.Clear()

                    End If
                End If
            End If
        End If

    End Sub

    Function sum_cantidad(ByVal a As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COALESCE(SUM(CANTIDAD),0) FROM SC_DETALLE_COMPRA_PROV WHERE COD_COMPRA = " & a & ""
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

    Function sum_monto(ByVal a As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COALESCE(SUM(MONTO),0) FROM SC_DETALLE_COMPRA_PROV WHERE COD_COMPRA = " & a & ""
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

    Function sum_iva10(ByVal a As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COALESCE(SUM(IVA10),0) FROM SC_DETALLE_COMPRA_PROV WHERE COD_COMPRA = " & a & ""
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

    Function sum_iva5(ByVal a As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COALESCE(SUM(IVA5),0) FROM SC_DETALLE_COMPRA_PROV WHERE COD_COMPRA = " & a & ""
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

    Sub Visualizar_Detalle(ByVal a As Integer)
        Try
            conectar()
            Dim sel As String
            SQLconexion.Open()
            sel = "SELECT * FROM SC_DETALLE_COMPRA_PROV WHERE COD_COMPRA = " & a & ""
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaDetalle = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsDetalle = New Data.DataSet
            DaDetalle.Fill(Me.DsDetalle, "SC_DETALLE_COMPRA_PROV")
            'asignar dataset al datagrid
            Me.dg_Detalle.DataSource = Me.DsDetalle
            Me.dg_Detalle.DataMember = "SC_DETALLE_COMPRA_PROV"

            Me.DaDetalle.Update(Me.DsDetalle, "SC_DETALLE_COMPRA_PROV")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub

    Function Cantidad_articulo_Det(ByVal a As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM SC_DETALLE_COMPRA_PROV WHERE COD_COMPRA = " & a & ""
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

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click

        Try
            conectar()
            Dim sel As String
            sel = "DELETE FROM SC_DETALLE_COMPRA_PROV WHERE COD_COMPRA = " & contador & " AND PRODUCTO LIKE '" & producto & "' "
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As Integer = CInt(cmm.ExecuteScalar())
            cmm.Dispose()
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

        '************************************************************

        Visualizar_Detalle(contador)

        sumatoria_cantidad = sum_cantidad(contador)
        sumatoria_monto = sum_monto(contador)
        sumatoria_iva10 = sum_iva10(contador)
        sumatoria_iva5 = sum_iva5(contador)

        Try
            conectar()
            Dim sel As String
            sel = "UPDATE SC_COMPRA_PROVEEDOR SET TOTAL_GRAL = " & sumatoria_monto & ",TOTAL_IVA5 = " & sumatoria_iva5 & "" & _
            ",TOTAL_IVA10 = " & sumatoria_iva10 & ",TOTAL_ARTICULO= " & sumatoria_cantidad & "" & _
            "WHERE COD_COMPRA = " & contador & " "
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As Integer = CInt(cmm.ExecuteScalar())
            cmm.Dispose()
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

        Cargar_Datos1()
        Dim i As Integer
        For i = 0 To Me.BindingContext(Me.DsCabCompra, "SC_COMPRA_PROVEEDOR").Count - 1
            Me.BindingContext(Me.DsCabCompra, "SC_COMPRA_PROVEEDOR").Position = i

            If contador = Trim(Me.DsCabCompra.Tables("SC_COMPRA_PROVEEDOR").Rows(Me.BindingContext(Me.DsCabCompra, "SC_COMPRA_PROVEEDOR").Position).Item("COD_COMPRA").ToString) Then

                LBPROVEEDOR.Text = Trim(Me.DsCabCompra.Tables("SC_COMPRA_PROVEEDOR").Rows(Me.BindingContext(Me.DsCabCompra, "SC_COMPRA_PROVEEDOR").Position).Item("PROVEEDOR").ToString)
                LBFACTURA.Text = Trim(Me.DsCabCompra.Tables("SC_COMPRA_PROVEEDOR").Rows(Me.BindingContext(Me.DsCabCompra, "SC_COMPRA_PROVEEDOR").Position).Item("FACTURA_COMPRA").ToString)
                LBFECHA.Text = CDate(Me.DsCabCompra.Tables("SC_COMPRA_PROVEEDOR").Rows(Me.BindingContext(Me.DsCabCompra, "SC_COMPRA_PROVEEDOR").Position).Item("FECHA").ToString)
                LBMONEDA.Text = Trim(Me.DsCabCompra.Tables("SC_COMPRA_PROVEEDOR").Rows(Me.BindingContext(Me.DsCabCompra, "SC_COMPRA_PROVEEDOR").Position).Item("MONEDA").ToString)
                LBTOTAL_ARTICULO.Text = CStr(Puntos(Me.DsCabCompra.Tables("SC_COMPRA_PROVEEDOR").Rows(Me.BindingContext(Me.DsCabCompra, "SC_COMPRA_PROVEEDOR").Position).Item("TOTAL_ARTICULO")))
                LBIVA5.Text = CStr(Puntos(Me.DsCabCompra.Tables("SC_COMPRA_PROVEEDOR").Rows(Me.BindingContext(Me.DsCabCompra, "SC_COMPRA_PROVEEDOR").Position).Item("TOTAL_IVA5")))
                LBIVA10.Text = CStr(Puntos(Me.DsCabCompra.Tables("SC_COMPRA_PROVEEDOR").Rows(Me.BindingContext(Me.DsCabCompra, "SC_COMPRA_PROVEEDOR").Position).Item("TOTAL_IVA10")))
                LBTOTAL_MONTO.Text = CStr(Puntos(Me.DsCabCompra.Tables("SC_COMPRA_PROVEEDOR").Rows(Me.BindingContext(Me.DsCabCompra, "SC_COMPRA_PROVEEDOR").Position).Item("TOTAL_GRAL")))

            End If
        Next

        Me.txtBusqueda_por_Codigo.Clear()
        Me.txtBusqueda.Clear()
    End Sub

    Private Sub txtCantidad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrecio_Gs_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPrecio.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click

        Me.txtBusqueda.ReadOnly = False
        Me.txtFactura.Clear()
        Me.txtBusqueda.Clear()
        Me.lstProducto.ClearSelected()
        Me.txtCantidad.Clear()
        Me.txtPrecio.Clear()
        Me.txtBusqueda_por_Codigo.Clear()
        Me.rbIva10.Checked = False
        Me.rbIva5.Checked = False
        Me.rbExenta.Checked = False
        Me.rbMoneda_Gs.Checked = False

        LBPROVEEDOR.Text = ""
        LBFACTURA.Text = ""
        LBFECHA.Text = ""
        LBMONEDA.Text = ""
        LBTOTAL_ARTICULO.Text = ""
        LBIVA5.Text = ""
        LBIVA10.Text = ""
        LBTOTAL_MONTO.Text = ""

        guarani = 0
        dolar = 0
        Me.txtFactura.Focus()
        guardado = 0
        b = 0
        verif_iva = 0

        b = 0
        guardado = 0
        contador = Contador_Compra() + 1
        Label12.Text = CStr(contador)

        Visualizar_Detalle(contador + 1)

        MessageBox.Show("COMPRA INGRESADA", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        verif_iva = 0

    End Sub

    Private Sub txtCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCancelar.Click
        Try
            conectar()
            Dim sel As String
            sel = "DELETE FROM SC_DETALLE_COMPRA_PROV WHERE COD_COMPRA = " & contador & ""
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
            sel = "DELETE FROM SC_COMPRA_PROVEEDOR WHERE COD_COMPRA = " & contador & ""
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As Integer = CInt(cmm.ExecuteScalar())
            cmm.Dispose()
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

        Visualizar_Detalle(contador)

        Me.txtBusqueda.ReadOnly = False
        Me.txtFactura.Clear()
        Me.txtBusqueda.Clear()
        Me.lstProducto.ClearSelected()
        Me.txtCantidad.Clear()
        Me.txtPrecio.Clear()
        Me.txtBusqueda_por_Codigo.Clear()
        Me.rbIva10.Checked = False
        Me.rbIva5.Checked = False
        Me.rbExenta.Checked = False
        Me.rbMoneda_Gs.Checked = False

        LBPROVEEDOR.Text = ""
        LBFACTURA.Text = ""
        LBFECHA.Text = ""
        LBMONEDA.Text = ""
        LBTOTAL_ARTICULO.Text = ""
        LBIVA5.Text = ""
        LBIVA10.Text = ""
        LBTOTAL_MONTO.Text = ""

        guarani = 0
        dolar = 0
        Me.txtFactura.Focus()
        guardado = 0
        b = 0
        verif_iva = 0


    End Sub

    Private Sub btnSalir_cargo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir_cargo.Click
        Me.Close()
    End Sub

    Private Sub rbMoneda_Gs_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbMoneda_Gs.CheckedChanged
        moneda = "GUARANI"
        cotizacion = 0
        'Me.txtBusqueda.Focus()
    End Sub

    Function paraCargar_(ByVal a As Integer, ByVal b As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COALESCE(SUM(CANTIDAD_CALCES),0) FROM SC_DETALLE_COMPRA_UNI_MEDIDAS WHERE COD_DETALLE_COMPRA = " & a & " AND COD_COMPRA = " & b & ""
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

   
    Function Cantidad_por_Item(ByVal a As Integer, ByVal b As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT CANTIDAD FROM SC_DETALLE_COMPRA_PROV WHERE COD_COMPRA = " & a & " AND COD_DETALLE_COMPRA_PROV = " & b & ""
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

    Private Sub rbIva10_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbIva10.Leave
        verif_iva = 1
    End Sub

    Private Sub rbIva5_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbIva5.Leave
        verif_iva = 1
    End Sub

    Private Sub rbExenta_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbExenta.Leave
        verif_iva = 1
    End Sub

    Private Sub txtPrecio_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPrecio.Leave
        Me.rbIva10.Focus()
    End Sub

    Function paraCodigo_(ByVal a As String) As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT CODIGO FROM TP_PRODUCTO WHERE NOMBRE LIKE '" & a & "'"
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

    Private Sub DateTimePicker1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateTimePicker1.Leave
        band_fecha = 1
        Dim fecha1 As Date
        fecha1 = Me.DateTimePicker1.Value.Date.AddDays(0)
        FECHA_ = fecha1
    End Sub

    Private Sub txtBusqueda_por_Codigo_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBusqueda_por_Codigo.Leave
        If b = 0 Then

            If provee = 0 Then
                MessageBox.Show("SELECCIONAR PROVEEDOR", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If band_fecha = 0 Then
                    MessageBox.Show("INGRESAR FECHA DE COMPRA", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.DateTimePicker1.Focus()
                Else
                    If Me.txtFactura.Text = "" Then
                        MessageBox.Show("INGRESAR NUMERO DE FACTURA DE COMPRA", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.txtFactura.Focus()
                    Else
                        Try
                            b = 1
                            SQLconexion.Open()
                            Dim sqlbuilder As New System.Text.StringBuilder
                            With sqlbuilder
                                .Append("INSERT INTO SC_COMPRA_PROVEEDOR")
                                .Append(" VALUES ('")
                                .Append(CInt(contador) & "','")
                                .Append(FECHA_ & "','")
                                .Append(proveedor & "','")
                                .Append(Trim(Me.txtFactura.Text) & "','")
                                .Append(CInt(0) & "','")
                                .Append(CInt(0) & "','")
                                .Append(CInt(0) & "','")
                                .Append(CInt(0) & "','")
                                .Append(Trim("PENDIENTE") & "','")
                                .Append(Trim(moneda) & "')")
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

                        Cargar_Datos1()
                        Dim i As Integer
                        For i = 0 To Me.BindingContext(Me.DsCabCompra, "SC_COMPRA_PROVEEDOR").Count - 1
                            Me.BindingContext(Me.DsCabCompra, "SC_COMPRA_PROVEEDOR").Position = i

                            If contador = Trim(Me.DsCabCompra.Tables("SC_COMPRA_PROVEEDOR").Rows(Me.BindingContext(Me.DsCabCompra, "SC_COMPRA_PROVEEDOR").Position).Item("COD_COMPRA").ToString) Then

                                LBPROVEEDOR.Text = Trim(Me.DsCabCompra.Tables("SC_COMPRA_PROVEEDOR").Rows(Me.BindingContext(Me.DsCabCompra, "SC_COMPRA_PROVEEDOR").Position).Item("PROVEEDOR").ToString)
                                LBFACTURA.Text = Trim(Me.DsCabCompra.Tables("SC_COMPRA_PROVEEDOR").Rows(Me.BindingContext(Me.DsCabCompra, "SC_COMPRA_PROVEEDOR").Position).Item("FACTURA_COMPRA").ToString)
                                LBFECHA.Text = CDate(Me.DsCabCompra.Tables("SC_COMPRA_PROVEEDOR").Rows(Me.BindingContext(Me.DsCabCompra, "SC_COMPRA_PROVEEDOR").Position).Item("FECHA").ToString)
                                LBMONEDA.Text = Trim(Me.DsCabCompra.Tables("SC_COMPRA_PROVEEDOR").Rows(Me.BindingContext(Me.DsCabCompra, "SC_COMPRA_PROVEEDOR").Position).Item("MONEDA").ToString)
                                LBTOTAL_ARTICULO.Text = CStr(Puntos(Me.DsCabCompra.Tables("SC_COMPRA_PROVEEDOR").Rows(Me.BindingContext(Me.DsCabCompra, "SC_COMPRA_PROVEEDOR").Position).Item("TOTAL_ARTICULO")))
                                LBIVA5.Text = CStr(Puntos(Me.DsCabCompra.Tables("SC_COMPRA_PROVEEDOR").Rows(Me.BindingContext(Me.DsCabCompra, "SC_COMPRA_PROVEEDOR").Position).Item("TOTAL_IVA5")))
                                LBIVA10.Text = CStr(Puntos(Me.DsCabCompra.Tables("SC_COMPRA_PROVEEDOR").Rows(Me.BindingContext(Me.DsCabCompra, "SC_COMPRA_PROVEEDOR").Position).Item("TOTAL_IVA10")))
                                LBTOTAL_MONTO.Text = CStr(Puntos(Me.DsCabCompra.Tables("SC_COMPRA_PROVEEDOR").Rows(Me.BindingContext(Me.DsCabCompra, "SC_COMPRA_PROVEEDOR").Position).Item("TOTAL_GRAL")))

                            End If
                        Next

                    End If
                End If
            End If
            Me.txtFactura.Clear()
        End If
    End Sub

    Private Sub txtBusqueda_por_Codigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusqueda_por_Codigo.TextChanged
        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM TP_PRODUCTO WHERE CODIGO LIKE '%" & Trim(Me.txtBusqueda_por_Codigo.Text) & "%'"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaProducto = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            Dim dt As New DataTable("TP_PRODUCTO")
            DaProducto.Fill(dt)
            SQLconexion.Close()

            With lstProducto
                .DataSource = dt
                .DisplayMember = "NOMBRE PRODUCTOS"
                .ValueMember = "NOMBRE"
            End With

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub

    Private Sub dg_Detalle_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg_Detalle.Click
        producto = Trim(Me.dg_Detalle.Item(Me.dg_Detalle.CurrentRowIndex, 0))

    End Sub
End Class