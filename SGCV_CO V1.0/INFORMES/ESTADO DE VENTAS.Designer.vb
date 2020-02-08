<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ESTADO_DE_VENTAS
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
        Me.dg_EstadoCuentaCliente = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtARCAFacturado = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txtARCACobrado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtTUVENDEDORCobrado = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTUVENDEDORFacturado = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.txtTotal_hastaLaFecha = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        CType(Me.dg_EstadoCuentaCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'dg_EstadoCuentaCliente
        '
        Me.dg_EstadoCuentaCliente.AlternatingBackColor = System.Drawing.Color.White
        Me.dg_EstadoCuentaCliente.BackColor = System.Drawing.Color.White
        Me.dg_EstadoCuentaCliente.BackgroundColor = System.Drawing.Color.Ivory
        Me.dg_EstadoCuentaCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dg_EstadoCuentaCliente.CaptionBackColor = System.Drawing.Color.DarkSlateBlue
        Me.dg_EstadoCuentaCliente.CaptionFont = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dg_EstadoCuentaCliente.CaptionForeColor = System.Drawing.Color.Lavender
        Me.dg_EstadoCuentaCliente.DataMember = ""
        Me.dg_EstadoCuentaCliente.FlatMode = True
        Me.dg_EstadoCuentaCliente.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dg_EstadoCuentaCliente.ForeColor = System.Drawing.Color.Black
        Me.dg_EstadoCuentaCliente.GridLineColor = System.Drawing.Color.Wheat
        Me.dg_EstadoCuentaCliente.HeaderBackColor = System.Drawing.Color.CadetBlue
        Me.dg_EstadoCuentaCliente.HeaderFont = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dg_EstadoCuentaCliente.HeaderForeColor = System.Drawing.Color.Black
        Me.dg_EstadoCuentaCliente.LinkColor = System.Drawing.Color.DarkSlateBlue
        Me.dg_EstadoCuentaCliente.Location = New System.Drawing.Point(9, 29)
        Me.dg_EstadoCuentaCliente.Name = "dg_EstadoCuentaCliente"
        Me.dg_EstadoCuentaCliente.ParentRowsBackColor = System.Drawing.Color.Ivory
        Me.dg_EstadoCuentaCliente.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dg_EstadoCuentaCliente.ReadOnly = True
        Me.dg_EstadoCuentaCliente.RowHeadersVisible = False
        Me.dg_EstadoCuentaCliente.SelectionBackColor = System.Drawing.Color.Wheat
        Me.dg_EstadoCuentaCliente.SelectionForeColor = System.Drawing.Color.DarkSlateBlue
        Me.dg_EstadoCuentaCliente.Size = New System.Drawing.Size(345, 417)
        Me.dg_EstadoCuentaCliente.TabIndex = 1345
        Me.dg_EstadoCuentaCliente.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dg_EstadoCuentaCliente
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn4})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "VF_CABECERA_CUENTACLIENTE"
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "Reg"
        Me.DataGridTextBoxColumn3.MappingName = "COD_CABECERA_CUENTACLI"
        Me.DataGridTextBoxColumn3.Width = 35
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "FECHA INGRESO"
        Me.DataGridTextBoxColumn1.MappingName = "FECHA_INGRESO"
        Me.DataGridTextBoxColumn1.Width = 120
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn2.Format = "n0"
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "MONTO CUENTA"
        Me.DataGridTextBoxColumn2.MappingName = "MONTO_CUENTA"
        Me.DataGridTextBoxColumn2.Width = 120
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.MappingName = "COD_FACTURA"
        Me.DataGridTextBoxColumn4.Width = 0
        '
        'DataGrid1
        '
        Me.DataGrid1.AlternatingBackColor = System.Drawing.Color.White
        Me.DataGrid1.BackColor = System.Drawing.Color.White
        Me.DataGrid1.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DataGrid1.CaptionBackColor = System.Drawing.Color.Silver
        Me.DataGrid1.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DataGrid1.CaptionForeColor = System.Drawing.Color.Black
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.FlatMode = True
        Me.DataGrid1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DataGrid1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.DataGrid1.GridLineColor = System.Drawing.Color.DarkGray
        Me.DataGrid1.HeaderBackColor = System.Drawing.Color.DarkGreen
        Me.DataGrid1.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DataGrid1.HeaderForeColor = System.Drawing.Color.White
        Me.DataGrid1.LinkColor = System.Drawing.Color.DarkGreen
        Me.DataGrid1.Location = New System.Drawing.Point(9, 29)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.DataGrid1.ParentRowsForeColor = System.Drawing.Color.Black
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.RowHeadersVisible = False
        Me.DataGrid1.SelectionBackColor = System.Drawing.Color.DarkSeaGreen
        Me.DataGrid1.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGrid1.Size = New System.Drawing.Size(369, 417)
        Me.DataGrid1.TabIndex = 1345
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dg_EstadoCuentaCliente)
        Me.GroupBox2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Green
        Me.GroupBox2.Location = New System.Drawing.Point(439, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(370, 462)
        Me.GroupBox2.TabIndex = 1346
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ESTADO DE CUENTA CLIENTES"
        '
        'txtARCAFacturado
        '
        Me.txtARCAFacturado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtARCAFacturado.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtARCAFacturado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtARCAFacturado.Location = New System.Drawing.Point(10, 62)
        Me.txtARCAFacturado.Name = "txtARCAFacturado"
        Me.txtARCAFacturado.Size = New System.Drawing.Size(390, 29)
        Me.txtARCAFacturado.TabIndex = 1347
        Me.txtARCAFacturado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtARCACobrado)
        Me.GroupBox3.Controls.Add(Me.txtARCAFacturado)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.Green
        Me.GroupBox3.Location = New System.Drawing.Point(18, 137)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(415, 167)
        Me.GroupBox3.TabIndex = 1347
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "TOTAL VENTAS GENERADO ARCA"
        '
        'txtARCACobrado
        '
        Me.txtARCACobrado.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtARCACobrado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtARCACobrado.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtARCACobrado.ForeColor = System.Drawing.Color.Red
        Me.txtARCACobrado.Location = New System.Drawing.Point(10, 120)
        Me.txtARCACobrado.Name = "txtARCACobrado"
        Me.txtARCACobrado.Size = New System.Drawing.Size(390, 29)
        Me.txtARCACobrado.TabIndex = 1347
        Me.txtARCACobrado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(10, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(390, 25)
        Me.Label1.TabIndex = 1348
        Me.Label1.Text = "FACTURADO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(10, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(390, 25)
        Me.Label2.TabIndex = 1349
        Me.Label2.Text = "COBRADO"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtTUVENDEDORCobrado)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtTUVENDEDORFacturado)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Green
        Me.GroupBox1.Location = New System.Drawing.Point(18, 310)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(415, 164)
        Me.GroupBox1.TabIndex = 1352
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "TOTAL VENTAS GENERADO TU VENDEDOR"
        '
        'txtTUVENDEDORCobrado
        '
        Me.txtTUVENDEDORCobrado.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTUVENDEDORCobrado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTUVENDEDORCobrado.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTUVENDEDORCobrado.ForeColor = System.Drawing.Color.Red
        Me.txtTUVENDEDORCobrado.Location = New System.Drawing.Point(13, 109)
        Me.txtTUVENDEDORCobrado.Name = "txtTUVENDEDORCobrado"
        Me.txtTUVENDEDORCobrado.Size = New System.Drawing.Size(381, 29)
        Me.txtTUVENDEDORCobrado.TabIndex = 1356
        Me.txtTUVENDEDORCobrado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(13, 90)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(381, 25)
        Me.Label4.TabIndex = 1357
        Me.Label4.Text = "TOTAL COBRADO"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txtTUVENDEDORFacturado
        '
        Me.txtTUVENDEDORFacturado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTUVENDEDORFacturado.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTUVENDEDORFacturado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTUVENDEDORFacturado.Location = New System.Drawing.Point(13, 51)
        Me.txtTUVENDEDORFacturado.Name = "txtTUVENDEDORFacturado"
        Me.txtTUVENDEDORFacturado.Size = New System.Drawing.Size(381, 29)
        Me.txtTUVENDEDORFacturado.TabIndex = 1347
        Me.txtTUVENDEDORFacturado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(13, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(381, 25)
        Me.Label5.TabIndex = 1348
        Me.Label5.Text = "FACTURADO"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.DataGrid1)
        Me.GroupBox4.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.ForeColor = System.Drawing.Color.Green
        Me.GroupBox4.Location = New System.Drawing.Point(815, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(392, 462)
        Me.GroupBox4.TabIndex = 1347
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "DETALLE DE CUENTA CLIENTES"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.txtTotal_hastaLaFecha)
        Me.GroupBox5.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox5.Location = New System.Drawing.Point(18, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(415, 119)
        Me.GroupBox5.TabIndex = 1353
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "TOTAL FACTURADO HASTA LA FECHA"
        '
        'txtTotal_hastaLaFecha
        '
        Me.txtTotal_hastaLaFecha.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotal_hastaLaFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotal_hastaLaFecha.Font = New System.Drawing.Font("Segoe UI Semibold", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotal_hastaLaFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtTotal_hastaLaFecha.Location = New System.Drawing.Point(6, 30)
        Me.txtTotal_hastaLaFecha.Multiline = True
        Me.txtTotal_hastaLaFecha.Name = "txtTotal_hastaLaFecha"
        Me.txtTotal_hastaLaFecha.Size = New System.Drawing.Size(394, 72)
        Me.txtTotal_hastaLaFecha.TabIndex = 1348
        Me.txtTotal_hastaLaFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.Location = New System.Drawing.Point(18, 480)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(1189, 38)
        Me.btnSalir.TabIndex = 1354
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'ESTADO_DE_VENTAS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1219, 532)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "ESTADO_DE_VENTAS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ESTADO DE VENTAS"
        CType(Me.dg_EstadoCuentaCliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dg_EstadoCuentaCliente As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtARCAFacturado As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents txtARCACobrado As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTUVENDEDORFacturado As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTUVENDEDORCobrado As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents txtTotal_hastaLaFecha As System.Windows.Forms.TextBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
End Class
