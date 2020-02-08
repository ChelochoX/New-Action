<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VER_DOCUMENTOS_ANULADOS
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
        Me.ltsDetallesBusqueda = New System.Windows.Forms.ListBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBuscar_Facturacion = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFechaAnulacion = New System.Windows.Forms.TextBox()
        Me.txtMotivoAnulacion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.Location = New System.Drawing.Point(12, 321)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(409, 28)
        Me.btnSalir.TabIndex = 3009
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'ltsDetallesBusqueda
        '
        Me.ltsDetallesBusqueda.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltsDetallesBusqueda.ForeColor = System.Drawing.Color.DarkCyan
        Me.ltsDetallesBusqueda.FormattingEnabled = True
        Me.ltsDetallesBusqueda.ItemHeight = 20
        Me.ltsDetallesBusqueda.Location = New System.Drawing.Point(12, 151)
        Me.ltsDetallesBusqueda.Name = "ltsDetallesBusqueda"
        Me.ltsDetallesBusqueda.Size = New System.Drawing.Size(199, 164)
        Me.ltsDetallesBusqueda.TabIndex = 3005
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CalendarFont = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.CalendarForeColor = System.Drawing.Color.Navy
        Me.DateTimePicker2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(236, 65)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DateTimePicker2.Size = New System.Drawing.Size(121, 23)
        Me.DateTimePicker2.TabIndex = 3003
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(12, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(199, 20)
        Me.Label7.TabIndex = 3006
        Me.Label7.Text = "Detalle Documentos"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(236, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 23)
        Me.Label2.TabIndex = 3004
        Me.Label2.Text = "Fecha Fin"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnBuscar_Facturacion
        '
        Me.btnBuscar_Facturacion.BackColor = System.Drawing.Color.White
        Me.btnBuscar_Facturacion.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuscar_Facturacion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBuscar_Facturacion.Location = New System.Drawing.Point(12, 94)
        Me.btnBuscar_Facturacion.Name = "btnBuscar_Facturacion"
        Me.btnBuscar_Facturacion.Size = New System.Drawing.Size(406, 28)
        Me.btnBuscar_Facturacion.TabIndex = 3001
        Me.btnBuscar_Facturacion.Text = "Buscar Facturacion"
        Me.btnBuscar_Facturacion.UseVisualStyleBackColor = False
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.CalendarForeColor = System.Drawing.Color.Navy
        Me.DateTimePicker1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(61, 65)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.DateTimePicker1.Size = New System.Drawing.Size(121, 23)
        Me.DateTimePicker1.TabIndex = 3011
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(16, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(402, 23)
        Me.Label4.TabIndex = 3007
        Me.Label4.Text = "BUSCAR DOCUMENTO POR FECHA"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(57, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 23)
        Me.Label6.TabIndex = 3002
        Me.Label6.Text = "Fecha Inicio"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(217, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(201, 20)
        Me.Label1.TabIndex = 3012
        Me.Label1.Text = "Fecha Anulacion"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtFechaAnulacion
        '
        Me.txtFechaAnulacion.BackColor = System.Drawing.Color.White
        Me.txtFechaAnulacion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaAnulacion.Location = New System.Drawing.Point(221, 151)
        Me.txtFechaAnulacion.Name = "txtFechaAnulacion"
        Me.txtFechaAnulacion.ReadOnly = True
        Me.txtFechaAnulacion.Size = New System.Drawing.Size(197, 23)
        Me.txtFechaAnulacion.TabIndex = 3013
        Me.txtFechaAnulacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtMotivoAnulacion
        '
        Me.txtMotivoAnulacion.BackColor = System.Drawing.Color.White
        Me.txtMotivoAnulacion.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMotivoAnulacion.Location = New System.Drawing.Point(221, 202)
        Me.txtMotivoAnulacion.Multiline = True
        Me.txtMotivoAnulacion.Name = "txtMotivoAnulacion"
        Me.txtMotivoAnulacion.ReadOnly = True
        Me.txtMotivoAnulacion.Size = New System.Drawing.Size(197, 113)
        Me.txtMotivoAnulacion.TabIndex = 3015
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(217, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(201, 20)
        Me.Label3.TabIndex = 3014
        Me.Label3.Text = "Motivo Anulacion"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'VER_DOCUMENTOS_ANULADOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(433, 358)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtMotivoAnulacion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtFechaAnulacion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.ltsDetallesBusqueda)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnBuscar_Facturacion)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label6)
        Me.Name = "VER_DOCUMENTOS_ANULADOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VER DOCUMENTOS ANULADOS"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents ltsDetallesBusqueda As System.Windows.Forms.ListBox
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar_Facturacion As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFechaAnulacion As System.Windows.Forms.TextBox
    Friend WithEvents txtMotivoAnulacion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
