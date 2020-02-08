<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DETALLES_DE_CAJA
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnEstadoCaja = New System.Windows.Forms.Button()
        Me.txtTotalenCaja = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txttotalCobrado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.txtMontoApertura = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtSucursalHabilitada = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dg_DetalleCaja = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.dg_DetalleCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btnEstadoCaja)
        Me.Panel1.Controls.Add(Me.txtTotalenCaja)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txttotalCobrado)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtFecha)
        Me.Panel1.Controls.Add(Me.txtMontoApertura)
        Me.Panel1.Controls.Add(Me.txtUsuario)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtSucursalHabilitada)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(848, 146)
        Me.Panel1.TabIndex = 0
        '
        'btnEstadoCaja
        '
        Me.btnEstadoCaja.BackColor = System.Drawing.Color.White
        Me.btnEstadoCaja.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEstadoCaja.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnEstadoCaja.Location = New System.Drawing.Point(21, 93)
        Me.btnEstadoCaja.Name = "btnEstadoCaja"
        Me.btnEstadoCaja.Size = New System.Drawing.Size(812, 40)
        Me.btnEstadoCaja.TabIndex = 0
        Me.btnEstadoCaja.UseVisualStyleBackColor = False
        '
        'txtTotalenCaja
        '
        Me.txtTotalenCaja.BackColor = System.Drawing.Color.White
        Me.txtTotalenCaja.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTotalenCaja.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalenCaja.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTotalenCaja.Location = New System.Drawing.Point(527, 64)
        Me.txtTotalenCaja.Name = "txtTotalenCaja"
        Me.txtTotalenCaja.ReadOnly = True
        Me.txtTotalenCaja.Size = New System.Drawing.Size(306, 23)
        Me.txtTotalenCaja.TabIndex = 5010
        Me.txtTotalenCaja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(403, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 23)
        Me.Label6.TabIndex = 5009
        Me.Label6.Text = "TOTAL EN CAJA"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txttotalCobrado
        '
        Me.txttotalCobrado.BackColor = System.Drawing.Color.White
        Me.txttotalCobrado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txttotalCobrado.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotalCobrado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txttotalCobrado.Location = New System.Drawing.Point(527, 35)
        Me.txttotalCobrado.Name = "txttotalCobrado"
        Me.txttotalCobrado.ReadOnly = True
        Me.txttotalCobrado.Size = New System.Drawing.Size(306, 23)
        Me.txttotalCobrado.TabIndex = 5007
        Me.txttotalCobrado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(403, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 23)
        Me.Label1.TabIndex = 5008
        Me.Label1.Text = "MONTO COBRADO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFecha
        '
        Me.txtFecha.BackColor = System.Drawing.Color.White
        Me.txtFecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFecha.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFecha.Location = New System.Drawing.Point(95, 64)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.ReadOnly = True
        Me.txtFecha.Size = New System.Drawing.Size(302, 23)
        Me.txtFecha.TabIndex = 1000
        Me.txtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMontoApertura
        '
        Me.txtMontoApertura.BackColor = System.Drawing.Color.White
        Me.txtMontoApertura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtMontoApertura.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMontoApertura.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtMontoApertura.Location = New System.Drawing.Point(527, 6)
        Me.txtMontoApertura.Name = "txtMontoApertura"
        Me.txtMontoApertura.ReadOnly = True
        Me.txtMontoApertura.Size = New System.Drawing.Size(306, 23)
        Me.txtMontoApertura.TabIndex = 1
        Me.txtMontoApertura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.White
        Me.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUsuario.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtUsuario.Location = New System.Drawing.Point(95, 35)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.ReadOnly = True
        Me.txtUsuario.Size = New System.Drawing.Size(302, 23)
        Me.txtUsuario.TabIndex = 5006
        Me.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(403, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 23)
        Me.Label5.TabIndex = 5003
        Me.Label5.Text = "MONTO APERTURA"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(18, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 23)
        Me.Label7.TabIndex = 5003
        Me.Label7.Text = "SUCURSAL HABILITADA"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSucursalHabilitada
        '
        Me.txtSucursalHabilitada.BackColor = System.Drawing.Color.White
        Me.txtSucursalHabilitada.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSucursalHabilitada.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSucursalHabilitada.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSucursalHabilitada.Location = New System.Drawing.Point(95, 6)
        Me.txtSucursalHabilitada.Name = "txtSucursalHabilitada"
        Me.txtSucursalHabilitada.ReadOnly = True
        Me.txtSucursalHabilitada.Size = New System.Drawing.Size(302, 23)
        Me.txtSucursalHabilitada.TabIndex = 5005
        Me.txtSucursalHabilitada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(18, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 23)
        Me.Label2.TabIndex = 5004
        Me.Label2.Text = "USUARIO "
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(18, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 23)
        Me.Label4.TabIndex = 5001
        Me.Label4.Text = "FECHA"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dg_DetalleCaja
        '
        Me.dg_DetalleCaja.AlternatingBackColor = System.Drawing.Color.White
        Me.dg_DetalleCaja.BackColor = System.Drawing.Color.White
        Me.dg_DetalleCaja.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dg_DetalleCaja.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dg_DetalleCaja.CaptionBackColor = System.Drawing.Color.Silver
        Me.dg_DetalleCaja.CaptionFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dg_DetalleCaja.CaptionForeColor = System.Drawing.Color.Black
        Me.dg_DetalleCaja.DataMember = ""
        Me.dg_DetalleCaja.FlatMode = True
        Me.dg_DetalleCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dg_DetalleCaja.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.dg_DetalleCaja.GridLineColor = System.Drawing.Color.DarkGray
        Me.dg_DetalleCaja.HeaderBackColor = System.Drawing.Color.DarkGreen
        Me.dg_DetalleCaja.HeaderFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.dg_DetalleCaja.HeaderForeColor = System.Drawing.Color.White
        Me.dg_DetalleCaja.LinkColor = System.Drawing.Color.DarkGreen
        Me.dg_DetalleCaja.Location = New System.Drawing.Point(12, 164)
        Me.dg_DetalleCaja.Name = "dg_DetalleCaja"
        Me.dg_DetalleCaja.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.dg_DetalleCaja.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dg_DetalleCaja.ReadOnly = True
        Me.dg_DetalleCaja.RowHeadersVisible = False
        Me.dg_DetalleCaja.SelectionBackColor = System.Drawing.Color.DarkSeaGreen
        Me.dg_DetalleCaja.SelectionForeColor = System.Drawing.Color.Black
        Me.dg_DetalleCaja.Size = New System.Drawing.Size(848, 425)
        Me.dg_DetalleCaja.TabIndex = 1314
        Me.dg_DetalleCaja.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dg_DetalleCaja
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6})
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.Lime
        Me.DataGridTableStyle1.HeaderFont = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridTableStyle1.MappingName = "CP_DETALLE_CAJA"
        Me.DataGridTableStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "RECIBO N°"
        Me.DataGridTextBoxColumn1.MappingName = "RECIBO_NUMERO"
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn2.Format = "n0"
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "MONTO RECIBO"
        Me.DataGridTextBoxColumn2.MappingName = "MONTO_RECIBO"
        Me.DataGridTextBoxColumn2.Width = 120
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "FACTURA N°"
        Me.DataGridTextBoxColumn3.MappingName = "FACTURA_NUMERO"
        Me.DataGridTextBoxColumn3.Width = 110
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn4.Format = "n0"
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "MONTO FACTURA"
        Me.DataGridTextBoxColumn4.MappingName = "MONTO_FACTURA"
        Me.DataGridTextBoxColumn4.Width = 120
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "FORMA DE PAGO"
        Me.DataGridTextBoxColumn5.MappingName = "FORMA_PAGO"
        Me.DataGridTextBoxColumn5.Width = 120
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "DETALLES DE PAGO"
        Me.DataGridTextBoxColumn6.MappingName = "DETALLE_FORMAPAGO"
        Me.DataGridTextBoxColumn6.Width = 200
        '
        'DETALLES_DE_CAJA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(873, 601)
        Me.Controls.Add(Me.dg_DetalleCaja)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "DETALLES_DE_CAJA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DETALLES DE CAJA"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dg_DetalleCaja, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtSucursalHabilitada As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtMontoApertura As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTotalenCaja As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txttotalCobrado As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnEstadoCaja As System.Windows.Forms.Button
    Friend WithEvents dg_DetalleCaja As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
End Class
