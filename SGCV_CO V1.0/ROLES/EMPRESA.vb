Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System
Imports System.IO
Imports System.Diagnostics

Public Class EMPRESA

    Dim B As Integer


    Private Sub EMPRESA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        B = 0

        Me.txtEmpresa_.Text = recu_empresa()
        Me.txtActividad_.Text = recu_actividad()
        Me.txtPropietario_.Text = recu_propietario()
        Me.txtDireccion_.Text = recu_direccion()
        Me.txtTelefono_.Text = recu_telefono()
        Me.txtsucursal_.Text = "SUCURSAL" & " " & recu_sucursal()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Try
            Dim sel As String
            sel = "UPDATE CONFIG_EMPRESA SET NOMBRE ='" & Trim(Me.txtNombreEmpresa.Text) & "', " & _
            "PROPIETARIO ='" & Trim(Me.txtPropietario.Text) & "',TELEFONO ='" & Trim(Me.txtTelefono.Text) & "'," & _
            "DIRECCION ='" & Trim(Me.txtDireccion.Text) & "',SUCURSAL='" & Trim(Me.txtSucursal.Text) & "'," & _
            "ACTIVIDAD ='" & Trim(Me.txtActividad.Text) & "'" & _
            "WHERE COD_EMPRESA ='" & 1 & "'"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As Integer = CInt(cmm.ExecuteScalar())
            cmm.Dispose()
            SQLconexion.Close()

            Me.txtEmpresa_.Text = recu_empresa()
            Me.txtActividad_.Text = recu_actividad()
            Me.txtPropietario_.Text = recu_propietario()
            Me.txtDireccion_.Text = recu_direccion()
            Me.txtTelefono_.Text = recu_telefono()
            Me.txtsucursal_.Text = "SUCURSAL" & " " & recu_sucursal()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

    End Sub

    Function Existe_empresa() As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COD_EMPRESA FROM CONFIG_EMPRESA WHERE COD_EMPRESA = " & 1 & ""
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
    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click

        If Existe_empresa = 1 Then
            MessageBox.Show("DATOS EMPRESA YA ESTAN CARGADOS, NO SE PUEDE CARGAR OTRO NOMBRE", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If Me.txtNombreEmpresa.Text = "" Then
                MessageBox.Show("INGRESAR NOMBRE DE LA EMPRESA", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtNombreEmpresa.Focus()
            Else
                If Me.txtPropietario.Text = "" Then
                    MessageBox.Show("INGRESAR NOMBRE DEL PROPIETARIO", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtPropietario.Focus()
                Else
                    If Me.txtSucursal.Text = "" Then
                        MessageBox.Show("INGRESAR NOMBRE DE LA SUCURSAL", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.txtSucursal.Focus()
                    Else
                        Dim contador As Integer = 1
                        Try
                            conectar()
                            SQLconexion.Open()
                            Dim sqlbuilder As New System.Text.StringBuilder
                            With sqlbuilder
                                .Append("INSERT INTO CONFIG_EMPRESA")
                                .Append(" VALUES ('")
                                .Append(contador & "','")
                                .Append(CStr(Me.txtNombreEmpresa.Text) & "','")
                                .Append(CStr(Me.txtPropietario.Text) & "','")
                                .Append(CStr(Me.txtTelefono.Text) & "','")
                                .Append(CStr(Me.txtDireccion.Text) & "','")
                                .Append(CStr(Me.txtSucursal.Text) & "','")
                                .Append(CStr(Me.txtActividad.Text) & "')")

                            End With

                            cmm = New SqlClient.SqlCommand(sqlbuilder.ToString, SQLconexion)
                            cmm.ExecuteNonQuery()
                            SQLconexion.Close()
                            cmm.Dispose()
                            SQLconexion.Dispose()

                            B = 1
                        Catch ex As SqlClient.SqlException
                            MsgBox(ex.Message())
                            SQLconexion.Close()
                        End Try
                    End If
                End If
            End If
        End If
        '***********************************************************************
        Me.txtEmpresa_.Text = recu_empresa()
        Me.txtActividad_.Text = recu_actividad()
        Me.txtPropietario_.Text = recu_propietario()
        Me.txtDireccion_.Text = recu_direccion()
        Me.txtTelefono_.Text = recu_telefono()
        Me.txtsucursal_.Text = "SUCURSAL" & " " & recu_sucursal()

    End Sub

    Private Sub btnSalir_cargo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir_cargo.Click
        Me.Close()
    End Sub

    Private Sub btnRecuperar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecuperar.Click
        If recu_empresa() Is Nothing Then
            Me.txtNombreEmpresa.Text = "CAMPO VACIO"
        Else
            Me.txtNombreEmpresa.Text = recu_empresa()
        End If
        If recu_propietario() Is Nothing Then
            Me.txtNombreEmpresa.Text = "CAMPO VACIO"
        Else
            Me.txtPropietario.Text = recu_propietario()
        End If
        If recu_telefono() Is Nothing Then
            Me.txtTelefono.Text = "CAMPO VACIO"
        Else
            Me.txtTelefono.Text = recu_telefono()
        End If
        If recu_direccion() Is Nothing Then
            Me.txtDireccion.Text = "CAMPO VACIO"
        Else
            Me.txtDireccion.Text = recu_direccion()
        End If
        If recu_sucursal() Is Nothing Then
            Me.txtSucursal.Text = "CAMPO VACIO"
        Else
            Me.txtSucursal.Text = recu_sucursal()
        End If
        If recu_actividad() Is Nothing Then
            Me.txtActividad.Text = "CAMPO VACIO"
        Else
            Me.txtActividad.Text = recu_actividad()
        End If

    End Sub

    Function recu_empresa() As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT NOMBRE FROM CONFIG_EMPRESA WHERE COD_EMPRESA = " & 1 & ""
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
    Function recu_propietario() As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT PROPIETARIO FROM CONFIG_EMPRESA WHERE COD_EMPRESA = " & 1 & ""
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
    Function recu_telefono() As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT TELEFONO FROM CONFIG_EMPRESA WHERE COD_EMPRESA = " & 1 & ""
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
    Function recu_direccion() As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT DIRECCION FROM CONFIG_EMPRESA WHERE COD_EMPRESA = " & 1 & ""
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
    Function recu_sucursal() As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT SUCURSAL FROM CONFIG_EMPRESA WHERE COD_EMPRESA = " & 1 & ""
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
    Function recu_actividad() As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT ACTIVIDAD FROM CONFIG_EMPRESA WHERE COD_EMPRESA = " & 1 & ""
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