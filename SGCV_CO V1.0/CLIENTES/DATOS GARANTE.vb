Public Class DATOS_GARANTE

    Dim contador, codigo As Integer
    Dim DaGarante As New SqlClient.SqlDataAdapter
    Dim DsGarante As New Data.DataSet

    Function Contador_Garante() As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM TP_CLIENTE_GARANTE"
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

    '** VISUALIZAR DATOS DE CLIENTE***
    Public Sub Visualizar_Garante()
        Try
            conectar()
            Dim sel As String
            SQLconexion.Open()
            sel = "SELECT * FROM TP_CLIENTE_GARANTE"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaGarante = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsGarante = New Data.DataSet
            DaGarante.Fill(Me.DsGarante, "TP_CLIENTE_GARANTE")
            'asignar dataset al datagrid
            Me.dg_GARANTE.DataSource = Me.DsGarante
            Me.dg_GARANTE.DataMember = "TP_CLIENTE_GARANTE"

            DaGarante.Update(Me.DsGarante, "TP_CLIENTE_GARANTE")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Sub

    Private Sub DATOS_GARANTE_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Contador_Garante() = 0 Then
            contador = 1
        Else
            contador = Contador_Garante() + 1
        End If

        Visualizar_Garante()

    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        If Me.txtCIP.Text = "" Then
            MessageBox.Show("INGRESAR NUMERO DE CEDULA", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
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
                        .Append("INSERT INTO TP_CLIENTE_GARANTE")
                        .Append(" VALUES ('")
                        .Append(contador & "','")
                        .Append(CODIGO_TITULAR & "','")
                        .Append(CInt(Me.txtCIP.Text) & "','")
                        .Append(Trim(Me.txtNombre.Text) & "','")
                        .Append(Trim(Me.txtTelefono.Text) & "','")
                        .Append(Trim(Me.txtDireccion.Text) & "')")

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
                Me.txtNombre.Clear()
                Me.txtTelefono.Clear()
                Me.txtDireccion.Clear()
              
                'ACTUALIZAR CANTIDAD ID.REGISTROS*******************
                contador = Contador_Garante() + 1

            End If
        End If
        Visualizar_Garante()

    End Sub

    '** VISUALIZAR DATOS DE CLIENTE MODIFICADO***
    Public Sub Visualizar_Cliente_Modificado(ByVal a As Integer)
        Try
            conectar()
            Dim sel As String
            SQLconexion.Open()
            sel = "SELECT * FROM TP_CLIENTE_GARANTE WHERE COD_CLIENTE_GARANTE = " & a & ""
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaGarante = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsGarante = New Data.DataSet
            DaGarante.Fill(Me.DsGarante, "TP_CLIENTE_GARANTE")
            'asignar dataset al datagrid
            Me.dg_GARANTE.DataSource = Me.DsGarante
            Me.dg_GARANTE.DataMember = "TP_CLIENTE_GARANTE"

            DaGarante.Update(Me.DsGarante, "TP_CLIENTE_GARANTE")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
        End Try
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Try
            Dim sel As String
            sel = "UPDATE TP_CLIENTE_GARANTE SET CI='" & Trim(Me.txtCIP.Text) & "', " & _
            "NOM_APE ='" & Trim(Me.txtNombre.Text) & "', " & _
            "TELEFONO='" & Trim(Me.txtTelefono.Text) & "',DIRECCION='" & Trim(Me.txtDireccion.Text) & "' " & _
            "WHERE COD_CLIENTE_GARANTE= " & codigo & ""
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As Integer = CInt(cmm.ExecuteScalar())
            cmm.Dispose()
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Open()
        End Try

        Visualizar_Cliente_Modificado(codigo)

        'LIMPIAR LOS CAMPOS
        Me.txtCIP.Clear()
        Me.txtNombre.Clear()
        Me.txtTelefono.Clear()
        Me.txtDireccion.Clear()
        Me.txtCIP.Focus()

    End Sub

    Private Sub dg_GARANTE_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg_GARANTE.Click

        Me.txtCIP.Text = Me.dg_GARANTE.Item(Me.dg_GARANTE.CurrentRowIndex, 0)
        Me.txtNombre.Text = Me.dg_GARANTE.Item(Me.dg_GARANTE.CurrentRowIndex, 1)
        Me.txtTelefono.Text = Me.dg_GARANTE.Item(Me.dg_GARANTE.CurrentRowIndex, 2)
        Me.txtDireccion.Text = Me.dg_GARANTE.Item(Me.dg_GARANTE.CurrentRowIndex, 3)
        codigo = Me.dg_GARANTE.Item(Me.dg_GARANTE.CurrentRowIndex, 4)
        
    End Sub

    Private Sub txtLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLimpiar.Click
        'LIMPIAR LOS CAMPOS
        Me.txtCIP.Clear()
        Me.txtNombre.Clear()
        Me.txtTelefono.Clear()
        Me.txtDireccion.Clear()
        Me.txtCIP.Focus()
    End Sub

    Private Sub btnSalir_cargo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir_cargo.Click
        Me.Close()
    End Sub
End Class