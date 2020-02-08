Public Class VER_DOCUMENTOS_ANULADOS

    Dim FECHA_INICIAL, FECHA_FINAL As Date
    Dim DaAnulacion As New SqlClient.SqlDataAdapter
    Dim DsAnulacion As New Data.DataSet
    Dim valor As String
    Dim bandera As Integer

    Private Sub VER_DOCUMENTOS_ANULADOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        bandera = 0
    End Sub

    Private Sub btnBuscar_Facturacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar_Facturacion.Click

        If bandera = 0 Then
            MessageBox.Show("SELECCIONAR RANGO DE FECHAS PARA VER DOCUMENTOS", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                conectar()
                SQLconexion.Open()
                Dim sel As String
                sel = "SELECT * FROM ANULAR_DOCUMENTOS WHERE FECHA_ANULACION BETWEEN '" & FECHA_INICIAL & "' AND '" & FECHA_FINAL & "'"
                cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                'crear adapter
                DaAnulacion = New SqlClient.SqlDataAdapter(cmm)
                'crear dataset
                Dim dt1 As New DataTable("ANULAR_DOCUMENTOS")
                DaAnulacion.Fill(dt1)
                SQLconexion.Close()
                With ltsDetallesBusqueda
                    .DataSource = dt1
                    .DisplayMember = "DOCUMENTO"
                    .ValueMember = "NUMERO_DOCUMENTO"
                    .Refresh()
                End With
            Catch ex As Exception
                MsgBox(ex.Message())
                SQLconexion.Close()
            End Try
        End If
    End Sub

    Private Sub DateTimePicker1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateTimePicker1.Leave
        Dim fecha1 As Date
        fecha1 = Me.DateTimePicker1.Value.Date.AddDays(0)
        FECHA_INICIAL = fecha1
        bandera = 1
    End Sub

    Private Sub DateTimePicker2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateTimePicker2.Leave
        Dim fecha1 As Date
        fecha1 = Me.DateTimePicker2.Value.Date.AddDays(1)
        FECHA_FINAL = fecha1
    End Sub

    Private Sub ltsDetallesBusqueda_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ltsDetallesBusqueda.Click

        valor = Trim(Me.ltsDetallesBusqueda.Text)

        Me.txtFechaAnulacion.Text = FECHA_ANULACION_RECIBO(valor)
        Me.txtMotivoAnulacion.Text = MOTIVO_ANULACION_RECIBO(valor)
      
    End Sub

    Function FECHA_ANULACION(ByVal A As String) As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT FECHA_ANULACION FROM ANULAR_DOCUMENTOS WHERE NUMERO_DOCUMENTO = '" & A & "'"
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
    Function FECHA_ANULACION_RECIBO(ByVal A As String) As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT FECHA_ANULACION FROM ANULAR_DOCUMENTOS WHERE NUMERO_DOCUMENTO = '" & A & "'"
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

    Function MOTIVO_ANULACION(ByVal A As String) As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT MOTIVO FROM ANULAR_DOCUMENTOS WHERE NUMERO_DOCUMENTO = '" & A & "'"
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
    Function MOTIVO_ANULACION_RECIBO(ByVal A As String) As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT MOTIVO FROM ANULAR_DOCUMENTOS WHERE NUMERO_DOCUMENTO = '" & A & "'"
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

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

End Class