Public Class REGISTRO_CLIENTE

    Dim contador, codigo As Integer
    Dim DaCliente As New SqlClient.SqlDataAdapter
    Dim DsCliente As New Data.DataSet


    '*** CONTADOR DE REGISTROS CLIENTE****
    Function Contador_Cliente() As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COALESCE(MAX(COD_CLIENTE),0) FROM TP_CLIENTE"
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

    '** VISUALIZAR DATOS DE CLIENTE***
    Public Sub Visualizar_Cliente()
        Try
            conectar()
            Dim sel As String
            SQLconexion.Open()
            sel = "SELECT * FROM TP_CLIENTE ORDER BY FECHA DESC"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaCliente = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsCliente = New Data.DataSet
            DaCliente.Fill(Me.DsCliente, "TP_CLIENTE")
            'asignar dataset al datagrid
            Me.dg_cliente.DataSource = Me.DsCliente
            Me.dg_cliente.DataMember = "TP_CLIENTE"

            DaCliente.Update(Me.DsCliente, "TP_CLIENTE")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub

    '** VISUALIZAR DATOS DE CLIENTE MODIFICADO***
    Public Sub Visualizar_Cliente_Modificado(ByVal a As Integer)
        Try
            conectar()
            Dim sel As String
            SQLconexion.Open()
            sel = "SELECT * FROM TP_CLIENTE WHERE COD_CLIENTE = " & a & ""
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaCliente = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsCliente = New Data.DataSet
            DaCliente.Fill(Me.DsCliente, "TP_CLIENTE")
            'asignar dataset al datagrid
            Me.dg_cliente.DataSource = Me.DsCliente
            Me.dg_cliente.DataMember = "TP_CLIENTE"

            DaCliente.Update(Me.DsCliente, "TP_CLIENTE")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub

    '** VERIFICAR EXISTENCIA DE DATOS DE CLIENTE*****
    Public Function YaExisteCLiente(ByVal a As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM TP_CLIENTE WHERE CI = '" & a & "'"
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

    Private Sub REGISTRO_CLIENTE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Contador_Cliente() = 0 Then
            contador = 1
        Else
            contador = Contador_Cliente() + 1
        End If

        Visualizar_Cliente()
    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        If Me.txtCIP.Text = "" Then
            MessageBox.Show("Debe ingresar algun numero de C.P.; ""En el Campo C.I.P."" ", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtCIP.Focus()
        Else
            If Me.txtNombre.Text = "" Then
                MessageBox.Show("Debe igresar algun nombre;""En el Campo Nombre"" ", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtNombre.Focus()
            Else
                Try
                    SQLconexion.Open()
                    Dim sqlbuilder As New System.Text.StringBuilder
                    With sqlbuilder
                        .Append("INSERT INTO TP_CLIENTE")
                        .Append(" VALUES ('")
                        .Append(contador & "','")
                        .Append(Trim(Me.txtRUC.Text) & "','")
                        .Append(CInt(Me.txtCIP.Text) & "','")
                        .Append(Trim(Me.txtNombre.Text) & "','")
                        .Append(Trim(Me.txtTelefono.Text) & "','")
                        .Append(Trim(Me.txtDireccion.Text) & "','")
                        .Append(CDate(Today) & "','")
                        .Append(Trim(Me.txtRef_Personal1.Text) & "','")
                        .Append(Trim(Me.txtRef_Personal2.Text) & "','")
                        .Append(Trim(Me.txtLatitud.Text) & "','")
                        .Append(Trim(Me.txtLongitud.Text) & "')")

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
                Me.txtRUC.Clear()
                Me.txtCIP.Clear()
                Me.txtNombre.Clear()
                Me.txtTelefono.Clear()
                Me.txtDireccion.Clear()
                Me.txtRef_Personal1.Clear()
                Me.txtRef_Personal2.Clear()
                Me.txtLongitud.Clear()
                Me.txtLatitud.Clear()
                Me.txtRUC.Focus()
                'ACTUALIZAR CANTIDAD ID.REGISTROS*******************
                contador = Contador_Cliente() + 1

                End If
            End If
        Visualizar_Cliente()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Try
            Dim sel As String
            sel = "UPDATE TP_CLIENTE SET RUC='" & Trim(Me.txtRUC.Text) & "',CI='" & Trim(Me.txtCIP.Text) & "', " & _
            "NOM_APE ='" & Trim(Me.txtNombre.Text) & "', " & _
            "TELEFONO='" & Trim(Me.txtTelefono.Text) & "',DIRECCION='" & Trim(Me.txtDireccion.Text) & "'," & _
             "REF_PERSONAL1='" & Trim(Me.txtRef_Personal1.Text) & "',REF_PERSONAL2='" & Trim(Me.txtRef_Personal2.Text) & "'," & _
             "LATITUD='" & Trim(Me.txtLatitud.Text) & "',LONGITUD='" & Trim(Me.txtLongitud.Text) & "'" & _
            "WHERE COD_CLIENTE= " & codigo & ""
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As Integer = CInt(cmm.ExecuteScalar())
            cmm.Dispose()
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

        Visualizar_Cliente_Modificado(codigo)

        'LIMPIAR LOS CAMPOS
        Me.txtRUC.Clear()
        Me.txtCIP.Clear()
        Me.txtNombre.Clear()
        Me.txtTelefono.Clear()
        Me.txtDireccion.Clear()
        Me.txtRef_Personal1.Clear()
        Me.txtRef_Personal2.Clear()
        Me.txtLongitud.Clear()
        Me.txtLatitud.Clear()
        Me.txtRUC.Focus()
    End Sub

    Private Sub txtLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLimpiar.Click
        'LIMPIAR LOS CAMPOS
        Me.txtRUC.Clear()
        Me.txtCIP.Clear()
        Me.txtNombre.Clear()
        Me.txtTelefono.Clear()
        Me.txtDireccion.Clear()
        Me.txtRef_Personal1.Clear()
        Me.txtRef_Personal2.Clear()
        Me.txtLongitud.Clear()
        Me.txtLatitud.Clear()
        Me.txtRUC.Focus()
    End Sub

    Private Sub btnSalir_cargo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir_cargo.Click
        Me.Close()

    End Sub

    Private Sub txtCIP_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCIP.Leave
        If YaExisteCLiente(Trim(Me.txtCIP.Text)) = 1 Then
            MessageBox.Show("Ya hay cliente con este numero de Cedula", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Me.txtCIP.Focus()
        Else
            Dim texto As String
            If Not IsNumeric(txtCIP.Text) Then
                MsgBox("Se debe ingresar solo números")
            Else
                texto = Me.txtCIP.Text
                texto = Replace(texto, ".", "")
                texto = Replace(texto, ",", "")
                texto = Replace(texto, "/", "")
                texto = Replace(texto, "-", "")
            End If
            Me.txtCIP.Text = texto
        End If
    End Sub

    Private Sub txtRUC_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRUC.Leave
        Dim texto As String
        texto = Me.txtRUC.Text
        texto = Replace(texto, ".", "")
        texto = Replace(texto, ",", "")
        texto = Replace(texto, "/", "")

        Me.txtRUC.Text = texto
    End Sub

    Private Sub dg_cliente_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg_cliente.Click
        Me.txtRUC.Text = Me.dg_cliente.Item(Me.dg_cliente.CurrentRowIndex, 0)
        Me.txtCIP.Text = Me.dg_cliente.Item(Me.dg_cliente.CurrentRowIndex, 1)
        Me.txtNombre.Text = Me.dg_cliente.Item(Me.dg_cliente.CurrentRowIndex, 2)
        Me.txtTelefono.Text = Me.dg_cliente.Item(Me.dg_cliente.CurrentRowIndex, 3)
        Me.txtDireccion.Text = Me.dg_cliente.Item(Me.dg_cliente.CurrentRowIndex, 4)
        codigo = Me.dg_cliente.Item(Me.dg_cliente.CurrentRowIndex, 5)
        Me.txtRef_Personal1.Text = Me.dg_cliente.Item(Me.dg_cliente.CurrentRowIndex, 6)
        Me.txtRef_Personal2.Text = Me.dg_cliente.Item(Me.dg_cliente.CurrentRowIndex, 7)
        Me.txtLatitud.Text = Me.dg_cliente.Item(Me.dg_cliente.CurrentRowIndex, 8)
        Me.txtLongitud.Text = Me.dg_cliente.Item(Me.dg_cliente.CurrentRowIndex, 9)
        CODIGO_TITULAR = codigo
    End Sub

    Private Sub txbuscar_nombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txbuscar_nombre.TextChanged
        Try
            conectar()
            Dim sel As String
            SQLconexion.Open()
            sel = "SELECT * FROM TP_CLIENTE WHERE NOM_APE LIKE '%" & Trim(Me.txbuscar_nombre.Text) & "%'"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaCliente = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsCliente = New Data.DataSet
            DaCliente.Fill(Me.DsCliente, "TP_CLIENTE")
            'asignar dataset al datagrid
            Me.dg_cliente.DataSource = Me.DsCliente
            Me.dg_cliente.DataMember = "TP_CLIENTE"

            DaCliente.Update(Me.DsCliente, "TP_CLIENTE")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub

    Private Sub txtBuscar_telefono_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar_telefono.TextChanged
        Try
            conectar()
            Dim sel As String
            SQLconexion.Open()
            sel = "SELECT * FROM TP_CLIENTE WHERE TELEFONO LIKE '%" & Trim(Me.txtBuscar_telefono.Text) & "%'"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaCliente = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsCliente = New Data.DataSet
            DaCliente.Fill(Me.DsCliente, "TP_CLIENTE")
            'asignar dataset al datagrid
            Me.dg_cliente.DataSource = Me.DsCliente
            Me.dg_cliente.DataMember = "TP_CLIENTE"

            DaCliente.Update(Me.DsCliente, "TP_CLIENTE")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub

    Private Sub txtBuscar_Direccion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar_Direccion.TextChanged
        Try
            conectar()
            Dim sel As String
            SQLconexion.Open()
            sel = "SELECT * FROM TP_CLIENTE WHERE DIRECCION LIKE '%" & Trim(Me.txtBuscar_Direccion.Text) & "%'"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaCliente = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsCliente = New Data.DataSet
            DaCliente.Fill(Me.DsCliente, "TP_CLIENTE")
            'asignar dataset al datagrid
            Me.dg_cliente.DataSource = Me.DsCliente
            Me.dg_cliente.DataMember = "TP_CLIENTE"

            DaCliente.Update(Me.DsCliente, "TP_CLIENTE")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub

    Private Sub btnDatosGarante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDatosGarante.Click
        Dim frm_DatosGarante As New DATOS_GARANTE
        frm_DatosGarante.Show()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Try
            Dim sel As String
            sel = "DELETE FROM TP_CLIENTE WHERE COD_CLIENTE= " & codigo & ""
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As Integer = CInt(cmm.ExecuteScalar())
            cmm.Dispose()
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
        End Try

        Visualizar_Cliente()

        'LIMPIAR LOS CAMPOS
        Me.txtRUC.Clear()
        Me.txtCIP.Clear()
        Me.txtNombre.Clear()
        Me.txtTelefono.Clear()
        Me.txtDireccion.Clear()
        Me.txtRef_Personal1.Clear()
        Me.txtRef_Personal2.Clear()
        Me.txtLongitud.Clear()
        Me.txtLatitud.Clear()
        Me.txtRUC.Focus()
    End Sub
End Class