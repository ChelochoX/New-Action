Public Class GESTIONAR_INTERES_PARA_CREDITO

    Dim DaInteres As New SqlClient.SqlDataAdapter
    Dim DsInteres As New Data.DataSet


    Public Sub Visualizar_Interes()
        Try
            conectar()
            Dim sel As String
            SQLconexion.Open()
            sel = "SELECT * FROM TP_PRODUCTO_INTERES_PORCUOTA"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaInteres = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsInteres = New Data.DataSet
            DaInteres.Fill(Me.DsInteres, "TP_PRODUCTO_INTERES_PORCUOTA")
            'asignar dataset al datagrid
            Me.dg_interes.DataSource = Me.DsInteres
            Me.dg_interes.DataMember = "TP_PRODUCTO_INTERES_PORCUOTA"

            DaInteres.Update(Me.DsInteres, "TP_PRODUCTO_INTERES_PORCUOTA")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub

    Private Sub GESTIONAR_INTERES_PARA_CREDITO_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Visualizar_Interes()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        Dim i, valor_cuota As Integer
        For I = 1 To 20

            If I = 1 Then
                valor_cuota = CInt(Me.txtCuota1.Text)
            Else
                If I = 2 Then
                    valor_cuota = CInt(Me.txtCuota2.Text)
                Else
                    If I = 3 Then
                        valor_cuota = CInt(Me.txtCuota3.Text)
                    Else
                        If I = 4 Then
                            valor_cuota = CInt(Me.txtCuota4.Text)
                        Else
                            If I = 5 Then
                                valor_cuota = CInt(Me.txtCuota5.Text)
                            Else
                                If I = 6 Then
                                    valor_cuota = CInt(Me.txtCuota6.Text)
                                Else
                                    If I = 7 Then
                                        valor_cuota = CInt(Me.txtCuota7.Text)
                                    Else
                                        If I = 8 Then
                                            valor_cuota = CInt(Me.txtCuota8.Text)
                                        Else
                                            If I = 9 Then
                                                valor_cuota = CInt(Me.txtCuota9.Text)
                                            Else
                                                If I = 10 Then
                                                    valor_cuota = CInt(Me.txtCuota10.Text)
                                                Else
                                                    If I = 11 Then
                                                        valor_cuota = CInt(Me.txtCuota11.Text)
                                                    Else
                                                        If I = 12 Then
                                                            valor_cuota = CInt(Me.txtCuota12.Text)
                                                        Else
                                                            If I = 13 Then
                                                                valor_cuota = CInt(Me.txtCuota13.Text)
                                                            Else
                                                                If I = 14 Then
                                                                    valor_cuota = CInt(Me.txtCuota14.Text)
                                                                Else
                                                                    If I = 15 Then
                                                                        valor_cuota = CInt(Me.txtCuota15.Text)
                                                                    Else
                                                                        If I = 16 Then
                                                                            valor_cuota = CInt(Me.txtCuota16.Text)
                                                                        Else
                                                                            If I = 17 Then
                                                                                valor_cuota = CInt(Me.txtCuota17.Text)
                                                                            Else
                                                                                If I = 18 Then
                                                                                    valor_cuota = CInt(Me.txtCuota18.Text)
                                                                                Else
                                                                                    If I = 19 Then
                                                                                        valor_cuota = CInt(Me.txtCuota19.Text)
                                                                                    Else
                                                                                        If I = 20 Then
                                                                                            valor_cuota = CInt(Me.txtCuota20.Text)
                                                                                        End If
                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If

            Try
                Dim sel As String
                sel = "UPDATE TP_PRODUCTO_INTERES_PORCUOTA SET PORCENTAJE =" & valor_cuota & " " & _
               "WHERE CUOTA =" & i & ""
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

        'LIMPIAR LOS CAMPOS
        Me.txtCuota1.Clear()
        Me.txtCuota2.Clear()
        Me.txtCuota3.Clear()
        Me.txtCuota4.Clear()
        Me.txtCuota5.Clear()
        Me.txtCuota6.Clear()
        Me.txtCuota7.Clear()
        Me.txtCuota8.Clear()
        Me.txtCuota9.Clear()
        Me.txtCuota10.Clear()
        Me.txtCuota11.Clear()
        Me.txtCuota12.Clear()
        Me.txtCuota13.Clear()
        Me.txtCuota14.Clear()
        Me.txtCuota15.Clear()
        Me.txtCuota16.Clear()
        Me.txtCuota17.Clear()
        Me.txtCuota18.Clear()
        Me.txtCuota19.Clear()
        Me.txtCuota20.Clear()
        Me.txtCuota21.Clear()
        Me.txtCuota22.Clear()
        Me.txtCuota23.Clear()
        Me.txtCuota24.Clear()

        Visualizar_Interes()
    End Sub

    Function Recuperar_Datos(ByVal a As Integer) As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT PORCENTAJE FROM TP_PRODUCTO_INTERES_PORCUOTA  WHERE CUOTA = " & a & ""
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

    Private Sub txtLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLimpiar.Click
        'LIMPIAR LOS CAMPOS
        Me.txtCuota1.Clear()
        Me.txtCuota2.Clear()
        Me.txtCuota3.Clear()
        Me.txtCuota4.Clear()
        Me.txtCuota5.Clear()
        Me.txtCuota6.Clear()
        Me.txtCuota7.Clear()
        Me.txtCuota8.Clear()
        Me.txtCuota9.Clear()
        Me.txtCuota10.Clear()
        Me.txtCuota11.Clear()
        Me.txtCuota12.Clear()
        Me.txtCuota13.Clear()
        Me.txtCuota14.Clear()
        Me.txtCuota15.Clear()
        Me.txtCuota16.Clear()
        Me.txtCuota17.Clear()
        Me.txtCuota18.Clear()
        Me.txtCuota19.Clear()
        Me.txtCuota20.Clear()
        Me.txtCuota21.Clear()
        Me.txtCuota22.Clear()
        Me.txtCuota23.Clear()
        Me.txtCuota24.Clear()

        Visualizar_Interes()
    End Sub

    Private Sub btnSalir_cargo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir_cargo.Click
        Me.Close()

    End Sub

    Private Sub btnRecuperar_Datos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRecuperar_Datos.Click

        Dim i As Integer
        For i = 1 To 20

            If i = 1 Then
                Me.txtCuota1.Text = Recuperar_Datos(i)
            Else
                If i = 2 Then
                    Me.txtCuota2.Text = Recuperar_Datos(i)
                Else
                    If i = 3 Then
                        Me.txtCuota3.Text = Recuperar_Datos(i)
                    Else
                        If i = 4 Then
                            Me.txtCuota4.Text = Recuperar_Datos(i)
                        Else
                            If i = 5 Then
                                Me.txtCuota5.Text = Recuperar_Datos(i)
                            Else
                                If i = 6 Then
                                    Me.txtCuota6.Text = Recuperar_Datos(i)
                                Else
                                    If i = 7 Then
                                        Me.txtCuota7.Text = Recuperar_Datos(i)
                                    Else
                                        If i = 8 Then
                                            Me.txtCuota8.Text = Recuperar_Datos(i)
                                        Else
                                            If i = 9 Then
                                                Me.txtCuota9.Text = Recuperar_Datos(i)
                                            Else
                                                If i = 10 Then
                                                    Me.txtCuota10.Text = Recuperar_Datos(i)
                                                Else
                                                    If i = 11 Then
                                                        Me.txtCuota11.Text = Recuperar_Datos(i)
                                                    Else
                                                        If i = 12 Then
                                                            Me.txtCuota12.Text = Recuperar_Datos(i)
                                                        Else
                                                            If i = 13 Then
                                                                Me.txtCuota13.Text = Recuperar_Datos(i)
                                                            Else
                                                                If i = 14 Then
                                                                    Me.txtCuota14.Text = Recuperar_Datos(i)
                                                                Else
                                                                    If i = 15 Then
                                                                        Me.txtCuota15.Text = Recuperar_Datos(i)
                                                                    Else
                                                                        If i = 16 Then
                                                                            Me.txtCuota16.Text = Recuperar_Datos(i)
                                                                        Else
                                                                            If i = 17 Then
                                                                                Me.txtCuota17.Text = Recuperar_Datos(i)
                                                                            Else
                                                                                If i = 18 Then
                                                                                    Me.txtCuota18.Text = Recuperar_Datos(i)
                                                                                Else
                                                                                    If i = 19 Then
                                                                                        Me.txtCuota19.Text = Recuperar_Datos(i)
                                                                                    Else
                                                                                        If i = 20 Then
                                                                                            Me.txtCuota20.Text = Recuperar_Datos(i)
                                                                                        End If
                                                                                    End If
                                                                                End If
                                                                            End If
                                                                        End If
                                                                    End If
                                                                End If
                                                            End If
                                                        End If
                                                    End If
                                                End If
                                            End If
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        Next

    End Sub
End Class