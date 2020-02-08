<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ANULAR_RECIBOS
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
        Me.btnLimpiarBusqueda = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtObs_Anulacion = New System.Windows.Forms.TextBox()
        Me.ltsDetallesBusqueda = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBuscar_Facturacion = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLimpiarBusqueda
        '
        Me.btnLimpiarBusqueda.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLimpiarBusqueda.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiarBusqueda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLimpiarBusqueda.Location = New System.Drawing.Point(13, 529)
        Me.btnLimpiarBusqueda.Name = "btnLimpiarBusqueda"
        Me.btnLimpiarBusqueda.Size = New System.Drawing.Size(213, 35)
        Me.btnLimpiarBusqueda.TabIndex = 1287
        Me.btnLimpiarBusqueda.Text = "LIMPIAR BUSQUEDA"
        Me.btnLimpiarBusqueda.UseVisualStyleBackColor = False
        '
        'btnGuardar
        '
        Me.btnGuardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnGuardar.Location = New System.Drawing.Point(13, 488)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(213, 35)
        Me.btnGuardar.TabIndex = 1276
        Me.btnGuardar.Text = "ANULAR RECIBO"
        Me.btnGuardar.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.Location = New System.Drawing.Point(13, 570)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(213, 35)
        Me.btnSalir.TabIndex = 1275
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'txtObs_Anulacion
        '
        Me.txtObs_Anulacion.BackColor = System.Drawing.Color.White
        Me.txtObs_Anulacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtObs_Anulacion.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObs_Anulacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtObs_Anulacion.Location = New System.Drawing.Point(14, 369)
        Me.txtObs_Anulacion.Multiline = True
        Me.txtObs_Anulacion.Name = "txtObs_Anulacion"
        Me.txtObs_Anulacion.Size = New System.Drawing.Size(212, 114)
        Me.txtObs_Anulacion.TabIndex = 1285
        '
        'ltsDetallesBusqueda
        '
        Me.ltsDetallesBusqueda.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltsDetallesBusqueda.ForeColor = System.Drawing.Color.Teal
        Me.ltsDetallesBusqueda.FormattingEnabled = True
        Me.ltsDetallesBusqueda.ItemHeight = 19
        Me.ltsDetallesBusqueda.Location = New System.Drawing.Point(14, 169)
        Me.ltsDetallesBusqueda.Name = "ltsDetallesBusqueda"
        Me.ltsDetallesBusqueda.Size = New System.Drawing.Size(212, 175)
        Me.ltsDetallesBusqueda.TabIndex = 1282
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(16, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(210, 20)
        Me.Label7.TabIndex = 1283
        Me.Label7.Text = "Detalles de Busqueda"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CalendarForeColor = System.Drawing.Color.Navy
        Me.DateTimePicker2.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(117, 90)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(106, 22)
        Me.DateTimePicker2.TabIndex = 1280
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(117, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(97, 23)
        Me.Label2.TabIndex = 1281
        Me.Label2.Text = "Fecha Fin"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnBuscar_Facturacion
        '
        Me.btnBuscar_Facturacion.BackColor = System.Drawing.Color.White
        Me.btnBuscar_Facturacion.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar_Facturacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBuscar_Facturacion.Location = New System.Drawing.Point(14, 119)
        Me.btnBuscar_Facturacion.Name = "btnBuscar_Facturacion"
        Me.btnBuscar_Facturacion.Size = New System.Drawing.Size(210, 28)
        Me.btnBuscar_Facturacion.TabIndex = 1279
        Me.btnBuscar_Facturacion.Text = "BUSCAR DOCUMENTO"
        Me.btnBuscar_Facturacion.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarForeColor = System.Drawing.Color.Navy
        Me.DateTimePicker1.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(16, 89)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(98, 22)
        Me.DateTimePicker1.TabIndex = 1277
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Green
        Me.Label6.Location = New System.Drawing.Point(17, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 23)
        Me.Label6.TabIndex = 1278
        Me.Label6.Text = "Fecha Inicio"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(17, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(1116, 23)
        Me.Label1.TabIndex = 1272
        Me.Label1.Text = "FORMULARIO ANULAR RECIBOS"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.DisplayStatusBar = False
        Me.CrystalReportViewer1.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CrystalReportViewer1.ForeColor = System.Drawing.Color.Navy
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(232, 78)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(901, 527)
        Me.CrystalReportViewer1.TabIndex = 1274
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Rockwell", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(11, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(215, 19)
        Me.Label4.TabIndex = 1286
        Me.Label4.Text = "BUSCAR DOCUMENTO POR FECHA"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(13, 348)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(213, 23)
        Me.Label8.TabIndex = 1284
        Me.Label8.Text = "Observaciones de Anulacion"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Green
        Me.Label3.Location = New System.Drawing.Point(232, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(901, 23)
        Me.Label3.TabIndex = 1273
        Me.Label3.Text = "Detalles de Visualizacion"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ANULAR_RECIBOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1144, 616)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnLimpiarBusqueda)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.txtObs_Anulacion)
        Me.Controls.Add(Me.ltsDetallesBusqueda)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnBuscar_Facturacion)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label3)
        Me.Name = "ANULAR_RECIBOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ANULAR RECIBOS   ** SGCV + CO (E) V1.1.0          CONSULTAS Y PRECIOS AL 0994 60 " & _
            "60 48  / 0982 12 12 69     *** TU VENDEDOR SOFT ***"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLimpiarBusqueda As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents txtObs_Anulacion As System.Windows.Forms.TextBox
    Friend WithEvents ltsDetallesBusqueda As System.Windows.Forms.ListBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar_Facturacion As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
