<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuSupervisor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuSupervisor))
        Me.GpMenuVendedor = New System.Windows.Forms.GroupBox()
        Me.BReportes = New System.Windows.Forms.Button()
        Me.BVentas = New System.Windows.Forms.Button()
        Me.BUsuarios = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ElectrodomesticosDataSet = New ElectrodomesticosLMJVA.ElectrodomesticosDataSet()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuariosTableAdapter = New ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.UsuariosTableAdapter()
        Me.TableAdapterManager = New ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.TableAdapterManager()
        Me.LApellidoNombre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LFecha = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Lhora = New System.Windows.Forms.Label()
        Me.GpMenuVendedor.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.ElectrodomesticosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GpMenuVendedor
        '
        Me.GpMenuVendedor.BackColor = System.Drawing.Color.Transparent
        Me.GpMenuVendedor.Controls.Add(Me.BReportes)
        Me.GpMenuVendedor.Controls.Add(Me.BVentas)
        Me.GpMenuVendedor.Controls.Add(Me.BUsuarios)
        Me.GpMenuVendedor.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GpMenuVendedor.ForeColor = System.Drawing.Color.White
        Me.GpMenuVendedor.Location = New System.Drawing.Point(36, 176)
        Me.GpMenuVendedor.Name = "GpMenuVendedor"
        Me.GpMenuVendedor.Size = New System.Drawing.Size(863, 402)
        Me.GpMenuVendedor.TabIndex = 15
        Me.GpMenuVendedor.TabStop = False
        Me.GpMenuVendedor.Text = "Menu Gerente"
        '
        'BReportes
        '
        Me.BReportes.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BReportes.ForeColor = System.Drawing.Color.Black
        Me.BReportes.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.button__5_
        Me.BReportes.Location = New System.Drawing.Point(229, 313)
        Me.BReportes.Name = "BReportes"
        Me.BReportes.Size = New System.Drawing.Size(420, 46)
        Me.BReportes.TabIndex = 16
        Me.BReportes.UseVisualStyleBackColor = True
        '
        'BVentas
        '
        Me.BVentas.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.button2
        Me.BVentas.Location = New System.Drawing.Point(229, 178)
        Me.BVentas.Name = "BVentas"
        Me.BVentas.Size = New System.Drawing.Size(420, 48)
        Me.BVentas.TabIndex = 14
        Me.BVentas.UseVisualStyleBackColor = True
        '
        'BUsuarios
        '
        Me.BUsuarios.BackColor = System.Drawing.Color.Transparent
        Me.BUsuarios.ForeColor = System.Drawing.Color.Black
        Me.BUsuarios.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.button1
        Me.BUsuarios.Location = New System.Drawing.Point(229, 49)
        Me.BUsuarios.Name = "BUsuarios"
        Me.BUsuarios.Size = New System.Drawing.Size(420, 48)
        Me.BUsuarios.TabIndex = 6
        Me.BUsuarios.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(940, 27)
        Me.MenuStrip1.TabIndex = 16
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
        'ElectrodomesticosDataSet
        '
        Me.ElectrodomesticosDataSet.DataSetName = "ElectrodomesticosDataSet"
        Me.ElectrodomesticosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "Usuarios"
        Me.UsuariosBindingSource.DataSource = Me.ElectrodomesticosDataSet
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoriasTableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.MarcaTableAdapter = Nothing
        Me.TableAdapterManager.ProvinciaTableAdapter = Nothing
        Me.TableAdapterManager.TipoEmpleadoTableAdapter = Nothing
        Me.TableAdapterManager.TipoUsuarioTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LApellidoNombre
        '
        Me.LApellidoNombre.AutoSize = True
        Me.LApellidoNombre.BackColor = System.Drawing.Color.Transparent
        Me.LApellidoNombre.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LApellidoNombre.ForeColor = System.Drawing.Color.White
        Me.LApellidoNombre.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LApellidoNombre.Location = New System.Drawing.Point(299, 113)
        Me.LApellidoNombre.Name = "LApellidoNombre"
        Me.LApellidoNombre.Size = New System.Drawing.Size(282, 45)
        Me.LApellidoNombre.TabIndex = 18
        Me.LApellidoNombre.Text = "nombreYapellido"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(26, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(487, 59)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Bienvenido Supervisor:"
        '
        'LFecha
        '
        Me.LFecha.AutoSize = True
        Me.LFecha.BackColor = System.Drawing.Color.Transparent
        Me.LFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold)
        Me.LFecha.ForeColor = System.Drawing.Color.Black
        Me.LFecha.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LFecha.Location = New System.Drawing.Point(42, 606)
        Me.LFecha.Name = "LFecha"
        Me.LFecha.Size = New System.Drawing.Size(77, 25)
        Me.LFecha.TabIndex = 19
        Me.LFecha.Text = "Fecha"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Lhora
        '
        Me.Lhora.AutoSize = True
        Me.Lhora.BackColor = System.Drawing.Color.Transparent
        Me.Lhora.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold)
        Me.Lhora.ForeColor = System.Drawing.Color.Black
        Me.Lhora.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Lhora.Location = New System.Drawing.Point(790, 606)
        Me.Lhora.Name = "Lhora"
        Me.Lhora.Size = New System.Drawing.Size(61, 29)
        Me.Lhora.TabIndex = 21
        Me.Lhora.Text = "Hora"
        '
        'MenuSupervisor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ElectrodomesticosLMJVA.My.Resources.Resources.fondoclaro
        Me.ClientSize = New System.Drawing.Size(940, 681)
        Me.ControlBox = False
        Me.Controls.Add(Me.Lhora)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LApellidoNombre)
        Me.Controls.Add(Me.LFecha)
        Me.Controls.Add(Me.GpMenuVendedor)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "MenuSupervisor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu del Gerente"
        Me.GpMenuVendedor.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.ElectrodomesticosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GpMenuVendedor As System.Windows.Forms.GroupBox
    Friend WithEvents BUsuarios As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ElectrodomesticosDataSet As ElectrodomesticosLMJVA.ElectrodomesticosDataSet
    Friend WithEvents UsuariosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsuariosTableAdapter As ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.UsuariosTableAdapter
    Friend WithEvents TableAdapterManager As ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LApellidoNombre As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LFecha As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Lhora As System.Windows.Forms.Label
    Friend WithEvents BVentas As System.Windows.Forms.Button
    Friend WithEvents BReportes As System.Windows.Forms.Button
End Class
