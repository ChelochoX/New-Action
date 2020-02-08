<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AGREGAR_PRODUCTOS_USADOS
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
        Me.btnIngresarMercaderia = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtDetalle_Producto = New System.Windows.Forms.TextBox()
        Me.txtCantidad_aIngresar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.lstProducto = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.lstDeposito = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDetalle_deposito = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnIngresarMercaderia
        '
        Me.btnIngresarMercaderia.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnIngresarMercaderia.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresarMercaderia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnIngresarMercaderia.Location = New System.Drawing.Point(6, 232)
        Me.btnIngresarMercaderia.Name = "btnIngresarMercaderia"
        Me.btnIngresarMercaderia.Size = New System.Drawing.Size(237, 28)
        Me.btnIngresarMercaderia.TabIndex = 15
        Me.btnIngresarMercaderia.Text = "INGRESAR MERCADERIA"
        Me.btnIngresarMercaderia.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtDetalle_Producto)
        Me.GroupBox2.Controls.Add(Me.txtCantidad_aIngresar)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtBusqueda)
        Me.GroupBox2.Controls.Add(Me.lstProducto)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.btnIngresarMercaderia)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Green
        Me.GroupBox2.Location = New System.Drawing.Point(12, 185)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(249, 272)
        Me.GroupBox2.TabIndex = 1282
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DETALLES DE ACCION "
        '
        'txtDetalle_Producto
        '
        Me.txtDetalle_Producto.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDetalle_Producto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDetalle_Producto.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetalle_Producto.ForeColor = System.Drawing.Color.Red
        Me.txtDetalle_Producto.Location = New System.Drawing.Point(6, 157)
        Me.txtDetalle_Producto.Name = "txtDetalle_Producto"
        Me.txtDetalle_Producto.ReadOnly = True
        Me.txtDetalle_Producto.Size = New System.Drawing.Size(237, 25)
        Me.txtDetalle_Producto.TabIndex = 13
        Me.txtDetalle_Producto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtCantidad_aIngresar
        '
        Me.txtCantidad_aIngresar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCantidad_aIngresar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad_aIngresar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCantidad_aIngresar.Location = New System.Drawing.Point(6, 203)
        Me.txtCantidad_aIngresar.Name = "txtCantidad_aIngresar"
        Me.txtCantidad_aIngresar.Size = New System.Drawing.Size(237, 23)
        Me.txtCantidad_aIngresar.TabIndex = 14
        Me.txtCantidad_aIngresar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(6, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(155, 20)
        Me.Label3.TabIndex = 1285
        Me.Label3.Text = "CANTIDAD A INGRESAR"
        '
        'txtBusqueda
        '
        Me.txtBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBusqueda.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqueda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBusqueda.Location = New System.Drawing.Point(6, 42)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(237, 23)
        Me.txtBusqueda.TabIndex = 11
        Me.txtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lstProducto
        '
        Me.lstProducto.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstProducto.ForeColor = System.Drawing.Color.Teal
        Me.lstProducto.FormattingEnabled = True
        Me.lstProducto.ItemHeight = 15
        Me.lstProducto.Location = New System.Drawing.Point(6, 72)
        Me.lstProducto.Name = "lstProducto"
        Me.lstProducto.Size = New System.Drawing.Size(237, 79)
        Me.lstProducto.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(6, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(155, 20)
        Me.Label6.TabIndex = 128
        Me.Label6.Text = "BUSCAR PRODUCTO"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.DisplayStatusBar = False
        Me.CrystalReportViewer1.DisplayToolbar = False
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(277, 43)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(543, 447)
        Me.CrystalReportViewer1.TabIndex = 1280
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.Location = New System.Drawing.Point(18, 463)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(234, 27)
        Me.btnSalir.TabIndex = 1000
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'lstDeposito
        '
        Me.lstDeposito.Font = New System.Drawing.Font("Rockwell", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstDeposito.ForeColor = System.Drawing.Color.Teal
        Me.lstDeposito.FormattingEnabled = True
        Me.lstDeposito.ItemHeight = 14
        Me.lstDeposito.Location = New System.Drawing.Point(21, 74)
        Me.lstDeposito.Name = "lstDeposito"
        Me.lstDeposito.Size = New System.Drawing.Size(234, 74)
        Me.lstDeposito.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(808, 23)
        Me.Label1.TabIndex = 1277
        Me.Label1.Text = "INGRESAR MERCADERIAS USADAS A STOCK"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(249, 20)
        Me.Label2.TabIndex = 1278
        Me.Label2.Text = "DETALLE DEPOSITO"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtDetalle_deposito
        '
        Me.txtDetalle_deposito.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDetalle_deposito.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDetalle_deposito.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetalle_deposito.ForeColor = System.Drawing.Color.Red
        Me.txtDetalle_deposito.Location = New System.Drawing.Point(21, 154)
        Me.txtDetalle_deposito.Name = "txtDetalle_deposito"
        Me.txtDetalle_deposito.ReadOnly = True
        Me.txtDetalle_deposito.Size = New System.Drawing.Size(234, 25)
        Me.txtDetalle_deposito.TabIndex = 10
        Me.txtDetalle_deposito.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'AGREGAR_PRODUCTOS_USADOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(832, 513)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtDetalle_deposito)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lstDeposito)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Name = "AGREGAR_PRODUCTOS_USADOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AGREGAR PRODUCTOS USADOS"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnIngresarMercaderia As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents lstDeposito As System.Windows.Forms.ListBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lstProducto As System.Windows.Forms.ListBox
    Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents txtCantidad_aIngresar As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDetalle_Producto As System.Windows.Forms.TextBox
    Friend WithEvents txtDetalle_deposito As System.Windows.Forms.TextBox
End Class
