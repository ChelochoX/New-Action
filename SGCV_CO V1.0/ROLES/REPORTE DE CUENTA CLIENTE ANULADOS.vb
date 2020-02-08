Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System
Imports System.IO
Imports System.Diagnostics

Public Class REPORTE_DE_CUENTA_CLIENTE_ANULADOS

    Dim FECHA_INICIAL, FECHA_FINAL As Date
    Dim DaReporte As New SqlClient.SqlDataAdapter
    Dim DsReporte As New Data.DataSet
    Dim valor As Date

    Private Sub REPORTE_DE_CUENTA_CLIENTE_ANULADOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnBuscar_Reporte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar_Reporte.Click
        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT DISTINCT FECHA_ANULACION FROM ANULAR_CUENTA_CLIENTE WHERE FECHA_ANULACION >='" & FECHA_INICIAL & "' AND FECHA_ANULACION <= '" & FECHA_FINAL & "'"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaReporte = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            Dim dt1 As New DataTable("ANULAR_CUENTA_CLIENTE")
            DaReporte.Fill(dt1)
            SQLconexion.Close()
            With ltsDetallesBusqueda
                .DataSource = dt1
                .DisplayMember = "FECHA REPORTE"
                .ValueMember = "FECHA_ANULACION"
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
        FECHA_INICIAL = Format(fecha1, "dd/MM/yyyy")
    End Sub

    Private Sub DateTimePicker2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateTimePicker2.Leave
        Dim fecha1 As Date
        fecha1 = Me.DateTimePicker2.Value.Date.AddDays(0)
        FECHA_FINAL = Format(fecha1, "dd/MM/yyyy")
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        valor = CDate(Me.ltsDetallesBusqueda.Text)
        Try
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter("CUENTA_CLIENTES_ANULADOS", SQLconexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@FECHA_INI", valor)
            da.SelectCommand.Parameters.AddWithValue("@FECHA_FIN", valor)
            da.Fill(dt)

            Dim ds As New Data.DataSet
            ds.Tables.Add(dt)
            Dim RENDICION As String
            RENDICION = "ANULADO"

            Dim info As New REPORTE_CUENTA_CLIENTES_ANULADOS
            info.SetDataSource(ds)
            info.SetParameterValue("@FECHA_INI", valor)
            info.SetParameterValue("@FECHA_FIN", valor)
            info.SetDatabaseLogon("clezcano", "Cesar1983")
            Me.CrystalReportViewer1.ReportSource = info
            info.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, "H:\Sistemas PYMES\SGCV_CO V1.0\Reporte Cuenta Cliente\" & RENDICION & ".pdf")
            info.PrintToPrinter(1, False, 0, 0)

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            SQLconexion.Close()
        End Try
    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        valor = CDate(Me.ltsDetallesBusqueda.Text)
        Try
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter("CUENTA_CLIENTES_ANULADOS", SQLconexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@FECHA_INI", valor)
            da.SelectCommand.Parameters.AddWithValue("@FECHA_FIN", valor)
            da.Fill(dt)

            Dim ds As New Data.DataSet
            ds.Tables.Add(dt)
            Dim RENDICION As String
            RENDICION = "ANULADO"

            Dim info As New REPORTE_CUENTA_CLIENTES_ANULADOS
            info.SetDataSource(ds)
            info.SetParameterValue("@FECHA_INI", valor)
            info.SetParameterValue("@FECHA_FIN", valor)
            info.SetDatabaseLogon("clezcano", "Cesar1983")
            Me.CrystalReportViewer1.ReportSource = info
            info.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.Excel, "H:\Sistemas PYMES\SGCV_CO V1.0\Reporte Cuenta Cliente\" & RENDICION & ".xls")
            Dim psi As New ProcessStartInfo
            psi.UseShellExecute = True
            psi.FileName = "H:\Sistemas PYMES\SGCV_CO V1.0\Reporte Cuenta Cliente\" & RENDICION & ".xls"
            Process.Start(psi)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            SQLconexion.Close()
        End Try
    End Sub

    Private Sub btnPDF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPDF.Click
        valor = CDate(Me.ltsDetallesBusqueda.Text)
        Try
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter("CUENTA_CLIENTES_ANULADOS", SQLconexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@FECHA_INI", valor)
            da.SelectCommand.Parameters.AddWithValue("@FECHA_FIN", valor)
            da.Fill(dt)

            Dim ds As New Data.DataSet
            ds.Tables.Add(dt)
            Dim RENDICION As String
            RENDICION = "ANULADO"

            Dim info As New REPORTE_CUENTA_CLIENTES_ANULADOS
            info.SetDataSource(ds)
            info.SetParameterValue("@FECHA_INI", valor)
            info.SetParameterValue("@FECHA_FIN", valor)
            info.SetDatabaseLogon("clezcano", "Cesar1983")
            Me.CrystalReportViewer1.ReportSource = info
            info.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, "H:\Sistemas PYMES\SGCV_CO V1.0\Reporte Cuenta Cliente\" & RENDICION & ".pdf")
            Dim psi As New ProcessStartInfo
            psi.UseShellExecute = True
            psi.FileName = "H:\Sistemas PYMES\SGCV_CO V1.0\Reporte Cuenta Cliente\" & RENDICION & ".pdf"
            Process.Start(psi)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            SQLconexion.Close()
        End Try
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class