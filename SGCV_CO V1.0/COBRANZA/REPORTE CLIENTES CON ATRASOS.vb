Public Class REPORTE_CLIENTES_CON_ATRASOS

    Dim DaDetCuenta_Cliente, DaCliente_, DaSegCobranza As New SqlClient.SqlDataAdapter
    Dim DsDetCuenta_Cliente, DsCliente_, DsSegCobranza As New Data.DataSet
    Dim codido_cliente_ As Integer


    Sub Cargar_Dataset()
        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM VF_DETALLE_CUENTACLIENTE"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaDetCuenta_Cliente = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DaDetCuenta_Cliente.Fill(Me.DsDetCuenta_Cliente, "VF_DETALLE_CUENTACLIENTE")
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
            DaCliente_ = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DaCliente_.Fill(Me.DsCliente_, "TP_CLIENTE")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM CP_SEGUIM_COBRANZA"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaSegCobranza = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DaSegCobranza.Fill(Me.DsSegCobranza, "CP_SEGUIM_COBRANZA")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub

    Sub actualizar_cuentacli()
        'ACTUALIZA LAS FECHAS DE VENCIMIENTO DE LAS CUOTAS********************************
        Dim AUX_FECHAVENC As Date
        Dim PAGADO As String
        Dim NUM_CUOTA, COD_CUENTA, dias_cuota, cliente As Integer

        Dim i As Integer
        For i = 0 To Me.BindingContext(Me.DsDetCuenta_Cliente, "VF_DETALLE_CUENTACLIENTE").Count - 1
            Me.BindingContext(Me.DsDetCuenta_Cliente, "VF_DETALLE_CUENTACLIENTE").Position = i

            cliente = CInt(Me.DsDetCuenta_Cliente.Tables("VF_DETALLE_CUENTACLIENTE").Rows(Me.BindingContext(Me.DsDetCuenta_Cliente, "VF_DETALLE_CUENTACLIENTE").Position).Item("COD_CLIENTE"))
            AUX_FECHAVENC = CDate(Me.DsDetCuenta_Cliente.Tables("VF_DETALLE_CUENTACLIENTE").Rows(Me.BindingContext(Me.DsDetCuenta_Cliente, "VF_DETALLE_CUENTACLIENTE").Position).Item("FECHA_VENCIMIENTO"))
            PAGADO = Trim(Me.DsDetCuenta_Cliente.Tables("VF_DETALLE_CUENTACLIENTE").Rows(Me.BindingContext(Me.DsDetCuenta_Cliente, "VF_DETALLE_CUENTACLIENTE").Position).Item("ESTADO_CUOTA"))
            NUM_CUOTA = Me.DsDetCuenta_Cliente.Tables("VF_DETALLE_CUENTACLIENTE").Rows(Me.BindingContext(Me.DsDetCuenta_Cliente, "VF_DETALLE_CUENTACLIENTE").Position).Item("CUOTA")
            COD_CUENTA = Me.DsDetCuenta_Cliente.Tables("VF_DETALLE_CUENTACLIENTE").Rows(Me.BindingContext(Me.DsDetCuenta_Cliente, "VF_DETALLE_CUENTACLIENTE").Position).Item("COD_CABECERA_CUENTACLI")
            dias_cuota = DateDiff(DateInterval.Day, Today, AUX_FECHAVENC)

            'SI LA CUOTA NO FUE ABONADA SE MODIFICA LOS DIAS DE VENCIMIENTO***
            If "PENDIENTE" = Trim(Me.DsDetCuenta_Cliente.Tables("VF_DETALLE_CUENTACLIENTE").Rows(Me.BindingContext(Me.DsDetCuenta_Cliente, "VF_DETALLE_CUENTACLIENTE").Position).Item("ESTADO_CUOTA")) Then
                actualizar_diasVencimiento(dias_cuota, cliente, NUM_CUOTA, COD_CUENTA)
            End If
        Next
    End Sub

    Private Sub REPORTE_CLIENTES_CON_ATRASOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar_Dataset()

       
    End Sub

    'ACTUALIZA LOS DIAS DE FECHA DE VENCIMIENTO DE LAS CUOTAS******
    Function actualizar_diasVencimiento(ByVal a As Integer, ByVal b As Integer, ByVal c As Integer, ByVal d As Integer) As Integer
        Try
            Dim sel As String

            sel = "UPDATE VF_DETALLE_CUENTACLIENTE SET DIAS_A_VENCER = " & a & " WHERE COD_CLIENTE = " & b & " AND CUOTA =" & c & " AND COD_CABECERA_CUENTACLI= " & d & ""
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)

            SQLconexion.Open()
            Dim t As Integer = CInt(cmm.ExecuteScalar())
            SQLconexion.Close()
            Return t

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Function

    Function Cuenta_Actual_Cliente(ByVal a As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COALESCE(SUM(MONTO_CUOTA),0) FROM VF_DETALLE_CUENTACLIENTE " & _
            "WHERE COD_CLIENTE = " & a & " AND ESTADO_CUOTA = '" & "PENDIENTE" & "'"
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


    Private Sub BTNGENERAR_REPORTE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNGENERAR_REPORTE.Click

        actualizar_cuentacli()

        Try
            conectar()
            Dim sel As String
            SQLconexion.Open()
            sel = "SELECT * FROM VF_DETALLE_CUENTACLIENTE WHERE DIAS_A_VENCER < 0 AND ESTADO_CUOTA = '" & "PENDIENTE" & "' ORDER BY FECHA_VENCIMIENTO ASC"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaDetCuenta_Cliente = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsDetCuenta_Cliente = New Data.DataSet
            DaDetCuenta_Cliente.Fill(Me.DsDetCuenta_Cliente, "VF_DETALLE_CUENTACLIENTE")
            'asignar dataset al datagrid
            Me.dg_Cuenta_Cliente.DataSource = Me.DsDetCuenta_Cliente
            Me.dg_Cuenta_Cliente.DataMember = "VF_DETALLE_CUENTACLIENTE"

            Me.DaDetCuenta_Cliente.Update(Me.DsDetCuenta_Cliente, "VF_DETALLE_CUENTACLIENTE")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try


    
    End Sub

    Private Sub dg_Cuenta_Cliente_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg_Cuenta_Cliente.Click
        If Me.dg_Cuenta_Cliente.CurrentRowIndex < 0 Then

        Else
            codido_cliente_ = CInt(Me.dg_Cuenta_Cliente.Item(Me.dg_Cuenta_Cliente.CurrentRowIndex, 0))

            Dim j As Integer
            For j = 0 To Me.BindingContext(Me.DsCliente_, "TP_CLIENTE").Count - 1
                Me.BindingContext(Me.DsCliente_, "TP_CLIENTE").Position = j
                If (codido_cliente_) = Me.DsCliente_.Tables("TP_CLIENTE").Rows(Me.BindingContext(Me.DsCliente_, "TP_CLIENTE").Position).Item("COD_CLIENTE") Then

                    Me.txtCIP.Text = Trim(Me.DsCliente_.Tables("TP_CLIENTE").Rows(Me.BindingContext(Me.DsCliente_, "TP_CLIENTE").Position).Item("CI"))
                    Me.txtNombre.Text = Trim(Me.DsCliente_.Tables("TP_CLIENTE").Rows(Me.BindingContext(Me.DsCliente_, "TP_CLIENTE").Position).Item("NOM_APE"))
                    Me.txtTelefono.Text = Trim(Me.DsCliente_.Tables("TP_CLIENTE").Rows(Me.BindingContext(Me.DsCliente_, "TP_CLIENTE").Position).Item("TELEFONO"))
                End If
            Next
            ''************************************************************************
            'CUENTA ACTUAL
            Me.txtCuentaActual.Text = Puntos(Cuenta_Actual_Cliente(codido_cliente_)) & " " & "GS"

            Try
                conectar()
                Dim sel As String
                SQLconexion.Open()
                sel = "SELECT * FROM CP_SEGUIM_COBRANZA WHERE COD_CLIENTE = " & codido_cliente_ & ""
                cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                'crear adapter
                DaSegCobranza = New SqlClient.SqlDataAdapter(cmm)
                'crear dataset
                DsSegCobranza = New Data.DataSet
                DaSegCobranza.Fill(Me.DsSegCobranza, "CP_SEGUIM_COBRANZA")
                'asignar dataset al datagrid
                Me.dg_seg_cobranza.DataSource = Me.DsSegCobranza
                Me.dg_seg_cobranza.DataMember = "CP_SEGUIM_COBRANZA"

                Me.DaSegCobranza.Update(Me.DsSegCobranza, "CP_SEGUIM_COBRANZA")
                SQLconexion.Close()

            Catch ex As Exception
                MsgBox(ex.Message())
                SQLconexion.Close()
            End Try

            Me.txtFecha_Seg.Clear()
            Me.txtObservacion.Clear()
            Me.txtMontoCompromiso.Clear()
            Me.txtCobrador.Clear()
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub dg_seg_cobranza_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg_seg_cobranza.Click
        If Me.dg_seg_cobranza.CurrentRowIndex < 0 Then

        Else
            Me.txtFecha_Seg.Text = Me.dg_seg_cobranza.Item(Me.dg_seg_cobranza.CurrentRowIndex, 0)

            Me.txtCobrador.Text = Me.dg_seg_cobranza.Item(Me.dg_seg_cobranza.CurrentRowIndex, 2)
            Me.txtMontoCompromiso.Text = Puntos(Me.dg_seg_cobranza.Item(Me.dg_seg_cobranza.CurrentRowIndex, 3))
            Me.txtObservacion.Text = Me.dg_seg_cobranza.Item(Me.dg_seg_cobranza.CurrentRowIndex, 4)
        End If
    End Sub
End Class