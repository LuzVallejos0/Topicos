﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReporteMayorVendedor
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
        Me.mejoresVendedorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ElectrodomesticosDataSetReportes = New ElectrodomesticosLMJVA.ElectrodomesticosDataSetReportes()
        Me.LVendedor = New System.Windows.Forms.Label()
        Me.lblFac = New System.Windows.Forms.GroupBox()
        Me.BFecha = New System.Windows.Forms.Button()
        Me.Hasta = New System.Windows.Forms.DateTimePicker()
        Me.Desde = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.mejoresVendedorTableAdapter = New ElectrodomesticosLMJVA.ElectrodomesticosDataSetReportesTableAdapters.mejoresVendedorTableAdapter()
        CType(Me.mejoresVendedorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElectrodomesticosDataSetReportes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lblFac.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'mejoresVendedorBindingSource
        '
        Me.mejoresVendedorBindingSource.DataMember = "mejoresVendedor"
        Me.mejoresVendedorBindingSource.DataSource = Me.ElectrodomesticosDataSetReportes
        '
        'ElectrodomesticosDataSetReportes
        '
        Me.ElectrodomesticosDataSetReportes.DataSetName = "ElectrodomesticosDataSetReportes"
        Me.ElectrodomesticosDataSetReportes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LVendedor
        '
        Me.LVendedor.AutoSize = True
        Me.LVendedor.BackColor = System.Drawing.Color.Transparent
        Me.LVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LVendedor.Location = New System.Drawing.Point(12, 49)
        Me.LVendedor.Name = "LVendedor"
        Me.LVendedor.Size = New System.Drawing.Size(280, 62)
        Me.LVendedor.TabIndex = 44
        Me.LVendedor.Text = "ESTADISTICAS DE " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   VENDEDORES"
        '
        'lblFac
        '
        Me.lblFac.BackColor = System.Drawing.Color.Transparent
        Me.lblFac.Controls.Add(Me.BFecha)
        Me.lblFac.Controls.Add(Me.Hasta)
        Me.lblFac.Controls.Add(Me.Desde)
        Me.lblFac.Controls.Add(Me.Label1)
        Me.lblFac.Controls.Add(Me.Label3)
        Me.lblFac.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFac.ForeColor = System.Drawing.Color.Black
        Me.lblFac.Location = New System.Drawing.Point(511, 31)
        Me.lblFac.Name = "lblFac"
        Me.lblFac.Size = New System.Drawing.Size(488, 88)
        Me.lblFac.TabIndex = 47
        Me.lblFac.TabStop = False
        Me.lblFac.Text = "Buscar Fecha"
        '
        'BFecha
        '
        Me.BFecha.BackColor = System.Drawing.Color.White
        Me.BFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BFecha.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.Buscarr
        Me.BFecha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BFecha.Location = New System.Drawing.Point(321, 33)
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
        Me.Hasta.Location = New System.Drawing.Point(171, 52)
        Me.Hasta.Name = "Hasta"
        Me.Hasta.Size = New System.Drawing.Size(118, 24)
        Me.Hasta.TabIndex = 36
        '
        'Desde
        '
        Me.Desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Desde.Location = New System.Drawing.Point(171, 20)
        Me.Desde.Name = "Desde"
        Me.Desde.Size = New System.Drawing.Size(118, 24)
        Me.Desde.TabIndex = 35
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(110, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 18)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Hasta:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(110, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 18)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Desde:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.estadistica__2_
        Me.PictureBox1.Location = New System.Drawing.Point(298, 49)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(71, 63)
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1012, 27)
        Me.MenuStrip1.TabIndex = 52
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalirToolStripMenuItem.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.flecha_hacia_la_izquierda
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(81, 23)
        Me.SalirToolStripMenuItem.Text = "Volver "
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.mejoresVendedorBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "ElectrodomesticosLMJVA.MayorVendedor.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(12, 125)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(987, 544)
        Me.ReportViewer1.TabIndex = 53
        '
        'mejoresVendedorTableAdapter
        '
        Me.mejoresVendedorTableAdapter.ClearBeforeFill = True
        '
        'ReporteMayorVendedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1012, 681)
        Me.ControlBox = False
        Me.Controls.Add(Me.ReportViewer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblFac)
        Me.Controls.Add(Me.LVendedor)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReporteMayorVendedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reporte Mayor Vendedor"
        CType(Me.mejoresVendedorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElectrodomesticosDataSetReportes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lblFac.ResumeLayout(False)
        Me.lblFac.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LVendedor As System.Windows.Forms.Label
    Friend WithEvents lblFac As System.Windows.Forms.GroupBox
    Friend WithEvents Hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BFecha As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents mejoresVendedorBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ElectrodomesticosDataSetReportes As ElectrodomesticosLMJVA.ElectrodomesticosDataSetReportes
    Friend WithEvents mejoresVendedorTableAdapter As ElectrodomesticosLMJVA.ElectrodomesticosDataSetReportesTableAdapters.mejoresVendedorTableAdapter
End Class
