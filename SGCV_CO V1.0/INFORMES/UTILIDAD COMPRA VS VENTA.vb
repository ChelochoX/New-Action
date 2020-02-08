Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System
Imports System.IO
Imports System.Diagnostics

Public Class UTILIDAD_COMPRA_VS_VENTA

    Dim FECHA_INICIAL, FECHA_FINAL, FECHA_FINAL_ As Date
    Dim dia, mes, año, dia_fin As Integer
    Dim DaCabFactura, DaDetFactura As New SqlClient.SqlDataAdapter
    Dim DsCabFactura, DsDetFactura As New Data.DataSet
    Dim B, sumacantidad, sumautilidad As Integer
    Dim sucursal As String
    Dim contador As Integer
    Dim d1, d2, m1, m2, y1, y2 As Integer

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

    Sub SetDBLogonForReport(ByVal myConnectionInfo As ConnectionInfo, ByVal myReportDocument As ReportDocument)
        Dim myTables As Tables = myReportDocument.Database.Tables
        For Each myTable As CrystalDecisions.CrystalReports.Engine.Table In myTables
            Dim myTableLogonInfo As TableLogOnInfo = myTable.LogOnInfo
            myTableLogonInfo.ConnectionInfo = myConnectionInfo
            myTable.ApplyLogOnInfo(myTableLogonInfo)
        Next
    End Sub

    Private Sub UTILIDAD_COMPRA_VS_VENTA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar_Datos()
        B = 0
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
        d1 = FECHA_INICIAL.Day
        m1 = FECHA_INICIAL.Month
        y1 = FECHA_INICIAL.Year

    End Sub

    Private Sub DateTimePicker2_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles DateTimePicker2.Leave

        Dim fecha1, fecha2 As Date
        fecha1 = Me.DateTimePicker2.Value.Date.AddDays(0)
        fecha2 = Me.DateTimePicker2.Value.Date.AddDays(0)
        FECHA_FINAL = fecha1
        FECHA_FINAL_ = fecha2
        dia_fin = FECHA_FINAL.Day
        d2 = FECHA_FINAL.Day
        m2 = FECHA_FINAL.Month
        y2 = FECHA_FINAL.Year
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

    Function Contador_InfUtilidad() As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM INF_CABECERA_UTILIDAD_COMPRA_VENTA"
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
    Function Contador_DetInfUtilidad() As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM INF_UTILIDAD_COMPRA_VENTA"
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
    Function ELIMAR_DATOS_INF() As Integer
        Try
            conectar()
            Dim sel As String
            sel = "DELETE FROM INF_UTILIDAD_COMPRA_VENTA"
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
    Private Sub btnCerrar_Periodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar_Periodo.Click

        'ELIMNAR ANTES DATOS DE TABLA INFORME****
        ELIMAR_DATOS_INF()

        Dim i, j, PrecioCompra As Integer
        Dim FechaCab As Date
        Dim CodigoCab, CodigoDet, CantidadCab As Integer
        Dim ProductoDet As String
        Dim CantidadDet, PrecioVentaDet As Integer
        Dim iva5Det, iva10Det As Integer
        Dim Documento As String
        Dim utilidad As Integer

        For i = 0 To Me.BindingContext(Me.DsCabFactura, "VF_CABECERA_FACTURA").Count - 1
            Me.BindingContext(Me.DsCabFactura, "VF_CABECERA_FACTURA").Position = i

            FechaCab = CDate(Me.DsCabFactura.Tables("VF_CABECERA_FACTURA").Rows(Me.BindingContext(Me.DsCabFactura, "VF_CABECERA_FACTURA").Position).Item("FECHA").ToString)
            CodigoCab = CInt(Me.DsCabFactura.Tables("VF_CABECERA_FACTURA").Rows(Me.BindingContext(Me.DsCabFactura, "VF_CABECERA_FACTURA").Position).Item("COD_FACTURA").ToString)
            Documento = Trim(Me.DsCabFactura.Tables("VF_CABECERA_FACTURA").Rows(Me.BindingContext(Me.DsCabFactura, "VF_CABECERA_FACTURA").Position).Item("NUMERO_FACTURA").ToString)
            CantidadCab = CInt(Me.DsCabFactura.Tables("VF_CABECERA_FACTURA").Rows(Me.BindingContext(Me.DsCabFactura, "VF_CABECERA_FACTURA").Position).Item("TOTAL_ARTICULO").ToString)

            dia = FechaCab.Day
            mes = FechaCab.Month
            año = FechaCab.Year

            If FechaCab >= FECHA_INICIAL And FechaCab <= FECHA_FINAL Then
                If Anulado(Documento) = 0 Then

                    For j = 0 To Me.BindingContext(Me.DsDetFactura, "VF_DETALLE_FACTURA").Count - 1
                        Me.BindingContext(Me.DsDetFactura, "VF_DETALLE_FACTURA").Position = j

                        CodigoDet = Trim(Me.DsDetFactura.Tables("VF_DETALLE_FACTURA").Rows(Me.BindingContext(Me.DsDetFactura, "VF_DETALLE_FACTURA").Position).Item("COD_FACTURA").ToString)

                        If CodigoCab = CodigoDet Then

                            ProductoDet = Trim(Me.DsDetFactura.Tables("VF_DETALLE_FACTURA").Rows(Me.BindingContext(Me.DsDetFactura, "VF_DETALLE_FACTURA").Position).Item("PRODUCTO").ToString)
                            CantidadDet = CInt(Me.DsDetFactura.Tables("VF_DETALLE_FACTURA").Rows(Me.BindingContext(Me.DsDetFactura, "VF_DETALLE_FACTURA").Position).Item("CANTIDAD").ToString)
                            PrecioVentaDet = CInt(Me.DsDetFactura.Tables("VF_DETALLE_FACTURA").Rows(Me.BindingContext(Me.DsDetFactura, "VF_DETALLE_FACTURA").Position).Item("PRECIO_UNI").ToString)
                            iva5Det = CInt(Me.DsDetFactura.Tables("VF_DETALLE_FACTURA").Rows(Me.BindingContext(Me.DsDetFactura, "VF_DETALLE_FACTURA").Position).Item("IVA5").ToString)
                            iva10Det = CInt(Me.DsDetFactura.Tables("VF_DETALLE_FACTURA").Rows(Me.BindingContext(Me.DsDetFactura, "VF_DETALLE_FACTURA").Position).Item("IVA10").ToString)

                            PrecioCompra = paraPrecioCompra(ProductoDet)
                            Dim aux, aux1 As Integer
                            If iva5Det > 0 Then
                                aux = PrecioVentaDet - (PrecioVentaDet / 21)
                                aux1 = (CantidadDet * PrecioCompra) - ((CantidadDet * PrecioCompra) / 21)
                                utilidad = aux - aux1
                            Else
                                If iva10Det > 0 Then
                                    aux = PrecioVentaDet - (PrecioVentaDet / 11)
                                    aux1 = (CantidadDet * PrecioCompra) - ((CantidadDet * PrecioCompra) / 11)
                                    utilidad = aux - aux1
                                Else
                                    aux = PrecioVentaDet
                                    aux1 = (CantidadDet * PrecioCompra)
                                    utilidad = aux - aux1
                                End If
                            End If
                            Try
                                Dim contador As Integer
                                contador = Contador_DetInfUtilidad() + 1
                                SQLconexion.Open()
                                Dim sqlbuilder As New System.Text.StringBuilder
                                With sqlbuilder
                                    .Append("INSERT INTO INF_UTILIDAD_COMPRA_VENTA")
                                    .Append(" VALUES ('")
                                    .Append(contador & "','")
                                    .Append(sucursal & "','")
                                    .Append(FECHA_INICIAL & "','")
                                    .Append(FECHA_FINAL_ & "','")
                                    .Append(dia & "','")
                                    .Append(mes & "','")
                                    .Append(año & "','")
                                    .Append(ProductoDet & "','")
                                    .Append(CantidadDet & "','")
                                    .Append(PrecioCompra & "','")
                                    .Append(PrecioVentaDet & "','")
                                    .Append(utilidad & "')")

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
                        End If
                    Next
                End If
            End If
        Next

        '*******************************************************************************************
        Try
            conectar()
            Dim dt As New DataTable
            Dim da As New SqlDataAdapter("UTILIDAD_COMPRAS_VS_VENTAS", SQLconexion)
            da.SelectCommand.CommandType = CommandType.StoredProcedure
            da.SelectCommand.Parameters.AddWithValue("@D1", d1)
            da.SelectCommand.Parameters.AddWithValue("@D2", d2)
            da.SelectCommand.Parameters.AddWithValue("@M1", m1)
            da.SelectCommand.Parameters.AddWithValue("@M2", m2)
            da.SelectCommand.Parameters.AddWithValue("@Y1", y1)
            da.SelectCommand.Parameters.AddWithValue("@Y2", y2)
            da.Fill(dt)

            Dim ds As New Data.DataSet
            ds.Tables.Add(dt)

            Dim info As New UTILIDAD_COMPRASVSVENTAS

            info.SetDataSource(ds)
            info.SetParameterValue("@D1", d1)
            info.SetParameterValue("@D2", d2)
            info.SetParameterValue("@M1", m1)
            info.SetParameterValue("@M2", m2)
            info.SetParameterValue("@Y1", y1)
            info.SetParameterValue("@Y2", y2)
            SetDBLogonForReport(iconexion, info)
            Me.crw.ReportSource = info

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            SQLconexion.Close()
        End Try

    End Sub

    Function paraPrecioCompra(ByVal a As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT PRECIO_COMPRA FROM TP_PRODUCTO WHERE NOMBRE = '" & a & "'"
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



    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

End Class