Imports System.Text

Public Class REGISTRO_PRODUCTOS

    Dim contador, codigo, b As Integer
    Dim DaProducto, DaCategoria, DaCategoria_ As New SqlClient.SqlDataAdapter
    Dim DsProducto, DsCategoria, DsCategoria_ As New Data.DataSet
    Dim unid_medida, categoria_, categoria_desc As String

    '*** CONTADOR DE REGISTROS CLIENTE****
    Function Contador_Producto() As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COD_PRODUCTO FROM TP_PRODUCTO ORDER BY COD_PRODUCTO DESC"
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

    Sub Cargar_Datos()
        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM UNID_MEDIDA"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaCategoria = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsCategoria = New Data.DataSet
            DaCategoria.Fill(Me.DsCategoria, "UNID_MEDIDA")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM TP_CATEGORIA_"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaCategoria_ = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsCategoria_ = New Data.DataSet
            DaCategoria_.Fill(Me.DsCategoria_, "TP_CATEGORIA_")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

    End Sub

    Sub Visualizar_Producto()
        Try
            conectar()
            Dim sel As String
            SQLconexion.Open()
            sel = "SELECT * FROM TP_PRODUCTO"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaProducto = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsProducto = New Data.DataSet
            DaProducto.Fill(Me.DsProducto, "TP_PRODUCTO")
            'asignar dataset al datagrid
            Me.dg_Producto.DataSource = Me.DsProducto
            Me.dg_Producto.DataMember = "TP_PRODUCTO"

            Me.DaProducto.Update(Me.DsProducto, "TP_PRODUCTO")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub

    Private Function CrearPassword(ByVal longitud As Integer) As String
        Dim caracteres As String = "1234567890"
        Dim res As New StringBuilder()
        Dim rnd As New Random()
        While 0 < System.Math.Max(System.Threading.Interlocked.Decrement(longitud), longitud + 1)
            res.Append(caracteres(rnd.[Next](caracteres.Length)))
        End While
        Return res.ToString()
    End Function

    Private Sub REGISTRO_PRODUCTOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        b = 0
        Cargar_Datos()

        Visualizar_Producto()

        Me.cbUnidad_Medida.DataSource = Me.DsCategoria.Tables("UNID_MEDIDA")
        Me.cbUnidad_Medida.DisplayMember = "NOMBRE"

        Me.cbCategoria.DataSource = Me.DsCategoria_.Tables("TP_CATEGORIA_")
        Me.cbCategoria.DisplayMember = "NOMBRE"

        Me.txtCodigo.Clear()
        Me.txtNombre.Clear()

        Me.txtCodigo.Focus()

    End Sub

    Function CodigoProd(ByVal a As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM TP_PRODUCTO WHERE CODIGO = '" & a & "'"
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

    Function NombreProd(ByVal a As String) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM TP_PRODUCTO WHERE NOMBRE = '" & a & "'"
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

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        If Me.txtCodigo.Text = "" Then
            MessageBox.Show("Debe ingresar codigo; ""En el Campo Codigo"" ", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtNombre.Focus()
        Else
            If Me.txtPrecio_Compra.Text = "" Then
                MessageBox.Show("Debe ingresar algun monto; ""En el Campo Precio Compra"" ", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtPrecio_Compra.Focus()
            Else
                If Me.txtNombre.Text = "" Then
                    MessageBox.Show("Debe ingresar algun nombre; ""En el Campo Nombre"" ", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtNombre.Focus()
                Else
                    If b = 0 Then
                        MessageBox.Show("Debe seleccionar Categoria ", "SGCV_CO V1.0", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.cbUnidad_Medida.Focus()
                    Else
                        Dim AUX As Integer = CodigoProd(Trim(Me.txtCodigo.Text))
                        Dim AUX1 As Integer = NombreProd(Trim(Me.txtNombre.Text))
                        If AUX = 1 Then
                            MessageBox.Show("Producto ya Existe no se puede duplicar"" ", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.txtCodigo.Focus()
                        Else
                            If AUX1 = 1 Then
                                MessageBox.Show("Producto ya Existe no se puede duplicar"" ", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Me.txtNombre.Focus()
                            Else
                                If Me.chkProducto_Usado.Checked = False Then
                                    'CONTADOR REGISTRO
                                    Dim AUX_CONTADOR As Integer
                                    AUX_CONTADOR = Contador_Producto()
                                    contador = AUX_CONTADOR + 1
                                    Try
                                        SQLconexion.Open()
                                        Dim sqlbuilder As New System.Text.StringBuilder
                                        With sqlbuilder
                                            .Append("INSERT INTO TP_PRODUCTO")
                                            .Append(" VALUES ('")
                                            .Append(CInt(contador) & "','")
                                            .Append(Trim(Me.txtCodigo.Text) & "','")
                                            .Append(Trim(Me.txtNombre.Text) & "','")
                                            .Append(Trim(Me.txtDescipcion_prod.Text) & "','")
                                            .Append(Trim(unid_medida) & "','")
                                            .Append(Trim(categoria_) & "','")
                                            .Append(CInt(Me.txtPrecio_Compra.Text) & "','")
                                            .Append(Trim(0) & "','")
                                            .Append(Trim(0) & "','")
                                            .Append(Trim("10") & "','")
                                            .Append(Trim("") & "','")
                                            .Append(CInt(0) & "')")
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
                                    If Me.chkProducto_Usado.Checked = True Then

                                        'ACTUALIZAR CANTIDAD ID.REGISTROS***************************
                                        contador = Contador_Producto() + 1
                                        Try
                                            SQLconexion.Open()
                                            Dim sqlbuilder As New System.Text.StringBuilder
                                            With sqlbuilder
                                                .Append("INSERT INTO TP_PRODUCTO")
                                                .Append(" VALUES ('")
                                                .Append(CInt(contador) & "','")
                                                .Append(Trim(Me.txtCodigo.Text) & "','")
                                                .Append(Trim(Me.txtNombre.Text) & "','")
                                                .Append(Trim(Me.txtDescipcion_prod.Text) & "','")
                                                .Append(Trim(unid_medida) & "','")
                                                .Append(Trim(categoria_) & "','")
                                                .Append(CInt(Me.txtPrecio_Compra.Text) & "','")
                                                .Append(Trim(0) & "','")
                                                .Append(Trim(0) & "','")
                                                .Append(Trim("0") & "','")
                                                .Append(Trim("") & "','")
                                                .Append(CInt(0) & "')")
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
                                End If

                                b = 0
                                Me.txtCodigo.Clear()
                                Me.txtNombre.Clear()
                                Me.txtCodigo.Focus()
                                Me.txtDescipcion_prod.Clear()
                                Me.txtPrecio_Compra.Clear()
                                Me.chkProducto_Usado.Checked = False

                            End If
                        End If
                    End If
                End If
            End If
        End If

        Visualizar_Producto()
    End Sub

    Private Sub cbCategoria_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cbUnidad_Medida.Click
        b = 1
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        If Me.txtPrecio_Compra.Text = "" Then
            MessageBox.Show("Precio Compra no puede ser nulo", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtPrecio_Compra.Focus()
        Else
            If Me.txtPrecio_Compra.Text = CStr(0) Then
                MessageBox.Show("Precio Compra no puede ser cero", "SGCV_CO VERSION EXTENDIDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtPrecio_Compra.Focus()
            Else
                Try
                    Dim sel As String
                    sel = "UPDATE TP_PRODUCTO SET CODIGO = '" & Trim(Me.txtCodigo.Text) & "',NOMBRE= '" & Trim(Me.txtNombre.Text) & "'" & _
                    ",UNI_MEDIDA = '" & Trim(unid_medida) & "',PRECIO_COMPRA = " & CInt(Me.txtPrecio_Compra.Text) & "" & _
                     ",DESCRIPCION = '" & Trim(Me.txtDescipcion_prod.Text) & "',CATEGORIA = '" & Trim(categoria_) & "'" & _
                    "WHERE COD_PRODUCTO = " & codigo & " "
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

        Me.txtCodigo.Clear()
        Me.txtNombre.Clear()
        Me.txtDescipcion_prod.Clear()
        Me.txtPrecio_Compra.Clear()
        Me.txtCodigo.Focus()
        Visualizar_Producto()
    End Sub

    Private Sub dg_Producto_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg_Producto.Click
        Me.txtCodigo.Text = Trim(Me.dg_Producto.Item(Me.dg_Producto.CurrentRowIndex, 0))
        Me.txtNombre.Text = Trim(Me.dg_Producto.Item(Me.dg_Producto.CurrentRowIndex, 1))
        Me.txtDescipcion_prod.Text = Trim(Me.dg_Producto.Item(Me.dg_Producto.CurrentRowIndex, 2))
        unid_medida = Trim(Me.dg_Producto.Item(Me.dg_Producto.CurrentRowIndex, 3))
        categoria_desc = Trim(Me.dg_Producto.Item(Me.dg_Producto.CurrentRowIndex, 7))
        Me.txtPrecio_Compra.Text = Puntos(Trim(Me.dg_Producto.Item(Me.dg_Producto.CurrentRowIndex, 4)))
        codigo = Me.dg_Producto.Item(Me.dg_Producto.CurrentRowIndex, 6)
    End Sub

    Private Sub txtLimpiar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLimpiar.Click
        b = 0
        Me.txtCodigo.Clear()
        Me.txtNombre.Clear()
        Me.txtDescipcion_prod.Clear()
        Me.txtPrecio_Compra.Clear()
        Me.txtCodigo.Focus()
     
    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub btnGenerar_Codigo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerar_Codigo.Click
        txtCodigo.Text = CrearPassword(5)
        Me.txtNombre.Focus()
    End Sub


    Private Sub chkProducto_Usado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkProducto_Usado.CheckedChanged
        If Me.chkProducto_Usado.Checked = True Then
            Dim NOMBRE_USADO As String
            NOMBRE_USADO = Me.txtNombre.Text & "-" & "USADO"
            Me.txtNombre.Text = NOMBRE_USADO
            Me.txtNombre.Update()
        Else
            If Me.chkProducto_Usado.Checked = False Then
            End If
        End If
    End Sub

    Private Sub cbUnidad_Medida_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbUnidad_Medida.SelectedIndexChanged
        unid_medida = CStr(Me.DsCategoria.Tables("UNID_MEDIDA").Rows(Me.cbUnidad_Medida.SelectedIndex).Item(1).ToString)
    End Sub

    Private Sub cbCategoria_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbCategoria.SelectedIndexChanged
        categoria_ = CStr(Me.DsCategoria_.Tables("TP_CATEGORIA_").Rows(Me.cbCategoria.SelectedIndex).Item(1).ToString)
    End Sub

    Private Sub txtBuscarCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarCodigo.TextChanged
        Try
            conectar()
            Dim sel As String
            SQLconexion.Open()
            sel = "SELECT * FROM TP_PRODUCTO WHERE CODIGO LIKE '%" & Trim(Me.txtBuscarCodigo.Text) & "%'"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaProducto = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsProducto = New Data.DataSet
            DaProducto.Fill(Me.DsProducto, "TP_PRODUCTO")
            'asignar dataset al datagrid
            Me.dg_Producto.DataSource = Me.DsProducto
            Me.dg_Producto.DataMember = "TP_PRODUCTO"

            Me.DaProducto.Update(Me.DsProducto, "TP_PRODUCTO")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub

    Private Sub txtBuscarNombre_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscarNombre.TextChanged
        Try
            conectar()
            Dim sel As String
            SQLconexion.Open()
            sel = "SELECT * FROM TP_PRODUCTO WHERE NOMBRE LIKE '%" & Trim(Me.txtBuscarNombre.Text) & "%'"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaProducto = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsProducto = New Data.DataSet
            DaProducto.Fill(Me.DsProducto, "TP_PRODUCTO")
            'asignar dataset al datagrid
            Me.dg_Producto.DataSource = Me.DsProducto
            Me.dg_Producto.DataMember = "TP_PRODUCTO"

            Me.DaProducto.Update(Me.DsProducto, "TP_PRODUCTO")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub
End Class