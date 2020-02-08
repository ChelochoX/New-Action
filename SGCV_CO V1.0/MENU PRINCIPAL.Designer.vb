<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MENU_PRINCIPAL
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CLIENTESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REGISTRO_CLIENTES = New System.Windows.Forms.ToolStripMenuItem()
        Me.REPORTE_CLIENTES = New System.Windows.Forms.ToolStripMenuItem()
        Me.PRODUCTOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REGISTRO_DE_PRODUCTOS = New System.Windows.Forms.ToolStripMenuItem()
        Me.MODIFICAR_PRECIOS = New System.Windows.Forms.ToolStripMenuItem()
        Me.APLICAR_IMAGEN_A_PRODUCTO = New System.Windows.Forms.ToolStripMenuItem()
        Me.PANEL_DE_PRECIOS_PROMO_PRODUCTOS = New System.Windows.Forms.ToolStripMenuItem()
        Me.PROVEEDORToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REGISTRO_DE_PROVEEDORES = New System.Windows.Forms.ToolStripMenuItem()
        Me.DEPOSITOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VER_PRODUCTOS_EN_DEPOSITO = New System.Windows.Forms.ToolStripMenuItem()
        Me.TRASLADO_DE_PRODUCTOS = New System.Windows.Forms.ToolStripMenuItem()
        Me.VISUALIZAR_STOCK = New System.Windows.Forms.ToolStripMenuItem()
        Me.COMPRASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.COMPRAS_DE_PROVEEDORES = New System.Windows.Forms.ToolStripMenuItem()
        Me.INGRESAR_COMPRAS = New System.Windows.Forms.ToolStripMenuItem()
        Me.FACTURACIONToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FACTURACION = New System.Windows.Forms.ToolStripMenuItem()
        Me.REIMPRESION_FACTURACIONES = New System.Windows.Forms.ToolStripMenuItem()
        Me.ANULAR_FACTURACION = New System.Windows.Forms.ToolStripMenuItem()
        Me.REPORTE_DOCUMENTO_DE_FACTURACION = New System.Windows.Forms.ToolStripMenuItem()
        Me.CAJAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.APERTURA_CIERRE = New System.Windows.Forms.ToolStripMenuItem()
        Me.VER_CUENTA_CLIENTE = New System.Windows.Forms.ToolStripMenuItem()
        Me.GESTIONAR_COBRO = New System.Windows.Forms.ToolStripMenuItem()
        Me.REPORTE_RENDICION_DE_CAJA = New System.Windows.Forms.ToolStripMenuItem()
        Me.VER_DOCUMENTOS_ANULADOS = New System.Windows.Forms.ToolStripMenuItem()
        Me.ANULAR_RECIBO = New System.Windows.Forms.ToolStripMenuItem()
        Me.REPORTE_DE_RECIBOS_DE_DINERO = New System.Windows.Forms.ToolStripMenuItem()
        Me.RE_IMPRESION_DE_RECIBOS_DE_DINERO = New System.Windows.Forms.ToolStripMenuItem()
        Me.COBRANZAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SEGUIMIENTO_COBRANZA_CLIENTE = New System.Windows.Forms.ToolStripMenuItem()
        Me.REPORTE_SEGUIMIENTO_COBRANZA = New System.Windows.Forms.ToolStripMenuItem()
        Me.REPORTE_CLIENTES_CON_ATRASO = New System.Windows.Forms.ToolStripMenuItem()
        Me.INFORMEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UTILIDAD_COSTOVsVENTA = New System.Windows.Forms.ToolStripMenuItem()
        Me.ESTADISTICAS_DE_CUENTAS_POR_COBRAR = New System.Windows.Forms.ToolStripMenuItem()
        Me.ROTACION_DE_MERCADERIAS = New System.Windows.Forms.ToolStripMenuItem()
        Me.ROLESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AGREGAR_USUARIO = New System.Windows.Forms.ToolStripMenuItem()
        Me.HABILITAR_DESHABILITAR_ROLES_USUARIO = New System.Windows.Forms.ToolStripMenuItem()
        Me.EMPRESA = New System.Windows.Forms.ToolStripMenuItem()
        Me.FACTURACIONES_SIN_DOCUMENTO = New System.Windows.Forms.ToolStripMenuItem()
        Me.ESTADO_DE_DOCUMENTOS = New System.Windows.Forms.ToolStripMenuItem()
        Me.GESTIONAR_INTERES_PARACUOTAS = New System.Windows.Forms.ToolStripMenuItem()
        Me.CONTACTOToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DATOS_PARA_CONTACTOS = New System.Windows.Forms.ToolStripMenuItem()
        Me.CERRARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lbFechaActual = New System.Windows.Forms.Label()
        Me.lbUsuarioActivo = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lbHora = New System.Windows.Forms.Label()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CLIENTESToolStripMenuItem, Me.PRODUCTOSToolStripMenuItem, Me.PROVEEDORToolStripMenuItem, Me.DEPOSITOToolStripMenuItem, Me.COMPRASToolStripMenuItem, Me.FACTURACIONToolStripMenuItem, Me.CAJAToolStripMenuItem, Me.COBRANZAToolStripMenuItem, Me.INFORMEToolStripMenuItem, Me.ROLESToolStripMenuItem, Me.CONTACTOToolStripMenuItem, Me.CERRARToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 3, 0, 3)
        Me.MenuStrip1.Size = New System.Drawing.Size(186, 733)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CLIENTESToolStripMenuItem
        '
        Me.CLIENTESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.REGISTRO_CLIENTES, Me.REPORTE_CLIENTES})
        Me.CLIENTESToolStripMenuItem.ForeColor = System.Drawing.Color.MediumBlue
        Me.CLIENTESToolStripMenuItem.Image = Global.SGCV_CO_V1._0.My.Resources.Resources.icons8_tipo_de_piel_de_conferencia_7_48
        Me.CLIENTESToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CLIENTESToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CLIENTESToolStripMenuItem.Name = "CLIENTESToolStripMenuItem"
        Me.CLIENTESToolStripMenuItem.Size = New System.Drawing.Size(169, 52)
        Me.CLIENTESToolStripMenuItem.Text = "CLIENTES"
        '
        'REGISTRO_CLIENTES
        '
        Me.REGISTRO_CLIENTES.Image = Global.SGCV_CO_V1._0.My.Resources.Resources.icons8_gestión_de_clientes_48
        Me.REGISTRO_CLIENTES.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.REGISTRO_CLIENTES.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.REGISTRO_CLIENTES.Name = "REGISTRO_CLIENTES"
        Me.REGISTRO_CLIENTES.Size = New System.Drawing.Size(228, 54)
        Me.REGISTRO_CLIENTES.Text = "REGISTRO CLIENTES"
        '
        'REPORTE_CLIENTES
        '
        Me.REPORTE_CLIENTES.Image = Global.SGCV_CO_V1._0.My.Resources.Resources.icons8_reporte_de_negocios_48
        Me.REPORTE_CLIENTES.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.REPORTE_CLIENTES.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.REPORTE_CLIENTES.Name = "REPORTE_CLIENTES"
        Me.REPORTE_CLIENTES.Size = New System.Drawing.Size(228, 54)
        Me.REPORTE_CLIENTES.Text = "REPORTE  CLIENTES"
        '
        'PRODUCTOSToolStripMenuItem
        '
        Me.PRODUCTOSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.REGISTRO_DE_PRODUCTOS, Me.MODIFICAR_PRECIOS, Me.APLICAR_IMAGEN_A_PRODUCTO, Me.PANEL_DE_PRECIOS_PROMO_PRODUCTOS})
        Me.PRODUCTOSToolStripMenuItem.ForeColor = System.Drawing.Color.MediumBlue
        Me.PRODUCTOSToolStripMenuItem.Image = Global.SGCV_CO_V1._0.My.Resources.Resources.icons8_producto_nuevo_48
        Me.PRODUCTOSToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PRODUCTOSToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PRODUCTOSToolStripMenuItem.Name = "PRODUCTOSToolStripMenuItem"
        Me.PRODUCTOSToolStripMenuItem.Size = New System.Drawing.Size(169, 52)
        Me.PRODUCTOSToolStripMenuItem.Text = "PRODUCTO"
        '
        'REGISTRO_DE_PRODUCTOS
        '
        Me.REGISTRO_DE_PRODUCTOS.Image = Global.SGCV_CO_V1._0.My.Resources.Resources.icons8_comprobado_48
        Me.REGISTRO_DE_PRODUCTOS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.REGISTRO_DE_PRODUCTOS.ImageTransparentColor = System.Drawing.Color.White
        Me.REGISTRO_DE_PRODUCTOS.Name = "REGISTRO_DE_PRODUCTOS"
        Me.REGISTRO_DE_PRODUCTOS.Size = New System.Drawing.Size(363, 54)
        Me.REGISTRO_DE_PRODUCTOS.Text = "REGISTRO DE PRODUCTOS"
        '
        'MODIFICAR_PRECIOS
        '
        Me.MODIFICAR_PRECIOS.Image = Global.SGCV_CO_V1._0.My.Resources.Resources.icons8_mejoras_económicas_48
        Me.MODIFICAR_PRECIOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MODIFICAR_PRECIOS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.MODIFICAR_PRECIOS.Name = "MODIFICAR_PRECIOS"
        Me.MODIFICAR_PRECIOS.Size = New System.Drawing.Size(363, 54)
        Me.MODIFICAR_PRECIOS.Text = "MODIFICAR PRECIOS"
        '
        'APLICAR_IMAGEN_A_PRODUCTO
        '
        Me.APLICAR_IMAGEN_A_PRODUCTO.Image = Global.SGCV_CO_V1._0.My.Resources.Resources.icons8_foto_48
        Me.APLICAR_IMAGEN_A_PRODUCTO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.APLICAR_IMAGEN_A_PRODUCTO.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.APLICAR_IMAGEN_A_PRODUCTO.Name = "APLICAR_IMAGEN_A_PRODUCTO"
        Me.APLICAR_IMAGEN_A_PRODUCTO.Size = New System.Drawing.Size(363, 54)
        Me.APLICAR_IMAGEN_A_PRODUCTO.Text = "APLICAR IMAGEN A PRODUCTO"
        '
        'PANEL_DE_PRECIOS_PROMO_PRODUCTOS
        '
        Me.PANEL_DE_PRECIOS_PROMO_PRODUCTOS.Image = Global.SGCV_CO_V1._0.My.Resources.Resources.icons8_estimar_48
        Me.PANEL_DE_PRECIOS_PROMO_PRODUCTOS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PANEL_DE_PRECIOS_PROMO_PRODUCTOS.Name = "PANEL_DE_PRECIOS_PROMO_PRODUCTOS"
        Me.PANEL_DE_PRECIOS_PROMO_PRODUCTOS.Size = New System.Drawing.Size(363, 54)
        Me.PANEL_DE_PRECIOS_PROMO_PRODUCTOS.Text = "PANEL DE PRECIOS - PROMO PRODUCTOS"
        '
        'PROVEEDORToolStripMenuItem
        '
        Me.PROVEEDORToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.REGISTRO_DE_PROVEEDORES})
        Me.PROVEEDORToolStripMenuItem.ForeColor = System.Drawing.Color.MediumBlue
        Me.PROVEEDORToolStripMenuItem.Image = Global.SGCV_CO_V1._0.My.Resources.Resources.icons8_proveedor_48
        Me.PROVEEDORToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.PROVEEDORToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.PROVEEDORToolStripMenuItem.Name = "PROVEEDORToolStripMenuItem"
        Me.PROVEEDORToolStripMenuItem.Size = New System.Drawing.Size(169, 52)
        Me.PROVEEDORToolStripMenuItem.Text = "PROVEEDOR"
        '
        'REGISTRO_DE_PROVEEDORES
        '
        Me.REGISTRO_DE_PROVEEDORES.Image = Global.SGCV_CO_V1._0.My.Resources.Resources.icons8_comprobado_48
        Me.REGISTRO_DE_PROVEEDORES.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.REGISTRO_DE_PROVEEDORES.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.REGISTRO_DE_PROVEEDORES.Name = "REGISTRO_DE_PROVEEDORES"
        Me.REGISTRO_DE_PROVEEDORES.Size = New System.Drawing.Size(281, 54)
        Me.REGISTRO_DE_PROVEEDORES.Text = "REGISTRO DE PROVEEDORES"
        '
        'DEPOSITOToolStripMenuItem
        '
        Me.DEPOSITOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VER_PRODUCTOS_EN_DEPOSITO, Me.TRASLADO_DE_PRODUCTOS, Me.VISUALIZAR_STOCK})
        Me.DEPOSITOToolStripMenuItem.ForeColor = System.Drawing.Color.MediumBlue
        Me.DEPOSITOToolStripMenuItem.Image = Global.SGCV_CO_V1._0.My.Resources.Resources.icons8_tienda_48
        Me.DEPOSITOToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DEPOSITOToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DEPOSITOToolStripMenuItem.Name = "DEPOSITOToolStripMenuItem"
        Me.DEPOSITOToolStripMenuItem.Size = New System.Drawing.Size(169, 52)
        Me.DEPOSITOToolStripMenuItem.Text = "DEPOSITO"
        '
        'VER_PRODUCTOS_EN_DEPOSITO
        '
        Me.VER_PRODUCTOS_EN_DEPOSITO.Image = Global.SGCV_CO_V1._0.My.Resources.Resources.icons8_foto_48
        Me.VER_PRODUCTOS_EN_DEPOSITO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.VER_PRODUCTOS_EN_DEPOSITO.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.VER_PRODUCTOS_EN_DEPOSITO.Name = "VER_PRODUCTOS_EN_DEPOSITO"
        Me.VER_PRODUCTOS_EN_DEPOSITO.Size = New System.Drawing.Size(348, 54)
        Me.VER_PRODUCTOS_EN_DEPOSITO.Text = "VER PRODUCTOS EN DEPOSITO"
        '
        'TRASLADO_DE_PRODUCTOS
        '
        Me.TRASLADO_DE_PRODUCTOS.Image = Global.SGCV_CO_V1._0.My.Resources.Resources.icons8_entrega_48
        Me.TRASLADO_DE_PRODUCTOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TRASLADO_DE_PRODUCTOS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.TRASLADO_DE_PRODUCTOS.Name = "TRASLADO_DE_PRODUCTOS"
        Me.TRASLADO_DE_PRODUCTOS.Size = New System.Drawing.Size(348, 54)
        Me.TRASLADO_DE_PRODUCTOS.Text = "TRASLADO DE PRODUCTOS"
        '
        'VISUALIZAR_STOCK
        '
        Me.VISUALIZAR_STOCK.Image = Global.SGCV_CO_V1._0.My.Resources.Resources.icons8_noticias_48
        Me.VISUALIZAR_STOCK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.VISUALIZAR_STOCK.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.VISUALIZAR_STOCK.Name = "VISUALIZAR_STOCK"
        Me.VISUALIZAR_STOCK.Size = New System.Drawing.Size(348, 54)
        Me.VISUALIZAR_STOCK.Text = "REPORTE DE PRODUCTOS EN DEPOSITO"
        '
        'COMPRASToolStripMenuItem
        '
        Me.COMPRASToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.COMPRAS_DE_PROVEEDORES, Me.INGRESAR_COMPRAS})
        Me.COMPRASToolStripMenuItem.ForeColor = System.Drawing.Color.MediumBlue
        Me.COMPRASToolStripMenuItem.Image = Global.SGCV_CO_V1._0.My.Resources.Resources.icons8_cesta_de_la_compra_48
        Me.COMPRASToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.COMPRASToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.COMPRASToolStripMenuItem.Name = "COMPRASToolStripMenuItem"
        Me.COMPRASToolStripMenuItem.Size = New System.Drawing.Size(169, 52)
        Me.COMPRASToolStripMenuItem.Text = "COMPRAS"
        '
        'COMPRAS_DE_PROVEEDORES
        '
        Me.COMPRAS_DE_PROVEEDORES.Image = Global.SGCV_CO_V1._0.My.Resources.Resources.icons8_comprar_48
        Me.COMPRAS_DE_PROVEEDORES.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.COMPRAS_DE_PROVEEDORES.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.COMPRAS_DE_PROVEEDORES.Name = "COMPRAS_DE_PROVEEDORES"
        Me.COMPRAS_DE_PROVEEDORES.Size = New System.Drawing.Size(292, 54)
        Me.COMPRAS_DE_PROVEEDORES.Text = "COMPRAS DE PROVEEDORES"
        '
        'INGRESAR_COMPRAS
        '
        Me.INGRESAR_COMPRAS.Image = Global.SGCV_CO_V1._0.My.Resources.Resources.icons8_verificar_48
        Me.INGRESAR_COMPRAS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.INGRESAR_COMPRAS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.INGRESAR_COMPRAS.Name = "INGRESAR_COMPRAS"
        Me.INGRESAR_COMPRAS.Size = New System.Drawing.Size(292, 54)
        Me.INGRESAR_COMPRAS.Text = "INGRESAR COMPRAS A STOCK"
        '
        'FACTURACIONToolStripMenuItem
        '
        Me.FACTURACIONToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FACTURACION, Me.REIMPRESION_FACTURACIONES, Me.ANULAR_FACTURACION, Me.REPORTE_DOCUMENTO_DE_FACTURACION})
        Me.FACTURACIONToolStripMenuItem.ForeColor = System.Drawing.Color.MediumBlue
        Me.FACTURACIONToolStripMenuItem.Image = Global.SGCV_CO_V1._0.My.Resources.Resources.icons8_tarea_completada_48
        Me.FACTURACIONToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FACTURACIONToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FACTURACIONToolStripMenuItem.Name = "FACTURACIONToolStripMenuItem"
        Me.FACTURACIONToolStripMenuItem.Size = New System.Drawing.Size(169, 52)
        Me.FACTURACIONToolStripMenuItem.Text = "VENTAS"
        '
        'FACTURACION
        '
        Me.FACTURACION.Image = Global.SGCV_CO_V1._0.My.Resources.Resources.icons8_solicitud_de_dinero_48
        Me.FACTURACION.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FACTURACION.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FACTURACION.Name = "FACTURACION"
        Me.FACTURACION.Size = New System.Drawing.Size(360, 54)
        Me.FACTURACION.Text = "FACTURACION"
        '
        'REIMPRESION_FACTURACIONES
        '
        Me.REIMPRESION_FACTURACIONES.Image = Global.SGCV_CO_V1._0.My.Resources.Resources.icons8_imprimir_48
        Me.REIMPRESION_FACTURACIONES.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.REIMPRESION_FACTURACIONES.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.REIMPRESION_FACTURACIONES.Name = "REIMPRESION_FACTURACIONES"
        Me.REIMPRESION_FACTURACIONES.Size = New System.Drawing.Size(360, 54)
        Me.REIMPRESION_FACTURACIONES.Text = "REIMPRESION FACTURACIONES"
        '
        'ANULAR_FACTURACION
        '
        Me.ANULAR_FACTURACION.Image = Global.SGCV_CO_V1._0.My.Resources.Resources.icons8_descargo_de_responsabilidad_48
        Me.ANULAR_FACTURACION.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ANULAR_FACTURACION.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ANULAR_FACTURACION.Name = "ANULAR_FACTURACION"
        Me.ANULAR_FACTURACION.Size = New System.Drawing.Size(360, 54)
        Me.ANULAR_FACTURACION.Text = "ANULAR FACTURACION"
        '
        'REPORTE_DOCUMENTO_DE_FACTURACION
        '
        Me.REPORTE_DOCUMENTO_DE_FACTURACION.Image = Global.SGCV_CO_V1._0.My.Resources.Resources.icons8_noticias_48
        Me.REPORTE_DOCUMENTO_DE_FACTURACION.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.REPORTE_DOCUMENTO_DE_FACTURACION.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.REPORTE_DOCUMENTO_DE_FACTURACION.Name = "REPORTE_DOCUMENTO_DE_FACTURACION"
        Me.REPORTE_DOCUMENTO_DE_FACTURACION.Size = New System.Drawing.Size(360, 54)
        Me.REPORTE_DOCUMENTO_DE_FACTURACION.Text = "REPORTE DOCUMENTO DE FACTURACION"
        '
        'CAJAToolStripMenuItem
        '
        Me.CAJAToolStripMenuItem.Checked = True
        Me.CAJAToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CAJAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.APERTURA_CIERRE, Me.VER_CUENTA_CLIENTE, Me.GESTIONAR_COBRO, Me.REPORTE_RENDICION_DE_CAJA, Me.VER_DOCUMENTOS_ANULADOS, Me.ANULAR_RECIBO, Me.REPORTE_DE_RECIBOS_DE_DINERO, Me.RE_IMPRESION_DE_RECIBOS_DE_DINERO})
        Me.CAJAToolStripMenuItem.ForeColor = System.Drawing.Color.MediumBlue
        Me.CAJAToolStripMenuItem.Image = Global.SGCV_CO_V1._0.My.Resources.Resources.icons8_estimar_48
        Me.CAJAToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CAJAToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CAJAToolStripMenuItem.Name = "CAJAToolStripMenuItem"
        Me.CAJAToolStripMenuItem.Size = New System.Drawing.Size(169, 52)
        Me.CAJAToolStripMenuItem.Text = "CAJA"
        '
        'APERTURA_CIERRE
        '
        Me.APERTURA_CIERRE.Image = Global.SGCV_CO_V1._0.My.Resources.Resources.icons8_monedas_48
        Me.APERTURA_CIERRE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.APERTURA_CIERRE.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.APERTURA_CIERRE.Name = "APERTURA_CIERRE"
        Me.APERTURA_CIERRE.Size = New System.Drawing.Size(359, 54)
        Me.APERTURA_CIERRE.Text = "APERTURA - RENDICION - MOVIMIENTOS"
        '
        'VER_CUENTA_CLIENTE
        '
        Me.VER_CUENTA_CLIENTE.Image = Global.SGCV_CO_V1._0.My.Resources.Resources.icons8_deuda_48
        Me.VER_CUENTA_CLIENTE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.VER_CUENTA_CLIENTE.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.VER_CUENTA_CLIENTE.Name = "VER_CUENTA_CLIENTE"
        Me.VER_CUENTA_CLIENTE.Size = New System.Drawing.Size(359, 54)
        Me.VER_CUENTA_CLIENTE.Text = "VER CUENTA CLIENTE"
        '
        'GESTIONAR_COBRO
        '
        Me.GESTIONAR_COBRO.Image = Global.SGCV_CO_V1._0.My.Resources.Resources.icons8_presupuesto_48
        Me.GESTIONAR_COBRO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GESTIONAR_COBRO.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.GESTIONAR_COBRO.Name = "GESTIONAR_COBRO"
        Me.GESTIONAR_COBRO.Size = New System.Drawing.Size(359, 54)
        Me.GESTIONAR_COBRO.Text = "GESTIONAR COBRO"
        '
        'REPORTE_RENDICION_DE_CAJA
        '
        Me.REPORTE_RENDICION_DE_CAJA.Image = Global.SGCV_CO_V1._0.My.Resources.Resources.icons8_contabilidad_48
        Me.REPORTE_RENDICION_DE_CAJA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.REPORTE_RENDICION_DE_CAJA.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.REPORTE_RENDICION_DE_CAJA.Name = "REPORTE_RENDICION_DE_CAJA"
        Me.REPORTE_RENDICION_DE_CAJA.Size = New System.Drawing.Size(359, 54)
        Me.REPORTE_RENDICION_DE_CAJA.Text = "REPORTE RENDICION DE CAJA"
        '
        'VER_DOCUMENTOS_ANULADOS
        '
        Me.VER_DOCUMENTOS_ANULADOS.Image = Global.SGCV_CO_V1._0.My.Resources.Resources.icons8_eliminar_archivo_48
        Me.VER_DOCUMENTOS_ANULADOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.VER_DOCUMENTOS_ANULADOS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.VER_DOCUMENTOS_ANULADOS.Name = "VER_DOCUMENTOS_ANULADOS"
        Me.VER_DOCUMENTOS_ANULADOS.Size = New System.Drawing.Size(359, 54)
        Me.VER_DOCUMENTOS_ANULADOS.Text = "VER DOCUMENTOS ANULADOS"
        '
        'ANULAR_RECIBO
        '
        Me.ANULAR_RECIBO.Image = Global.SGCV_CO_V1._0.My.Resources.Resources.icons8_eliminar_archivo_48__2_
        Me.ANULAR_RECIBO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ANULAR_RECIBO.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ANULAR_RECIBO.Name = "ANULAR_RECIBO"
        Me.ANULAR_RECIBO.Size = New System.Drawing.Size(359, 54)
        Me.ANULAR_RECIBO.Text = "ANULAR RECIBO"
        '
        'REPORTE_DE_RECIBOS_DE_DINERO
        '
        Me.REPORTE_DE_RECIBOS_DE_DINERO.Image = Global.SGCV_CO_V1._0.My.Resources.Resources.icons8_noticias_48
        Me.REPORTE_DE_RECIBOS_DE_DINERO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.REPORTE_DE_RECIBOS_DE_DINERO.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.REPORTE_DE_RECIBOS_DE_DINERO.Name = "REPORTE_DE_RECIBOS_DE_DINERO"
        Me.REPORTE_DE_RECIBOS_DE_DINERO.Size = New System.Drawing.Size(359, 54)
        Me.REPORTE_DE_RECIBOS_DE_DINERO.Text = "REPORTE DE RECIBOS DE DINERO"
        '
        'RE_IMPRESION_DE_RECIBOS_DE_DINERO
        '
        Me.RE_IMPRESION_DE_RECIBOS_DE_DINERO.Image = Global.SGCV_CO_V1._0.My.Resources.Resources.icons8_imprimir_48
        Me.RE_IMPRESION_DE_RECIBOS_DE_DINERO.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.RE_IMPRESION_DE_RECIBOS_DE_DINERO.Name = "RE_IMPRESION_DE_RECIBOS_DE_DINERO"
        Me.RE_IMPRESION_DE_RECIBOS_DE_DINERO.Size = New System.Drawing.Size(359, 54)
        Me.RE_IMPRESION_DE_RECIBOS_DE_DINERO.Text = "RE IMPRECION DE RECIBOS DE PAGO"
        '
        'COBRANZAToolStripMenuItem
        '
        Me.COBRANZAToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SEGUIMIENTO_COBRANZA_CLIENTE, Me.REPORTE_SEGUIMIENTO_COBRANZA, Me.REPORTE_CLIENTES_CON_ATRASO})
        Me.COBRANZAToolStripMenuItem.ForeColor = System.Drawing.Color.MediumBlue
        Me.COBRANZAToolStripMenuItem.Image = Global.SGCV_CO_V1._0.My.Resources.Resources.icons8_asistente_48
        Me.COBRANZAToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.COBRANZAToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.COBRANZAToolStripMenuItem.Name = "COBRANZAToolStripMenuItem"
        Me.COBRANZAToolStripMenuItem.Size = New System.Drawing.Size(169, 52)
        Me.COBRANZAToolStripMenuItem.Text = "COBRANZA"
        '
        'SEGUIMIENTO_COBRANZA_CLIENTE
        '
        Me.SEGUIMIENTO_COBRANZA_CLIENTE.Image = Global.SGCV_CO_V1._0.My.Resources.Resources.icons8_colaboración_hombre_mujer_48
        Me.SEGUIMIENTO_COBRANZA_CLIENTE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SEGUIMIENTO_COBRANZA_CLIENTE.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.SEGUIMIENTO_COBRANZA_CLIENTE.Name = "SEGUIMIENTO_COBRANZA_CLIENTE"
        Me.SEGUIMIENTO_COBRANZA_CLIENTE.Size = New System.Drawing.Size(326, 54)
        Me.SEGUIMIENTO_COBRANZA_CLIENTE.Text = "SEGUIMIENTO COBRANZA CLIENTE"
        '
        'REPORTE_SEGUIMIENTO_COBRANZA
        '
        Me.REPORTE_SEGUIMIENTO_COBRANZA.Image = Global.SGCV_CO_V1._0.My.Resources.Resources.icons8_noticias_48
        Me.REPORTE_SEGUIMIENTO_COBRANZA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.REPORTE_SEGUIMIENTO_COBRANZA.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.REPORTE_SEGUIMIENTO_COBRANZA.Name = "REPORTE_SEGUIMIENTO_COBRANZA"
        Me.REPORTE_SEGUIMIENTO_COBRANZA.Size = New System.Drawing.Size(326, 54)
        Me.REPORTE_SEGUIMIENTO_COBRANZA.Text = "REPORTE SEGUIMIENTO COBRANZA"
        '
        'REPORTE_CLIENTES_CON_ATRASO
        '
        Me.REPORTE_CLIENTES_CON_ATRASO.Image = Global.SGCV_CO_V1._0.My.Resources.Resources.icons8_noticias_48
        Me.REPORTE_CLIENTES_CON_ATRASO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.REPORTE_CLIENTES_CON_ATRASO.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.REPORTE_CLIENTES_CON_ATRASO.Name = "REPORTE_CLIENTES_CON_ATRASO"
        Me.REPORTE_CLIENTES_CON_ATRASO.Size = New System.Drawing.Size(326, 54)
        Me.REPORTE_CLIENTES_CON_ATRASO.Text = "REPORTE CLIENTES CON ATRASO"
        '
        'INFORMEToolStripMenuItem
        '
        Me.INFORMEToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UTILIDAD_COSTOVsVENTA, Me.ESTADISTICAS_DE_CUENTAS_POR_COBRAR, Me.ROTACION_DE_MERCADERIAS})
        Me.INFORMEToolStripMenuItem.ForeColor = System.Drawing.Color.MediumBlue
        Me.INFORMEToolStripMenuItem.Image = Global.SGCV_CO_V1._0.My.Resources.Resources.icons8_lista_de_quehaceres_48
        Me.INFORMEToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.INFORMEToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.INFORMEToolStripMenuItem.Name = "INFORMEToolStripMenuItem"
        Me.INFORMEToolStripMenuItem.Size = New System.Drawing.Size(169, 52)
        Me.INFORMEToolStripMenuItem.Text = "INFORME"
        '
        'UTILIDAD_COSTOVsVENTA
        '
        Me.UTILIDAD_COSTOVsVENTA.Image = Global.SGCV_CO_V1._0.My.Resources.Resources.icons8_flujo_de_fondos_48
        Me.UTILIDAD_COSTOVsVENTA.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.UTILIDAD_COSTOVsVENTA.Name = "UTILIDAD_COSTOVsVENTA"
        Me.UTILIDAD_COSTOVsVENTA.Size = New System.Drawing.Size(357, 54)
        Me.UTILIDAD_COSTOVsVENTA.Text = "UTILIDAD (COSTO vs VENTA)"
        '
        'ESTADISTICAS_DE_CUENTAS_POR_COBRAR
        '
        Me.ESTADISTICAS_DE_CUENTAS_POR_COBRAR.Image = Global.SGCV_CO_V1._0.My.Resources.Resources.icons8_contabilidad_48
        Me.ESTADISTICAS_DE_CUENTAS_POR_COBRAR.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ESTADISTICAS_DE_CUENTAS_POR_COBRAR.Name = "ESTADISTICAS_DE_CUENTAS_POR_COBRAR"
        Me.ESTADISTICAS_DE_CUENTAS_POR_COBRAR.Size = New System.Drawing.Size(357, 54)
        Me.ESTADISTICAS_DE_CUENTAS_POR_COBRAR.Text = "ESTADISTICAS DE CUENTAS POR COBRAR"
        '
        'ROTACION_DE_MERCADERIAS
        '
        Me.ROTACION_DE_MERCADERIAS.Image = Global.SGCV_CO_V1._0.My.Resources.Resources.icons8_producto_nuevo_48
        Me.ROTACION_DE_MERCADERIAS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ROTACION_DE_MERCADERIAS.Name = "ROTACION_DE_MERCADERIAS"
        Me.ROTACION_DE_MERCADERIAS.Size = New System.Drawing.Size(357, 54)
        Me.ROTACION_DE_MERCADERIAS.Text = "ROTACION DE MERCADERIAS"
        '
        'ROLESToolStripMenuItem
        '
        Me.ROLESToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AGREGAR_USUARIO, Me.HABILITAR_DESHABILITAR_ROLES_USUARIO, Me.EMPRESA, Me.FACTURACIONES_SIN_DOCUMENTO, Me.ESTADO_DE_DOCUMENTOS, Me.GESTIONAR_INTERES_PARACUOTAS})
        Me.ROLESToolStripMenuItem.ForeColor = System.Drawing.Color.MediumBlue
        Me.ROLESToolStripMenuItem.Image = Global.SGCV_CO_V1._0.My.Resources.Resources.icons8_trabajo_48
        Me.ROLESToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ROLESToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ROLESToolStripMenuItem.Name = "ROLESToolStripMenuItem"
        Me.ROLESToolStripMenuItem.Size = New System.Drawing.Size(169, 52)
        Me.ROLESToolStripMenuItem.Text = "CONFIGURACION "
        '
        'AGREGAR_USUARIO
        '
        Me.AGREGAR_USUARIO.Image = Global.SGCV_CO_V1._0.My.Resources.Resources.icons8_agregar_grupo_de_usuarios_mujer_hombre_tipo_de_piel_7_48
        Me.AGREGAR_USUARIO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.AGREGAR_USUARIO.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.AGREGAR_USUARIO.Name = "AGREGAR_USUARIO"
        Me.AGREGAR_USUARIO.Size = New System.Drawing.Size(322, 54)
        Me.AGREGAR_USUARIO.Text = "AGREGAR USUARIO"
        '
        'HABILITAR_DESHABILITAR_ROLES_USUARIO
        '
        Me.HABILITAR_DESHABILITAR_ROLES_USUARIO.Image = Global.SGCV_CO_V1._0.My.Resources.Resources.icons8_editar_usuario_masculino_48
        Me.HABILITAR_DESHABILITAR_ROLES_USUARIO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.HABILITAR_DESHABILITAR_ROLES_USUARIO.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.HABILITAR_DESHABILITAR_ROLES_USUARIO.Name = "HABILITAR_DESHABILITAR_ROLES_USUARIO"
        Me.HABILITAR_DESHABILITAR_ROLES_USUARIO.Size = New System.Drawing.Size(322, 54)
        Me.HABILITAR_DESHABILITAR_ROLES_USUARIO.Text = "ROLES DE USUARIO"
        '
        'EMPRESA
        '
        Me.EMPRESA.Image = Global.SGCV_CO_V1._0.My.Resources.Resources.icons8_añadir_contacto_a_empresa_48
        Me.EMPRESA.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.EMPRESA.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.EMPRESA.Name = "EMPRESA"
        Me.EMPRESA.Size = New System.Drawing.Size(322, 54)
        Me.EMPRESA.Text = "EMPRESA"
        '
        'FACTURACIONES_SIN_DOCUMENTO
        '
        Me.FACTURACIONES_SIN_DOCUMENTO.Image = Global.SGCV_CO_V1._0.My.Resources.Resources.icons8_documento_48
        Me.FACTURACIONES_SIN_DOCUMENTO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.FACTURACIONES_SIN_DOCUMENTO.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.FACTURACIONES_SIN_DOCUMENTO.Name = "FACTURACIONES_SIN_DOCUMENTO"
        Me.FACTURACIONES_SIN_DOCUMENTO.Size = New System.Drawing.Size(322, 54)
        Me.FACTURACIONES_SIN_DOCUMENTO.Text = "FACTURACIONES SIN DOCUMENTO"
        '
        'ESTADO_DE_DOCUMENTOS
        '
        Me.ESTADO_DE_DOCUMENTOS.Image = Global.SGCV_CO_V1._0.My.Resources.Resources.icons8_estructura_de_precios_48
        Me.ESTADO_DE_DOCUMENTOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ESTADO_DE_DOCUMENTOS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ESTADO_DE_DOCUMENTOS.Name = "ESTADO_DE_DOCUMENTOS"
        Me.ESTADO_DE_DOCUMENTOS.Size = New System.Drawing.Size(322, 54)
        Me.ESTADO_DE_DOCUMENTOS.Text = "ESTADO DE DOCUMENTOS"
        '
        'GESTIONAR_INTERES_PARACUOTAS
        '
        Me.GESTIONAR_INTERES_PARACUOTAS.Image = Global.SGCV_CO_V1._0.My.Resources.Resources.icons8_estimar_48
        Me.GESTIONAR_INTERES_PARACUOTAS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.GESTIONAR_INTERES_PARACUOTAS.Name = "GESTIONAR_INTERES_PARACUOTAS"
        Me.GESTIONAR_INTERES_PARACUOTAS.Size = New System.Drawing.Size(322, 54)
        Me.GESTIONAR_INTERES_PARACUOTAS.Text = "GESTIONAR INTERES PARA CUOTAS"
        '
        'CONTACTOToolStripMenuItem
        '
        Me.CONTACTOToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DATOS_PARA_CONTACTOS})
        Me.CONTACTOToolStripMenuItem.ForeColor = System.Drawing.Color.MediumBlue
        Me.CONTACTOToolStripMenuItem.Image = Global.SGCV_CO_V1._0.My.Resources.Resources.icons8_atención_al_cliente_48
        Me.CONTACTOToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CONTACTOToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CONTACTOToolStripMenuItem.Name = "CONTACTOToolStripMenuItem"
        Me.CONTACTOToolStripMenuItem.Size = New System.Drawing.Size(169, 52)
        Me.CONTACTOToolStripMenuItem.Text = "SOPORTE"
        '
        'DATOS_PARA_CONTACTOS
        '
        Me.DATOS_PARA_CONTACTOS.Image = Global.SGCV_CO_V1._0.My.Resources.Resources.icons8_colaboración_hombre_mujer_481
        Me.DATOS_PARA_CONTACTOS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DATOS_PARA_CONTACTOS.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.DATOS_PARA_CONTACTOS.Name = "DATOS_PARA_CONTACTOS"
        Me.DATOS_PARA_CONTACTOS.Size = New System.Drawing.Size(263, 54)
        Me.DATOS_PARA_CONTACTOS.Text = "DATOS PARA CONTACTOS"
        '
        'CERRARToolStripMenuItem
        '
        Me.CERRARToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.CERRARToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CERRARToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CERRARToolStripMenuItem.Image = Global.SGCV_CO_V1._0.My.Resources.Resources.icons8_bloquear_48
        Me.CERRARToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CERRARToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CERRARToolStripMenuItem.Name = "CERRARToolStripMenuItem"
        Me.CERRARToolStripMenuItem.Size = New System.Drawing.Size(169, 52)
        Me.CERRARToolStripMenuItem.Text = "CERRAR"
        '
        'lbFechaActual
        '
        Me.lbFechaActual.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbFechaActual.BackColor = System.Drawing.Color.White
        Me.lbFechaActual.Font = New System.Drawing.Font("Segoe UI", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFechaActual.ForeColor = System.Drawing.Color.White
        Me.lbFechaActual.Location = New System.Drawing.Point(804, 9)
        Me.lbFechaActual.Name = "lbFechaActual"
        Me.lbFechaActual.Size = New System.Drawing.Size(519, 32)
        Me.lbFechaActual.TabIndex = 0
        Me.lbFechaActual.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbUsuarioActivo
        '
        Me.lbUsuarioActivo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbUsuarioActivo.BackColor = System.Drawing.Color.White
        Me.lbUsuarioActivo.Font = New System.Drawing.Font("Segoe UI", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUsuarioActivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbUsuarioActivo.Location = New System.Drawing.Point(804, 97)
        Me.lbUsuarioActivo.Name = "lbUsuarioActivo"
        Me.lbUsuarioActivo.Size = New System.Drawing.Size(519, 45)
        Me.lbUsuarioActivo.TabIndex = 30
        Me.lbUsuarioActivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'lbHora
        '
        Me.lbHora.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbHora.BackColor = System.Drawing.Color.White
        Me.lbHora.Font = New System.Drawing.Font("Segoe UI", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHora.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbHora.Location = New System.Drawing.Point(804, 180)
        Me.lbHora.Name = "lbHora"
        Me.lbHora.Size = New System.Drawing.Size(519, 45)
        Me.lbHora.TabIndex = 32
        Me.lbHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window
        Me.MonthCalendar1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MonthCalendar1.CalendarDimensions = New System.Drawing.Size(2, 2)
        Me.MonthCalendar1.Font = New System.Drawing.Font("Segoe UI Semibold", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MonthCalendar1.Location = New System.Drawing.Point(823, 456)
        Me.MonthCalendar1.MaxSelectionCount = 30
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(804, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(519, 45)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "USTED ESTA REGISTRADO COMO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MENU_PRINCIPAL
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1335, 733)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.lbHora)
        Me.Controls.Add(Me.lbFechaActual)
        Me.Controls.Add(Me.lbUsuarioActivo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Blue
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MENU_PRINCIPAL"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MENU PRINCIPAL      *** SISTEMA DE GESTION DE COMPRAS Y VENTAS + COBRANZAS   ***"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CLIENTESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REGISTRO_CLIENTES As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PRODUCTOSToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REGISTRO_DE_PRODUCTOS As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MODIFICAR_PRECIOS As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PROVEEDORToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REGISTRO_DE_PROVEEDORES As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DEPOSITOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VISUALIZAR_STOCK As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents COMPRASToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents COMPRAS_DE_PROVEEDORES As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents INGRESAR_COMPRAS As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FACTURACIONToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FACTURACION As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REIMPRESION_FACTURACIONES As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CAJAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents APERTURA_CIERRE As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents COBRANZAToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents INFORMEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ROLESToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AGREGAR_USUARIO As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HABILITAR_DESHABILITAR_ROLES_USUARIO As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EMPRESA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VER_CUENTA_CLIENTE As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GESTIONAR_COBRO As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lbFechaActual As System.Windows.Forms.Label
    Friend WithEvents lbUsuarioActivo As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lbHora As System.Windows.Forms.Label
    Friend WithEvents VER_DOCUMENTOS_ANULADOS As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SEGUIMIENTO_COBRANZA_CLIENTE As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REPORTE_SEGUIMIENTO_COBRANZA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ANULAR_FACTURACION As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UTILIDAD_COSTOVsVENTA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ESTADISTICAS_DE_CUENTAS_POR_COBRAR As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ROTACION_DE_MERCADERIAS As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CERRARToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ANULAR_RECIBO As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REPORTE_RENDICION_DE_CAJA As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FACTURACIONES_SIN_DOCUMENTO As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REPORTE_CLIENTES As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REPORTE_CLIENTES_CON_ATRASO As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TRASLADO_DE_PRODUCTOS As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ESTADO_DE_DOCUMENTOS As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REPORTE_DOCUMENTO_DE_FACTURACION As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REPORTE_DE_RECIBOS_DE_DINERO As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CONTACTOToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DATOS_PARA_CONTACTOS As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VER_PRODUCTOS_EN_DEPOSITO As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents APLICAR_IMAGEN_A_PRODUCTO As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PANEL_DE_PRECIOS_PROMO_PRODUCTOS As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GESTIONAR_INTERES_PARACUOTAS As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RE_IMPRESION_DE_RECIBOS_DE_DINERO As System.Windows.Forms.ToolStripMenuItem
End Class
