Public Class REGISTRO_PROVEEDOR

    Dim contador, codigo As Integer
    Dim DaProveedor As New SqlClient.SqlDataAdapter
    Dim DsProveedor As New Data.DataSet

    '*** CONTADOR DE REGISTROS PROVEEDOR****
    Function Contador_Proveedor() As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM TP_PROVEEDOR"
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

    '** VISUALIZAR DATOS DE PROVEEDOR***
    Public Sub Visualizar_Proveedor()
        Try
            conectar()
            Dim sel As String
            SQLconexion.Open()
            sel = "SELECT * FROM TP_PROVEEDOR"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaProveedor = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsProveedor = New Data.DataSet
            DaProveedor.Fill(Me.DsProveedor, "TP_PROVEEDOR")
            'asignar dataset al datagrid
            Me.dg_Proveedor.DataSource = Me.DsProveedor
            Me.dg_Proveedor.DataMember = "TP_PROVEEDOR"

            DaProveedor.Update(Me.DsProveedor, "TP_PROVEEDOR")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Sub
    Private Sub REGISTRO_PROVEEDOR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Contador_Proveedor() = 0 Then
            contador = 1
        Else
            contador = Contador_Proveedor() + 1
        End If

        Visualizar_Proveedor()
    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        If Me.txtRUC.Text = "" Then
            MessageBox.Show("Debe ingresar algun Ruc.", "SGCV V2.0", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtRUC.Focus()
        Else
            If Me.txtNombre.Text = "" Then
                MessageBox.Show("Debe igresar algun nombre;""En el Campo Nombre"" ", "SGCV V2.0", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtNombre.Focus()
            Else
                Try
                    SQLconexion.Open()
                    Dim sqlbuilder As New System.Text.StringBuilder
                    With sqlbuilder
                        .Append("INSERT INTO TP_PROVEEDOR")
                        .Append(" VALUES ('")
                        .Append(contador & "','")
                        .Append(CStr(Me.txtRUC.Text) & "','")
                        .Append(CStr(Me.txtNombre.Text) & "','")
                        .Append(CStr(Me.txtDireccion.Text) & "','")
                        .Append(CStr(Me.txtTelefono.Text) & "')")

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
                Me.txtNombre.Clear()
                Me.txtTelefono.Clear()
                Me.txtDireccion.Clear()
                Me.txtRUC.Focus()

                contador = Contador_Proveedor() + 1

            End If
        End If

        Visualizar_Proveedor()

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Try
            Dim sel As String
            sel = "UPDATE TP_PROVEEDOR SET RUC='" & Trim(Me.txtRUC.Text) & "', " & _
            "NOMBRE='" & Trim(Me.txtNombre.Text) & "'," & _
            "TELEFONO='" & Trim(Me.txtTelefono.Text) & "',DIRECCION='" & Trim(Me.txtDireccion.Text) & "'" & _
            "WHERE COD_PROVEEDOR= " & codigo & ""
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As Integer = CInt(cmm.ExecuteScalar())
            cmm.Dispose()
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

        Visualizar_Proveedor()

        'LIMPIAR LOS CAMPOS
        Me.txtRUC.Clear()
        Me.txtNombre.Clear()
        Me.txtTelefono.Clear()
        Me.txtDireccion.Clear()
        Me.txtRUC.Focus()
    End Sub

    Private Sub dg_Proveedor_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg_Proveedor.Click
        Me.txtRUC.Text = Trim(Me.dg_Proveedor.Item(Me.dg_Proveedor.CurrentRowIndex, 0))
        Me.txtNombre.Text = Trim(Me.dg_Proveedor.Item(Me.dg_Proveedor.CurrentRowIndex, 1))
        Me.txtTelefono.Text = Trim(Me.dg_Proveedor.Item(Me.dg_Proveedor.CurrentRowIndex, 3))
        Me.txtDireccion.Text = Trim(Me.dg_Proveedor.Item(Me.dg_Proveedor.CurrentRowIndex, 2))
        codigo = CInt(Me.dg_Proveedor.Item(Me.dg_Proveedor.CurrentRowIndex, 4))
    End Sub

    Private Sub BTNLIMPIAR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNLIMPIAR.Click
        'LIMPIAR LOS CAMPOS
        Me.txtRUC.Clear()
        Me.txtNombre.Clear()
        Me.txtTelefono.Clear()
        Me.txtDireccion.Clear()
        Me.txtRUC.Focus()
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class