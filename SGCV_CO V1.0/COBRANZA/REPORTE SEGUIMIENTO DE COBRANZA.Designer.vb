<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class REPORTE_SEGUIMIENTO_DE_COBRANZA
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.rbRangoFechas = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbPorCedula = New System.Windows.Forms.RadioButton()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnVerSeguimiento = New System.Windows.Forms.Button()
        Me.txtCedulaCliente = New System.Windows.Forms.TextBox()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.DisplayStatusBar = False
        Me.CrystalReportViewer1.DisplayToolbar = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(381, 42)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(824, 515)
        Me.CrystalReportViewer1.TabIndex = 1334
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'rbRangoFechas
        '
        Me.rbRangoFechas.AutoSize = True
        Me.rbRangoFechas.Location = New System.Drawing.Point(174, 22)
        Me.rbRangoFechas.Name = "rbRangoFechas"
        Me.rbRangoFechas.Size = New System.Drawing.Size(122, 24)
        Me.rbRangoFechas.TabIndex = 1
        Me.rbRangoFechas.TabStop = True
        Me.rbRangoFechas.Text = "Rango Fechas"
        Me.rbRangoFechas.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbRangoFechas)
        Me.GroupBox1.Controls.Add(Me.rbPorCedula)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Green
        Me.GroupBox1.Location = New System.Drawing.Point(12, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(350, 52)
        Me.GroupBox1.TabIndex = 1333
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de Visualizacion"
        '
        'rbPorCedula
        '
        Me.rbPorCedula.AutoSize = True
        Me.rbPorCedula.Location = New System.Drawing.Point(47, 22)
        Me.rbPorCedula.Name = "rbPorCedula"
        Me.rbPorCedula.Size = New System.Drawing.Size(103, 24)
        Me.rbPorCedula.TabIndex = 0
        Me.rbPorCedula.TabStop = True
        Me.rbPorCedula.Text = "Por Cedula"
        Me.rbPorCedula.UseVisualStyleBackColor = True
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.CalendarFont = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker3.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DateTimePicker3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker3.Location = New System.Drawing.Point(12, 253)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(350, 23)
        Me.DateTimePicker3.TabIndex = 1332
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.White
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(13, 225)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(350, 22)
        Me.Label8.TabIndex = 1331
        Me.Label8.Text = "Fecha Seguimiento Final"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.CalendarFont = New System.Drawing.Font("Segoe UI Semibold", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DateTimePicker2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker2.Location = New System.Drawing.Point(12, 187)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(350, 23)
        Me.DateTimePicker2.TabIndex = 1330
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLimpiar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLimpiar.Location = New System.Drawing.Point(12, 357)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(351, 39)
        Me.btnLimpiar.TabIndex = 1329
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(13, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(350, 23)
        Me.Label3.TabIndex = 1328
        Me.Label3.Text = "Fecha Seguimiento Inicial"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnVerSeguimiento
        '
        Me.btnVerSeguimiento.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnVerSeguimiento.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerSeguimiento.Location = New System.Drawing.Point(12, 303)
        Me.btnVerSeguimiento.Name = "btnVerSeguimiento"
        Me.btnVerSeguimiento.Size = New System.Drawing.Size(350, 33)
        Me.btnVerSeguimiento.TabIndex = 1324
        Me.btnVerSeguimiento.Text = "Ver Seguimiento"
        Me.btnVerSeguimiento.UseVisualStyleBackColor = False
        '
        'txtCedulaCliente
        '
        Me.txtCedulaCliente.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCedulaCliente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCedulaCliente.Location = New System.Drawing.Point(12, 120)
        Me.txtCedulaCliente.Name = "txtCedulaCliente"
        Me.txtCedulaCliente.Size = New System.Drawing.Size(350, 29)
        Me.txtCedulaCliente.TabIndex = 1323
        Me.txtCedulaCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.Location = New System.Drawing.Point(12, 442)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(351, 36)
        Me.btnSalir.TabIndex = 1327
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(377, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(828, 23)
        Me.Label1.TabIndex = 1325
        Me.Label1.Text = "REPORTE DETALLES SEGUIMIENTO A CLIENTE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Green
        Me.Label2.Location = New System.Drawing.Point(12, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(350, 26)
        Me.Label2.TabIndex = 1326
        Me.Label2.Text = "CEDULA DE CLIENTE"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnImprimir
        '
        Me.btnImprimir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnImprimir.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnImprimir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnImprimir.Location = New System.Drawing.Point(12, 399)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(351, 39)
        Me.btnImprimir.TabIndex = 1335
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = False
        '
        'REPORTE_SEGUIMIENTO_DE_COBRANZA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1217, 569)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DateTimePicker3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnVerSeguimiento)
        Me.Controls.Add(Me.txtCedulaCliente)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "REPORTE_SEGUIMIENTO_DE_COBRANZA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REPORTE SEGUIMIENTO DE COBRANZA"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents rbRangoFechas As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rbPorCedula As System.Windows.Forms.RadioButton
    Friend WithEvents DateTimePicker3 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnVerSeguimiento As System.Windows.Forms.Button
    Friend WithEvents txtCedulaCliente As System.Windows.Forms.TextBox
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
End Class
