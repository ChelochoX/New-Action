<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REGISTRO_CLIENTE
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLimpiar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.btnSalir_cargo = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCIP = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtRUC = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.dg_cliente = New System.Windows.Forms.DataGrid()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn11 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn12 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn13 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn14 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn15 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn16 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtBuscar_Direccion = New System.Windows.Forms.TextBox()
        Me.txtBuscar_telefono = New System.Windows.Forms.TextBox()
        Me.txbuscar_nombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRef_Personal2 = New System.Windows.Forms.TextBox()
        Me.txtRef_Personal1 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtLongitud = New System.Windows.Forms.TextBox()
        Me.txtLatitud = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnDatosGarante = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        CType(Me.dg_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(13, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1023, 23)
        Me.Label1.TabIndex = 103
        Me.Label1.Text = "FORMULARIO REGISTRO DE CLIENTES"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtLimpiar
        '
        Me.txtLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtLimpiar.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLimpiar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtLimpiar.Location = New System.Drawing.Point(744, 268)
        Me.txtLimpiar.Name = "txtLimpiar"
        Me.txtLimpiar.Size = New System.Drawing.Size(84, 31)
        Me.txtLimpiar.TabIndex = 95
        Me.txtLimpiar.Text = "Limpiar"
        Me.txtLimpiar.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(14, 161)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 23)
        Me.Label9.TabIndex = 102
        Me.Label9.Text = "Direccion     **"
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnModificar.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnModificar.Location = New System.Drawing.Point(644, 268)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(92, 31)
        Me.btnModificar.TabIndex = 94
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'txtDireccion
        '
        Me.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDireccion.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDireccion.Location = New System.Drawing.Point(92, 155)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(432, 40)
        Me.txtDireccion.TabIndex = 92
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnguardar.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnguardar.Location = New System.Drawing.Point(552, 268)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(84, 31)
        Me.btnguardar.TabIndex = 93
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'txtTelefono
        '
        Me.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelefono.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTelefono.Location = New System.Drawing.Point(92, 126)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(304, 25)
        Me.txtTelefono.TabIndex = 91
        '
        'btnSalir_cargo
        '
        Me.btnSalir_cargo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir_cargo.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir_cargo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir_cargo.Location = New System.Drawing.Point(936, 268)
        Me.btnSalir_cargo.Name = "btnSalir_cargo"
        Me.btnSalir_cargo.Size = New System.Drawing.Size(84, 31)
        Me.btnSalir_cargo.TabIndex = 96
        Me.btnSalir_cargo.Text = "Salir"
        Me.btnSalir_cargo.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(14, 126)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 23)
        Me.Label7.TabIndex = 101
        Me.Label7.Text = "Telefono      **"
        '
        'txtCIP
        '
        Me.txtCIP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCIP.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCIP.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCIP.Location = New System.Drawing.Point(92, 69)
        Me.txtCIP.Name = "txtCIP"
        Me.txtCIP.Size = New System.Drawing.Size(304, 25)
        Me.txtCIP.TabIndex = 88
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(14, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 23)
        Me.Label5.TabIndex = 98
        Me.Label5.Text = "C.I.P."
        '
        'txtNombre
        '
        Me.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombre.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNombre.Location = New System.Drawing.Point(92, 98)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(432, 25)
        Me.txtNombre.TabIndex = 89
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(14, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 99
        Me.Label4.Text = "Nombre"
        '
        'txtRUC
        '
        Me.txtRUC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRUC.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRUC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRUC.Location = New System.Drawing.Point(92, 40)
        Me.txtRUC.Name = "txtRUC"
        Me.txtRUC.Size = New System.Drawing.Size(304, 25)
        Me.txtRUC.TabIndex = 87
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(14, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 23)
        Me.Label8.TabIndex = 97
        Me.Label8.Text = "RUC      "
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dg_cliente
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10, Me.DataGridTextBoxColumn11, Me.DataGridTextBoxColumn12, Me.DataGridTextBoxColumn13, Me.DataGridTextBoxColumn14, Me.DataGridTextBoxColumn15, Me.DataGridTextBoxColumn16})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "TP_CLIENTE"
        '
        'dg_cliente
        '
        Me.dg_cliente.AlternatingBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.dg_cliente.BackColor = System.Drawing.Color.White
        Me.dg_cliente.BackgroundColor = System.Drawing.Color.LightGoldenrodYellow
        Me.dg_cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dg_cliente.CaptionBackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.dg_cliente.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dg_cliente.CaptionForeColor = System.Drawing.Color.DarkSlateBlue
        Me.dg_cliente.DataMember = ""
        Me.dg_cliente.FlatMode = True
        Me.dg_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dg_cliente.ForeColor = System.Drawing.Color.DarkSlateBlue
        Me.dg_cliente.GridLineColor = System.Drawing.Color.Peru
        Me.dg_cliente.GridLineStyle = System.Windows.Forms.DataGridLineStyle.None
        Me.dg_cliente.HeaderBackColor = System.Drawing.Color.Maroon
        Me.dg_cliente.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dg_cliente.HeaderForeColor = System.Drawing.Color.LightGoldenrodYellow
        Me.dg_cliente.LinkColor = System.Drawing.Color.Maroon
        Me.dg_cliente.Location = New System.Drawing.Point(13, 314)
        Me.dg_cliente.Name = "dg_cliente"
        Me.dg_cliente.ParentRowsBackColor = System.Drawing.Color.BurlyWood
        Me.dg_cliente.ParentRowsForeColor = System.Drawing.Color.DarkSlateBlue
        Me.dg_cliente.ReadOnly = True
        Me.dg_cliente.RowHeadersVisible = False
        Me.dg_cliente.SelectionBackColor = System.Drawing.Color.DarkSlateBlue
        Me.dg_cliente.SelectionForeColor = System.Drawing.Color.GhostWhite
        Me.dg_cliente.Size = New System.Drawing.Size(1036, 311)
        Me.dg_cliente.TabIndex = 104
        Me.dg_cliente.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "RUC"
        Me.DataGridTextBoxColumn4.MappingName = "RUC"
        Me.DataGridTextBoxColumn4.Width = 85
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "CEDULA"
        Me.DataGridTextBoxColumn8.MappingName = "CI"
        Me.DataGridTextBoxColumn8.Width = 85
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "NOMBRE y APELLIDO"
        Me.DataGridTextBoxColumn9.MappingName = "NOM_APE"
        Me.DataGridTextBoxColumn9.Width = 250
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.HeaderText = "TELEFONO"
        Me.DataGridTextBoxColumn10.MappingName = "TELEFONO"
        Me.DataGridTextBoxColumn10.Width = 80
        '
        'DataGridTextBoxColumn11
        '
        Me.DataGridTextBoxColumn11.Format = ""
        Me.DataGridTextBoxColumn11.FormatInfo = Nothing
        Me.DataGridTextBoxColumn11.HeaderText = "DIRECCION"
        Me.DataGridTextBoxColumn11.MappingName = "DIRECCION"
        Me.DataGridTextBoxColumn11.Width = 450
        '
        'DataGridTextBoxColumn12
        '
        Me.DataGridTextBoxColumn12.Format = ""
        Me.DataGridTextBoxColumn12.FormatInfo = Nothing
        Me.DataGridTextBoxColumn12.MappingName = "COD_CLIENTE"
        Me.DataGridTextBoxColumn12.Width = 0
        '
        'DataGridTextBoxColumn13
        '
        Me.DataGridTextBoxColumn13.Format = ""
        Me.DataGridTextBoxColumn13.FormatInfo = Nothing
        Me.DataGridTextBoxColumn13.MappingName = "REF_PERSONAL1"
        Me.DataGridTextBoxColumn13.Width = 0
        '
        'DataGridTextBoxColumn14
        '
        Me.DataGridTextBoxColumn14.Format = ""
        Me.DataGridTextBoxColumn14.FormatInfo = Nothing
        Me.DataGridTextBoxColumn14.MappingName = "REF_PERSONAL2"
        Me.DataGridTextBoxColumn14.Width = 0
        '
        'DataGridTextBoxColumn15
        '
        Me.DataGridTextBoxColumn15.Format = ""
        Me.DataGridTextBoxColumn15.FormatInfo = Nothing
        Me.DataGridTextBoxColumn15.MappingName = "LATITUD"
        Me.DataGridTextBoxColumn15.Width = 0
        '
        'DataGridTextBoxColumn16
        '
        Me.DataGridTextBoxColumn16.Format = ""
        Me.DataGridTextBoxColumn16.FormatInfo = Nothing
        Me.DataGridTextBoxColumn16.MappingName = "LONGITUD"
        Me.DataGridTextBoxColumn16.Width = 0
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.MappingName = "COD_CLIENTE"
        Me.DataGridTextBoxColumn7.Width = 0
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "DIRECCION"
        Me.DataGridTextBoxColumn6.MappingName = "DIRECCION"
        Me.DataGridTextBoxColumn6.Width = 250
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "TELEFONO"
        Me.DataGridTextBoxColumn5.MappingName = "TELEFONO"
        Me.DataGridTextBoxColumn5.Width = 75
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "NOMBRE Y APELLIDO"
        Me.DataGridTextBoxColumn3.MappingName = "NOM_APE"
        Me.DataGridTextBoxColumn3.Width = 250
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "CI"
        Me.DataGridTextBoxColumn2.MappingName = "CI"
        Me.DataGridTextBoxColumn2.Width = 75
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "RUC"
        Me.DataGridTextBoxColumn1.MappingName = "RUC"
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtBuscar_Direccion)
        Me.GroupBox1.Controls.Add(Me.txtBuscar_telefono)
        Me.GroupBox1.Controls.Add(Me.txbuscar_nombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(549, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(486, 160)
        Me.GroupBox1.TabIndex = 105
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "OPCIONES DE BUSQUEDA"
        '
        'txtBuscar_Direccion
        '
        Me.txtBuscar_Direccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscar_Direccion.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar_Direccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBuscar_Direccion.Location = New System.Drawing.Point(69, 96)
        Me.txtBuscar_Direccion.Multiline = True
        Me.txtBuscar_Direccion.Name = "txtBuscar_Direccion"
        Me.txtBuscar_Direccion.Size = New System.Drawing.Size(403, 54)
        Me.txtBuscar_Direccion.TabIndex = 105
        '
        'txtBuscar_telefono
        '
        Me.txtBuscar_telefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscar_telefono.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar_telefono.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBuscar_telefono.Location = New System.Drawing.Point(69, 58)
        Me.txtBuscar_telefono.Name = "txtBuscar_telefono"
        Me.txtBuscar_telefono.Size = New System.Drawing.Size(275, 23)
        Me.txtBuscar_telefono.TabIndex = 104
        '
        'txbuscar_nombre
        '
        Me.txbuscar_nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txbuscar_nombre.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txbuscar_nombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txbuscar_nombre.Location = New System.Drawing.Point(69, 24)
        Me.txbuscar_nombre.Name = "txbuscar_nombre"
        Me.txbuscar_nombre.Size = New System.Drawing.Size(403, 23)
        Me.txbuscar_nombre.TabIndex = 103
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 23)
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "Direccion     **"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(12, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 23)
        Me.Label3.TabIndex = 107
        Me.Label3.Text = "Telefono      **"
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(12, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 23)
        Me.Label6.TabIndex = 106
        Me.Label6.Text = "Nombre"
        '
        'txtRef_Personal2
        '
        Me.txtRef_Personal2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRef_Personal2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRef_Personal2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRef_Personal2.Location = New System.Drawing.Point(92, 226)
        Me.txtRef_Personal2.Name = "txtRef_Personal2"
        Me.txtRef_Personal2.Size = New System.Drawing.Size(432, 25)
        Me.txtRef_Personal2.TabIndex = 107
        '
        'txtRef_Personal1
        '
        Me.txtRef_Personal1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRef_Personal1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRef_Personal1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRef_Personal1.Location = New System.Drawing.Point(92, 198)
        Me.txtRef_Personal1.Name = "txtRef_Personal1"
        Me.txtRef_Personal1.Size = New System.Drawing.Size(432, 25)
        Me.txtRef_Personal1.TabIndex = 106
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(14, 226)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(100, 23)
        Me.Label10.TabIndex = 109
        Me.Label10.Text = "Ref Pers. 2"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(14, 198)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(100, 23)
        Me.Label11.TabIndex = 108
        Me.Label11.Text = "Ref Pers. 1"
        '
        'txtLongitud
        '
        Me.txtLongitud.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLongitud.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLongitud.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtLongitud.Location = New System.Drawing.Point(92, 282)
        Me.txtLongitud.Name = "txtLongitud"
        Me.txtLongitud.Size = New System.Drawing.Size(432, 25)
        Me.txtLongitud.TabIndex = 111
        Me.txtLongitud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtLatitud
        '
        Me.txtLatitud.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLatitud.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLatitud.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtLatitud.Location = New System.Drawing.Point(92, 254)
        Me.txtLatitud.Name = "txtLatitud"
        Me.txtLatitud.Size = New System.Drawing.Size(432, 25)
        Me.txtLatitud.TabIndex = 110
        Me.txtLatitud.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(14, 282)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(100, 23)
        Me.Label12.TabIndex = 113
        Me.Label12.Text = "Longitud"
        '
        'Label13
        '
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(14, 254)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(100, 23)
        Me.Label13.TabIndex = 112
        Me.Label13.Text = "Latitud"
        '
        'btnDatosGarante
        '
        Me.btnDatosGarante.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnDatosGarante.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDatosGarante.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDatosGarante.Location = New System.Drawing.Point(549, 211)
        Me.btnDatosGarante.Name = "btnDatosGarante"
        Me.btnDatosGarante.Size = New System.Drawing.Size(486, 31)
        Me.btnDatosGarante.TabIndex = 114
        Me.btnDatosGarante.Text = "AGREGAR DATOS DEL GARANTE"
        Me.btnDatosGarante.UseVisualStyleBackColor = False
        '
        'btnEliminar
        '
        Me.btnEliminar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnEliminar.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnEliminar.Location = New System.Drawing.Point(836, 268)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(92, 31)
        Me.btnEliminar.TabIndex = 115
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = False
        '
        'REGISTRO_CLIENTE
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1061, 637)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnDatosGarante)
        Me.Controls.Add(Me.txtLongitud)
        Me.Controls.Add(Me.txtLatitud)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtRef_Personal2)
        Me.Controls.Add(Me.txtRef_Personal1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dg_cliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtLimpiar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.btnSalir_cargo)
        Me.Controls.Add(Me.txtCIP)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.txtRUC)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label8)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "REGISTRO_CLIENTE"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REGISTRO CLIENTE"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dg_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtLimpiar As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents btnSalir_cargo As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCIP As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRUC As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents dg_cliente As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn11 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn12 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtBuscar_Direccion As System.Windows.Forms.TextBox
    Friend WithEvents txtBuscar_telefono As System.Windows.Forms.TextBox
    Friend WithEvents txbuscar_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtRef_Personal2 As System.Windows.Forms.TextBox
    Friend WithEvents txtRef_Personal1 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtLongitud As System.Windows.Forms.TextBox
    Friend WithEvents txtLatitud As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents DataGridTextBoxColumn13 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn14 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn15 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn16 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btnDatosGarante As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
End Class
