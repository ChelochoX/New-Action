Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System
Imports System.IO
Imports System.Diagnostics

Public Class REPORTE_RENDICION_CAJA

    Dim FECHA_INICIAL, FECHA_FINAL As Date
    Dim DaRendicion As New SqlClient.SqlDataAdapter
    Dim DsRendicion As New Data.DataSet
    Dim valor As String

    Sub SetDBLogonForReport(ByVal myConnectionInfo As ConnectionInfo, ByVal myReportDocument As ReportDocument)
        Dim myTables As Tables = myReportDocument.Database.Tables
        For Each myTable As CrystalDecisions.CrystalReports.Engine.Table In myTables
            Dim myTableLogonInfo As TableLogOnInfo = myTable.LogOnInfo
            myTableLogonInfo.ConnectionInfo = myConnectionInfo
            myTable.ApplyLogOnInfo(myTableLogonInfo)
        Next
    End Sub

    Private Sub REPORTE_RENDICION_CAJA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.btnExcel.Enabled = False
        Me.btnPDF.Enabled = False

        iconexion.DatabaseName = bbdd
        iconexion.UserID = usuario_
        iconexion.Password = contrasena_
        iconexion.ServerName = servidor

        iconexion.Type = ConnectionInfoType.SQL

    End Sub

    Private Sub btnBuscar_Rendicion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar_Rendicion.Click
        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM CP_CABECERA_CAJA WHERE FECHA_APERTURA >='" & FECHA_INICIAL & "' AND FECHA_APERTURA <= '" & FECHA_FINAL & "'"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaRendicion = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            Dim dt1 As New DataTable("CP_CABECERA_CAJA")
            DaRendicion.Fill(dt1)
            SQLconexion.Close()
            With ltsDetallesBusqueda
                .DataSource = dt1
                .DisplayMember = "FECHA RENDICION"
                .ValueMember = "FECHA_APERTURA"
                .Refresh()
            End With
        Catch ex As Exception
            MsgBox(ex.Message())
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
        fecha1 = Me.DateTimePicker2.Value.Date.AddDays(0)
        FECHA_FINAL = fecha1
    End Sub

    Private Sub btnPDF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPDF.Click
        valor = Trim(Me.ltsDetallesBusqueda.Text)
        Try
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter("RENCIDION_CAJA_MASDETALLADO", SQLconexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@FECHA", valor)
            da.Fill(dt)

            Dim ds As New Data.DataSet
            ds.Tables.Add(dt)
            Dim RENDICION As String
            RENDICION = "RENDICION"

            Dim info As New RENDICION_DE_CAJA
            info.SetDataSource(ds)
            info.SetParameterValue("@FECHA", valor)
            info.SetDatabaseLogon("clezcano", "Cesar1983")
            Me.CrystalReportViewer1.ReportSource = info
            info.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, "H:\Sistemas PYMES\SGCV_CO V1.0\Reporte Movimiento Caja\" & RENDICION & ".pdf")

            Dim psi As New ProcessStartInfo
            psi.UseShellExecute = True
            psi.FileName = "H:\Sistemas PYMES\SGCV_CO V1.0\Reporte Movimiento Caja\" & RENDICION & ".pdf"
            Process.Start(psi)


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            SQLconexion.Close()
        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        valor = Trim(Me.ltsDetallesBusqueda.Text)
        Try
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter("RENCIDION_CAJA_MASDETALLADO", SQLconexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@FECHA", valor)
            da.Fill(dt)

            Dim ds As New Data.DataSet
            ds.Tables.Add(dt)
            Dim RENDICION As String
            RENDICION = "RENDICION"

            Dim info As New RENDICION_DE_CAJA
            info.SetDataSource(ds)
            info.SetParameterValue("@FECHA", valor)
            info.SetDatabaseLogon("clezcano", "Cesar1983")
            Me.CrystalReportViewer1.ReportSource = info
            info.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.Excel, "H:\Sistemas PYMES\SGCV_CO V1.0\Reporte Movimiento Caja\" & RENDICION & ".xls")

            Dim psi As New ProcessStartInfo
            psi.UseShellExecute = True
            psi.FileName = "H:\Sistemas PYMES\SGCV_CO V1.0\Reporte Movimiento Caja\" & RENDICION & ".xls"
            Process.Start(psi)


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            SQLconexion.Close()
        End Try
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        valor = Trim(Me.ltsDetallesBusqueda.Text)

        Dim instance As New Printing.PrinterSettings
        Dim impresosaPredt As String = instance.PrinterName

        Try
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter("RENCIDION_CAJA_MASDETALLADO", SQLconexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@FECHA", valor)
            da.Fill(dt)

            Dim ds As New Data.DataSet
            ds.Tables.Add(dt)
            Dim RENDICION As String
            RENDICION = "RENDICION"

            Dim info As New RENDICION_DE_CAJA
            info.SetDataSource(ds)
            info.SetParameterValue("@FECHA", valor)
            SetDBLogonForReport(iconexion, info)
            Me.CrystalReportViewer1.ReportSource = info
            info.PrintOptions.PrinterName = impresosaPredt
            info.PrintToPrinter(1, False, 0, 0)

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            SQLconexion.Close()
        End Try
    End Sub
End Class