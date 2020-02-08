Public Class FACTURACION

    Dim Contador_Factura, Contador_Ticket, b, bandera_fact, cod_Cliente As Integer
    Dim fecha As Date
    Dim DaCliente, DaProducto, DaDetalle, DaStock, DaDeposito As New SqlClient.SqlDataAdapter
    Dim DsCliente, DsProducto, DsDetalle, DsStock, DsDeposito As New Data.DataSet
    Dim articulo, tipo_factura, tipo_factura_, codigo_prod, Operador As String
    Dim Contador_cabecera, precio_contado, calculo_precio, calculo_iva10, calculo_iva5, precio_compra, precio_credito As Integer
    Dim iva_prod, deposito As String
    Dim sumatoria_cantidad, sumatoria_monto, sumatoria_iva10, sumatoria_iva5, sumatoria_exenta As Integer
    Dim contador_normal, contador_normal1 As Integer
    Dim contador_CuentaCliente, Codigo_CuentaCliente As Integer
    Dim reg_tipofactura As String
    Dim CODIGO_DEPOSITO, para_CantCuotas As Integer
    Dim bandera_fecha, Contador_Batusada As Integer
    Dim precio_unitario, precio_5, precio_10, precio_ex, para_Precio As Integer
    Dim sumatoria_ex, sumatoria_5, sumatoria_10 As Integer
    Dim codigo_producto As String
    Dim paraBorrar As String
    Dim Contador_Detalle As Integer
    Dim cantidad_cuotas, botonApretado, botonNoApretado As Integer
    Dim PLAZO As String
    Dim boton1, boton2, boton3, boton4, boton5, boton6, boton7, boton8, boton9, boton10, boton11 As Integer
    Dim boton12, boton13, boton14, boton15, boton16, boton17, boton18 As Integer
    Dim verificador_fecha, verificador_selecc_cuotas As Integer
    Dim fecha_vencimiento As Date
    Dim calculo_paraPrecio, interes, precio_base, valor_cuenta As Integer
    Dim para_InteresFinanciero, saldo_deIF, monto_deIF, iva_deIF, sumatoria_pb As Integer

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

    End Sub

    Function Existe_Cliente_porCI(ByVal a As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM TP_CLIENTE WHERE CI LIKE '" & a & "'"
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

    Function Existe_Cliente_porRUC(ByVal a As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM TP_CLIENTE WHERE RUC LIKE '" & a & "'"
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

    Function Contador_Factura_(ByVal a As String, ByVal b As String, ByVal c As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT SECUENCIA_FINAL_FACTURA FROM TP_DOCUMENTOS WHERE TIPO_DOCUMENTO LIKE '" & a & "' AND ESTADO LIKE '" & b & "' AND RUC_PROPIETARIO = '" & c & "' "
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

    Function Contador_Ticket_(ByVal a As String, ByVal b As String, ByVal c As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT SECUENCIA_FINAL_TICKET FROM TP_DOCUMENTOS WHERE TIPO_DOCUMENTO LIKE '" & a & "' AND ESTADO LIKE '" & b & "' AND RUC_PROPIETARIO = '" & c & "' "
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


    Function rango1_(ByVal a As String, ByVal b As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT RANGO1 FROM TP_DOCUMENTOS WHERE TIPO_DOCUMENTO LIKE '" & a & "' AND ESTADO LIKE '" & b & "'"
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

    Function rango2_(ByVal a As String, ByVal b As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT RANGO2 FROM TP_DOCUMENTOS WHERE TIPO_DOCUMENTO LIKE '" & a & "' AND ESTADO LIKE '" & b & "'"
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

    Function Contador_NormalFactura() As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COALESCE(MAX(COD_FACTURA),0) FROM VF_CABECERA_FACTURA"
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

    Function precio_proveedor(ByVal a As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT PRECIO_CREDITO_PROVE FROM TP_PRODUCTO WHERE CODIGO = '" & a & "'"
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

    Function operador_(ByVal A As String) As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT CATEGORIA_USUARIO FROM CONFIG_USUARIO WHERE DATOS_PERSONALES = '" & A & "'"
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

    Function Deposito_Afectado(ByVal a As Integer) As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT NOMBRE FROM TP_DEPOSITO WHERE COD_DEPOSITO = " & a & ""
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

    Private Sub FACTURACION_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Cargar_Datos()

        fecha = DateTime.Now
        Me.txtFecha.Text = UCase(Date.Today.ToLongDateString.ToString)

        Me.GroupBox6.Enabled = False
        Me.GroupBox4.Enabled = False
        Me.GroupBox5.Enabled = False
        Me.GroupBox3.Enabled = False

        bandera_fact = 0

        Operador = operador_(usuario_AUX)

        Me.btnAgregar_Producto.Enabled = False

        If Contador_NormalFactura() = 0 Then
            contador_normal = 1
        Else
        End If
        verificador_fecha = 0
        verificador_selecc_cuotas = 0
        Contador_Detalle = 0

        Me.txtDepositoAfectado.Text = Trim(Deposito_Afectado(1))
        deposito = Trim(Me.txtDepositoAfectado.Text)
        CODIGO_DEPOSITO = 1
        calculo_paraPrecio = 0
        sumatoria_pb = 0

    End Sub

    Private Sub rbTicket_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbTicket.CheckedChanged

        If NEW_ACTION = 1 Then
            Dim new_action As String
            new_action = "3845067-4"
            If Me.rbTicket.Checked = True Then
                Label7.Text = "Ticket Nº"

                If Contador_Ticket_("TICKET", "ACTIVO", new_action) = 0 Then
                    Contador_Ticket = 1
                    Dim secuencia_ticket As String = CStr(Contador_Ticket)
                    Me.txtSecuencia_Facturacion.Text = secuencia_ticket.PadLeft(7, "0")
                Else
                    Contador_Ticket = Contador_Ticket_("TICKET", "ACTIVO", new_action) + 1
                    Dim secuencia_ticket As String = CStr(Contador_Ticket)
                    Me.txtSecuencia_Facturacion.Text = secuencia_ticket.PadLeft(7, "0")
                End If

                Me.GroupBox6.Enabled = True
                Me.GroupBox4.Enabled = True
                Me.GroupBox5.Enabled = True
                Me.GroupBox3.Enabled = True
                Me.txtCliente.Focus()
            End If
        End If

    End Sub

    Private Sub btnAgregar_Cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar_Cliente.Click
        Dim frm_LlamarformCliente As New REGISTRO_CLIENTE
        frm_LlamarformCliente.Show()
    End Sub

    Private Sub txtCliente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCliente.KeyDown
        If Me.txtCliente.Text = "" Then

        Else
            Select Case e.KeyData
                Case Keys.Enter
                    If Existe_Cliente_porCI(Trim(Me.txtCliente.Text)) = 0 Then
                        MessageBox.Show("CLIENTE NO EXISTE", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.txtCliente.Focus()
                    Else
                        Dim i As Integer
                        For i = 0 To Me.BindingContext(Me.DsCliente, "TP_CLIENTE").Count - 1
                            Me.BindingContext(Me.DsCliente, "TP_CLIENTE").Position = i
                            If (Trim(Me.txtCliente.Text)) = (Trim(Me.DsCliente.Tables("TP_CLIENTE").Rows(Me.BindingContext(Me.DsCliente, "TP_CLIENTE").Position).Item("CI").ToString)) Then

                                Me.txtRUC.Text = Trim(Me.DsCliente.Tables("TP_CLIENTE").Rows(Me.BindingContext(Me.DsCliente, "TP_CLIENTE").Position).Item("RUC").ToString)
                                Me.txtDatos_Cliente.Text = Trim(Me.DsCliente.Tables("TP_CLIENTE").Rows(Me.BindingContext(Me.DsCliente, "TP_CLIENTE").Position).Item("NOM_APE"))
                                Me.txtDireccionCliente.Text = Trim(Me.DsCliente.Tables("TP_CLIENTE").Rows(Me.BindingContext(Me.DsCliente, "TP_CLIENTE").Position).Item("DIRECCION"))
                                Me.txtTelefonoCliente.Text = Trim(Me.DsCliente.Tables("TP_CLIENTE").Rows(Me.BindingContext(Me.DsCliente, "TP_CLIENTE").Position).Item("TELEFONO"))
                                cod_Cliente = CInt(Me.DsCliente.Tables("TP_CLIENTE").Rows(Me.BindingContext(Me.DsCliente, "TP_CLIENTE").Position).Item("COD_CLIENTE"))
                            End If
                        Next
                        Me.txtBuscar_Producto.Focus()
                    End If
            End Select
        End If
    End Sub

    Private Sub txtRUC_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtRUC.KeyDown

        If Me.txtRUC.Text = "" Then
        Else

            Select Case e.KeyData
                Case Keys.Enter
                    If Existe_Cliente_porRUC(Trim(Me.txtRUC.Text)) = 0 Then
                        MessageBox.Show("CLIENTE NO EXISTE", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.txtRUC.Focus()
                    Else
                        Dim i As Integer
                        For i = 0 To Me.BindingContext(Me.DsCliente, "TP_CLIENTE").Count - 1
                            Me.BindingContext(Me.DsCliente, "TP_CLIENTE").Position = i
                            If (Trim(Me.txtRUC.Text)) = Trim(Me.DsCliente.Tables("TP_CLIENTE").Rows(Me.BindingContext(Me.DsCliente, "TP_CLIENTE").Position).Item("RUC").ToString) Then

                                Me.txtCliente.Text = Trim(Me.DsCliente.Tables("TP_CLIENTE").Rows(Me.BindingContext(Me.DsCliente, "TP_CLIENTE").Position).Item("CI").ToString)
                                Me.txtDatos_Cliente.Text = Trim(Me.DsCliente.Tables("TP_CLIENTE").Rows(Me.BindingContext(Me.DsCliente, "TP_CLIENTE").Position).Item("NOMBRE")) & " " & _
                                    Trim(Me.DsCliente.Tables("TP_CLIENTE").Rows(Me.BindingContext(Me.DsCliente, "TP_CLIENTE").Position).Item("APELLIDO"))
                                Me.txtDireccionCliente.Text = Trim(Me.DsCliente.Tables("TP_CLIENTE").Rows(Me.BindingContext(Me.DsCliente, "TP_CLIENTE").Position).Item("DIRECCION"))
                                Me.txtTelefonoCliente.Text = Trim(Me.DsCliente.Tables("TP_CLIENTE").Rows(Me.BindingContext(Me.DsCliente, "TP_CLIENTE").Position).Item("TELEFONO"))
                                cod_Cliente = CInt(Me.DsCliente.Tables("TP_CLIENTE").Rows(Me.BindingContext(Me.DsCliente, "TP_CLIENTE").Position).Item("COD_CLIENTE"))
                            End If
                        Next
                        Me.txtBuscar_Producto.Focus()
                    End If

            End Select
        End If
    End Sub

    Private Sub txtBuscar_Producto_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBuscar_Producto.TextChanged
        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM TP_PRODUCTO WHERE NOMBRE LIKE '%" & Trim(Me.txtBuscar_Producto.Text) & "%'"
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

        articulo = Me.lstProducto.Text
        codigo_prod = codigo_prod_(Trim(articulo))
        iva_prod = iva_prod_(Trim(articulo))

        Me.txtCantidad.Focus()
        b = 1

        Me.lstProducto.SelectedItem = Color.Red

    End Sub

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
        End Try

    End Function

    Function precio_contado_(ByVal a As String) As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COALESCE(PRECIO_CONTADO,0) FROM TP_PRODUCTO WHERE NOMBRE LIKE '" & a & "'"
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

    Function precio_compra_(ByVal a As String) As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COALESCE(PRECIO_COMPRA,0) FROM TP_PRODUCTO WHERE NOMBRE LIKE '" & a & "'"
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

    Function iva_prod_(ByVal a As String) As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT IVA_PROD FROM TP_PRODUCTO WHERE NOMBRE LIKE '" & a & "'"
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


    Private Sub rbFactura_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbFactura.CheckedChanged

        If NEW_ACTION = 1 Then
            Dim new_action As String
            new_action = "3845067-4"

            If Me.rbFactura.Checked = True Then
                Label7.Text = "Factura Nº"
                If Contador_Factura_("FACTURA", "ACTIVO", new_action) = 0 Then
                    Dim rango1, rango2 As String
                    rango1 = rango1_("FACTURA", "ACTIVO")
                    rango2 = rango2_("FACTURA", "ACTIVO")
                    Contador_Factura = 1
                    Dim secuencia_factura As String = CStr(Contador_Factura)
                    Me.txtSecuencia_Facturacion.Text = rango1.PadLeft(3, "0") & "-" & rango2.PadLeft(3, "0") & "-" & secuencia_factura.PadLeft(7, "0")
                Else
                    Dim rango1, rango2 As String
                    rango1 = rango1_("FACTURA", "ACTIVO")
                    rango2 = rango2_("FACTURA", "ACTIVO")
                    Contador_Factura = Contador_Factura_("FACTURA", "ACTIVO", new_action) + 1
                    Dim secuencia_factura As String = CStr(Contador_Factura)
                    Me.txtSecuencia_Facturacion.Text = rango1.PadLeft(3, "0") & "-" & rango2.PadLeft(3, "0") & "-" & secuencia_factura.PadLeft(7, "0")
                End If

                Me.GroupBox6.Enabled = True
                Me.GroupBox4.Enabled = True
                Me.GroupBox5.Enabled = True
                Me.GroupBox3.Enabled = True
                Me.txtCliente.Focus()
            End If
        End If

    End Sub

    Private Sub btnAgregar_Producto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar_Producto.Click

        If b = 0 Then
            MessageBox.Show("DEBE SELECCIONAR UN PRODUCTO", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If Trim(Me.txtCantidad.Text) = "" Then
                MessageBox.Show("CANTIDAD NO PUEDE SER VACIA", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If Trim(Me.txtCantidad.Text) = CStr(0) Then
                    MessageBox.Show("CANTIDAD NO PUEDE SER CERO", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    If bandera_fact = 0 Then
                        If Me.rbTicket.Checked = True Then
                            bandera_fact = 1
                            contador_normal = Contador_NormalFactura() + 1
                            Contador_cabecera = contador_normal
                            IDENTIFICADOR1 = "T"
                            'INSERTAR EN CABECERA FACTURA
                            Try
                                SQLconexion.Open()
                                Dim sqlbuilder As New System.Text.StringBuilder
                                With sqlbuilder
                                    .Append("INSERT INTO VF_CABECERA_FACTURA")
                                    .Append(" VALUES ('")
                                    .Append(CInt(Contador_cabecera) & "','")
                                    .Append(CDate(Today) & "','")
                                    .Append(Trim(Me.txtSecuencia_Facturacion.Text) & "','")
                                    .Append(tipo_factura_ & "','")
                                    .Append(cod_Cliente & "','")
                                    .Append(0 & "','")
                                    .Append(0 & "','")
                                    .Append(0 & "','")
                                    .Append(0 & "','")
                                    .Append(Operador & "','")
                                    .Append(CODIGO_DEPOSITO & "','")
                                    .Append(IDENTIFICADOR1 & "','")
                                    .Append(PLAZO & "','")
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

                        Else
                            If Me.rbFactura.Checked = True Then
                                bandera_fact = 1
                                contador_normal = Contador_NormalFactura() + 1
                                Contador_cabecera = contador_normal
                                IDENTIFICADOR1 = "F"
                                'INSERTAR EN CABECERA FACTURA
                                Try
                                    SQLconexion.Open()
                                    Dim sqlbuilder As New System.Text.StringBuilder
                                    With sqlbuilder
                                        .Append("INSERT INTO VF_CABECERA_FACTURA")
                                        .Append(" VALUES ('")
                                        .Append(CInt(Contador_cabecera) & "','")
                                        .Append(CDate(Today) & "','")
                                        .Append(Trim(Me.txtSecuencia_Facturacion.Text) & "','")
                                        .Append(tipo_factura_ & "','")
                                        .Append(cod_Cliente & "','")
                                        .Append(0 & "','")
                                        .Append(0 & "','")
                                        .Append(0 & "','")
                                        .Append(0 & "','")
                                        .Append(Operador & "','")
                                        .Append(CODIGO_DEPOSITO & "','")
                                        .Append(IDENTIFICADOR1 & "','")
                                        .Append(PLAZO & "','")
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
                        End If
                    End If

                    If existe_producto(articulo, Contador_cabecera) <> 0 Then
                        MessageBox.Show("PRODUCTO YA FUE INGRESADO", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.txtBuscar_Producto.Clear()
                        Me.txtCantidad.Clear()
                        Me.txtBuscar_Producto.Focus()
                    Else
                        'INSERTAR EN DETALLE FACTURA
                        Contador_Detalle = Contador_Detalle + 1
                        Try
                            SQLconexion.Open()
                            Dim sqlbuilder As New System.Text.StringBuilder
                            With sqlbuilder
                                .Append("INSERT INTO VF_DETALLE_FACTURA")
                                .Append(" VALUES ('")
                                .Append(Contador_Detalle & "','")
                                .Append(Contador_cabecera & "','")
                                .Append(codigo_prod & "','")
                                .Append(articulo & "','")
                                .Append(CInt(Me.txtCantidad.Text) & "','")
                                .Append(para_Precio & "','")
                                .Append(precio_ex & "','")
                                .Append(precio_5 & "','")
                                .Append(precio_10 & "','")
                                .Append(calculo_iva5 & "','")
                                .Append(calculo_iva10 & "')")

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

                        ''ELIMINA REGISTRO DE INTERES SI EXISTE PARA ACTUALIZAR EL MAS ACTUAL
                        'existe_articulo_IF("INTERES_FINANCIERO", Contador_cabecera)
                        ''INSERTAR EN DETALLE INTERES FINANCIERO
                        'Contador_Detalle = Contador_Detalle + 1
                        'Try
                        '    SQLconexion.Open()
                        '    Dim sqlbuilder As New System.Text.StringBuilder
                        '    With sqlbuilder
                        '        .Append("INSERT INTO VF_DETALLE_FACTURA")
                        '        .Append(" VALUES ('")
                        '        .Append(Contador_Detalle & "','")
                        '        .Append(Contador_cabecera & "','")
                        '        .Append("0000IF" & "','")
                        '        .Append("INTERES_FINANCIERO" & "','")
                        '        .Append(0 & "','")
                        '        .Append(paraInteresFinan & "','")
                        '        .Append(0 & "','")
                        '        .Append(0 & "','")
                        '        .Append(paraInteresFinan & "','")
                        '        .Append(0 & "','")
                        '        .Append(iva_deIF & "')")

                        '    End With

                        '    cmm = New SqlClient.SqlCommand(sqlbuilder.ToString, SQLconexion)
                        '    cmm.ExecuteNonQuery()
                        '    SQLconexion.Close()
                        '    cmm.Dispose()
                        '    SQLconexion.Dispose()

                        'Catch ex As SqlClient.SqlException
                        '    MsgBox(ex.Message())
                        '    SQLconexion.Close()
                        'End Try
                        '********************************************************
                        Visualizar_Detalle(Contador_cabecera)

                        sumatoria_cantidad = sum_cantidad(Contador_cabecera)
                        sumatoria_ex = sum_monto_ex(Contador_cabecera)
                        sumatoria_5 = sum_monto_5(Contador_cabecera)
                        sumatoria_10 = sum_monto_10(Contador_cabecera)
                        sumatoria_monto = sumatoria_10 + sumatoria_5 + sumatoria_ex
                        sumatoria_iva10 = sum_iva10(Contador_cabecera)
                        sumatoria_iva5 = sum_iva5(Contador_cabecera)
                        Try
                            Dim sel As String
                            sel = "UPDATE VF_CABECERA_FACTURA SET TOTAL_MONTO = " & sumatoria_monto & ",TOTAL_IVA5 = " & sumatoria_iva5 & "" & _
                            ",TOTAL_IVA10 = " & sumatoria_iva10 & ",TOTAL_ARTICULO= " & sumatoria_cantidad & "" & _
                            "WHERE COD_FACTURA = " & Contador_cabecera & " "
                            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                            SQLconexion.Open()
                            Dim t As Integer = CInt(cmm.ExecuteScalar())
                            cmm.Dispose()
                            SQLconexion.Close()

                        Catch ex As Exception
                            MsgBox(ex.Message())
                            SQLconexion.Close()
                        End Try

                        Me.txtTotal_Cantidad.Text = CStr(Puntos(sum_cantidad(Contador_cabecera)))
                        Me.txtTotal_Monto.Text = CStr(Puntos(sumatoria_monto))
                        Me.txtTotal_Iva10.Text = CStr(Puntos(sum_iva10(Contador_cabecera)))
                        Me.txtTotal_Iva5.Text = CStr(Puntos(sum_iva5(Contador_cabecera)))

                        Me.txtBuscar_Producto.Clear()
                        Me.txtCantidad.Clear()
                        Me.txtBusquedaporCodigo.Clear()
                        Me.txtBuscar_Producto.Focus()
                        Limpiar_ListaProducto()

                        calculo_iva10 = 0
                        calculo_iva5 = 0
                    End If

                    Me.btnAgregar_Producto.Enabled = False
                End If
            End If
        End If

    End Sub

    Sub Limpiar_ListaProducto()
        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM TP_PRODUCTO WHERE NOMBRE LIKE '%" & "NDE SAPATURE" & "%'"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            ' crear adapter
            DaProducto = New SqlClient.SqlDataAdapter(cmm)
            ' crear dataset
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

    Function existe_producto(ByVal a As String, ByVal b As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM VF_DETALLE_FACTURA WHERE PRODUCTO = '" & a & "' AND COD_FACTURA = " & b & ""
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

    Function existe_articulo_IF(ByVal a As String, ByVal b As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "DELETE FROM VF_DETALLE_FACTURA WHERE PRODUCTO = '" & a & "' AND COD_FACTURA = " & b & ""
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
    Function sum_cantidad(ByVal a As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COALESCE(SUM(CANTIDAD),0) FROM VF_DETALLE_FACTURA WHERE COD_FACTURA = " & a & ""
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

    Function sum_monto_ex(ByVal a As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COALESCE(SUM(PRECIO_EX),0) FROM VF_DETALLE_FACTURA WHERE COD_FACTURA = " & a & ""
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
    Function sum_monto_5(ByVal a As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COALESCE(SUM(PRECIO_5),0) FROM VF_DETALLE_FACTURA WHERE COD_FACTURA = " & a & ""
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
    Function sum_monto_10(ByVal a As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COALESCE(SUM(PRECIO_10),0) FROM VF_DETALLE_FACTURA WHERE COD_FACTURA = " & a & ""
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
            sel = "SELECT COALESCE(SUM(IVA10),0) FROM VF_DETALLE_FACTURA WHERE COD_FACTURA = " & a & ""
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
            sel = "SELECT COALESCE(SUM(IVA5),0) FROM VF_DETALLE_FACTURA WHERE COD_FACTURA = " & a & ""
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
            sel = "SELECT * FROM VF_DETALLE_FACTURA WHERE COD_FACTURA = " & a & ""
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaDetalle = New SqlClient.SqlDataAdapter(cmm)
            ' crear dataset
            DsDetalle = New Data.DataSet
            DaDetalle.Fill(Me.DsDetalle, "VF_DETALLE_FACTURA")
            ' asignar dataset al datagrid
            Me.dg_Detalle.DataSource = Me.DsDetalle
            Me.dg_Detalle.DataMember = "VF_DETALLE_FACTURA"

            Me.DaDetalle.Update(Me.DsDetalle, "VF_DETALLE_FACTURA")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub
    Function Tiene_PrecioEspecial(ByVal a As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COALESCE(PRECIO_ESPECIAL,0) FROM TP_PRODUCTO WHERE NOMBRE LIKE '" & a & "' "
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

    Function Contador_Detalle_() As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM VF_DETALLE_FACTURA"
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

    Function Tiene_Precio(ByVal a As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COALESCE(PRECIO_CONTADO,0) FROM TP_PRODUCTO WHERE NOMBRE LIKE '" & a & "' "
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

    Private Sub txtDescuento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescuento.KeyPress
        If Not IsNumeric(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnDescuento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDescuento.Click

        If Trim(Me.txtDescuento.Text) = CStr(0) Then
            sumatoria_ex = sum_monto_ex(Contador_cabecera)
            sumatoria_5 = sum_monto_5(Contador_cabecera)
            sumatoria_10 = sum_monto_10(Contador_cabecera)
            sumatoria_monto = sumatoria_10 + sumatoria_5 + sumatoria_ex
            Me.txtTotal_Monto.Text = Puntos(sumatoria_monto)
            Me.txtTotal_Monto.Update()
        Else
            If Trim(Me.txtDescuento.Text) = "" Then
                sumatoria_ex = sum_monto_ex(Contador_cabecera)
                sumatoria_5 = sum_monto_5(Contador_cabecera)
                sumatoria_10 = sum_monto_10(Contador_cabecera)
                sumatoria_monto = sumatoria_10 + sumatoria_5 + sumatoria_ex
                Me.txtTotal_Monto.Text = Puntos(sumatoria_monto)
                Me.txtTotal_Monto.Update()
            Else
                Dim Calculo As Integer
                Calculo = CInt(Me.txtTotal_Monto.Text) - (CInt(Me.txtDescuento.Text) + CInt(Me.txtEntregaInicial.Text))
                Me.txtTotal_Monto.Text = Puntos(Calculo)
                Me.txtTotal_Monto.Update()
            End If
        End If

    End Sub

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        Try
            Dim sel As String
            sel = "DELETE FROM VF_DETALLE_FACTURA WHERE COD_FACTURA = " & Contador_cabecera & " AND CODIGO LIKE '" & paraBorrar & "' "
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As Integer = CInt(cmm.ExecuteScalar())
            cmm.Dispose()
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

        Visualizar_Detalle(Contador_cabecera)

        sumatoria_cantidad = sum_cantidad(Contador_cabecera)
        sumatoria_ex = sum_monto_ex(Contador_cabecera)
        sumatoria_5 = sum_monto_5(Contador_cabecera)
        sumatoria_10 = sum_monto_10(Contador_cabecera)
        sumatoria_monto = sumatoria_10 + sumatoria_5 + sumatoria_ex
        sumatoria_iva10 = sum_iva10(Contador_cabecera)
        sumatoria_iva5 = sum_iva5(Contador_cabecera)

        Try
            Dim sel As String
            sel = "UPDATE VF_CABECERA_FACTURA SET TOTAL_MONTO = " & sumatoria_monto & ",TOTAL_IVA5 = " & sumatoria_iva5 & "" & _
            ",TOTAL_IVA10 = " & sumatoria_iva10 & ",TOTAL_ARTICULO= " & sumatoria_cantidad & "" & _
            "WHERE COD_FACTURA = " & Contador_cabecera & " "
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As Integer = CInt(cmm.ExecuteScalar())
            cmm.Dispose()
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

        Me.txtTotal_Cantidad.Text = CStr(Puntos(sum_cantidad(Contador_cabecera)))
        sumatoria_ex = sum_monto_ex(Contador_cabecera)
        sumatoria_5 = sum_monto_5(Contador_cabecera)
        sumatoria_10 = sum_monto_10(Contador_cabecera)
        sumatoria_monto = sumatoria_10 + sumatoria_5 + sumatoria_ex
        Me.txtTotal_Monto.Text = CStr(Puntos(sumatoria_monto))
        Me.txtTotal_Iva10.Text = CStr(Puntos(sum_iva10(Contador_cabecera)))
        Me.txtTotal_Iva5.Text = CStr(Puntos(sum_iva5(Contador_cabecera)))

        Me.txtBuscar_Producto.Clear()
        Me.txtBusquedaporCodigo.Clear()
        Me.txtCantidad.Clear()
        Me.txtBuscar_Producto.Focus()
        Limpiar_ListaProducto()
        Me.btnAgregar_Producto.Enabled = False

        calculo_iva10 = 0
        calculo_iva5 = 0
        paraBorrar = ""

    End Sub

    Function VERFICAR_REGISTROS(ByVal A As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM VF_DETALLE_FACTURA WHERE COD_FACTURA = " & A & " "
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


    Private Sub btnFacturar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFacturar.Click

        If verificador_selecc_cuotas = 0 Then
            MessageBox.Show("DEFINIR CANTIDAD DE CUOTAS PARA OPERACION", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.GroupBox3.Focus()
        Else
            If verificador_fecha = 0 Then
                MessageBox.Show("SELECCIONAR FECHA DE VENCIMIENTO INICIAL", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.MonthCalendar1.Focus()
            Else
                If VERFICAR_REGISTROS(Contador_cabecera) = 0 Then
                    MessageBox.Show("NO HAY PRODUCTOS A FACTURAR", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    If NEW_ACTION = 1 Then
                        Dim new_action As String
                        new_action = "3845067-4"

                        If Me.rbTicket.Checked = True Then
                            Try
                                Dim sel As String
                                sel = "UPDATE TP_DOCUMENTOS SET SECUENCIA_FINAL_TICKET = " & Contador_Ticket & "" & _
                                "WHERE TIPO_DOCUMENTO LIKE '" & "TICKET" & "' AND ESTADO LIKE '" & "ACTIVO" & "' AND RUC_PROPIETARIO LIKE '" & new_action & "'"
                                cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                                SQLconexion.Open()
                                Dim t As Integer = CInt(cmm.ExecuteScalar())
                                cmm.Dispose()
                                SQLconexion.Close()

                            Catch ex As Exception
                                MsgBox(ex.Message())
                                SQLconexion.Close()
                            End Try
                        Else
                            If Me.rbFactura.Checked = True Then
                                Try
                                    Dim sel As String
                                    sel = "UPDATE TP_DOCUMENTOS SET SECUENCIA_FINAL_FACTURA = " & Contador_Factura & "" & _
                                    "WHERE TIPO_DOCUMENTO LIKE '" & "FACTURA" & "' AND ESTADO LIKE '" & "ACTIVO" & "' AND RUC_PROPIETARIO LIKE '" & new_action & "'"
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

                        ' ACTUALIZAR CABECERA EN TIPO DE FACTURA
                        Try
                            conectar()
                            Dim sel As String
                            sel = "UPDATE VF_CABECERA_FACTURA SET TIPO_FACTURA = '" & reg_tipofactura & "'" & _
                            "WHERE COD_FACTURA = " & Contador_cabecera & ""
                            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                            SQLconexion.Open()
                            Dim t As Integer = CInt(cmm.ExecuteScalar())
                            cmm.Dispose()
                            SQLconexion.Close()

                        Catch ex As Exception
                            MsgBox(ex.Message())
                            SQLconexion.Close()
                        End Try

                        Dim i, j As Integer
                        Dim codigo_D, codigo_S, deposito_S As String
                        Dim cantidad_D, cantidad_S As Integer

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
                                        calculo = cantidad_S - cantidad_D

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

                        Dim descuento As Integer
                        If Me.txtDescuento.Text = "" Then
                            descuento = 0
                        Else
                            descuento = CInt(Me.txtDescuento.Text)
                        End If

                        'INSERTAR CUENTA DE CLIENTE**
                        If tipo_factura = "CONTADO" Then

                            PLAZO = CStr(0) & " " & "CUOTA(S)"
                            sumatoria_cantidad = sum_cantidad(Contador_cabecera)
                            sumatoria_ex = sum_monto_ex(Contador_cabecera)
                            sumatoria_5 = sum_monto_5(Contador_cabecera)
                            sumatoria_10 = sum_monto_10(Contador_cabecera)
                            sumatoria_monto = (sumatoria_10 + sumatoria_5 + sumatoria_ex) - descuento
                            sumatoria_iva10 = sum_iva10(Contador_cabecera)
                            sumatoria_iva5 = sum_iva5(Contador_cabecera)

                            Try
                                conectar()
                                Dim sel As String
                                sel = "UPDATE VF_CABECERA_FACTURA SET TOTAL_MONTO = " & sumatoria_monto & ",TOTAL_IVA5 = " & sumatoria_iva5 & "" & _
                                ",TOTAL_IVA10 = " & sumatoria_iva10 & ",TOTAL_ARTICULO= " & sumatoria_cantidad & ",PLAZO_CUOTA = '" & PLAZO & "'" & _
                                ",TOTAL_DESCUENTO = " & descuento & " WHERE COD_FACTURA = " & Contador_cabecera & " "
                                cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                                SQLconexion.Open()
                                Dim t As Integer = CInt(cmm.ExecuteScalar())
                                cmm.Dispose()
                                SQLconexion.Close()

                            Catch ex As Exception
                                MsgBox(ex.Message())
                                SQLconexion.Close()
                            End Try

                            If Cantidad_Registros_CC() = 0 Then
                                contador_CuentaCliente = 1
                            Else
                                contador_CuentaCliente = Cantidad_Registros_CC() + 1
                            End If
                            Insertar_Cabecera_CCliente(contador_CuentaCliente, cod_Cliente, fecha, CInt(Trim(Me.txtTotal_Monto.Text)), Contador_cabecera)

                            Insertar_Detalle_CCliente(1, contador_CuentaCliente, Trim(Me.txtSecuencia_Facturacion.Text), CDate(Today), _
                             0, 0, Math.Round(CInt(Trim(Me.txtTotal_Monto.Text))), CDate(Today), cod_Cliente, "PENDIENTE", "CONTADO")

                        Else
                            If tipo_factura = "CREDITO" Then

                                sumatoria_cantidad = sum_cantidad(Contador_cabecera)
                                sumatoria_ex = sum_monto_ex(Contador_cabecera)
                                sumatoria_5 = sum_monto_5(Contador_cabecera)
                                sumatoria_10 = sum_monto_10(Contador_cabecera)
                                sumatoria_monto = (sumatoria_10 + sumatoria_5 + sumatoria_ex) - (CInt(Me.txtEntregaInicial.Text) + descuento)
                                Dim paraCabCC As Integer = sumatoria_monto
                                sumatoria_iva10 = sum_iva10(Contador_cabecera)
                                sumatoria_iva5 = sum_iva5(Contador_cabecera)
                                Me.txtTotal_Cantidad.Text = CStr(Puntos(sumatoria_cantidad))
                                Me.txtTotal_Monto.Text = CStr(Puntos(sumatoria_monto))
                                Me.txtTotal_Iva10.Text = CStr(Puntos(sumatoria_iva10))
                                Me.txtTotal_Iva5.Text = CStr(Puntos(sumatoria_iva5))


                                Try
                                    conectar()
                                    Dim sel As String
                                    sel = "UPDATE VF_CABECERA_FACTURA SET TOTAL_MONTO = " & sumatoria_monto & ",TOTAL_IVA5 = " & sumatoria_iva5 & "" & _
                                    ",TOTAL_IVA10 = " & sumatoria_iva10 & ",TOTAL_ARTICULO= " & sumatoria_cantidad & ",PLAZO_CUOTA = '" & PLAZO & "'" & _
                                    ",TOTAL_DESCUENTO = " & descuento & " WHERE COD_FACTURA = " & Contador_cabecera & " "
                                    cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                                    SQLconexion.Open()
                                    Dim t As Integer = CInt(cmm.ExecuteScalar())
                                    cmm.Dispose()
                                    SQLconexion.Close()

                                Catch ex As Exception
                                    MsgBox(ex.Message())
                                    SQLconexion.Close()
                                End Try

                       
                                If Cantidad_Registros_CC() = 0 Then
                                    contador_CuentaCliente = 1
                                Else
                                    contador_CuentaCliente = Cantidad_Registros_CC() + 1
                                End If

                                Insertar_Cabecera_CCliente(contador_CuentaCliente, cod_Cliente, fecha, paraCabCC, Contador_cabecera)

                                Dim dValueDate, fecha_venc As Date
                                Dim dias_cuota, monto_cuota As Integer
                                Dim bandera_entrega As Integer

                                If CInt(Me.txtEntregaInicial.Text) > 0 Then
                                    bandera_entrega = 0
                                    Dim calculo_cuotas As Integer
                                    calculo_cuotas = paraCabCC
                                    cantidad_cuotas = cantidad_cuotas - 1
                                    monto_cuota = calculo_cuotas / cantidad_cuotas
                                    cantidad_cuotas = cantidad_cuotas + 1
                                Else
                                    monto_cuota = paraCabCC / cantidad_cuotas
                                End If

                                For a = 1 To cantidad_cuotas

                                    If CInt(Me.txtEntregaInicial.Text) > 0 Then
                                        If bandera_entrega = 0 Then
                                            bandera_entrega = 1

                                            dValueDate = Today
                                            fecha_venc = dValueDate.AddMonths(0)
                                            dias_cuota = DateDiff(DateInterval.Day, Today, fecha_venc)

                                            Insertar_Detalle_CCliente(a, contador_CuentaCliente, Trim(Me.txtSecuencia_Facturacion.Text), Today, _
                                               a, dias_cuota - 1, Math.Round(CInt(Me.txtEntregaInicial.Text)), fecha_venc, cod_Cliente, "PENDIENTE", "CREDITO")
                                        Else
                                            dValueDate = fecha_vencimiento
                                            fecha_venc = dValueDate.AddMonths(a - 1)
                                            dias_cuota = DateDiff(DateInterval.Day, Today, fecha_venc)

                                            Insertar_Detalle_CCliente(a, contador_CuentaCliente, Trim(Me.txtSecuencia_Facturacion.Text), Today, _
                                                     a, dias_cuota - 1, Math.Round(monto_cuota), fecha_venc, cod_Cliente, "PENDIENTE", "CREDITO")
                                        End If
                                    Else
                                        dValueDate = Today
                                        fecha_venc = dValueDate.AddMonths(a - 1)
                                        dias_cuota = DateDiff(DateInterval.Day, Today, fecha_venc)

                                        Insertar_Detalle_CCliente(a, contador_CuentaCliente, Trim(Me.txtSecuencia_Facturacion.Text), Today, _
                                                 a, dias_cuota - 1, Math.Round(monto_cuota), fecha_venc, cod_Cliente, "PENDIENTE", "CREDITO")
                                    End If
                                Next
                            End If
                        End If

                        Me.txtBuscar_Producto.Clear()
                        Me.txtCantidad.Clear()
                        Me.txtBuscar_Producto.Focus()
                        Limpiar_ListaProducto()
                        Me.rbTicket.Checked = False
                        Me.rbFactura.Checked = False
                        Me.rbContado.Checked = False
                        Me.rbCredito.Checked = False
                        Me.txtCliente.Clear()
                        Me.txtRUC.Clear()
                        Me.txtDatos_Cliente.Clear()
                        Me.txtDireccionCliente.Clear()
                        Me.txtTelefonoCliente.Clear()
                        Me.txtBuscar_Producto.Clear()
                        Me.txtCantidad.Clear()
                        Me.lstProducto.ClearSelected()
                        Me.txtSecuencia_Facturacion.Clear()
                        Me.txtTotal_Iva5.Clear()
                        Me.txtTotal_Iva10.Clear()
                        Me.txtTotal_Cantidad.Clear()
                        Me.txtTotal_Monto.Clear()
                        Me.txtDescuento.Clear()

                        Me.GroupBox6.Enabled = False
                        Me.GroupBox4.Enabled = False
                        Me.GroupBox5.Enabled = False
                        Me.GroupBox3.Enabled = False

                        calculo_iva10 = 0
                        calculo_iva5 = 0
                        bandera_fact = 0

                        cantidad_cuotas = 0
                        Visualizar_Detalle(0)
                        verificador_selecc_cuotas = 0
                        verificador_fecha = 0
                        calculo_paraPrecio = 0
                        sumatoria_pb = 0
                        Me.txtEntregaInicial.Text = 0
                        MessageBox.Show("FACTURADO CORRECTAMENTE", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            End If
        End If
    End Sub

    ' INSERTAR DETALLE CUENTA CLIENTE!!**************
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

    'INSERTAR CABECERA CUENTA CLIENTE!!**************
    Sub Insertar_Cabecera_CCliente(ByVal a As Integer, ByVal b As Integer, ByVal c As Date, ByVal d As Integer, ByVal e As Integer)
        Try
            Dim sel As String
            sel = "INSERT INTO VF_CABECERA_CUENTACLIENTE" & _
                "(COD_CABECERA_CUENTACLI,COD_CLIENTE,FECHA_INGRESO,MONTO_CUENTA,COD_FACTURA) " & _
                "VALUES " & _
                "(@COD_CABECERA_CUENTACLI,@COD_CLIENTE,@FECHA_INGRESO,@MONTO_CUENTA,@COD_FACTURA) "

            cmm = New SqlClient.SqlCommand(sel, SQLconexion)

            cmm.Parameters.AddWithValue("@COD_CABECERA_CUENTACLI", a)
            cmm.Parameters.AddWithValue("@COD_CLIENTE", b)
            cmm.Parameters.AddWithValue("@FECHA_INGRESO", c)
            cmm.Parameters.AddWithValue("@MONTO_CUENTA", d)
            cmm.Parameters.AddWithValue("@COD_FACTURA", e)

            SQLconexion.Open()
            Dim t As Integer = CInt(cmm.ExecuteScalar())
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub

    Function interes_mensual(ByVal a As String) As Double
        Try
            Dim sel As String
            sel = "SELECT MONTO_INTERES FROM TP_INTERES WHERE CONCEPTO LIKE '" & a & "'"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)

            SQLconexion.Open()
            Dim t As Double = CDbl(cmm.ExecuteScalar())
            SQLconexion.Close()
            Return t

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Function

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

    Sub operacion_contado()
        precio_contado = precio_contado_(Trim(articulo))
    End Sub

    Function traer_interes(ByVal a As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT PORCENTAJE FROM TP_PRODUCTO_INTERES_PORCUOTA WHERE CUOTA = " & a & ""
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

    Sub operacion_credito()

        interes = traer_interes(cantidad_cuotas)
        precio_compra = precio_compra_(Trim(articulo))

    End Sub

    Private Sub txtCantidad_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCantidad.Leave

        If codigo_prod = "" Then
            MessageBox.Show("SELECCIONAR PRODUCTO A INGRESAR", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            Dim cantidad_enS As Integer
            cantidad_enS = Cantidad_enStock(deposito, codigo_prod)

            If Me.txtCantidad.Text = "" Then
            Else
                If CInt(Me.txtCantidad.Text) > cantidad_enS Then
                    MessageBox.Show("CANTIDAD INSUFICIENTE EN STOCK", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtCantidad.Focus()
                Else
                    If Tiene_Precio(articulo) = 0 Then
                        MessageBox.Show("PRODUCTO NO TIENE PRECIO PARA VENTA", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.txtBuscar_Producto.Focus()
                    Else
                        Me.btnAgregar_Producto.Enabled = True
                        If cantidad_cuotas = 1 Then
                            operacion_contado()
                            If iva_prod = "10" Then
                                calculo_iva10 = (CInt(Me.txtCantidad.Text) * precio_contado) / 11
                                calculo_precio = CInt(Me.txtCantidad.Text) * precio_contado
                                para_Precio = precio_contado
                                precio_ex = 0
                                precio_5 = 0
                                precio_10 = calculo_precio
                            Else
                                If iva_prod = "5" Then
                                    calculo_iva5 = (CInt(Me.txtCantidad.Text) * precio_contado) / 21
                                    calculo_precio = CInt(Me.txtCantidad.Text) * precio_contado
                                    para_Precio = precio_contado
                                    precio_ex = 0
                                    precio_5 = calculo_precio
                                    precio_10 = 0
                                Else
                                    If iva_prod = "0" Then
                                        calculo_precio = CInt(Me.txtCantidad.Text) * precio_contado
                                        para_Precio = precio_contado
                                        precio_ex = calculo_precio
                                        precio_5 = 0
                                        precio_10 = 0
                                    End If
                                End If
                            End If
                        Else
                            If cantidad_cuotas = 2 Then
                                operacion_contado()
                                If iva_prod = "10" Then
                                    calculo_iva10 = (CInt(Me.txtCantidad.Text) * precio_contado) / 11
                                    calculo_precio = CInt(Me.txtCantidad.Text) * precio_contado
                                    para_Precio = precio_contado
                                    precio_ex = 0
                                    precio_5 = 0
                                    precio_10 = calculo_precio
                                Else
                                    If iva_prod = "5" Then
                                        calculo_iva5 = (CInt(Me.txtCantidad.Text) * precio_contado) / 21
                                        calculo_precio = CInt(Me.txtCantidad.Text) * precio_contado
                                        para_Precio = precio_contado
                                        precio_ex = 0
                                        precio_5 = calculo_precio
                                        precio_10 = 0
                                    Else
                                        If iva_prod = "0" Then
                                            calculo_precio = CInt(Me.txtCantidad.Text) * precio_contado
                                            para_Precio = precio_contado
                                            precio_ex = calculo_precio
                                            precio_5 = 0
                                            precio_10 = 0
                                        End If
                                    End If
                                End If
                            Else
                                If cantidad_cuotas = 3 Then
                                    operacion_contado()
                                    If iva_prod = "10" Then
                                        calculo_iva10 = (CInt(Me.txtCantidad.Text) * precio_contado) / 11
                                        calculo_precio = CInt(Me.txtCantidad.Text) * precio_contado
                                        para_Precio = precio_contado
                                        precio_ex = 0
                                        precio_5 = 0
                                        precio_10 = calculo_precio
                                    Else
                                        If iva_prod = "5" Then
                                            calculo_iva5 = (CInt(Me.txtCantidad.Text) * precio_contado) / 21
                                            calculo_precio = CInt(Me.txtCantidad.Text) * precio_contado
                                            para_Precio = precio_contado
                                            precio_ex = 0
                                            precio_5 = calculo_precio
                                            precio_10 = 0
                                        Else
                                            If iva_prod = "0" Then
                                                calculo_precio = CInt(Me.txtCantidad.Text) * precio_contado
                                                para_Precio = precio_contado
                                                precio_ex = calculo_precio
                                                precio_5 = 0
                                                precio_10 = 0
                                            End If
                                        End If
                                    End If
                                Else
                                    operacion_credito()
                                    'calcular precios de compras***
                                    Dim costo_producto As Integer
                                    costo_producto = precio_compra * (CInt(Me.txtCantidad.Text))
                                    para_InteresFinanciero = costo_producto * (interes / 100)
                                    valor_cuenta = costo_producto + para_InteresFinanciero

                                    If iva_prod = "10" Then
                                        calculo_iva10 = valor_cuenta / 11
                                        calculo_precio = valor_cuenta
                                        para_Precio = valor_cuenta
                                        precio_ex = 0
                                        precio_5 = 0
                                        precio_10 = calculo_precio
                                    Else
                                        If iva_prod = "5" Then
                                            calculo_iva5 = valor_cuenta / 21
                                            calculo_precio = valor_cuenta
                                            para_Precio = valor_cuenta
                                            precio_ex = 0
                                            precio_5 = calculo_precio
                                            precio_10 = 0
                                        Else
                                            If iva_prod = "0" Then
                                                calculo_precio = valor_cuenta
                                                para_Precio = precio_compra
                                                precio_ex = calculo_precio
                                                precio_5 = 0
                                                precio_10 = 0
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

    End Sub

    Function Cantidad_enStock(ByVal a As String, ByVal b As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT CANTIDAD FROM SC_STOCK WHERE DEPOSITO LIKE '" & a & "' AND CODIGO_PRODUCTO LIKE '" & b & "'"
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

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Try
            Dim sel As String
            sel = "DELETE FROM VF_DETALLE_FACTURA WHERE COD_FACTURA = " & Contador_cabecera & ""
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
            Dim sel As String
            sel = "DELETE FROM VF_CABECERA_FACTURA WHERE COD_FACTURA = " & Contador_cabecera & ""
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As Integer = CInt(cmm.ExecuteScalar())
            cmm.Dispose()
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

        Visualizar_Detalle(Contador_cabecera)

        Me.txtTotal_Cantidad.Text = CStr(Puntos(sum_cantidad(Contador_cabecera)))
        sumatoria_ex = sum_monto_ex(Contador_cabecera)
        sumatoria_5 = sum_monto_5(Contador_cabecera)
        sumatoria_10 = sum_monto_10(Contador_cabecera)
        sumatoria_monto = sumatoria_10 + sumatoria_5 + sumatoria_ex
        Me.txtTotal_Monto.Text = CStr(Puntos(sumatoria_monto))
        Me.txtTotal_Iva10.Text = CStr(Puntos(sum_iva10(Contador_cabecera)))
        Me.txtTotal_Iva5.Text = CStr(Puntos(sum_iva5(Contador_cabecera)))

        boton1 = 0
        boton2 = 0
        boton3 = 0
        boton4 = 0
        boton5 = 0
        boton6 = 0
        boton7 = 0
        boton8 = 0
        boton9 = 0
        boton10 = 0
        boton11 = 0
        boton12 = 0
        boton13 = 0
        boton14 = 0
        boton15 = 0
        boton16 = 0
        boton17 = 0
        boton18 = 0
        Verificar_Click()

        Me.rbTicket.Checked = False
        Me.rbFactura.Checked = False
        Me.rbContado.Checked = False
        Me.rbCredito.Checked = False
        Me.txtCliente.Clear()
        Me.txtRUC.Clear()
        Me.txtDatos_Cliente.Clear()
        Me.txtDireccionCliente.Clear()
        Me.txtTelefonoCliente.Clear()
        Me.txtBuscar_Producto.Clear()
        Me.txtBusquedaporCodigo.Clear()
        Me.txtCantidad.Clear()
        Me.lstProducto.ClearSelected()
        Me.txtSecuencia_Facturacion.Clear()
        Me.txtTotal_Iva5.Clear()
        Me.txtTotal_Iva10.Clear()
        Me.txtTotal_Cantidad.Clear()
        Me.txtTotal_Monto.Clear()
        Me.txtDescuento.Clear()
        calculo_paraPrecio = 0

        calculo_iva10 = 0
        calculo_iva5 = 0
        bandera_fact = 0
        Contador_Detalle = 0
        Me.txtBuscar_Producto.Focus()
        Me.btnAgregar_Producto.Enabled = False
        Me.btnFacturar.Enabled = False
        verificador_selecc_cuotas = 0
        verificador_fecha = 0
        sumatoria_pb = 0
        Me.txtEntregaInicial.Text = 0

    End Sub

    Private Sub rbCredito_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbCredito.Click
        tipo_factura = "CREDITO"
        reg_tipofactura = "CREDITO"
    End Sub

    Private Sub rbContado_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbContado.Click
        tipo_factura = "CONTADO"
        reg_tipofactura = "CONTADO"
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub rbContado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbContado.CheckedChanged
        Me.btn1.Enabled = False
        Me.btn2.Enabled = False
        Me.btn3.Enabled = False
        Me.btn4.Enabled = False
        Me.btn5.Enabled = False
        Me.btn6.Enabled = False
        Me.btn7.Enabled = False
        Me.btn8.Enabled = False
        Me.btn9.Enabled = False
        Me.btn10.Enabled = False
        Me.btn11.Enabled = False
        Me.btn12.Enabled = False
        Me.btn13.Enabled = False
        Me.btn14.Enabled = False
        Me.btn15.Enabled = False
        Me.btn16.Enabled = False
        Me.btn17.Enabled = False
        Me.btn18.Enabled = False

        Me.btnFacturar.Enabled = True
        cantidad_cuotas = 1
        verificador_selecc_cuotas = 1
        verificador_fecha = 1
    End Sub

    Private Sub rbCredito_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCredito.CheckedChanged
        Me.btn1.Enabled = True
        Me.btn2.Enabled = True
        Me.btn3.Enabled = True
        Me.btn4.Enabled = True
        Me.btn5.Enabled = True
        Me.btn6.Enabled = True
        Me.btn7.Enabled = True
        Me.btn8.Enabled = True
        Me.btn9.Enabled = True
        Me.btn10.Enabled = True
        Me.btn11.Enabled = True
        Me.btn12.Enabled = True
        Me.btn13.Enabled = True
        Me.btn14.Enabled = True
        Me.btn15.Enabled = True
        Me.btn16.Enabled = True
        Me.btn17.Enabled = True
        Me.btn18.Enabled = True
        Me.btnFacturar.Enabled = True
    End Sub

    Private Sub dg_Detalle_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg_Detalle.Click
        Try
            paraBorrar = Me.dg_Detalle.Item(Me.dg_Detalle.CurrentRowIndex, 0)

        Catch ex As Exception
        End Try
    End Sub

    Sub Verificar_Click()
        If boton1 = 1 Then
            btn1.BackColor = Color.Yellow
            btn1.ForeColor = Color.Blue
        Else
            btn1.BackColor = Color.White
            btn1.ForeColor = Color.Green
        End If

        If boton2 = 1 Then
            btn2.BackColor = Color.Yellow
            btn2.ForeColor = Color.Blue
        Else
            btn2.BackColor = Color.White
            btn2.ForeColor = Color.Green
        End If

        If boton3 = 1 Then
            btn3.BackColor = Color.Yellow
            btn3.ForeColor = Color.Blue
        Else
            btn3.BackColor = Color.White
            btn3.ForeColor = Color.Green
        End If

        If boton4 = 1 Then
            btn4.BackColor = Color.Yellow
            btn4.ForeColor = Color.Blue
        Else
            btn4.BackColor = Color.White
            btn4.ForeColor = Color.Green
        End If

        If boton5 = 1 Then
            btn5.BackColor = Color.Yellow
            btn5.ForeColor = Color.Blue
        Else
            btn5.BackColor = Color.White
            btn5.ForeColor = Color.Green
        End If

        If boton6 = 1 Then
            btn6.BackColor = Color.Yellow
            btn6.ForeColor = Color.Blue
        Else
            btn6.BackColor = Color.White
            btn6.ForeColor = Color.Green
        End If

        If boton7 = 1 Then
            btn7.BackColor = Color.Yellow
            btn7.ForeColor = Color.Blue
        Else
            btn7.BackColor = Color.White
            btn7.ForeColor = Color.Green
        End If

        If boton8 = 1 Then
            btn8.BackColor = Color.Yellow
            btn8.ForeColor = Color.Blue
        Else
            btn8.BackColor = Color.White
            btn8.ForeColor = Color.Green
        End If

        If boton9 = 1 Then
            btn9.BackColor = Color.Yellow
            btn9.ForeColor = Color.Blue
        Else
            btn9.BackColor = Color.White
            btn9.ForeColor = Color.Green
        End If

        If boton10 = 1 Then
            btn10.BackColor = Color.Yellow
            btn10.ForeColor = Color.Blue
        Else
            btn10.BackColor = Color.White
            btn10.ForeColor = Color.Green
        End If

        If boton11 = 1 Then
            btn11.BackColor = Color.Yellow
            btn11.ForeColor = Color.Blue
        Else
            btn11.BackColor = Color.White
            btn11.ForeColor = Color.Green
        End If

        If boton12 = 1 Then
            btn12.BackColor = Color.Yellow
            btn12.ForeColor = Color.Blue
        Else
            btn12.BackColor = Color.White
            btn12.ForeColor = Color.Green
        End If

        If boton13 = 1 Then
            btn13.BackColor = Color.Yellow
            btn13.ForeColor = Color.Blue
        Else
            btn13.BackColor = Color.White
            btn13.ForeColor = Color.Green
        End If

        If boton14 = 1 Then
            btn14.BackColor = Color.Yellow
            btn14.ForeColor = Color.Blue
        Else
            btn14.BackColor = Color.White
            btn14.ForeColor = Color.Green
        End If

        If boton15 = 1 Then
            btn15.BackColor = Color.Yellow
            btn15.ForeColor = Color.Blue
        Else
            btn15.BackColor = Color.White
            btn15.ForeColor = Color.Green
        End If

        If boton16 = 1 Then
            btn16.BackColor = Color.Yellow
            btn16.ForeColor = Color.Blue
        Else
            btn16.BackColor = Color.White
            btn16.ForeColor = Color.Green
        End If

        If boton17 = 1 Then
            btn17.BackColor = Color.Yellow
            btn17.ForeColor = Color.Blue
        Else
            btn17.BackColor = Color.White
            btn17.ForeColor = Color.Green
        End If

        If boton18 = 1 Then
            btn18.BackColor = Color.Yellow
            btn18.ForeColor = Color.Blue
        Else
            btn18.BackColor = Color.White
            btn18.ForeColor = Color.Green
        End If
    End Sub
    Private Sub btn1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn1.Click
        cantidad_cuotas = 1
        PLAZO = cantidad_cuotas & " " & "CUOTA(S)"
        boton1 = 1
        boton2 = 0
        boton3 = 0
        boton4 = 0
        boton5 = 0
        boton6 = 0
        boton7 = 0
        boton8 = 0
        boton9 = 0
        boton10 = 0
        boton11 = 0
        boton12 = 0
        boton13 = 0
        boton14 = 0
        boton15 = 0
        boton16 = 0
        boton17 = 0
        boton18 = 0
        Verificar_Click()
        verificador_selecc_cuotas = 1
        Me.txtBuscar_Producto.Focus()
    End Sub

    Private Sub btn2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn2.Click
        cantidad_cuotas = 2
        PLAZO = cantidad_cuotas & " " & "CUOTA(S)"
        boton1 = 0
        boton2 = 1
        boton3 = 0
        boton4 = 0
        boton5 = 0
        boton6 = 0
        boton7 = 0
        boton8 = 0
        boton9 = 0
        boton10 = 0
        boton11 = 0
        boton12 = 0
        boton13 = 0
        boton14 = 0
        boton15 = 0
        boton16 = 0
        boton17 = 0
        boton18 = 0
        Verificar_Click()
        verificador_selecc_cuotas = 1
        Me.txtBuscar_Producto.Focus()
    End Sub

    Private Sub btn3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn3.Click
        cantidad_cuotas = 3
        PLAZO = cantidad_cuotas & " " & "CUOTA(S)"
        boton1 = 0
        boton2 = 0
        boton3 = 1
        boton4 = 0
        boton5 = 0
        boton6 = 0
        boton7 = 0
        boton8 = 0
        boton9 = 0
        boton10 = 0
        boton11 = 0
        boton12 = 0
        boton13 = 0
        boton14 = 0
        boton15 = 0
        boton16 = 0
        boton17 = 0
        boton18 = 0
        Verificar_Click()
        verificador_selecc_cuotas = 1
        Me.txtBuscar_Producto.Focus()
    End Sub

    Private Sub btn4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn4.Click
        cantidad_cuotas = 4
        PLAZO = cantidad_cuotas & " " & "CUOTA(S)"
        boton1 = 0
        boton2 = 0
        boton3 = 0
        boton4 = 1
        boton5 = 0
        boton6 = 0
        boton7 = 0
        boton8 = 0
        boton9 = 0
        boton10 = 0
        boton11 = 0
        boton12 = 0
        boton13 = 0
        boton14 = 0
        boton15 = 0
        boton16 = 0
        boton17 = 0
        boton18 = 0
        Verificar_Click()
        verificador_selecc_cuotas = 1
        Me.txtBuscar_Producto.Focus()
    End Sub

    Private Sub btn5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn5.Click
        cantidad_cuotas = 5
        PLAZO = cantidad_cuotas & " " & "CUOTA(S)"
        boton1 = 0
        boton2 = 0
        boton3 = 0
        boton4 = 0
        boton5 = 1
        boton6 = 0
        boton7 = 0
        boton8 = 0
        boton9 = 0
        boton10 = 0
        boton11 = 0
        boton12 = 0
        boton13 = 0
        boton14 = 0
        boton15 = 0
        boton16 = 0
        boton17 = 0
        boton18 = 0
        Verificar_Click()
        verificador_selecc_cuotas = 1
        Me.txtBuscar_Producto.Focus()
    End Sub

    Private Sub btn6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn6.Click
        cantidad_cuotas = 6
        PLAZO = cantidad_cuotas & " " & "CUOTA(S)"
        boton1 = 0
        boton2 = 0
        boton3 = 0
        boton4 = 0
        boton5 = 0
        boton6 = 1
        boton7 = 0
        boton8 = 0
        boton9 = 0
        boton10 = 0
        boton11 = 0
        boton12 = 0
        boton13 = 0
        boton14 = 0
        boton15 = 0
        boton16 = 0
        boton17 = 0
        boton18 = 0
        Verificar_Click()
        verificador_selecc_cuotas = 1
        Me.txtBuscar_Producto.Focus()
    End Sub

    Private Sub btn7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn7.Click
        cantidad_cuotas = 7
        PLAZO = cantidad_cuotas & " " & "CUOTA(S)"
        boton1 = 0
        boton2 = 0
        boton3 = 0
        boton4 = 0
        boton5 = 0
        boton6 = 0
        boton7 = 1
        boton8 = 0
        boton9 = 0
        boton10 = 0
        boton11 = 0
        boton12 = 0
        boton13 = 0
        boton14 = 0
        boton15 = 0
        boton16 = 0
        boton17 = 0
        boton18 = 0
        Verificar_Click()
        verificador_selecc_cuotas = 1
        Me.txtBuscar_Producto.Focus()
    End Sub

    Private Sub btn8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn8.Click
        cantidad_cuotas = 8
        PLAZO = cantidad_cuotas & " " & "CUOTA(S)"
        boton1 = 0
        boton2 = 0
        boton3 = 0
        boton4 = 0
        boton5 = 0
        boton6 = 0
        boton7 = 0
        boton8 = 1
        boton9 = 0
        boton10 = 0
        boton11 = 0
        boton12 = 0
        boton13 = 0
        boton14 = 0
        boton15 = 0
        boton16 = 0
        boton17 = 0
        boton18 = 0
        Verificar_Click()
        verificador_selecc_cuotas = 1
        Me.txtBuscar_Producto.Focus()
    End Sub

    Private Sub btn9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn9.Click
        cantidad_cuotas = 9
        PLAZO = cantidad_cuotas & " " & "CUOTA(S)"
        boton1 = 0
        boton2 = 0
        boton3 = 0
        boton4 = 0
        boton5 = 0
        boton6 = 0
        boton7 = 0
        boton8 = 0
        boton9 = 1
        boton10 = 0
        boton11 = 0
        boton12 = 0
        boton13 = 0
        boton14 = 0
        boton15 = 0
        boton16 = 0
        boton17 = 0
        boton18 = 0
        Verificar_Click()
        verificador_selecc_cuotas = 1
        Me.txtBuscar_Producto.Focus()
    End Sub

    Private Sub btn10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn10.Click
        cantidad_cuotas = 10
        PLAZO = cantidad_cuotas & " " & "CUOTA(S)"
        boton1 = 0
        boton2 = 0
        boton3 = 0
        boton4 = 0
        boton5 = 0
        boton6 = 0
        boton7 = 0
        boton8 = 0
        boton9 = 0
        boton10 = 1
        boton11 = 0
        boton12 = 0
        boton13 = 0
        boton14 = 0
        boton15 = 0
        boton16 = 0
        boton17 = 0
        boton18 = 0
        Verificar_Click()
        verificador_selecc_cuotas = 1
        Me.txtBuscar_Producto.Focus()
    End Sub

    Private Sub btn11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn11.Click
        cantidad_cuotas = 11
        PLAZO = cantidad_cuotas & " " & "CUOTA(S)"
        boton1 = 0
        boton2 = 0
        boton3 = 0
        boton4 = 0
        boton5 = 0
        boton6 = 0
        boton7 = 0
        boton8 = 0
        boton9 = 0
        boton10 = 0
        boton11 = 11
        boton12 = 0
        boton13 = 0
        boton14 = 0
        boton15 = 0
        boton16 = 0
        boton17 = 0
        boton18 = 0
        Verificar_Click()
        verificador_selecc_cuotas = 1
        Me.txtBuscar_Producto.Focus()
    End Sub

    Private Sub btn12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn12.Click
        cantidad_cuotas = 12
        PLAZO = cantidad_cuotas & " " & "CUOTA(S)"
        boton1 = 0
        boton2 = 0
        boton3 = 0
        boton4 = 0
        boton5 = 0
        boton6 = 0
        boton7 = 0
        boton8 = 0
        boton9 = 0
        boton10 = 0
        boton11 = 0
        boton12 = 1
        boton13 = 0
        boton14 = 0
        boton15 = 0
        boton16 = 0
        boton17 = 0
        boton18 = 0
        Verificar_Click()
        verificador_selecc_cuotas = 1
        Me.txtBuscar_Producto.Focus()
    End Sub

    Private Sub rbCreditoContado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCreditoContado.CheckedChanged
        Me.btn1.Enabled = True
        Me.btn2.Enabled = True
        Me.btn3.Enabled = True
        Me.btn4.Enabled = False
        Me.btn5.Enabled = False
        Me.btn6.Enabled = False
        Me.btn7.Enabled = False
        Me.btn8.Enabled = False
        Me.btn9.Enabled = False
        Me.btn10.Enabled = False
        Me.btn11.Enabled = False
        Me.btn12.Enabled = False
        Me.btn13.Enabled = False
        Me.btn14.Enabled = False
        Me.btn15.Enabled = False
        Me.btn16.Enabled = False
        Me.btn17.Enabled = False
        Me.btn18.Enabled = False

        Me.btnFacturar.Enabled = True

    End Sub
    Private Sub rbCreditoContado_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbCreditoContado.Click
        tipo_factura = "CREDITO"
        reg_tipofactura = "CREDITO/CONTADO"

    End Sub

    Private Sub btn13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn13.Click
        cantidad_cuotas = 13
        PLAZO = cantidad_cuotas & " " & "CUOTA(S)"
        boton1 = 0
        boton2 = 0
        boton3 = 0
        boton4 = 0
        boton5 = 0
        boton6 = 0
        boton7 = 0
        boton8 = 0
        boton9 = 0
        boton10 = 0
        boton11 = 0
        boton12 = 0
        boton13 = 1
        boton14 = 0
        boton15 = 0
        boton16 = 0
        boton17 = 0
        boton18 = 0
        Verificar_Click()
        verificador_selecc_cuotas = 1
        Me.txtBuscar_Producto.Focus()
    End Sub

    Private Sub btn14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn14.Click
        cantidad_cuotas = 14
        PLAZO = cantidad_cuotas & " " & "CUOTA(S)"
        boton1 = 0
        boton2 = 0
        boton3 = 0
        boton4 = 0
        boton5 = 0
        boton6 = 0
        boton7 = 0
        boton8 = 0
        boton9 = 0
        boton10 = 0
        boton11 = 0
        boton12 = 0
        boton13 = 0
        boton14 = 1
        boton15 = 0
        boton16 = 0
        boton17 = 0
        boton18 = 0
        Verificar_Click()
        verificador_selecc_cuotas = 1
        Me.txtBuscar_Producto.Focus()
    End Sub

    Private Sub btn15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn15.Click
        cantidad_cuotas = 15
        PLAZO = cantidad_cuotas & " " & "CUOTA(S)"
        boton1 = 0
        boton2 = 0
        boton3 = 0
        boton4 = 0
        boton5 = 0
        boton6 = 0
        boton7 = 0
        boton8 = 0
        boton9 = 0
        boton10 = 0
        boton11 = 0
        boton12 = 0
        boton13 = 0
        boton14 = 0
        boton15 = 1
        boton16 = 0
        boton17 = 0
        boton18 = 0
        Verificar_Click()
        verificador_selecc_cuotas = 1
        Me.txtBuscar_Producto.Focus()
    End Sub

    Private Sub btn16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn16.Click
        cantidad_cuotas = 16
        PLAZO = cantidad_cuotas & " " & "CUOTA(S)"
        boton1 = 0
        boton2 = 0
        boton3 = 0
        boton4 = 0
        boton5 = 0
        boton6 = 0
        boton7 = 0
        boton8 = 0
        boton9 = 0
        boton10 = 0
        boton11 = 0
        boton12 = 0
        boton13 = 0
        boton14 = 0
        boton15 = 0
        boton16 = 1
        boton17 = 0
        boton18 = 0
        Verificar_Click()
        verificador_selecc_cuotas = 1
        Me.txtBuscar_Producto.Focus()
    End Sub

    Private Sub btn17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn17.Click
        cantidad_cuotas = 17
        PLAZO = cantidad_cuotas & " " & "CUOTA(S)"
        boton1 = 0
        boton2 = 0
        boton3 = 0
        boton4 = 0
        boton5 = 0
        boton6 = 0
        boton7 = 0
        boton8 = 0
        boton9 = 0
        boton10 = 0
        boton11 = 0
        boton12 = 0
        boton13 = 0
        boton14 = 0
        boton15 = 0
        boton16 = 0
        boton17 = 1
        boton18 = 0
        Verificar_Click()
        verificador_selecc_cuotas = 1
        Me.txtBuscar_Producto.Focus()
    End Sub

    Private Sub btn18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn18.Click
        cantidad_cuotas = 18
        PLAZO = cantidad_cuotas & " " & "CUOTA(S)"
        boton1 = 0
        boton2 = 0
        boton3 = 0
        boton4 = 0
        boton5 = 0
        boton6 = 0
        boton7 = 0
        boton8 = 0
        boton9 = 0
        boton10 = 0
        boton11 = 0
        boton12 = 0
        boton13 = 0
        boton14 = 0
        boton15 = 0
        boton16 = 0
        boton17 = 0
        boton18 = 1
        Verificar_Click()
        verificador_selecc_cuotas = 1
        Me.txtBuscar_Producto.Focus()
    End Sub

    Private Sub txtBusquedaporCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusquedaporCodigo.TextChanged
        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM TP_PRODUCTO WHERE CODIGO LIKE '%" & Trim(Me.txtBusquedaporCodigo.Text) & "%'"
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

    Private Sub MonthCalendar1_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        verificador_fecha = 1
        fecha_vencimiento = MonthCalendar1.SelectionRange.Start.ToShortDateString()
    End Sub

    Private Sub txtEntregaInicial_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtEntregaInicial.Leave
        If Me.txtEntregaInicial.Text = "" Then
            Me.txtEntregaInicial.Text = CInt(0)
        End If
    End Sub
End Class