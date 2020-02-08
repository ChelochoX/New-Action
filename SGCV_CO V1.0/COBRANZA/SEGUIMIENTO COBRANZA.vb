
Public Class SEGUIMIENTO_COBRANZA

    Dim DaUsuario, DaSeg, DaCliente As New SqlClient.SqlDataAdapter
    Dim DsUsuario, DsSeg, DsCliente As New Data.DataSet
    Dim FechaIni, FechaFin As Date
    Dim Fecha_ProxSeg As Date
    Dim cobrador As String
    Dim b, bandera, COD_cliente, COD_COBRANZA As Integer
    Dim aux_fechaproxseg As Date
    Dim aux_cobrador, aux_obs As String
    Dim aux_montocompromiso As Integer
    Dim datos_cliente As String


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
            sel = "SELECT * FROM TP_CLIENTE"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaCliente = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsCliente = New Data.DataSet
            DaCliente.Fill(Me.DsCliente, "TP_CLIENTE")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub

    Function DatosCliente(ByVal a As String) As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT CI FROM TP_CLIENTE WHERE NOM_APE = '" & a & "'"
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
    Function CODCLIENTE(ByVal a As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COD_CLIENTE FROM TP_CLIENTE WHERE NOM_APE = '" & a & "'"
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

    Function Contador_SegCobranza() As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM CP_SEGUIM_COBRANZA"
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

    Private Sub SEGUIMIENTO_COBRANZA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar_Datos()

        Me.cbCobrador.DataSource = Me.DsUsuario.Tables("CONFIG_USUARIO")
        Me.cbCobrador.DisplayMember = "DATOS_PERSONALES"
    End Sub

    Sub Seguimiento()
        Try
            conectar()
            Dim sel As String
            SQLconexion.Open()
            sel = "SELECT * FROM CP_SEGUIM_COBRANZA WHERE COD_CLIENTE = " & COD_cliente & ""
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaSeg = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsSeg = New Data.DataSet
            DaSeg.Fill(Me.DsSeg, "CP_SEGUIM_COBRANZA")
            'asignar dataset al datagrid
            Me.dg_Seguimiento.DataSource = Me.DsSeg
            Me.dg_Seguimiento.DataMember = "CP_SEGUIM_COBRANZA"

            Me.DaSeg.Update(Me.DsSeg, "CP_SEGUIM_COBRANZA")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub
    Private Sub btnVerSeguimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerSeguimiento.Click

        Me.Label4.Text = datos_cliente & " -  " & DatosCliente(datos_cliente)

        COD_cliente = CODCLIENTE(datos_cliente)

        Seguimiento()

    End Sub

    Private Sub btnGuardarSeguimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardarSeguimiento.Click
        If b = 0 Then
            MessageBox.Show("SELECCIONAR COBRADOR RESPONSABLE", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cbCobrador.Focus()
        Else
            If bandera = 0 Then
                MessageBox.Show("DEFINIR FECHA PROXIMO SEGUIMIENTO", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DateTimePicker1.Focus()
            Else
                If Me.txtMontoCompromiso.Text = "" Then
                    MessageBox.Show("DEFINIR MONTO COMPROMISO DE PAGO", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtMontoCompromiso.Focus()
                Else
                    Try
                        Dim contador As Integer
                        contador = Contador_SegCobranza() + 1
                        SQLconexion.Open()
                        Dim sqlbuilder As New System.Text.StringBuilder
                        With sqlbuilder
                            .Append("INSERT INTO CP_SEGUIM_COBRANZA")
                            .Append(" VALUES ('")
                            .Append(contador & "','")
                            .Append(COD_cliente & "','")
                            .Append(CDate(Fecha_ProxSeg) & "','")
                            .Append(Trim(cobrador) & "','")
                            .Append(CInt(Me.txtMontoCompromiso.Text) & "','")
                            .Append(Trim(Me.txtObservacion.Text) & "')")

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

                    Seguimiento()
                End If
            End If
        End If

        Me.txtMontoCompromiso.Clear()
        Me.txtObservacion.Clear()
        b = 0
        bandera = 0


    End Sub

    Private Sub cbCobrador_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbCobrador.Leave
        b = 1
    End Sub

    Private Sub cbCobrador_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCobrador.SelectedIndexChanged
        cobrador = CStr(Me.DsUsuario.Tables("CONFIG_USUARIO").Rows(Me.cbCobrador.SelectedIndex).Item(2).ToString)

    End Sub

    Private Sub DateTimePicker1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateTimePicker1.Leave
        Dim fecha1 As Date
        fecha1 = Me.DateTimePicker1.Value.Date.AddDays(0)
        Fecha_ProxSeg = fecha1
        bandera = 1
    End Sub

    Private Sub dg_Seguimiento_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg_Seguimiento.Click
        Try
            Me.txtMontoCompromiso.Text = CInt(Me.dg_Seguimiento.Item(Me.dg_Seguimiento.CurrentRowIndex, 2))
            Me.txtObservacion.Text = Trim(Me.dg_Seguimiento.Item(Me.dg_Seguimiento.CurrentRowIndex, 3))
            COD_COBRANZA = CInt(Me.dg_Seguimiento.Item(Me.dg_Seguimiento.CurrentRowIndex, 4))
            Me.txtObservacion.Focus()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnModificarSeguimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarSeguimiento.Click

        If b = 0 Then
            MessageBox.Show("SELECCIONAR COBRADOR RESPONSABLE", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cbCobrador.Focus()
        Else
            If bandera = 0 Then
                MessageBox.Show("DEFINIR FECHA PROXIMO SEGUIMIENTO", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DateTimePicker1.Focus()
            Else
                Try
                    conectar()
                    Dim sel As String
                    sel = "UPDATE CP_SEGUIM_COBRANZA SET FECHA_SEGUIMIENTO = '" & Fecha_ProxSeg & "'," & _
                    "COBRADOR = '" & cobrador & "', MONTO_COMPROMISO = " & CInt(Me.txtMontoCompromiso.Text) & ", " & _
                    "OBSERVACION = '" & Trim(Me.txtObservacion.Text) & "'" & _
                    "WHERE COD_CLIENTE = " & COD_cliente & " AND COD_SEGCOBRANZA = " & COD_COBRANZA & ""
                    cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                    SQLconexion.Open()
                    Dim t As Integer = CInt(cmm.ExecuteScalar())
                    cmm.Dispose()
                    SQLconexion.Close()

                Catch ex As Exception
                    MsgBox(ex.Message())
                    SQLconexion.Close()
                End Try

                Me.txtMontoCompromiso.Clear()
                Me.txtObservacion.Clear()
                Seguimiento()
                b = 0
                bandera = 0
            End If
        End If

    End Sub

    Private Sub txtMontoCompromiso_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMontoCompromiso.Leave
        Dim texto As String
        Dim pasar As Integer = 0
        If Not IsNumeric(txtMontoCompromiso.Text) Then
            Beep()
            MsgBox("Se debe ingresar solo números")
            Me.txtMontoCompromiso.Text = 0
            Me.txtMontoCompromiso.Focus()
        Else
            texto = Me.txtMontoCompromiso.Text
            texto = Replace(texto, ".", "")
            texto = Replace(texto, ",", "")
            texto = Replace(texto, "/", "")
            texto = Replace(texto, "-", "")
        End If
        If Me.txtMontoCompromiso.Text = "" Then
            Me.txtMontoCompromiso.Text = 0
            Dim reeplazo As Integer
            reeplazo = CInt(Me.txtMontoCompromiso.Text)
            Me.txtMontoCompromiso.Text = CStr(Puntos(reeplazo))
        End If

    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        Me.txtMontoCompromiso.Clear()
        Me.txtObservacion.Clear()
        b = 0
        bandera = 0
        Me.txtBuscar_Datos.Clear()
        Me.txtBuscar_Datos.Focus()

        Try
            conectar()
            Dim sel As String
            SQLconexion.Open()
            sel = "SELECT * FROM CP_SEGUIM_COBRANZA WHERE COD_CLIENTE = " & 0 & ""
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaSeg = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsSeg = New Data.DataSet
            DaSeg.Fill(Me.DsSeg, "CP_SEGUIM_COBRANZA")
            'asignar dataset al datagrid
            Me.dg_Seguimiento.DataSource = Me.DsSeg
            Me.dg_Seguimiento.DataMember = "CP_SEGUIM_COBRANZA"

            Me.DaSeg.Update(Me.DsSeg, "CP_SEGUIM_COBRANZA")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub

    Private Sub txtBuscar_Datos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar_Datos.TextChanged

        If Me.rbCedula.Checked = True Then
            Try
                conectar()
                SQLconexion.Open()
                Dim sel As String
                sel = "SELECT * FROM TP_CLIENTE WHERE CI LIKE '%" & Trim(Me.txtBuscar_Datos.Text) & "%'"
                cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                'crear adapter
                DaCliente = New SqlClient.SqlDataAdapter(cmm)
                'crear dataset
                Dim dt As New DataTable("TP_CLIENTE")
                DaCliente.Fill(dt)
                SQLconexion.Close()

                With lstnombre
                    .DataSource = dt
                    .DisplayMember = "CLIENTE"
                    .ValueMember = "NOM_APE"
                End With
            Catch ex As Exception
                MsgBox(ex.Message())
                SQLconexion.Close()
            End Try
        Else
            If Me.rbRuc.Checked = True Then
                Try
                    conectar()
                    SQLconexion.Open()
                    Dim sel As String
                    sel = "SELECT * FROM TP_CLIENTE WHERE RUC LIKE '%" & Trim(Me.txtBuscar_Datos.Text) & "%'"
                    cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                    'crear adapter
                    DaCliente = New SqlClient.SqlDataAdapter(cmm)
                    'crear dataset
                    Dim dt As New DataTable("TP_CLIENTE")
                    DaCliente.Fill(dt)
                    SQLconexion.Close()

                    With lstnombre
                        .DataSource = dt
                        .DisplayMember = "CLIENTE"
                        .ValueMember = "NOM_APE"
                    End With
                Catch ex As Exception
                    MsgBox(ex.Message())
                    SQLconexion.Close()
                End Try

            Else
                If Me.rbNombreApellido.Checked = True Then
                    Try
                        conectar()
                        SQLconexion.Open()
                        Dim sel As String
                        sel = "SELECT * FROM TP_CLIENTE WHERE NOM_APE LIKE '%" & Trim(Me.txtBuscar_Datos.Text) & "%'"
                        cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                        'crear adapter
                        DaCliente = New SqlClient.SqlDataAdapter(cmm)
                        'crear dataset
                        Dim dt As New DataTable("TP_CLIENTE")
                        DaCliente.Fill(dt)
                        SQLconexion.Close()

                        With lstnombre
                            .DataSource = dt
                            .DisplayMember = "CLIENTE"
                            .ValueMember = "NOM_APE"
                        End With
                    Catch ex As Exception
                        MsgBox(ex.Message())
                        SQLconexion.Close()
                    End Try


                End If
            End If
        End If
    End Sub

    Private Sub lstnombre_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstnombre.Click
        datos_cliente = Trim(Me.lstnombre.Text)
    End Sub

    Private Sub rbCedula_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbCedula.CheckedChanged
        Me.txtBuscar_Datos.Focus()
    End Sub

    Private Sub rbRuc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbRuc.CheckedChanged
        Me.txtBuscar_Datos.Focus()
    End Sub

    Private Sub rbNombreApellido_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNombreApellido.CheckedChanged
        Me.txtBuscar_Datos.Focus()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub
End Class