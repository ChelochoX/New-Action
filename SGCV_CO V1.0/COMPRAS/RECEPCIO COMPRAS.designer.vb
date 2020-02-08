<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RECEPCIO_COMPRAS
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
        Me.rbVer_soloPendientes = New System.Windows.Forms.RadioButton()
        Me.dg_Detalle = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn18 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn19 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn20 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.rbVer_PendientesyProcesados = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnVer_Compras = New System.Windows.Forms.Button()
        Me.txtDeposito = New System.Windows.Forms.TextBox()
        Me.DataGridTextBoxColumn15 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTableStyle3 = New System.Windows.Forms.DataGridTableStyle()
        Me.dgCabecera = New System.Windows.Forms.DataGrid()
        Me.DataGridTextBoxColumn16 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn17 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.btnIngresar_aDeposito = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.rbPrecio_NO_Modificado = New System.Windows.Forms.RadioButton()
        Me.rbPrecio_Modificado = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dg_Detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgCabecera, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rbVer_soloPendientes
        '
        Me.rbVer_soloPendientes.AutoSize = True
        Me.rbVer_soloPendientes.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbVer_soloPendientes.ForeColor = System.Drawing.Color.Teal
        Me.rbVer_soloPendientes.Location = New System.Drawing.Point(16, 122)
        Me.rbVer_soloPendientes.Name = "rbVer_soloPendientes"
        Me.rbVer_soloPendientes.Size = New System.Drawing.Size(139, 21)
        Me.rbVer_soloPendientes.TabIndex = 1255
        Me.rbVer_soloPendientes.TabStop = True
        Me.rbVer_soloPendientes.Text = "SOLO PENDIENTES"
        Me.rbVer_soloPendientes.UseVisualStyleBackColor = True
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
        Me.dg_Detalle.Location = New System.Drawing.Point(262, 240)
        Me.dg_Detalle.Name = "dg_Detalle"
        Me.dg_Detalle.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.dg_Detalle.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dg_Detalle.ReadOnly = True
        Me.dg_Detalle.RowHeadersVisible = False
        Me.dg_Detalle.SelectionBackColor = System.Drawing.Color.DarkSeaGreen
        Me.dg_Detalle.SelectionForeColor = System.Drawing.Color.Black
        Me.dg_Detalle.Size = New System.Drawing.Size(700, 326)
        Me.dg_Detalle.TabIndex = 1243
        Me.dg_Detalle.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dg_Detalle
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn18, Me.DataGridTextBoxColumn19, Me.DataGridTextBoxColumn20})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "SC_DETALLE_COMPRA_PROV"
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "PRODUCTO"
        Me.DataGridTextBoxColumn2.MappingName = "PRODUCTO"
        Me.DataGridTextBoxColumn2.Width = 90
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn3.Format = "n0"
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "CANTIDAD"
        Me.DataGridTextBoxColumn3.MappingName = "CANTIDAD"
        Me.DataGridTextBoxColumn3.Width = 65
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn4.Format = "n0"
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "PRECIO"
        Me.DataGridTextBoxColumn4.MappingName = "PRECIO"
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn12.Format = "n0"
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "IVA5"
        Me.DataGridTextBoxColumn12.MappingName = "IVA5"
        Me.DataGridTextBoxColumn12.Width = 65
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn13.Format = "n0"
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.HeaderText = "IVA10"
        Me.DataGridTextBoxColumn13.MappingName = "IVA10"
        Me.DataGridTextBoxColumn13.Width = 65
        '
        'DataGridTextBoxColumn18
        '
        Me.DataGridTextBoxColumn18.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn18.Format = "n0"
        Me.DataGridTextBoxColumn18.FormatInfo = Nothing
        Me.DataGridTextBoxColumn18.HeaderText = "MONTO"
        Me.DataGridTextBoxColumn18.MappingName = "MONTO"
        Me.DataGridTextBoxColumn18.Width = 85
        '
        'DataGridTextBoxColumn19
        '
        Me.DataGridTextBoxColumn19.Format = ""
        Me.DataGridTextBoxColumn19.FormatInfo = Nothing
        Me.DataGridTextBoxColumn19.MappingName = "COD_DETALLE_COMPRA"
        Me.DataGridTextBoxColumn19.Width = 0
        '
        'DataGridTextBoxColumn20
        '
        Me.DataGridTextBoxColumn20.Format = ""
        Me.DataGridTextBoxColumn20.FormatInfo = Nothing
        Me.DataGridTextBoxColumn20.MappingName = "COD_COMPRA"
        Me.DataGridTextBoxColumn20.Width = 0
        '
        'rbVer_PendientesyProcesados
        '
        Me.rbVer_PendientesyProcesados.AutoSize = True
        Me.rbVer_PendientesyProcesados.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbVer_PendientesyProcesados.ForeColor = System.Drawing.Color.Teal
        Me.rbVer_PendientesyProcesados.Location = New System.Drawing.Point(16, 96)
        Me.rbVer_PendientesyProcesados.Name = "rbVer_PendientesyProcesados"
        Me.rbVer_PendientesyProcesados.Size = New System.Drawing.Size(130, 21)
        Me.rbVer_PendientesyProcesados.TabIndex = 1254
        Me.rbVer_PendientesyProcesados.TabStop = True
        Me.rbVer_PendientesyProcesados.Text = "VER EN GENERAL"
        Me.rbVer_PendientesyProcesados.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(12, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(158, 20)
        Me.Label5.TabIndex = 1253
        Me.Label5.Text = "VISUALIZAR POR"
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.Location = New System.Drawing.Point(12, 411)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(243, 27)
        Me.btnSalir.TabIndex = 1252
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CalendarForeColor = System.Drawing.Color.Navy
        Me.DateTimePicker2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(137, 29)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(118, 25)
        Me.DateTimePicker2.TabIndex = 1250
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(134, 7)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 23)
        Me.Label4.TabIndex = 1251
        Me.Label4.Text = "FECHA FIN"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnVer_Compras
        '
        Me.btnVer_Compras.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnVer_Compras.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVer_Compras.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnVer_Compras.Location = New System.Drawing.Point(11, 149)
        Me.btnVer_Compras.Name = "btnVer_Compras"
        Me.btnVer_Compras.Size = New System.Drawing.Size(244, 27)
        Me.btnVer_Compras.TabIndex = 1249
        Me.btnVer_Compras.Text = "VISUALIZAR COMPRAS"
        Me.btnVer_Compras.UseVisualStyleBackColor = False
        '
        'txtDeposito
        '
        Me.txtDeposito.BackColor = System.Drawing.Color.White
        Me.txtDeposito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDeposito.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeposito.ForeColor = System.Drawing.Color.Green
        Me.txtDeposito.Location = New System.Drawing.Point(11, 218)
        Me.txtDeposito.Name = "txtDeposito"
        Me.txtDeposito.ReadOnly = True
        Me.txtDeposito.Size = New System.Drawing.Size(244, 29)
        Me.txtDeposito.TabIndex = 1236
        Me.txtDeposito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DataGridTextBoxColumn15
        '
        Me.DataGridTextBoxColumn15.Format = ""
        Me.DataGridTextBoxColumn15.FormatInfo = Nothing
        Me.DataGridTextBoxColumn15.HeaderText = "PROVEEDOR"
        Me.DataGridTextBoxColumn15.MappingName = "PROVEEDOR"
        Me.DataGridTextBoxColumn15.Width = 250
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(13, 257)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(242, 20)
        Me.Label9.TabIndex = 1246
        Me.Label9.Text = "SELECCIONAR ACCIONES SOBRE PRECIO"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(11, 195)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(244, 20)
        Me.Label2.TabIndex = 1248
        Me.Label2.Text = "DEPOSITO DE RECEPCION"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "FECHA"
        Me.DataGridTextBoxColumn14.MappingName = "FECHA"
        Me.DataGridTextBoxColumn14.Width = 95
        '
        'DataGridTableStyle3
        '
        Me.DataGridTableStyle3.ColumnHeadersVisible = False
        Me.DataGridTableStyle3.DataGrid = Me.dgCabecera
        Me.DataGridTableStyle3.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn14, Me.DataGridTextBoxColumn15, Me.DataGridTextBoxColumn16, Me.DataGridTextBoxColumn17, Me.DataGridTextBoxColumn1})
        Me.DataGridTableStyle3.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DataGridTableStyle3.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridTableStyle3.MappingName = "SC_COMPRA_PROVEEDOR"
        Me.DataGridTableStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'dgCabecera
        '
        Me.dgCabecera.AlternatingBackColor = System.Drawing.Color.White
        Me.dgCabecera.BackColor = System.Drawing.Color.White
        Me.dgCabecera.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgCabecera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgCabecera.CaptionBackColor = System.Drawing.Color.Silver
        Me.dgCabecera.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dgCabecera.CaptionForeColor = System.Drawing.Color.Black
        Me.dgCabecera.CaptionVisible = False
        Me.dgCabecera.DataMember = ""
        Me.dgCabecera.FlatMode = True
        Me.dgCabecera.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dgCabecera.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.dgCabecera.GridLineColor = System.Drawing.Color.DarkGray
        Me.dgCabecera.HeaderBackColor = System.Drawing.Color.DarkGreen
        Me.dgCabecera.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dgCabecera.HeaderForeColor = System.Drawing.Color.White
        Me.dgCabecera.LinkColor = System.Drawing.Color.DarkGreen
        Me.dgCabecera.Location = New System.Drawing.Point(262, 34)
        Me.dgCabecera.Name = "dgCabecera"
        Me.dgCabecera.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.dgCabecera.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgCabecera.PreferredRowHeight = 20
        Me.dgCabecera.ReadOnly = True
        Me.dgCabecera.SelectionBackColor = System.Drawing.Color.DarkSeaGreen
        Me.dgCabecera.SelectionForeColor = System.Drawing.Color.Black
        Me.dgCabecera.Size = New System.Drawing.Size(700, 177)
        Me.dgCabecera.TabIndex = 1242
        Me.dgCabecera.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle3})
        '
        'DataGridTextBoxColumn16
        '
        Me.DataGridTextBoxColumn16.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn16.Format = ""
        Me.DataGridTextBoxColumn16.FormatInfo = Nothing
        Me.DataGridTextBoxColumn16.HeaderText = "FACTURA"
        Me.DataGridTextBoxColumn16.MappingName = "FACTURA_COMPRA"
        Me.DataGridTextBoxColumn16.Width = 120
        '
        'DataGridTextBoxColumn17
        '
        Me.DataGridTextBoxColumn17.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn17.Format = ""
        Me.DataGridTextBoxColumn17.FormatInfo = Nothing
        Me.DataGridTextBoxColumn17.HeaderText = "ESTADO"
        Me.DataGridTextBoxColumn17.MappingName = "ESTADO"
        Me.DataGridTextBoxColumn17.Width = 95
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.MappingName = "COD_COMPRA"
        Me.DataGridTextBoxColumn1.Width = 0
        '
        'btnIngresar_aDeposito
        '
        Me.btnIngresar_aDeposito.BackColor = System.Drawing.Color.White
        Me.btnIngresar_aDeposito.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar_aDeposito.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnIngresar_aDeposito.Location = New System.Drawing.Point(11, 361)
        Me.btnIngresar_aDeposito.Name = "btnIngresar_aDeposito"
        Me.btnIngresar_aDeposito.Size = New System.Drawing.Size(244, 27)
        Me.btnIngresar_aDeposito.TabIndex = 1241
        Me.btnIngresar_aDeposito.Text = "INGRESAR A DEPOSITO"
        Me.btnIngresar_aDeposito.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarForeColor = System.Drawing.Color.Navy
        Me.DateTimePicker1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(12, 29)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(118, 25)
        Me.DateTimePicker1.TabIndex = 1237
        '
        'rbPrecio_NO_Modificado
        '
        Me.rbPrecio_NO_Modificado.AutoSize = True
        Me.rbPrecio_NO_Modificado.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPrecio_NO_Modificado.ForeColor = System.Drawing.Color.Teal
        Me.rbPrecio_NO_Modificado.Location = New System.Drawing.Point(12, 317)
        Me.rbPrecio_NO_Modificado.Name = "rbPrecio_NO_Modificado"
        Me.rbPrecio_NO_Modificado.Size = New System.Drawing.Size(243, 21)
        Me.rbPrecio_NO_Modificado.TabIndex = 1240
        Me.rbPrecio_NO_Modificado.TabStop = True
        Me.rbPrecio_NO_Modificado.Text = "NO MODIFICAR PRECIOS ACTUALES"
        Me.rbPrecio_NO_Modificado.UseVisualStyleBackColor = True
        '
        'rbPrecio_Modificado
        '
        Me.rbPrecio_Modificado.AutoSize = True
        Me.rbPrecio_Modificado.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbPrecio_Modificado.ForeColor = System.Drawing.Color.Teal
        Me.rbPrecio_Modificado.Location = New System.Drawing.Point(12, 291)
        Me.rbPrecio_Modificado.Name = "rbPrecio_Modificado"
        Me.rbPrecio_Modificado.Size = New System.Drawing.Size(219, 21)
        Me.rbPrecio_Modificado.TabIndex = 1239
        Me.rbPrecio_Modificado.TabStop = True
        Me.rbPrecio_Modificado.Text = "MODIFICAR PRECIOS ACTUALES"
        Me.rbPrecio_Modificado.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(12, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 23)
        Me.Label3.TabIndex = 1245
        Me.Label3.Text = "FECHA INICIO"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(262, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(700, 23)
        Me.Label6.TabIndex = 1256
        Me.Label6.Text = "DETALLES COMPRAS DE PROVEEDORES"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(262, 214)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(700, 23)
        Me.Label1.TabIndex = 1257
        Me.Label1.Text = "DETALLES DE COMPRA POR ITEM"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'RECEPCIO_COMPRAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(975, 575)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.rbVer_soloPendientes)
        Me.Controls.Add(Me.rbVer_PendientesyProcesados)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnVer_Compras)
        Me.Controls.Add(Me.txtDeposito)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnIngresar_aDeposito)
        Me.Controls.Add(Me.dgCabecera)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.rbPrecio_Modificado)
        Me.Controls.Add(Me.dg_Detalle)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.rbPrecio_NO_Modificado)
        Me.Name = "RECEPCIO_COMPRAS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SISTEMA DE GESTION DE COMPRAS Y VENTAS VERSION (E) V1.1.0          CONSULTAS Y PR" & _
            "ECIOS AL 0994 60 60 48  / 0982 12 12 69     *** TU VENDEDOR SOFT ***"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dg_Detalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgCabecera, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rbVer_soloPendientes As System.Windows.Forms.RadioButton
    Friend WithEvents dg_Detalle As System.Windows.Forms.DataGrid
    Friend WithEvents rbVer_PendientesyProcesados As System.Windows.Forms.RadioButton
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnVer_Compras As System.Windows.Forms.Button
    Friend WithEvents txtDeposito As System.Windows.Forms.TextBox
    Friend WithEvents DataGridTextBoxColumn15 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTableStyle3 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents dgCabecera As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTextBoxColumn16 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn17 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btnIngresar_aDeposito As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents rbPrecio_NO_Modificado As System.Windows.Forms.RadioButton
    Friend WithEvents rbPrecio_Modificado As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn18 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn19 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn20 As System.Windows.Forms.DataGridTextBoxColumn
End Class
