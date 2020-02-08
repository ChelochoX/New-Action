Public Class ROLES_DE_USUARIO

    Dim DaUsuario, DaDeposito, DaFunciones As New SqlClient.SqlDataAdapter
    Dim DsUsuario, DsDeposito, DsFunciones As New Data.DataSet
    Dim usuario, sucursal, categoria As String
    Dim empresa As String

    Sub Cargar_Datos()
        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM CONFIG_USUARIO"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaUsuario = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsUsuario = New Data.DataSet
            DaUsuario.Fill(Me.DsUsuario, "CONFIG_USUARIO")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM TP_DEPOSITO"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaDeposito = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsDeposito = New Data.DataSet
            DaDeposito.Fill(Me.DsDeposito, "TP_DEPOSITO")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub

    Sub FUNCIONES_GENERALES()
        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM CONFIG_FUNCIONES_DEL_SISTEMA "
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaFunciones = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            Dim dt As New DataTable("CONFIG_FUNCIONES_DEL_SISTEMA")
            DaFunciones.Fill(dt)
            SQLconexion.Close()

            With ListBox1
                .DataSource = dt
                .DisplayMember = "FUNCIONES"
                .ValueMember = "FUNCIONES"
            End With

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub

    Sub FUNCIONES_HABILITADAS_USUARIO(ByVal a As Integer)
        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM CONFIG_DETALLE_PERMISOS WHERE COD_CAB_PERMISOS = " & a & " AND ESTADO = '" & "HABILITADO" & " '"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaFunciones = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            Dim dt As New DataTable("CONFIG_DETALLE_PERMISOS")
            DaFunciones.Fill(dt)
            SQLconexion.Close()

            With ListBox2
                .DataSource = dt
                .DisplayMember = "FUNCIONES"
                .ValueMember = "FUNCIONES"
            End With

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub
    Function paraFUNCIONES_HABILITADAS_USUARIO(ByVal a As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COD_CAB_PERMISOS FROM CONFIG_CABECERA_PERMISOS WHERE CATEGORIA = '" & a & "'"
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

    Function paraCategoria(ByVal a As String) As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT CATEGORIA_USUARIO FROM CONFIG_USUARIO WHERE DATOS_PERSONALES = '" & a & "'"
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
    Private Sub ROLES_DE_USUARIO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar_Datos()
        Me.cbUsuario.DataSource = Me.DsUsuario.Tables("CONFIG_USUARIO")
        Me.cbUsuario.DisplayMember = "DATOS_PERSONALES"

        'EMPRESA ACTUAL
        empresa = EmpresaActual(1)
        Me.Label12.Text = Trim(empresa)
        FUNCIONES_GENERALES()
        Dim categoria_de_usuario As String
        categoria_de_usuario = Trim(paraCategoria(usuario_AUX))
        Dim COD_FUNCIONES As Integer
        COD_FUNCIONES = paraFUNCIONES_HABILITADAS_USUARIO(categoria_de_usuario)
        FUNCIONES_HABILITADAS_USUARIO(COD_FUNCIONES)
    End Sub

    Function EmpresaActual(ByVal a As Integer) As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT SUCURSAL FROM CONFIG_EMPRESA WHERE COD_EMPRESA = " & a & ""
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

    Function Estado_Usuario(ByVal a As String, ByVal b As String) As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT ESTADO FROM CONFIG_USUARIO WHERE DATOS_PERSONALES = '" & a & "' AND SUCURSAL = '" & b & "' "
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

    Private Sub btnCambiarEstado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCambiarEstado.Click

        If (MessageBox.Show("PRESIONA (SI) PARA HABILITAR O PRECIONA (NO) PARA DESABILTIAR", "SCV_CO V2.0", MessageBoxButtons.YesNo, MessageBoxIcon.Information)) = DialogResult.Yes Then
            If Me.txtContrasena1.Text = "" Then
                MessageBox.Show("INGRESAR CONTRASEÑA PARA USUARIO", "SGCV_CO V2.0", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtContrasena1.Focus()
            Else
                If Me.txtContrasena2.Text = "" Then
                    MessageBox.Show("VOLVER A INGRESAR CONTRASEÑA", "SGCV_CO V2.0", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtContrasena2.Focus()
                Else
                    If Trim(Me.txtContrasena1.Text) <> Trim(Me.txtContrasena2.Text) Then
                        MessageBox.Show("CONTRASEÑAS NO COINCIDEN,VOLVER A INGRESAR", "SGCV_CO V2.0", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.txtContrasena1.Focus()
                    Else
                        If categoria = "" Then
                            MessageBox.Show("DEFINIR CATEGORIA AL USUARIO", "SGCV_CO V2.0", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.GroupBox1.Focus()
                        Else
                            Dim usuario_ As String = "USUARIO HABILITADO"
                            Try
                                Dim sel As String
                                sel = "UPDATE CONFIG_USUARIO SET CONTRASENA ='" & Trim(Me.txtContrasena1.Text) & "', " & _
                                "ESTADO ='" & usuario_ & "', SUCURSAL = '" & empresa & "'," & _
                                "CATEGORIA_USUARIO ='" & categoria & "'" & _
                                "WHERE DATOS_PERSONALES ='" & Trim(usuario) & "'"
                                cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                                SQLconexion.Open()
                                Dim t As Integer = CInt(cmm.ExecuteScalar())
                                cmm.Dispose()
                                SQLconexion.Close()

                            Catch ex As Exception
                                MsgBox(ex.Message())
                                SQLconexion.Close()
                            End Try
                        End If
                    End If
                End If
            End If
        Else
            Dim usuario_ As String = "USUARIO BLOQUEADO"
            Try
                Dim sel As String
                sel = "UPDATE CONFIG_USUARIO SET ESTADO ='" & usuario_ & "'" & _
                "WHERE DATOS_PERSONALES ='" & Trim(usuario) & "'"
                cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                SQLconexion.Open()
                Dim t As Integer = CInt(cmm.ExecuteScalar())
                cmm.Dispose()
                SQLconexion.Close()

            Catch ex As Exception
                MsgBox(ex.Message())
                SQLconexion.Close()
            End Try
        End If

        If Estado_Usuario(usuario, empresa) = "USUARIO BLOQUEADO" Then
            Me.btnEstadoUsuario.Text = "USUARIO BLOQUEADO"
            Me.btnEstadoUsuario.BackColor = Color.Red
            Me.btnEstadoUsuario.ForeColor = Color.White
        Else
            If Estado_Usuario(usuario, empresa) = "USUARIO HABILITADO" Then
                Me.btnEstadoUsuario.Text = "USUARIO HABILITADO"
                Me.btnEstadoUsuario.BackColor = Color.GreenYellow
                Me.btnEstadoUsuario.ForeColor = Color.White
            End If
        End If

            Me.txtContrasena1.Clear()
            Me.txtContrasena2.Clear()

    End Sub

    Private Sub btnCambiarContraseña_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCambiarContraseña.Click
        If Me.txtContrasena1.Text = "" Then
            MessageBox.Show("INGRESAR CONTRASEÑA PARA USUARIO", "SGCV_CO V1.0", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtContrasena1.Focus()
        Else
            If Me.txtContrasena2.Text = "" Then
                MessageBox.Show("VOLVER A INGRESAR CONTRASEÑA", "SGCV_CO V1.0", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtContrasena2.Focus()
            Else
                If Trim(Me.txtContrasena1.Text) <> Trim(Me.txtContrasena2.Text) Then
                    MessageBox.Show("CONTRASEÑAS NO COINCIDEN,VOLVER A INGRESAR", "SGCV_CO V1.0", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtContrasena1.Focus()
                Else
                    Try
                        Dim sel As String
                        sel = "UPDATE CONFIG_USUARIO SET CONTRASENA ='" & Trim(Me.txtContrasena1.Text) & "'" & _
                        "WHERE DATOS_PERSONALES ='" & Trim(usuario) & "'"
                        cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                        SQLconexion.Open()
                        Dim t As Integer = CInt(cmm.ExecuteScalar())
                        cmm.Dispose()
                        SQLconexion.Close()

                        MessageBox.Show("CONTRASEÑA MODIFICADA", "SGCV_CO V1.0", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.txtContrasena1.Clear()
                        Me.txtContrasena2.Clear()
                        Me.txtContrasena1.Focus()

                    Catch ex As Exception
                        MsgBox(ex.Message())
                        SQLconexion.Close()
                    End Try
                End If
            End If
        End If

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub rbAdmin_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbAdmin.Click
        categoria = "ADMIN"
    End Sub

    Private Sub rbOperador_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbOperador.Click
        categoria = "OPERADOR"
    End Sub

    Private Sub rbVisitante_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbVisitante.Click
        categoria = "VISITANTE"
    End Sub

    Private Sub cbUsuario_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbUsuario.SelectedIndexChanged
        usuario = CStr(Me.DsUsuario.Tables("CONFIG_USUARIO").Rows(Me.cbUsuario.SelectedIndex).Item(2).ToString)

        If Estado_Usuario(usuario, empresa) = "USUARIO BLOQUEADO" Then
            Me.btnEstadoUsuario.Text = "USUARIO BLOQUEADO"
            Me.btnEstadoUsuario.BackColor = Color.Red
            Me.btnEstadoUsuario.ForeColor = Color.White
        Else
            If Estado_Usuario(usuario, empresa) = "USUARIO HABILITADO" Then
                Me.btnEstadoUsuario.Text = "USUARIO HABILITADO"
                Me.btnEstadoUsuario.BackColor = Color.GreenYellow
                Me.btnEstadoUsuario.ForeColor = Color.White
            End If
        End If

        Dim categoria_de_usuario As String
        categoria_de_usuario = Trim(paraCategoria(usuario))
        Dim COD_FUNCIONES As Integer
        COD_FUNCIONES = paraFUNCIONES_HABILITADAS_USUARIO(categoria_de_usuario)
        FUNCIONES_HABILITADAS_USUARIO(COD_FUNCIONES)

    End Sub
    Function Habilitado_enSucursal(ByVal a As String, ByVal b As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM CONFIG_USUARIO WHERE DATOS_PERSONALES = '" & a & "' AND SUCURSAL = '" & b & "'"
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

    Private Sub btnCategoria_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCategoria.Click

        If Me.rbAdmin.Checked = True Then
            Try
                Dim sel As String
                sel = "UPDATE CONFIG_USUARIO SET CATEGORIA_USUARIO ='" & categoria & "'" & _
                "WHERE DATOS_PERSONALES ='" & Trim(usuario) & "'"
                cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                SQLconexion.Open()
                Dim t As Integer = CInt(cmm.ExecuteScalar())
                cmm.Dispose()
                SQLconexion.Close()

                MessageBox.Show("CATEGORIA MODIFICADA", "SGCV_CO V1.0", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MsgBox(ex.Message())
                SQLconexion.Close()
            End Try
        Else
            If Me.rbOperador.Checked = True Then
                Try
                    Dim sel As String
                    sel = "UPDATE CONFIG_USUARIO SET CATEGORIA_USUARIO ='" & categoria & "'" & _
                    "WHERE DATOS_PERSONALES ='" & Trim(usuario) & "'"
                    cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                    SQLconexion.Open()
                    Dim t As Integer = CInt(cmm.ExecuteScalar())
                    cmm.Dispose()
                    SQLconexion.Close()

                    MessageBox.Show("CATEGORIA MODIFICADA", "SGCV_CO V1.0", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MsgBox(ex.Message())
                    SQLconexion.Close()
                End Try
            Else
                If Me.rbVisitante.Checked = True Then
                    Try
                        Dim sel As String
                        sel = "UPDATE CONFIG_USUARIO SET CATEGORIA_USUARIO ='" & categoria & "'" & _
                        "WHERE DATOS_PERSONALES ='" & Trim(usuario) & "'"
                        cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                        SQLconexion.Open()
                        Dim t As Integer = CInt(cmm.ExecuteScalar())
                        cmm.Dispose()
                        SQLconexion.Close()

                        MessageBox.Show("CATEGORIA MODIFICADA", "SGCV_CO V1.0", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                        MsgBox(ex.Message())
                        SQLconexion.Close()
                    End Try
                End If
            End If
        End If
       
    End Sub

    Private Sub btnEstadoUsuario_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEstadoUsuario.Click

    End Sub
End Class