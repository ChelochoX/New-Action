Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System
Imports System.IO
Imports System.Diagnostics

Public Class VER_DOCUMENTO_FACTURACION

    Function BUSQUEDA_IDENTIFICADOR(ByVal A As String) As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT IDENTIFICADOR FROM VF_CABECERA_FACTURA WHERE NUMERO_FACTURA = '" & A & "'"
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

    Sub SetDBLogonForReport(ByVal myConnectionInfo As ConnectionInfo, ByVal myReportDocument As ReportDocument)
        Dim myTables As Tables = myReportDocument.Database.Tables
        For Each myTable As CrystalDecisions.CrystalReports.Engine.Table In myTables
            Dim myTableLogonInfo As TableLogOnInfo = myTable.LogOnInfo
            myTableLogonInfo.ConnectionInfo = myConnectionInfo
            myTable.ApplyLogOnInfo(myTableLogonInfo)
        Next
    End Sub

    Private Sub VER_DOCUMENTO_FACTURACION_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        iconexion.DatabaseName = bbdd
        iconexion.UserID = usuario_
        iconexion.Password = contrasena_
        iconexion.ServerName = servidor

        iconexion.Type = ConnectionInfoType.SQL

        Dim Identificador_Factura As String
        Identificador_Factura = BUSQUEDA_IDENTIFICADOR(Valor_ParaReporteFactura)

        If Identificador_Factura = "T" Then
            Try
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter("REPORTE_FACTURACION_FACTURA", SQLconexion)
                da.SelectCommand.CommandType = CommandType.StoredProcedure
                da.SelectCommand.Parameters.AddWithValue("@NUMERO_FACTURA", Valor_ParaReporteFactura)
                da.Fill(dt)

                Dim ds As New Data.DataSet
                ds.Tables.Add(dt)

                Dim info As New REPORTE_TICKET
                info.SetDataSource(ds)
                info.SetParameterValue("@NUMERO_FACTURA", Valor_ParaReporteFactura)
                SetDBLogonForReport(iconexion, info)
                Me.CrystalReportViewer1.ReportSource = info

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                SQLconexion.Close()
            End Try
        Else
            If Identificador_Factura = "F" Then
                Try
                    Dim dt As New DataTable
                    Dim da As New SqlDataAdapter("REPORTE_FACTURACION_FACTURA", SQLconexion)
                    da.SelectCommand.CommandType = CommandType.StoredProcedure
                    da.SelectCommand.Parameters.AddWithValue("@NUMERO_FACTURA", Valor_ParaReporteFactura)
                    da.Fill(dt)

                    Dim ds As New Data.DataSet
                    ds.Tables.Add(dt)

                    Dim info As New REPORTE_FACTURA
                    info.SetDataSource(ds)
                    info.SetParameterValue("@NUMERO_FACTURA", Valor_ParaReporteFactura)
                    SetDBLogonForReport(iconexion, info)
                    Me.CrystalReportViewer1.ReportSource = info

                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                    SQLconexion.Close()
                End Try
            End If
        End If
    End Sub
End Class