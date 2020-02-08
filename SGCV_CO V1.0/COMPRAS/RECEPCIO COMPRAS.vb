Public Class RECEPCIO_COMPRAS

    Dim DaDeposito, DaCabecera, DaDetalle, DaDetalleUM As New SqlClient.SqlDataAdapter
    Dim DsDeposito, DsCabecera, DsDetalle, DsDetalleUM As New Data.DataSet
    Dim FECHA_INICIAL, FECHA_FINAL As Date
    Dim b, c, codigo, p_cod_deposito As Integer
    Dim BR, US, UK, EU, TALLA, COLOR_ As String
    Dim codigo_detalle, codigo_cabecera As Integer
    Dim cabecera, detalle As Integer
    Dim BANDERA_CARGA As Integer

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
            sel = "SELECT * FROM SC_DETALLE_COMPRA_PROV"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaDetalle = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsDetalle = New Data.DataSet
            DaDetalle.Fill(Me.DsDetalle, "SC_DETALLE_COMPRA_PROV")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub

    Sub Ver_CAbecera_Detalle()
        Try
            conectar()
            Dim sel As String
            SQLconexion.Open()
            sel = "SELECT * FROM SC_COMPRA_PROVEEDOR WHERE FECHA BETWEEN '" & FECHA_INICIAL & "' AND '" & FECHA_FINAL & "'"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaCabecera = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsCabecera = New Data.DataSet
            DaCabecera.Fill(Me.DsCabecera, "SC_COMPRA_PROVEEDOR")
            'asignar dataset al datagrid
            Me.dgCabecera.DataSource = Me.DsCabecera
            Me.dgCabecera.DataMember = "SC_COMPRA_PROVEEDOR"

            Me.DaCabecera.Update(Me.DsCabecera, "SC_COMPRA_PROVEEDOR")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

        Try
            conectar()
            Dim sel As String
            SQLconexion.Open()
            sel = "SELECT * FROM SC_DETALLE_COMPRA_PROV WHERE COD_COMPRA = " & 0 & ""
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

    Function contador_stock_() As Integer
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
        End Try

    End Function

    Function SucursalNombre(ByVal a As Integer) As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT SUCURSAL FROM CONFIG_EMPRESA WHERE COD_EMPRESA = " & a & ""
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

    Private Sub RECEPCIO_COMPRAS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Cargar_Datos()

        Me.txtDeposito.Clear()

        BANDERA_CARGA = 0

        Me.txtDeposito.Text = Trim(SucursalNombre(1))
        p_cod_deposito = Cod_Deposito(Trim(Me.txtDeposito.Text))

    End Sub

    Private Sub btnVer_Compras_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVer_Compras.Click

        If Me.rbVer_PendientesyProcesados.Checked = True Then

            Try
                conectar()
                Dim sel As String
                SQLconexion.Open()
                sel = "SELECT * FROM SC_COMPRA_PROVEEDOR WHERE FECHA BETWEEN '" & FECHA_INICIAL & "' AND '" & FECHA_FINAL & "'"
                cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                'crear adapter
                DaCabecera = New SqlClient.SqlDataAdapter(cmm)
                'crear dataset
                DsCabecera = New Data.DataSet
                DaCabecera.Fill(Me.DsCabecera, "SC_COMPRA_PROVEEDOR")
                'asignar dataset al datagrid
                Me.dgCabecera.DataSource = Me.DsCabecera
                Me.dgCabecera.DataMember = "SC_COMPRA_PROVEEDOR"

                Me.DaCabecera.Update(Me.DsCabecera, "SC_COMPRA_PROVEEDOR")
                SQLconexion.Close()

            Catch ex As Exception
                MsgBox(ex.Message())
                SQLconexion.Close()
            End Try
        Else
            If Me.rbVer_soloPendientes.Checked = True Then

                Try
                    conectar()
                    Dim sel As String
                    SQLconexion.Open()
                    sel = "SELECT * FROM SC_COMPRA_PROVEEDOR WHERE FECHA BETWEEN '" & FECHA_INICIAL & "' AND '" & FECHA_FINAL & "'" & _
                        "AND ESTADO LIKE '" & "PENDIENTE" & "'"
                    cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                    'crear adapter
                    DaCabecera = New SqlClient.SqlDataAdapter(cmm)
                    'crear dataset
                    DsCabecera = New Data.DataSet
                    DaCabecera.Fill(Me.DsCabecera, "SC_COMPRA_PROVEEDOR")
                    'asignar dataset al datagrid
                    Me.dgCabecera.DataSource = Me.DsCabecera
                    Me.dgCabecera.DataMember = "SC_COMPRA_PROVEEDOR"

                    Me.DaCabecera.Update(Me.DsCabecera, "SC_COMPRA_PROVEEDOR")
                    SQLconexion.Close()

                Catch ex As Exception
                    MsgBox(ex.Message())
                    SQLconexion.Close()
                End Try

            End If
        End If
    End Sub

    Private Sub DateTimePicker1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateTimePicker1.Leave
        b = 1
        Dim fecha1 As Date
        fecha1 = Me.DateTimePicker1.Value.Date.AddDays(0)
        FECHA_INICIAL = fecha1
    End Sub

    Private Sub DateTimePicker2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateTimePicker2.Leave
        c = 1
        Dim fecha1 As Date
        fecha1 = Me.DateTimePicker2.Value.Date.AddDays(0)
        FECHA_FINAL = fecha1
    End Sub

    Private Sub dgCabecera_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgCabecera.Click

        codigo = CInt(Me.dgCabecera.Item(Me.dgCabecera.CurrentRowIndex, 4))

        Try
            conectar()
            Dim sel As String
            SQLconexion.Open()
            sel = "SELECT * FROM SC_DETALLE_COMPRA_PROV WHERE COD_COMPRA = " & codigo & ""
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

        Try
            conectar()
            Dim sel As String
            SQLconexion.Open()
            sel = "SELECT * FROM SC_DETALLE_COMPRA_PROV WHERE COD_COMPRA = " & codigo & ""
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
    Function Deposito_Existe(ByVal a As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM SC_STOCK WHERE DEPOSITO LIKE '" & a & "'"
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

    Function Situacion_Estado(ByVal a As Integer) As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT ESTADO FROM SC_COMPRA_PROVEEDOR WHERE COD_COMPRA = " & a & ""
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

    Sub Cargar_Datos_()
        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM SC_DETALLE_COMPRA_UNI_MEDIDAS"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaDetalleUM = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsDetalleUM = New Data.DataSet
            DaDetalleUM.Fill(Me.DsDetalleUM, "SC_DETALLE_COMPRA_UNI_MEDIDAS")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub
    Private Sub btnIngresar_aDeposito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar_aDeposito.Click

        Dim i, precio, cantidad, para_cod_producto As Integer
        Dim producto, para_codigo_producto As String
        Dim situ As String = Trim(Situacion_Estado(codigo))
        If situ = "PROCESADO" Then

            MessageBox.Show("Esta Compra ya fue procesada, NO puede ingresar", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If Me.txtDeposito.Text = "" Then
                MessageBox.Show("No hay Deposito Destino de Referencia", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtDeposito.Focus()
            Else
                If Deposito_Existe(Trim(Me.txtDeposito.Text)) = 0 Then

                    For i = 0 To Me.BindingContext(Me.DsDetalle, "SC_DETALLE_COMPRA_PROV").Count - 1
                        Me.BindingContext(Me.DsDetalle, "SC_DETALLE_COMPRA_PROV").Position = i

                        If codigo = Trim(Me.DsDetalle.Tables("SC_DETALLE_COMPRA_PROV").Rows(Me.BindingContext(Me.DsDetalle, "SC_DETALLE_COMPRA_PROV").Position).Item("COD_COMPRA").ToString) Then

                            producto = Trim(Me.DsDetalle.Tables("SC_DETALLE_COMPRA_PROV").Rows(Me.BindingContext(Me.DsDetalle, "SC_DETALLE_COMPRA_PROV").Position).Item("PRODUCTO").ToString)
                            cantidad = Trim(Me.DsDetalle.Tables("SC_DETALLE_COMPRA_PROV").Rows(Me.BindingContext(Me.DsDetalle, "SC_DETALLE_COMPRA_PROV").Position).Item("CANTIDAD").ToString)
                            precio = Me.DsDetalle.Tables("SC_DETALLE_COMPRA_PROV").Rows(Me.BindingContext(Me.DsDetalle, "SC_DETALLE_COMPRA_PROV").Position).Item("PRECIO").ToString

                            para_cod_producto = Cod_Producto(producto)
                            para_codigo_producto = Codigo_Producto(producto)

                            Dim contador_stock As Integer
                            contador_stock = contador_stock_() + 1
                            Try
                                SQLconexion.Open()
                                Dim sqlbuilder As New System.Text.StringBuilder
                                With sqlbuilder
                                    .Append("INSERT INTO SC_STOCK")
                                    .Append(" VALUES ('")
                                    .Append(CInt(contador_stock) & "','")
                                    .Append(CInt(para_cod_producto) & "','")
                                    .Append(CInt(p_cod_deposito) & "','")
                                    .Append(CStr(Me.txtDeposito.Text) & "','")
                                    .Append(CStr(para_codigo_producto) & "','")
                                    .Append(CStr(producto) & "','")
                                    .Append(CInt(cantidad) & "')")

                                End With

                                cmm = New SqlClient.SqlCommand(sqlbuilder.ToString, SQLconexion)
                                cmm.ExecuteNonQuery()
                                SQLconexion.Close()
                                cmm.Dispose()
                                SQLconexion.Dispose()

                            Catch ex As SqlClient.SqlException
                                MsgBox(ex.Message())
                            End Try
                            '**************************************************************
                            If Me.rbPrecio_Modificado.Checked = True Then
                                Try
                                    conectar()
                                    Dim sel As String
                                    sel = "UPDATE TP_PRODUCTO SET PRECIO_COMPRA = " & precio & "" & _
                                    "WHERE CODIGO LIKE '" & para_codigo_producto & "'"
                                    cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                                    SQLconexion.Open()
                                    Dim t As Integer = CInt(cmm.ExecuteScalar())
                                    cmm.Dispose()
                                    SQLconexion.Close()

                                Catch ex As Exception
                                    MsgBox(ex.Message())
                                End Try
                            End If
                        End If
                    Next
                    '**************************************************************
                    Try
                        conectar()
                        Dim sel As String
                        sel = "UPDATE SC_COMPRA_PROVEEDOR SET ESTADO = '" & "PROCESADO" & "'" & _
                        "WHERE COD_COMPRA =" & codigo & ""
                        cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                        SQLconexion.Open()
                        Dim t As Integer = CInt(cmm.ExecuteScalar())
                        cmm.Dispose()
                        SQLconexion.Close()

                    Catch ex As Exception
                        MsgBox(ex.Message())
                    End Try


                    Me.txtDeposito.Clear()
                    Ver_CAbecera_Detalle()

                Else
                    If Deposito_Existe(Trim(Me.txtDeposito.Text)) <> 0 Then

                        For i = 0 To Me.BindingContext(Me.DsDetalle, "SC_DETALLE_COMPRA_PROV").Count - 1
                            Me.BindingContext(Me.DsDetalle, "SC_DETALLE_COMPRA_PROV").Position = i

                            If codigo = Trim(Me.DsDetalle.Tables("SC_DETALLE_COMPRA_PROV").Rows(Me.BindingContext(Me.DsDetalle, "SC_DETALLE_COMPRA_PROV").Position).Item("COD_COMPRA").ToString) Then

                                producto = Trim(Me.DsDetalle.Tables("SC_DETALLE_COMPRA_PROV").Rows(Me.BindingContext(Me.DsDetalle, "SC_DETALLE_COMPRA_PROV").Position).Item("PRODUCTO").ToString)
                                cantidad = Trim(Me.DsDetalle.Tables("SC_DETALLE_COMPRA_PROV").Rows(Me.BindingContext(Me.DsDetalle, "SC_DETALLE_COMPRA_PROV").Position).Item("CANTIDAD").ToString)
                                precio = Me.DsDetalle.Tables("SC_DETALLE_COMPRA_PROV").Rows(Me.BindingContext(Me.DsDetalle, "SC_DETALLE_COMPRA_PROV").Position).Item("PRECIO").ToString

                                para_cod_producto = Cod_Producto(producto)
                                para_codigo_producto = Codigo_Producto(producto)
                                '****************************************************************************************
                                Dim para_ExisteProducto As Integer
                                para_ExisteProducto = producto_Existe(producto, p_cod_deposito)

                                If para_ExisteProducto = 0 Then

                                    Dim contador_stock As Integer
                                    contador_stock = contador_stock_() + 1
                                    Try
                                        SQLconexion.Open()
                                        Dim sqlbuilder As New System.Text.StringBuilder
                                        With sqlbuilder
                                            .Append("INSERT INTO SC_STOCK")
                                            .Append(" VALUES ('")
                                            .Append(CInt(contador_stock) & "','")
                                            .Append(CInt(para_cod_producto) & "','")
                                            .Append(CInt(p_cod_deposito) & "','")
                                            .Append(CStr(Me.txtDeposito.Text) & "','")
                                            .Append(CStr(para_codigo_producto) & "','")
                                            .Append(CStr(producto) & "','")
                                            .Append(CInt(cantidad) & "')")

                                        End With

                                        cmm = New SqlClient.SqlCommand(sqlbuilder.ToString, SQLconexion)
                                        cmm.ExecuteNonQuery()
                                        SQLconexion.Close()
                                        cmm.Dispose()
                                        SQLconexion.Dispose()

                                    Catch ex As SqlClient.SqlException
                                        MsgBox(ex.Message())
                                    End Try
                                    '**************************************************************
                                    If Me.rbPrecio_Modificado.Checked = True Then
                                        Try
                                            conectar()
                                            Dim sel As String
                                            sel = "UPDATE TP_PRODUCTO SET PRECIO_COMPRA = " & precio & "" & _
                                            "WHERE CODIGO LIKE '" & para_codigo_producto & "'"
                                            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                                            SQLconexion.Open()
                                            Dim t As Integer = CInt(cmm.ExecuteScalar())
                                            cmm.Dispose()
                                            SQLconexion.Close()

                                        Catch ex As Exception
                                            MsgBox(ex.Message())
                                        End Try

                                    End If
                                Else
                                    Dim suma_productos, productos_enDeposito As Integer
                                    productos_enDeposito = Productos_en_Deposito(producto, Trim(Me.txtDeposito.Text))
                                    suma_productos = productos_enDeposito + cantidad
                                    Try
                                        conectar()
                                        Dim sel As String
                                        sel = "UPDATE SC_STOCK SET CANTIDAD = " & suma_productos & "" & _
                                        "WHERE CODIGO_PRODUCTO LIKE '" & para_codigo_producto & "'"
                                        cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                                        SQLconexion.Open()
                                        Dim t As Integer = CInt(cmm.ExecuteScalar())
                                        cmm.Dispose()
                                        SQLconexion.Close()

                                    Catch ex As Exception
                                        MsgBox(ex.Message())
                                    End Try
                                    '**************************************************************
                                    If Me.rbPrecio_Modificado.Checked = True Then
                                        Try
                                            conectar()
                                            Dim sel As String
                                            sel = "UPDATE TP_PRODUCTO SET PRECIO_COMPRA = " & precio & "" & _
                                            "WHERE CODIGO LIKE '" & para_codigo_producto & "'"
                                            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                                            SQLconexion.Open()
                                            Dim t As Integer = CInt(cmm.ExecuteScalar())
                                            cmm.Dispose()
                                            SQLconexion.Close()

                                        Catch ex As Exception
                                            MsgBox(ex.Message())
                                        End Try

                                    End If
                                End If
                            End If
                        Next
                        '*****************************************************************************
                        Try
                            conectar()
                            Dim sel As String
                            sel = "UPDATE SC_COMPRA_PROVEEDOR SET ESTADO = '" & "PROCESADO" & "'" & _
                            "WHERE COD_COMPRA =" & codigo & ""
                            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                            SQLconexion.Open()
                            Dim t As Integer = CInt(cmm.ExecuteScalar())
                            cmm.Dispose()
                            SQLconexion.Close()

                        Catch ex As Exception
                            MsgBox(ex.Message())
                        End Try

                    End If

                    Me.txtDeposito.Clear()
                    Ver_CAbecera_Detalle()

                End If
            End If
        End If

    End Sub

    Private Sub lstDeposito_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)


    End Sub

    Function Codigo_Producto(ByVal a As String) As String
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

    Function Categoria(ByVal a As String) As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT CATEGORIA FROM TP_PRODUCTO WHERE CODIGO LIKE '" & a & "'"
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

    Function Cod_Deposito(ByVal a As String) As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COD_DEPOSITO FROM TP_DEPOSITO WHERE NOMBRE LIKE '" & a & "'"
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

    Function Cod_Producto(ByVal a As String) As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COD_PRODUCTO FROM TP_PRODUCTO WHERE NOMBRE LIKE '" & a & "'"
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

    Function producto_Existe(ByVal a As String, ByVal b As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM SC_STOCK WHERE NOMBRE_PRODUCTO LIKE '" & a & "' AND COD_DEPOSITO = " & b & ""
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

    Function Productos_en_Deposito(ByVal a As String, ByVal b As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT CANTIDAD FROM SC_STOCK WHERE NOMBRE_PRODUCTO LIKE '" & a & "' AND DEPOSITO LIKE '" & b & "'"
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

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
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

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub
End Class