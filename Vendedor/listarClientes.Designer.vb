<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listarClientes
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
        Me.ClientesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DNIclienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.localidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvinciaNombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado_cliente = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ElectrodomesticosDataSet = New ElectrodomesticosLMJVA.ElectrodomesticosDataSet()
        Me.ClientesTableAdapter = New ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.ClientesTableAdapter()
        Me.GPBuscador = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LblBuscador = New System.Windows.Forms.Label()
        Me.TApellido = New System.Windows.Forms.TextBox()
        Me.LblBuscarDni = New System.Windows.Forms.Label()
        Me.LblBuscarApellido = New System.Windows.Forms.Label()
        Me.TDNI = New System.Windows.Forms.TextBox()
        Me.LAgregar = New System.Windows.Forms.Label()
        Me.GBalta = New System.Windows.Forms.GroupBox()
        Me.Bagregar = New System.Windows.Forms.Button()
        Me.BEditar = New System.Windows.Forms.Button()
        Me.CBProvincia = New System.Windows.Forms.ComboBox()
        Me.ProvinciaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.LblEmail = New System.Windows.Forms.Label()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.LblTelefono = New System.Windows.Forms.Label()
        Me.TxtLocalidad = New System.Windows.Forms.TextBox()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtDNI = New System.Windows.Forms.TextBox()
        Me.LblProvincia = New System.Windows.Forms.Label()
        Me.LblLocalidad = New System.Windows.Forms.Label()
        Me.LblDireccion = New System.Windows.Forms.Label()
        Me.LblApellido = New System.Windows.Forms.Label()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.LblDNI = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProvinciaTableAdapter = New ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.ProvinciaTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElectrodomesticosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GPBuscador.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBalta.SuspendLayout()
        CType(Me.ProvinciaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ClientesDataGridView
        '
        Me.ClientesDataGridView.AllowUserToAddRows = False
        Me.ClientesDataGridView.AllowUserToDeleteRows = False
        Me.ClientesDataGridView.AutoGenerateColumns = False
        Me.ClientesDataGridView.BackgroundColor = System.Drawing.SystemColors.InactiveBorder
        Me.ClientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClientesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DNIclienteDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ApellidoDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn, Me.localidad, Me.ProvinciaNombreDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.email, Me.estado_cliente})
        Me.ClientesDataGridView.DataSource = Me.ClientesBindingSource
        Me.ClientesDataGridView.Location = New System.Drawing.Point(12, 400)
        Me.ClientesDataGridView.Name = "ClientesDataGridView"
        Me.ClientesDataGridView.ReadOnly = True
        Me.ClientesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ClientesDataGridView.Size = New System.Drawing.Size(821, 248)
        Me.ClientesDataGridView.TabIndex = 0
        '
        'DNIclienteDataGridViewTextBoxColumn
        '
        Me.DNIclienteDataGridViewTextBoxColumn.DataPropertyName = "DNI_cliente"
        Me.DNIclienteDataGridViewTextBoxColumn.HeaderText = "DNI_cliente"
        Me.DNIclienteDataGridViewTextBoxColumn.Name = "DNIclienteDataGridViewTextBoxColumn"
        Me.DNIclienteDataGridViewTextBoxColumn.ReadOnly = True
        Me.DNIclienteDataGridViewTextBoxColumn.Width = 110
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 110
        '
        'ApellidoDataGridViewTextBoxColumn
        '
        Me.ApellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido"
        Me.ApellidoDataGridViewTextBoxColumn.HeaderText = "Apellido"
        Me.ApellidoDataGridViewTextBoxColumn.Name = "ApellidoDataGridViewTextBoxColumn"
        Me.ApellidoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ApellidoDataGridViewTextBoxColumn.Width = 110
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "Dirección"
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        Me.DireccionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DireccionDataGridViewTextBoxColumn.Width = 110
        '
        'localidad
        '
        Me.localidad.DataPropertyName = "localidad"
        Me.localidad.HeaderText = "localidad"
        Me.localidad.Name = "localidad"
        Me.localidad.ReadOnly = True
        Me.localidad.Width = 110
        '
        'ProvinciaNombreDataGridViewTextBoxColumn
        '
        Me.ProvinciaNombreDataGridViewTextBoxColumn.DataPropertyName = "ProvinciaNombre"
        Me.ProvinciaNombreDataGridViewTextBoxColumn.HeaderText = "Provincia"
        Me.ProvinciaNombreDataGridViewTextBoxColumn.Name = "ProvinciaNombreDataGridViewTextBoxColumn"
        Me.ProvinciaNombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.ProvinciaNombreDataGridViewTextBoxColumn.Width = 110
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Télefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TelefonoDataGridViewTextBoxColumn.Width = 110
        '
        'email
        '
        Me.email.DataPropertyName = "email"
        Me.email.HeaderText = "Email"
        Me.email.Name = "email"
        Me.email.ReadOnly = True
        '
        'estado_cliente
        '
        Me.estado_cliente.DataPropertyName = "estado_cliente"
        Me.estado_cliente.HeaderText = "estado_cliente"
        Me.estado_cliente.Name = "estado_cliente"
        Me.estado_cliente.ReadOnly = True
        Me.estado_cliente.Visible = False
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.ElectrodomesticosDataSet
        '
        'ElectrodomesticosDataSet
        '
        Me.ElectrodomesticosDataSet.DataSetName = "ElectrodomesticosDataSet"
        Me.ElectrodomesticosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'GPBuscador
        '
        Me.GPBuscador.BackColor = System.Drawing.Color.Transparent
        Me.GPBuscador.Controls.Add(Me.Button2)
        Me.GPBuscador.Controls.Add(Me.PictureBox1)
        Me.GPBuscador.Controls.Add(Me.LblBuscador)
        Me.GPBuscador.Controls.Add(Me.TApellido)
        Me.GPBuscador.Controls.Add(Me.LblBuscarDni)
        Me.GPBuscador.Controls.Add(Me.LblBuscarApellido)
        Me.GPBuscador.Controls.Add(Me.TDNI)
        Me.GPBuscador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GPBuscador.Location = New System.Drawing.Point(12, 276)
        Me.GPBuscador.Name = "GPBuscador"
        Me.GPBuscador.Size = New System.Drawing.Size(819, 100)
        Me.GPBuscador.TabIndex = 17
        Me.GPBuscador.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.Buscarr
        Me.PictureBox1.Location = New System.Drawing.Point(569, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(22, 22)
        Me.PictureBox1.TabIndex = 11
        Me.PictureBox1.TabStop = False
        '
        'LblBuscador
        '
        Me.LblBuscador.AutoSize = True
        Me.LblBuscador.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBuscador.ForeColor = System.Drawing.Color.Black
        Me.LblBuscador.Location = New System.Drawing.Point(271, 12)
        Me.LblBuscador.Name = "LblBuscador"
        Me.LblBuscador.Size = New System.Drawing.Size(292, 31)
        Me.LblBuscador.TabIndex = 5
        Me.LblBuscador.Text = "Buscador de Clientes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TApellido
        '
        Me.TApellido.Location = New System.Drawing.Point(584, 62)
        Me.TApellido.Name = "TApellido"
        Me.TApellido.Size = New System.Drawing.Size(220, 22)
        Me.TApellido.TabIndex = 10
        '
        'LblBuscarDni
        '
        Me.LblBuscarDni.AutoSize = True
        Me.LblBuscarDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBuscarDni.ForeColor = System.Drawing.Color.Black
        Me.LblBuscarDni.Location = New System.Drawing.Point(18, 64)
        Me.LblBuscarDni.Name = "LblBuscarDni"
        Me.LblBuscarDni.Size = New System.Drawing.Size(69, 20)
        Me.LblBuscarDni.TabIndex = 6
        Me.LblBuscarDni.Text = "Por DNI:"
        '
        'LblBuscarApellido
        '
        Me.LblBuscarApellido.AutoSize = True
        Me.LblBuscarApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBuscarApellido.ForeColor = System.Drawing.Color.Black
        Me.LblBuscarApellido.Location = New System.Drawing.Point(470, 62)
        Me.LblBuscarApellido.Name = "LblBuscarApellido"
        Me.LblBuscarApellido.Size = New System.Drawing.Size(97, 20)
        Me.LblBuscarApellido.TabIndex = 9
        Me.LblBuscarApellido.Text = "Por Apellido:"
        '
        'TDNI
        '
        Me.TDNI.Location = New System.Drawing.Point(93, 62)
        Me.TDNI.MaxLength = 8
        Me.TDNI.Name = "TDNI"
        Me.TDNI.Size = New System.Drawing.Size(216, 22)
        Me.TDNI.TabIndex = 7
        '
        'LAgregar
        '
        Me.LAgregar.AutoSize = True
        Me.LAgregar.BackColor = System.Drawing.Color.Transparent
        Me.LAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LAgregar.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LAgregar.Location = New System.Drawing.Point(559, 379)
        Me.LAgregar.Name = "LAgregar"
        Me.LAgregar.Size = New System.Drawing.Size(274, 18)
        Me.LAgregar.TabIndex = 30
        Me.LAgregar.Text = "(Doble click para modificar Cliente)"
        '
        'GBalta
        '
        Me.GBalta.BackColor = System.Drawing.Color.Transparent
        Me.GBalta.Controls.Add(Me.Bagregar)
        Me.GBalta.Controls.Add(Me.BEditar)
        Me.GBalta.Controls.Add(Me.CBProvincia)
        Me.GBalta.Controls.Add(Me.TxtEmail)
        Me.GBalta.Controls.Add(Me.LblEmail)
        Me.GBalta.Controls.Add(Me.TxtTelefono)
        Me.GBalta.Controls.Add(Me.LblTelefono)
        Me.GBalta.Controls.Add(Me.TxtLocalidad)
        Me.GBalta.Controls.Add(Me.TxtDireccion)
        Me.GBalta.Controls.Add(Me.TxtApellido)
        Me.GBalta.Controls.Add(Me.TxtNombre)
        Me.GBalta.Controls.Add(Me.TxtDNI)
        Me.GBalta.Controls.Add(Me.LblProvincia)
        Me.GBalta.Controls.Add(Me.LblLocalidad)
        Me.GBalta.Controls.Add(Me.LblDireccion)
        Me.GBalta.Controls.Add(Me.LblApellido)
        Me.GBalta.Controls.Add(Me.LblNombre)
        Me.GBalta.Controls.Add(Me.LblDNI)
        Me.GBalta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBalta.ForeColor = System.Drawing.Color.Black
        Me.GBalta.Location = New System.Drawing.Point(10, 46)
        Me.GBalta.Name = "GBalta"
        Me.GBalta.Size = New System.Drawing.Size(821, 224)
        Me.GBalta.TabIndex = 31
        Me.GBalta.TabStop = False
        Me.GBalta.Text = "Modificar Clientes"
        '
        'Bagregar
        '
        Me.Bagregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bagregar.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.ag
        Me.Bagregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Bagregar.Location = New System.Drawing.Point(719, 122)
        Me.Bagregar.Name = "Bagregar"
        Me.Bagregar.Size = New System.Drawing.Size(87, 88)
        Me.Bagregar.TabIndex = 20
        Me.Bagregar.Text = "Agregar a Ventas"
        Me.Bagregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Bagregar.UseVisualStyleBackColor = True
        '
        'BEditar
        '
        Me.BEditar.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.editar
        Me.BEditar.Location = New System.Drawing.Point(719, 33)
        Me.BEditar.Name = "BEditar"
        Me.BEditar.Size = New System.Drawing.Size(87, 88)
        Me.BEditar.TabIndex = 19
        Me.BEditar.UseVisualStyleBackColor = True
        '
        'CBProvincia
        '
        Me.CBProvincia.DataSource = Me.ProvinciaBindingSource
        Me.CBProvincia.DisplayMember = "nombre"
        Me.CBProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBProvincia.FormattingEnabled = True
        Me.CBProvincia.Location = New System.Drawing.Point(476, 79)
        Me.CBProvincia.Name = "CBProvincia"
        Me.CBProvincia.Size = New System.Drawing.Size(222, 28)
        Me.CBProvincia.TabIndex = 17
        Me.CBProvincia.ValueMember = "id_provincia"
        '
        'ProvinciaBindingSource
        '
        Me.ProvinciaBindingSource.DataMember = "Provincia"
        Me.ProvinciaBindingSource.DataSource = Me.ElectrodomesticosDataSet
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(476, 178)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(222, 26)
        Me.TxtEmail.TabIndex = 16
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Location = New System.Drawing.Point(386, 184)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(52, 20)
        Me.LblEmail.TabIndex = 15
        Me.LblEmail.Text = "Email:"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(476, 128)
        Me.TxtTelefono.MaxLength = 8
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(222, 26)
        Me.TxtTelefono.TabIndex = 14
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.Location = New System.Drawing.Point(377, 122)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(75, 20)
        Me.LblTelefono.TabIndex = 13
        Me.LblTelefono.Text = "Telefono:"
        '
        'TxtLocalidad
        '
        Me.TxtLocalidad.Location = New System.Drawing.Point(476, 33)
        Me.TxtLocalidad.Name = "TxtLocalidad"
        Me.TxtLocalidad.Size = New System.Drawing.Size(222, 26)
        Me.TxtLocalidad.TabIndex = 10
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(137, 178)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(222, 26)
        Me.TxtDireccion.TabIndex = 9
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(137, 122)
        Me.TxtApellido.MaxLength = 100
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(222, 26)
        Me.TxtApellido.TabIndex = 8
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(137, 75)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(222, 26)
        Me.TxtNombre.TabIndex = 7
        '
        'TxtDNI
        '
        Me.TxtDNI.Location = New System.Drawing.Point(137, 33)
        Me.TxtDNI.MaxLength = 8
        Me.TxtDNI.Name = "TxtDNI"
        Me.TxtDNI.Size = New System.Drawing.Size(222, 26)
        Me.TxtDNI.TabIndex = 6
        '
        'LblProvincia
        '
        Me.LblProvincia.AutoSize = True
        Me.LblProvincia.Location = New System.Drawing.Point(376, 76)
        Me.LblProvincia.Name = "LblProvincia"
        Me.LblProvincia.Size = New System.Drawing.Size(76, 20)
        Me.LblProvincia.TabIndex = 5
        Me.LblProvincia.Text = "Provincia:"
        '
        'LblLocalidad
        '
        Me.LblLocalidad.AutoSize = True
        Me.LblLocalidad.Location = New System.Drawing.Point(376, 33)
        Me.LblLocalidad.Name = "LblLocalidad"
        Me.LblLocalidad.Size = New System.Drawing.Size(81, 20)
        Me.LblLocalidad.TabIndex = 4
        Me.LblLocalidad.Text = "Localidad:"
        '
        'LblDireccion
        '
        Me.LblDireccion.AutoSize = True
        Me.LblDireccion.Location = New System.Drawing.Point(37, 181)
        Me.LblDireccion.Name = "LblDireccion"
        Me.LblDireccion.Size = New System.Drawing.Size(79, 20)
        Me.LblDireccion.TabIndex = 3
        Me.LblDireccion.Text = "Direccion:"
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.Location = New System.Drawing.Point(37, 122)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(69, 20)
        Me.LblApellido.TabIndex = 2
        Me.LblApellido.Text = "Apellido:"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(37, 75)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(69, 20)
        Me.LblNombre.TabIndex = 1
        Me.LblNombre.Text = "Nombre:"
        '
        'LblDNI
        '
        Me.LblDNI.AutoSize = True
        Me.LblDNI.Location = New System.Drawing.Point(37, 33)
        Me.LblDNI.Name = "LblDNI"
        Me.LblDNI.Size = New System.Drawing.Size(41, 20)
        Me.LblDNI.TabIndex = 0
        Me.LblDNI.Text = "DNI:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(312, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 31)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Lista de Clientes"
        '
        'ProvinciaTableAdapter
        '
        Me.ProvinciaTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.refrescar
        Me.Button2.Location = New System.Drawing.Point(761, 12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(43, 37)
        Me.Button2.TabIndex = 57
        Me.Button2.UseVisualStyleBackColor = True
        '
        'listarClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(843, 660)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GBalta)
        Me.Controls.Add(Me.LAgregar)
        Me.Controls.Add(Me.GPBuscador)
        Me.Controls.Add(Me.ClientesDataGridView)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "listarClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Clientes"
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElectrodomesticosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GPBuscador.ResumeLayout(False)
        Me.GPBuscador.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBalta.ResumeLayout(False)
        Me.GBalta.PerformLayout()
        CType(Me.ProvinciaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ClientesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ElectrodomesticosDataSet As ElectrodomesticosLMJVA.ElectrodomesticosDataSet
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents GPBuscador As System.Windows.Forms.GroupBox
    Friend WithEvents LblBuscador As System.Windows.Forms.Label
    Friend WithEvents TApellido As System.Windows.Forms.TextBox
    Friend WithEvents LblBuscarDni As System.Windows.Forms.Label
    Friend WithEvents LblBuscarApellido As System.Windows.Forms.Label
    Friend WithEvents TDNI As System.Windows.Forms.TextBox
    Friend WithEvents LAgregar As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GBalta As System.Windows.Forms.GroupBox
    Friend WithEvents BEditar As System.Windows.Forms.Button
    Friend WithEvents CBProvincia As System.Windows.Forms.ComboBox
    Friend WithEvents TxtEmail As System.Windows.Forms.TextBox
    Friend WithEvents LblEmail As System.Windows.Forms.Label
    Friend WithEvents TxtTelefono As System.Windows.Forms.TextBox
    Friend WithEvents LblTelefono As System.Windows.Forms.Label
    Friend WithEvents TxtLocalidad As System.Windows.Forms.TextBox
    Friend WithEvents TxtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents TxtApellido As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents TxtDNI As System.Windows.Forms.TextBox
    Friend WithEvents LblProvincia As System.Windows.Forms.Label
    Friend WithEvents LblLocalidad As System.Windows.Forms.Label
    Friend WithEvents LblDireccion As System.Windows.Forms.Label
    Friend WithEvents LblApellido As System.Windows.Forms.Label
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents LblDNI As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProvinciaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProvinciaTableAdapter As ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.ProvinciaTableAdapter
    Friend WithEvents DNIclienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApellidoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents localidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProvinciaNombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado_cliente As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Bagregar As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
