<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GESTIONAR_PRECIO_PRODUCTOS
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
        Me.txtLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnAplicar_Precio = New System.Windows.Forms.Button()
        Me.txtBuscar_Producto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtProducto_Seleccionado = New System.Windows.Forms.TextBox()
        Me.txtMonto_Contado = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDetalles_Promo = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtPrecio_Contado = New System.Windows.Forms.TextBox()
        Me.rbporITEM = New System.Windows.Forms.RadioButton()
        Me.rbporCOMPLETO = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dg_Producto = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtPromocion = New System.Windows.Forms.TextBox()
        Me.txtBuscar_por_Codigo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtBuscar_por_Descripcion = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtProductoAfectado = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dg_Producto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtLimpiar
        '
        Me.txtLimpiar.BackColor = System.Drawing.Color.LightGreen
        Me.txtLimpiar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLimpiar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtLimpiar.Location = New System.Drawing.Point(19, 635)
        Me.txtLimpiar.Name = "txtLimpiar"
        Me.txtLimpiar.Size = New System.Drawing.Size(337, 30)
        Me.txtLimpiar.TabIndex = 1255
        Me.txtLimpiar.Text = "CANCELAR Y LIMPIAR"
        Me.txtLimpiar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSalir.Location = New System.Drawing.Point(19, 667)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(337, 30)
        Me.btnSalir.TabIndex = 1249
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnAplicar_Precio
        '
        Me.btnAplicar_Precio.BackColor = System.Drawing.Color.LightGreen
        Me.btnAplicar_Precio.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAplicar_Precio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAplicar_Precio.Location = New System.Drawing.Point(19, 602)
        Me.btnAplicar_Precio.Name = "btnAplicar_Precio"
        Me.btnAplicar_Precio.Size = New System.Drawing.Size(337, 30)
        Me.btnAplicar_Precio.TabIndex = 1248
        Me.btnAplicar_Precio.Text = "APLICAR PRECIOS"
        Me.btnAplicar_Precio.UseVisualStyleBackColor = False
        '
        'txtBuscar_Producto
        '
        Me.txtBuscar_Producto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscar_Producto.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar_Producto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBuscar_Producto.Location = New System.Drawing.Point(17, 75)
        Me.txtBuscar_Producto.Name = "txtBuscar_Producto"
        Me.txtBuscar_Producto.Size = New System.Drawing.Size(339, 25)
        Me.txtBuscar_Producto.TabIndex = 1
        Me.txtBuscar_Producto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(17, 54)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(339, 23)
        Me.Label4.TabIndex = 1253
        Me.Label4.Text = "Buscar Producto por Nombre"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(14, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(342, 23)
        Me.Label2.TabIndex = 1252
        Me.Label2.Text = "Seleccionar Tipo de Accion en el Precio"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(14, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1227, 23)
        Me.Label1.TabIndex = 1251
        Me.Label1.Text = "FORMULARIO GESTION DE PRECIO PRODUCTOS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Green
        Me.Label5.Location = New System.Drawing.Point(360, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(611, 23)
        Me.Label5.TabIndex = 1254
        Me.Label5.Text = "Detalles de Productos Afectados"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(977, 113)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(264, 23)
        Me.Label13.TabIndex = 1261
        Me.Label13.Text = "DETALLES DE PROMOCIONES DISPONIBLES"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(12, 21)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(311, 23)
        Me.Label14.TabIndex = 1263
        Me.Label14.Text = "PRECIO CONTADO (en Porcentaje)"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtProducto_Seleccionado
        '
        Me.txtProducto_Seleccionado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProducto_Seleccionado.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProducto_Seleccionado.ForeColor = System.Drawing.Color.Teal
        Me.txtProducto_Seleccionado.Location = New System.Drawing.Point(977, 66)
        Me.txtProducto_Seleccionado.Multiline = True
        Me.txtProducto_Seleccionado.Name = "txtProducto_Seleccionado"
        Me.txtProducto_Seleccionado.Size = New System.Drawing.Size(264, 44)
        Me.txtProducto_Seleccionado.TabIndex = 1270
        Me.txtProducto_Seleccionado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMonto_Contado
        '
        Me.txtMonto_Contado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMonto_Contado.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonto_Contado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMonto_Contado.Location = New System.Drawing.Point(977, 262)
        Me.txtMonto_Contado.Multiline = True
        Me.txtMonto_Contado.Name = "txtMonto_Contado"
        Me.txtMonto_Contado.Size = New System.Drawing.Size(264, 32)
        Me.txtMonto_Contado.TabIndex = 1275
        Me.txtMonto_Contado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(977, 241)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(264, 23)
        Me.Label6.TabIndex = 1274
        Me.Label6.Text = "PRECIO DE VENTA AL CONTADO"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDetalles_Promo
        '
        Me.txtDetalles_Promo.BackColor = System.Drawing.Color.Linen
        Me.txtDetalles_Promo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDetalles_Promo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetalles_Promo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDetalles_Promo.Location = New System.Drawing.Point(977, 138)
        Me.txtDetalles_Promo.Multiline = True
        Me.txtDetalles_Promo.Name = "txtDetalles_Promo"
        Me.txtDetalles_Promo.Size = New System.Drawing.Size(264, 100)
        Me.txtDetalles_Promo.TabIndex = 1271
        Me.txtDetalles_Promo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtPrecio_Contado)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Green
        Me.GroupBox2.Location = New System.Drawing.Point(17, 394)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(339, 80)
        Me.GroupBox2.TabIndex = 1276
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detalles de PRECIOS/PORCENTAJE de articulos"
        '
        'txtPrecio_Contado
        '
        Me.txtPrecio_Contado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPrecio_Contado.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio_Contado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPrecio_Contado.Location = New System.Drawing.Point(12, 44)
        Me.txtPrecio_Contado.Multiline = True
        Me.txtPrecio_Contado.Name = "txtPrecio_Contado"
        Me.txtPrecio_Contado.Size = New System.Drawing.Size(312, 25)
        Me.txtPrecio_Contado.TabIndex = 1281
        Me.txtPrecio_Contado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'rbporITEM
        '
        Me.rbporITEM.AutoSize = True
        Me.rbporITEM.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbporITEM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rbporITEM.Location = New System.Drawing.Point(19, 229)
        Me.rbporITEM.Name = "rbporITEM"
        Me.rbporITEM.Size = New System.Drawing.Size(187, 21)
        Me.rbporITEM.TabIndex = 1277
        Me.rbporITEM.Text = "Establecer precios por ITEM"
        Me.rbporITEM.UseVisualStyleBackColor = True
        '
        'rbporCOMPLETO
        '
        Me.rbporCOMPLETO.AutoSize = True
        Me.rbporCOMPLETO.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbporCOMPLETO.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.rbporCOMPLETO.Location = New System.Drawing.Point(20, 322)
        Me.rbporCOMPLETO.Name = "rbporCOMPLETO"
        Me.rbporCOMPLETO.Size = New System.Drawing.Size(305, 21)
        Me.rbporCOMPLETO.TabIndex = 1278
        Me.rbporCOMPLETO.Text = "Establecer precios por PORCENTAJE (Completo)"
        Me.rbporCOMPLETO.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Green
        Me.Label7.Location = New System.Drawing.Point(977, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(264, 23)
        Me.Label7.TabIndex = 1281
        Me.Label7.Text = "Detalles de Precios por ITEM"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dg_Producto
        '
        Me.dg_Producto.AlternatingBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.dg_Producto.BackColor = System.Drawing.Color.White
        Me.dg_Producto.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow
        Me.dg_Producto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dg_Producto.CaptionBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.dg_Producto.CaptionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dg_Producto.CaptionForeColor = System.Drawing.Color.DarkSlateBlue
        Me.dg_Producto.DataMember = ""
        Me.dg_Producto.FlatMode = True
        Me.dg_Producto.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dg_Producto.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.dg_Producto.GridLineColor = System.Drawing.Color.Peru
        Me.dg_Producto.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dg_Producto.HeaderBackColor = System.Drawing.Color.Maroon
        Me.dg_Producto.HeaderFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dg_Producto.HeaderForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.dg_Producto.LinkColor = System.Drawing.Color.Maroon
        Me.dg_Producto.Location = New System.Drawing.Point(362, 58)
        Me.dg_Producto.Name = "dg_Producto"
        Me.dg_Producto.ParentRowsBackColor = System.Drawing.Color.BurlyWood
        Me.dg_Producto.ParentRowsForeColor = System.Drawing.Color.DarkSlateBlue
        Me.dg_Producto.ReadOnly = True
        Me.dg_Producto.RowHeadersVisible = False
        Me.dg_Producto.SelectionBackColor = System.Drawing.Color.DarkSlateBlue
        Me.dg_Producto.SelectionForeColor = System.Drawing.Color.GhostWhite
        Me.dg_Producto.Size = New System.Drawing.Size(609, 639)
        Me.dg_Producto.TabIndex = 1282
        Me.dg_Producto.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dg_Producto
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "TP_PRODUCTO"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "CODIGO"
        Me.DataGridTextBoxColumn1.MappingName = "CODIGO"
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "ARTICULO"
        Me.DataGridTextBoxColumn2.MappingName = "NOMBRE"
        Me.DataGridTextBoxColumn2.Width = 250
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn3.Format = "n0"
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "PRECIO COMPRA"
        Me.DataGridTextBoxColumn3.MappingName = "PRECIO_COMPRA"
        Me.DataGridTextBoxColumn3.Width = 95
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn4.Format = "n0"
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "PRECIO CONTADO"
        Me.DataGridTextBoxColumn4.MappingName = "PRECIO_CONTADO"
        Me.DataGridTextBoxColumn4.Width = 95
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn5.Format = "n0"
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.MappingName = "PRECIO_CREDITO"
        Me.DataGridTextBoxColumn5.Width = 0
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.MappingName = "COD_PRODUCTO"
        Me.DataGridTextBoxColumn8.Width = 0
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.MappingName = "OBSERVACION"
        Me.DataGridTextBoxColumn9.Width = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPromocion)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(17, 476)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(339, 118)
        Me.GroupBox1.TabIndex = 1283
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles de PROMOCIONES VIGENTES"
        '
        'txtPromocion
        '
        Me.txtPromocion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPromocion.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPromocion.ForeColor = System.Drawing.Color.Green
        Me.txtPromocion.Location = New System.Drawing.Point(15, 23)
        Me.txtPromocion.Multiline = True
        Me.txtPromocion.Name = "txtPromocion"
        Me.txtPromocion.Size = New System.Drawing.Size(309, 88)
        Me.txtPromocion.TabIndex = 1282
        '
        'txtBuscar_por_Codigo
        '
        Me.txtBuscar_por_Codigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscar_por_Codigo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar_por_Codigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBuscar_por_Codigo.Location = New System.Drawing.Point(17, 123)
        Me.txtBuscar_por_Codigo.Name = "txtBuscar_por_Codigo"
        Me.txtBuscar_por_Codigo.Size = New System.Drawing.Size(339, 25)
        Me.txtBuscar_por_Codigo.TabIndex = 2
        Me.txtBuscar_por_Codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(17, 100)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(339, 23)
        Me.Label10.TabIndex = 1286
        Me.Label10.Text = "Buscar Producto por Codigo"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBuscar_por_Descripcion
        '
        Me.txtBuscar_por_Descripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscar_por_Descripcion.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar_por_Descripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBuscar_por_Descripcion.Location = New System.Drawing.Point(17, 172)
        Me.txtBuscar_por_Descripcion.Name = "txtBuscar_por_Descripcion"
        Me.txtBuscar_por_Descripcion.Size = New System.Drawing.Size(339, 25)
        Me.txtBuscar_por_Descripcion.TabIndex = 3
        Me.txtBuscar_por_Descripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(17, 149)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(339, 23)
        Me.Label11.TabIndex = 1288
        Me.Label11.Text = "Buscar Producto por Descripcion"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(17, 253)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(339, 23)
        Me.Label3.TabIndex = 1289
        Me.Label3.Text = "PRODUCTO AFECTADO"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtProductoAfectado
        '
        Me.txtProductoAfectado.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtProductoAfectado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProductoAfectado.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProductoAfectado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtProductoAfectado.Location = New System.Drawing.Point(17, 279)
        Me.txtProductoAfectado.Name = "txtProductoAfectado"
        Me.txtProductoAfectado.ReadOnly = True
        Me.txtProductoAfectado.Size = New System.Drawing.Size(339, 29)
        Me.txtProductoAfectado.TabIndex = 1290
        Me.txtProductoAfectado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GESTIONAR_PRECIO_PRODUCTOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1250, 705)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtProductoAfectado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtBuscar_por_Descripcion)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtBuscar_por_Codigo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtMonto_Contado)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtDetalles_Promo)
        Me.Controls.Add(Me.txtProducto_Seleccionado)
        Me.Controls.Add(Me.txtBuscar_Producto)
        Me.Controls.Add(Me.txtLimpiar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAplicar_Precio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dg_Producto)
        Me.Controls.Add(Me.rbporCOMPLETO)
        Me.Controls.Add(Me.rbporITEM)
        Me.Name = "GESTIONAR_PRECIO_PRODUCTOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SISTEMA DE GESTION DE COMPRAS Y VENTAS VERSION (E) V1.1.0          CONSULTAS Y PR" & _
            "ECIOS AL 0994 60 60 48  / 0982 12 12 69     *** TU VENDEDOR SOFT ***"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dg_Producto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnAplicar_Precio As System.Windows.Forms.Button
    Friend WithEvents txtBuscar_Producto As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtProducto_Seleccionado As System.Windows.Forms.TextBox
    Friend WithEvents txtMonto_Contado As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDetalles_Promo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbporITEM As System.Windows.Forms.RadioButton
    Friend WithEvents rbporCOMPLETO As System.Windows.Forms.RadioButton
    Friend WithEvents txtPrecio_Contado As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dg_Producto As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtPromocion As System.Windows.Forms.TextBox
    Friend WithEvents txtBuscar_por_Codigo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtBuscar_por_Descripcion As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtProductoAfectado As System.Windows.Forms.TextBox
End Class
