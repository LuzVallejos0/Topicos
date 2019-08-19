<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AMClientes
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
        Me.LBaja = New System.Windows.Forms.Label()
        Me.LModificar = New System.Windows.Forms.Label()
        Me.ClientesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DNIclienteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocalidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProvinciaNombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.estado_cliente = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ElectrodomesticosDataSet = New ElectrodomesticosLMJVA.ElectrodomesticosDataSet()
        Me.GPbotones = New System.Windows.Forms.GroupBox()
        Me.BAgregar = New System.Windows.Forms.Button()
        Me.BLimpiar = New System.Windows.Forms.Button()
        Me.BEditar = New System.Windows.Forms.Button()
        Me.GPBuscador = New System.Windows.Forms.GroupBox()
        Me.PicFotoBuscar = New System.Windows.Forms.PictureBox()
        Me.LblBuscador = New System.Windows.Forms.Label()
        Me.TApellido = New System.Windows.Forms.TextBox()
        Me.LblBuscarDni = New System.Windows.Forms.Label()
        Me.LblBuscarApellido = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TDNI = New System.Windows.Forms.TextBox()
        Me.LblClientes = New System.Windows.Forms.Label()
        Me.BVolver = New System.Windows.Forms.Button()
        Me.GBalta = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblCampos = New System.Windows.Forms.Label()
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
        Me.ClientesTableAdapter = New ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.ClientesTableAdapter()
        Me.ProvinciaTableAdapter = New ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.ProvinciaTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElectrodomesticosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GPbotones.SuspendLayout()
        Me.GPBuscador.SuspendLayout()
        CType(Me.PicFotoBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBalta.SuspendLayout()
        CType(Me.ProvinciaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBaja
        '
        Me.LBaja.AutoSize = True
        Me.LBaja.BackColor = System.Drawing.Color.Transparent
        Me.LBaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBaja.ForeColor = System.Drawing.Color.YellowGreen
        Me.LBaja.Location = New System.Drawing.Point(12, 639)
        Me.LBaja.Name = "LBaja"
        Me.LBaja.Size = New System.Drawing.Size(173, 18)
        Me.LBaja.TabIndex = 40
        Me.LBaja.Text = "* Cliente dado de baja"
        '
        'LModificar
        '
        Me.LModificar.AutoSize = True
        Me.LModificar.BackColor = System.Drawing.Color.Transparent
        Me.LModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LModificar.ForeColor = System.Drawing.Color.DarkBlue
        Me.LModificar.Location = New System.Drawing.Point(12, 399)
        Me.LModificar.Name = "LModificar"
        Me.LModificar.Size = New System.Drawing.Size(294, 18)
        Me.LModificar.TabIndex = 39
        Me.LModificar.Text = "(Doble click para modificar un cliente)"
        '
        'ClientesDataGridView
        '
        Me.ClientesDataGridView.AllowUserToAddRows = False
        Me.ClientesDataGridView.AllowUserToDeleteRows = False
        Me.ClientesDataGridView.AutoGenerateColumns = False
        Me.ClientesDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ClientesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DNIclienteDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ApellidoDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn, Me.LocalidadDataGridViewTextBoxColumn, Me.ProvinciaNombre, Me.TelefonoDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.estado_cliente})
        Me.ClientesDataGridView.DataSource = Me.ClientesBindingSource
        Me.ClientesDataGridView.Location = New System.Drawing.Point(12, 420)
        Me.ClientesDataGridView.Name = "ClientesDataGridView"
        Me.ClientesDataGridView.ReadOnly = True
        Me.ClientesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ClientesDataGridView.Size = New System.Drawing.Size(916, 213)
        Me.ClientesDataGridView.TabIndex = 38
        '
        'DNIclienteDataGridViewTextBoxColumn
        '
        Me.DNIclienteDataGridViewTextBoxColumn.DataPropertyName = "DNI_cliente"
        Me.DNIclienteDataGridViewTextBoxColumn.HeaderText = "DNI Cliente"
        Me.DNIclienteDataGridViewTextBoxColumn.Name = "DNIclienteDataGridViewTextBoxColumn"
        Me.DNIclienteDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ApellidoDataGridViewTextBoxColumn
        '
        Me.ApellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido"
        Me.ApellidoDataGridViewTextBoxColumn.HeaderText = "Apellido"
        Me.ApellidoDataGridViewTextBoxColumn.Name = "ApellidoDataGridViewTextBoxColumn"
        Me.ApellidoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "Dirección"
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        Me.DireccionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LocalidadDataGridViewTextBoxColumn
        '
        Me.LocalidadDataGridViewTextBoxColumn.DataPropertyName = "localidad"
        Me.LocalidadDataGridViewTextBoxColumn.HeaderText = "Localidad"
        Me.LocalidadDataGridViewTextBoxColumn.Name = "LocalidadDataGridViewTextBoxColumn"
        Me.LocalidadDataGridViewTextBoxColumn.ReadOnly = True
        Me.LocalidadDataGridViewTextBoxColumn.Width = 90
        '
        'ProvinciaNombre
        '
        Me.ProvinciaNombre.DataPropertyName = "ProvinciaNombre"
        Me.ProvinciaNombre.HeaderText = "Provincia"
        Me.ProvinciaNombre.Name = "ProvinciaNombre"
        Me.ProvinciaNombre.ReadOnly = True
        Me.ProvinciaNombre.Width = 90
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Télefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TelefonoDataGridViewTextBoxColumn.Width = 90
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmailDataGridViewTextBoxColumn.Width = 80
        '
        'estado_cliente
        '
        Me.estado_cliente.DataPropertyName = "estado_cliente"
        Me.estado_cliente.HeaderText = "Estado (Chekeado=""Activo, No Chekeado= ""Dado de Baja"")"
        Me.estado_cliente.Name = "estado_cliente"
        Me.estado_cliente.ReadOnly = True
        Me.estado_cliente.Width = 150
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
        'GPbotones
        '
        Me.GPbotones.BackColor = System.Drawing.Color.Transparent
        Me.GPbotones.Controls.Add(Me.BAgregar)
        Me.GPbotones.Controls.Add(Me.BLimpiar)
        Me.GPbotones.Controls.Add(Me.BEditar)
        Me.GPbotones.Location = New System.Drawing.Point(478, 252)
        Me.GPbotones.Name = "GPbotones"
        Me.GPbotones.Size = New System.Drawing.Size(450, 144)
        Me.GPbotones.TabIndex = 37
        Me.GPbotones.TabStop = False
        '
        'BAgregar
        '
        Me.BAgregar.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.agregar
        Me.BAgregar.Location = New System.Drawing.Point(43, 34)
        Me.BAgregar.Name = "BAgregar"
        Me.BAgregar.Size = New System.Drawing.Size(87, 88)
        Me.BAgregar.TabIndex = 2
        Me.BAgregar.UseVisualStyleBackColor = True
        '
        'BLimpiar
        '
        Me.BLimpiar.BackColor = System.Drawing.Color.Transparent
        Me.BLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BLimpiar.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.escoba
        Me.BLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BLimpiar.Location = New System.Drawing.Point(336, 59)
        Me.BLimpiar.Name = "BLimpiar"
        Me.BLimpiar.Size = New System.Drawing.Size(105, 39)
        Me.BLimpiar.TabIndex = 12
        Me.BLimpiar.Text = "Borrar"
        Me.BLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BLimpiar.UseVisualStyleBackColor = False
        '
        'BEditar
        '
        Me.BEditar.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.editar
        Me.BEditar.Location = New System.Drawing.Point(195, 34)
        Me.BEditar.Name = "BEditar"
        Me.BEditar.Size = New System.Drawing.Size(87, 88)
        Me.BEditar.TabIndex = 4
        Me.BEditar.UseVisualStyleBackColor = True
        '
        'GPBuscador
        '
        Me.GPBuscador.BackColor = System.Drawing.Color.Transparent
        Me.GPBuscador.Controls.Add(Me.Button2)
        Me.GPBuscador.Controls.Add(Me.PicFotoBuscar)
        Me.GPBuscador.Controls.Add(Me.LblBuscador)
        Me.GPBuscador.Controls.Add(Me.TApellido)
        Me.GPBuscador.Controls.Add(Me.LblBuscarDni)
        Me.GPBuscador.Controls.Add(Me.LblBuscarApellido)
        Me.GPBuscador.Controls.Add(Me.DateTimePicker1)
        Me.GPBuscador.Controls.Add(Me.TDNI)
        Me.GPBuscador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GPBuscador.Location = New System.Drawing.Point(478, 9)
        Me.GPBuscador.Name = "GPBuscador"
        Me.GPBuscador.Size = New System.Drawing.Size(447, 237)
        Me.GPBuscador.TabIndex = 36
        Me.GPBuscador.TabStop = False
        '
        'PicFotoBuscar
        '
        Me.PicFotoBuscar.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.buscarCliente
        Me.PicFotoBuscar.Location = New System.Drawing.Point(313, 96)
        Me.PicFotoBuscar.Name = "PicFotoBuscar"
        Me.PicFotoBuscar.Size = New System.Drawing.Size(128, 130)
        Me.PicFotoBuscar.TabIndex = 12
        Me.PicFotoBuscar.TabStop = False
        '
        'LblBuscador
        '
        Me.LblBuscador.AutoSize = True
        Me.LblBuscador.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBuscador.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.LblBuscador.Location = New System.Drawing.Point(99, 56)
        Me.LblBuscador.Name = "LblBuscador"
        Me.LblBuscador.Size = New System.Drawing.Size(237, 25)
        Me.LblBuscador.TabIndex = 5
        Me.LblBuscador.Text = "Buscador de Clientes" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'TApellido
        '
        Me.TApellido.Location = New System.Drawing.Point(114, 191)
        Me.TApellido.Name = "TApellido"
        Me.TApellido.Size = New System.Drawing.Size(178, 22)
        Me.TApellido.TabIndex = 10
        '
        'LblBuscarDni
        '
        Me.LblBuscarDni.AutoSize = True
        Me.LblBuscarDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBuscarDni.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.LblBuscarDni.Location = New System.Drawing.Point(39, 122)
        Me.LblBuscarDni.Name = "LblBuscarDni"
        Me.LblBuscarDni.Size = New System.Drawing.Size(41, 20)
        Me.LblBuscarDni.TabIndex = 6
        Me.LblBuscarDni.Text = "DNI:"
        '
        'LblBuscarApellido
        '
        Me.LblBuscarApellido.AutoSize = True
        Me.LblBuscarApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBuscarApellido.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.LblBuscarApellido.Location = New System.Drawing.Point(39, 191)
        Me.LblBuscarApellido.Name = "LblBuscarApellido"
        Me.LblBuscarApellido.Size = New System.Drawing.Size(69, 20)
        Me.LblBuscarApellido.TabIndex = 9
        Me.LblBuscarApellido.Text = "Apellido:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(6, 19)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(439, 22)
        Me.DateTimePicker1.TabIndex = 7
        '
        'TDNI
        '
        Me.TDNI.Location = New System.Drawing.Point(114, 121)
        Me.TDNI.MaxLength = 8
        Me.TDNI.Name = "TDNI"
        Me.TDNI.Size = New System.Drawing.Size(178, 22)
        Me.TDNI.TabIndex = 7
        '
        'LblClientes
        '
        Me.LblClientes.AutoSize = True
        Me.LblClientes.BackColor = System.Drawing.Color.Transparent
        Me.LblClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblClientes.ForeColor = System.Drawing.Color.Transparent
        Me.LblClientes.Location = New System.Drawing.Point(21, 9)
        Me.LblClientes.Name = "LblClientes"
        Me.LblClientes.Size = New System.Drawing.Size(50, 376)
        Me.LblClientes.TabIndex = 35
        Me.LblClientes.Text = "C" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "L" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " I" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "E" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "N" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "T" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "E" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "S"
        '
        'BVolver
        '
        Me.BVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BVolver.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.espalda__1_
        Me.BVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BVolver.Location = New System.Drawing.Point(820, 630)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(108, 48)
        Me.BVolver.TabIndex = 34
        Me.BVolver.Text = "Volver"
        Me.BVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BVolver.UseVisualStyleBackColor = True
        '
        'GBalta
        '
        Me.GBalta.BackColor = System.Drawing.Color.Transparent
        Me.GBalta.Controls.Add(Me.Label8)
        Me.GBalta.Controls.Add(Me.Label7)
        Me.GBalta.Controls.Add(Me.Label6)
        Me.GBalta.Controls.Add(Me.Label5)
        Me.GBalta.Controls.Add(Me.Label4)
        Me.GBalta.Controls.Add(Me.Label3)
        Me.GBalta.Controls.Add(Me.Label1)
        Me.GBalta.Controls.Add(Me.Label2)
        Me.GBalta.Controls.Add(Me.LblCampos)
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
        Me.GBalta.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.GBalta.Location = New System.Drawing.Point(77, 9)
        Me.GBalta.Name = "GBalta"
        Me.GBalta.Size = New System.Drawing.Size(384, 387)
        Me.GBalta.TabIndex = 33
        Me.GBalta.TabStop = False
        Me.GBalta.Text = "Agregar Clientes"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label8.Location = New System.Drawing.Point(14, 256)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(15, 20)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label7.Location = New System.Drawing.Point(15, 302)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 20)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label6.Location = New System.Drawing.Point(15, 349)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 20)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label5.Location = New System.Drawing.Point(14, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 20)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label4.Location = New System.Drawing.Point(14, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 20)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label3.Location = New System.Drawing.Point(14, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(15, 20)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label1.Location = New System.Drawing.Point(14, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 20)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label2.Location = New System.Drawing.Point(14, 213)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 20)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "*"
        '
        'LblCampos
        '
        Me.LblCampos.AutoSize = True
        Me.LblCampos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCampos.ForeColor = System.Drawing.Color.GreenYellow
        Me.LblCampos.Location = New System.Drawing.Point(200, 12)
        Me.LblCampos.Name = "LblCampos"
        Me.LblCampos.Size = New System.Drawing.Size(159, 18)
        Me.LblCampos.TabIndex = 18
        Me.LblCampos.Text = "* Campos Obligatorios"
        '
        'CBProvincia
        '
        Me.CBProvincia.DataSource = Me.ProvinciaBindingSource
        Me.CBProvincia.DisplayMember = "nombre"
        Me.CBProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBProvincia.FormattingEnabled = True
        Me.CBProvincia.Location = New System.Drawing.Point(135, 259)
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
        Me.TxtEmail.Location = New System.Drawing.Point(135, 346)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(222, 26)
        Me.TxtEmail.TabIndex = 16
        '
        'LblEmail
        '
        Me.LblEmail.AutoSize = True
        Me.LblEmail.Location = New System.Drawing.Point(36, 349)
        Me.LblEmail.Name = "LblEmail"
        Me.LblEmail.Size = New System.Drawing.Size(52, 20)
        Me.LblEmail.TabIndex = 15
        Me.LblEmail.Text = "Email:"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(135, 308)
        Me.TxtTelefono.MaxLength = 8
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(222, 26)
        Me.TxtTelefono.TabIndex = 14
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.Location = New System.Drawing.Point(36, 302)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(75, 20)
        Me.LblTelefono.TabIndex = 13
        Me.LblTelefono.Text = "Telefono:"
        '
        'TxtLocalidad
        '
        Me.TxtLocalidad.Location = New System.Drawing.Point(135, 213)
        Me.TxtLocalidad.Name = "TxtLocalidad"
        Me.TxtLocalidad.Size = New System.Drawing.Size(222, 26)
        Me.TxtLocalidad.TabIndex = 10
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(135, 172)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(222, 26)
        Me.TxtDireccion.TabIndex = 9
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(135, 132)
        Me.TxtApellido.MaxLength = 100
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(222, 26)
        Me.TxtApellido.TabIndex = 8
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(135, 88)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(222, 26)
        Me.TxtNombre.TabIndex = 7
        '
        'TxtDNI
        '
        Me.TxtDNI.Location = New System.Drawing.Point(135, 46)
        Me.TxtDNI.MaxLength = 8
        Me.TxtDNI.Name = "TxtDNI"
        Me.TxtDNI.Size = New System.Drawing.Size(222, 26)
        Me.TxtDNI.TabIndex = 6
        '
        'LblProvincia
        '
        Me.LblProvincia.AutoSize = True
        Me.LblProvincia.Location = New System.Drawing.Point(35, 256)
        Me.LblProvincia.Name = "LblProvincia"
        Me.LblProvincia.Size = New System.Drawing.Size(76, 20)
        Me.LblProvincia.TabIndex = 5
        Me.LblProvincia.Text = "Provincia:"
        '
        'LblLocalidad
        '
        Me.LblLocalidad.AutoSize = True
        Me.LblLocalidad.Location = New System.Drawing.Point(35, 213)
        Me.LblLocalidad.Name = "LblLocalidad"
        Me.LblLocalidad.Size = New System.Drawing.Size(81, 20)
        Me.LblLocalidad.TabIndex = 4
        Me.LblLocalidad.Text = "Localidad:"
        '
        'LblDireccion
        '
        Me.LblDireccion.AutoSize = True
        Me.LblDireccion.Location = New System.Drawing.Point(35, 172)
        Me.LblDireccion.Name = "LblDireccion"
        Me.LblDireccion.Size = New System.Drawing.Size(79, 20)
        Me.LblDireccion.TabIndex = 3
        Me.LblDireccion.Text = "Direccion:"
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.Location = New System.Drawing.Point(35, 132)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(69, 20)
        Me.LblApellido.TabIndex = 2
        Me.LblApellido.Text = "Apellido:"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(35, 88)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(69, 20)
        Me.LblNombre.TabIndex = 1
        Me.LblNombre.Text = "Nombre:"
        '
        'LblDNI
        '
        Me.LblDNI.AutoSize = True
        Me.LblDNI.Location = New System.Drawing.Point(35, 46)
        Me.LblDNI.Name = "LblDNI"
        Me.LblDNI.Size = New System.Drawing.Size(41, 20)
        Me.LblDNI.TabIndex = 0
        Me.LblDNI.Text = "DNI:"
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'ProvinciaTableAdapter
        '
        Me.ProvinciaTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.refrescar
        Me.Button2.Location = New System.Drawing.Point(398, 47)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(43, 37)
        Me.Button2.TabIndex = 57
        Me.Button2.UseVisualStyleBackColor = True
        '
        'AMClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ElectrodomesticosLMJVA.My.Resources.Resources.fondoclaro
        Me.ClientSize = New System.Drawing.Size(940, 681)
        Me.ControlBox = False
        Me.Controls.Add(Me.LBaja)
        Me.Controls.Add(Me.LModificar)
        Me.Controls.Add(Me.ClientesDataGridView)
        Me.Controls.Add(Me.GPbotones)
        Me.Controls.Add(Me.GPBuscador)
        Me.Controls.Add(Me.LblClientes)
        Me.Controls.Add(Me.BVolver)
        Me.Controls.Add(Me.GBalta)
        Me.Name = "AMClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar y Modificar Clientes"
        CType(Me.ClientesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElectrodomesticosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GPbotones.ResumeLayout(False)
        Me.GPBuscador.ResumeLayout(False)
        Me.GPBuscador.PerformLayout()
        CType(Me.PicFotoBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBalta.ResumeLayout(False)
        Me.GBalta.PerformLayout()
        CType(Me.ProvinciaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBaja As System.Windows.Forms.Label
    Friend WithEvents LModificar As System.Windows.Forms.Label
    Friend WithEvents ClientesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents GPbotones As System.Windows.Forms.GroupBox
    Friend WithEvents BAgregar As System.Windows.Forms.Button
    Friend WithEvents BLimpiar As System.Windows.Forms.Button
    Friend WithEvents BEditar As System.Windows.Forms.Button
    Friend WithEvents GPBuscador As System.Windows.Forms.GroupBox
    Friend WithEvents PicFotoBuscar As System.Windows.Forms.PictureBox
    Friend WithEvents LblBuscador As System.Windows.Forms.Label
    Friend WithEvents TApellido As System.Windows.Forms.TextBox
    Friend WithEvents LblBuscarDni As System.Windows.Forms.Label
    Friend WithEvents LblBuscarApellido As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TDNI As System.Windows.Forms.TextBox
    Friend WithEvents LblClientes As System.Windows.Forms.Label
    Friend WithEvents BVolver As System.Windows.Forms.Button
    Friend WithEvents GBalta As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LblCampos As System.Windows.Forms.Label
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
    Friend WithEvents ElectrodomesticosDataSet As ElectrodomesticosLMJVA.ElectrodomesticosDataSet
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents ProvinciaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProvinciaTableAdapter As ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.ProvinciaTableAdapter
    Friend WithEvents DNIclienteDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApellidoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LocalidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProvinciaNombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado_cliente As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
