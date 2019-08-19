<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class imprimir
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
        Me.DetalleFacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ElectrodomesticosDataSetReportes = New ElectrodomesticosLMJVA.ElectrodomesticosDataSetReportes()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DetalleFacturaTableAdapter = New ElectrodomesticosLMJVA.ElectrodomesticosDataSetReportesTableAdapters.DetalleFacturaTableAdapter()
        Me.txtfacImp = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.VolverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.DetalleFacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElectrodomesticosDataSetReportes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DetalleFacturaBindingSource
        '
        Me.DetalleFacturaBindingSource.DataMember = "DetalleFactura"
        Me.DetalleFacturaBindingSource.DataSource = Me.ElectrodomesticosDataSetReportes
        '
        'ElectrodomesticosDataSetReportes
        '
        Me.ElectrodomesticosDataSetReportes.DataSetName = "ElectrodomesticosDataSetReportes"
        Me.ElectrodomesticosDataSetReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.DetalleFacturaBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ElectrodomesticosLMJVA.Reporte.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 26)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(908, 655)
        Me.ReportViewer1.TabIndex = 0
        '
        'DetalleFacturaTableAdapter
        '
        Me.DetalleFacturaTableAdapter.ClearBeforeFill = True
        '
        'txtfacImp
        '
        Me.txtfacImp.Location = New System.Drawing.Point(717, 26)
        Me.txtfacImp.Name = "txtfacImp"
        Me.txtfacImp.Size = New System.Drawing.Size(100, 20)
        Me.txtfacImp.TabIndex = 1
        Me.txtfacImp.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VolverToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(908, 26)
        Me.MenuStrip1.TabIndex = 38
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'VolverToolStripMenuItem
        '
        Me.VolverToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VolverToolStripMenuItem.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.flecha_hacia_la_izquierda
        Me.VolverToolStripMenuItem.Name = "VolverToolStripMenuItem"
        Me.VolverToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.VolverToolStripMenuItem.Text = "Volver al menú del Vendedor"
        '
        'imprimir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(908, 681)
        Me.ControlBox = False
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.txtfacImp)
        Me.Controls.Add(Me.ReportViewer1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "imprimir"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Factura"
        CType(Me.DetalleFacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElectrodomesticosDataSetReportes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DetalleFacturaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ElectrodomesticosDataSetReportes As ElectrodomesticosLMJVA.ElectrodomesticosDataSetReportes
    Friend WithEvents DetalleFacturaTableAdapter As ElectrodomesticosLMJVA.ElectrodomesticosDataSetReportesTableAdapters.DetalleFacturaTableAdapter
    Friend WithEvents txtfacImp As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents VolverToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
