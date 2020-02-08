Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System
Imports System.IO
Imports System.Diagnostics

Public Class REPORTE_CLIENTES

    Dim bandera_cedula, bandera_nombre, bandera_fecha As Integer

    Sub SetDBLogonForReport(ByVal myConnectionInfo As ConnectionInfo, ByVal myReportDocument As ReportDocument)
        Dim myTables As Tables = myReportDocument.Database.Tables
        For Each myTable As CrystalDecisions.CrystalReports.Engine.Table In myTables
            Dim myTableLogonInfo As TableLogOnInfo = myTable.LogOnInfo
            myTableLogonInfo.ConnectionInfo = myConnectionInfo
            myTable.ApplyLogOnInfo(myTableLogonInfo)
        Next
    End Sub


    Private Sub REPORTE_CLIENTES_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        bandera_cedula = 0
        bandera_nombre = 0
        bandera_fecha = 0

        iconexion.DatabaseName = bbdd
        iconexion.UserID = usuario_
        iconexion.Password = contrasena_
        iconexion.ServerName = servidor

        iconexion.Type = ConnectionInfoType.SQL

        btnExcel.Enabled = False
        btnPDF.Enabled = False

    End Sub

    Private Sub btnPDF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPDF.Click

        Dim dt As New DataTable

        If bandera_cedula = 1 Then
            Try
                Dim da As New SqlDataAdapter("CLIENTE_LISTARPOR_CEDULA", SQLconexion)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.Fill(dt)

                Dim ds As New Data.DataSet
                ds.Tables.Add(dt)

                Dim info As New LISTAR_POR_CEDULA_CLIENTE
                Dim report As String
                report = "REPORTE CLIENTE"
                info.SetDataSource(ds)
                info.SetDatabaseLogon("clezcano", "Cesar1983")
                CrystalReportViewer1.ReportSource = info
                info.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, "H:\Sistemas PYMES\SGCV_CO V1.0\Reporte Clientes\" & report & ".pdf")
                Dim psi As New ProcessStartInfo
                psi.UseShellExecute = True
                psi.FileName = "H:\Sistemas PYMES\SGCV_CO V1.0\Reporte Clientes\" & report & ".pdf"
                Process.Start(psi)

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        Else
            If bandera_nombre = 1 Then
                Try
                    Dim da As New SqlDataAdapter("CLIENTE_LISTARPOR_NOMBRE", SQLconexion)
                    da.SelectCommand.CommandType = CommandType.StoredProcedure
                    da.Fill(dt)

                    Dim ds As New Data.DataSet
                    ds.Tables.Add(dt)

                    Dim info As New LISTAR_POR_NOMBRE_CLIENTE
                    Dim report As String
                    report = "REPORTE CLIENTE"
                    info.SetDataSource(ds)
                    info.SetDatabaseLogon("clezcano", "Cesar1983")
                    CrystalReportViewer1.ReportSource = info
                    info.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, "H:\Sistemas PYMES\SGCV_CO V1.0\Reporte Clientes\" & report & ".pdf")
                    Dim psi As New ProcessStartInfo
                    psi.UseShellExecute = True
                    psi.FileName = "H:\Sistemas PYMES\SGCV_CO V1.0\Reporte Clientes\" & report & ".pdf"
                    Process.Start(psi)

                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try
            Else
                If bandera_fecha = 1 Then
                    Try
                        Dim da As New SqlDataAdapter("CLIENTE_LISTARPOR_FECHAREGISTRO", SQLconexion)
                        da.SelectCommand.CommandType = CommandType.StoredProcedure
                        da.Fill(dt)

                        Dim ds As New Data.DataSet
                        ds.Tables.Add(dt)

                        Dim info As New LISTAR_POR_FECHA_DE_REGISTRO
                        Dim report As String
                        report = "REPORTE CLIENTE"
                        info.SetDataSource(ds)
                        info.SetDatabaseLogon("clezcano", "Cesar1983")
                        CrystalReportViewer1.ReportSource = info
                        info.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, "H:\Sistemas PYMES\SGCV_CO V1.0\Reporte Clientes\" & report & ".pdf")
                        Dim psi As New ProcessStartInfo
                        psi.UseShellExecute = True
                        psi.FileName = "H:\Sistemas PYMES\SGCV_CO V1.0\Reporte Clientes\" & report & ".pdf"
                        Process.Start(psi)

                    Catch ex As Exception
                        MessageBox.Show(ex.ToString)
                    End Try
                End If
            End If
        End If

        bandera_cedula = 0
        bandera_nombre = 0
        bandera_fecha = 0

    End Sub

    Private Sub btnListarporCedula_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListarporCedula.Click
        Try
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter("CLIENTE_LISTARPOR_CEDULA", SQLconexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            'da.SelectCommand.Parameters.AddWithValue("@DEPOSITO", DEPOSITO)
            da.Fill(dt)

            Dim ds As New Data.DataSet
            ds.Tables.Add(dt)

            Dim info As New LISTAR_POR_CEDULA_CLIENTE

            info.SetDataSource(ds)
            SetDBLogonForReport(iconexion, info)
            CrystalReportViewer1.ReportSource = info

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        bandera_cedula = 1
    End Sub

    Private Sub btnListarporNombre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListarporNombre.Click
        Try
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter("CLIENTE_LISTARPOR_NOMBRE", SQLconexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            'da.SelectCommand.Parameters.AddWithValue("@DEPOSITO", DEPOSITO)
            da.Fill(dt)

            Dim ds As New Data.DataSet
            ds.Tables.Add(dt)

            Dim info As New LISTAR_POR_NOMBRE_CLIENTE

            info.SetDataSource(ds)
            SetDBLogonForReport(iconexion, info)
            CrystalReportViewer1.ReportSource = info

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        bandera_nombre = 1
    End Sub

    Private Sub btnListarporFecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnListarporFecha.Click
        Try
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter("CLIENTE_LISTARPOR_FECHAREGISTRO", SQLconexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            'da.SelectCommand.Parameters.AddWithValue("@DEPOSITO", DEPOSITO)
            da.Fill(dt)

            Dim ds As New Data.DataSet
            ds.Tables.Add(dt)

            Dim info As New LISTAR_POR_FECHA_DE_REGISTRO

            info.SetDataSource(ds)
            SetDBLogonForReport(iconexion, info)
            CrystalReportViewer1.ReportSource = info

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        bandera_fecha = 1
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        Dim instance As New Printing.PrinterSettings
        Dim impresosaPredt As String = instance.PrinterName
        Dim dt As New DataTable

        If bandera_cedula = 1 Then
            Try
                Dim da As New SqlDataAdapter("CLIENTE_LISTARPOR_CEDULA", SQLconexion)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.Fill(dt)

                Dim ds As New Data.DataSet
                ds.Tables.Add(dt)

                Dim info As New LISTAR_POR_CEDULA_CLIENTE
                Dim report As String
                report = "REPORTE CLIENTE"
                info.SetDataSource(ds)
                SetDBLogonForReport(iconexion, info)
                CrystalReportViewer1.ReportSource = info
                info.PrintOptions.PrinterName = impresosaPredt
                info.PrintToPrinter(1, False, 0, 0)

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        Else
            If bandera_nombre = 1 Then
                Try
                    Dim da As New SqlDataAdapter("CLIENTE_LISTARPOR_NOMBRE", SQLconexion)
                    da.SelectCommand.CommandType = CommandType.StoredProcedure
                    da.Fill(dt)

                    Dim ds As New Data.DataSet
                    ds.Tables.Add(dt)

                    Dim info As New LISTAR_POR_NOMBRE_CLIENTE
                    Dim report As String
                    report = "REPORTE CLIENTE"
                    info.SetDataSource(ds)
                    SetDBLogonForReport(iconexion, info)
                    CrystalReportViewer1.ReportSource = info
                    info.PrintOptions.PrinterName = impresosaPredt
                    info.PrintToPrinter(1, False, 0, 0)

                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try
            Else
                If bandera_fecha = 1 Then
                    Try
                        Dim da As New SqlDataAdapter("CLIENTE_LISTARPOR_FECHAREGISTRO", SQLconexion)
                        da.SelectCommand.CommandType = CommandType.StoredProcedure
                        da.Fill(dt)

                        Dim ds As New Data.DataSet
                        ds.Tables.Add(dt)

                        Dim info As New LISTAR_POR_FECHA_DE_REGISTRO
                        Dim report As String
                        report = "REPORTE CLIENTE"
                        info.SetDataSource(ds)
                        SetDBLogonForReport(iconexion, info)
                        CrystalReportViewer1.ReportSource = info
                        info.PrintOptions.PrinterName = impresosaPredt
                        info.PrintToPrinter(1, False, 0, 0)

                    Catch ex As Exception
                        MessageBox.Show(ex.ToString)
                    End Try
                End If
            End If
        End If

        bandera_cedula = 0
        bandera_nombre = 0
        bandera_fecha = 0
    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click

        Dim dt As New DataTable

        If bandera_cedula = 1 Then
            Try
                Dim da As New SqlDataAdapter("CLIENTE_LISTARPOR_CEDULA", SQLconexion)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.Fill(dt)

                Dim ds As New Data.DataSet
                ds.Tables.Add(dt)

                Dim info As New LISTAR_POR_CEDULA_CLIENTE
                Dim report As String
                report = "REPORTE CLIENTE"
                info.SetDataSource(ds)
                info.SetDatabaseLogon("clezcano", "Cesar1983")
                CrystalReportViewer1.ReportSource = info
                info.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.Excel, "H:\Sistemas PYMES\SGCV_CO V1.0\Reporte Clientes\" & report & ".xls")
                Dim psi As New ProcessStartInfo
                psi.UseShellExecute = True
                psi.FileName = "H:\Sistemas PYMES\SGCV_CO V1.0\Reporte Clientes\" & report & ".xls"
                Process.Start(psi)

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
        Else
            If bandera_nombre = 1 Then
                Try
                    Dim da As New SqlDataAdapter("CLIENTE_LISTARPOR_NOMBRE", SQLconexion)
                    da.SelectCommand.CommandType = CommandType.StoredProcedure
                    da.Fill(dt)

                    Dim ds As New Data.DataSet
                    ds.Tables.Add(dt)

                    Dim info As New LISTAR_POR_NOMBRE_CLIENTE
                    Dim report As String
                    report = "REPORTE CLIENTE"
                    info.SetDataSource(ds)
                    info.SetDatabaseLogon("clezcano", "Cesar1983")
                    CrystalReportViewer1.ReportSource = info
                    info.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.Excel, "H:\Sistemas PYMES\SGCV_CO V1.0\Reporte Clientes\" & report & ".xls")
                    Dim psi As New ProcessStartInfo
                    psi.UseShellExecute = True
                    psi.FileName = "H:\Sistemas PYMES\SGCV_CO V1.0\Reporte Clientes\" & report & ".xls"
                    Process.Start(psi)

                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try
            Else
                If bandera_fecha = 1 Then
                    Try
                        Dim da As New SqlDataAdapter("CLIENTE_LISTARPOR_FECHAREGISTRO", SQLconexion)
                        da.SelectCommand.CommandType = CommandType.StoredProcedure
                        da.Fill(dt)

                        Dim ds As New Data.DataSet
                        ds.Tables.Add(dt)

                        Dim info As New LISTAR_POR_FECHA_DE_REGISTRO
                        Dim report As String
                        report = "REPORTE CLIENTE"
                        info.SetDataSource(ds)
                        info.SetDatabaseLogon("clezcano", "Cesar1983")
                        CrystalReportViewer1.ReportSource = info
                        info.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.Excel, "H:\Sistemas PYMES\SGCV_CO V1.0\Reporte Clientes\" & report & ".xls")
                        Dim psi As New ProcessStartInfo
                        psi.UseShellExecute = True
                        psi.FileName = "H:\Sistemas PYMES\SGCV_CO V1.0\Reporte Clientes\" & report & ".xls"
                        Process.Start(psi)

                    Catch ex As Exception
                        MessageBox.Show(ex.ToString)
                    End Try
                End If
            End If
        End If

        bandera_cedula = 0
        bandera_nombre = 0
        bandera_fecha = 0

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class