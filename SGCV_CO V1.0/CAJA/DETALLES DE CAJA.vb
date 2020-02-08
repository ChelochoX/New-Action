Public Class DETALLES_DE_CAJA

    Dim Contador_Cabecera_Caja As Integer
    Dim FECHA_ULTIMO_APERTURA As Date
    Dim DaDetalleCaja As New SqlClient.SqlDataAdapter
    Dim DsDetalleCaja As New Data.DataSet

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

    Function Caja_Habilitada(ByVal b As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM CP_CABECERA_CAJA WHERE ESTADO = '" & b & "'"
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

    Function Contador_Cabecera_Caja_() As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM CP_CABECERA_CAJA"
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

    Function Nombre_Sucursal() As String
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

    Function FECHA_APERTURA() As Date
        Try
            conectar()
            Dim sel As String
            sel = "SELECT FECHA_APERTURA FROM CP_CABECERA_CAJA WHERE ESTADO = '" & "HABILITADO" & "'"
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

    Function Codigo_Apertura_(ByVal a As Date) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COD_CAB_CAJA FROM CP_CABECERA_CAJA WHERE FECHA_APERTURA = '" & a & "'"
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

    Function Monto_Ultimo_Apertura_(ByVal a As Date) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT MONTO_APERTURA FROM CP_CABECERA_CAJA WHERE FECHA_APERTURA = '" & a & "'"
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

    Function Sumatoria_Recibos(ByVal a As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COALESCE(SUM(MONTO_RECIBO),0) FROM CP_DETALLE_CAJA WHERE COD_CAB_CAJA = " & a & ""
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

    Function Sumatoria_Facturas(ByVal a As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COALESCE(SUM(MONTO_FACTURA),0) FROM CP_DETALLE_CAJA WHERE COD_CAB_CAJA = " & a & ""
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

    Function HuboAperturaHoy(ByVal a As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM CP_CABECERA_CAJA WHERE FECHA_APERTURA = '" & a & "'"
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
    Private Sub DETALLES_DE_CAJA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Caja_Habilitada("HABILITADO") = 0 Then
            Me.btnEstadoCaja.Text = "ESTADO DE CAJA     *** CAJA INHABILITADA *** "
            Me.btnEstadoCaja.BackColor = Color.Red
            Me.btnEstadoCaja.ForeColor = Color.White
            Me.txtFecha.Text = UCase(Date.Today.ToLongDateString.ToString)
            Me.txtUsuario.Text = usuario_AUX
            Me.txtMontoApertura.Text = 0
            Me.txttotalCobrado.Text = 0
            Me.txtTotalenCaja.Text = 0
            Me.txtSucursalHabilitada.Text = Trim(Nombre_Sucursal())
        Else
            'ENCABEZADO DE CAJA***
            FECHA_ULTIMO_APERTURA = FECHA_APERTURA()
            If FECHA_ULTIMO_APERTURA < Today Then
                Me.btnEstadoCaja.Text = "CAJA HABILITADA EN FECHA   " & "**" & FECHA_ULTIMO_APERTURA & "**" & "   REALIZAR RENDICION PARA NUEVA APERTURA "
                Me.btnEstadoCaja.BackColor = Color.LightBlue
                Me.btnEstadoCaja.ForeColor = Color.Red
                Me.btnEstadoCaja.Font = New Font(Me.btnEstadoCaja.Font.Name, 10)
                Me.txtFecha.Text = UCase(Date.Today.ToLongDateString.ToString)
                Me.txtUsuario.Text = usuario_AUX
                Me.txtSucursalHabilitada.Text = Trim(Nombre_Sucursal())
                Dim Codigo_Apertura As Integer = Codigo_Apertura_(FECHA_ULTIMO_APERTURA)
                Me.txtMontoApertura.Text = CStr(Puntos(Monto_Ultimo_Apertura_(FECHA_ULTIMO_APERTURA)))
                Me.txttotalCobrado.Text = CStr(Puntos(Sumatoria_Recibos(Codigo_Apertura) + Sumatoria_Facturas(Codigo_Apertura)))
                Me.txtTotalenCaja.Text = CStr(Puntos(CInt(Me.txtMontoApertura.Text) + CInt(Me.txttotalCobrado.Text)))
                'DETALLE DE CAJA***
                Try
                    conectar()
                    Dim sel As String
                    SQLconexion.Open()
                    sel = "SELECT * FROM CP_DETALLE_CAJA WHERE COD_CAB_CAJA = " & Codigo_Apertura & ""
                    cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                    'crear adapter
                    DaDetalleCaja = New SqlClient.SqlDataAdapter(cmm)
                    'crear dataset
                    DsDetalleCaja = New Data.DataSet
                    DaDetalleCaja.Fill(Me.DsDetalleCaja, "CP_DETALLE_CAJA")
                    'asignar dataset al datagrid
                    Me.dg_DetalleCaja.DataSource = Me.DsDetalleCaja
                    Me.dg_DetalleCaja.DataMember = "CP_DETALLE_CAJA"

                    Me.DaDetalleCaja.Update(Me.DsDetalleCaja, "CP_DETALLE_CAJA")
                    SQLconexion.Close()

                Catch ex As Exception
                    MsgBox(ex.Message())
                    SQLconexion.Close()
                End Try

            Else
                Me.btnEstadoCaja.Text = "ESTADO DE CAJA --> *** CAJA HABILITADA *** "
                Me.btnEstadoCaja.BackColor = Color.GreenYellow
                Me.btnEstadoCaja.ForeColor = Color.Blue
                Me.txtFecha.Text = UCase(Date.Today.ToLongDateString.ToString)
                Me.txtUsuario.Text = usuario_AUX
                Me.txtSucursalHabilitada.Text = Trim(Nombre_Sucursal())
                Dim Codigo_Apertura As Integer = Codigo_Apertura_(Today)
                Me.txtMontoApertura.Text = CStr(Puntos(Monto_Ultimo_Apertura_(FECHA_ULTIMO_APERTURA)))
                Me.txttotalCobrado.Text = CStr(Puntos(Sumatoria_Recibos(Codigo_Apertura) + Sumatoria_Facturas(Codigo_Apertura)))
                Me.txtTotalenCaja.Text = CStr(Puntos(CInt(Me.txtMontoApertura.Text) + CInt(Me.txttotalCobrado.Text)))
                'DETALLE DE CAJA***
                Try
                    conectar()
                    Dim sel As String
                    SQLconexion.Open()
                    sel = "SELECT * FROM CP_DETALLE_CAJA WHERE COD_CAB_CAJA = " & Codigo_Apertura & ""
                    cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                    'crear adapter
                    DaDetalleCaja = New SqlClient.SqlDataAdapter(cmm)
                    'crear dataset
                    DsDetalleCaja = New Data.DataSet
                    DaDetalleCaja.Fill(Me.DsDetalleCaja, "CP_DETALLE_CAJA")
                    'asignar dataset al datagrid
                    Me.dg_DetalleCaja.DataSource = Me.DsDetalleCaja
                    Me.dg_DetalleCaja.DataMember = "CP_DETALLE_CAJA"

                    Me.DaDetalleCaja.Update(Me.DsDetalleCaja, "CP_DETALLE_CAJA")
                    SQLconexion.Close()

                Catch ex As Exception
                    MsgBox(ex.Message())
                    SQLconexion.Close()
                End Try
            End If
        End If
    End Sub

    Private Sub btnEstadoCaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEstadoCaja.Click


        If Caja_Habilitada("HABILITADO") = 0 Then
            If HuboAperturaHoy(Today) = 0 Then
                Dim monto_apertura_ As String = InputBox("INGRESAR MONTO DE APERTURA")
                If Me.txtMontoApertura.Text = "" Then
                    Me.txtMontoApertura.Text = CInt(0)
                End If
                If monto_apertura_ = "" Then
                    monto_apertura_ = 0
                End If
                'CONTADOR DE CABECERA****
                Contador_Cabecera_Caja = Contador_Cabecera_Caja_() + 1
                'DATOS DE LA SUCURSAL***
                Dim Sucursal As String = Trim(Nombre_Sucursal())
                Try
                    SQLconexion.Open()
                    Dim sqlbuilder As New System.Text.StringBuilder
                    With sqlbuilder
                        .Append("INSERT INTO CP_CABECERA_CAJA")
                        .Append(" VALUES ('")
                        .Append(Contador_Cabecera_Caja & "','")
                        .Append(Sucursal & "','")
                        .Append(Trim(usuario_AUX) & "','")
                        .Append("HABILITADO" & "','")
                        .Append(CDate(Today) & "','")
                        .Append(CInt(monto_apertura_) & "','")
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
            Else
                Dim Codigo_Apertura As Integer = Codigo_Apertura_(Today)
                Try
                    conectar()
                    Dim sel As String
                    sel = "UPDATE CP_CABECERA_CAJA SET ESTADO = '" & "HABILITADO" & "' WHERE COD_CAB_CAJA = " & Codigo_Apertura & ""
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
        Else
            Dim para_FechaRendicion As Date
            FECHA_ULTIMO_APERTURA = FECHA_APERTURA()
            If FECHA_ULTIMO_APERTURA < Today Then
                para_FechaRendicion = FECHA_ULTIMO_APERTURA
            Else
                para_FechaRendicion = Today
            End If
            Dim Codigo_Apertura As Integer = Codigo_Apertura_(para_FechaRendicion)
            Dim MontoApertura As Integer = Monto_Ultimo_Apertura_(para_FechaRendicion)
            Dim TotalCobrado As Integer = Sumatoria_Recibos(Codigo_Apertura) + Sumatoria_Facturas(Codigo_Apertura)
            Dim TotalCaja As Integer = MontoApertura + TotalCobrado
            Try
                conectar()
                Dim sel As String
                sel = "UPDATE CP_CABECERA_CAJA SET ESTADO = '" & "INHABILITADO" & "', FECHA_RENDICION = '" & para_FechaRendicion & "', MONTO_RENDICION = " & TotalCaja & " " & _
                    "WHERE COD_CAB_CAJA = " & Codigo_Apertura & ""
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

        If Caja_Habilitada("HABILITADO") = 0 Then
            Me.btnEstadoCaja.Text = "ESTADO DE CAJA --> *** CAJA INHABILITADA *** "
            Me.btnEstadoCaja.BackColor = Color.Red
            Me.btnEstadoCaja.ForeColor = Color.White
            Me.txtFecha.Text = UCase(Date.Today.ToLongDateString.ToString)
            Me.txtUsuario.Text = usuario_AUX
            Me.txtMontoApertura.Text = 0
            Me.txttotalCobrado.Text = 0
            Me.txtTotalenCaja.Text = 0
            Me.txtSucursalHabilitada.Text = Trim(Nombre_Sucursal())
            'DETALLE DE CAJA***
            Try
                conectar()
                Dim sel As String
                SQLconexion.Open()
                sel = "SELECT * FROM CP_DETALLE_CAJA WHERE COD_CAB_CAJA = " & 0 & ""
                cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                'crear adapter
                DaDetalleCaja = New SqlClient.SqlDataAdapter(cmm)
                'crear dataset
                DsDetalleCaja = New Data.DataSet
                DaDetalleCaja.Fill(Me.DsDetalleCaja, "CP_DETALLE_CAJA")
                'asignar dataset al datagrid
                Me.dg_DetalleCaja.DataSource = Me.DsDetalleCaja
                Me.dg_DetalleCaja.DataMember = "CP_DETALLE_CAJA"

                Me.DaDetalleCaja.Update(Me.DsDetalleCaja, "CP_DETALLE_CAJA")
                SQLconexion.Close()

            Catch ex As Exception
                MsgBox(ex.Message())
                SQLconexion.Close()
            End Try
        Else
            Me.btnEstadoCaja.Text = "ESTADO DE CAJA --> *** CAJA HABILITADA *** "
            Me.btnEstadoCaja.BackColor = Color.GreenYellow
            Me.btnEstadoCaja.ForeColor = Color.Blue
            Dim Codigo_Apertura As Integer = Codigo_Apertura_(Today)
            Me.txtMontoApertura.Text = CStr(Puntos(Monto_Ultimo_Apertura_(Today)))
            Me.txttotalCobrado.Text = CStr(Puntos(Sumatoria_Recibos(Codigo_Apertura) + Sumatoria_Facturas(Codigo_Apertura)))
            Me.txtTotalenCaja.Text = CStr(Puntos(CInt(Me.txtMontoApertura.Text) + CInt(Me.txttotalCobrado.Text)))
            'DETALLE DE CAJA***
            Try
                conectar()
                Dim sel As String
                SQLconexion.Open()
                sel = "SELECT * FROM CP_DETALLE_CAJA WHERE COD_CAB_CAJA = " & Codigo_Apertura & ""
                cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                'crear adapter
                DaDetalleCaja = New SqlClient.SqlDataAdapter(cmm)
                'crear dataset
                DsDetalleCaja = New Data.DataSet
                DaDetalleCaja.Fill(Me.DsDetalleCaja, "CP_DETALLE_CAJA")
                'asignar dataset al datagrid
                Me.dg_DetalleCaja.DataSource = Me.DsDetalleCaja
                Me.dg_DetalleCaja.DataMember = "CP_DETALLE_CAJA"

                Me.DaDetalleCaja.Update(Me.DsDetalleCaja, "CP_DETALLE_CAJA")
                SQLconexion.Close()

            Catch ex As Exception
                MsgBox(ex.Message())
                SQLconexion.Close()
            End Try
        End If
    End Sub
End Class