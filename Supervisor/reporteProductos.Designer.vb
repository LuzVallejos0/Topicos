<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reporteProductos
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ElectrodomesticosDataSetReportes = New ElectrodomesticosLMJVA.ElectrodomesticosDataSetReportes()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProductosTableAdapter = New ElectrodomesticosLMJVA.ElectrodomesticosDataSetReportesTableAdapters.ProductosTableAdapter()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblFac = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.BSinstock = New System.Windows.Forms.Button()
        Me.BInactivo = New System.Windows.Forms.Button()
        Me.BMarca = New System.Windows.Forms.Button()
        Me.BCategoria = New System.Windows.Forms.Button()
        Me.BBajoStock = New System.Windows.Forms.Button()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.CMarca = New System.Windows.Forms.ComboBox()
        Me.MarcaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ElectrodomesticosDataSet = New ElectrodomesticosLMJVA.ElectrodomesticosDataSet()
        Me.CCategoria = New System.Windows.Forms.ComboBox()
        Me.CategoriasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblFactura = New System.Windows.Forms.Label()
        Me.CategoriasTableAdapter = New ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.CategoriasTableAdapter()
        Me.MarcaTableAdapter = New ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.MarcaTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverAlMenúDelSupervisorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElectrodomesticosDataSetReportes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lblFac.SuspendLayout()
        CType(Me.MarcaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElectrodomesticosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.ElectrodomesticosDataSetReportes
        '
        'ElectrodomesticosDataSetReportes
        '
        Me.ElectrodomesticosDataSetReportes.DataSetName = "ElectrodomesticosDataSetReportes"
        Me.ElectrodomesticosDataSetReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.DocumentMapWidth = 51
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.ProductosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ElectrodomesticosLMJVA.listadoProductos.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 250)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(967, 429)
        Me.ReportViewer1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(218, 49)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(508, 42)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "LISTADO DE PRODUCTOS"
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.lista
        Me.PictureBox1.Location = New System.Drawing.Point(732, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(67, 65)
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'lblFac
        '
        Me.lblFac.BackColor = System.Drawing.Color.Transparent
        Me.lblFac.Controls.Add(Me.Button4)
        Me.lblFac.Controls.Add(Me.BSinstock)
        Me.lblFac.Controls.Add(Me.BInactivo)
        Me.lblFac.Controls.Add(Me.BMarca)
        Me.lblFac.Controls.Add(Me.BCategoria)
        Me.lblFac.Controls.Add(Me.BBajoStock)
        Me.lblFac.Controls.Add(Me.txtDescripcion)
        Me.lblFac.Controls.Add(Me.txtCodigo)
        Me.lblFac.Controls.Add(Me.CMarca)
        Me.lblFac.Controls.Add(Me.CCategoria)
        Me.lblFac.Controls.Add(Me.Label4)
        Me.lblFac.Controls.Add(Me.Label3)
        Me.lblFac.Controls.Add(Me.Label2)
        Me.lblFac.Controls.Add(Me.LblFactura)
        Me.lblFac.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFac.ForeColor = System.Drawing.Color.Black
        Me.lblFac.Location = New System.Drawing.Point(0, 94)
        Me.lblFac.Name = "lblFac"
        Me.lblFac.Size = New System.Drawing.Size(634, 150)
        Me.lblFac.TabIndex = 45
        Me.lblFac.TabStop = False
        Me.lblFac.Text = "Buscar Productos"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.Salmon
        Me.Button4.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.actualizar_pagina_opcion
        Me.Button4.Location = New System.Drawing.Point(566, 99)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(62, 45)
        Me.Button4.TabIndex = 51
        Me.Button4.UseVisualStyleBackColor = False
        '
        'BSinstock
        '
        Me.BSinstock.BackColor = System.Drawing.Color.Gray
        Me.BSinstock.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BSinstock.Location = New System.Drawing.Point(380, 98)
        Me.BSinstock.Name = "BSinstock"
        Me.BSinstock.Size = New System.Drawing.Size(180, 45)
        Me.BSinstock.TabIndex = 50
        Me.BSinstock.Text = "Productos sin stock"
        Me.BSinstock.UseVisualStyleBackColor = False
        '
        'BInactivo
        '
        Me.BInactivo.BackColor = System.Drawing.Color.Gray
        Me.BInactivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BInactivo.Location = New System.Drawing.Point(182, 99)
        Me.BInactivo.Name = "BInactivo"
        Me.BInactivo.Size = New System.Drawing.Size(192, 44)
        Me.BInactivo.TabIndex = 49
        Me.BInactivo.Text = "Productos Inactivos"
        Me.BInactivo.UseVisualStyleBackColor = False
        '
        'BMarca
        '
        Me.BMarca.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.Buscarr
        Me.BMarca.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BMarca.Location = New System.Drawing.Point(588, 29)
        Me.BMarca.Name = "BMarca"
        Me.BMarca.Size = New System.Drawing.Size(29, 25)
        Me.BMarca.TabIndex = 48
        Me.BMarca.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BMarca.UseVisualStyleBackColor = True
        '
        'BCategoria
        '
        Me.BCategoria.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.Buscarr
        Me.BCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BCategoria.Location = New System.Drawing.Point(272, 28)
        Me.BCategoria.Name = "BCategoria"
        Me.BCategoria.Size = New System.Drawing.Size(29, 25)
        Me.BCategoria.TabIndex = 47
        Me.BCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BCategoria.UseVisualStyleBackColor = True
        '
        'BBajoStock
        '
        Me.BBajoStock.BackColor = System.Drawing.Color.Salmon
        Me.BBajoStock.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBajoStock.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.signo_de_exclamacion
        Me.BBajoStock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BBajoStock.Location = New System.Drawing.Point(12, 99)
        Me.BBajoStock.Name = "BBajoStock"
        Me.BBajoStock.Size = New System.Drawing.Size(164, 45)
        Me.BBajoStock.TabIndex = 46
        Me.BBajoStock.Text = "   Productos con " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   Bajo Stock"
        Me.BBajoStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BBajoStock.UseVisualStyleBackColor = False
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(442, 65)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(140, 24)
        Me.txtDescripcion.TabIndex = 34
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(126, 62)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(140, 24)
        Me.txtCodigo.TabIndex = 33
        '
        'CMarca
        '
        Me.CMarca.DataSource = Me.MarcaBindingSource
        Me.CMarca.DisplayMember = "nombre"
        Me.CMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMarca.FormattingEnabled = True
        Me.CMarca.Location = New System.Drawing.Point(442, 28)
        Me.CMarca.Name = "CMarca"
        Me.CMarca.Size = New System.Drawing.Size(140, 26)
        Me.CMarca.TabIndex = 32
        Me.CMarca.ValueMember = "id_marca"
        '
        'MarcaBindingSource
        '
        Me.MarcaBindingSource.DataMember = "Marca"
        Me.MarcaBindingSource.DataSource = Me.ElectrodomesticosDataSet
        '
        'ElectrodomesticosDataSet
        '
        Me.ElectrodomesticosDataSet.DataSetName = "ElectrodomesticosDataSet"
        Me.ElectrodomesticosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CCategoria
        '
        Me.CCategoria.DataSource = Me.CategoriasBindingSource
        Me.CCategoria.DisplayMember = "nombre"
        Me.CCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CCategoria.FormattingEnabled = True
        Me.CCategoria.Location = New System.Drawing.Point(126, 28)
        Me.CCategoria.Name = "CCategoria"
        Me.CCategoria.Size = New System.Drawing.Size(140, 26)
        Me.CCategoria.TabIndex = 31
        Me.CCategoria.ValueMember = "id_categoria"
        '
        'CategoriasBindingSource
        '
        Me.CategoriasBindingSource.DataMember = "Categorias"
        Me.CategoriasBindingSource.DataSource = Me.ElectrodomesticosDataSet
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(319, 68)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 18)
        Me.Label4.TabIndex = 30
        Me.Label4.Text = "Por Descripción:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 65)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 18)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Por Código:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 18)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Por Categoría:"
        '
        'LblFactura
        '
        Me.LblFactura.AutoSize = True
        Me.LblFactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFactura.Location = New System.Drawing.Point(319, 31)
        Me.LblFactura.Name = "LblFactura"
        Me.LblFactura.Size = New System.Drawing.Size(82, 18)
        Me.LblFactura.TabIndex = 0
        Me.LblFactura.Text = "Por Marca:"
        '
        'CategoriasTableAdapter
        '
        Me.CategoriasTableAdapter.ClearBeforeFill = True
        '
        'MarcaTableAdapter
        '
        Me.MarcaTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.codigo_de_barras__1_
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(6, 13)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(239, 39)
        Me.Button1.TabIndex = 46
        Me.Button1.Text = "Productos más vendidos"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.advertencia
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(118, 58)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(203, 39)
        Me.Button2.TabIndex = 47
        Me.Button2.Text = "Productos sin venta"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Location = New System.Drawing.Point(640, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(327, 148)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.crecimiento
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(23, 103)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(264, 39)
        Me.Button3.TabIndex = 48
        Me.Button3.Text = "Comportamiento de Productos"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem, Me.VolverAlMenúDelSupervisorToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(974, 27)
        Me.MenuStrip1.TabIndex = 51
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalirToolStripMenuItem.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.flecha_hacia_la_izquierda
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(215, 23)
        Me.SalirToolStripMenuItem.Text = "Volver al menú de Reportes"
        '
        'VolverAlMenúDelSupervisorToolStripMenuItem
        '
        Me.VolverAlMenúDelSupervisorToolStripMenuItem.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VolverAlMenúDelSupervisorToolStripMenuItem.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.flecha_hacia_la_izquierda
        Me.VolverAlMenúDelSupervisorToolStripMenuItem.Name = "VolverAlMenúDelSupervisorToolStripMenuItem"
        Me.VolverAlMenúDelSupervisorToolStripMenuItem.Size = New System.Drawing.Size(229, 23)
        Me.VolverAlMenúDelSupervisorToolStripMenuItem.Text = "Volver al Menú del Supervisor"
        '
        'reporteProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(974, 681)
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblFac)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ReportViewer1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "reporteProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Productos"
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElectrodomesticosDataSetReportes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lblFac.ResumeLayout(False)
        Me.lblFac.PerformLayout()
        CType(Me.MarcaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElectrodomesticosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents ProductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ElectrodomesticosDataSetReportes As ElectrodomesticosLMJVA.ElectrodomesticosDataSetReportes
    Friend WithEvents ProductosTableAdapter As ElectrodomesticosLMJVA.ElectrodomesticosDataSetReportesTableAdapters.ProductosTableAdapter
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblFac As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents CMarca As System.Windows.Forms.ComboBox
    Friend WithEvents CCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LblFactura As System.Windows.Forms.Label
    Friend WithEvents ElectrodomesticosDataSet As ElectrodomesticosLMJVA.ElectrodomesticosDataSet
    Friend WithEvents CategoriasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoriasTableAdapter As ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.CategoriasTableAdapter
    Friend WithEvents MarcaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MarcaTableAdapter As ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.MarcaTableAdapter
    Friend WithEvents BBajoStock As System.Windows.Forms.Button
    Friend WithEvents BMarca As System.Windows.Forms.Button
    Friend WithEvents BCategoria As System.Windows.Forms.Button
    Friend WithEvents BSinstock As System.Windows.Forms.Button
    Friend WithEvents BInactivo As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VolverAlMenúDelSupervisorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
