<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GESTIONAR_COBRO
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbCheque = New System.Windows.Forms.RadioButton()
        Me.rbEfectivo = New System.Windows.Forms.RadioButton()
        Me.txtClienteCI = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgDetalleCuentCli = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbBanco = New System.Windows.Forms.ComboBox()
        Me.txtNombre_Banco = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtChequeNum = New System.Windows.Forms.TextBox()
        Me.btnBuscarDatos = New System.Windows.Forms.Button()
        Me.btnRealizarPago = New System.Windows.Forms.Button()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.btnCancelarOperacion = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtDescuentoInteres = New System.Windows.Forms.TextBox()
        Me.txtSaldodeInteres = New System.Windows.Forms.TextBox()
        Me.txtMontoPagoInteres = New System.Windows.Forms.TextBox()
        Me.txtMontoPagoCuotas = New System.Windows.Forms.TextBox()
        Me.txtImportedeInteres = New System.Windows.Forms.TextBox()
        Me.txtImportedeCuotas = New System.Windows.Forms.TextBox()
        Me.txtDescuentoCuota = New System.Windows.Forms.TextBox()
        Me.txtSaldodeCuotas = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.rbCredito = New System.Windows.Forms.RadioButton()
        Me.rbContado = New System.Windows.Forms.RadioButton()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.btnImprimirRecibo = New System.Windows.Forms.Button()
        Me.btnImprimirPagare = New System.Windows.Forms.Button()
        Me.btnImprimirFactura = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgDetalleCuentCli, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbCheque)
        Me.GroupBox2.Controls.Add(Me.rbEfectivo)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkGreen
        Me.GroupBox2.Location = New System.Drawing.Point(16, 215)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(183, 38)
        Me.GroupBox2.TabIndex = 1289
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Seleccionar forma de Pago"
        '
        'rbCheque
        '
        Me.rbCheque.AutoSize = True
        Me.rbCheque.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCheque.ForeColor = System.Drawing.Color.ForestGreen
        Me.rbCheque.Location = New System.Drawing.Point(96, 16)
        Me.rbCheque.Name = "rbCheque"
        Me.rbCheque.Size = New System.Drawing.Size(68, 17)
        Me.rbCheque.TabIndex = 2
        Me.rbCheque.TabStop = True
        Me.rbCheque.Text = "CHEQUE"
        Me.rbCheque.UseVisualStyleBackColor = True
        '
        'rbEfectivo
        '
        Me.rbEfectivo.AutoSize = True
        Me.rbEfectivo.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbEfectivo.ForeColor = System.Drawing.Color.ForestGreen
        Me.rbEfectivo.Location = New System.Drawing.Point(12, 16)
        Me.rbEfectivo.Name = "rbEfectivo"
        Me.rbEfectivo.Size = New System.Drawing.Size(74, 17)
        Me.rbEfectivo.TabIndex = 1
        Me.rbEfectivo.TabStop = True
        Me.rbEfectivo.Text = "EFECTIVO"
        Me.rbEfectivo.UseVisualStyleBackColor = True
        '
        'txtClienteCI
        '
        Me.txtClienteCI.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtClienteCI.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClienteCI.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtClienteCI.Location = New System.Drawing.Point(92, 34)
        Me.txtClienteCI.Name = "txtClienteCI"
        Me.txtClienteCI.Size = New System.Drawing.Size(159, 23)
        Me.txtClienteCI.TabIndex = 0
        Me.txtClienteCI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.Location = New System.Drawing.Point(16, 667)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(491, 27)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(495, 22)
        Me.Label2.TabIndex = 1285
        Me.Label2.Text = "BUSCAR DATOS DEL CLIENTE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Green
        Me.Label6.Location = New System.Drawing.Point(8, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 23)
        Me.Label6.TabIndex = 1292
        Me.Label6.Text = "CI CLIENTE"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgDetalleCuentCli
        '
        Me.dgDetalleCuentCli.AlternatingBackColor = System.Drawing.Color.White
        Me.dgDetalleCuentCli.BackColor = System.Drawing.Color.White
        Me.dgDetalleCuentCli.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dgDetalleCuentCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgDetalleCuentCli.CaptionBackColor = System.Drawing.Color.Silver
        Me.dgDetalleCuentCli.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dgDetalleCuentCli.CaptionForeColor = System.Drawing.Color.Black
        Me.dgDetalleCuentCli.CaptionVisible = False
        Me.dgDetalleCuentCli.DataMember = ""
        Me.dgDetalleCuentCli.FlatMode = True
        Me.dgDetalleCuentCli.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dgDetalleCuentCli.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.dgDetalleCuentCli.GridLineColor = System.Drawing.Color.DarkGray
        Me.dgDetalleCuentCli.HeaderBackColor = System.Drawing.Color.DarkGreen
        Me.dgDetalleCuentCli.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dgDetalleCuentCli.HeaderForeColor = System.Drawing.Color.White
        Me.dgDetalleCuentCli.LinkColor = System.Drawing.Color.DarkGreen
        Me.dgDetalleCuentCli.Location = New System.Drawing.Point(12, 87)
        Me.dgDetalleCuentCli.Name = "dgDetalleCuentCli"
        Me.dgDetalleCuentCli.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.dgDetalleCuentCli.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgDetalleCuentCli.ReadOnly = True
        Me.dgDetalleCuentCli.SelectionBackColor = System.Drawing.Color.DarkSeaGreen
        Me.dgDetalleCuentCli.SelectionForeColor = System.Drawing.Color.Black
        Me.dgDetalleCuentCli.Size = New System.Drawing.Size(495, 126)
        Me.dgDetalleCuentCli.TabIndex = 50000
        Me.dgDetalleCuentCli.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.DataGrid = Me.dgDetalleCuentCli
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10})
        Me.DataGridTableStyle2.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridTableStyle2.MappingName = "VF_DETALLE_CUENTACLIENTE"
        Me.DataGridTableStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "Documento"
        Me.DataGridTextBoxColumn4.MappingName = "DOCUMENTO_FACTURACION"
        Me.DataGridTextBoxColumn4.Width = 115
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "Cuota"
        Me.DataGridTextBoxColumn5.MappingName = "CUOTA"
        Me.DataGridTextBoxColumn5.Width = 45
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "a Vencer"
        Me.DataGridTextBoxColumn6.MappingName = "DIAS_A_VENCER"
        Me.DataGridTextBoxColumn6.Width = 60
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn7.Format = "n0"
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "Monto"
        Me.DataGridTextBoxColumn7.MappingName = "MONTO_CUOTA"
        Me.DataGridTextBoxColumn7.Width = 80
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "Vencimiento"
        Me.DataGridTextBoxColumn8.MappingName = "FECHA_VENCIMIENTO"
        Me.DataGridTextBoxColumn8.Width = 75
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.MappingName = "COD_CLIENTE"
        Me.DataGridTextBoxColumn1.Width = 0
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.MappingName = "COD_CABECERA_CUENTACLI"
        Me.DataGridTextBoxColumn2.Width = 0
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn3.Format = "n0"
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "MORA"
        Me.DataGridTextBoxColumn3.MappingName = "INTERES_MORATORIO"
        Me.DataGridTextBoxColumn3.Width = 80
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.MappingName = "TIPO_DOCUMENTO"
        Me.DataGridTextBoxColumn9.Width = 0
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.MappingName = "FECHA_FACTURACION"
        Me.DataGridTextBoxColumn10.Width = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbBanco)
        Me.GroupBox1.Controls.Add(Me.txtNombre_Banco)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtChequeNum)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(16, 478)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(491, 116)
        Me.GroupBox1.TabIndex = 1290
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles Pago en Cheque/Banco"
        '
        'cbBanco
        '
        Me.cbBanco.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBanco.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbBanco.FormattingEnabled = True
        Me.cbBanco.Location = New System.Drawing.Point(57, 25)
        Me.cbBanco.Name = "cbBanco"
        Me.cbBanco.Size = New System.Drawing.Size(408, 25)
        Me.cbBanco.TabIndex = 550
        '
        'txtNombre_Banco
        '
        Me.txtNombre_Banco.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtNombre_Banco.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombre_Banco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre_Banco.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre_Banco.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNombre_Banco.Location = New System.Drawing.Point(107, 56)
        Me.txtNombre_Banco.Multiline = True
        Me.txtNombre_Banco.Name = "txtNombre_Banco"
        Me.txtNombre_Banco.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtNombre_Banco.Size = New System.Drawing.Size(358, 23)
        Me.txtNombre_Banco.TabIndex = 9
        Me.txtNombre_Banco.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(11, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 25)
        Me.Label1.TabIndex = 418
        Me.Label1.Text = "Banco"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(12, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 23)
        Me.Label4.TabIndex = 420
        Me.Label4.Text = "Nombre Banco"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(12, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 23)
        Me.Label5.TabIndex = 419
        Me.Label5.Text = "Cheque Nº"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtChequeNum
        '
        Me.txtChequeNum.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtChequeNum.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtChequeNum.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtChequeNum.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChequeNum.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtChequeNum.Location = New System.Drawing.Point(107, 85)
        Me.txtChequeNum.Multiline = True
        Me.txtChequeNum.Name = "txtChequeNum"
        Me.txtChequeNum.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtChequeNum.Size = New System.Drawing.Size(358, 23)
        Me.txtChequeNum.TabIndex = 8
        Me.txtChequeNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnBuscarDatos
        '
        Me.btnBuscarDatos.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBuscarDatos.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscarDatos.ForeColor = System.Drawing.Color.Navy
        Me.btnBuscarDatos.Location = New System.Drawing.Point(12, 59)
        Me.btnBuscarDatos.Name = "btnBuscarDatos"
        Me.btnBuscarDatos.Size = New System.Drawing.Size(242, 25)
        Me.btnBuscarDatos.TabIndex = 2
        Me.btnBuscarDatos.Text = "BUSCAR DATOS"
        Me.btnBuscarDatos.UseVisualStyleBackColor = False
        '
        'btnRealizarPago
        '
        Me.btnRealizarPago.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnRealizarPago.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRealizarPago.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnRealizarPago.Location = New System.Drawing.Point(16, 597)
        Me.btnRealizarPago.Name = "btnRealizarPago"
        Me.btnRealizarPago.Size = New System.Drawing.Size(183, 31)
        Me.btnRealizarPago.TabIndex = 7
        Me.btnRealizarPago.Text = "REALIZAR PAGO"
        Me.btnRealizarPago.UseVisualStyleBackColor = False
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.DisplayStatusBar = False
        Me.CrystalReportViewer1.DisplayToolbar = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(528, 12)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(770, 678)
        Me.CrystalReportViewer1.TabIndex = 1300
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'btnCancelarOperacion
        '
        Me.btnCancelarOperacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCancelarOperacion.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelarOperacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnCancelarOperacion.Location = New System.Drawing.Point(16, 630)
        Me.btnCancelarOperacion.Name = "btnCancelarOperacion"
        Me.btnCancelarOperacion.Size = New System.Drawing.Size(183, 31)
        Me.btnCancelarOperacion.TabIndex = 8
        Me.btnCancelarOperacion.Text = "CANCELAR OPERACION"
        Me.btnCancelarOperacion.UseVisualStyleBackColor = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtDescuentoInteres)
        Me.GroupBox3.Controls.Add(Me.txtSaldodeInteres)
        Me.GroupBox3.Controls.Add(Me.txtMontoPagoInteres)
        Me.GroupBox3.Controls.Add(Me.txtMontoPagoCuotas)
        Me.GroupBox3.Controls.Add(Me.txtImportedeInteres)
        Me.GroupBox3.Controls.Add(Me.txtImportedeCuotas)
        Me.GroupBox3.Controls.Add(Me.txtDescuentoCuota)
        Me.GroupBox3.Controls.Add(Me.txtSaldodeCuotas)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox3.Location = New System.Drawing.Point(16, 256)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(491, 216)
        Me.GroupBox3.TabIndex = 1291
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detalles de Monto y Pago"
        '
        'txtDescuentoInteres
        '
        Me.txtDescuentoInteres.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDescuentoInteres.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescuentoInteres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescuentoInteres.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescuentoInteres.ForeColor = System.Drawing.Color.Red
        Me.txtDescuentoInteres.Location = New System.Drawing.Point(264, 180)
        Me.txtDescuentoInteres.Multiline = True
        Me.txtDescuentoInteres.Name = "txtDescuentoInteres"
        Me.txtDescuentoInteres.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtDescuentoInteres.Size = New System.Drawing.Size(204, 23)
        Me.txtDescuentoInteres.TabIndex = 6
        Me.txtDescuentoInteres.Text = "0"
        Me.txtDescuentoInteres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSaldodeInteres
        '
        Me.txtSaldodeInteres.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSaldodeInteres.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSaldodeInteres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSaldodeInteres.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldodeInteres.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtSaldodeInteres.Location = New System.Drawing.Point(264, 128)
        Me.txtSaldodeInteres.Multiline = True
        Me.txtSaldodeInteres.Name = "txtSaldodeInteres"
        Me.txtSaldodeInteres.ReadOnly = True
        Me.txtSaldodeInteres.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtSaldodeInteres.Size = New System.Drawing.Size(204, 23)
        Me.txtSaldodeInteres.TabIndex = 4
        Me.txtSaldodeInteres.Text = "0"
        Me.txtSaldodeInteres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMontoPagoInteres
        '
        Me.txtMontoPagoInteres.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtMontoPagoInteres.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMontoPagoInteres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMontoPagoInteres.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoPagoInteres.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMontoPagoInteres.Location = New System.Drawing.Point(264, 81)
        Me.txtMontoPagoInteres.Multiline = True
        Me.txtMontoPagoInteres.Name = "txtMontoPagoInteres"
        Me.txtMontoPagoInteres.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtMontoPagoInteres.Size = New System.Drawing.Size(204, 23)
        Me.txtMontoPagoInteres.TabIndex = 2
        Me.txtMontoPagoInteres.Text = "0"
        Me.txtMontoPagoInteres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMontoPagoCuotas
        '
        Me.txtMontoPagoCuotas.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtMontoPagoCuotas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtMontoPagoCuotas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMontoPagoCuotas.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoPagoCuotas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMontoPagoCuotas.Location = New System.Drawing.Point(30, 81)
        Me.txtMontoPagoCuotas.Multiline = True
        Me.txtMontoPagoCuotas.Name = "txtMontoPagoCuotas"
        Me.txtMontoPagoCuotas.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtMontoPagoCuotas.Size = New System.Drawing.Size(204, 23)
        Me.txtMontoPagoCuotas.TabIndex = 1
        Me.txtMontoPagoCuotas.Text = "0"
        Me.txtMontoPagoCuotas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtImportedeInteres
        '
        Me.txtImportedeInteres.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtImportedeInteres.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtImportedeInteres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtImportedeInteres.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImportedeInteres.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtImportedeInteres.Location = New System.Drawing.Point(264, 38)
        Me.txtImportedeInteres.Name = "txtImportedeInteres"
        Me.txtImportedeInteres.ReadOnly = True
        Me.txtImportedeInteres.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtImportedeInteres.Size = New System.Drawing.Size(205, 22)
        Me.txtImportedeInteres.TabIndex = 50006
        Me.txtImportedeInteres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtImportedeCuotas
        '
        Me.txtImportedeCuotas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtImportedeCuotas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtImportedeCuotas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtImportedeCuotas.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtImportedeCuotas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtImportedeCuotas.Location = New System.Drawing.Point(30, 38)
        Me.txtImportedeCuotas.Name = "txtImportedeCuotas"
        Me.txtImportedeCuotas.ReadOnly = True
        Me.txtImportedeCuotas.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtImportedeCuotas.Size = New System.Drawing.Size(204, 22)
        Me.txtImportedeCuotas.TabIndex = 50005
        Me.txtImportedeCuotas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDescuentoCuota
        '
        Me.txtDescuentoCuota.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtDescuentoCuota.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescuentoCuota.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescuentoCuota.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescuentoCuota.ForeColor = System.Drawing.Color.Red
        Me.txtDescuentoCuota.Location = New System.Drawing.Point(30, 180)
        Me.txtDescuentoCuota.Multiline = True
        Me.txtDescuentoCuota.Name = "txtDescuentoCuota"
        Me.txtDescuentoCuota.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtDescuentoCuota.Size = New System.Drawing.Size(204, 23)
        Me.txtDescuentoCuota.TabIndex = 5
        Me.txtDescuentoCuota.Text = "0"
        Me.txtDescuentoCuota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSaldodeCuotas
        '
        Me.txtSaldodeCuotas.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSaldodeCuotas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSaldodeCuotas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSaldodeCuotas.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSaldodeCuotas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtSaldodeCuotas.Location = New System.Drawing.Point(30, 128)
        Me.txtSaldodeCuotas.Multiline = True
        Me.txtSaldodeCuotas.Name = "txtSaldodeCuotas"
        Me.txtSaldodeCuotas.ReadOnly = True
        Me.txtSaldodeCuotas.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtSaldodeCuotas.Size = New System.Drawing.Size(204, 23)
        Me.txtSaldodeCuotas.TabIndex = 3
        Me.txtSaldodeCuotas.Text = "0"
        Me.txtSaldodeCuotas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(264, 154)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(204, 23)
        Me.Label14.TabIndex = 50010
        Me.Label14.Text = "Descuentos Interes"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(264, 103)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(205, 23)
        Me.Label13.TabIndex = 50009
        Me.Label13.Text = "Saldo de Interes"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(264, 57)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(205, 23)
        Me.Label12.TabIndex = 50008
        Me.Label12.Text = "Monto Pago Interes"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(30, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(204, 23)
        Me.Label3.TabIndex = 50007
        Me.Label3.Text = "Monto Pago Cuotas"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Green
        Me.Label11.Location = New System.Drawing.Point(264, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(204, 23)
        Me.Label11.TabIndex = 50004
        Me.Label11.Text = "Importe Interes Mora."
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(30, 154)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(204, 23)
        Me.Label9.TabIndex = 50003
        Me.Label9.Text = "Descuentos Cuotas"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(30, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(204, 23)
        Me.Label8.TabIndex = 425
        Me.Label8.Text = "Saldo de Cuotas"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Green
        Me.Label7.Location = New System.Drawing.Point(30, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(204, 23)
        Me.Label7.TabIndex = 423
        Me.Label7.Text = "Importe Cuotas"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.rbCredito)
        Me.GroupBox4.Controls.Add(Me.rbContado)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox4.Location = New System.Drawing.Point(273, 32)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(215, 52)
        Me.GroupBox4.TabIndex = 1302
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Seleccionar tipo de Operacion"
        '
        'rbCredito
        '
        Me.rbCredito.AutoSize = True
        Me.rbCredito.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCredito.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbCredito.Location = New System.Drawing.Point(113, 19)
        Me.rbCredito.Name = "rbCredito"
        Me.rbCredito.Size = New System.Drawing.Size(81, 21)
        Me.rbCredito.TabIndex = 2
        Me.rbCredito.TabStop = True
        Me.rbCredito.Text = "CREDITO"
        Me.rbCredito.UseVisualStyleBackColor = True
        '
        'rbContado
        '
        Me.rbContado.AutoSize = True
        Me.rbContado.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbContado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbContado.Location = New System.Drawing.Point(14, 19)
        Me.rbContado.Name = "rbContado"
        Me.rbContado.Size = New System.Drawing.Size(90, 21)
        Me.rbContado.TabIndex = 1
        Me.rbContado.TabStop = True
        Me.rbContado.Text = "CONTADO"
        Me.rbContado.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBorrar.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnBorrar.Location = New System.Drawing.Point(357, 217)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(150, 25)
        Me.btnBorrar.TabIndex = 50002
        Me.btnBorrar.Text = "BORRAR REGISTRO"
        Me.btnBorrar.UseVisualStyleBackColor = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.btnImprimirRecibo)
        Me.GroupBox6.Controls.Add(Me.btnImprimirPagare)
        Me.GroupBox6.Controls.Add(Me.btnImprimirFactura)
        Me.GroupBox6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox6.Location = New System.Drawing.Point(214, 600)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(293, 58)
        Me.GroupBox6.TabIndex = 1291
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Impresiones"
        '
        'btnImprimirRecibo
        '
        Me.btnImprimirRecibo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnImprimirRecibo.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimirRecibo.ForeColor = System.Drawing.Color.Blue
        Me.btnImprimirRecibo.Location = New System.Drawing.Point(182, 20)
        Me.btnImprimirRecibo.Name = "btnImprimirRecibo"
        Me.btnImprimirRecibo.Size = New System.Drawing.Size(75, 27)
        Me.btnImprimirRecibo.TabIndex = 50004
        Me.btnImprimirRecibo.Text = "RECIBO"
        Me.btnImprimirRecibo.UseVisualStyleBackColor = False
        '
        'btnImprimirPagare
        '
        Me.btnImprimirPagare.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnImprimirPagare.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimirPagare.ForeColor = System.Drawing.Color.Blue
        Me.btnImprimirPagare.Location = New System.Drawing.Point(101, 20)
        Me.btnImprimirPagare.Name = "btnImprimirPagare"
        Me.btnImprimirPagare.Size = New System.Drawing.Size(75, 27)
        Me.btnImprimirPagare.TabIndex = 50003
        Me.btnImprimirPagare.Text = "PAGARE"
        Me.btnImprimirPagare.UseVisualStyleBackColor = False
        '
        'btnImprimirFactura
        '
        Me.btnImprimirFactura.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnImprimirFactura.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimirFactura.ForeColor = System.Drawing.Color.Blue
        Me.btnImprimirFactura.Location = New System.Drawing.Point(20, 20)
        Me.btnImprimirFactura.Name = "btnImprimirFactura"
        Me.btnImprimirFactura.Size = New System.Drawing.Size(75, 27)
        Me.btnImprimirFactura.TabIndex = 50002
        Me.btnImprimirFactura.Text = "FACTURA"
        Me.btnImprimirFactura.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(211, 219)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(150, 21)
        Me.Label10.TabIndex = 50002
        Me.Label10.Text = "Click Eliminar Registro"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GESTIONAR_COBRO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1305, 702)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnCancelarOperacion)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.btnRealizarPago)
        Me.Controls.Add(Me.btnBuscarDatos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgDetalleCuentCli)
        Me.Controls.Add(Me.txtClienteCI)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Name = "GESTIONAR_COBRO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GESTIONAR COBRO CUENTA CLIENTE  ** SGCV + CO (E) V1.1.0          CONSULTAS Y PREC" & _
            "IOS AL 0994 60 60 48  / 0982 12 12 69     *** TU VENDEDOR SOFT ***"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgDetalleCuentCli, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbCheque As System.Windows.Forms.RadioButton
    Friend WithEvents rbEfectivo As System.Windows.Forms.RadioButton
    Friend WithEvents txtClienteCI As System.Windows.Forms.TextBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dgDetalleCuentCli As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscarDatos As System.Windows.Forms.Button
    Friend WithEvents cbBanco As System.Windows.Forms.ComboBox
    Friend WithEvents txtNombre_Banco As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtChequeNum As System.Windows.Forms.TextBox
    Friend WithEvents btnRealizarPago As System.Windows.Forms.Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnCancelarOperacion As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents rbCredito As System.Windows.Forms.RadioButton
    Friend WithEvents rbContado As System.Windows.Forms.RadioButton
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtSaldodeCuotas As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents btnImprimirRecibo As System.Windows.Forms.Button
    Friend WithEvents btnImprimirPagare As System.Windows.Forms.Button
    Friend WithEvents btnImprimirFactura As System.Windows.Forms.Button
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtDescuentoCuota As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtImportedeInteres As System.Windows.Forms.TextBox
    Friend WithEvents txtImportedeCuotas As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtMontoPagoInteres As System.Windows.Forms.TextBox
    Friend WithEvents txtMontoPagoCuotas As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSaldodeInteres As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtDescuentoInteres As System.Windows.Forms.TextBox
End Class
