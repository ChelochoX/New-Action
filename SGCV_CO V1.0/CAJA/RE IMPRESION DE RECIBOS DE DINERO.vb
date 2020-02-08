
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System
Imports System.IO
Imports System.Diagnostics

Public Class RE_IMPRESION_DE_RECIBOS_DE_DINERO

    Dim FECHA_INICIAL, FECHA_FINAL As Date
    Dim DaDetalleRecibo, DaRecibo As New SqlClient.SqlDataAdapter
    Dim DSDetalleRecibo, DsRecibo As New Data.DataSet
    Dim valor As String
    Dim deposito_, codigo_recibo, paraCodigo As Integer


    Sub SetDBLogonForReport(ByVal myConnectionInfo As ConnectionInfo, ByVal myReportDocument As ReportDocument)
        Dim myTables As Tables = myReportDocument.Database.Tables
        For Each myTable As CrystalDecisions.CrystalReports.Engine.Table In myTables
            Dim myTableLogonInfo As TableLogOnInfo = myTable.LogOnInfo
            myTableLogonInfo.ConnectionInfo = myConnectionInfo
            myTable.ApplyLogOnInfo(myTableLogonInfo)
        Next
    End Sub

    Private Sub RE_IMPRESION_DE_RECIBOS_DE_DINERO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        iconexion.DatabaseName = bbdd
        iconexion.UserID = usuario_
        iconexion.Password = contrasena_
        iconexion.ServerName = servidor
        iconexion.Type = ConnectionInfoType.SQL
    End Sub

    Private Sub DateTimePicker1_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateTimePicker1.Leave
        Dim fecha1 As Date
        fecha1 = Me.DateTimePicker1.Value.Date.AddDays(0)
        FECHA_INICIAL = fecha1
    End Sub

    Private Sub DateTimePicker2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateTimePicker2.Leave
        Dim fecha1 As Date
        fecha1 = Me.DateTimePicker2.Value.Date.AddDays(1)
        FECHA_FINAL = fecha1
    End Sub

    Private Sub btnBuscar_Facturacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar_Facturacion.Click
        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM CP_CABECERA_RECIBO WHERE FECHA BETWEEN '" & FECHA_INICIAL & "' AND '" & FECHA_FINAL & "'"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaRecibo = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            Dim dt1 As New DataTable("CP_CABECERA_RECIBO")
            DaRecibo.Fill(dt1)
            SQLconexion.Close()
            With ltsDetallesBusqueda
                .DataSource = dt1
                .DisplayMember = "DOCUMENTO"
                .ValueMember = "NUM_RECIBO"
                .Refresh()
            End With
        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub

    Function Codigo_CabRecibo(ByVal a As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COD_CABECERA_RECIBO FROM CP_CABECERA_RECIBO WHERE NUM_RECIBO = '" & a & "'"
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

    Function Codigo_Cliente(ByVal a As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COD_CLIENTE FROM CP_CABECERA_RECIBO WHERE NUM_RECIBO = '" & a & "'"
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

    Private Sub ltsDetallesBusqueda_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ltsDetallesBusqueda.Click

        valor = Trim(Me.ltsDetallesBusqueda.Text)
        paraCodigo = Codigo_CabRecibo(valor)
        codigo_recibo = paraCodigo

        Try
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter("PAGO_RECIBO", SQLconexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@NUMERO_RECIBO", valor)
            da.Fill(dt)

            Dim ds As New Data.DataSet
            ds.Tables.Add(dt)

            Dim info As New RECIBO_DE_DINERO_

            info.SetDataSource(ds)
            info.SetParameterValue("@NUMERO_RECIBO", valor)
            SetDBLogonForReport(iconexion, info)
            Me.CrystalReportViewer1.ReportSource = info

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            SQLconexion.Close()
        End Try

    End Sub

    Private Sub btnReImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReImprimir.Click

        Dim instance As New Printing.PrinterSettings
        Dim impresosaPredt As String = instance.PrinterName

        If valor = "" Then

        Else
            Try
                conectar()
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter("PAGO_RECIBO", SQLconexion)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@NUMERO_RECIBO", valor)
                da.Fill(dt)

                Dim ds As New Data.DataSet
                ds.Tables.Add(dt)

                Dim info As New RECIBO_DE_DINERO_
                info.SetDataSource(ds)
                info.SetParameterValue("@NUMERO_RECIBO", valor)
                SetDBLogonForReport(iconexion, info)
                Me.CrystalReportViewer1.ReportSource = info

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                SQLconexion.Close()
            End Try

            Try
                conectar()
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter("PAGO_RECIBO", SQLconexion)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@NUMERO_RECIBO", valor)
                da.Fill(dt)

                Dim ds As New Data.DataSet
                ds.Tables.Add(dt)

                Dim info As New RECIBO_DE_DINERO_IMPRESION
                info.SetDataSource(ds)
                info.SetParameterValue("@NUMERO_RECIBO", valor)
                SetDBLogonForReport(iconexion, info)
                info.PrintOptions.PrinterName = impresosaPredt
                info.PrintToPrinter(1, False, 0, 0)

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                SQLconexion.Close()
            End Try

            Try
                conectar()
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter("PAGO_RECIBO", SQLconexion)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@NUMERO_RECIBO", valor)
                da.Fill(dt)

                Dim ds As New Data.DataSet
                ds.Tables.Add(dt)

                Dim info As New RECIBO_DE_DINERO_IMPRESION_DUPLICADO
                info.SetDataSource(ds)
                info.SetParameterValue("@NUMERO_RECIBO", valor)
                SetDBLogonForReport(iconexion, info)
                info.PrintOptions.PrinterName = impresosaPredt
                info.PrintToPrinter(1, False, 0, 0)

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                SQLconexion.Close()
            End Try
        End If
    End Sub

    Private Sub btnLimpiarBusqueda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiarBusqueda.Click
        Me.CrystalReportViewer1.ReportSource = Nothing
        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM CP_CABECERA_RECIBO WHERE COD_CABECERA_RECIBO =  " & 0 & ""
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaRecibo = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            Dim dt1 As New DataTable("CP_CABECERA_RECIBO")
            DaRecibo.Fill(dt1)
            SQLconexion.Close()
            With ltsDetallesBusqueda
                .DataSource = dt1
                .DisplayMember = "DOCUMENTO"
                .ValueMember = "NUM_RECIBO"
                .Refresh()
            End With
        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub
End Class