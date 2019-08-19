<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuAdministrador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MenuAdministrador))
        Me.BTipo = New System.Windows.Forms.Button()
        Me.BMarcas = New System.Windows.Forms.Button()
        Me.BCategorias = New System.Windows.Forms.Button()
        Me.BProductos = New System.Windows.Forms.Button()
        Me.BEmpleados = New System.Windows.Forms.Button()
        Me.ElectrodomesticosDataSet = New ElectrodomesticosLMJVA.ElectrodomesticosDataSet()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuariosTableAdapter = New ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.UsuariosTableAdapter()
        Me.TableAdapterManager = New ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.TableAdapterManager()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LApellidoNombre = New System.Windows.Forms.Label()
        Me.LFecha = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Lhora = New System.Windows.Forms.Label()
        Me.GAdministrador = New System.Windows.Forms.GroupBox()
        Me.BBackup = New System.Windows.Forms.Button()
        Me.BClientes = New System.Windows.Forms.Button()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpleadosTableAdapter = New ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.EmpleadosTableAdapter()
        CType(Me.ElectrodomesticosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.GAdministrador.SuspendLayout()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTipo
        '
        Me.BTipo.BackColor = System.Drawing.Color.Transparent
        Me.BTipo.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTipo.ForeColor = System.Drawing.Color.Black
        Me.BTipo.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.button__4_
        Me.BTipo.Location = New System.Drawing.Point(30, 143)
        Me.BTipo.Name = "BTipo"
        Me.BTipo.Size = New System.Drawing.Size(423, 48)
        Me.BTipo.TabIndex = 14
        Me.BTipo.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BTipo.UseVisualStyleBackColor = False
        '
        'BMarcas
        '
        Me.BMarcas.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BMarcas.ForeColor = System.Drawing.Color.Black
        Me.BMarcas.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.button__3_
        Me.BMarcas.Location = New System.Drawing.Point(472, 143)
        Me.BMarcas.Name = "BMarcas"
        Me.BMarcas.Size = New System.Drawing.Size(423, 49)
        Me.BMarcas.TabIndex = 13
        Me.BMarcas.UseVisualStyleBackColor = True
        '
        'BCategorias
        '
        Me.BCategorias.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCategorias.ForeColor = System.Drawing.Color.Black
        Me.BCategorias.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.button__2_
        Me.BCategorias.Location = New System.Drawing.Point(472, 257)
        Me.BCategorias.Name = "BCategorias"
        Me.BCategorias.Size = New System.Drawing.Size(423, 49)
        Me.BCategorias.TabIndex = 12
        Me.BCategorias.UseVisualStyleBackColor = True
        '
        'BProductos
        '
        Me.BProductos.BackColor = System.Drawing.Color.Transparent
        Me.BProductos.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BProductos.ForeColor = System.Drawing.Color.Black
        Me.BProductos.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.button
        Me.BProductos.Location = New System.Drawing.Point(472, 32)
        Me.BProductos.Name = "BProductos"
        Me.BProductos.Size = New System.Drawing.Size(423, 49)
        Me.BProductos.TabIndex = 11
        Me.BProductos.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BProductos.UseVisualStyleBackColor = False
        '
        'BEmpleados
        '
        Me.BEmpleados.BackColor = System.Drawing.Color.Transparent
        Me.BEmpleados.Font = New System.Drawing.Font("Lucida Sans Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BEmpleados.ForeColor = System.Drawing.Color.Black
        Me.BEmpleados.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.button__1_
        Me.BEmpleados.Location = New System.Drawing.Point(30, 32)
        Me.BEmpleados.Name = "BEmpleados"
        Me.BEmpleados.Size = New System.Drawing.Size(423, 48)
        Me.BEmpleados.TabIndex = 6
        Me.BEmpleados.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BEmpleados.UseVisualStyleBackColor = False
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
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(940, 27)
        Me.MenuStrip1.TabIndex = 11
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.Label1.Location = New System.Drawing.Point(17, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(562, 59)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Bienvenido Administrador:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LApellidoNombre
        '
        Me.LApellidoNombre.AutoSize = True
        Me.LApellidoNombre.BackColor = System.Drawing.Color.Transparent
        Me.LApellidoNombre.Font = New System.Drawing.Font("Calibri", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LApellidoNombre.ForeColor = System.Drawing.Color.White
        Me.LApellidoNombre.Location = New System.Drawing.Point(440, 114)
        Me.LApellidoNombre.Name = "LApellidoNombre"
        Me.LApellidoNombre.Size = New System.Drawing.Size(290, 45)
        Me.LApellidoNombre.TabIndex = 12
        Me.LApellidoNombre.Text = "NombreYApellido"
        '
        'LFecha
        '
        Me.LFecha.AutoSize = True
        Me.LFecha.BackColor = System.Drawing.Color.Transparent
        Me.LFecha.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LFecha.ForeColor = System.Drawing.Color.Black
        Me.LFecha.Location = New System.Drawing.Point(30, 621)
        Me.LFecha.Name = "LFecha"
        Me.LFecha.Size = New System.Drawing.Size(71, 29)
        Me.LFecha.TabIndex = 13
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
        Me.Lhora.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lhora.ForeColor = System.Drawing.Color.Black
        Me.Lhora.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Lhora.Location = New System.Drawing.Point(779, 621)
        Me.Lhora.Name = "Lhora"
        Me.Lhora.Size = New System.Drawing.Size(61, 29)
        Me.Lhora.TabIndex = 20
        Me.Lhora.Text = "Hora"
        '
        'GAdministrador
        '
        Me.GAdministrador.BackColor = System.Drawing.Color.Transparent
        Me.GAdministrador.Controls.Add(Me.BBackup)
        Me.GAdministrador.Controls.Add(Me.BClientes)
        Me.GAdministrador.Controls.Add(Me.BEmpleados)
        Me.GAdministrador.Controls.Add(Me.BTipo)
        Me.GAdministrador.Controls.Add(Me.BProductos)
        Me.GAdministrador.Controls.Add(Me.BCategorias)
        Me.GAdministrador.Controls.Add(Me.BMarcas)
        Me.GAdministrador.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GAdministrador.ForeColor = System.Drawing.Color.White
        Me.GAdministrador.Location = New System.Drawing.Point(27, 162)
        Me.GAdministrador.Name = "GAdministrador"
        Me.GAdministrador.Size = New System.Drawing.Size(901, 438)
        Me.GAdministrador.TabIndex = 22
        Me.GAdministrador.TabStop = False
        Me.GAdministrador.Text = "Menú Administrador"
        '
        'BBackup
        '
        Me.BBackup.Font = New System.Drawing.Font("Lucida Sans Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBackup.ForeColor = System.Drawing.Color.Black
        Me.BBackup.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.btn_ingresar2_log1
        Me.BBackup.Location = New System.Drawing.Point(280, 361)
        Me.BBackup.Name = "BBackup"
        Me.BBackup.Size = New System.Drawing.Size(423, 46)
        Me.BBackup.TabIndex = 16
        Me.BBackup.UseVisualStyleBackColor = True
        '
        'BClientes
        '
        Me.BClientes.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.button__2_1
        Me.BClientes.Location = New System.Drawing.Point(30, 256)
        Me.BClientes.Name = "BClientes"
        Me.BClientes.Size = New System.Drawing.Size(423, 48)
        Me.BClientes.TabIndex = 15
        Me.BClientes.UseVisualStyleBackColor = True
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "Empleados"
        Me.EmpleadosBindingSource.DataSource = Me.ElectrodomesticosDataSet
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'MenuAdministrador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Gray
        Me.BackgroundImage = Global.ElectrodomesticosLMJVA.My.Resources.Resources.fondoclaro
        Me.ClientSize = New System.Drawing.Size(940, 681)
        Me.ControlBox = False
        Me.Controls.Add(Me.GAdministrador)
        Me.Controls.Add(Me.Lhora)
        Me.Controls.Add(Me.LFecha)
        Me.Controls.Add(Me.LApellidoNombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MenuAdministrador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú Administrador"
        CType(Me.ElectrodomesticosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GAdministrador.ResumeLayout(False)
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BEmpleados As System.Windows.Forms.Button
    Friend WithEvents ElectrodomesticosDataSet As ElectrodomesticosLMJVA.ElectrodomesticosDataSet
    Friend WithEvents UsuariosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsuariosTableAdapter As ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.UsuariosTableAdapter
    Friend WithEvents TableAdapterManager As ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BMarcas As System.Windows.Forms.Button
    Friend WithEvents BCategorias As System.Windows.Forms.Button
    Friend WithEvents BProductos As System.Windows.Forms.Button
    Friend WithEvents LApellidoNombre As System.Windows.Forms.Label
    Friend WithEvents LFecha As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BTipo As System.Windows.Forms.Button
    Friend WithEvents Lhora As System.Windows.Forms.Label
    Friend WithEvents GAdministrador As System.Windows.Forms.GroupBox
    Friend WithEvents EmpleadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpleadosTableAdapter As ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.EmpleadosTableAdapter
    Friend WithEvents BClientes As System.Windows.Forms.Button
    Friend WithEvents BBackup As System.Windows.Forms.Button
End Class
