<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FACTURACIONES_SON_DOCUMENTOS
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
        Me.txtDivisor = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.rbMensual = New System.Windows.Forms.RadioButton()
        Me.rbSemanal = New System.Windows.Forms.RadioButton()
        Me.btnRevertir_Operacion = New System.Windows.Forms.Button()
        Me.txtMontoCuenta = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.btnGenerarCuota = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rbDireccion = New System.Windows.Forms.RadioButton()
        Me.rbNombreApellido = New System.Windows.Forms.RadioButton()
        Me.rbRuc = New System.Windows.Forms.RadioButton()
        Me.rbCedula = New System.Windows.Forms.RadioButton()
        Me.txtBuscar_Datos = New System.Windows.Forms.TextBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgDeudas_Activas_Cliente = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.txtCuentaActual = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dg_clientes = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle2 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.txtEntregaInicial = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgDeudas_Activas_Cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtEntregaInicial)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtDivisor)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.GroupBox7)
        Me.GroupBox2.Controls.Add(Me.btnRevertir_Operacion)
        Me.GroupBox2.Controls.Add(Me.txtMontoCuenta)
        Me.GroupBox2.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox2.Controls.Add(Me.btnGenerarCuota)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(396, 200)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(684, 287)
        Me.GroupBox2.TabIndex = 1252
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "SELECCIONAR ACCION A EJECUTAR"
        '
        'txtDivisor
        '
        Me.txtDivisor.BackColor = System.Drawing.Color.White
        Me.txtDivisor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDivisor.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDivisor.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDivisor.Location = New System.Drawing.Point(359, 116)
        Me.txtDivisor.Name = "txtDivisor"
        Me.txtDivisor.Size = New System.Drawing.Size(309, 29)
        Me.txtDivisor.TabIndex = 100
        Me.txtDivisor.Text = "0"
        Me.txtDivisor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label20
        '
        Me.Label20.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label20.Location = New System.Drawing.Point(359, 93)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(309, 23)
        Me.Label20.TabIndex = 1258
        Me.Label20.Text = "CANTIDAD DE CUOTAS"
        Me.Label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.rbMensual)
        Me.GroupBox7.Controls.Add(Me.rbSemanal)
        Me.GroupBox7.Font = New System.Drawing.Font("Segoe UI", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox7.Location = New System.Drawing.Point(19, 32)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(309, 72)
        Me.GroupBox7.TabIndex = 1256
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "SELECCIONAR UNA FORMA DE PAGO"
        '
        'rbMensual
        '
        Me.rbMensual.AutoSize = True
        Me.rbMensual.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbMensual.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbMensual.Location = New System.Drawing.Point(34, 28)
        Me.rbMensual.Name = "rbMensual"
        Me.rbMensual.Size = New System.Drawing.Size(89, 25)
        Me.rbMensual.TabIndex = 0
        Me.rbMensual.TabStop = True
        Me.rbMensual.Text = "Mensual"
        Me.rbMensual.UseVisualStyleBackColor = True
        '
        'rbSemanal
        '
        Me.rbSemanal.AutoSize = True
        Me.rbSemanal.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbSemanal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.rbSemanal.Location = New System.Drawing.Point(176, 28)
        Me.rbSemanal.Name = "rbSemanal"
        Me.rbSemanal.Size = New System.Drawing.Size(89, 25)
        Me.rbSemanal.TabIndex = 1
        Me.rbSemanal.TabStop = True
        Me.rbSemanal.Text = "Semanal"
        Me.rbSemanal.UseVisualStyleBackColor = True
        '
        'btnRevertir_Operacion
        '
        Me.btnRevertir_Operacion.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRevertir_Operacion.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRevertir_Operacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRevertir_Operacion.Location = New System.Drawing.Point(19, 179)
        Me.btnRevertir_Operacion.Name = "btnRevertir_Operacion"
        Me.btnRevertir_Operacion.Size = New System.Drawing.Size(289, 38)
        Me.btnRevertir_Operacion.TabIndex = 1255
        Me.btnRevertir_Operacion.Text = "Revertir Operacion"
        Me.btnRevertir_Operacion.UseVisualStyleBackColor = False
        '
        'txtMontoCuenta
        '
        Me.txtMontoCuenta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMontoCuenta.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoCuenta.ForeColor = System.Drawing.Color.Green
        Me.txtMontoCuenta.Location = New System.Drawing.Point(359, 236)
        Me.txtMontoCuenta.Multiline = True
        Me.txtMontoCuenta.Name = "txtMontoCuenta"
        Me.txtMontoCuenta.Size = New System.Drawing.Size(309, 40)
        Me.txtMontoCuenta.TabIndex = 103
        Me.txtMontoCuenta.Text = "0"
        Me.txtMontoCuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.CalendarForeColor = System.Drawing.Color.Green
        Me.DateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DateTimePicker1.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DateTimePicker1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(359, 178)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(309, 25)
        Me.DateTimePicker1.TabIndex = 102
        '
        'btnGenerarCuota
        '
        Me.btnGenerarCuota.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnGenerarCuota.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGenerarCuota.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnGenerarCuota.Location = New System.Drawing.Point(19, 228)
        Me.btnGenerarCuota.Name = "btnGenerarCuota"
        Me.btnGenerarCuota.Size = New System.Drawing.Size(289, 40)
        Me.btnGenerarCuota.TabIndex = 1251
        Me.btnGenerarCuota.Text = "Generar Cuotas"
        Me.btnGenerarCuota.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(359, 213)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(309, 20)
        Me.Label1.TabIndex = 1250
        Me.Label1.Text = "MONTO CUENTA DE CLIENTE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label17
        '
        Me.Label17.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label17.Location = New System.Drawing.Point(359, 150)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(309, 23)
        Me.Label17.TabIndex = 1253
        Me.Label17.Text = "Fecha de Vencimiento Inicial"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCliente
        '
        Me.txtCliente.BackColor = System.Drawing.Color.White
        Me.txtCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCliente.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCliente.ForeColor = System.Drawing.Color.Red
        Me.txtCliente.Location = New System.Drawing.Point(751, 35)
        Me.txtCliente.Multiline = True
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(329, 80)
        Me.txtCliente.TabIndex = 4
        Me.txtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rbDireccion)
        Me.GroupBox3.Controls.Add(Me.rbNombreApellido)
        Me.GroupBox3.Controls.Add(Me.rbRuc)
        Me.GroupBox3.Controls.Add(Me.rbCedula)
        Me.GroupBox3.ForeColor = System.Drawing.Color.DarkGreen
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(368, 103)
        Me.GroupBox3.TabIndex = 1303
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Buscar por"
        '
        'rbDireccion
        '
        Me.rbDireccion.AutoSize = True
        Me.rbDireccion.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbDireccion.ForeColor = System.Drawing.Color.ForestGreen
        Me.rbDireccion.Location = New System.Drawing.Point(10, 77)
        Me.rbDireccion.Name = "rbDireccion"
        Me.rbDireccion.Size = New System.Drawing.Size(106, 17)
        Me.rbDireccion.TabIndex = 3
        Me.rbDireccion.TabStop = True
        Me.rbDireccion.Text = "POR DIRECCION"
        Me.rbDireccion.UseVisualStyleBackColor = True
        '
        'rbNombreApellido
        '
        Me.rbNombreApellido.AutoSize = True
        Me.rbNombreApellido.Font = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbNombreApellido.ForeColor = System.Drawing.Color.ForestGreen
        Me.rbNombreApellido.Location = New System.Drawing.Point(10, 56)
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
        'txtBuscar_Datos
        '
        Me.txtBuscar_Datos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscar_Datos.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar_Datos.ForeColor = System.Drawing.Color.Green
        Me.txtBuscar_Datos.Location = New System.Drawing.Point(12, 123)
        Me.txtBuscar_Datos.Name = "txtBuscar_Datos"
        Me.txtBuscar_Datos.Size = New System.Drawing.Size(368, 27)
        Me.txtBuscar_Datos.TabIndex = 1302
        Me.txtBuscar_Datos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLimpiar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLimpiar.Location = New System.Drawing.Point(29, 412)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(338, 31)
        Me.btnLimpiar.TabIndex = 1305
        Me.btnLimpiar.Text = "LIMPIAR DATOS"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.Location = New System.Drawing.Point(29, 449)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(338, 38)
        Me.btnSalir.TabIndex = 1306
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(396, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(684, 20)
        Me.Label2.TabIndex = 1307
        Me.Label2.Text = "DETALLE DE DEUDAS ACTIVAS DEL CLIENTE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dgDeudas_Activas_Cliente
        '
        Me.dgDeudas_Activas_Cliente.AlternatingBackColor = System.Drawing.Color.White
        Me.dgDeudas_Activas_Cliente.BackColor = System.Drawing.Color.White
        Me.dgDeudas_Activas_Cliente.BackgroundColor = System.Drawing.Color.Ivory
        Me.dgDeudas_Activas_Cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dgDeudas_Activas_Cliente.CaptionBackColor = System.Drawing.Color.DarkSlateBlue
        Me.dgDeudas_Activas_Cliente.CaptionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgDeudas_Activas_Cliente.CaptionForeColor = System.Drawing.Color.Lavender
        Me.dgDeudas_Activas_Cliente.DataMember = ""
        Me.dgDeudas_Activas_Cliente.FlatMode = True
        Me.dgDeudas_Activas_Cliente.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgDeudas_Activas_Cliente.ForeColor = System.Drawing.Color.Black
        Me.dgDeudas_Activas_Cliente.GridLineColor = System.Drawing.Color.Wheat
        Me.dgDeudas_Activas_Cliente.HeaderBackColor = System.Drawing.Color.CadetBlue
        Me.dgDeudas_Activas_Cliente.HeaderFont = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dgDeudas_Activas_Cliente.HeaderForeColor = System.Drawing.Color.Black
        Me.dgDeudas_Activas_Cliente.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dgDeudas_Activas_Cliente.Location = New System.Drawing.Point(396, 35)
        Me.dgDeudas_Activas_Cliente.Name = "dgDeudas_Activas_Cliente"
        Me.dgDeudas_Activas_Cliente.ParentRowsBackColor = System.Drawing.Color.Ivory
        Me.dgDeudas_Activas_Cliente.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dgDeudas_Activas_Cliente.ReadOnly = True
        Me.dgDeudas_Activas_Cliente.RowHeadersVisible = False
        Me.dgDeudas_Activas_Cliente.SelectionBackColor = System.Drawing.Color.Wheat
        Me.dgDeudas_Activas_Cliente.SelectionForeColor = System.Drawing.Color.DarkSlateBlue
        Me.dgDeudas_Activas_Cliente.Size = New System.Drawing.Size(349, 145)
        Me.dgDeudas_Activas_Cliente.TabIndex = 1308
        Me.dgDeudas_Activas_Cliente.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dgDeudas_Activas_Cliente
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "VF_CABECERA_CUENTACLIENTE"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "FECHA DE INGRESO"
        Me.DataGridTextBoxColumn1.MappingName = "FECHA_INGRESO"
        Me.DataGridTextBoxColumn1.Width = 120
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn2.Format = "n0"
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "DEUDA DE CLIENTE"
        Me.DataGridTextBoxColumn2.MappingName = "MONTO_CUENTA"
        Me.DataGridTextBoxColumn2.Width = 200
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.MappingName = "COD_CLIENTE"
        Me.DataGridTextBoxColumn3.Width = 0
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.MappingName = "COD_CABECERA_CUENTACLI"
        Me.DataGridTextBoxColumn4.Width = 0
        '
        'txtCuentaActual
        '
        Me.txtCuentaActual.BackColor = System.Drawing.Color.White
        Me.txtCuentaActual.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCuentaActual.ForeColor = System.Drawing.Color.Red
        Me.txtCuentaActual.Location = New System.Drawing.Point(751, 140)
        Me.txtCuentaActual.Multiline = True
        Me.txtCuentaActual.Name = "txtCuentaActual"
        Me.txtCuentaActual.Size = New System.Drawing.Size(284, 40)
        Me.txtCuentaActual.TabIndex = 1311
        Me.txtCuentaActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(751, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(284, 19)
        Me.Label3.TabIndex = 1310
        Me.Label3.Text = "DEUDAS TOTALES ACUMULADOS"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dg_clientes
        '
        Me.dg_clientes.AlternatingBackColor = System.Drawing.Color.White
        Me.dg_clientes.BackColor = System.Drawing.Color.White
        Me.dg_clientes.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dg_clientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dg_clientes.CaptionBackColor = System.Drawing.Color.Silver
        Me.dg_clientes.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dg_clientes.CaptionForeColor = System.Drawing.Color.Black
        Me.dg_clientes.DataMember = ""
        Me.dg_clientes.FlatMode = True
        Me.dg_clientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dg_clientes.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.dg_clientes.GridLineColor = System.Drawing.Color.DarkGray
        Me.dg_clientes.HeaderBackColor = System.Drawing.Color.DarkGreen
        Me.dg_clientes.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dg_clientes.HeaderForeColor = System.Drawing.Color.White
        Me.dg_clientes.LinkColor = System.Drawing.Color.DarkGreen
        Me.dg_clientes.Location = New System.Drawing.Point(12, 156)
        Me.dg_clientes.Name = "dg_clientes"
        Me.dg_clientes.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.dg_clientes.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dg_clientes.ReadOnly = True
        Me.dg_clientes.SelectionBackColor = System.Drawing.Color.DarkSeaGreen
        Me.dg_clientes.SelectionForeColor = System.Drawing.Color.Black
        Me.dg_clientes.Size = New System.Drawing.Size(368, 235)
        Me.dg_clientes.TabIndex = 1312
        Me.dg_clientes.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle2})
        '
        'DataGridTableStyle2
        '
        Me.DataGridTableStyle2.DataGrid = Me.dg_clientes
        Me.DataGridTableStyle2.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7})
        Me.DataGridTableStyle2.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DataGridTableStyle2.HeaderFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle2.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridTableStyle2.MappingName = "TP_CLIENTE"
        Me.DataGridTableStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "NOMBRE y APELLIDO"
        Me.DataGridTextBoxColumn5.MappingName = "NOM_APE"
        Me.DataGridTextBoxColumn5.Width = 200
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "CEDULA"
        Me.DataGridTextBoxColumn6.MappingName = "CI"
        Me.DataGridTextBoxColumn6.Width = 65
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.MappingName = "COD_CLIENTE"
        Me.DataGridTextBoxColumn7.Width = 0
        '
        'txtEntregaInicial
        '
        Me.txtEntregaInicial.BackColor = System.Drawing.Color.White
        Me.txtEntregaInicial.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEntregaInicial.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEntregaInicial.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEntregaInicial.Location = New System.Drawing.Point(359, 56)
        Me.txtEntregaInicial.Name = "txtEntregaInicial"
        Me.txtEntregaInicial.Size = New System.Drawing.Size(309, 29)
        Me.txtEntregaInicial.TabIndex = 99
        Me.txtEntregaInicial.Text = "0"
        Me.txtEntregaInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(359, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(309, 23)
        Me.Label4.TabIndex = 1260
        Me.Label4.Text = "ENTREGA INICIAL"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FACTURACIONES_SON_DOCUMENTOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1097, 518)
        Me.ControlBox = False
        Me.Controls.Add(Me.dg_clientes)
        Me.Controls.Add(Me.txtCuentaActual)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.dgDeudas_Activas_Cliente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.txtBuscar_Datos)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "FACTURACIONES_SON_DOCUMENTOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FACTURACIONES SIN DOCUMENTOS"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgDeudas_Activas_Cliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnGenerarCuota As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtMontoCuenta As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents btnRevertir_Operacion As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rbNombreApellido As System.Windows.Forms.RadioButton
    Friend WithEvents rbRuc As System.Windows.Forms.RadioButton
    Friend WithEvents rbCedula As System.Windows.Forms.RadioButton
    Friend WithEvents txtBuscar_Datos As System.Windows.Forms.TextBox
    Friend WithEvents rbDireccion As System.Windows.Forms.RadioButton
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgDeudas_Activas_Cliente As System.Windows.Forms.DataGrid
    Friend WithEvents txtCuentaActual As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents rbMensual As System.Windows.Forms.RadioButton
    Friend WithEvents rbSemanal As System.Windows.Forms.RadioButton
    Friend WithEvents txtDivisor As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents dg_clientes As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle2 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents txtEntregaInicial As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
