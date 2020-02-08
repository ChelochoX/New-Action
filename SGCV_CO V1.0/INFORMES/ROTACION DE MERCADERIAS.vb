Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System
Imports System.IO
Imports System.Diagnostics

Public Class ROTACION_DE_MERCADERIAS


    Dim DaCabFactura, DaDetFactura, DaRota As New SqlClient.SqlDataAdapter
    Dim DsCabFactura, DsDetFactura, DsRota As New Data.DataSet
    Dim sucursal As String
    Dim FECHA_INICIAL, FECHA_FINAL, FECHA_FINAL_ As Date

    Sub Cargar_Datos()
        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM VF_CABECERA_FACTURA"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaCabFactura = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsCabFactura = New Data.DataSet
            DaCabFactura.Fill(Me.DsCabFactura, "VF_CABECERA_FACTURA")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM VF_DETALLE_FACTURA"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaDetFactura = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsDetFactura = New Data.DataSet
            DaDetFactura.Fill(Me.DsDetFactura, "VF_DETALLE_FACTURA")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM INF_ROTACION_MERCADERIAS"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaRota = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsRota = New Data.DataSet
            DaRota.Fill(Me.DsRota, "INF_ROTACION_MERCADERIAS")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub

    Function EstadoCaja(ByVal a As String, ByVal b As Date) As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COD_CAB_CAJA FROM CP_CABECERA_CAJA WHERE ESTADO = '" & a & "' AND FECHA_APERTURA = '" & b & "'"
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

    Function Recuperar_Sucursal(ByVal a As Integer) As String
        Try
            conectar()
            Dim sel As String
            sel = "Select J.SUCURSAL FROM CP_ESTADO_CAJA E INNER JOIN CP_CAJA J ON " & _
            "E.COD_ESTADOCAJA = J.COD_ESTADOCAJA INNER JOIN CP_CABECERA_MOVIMIENTO_CAJA C " & _
            "ON J.COD_CAJA = C.COD_CAJA WHERE E.ESTADO = " & a & ""
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

    Function ELIMAR_DATOS_INF() As Integer
        Try
            conectar()
            Dim sel As String
            sel = "DELETE FROM INF_ROTACION_MERCADERIAS"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As Integer = CInt(cmm.ExecuteScalar())
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

    Private Sub ROTACION_DE_MERCADERIAS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar_Datos()
        Dim Estado_Caja As Integer
        Estado_Caja = EstadoCaja("HABILITADO", Today)
        Contador_MovCaja_Apertura = Estado_Caja

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
        fecha1 = Me.DateTimePicker2.Value.Date.AddDays(0)
        FECHA_FINAL = fecha1
    End Sub

    Function Anulado(ByVal a As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM ANULAR_FACTURACION WHERE NUMERO_DOCUMENTO = '" & a & "'"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As Integer = CInt(cmm.ExecuteScalar())
            cmm.Dispose()
            SQLconexion.Close()

            Return t
        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Function

    Function Contador_Rotacion() As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM INF_ROTACION_MERCADERIAS"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As Integer = CInt(cmm.ExecuteScalar())
            cmm.Dispose()
            SQLconexion.Close()

            Return t
        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

    End Function

    Function StockProducto(ByVal a As String, ByVal b As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT CANTIDAD FROM SC_STOCK WHERE NOMBRE_PRODUCTO = '" & a & "' AND DEPOSITO = '" & b & "'"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As Integer = CInt(cmm.ExecuteScalar())
            cmm.Dispose()
            SQLconexion.Close()

            Return t
        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

    End Function

    Function existe_producto(ByVal a As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM INF_ROTACION_MERCADERIAS WHERE PRODUCTO = '" & a & "'"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As Integer = CInt(cmm.ExecuteScalar())
            cmm.Dispose()
            SQLconexion.Close()

            Return t
        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

    End Function

    Function CantidadDisponible(ByVal a As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT CANT_MOVIDA FROM INF_ROTACION_MERCADERIAS WHERE PRODUCTO = '" & a & "'"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As Integer = CInt(cmm.ExecuteScalar())
            cmm.Dispose()
            SQLconexion.Close()

            Return t
        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

    End Function

    Private Sub btnGenerar_Calculo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar_Calculo.Click

        'ELIMNAR ANTES DATOS DE TABLA INFORME****
        ELIMAR_DATOS_INF()

        Dim i, j, l As Integer
        Dim FechaCab As Date
        Dim CodigoCab, CodigoDet, CantidadDet, stock_producto, cantidad_disponible As Integer
        Dim Documento, ProductoDet As String

        For i = 0 To Me.BindingContext(Me.DsCabFactura, "VF_CABECERA_FACTURA").Count - 1
            Me.BindingContext(Me.DsCabFactura, "VF_CABECERA_FACTURA").Position = i

            FechaCab = CDate(Me.DsCabFactura.Tables("VF_CABECERA_FACTURA").Rows(Me.BindingContext(Me.DsCabFactura, "VF_CABECERA_FACTURA").Position).Item("FECHA").ToString)
            CodigoCab = CInt(Me.DsCabFactura.Tables("VF_CABECERA_FACTURA").Rows(Me.BindingContext(Me.DsCabFactura, "VF_CABECERA_FACTURA").Position).Item("COD_FACTURA").ToString)
            Documento = Trim(Me.DsCabFactura.Tables("VF_CABECERA_FACTURA").Rows(Me.BindingContext(Me.DsCabFactura, "VF_CABECERA_FACTURA").Position).Item("NUMERO_FACTURA").ToString)

            If FechaCab >= FECHA_INICIAL And FechaCab <= FECHA_FINAL Then
                If Anulado(Documento) = 0 Then

                    For j = 0 To Me.BindingContext(Me.DsDetFactura, "VF_DETALLE_FACTURA").Count - 1
                        Me.BindingContext(Me.DsDetFactura, "VF_DETALLE_FACTURA").Position = j

                        CodigoDet = Trim(Me.DsDetFactura.Tables("VF_DETALLE_FACTURA").Rows(Me.BindingContext(Me.DsDetFactura, "VF_DETALLE_FACTURA").Position).Item("COD_FACTURA").ToString)

                        If CodigoCab = CodigoDet Then

                            ProductoDet = Trim(Me.DsDetFactura.Tables("VF_DETALLE_FACTURA").Rows(Me.BindingContext(Me.DsDetFactura, "VF_DETALLE_FACTURA").Position).Item("PRODUCTO").ToString)
                            CantidadDet = CInt(Me.DsDetFactura.Tables("VF_DETALLE_FACTURA").Rows(Me.BindingContext(Me.DsDetFactura, "VF_DETALLE_FACTURA").Position).Item("CANTIDAD").ToString)

                            If existe_producto(ProductoDet) = 0 Then
                                Try
                                    Dim contador As Integer
                                    contador = Contador_Rotacion() + 1
                                    SQLconexion.Open()
                                    Dim sqlbuilder As New System.Text.StringBuilder
                                    With sqlbuilder
                                        .Append("INSERT INTO INF_ROTACION_MERCADERIAS")
                                        .Append(" VALUES ('")
                                        .Append(contador & "','")
                                        .Append(sucursal & "','")
                                        .Append(FECHA_INICIAL & "','")
                                        .Append(FECHA_FINAL & "','")
                                        .Append(ProductoDet & "','")
                                        .Append(CantidadDet & "','")
                                        .Append(0 & "')")

                                    End With
                                    cmm = New SqlClient.SqlCommand(sqlbuilder.ToString, SQLconexion)
                                    cmm.ExecuteNonQuery()
                                    SQLconexion.Close()
                                    cmm.Dispose()
                                    SQLconexion.Dispose()

                                Catch ex As SqlClient.SqlException
                                    MsgBox(ex.Message())
                                    SQLconexion.Close()
                                End Try
                            Else
                                cantidad_disponible = CantidadDisponible(ProductoDet) + CantidadDet
                                Try
                                    conectar()
                                    Dim sel As String
                                    sel = "UPDATE INF_ROTACION_MERCADERIAS SET CANT_MOVIDA = " & cantidad_disponible & "" & _
                                    "WHERE PRODUCTO = '" & ProductoDet & "'"
                                    cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                                    SQLconexion.Open()
                                    Dim t As Integer = CInt(cmm.ExecuteScalar())
                                    cmm.Dispose()
                                    SQLconexion.Close()

                                Catch ex As Exception
                                    MsgBox(ex.Message())
                                    SQLconexion.Close()
                                End Try
                            End If
                        End If
                    Next
                End If
            End If
        Next

        Dim producto_rota As String

        For l = 0 To Me.BindingContext(Me.DsRota, "INF_ROTACION_MERCADERIAS").Count - 1
            Me.BindingContext(Me.DsRota, "INF_ROTACION_MERCADERIAS").Position = l

            producto_rota = Trim(Me.DsRota.Tables("INF_ROTACION_MERCADERIAS").Rows(Me.BindingContext(Me.DsRota, "INF_ROTACION_MERCADERIAS").Position).Item("PRODUCTO").ToString)
            stock_producto = StockProducto(producto_rota, "AREGUA")
            Try
                conectar()
                Dim sel As String
                sel = "UPDATE INF_ROTACION_MERCADERIAS SET STOCK_DISPONIBLE = " & stock_producto & "" & _
                "WHERE PRODUCTO = '" & producto_rota & "'"
                cmm = New SqlClient.SqlCommand(sel, SQLconexion)
                SQLconexion.Open()
                Dim t As Integer = CInt(cmm.ExecuteScalar())
                cmm.Dispose()
                SQLconexion.Close()

            Catch ex As Exception
                MsgBox(ex.Message())
                SQLconexion.Close()
            End Try
        Next

        Try
            conectar()
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter("ROTACION_MERCADERIAS", SQLconexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@FECHA_INI", FECHA_INICIAL)
            da.SelectCommand.Parameters.AddWithValue("@FECHA_FIN", FECHA_FINAL)

            da.Fill(dt)

            Dim ds As New Data.DataSet
            ds.Tables.Add(dt)

            Dim info As New ROTACION_MERCADERIAS

            info.SetDataSource(ds)
            info.SetParameterValue("@FECHA_INI", FECHA_INICIAL)
            info.SetParameterValue("@FECHA_FIN", FECHA_FINAL)
            SetDBLogonForReport(iconexion, info)
            Me.CrystalReportViewer1.ReportSource = info

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            SQLconexion.Close()
        End Try


    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

End Class