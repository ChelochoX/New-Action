<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class COMPRAS_DE_PROVEEDOR
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
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnQuitar = New System.Windows.Forms.Button()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.rbExenta = New System.Windows.Forms.RadioButton()
        Me.rbIva5 = New System.Windows.Forms.RadioButton()
        Me.rbIva10 = New System.Windows.Forms.RadioButton()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lstProducto = New System.Windows.Forms.ListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbProveedor = New System.Windows.Forms.ComboBox()
        Me.dg_Detalle = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle3 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn15 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn16 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn17 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCancelar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btnSalir_cargo = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.rbMoneda_Gs = New System.Windows.Forms.RadioButton()
        Me.LBUSUARIOONLINE = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.LBFECHAACTUAL = New System.Windows.Forms.Label()
        Me.LBFECHAONLINE = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LBTOTAL_MONTO = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.LBIVA10 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.LBIVA5 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.LBTOTAL_ARTICULO = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.LBMONEDA = New System.Windows.Forms.Label()
        Me.LBFECHA = New System.Windows.Forms.Label()
        Me.LBFACTURA = New System.Windows.Forms.Label()
        Me.LBPROVEEDOR = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtFactura = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtBusqueda_por_Codigo = New System.Windows.Forms.TextBox()
        CType(Me.dg_Detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Green
        Me.Label12.Location = New System.Drawing.Point(9, 82)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(281, 23)
        Me.Label12.TabIndex = 1239
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(9, 59)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(281, 23)
        Me.Label11.TabIndex = 1238
        Me.Label11.Text = "MOVIMIENTO GENERADO N°"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnQuitar
        '
        Me.btnQuitar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnQuitar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnQuitar.Location = New System.Drawing.Point(885, 149)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(91, 27)
        Me.btnQuitar.TabIndex = 19
        Me.btnQuitar.Text = "Quitar"
        Me.btnQuitar.UseVisualStyleBackColor = False
        '
        'btnAgregar
        '
        Me.btnAgregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAgregar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnAgregar.Location = New System.Drawing.Point(790, 149)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(91, 27)
        Me.btnAgregar.TabIndex = 18
        Me.btnAgregar.Text = "Agregar"
        Me.btnAgregar.UseVisualStyleBackColor = False
        '
        'rbExenta
        '
        Me.rbExenta.AutoSize = True
        Me.rbExenta.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbExenta.ForeColor = System.Drawing.Color.Teal
        Me.rbExenta.Location = New System.Drawing.Point(908, 123)
        Me.rbExenta.Name = "rbExenta"
        Me.rbExenta.Size = New System.Drawing.Size(64, 17)
        Me.rbExenta.TabIndex = 17
        Me.rbExenta.TabStop = True
        Me.rbExenta.Text = "EXENTA"
        Me.rbExenta.UseVisualStyleBackColor = True
        '
        'rbIva5
        '
        Me.rbIva5.AutoSize = True
        Me.rbIva5.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbIva5.ForeColor = System.Drawing.Color.Teal
        Me.rbIva5.Location = New System.Drawing.Point(854, 123)
        Me.rbIva5.Name = "rbIva5"
        Me.rbIva5.Size = New System.Drawing.Size(50, 17)
        Me.rbIva5.TabIndex = 16
        Me.rbIva5.TabStop = True
        Me.rbIva5.Text = "IVA 5"
        Me.rbIva5.UseVisualStyleBackColor = True
        '
        'rbIva10
        '
        Me.rbIva10.AutoSize = True
        Me.rbIva10.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbIva10.ForeColor = System.Drawing.Color.Teal
        Me.rbIva10.Location = New System.Drawing.Point(794, 123)
        Me.rbIva10.Name = "rbIva10"
        Me.rbIva10.Size = New System.Drawing.Size(57, 17)
        Me.rbIva10.TabIndex = 15
        Me.rbIva10.TabStop = True
        Me.rbIva10.Text = "IVA 10 "
        Me.rbIva10.UseVisualStyleBackColor = True
        '
        'txtPrecio
        '
        Me.txtPrecio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPrecio.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPrecio.Location = New System.Drawing.Point(789, 74)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(186, 23)
        Me.txtPrecio.TabIndex = 14
        Me.txtPrecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(787, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(188, 20)
        Me.Label8.TabIndex = 1232
        Me.Label8.Text = "Precio Compra"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lstProducto
        '
        Me.lstProducto.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstProducto.ForeColor = System.Drawing.Color.Teal
        Me.lstProducto.FormattingEnabled = True
        Me.lstProducto.ItemHeight = 14
        Me.lstProducto.Location = New System.Drawing.Point(296, 56)
        Me.lstProducto.Name = "lstProducto"
        Me.lstProducto.Size = New System.Drawing.Size(490, 88)
        Me.lstProducto.TabIndex = 1212
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(508, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(276, 20)
        Me.Label5.TabIndex = 1231
        Me.Label5.Text = "BUSCAR ARTICULO POR NOMBRE"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(8, 263)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 23)
        Me.Label3.TabIndex = 1230
        Me.Label3.Text = "Fecha"
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(8, 236)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(124, 21)
        Me.Label7.TabIndex = 1228
        Me.Label7.Text = "Factura"
        '
        'cbProveedor
        '
        Me.cbProveedor.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProveedor.ForeColor = System.Drawing.Color.Navy
        Me.cbProveedor.FormattingEnabled = True
        Me.cbProveedor.Location = New System.Drawing.Point(83, 206)
        Me.cbProveedor.Name = "cbProveedor"
        Me.cbProveedor.Size = New System.Drawing.Size(207, 24)
        Me.cbProveedor.TabIndex = 1205
        '
        'dg_Detalle
        '
        Me.dg_Detalle.AlternatingBackColor = System.Drawing.Color.White
        Me.dg_Detalle.BackColor = System.Drawing.Color.White
        Me.dg_Detalle.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dg_Detalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dg_Detalle.CaptionBackColor = System.Drawing.Color.Silver
        Me.dg_Detalle.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dg_Detalle.CaptionForeColor = System.Drawing.Color.Black
        Me.dg_Detalle.DataMember = ""
        Me.dg_Detalle.FlatMode = True
        Me.dg_Detalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dg_Detalle.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.dg_Detalle.GridLineColor = System.Drawing.Color.DarkGray
        Me.dg_Detalle.HeaderBackColor = System.Drawing.Color.DarkGreen
        Me.dg_Detalle.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dg_Detalle.HeaderForeColor = System.Drawing.Color.White
        Me.dg_Detalle.LinkColor = System.Drawing.Color.DarkGreen
        Me.dg_Detalle.Location = New System.Drawing.Point(299, 183)
        Me.dg_Detalle.Name = "dg_Detalle"
        Me.dg_Detalle.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.dg_Detalle.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dg_Detalle.ReadOnly = True
        Me.dg_Detalle.RowHeadersVisible = False
        Me.dg_Detalle.SelectionBackColor = System.Drawing.Color.DarkSeaGreen
        Me.dg_Detalle.SelectionForeColor = System.Drawing.Color.Black
        Me.dg_Detalle.Size = New System.Drawing.Size(677, 499)
        Me.dg_Detalle.TabIndex = 1225
        Me.dg_Detalle.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle3})
        '
        'DataGridTableStyle3
        '
        Me.DataGridTableStyle3.DataGrid = Me.dg_Detalle
        Me.DataGridTableStyle3.ForeColor = System.Drawing.Color.Black
        Me.DataGridTableStyle3.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn15, Me.DataGridTextBoxColumn16, Me.DataGridTextBoxColumn17, Me.DataGridTextBoxColumn1})
        Me.DataGridTableStyle3.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DataGridTableStyle3.HeaderFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle3.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridTableStyle3.MappingName = "SC_DETALLE_COMPRA_PROV"
        Me.DataGridTableStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "PRODUCTO"
        Me.DataGridTextBoxColumn8.MappingName = "PRODUCTO"
        Me.DataGridTextBoxColumn8.Width = 200
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn9.Format = "n0"
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "CANTIDAD"
        Me.DataGridTextBoxColumn9.MappingName = "CANTIDAD"
        Me.DataGridTextBoxColumn9.Width = 85
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn10.Format = "n0"
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "PRECIO"
        Me.DataGridTextBoxColumn10.MappingName = "PRECIO"
        Me.DataGridTextBoxColumn10.Width = 85
        '
        'DataGridTextBoxColumn15
        '
        Me.DataGridTextBoxColumn15.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn15.Format = "n0"
        Me.DataGridTextBoxColumn15.FormatInfo = Nothing
        Me.DataGridTextBoxColumn15.HeaderText = "IVA5"
        Me.DataGridTextBoxColumn15.MappingName = "IVA5"
        Me.DataGridTextBoxColumn15.Width = 75
        '
        'DataGridTextBoxColumn16
        '
        Me.DataGridTextBoxColumn16.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn16.Format = "n0"
        Me.DataGridTextBoxColumn16.FormatInfo = Nothing
        Me.DataGridTextBoxColumn16.HeaderText = "IVA10"
        Me.DataGridTextBoxColumn16.MappingName = "IVA10"
        Me.DataGridTextBoxColumn16.Width = 75
        '
        'DataGridTextBoxColumn17
        '
        Me.DataGridTextBoxColumn17.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn17.Format = "n0"
        Me.DataGridTextBoxColumn17.FormatInfo = Nothing
        Me.DataGridTextBoxColumn17.HeaderText = "MONTO"
        Me.DataGridTextBoxColumn17.MappingName = "MONTO"
        Me.DataGridTextBoxColumn17.Width = 95
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.MappingName = "COD_DETALLE_COMPRA"
        Me.DataGridTextBoxColumn1.Width = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(9, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(281, 23)
        Me.Label1.TabIndex = 1229
        Me.Label1.Text = "FORMULARIO DE REGISTRO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCancelar
        '
        Me.txtCancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCancelar.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCancelar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCancelar.Location = New System.Drawing.Point(11, 614)
        Me.txtCancelar.Name = "txtCancelar"
        Me.txtCancelar.Size = New System.Drawing.Size(280, 31)
        Me.txtCancelar.TabIndex = 1324
        Me.txtCancelar.Text = "Cancelar"
        Me.txtCancelar.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnguardar.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnguardar.Location = New System.Drawing.Point(11, 577)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(280, 31)
        Me.btnguardar.TabIndex = 1323
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'btnSalir_cargo
        '
        Me.btnSalir_cargo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir_cargo.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir_cargo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir_cargo.Location = New System.Drawing.Point(11, 651)
        Me.btnSalir_cargo.Name = "btnSalir_cargo"
        Me.btnSalir_cargo.Size = New System.Drawing.Size(279, 31)
        Me.btnSalir_cargo.TabIndex = 1325
        Me.btnSalir_cargo.Text = "Salir"
        Me.btnSalir_cargo.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(8, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 20)
        Me.Label6.TabIndex = 1226
        Me.Label6.Text = "Proveedor"
        '
        'txtCantidad
        '
        Me.txtCantidad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCantidad.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCantidad.Location = New System.Drawing.Point(789, 27)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(186, 23)
        Me.txtCantidad.TabIndex = 13
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(790, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(185, 20)
        Me.Label4.TabIndex = 1227
        Me.Label4.Text = "Cantidad"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtBusqueda
        '
        Me.txtBusqueda.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBusqueda.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqueda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBusqueda.Location = New System.Drawing.Point(508, 27)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(276, 23)
        Me.txtBusqueda.TabIndex = 11
        Me.txtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(790, 104)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(185, 20)
        Me.Label9.TabIndex = 1233
        Me.Label9.Text = "IVA  del Producto"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'rbMoneda_Gs
        '
        Me.rbMoneda_Gs.AutoSize = True
        Me.rbMoneda_Gs.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbMoneda_Gs.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbMoneda_Gs.Location = New System.Drawing.Point(83, 291)
        Me.rbMoneda_Gs.Name = "rbMoneda_Gs"
        Me.rbMoneda_Gs.Size = New System.Drawing.Size(98, 21)
        Me.rbMoneda_Gs.TabIndex = 4
        Me.rbMoneda_Gs.TabStop = True
        Me.rbMoneda_Gs.Text = "GUARANIES"
        Me.rbMoneda_Gs.UseVisualStyleBackColor = True
        '
        'LBUSUARIOONLINE
        '
        Me.LBUSUARIOONLINE.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LBUSUARIOONLINE.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBUSUARIOONLINE.ForeColor = System.Drawing.Color.Green
        Me.LBUSUARIOONLINE.Location = New System.Drawing.Point(9, 129)
        Me.LBUSUARIOONLINE.Name = "LBUSUARIOONLINE"
        Me.LBUSUARIOONLINE.Size = New System.Drawing.Size(281, 24)
        Me.LBUSUARIOONLINE.TabIndex = 1328
        Me.LBUSUARIOONLINE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Label15.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(9, 106)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(281, 23)
        Me.Label15.TabIndex = 1327
        Me.Label15.Text = "USUARIO EN LINEA"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBFECHAACTUAL
        '
        Me.LBFECHAACTUAL.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LBFECHAACTUAL.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBFECHAACTUAL.ForeColor = System.Drawing.Color.Green
        Me.LBFECHAACTUAL.Location = New System.Drawing.Point(9, 176)
        Me.LBFECHAACTUAL.Name = "LBFECHAACTUAL"
        Me.LBFECHAACTUAL.Size = New System.Drawing.Size(281, 24)
        Me.LBFECHAACTUAL.TabIndex = 1332
        Me.LBFECHAACTUAL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBFECHAONLINE
        '
        Me.LBFECHAONLINE.BackColor = System.Drawing.Color.WhiteSmoke
        Me.LBFECHAONLINE.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBFECHAONLINE.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LBFECHAONLINE.Location = New System.Drawing.Point(9, 153)
        Me.LBFECHAONLINE.Name = "LBFECHAONLINE"
        Me.LBFECHAONLINE.Size = New System.Drawing.Size(281, 23)
        Me.LBFECHAONLINE.TabIndex = 1331
        Me.LBFECHAONLINE.Text = "FECHA ACTUAL"
        Me.LBFECHAONLINE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label20
        '
        Me.Label20.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label20.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Green
        Me.Label20.Location = New System.Drawing.Point(9, 31)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(281, 28)
        Me.Label20.TabIndex = 1333
        Me.Label20.Text = "COMPRAS DE PROVEEDOR"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LBTOTAL_MONTO)
        Me.GroupBox2.Controls.Add(Me.Label36)
        Me.GroupBox2.Controls.Add(Me.LBIVA10)
        Me.GroupBox2.Controls.Add(Me.Label35)
        Me.GroupBox2.Controls.Add(Me.LBIVA5)
        Me.GroupBox2.Controls.Add(Me.Label34)
        Me.GroupBox2.Controls.Add(Me.LBTOTAL_ARTICULO)
        Me.GroupBox2.Controls.Add(Me.Label31)
        Me.GroupBox2.Controls.Add(Me.LBMONEDA)
        Me.GroupBox2.Controls.Add(Me.LBFECHA)
        Me.GroupBox2.Controls.Add(Me.LBFACTURA)
        Me.GroupBox2.Controls.Add(Me.LBPROVEEDOR)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(11, 321)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(280, 250)
        Me.GroupBox2.TabIndex = 1334
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DETALLE ENCABEZADO COMPRA"
        '
        'LBTOTAL_MONTO
        '
        Me.LBTOTAL_MONTO.BackColor = System.Drawing.Color.White
        Me.LBTOTAL_MONTO.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBTOTAL_MONTO.ForeColor = System.Drawing.Color.Red
        Me.LBTOTAL_MONTO.Location = New System.Drawing.Point(89, 211)
        Me.LBTOTAL_MONTO.Name = "LBTOTAL_MONTO"
        Me.LBTOTAL_MONTO.Size = New System.Drawing.Size(179, 26)
        Me.LBTOTAL_MONTO.TabIndex = 1346
        Me.LBTOTAL_MONTO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label36
        '
        Me.Label36.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label36.Location = New System.Drawing.Point(5, 211)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(113, 26)
        Me.Label36.TabIndex = 1345
        Me.Label36.Text = "TOTAL MONTO"
        Me.Label36.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBIVA10
        '
        Me.LBIVA10.BackColor = System.Drawing.Color.White
        Me.LBIVA10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBIVA10.ForeColor = System.Drawing.Color.Red
        Me.LBIVA10.Location = New System.Drawing.Point(89, 185)
        Me.LBIVA10.Name = "LBIVA10"
        Me.LBIVA10.Size = New System.Drawing.Size(179, 26)
        Me.LBIVA10.TabIndex = 1344
        Me.LBIVA10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label35
        '
        Me.Label35.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label35.Location = New System.Drawing.Point(5, 185)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(113, 26)
        Me.Label35.TabIndex = 1343
        Me.Label35.Text = "TOTAL IVA10"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBIVA5
        '
        Me.LBIVA5.BackColor = System.Drawing.Color.White
        Me.LBIVA5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBIVA5.ForeColor = System.Drawing.Color.Red
        Me.LBIVA5.Location = New System.Drawing.Point(89, 159)
        Me.LBIVA5.Name = "LBIVA5"
        Me.LBIVA5.Size = New System.Drawing.Size(179, 26)
        Me.LBIVA5.TabIndex = 1342
        Me.LBIVA5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label34
        '
        Me.Label34.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label34.Location = New System.Drawing.Point(5, 159)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(113, 26)
        Me.Label34.TabIndex = 1341
        Me.Label34.Text = "TOTAL IVA5"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBTOTAL_ARTICULO
        '
        Me.LBTOTAL_ARTICULO.BackColor = System.Drawing.Color.White
        Me.LBTOTAL_ARTICULO.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBTOTAL_ARTICULO.ForeColor = System.Drawing.Color.Red
        Me.LBTOTAL_ARTICULO.Location = New System.Drawing.Point(89, 133)
        Me.LBTOTAL_ARTICULO.Name = "LBTOTAL_ARTICULO"
        Me.LBTOTAL_ARTICULO.Size = New System.Drawing.Size(179, 26)
        Me.LBTOTAL_ARTICULO.TabIndex = 1340
        Me.LBTOTAL_ARTICULO.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label31
        '
        Me.Label31.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label31.Location = New System.Drawing.Point(5, 133)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(113, 26)
        Me.Label31.TabIndex = 1339
        Me.Label31.Text = "TOTAL ARTIC."
        Me.Label31.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LBMONEDA
        '
        Me.LBMONEDA.BackColor = System.Drawing.Color.White
        Me.LBMONEDA.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBMONEDA.ForeColor = System.Drawing.Color.Red
        Me.LBMONEDA.Location = New System.Drawing.Point(89, 107)
        Me.LBMONEDA.Name = "LBMONEDA"
        Me.LBMONEDA.Size = New System.Drawing.Size(179, 26)
        Me.LBMONEDA.TabIndex = 1338
        Me.LBMONEDA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBFECHA
        '
        Me.LBFECHA.BackColor = System.Drawing.Color.White
        Me.LBFECHA.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBFECHA.ForeColor = System.Drawing.Color.Red
        Me.LBFECHA.Location = New System.Drawing.Point(89, 77)
        Me.LBFECHA.Name = "LBFECHA"
        Me.LBFECHA.Size = New System.Drawing.Size(179, 30)
        Me.LBFECHA.TabIndex = 1337
        Me.LBFECHA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBFACTURA
        '
        Me.LBFACTURA.BackColor = System.Drawing.Color.White
        Me.LBFACTURA.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBFACTURA.ForeColor = System.Drawing.Color.Red
        Me.LBFACTURA.Location = New System.Drawing.Point(89, 52)
        Me.LBFACTURA.Name = "LBFACTURA"
        Me.LBFACTURA.Size = New System.Drawing.Size(179, 25)
        Me.LBFACTURA.TabIndex = 1336
        Me.LBFACTURA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LBPROVEEDOR
        '
        Me.LBPROVEEDOR.BackColor = System.Drawing.Color.White
        Me.LBPROVEEDOR.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBPROVEEDOR.ForeColor = System.Drawing.Color.Red
        Me.LBPROVEEDOR.Location = New System.Drawing.Point(89, 24)
        Me.LBPROVEEDOR.Name = "LBPROVEEDOR"
        Me.LBPROVEEDOR.Size = New System.Drawing.Size(179, 28)
        Me.LBPROVEEDOR.TabIndex = 1335
        Me.LBPROVEEDOR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label24
        '
        Me.Label24.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label24.Location = New System.Drawing.Point(5, 107)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(113, 26)
        Me.Label24.TabIndex = 1232
        Me.Label24.Text = "MONEDA"
        Me.Label24.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label23.Location = New System.Drawing.Point(5, 77)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(83, 30)
        Me.Label23.TabIndex = 1231
        Me.Label23.Text = "FECHA"
        Me.Label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label22
        '
        Me.Label22.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label22.Location = New System.Drawing.Point(5, 52)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(124, 25)
        Me.Label22.TabIndex = 1229
        Me.Label22.Text = "FACTURA"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label21.Location = New System.Drawing.Point(5, 24)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(87, 28)
        Me.Label21.TabIndex = 1227
        Me.Label21.Text = "PROVEEDOR"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(300, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(490, 20)
        Me.Label2.TabIndex = 1335
        Me.Label2.Text = "DETALLE DE PRODUCTOS PARA INGRESAR"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(10, 291)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 23)
        Me.Label10.TabIndex = 1360
        Me.Label10.Text = "Moneda"
        '
        'txtFactura
        '
        Me.txtFactura.BackColor = System.Drawing.Color.White
        Me.txtFactura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFactura.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFactura.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFactura.Location = New System.Drawing.Point(83, 234)
        Me.txtFactura.Name = "txtFactura"
        Me.txtFactura.Size = New System.Drawing.Size(207, 23)
        Me.txtFactura.TabIndex = 0
        Me.txtFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DateTimePicker1.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DateTimePicker1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(83, 263)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(207, 22)
        Me.DateTimePicker1.TabIndex = 1361
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(296, 7)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(208, 20)
        Me.Label13.TabIndex = 1362
        Me.Label13.Text = "BUSCAR ARTICULO POR CODIGO"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtBusqueda_por_Codigo
        '
        Me.txtBusqueda_por_Codigo.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBusqueda_por_Codigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBusqueda_por_Codigo.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqueda_por_Codigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBusqueda_por_Codigo.Location = New System.Drawing.Point(296, 27)
        Me.txtBusqueda_por_Codigo.Name = "txtBusqueda_por_Codigo"
        Me.txtBusqueda_por_Codigo.Size = New System.Drawing.Size(208, 23)
        Me.txtBusqueda_por_Codigo.TabIndex = 10
        Me.txtBusqueda_por_Codigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'COMPRAS_DE_PROVEEDOR
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(997, 696)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtBusqueda_por_Codigo)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.rbMoneda_Gs)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.LBFECHAACTUAL)
        Me.Controls.Add(Me.LBFECHAONLINE)
        Me.Controls.Add(Me.LBUSUARIOONLINE)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.rbExenta)
        Me.Controls.Add(Me.rbIva5)
        Me.Controls.Add(Me.rbIva10)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lstProducto)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbProveedor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCancelar)
        Me.Controls.Add(Me.txtFactura)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btnSalir_cargo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.dg_Detalle)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label5)
        Me.Name = "COMPRAS_DE_PROVEEDOR"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SISTEMA DE GESTION DE COMPRAS Y VENTAS VERSION (E) V1.1.0          CONSULTAS Y PR" & _
            "ECIOS AL 0994 60 60 48  / 0982 12 12 69     *** TU VENDEDOR SOFT ***"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dg_Detalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents rbExenta As System.Windows.Forms.RadioButton
    Friend WithEvents rbIva5 As System.Windows.Forms.RadioButton
    Friend WithEvents rbIva10 As System.Windows.Forms.RadioButton
    Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lstProducto As System.Windows.Forms.ListBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cbProveedor As System.Windows.Forms.ComboBox
    Friend WithEvents dg_Detalle As System.Windows.Forms.DataGrid
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCancelar As System.Windows.Forms.Button
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents btnSalir_cargo As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DataGridTableStyle3 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn15 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn16 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn17 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents rbMoneda_Gs As System.Windows.Forms.RadioButton
    Friend WithEvents LBUSUARIOONLINE As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents LBFECHAACTUAL As System.Windows.Forms.Label
    Friend WithEvents LBFECHAONLINE As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents LBMONEDA As System.Windows.Forms.Label
    Friend WithEvents LBFECHA As System.Windows.Forms.Label
    Friend WithEvents LBFACTURA As System.Windows.Forms.Label
    Friend WithEvents LBPROVEEDOR As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LBTOTAL_ARTICULO As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents LBIVA5 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents LBIVA10 As System.Windows.Forms.Label
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents LBTOTAL_MONTO As System.Windows.Forms.Label
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtFactura As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtBusqueda_por_Codigo As System.Windows.Forms.TextBox
End Class
