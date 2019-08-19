<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SubMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SubMenu))
        Me.Lhora = New System.Windows.Forms.Label()
        Me.LFecha = New System.Windows.Forms.Label()
        Me.GpMenuVendedor = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BClientes = New System.Windows.Forms.Button()
        Me.PicProducto = New System.Windows.Forms.PictureBox()
        Me.PicVenta = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BProductos = New System.Windows.Forms.Button()
        Me.BVendedores = New System.Windows.Forms.Button()
        Me.BVentas = New System.Windows.Forms.Button()
        Me.LReporte = New System.Windows.Forms.Label()
        Me.PicReporte = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VolverAlMenuDelSupervisorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GpMenuVendedor.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicReporte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lhora
        '
        Me.Lhora.AutoSize = True
        Me.Lhora.BackColor = System.Drawing.Color.Transparent
        Me.Lhora.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Lhora.ForeColor = System.Drawing.Color.Black
        Me.Lhora.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Lhora.Location = New System.Drawing.Point(789, 618)
        Me.Lhora.Name = "Lhora"
        Me.Lhora.Size = New System.Drawing.Size(61, 29)
        Me.Lhora.TabIndex = 24
        Me.Lhora.Text = "Hora"
        '
        'LFecha
        '
        Me.LFecha.AutoSize = True
        Me.LFecha.BackColor = System.Drawing.Color.Transparent
        Me.LFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.LFecha.ForeColor = System.Drawing.Color.Black
        Me.LFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LFecha.Location = New System.Drawing.Point(52, 618)
        Me.LFecha.Name = "LFecha"
        Me.LFecha.Size = New System.Drawing.Size(77, 25)
        Me.LFecha.TabIndex = 23
        Me.LFecha.Text = "Fecha"
        '
        'GpMenuVendedor
        '
        Me.GpMenuVendedor.BackColor = System.Drawing.Color.Transparent
        Me.GpMenuVendedor.Controls.Add(Me.PictureBox1)
        Me.GpMenuVendedor.Controls.Add(Me.BClientes)
        Me.GpMenuVendedor.Controls.Add(Me.PicProducto)
        Me.GpMenuVendedor.Controls.Add(Me.PicVenta)
        Me.GpMenuVendedor.Controls.Add(Me.PictureBox2)
        Me.GpMenuVendedor.Controls.Add(Me.BProductos)
        Me.GpMenuVendedor.Controls.Add(Me.BVendedores)
        Me.GpMenuVendedor.Controls.Add(Me.BVentas)
        Me.GpMenuVendedor.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GpMenuVendedor.ForeColor = System.Drawing.Color.White
        Me.GpMenuVendedor.Location = New System.Drawing.Point(46, 155)
        Me.GpMenuVendedor.Name = "GpMenuVendedor"
        Me.GpMenuVendedor.Size = New System.Drawing.Size(863, 435)
        Me.GpMenuVendedor.TabIndex = 22
        Me.GpMenuVendedor.TabStop = False
        Me.GpMenuVendedor.Text = "Menu de Reportes"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.lista_de_usuarios
        Me.PictureBox1.Location = New System.Drawing.Point(637, 32)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(68, 66)
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'BClientes
        '
        Me.BClientes.BackColor = System.Drawing.Color.Transparent
        Me.BClientes.ForeColor = System.Drawing.Color.Black
        Me.BClientes.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.button4
        Me.BClientes.Location = New System.Drawing.Point(126, 32)
        Me.BClientes.Name = "BClientes"
        Me.BClientes.Size = New System.Drawing.Size(420, 48)
        Me.BClientes.TabIndex = 30
        Me.BClientes.UseVisualStyleBackColor = False
        '
        'PicProducto
        '
        Me.PicProducto.BackColor = System.Drawing.Color.Transparent
        Me.PicProducto.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.codigo_de_barras
        Me.PicProducto.Location = New System.Drawing.Point(637, 346)
        Me.PicProducto.Name = "PicProducto"
        Me.PicProducto.Size = New System.Drawing.Size(64, 63)
        Me.PicProducto.TabIndex = 29
        Me.PicProducto.TabStop = False
        '
        'PicVenta
        '
        Me.PicVenta.BackColor = System.Drawing.Color.Transparent
        Me.PicVenta.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.calendario
        Me.PicVenta.Location = New System.Drawing.Point(637, 141)
        Me.PicVenta.Name = "PicVenta"
        Me.PicVenta.Size = New System.Drawing.Size(68, 66)
        Me.PicVenta.TabIndex = 28
        Me.PicVenta.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.dependiente_con_corbata
        Me.PictureBox2.Location = New System.Drawing.Point(637, 248)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(68, 63)
        Me.PictureBox2.TabIndex = 27
        Me.PictureBox2.TabStop = False
        '
        'BProductos
        '
        Me.BProductos.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BProductos.ForeColor = System.Drawing.Color.Black
        Me.BProductos.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.button__1_3
        Me.BProductos.Location = New System.Drawing.Point(126, 363)
        Me.BProductos.Name = "BProductos"
        Me.BProductos.Size = New System.Drawing.Size(420, 46)
        Me.BProductos.TabIndex = 17
        Me.BProductos.UseVisualStyleBackColor = True
        '
        'BVendedores
        '
        Me.BVendedores.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BVendedores.ForeColor = System.Drawing.Color.Black
        Me.BVendedores.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.button__9_
        Me.BVendedores.Location = New System.Drawing.Point(126, 248)
        Me.BVendedores.Name = "BVendedores"
        Me.BVendedores.Size = New System.Drawing.Size(420, 46)
        Me.BVendedores.TabIndex = 16
        Me.BVendedores.UseVisualStyleBackColor = True
        '
        'BVentas
        '
        Me.BVentas.BackColor = System.Drawing.Color.Transparent
        Me.BVentas.ForeColor = System.Drawing.Color.Black
        Me.BVentas.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.button__8_
        Me.BVentas.Location = New System.Drawing.Point(126, 141)
        Me.BVentas.Name = "BVentas"
        Me.BVentas.Size = New System.Drawing.Size(420, 48)
        Me.BVentas.TabIndex = 6
        Me.BVentas.UseVisualStyleBackColor = False
        '
        'LReporte
        '
        Me.LReporte.AutoSize = True
        Me.LReporte.BackColor = System.Drawing.Color.Transparent
        Me.LReporte.Font = New System.Drawing.Font("Calibri", 48.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LReporte.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.LReporte.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LReporte.Location = New System.Drawing.Point(44, 39)
        Me.LReporte.Name = "LReporte"
        Me.LReporte.Size = New System.Drawing.Size(270, 78)
        Me.LReporte.TabIndex = 25
        Me.LReporte.Text = "Reportes"
        '
        'PicReporte
        '
        Me.PicReporte.BackColor = System.Drawing.Color.Transparent
        Me.PicReporte.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.lineas_de_texto
        Me.PicReporte.Location = New System.Drawing.Point(336, 54)
        Me.PicReporte.Name = "PicReporte"
        Me.PicReporte.Size = New System.Drawing.Size(81, 63)
        Me.PicReporte.TabIndex = 26
        Me.PicReporte.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(679, 54)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(230, 20)
        Me.DateTimePicker1.TabIndex = 27
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem, Me.VolverAlMenuDelSupervisorToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(940, 27)
        Me.MenuStrip1.TabIndex = 28
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalirToolStripMenuItem.Image = CType(resources.GetObject("SalirToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(123, 23)
        Me.SalirToolStripMenuItem.Text = "Cerrar Sesión"
        '
        'VolverAlMenuDelSupervisorToolStripMenuItem
        '
        Me.VolverAlMenuDelSupervisorToolStripMenuItem.BackColor = System.Drawing.Color.Transparent
        Me.VolverAlMenuDelSupervisorToolStripMenuItem.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VolverAlMenuDelSupervisorToolStripMenuItem.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.flecha_hacia_la_izquierda
        Me.VolverAlMenuDelSupervisorToolStripMenuItem.Name = "VolverAlMenuDelSupervisorToolStripMenuItem"
        Me.VolverAlMenuDelSupervisorToolStripMenuItem.Size = New System.Drawing.Size(228, 23)
        Me.VolverAlMenuDelSupervisorToolStripMenuItem.Text = "Volver al menu del Supervisor"
        '
        'SubMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ElectrodomesticosLMJVA.My.Resources.Resources.fondoclaro
        Me.ClientSize = New System.Drawing.Size(940, 681)
        Me.ControlBox = False
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.PicReporte)
        Me.Controls.Add(Me.LReporte)
        Me.Controls.Add(Me.Lhora)
        Me.Controls.Add(Me.LFecha)
        Me.Controls.Add(Me.GpMenuVendedor)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SubMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú de Reportes"
        Me.GpMenuVendedor.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicVenta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicReporte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lhora As System.Windows.Forms.Label
    Friend WithEvents LFecha As System.Windows.Forms.Label
    Friend WithEvents GpMenuVendedor As System.Windows.Forms.GroupBox
    Friend WithEvents BVendedores As System.Windows.Forms.Button
    Friend WithEvents BVentas As System.Windows.Forms.Button
    Friend WithEvents LReporte As System.Windows.Forms.Label
    Friend WithEvents PicReporte As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BProductos As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PicProducto As System.Windows.Forms.PictureBox
    Friend WithEvents PicVenta As System.Windows.Forms.PictureBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VolverAlMenuDelSupervisorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BClientes As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
End Class
