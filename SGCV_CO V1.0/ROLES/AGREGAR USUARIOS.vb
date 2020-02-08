Public Class AGREGAR_USUARIOS
    Dim contador As Integer
    Dim DaUsuario As New SqlClient.SqlDataAdapter


    Private Sub AGREGAR_USUARIOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Visualizar_Usuario()
    End Sub
    Function Contador_Usuario() As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM CONFIG_USUARIO"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As Integer = CInt(cmm.ExecuteScalar())
            cmm.Dispose()
            SQLconexion.Close()

            Return t
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try

    End Function

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        If Me.txtDatos_Personales.Text = "" Then
            MessageBox.Show("INGRESAR DATOS PERSONALES ", "SGCV_CO V1.0", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtDatos_Personales.Focus()
        Else
            contador = Contador_Usuario() + 1
            Try
                SQLconexion.Open()
                Dim sqlbuilder As New System.Text.StringBuilder
                With sqlbuilder
                    .Append("INSERT INTO CONFIG_USUARIO")
                    .Append(" VALUES ('")
                    .Append(contador & "','")
                    .Append(CStr(Me.txtCIP.Text) & "','")
                    .Append(CStr(Me.txtDatos_Personales.Text) & "','")
                    .Append(CStr(Me.txtTelefono.Text) & "','")
                    .Append(CStr(Me.txtDireccion.Text) & "','")
                    .Append("USUARIO BLOQUEADO" & "','")
                    .Append("" & "','")
                    .Append("" & "','")
                    .Append("" & "')")

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

            'LIMPIAR LOS CAMPOS
            Me.txtCIP.Clear()
            Me.txtDatos_Personales.Clear()
            Me.txtTelefono.Clear()
            Me.txtDireccion.Clear()

        End If

        Visualizar_Usuario()

    End Sub

    Sub Visualizar_Usuario()
        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM CONFIG_USUARIO "
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaUsuario = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            Dim dt As New DataTable("USUARIO")
            DaUsuario.Fill(dt)
            SQLconexion.Close()

            With ListBox1
                .DataSource = dt
                .DisplayMember = "DATOS USUARIO"
                .ValueMember = "DATOS_PERSONALES"
            End With

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub

    Private Sub ListBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.Click
        Dim NOMBRE As String
        NOMBRE = Me.ListBox1.Text

        Me.txtCIP.Text = CEDULA(NOMBRE)
        Me.txtDatos_Personales.Text = NOMBRE
        Me.txtTelefono.Text = TELEFONO(NOMBRE)
        Me.txtDireccion.Text = DIRECCION(NOMBRE)

    End Sub

    Function CEDULA(ByVal A As String) As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT CEDULA FROM CONFIG_USUARIO WHERE DATOS_PERSONALES = '" & A & "'"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As String = CStr(cmm.ExecuteScalar())
            cmm.Dispose()
            SQLconexion.Close()

            Return t
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Function

    Function TELEFONO(ByVal A As String) As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT TELEFONO FROM CONFIG_USUARIO WHERE DATOS_PERSONALES = '" & A & "'"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As String = CStr(cmm.ExecuteScalar())
            cmm.Dispose()
            SQLconexion.Close()

            Return t
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Function

    Function DIRECCION(ByVal A As String) As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT DIRECCION FROM CONFIG_USUARIO WHERE DATOS_PERSONALES = '" & A & "'"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As String = CStr(cmm.ExecuteScalar())
            cmm.Dispose()
            SQLconexion.Close()

            Return t
        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Function

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Try
            Dim sel As String
            sel = "UPDATE CONFIG_USUARIO SET CEDULA='" & Trim(Me.txtCIP.Text) & "', " & _
            "TELEFONO='" & Trim(Me.txtTelefono.Text) & "',DIRECCION='" & Trim(Me.txtDireccion.Text) & "'" & _
            "WHERE DATOS_PERSONALES ='" & Trim(Me.txtDatos_Personales.Text) & "'"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As Integer = CInt(cmm.ExecuteScalar())
            cmm.Dispose()
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
        End Try

        Visualizar_Usuario()

        'LIMPIAR LOS CAMPOS
        Me.txtCIP.Clear()
        Me.txtDatos_Personales.Clear()
        Me.txtTelefono.Clear()
        Me.txtDireccion.Clear()

    End Sub

    Private Sub btnSalir_cargo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir_cargo.Click
        Me.Close()
    End Sub
End Class