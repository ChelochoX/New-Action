Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Data.SqlClient
Imports System
Imports System.IO
Imports System.Diagnostics

Public Class AGREGAR_PRODUCTOS_USADOS

    Dim DaProducto, DaDeposito As New SqlClient.SqlDataAdapter
    Dim DsDeposito As New Data.DataSet
    Dim DEPOSITO, PRODUCTO As String
    Dim COD_PRODUCTO, COD_DEPOSITO As Integer
    Dim CODIGO_PRODUCTO As String


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

    Private Sub AGREGAR_PRODUCTOS_USADOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Cargar_Datos()
        Dim dt As New DataTable("TP_DEPOSITO")
        DaDeposito.Fill(dt)
        SQLconexion.Close()

        With lstDeposito
            .DataSource = dt
            .DisplayMember = "Deposito"
            .ValueMember = "NOMBRE"
        End With
    End Sub

    Private Sub txtBusqueda_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBusqueda.TextChanged
        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM TP_PRODUCTO WHERE NOMBRE LIKE '%" & Trim(Me.txtBusqueda.Text) & "%'"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaProducto = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            Dim dt As New DataTable("TP_PRODUCTO")
            DaProducto.Fill(dt)
            SQLconexion.Close()

            With lstProducto
                .DataSource = dt
                .DisplayMember = "NOMBRE PRODUCTOS"
                .ValueMember = "NOMBRE"
            End With

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub

    Private Sub lstDeposito_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstDeposito.Click
        DEPOSITO = Trim(Me.lstDeposito.Text)
        COD_DEPOSITO = paraCod_(DEPOSITO)
        Me.txtDetalle_deposito.Text = DEPOSITO
        Me.txtDetalle_deposito.Focus()
    End Sub

    Function paraCod_(ByVal a As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COD_DEPOSITO FROM TP_DEPOSITO WHERE NOMBRE = '" & a & "'"
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

    Function contador_stock_() As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM SC_STOCK "
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

    Private Sub btnIngresarMercaderia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngresarMercaderia.Click
        If Me.txtDetalle_deposito.Text = "" Then
            MessageBox.Show("SELECCIONAR DEPOSITO DESTINO", "SGCV_CO V1.0", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtDetalle_deposito.Focus()
        Else
            If Me.txtDetalle_Producto.Text = "" Then
                MessageBox.Show("SELECCIONAR PRODUCTO PARA INGRESAR", "SGCV_CO V1.0", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtDetalle_Producto.Focus()
            Else
                If Me.txtCantidad_aIngresar.Text = "" Then
                    MessageBox.Show("DEFINIR CANTIDAD A INGRESR", "SGCV_CO V1.0", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtCantidad_aIngresar.Focus()
                Else
                    Dim CANTIDAD_USADO, cantidad As Integer
                    CANTIDAD_USADO = Existe_Producto(PRODUCTO)
                    cantidad = CANTIDAD_USADO + CInt(Me.txtCantidad_aIngresar.Text)
                    Dim contador_stock As Integer
                    If CANTIDAD_USADO = 0 Then
                        contador_stock = contador_stock_() + 1
                        Try
                            SQLconexion.Open()
                            Dim sqlbuilder As New System.Text.StringBuilder
                            With sqlbuilder
                                .Append("INSERT INTO SC_STOCK")
                                .Append(" VALUES ('")
                                .Append(CInt(contador_stock) & "','")
                                .Append(CInt(COD_PRODUCTO) & "','")
                                .Append(CInt(COD_DEPOSITO) & "','")
                                .Append(Trim(DEPOSITO) & "','")
                                .Append(Trim(CODIGO_PRODUCTO) & "','")
                                .Append(CStr(PRODUCTO) & "','")
                                .Append(CInt(cantidad) & "')")

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
                        Try
                            Dim sel As String
                            sel = "UPDATE SC_STOCK SET CANTIDAD =" & cantidad & "" & _
                           "WHERE NOMBRE_PRODUCTO ='" & PRODUCTO & "' AND DEPOSITO = '" & DEPOSITO & "'"
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

                    Try
                        Dim dt As New DataTable
                        Dim da As New SqlDataAdapter("LISTAR_STOCK_POR_NOMBRE_USADOS", SQLconexion)
                        da.SelectCommand.CommandType = CommandType.StoredProcedure
                        da.SelectCommand.Parameters.AddWithValue("@DEPOSITO", DEPOSITO)
                        da.SelectCommand.Parameters.AddWithValue("@NOMBRE", PRODUCTO)
                        da.Fill(dt)

                        Dim ds As New Data.DataSet
                        ds.Tables.Add(dt)

                        Dim info As New STOCK_POR_NOMBRE_USADOS

                        info.SetDataSource(ds)
                        info.SetParameterValue("@DEPOSITO", DEPOSITO)
                        info.SetParameterValue("@NOMBRE", PRODUCTO)
                        info.SetDatabaseLogon("clezcano", "Cesar1983")
                        Me.CrystalReportViewer1.ReportSource = info

                    Catch ex As Exception
                        MessageBox.Show(ex.ToString)
                        SQLconexion.Close()
                    End Try

                    Me.txtDetalle_deposito.Clear()
                    Me.txtDetalle_Producto.Clear()
                    Me.txtCantidad_aIngresar.Clear()
                    Me.txtBusqueda.Clear()
                End If
            End If
        End If

    End Sub

    Function Existe_Producto(ByVal a As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COALESCE(SUM(CANTIDAD),0) FROM SC_STOCK WHERE NOMBRE_PRODUCTO = '" & a & "'"
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

    Private Sub lstProducto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstProducto.Click
        PRODUCTO = Trim(Me.lstProducto.Text)
        COD_PRODUCTO = paraCod(PRODUCTO)
        CODIGO_PRODUCTO = paraCodigo(PRODUCTO)
        Me.txtDetalle_Producto.Text = PRODUCTO
    End Sub

    Function paraCod(ByVal a As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COD_PRODUCTO FROM TP_PRODUCTO WHERE NOMBRE = '" & a & "'"
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


    Function paraCodigo(ByVal a As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT CODIGO FROM TP_PRODUCTO WHERE NOMBRE = '" & a & "'"
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

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class