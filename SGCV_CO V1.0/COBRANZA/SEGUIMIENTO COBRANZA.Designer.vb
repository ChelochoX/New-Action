<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SEGUIMIENTO_COBRANZA
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
        Me.btnVerSeguimiento = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBuscar_Datos = New System.Windows.Forms.TextBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.dg_Seguimiento = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cbCobrador = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMontoCompromiso = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtObservacion = New System.Windows.Forms.TextBox()
        Me.btnGuardarSeguimiento = New System.Windows.Forms.Button()
        Me.btnModificarSeguimiento = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbNombreApellido = New System.Windows.Forms.RadioButton()
        Me.rbRuc = New System.Windows.Forms.RadioButton()
        Me.rbCedula = New System.Windows.Forms.RadioButton()
        Me.lstnombre = New System.Windows.Forms.ListBox()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        CType(Me.dg_Seguimiento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnVerSeguimiento
        '
        Me.btnVerSeguimiento.BackColor = System.Drawing.Color.White
        Me.btnVerSeguimiento.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerSeguimiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnVerSeguimiento.Location = New System.Drawing.Point(17, 317)
        Me.btnVerSeguimiento.Name = "btnVerSeguimiento"
        Me.btnVerSeguimiento.Size = New System.Drawing.Size(327, 45)
        Me.btnVerSeguimiento.TabIndex = 0
        Me.btnVerSeguimiento.Text = "Ver Seguimiento"
        Me.btnVerSeguimiento.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.Location = New System.Drawing.Point(17, 408)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(327, 30)
        Me.btnSalir.TabIndex = 1278
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(333, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(844, 23)
        Me.Label1.TabIndex = 1276
        Me.Label1.Text = "VISUALIZAR DETALLES SEGUIMIENTO A CLIENTE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBuscar_Datos
        '
        Me.txtBuscar_Datos.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar_Datos.ForeColor = System.Drawing.Color.Green
        Me.txtBuscar_Datos.Location = New System.Drawing.Point(18, 129)
        Me.txtBuscar_Datos.Name = "txtBuscar_Datos"
        Me.txtBuscar_Datos.Size = New System.Drawing.Size(326, 27)
        Me.txtBuscar_Datos.TabIndex = 0
        Me.txtBuscar_Datos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLimpiar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLimpiar.Location = New System.Drawing.Point(17, 367)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(327, 33)
        Me.btnLimpiar.TabIndex = 1284
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'dg_Seguimiento
        '
        Me.dg_Seguimiento.AlternatingBackColor = System.Drawing.Color.White
        Me.dg_Seguimiento.BackColor = System.Drawing.Color.White
        Me.dg_Seguimiento.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dg_Seguimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dg_Seguimiento.CaptionBackColor = System.Drawing.Color.Silver
        Me.dg_Seguimiento.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dg_Seguimiento.CaptionForeColor = System.Drawing.Color.Black
        Me.dg_Seguimiento.DataMember = ""
        Me.dg_Seguimiento.FlatMode = True
        Me.dg_Seguimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dg_Seguimiento.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.dg_Seguimiento.GridLineColor = System.Drawing.Color.DarkGray
        Me.dg_Seguimiento.HeaderBackColor = System.Drawing.Color.DarkGreen
        Me.dg_Seguimiento.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dg_Seguimiento.HeaderForeColor = System.Drawing.Color.White
        Me.dg_Seguimiento.LinkColor = System.Drawing.Color.DarkGreen
        Me.dg_Seguimiento.Location = New System.Drawing.Point(350, 68)
        Me.dg_Seguimiento.Name = "dg_Seguimiento"
        Me.dg_Seguimiento.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.dg_Seguimiento.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dg_Seguimiento.ReadOnly = True
        Me.dg_Seguimiento.RowHeadersVisible = False
        Me.dg_Seguimiento.SelectionBackColor = System.Drawing.Color.DarkSeaGreen
        Me.dg_Seguimiento.SelectionForeColor = System.Drawing.Color.Black
        Me.dg_Seguimiento.Size = New System.Drawing.Size(827, 215)
        Me.dg_Seguimiento.TabIndex = 1285
        Me.dg_Seguimiento.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dg_Seguimiento
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5})
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DataGridTableStyle1.HeaderFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.Color.Blue
        Me.DataGridTableStyle1.MappingName = "CP_SEGUIM_COBRANZA"
        Me.DataGridTableStyle1.PreferredRowHeight = 20
        Me.DataGridTableStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "FECHA SEG"
        Me.DataGridTextBoxColumn1.MappingName = "FECHA_SEGUIMIENTO"
        Me.DataGridTextBoxColumn1.Width = 95
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "COBRADOR"
        Me.DataGridTextBoxColumn2.MappingName = "COBRADOR"
        Me.DataGridTextBoxColumn2.Width = 150
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn3.Format = "n0"
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "MONTO COMPROMISO"
        Me.DataGridTextBoxColumn3.MappingName = "MONTO_COMPROMISO"
        Me.DataGridTextBoxColumn3.Width = 75
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "OBSERVACION"
        Me.DataGridTextBoxColumn4.MappingName = "OBSERVACION"
        Me.DataGridTextBoxColumn4.Width = 450
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(350, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(827, 23)
        Me.Label4.TabIndex = 1286
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label12
        '
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(353, 296)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(301, 19)
        Me.Label12.TabIndex = 1287
        Me.Label12.Text = "Cobrador"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cbCobrador
        '
        Me.cbCobrador.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCobrador.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cbCobrador.FormattingEnabled = True
        Me.cbCobrador.Location = New System.Drawing.Point(350, 317)
        Me.cbCobrador.Name = "cbCobrador"
        Me.cbCobrador.Size = New System.Drawing.Size(304, 23)
        Me.cbCobrador.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(660, 295)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(270, 19)
        Me.Label5.TabIndex = 1289
        Me.Label5.Text = "Fecha Seguimiento"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DateTimePicker1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(660, 317)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(270, 23)
        Me.DateTimePicker1.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(936, 295)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(241, 19)
        Me.Label6.TabIndex = 1291
        Me.Label6.Text = "Monto Compromiso"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtMontoCompromiso
        '
        Me.txtMontoCompromiso.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoCompromiso.ForeColor = System.Drawing.Color.Green
        Me.txtMontoCompromiso.Location = New System.Drawing.Point(936, 317)
        Me.txtMontoCompromiso.Name = "txtMontoCompromiso"
        Me.txtMontoCompromiso.Size = New System.Drawing.Size(241, 23)
        Me.txtMontoCompromiso.TabIndex = 4
        Me.txtMontoCompromiso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(353, 343)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(190, 19)
        Me.Label7.TabIndex = 1293
        Me.Label7.Text = "Observacion de Seguimiento Cliente"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtObservacion
        '
        Me.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObservacion.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtObservacion.Location = New System.Drawing.Point(350, 365)
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Size = New System.Drawing.Size(827, 71)
        Me.txtObservacion.TabIndex = 5
        '
        'btnGuardarSeguimiento
        '
        Me.btnGuardarSeguimiento.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnGuardarSeguimiento.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardarSeguimiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnGuardarSeguimiento.Location = New System.Drawing.Point(569, 442)
        Me.btnGuardarSeguimiento.Name = "btnGuardarSeguimiento"
        Me.btnGuardarSeguimiento.Size = New System.Drawing.Size(188, 34)
        Me.btnGuardarSeguimiento.TabIndex = 1294
        Me.btnGuardarSeguimiento.Text = "Guardar Seguimiento"
        Me.btnGuardarSeguimiento.UseVisualStyleBackColor = False
        '
        'btnModificarSeguimiento
        '
        Me.btnModificarSeguimiento.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnModificarSeguimiento.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificarSeguimiento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnModificarSeguimiento.Location = New System.Drawing.Point(763, 442)
        Me.btnModificarSeguimiento.Name = "btnModificarSeguimiento"
        Me.btnModificarSeguimiento.Size = New System.Drawing.Size(188, 34)
        Me.btnModificarSeguimiento.TabIndex = 1295
        Me.btnModificarSeguimiento.Text = "Modificar Seguimiento"
        Me.btnModificarSeguimiento.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(18, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(326, 23)
        Me.Label2.TabIndex = 1299
        Me.Label2.Text = "BUSCAR DATOS DE CLIENTE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbNombreApellido)
        Me.GroupBox2.Controls.Add(Me.rbRuc)
        Me.GroupBox2.Controls.Add(Me.rbCedula)
        Me.GroupBox2.ForeColor = System.Drawing.Color.DarkGreen
        Me.GroupBox2.Location = New System.Drawing.Point(22, 42)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(169, 81)
        Me.GroupBox2.TabIndex = 1300
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buscar por"
        '
        'rbNombreApellido
        '
        Me.rbNombreApellido.AutoSize = True
        Me.rbNombreApellido.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNombreApellido.ForeColor = System.Drawing.Color.ForestGreen
        Me.rbNombreApellido.Location = New System.Drawing.Point(10, 54)
        Me.rbNombreApellido.Name = "rbNombreApellido"
        Me.rbNombreApellido.Size = New System.Drawing.Size(124, 17)
        Me.rbNombreApellido.TabIndex = 2
        Me.rbNombreApellido.TabStop = True
        Me.rbNombreApellido.Text = "NOMBRE/APELLIDO"
        Me.rbNombreApellido.UseVisualStyleBackColor = True
        '
        'rbRuc
        '
        Me.rbRuc.AutoSize = True
        Me.rbRuc.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbRuc.ForeColor = System.Drawing.Color.ForestGreen
        Me.rbRuc.Location = New System.Drawing.Point(10, 37)
        Me.rbRuc.Name = "rbRuc"
        Me.rbRuc.Size = New System.Drawing.Size(47, 17)
        Me.rbRuc.TabIndex = 1
        Me.rbRuc.TabStop = True
        Me.rbRuc.Text = "RUC"
        Me.rbRuc.UseVisualStyleBackColor = True
        '
        'rbCedula
        '
        Me.rbCedula.AutoSize = True
        Me.rbCedula.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbCedula.ForeColor = System.Drawing.Color.ForestGreen
        Me.rbCedula.Location = New System.Drawing.Point(10, 19)
        Me.rbCedula.Name = "rbCedula"
        Me.rbCedula.Size = New System.Drawing.Size(66, 17)
        Me.rbCedula.TabIndex = 0
        Me.rbCedula.TabStop = True
        Me.rbCedula.Text = "CEDULA"
        Me.rbCedula.UseVisualStyleBackColor = True
        '
        'lstnombre
        '
        Me.lstnombre.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstnombre.ForeColor = System.Drawing.Color.Blue
        Me.lstnombre.FormattingEnabled = True
        Me.lstnombre.Location = New System.Drawing.Point(17, 162)
        Me.lstnombre.Name = "lstnombre"
        Me.lstnombre.Size = New System.Drawing.Size(327, 147)
        Me.lstnombre.TabIndex = 1301
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.MappingName = "COD_SEGCOBRANZA"
        Me.DataGridTextBoxColumn5.Width = 0
        '
        'SEGUIMIENTO_COBRANZA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1189, 488)
        Me.ControlBox = False
        Me.Controls.Add(Me.lstnombre)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnModificarSeguimiento)
        Me.Controls.Add(Me.btnGuardarSeguimiento)
        Me.Controls.Add(Me.txtObservacion)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtMontoCompromiso)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cbCobrador)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dg_Seguimiento)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnVerSeguimiento)
        Me.Controls.Add(Me.txtBuscar_Datos)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SEGUIMIENTO_COBRANZA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SEGUIMIENTO COBRANZA"
        CType(Me.dg_Seguimiento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnVerSeguimiento As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBuscar_Datos As System.Windows.Forms.TextBox
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents dg_Seguimiento As System.Windows.Forms.DataGrid
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cbCobrador As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtMontoCompromiso As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtObservacion As System.Windows.Forms.TextBox
    Friend WithEvents btnGuardarSeguimiento As System.Windows.Forms.Button
    Friend WithEvents btnModificarSeguimiento As System.Windows.Forms.Button
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbNombreApellido As System.Windows.Forms.RadioButton
    Friend WithEvents rbRuc As System.Windows.Forms.RadioButton
    Friend WithEvents rbCedula As System.Windows.Forms.RadioButton
    Friend WithEvents lstnombre As System.Windows.Forms.ListBox
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
End Class
