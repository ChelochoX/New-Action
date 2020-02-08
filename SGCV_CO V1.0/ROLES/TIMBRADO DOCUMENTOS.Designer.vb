<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TIMBRADO_DOCUMENTOS
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtEstado_Doc = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSecuencia_Final_Factura = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTimbrado = New System.Windows.Forms.TextBox()
        Me.txtRUC = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPeriodo_Validez = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSecuen_Final_Ticket = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRango2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRango1 = New System.Windows.Forms.TextBox()
        Me.txtTipoDoc = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dg_documentos = New System.Windows.Forms.DataGrid()
        Me.DataGridTableStyle1 = New System.Windows.Forms.DataGridTableStyle()
        Me.DataGridTextBoxColumn1 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn2 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn3 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn4 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn5 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn6 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn7 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn8 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn9 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.DataGridTextBoxColumn10 = New System.Windows.Forms.DataGridTextBoxColumn()
        Me.txtLimpiar = New System.Windows.Forms.Button()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btnSalir_cargo = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dg_documentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtEstado_Doc)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtSecuencia_Final_Factura)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtTimbrado)
        Me.GroupBox1.Controls.Add(Me.txtRUC)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtPeriodo_Validez)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtSecuen_Final_Ticket)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtRango2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtRango1)
        Me.GroupBox1.Controls.Add(Me.txtTipoDoc)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(334, 486)
        Me.GroupBox1.TabIndex = 380
        Me.GroupBox1.TabStop = False
        '
        'txtEstado_Doc
        '
        Me.txtEstado_Doc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtEstado_Doc.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstado_Doc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtEstado_Doc.Location = New System.Drawing.Point(19, 454)
        Me.txtEstado_Doc.Name = "txtEstado_Doc"
        Me.txtEstado_Doc.Size = New System.Drawing.Size(298, 27)
        Me.txtEstado_Doc.TabIndex = 390
        Me.txtEstado_Doc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(19, 432)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(298, 23)
        Me.Label8.TabIndex = 391
        Me.Label8.Text = "Estado Documento"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSecuencia_Final_Factura
        '
        Me.txtSecuencia_Final_Factura.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSecuencia_Final_Factura.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecuencia_Final_Factura.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSecuencia_Final_Factura.Location = New System.Drawing.Point(19, 302)
        Me.txtSecuencia_Final_Factura.Name = "txtSecuencia_Final_Factura"
        Me.txtSecuencia_Final_Factura.Size = New System.Drawing.Size(298, 27)
        Me.txtSecuencia_Final_Factura.TabIndex = 388
        Me.txtSecuencia_Final_Factura.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(19, 278)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(298, 23)
        Me.Label7.TabIndex = 389
        Me.Label7.Text = "Secuencia Final Factura"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTimbrado
        '
        Me.txtTimbrado.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTimbrado.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimbrado.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTimbrado.Location = New System.Drawing.Point(19, 85)
        Me.txtTimbrado.Name = "txtTimbrado"
        Me.txtTimbrado.Size = New System.Drawing.Size(298, 27)
        Me.txtTimbrado.TabIndex = 1
        Me.txtTimbrado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtRUC
        '
        Me.txtRUC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRUC.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRUC.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRUC.Location = New System.Drawing.Point(19, 405)
        Me.txtRUC.Name = "txtRUC"
        Me.txtRUC.Size = New System.Drawing.Size(298, 27)
        Me.txtRUC.TabIndex = 6
        Me.txtRUC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(19, 383)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(298, 23)
        Me.Label6.TabIndex = 385
        Me.Label6.Text = "RUC del Propietario"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPeriodo_Validez
        '
        Me.txtPeriodo_Validez.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPeriodo_Validez.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeriodo_Validez.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPeriodo_Validez.Location = New System.Drawing.Point(19, 354)
        Me.txtPeriodo_Validez.Name = "txtPeriodo_Validez"
        Me.txtPeriodo_Validez.Size = New System.Drawing.Size(298, 27)
        Me.txtPeriodo_Validez.TabIndex = 5
        Me.txtPeriodo_Validez.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(19, 332)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(298, 23)
        Me.Label5.TabIndex = 383
        Me.Label5.Text = "Periodo Validez"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSecuen_Final_Ticket
        '
        Me.txtSecuen_Final_Ticket.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtSecuen_Final_Ticket.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecuen_Final_Ticket.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtSecuen_Final_Ticket.Location = New System.Drawing.Point(19, 246)
        Me.txtSecuen_Final_Ticket.Name = "txtSecuen_Final_Ticket"
        Me.txtSecuen_Final_Ticket.Size = New System.Drawing.Size(298, 27)
        Me.txtSecuen_Final_Ticket.TabIndex = 4
        Me.txtSecuen_Final_Ticket.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(19, 222)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(298, 23)
        Me.Label2.TabIndex = 381
        Me.Label2.Text = "Secuencia Final Ticket"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtRango2
        '
        Me.txtRango2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRango2.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRango2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRango2.Location = New System.Drawing.Point(19, 190)
        Me.txtRango2.Name = "txtRango2"
        Me.txtRango2.Size = New System.Drawing.Size(298, 27)
        Me.txtRango2.TabIndex = 3
        Me.txtRango2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(19, 168)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(298, 23)
        Me.Label1.TabIndex = 379
        Me.Label1.Text = "Rango 2"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtRango1
        '
        Me.txtRango1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtRango1.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRango1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtRango1.Location = New System.Drawing.Point(19, 137)
        Me.txtRango1.Name = "txtRango1"
        Me.txtRango1.Size = New System.Drawing.Size(298, 27)
        Me.txtRango1.TabIndex = 2
        Me.txtRango1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtTipoDoc
        '
        Me.txtTipoDoc.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtTipoDoc.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTipoDoc.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtTipoDoc.Location = New System.Drawing.Point(19, 34)
        Me.txtTipoDoc.Name = "txtTipoDoc"
        Me.txtTipoDoc.Size = New System.Drawing.Size(298, 27)
        Me.txtTipoDoc.TabIndex = 0
        Me.txtTipoDoc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(19, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(298, 23)
        Me.Label4.TabIndex = 377
        Me.Label4.Text = "Rango 1"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(19, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(298, 23)
        Me.Label3.TabIndex = 376
        Me.Label3.Text = "Tipo de Documento"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(19, 65)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(298, 23)
        Me.Label9.TabIndex = 387
        Me.Label9.Text = "Timbrado"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dg_documentos
        '
        Me.dg_documentos.AlternatingBackColor = System.Drawing.Color.GhostWhite
        Me.dg_documentos.BackColor = System.Drawing.Color.GhostWhite
        Me.dg_documentos.BackgroundColor = System.Drawing.Color.Lavender
        Me.dg_documentos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dg_documentos.CaptionBackColor = System.Drawing.Color.RoyalBlue
        Me.dg_documentos.CaptionFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dg_documentos.CaptionForeColor = System.Drawing.Color.White
        Me.dg_documentos.DataMember = ""
        Me.dg_documentos.FlatMode = True
        Me.dg_documentos.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dg_documentos.ForeColor = System.Drawing.Color.MidnightBlue
        Me.dg_documentos.GridLineColor = System.Drawing.Color.RoyalBlue
        Me.dg_documentos.HeaderBackColor = System.Drawing.Color.MidnightBlue
        Me.dg_documentos.HeaderFont = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dg_documentos.HeaderForeColor = System.Drawing.Color.Lavender
        Me.dg_documentos.LinkColor = System.Drawing.Color.Teal
        Me.dg_documentos.Location = New System.Drawing.Point(352, 24)
        Me.dg_documentos.Name = "dg_documentos"
        Me.dg_documentos.ParentRowsBackColor = System.Drawing.Color.Lavender
        Me.dg_documentos.ParentRowsForeColor = System.Drawing.Color.MidnightBlue
        Me.dg_documentos.ReadOnly = True
        Me.dg_documentos.SelectionBackColor = System.Drawing.Color.Teal
        Me.dg_documentos.SelectionForeColor = System.Drawing.Color.PaleGreen
        Me.dg_documentos.Size = New System.Drawing.Size(737, 259)
        Me.dg_documentos.TabIndex = 383
        Me.dg_documentos.TableStyles.AddRange(New System.Windows.Forms.DataGridTableStyle() {Me.DataGridTableStyle1})
        '
        'DataGridTableStyle1
        '
        Me.DataGridTableStyle1.DataGrid = Me.dg_documentos
        Me.DataGridTableStyle1.GridColumnStyles.AddRange(New System.Windows.Forms.DataGridColumnStyle() {Me.DataGridTextBoxColumn1, Me.DataGridTextBoxColumn2, Me.DataGridTextBoxColumn3, Me.DataGridTextBoxColumn4, Me.DataGridTextBoxColumn5, Me.DataGridTextBoxColumn6, Me.DataGridTextBoxColumn7, Me.DataGridTextBoxColumn8, Me.DataGridTextBoxColumn9, Me.DataGridTextBoxColumn10})
        Me.DataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGridTableStyle1.MappingName = "TP_DOCUMENTOS"
        '
        'DataGridTextBoxColumn1
        '
        Me.DataGridTextBoxColumn1.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn1.Format = ""
        Me.DataGridTextBoxColumn1.FormatInfo = Nothing
        Me.DataGridTextBoxColumn1.HeaderText = "DOCUMENTO"
        Me.DataGridTextBoxColumn1.MappingName = "TIPO_DOCUMENTO"
        Me.DataGridTextBoxColumn1.Width = 85
        '
        'DataGridTextBoxColumn2
        '
        Me.DataGridTextBoxColumn2.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn2.Format = ""
        Me.DataGridTextBoxColumn2.FormatInfo = Nothing
        Me.DataGridTextBoxColumn2.HeaderText = "TIMBRADO"
        Me.DataGridTextBoxColumn2.MappingName = "NUMERO_TIMBRADO"
        Me.DataGridTextBoxColumn2.Width = 75
        '
        'DataGridTextBoxColumn3
        '
        Me.DataGridTextBoxColumn3.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn3.Format = ""
        Me.DataGridTextBoxColumn3.FormatInfo = Nothing
        Me.DataGridTextBoxColumn3.HeaderText = "RANGO 1"
        Me.DataGridTextBoxColumn3.MappingName = "RANGO1"
        Me.DataGridTextBoxColumn3.Width = 65
        '
        'DataGridTextBoxColumn4
        '
        Me.DataGridTextBoxColumn4.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn4.Format = ""
        Me.DataGridTextBoxColumn4.FormatInfo = Nothing
        Me.DataGridTextBoxColumn4.HeaderText = "RANGO 2"
        Me.DataGridTextBoxColumn4.MappingName = "RANGO2"
        Me.DataGridTextBoxColumn4.Width = 65
        '
        'DataGridTextBoxColumn5
        '
        Me.DataGridTextBoxColumn5.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn5.Format = ""
        Me.DataGridTextBoxColumn5.FormatInfo = Nothing
        Me.DataGridTextBoxColumn5.HeaderText = "SEC. FINAL TICKET"
        Me.DataGridTextBoxColumn5.MappingName = "SECUENCIA_FINAL_TICKET"
        Me.DataGridTextBoxColumn5.Width = 85
        '
        'DataGridTextBoxColumn6
        '
        Me.DataGridTextBoxColumn6.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn6.Format = ""
        Me.DataGridTextBoxColumn6.FormatInfo = Nothing
        Me.DataGridTextBoxColumn6.HeaderText = "SEC.FINAL FACTURA"
        Me.DataGridTextBoxColumn6.MappingName = "SECUENCIA_FINAL_FACTURA"
        Me.DataGridTextBoxColumn6.Width = 85
        '
        'DataGridTextBoxColumn7
        '
        Me.DataGridTextBoxColumn7.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn7.Format = ""
        Me.DataGridTextBoxColumn7.FormatInfo = Nothing
        Me.DataGridTextBoxColumn7.HeaderText = "VALIDEZ"
        Me.DataGridTextBoxColumn7.MappingName = "VALIDEZ"
        Me.DataGridTextBoxColumn7.Width = 75
        '
        'DataGridTextBoxColumn8
        '
        Me.DataGridTextBoxColumn8.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn8.Format = ""
        Me.DataGridTextBoxColumn8.FormatInfo = Nothing
        Me.DataGridTextBoxColumn8.HeaderText = "RUC"
        Me.DataGridTextBoxColumn8.MappingName = "RUC_PROPIETARIO"
        Me.DataGridTextBoxColumn8.Width = 60
        '
        'DataGridTextBoxColumn9
        '
        Me.DataGridTextBoxColumn9.Alignment = System.Windows.Forms.HorizontalAlignment.Center
        Me.DataGridTextBoxColumn9.Format = ""
        Me.DataGridTextBoxColumn9.FormatInfo = Nothing
        Me.DataGridTextBoxColumn9.HeaderText = "ESTADO"
        Me.DataGridTextBoxColumn9.MappingName = "ESTADO"
        Me.DataGridTextBoxColumn9.Width = 60
        '
        'DataGridTextBoxColumn10
        '
        Me.DataGridTextBoxColumn10.Format = ""
        Me.DataGridTextBoxColumn10.FormatInfo = Nothing
        Me.DataGridTextBoxColumn10.MappingName = "COD_DOCUMENTOS"
        Me.DataGridTextBoxColumn10.Width = 0
        '
        'txtLimpiar
        '
        Me.txtLimpiar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtLimpiar.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLimpiar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtLimpiar.Location = New System.Drawing.Point(724, 344)
        Me.txtLimpiar.Name = "txtLimpiar"
        Me.txtLimpiar.Size = New System.Drawing.Size(174, 31)
        Me.txtLimpiar.TabIndex = 386
        Me.txtLimpiar.Text = "Limpiar"
        Me.txtLimpiar.UseVisualStyleBackColor = False
        '
        'btnModificar
        '
        Me.btnModificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnModificar.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModificar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnModificar.Location = New System.Drawing.Point(544, 344)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(174, 31)
        Me.btnModificar.TabIndex = 385
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = False
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnguardar.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnguardar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnguardar.Location = New System.Drawing.Point(352, 344)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(174, 31)
        Me.btnguardar.TabIndex = 384
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'btnSalir_cargo
        '
        Me.btnSalir_cargo.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir_cargo.Font = New System.Drawing.Font("Rockwell", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir_cargo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSalir_cargo.Location = New System.Drawing.Point(904, 344)
        Me.btnSalir_cargo.Name = "btnSalir_cargo"
        Me.btnSalir_cargo.Size = New System.Drawing.Size(174, 31)
        Me.btnSalir_cargo.TabIndex = 387
        Me.btnSalir_cargo.Text = "Salir"
        Me.btnSalir_cargo.UseVisualStyleBackColor = False
        '
        'TIMBRADO_DOCUMENTOS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1101, 510)
        Me.Controls.Add(Me.txtLimpiar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btnSalir_cargo)
        Me.Controls.Add(Me.dg_documentos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "TIMBRADO_DOCUMENTOS"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TIMBRADO DE DOCUMENTOS"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dg_documentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSecuencia_Final_Factura As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtTimbrado As System.Windows.Forms.TextBox
    Friend WithEvents txtRUC As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPeriodo_Validez As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtSecuen_Final_Ticket As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtRango2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtRango1 As System.Windows.Forms.TextBox
    Friend WithEvents txtTipoDoc As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtEstado_Doc As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dg_documentos As System.Windows.Forms.DataGrid
    Friend WithEvents DataGridTableStyle1 As System.Windows.Forms.DataGridTableStyle
    Friend WithEvents txtLimpiar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents btnSalir_cargo As System.Windows.Forms.Button
    Friend WithEvents DataGridTextBoxColumn1 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn2 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn3 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn4 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn5 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn6 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn7 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn8 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn9 As System.Windows.Forms.DataGridTextBoxColumn
    Friend WithEvents DataGridTextBoxColumn10 As System.Windows.Forms.DataGridTextBoxColumn
End Class
