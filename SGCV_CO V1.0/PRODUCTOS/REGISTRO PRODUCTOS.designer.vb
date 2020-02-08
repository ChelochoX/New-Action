<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REGISTRO_PRODUCTOS
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
        Me.btnGenerar_Codigo = New System.Windows.Forms.Button()
        Me.cbUnidad_Medida = New System.Windows.Forms.ComboBox()
        Me.dg_Producto = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLimpiar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.chkProducto_Usado = New System.Windows.Forms.CheckBox()
        Me.cbCategoria = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBuscarCodigo = New System.Windows.Forms.TextBox()
        Me.txtBuscarNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrecio_Compra = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDescipcion_prod = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.dg_Producto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGenerar_Codigo
        '
        Me.btnGenerar_Codigo.BackColor = System.Drawing.Color.Honeydew
        Me.btnGenerar_Codigo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerar_Codigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnGenerar_Codigo.Location = New System.Drawing.Point(7, 46)
        Me.btnGenerar_Codigo.Name = "btnGenerar_Codigo"
        Me.btnGenerar_Codigo.Size = New System.Drawing.Size(255, 26)
        Me.btnGenerar_Codigo.TabIndex = 130
        Me.btnGenerar_Codigo.Text = "Generar Codigo"
        Me.btnGenerar_Codigo.UseVisualStyleBackColor = False
        '
        'cbUnidad_Medida
        '
        Me.cbUnidad_Medida.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbUnidad_Medida.ForeColor = System.Drawing.Color.Navy
        Me.cbUnidad_Medida.FormattingEnabled = True
        Me.cbUnidad_Medida.Location = New System.Drawing.Point(6, 283)
        Me.cbUnidad_Medida.Name = "cbUnidad_Medida"
        Me.cbUnidad_Medida.Size = New System.Drawing.Size(256, 25)
        Me.cbUnidad_Medida.TabIndex = 117
        '
        'dg_Producto
        '
        Me.dg_Producto.AlternatingBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.dg_Producto.BackColor = System.Drawing.Color.White
        Me.dg_Producto.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow
        Me.dg_Producto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dg_Producto.CaptionBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.dg_Producto.CaptionFont = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dg_Producto.CaptionForeColor = System.Drawing.Color.DarkSlateBlue
        Me.dg_Producto.DataMember = ""
        Me.dg_Producto.FlatMode = True
        Me.dg_Producto.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dg_Producto.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.dg_Producto.GridLineColor = System.Drawing.Color.Peru
        Me.dg_Producto.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dg_Producto.HeaderBackColor = System.Drawing.Color.Maroon
        Me.dg_Producto.HeaderFont = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dg_Producto.HeaderForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.dg_Producto.LinkColor = System.Drawing.Color.Maroon
        Me.dg_Producto.Location = New System.Drawing.Point(268, 84)
        Me.dg_Producto.Name = "dg_Producto"
        Me.dg_Producto.ParentRowsBackColor = System.Drawing.Color.BurlyWood
        Me.dg_Producto.ParentRowsForeColor = System.Drawing.Color.DarkSlateBlue
        Me.dg_Producto.ReadOnly = True
        Me.dg_Producto.RowHeadersVisible = False
        Me.dg_Producto.SelectionBackColor = System.Drawing.Color.DarkSlateBlue
        Me.dg_Producto.SelectionForeColor = System.Drawing.Color.GhostWhite
        Me.dg_Producto.Size = New System.Drawing.Size(1028, 504)
        Me.dg_Producto.TabIndex = 123
        Me.dg_Producto.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.DataGrid = Me.dg_Producto
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn14, Me.DataGridTextBoxColumn1})
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle2.MappingName = "TP_PRODUCTO"
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "CODIGO"
        Me.DataGridTextBoxColumn8.MappingName = "CODIGO"
        Me.DataGridTextBoxColumn8.Width = 70
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "NOMBRE"
        Me.DataGridTextBoxColumn9.MappingName = "NOMBRE"
        Me.DataGridTextBoxColumn9.Width = 250
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "DESCRIPCION"
        Me.DataGridTextBoxColumn2.MappingName = "DESCRIPCION"
        Me.DataGridTextBoxColumn2.Width = 250
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "U.MEDIDA"
        Me.DataGridTextBoxColumn10.MappingName = "UNI_MEDIDA"
        Me.DataGridTextBoxColumn10.Width = 90
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn11.Format = "n0"
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "PRECIO COMPRA"
        Me.DataGridTextBoxColumn11.MappingName = "PRECIO_COMPRA"
        Me.DataGridTextBoxColumn11.Width = 95
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "IVA"
        Me.DataGridTextBoxColumn13.MappingName = "IVA_PROD"
        Me.DataGridTextBoxColumn13.Width = 80
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.MappingName = "COD_PRODUCTO"
        Me.DataGridTextBoxColumn14.Width = 0
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "CATEGORIA"
        Me.DataGridTextBoxColumn1.MappingName = "CATEGORIA"
        Me.DataGridTextBoxColumn1.Width = 120
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnModificar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnModificar.Location = New System.Drawing.Point(7, 478)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(255, 35)
        Me.btnModificar.TabIndex = 121
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1286, 23)
        Me.Label1.TabIndex = 128
        Me.Label1.Text = "FORMULARIO REGISTRO DE PRODUCTOS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtLimpiar
        '
        Me.txtLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtLimpiar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLimpiar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtLimpiar.Location = New System.Drawing.Point(7, 515)
        Me.txtLimpiar.Name = "txtLimpiar"
        Me.txtLimpiar.Size = New System.Drawing.Size(255, 35)
        Me.txtLimpiar.TabIndex = 122
        Me.txtLimpiar.Text = "Limpiar"
        Me.txtLimpiar.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnguardar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnguardar.Location = New System.Drawing.Point(6, 441)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(255, 35)
        Me.btnguardar.TabIndex = 120
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.Location = New System.Drawing.Point(7, 553)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(255, 35)
        Me.btnSalir.TabIndex = 124
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(6, 263)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(256, 20)
        Me.Label6.TabIndex = 126
        Me.Label6.Text = "UNIDAD MEDIDA"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNombre.Location = New System.Drawing.Point(7, 125)
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(255, 37)
        Me.txtNombre.TabIndex = 115
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(7, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(255, 23)
        Me.Label4.TabIndex = 125
        Me.Label4.Text = "Nombre Producto"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCodigo
        '
        Me.txtCodigo.BackColor = System.Drawing.Color.White
        Me.txtCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCodigo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCodigo.Location = New System.Drawing.Point(8, 76)
        Me.txtCodigo.Multiline = True
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(254, 27)
        Me.txtCodigo.TabIndex = 114
        Me.txtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'chkProducto_Usado
        '
        Me.chkProducto_Usado.AutoSize = True
        Me.chkProducto_Usado.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkProducto_Usado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.chkProducto_Usado.Location = New System.Drawing.Point(6, 357)
        Me.chkProducto_Usado.Name = "chkProducto_Usado"
        Me.chkProducto_Usado.Size = New System.Drawing.Size(143, 25)
        Me.chkProducto_Usado.TabIndex = 133
        Me.chkProducto_Usado.Text = "Producto Usado"
        Me.chkProducto_Usado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.chkProducto_Usado.UseVisualStyleBackColor = True
        '
        'cbCategoria
        '
        Me.cbCategoria.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCategoria.ForeColor = System.Drawing.Color.Navy
        Me.cbCategoria.FormattingEnabled = True
        Me.cbCategoria.Location = New System.Drawing.Point(6, 328)
        Me.cbCategoria.Name = "cbCategoria"
        Me.cbCategoria.Size = New System.Drawing.Size(256, 25)
        Me.cbCategoria.TabIndex = 118
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(6, 308)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(256, 20)
        Me.Label2.TabIndex = 135
        Me.Label2.Text = "CATEGORIA"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBuscarCodigo
        '
        Me.txtBuscarCodigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBuscarCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBuscarCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscarCodigo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarCodigo.ForeColor = System.Drawing.Color.Black
        Me.txtBuscarCodigo.Location = New System.Drawing.Point(268, 58)
        Me.txtBuscarCodigo.Multiline = True
        Me.txtBuscarCodigo.Name = "txtBuscarCodigo"
        Me.txtBuscarCodigo.Size = New System.Drawing.Size(227, 23)
        Me.txtBuscarCodigo.TabIndex = 136
        Me.txtBuscarCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBuscarNombre
        '
        Me.txtBuscarNombre.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBuscarNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtBuscarNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscarNombre.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscarNombre.ForeColor = System.Drawing.Color.Black
        Me.txtBuscarNombre.Location = New System.Drawing.Point(501, 58)
        Me.txtBuscarNombre.Multiline = True
        Me.txtBuscarNombre.Name = "txtBuscarNombre"
        Me.txtBuscarNombre.Size = New System.Drawing.Size(602, 23)
        Me.txtBuscarNombre.TabIndex = 137
        Me.txtBuscarNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(268, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(227, 23)
        Me.Label3.TabIndex = 138
        Me.Label3.Text = "BUSCAR POR CODIGO"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtPrecio_Compra
        '
        Me.txtPrecio_Compra.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPrecio_Compra.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio_Compra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtPrecio_Compra.Location = New System.Drawing.Point(7, 402)
        Me.txtPrecio_Compra.Multiline = True
        Me.txtPrecio_Compra.Name = "txtPrecio_Compra"
        Me.txtPrecio_Compra.Size = New System.Drawing.Size(255, 31)
        Me.txtPrecio_Compra.TabIndex = 119
        Me.txtPrecio_Compra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(7, 381)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(255, 23)
        Me.Label5.TabIndex = 140
        Me.Label5.Text = "Precio de Compra"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDescipcion_prod
        '
        Me.txtDescipcion_prod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescipcion_prod.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescipcion_prod.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDescipcion_prod.Location = New System.Drawing.Point(7, 188)
        Me.txtDescipcion_prod.Multiline = True
        Me.txtDescipcion_prod.Name = "txtDescipcion_prod"
        Me.txtDescipcion_prod.Size = New System.Drawing.Size(255, 68)
        Me.txtDescipcion_prod.TabIndex = 116
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(7, 165)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(255, 23)
        Me.Label7.TabIndex = 142
        Me.Label7.Text = "Descripcion Producto"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Maroon
        Me.Label8.Location = New System.Drawing.Point(501, 34)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(602, 23)
        Me.Label8.TabIndex = 143
        Me.Label8.Text = "BUSCAR POR NOMBRE DE PRODUCTOS"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'REGISTRO_PRODUCTOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1307, 603)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtDescipcion_prod)
        Me.Controls.Add(Me.txtPrecio_Compra)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtBuscarNombre)
        Me.Controls.Add(Me.txtBuscarCodigo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbCategoria)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.chkProducto_Usado)
        Me.Controls.Add(Me.btnGenerar_Codigo)
        Me.Controls.Add(Me.cbUnidad_Medida)
        Me.Controls.Add(Me.dg_Producto)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLimpiar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Name = "REGISTRO_PRODUCTOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SISTEMA DE GESTION DE COMPRAS Y VENTAS VERSION (E) V1.1.0          CONSULTAS Y PR" & _
            "ECIOS AL 0994 60 60 48  / 0982 12 12 69     *** TU VENDEDOR SOFT ***"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dg_Producto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGenerar_Codigo As System.Windows.Forms.Button
    Friend WithEvents cbUnidad_Medida As System.Windows.Forms.ComboBox
    Friend WithEvents dg_Producto As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents chkProducto_Usado As System.Windows.Forms.CheckBox
    Friend WithEvents cbCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents txtBuscarCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtBuscarNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtPrecio_Compra As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtDescipcion_prod As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
