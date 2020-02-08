Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System
Imports System.IO
Imports System.Diagnostics

Public Class VISUALIZAR_STOCK_EN_DEPOSITO

    Dim DaDeposito As New SqlClient.SqlDataAdapter
    Dim DsDeposito As New Data.DataSet
    Dim DEPOSITO As String
    Dim bandera_cantidad, bandera_nombre, bandera_usado, bandera_StockValorizado As Integer


    Sub Cargar_Datos()
        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM TP_DEPOSITO"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaDeposito = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsDeposito = New Data.DataSet
            DaDeposito.Fill(Me.DsDeposito, "TP_DEPOSITO")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub

    Sub SetDBLogonForReport(ByVal myConnectionInfo As ConnectionInfo, ByVal myReportDocument As ReportDocument)
        Dim myTables As Tables = myReportDocument.Database.Tables
        For Each myTable As CrystalDecisions.CrystalReports.Engine.Table In myTables
            Dim myTableLogonInfo As TableLogOnInfo = myTable.LogOnInfo
            myTableLogonInfo.ConnectionInfo = myConnectionInfo
            myTable.ApplyLogOnInfo(myTableLogonInfo)
        Next
    End Sub

    Private Sub VISUALIZAR_STOCK_EN_DEPOSITO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar_Datos()

        Dim dt As New DataTable("TP_DEPOSITO")
        DaDeposito.Fill(dt)
        SQLconexion.Close()

        With lstDeposito
            .DataSource = dt
            .DisplayMember = "Deposito"
            .ValueMember = "NOMBRE"
        End With

        bandera_cantidad = 0
        bandera_nombre = 0
        bandera_usado = 0
        bandera_StockValorizado = 0

        Me.btnExcel.Enabled = False
        Me.btnPDF.Enabled = False

        iconexion.DatabaseName = bbdd
        iconexion.UserID = usuario_
        iconexion.Password = contrasena_
        iconexion.ServerName = servidor

        iconexion.Type = ConnectionInfoType.SQL

        DEPOSITO = Me.lstDeposito.Text

    End Sub

    Private Sub lstDeposito_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstDeposito.Click
        DEPOSITO = Me.lstDeposito.Text
        Me.lstDeposito.SelectedItem = Color.Blue
        Me.lstDeposito.SelectedItem = Color.Yellow

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        Dim instance As New Printing.PrinterSettings
        Dim impresosaPredt As String = instance.PrinterName

        If bandera_cantidad = 1 Then
            Try
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter("STOCK_POR_CADA_DEPOSITO", SQLconexion)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@DEPOSITO", DEPOSITO)
                da.Fill(dt)

                Dim ds As New Data.DataSet
                ds.Tables.Add(dt)

                Dim info As New STOCK_POR_CADA_DEPOSITO

                info.SetDataSource(ds)
                info.SetParameterValue("@DEPOSITO", DEPOSITO)
                SetDBLogonForReport(iconexion, info)
                Me.CrystalReportViewer1.ReportSource = info
                info.PrintOptions.PrinterName = impresosaPredt
                info.PrintToPrinter(1, False, 0, 0)

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                SQLconexion.Close()
            End Try
        Else
            If bandera_nombre = 1 Then
                Try
                    Dim dt As New DataTable
                    Dim da As New SqlDataAdapter("LISTAR_STOCK_POR_NOMBRE", SQLconexion)
                    da.SelectCommand.CommandType = CommandType.StoredProcedure
                    da.SelectCommand.Parameters.AddWithValue("@DEPOSITO", DEPOSITO)
                    da.Fill(dt)

                    Dim ds As New Data.DataSet
                    ds.Tables.Add(dt)

                    Dim info As New STOCK_POR_NOMBRE

                    info.SetDataSource(ds)
                    info.SetParameterValue("@DEPOSITO", DEPOSITO)
                    SetDBLogonForReport(iconexion, info)
                    Me.CrystalReportViewer1.ReportSource = info
                    info.PrintOptions.PrinterName = impresosaPredt
                    info.PrintToPrinter(1, False, 0, 0)

                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                    SQLconexion.Close()
                End Try
            Else
                If bandera_usado = 1 Then
                    Try
                        Dim dt As New DataTable
                        Dim da As New SqlDataAdapter("LISTAR_STOCK_POR_USADOS", SQLconexion)
                        da.SelectCommand.CommandType = CommandType.StoredProcedure
                        da.SelectCommand.Parameters.AddWithValue("@DEPOSITO", DEPOSITO)
                        da.Fill(dt)

                        Dim ds As New Data.DataSet
                        ds.Tables.Add(dt)

                        Dim info As New STOCK_POR_NOMBRE_USADOS

                        info.SetDataSource(ds)
                        info.SetParameterValue("@DEPOSITO", DEPOSITO)
                        SetDBLogonForReport(iconexion, info)
                        Me.CrystalReportViewer1.ReportSource = info
                        info.PrintOptions.PrinterName = impresosaPredt
                        info.PrintToPrinter(1, False, 0, 0)

                    Catch ex As Exception
                        MessageBox.Show(ex.ToString)
                        SQLconexion.Close()
                    End Try
                Else
                    If bandera_StockValorizado = 1 Then
                        Try
                            Dim dt As New DataTable
                            Dim da As New SqlDataAdapter("LISTAR_STOCK_POR_VALORIZACION", SQLconexion)
                            da.SelectCommand.CommandType = CommandType.StoredProcedure
                            da.SelectCommand.Parameters.AddWithValue("@DEPOSITO", DEPOSITO)
                            da.Fill(dt)

                            Dim ds As New Data.DataSet
                            ds.Tables.Add(dt)

                            Dim info As New STOCK_POR_VALORIZACION

                            info.SetDataSource(ds)
                            info.SetParameterValue("@DEPOSITO", DEPOSITO)
                            SetDBLogonForReport(iconexion, info)
                            Me.CrystalReportViewer1.ReportSource = info
                            info.PrintOptions.PrinterName = impresosaPredt
                            info.PrintToPrinter(1, False, 0, 0)

                        Catch ex As Exception
                            MessageBox.Show(ex.ToString)
                            SQLconexion.Close()
                        End Try
                    Else
                        If bandera_StockValorizado = 1 Then

                        End If
                    End If
                End If
            End If
        End If

        bandera_cantidad = 0
        bandera_nombre = 0
        bandera_usado = 0
        bandera_StockValorizado = 0

    End Sub

    Private Sub btnPor_cantidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPor_cantidad.Click
        If DEPOSITO = "" Then
            MessageBox.Show("SELECCIONAR DEPOSITO PARA VISUALIZACION", "SGCV_CO V1.0", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter("STOCK_POR_CADA_DEPOSITO", SQLconexion)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@DEPOSITO", DEPOSITO)
                da.Fill(dt)

                Dim ds As New Data.DataSet
                ds.Tables.Add(dt)

                Dim info As New STOCK_POR_CADA_DEPOSITO
                info.SetDataSource(ds)
                info.SetParameterValue("@DEPOSITO", DEPOSITO)
                SetDBLogonForReport(iconexion, info)
                Me.CrystalReportViewer1.ReportSource = info

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                SQLconexion.Close()
            End Try

            bandera_cantidad = 1
        End If

    End Sub

    Private Sub btnPor_Nombre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPor_Nombre.Click
        If DEPOSITO = "" Then
            MessageBox.Show("SELECCIONAR DEPOSITO PARA VISUALIZACION", "SGCV_CO V1.0", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter("LISTAR_STOCK_POR_NOMBRE", SQLconexion)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@DEPOSITO", DEPOSITO)
                da.Fill(dt)

                Dim ds As New Data.DataSet
                ds.Tables.Add(dt)

                Dim info As New STOCK_POR_NOMBRE
                info.SetDataSource(ds)
                info.SetParameterValue("@DEPOSITO", DEPOSITO)
                SetDBLogonForReport(iconexion, info)
                Me.CrystalReportViewer1.ReportSource = info

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                SQLconexion.Close()
            End Try


            bandera_nombre = 1
        End If
    End Sub


    Private Sub btnUsado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUsado.Click
        If DEPOSITO = "" Then
            MessageBox.Show("SELECCIONAR DEPOSITO PARA VISUALIZACION", "SGCV_CO V1.0", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter("LISTAR_STOCK_POR_NOMBRE_USADOS_", SQLconexion)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@DEPOSITO", DEPOSITO)
                da.Fill(dt)

                Dim ds As New Data.DataSet
                ds.Tables.Add(dt)

                Dim info As New STOCK_POR_NOMBRE_USADOS

                info.SetDataSource(ds)
                info.SetParameterValue("@DEPOSITO", DEPOSITO)
                SetDBLogonForReport(iconexion, info)
                Me.CrystalReportViewer1.ReportSource = info

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                SQLconexion.Close()
            End Try


            bandera_usado = 1
        End If
    End Sub

    Private Sub btnStock_Valorizado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStock_Valorizado.Click
        If DEPOSITO = "" Then
            MessageBox.Show("SELECCIONAR DEPOSITO PARA VISUALIZACION", "SGCV_CO V1.0", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Try
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter("LISTAR_STOCK_POR_VALORIZACION", SQLconexion)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@DEPOSITO", DEPOSITO)
                da.Fill(dt)

                Dim ds As New Data.DataSet
                ds.Tables.Add(dt)

                Dim info As New STOCK_POR_VALORIZACION

                info.SetDataSource(ds)
                info.SetParameterValue("@DEPOSITO", DEPOSITO)
                SetDBLogonForReport(iconexion, info)
                Me.CrystalReportViewer1.ReportSource = info

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                SQLconexion.Close()
            End Try


            bandera_StockValorizado = 1
        End If
    End Sub

End Class