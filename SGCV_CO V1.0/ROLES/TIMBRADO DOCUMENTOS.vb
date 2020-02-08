Public Class TIMBRADO_DOCUMENTOS

    Dim DaDocumento As New SqlClient.SqlDataAdapter
    Dim DsDocumento As New Data.DataSet
    Dim codigo, contador As Integer

    Private Sub TIMBRADO_DOCUMENTOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Visualizar_Documentos()
    End Sub

    Public Sub Visualizar_Documentos()
        Try
            conectar()
            Dim sel As String
            SQLconexion.Open()
            sel = "SELECT * FROM TP_DOCUMENTOS"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            'crear adapter
            DaDocumento = New SqlClient.SqlDataAdapter(cmm)
            'crear dataset
            DsDocumento = New Data.DataSet
            DaDocumento.Fill(Me.DsDocumento, "TP_DOCUMENTOS")
            'asignar dataset al datagrid
            Me.dg_documentos.DataSource = Me.DsDocumento
            Me.dg_documentos.DataMember = "TP_DOCUMENTOS"

            DaDocumento.Update(Me.DsDocumento, "TP_DOCUMENTOS")
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try
    End Sub

    Private Sub dg_documentos_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dg_documentos.Click
        Me.txtTipoDoc.Text = Me.dg_documentos.Item(Me.dg_documentos.CurrentRowIndex, 0)
        Me.txtTimbrado.Text = Me.dg_documentos.Item(Me.dg_documentos.CurrentRowIndex, 1)
        Me.txtRango1.Text = Me.dg_documentos.Item(Me.dg_documentos.CurrentRowIndex, 2)
        Me.txtRango2.Text = Me.dg_documentos.Item(Me.dg_documentos.CurrentRowIndex, 3)
        Me.txtSecuen_Final_Ticket.Text = Me.dg_documentos.Item(Me.dg_documentos.CurrentRowIndex, 4)
        Me.txtSecuencia_Final_Factura.Text = Me.dg_documentos.Item(Me.dg_documentos.CurrentRowIndex, 5)
        Me.txtPeriodo_Validez.Text = Me.dg_documentos.Item(Me.dg_documentos.CurrentRowIndex, 6)
        Me.txtRUC.Text = Me.dg_documentos.Item(Me.dg_documentos.CurrentRowIndex, 7)
        Me.txtEstado_Doc.Text = Me.dg_documentos.Item(Me.dg_documentos.CurrentRowIndex, 8)
        codigo = Me.dg_documentos.Item(Me.dg_documentos.CurrentRowIndex, 9)
    End Sub

    Function Contador_Doc() As Integer
        Try
            conectar()
            Dim sel As String
            sel = "SELECT COUNT(*) FROM TP_DOCUMENTOS"
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
        If Me.txtTipoDoc.Text = "" Then
            MessageBox.Show("INGRESAR TIPO DE DOCUMENTO", "SGCV_CO V2", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.txtTipoDoc.Focus()
        Else
            If Me.txtTimbrado.Text = "" Then
                MessageBox.Show("INGRESAR TIMBRADO", "SGCV_CO V2", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.txtTimbrado.Focus()
            Else
                If Me.txtRango1.Text = "" Then
                    MessageBox.Show("INGRESAR RANGO 1", "SGCV_CO V2", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.txtRango1.Focus()
                Else
                    If Me.txtRango2.Text = "" Then
                        MessageBox.Show("INGRESAR RANGO 2", "SGCV_CO V2", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.txtRango2.Focus()
                    Else
                        If Me.txtSecuen_Final_Ticket.Text = "" Then
                            MessageBox.Show("INGRESAR SECUENCIA FINAL PARA TICKET", "SGCV_CO V2", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            Me.txtSecuen_Final_Ticket.Focus()
                        Else
                            If Me.txtSecuencia_Final_Factura.Text = "" Then
                                MessageBox.Show("INGRESAR SECUENCIA FINAL PARA FACTURA", "SGCV_CO V2", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                Me.txtSecuencia_Final_Factura.Focus()
                            Else
                                If Me.txtPeriodo_Validez.Text = "" Then
                                    MessageBox.Show("INGRESAR PERIODO DE VALIDEZ", "SGCV_CO V2", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                    Me.txtPeriodo_Validez.Focus()
                                Else
                                    If Me.txtRUC.Text = "" Then
                                        MessageBox.Show("INGRESAR RUC DEL PROPIETARIO", "SGCV_CO V2", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                        Me.txtRUC.Focus()
                                    Else
                                        If Me.txtEstado_Doc.Text = "" Then
                                            MessageBox.Show("INGRESAR ESTADO DE DOCUMENTO", "SGCV_CO V2", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                            Me.txtEstado_Doc.Focus()
                                        Else
                                            If Contador_Doc() = 0 Then
                                                contador = 1
                                            Else
                                                contador = Contador_Doc() + 1
                                            End If

                                            Try
                                                SQLconexion.Open()
                                                Dim sqlbuilder As New System.Text.StringBuilder
                                                With sqlbuilder
                                                    .Append("INSERT INTO TP_DOCUMENTOS")
                                                    .Append(" VALUES ('")
                                                    .Append(contador & "','")
                                                    .Append(CStr(Me.txtTipoDoc.Text) & "','")
                                                    .Append(CInt(Me.txtTimbrado.Text) & "','")
                                                    .Append(CStr(Me.txtRango1.Text) & "','")
                                                    .Append(CStr(Me.txtRango2.Text) & "','")
                                                    .Append(CStr(Me.txtSecuen_Final_Ticket.Text) & "','")
                                                    .Append(CStr(Me.txtSecuencia_Final_Factura.Text) & "','")
                                                    .Append(CStr(Me.txtPeriodo_Validez.Text) & "','")
                                                    .Append(CStr(Me.txtRUC.Text) & "','")
                                                    .Append(CStr(Me.txtEstado_Doc.Text) & "')")

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
                                            Me.txtRUC.Clear()
                                            Me.txtTimbrado.Clear()
                                            Me.txtTipoDoc.Clear()
                                            Me.txtRango2.Clear()
                                            Me.txtRango1.Clear()
                                            Me.txtRUC.Focus()
                                            Me.txtSecuencia_Final_Factura.Clear()
                                            Me.txtSecuen_Final_Ticket.Clear()
                                            Me.txtPeriodo_Validez.Clear()
                                            Me.txtEstado_Doc.Clear()

                                            Visualizar_Documentos()

                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Try
            Dim sel As String
            sel = "UPDATE TP_DOCUMENTOS SET TIPO_DOCUMENTO ='" & Trim(Me.txtTipoDoc.Text) & "',NUMERO_TIMBRADO ='" & Trim(Me.txtTimbrado.Text) & "', " & _
            "RANGO1 ='" & Trim(Me.txtRango1.Text) & "',RANGO2 ='" & Trim(Me.txtRango2.Text) & "',  " & _
            "SECUENCIA_FINAL_TICKET= '" & Trim(Me.txtSecuen_Final_Ticket.Text) & "',SECUENCIA_FINAL_FACTURA= '" & Trim(Me.txtSecuencia_Final_Factura.Text) & "'," & _
            "VALIDEZ ='" & Trim(Me.txtPeriodo_Validez.Text) & "',RUC_PROPIETARIO ='" & Trim(Me.txtRUC.Text) & "',ESTADO ='" & Trim(Me.txtEstado_Doc.Text) & "'  " & _
            "WHERE COD_DOCUMENTOS ='" & codigo & "'"
            cmm = New SqlClient.SqlCommand(sel, SQLconexion)
            SQLconexion.Open()
            Dim t As Integer = CInt(cmm.ExecuteScalar())
            cmm.Dispose()
            SQLconexion.Close()

        Catch ex As Exception
            MsgBox(ex.Message())
            SQLconexion.Close()
        End Try

        'LIMPIAR LOS CAMPOS
        Me.txtRUC.Clear()
        Me.txtTimbrado.Clear()
        Me.txtTipoDoc.Clear()
        Me.txtRango2.Clear()
        Me.txtRango1.Clear()
        Me.txtRUC.Focus()
        Me.txtSecuencia_Final_Factura.Clear()
        Me.txtSecuen_Final_Ticket.Clear()
        Me.txtPeriodo_Validez.Clear()
        Me.txtEstado_Doc.Clear()

        Visualizar_Documentos()

    End Sub

    Private Sub txtLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLimpiar.Click
        'LIMPIAR LOS CAMPOS
        Me.txtRUC.Clear()
        Me.txtTimbrado.Clear()
        Me.txtTipoDoc.Clear()
        Me.txtRango2.Clear()
        Me.txtRango1.Clear()
        Me.txtRUC.Focus()
        Me.txtSecuencia_Final_Factura.Clear()
        Me.txtSecuen_Final_Ticket.Clear()
        Me.txtPeriodo_Validez.Clear()
        Me.txtEstado_Doc.Clear()

        Visualizar_Documentos()
    End Sub

    Private Sub btnSalir_cargo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir_cargo.Click
        Me.Close()
    End Sub
End Class