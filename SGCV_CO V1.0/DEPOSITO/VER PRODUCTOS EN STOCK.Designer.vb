<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VER_PRODUCTOS_EN_STOCK
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
        Me.txtBuscar_Producto = New System.Windows.Forms.TextBox()
        Me.lstProducto = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dg_Stock = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtDepositoAfectado = New System.Windows.Forms.TextBox()
        Me.txtBuscar_porCodigo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtLimpiarBusqueda = New System.Windows.Forms.Button()
        CType(Me.dg_Stock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(901, 23)
        Me.Label1.TabIndex = 1252
        Me.Label1.Text = "VISUALIZAR PRODUCTOS EN DEPOSITO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBuscar_Producto
        '
        Me.txtBuscar_Producto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscar_Producto.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar_Producto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBuscar_Producto.Location = New System.Drawing.Point(12, 126)
        Me.txtBuscar_Producto.Name = "txtBuscar_Producto"
        Me.txtBuscar_Producto.Size = New System.Drawing.Size(310, 25)
        Me.txtBuscar_Producto.TabIndex = 1
        Me.txtBuscar_Producto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lstProducto
        '
        Me.lstProducto.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstProducto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lstProducto.FormattingEnabled = True
        Me.lstProducto.ItemHeight = 17
        Me.lstProducto.Location = New System.Drawing.Point(331, 68)
        Me.lstProducto.Name = "lstProducto"
        Me.lstProducto.Size = New System.Drawing.Size(582, 191)
        Me.lstProducto.TabIndex = 1269
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(12, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(310, 23)
        Me.Label4.TabIndex = 1268
        Me.Label4.Text = "BUSCAR PRODUCTO POR NOMBRE"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(310, 23)
        Me.Label2.TabIndex = 1270
        Me.Label2.Text = "DEPOSITO AFECTADO"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dg_Stock
        '
        Me.dg_Stock.AlternatingBackColor = System.Drawing.Color.White
        Me.dg_Stock.BackColor = System.Drawing.Color.White
        Me.dg_Stock.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.dg_Stock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dg_Stock.CaptionBackColor = System.Drawing.Color.Silver
        Me.dg_Stock.CaptionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dg_Stock.CaptionForeColor = System.Drawing.Color.Black
        Me.dg_Stock.DataMember = ""
        Me.dg_Stock.FlatMode = True
        Me.dg_Stock.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dg_Stock.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.dg_Stock.GridLineColor = System.Drawing.Color.DarkGray
        Me.dg_Stock.HeaderBackColor = System.Drawing.Color.DarkGreen
        Me.dg_Stock.HeaderFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dg_Stock.HeaderForeColor = System.Drawing.Color.White
        Me.dg_Stock.LinkColor = System.Drawing.Color.DarkGreen
        Me.dg_Stock.Location = New System.Drawing.Point(328, 266)
        Me.dg_Stock.Name = "dg_Stock"
        Me.dg_Stock.ParentRowsBackColor = System.Drawing.Color.Gainsboro
        Me.dg_Stock.ParentRowsForeColor = System.Drawing.Color.Black
        Me.dg_Stock.ReadOnly = True
        Me.dg_Stock.RowHeadersVisible = False
        Me.dg_Stock.SelectionBackColor = System.Drawing.Color.DarkSeaGreen
        Me.dg_Stock.SelectionForeColor = System.Drawing.Color.Black
        Me.dg_Stock.Size = New System.Drawing.Size(585, 212)
        Me.dg_Stock.TabIndex = 1319
        Me.dg_Stock.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dg_Stock
        Me.DataGridTableStyle1.ForeColor = System.Drawing.Color.Black
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4})
        Me.DataGridTableStyle1.HeaderBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DataGridTableStyle1.MappingName = "SC_STOCK"
        Me.DataGridTableStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DataGridTableStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "DEPOSITO"
        Me.DataGridTextBoxColumn1.MappingName = "DEPOSITO"
        Me.DataGridTextBoxColumn1.Width = 75
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "CODIGO"
        Me.DataGridTextBoxColumn2.MappingName = "CODIGO_PRODUCTO"
        Me.DataGridTextBoxColumn2.Width = 75
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "PRODUCTO"
        Me.DataGridTextBoxColumn3.MappingName = "NOMBRE_PRODUCTO"
        Me.DataGridTextBoxColumn3.Width = 300
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn4.Format = "n0"
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "CANTIDAD"
        Me.DataGridTextBoxColumn4.MappingName = "CANTIDAD"
        Me.DataGridTextBoxColumn4.Width = 75
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(328, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(584, 23)
        Me.Label3.TabIndex = 1320
        Me.Label3.Text = "DETALLES DEL PRODUCTO EN DEPOSITO"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.Location = New System.Drawing.Point(12, 445)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(310, 33)
        Me.btnSalir.TabIndex = 1321
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'txtDepositoAfectado
        '
        Me.txtDepositoAfectado.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDepositoAfectado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDepositoAfectado.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepositoAfectado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDepositoAfectado.Location = New System.Drawing.Point(12, 68)
        Me.txtDepositoAfectado.Name = "txtDepositoAfectado"
        Me.txtDepositoAfectado.ReadOnly = True
        Me.txtDepositoAfectado.Size = New System.Drawing.Size(310, 25)
        Me.txtDepositoAfectado.TabIndex = 1322
        Me.txtDepositoAfectado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtBuscar_porCodigo
        '
        Me.txtBuscar_porCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscar_porCodigo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar_porCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBuscar_porCodigo.Location = New System.Drawing.Point(12, 179)
        Me.txtBuscar_porCodigo.Name = "txtBuscar_porCodigo"
        Me.txtBuscar_porCodigo.Size = New System.Drawing.Size(310, 25)
        Me.txtBuscar_porCodigo.TabIndex = 2
        Me.txtBuscar_porCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(12, 155)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(310, 23)
        Me.Label5.TabIndex = 1324
        Me.Label5.Text = "BUSCAR PRODUCTO POR CODIGO"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtLimpiarBusqueda
        '
        Me.txtLimpiarBusqueda.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtLimpiarBusqueda.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLimpiarBusqueda.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtLimpiarBusqueda.Location = New System.Drawing.Point(12, 406)
        Me.txtLimpiarBusqueda.Name = "txtLimpiarBusqueda"
        Me.txtLimpiarBusqueda.Size = New System.Drawing.Size(310, 33)
        Me.txtLimpiarBusqueda.TabIndex = 1327
        Me.txtLimpiarBusqueda.Text = "LIMPIAR BUSQUEDA"
        Me.txtLimpiarBusqueda.UseVisualStyleBackColor = False
        '
        'VER_PRODUCTOS_EN_STOCK
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(935, 521)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtLimpiarBusqueda)
        Me.Controls.Add(Me.txtBuscar_porCodigo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDepositoAfectado)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtBuscar_Producto)
        Me.Controls.Add(Me.lstProducto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dg_Stock)
        Me.Controls.Add(Me.Label3)
        Me.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Name = "VER_PRODUCTOS_EN_STOCK"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VER PRODUCTOS EN STOCK ** SGCV + CO (E) V1.1.0          CONSULTAS Y PRECIOS AL 09" & _
            "94 60 60 48  / 0982 12 12 69     *** TU VENDEDOR SOFT ***"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dg_Stock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBuscar_Producto As System.Windows.Forms.TextBox
    Friend WithEvents lstProducto As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dg_Stock As System.Windows.Forms.DataGrid
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents txtDepositoAfectado As System.Windows.Forms.TextBox
    Friend WithEvents txtBuscar_porCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtLimpiarBusqueda As System.Windows.Forms.Button
End Class
