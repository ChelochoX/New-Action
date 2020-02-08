Public Class VER_PRODUCTOS_EN_STOCK

    Dim DaStock, DaStock1, DaDeposito As New SqlClient.SqlDataAdapter
    Dim DsStock, DsStock1, DsDeposito As New Data.DataSet
    Dim deposito, articulo As String


    Function Deposito_Afectado(ByVal a As Integer) As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT NOMBRE FROM TP_DEPOSITO WHERE COD_DEPOSITO = " & a & ""
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

    Private Sub VER_PRODUCTOS_EN_STOCK_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.txtDepositoAfectado.Text = Trim(Deposito_Afectado(1))
        deposito = Trim(Me.txtDepositoAfectado.Text)

    End Sub

    Private Sub txtBuscar_Producto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar_Producto.TextChanged
        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM SC_STOCK WHERE NOMBRE_PRODUCTO LIKE '%" & Trim(Me.txtBuscar_Producto.Text) & "%'"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaStock = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            Dim dt As New DataTable("SC_STOCK")
            DaStock.Fill(dt)
            SQLconexion.Close()

            With lstProducto
                .DataSource = dt
                .DisplayMember = "NOMBRE PRODUCTOS"
                .ValueMember = "NOMBRE_PRODUCTO"
            End With

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub


    Private Sub lstProducto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstProducto.Click

        articulo = Trim(Me.lstProducto.Text)

        Try
            conectar()
            Dim sel As String
            SQLconexion.Open()
            sel = "SELECT * FROM SC_STOCK WHERE DEPOSITO LIKE '" & deposito & "' AND NOMBRE_PRODUCTO LIKE '" & articulo & "'"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaStock1 = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsStock1 = New Data.DataSet
            DaStock1.Fill(Me.DsStock1, "SC_STOCK")
            'asignar dataset al datagrid
            Me.dg_Stock.DataSource = Me.DsStock1
            Me.dg_Stock.DataMember = "SC_STOCK"

            DaStock1.Update(Me.DsStock1, "SC_STOCK")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
        End Try

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    Private Sub txtBuscar_porCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar_porCodigo.TextChanged
        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM SC_STOCK WHERE CODIGO_PRODUCTO LIKE '%" & Trim(Me.txtBuscar_porCodigo.Text) & "%'"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaStock = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            Dim dt As New DataTable("SC_STOCK")
            DaStock.Fill(dt)
            SQLconexion.Close()

            With lstProducto
                .DataSource = dt
                .DisplayMember = "NOMBRE PRODUCTOS"
                .ValueMember = "NOMBRE_PRODUCTO"
            End With

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub

    Private Sub txtBuscarporDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub txtLimpiarBusqueda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLimpiarBusqueda.Click
        Me.txtBuscar_porCodigo.Clear()
        Me.txtBuscar_Producto.Clear()
        Me.lstProducto.ClearSelected()
        Try
            conectar()
            Dim sel As String
            SQLconexion.Open()
            sel = "SELECT * FROM SC_STOCK WHERE DEPOSITO LIKE '" & "LOLO" & "' AND NOMBRE_PRODUCTO LIKE '" & articulo & "'"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaStock1 = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsStock1 = New Data.DataSet
            DaStock1.Fill(Me.DsStock1, "SC_STOCK")
            'asignar dataset al datagrid
            Me.dg_Stock.DataSource = Me.DsStock1
            Me.dg_Stock.DataMember = "SC_STOCK"

            DaStock1.Update(Me.DsStock1, "SC_STOCK")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
        End Try

    End Sub
End Class