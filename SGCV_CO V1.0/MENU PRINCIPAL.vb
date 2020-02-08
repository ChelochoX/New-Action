Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System
Imports System.IO
Imports System.Diagnostics

Public Class MENU_PRINCIPAL

    Dim DaDetPermiso As New SqlClient.SqlDataAdapter
    Dim DsDetPermiso As New Data.DataSet

    Private Sub REGISTROCLIENTESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REGISTRO_CLIENTES.Click
        Dim FRM_REGISTROCLIENTES As New REGISTRO_CLIENTE
        FRM_REGISTROCLIENTES.Show()

    End Sub

    Private Sub REGISTRODEPRODUCTOSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REGISTRO_DE_PRODUCTOS.Click
        Dim FRM_REGISTROPRODUCTOS As New REGISTRO_PRODUCTOS
        FRM_REGISTROPRODUCTOS.Show()

    End Sub

    Private Sub MODIFICARPRECIOSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MODIFICAR_PRECIOS.Click
        Dim FRM_MODIFICARPRECIOS As New GESTIONAR_PRECIO_PRODUCTOS
        FRM_MODIFICARPRECIOS.Show()

    End Sub

    Private Sub REGISTRODEPROVEEDORESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REGISTRO_DE_PROVEEDORES.Click
        Dim FRM_REGISTROPROVEEDORES As New REGISTRO_PROVEEDOR
        FRM_REGISTROPROVEEDORES.Show()

    End Sub

    Private Sub VISUALIZARSTOCKToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VISUALIZAR_STOCK.Click
        Dim FRM_VISUALIZARSTOCK As New VISUALIZAR_STOCK_EN_DEPOSITO
        FRM_VISUALIZARSTOCK.Show()

    End Sub

    Private Sub COMPRASDEPROVEEDORESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles COMPRAS_DE_PROVEEDORES.Click
        Dim FRM_COMPRASDEPROVEEDOR As New COMPRAS_DE_PROVEEDOR
        FRM_COMPRASDEPROVEEDOR.Show()

    End Sub

    Private Sub INGRESARCOMPRASToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles INGRESAR_COMPRAS.Click
        Dim FRM_INGRESARCOMPRAS As New RECEPCIO_COMPRAS
        FRM_INGRESARCOMPRAS.Show()

    End Sub

    Function estado_caja(ByVal a As String, ByVal b As Date) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM CP_CABECERA_CAJA WHERE ESTADO = '" & a & "' AND FECHA_APERTURA = '" & b & "'"
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

    Private Sub FACTURACIONToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FACTURACION.Click
        If estado_caja("HABILITADO", Today) = 0 Then
            MessageBox.Show("ESTADO DE CAJA CERRADO, DAR APERTURA DE CAJA", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim FRM_FACTURACION As New FACTURACION
            FRM_FACTURACION.Show()
            NEW_ACTION = 1
        End If
    End Sub

    Private Sub REIMPRESIONFACTURACIONESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REIMPRESION_FACTURACIONES.Click
        Dim FRM_REIMPRESIONFACTURACIONES As New RE_IMPRESION_DE_FACTURACIONES
        FRM_REIMPRESIONFACTURACIONES.Show()
    End Sub

    Private Sub AGREGARUSUARIOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AGREGAR_USUARIO.Click
        Dim FRM_USUARIO As New AGREGAR_USUARIOS
        FRM_USUARIO.Show()
    End Sub

    Private Sub HABILITARDESHABILITARROLESUSUARIOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HABILITAR_DESHABILITAR_ROLES_USUARIO.Click
        Dim FRM_ROLESUSUARIO As New ROLES_DE_USUARIO
        FRM_ROLESUSUARIO.Show()

    End Sub

    Private Sub EMPRESAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EMPRESA.Click
        Dim FRM_EMPRESA As New EMPRESA
        FRM_EMPRESA.Show()
    End Sub

    Private Sub APERTURACIERREToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles APERTURA_CIERRE.Click
        Dim FRM_APERTURACIERRECAJA As New DETALLES_DE_CAJA
        FRM_APERTURACIERRECAJA.Show()
    End Sub

    Private Sub VERCUENTACLIENTEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VER_CUENTA_CLIENTE.Click
        Dim FRM_CUENTACLIENTE As New VISUALIZAR_CUENTA_CLIENTE
        FRM_CUENTACLIENTE.Show()
    End Sub

    Private Sub GESTIONARCOBROToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GESTIONAR_COBRO.Click
        If estado_caja("HABILITADO", Today) = 0 Then
            MessageBox.Show("ESTADO DE CAJA CERRADO, DAR APERTURA DE CAJA", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim FRM_GESTIONCOBRO As New GESTIONAR_COBRO
            FRM_GESTIONCOBRO.Show()
        End If

    End Sub
    Function paraCategoria(ByVal a As String) As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT CATEGORIA_USUARIO FROM CONFIG_USUARIO WHERE DATOS_PERSONALES = '" & a & "'"
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
    Function paraFUNCIONES_HABILITADAS_USUARIO_(ByVal a As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COD_CAB_PERMISOS FROM CONFIG_CABECERA_PERMISOS WHERE CATEGORIA = '" & a & "'"
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
            sel = "SELECT * FROM CONFIG_DETALLE_PERMISOS"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaDetPermiso = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsDetPermiso = New Data.DataSet
            DaDetPermiso.Fill(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub

    Function paraFUNCIONES_HABILITADAS_USUARIO(ByVal a As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COD_CAB_PERMISOS FROM CONFIG_CABECERA_PERMISOS WHERE CATEGORIA = '" & a & "'"
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
    Function ELIMINAR_ESTADO_DEL_DIA(ByVal b As Date) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "DELETE FROM CP_ESTADO_CAJA WHERE FECHA_ESTADO = '" & b & "'"
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

    Sub Inhabilitar_Funciones()
        Me.REGISTRO_CLIENTES.Enabled = False
        Me.REGISTRO_CLIENTES.Visible = False
        Me.REPORTE_CLIENTES.Enabled = False
        Me.REPORTE_CLIENTES.Visible = False
        Me.REGISTRO_DE_PRODUCTOS.Enabled = False
        Me.REGISTRO_DE_PRODUCTOS.Visible = False
        Me.MODIFICAR_PRECIOS.Enabled = False
        Me.MODIFICAR_PRECIOS.Visible = False
        Me.APLICAR_IMAGEN_A_PRODUCTO.Enabled = False
        Me.APLICAR_IMAGEN_A_PRODUCTO.Visible = False
        Me.PANEL_DE_PRECIOS_PROMO_PRODUCTOS.Enabled = False
        Me.PANEL_DE_PRECIOS_PROMO_PRODUCTOS.Visible = False
        Me.REGISTRO_DE_PROVEEDORES.Enabled = False
        Me.REGISTRO_DE_PROVEEDORES.Visible = False
        Me.VER_PRODUCTOS_EN_DEPOSITO.Enabled = False
        Me.VER_PRODUCTOS_EN_DEPOSITO.Visible = False
        Me.TRASLADO_DE_PRODUCTOS.Enabled = False
        Me.TRASLADO_DE_PRODUCTOS.Visible = False
        Me.VISUALIZAR_STOCK.Enabled = False
        Me.VISUALIZAR_STOCK.Visible = False
        Me.COMPRAS_DE_PROVEEDORES.Enabled = False
        Me.COMPRAS_DE_PROVEEDORES.Visible = False
        Me.INGRESAR_COMPRAS.Enabled = False
        Me.INGRESAR_COMPRAS.Visible = False
        Me.FACTURACION.Enabled = False
        Me.FACTURACION.Visible = False
        Me.REIMPRESION_FACTURACIONES.Enabled = False
        Me.REIMPRESION_FACTURACIONES.Visible = False
        Me.ANULAR_FACTURACION.Enabled = False
        Me.ANULAR_FACTURACION.Visible = False
        Me.REPORTE_DOCUMENTO_DE_FACTURACION.Enabled = False
        Me.REPORTE_DOCUMENTO_DE_FACTURACION.Visible = False
        Me.APERTURA_CIERRE.Enabled = False
        Me.APERTURA_CIERRE.Visible = False
        Me.VER_CUENTA_CLIENTE.Enabled = False
        Me.VER_CUENTA_CLIENTE.Visible = False
        Me.GESTIONAR_COBRO.Enabled = False
        Me.GESTIONAR_COBRO.Visible = False
        Me.REPORTE_RENDICION_DE_CAJA.Enabled = False
        Me.REPORTE_RENDICION_DE_CAJA.Visible = False
        Me.ANULAR_RECIBO.Enabled = False
        Me.ANULAR_RECIBO.Visible = False
        Me.VER_DOCUMENTOS_ANULADOS.Enabled = False
        Me.VER_DOCUMENTOS_ANULADOS.Visible = False
        Me.SEGUIMIENTO_COBRANZA_CLIENTE.Enabled = False
        Me.SEGUIMIENTO_COBRANZA_CLIENTE.Visible = False
        Me.ANULAR_RECIBO.Enabled = False
        Me.ANULAR_RECIBO.Visible = False
        Me.REPORTE_DE_RECIBOS_DE_DINERO.Enabled = False
        Me.REPORTE_DE_RECIBOS_DE_DINERO.Visible = False
        Me.SEGUIMIENTO_COBRANZA_CLIENTE.Enabled = False
        Me.SEGUIMIENTO_COBRANZA_CLIENTE.Visible = False
        Me.REPORTE_SEGUIMIENTO_COBRANZA.Enabled = False
        Me.REPORTE_SEGUIMIENTO_COBRANZA.Visible = False
        Me.REPORTE_CLIENTES_CON_ATRASO.Enabled = False
        Me.REPORTE_CLIENTES_CON_ATRASO.Visible = False
        Me.UTILIDAD_COSTOVsVENTA.Enabled = False
        Me.UTILIDAD_COSTOVsVENTA.Visible = False
        Me.ESTADISTICAS_DE_CUENTAS_POR_COBRAR.Enabled = False
        Me.ESTADISTICAS_DE_CUENTAS_POR_COBRAR.Visible = False
        Me.ROTACION_DE_MERCADERIAS.Enabled = False
        Me.ROTACION_DE_MERCADERIAS.Visible = False
        Me.AGREGAR_USUARIO.Enabled = False
        Me.AGREGAR_USUARIO.Visible = False
        Me.HABILITAR_DESHABILITAR_ROLES_USUARIO.Enabled = False
        Me.HABILITAR_DESHABILITAR_ROLES_USUARIO.Visible = False
        Me.EMPRESA.Enabled = False
        Me.EMPRESA.Visible = False
        Me.FACTURACIONES_SIN_DOCUMENTO.Enabled = False
        Me.FACTURACIONES_SIN_DOCUMENTO.Visible = False
        Me.ESTADO_DE_DOCUMENTOS.Enabled = False
        Me.ESTADO_DE_DOCUMENTOS.Visible = False
        Me.GESTIONAR_INTERES_PARACUOTAS.Enabled = False
        Me.GESTIONAR_INTERES_PARACUOTAS.Visible = False
         
    End Sub
    Private Sub MENU_PRINCIPAL_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Cargar_Datos()
        lbHora.Text = Date.Now.ToLongTimeString
        Timer1.Start()
        Me.lbFechaActual.Text = Today
        Me.lbUsuarioActivo.Text = usuario_AUX
        Inicio_Sesion = Me.lbFechaActual.Text

        'INHABILITAR FUNCIONES
        Inhabilitar_Funciones()

        'HABILITAR FUNCIONES PARA USUARIOS
        Dim categoria_de_usuario As String
        categoria_de_usuario = Trim(paraCategoria(usuario_AUX))
        Dim COD_FUNCIONES As Integer
        COD_FUNCIONES = paraFUNCIONES_HABILITADAS_USUARIO_(categoria_de_usuario)

        For i = 0 To Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Count - 1
            Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position = i

            If COD_FUNCIONES = Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("COD_CAB_PERMISOS").ToString Then
                '*************************************************************************************************************************
                If ("REGISTRO_CLIENTES") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("FUNCIONES").ToString) Then
                    If ("HABILITADO") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("ESTADO").ToString) Then
                        Me.REGISTRO_CLIENTES.Enabled = True
                        Me.REGISTRO_CLIENTES.Visible = True
                    Else
                        Me.REGISTRO_CLIENTES.Enabled = False
                        Me.REGISTRO_CLIENTES.Visible = False
                    End If
                End If
                '*************************************************************************************************************************
                If ("REPORTE_CLIENTES") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("FUNCIONES").ToString) Then
                    If ("HABILITADO") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("ESTADO").ToString) Then
                        Me.REPORTE_CLIENTES.Enabled = True
                        Me.REPORTE_CLIENTES.Visible = True
                    Else
                        Me.REPORTE_CLIENTES.Enabled = False
                        Me.REPORTE_CLIENTES.Visible = False
                    End If
                End If
                '*************************************************************************************************************************
                If ("REGISTRO_DE_PRODUCTOS") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("FUNCIONES").ToString) Then
                    If ("HABILITADO") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("ESTADO").ToString) Then
                        Me.REGISTRO_DE_PRODUCTOS.Enabled = True
                        Me.REGISTRO_DE_PRODUCTOS.Visible = True
                    Else
                        Me.REGISTRO_DE_PRODUCTOS.Enabled = False
                        Me.REGISTRO_DE_PRODUCTOS.Visible = False
                    End If
                End If
                '*************************************************************************************************************************
                If ("MODIFICAR_PRECIOS") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("FUNCIONES").ToString) Then
                    If ("HABILITADO") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("ESTADO").ToString) Then
                        Me.MODIFICAR_PRECIOS.Enabled = True
                        Me.MODIFICAR_PRECIOS.Visible = True
                    Else
                        Me.MODIFICAR_PRECIOS.Enabled = False
                        Me.MODIFICAR_PRECIOS.Visible = False
                    End If
                End If
                '*************************************************************************************************************************
                If ("APLICAR_IMAGEN_A_PRODUCTO") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("FUNCIONES").ToString) Then
                    If ("HABILITADO") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("ESTADO").ToString) Then
                        Me.APLICAR_IMAGEN_A_PRODUCTO.Enabled = True
                        Me.APLICAR_IMAGEN_A_PRODUCTO.Visible = True
                    Else
                        Me.APLICAR_IMAGEN_A_PRODUCTO.Enabled = False
                        Me.APLICAR_IMAGEN_A_PRODUCTO.Visible = False
                    End If
                End If
                '*************************************************************************************************************************
                If ("PANEL_DE_PRECIOS_PROMO_PRODUCTOS") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("FUNCIONES").ToString) Then
                    If ("HABILITADO") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("ESTADO").ToString) Then
                        Me.PANEL_DE_PRECIOS_PROMO_PRODUCTOS.Enabled = True
                        Me.PANEL_DE_PRECIOS_PROMO_PRODUCTOS.Visible = True
                    Else
                        Me.PANEL_DE_PRECIOS_PROMO_PRODUCTOS.Enabled = False
                        Me.PANEL_DE_PRECIOS_PROMO_PRODUCTOS.Visible = False
                    End If
                End If
                '*************************************************************************************************************************
                If ("REGISTRO_DE_PROVEEDORES") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("FUNCIONES").ToString) Then
                    If ("HABILITADO") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("ESTADO").ToString) Then
                        Me.REGISTRO_DE_PROVEEDORES.Enabled = True
                        Me.REGISTRO_DE_PROVEEDORES.Visible = True
                    Else
                        Me.REGISTRO_DE_PROVEEDORES.Enabled = False
                        Me.REGISTRO_DE_PROVEEDORES.Visible = False
                    End If
                End If
                '*************************************************************************************************************************
                If ("VER_PRODUCTOS_EN_DEPOSITO") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("FUNCIONES").ToString) Then
                    If ("HABILITADO") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("ESTADO").ToString) Then
                        Me.VER_PRODUCTOS_EN_DEPOSITO.Enabled = True
                        Me.VER_PRODUCTOS_EN_DEPOSITO.Visible = True
                    Else
                        Me.VER_PRODUCTOS_EN_DEPOSITO.Enabled = False
                        Me.VER_PRODUCTOS_EN_DEPOSITO.Visible = False
                    End If
                End If
                '*************************************************************************************************************************
                If ("TRASLADO_DE_PRODUCTOS") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("FUNCIONES").ToString) Then
                    If ("HABILITADO") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("ESTADO").ToString) Then
                        Me.TRASLADO_DE_PRODUCTOS.Enabled = True
                        Me.TRASLADO_DE_PRODUCTOS.Visible = True
                    Else
                        Me.TRASLADO_DE_PRODUCTOS.Enabled = False
                        Me.TRASLADO_DE_PRODUCTOS.Visible = False
                    End If
                End If
                '*************************************************************************************************************************
                If ("VISUALIZAR_STOCK") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("FUNCIONES").ToString) Then
                    If ("HABILITADO") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("ESTADO").ToString) Then
                        Me.VISUALIZAR_STOCK.Enabled = True
                        Me.VISUALIZAR_STOCK.Visible = True
                    Else
                        Me.VISUALIZAR_STOCK.Enabled = False
                        Me.VISUALIZAR_STOCK.Visible = False
                    End If
                End If
                '*************************************************************************************************************************
                If ("COMPRAS_DE_PROVEEDORES") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("FUNCIONES").ToString) Then
                    If ("HABILITADO") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("ESTADO").ToString) Then
                        Me.COMPRAS_DE_PROVEEDORES.Enabled = True
                        Me.COMPRAS_DE_PROVEEDORES.Visible = True
                    Else
                        Me.COMPRAS_DE_PROVEEDORES.Enabled = False
                        Me.COMPRAS_DE_PROVEEDORES.Visible = False
                    End If
                End If
                '*************************************************************************************************************************
                If ("INGRESAR_COMPRAS") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("FUNCIONES").ToString) Then
                    If ("HABILITADO") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("ESTADO").ToString) Then
                        Me.INGRESAR_COMPRAS.Enabled = True
                        Me.INGRESAR_COMPRAS.Visible = True
                    Else
                        Me.INGRESAR_COMPRAS.Enabled = False
                        Me.INGRESAR_COMPRAS.Visible = False
                    End If
                End If
                '*************************************************************************************************************************
                If ("FACTURACION") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("FUNCIONES").ToString) Then
                    If ("HABILITADO") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("ESTADO").ToString) Then
                        Me.FACTURACION.Enabled = True
                        Me.FACTURACION.Visible = True
                    Else
                        Me.FACTURACION.Enabled = False
                        Me.FACTURACION.Visible = False
                    End If
                End If
                '*************************************************************************************************************************
                If ("REIMPRESION_FACTURACIONES") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("FUNCIONES").ToString) Then
                    If ("HABILITADO") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("ESTADO").ToString) Then
                        Me.REIMPRESION_FACTURACIONES.Enabled = True
                        Me.REIMPRESION_FACTURACIONES.Visible = True
                    Else
                        Me.REIMPRESION_FACTURACIONES.Enabled = False
                        Me.REIMPRESION_FACTURACIONES.Visible = False
                    End If
                End If
                '*************************************************************************************************************************
                If ("ANULAR_FACTURACION") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("FUNCIONES").ToString) Then
                    If ("HABILITADO") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("ESTADO").ToString) Then
                        Me.ANULAR_FACTURACION.Enabled = True
                        Me.ANULAR_FACTURACION.Visible = True
                    Else
                        Me.ANULAR_FACTURACION.Enabled = False
                        Me.ANULAR_FACTURACION.Visible = False
                    End If
                End If
                '*************************************************************************************************************************
                If ("REPORTE_DOCUMENTO_DE_FACTURACION") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("FUNCIONES").ToString) Then
                    If ("HABILITADO") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("ESTADO").ToString) Then
                        Me.REPORTE_DOCUMENTO_DE_FACTURACION.Enabled = True
                        Me.REPORTE_DOCUMENTO_DE_FACTURACION.Visible = True
                    Else
                        Me.REPORTE_DOCUMENTO_DE_FACTURACION.Enabled = False
                        Me.REPORTE_DOCUMENTO_DE_FACTURACION.Visible = False
                    End If
                End If
                '*************************************************************************************************************************

                If ("APERTURA_CIERRE") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("FUNCIONES").ToString) Then
                    If ("HABILITADO") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("ESTADO").ToString) Then
                        Me.APERTURA_CIERRE.Enabled = True
                        Me.APERTURA_CIERRE.Visible = True
                    Else
                        Me.APERTURA_CIERRE.Enabled = False
                        Me.APERTURA_CIERRE.Visible = False
                    End If
                End If
                '**5***********************************************************************************************************************
                If ("VER_CUENTA_CLIENTE") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("FUNCIONES").ToString) Then
                    If ("HABILITADO") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("ESTADO").ToString) Then
                        Me.VER_CUENTA_CLIENTE.Enabled = True
                        Me.VER_CUENTA_CLIENTE.Visible = True
                    Else
                        Me.VER_CUENTA_CLIENTE.Enabled = False
                        Me.VER_CUENTA_CLIENTE.Visible = False
                    End If
                End If
                '*************************************************************************************************************************
                If ("GESTIONAR_COBRO") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("FUNCIONES").ToString) Then
                    If ("HABILITADO") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("ESTADO").ToString) Then
                        Me.GESTIONAR_COBRO.Enabled = True
                        Me.GESTIONAR_COBRO.Visible = True
                    Else
                        Me.GESTIONAR_COBRO.Enabled = False
                        Me.GESTIONAR_COBRO.Visible = False
                    End If
                End If
                '*************************************************************************************************************************
                If ("REPORTE_RENDICION_DE_CAJA") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("FUNCIONES").ToString) Then
                    If ("HABILITADO") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("ESTADO").ToString) Then
                        Me.REPORTE_RENDICION_DE_CAJA.Enabled = True
                        Me.REPORTE_RENDICION_DE_CAJA.Visible = True
                    Else
                        Me.REPORTE_RENDICION_DE_CAJA.Enabled = False
                        Me.REPORTE_RENDICION_DE_CAJA.Visible = False
                    End If
                End If
                '*************************************************************************************************************************
                If ("ANULAR_RECIBO") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("FUNCIONES").ToString) Then
                    If ("HABILITADO") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("ESTADO").ToString) Then
                        Me.ANULAR_RECIBO.Enabled = True
                        Me.ANULAR_RECIBO.Visible = True
                    Else
                        Me.ANULAR_RECIBO.Enabled = False
                        Me.ANULAR_RECIBO.Visible = False
                    End If
                End If
                '*************************************************************************************************************************
                If ("VER_DOCUMENTOS_ANULADOS") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("FUNCIONES").ToString) Then
                    If ("HABILITADO") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("ESTADO").ToString) Then
                        Me.VER_DOCUMENTOS_ANULADOS.Enabled = True
                        Me.VER_DOCUMENTOS_ANULADOS.Visible = True
                    Else
                        Me.VER_DOCUMENTOS_ANULADOS.Enabled = False
                        Me.VER_DOCUMENTOS_ANULADOS.Visible = False
                    End If
                End If
                '*************************************************************************************************************************
                If ("REPORTE_DE_RECIBOS_DE_DINERO") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("FUNCIONES").ToString) Then
                    If ("HABILITADO") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("ESTADO").ToString) Then
                        Me.REPORTE_DE_RECIBOS_DE_DINERO.Enabled = True
                        Me.REPORTE_DE_RECIBOS_DE_DINERO.Visible = True
                    Else
                        Me.REPORTE_DE_RECIBOS_DE_DINERO.Enabled = False
                        Me.REPORTE_DE_RECIBOS_DE_DINERO.Visible = False
                    End If
                End If
                '*************************************************************************************************************************
                If ("SEGUIMIENTO_COBRANZA_CLIENTE") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("FUNCIONES").ToString) Then
                    If ("HABILITADO") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("ESTADO").ToString) Then
                        Me.SEGUIMIENTO_COBRANZA_CLIENTE.Enabled = True
                        Me.SEGUIMIENTO_COBRANZA_CLIENTE.Visible = True
                    Else
                        Me.SEGUIMIENTO_COBRANZA_CLIENTE.Enabled = False
                        Me.SEGUIMIENTO_COBRANZA_CLIENTE.Visible = False
                    End If
                End If
                '*************************************************************************************************************************
                If ("REPORTE_SEGUIMIENTO_COBRANZA") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("FUNCIONES").ToString) Then
                    If ("HABILITADO") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("ESTADO").ToString) Then
                        Me.REPORTE_SEGUIMIENTO_COBRANZA.Enabled = True
                        Me.REPORTE_SEGUIMIENTO_COBRANZA.Visible = True
                    Else
                        Me.REPORTE_SEGUIMIENTO_COBRANZA.Enabled = False
                        Me.REPORTE_SEGUIMIENTO_COBRANZA.Visible = False
                    End If
                End If
                '*************************************************************************************************************************
                If ("REPORTE_CLIENTES_CON_ATRASO") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("FUNCIONES").ToString) Then
                    If ("HABILITADO") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("ESTADO").ToString) Then
                        Me.REPORTE_CLIENTES_CON_ATRASO.Enabled = True
                        Me.REPORTE_CLIENTES_CON_ATRASO.Visible = True
                    Else
                        Me.REPORTE_CLIENTES_CON_ATRASO.Enabled = False
                        Me.REPORTE_CLIENTES_CON_ATRASO.Visible = False
                    End If
                End If
                '*************************************************************************************************************************

                If ("UTILIDAD_COSTOVsVENTA") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("FUNCIONES").ToString) Then
                    If ("HABILITADO") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("ESTADO").ToString) Then
                        Me.UTILIDAD_COSTOVsVENTA.Enabled = True
                        Me.UTILIDAD_COSTOVsVENTA.Visible = True
                    Else
                        Me.UTILIDAD_COSTOVsVENTA.Enabled = False
                        Me.UTILIDAD_COSTOVsVENTA.Visible = False
                    End If
                End If
                '*************************************************************************************************************************
                If ("ESTADISTICAS_DE_CUENTAS_POR_COBRAR") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("FUNCIONES").ToString) Then
                    If ("HABILITADO") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("ESTADO").ToString) Then
                        Me.ESTADISTICAS_DE_CUENTAS_POR_COBRAR.Enabled = True
                        Me.ESTADISTICAS_DE_CUENTAS_POR_COBRAR.Visible = True
                    Else
                        Me.ESTADISTICAS_DE_CUENTAS_POR_COBRAR.Enabled = False
                        Me.ESTADISTICAS_DE_CUENTAS_POR_COBRAR.Visible = False
                    End If
                End If
                '*************************************************************************************************************************
                If ("ROTACION_DE_MERCADERIAS") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("FUNCIONES").ToString) Then
                    If ("HABILITADO") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("ESTADO").ToString) Then
                        Me.ROTACION_DE_MERCADERIAS.Enabled = True
                        Me.ROTACION_DE_MERCADERIAS.Visible = True
                    Else
                        Me.ROTACION_DE_MERCADERIAS.Enabled = False
                        Me.ROTACION_DE_MERCADERIAS.Visible = False
                    End If
                End If
                '**5***********************************************************************************************************************
                If ("AGREGAR_USUARIO") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("FUNCIONES").ToString) Then
                    If ("HABILITADO") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("ESTADO").ToString) Then
                        Me.AGREGAR_USUARIO.Enabled = True
                        Me.AGREGAR_USUARIO.Visible = True
                    Else
                        Me.AGREGAR_USUARIO.Enabled = False
                        Me.AGREGAR_USUARIO.Visible = False
                    End If
                End If
                '*************************************************************************************************************************
                If ("HABILITAR_DESHABILITAR_ROLES_USUARIO") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("FUNCIONES").ToString) Then
                    If ("HABILITADO") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("ESTADO").ToString) Then
                        Me.HABILITAR_DESHABILITAR_ROLES_USUARIO.Enabled = True
                        Me.HABILITAR_DESHABILITAR_ROLES_USUARIO.Visible = True
                    Else
                        Me.HABILITAR_DESHABILITAR_ROLES_USUARIO.Enabled = False
                        Me.HABILITAR_DESHABILITAR_ROLES_USUARIO.Visible = False
                    End If
                End If
                '*************************************************************************************************************************
                If ("EMPRESA") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("FUNCIONES").ToString) Then
                    If ("HABILITADO") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("ESTADO").ToString) Then
                        Me.EMPRESA.Enabled = True
                        Me.EMPRESA.Visible = True
                    Else
                        Me.EMPRESA.Enabled = False
                        Me.EMPRESA.Visible = False
                    End If
                End If
                '*************************************************************************************************************************
                If ("FACTURACIONES_SIN_DOCUMENTO") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("FUNCIONES").ToString) Then
                    If ("HABILITADO") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("ESTADO").ToString) Then
                        Me.FACTURACIONES_SIN_DOCUMENTO.Enabled = True
                        Me.FACTURACIONES_SIN_DOCUMENTO.Visible = True
                    Else
                        Me.FACTURACIONES_SIN_DOCUMENTO.Enabled = False
                        Me.FACTURACIONES_SIN_DOCUMENTO.Visible = False
                    End If
                End If
                '*************************************************************************************************************************
                If ("ESTADO_DE_DOCUMENTOS") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("FUNCIONES").ToString) Then
                    If ("HABILITADO") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("ESTADO").ToString) Then
                        Me.ESTADO_DE_DOCUMENTOS.Enabled = True
                        Me.ESTADO_DE_DOCUMENTOS.Visible = True
                    Else
                        Me.ESTADO_DE_DOCUMENTOS.Enabled = False
                        Me.ESTADO_DE_DOCUMENTOS.Visible = False
                    End If
                End If
                '*************************************************************************************************************************
                If ("GESTIONAR_INTERES_PARACUOTAS") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("FUNCIONES").ToString) Then
                    If ("HABILITADO") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("ESTADO").ToString) Then
                        Me.GESTIONAR_INTERES_PARACUOTAS.Enabled = True
                        Me.GESTIONAR_INTERES_PARACUOTAS.Visible = True
                    Else
                        Me.GESTIONAR_INTERES_PARACUOTAS.Enabled = False
                        Me.GESTIONAR_INTERES_PARACUOTAS.Visible = False
                    End If
                End If
                '*************************************************************************************************************************
                If ("RE_IMPRESION_DE_RECIBOS_DE_DINERO") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("FUNCIONES").ToString) Then
                    If ("HABILITADO") = Trim(Me.DsDetPermiso.Tables("CONFIG_DETALLE_PERMISOS").Rows(Me.BindingContext(Me.DsDetPermiso, "CONFIG_DETALLE_PERMISOS").Position).Item("ESTADO").ToString) Then
                        Me.RE_IMPRESION_DE_RECIBOS_DE_DINERO.Enabled = True
                        Me.RE_IMPRESION_DE_RECIBOS_DE_DINERO.Visible = True
                    Else
                        Me.RE_IMPRESION_DE_RECIBOS_DE_DINERO.Enabled = False
                        Me.RE_IMPRESION_DE_RECIBOS_DE_DINERO.Visible = False
                    End If
                End If
                '*************************************************************************************************************************
            End If
        Next

    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.lbHora.Text = Date.Now.ToLongTimeString
    End Sub

    Private Sub VERDOCUMENTOSANULADOSToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VER_DOCUMENTOS_ANULADOS.Click
        Dim FRM_VERANULADOS As New VER_DOCUMENTOS_ANULADOS
        FRM_VERANULADOS.Show()
    End Sub

    Private Sub SEGUIMIENTOCOBRANZACLIENTEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SEGUIMIENTO_COBRANZA_CLIENTE.Click
        Dim FRM_SEGUIM_COBRANZA As New SEGUIMIENTO_COBRANZA
        FRM_SEGUIM_COBRANZA.Show()
    End Sub

    Private Sub REPORTESEGUIMIENTOCOBRANZAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REPORTE_SEGUIMIENTO_COBRANZA.Click
        Dim FRM_REPORTE_SEGCO As New REPORTE_SEGUIMIENTO_DE_COBRANZA
        FRM_REPORTE_SEGCO.Show()
    End Sub
    Private Sub ANULARFACTURACIONToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ANULAR_FACTURACION.Click
        If estado_caja("HABILITADO", Today) = 0 Then
            MessageBox.Show("ESTADO DE CAJA CERRADO, DAR APERTURA DE CAJA", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim FRM_ANULARFACTURACION As New ANULAR_FACTURACION
            FRM_ANULARFACTURACION.Show()
        End If

    End Sub
    Private Sub UTILIDADCOSTOVsVENTAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UTILIDAD_COSTOVsVENTA.Click
        Dim FRM_UTILIDAD_COMPRAVSVENTA As New UTILIDAD_COMPRA_VS_VENTA
        FRM_UTILIDAD_COMPRAVSVENTA.Show()
    End Sub

    Private Sub ESTADISTICASDECUENTASPORCOBRARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ESTADISTICAS_DE_CUENTAS_POR_COBRAR.Click
        Dim FRM_ESTADISTICA_DEUDA_PAGO As New ESTADISTICAS_CUENTAS_POR_COBRAR
        FRM_ESTADISTICA_DEUDA_PAGO.Show()

    End Sub

    Private Sub ROTACIONDEMERCADERIASToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ROTACION_DE_MERCADERIAS.Click
        Dim FRM_ROTACION_MERCADERIA As New ROTACION_DE_MERCADERIAS
        FRM_ROTACION_MERCADERIA.Show()
    End Sub

    Private Sub CERRARToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CERRARToolStripMenuItem.Click

        If (MessageBox.Show("DESEA CERRAR APLICACION?", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.YesNo, MessageBoxIcon.Information)) = DialogResult.Yes Then
            If estado_caja("HABILITADO", Today) = 1 Then
                MessageBox.Show("ESTADO DE CAJA ABIERTO, GENERAR RENDICION DE CAJA", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Try
                    conectar()
                    Dim sel As String
                    sel = "UPDATE CONFIG_INICIO_SESION SET ESTADO = '" & "CERRADO" & "'" & _
                    "WHERE USUARIO = '" & usuario_AUX & "' AND " & _
                    "FECHA_INICIO = '" & Today & "'"
                    cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                    SQLconexion.Open()
                    Dim t As Integer = CInt(cmm.ExecuteScalar())
                    cmm.Dispose()
                    SQLconexion.Close()

                Catch ex As SqlClient.SqlException
                    MsgBox(ex.Message())
                    SQLconexion.Close()
                End Try

                Application.Exit()
            End If
        End If

    End Sub

    Private Sub ANULAR_RECIBO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ANULAR_RECIBO.Click
        If estado_caja("HABILITADO", Today) = 0 Then
            MessageBox.Show("ESTADO DE CAJA CERRADO, DAR APERTURA DE CAJA", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Dim FRM_ANULARPROCESOS As New ANULAR_RECIBOS
            FRM_ANULARPROCESOS.Show()
        End If
    End Sub

    Private Sub REPORTERENDICIONDECAJAToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REPORTE_RENDICION_DE_CAJA.Click
        Dim FRM_RENDICION_CAJA As New REPORTE_RENDICION_CAJA
        FRM_RENDICION_CAJA.Show()
    End Sub

    Private Sub FACTURACIONESSINDOCUMENTOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FACTURACIONES_SIN_DOCUMENTO.Click
        Dim FRM_FACTURACIONES_SIN_DOCUMENTO As New FACTURACIONES_SON_DOCUMENTOS
        FRM_FACTURACIONES_SIN_DOCUMENTO.Show()
    End Sub

    Private Sub REPORTECLIENTESToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REPORTE_CLIENTES.Click
        Dim FRM_REPORTE_CLIENTES As New REPORTE_CLIENTES
        FRM_REPORTE_CLIENTES.Show()
    End Sub

    Private Sub REPORTE_CLIENTES_CON_ATRASO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REPORTE_CLIENTES_CON_ATRASO.Click
        Dim FRM_REPORTE_CLIENTE_CONATRASOS As New REPORTE_CLIENTES_CON_ATRASO
        FRM_REPORTE_CLIENTE_CONATRASOS.Show()
    End Sub

    Private Sub TRASLADO_DE_PRODUCTOS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TRASLADO_DE_PRODUCTOS.Click
        Dim FRM_TRASLADO_PRODUCTOS As New GESTIONAR_TRASLADO_DE_PRODUCTOS
        FRM_TRASLADO_PRODUCTOS.Show()
    End Sub

    Private Sub ESTADODEDOCUMENTOSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ESTADO_DE_DOCUMENTOS.Click
        Dim FRM_ESTADO_DOCUMENTOS As New TIMBRADO_DOCUMENTOS
        FRM_ESTADO_DOCUMENTOS.Show()
    End Sub

    Private Sub REPORTEDOCUMENTODEFACTURACIONToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REPORTE_DOCUMENTO_DE_FACTURACION.Click
        Dim FRM_REPORTE_FACTURACION As New VISUALIZAR_FACTURACIONES
        FRM_REPORTE_FACTURACION.Show()
    End Sub

    Private Sub REPORTEDERECIBOSDEDINEROToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles REPORTE_DE_RECIBOS_DE_DINERO.Click
        Dim FRM_EPORTE_RECIBOS As New REPORTE_DE_RECIBO_DE_DINERO
        FRM_EPORTE_RECIBOS.Show()
    End Sub

    Private Sub VERPRODUCTOSENDEPOSITOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VER_PRODUCTOS_EN_DEPOSITO.Click
        Dim FRM_VER_PRODUCTOS_ENSTOCK As New VER_PRODUCTOS_EN_STOCK
        FRM_VER_PRODUCTOS_ENSTOCK.Show()

    End Sub

    Private Sub DATOSPARACONTACTOSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DATOS_PARA_CONTACTOS.Click
        Dim FORM_SOPORTE_SISTEMA As New soporte
        FORM_SOPORTE_SISTEMA.Show()

    End Sub

    Private Sub APLICARIMAGENAPRODUCTOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles APLICAR_IMAGEN_A_PRODUCTO.Click
        Dim FORM_APLICAR_IMAGEN As New ASIGNAR_IMAGEN_A_LOS_PRODUCTOS
        FORM_APLICAR_IMAGEN.Show()
    End Sub

    Private Sub PANELDEPRECIOSPROMOPRODUCTOSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PANEL_DE_PRECIOS_PROMO_PRODUCTOS.Click
        'Dim FORM_DETALLE_PRECIO_PROMO As New DETALLE_PRECIO___PROMO_PRODUCTOS
        'FORM_DETALLE_PRECIO_PROMO.Show()
    End Sub

    Private Sub GESTIONARINTERESPARACUOTASToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GESTIONAR_INTERES_PARACUOTAS.Click
        Dim FORM_GESTIONAR_INTERES_PARACUOTA As New GESTIONAR_INTERES_PARA_CREDITO
        FORM_GESTIONAR_INTERES_PARACUOTA.Show()

    End Sub

    Private Sub REToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RE_IMPRESION_DE_RECIBOS_DE_DINERO.Click
        Dim FORM_RE_IMPRESION_RECIBOSDINERO As New RE_IMPRESION_DE_RECIBOS_DE_DINERO
        FORM_RE_IMPRESION_RECIBOSDINERO.Show()
    End Sub

End Class