<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EMPRESA
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
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btnSalir_cargo = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtPropietario = New System.Windows.Forms.TextBox()
        Me.txtNombreEmpresa = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSucursal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtActividad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnRecuperar = New System.Windows.Forms.Button()
        Me.txtActividad_ = New System.Windows.Forms.TextBox()
        Me.txtTelefono_ = New System.Windows.Forms.TextBox()
        Me.txtDireccion_ = New System.Windows.Forms.TextBox()
        Me.txtPropietario_ = New System.Windows.Forms.TextBox()
        Me.txtEmpresa_ = New System.Windows.Forms.TextBox()
        Me.txtsucursal_ = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnModificar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnModificar.Location = New System.Drawing.Point(271, 251)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(94, 31)
        Me.btnModificar.TabIndex = 130
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnguardar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnguardar.Location = New System.Drawing.Point(179, 251)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(94, 31)
        Me.btnguardar.TabIndex = 129
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'btnSalir_cargo
        '
        Me.btnSalir_cargo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir_cargo.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir_cargo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir_cargo.Location = New System.Drawing.Point(363, 251)
        Me.btnSalir_cargo.Name = "btnSalir_cargo"
        Me.btnSalir_cargo.Size = New System.Drawing.Size(94, 31)
        Me.btnSalir_cargo.TabIndex = 131
        Me.btnSalir_cargo.Text = "Salir"
        Me.btnSalir_cargo.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(12, 71)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 20)
        Me.Label9.TabIndex = 128
        Me.Label9.Text = "Propietario"
        '
        'txtPropietario
        '
        Me.txtPropietario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPropietario.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPropietario.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPropietario.Location = New System.Drawing.Point(76, 68)
        Me.txtPropietario.Name = "txtPropietario"
        Me.txtPropietario.Size = New System.Drawing.Size(419, 23)
        Me.txtPropietario.TabIndex = 124
        '
        'txtNombreEmpresa
        '
        Me.txtNombreEmpresa.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtNombreEmpresa.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreEmpresa.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtNombreEmpresa.Location = New System.Drawing.Point(76, 40)
        Me.txtNombreEmpresa.Name = "txtNombreEmpresa"
        Me.txtNombreEmpresa.Size = New System.Drawing.Size(419, 23)
        Me.txtNombreEmpresa.TabIndex = 122
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(12, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 16)
        Me.Label4.TabIndex = 126
        Me.Label4.Text = "Empresa"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(484, 20)
        Me.Label1.TabIndex = 120
        Me.Label1.Text = "DATOS DE LA EMPRESA"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtTelefono
        '
        Me.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelefono.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTelefono.Location = New System.Drawing.Point(76, 96)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(220, 23)
        Me.txtTelefono.TabIndex = 133
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 20)
        Me.Label2.TabIndex = 134
        Me.Label2.Text = "Telefono"
        '
        'txtDireccion
        '
        Me.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDireccion.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDireccion.Location = New System.Drawing.Point(76, 125)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(419, 23)
        Me.txtDireccion.TabIndex = 135
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(12, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.TabIndex = 136
        Me.Label3.Text = "Direccion"
        '
        'txtSucursal
        '
        Me.txtSucursal.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSucursal.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSucursal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSucursal.Location = New System.Drawing.Point(76, 154)
        Me.txtSucursal.Name = "txtSucursal"
        Me.txtSucursal.Size = New System.Drawing.Size(419, 23)
        Me.txtSucursal.TabIndex = 137
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(12, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 20)
        Me.Label5.TabIndex = 138
        Me.Label5.Text = "Sucursal"
        '
        'txtActividad
        '
        Me.txtActividad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtActividad.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtActividad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtActividad.Location = New System.Drawing.Point(76, 181)
        Me.txtActividad.Multiline = True
        Me.txtActividad.Name = "txtActividad"
        Me.txtActividad.Size = New System.Drawing.Size(419, 64)
        Me.txtActividad.TabIndex = 139
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(12, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 20)
        Me.Label6.TabIndex = 140
        Me.Label6.Text = "Actividad"
        '
        'btnRecuperar
        '
        Me.btnRecuperar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRecuperar.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRecuperar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRecuperar.Location = New System.Drawing.Point(88, 251)
        Me.btnRecuperar.Name = "btnRecuperar"
        Me.btnRecuperar.Size = New System.Drawing.Size(94, 31)
        Me.btnRecuperar.TabIndex = 142
        Me.btnRecuperar.Text = "Recuperar"
        Me.btnRecuperar.UseVisualStyleBackColor = False
        '
        'txtActividad_
        '
        Me.txtActividad_.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtActividad_.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtActividad_.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtActividad_.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtActividad_.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtActividad_.Location = New System.Drawing.Point(501, 60)
        Me.txtActividad_.Multiline = True
        Me.txtActividad_.Name = "txtActividad_"
        Me.txtActividad_.ReadOnly = True
        Me.txtActividad_.Size = New System.Drawing.Size(572, 64)
        Me.txtActividad_.TabIndex = 147
        Me.txtActividad_.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTelefono_
        '
        Me.txtTelefono_.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTelefono_.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTelefono_.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTelefono_.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefono_.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTelefono_.Location = New System.Drawing.Point(501, 225)
        Me.txtTelefono_.Multiline = True
        Me.txtTelefono_.Name = "txtTelefono_"
        Me.txtTelefono_.ReadOnly = True
        Me.txtTelefono_.Size = New System.Drawing.Size(572, 20)
        Me.txtTelefono_.TabIndex = 146
        Me.txtTelefono_.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtDireccion_
        '
        Me.txtDireccion_.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDireccion_.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDireccion_.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDireccion_.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccion_.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtDireccion_.Location = New System.Drawing.Point(501, 157)
        Me.txtDireccion_.Multiline = True
        Me.txtDireccion_.Name = "txtDireccion_"
        Me.txtDireccion_.ReadOnly = True
        Me.txtDireccion_.Size = New System.Drawing.Size(572, 61)
        Me.txtDireccion_.TabIndex = 145
        Me.txtDireccion_.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPropietario_
        '
        Me.txtPropietario_.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPropietario_.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPropietario_.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPropietario_.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPropietario_.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPropietario_.Location = New System.Drawing.Point(501, 130)
        Me.txtPropietario_.Multiline = True
        Me.txtPropietario_.Name = "txtPropietario_"
        Me.txtPropietario_.ReadOnly = True
        Me.txtPropietario_.Size = New System.Drawing.Size(572, 20)
        Me.txtPropietario_.TabIndex = 144
        Me.txtPropietario_.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtEmpresa_
        '
        Me.txtEmpresa_.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEmpresa_.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmpresa_.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEmpresa_.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpresa_.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEmpresa_.Location = New System.Drawing.Point(501, 9)
        Me.txtEmpresa_.Multiline = True
        Me.txtEmpresa_.Name = "txtEmpresa_"
        Me.txtEmpresa_.ReadOnly = True
        Me.txtEmpresa_.Size = New System.Drawing.Size(572, 51)
        Me.txtEmpresa_.TabIndex = 143
        Me.txtEmpresa_.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtsucursal_
        '
        Me.txtsucursal_.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtsucursal_.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtsucursal_.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtsucursal_.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsucursal_.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtsucursal_.Location = New System.Drawing.Point(501, 251)
        Me.txtsucursal_.Multiline = True
        Me.txtsucursal_.Name = "txtsucursal_"
        Me.txtsucursal_.ReadOnly = True
        Me.txtsucursal_.Size = New System.Drawing.Size(572, 32)
        Me.txtsucursal_.TabIndex = 148
        Me.txtsucursal_.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'EMPRESA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1083, 295)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtsucursal_)
        Me.Controls.Add(Me.txtActividad_)
        Me.Controls.Add(Me.txtTelefono_)
        Me.Controls.Add(Me.txtDireccion_)
        Me.Controls.Add(Me.txtPropietario_)
        Me.Controls.Add(Me.txtEmpresa_)
        Me.Controls.Add(Me.btnRecuperar)
        Me.Controls.Add(Me.txtActividad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtSucursal)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btnSalir_cargo)
        Me.Controls.Add(Me.txtPropietario)
        Me.Controls.Add(Me.txtNombreEmpresa)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label9)
        Me.Name = "EMPRESA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EMPRESA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents btnSalir_cargo As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtPropietario As System.Windows.Forms.TextBox
    Friend WithEvents txtNombreEmpresa As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSucursal As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtActividad As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnRecuperar As System.Windows.Forms.Button
    Friend WithEvents txtActividad_ As System.Windows.Forms.TextBox
    Friend WithEvents txtTelefono_ As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion_ As System.Windows.Forms.TextBox
    Friend WithEvents txtPropietario_ As System.Windows.Forms.TextBox
    Friend WithEvents txtEmpresa_ As System.Windows.Forms.TextBox
    Friend WithEvents txtsucursal_ As System.Windows.Forms.TextBox
End Class
