Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System
Imports System.IO
Imports System.Diagnostics

Public Class REPORTE_SEGUIMIENTO_DE_COBRANZA

    Dim FechaIni, FechaFin As Date
    Dim CEDULA As String
    Dim b, c As Integer


    Private Sub btnVerSeguimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerSeguimiento.Click

        CEDULA = Trim(Me.txtCedulaCliente.Text)

        If b = 0 Then
            MessageBox.Show("DEFINIR FECHA PARA SEGUIMIENTO DE COBRANZA", "SGCV_CO V1.0", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            If c = 0 Then
                MessageBox.Show("DEFINIR FECHA PARA SEGUIMIENTO DE COBRANZA", "SGCV_CO V1.0", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                If Me.rbPorCedula.Checked = True Then
                    Try
                        Dim dt As New DataTable
                        Dim da As New SqlDataAdapter("REPORTE_SEGUIMIENTO_COBRANZA_PORCEDULA", SQLconexion)
                        da.SelectCommand.CommandType = CommandType.StoredProcedure
                        da.SelectCommand.Parameters.AddWithValue("@FECHA_SEG_INI", FechaIni)
                        da.SelectCommand.Parameters.AddWithValue("@FECHA_SEG_FIN", FechaFin)
                        da.SelectCommand.Parameters.AddWithValue("@CEDULA", CEDULA)
                        da.Fill(dt)

                        Dim ds As New Data.DataSet
                        ds.Tables.Add(dt)

                        Dim info As New REPORTE_SEGUIMIENTO_COBRANZA_POR_CEDULA

                        info.SetDataSource(ds)
                        info.SetParameterValue("@FECHA_SEG_INI", FechaIni)
                        info.SetParameterValue("@FECHA_SEG_FIN", FechaFin)
                        info.SetParameterValue("@CEDULA", CEDULA)
                        SetDBLogonForReport(iconexion, info)
                        Me.CrystalReportViewer1.ReportSource = info

                    Catch ex As Exception
                        MessageBox.Show(ex.ToString)
                        SQLconexion.Close()
                    End Try
                Else
                    If Me.rbRangoFechas.Checked = True Then
                        Try
                            Dim dt As New DataTable
                            Dim da As New SqlDataAdapter("REPORTE_SEGUIMIENTO_COBRANZA_PORRANGOFECHA", SQLconexion)
                            da.SelectCommand.CommandType = CommandType.StoredProcedure
                            da.SelectCommand.Parameters.AddWithValue("@FECHA_SEG_INI", FechaIni)
                            da.SelectCommand.Parameters.AddWithValue("@FECHA_SEG_FIN", FechaFin)
                            da.Fill(dt)

                            Dim ds As New Data.DataSet
                            ds.Tables.Add(dt)

                            Dim info As New REPORTE_SEGUIMIENTO_COBRANZA_POR_RANGO_FECHA

                            info.SetDataSource(ds)
                            info.SetParameterValue("@FECHA_SEG_INI", FechaIni)
                            info.SetParameterValue("@FECHA_SEG_FIN", FechaFin)
                            SetDBLogonForReport(iconexion, info)
                            Me.CrystalReportViewer1.ReportSource = info

                        Catch ex As Exception
                            MessageBox.Show(ex.ToString)
                            SQLconexion.Close()
                        End Try
                    End If
                End If

            End If
        End If
    End Sub

    Private Sub DateTimePicker2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateTimePicker2.Leave
        Dim fecha1 As Date
        fecha1 = Me.DateTimePicker2.Value.Date.AddDays(0)
        FechaIni = fecha1
        b = 1
    End Sub

    Private Sub DateTimePicker3_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateTimePicker3.Leave
        Dim fecha1 As Date
        fecha1 = Me.DateTimePicker3.Value.Date.AddDays(0)
        FechaFin = fecha1
        c = 1
    End Sub

    Private Sub rbPorCedula_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbPorCedula.Click
        Me.txtCedulaCliente.Enabled = True
        Me.txtCedulaCliente.Focus()
    End Sub

    Private Sub rbRangoFechas_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rbRangoFechas.Click
        Me.DateTimePicker2.Focus()
        Me.txtCedulaCliente.Enabled = False
    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        Me.rbPorCedula.Checked = False
        Me.rbRangoFechas.Checked = False
        Me.txtCedulaCliente.Focus()
        Me.CrystalReportViewer1.ReportSource = Nothing
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        Dim instance As New Printing.PrinterSettings
        Dim impresosaPredt As String = instance.PrinterName

        CEDULA = Trim(Me.txtCedulaCliente.Text)
        If Me.rbPorCedula.Checked = True Then
            Try
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter("REPORTE_SEGUIMIENTO_COBRANZA_PORCEDULA", SQLconexion)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@FECHA_SEG_INI", FechaIni)
                da.SelectCommand.Parameters.AddWithValue("@FECHA_SEG_FIN", FechaFin)
                da.SelectCommand.Parameters.AddWithValue("@CEDULA", CEDULA)
                da.Fill(dt)

                Dim ds As New Data.DataSet
                ds.Tables.Add(dt)

                Dim info As New REPORTE_SEGUIMIENTO_COBRANZA_POR_CEDULA

                info.SetDataSource(ds)
                info.SetParameterValue("@FECHA_SEG_INI", FechaIni)
                info.SetParameterValue("@FECHA_SEG_FIN", FechaFin)
                info.SetParameterValue("@CEDULA", CEDULA)
                 SetDBLogonForReport(iconexion, info)
                Me.CrystalReportViewer1.ReportSource = info
                info.PrintOptions.PrinterName = impresosaPredt
                info.PrintToPrinter(1, False, 0, 0)


            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                SQLconexion.Close()
            End Try
        Else
            If Me.rbRangoFechas.Checked = True Then
                Try
                    Dim dt As New DataTable
                    Dim da As New SqlDataAdapter("REPORTE_SEGUIMIENTO_COBRANZA_PORRANGOFECHA", SQLconexion)
                    da.SelectCommand.CommandType = CommandType.StoredProcedure
                    da.SelectCommand.Parameters.AddWithValue("@FECHA_SEG_INI", FechaIni)
                    da.SelectCommand.Parameters.AddWithValue("@FECHA_SEG_FIN", FechaFin)
                    da.Fill(dt)

                    Dim ds As New Data.DataSet
                    ds.Tables.Add(dt)

                    Dim info As New REPORTE_SEGUIMIENTO_COBRANZA_POR_RANGO_FECHA
                    Dim rango As String
                    rango = "rango"

                    info.SetDataSource(ds)
                    info.SetParameterValue("@FECHA_SEG_INI", FechaIni)
                    info.SetParameterValue("@FECHA_SEG_FIN", FechaFin)
                    SetDBLogonForReport(iconexion, info)
                    Me.CrystalReportViewer1.ReportSource = info
                    info.PrintOptions.PrinterName = impresosaPredt
                    info.PrintToPrinter(1, False, 0, 0)

                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                    SQLconexion.Close()
                End Try
            End If
        End If
    End Sub

    Sub SetDBLogonForReport(ByVal myConnectionInfo As ConnectionInfo, ByVal myReportDocument As ReportDocument)
        Dim myTables As Tables = myReportDocument.Database.Tables
        For Each myTable As CrystalDecisions.CrystalReports.Engine.Table In myTables
            Dim myTableLogonInfo As TableLogOnInfo = myTable.LogOnInfo
            myTableLogonInfo.ConnectionInfo = myConnectionInfo
            myTable.ApplyLogOnInfo(myTableLogonInfo)
        Next
    End Sub

    Private Sub REPORTE_SEGUIMIENTO_DE_COBRANZA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        b = 0
        c = 0

        iconexion.DatabaseName = bbdd
        iconexion.UserID = usuario_
        iconexion.Password = contrasena_
        iconexion.ServerName = servidor

        iconexion.Type = ConnectionInfoType.SQL
    End Sub
End Class