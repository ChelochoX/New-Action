

Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System
Imports System.IO
Imports System.Diagnostics

Public Class REPORTE_DE_RECIBO_DE_DINERO

    Dim busqueda As Integer
    Dim FECHA_INICIAL, FECHA_FINAL As Date
    Dim DaRecibo, DaDetalleRecibo, Dafactura As New SqlClient.SqlDataAdapter
    Dim DsRecibo, DsDetalleRecibo, DsFactura As New Data.DataSet
    Dim valor As String
    Dim SUMARECIBO_TOTAL_DETMOVCAJA, SUMAFACTURA_TOTAL_DETMOVCAJA, paraCODCAJA, MONTO_APERTURA As Integer


    Sub SetDBLogonForReport(ByVal myConnectionInfo As ConnectionInfo, ByVal myReportDocument As ReportDocument)
        Dim myTables As Tables = myReportDocument.Database.Tables
        For Each myTable As CrystalDecisions.CrystalReports.Engine.Table In myTables
            Dim myTableLogonInfo As TableLogOnInfo = myTable.LogOnInfo
            myTableLogonInfo.ConnectionInfo = myConnectionInfo
            myTable.ApplyLogOnInfo(myTableLogonInfo)
        Next
    End Sub

    Private Sub REPORTE_DE_RECIBO_DE_DINERO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        iconexion.DatabaseName = bbdd
        iconexion.UserID = usuario_
        iconexion.Password = contrasena_
        iconexion.ServerName = servidor

        iconexion.Type = ConnectionInfoType.SQL
        '********************************************************
    End Sub

    Private Sub btnBuscar_Recibo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar_Recibo.Click
        Try
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter("REPORTE_RECIBOSDEPAGO_POR_FECHA", SQLconexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@FECHA_INICIAL", FECHA_INICIAL)
            da.SelectCommand.Parameters.AddWithValue("@FECHA_FINAL", FECHA_FINAL)
            da.Fill(dt)

            Dim ds As New Data.DataSet
            ds.Tables.Add(dt)

            Dim info As New REPORTE_RECIBOS_DE_PAGO_POR_FECHA
            info.SetDataSource(ds)
            info.SetParameterValue("@FECHA_INICIAL", FECHA_INICIAL)
            info.SetParameterValue("@FECHA_FINAL", FECHA_FINAL)
            SetDBLogonForReport(iconexion, info)
            Me.CrystalReportViewer1.ReportSource = info

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            SQLconexion.Close()
        End Try
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

    Private Sub btnSalir_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnLimpiarBusqueda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiarBusqueda.Click
        Me.CrystalReportViewer1.ReportSource = Nothing
    End Sub
End Class