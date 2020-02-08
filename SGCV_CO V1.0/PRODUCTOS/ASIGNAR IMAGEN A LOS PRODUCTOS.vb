Imports System.IO

Public Class ASIGNAR_IMAGEN_A_LOS_PRODUCTOS

    Dim DaProducto, DaProducto1 As New SqlClient.SqlDataAdapter
    Dim DsProducto, DsProducto1 As New Data.DataSet
    Dim articulo, articulo_seleccionado As String


    Sub Cargar_Datos()
        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM TP_PRODUCTO"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaProducto = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsProducto = New Data.DataSet
            DaProducto.Fill(Me.DsProducto, "TP_PRODUCTO")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM TP_PRODUCTO"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaProducto1 = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsProducto1 = New Data.DataSet
            DaProducto1.Fill(Me.DsProducto1, "TP_PRODUCTO")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

    End Sub
    Private Sub ASIGNAR_IMAGEN_A_LOS_PRODUCTOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Cargar_Datos()
        Dim rutaimagen As String = "C:\FOTOS PRODUCTOS\NEW ACTION.png"
        Me.PictureBox1.Image = Image.FromFile(rutaimagen)
    End Sub

    Private Sub txtBuscar_Producto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar_Producto.TextChanged
        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM TP_PRODUCTO WHERE NOMBRE LIKE '%" & Trim(Me.txtBuscar_Producto.Text) & "%'"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaProducto = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            Dim dt As New DataTable("TP_PRODUCTO")
            DaProducto.Fill(dt)
            SQLconexion.Close()

            With lstCodigo
                .DataSource = dt
                .DisplayMember = "NOMBRE PRODUCTOS"
                .ValueMember = "CODIGO"
            End With

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

        Try
            conectar()
            SQLconexion.Open()
            Dim sele As String
            sele = "SELECT * FROM TP_PRODUCTO WHERE NOMBRE LIKE '%" & Trim(Me.txtBuscar_Producto.Text) & "%'"
            cmm = New SqlClient.SqlCommand(sele, SQLconexion)
            'crear adapter
            DaProducto1 = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            Dim dt1 As New DataTable("TP_PRODUCTO")
            DaProducto1.Fill(dt1)
            SQLconexion.Close()

            With lstNombre
                .DataSource = dt1
                .DisplayMember = "NOMBRE PRODUCTOS"
                .ValueMember = "NOMBRE"
            End With

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub

    Private Sub lstCodigo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstCodigo.Click
        Dim SELECCIONADO_PROD_, DESCRIP_PROD_ As String
        articulo = Me.lstCodigo.Text
        SELECCIONADO_PROD_ = Seleccionar_ProductoSeleccionado(articulo)
        DESCRIP_PROD_ = Seleccionar_DescripProducto(articulo)

        Me.txtProducto_Seleccionado.Text = Trim(SELECCIONADO_PROD_)
        Me.txtDescripcion_Producto.Text = Trim(DESCRIP_PROD_)

        Dim paraFoto As String
        paraFoto = articulo
        Try
            Dim ubicacion As String = "C:\FOTOS PRODUCTOS\"
            Me.PictureBox1.Image = Image.FromFile(ubicacion & paraFoto & ".jpg")
        Catch ex As Exception
            '  Console.WriteLine(ex.Message)
        End Try

    End Sub

    Function Seleccionar_ProductoSeleccionado(ByVal a As String) As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT NOMBRE FROM TP_PRODUCTO WHERE CODIGO = '" & a & "'"
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

    Function Seleccionar_DescripProducto(ByVal a As String) As String
        Try
            conectar()
            Dim sel As String
            sel = "SELECT DESCRIPCION FROM TP_PRODUCTO WHERE CODIGO = '" & a & "'"
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

    Private Sub btnSeleccionar_Imagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar_Imagen.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.ToString
        OpenFileDialog.Filter = "Todos los archivos (*.*)|*.*"
        OpenFileDialog.Multiselect = True
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Try
                articulo_seleccionado = Path.GetFullPath(OpenFileDialog.FileName)
                Me.PictureBox1.Image = Image.FromFile(Path.GetFullPath(OpenFileDialog.FileName))

            Catch ex As Exception
                ' Console.WriteLine(ex.Message)
            End Try
        End If
        'bandera_foto = 1
    End Sub

    Private Sub btnAplicar_Imagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAplicar_Imagen.Click
        Try
            Dim ubicacion2 As String = "C:\FOTOS PRODUCTOS\"
            Dim NuevoNomobre As String
            'If ubicacion2 <> "" Then
            NuevoNomobre = articulo
            If File.Exists(ubicacion2) Then
                NuevoNomobre = InputBox("NOMBRE YA EXISTE,CAMBIAR EL NOMBRE",
                        "SGSS STANDAR")
                My.Computer.FileSystem.CopyFile(articulo_seleccionado, ubicacion2 & NuevoNomobre & ".jpg", FileIO.UIOption.AllDialogs,
                FileIO.UICancelOption.ThrowException)
            Else
                My.Computer.FileSystem.CopyFile(articulo_seleccionado, ubicacion2 & NuevoNomobre & ".jpg", FileIO.UIOption.AllDialogs,
                    FileIO.UICancelOption.ThrowException)
            End If
            'End If

        Catch ex As Exception
            'MsgBox(ex.Message())
            'SQLconexion.Close()
        End Try
        '***********************************************************************
        Dim rutaimagen As String = "C:\FOTOS PRODUCTOS\NEW ACTION.png"
        Me.PictureBox1.Image = Image.FromFile(rutaimagen)

    End Sub

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub txtBuscar_porCodigo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar_porCodigo.TextChanged
        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM TP_PRODUCTO WHERE CODIGO LIKE '%" & Trim(Me.txtBuscar_porCodigo.Text) & "%'"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaProducto = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            Dim dt As New DataTable("TP_PRODUCTO")
            DaProducto.Fill(dt)
            SQLconexion.Close()

            With lstCodigo
                .DataSource = dt
                .DisplayMember = "NOMBRE PRODUCTOS"
                .ValueMember = "CODIGO"
            End With

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

        Try
            conectar()
            SQLconexion.Open()
            Dim sele As String
            sele = "SELECT * FROM TP_PRODUCTO WHERE CODIGO LIKE '%" & Trim(Me.txtBuscar_porCodigo.Text) & "%'"
            cmm = New SqlClient.SqlCommand(sele, SQLconexion)
            'crear adapter
            DaProducto1 = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            Dim dt1 As New DataTable("TP_PRODUCTO")
            DaProducto1.Fill(dt1)
            SQLconexion.Close()

            With lstNombre
                .DataSource = dt1
                .DisplayMember = "NOMBRE PRODUCTOS"
                .ValueMember = "NOMBRE"
            End With

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub

    Private Sub txtBuscar_porDescripcion_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBuscar_porDescripcion.TextChanged
        Try
            conectar()
            SQLconexion.Open()
            Dim sel As String
            sel = "SELECT * FROM TP_PRODUCTO WHERE DESCRIPCION LIKE '%" & Trim(Me.txtBuscar_porDescripcion.Text) & "%'"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaProducto = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            Dim dt As New DataTable("TP_PRODUCTO")
            DaProducto.Fill(dt)
            SQLconexion.Close()

            With lstCodigo
                .DataSource = dt
                .DisplayMember = "NOMBRE PRODUCTOS"
                .ValueMember = "CODIGO"
            End With

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

        Try
            conectar()
            SQLconexion.Open()
            Dim sele As String
            sele = "SELECT * FROM TP_PRODUCTO WHERE DESCRIPCION LIKE '%" & Trim(Me.txtBuscar_porDescripcion.Text) & "%'"
            cmm = New SqlClient.SqlCommand(sele, SQLconexion)
            'crear adapter
            DaProducto1 = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            Dim dt1 As New DataTable("TP_PRODUCTO")
            DaProducto1.Fill(dt1)
            SQLconexion.Close()

            With lstNombre
                .DataSource = dt1
                .DisplayMember = "NOMBRE PRODUCTOS"
                .ValueMember = "NOMBRE"
            End With

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub
End Class