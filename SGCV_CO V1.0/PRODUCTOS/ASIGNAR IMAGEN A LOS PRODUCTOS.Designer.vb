<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ASIGNAR_IMAGEN_A_LOS_PRODUCTOS
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
        Me.txtBuscar_Producto = New System.Windows.Forms.TextBox()
        Me.lstCodigo = New System.Windows.Forms.ListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lstNombre = New System.Windows.Forms.ListBox()
        Me.txtProducto_Seleccionado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAplicar_Imagen = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnSeleccionar_Imagen = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtDescripcion_Producto = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBuscar_porCodigo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBuscar_porDescripcion = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtBuscar_Producto
        '
        Me.txtBuscar_Producto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscar_Producto.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar_Producto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBuscar_Producto.Location = New System.Drawing.Point(26, 83)
        Me.txtBuscar_Producto.Name = "txtBuscar_Producto"
        Me.txtBuscar_Producto.Size = New System.Drawing.Size(376, 25)
        Me.txtBuscar_Producto.TabIndex = 1
        Me.txtBuscar_Producto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lstCodigo
        '
        Me.lstCodigo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lstCodigo.FormattingEnabled = True
        Me.lstCodigo.ItemHeight = 17
        Me.lstCodigo.Location = New System.Drawing.Point(26, 168)
        Me.lstCodigo.Name = "lstCodigo"
        Me.lstCodigo.Size = New System.Drawing.Size(90, 395)
        Me.lstCodigo.TabIndex = 1282
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Maroon
        Me.Label4.Location = New System.Drawing.Point(26, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(376, 23)
        Me.Label4.TabIndex = 1281
        Me.Label4.Text = "Buscar Producto por Nombre"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lstNombre
        '
        Me.lstNombre.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lstNombre.FormattingEnabled = True
        Me.lstNombre.ItemHeight = 17
        Me.lstNombre.Location = New System.Drawing.Point(119, 168)
        Me.lstNombre.Name = "lstNombre"
        Me.lstNombre.Size = New System.Drawing.Size(281, 395)
        Me.lstNombre.TabIndex = 1286
        '
        'txtProducto_Seleccionado
        '
        Me.txtProducto_Seleccionado.BackColor = System.Drawing.Color.White
        Me.txtProducto_Seleccionado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtProducto_Seleccionado.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProducto_Seleccionado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtProducto_Seleccionado.Location = New System.Drawing.Point(406, 29)
        Me.txtProducto_Seleccionado.Multiline = True
        Me.txtProducto_Seleccionado.Name = "txtProducto_Seleccionado"
        Me.txtProducto_Seleccionado.ReadOnly = True
        Me.txtProducto_Seleccionado.Size = New System.Drawing.Size(239, 132)
        Me.txtProducto_Seleccionado.TabIndex = 1287
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(406, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(239, 23)
        Me.Label1.TabIndex = 1288
        Me.Label1.Text = "Detalle de Producto Seleccionado"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAplicar_Imagen
        '
        Me.btnAplicar_Imagen.BackColor = System.Drawing.Color.LightGreen
        Me.btnAplicar_Imagen.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAplicar_Imagen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnAplicar_Imagen.Location = New System.Drawing.Point(26, 602)
        Me.btnAplicar_Imagen.Name = "btnAplicar_Imagen"
        Me.btnAplicar_Imagen.Size = New System.Drawing.Size(376, 30)
        Me.btnAplicar_Imagen.TabIndex = 1291
        Me.btnAplicar_Imagen.Text = "APLICAR IMAGEN AL PRODUCTO"
        Me.btnAplicar_Imagen.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnSalir.Location = New System.Drawing.Point(26, 634)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(376, 30)
        Me.btnSalir.TabIndex = 1290
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnSeleccionar_Imagen
        '
        Me.btnSeleccionar_Imagen.BackColor = System.Drawing.Color.LightGreen
        Me.btnSeleccionar_Imagen.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeleccionar_Imagen.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSeleccionar_Imagen.Location = New System.Drawing.Point(26, 569)
        Me.btnSeleccionar_Imagen.Name = "btnSeleccionar_Imagen"
        Me.btnSeleccionar_Imagen.Size = New System.Drawing.Size(376, 30)
        Me.btnSeleccionar_Imagen.TabIndex = 1289
        Me.btnSeleccionar_Imagen.Text = "SELECCIONAR IMAGEN DE REFERENCIA"
        Me.btnSeleccionar_Imagen.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(651, 34)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(572, 625)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 1292
        Me.PictureBox1.TabStop = False
        '
        'txtDescripcion_Producto
        '
        Me.txtDescripcion_Producto.BackColor = System.Drawing.Color.White
        Me.txtDescripcion_Producto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDescripcion_Producto.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion_Producto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDescripcion_Producto.Location = New System.Drawing.Point(406, 167)
        Me.txtDescripcion_Producto.Multiline = True
        Me.txtDescripcion_Producto.Name = "txtDescripcion_Producto"
        Me.txtDescripcion_Producto.ReadOnly = True
        Me.txtDescripcion_Producto.Size = New System.Drawing.Size(239, 427)
        Me.txtDescripcion_Producto.TabIndex = 1293
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Maroon
        Me.Label2.Location = New System.Drawing.Point(649, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(574, 23)
        Me.Label2.TabIndex = 1295
        Me.Label2.Text = "Imagen de Referencia"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Maroon
        Me.Label3.Location = New System.Drawing.Point(26, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(376, 23)
        Me.Label3.TabIndex = 1297
        Me.Label3.Text = "Buscar Producto por Codigo"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBuscar_porCodigo
        '
        Me.txtBuscar_porCodigo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscar_porCodigo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar_porCodigo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBuscar_porCodigo.Location = New System.Drawing.Point(26, 29)
        Me.txtBuscar_porCodigo.Name = "txtBuscar_porCodigo"
        Me.txtBuscar_porCodigo.Size = New System.Drawing.Size(376, 25)
        Me.txtBuscar_porCodigo.TabIndex = 0
        Me.txtBuscar_porCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Maroon
        Me.Label5.Location = New System.Drawing.Point(26, 111)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(376, 23)
        Me.Label5.TabIndex = 1299
        Me.Label5.Text = "Buscar Producto por Descripcion"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtBuscar_porDescripcion
        '
        Me.txtBuscar_porDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBuscar_porDescripcion.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBuscar_porDescripcion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtBuscar_porDescripcion.Location = New System.Drawing.Point(26, 137)
        Me.txtBuscar_porDescripcion.Name = "txtBuscar_porDescripcion"
        Me.txtBuscar_porDescripcion.Size = New System.Drawing.Size(376, 25)
        Me.txtBuscar_porDescripcion.TabIndex = 3
        Me.txtBuscar_porDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ASIGNAR_IMAGEN_A_LOS_PRODUCTOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1235, 671)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtBuscar_porDescripcion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtBuscar_porCodigo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDescripcion_Producto)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnAplicar_Imagen)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnSeleccionar_Imagen)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lstNombre)
        Me.Controls.Add(Me.lstCodigo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtProducto_Seleccionado)
        Me.Controls.Add(Me.txtBuscar_Producto)
        Me.Name = "ASIGNAR_IMAGEN_A_LOS_PRODUCTOS"
        Me.Text = "SISTEMA DE GESTION DE COMPRAS Y VENTAS VERSION (E) V1.1.0          CONSULTAS Y PR" & _
            "ECIOS AL 0994 60 60 48  / 0982 12 12 69     *** TU VENDEDOR SOFT ***"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtBuscar_Producto As System.Windows.Forms.TextBox
    Friend WithEvents lstCodigo As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lstNombre As System.Windows.Forms.ListBox
    Friend WithEvents txtProducto_Seleccionado As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAplicar_Imagen As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnSeleccionar_Imagen As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents txtDescripcion_Producto As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtBuscar_porCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtBuscar_porDescripcion As System.Windows.Forms.TextBox
End Class
