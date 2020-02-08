Imports System.Data
Imports System.Data.SqlClient.SqlParameter
Imports System.Data.SqlClient.SqlException
Imports System.Data.SqlClient

Public Class Logeo_de_Usuario
    Inherits System.Windows.Forms.Form

    Dim fecha, fecha1 As DateTime

    'INSERTAR TABLA HISTORIAL USUARIO***
    Function Insertar_Historial_Usuario(ByVal a As Integer, _
                                 ByVal b As String, _
                                 ByVal c As DateTime, _
                                 ByVal d As DateTime, _
                                 ByVal e As String) As Integer
        Try
            Dim sel As String
            sel = "INSERT INTO TP_HISTORIAL_USUARIO" & _
           "(COD_HISTORIAL,USUARIO,ENTRADA,SALIDA,ESTADO)" & _
           "VALUES " & _
            "(@COD_HISTORIAL,@USUARIO,@ENTRADA,@SALIDA,@ESTADO)"

            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            cmm.Parameters.AddWithValue("@COD_HISTORIAL", a)
            cmm.Parameters.AddWithValue("@USUARIO", b)
            cmm.Parameters.AddWithValue("@ENTRADA", c)
            cmm.Parameters.AddWithValue("@SALIDA", d)
            cmm.Parameters.AddWithValue("@ESTADO", e)

            SQLconexion.Open()
            Dim t As Integer = CInt(cmm.ExecuteNonQuery())
            SQLconexion.Close()

            Return t

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

    End Function

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnIngresar As System.Windows.Forms.Button
    Friend WithEvents txtContraseña As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Logeo_de_Usuario))
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.White
        Me.btnSalir.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
        Me.btnSalir.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSalir.Location = New System.Drawing.Point(314, 247)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(86, 75)
        Me.btnSalir.TabIndex = 63
        Me.btnSalir.Text = "SALIR"
        Me.btnSalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'txtContraseña
        '
        Me.txtContraseña.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtContraseña.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtContraseña.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtContraseña.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContraseña.ForeColor = System.Drawing.Color.Blue
        Me.txtContraseña.Location = New System.Drawing.Point(191, 178)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtContraseña.Size = New System.Drawing.Size(230, 18)
        Me.txtContraseña.TabIndex = 58
        Me.txtContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.Color.WhiteSmoke
        Me.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUsuario.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.ForeColor = System.Drawing.Color.Blue
        Me.txtUsuario.Location = New System.Drawing.Point(191, 116)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(230, 18)
        Me.txtUsuario.TabIndex = 57
        Me.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnIngresar
        '
        Me.btnIngresar.BackColor = System.Drawing.Color.White
        Me.btnIngresar.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.btnIngresar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnIngresar.Image = CType(resources.GetObject("btnIngresar.Image"), System.Drawing.Image)
        Me.btnIngresar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnIngresar.Location = New System.Drawing.Point(176, 247)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(86, 75)
        Me.btnIngresar.TabIndex = 61
        Me.btnIngresar.Text = "INGRESAR"
        Me.btnIngresar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnIngresar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(124, 105)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(61, 43)
        Me.Button1.TabIndex = 64
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Button2.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(124, 167)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(61, 43)
        Me.Button2.TabIndex = 65
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(191, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 21)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "USUARIO"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(191, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(230, 21)
        Me.Label2.TabIndex = 67
        Me.Label2.Text = "CONTRASEÑA"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Logeo_de_Usuario
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(571, 366)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnIngresar)
        Me.Name = "Logeo_de_Usuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub Logeo_de_Usuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fecha = DateTime.Now
    End Sub

    Function Usuario_Habilitado(ByVal a As String, ByVal b As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM CONFIG_USUARIO WHERE DATOS_PERSONALES = '" & a & "' AND ESTADO = '" & b & "'"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As Integer = CInt(cmm.ExecuteScalar())
            cmm.Dispose()
            SQLconexion.Close()

            Return t
        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Function

    Private Sub btnIngresar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresar.Click
        Dim usuario, contrasena As String
        usuario = Trim(Me.txtUsuario.Text)
        contrasena = Trim(Me.txtContraseña.Text)
        '***********************************************************
        If Usuario_Habilitado(usuario, "USUARIO HABILITADO") = 0 Then
            MessageBox.Show("USUARIO INHABILITADO PARA OPERAR,VER CON SU ADMINISTRADOR", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtUsuario.Focus()
        Else
            '***********************************************************
            ESTADO_ABIERTO("CERRADO", "ABIERTO")

            If verificar_usuario(usuario, contrasena) = 0 Then
                MessageBox.Show("ERROR AL INGRESAR USUARIO O CONTRASEÑA. VUELVA A INTENTAR", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtUsuario.Focus()
            Else
                Try
                    Dim contador As Integer
                    contador = Contador_InicioSesion() + 1
                    SQLconexion.Open()
                    Dim sqlbuilder As New System.Text.StringBuilder
                    With sqlbuilder
                        .Append("INSERT INTO CONFIG_INICIO_SESION")
                        .Append(" VALUES ('")
                        .Append(contador & "','")
                        .Append(usuario & "','")
                        .Append(Today & "','")
                        .Append("ABIERTO" & "')")

                    End With
                    cmm = New SqlClient.SqlCommand(sqlbuilder.ToString, SQLconexion)
                    cmm.ExecuteNonQuery()
                    SQLconexion.Close()
                    cmm.Dispose()
                    SQLconexion.Dispose()

                Catch ex As SqlClient.SqlException
                    MsgBox(ex.Message())
                    SQLconexion.Close()
                End Try

                usuario_AUX = Trim(Me.txtUsuario.Text)
                contrasena_AUX = Trim(Me.txtContraseña.Text)

                Dim FRM_MENU_PRINCIPAL As New MENU_PRINCIPAL
                FRM_MENU_PRINCIPAL.Show()
                Me.Hide()

            End If
        End If

    End Sub

    Function ESTADO_ABIERTO(ByVal a As String, ByVal b As String) As String
        Try
            conectar()
            Dim sel As String
            sel = "UPDATE CONFIG_INICIO_SESION SET ESTADO = '" & a & "' WHERE ESTADO = '" & b & "'"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As String = CStr(cmm.ExecuteScalar())
            cmm.Dispose()
            SQLconexion.Close()

            Return t
        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

    End Function

    Function Contador_InicioSesion() As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM CONFIG_INICIO_SESION"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As Integer = CInt(cmm.ExecuteScalar())
            cmm.Dispose()
            SQLconexion.Close()

            Return t
        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

    End Function
    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Function verificar_usuario(ByVal a As String, ByVal b As String) As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM CONFIG_USUARIO WHERE DATOS_PERSONALES = '" & a & "' AND CONTRASENA = '" & b & "'"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As String = CStr(cmm.ExecuteScalar())
            cmm.Dispose()
            SQLconexion.Close()

            Return t
        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Function

End Class
