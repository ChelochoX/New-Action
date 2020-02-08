<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GESTIONAR_TRASLADO_DE_PRODUCTOS
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
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.lstProducto = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lstDeposito = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbSacar_Producto_otroDeposito = New System.Windows.Forms.RadioButton()
        Me.rbIngresar_Producto_otroDeposito = New System.Windows.Forms.RadioButton()
        Me.txtResponsable1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtResponsable2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btnIngresarMercaderia = New System.Windows.Forms.Button()
        Me.txtDeposito = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtResponsable_2 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtResponsable_1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dg_detalle = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtTotal_Producto = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnCancelar_Operacion = New System.Windows.Forms.Button()
        Me.btnGuardar_Operacion = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dg_detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBusqueda
        '
        Me.txtBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBusqueda.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqueda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBusqueda.Location = New System.Drawing.Point(12, 325)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(333, 25)
        Me.txtBusqueda.TabIndex = 6
        Me.txtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lstProducto
        '
        Me.lstProducto.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lstProducto.FormattingEnabled = True
        Me.lstProducto.ItemHeight = 17
        Me.lstProducto.Location = New System.Drawing.Point(12, 354)
        Me.lstProducto.Name = "lstProducto"
        Me.lstProducto.Size = New System.Drawing.Size(333, 72)
        Me.lstProducto.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Green
        Me.Label6.Location = New System.Drawing.Point(12, 305)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(333, 20)
        Me.Label6.TabIndex = 1281
        Me.Label6.Text = "BUSCAR PRODUCTO"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstDeposito
        '
        Me.lstDeposito.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDeposito.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lstDeposito.FormattingEnabled = True
        Me.lstDeposito.ItemHeight = 17
        Me.lstDeposito.Location = New System.Drawing.Point(13, 140)
        Me.lstDeposito.Name = "lstDeposito"
        Me.lstDeposito.Size = New System.Drawing.Size(333, 72)
        Me.lstDeposito.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Teal
        Me.Label1.Location = New System.Drawing.Point(13, 119)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(333, 20)
        Me.Label1.TabIndex = 1284
        Me.Label1.Text = "SELECCIONAR DEPOSITO AFECTADO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCantidad
        '
        Me.txtCantidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCantidad.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCantidad.Location = New System.Drawing.Point(12, 448)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(333, 25)
        Me.txtCantidad.TabIndex = 8
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(12, 428)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(333, 20)
        Me.Label3.TabIndex = 1286
        Me.Label3.Text = "INGRESAR CANTIDAD PRODUCTO"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbSacar_Producto_otroDeposito)
        Me.GroupBox2.Controls.Add(Me.rbIngresar_Producto_otroDeposito)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(333, 108)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SELECCIONAR ACCION A REALIZAR"
        '
        'rbSacar_Producto_otroDeposito
        '
        Me.rbSacar_Producto_otroDeposito.AutoSize = True
        Me.rbSacar_Producto_otroDeposito.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSacar_Producto_otroDeposito.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbSacar_Producto_otroDeposito.Location = New System.Drawing.Point(14, 53)
        Me.rbSacar_Producto_otroDeposito.Name = "rbSacar_Producto_otroDeposito"
        Me.rbSacar_Producto_otroDeposito.Size = New System.Drawing.Size(279, 21)
        Me.rbSacar_Producto_otroDeposito.TabIndex = 2
        Me.rbSacar_Producto_otroDeposito.TabStop = True
        Me.rbSacar_Producto_otroDeposito.Text = "SACAR PRODUCTO PARA OTRO DEPOSITO"
        Me.rbSacar_Producto_otroDeposito.UseVisualStyleBackColor = True
        '
        'rbIngresar_Producto_otroDeposito
        '
        Me.rbIngresar_Producto_otroDeposito.AutoSize = True
        Me.rbIngresar_Producto_otroDeposito.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbIngresar_Producto_otroDeposito.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbIngresar_Producto_otroDeposito.Location = New System.Drawing.Point(14, 26)
        Me.rbIngresar_Producto_otroDeposito.Name = "rbIngresar_Producto_otroDeposito"
        Me.rbIngresar_Producto_otroDeposito.Size = New System.Drawing.Size(283, 21)
        Me.rbIngresar_Producto_otroDeposito.TabIndex = 1
        Me.rbIngresar_Producto_otroDeposito.TabStop = True
        Me.rbIngresar_Producto_otroDeposito.Text = "INGRESAR PRODUCTO DE OTRO DEPOSITO"
        Me.rbIngresar_Producto_otroDeposito.UseVisualStyleBackColor = True
        '
        'txtResponsable1
        '
        Me.txtResponsable1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtResponsable1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResponsable1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtResponsable1.Location = New System.Drawing.Point(13, 233)
        Me.txtResponsable1.Name = "txtResponsable1"
        Me.txtResponsable1.Size = New System.Drawing.Size(333, 25)
        Me.txtResponsable1.TabIndex = 4
        Me.txtResponsable1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Teal
        Me.Label2.Location = New System.Drawing.Point(13, 213)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(333, 20)
        Me.Label2.TabIndex = 1289
        Me.Label2.Text = "RESPONSABLE DE ENTREGA"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtResponsable2
        '
        Me.txtResponsable2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtResponsable2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResponsable2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtResponsable2.Location = New System.Drawing.Point(13, 278)
        Me.txtResponsable2.Name = "txtResponsable2"
        Me.txtResponsable2.Size = New System.Drawing.Size(333, 25)
        Me.txtResponsable2.TabIndex = 5
        Me.txtResponsable2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Teal
        Me.Label4.Location = New System.Drawing.Point(13, 258)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(333, 20)
        Me.Label4.TabIndex = 1291
        Me.Label4.Text = "RESPONSABLE DE RECIBIR"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(371, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(576, 23)
        Me.Label5.TabIndex = 1292
        Me.Label5.Text = "DETALLES DE PRODUCTOS EN TRASLADO"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtFecha
        '
        Me.txtFecha.BackColor = System.Drawing.Color.White
        Me.txtFecha.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.ForeColor = System.Drawing.Color.ForestGreen
        Me.txtFecha.Location = New System.Drawing.Point(496, 52)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(451, 28)
        Me.txtFecha.TabIndex = 1309
        Me.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(374, 52)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(127, 28)
        Me.Label12.TabIndex = 1306
        Me.Label12.Text = "FECHA"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnIngresarMercaderia
        '
        Me.btnIngresarMercaderia.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnIngresarMercaderia.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresarMercaderia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnIngresarMercaderia.Location = New System.Drawing.Point(12, 479)
        Me.btnIngresarMercaderia.Name = "btnIngresarMercaderia"
        Me.btnIngresarMercaderia.Size = New System.Drawing.Size(334, 28)
        Me.btnIngresarMercaderia.TabIndex = 9
        Me.btnIngresarMercaderia.Text = "INGRESAR MERCADERIA"
        Me.btnIngresarMercaderia.UseVisualStyleBackColor = False
        '
        'txtDeposito
        '
        Me.txtDeposito.BackColor = System.Drawing.Color.White
        Me.txtDeposito.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeposito.ForeColor = System.Drawing.Color.ForestGreen
        Me.txtDeposito.Location = New System.Drawing.Point(496, 83)
        Me.txtDeposito.Name = "txtDeposito"
        Me.txtDeposito.ReadOnly = True
        Me.txtDeposito.Size = New System.Drawing.Size(451, 28)
        Me.txtDeposito.TabIndex = 1313
        Me.txtDeposito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(374, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 28)
        Me.Label7.TabIndex = 1312
        Me.Label7.Text = "DEPOSITO "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtResponsable_2
        '
        Me.txtResponsable_2.BackColor = System.Drawing.Color.White
        Me.txtResponsable_2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResponsable_2.ForeColor = System.Drawing.Color.ForestGreen
        Me.txtResponsable_2.Location = New System.Drawing.Point(496, 145)
        Me.txtResponsable_2.Name = "txtResponsable_2"
        Me.txtResponsable_2.ReadOnly = True
        Me.txtResponsable_2.Size = New System.Drawing.Size(451, 28)
        Me.txtResponsable_2.TabIndex = 1317
        Me.txtResponsable_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(374, 145)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 28)
        Me.Label8.TabIndex = 1316
        Me.Label8.Text = "RESPONSABLE 2"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtResponsable_1
        '
        Me.txtResponsable_1.BackColor = System.Drawing.Color.White
        Me.txtResponsable_1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResponsable_1.ForeColor = System.Drawing.Color.ForestGreen
        Me.txtResponsable_1.Location = New System.Drawing.Point(496, 114)
        Me.txtResponsable_1.Name = "txtResponsable_1"
        Me.txtResponsable_1.ReadOnly = True
        Me.txtResponsable_1.Size = New System.Drawing.Size(451, 28)
        Me.txtResponsable_1.TabIndex = 1315
        Me.txtResponsable_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(374, 114)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(127, 28)
        Me.Label9.TabIndex = 1314
        Me.Label9.Text = "RESPONSABLE 1"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dg_detalle
        '
        Me.dg_detalle.AlternatingBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.dg_detalle.BackColor = System.Drawing.Color.White
        Me.dg_detalle.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow
        Me.dg_detalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dg_detalle.CaptionBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.dg_detalle.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dg_detalle.CaptionForeColor = System.Drawing.Color.DarkSlateBlue
        Me.dg_detalle.DataMember = ""
        Me.dg_detalle.FlatMode = True
        Me.dg_detalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dg_detalle.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.dg_detalle.GridLineColor = System.Drawing.Color.Peru
        Me.dg_detalle.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dg_detalle.HeaderBackColor = System.Drawing.Color.Maroon
        Me.dg_detalle.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dg_detalle.HeaderForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.dg_detalle.LinkColor = System.Drawing.Color.Maroon
        Me.dg_detalle.Location = New System.Drawing.Point(371, 227)
        Me.dg_detalle.Name = "dg_detalle"
        Me.dg_detalle.ParentRowsBackColor = System.Drawing.Color.BurlyWood
        Me.dg_detalle.ParentRowsForeColor = System.Drawing.Color.DarkSlateBlue
        Me.dg_detalle.ReadOnly = True
        Me.dg_detalle.RowHeadersVisible = False
        Me.dg_detalle.SelectionBackColor = System.Drawing.Color.DarkSlateBlue
        Me.dg_detalle.SelectionForeColor = System.Drawing.Color.GhostWhite
        Me.dg_detalle.Size = New System.Drawing.Size(576, 216)
        Me.dg_detalle.TabIndex = 1318
        Me.dg_detalle.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dg_detalle
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "SC_DET_ROTACION_MERCADERIAS"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "CODIGO"
        Me.DataGridTextBoxColumn1.MappingName = "CODIGO_PRODUCTO"
        Me.DataGridTextBoxColumn1.Width = 120
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "PRODUCTO EN TRASLADO"
        Me.DataGridTextBoxColumn2.MappingName = "NOMBRE_PRODUCTO"
        Me.DataGridTextBoxColumn2.Width = 250
        '
        'txtObservacion
        '
        Me.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacion.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacion.ForeColor = System.Drawing.Color.Green
        Me.txtObservacion.Location = New System.Drawing.Point(496, 179)
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(451, 41)
        Me.txtObservacion.TabIndex = 1318
        Me.txtObservacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(374, 179)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(127, 23)
        Me.Label10.TabIndex = 1319
        Me.Label10.Text = "OBSERVACION"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTotal_Producto
        '
        Me.txtTotal_Producto.BackColor = System.Drawing.Color.White
        Me.txtTotal_Producto.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal_Producto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotal_Producto.Location = New System.Drawing.Point(760, 449)
        Me.txtTotal_Producto.Name = "txtTotal_Producto"
        Me.txtTotal_Producto.ReadOnly = True
        Me.txtTotal_Producto.Size = New System.Drawing.Size(187, 25)
        Me.txtTotal_Producto.TabIndex = 1322
        Me.txtTotal_Producto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label11
        '
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(637, 449)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(127, 25)
        Me.Label11.TabIndex = 1321
        Me.Label11.Text = "TOTAL PRODUCTOS"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnCancelar_Operacion
        '
        Me.btnCancelar_Operacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCancelar_Operacion.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar_Operacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCancelar_Operacion.Location = New System.Drawing.Point(377, 482)
        Me.btnCancelar_Operacion.Name = "btnCancelar_Operacion"
        Me.btnCancelar_Operacion.Size = New System.Drawing.Size(257, 28)
        Me.btnCancelar_Operacion.TabIndex = 20
        Me.btnCancelar_Operacion.Text = "CANCELAR OPERACION"
        Me.btnCancelar_Operacion.UseVisualStyleBackColor = False
        '
        'btnGuardar_Operacion
        '
        Me.btnGuardar_Operacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnGuardar_Operacion.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar_Operacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnGuardar_Operacion.Location = New System.Drawing.Point(690, 482)
        Me.btnGuardar_Operacion.Name = "btnGuardar_Operacion"
        Me.btnGuardar_Operacion.Size = New System.Drawing.Size(257, 28)
        Me.btnGuardar_Operacion.TabIndex = 21
        Me.btnGuardar_Operacion.Text = "PROCESAR TRASLADO"
        Me.btnGuardar_Operacion.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.White
        Me.btnSalir.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.Location = New System.Drawing.Point(690, 516)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(257, 28)
        Me.btnSalir.TabIndex = 23
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnImprimir.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnImprimir.Location = New System.Drawing.Point(377, 516)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(257, 28)
        Me.btnImprimir.TabIndex = 22
        Me.btnImprimir.Text = "IMPRIMIR TRASLADO"
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(575, 276)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(150, 150)
        Me.CrystalReportViewer1.TabIndex = 1328
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn3.Format = "n0"
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "CANTIDAD"
        Me.DataGridTextBoxColumn3.MappingName = "CANTIDAD"
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'GESTIONAR_TRASLADO_DE_PRODUCTOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(961, 552)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnGuardar_Operacion)
        Me.Controls.Add(Me.btnCancelar_Operacion)
        Me.Controls.Add(Me.txtTotal_Producto)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtObservacion)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dg_detalle)
        Me.Controls.Add(Me.txtResponsable_2)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtResponsable_1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtDeposito)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnIngresarMercaderia)
        Me.Controls.Add(Me.txtFecha)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtResponsable2)
        Me.Controls.Add(Me.txtResponsable1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.lstDeposito)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.lstProducto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Name = "GESTIONAR_TRASLADO_DE_PRODUCTOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GESTIONAR TRASLADO DE PRODUCTOS"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dg_detalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents lstProducto As System.Windows.Forms.ListBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lstDeposito As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbIngresar_Producto_otroDeposito As System.Windows.Forms.RadioButton
    Friend WithEvents rbSacar_Producto_otroDeposito As System.Windows.Forms.RadioButton
    Friend WithEvents txtResponsable1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtResponsable2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnIngresarMercaderia As System.Windows.Forms.Button
    Friend WithEvents txtDeposito As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtResponsable_2 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtResponsable_1 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents dg_detalle As System.Windows.Forms.DataGrid
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtTotal_Producto As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnCancelar_Operacion As System.Windows.Forms.Button
    Friend WithEvents btnGuardar_Operacion As System.Windows.Forms.Button
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
End Class
