Public Class REGISTRO_COLOR

    Dim contador, codigo As Integer
    Dim DaColor As New SqlClient.SqlDataAdapter
    Dim DsColor As New Data.DataSet

    Function Contador_Color() As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM TP_COLOR"
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

    Public Sub Visualizar_Color()
        Try
            conectar()
            Dim sel As String
            SQLconexion.Open()
            sel = "SELECT * FROM TP_COLOR"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaColor = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsColor = New Data.DataSet
            DaColor.Fill(Me.DsColor, "TP_COLOR")
            'asignar dataset al datagrid
            Me.dg_Color.DataSource = Me.DsColor
            Me.dg_Color.DataMember = "TP_COLOR"

            DaColor.Update(Me.DsColor, "TP_COLOR")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub

    Private Sub REGISTRO_COLOR_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If Contador_Color() = 0 Then
            contador = 1
        Else
            contador = Contador_Color() + 1
        End If

        Visualizar_Color()
        Me.txtcolor.focus()

    End Sub

    Private Sub btnguardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnguardar.Click
        If Me.txtColor.Text = "" Then
            MessageBox.Show("Debe Ingresar un Nombre para el Color", "SGSS STANDAR", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtColor.Focus()
        Else
            Try
                SQLconexion.Open()
                Dim sqlbuilder As New System.Text.StringBuilder
                With sqlbuilder
                    .Append("INSERT INTO TP_COLOR")
                    .Append(" VALUES ('")
                    .Append(contador & "','")
                    .Append(Trim(Me.txtColor.Text) & "')")

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

            'LIMPIAR LOS CAMPOS
            Me.txtColor.Clear()
            Me.txtColor.Focus()

            contador = Contador_Color() + 1

        End If

        Visualizar_Color()

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Try
            Dim sel As String
            sel = "UPDATE TP_COLOR SET NOMBRE ='" & Trim(Me.txtColor.Text) & "' WHERE COD_COLOR =" & codigo & ""
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As Integer = CInt(cmm.ExecuteScalar())
            cmm.Dispose()
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
        End Try

        Visualizar_Color()

          'LIMPIAR LOS CAMPOS
        Me.txtColor.Clear()
        Me.txtColor.Focus()

    End Sub

    Private Sub dg_Color_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg_Color.Click
        codigo = Me.dg_Color.Item(Me.dg_Color.CurrentRowIndex, 0)
        Me.txtColor.Text = Me.dg_Color.Item(Me.dg_Color.CurrentRowIndex, 1)
    End Sub

    Private Sub btnSalir_cargo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir_cargo.Click
        Me.Close()
    End Sub
End Class