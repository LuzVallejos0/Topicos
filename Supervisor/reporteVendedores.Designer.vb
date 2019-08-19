<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reporteVendedores
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
        Me.FacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ElectrodomesticosDataSetReportes = New ElectrodomesticosLMJVA.ElectrodomesticosDataSetReportes()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.LVendedor = New System.Windows.Forms.Label()
        Me.lblFac = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtVendedor = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BVendedor = New System.Windows.Forms.Button()
        Me.PicVendedor = New System.Windows.Forms.PictureBox()
        Me.FacturaTableAdapter = New ElectrodomesticosLMJVA.ElectrodomesticosDataSetReportesTableAdapters.FacturaTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BFecha = New System.Windows.Forms.Button()
        Me.Hasta = New System.Windows.Forms.DateTimePicker()
        Me.Desde = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverAlMenúDelSupervisorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElectrodomesticosDataSetReportes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lblFac.SuspendLayout()
        CType(Me.PicVendedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'FacturaBindingSource
        '
        Me.FacturaBindingSource.DataMember = "Factura"
        Me.FacturaBindingSource.DataSource = Me.ElectrodomesticosDataSetReportes
        '
        'ElectrodomesticosDataSetReportes
        '
        Me.ElectrodomesticosDataSetReportes.DataSetName = "ElectrodomesticosDataSetReportes"
        Me.ElectrodomesticosDataSetReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.FacturaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ElectrodomesticosLMJVA.listaVendedores.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(2, 188)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(986, 493)
        Me.ReportViewer1.TabIndex = 0
        '
        'LVendedor
        '
        Me.LVendedor.AutoSize = True
        Me.LVendedor.BackColor = System.Drawing.Color.Transparent
        Me.LVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LVendedor.Location = New System.Drawing.Point(12, 44)
        Me.LVendedor.Name = "LVendedor"
        Me.LVendedor.Size = New System.Drawing.Size(582, 47)
        Me.LVendedor.TabIndex = 43
        Me.LVendedor.Text = "LISTADO DE VENDEDORES"
        '
        'lblFac
        '
        Me.lblFac.BackColor = System.Drawing.Color.Transparent
        Me.lblFac.Controls.Add(Me.Button4)
        Me.lblFac.Controls.Add(Me.txtApellido)
        Me.lblFac.Controls.Add(Me.Label1)
        Me.lblFac.Controls.Add(Me.txtVendedor)
        Me.lblFac.Controls.Add(Me.Label3)
        Me.lblFac.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFac.ForeColor = System.Drawing.Color.Black
        Me.lblFac.Location = New System.Drawing.Point(2, 94)
        Me.lblFac.Name = "lblFac"
        Me.lblFac.Size = New System.Drawing.Size(626, 88)
        Me.lblFac.TabIndex = 46
        Me.lblFac.TabStop = False
        Me.lblFac.Text = "Buscar Vendedor"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.Button4.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.actualizar_pagina_opcion
        Me.Button4.Location = New System.Drawing.Point(549, 32)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(62, 45)
        Me.Button4.TabIndex = 52
        Me.Button4.UseVisualStyleBackColor = False
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(365, 45)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(140, 24)
        Me.txtApellido.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(268, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 18)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Por Apellido:"
        '
        'txtVendedor
        '
        Me.txtVendedor.Location = New System.Drawing.Point(91, 42)
        Me.txtVendedor.MaxLength = 8
        Me.txtVendedor.Name = "txtVendedor"
        Me.txtVendedor.Size = New System.Drawing.Size(140, 24)
        Me.txtVendedor.TabIndex = 33
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 18)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Por DNI:"
        '
        'BVendedor
        '
        Me.BVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BVendedor.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.dependiente_con_corbata
        Me.BVendedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BVendedor.Location = New System.Drawing.Point(841, 30)
        Me.BVendedor.Name = "BVendedor"
        Me.BVendedor.Size = New System.Drawing.Size(147, 69)
        Me.BVendedor.TabIndex = 36
        Me.BVendedor.Text = "Ver Mayor " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Vendedor"
        Me.BVendedor.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BVendedor.UseVisualStyleBackColor = True
        '
        'PicVendedor
        '
        Me.PicVendedor.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.lista_de_usuario
        Me.PicVendedor.Location = New System.Drawing.Point(600, 30)
        Me.PicVendedor.Name = "PicVendedor"
        Me.PicVendedor.Size = New System.Drawing.Size(71, 62)
        Me.PicVendedor.TabIndex = 44
        Me.PicVendedor.TabStop = False
        '
        'FacturaTableAdapter
        '
        Me.FacturaTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.BFecha)
        Me.GroupBox1.Controls.Add(Me.Hasta)
        Me.GroupBox1.Controls.Add(Me.Desde)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(634, 94)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(354, 88)
        Me.GroupBox1.TabIndex = 48
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar Fecha"
        '
        'BFecha
        '
        Me.BFecha.BackColor = System.Drawing.Color.White
        Me.BFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BFecha.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.Buscarr
        Me.BFecha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BFecha.Location = New System.Drawing.Point(255, 35)
        Me.BFecha.Name = "BFecha"
        Me.BFecha.Size = New System.Drawing.Size(93, 28)
        Me.BFecha.TabIndex = 37
        Me.BFecha.Text = "Buscar"
        Me.BFecha.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BFecha.UseVisualStyleBackColor = False
        '
        'Hasta
        '
        Me.Hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Hasta.Location = New System.Drawing.Point(111, 52)
        Me.Hasta.Name = "Hasta"
        Me.Hasta.Size = New System.Drawing.Size(118, 24)
        Me.Hasta.TabIndex = 36
        '
        'Desde
        '
        Me.Desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Desde.Location = New System.Drawing.Point(111, 20)
        Me.Desde.Name = "Desde"
        Me.Desde.Size = New System.Drawing.Size(118, 24)
        Me.Desde.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 18)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Hasta:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(50, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 18)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Desde:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem, Me.VolverAlMenúDelSupervisorToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1000, 27)
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
        Me.VolverAlMenúDelSupervisorToolStripMenuItem.Size = New System.Drawing.Size(228, 23)
        Me.VolverAlMenúDelSupervisorToolStripMenuItem.Text = "Volver al menú del Supervisor"
        '
        'reporteVendedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1000, 681)
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BVendedor)
        Me.Controls.Add(Me.lblFac)
        Me.Controls.Add(Me.PicVendedor)
        Me.Controls.Add(Me.LVendedor)
        Me.Controls.Add(Me.ReportViewer1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "reporteVendedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte de Vendedores"
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElectrodomesticosDataSetReportes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lblFac.ResumeLayout(False)
        Me.lblFac.PerformLayout()
        CType(Me.PicVendedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents FacturaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ElectrodomesticosDataSetReportes As ElectrodomesticosLMJVA.ElectrodomesticosDataSetReportes
    Friend WithEvents FacturaTableAdapter As ElectrodomesticosLMJVA.ElectrodomesticosDataSetReportesTableAdapters.FacturaTableAdapter
    Friend WithEvents LVendedor As System.Windows.Forms.Label
    Friend WithEvents PicVendedor As System.Windows.Forms.PictureBox
    Friend WithEvents lblFac As System.Windows.Forms.GroupBox
    Friend WithEvents txtVendedor As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BVendedor As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BFecha As System.Windows.Forms.Button
    Friend WithEvents Hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VolverAlMenúDelSupervisorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
