Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System
Imports System.IO
Imports System.Diagnostics

Public Class MOVIMIENTO_EN_CAJA
    Dim DaDetMov_Caja As New SqlClient.SqlDataAdapter
    Dim DsDetMov_Caja As New Data.DataSet

    Function sucursal(ByVal a As Integer) As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT SUCURSAL FROM CONFIG_EMPRESA WHERE COD_EMPRESA = " & a & ""
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
    Function Operador(ByVal a As Integer, ByVal b As Date) As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT USUARIO FROM CP_ESTADO_CAJA WHERE ESTADO = " & a & " AND FECHA_ESTADO = '" & b & "'"
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

    Function EstadoCaja(ByVal a As String, ByVal b As Date) As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT ESTADO FROM CP_ESTADO_CAJA WHERE USUARIO = '" & a & "' AND FECHA_ESTADO = '" & b & "'"
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

    Sub SetDBLogonForReport(ByVal myConnectionInfo As ConnectionInfo, ByVal myReportDocument As ReportDocument)
        Dim myTables As Tables = myReportDocument.Database.Tables
        For Each myTable As CrystalDecisions.CrystalReports.Engine.Table In myTables
            Dim myTableLogonInfo As TableLogOnInfo = myTable.LogOnInfo
            myTableLogonInfo.ConnectionInfo = myConnectionInfo
            myTable.ApplyLogOnInfo(myTableLogonInfo)
        Next
    End Sub

    Private Sub MOVIMIENTO_EN_CAJA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.btnExcel.Enabled = False
        Me.btnPDF.Enabled = False

        iconexion.DatabaseName = bbdd
        iconexion.UserID = usuario_
        iconexion.Password = contrasena_
        iconexion.ServerName = servidor

        iconexion.Type = ConnectionInfoType.SQL
        '********************************************************

        Me.Label1.Text = Date.Now.ToLongTimeString
        Timer1.Start()
        Me.Label2.Text = DateTime.Now.ToString("dd/MM/yyyy")

        Dim Estado_Caja As Integer
        Estado_Caja = EstadoCaja(usuario_AUX, Inicio_Sesion)

        If Estado_Caja = 1 Then

            Me.Label10.Text = sucursal(1)
            Me.lblOperador.Text = Operador(Estado_Caja, Today)
            Me.lblEstado_Caja.Text = "CAJA HABILITADA"

            Try
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter("ESTADO_CAJA", SQLconexion)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ESTADO", Estado_Caja)
                da.Fill(dt)

                Dim ds As New Data.DataSet
                ds.Tables.Add(dt)

                Dim info As New DETALLE_MOVIMIENTO_CAJA

                info.SetDataSource(ds)
                info.SetParameterValue("@ESTADO", Estado_Caja)
                SetDBLogonForReport(iconexion, info)
                Me.CrystalReportViewer1.ReportSource = info

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                SQLconexion.Close()
            End Try
        End If

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Label1.Text = Date.Now.ToLongTimeString
    End Sub

    Private Sub btnPDF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPDF.Click
        Dim Estado_Caja As Integer
        Estado_Caja = EstadoCaja(usuario_AUX, Inicio_Sesion)

        If Estado_Caja = 1 Then

            Me.Label10.Text = sucursal(1)
            Me.lblOperador.Text = Operador(Estado_Caja, Today)
            Me.lblEstado_Caja.Text = "CAJA HABILITADA"

            Try
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter("ESTADO_CAJA", SQLconexion)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ESTADO", Estado_Caja)
                da.Fill(dt)

                Dim ds As New Data.DataSet
                ds.Tables.Add(dt)

                Dim info As New DETALLE_MOVIMIENTO_CAJA_EXTENDIDO
                info.SetDataSource(ds)
                info.SetParameterValue("@ESTADO", Estado_Caja)
                info.SetDatabaseLogon("clezcano", "Cesar1983")
                Me.CrystalReportViewer2.ReportSource = info
                info.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, "H:\Sistemas PYMES\SGCV_CO V1.0\Reporte Movimiento Caja\" & Estado_Caja & ".pdf")

                Dim psi As New ProcessStartInfo
                psi.UseShellExecute = True
                psi.FileName = "H:\Sistemas PYMES\SGCV_CO V1.0\Reporte Movimiento Caja\" & Estado_Caja & ".pdf"
                Process.Start(psi)


            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                SQLconexion.Close()
            End Try
        End If
    End Sub

    Private Sub btnExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExcel.Click
        Dim Estado_Caja As Integer
        Estado_Caja = EstadoCaja(usuario_AUX, Inicio_Sesion)

        If Estado_Caja = 1 Then

            Me.Label10.Text = sucursal(1)
            Me.lblOperador.Text = Operador(Estado_Caja, Today)
            Me.lblEstado_Caja.Text = "CAJA HABILITADA"

            Try
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter("ESTADO_CAJA", SQLconexion)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ESTADO", Estado_Caja)
                da.Fill(dt)

                Dim ds As New Data.DataSet
                ds.Tables.Add(dt)

                Dim info As New DETALLE_MOVIMIENTO_CAJA_EXTENDIDO
                info.SetDataSource(ds)
                info.SetParameterValue("@ESTADO", Estado_Caja)
                info.SetDatabaseLogon("clezcano", "Cesar1983")
                Me.CrystalReportViewer2.ReportSource = info
                info.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.Excel, "H:\Sistemas PYMES\SGCV_CO V1.0\Reporte Movimiento Caja\" & Estado_Caja & ".XLS")

                Dim psi As New ProcessStartInfo
                psi.UseShellExecute = True
                psi.FileName = "H:\Sistemas PYMES\SGCV_CO V1.0\Reporte Movimiento Caja\" & Estado_Caja & ".XLS"
                Process.Start(psi)


            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                SQLconexion.Close()
            End Try
        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        Dim instance As New Printing.PrinterSettings
        Dim impresosaPredt As String = instance.PrinterName

        Dim Estado_Caja As Integer
        Estado_Caja = EstadoCaja(usuario_AUX, Inicio_Sesion)

        If Estado_Caja = 1 Then

            Me.Label10.Text = sucursal(1)
            Me.lblOperador.Text = Operador(Estado_Caja, Today)
            Me.lblEstado_Caja.Text = "CAJA HABILITADA"

            Try
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter("ESTADO_CAJA", SQLconexion)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ESTADO", Estado_Caja)
                da.Fill(dt)

                Dim ds As New Data.DataSet
                ds.Tables.Add(dt)

                Dim info As New DETALLE_MOVIMIENTO_CAJA_EXTENDIDO
                info.SetDataSource(ds)
                info.SetParameterValue("@ESTADO", Estado_Caja)
                SetDBLogonForReport(iconexion, info)
                Me.CrystalReportViewer1.ReportSource = info
                info.PrintOptions.PrinterName = impresosaPredt
                info.PrintToPrinter(1, False, 0, 0)

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                SQLconexion.Close()
            End Try
        End If
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnActualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizar.Click
        Dim Estado_Caja As Integer
        Estado_Caja = EstadoCaja(usuario_AUX, Inicio_Sesion)

        If Estado_Caja = 1 Then

            Me.Label10.Text = sucursal(1)
            Me.lblOperador.Text = Operador(Estado_Caja, Today)
            Me.lblEstado_Caja.Text = "CAJA HABILITADA"

            Try
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter("ESTADO_CAJA", SQLconexion)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@ESTADO", Estado_Caja)
                da.Fill(dt)

                Dim ds As New Data.DataSet
                ds.Tables.Add(dt)

                Dim info As New DETALLE_MOVIMIENTO_CAJA
                info.SetDataSource(ds)
                info.SetParameterValue("@ESTADO", Estado_Caja)
                SetDBLogonForReport(iconexion, info)
                Me.CrystalReportViewer1.ReportSource = info

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                SQLconexion.Close()
            End Try
        End If

    End Sub
End Class