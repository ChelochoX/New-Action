Public Class APERTURA_CIERRE_DE_CAJA

    Dim contador, B, contador_apertura, contador_mov_caja As Integer
    Dim usuario As String
    Dim DaUsuario As New SqlClient.SqlDataAdapter
    Dim DsUsuario As New Data.DataSet
    Dim contado_estado_caja As Integer
    Dim FECHA_ABIERTO As Date
    Dim USUARIO_ABIERTO As String
    Dim Estado_Caja1 As Integer


    Function Verificar_DatosEmpresa() As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM CONFIG_EMPRESA"
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

    Function sucursal(ByVal a As Integer) As String
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

    Function estado_caja(ByVal b As Date) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COALESCE(ESTADO,0) FROM CP_ESTADO_CAJA WHERE FECHA_ESTADO = '" & b & "'"
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

    Function contador_EstadoCaja() As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM CP_ESTADO_CAJA "
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

    Function EstadoCaja_(ByVal a As String, ByVal b As Date) As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT ESTADO FROM CP_ESTADO_CAJA WHERE USUARIO = '" & a & "' AND FECHA_ESTADO = '" & b & "'"
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

    Function Valor_Apertura_(ByVal a As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT MONTO_APERTURA FROM CP_CAJA WHERE COD_ESTADOCAJA = " & a & ""
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

    Function Valor_enCaja_(ByVal a As Integer, ByVal b As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT MONTO_TOTAL FROM CP_CABECERA_MOVIMIENTO_CAJA WHERE COD_CABECERA_MOVIMIENTO_CAJA = " & a & " AND COD_CAJA = " & b & ""
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

    Function Recuperar_CabMovCaja(ByVal a As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "Select C.COD_CABECERA_MOVIMIENTO_CAJA FROM CP_ESTADO_CAJA E INNER JOIN CP_CAJA J ON " & _
            "E.COD_ESTADOCAJA = J.COD_ESTADOCAJA INNER JOIN CP_CABECERA_MOVIMIENTO_CAJA C " & _
            "ON J.COD_CAJA = C.COD_CAJA WHERE E.ESTADO = " & a & " "
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

    Function Recuperar_CodCaja(ByVal a As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "Select J.COD_CAJA FROM CP_ESTADO_CAJA E INNER JOIN CP_CAJA J ON " & _
            "E.COD_ESTADOCAJA = J.COD_ESTADOCAJA INNER JOIN CP_CABECERA_MOVIMIENTO_CAJA C " & _
            "ON J.COD_CAJA = C.COD_CAJA WHERE E.ESTADO = " & a & ""
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

    Function ESTADO_CAJA_(ByVal a As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM CP_ESTADO_CAJA WHERE ESTADO = " & a & ""
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

    Function FECHAABIERTO(ByVal a As Integer) As Date
        Try
            conectar()
            Dim sel As String
            sel = "SELECT FECHA_APERTURA FROM CP_CAJA WHERE MONTO_RENDICION = " & a & ""
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As Date = CDate(cmm.ExecuteScalar())
            cmm.Dispose()
            SQLconexion.Close()

            Return t
        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Function

    Function USUARIOABIERTO(ByVal a As Integer) As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT USUARIO FROM CP_CAJA WHERE MONTO_RENDICION = " & a & ""
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

    Function Fecha_EstadoCaja(ByVal a As Integer) As Date
        Try
            conectar()
            Dim sel As String
            sel = "SELECT FECHA_ESTADO FROM CP_ESTADO_CAJA WHERE ESTADO = " & a & ""
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As Date = CDate(cmm.ExecuteScalar())
            cmm.Dispose()
            SQLconexion.Close()

            Return t
        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Function

    Function Usuario_EstadoCaja(ByVal a As Integer) As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT USUARIO FROM CP_ESTADO_CAJA WHERE ESTADO = " & a & ""
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

    Private Sub APERTURA_CIERRE_DE_CAJA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Verificar_DatosEmpresa() = 1 Then
            Me.txtSucursalHabilitada.Text = Trim(sucursal(1))
            Me.GroupBox1.Enabled = True

            Dim paraEstado_Caja As Integer
            paraEstado_Caja = ESTADO_CAJA_(1)

            If paraEstado_Caja = 1 Then
                FECHA_ABIERTO = Fecha_EstadoCaja(1)
                USUARIO_ABIERTO = Usuario_EstadoCaja(1)
            Else
                FECHA_ABIERTO = Today
            End If

            '*****************************************************************
            If FECHA_ABIERTO < Today Then
                Estado_Caja1 = EstadoCaja_(USUARIO_ABIERTO, FECHA_ABIERTO)
                Contador_MovCaja_Apertura = Recuperar_CabMovCaja(Estado_Caja1)
                Contador_paraCaja = Recuperar_CodCaja(Estado_Caja1)
                '********************************************************************
                Me.btnEstadoCaja.Text = "CAJA HABILITADA EN FECHA" & " " & FECHA_ABIERTO
                Me.btnEstadoCaja.BackColor = Color.LightBlue
                Me.btnEstadoCaja.ForeColor = Color.Red
                Me.btnEstadoCaja.Font = New Font(Me.btnEstadoCaja.Font.Name, 14)
                Me.Label4.Text = "FECHA RENDICION"
                Me.Label5.Text = "MONTO RENDICION"
                Dim valor_enCaja As Integer
                valor_enCaja = Valor_enCaja_(Contador_MovCaja_Apertura, Contador_paraCaja)
                Me.txtMonto.Text = CStr(Puntos(valor_enCaja))

                Me.txtFecha.Text = FECHA_ABIERTO
                Me.txtUsuario.Text = USUARIO_ABIERTO
            Else
                Estado_Caja1 = EstadoCaja_(usuario_AUX, Inicio_Sesion)
                Contador_MovCaja_Apertura = Recuperar_CabMovCaja(Estado_Caja1)
                Contador_paraCaja = Recuperar_CodCaja(Estado_Caja1)

                If estado_caja(Today) = 1 Then
                    Me.btnEstadoCaja.Text = "CAJA HABILITADA"
                    Me.btnEstadoCaja.BackColor = Color.GreenYellow
                    Me.btnEstadoCaja.ForeColor = Color.Black
                    Me.Label4.Text = "FECHA RENDICION"
                    Me.Label5.Text = "MONTO RENDICION"
                    Dim valor_enCaja As Integer
                    valor_enCaja = Valor_enCaja_(Contador_MovCaja_Apertura, Contador_paraCaja)
                    Me.txtMonto.Text = CStr(Puntos(valor_enCaja))
                Else
                    If estado_caja(Today) = 0 Then
                        Me.btnEstadoCaja.Text = "CAJA CERRADA"
                        Me.btnEstadoCaja.BackColor = Color.Red
                        Me.btnEstadoCaja.ForeColor = Color.White
                        Me.Label4.Text = "FECHA APERTURA"
                        Me.Label5.Text = "MONTO APERTURA"
                    End If
                End If
                'Dim fecha As Date = DateTime.Now
                Me.txtFecha.Text = UCase(Date.Today.ToLongDateString.ToString)
                Me.txtUsuario.Text = usuario_AUX

            End If
        Else
            MessageBox.Show("DEFINIR DATOS DE LA EMPRESA", "SGCV_CO V1.0", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.GroupBox1.Enabled = False
        End If

    End Sub
    Function contador_apertura_() As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM CP_CAJA"
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

    Function contador_mov_caja_() As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM CP_CABECERA_MOVIMIENTO_CAJA"
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

    Function Hubo_Apertura(ByVal a As Date) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM CP_ESTADO_CAJA WHERE FECHA_ESTADO = '" & a & "'"
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

    Sub Actualizar_Estado_Caja(ByVal a As Integer, ByVal b As Date, ByVal c As String)
        Try
            conectar()
            Dim sel As String
            sel = "UPDATE CP_ESTADO_CAJA SET ESTADO = " & a & ", USUARIO = '" & c & "' WHERE FECHA_ESTADO = '" & b & "'"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As Integer = CInt(cmm.ExecuteScalar())
            cmm.Dispose()
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub

    Function Valor_Caja(ByVal a As Date) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COALESCE(SUM(MONTO_APERTURA),0) FROM CP_CAJA WHERE FECHA_APERTURA = '" & a & "'"
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

    Sub Actualizar_Valores_Caja(ByVal a As Integer, ByVal b As Date, ByVal c As String)
        Try
            conectar()
            Dim sel As String
            sel = "UPDATE CP_CAJA SET MONTO_APERTURA = " & a & ",USUARIO = '" & c & "' WHERE FECHA_APERTURA = '" & b & "'"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As Integer = CInt(cmm.ExecuteScalar())
            cmm.Dispose()
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub

    Function Valor_Mov_caja(ByVal a As Date) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COALESCE(SUM(MONTO_TOTAL),0) FROM CP_CABECERA_MOVIMIENTO_CAJA WHERE FECHA = '" & a & "'"
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

    Sub Actualizar_Valores_MovCaja(ByVal a As Integer, ByVal b As Date)
        Try
            conectar()
            Dim sel As String
            sel = "UPDATE CP_CABECERA_MOVIMIENTO_CAJA SET MONTO_TOTAL = " & a & " WHERE FECHA = '" & b & "'"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As Integer = CInt(cmm.ExecuteScalar())
            cmm.Dispose()
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub

    Private Sub btnEstadoCaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEstadoCaja.Click

        If Me.txtMonto.Text = "" Then
            MessageBox.Show("INGRESAR MONTO PARA GUARDAR DATOS", "SGCV_CO V1.0", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtMonto.Focus()
        Else
            If estado_caja(CDate(Me.txtFecha.Text)) = 0 Then
                If Hubo_Apertura(CDate(Me.txtFecha.Text)) > 0 Then
                    'ACTUALIZAR ESTADO DE CAJA
                    Actualizar_Estado_Caja(1, CDate(Me.txtFecha.Text), usuario_AUX)
                    'ACTUALIZAR VALORES DE CAJA
                    Dim paraValorCaja As Integer
                    paraValorCaja = Valor_Caja(CDate(Me.txtFecha.Text))
                    Actualizar_Valores_Caja((paraValorCaja + CInt(Me.txtMonto.Text)), CDate(Me.txtFecha.Text), usuario_AUX)
                    'ACTUALIZAR VALORES MOV CAJA
                    Dim paraValorMovCaja As Integer
                    paraValorMovCaja = Valor_Mov_caja(CDate(Me.txtFecha.Text))
                    Actualizar_Valores_MovCaja((paraValorMovCaja + CInt(Me.txtMonto.Text)), CDate(Me.txtFecha.Text))
                Else

                    contado_estado_caja = contador_EstadoCaja() + 1
                    Try
                        SQLconexion.Open()
                        Dim sqlbuilder As New System.Text.StringBuilder
                        With sqlbuilder
                            .Append("INSERT INTO CP_ESTADO_CAJA")
                            .Append(" VALUES ('")
                            .Append(contado_estado_caja & "','")
                            .Append(Trim(Me.txtUsuario.Text) & "','")
                            .Append(1 & "','")
                            .Append(CDate(Me.txtFecha.Text) & "')")

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
                    '----------------------------------------------------------------
                    contador_apertura = contador_apertura_() + 1
                    Try
                        SQLconexion.Open()
                        Dim sqlbuilder As New System.Text.StringBuilder
                        With sqlbuilder
                            .Append("INSERT INTO CP_CAJA")
                            .Append(" VALUES ('")
                            .Append(contador_apertura & "','")
                            .Append(contado_estado_caja & "','")
                            .Append(Trim(Me.txtSucursalHabilitada.Text) & "','")
                            .Append(Trim(Me.txtUsuario.Text) & "','")
                            .Append(CDate(Me.txtFecha.Text) & "','")
                            .Append(CInt(Me.txtMonto.Text) & "','")
                            .Append("" & "','")
                            .Append(0 & "')")

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
                    '************************************************************
                    contador_mov_caja = contador_mov_caja_() + 1
                    Contador_MovCaja_Apertura = contador_mov_caja
                    Try
                        SQLconexion.Open()
                        Dim sqlbuilder As New System.Text.StringBuilder
                        With sqlbuilder
                            .Append("INSERT INTO CP_CABECERA_MOVIMIENTO_CAJA")
                            .Append(" VALUES ('")
                            .Append(contador_mov_caja & "','")
                            .Append(contador_apertura & "','")
                            .Append(CDate(Me.txtFecha.Text) & "','")
                            .Append(CInt(Me.txtMonto.Text) & "')")

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
                End If
            Else
                If estado_caja(CDate(Me.txtFecha.Text)) = 1 Then
                    Try
                        Dim sel As String
                        sel = "UPDATE CP_CAJA SET MONTO_RENDICION =" & CInt(Me.txtMonto.Text) & "," & _
                        "FECHA_RENDICION ='" & CDate(Me.txtFecha.Text) & "'" & _
                        "WHERE FECHA_APERTURA ='" & CDate(Me.txtFecha.Text) & "'"
                        cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                        SQLconexion.Open()
                        Dim t As Integer = CInt(cmm.ExecuteScalar())
                        cmm.Dispose()
                        SQLconexion.Close()

                    Catch ex As Exception
                        MsgBox(ex.Message())
                        SQLconexion.Close()
                    End Try

                    Try
                        Dim sel As String
                        sel = "UPDATE CP_ESTADO_CAJA SET ESTADO =" & 0 & "" & _
                        "WHERE FECHA_ESTADO ='" & CDate(Me.txtFecha.Text) & "'"
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

        '*******************************************************************
        Me.txtMonto.Clear()
        Estado_Caja1 = EstadoCaja_(usuario_AUX, Inicio_Sesion)
        Contador_MovCaja_Apertura = Recuperar_CabMovCaja(Estado_Caja1)
        Contador_paraCaja = Recuperar_CodCaja(Estado_Caja1)

        If estado_caja(Today) = 1 Then
            Me.btnEstadoCaja.Text = "CAJA HABILITADA"
            Me.btnEstadoCaja.BackColor = Color.GreenYellow
            Me.btnEstadoCaja.ForeColor = Color.Black
            Me.Label4.Text = "FECHA RENDICION"
            Me.Label5.Text = "MONTO RENDICION"
            Dim valor_enCaja As Integer
            valor_enCaja = Valor_enCaja_(Contador_MovCaja_Apertura, Contador_paraCaja)
            Me.txtMonto.Text = CStr(Puntos(valor_enCaja))
        Else
            If estado_caja(Today) = 0 Then
                Me.btnEstadoCaja.Text = "CAJA CERRADA"
                Me.btnEstadoCaja.BackColor = Color.Red
                Me.btnEstadoCaja.ForeColor = Color.White
                Me.Label4.Text = "FECHA APERTURA"
                Me.Label5.Text = "MONTO APERTURA"
            End If
        End If
        'Dim fecha As Date = DateTime.Now
        Me.txtFecha.Text = UCase(Date.Today.ToLongDateString.ToString)
        Me.txtUsuario.Text = usuario_AUX
        'End If

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub txtMonto_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtMonto.Leave
        Dim texto As String
        Dim pasar As Integer = 0
        If Not IsNumeric(txtMonto.Text) Then
            Beep()
            MsgBox("Se debe ingresar solo números")
            Me.txtMonto.Focus()
            Me.txtMonto.Text = 0
        Else
            texto = Me.txtMonto.Text
            texto = Replace(texto, ".", "")
            texto = Replace(texto, ",", "")
            texto = Replace(texto, "/", "")
            texto = Replace(texto, "-", "")
            pasar = 1
        End If
        If pasar = 1 Then
            Dim reemplazo As Integer
            reemplazo = CInt(Me.txtMonto.Text)
            Me.txtMonto.Text = CStr(Puntos(reemplazo))
        End If
    End Sub
End Class