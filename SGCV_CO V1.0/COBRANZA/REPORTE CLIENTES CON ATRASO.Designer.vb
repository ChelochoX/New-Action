<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REPORTE_CLIENTES_CON_ATRASO
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
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.btnGenerar_Reporte = New System.Windows.Forms.Button()
        Me.txtCuentaActual = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dg_seg_cobranza = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.dgClientesGral = New System.Windows.Forms.DataGrid()
        Me.txtMontoCompromiso = New System.Windows.Forms.TextBox()
        Me.txtFecha_Seguimiento = New System.Windows.Forms.TextBox()
        Me.txtCobrador = New System.Windows.Forms.TextBox()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCIP = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRUC = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtPendientes = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dgDetallesporCliente = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle3 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtInteres_Mora = New System.Windows.Forms.TextBox()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dg_seg_cobranza, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgClientesGral, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgDetallesporCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.Navy
        Me.btnSalir.Location = New System.Drawing.Point(878, 616)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(363, 34)
        Me.btnSalir.TabIndex = 14
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnGenerar_Reporte)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(214, 73)
        Me.GroupBox4.TabIndex = 1248
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Reporte"
        '
        'btnGenerar_Reporte
        '
        Me.btnGenerar_Reporte.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnGenerar_Reporte.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerar_Reporte.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnGenerar_Reporte.Location = New System.Drawing.Point(19, 26)
        Me.btnGenerar_Reporte.Name = "btnGenerar_Reporte"
        Me.btnGenerar_Reporte.Size = New System.Drawing.Size(176, 34)
        Me.btnGenerar_Reporte.TabIndex = 11
        Me.btnGenerar_Reporte.Text = "Generar Reporte"
        Me.btnGenerar_Reporte.UseVisualStyleBackColor = False
        '
        'txtCuentaActual
        '
        Me.txtCuentaActual.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtCuentaActual.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuentaActual.ForeColor = System.Drawing.Color.Red
        Me.txtCuentaActual.Location = New System.Drawing.Point(1001, 577)
        Me.txtCuentaActual.Multiline = True
        Me.txtCuentaActual.Name = "txtCuentaActual"
        Me.txtCuentaActual.Size = New System.Drawing.Size(239, 30)
        Me.txtCuentaActual.TabIndex = 1321
        Me.txtCuentaActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(875, 577)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(134, 30)
        Me.Label3.TabIndex = 1320
        Me.Label3.Text = "Deuda Actual"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dg_seg_cobranza
        '
        Me.dg_seg_cobranza.AlternatingBackColor = System.Drawing.Color.White
        Me.dg_seg_cobranza.BackColor = System.Drawing.Color.White
        Me.dg_seg_cobranza.BackgroundColor = System.Drawing.Color.Ivory
        Me.dg_seg_cobranza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dg_seg_cobranza.CaptionBackColor = System.Drawing.Color.DarkSlateBlue
        Me.dg_seg_cobranza.CaptionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dg_seg_cobranza.CaptionForeColor = System.Drawing.Color.Lavender
        Me.dg_seg_cobranza.DataMember = ""
        Me.dg_seg_cobranza.FlatMode = True
        Me.dg_seg_cobranza.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dg_seg_cobranza.ForeColor = System.Drawing.Color.Black
        Me.dg_seg_cobranza.GridLineColor = System.Drawing.Color.Wheat
        Me.dg_seg_cobranza.HeaderBackColor = System.Drawing.Color.CadetBlue
        Me.dg_seg_cobranza.HeaderFont = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dg_seg_cobranza.HeaderForeColor = System.Drawing.Color.Black
        Me.dg_seg_cobranza.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dg_seg_cobranza.Location = New System.Drawing.Point(882, 169)
        Me.dg_seg_cobranza.Name = "dg_seg_cobranza"
        Me.dg_seg_cobranza.ParentRowsBackColor = System.Drawing.Color.Ivory
        Me.dg_seg_cobranza.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dg_seg_cobranza.ReadOnly = True
        Me.dg_seg_cobranza.RowHeadersVisible = False
        Me.dg_seg_cobranza.SelectionBackColor = System.Drawing.Color.Wheat
        Me.dg_seg_cobranza.SelectionForeColor = System.Drawing.Color.DarkSlateBlue
        Me.dg_seg_cobranza.Size = New System.Drawing.Size(358, 233)
        Me.dg_seg_cobranza.TabIndex = 1319
        Me.dg_seg_cobranza.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dg_seg_cobranza
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "CP_SEGUIM_COBRANZA"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "FECHA SEGUIMIENTO"
        Me.DataGridTextBoxColumn1.MappingName = "FECHA_SEGUIMIENTO"
        Me.DataGridTextBoxColumn1.Width = 130
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.MappingName = "COBRADOR"
        Me.DataGridTextBoxColumn2.Width = 0
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.MappingName = "MONTO_COMPROMISO"
        Me.DataGridTextBoxColumn3.Width = 0
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.MappingName = "OBSERVACION"
        Me.DataGridTextBoxColumn4.Width = 0
        '
        'dgClientesGral
        '
        Me.dgClientesGral.AlternatingBackColor = System.Drawing.Color.White
        Me.dgClientesGral.BackColor = System.Drawing.Color.White
        Me.dgClientesGral.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgClientesGral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgClientesGral.CaptionBackColor = System.Drawing.Color.Silver
        Me.dgClientesGral.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dgClientesGral.CaptionForeColor = System.Drawing.Color.Black
        Me.dgClientesGral.DataMember = ""
        Me.dgClientesGral.FlatMode = True
        Me.dgClientesGral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dgClientesGral.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.dgClientesGral.GridLineColor = System.Drawing.Color.DarkGray
        Me.dgClientesGral.HeaderBackColor = System.Drawing.Color.DarkGreen
        Me.dgClientesGral.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dgClientesGral.HeaderForeColor = System.Drawing.Color.White
        Me.dgClientesGral.LinkColor = System.Drawing.Color.DarkGreen
        Me.dgClientesGral.Location = New System.Drawing.Point(12, 91)
        Me.dgClientesGral.Name = "dgClientesGral"
        Me.dgClientesGral.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.dgClientesGral.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgClientesGral.ReadOnly = True
        Me.dgClientesGral.RowHeadersVisible = False
        Me.dgClientesGral.SelectionBackColor = System.Drawing.Color.DarkSeaGreen
        Me.dgClientesGral.SelectionForeColor = System.Drawing.Color.Black
        Me.dgClientesGral.Size = New System.Drawing.Size(214, 560)
        Me.dgClientesGral.TabIndex = 1318
        Me.dgClientesGral.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        '
        'txtMontoCompromiso
        '
        Me.txtMontoCompromiso.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoCompromiso.ForeColor = System.Drawing.Color.Green
        Me.txtMontoCompromiso.Location = New System.Drawing.Point(957, 433)
        Me.txtMontoCompromiso.Name = "txtMontoCompromiso"
        Me.txtMontoCompromiso.Size = New System.Drawing.Size(113, 22)
        Me.txtMontoCompromiso.TabIndex = 1317
        '
        'txtFecha_Seguimiento
        '
        Me.txtFecha_Seguimiento.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha_Seguimiento.ForeColor = System.Drawing.Color.Green
        Me.txtFecha_Seguimiento.Location = New System.Drawing.Point(1122, 433)
        Me.txtFecha_Seguimiento.Name = "txtFecha_Seguimiento"
        Me.txtFecha_Seguimiento.Size = New System.Drawing.Size(119, 22)
        Me.txtFecha_Seguimiento.TabIndex = 1316
        '
        'txtCobrador
        '
        Me.txtCobrador.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCobrador.ForeColor = System.Drawing.Color.Green
        Me.txtCobrador.Location = New System.Drawing.Point(957, 408)
        Me.txtCobrador.Name = "txtCobrador"
        Me.txtCobrador.Size = New System.Drawing.Size(284, 22)
        Me.txtCobrador.TabIndex = 1315
        '
        'txtObservacion
        '
        Me.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacion.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtObservacion.Location = New System.Drawing.Point(957, 458)
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(284, 42)
        Me.txtObservacion.TabIndex = 1310
        '
        'Label6
        '
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(886, 428)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 30)
        Me.Label6.TabIndex = 1313
        Me.Label6.Text = "Monto Compromiso"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(1069, 433)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 22)
        Me.Label5.TabIndex = 1312
        Me.Label5.Text = "Prox Seg"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(886, 458)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 19)
        Me.Label7.TabIndex = 1314
        Me.Label7.Text = "Observacion "
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label12
        '
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(886, 411)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(61, 19)
        Me.Label12.TabIndex = 1311
        Me.Label12.Text = "Cobrador"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(875, 116)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 23)
        Me.Label9.TabIndex = 1331
        Me.Label9.Text = "Direccion     **"
        '
        'txtDireccion
        '
        Me.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDireccion.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDireccion.Location = New System.Drawing.Point(927, 108)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(314, 40)
        Me.txtDireccion.TabIndex = 1326
        '
        'txtTelefono
        '
        Me.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelefono.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTelefono.Location = New System.Drawing.Point(927, 84)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(118, 22)
        Me.txtTelefono.TabIndex = 1325
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(875, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 23)
        Me.Label1.TabIndex = 1330
        Me.Label1.Text = "Telefono      **"
        '
        'txtCIP
        '
        Me.txtCIP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCIP.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCIP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCIP.Location = New System.Drawing.Point(927, 36)
        Me.txtCIP.Name = "txtCIP"
        Me.txtCIP.Size = New System.Drawing.Size(118, 22)
        Me.txtCIP.TabIndex = 1323
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(875, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 23)
        Me.Label2.TabIndex = 1328
        Me.Label2.Text = "C.I.P."
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNombre.Location = New System.Drawing.Point(927, 60)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(314, 22)
        Me.txtNombre.TabIndex = 1324
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(875, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 23)
        Me.Label4.TabIndex = 1329
        Me.Label4.Text = "Nombre"
        '
        'txtRUC
        '
        Me.txtRUC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRUC.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRUC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRUC.Location = New System.Drawing.Point(927, 12)
        Me.txtRUC.Name = "txtRUC"
        Me.txtRUC.Size = New System.Drawing.Size(118, 22)
        Me.txtRUC.TabIndex = 1322
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(875, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 23)
        Me.Label8.TabIndex = 1327
        Me.Label8.Text = "RUC      "
        '
        'txtPendientes
        '
        Me.txtPendientes.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPendientes.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPendientes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtPendientes.Location = New System.Drawing.Point(1001, 545)
        Me.txtPendientes.Multiline = True
        Me.txtPendientes.Name = "txtPendientes"
        Me.txtPendientes.Size = New System.Drawing.Size(239, 30)
        Me.txtPendientes.TabIndex = 1333
        Me.txtPendientes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(875, 545)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(74, 30)
        Me.Label10.TabIndex = 1332
        Me.Label10.Text = "Pendiente"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgDetallesporCliente
        '
        Me.dgDetallesporCliente.AlternatingBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.dgDetallesporCliente.BackColor = System.Drawing.Color.White
        Me.dgDetallesporCliente.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow
        Me.dgDetallesporCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgDetallesporCliente.CaptionBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.dgDetallesporCliente.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dgDetallesporCliente.CaptionForeColor = System.Drawing.Color.DarkSlateBlue
        Me.dgDetallesporCliente.DataMember = ""
        Me.dgDetallesporCliente.FlatMode = True
        Me.dgDetallesporCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dgDetallesporCliente.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.dgDetallesporCliente.GridLineColor = System.Drawing.Color.Peru
        Me.dgDetallesporCliente.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dgDetallesporCliente.HeaderBackColor = System.Drawing.Color.Maroon
        Me.dgDetallesporCliente.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dgDetallesporCliente.HeaderForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.dgDetallesporCliente.LinkColor = System.Drawing.Color.Maroon
        Me.dgDetallesporCliente.Location = New System.Drawing.Point(232, 12)
        Me.dgDetallesporCliente.Name = "dgDetallesporCliente"
        Me.dgDetallesporCliente.ParentRowsBackColor = System.Drawing.Color.BurlyWood
        Me.dgDetallesporCliente.ParentRowsForeColor = System.Drawing.Color.DarkSlateBlue
        Me.dgDetallesporCliente.ReadOnly = True
        Me.dgDetallesporCliente.RowHeadersVisible = False
        Me.dgDetallesporCliente.SelectionBackColor = System.Drawing.Color.DarkSlateBlue
        Me.dgDetallesporCliente.SelectionForeColor = System.Drawing.Color.GhostWhite
        Me.dgDetallesporCliente.Size = New System.Drawing.Size(628, 638)
        Me.dgDetallesporCliente.TabIndex = 1334
        Me.dgDetallesporCliente.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle3})
        '
        'DataGridTableStyle3
        '
        Me.DataGridTableStyle3.DataGrid = Me.dgDetallesporCliente
        Me.DataGridTableStyle3.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn14})
        Me.DataGridTableStyle3.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DataGridTableStyle3.HeaderFont = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle3.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridTableStyle3.MappingName = "VF_DETALLE_CUENTACLIENTE"
        Me.DataGridTableStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.DataGrid = Me.dgClientesGral
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn13})
        Me.DataGridTableStyle2.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.DataGridTableStyle2.HeaderFont = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridTableStyle2.MappingName = "VF_DETALLE_CUENTACLIENTE"
        Me.DataGridTableStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "DOCUMENTO"
        Me.DataGridTextBoxColumn5.MappingName = "DOCUMENTO_FACTURACION"
        Me.DataGridTextBoxColumn5.Width = 85
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "ATRASO"
        Me.DataGridTextBoxColumn6.MappingName = "DIAS_A_VENCER"
        Me.DataGridTextBoxColumn6.Width = 70
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "DOCUMENTO"
        Me.DataGridTextBoxColumn7.MappingName = "DOCUMENTO_FACTURACION"
        Me.DataGridTextBoxColumn7.Width = 85
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "CUOTA"
        Me.DataGridTextBoxColumn8.MappingName = "CUOTA"
        Me.DataGridTextBoxColumn8.Width = 65
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "ATRASO"
        Me.DataGridTextBoxColumn9.MappingName = "DIAS_A_VENCER"
        Me.DataGridTextBoxColumn9.Width = 75
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn10.Format = "n0"
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "MONTO"
        Me.DataGridTextBoxColumn10.MappingName = "MONTO_CUOTA"
        Me.DataGridTextBoxColumn10.Width = 90
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "VENCIMIENTO"
        Me.DataGridTextBoxColumn11.MappingName = "FECHA_VENCIMIENTO"
        Me.DataGridTextBoxColumn11.Width = 90
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn12.Format = "n0"
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.HeaderText = "INTERES MORA"
        Me.DataGridTextBoxColumn12.MappingName = "INTERES_MORATORIO"
        Me.DataGridTextBoxColumn12.Width = 90
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Alignment = System.Windows.Forms.HorizontalAlignment.Right
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.MappingName = "COD_CLIENTE"
        Me.DataGridTextBoxColumn13.Width = 0
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.HeaderText = "ESTADO"
        Me.DataGridTextBoxColumn14.MappingName = "ESTADO_CUOTA"
        Me.DataGridTextBoxColumn14.Width = 80
        '
        'Label11
        '
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(875, 515)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(120, 30)
        Me.Label11.TabIndex = 1335
        Me.Label11.Text = "Interes Moratorio"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtInteres_Mora
        '
        Me.txtInteres_Mora.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtInteres_Mora.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInteres_Mora.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtInteres_Mora.Location = New System.Drawing.Point(1001, 512)
        Me.txtInteres_Mora.Multiline = True
        Me.txtInteres_Mora.Name = "txtInteres_Mora"
        Me.txtInteres_Mora.Size = New System.Drawing.Size(239, 30)
        Me.txtInteres_Mora.TabIndex = 1336
        Me.txtInteres_Mora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'REPORTE_CLIENTES_CON_ATRASO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1252, 684)
        Me.Controls.Add(Me.txtInteres_Mora)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.dgDetallesporCliente)
        Me.Controls.Add(Me.txtPendientes)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.txtCIP)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtRUC)
        Me.Controls.Add(Me.txtCuentaActual)
        Me.Controls.Add(Me.dg_seg_cobranza)
        Me.Controls.Add(Me.dgClientesGral)
        Me.Controls.Add(Me.txtMontoCompromiso)
        Me.Controls.Add(Me.txtFecha_Seguimiento)
        Me.Controls.Add(Me.txtCobrador)
        Me.Controls.Add(Me.txtObservacion)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Name = "REPORTE_CLIENTES_CON_ATRASO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REPORTE CLIENTES CON ATRASO  ** SGCV + CO (E) V1.1.0          CONSULTAS Y PRECIOS" & _
            " AL 0994 60 60 48  / 0982 12 12 69     *** TU VENDEDOR SOFT ***"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dg_seg_cobranza, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgClientesGral, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgDetallesporCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnGenerar_Reporte As System.Windows.Forms.Button
    Friend WithEvents txtCuentaActual As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dg_seg_cobranza As System.Windows.Forms.DataGrid
    Friend WithEvents dgClientesGral As System.Windows.Forms.DataGrid
    Friend WithEvents txtMontoCompromiso As System.Windows.Forms.TextBox
    Friend WithEvents txtFecha_Seguimiento As System.Windows.Forms.TextBox
    Friend WithEvents txtCobrador As System.Windows.Forms.TextBox
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtCIP As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRUC As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents txtPendientes As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dgDetallesporCliente As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle3 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtInteres_Mora As System.Windows.Forms.TextBox
End Class
