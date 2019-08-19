<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMUsuario
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CBID_empleado = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BAgregar = New System.Windows.Forms.Button()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.CBTipoUsuario = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CBTipo = New System.Windows.Forms.ComboBox()
        Me.TipoUsuarioBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ElectrodomesticosDataSet = New ElectrodomesticosLMJVA.ElectrodomesticosDataSet()
        Me.txtClave = New System.Windows.Forms.TextBox()
        Me.txtUsuarios = New System.Windows.Forms.TextBox()
        Me.Agregar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.LblApellido = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.BEliminar = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.UsuariosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DNIempleadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsuarioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContraseñaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadousuarioDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BActivar = New System.Windows.Forms.Button()
        Me.BEditar = New System.Windows.Forms.Button()
        Me.GBotones = New System.Windows.Forms.GroupBox()
        Me.BVolver = New System.Windows.Forms.Button()
        Me.UsuariosTableAdapter = New ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.UsuariosTableAdapter()
        Me.TipoUsuarioTableAdapter = New ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.TipoUsuarioTableAdapter()
        Me.EmpleadosTableAdapter = New ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.EmpleadosTableAdapter()
        Me.lblEmpleados = New System.Windows.Forms.Label()
        Me.EmpleadosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DniempleadoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripción = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocalidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreProvinciaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoempleadoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.txtApellidoBuscar = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.TipoUsuarioBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElectrodomesticosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.UsuariosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBotones.SuspendLayout()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Me.CBID_empleado)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.BAgregar)
        Me.GroupBox1.Controls.Add(Me.txtUsuario)
        Me.GroupBox1.Controls.Add(Me.txtContraseña)
        Me.GroupBox1.Controls.Add(Me.CBTipoUsuario)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(-335, -4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(241, 268)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Agregar Usuario"
        '
        'CBID_empleado
        '
        Me.CBID_empleado.DisplayMember = "dni_empleado"
        Me.CBID_empleado.FormattingEnabled = True
        Me.CBID_empleado.Location = New System.Drawing.Point(103, 27)
        Me.CBID_empleado.Name = "CBID_empleado"
        Me.CBID_empleado.Size = New System.Drawing.Size(121, 24)
        Me.CBID_empleado.TabIndex = 10
        Me.CBID_empleado.TabStop = False
        Me.CBID_empleado.ValueMember = "dni_empleado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "ID Empleado:"
        '
        'BAgregar
        '
        Me.BAgregar.Location = New System.Drawing.Point(148, 207)
        Me.BAgregar.Name = "BAgregar"
        Me.BAgregar.Size = New System.Drawing.Size(75, 24)
        Me.BAgregar.TabIndex = 8
        Me.BAgregar.Text = "Agregar"
        Me.BAgregar.UseVisualStyleBackColor = True
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(102, 77)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(121, 22)
        Me.txtUsuario.TabIndex = 6
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(103, 122)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(121, 22)
        Me.txtContraseña.TabIndex = 5
        '
        'CBTipoUsuario
        '
        Me.CBTipoUsuario.DisplayMember = "Descripcion"
        Me.CBTipoUsuario.FormattingEnabled = True
        Me.CBTipoUsuario.Location = New System.Drawing.Point(103, 164)
        Me.CBTipoUsuario.Name = "CBTipoUsuario"
        Me.CBTipoUsuario.Size = New System.Drawing.Size(121, 24)
        Me.CBTipoUsuario.TabIndex = 4
        Me.CBTipoUsuario.ValueMember = "id_tipoUsuario"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 16)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tipo Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Contraseña:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Usuario :"
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(14, 175)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(68, 18)
        Me.lblUsuario.TabIndex = 1
        Me.lblUsuario.Text = "Usuario :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 219)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 18)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Contraseña:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 264)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 18)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Tipo Usuario:"
        '
        'CBTipo
        '
        Me.CBTipo.DataSource = Me.TipoUsuarioBindingSource
        Me.CBTipo.DisplayMember = "Descripcion"
        Me.CBTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBTipo.FormattingEnabled = True
        Me.CBTipo.Location = New System.Drawing.Point(132, 258)
        Me.CBTipo.Name = "CBTipo"
        Me.CBTipo.Size = New System.Drawing.Size(147, 26)
        Me.CBTipo.TabIndex = 4
        Me.CBTipo.ValueMember = "id_tipoUsuario"
        '
        'TipoUsuarioBindingSource
        '
        Me.TipoUsuarioBindingSource.DataMember = "TipoUsuario"
        Me.TipoUsuarioBindingSource.DataSource = Me.ElectrodomesticosDataSet
        '
        'ElectrodomesticosDataSet
        '
        Me.ElectrodomesticosDataSet.DataSetName = "ElectrodomesticosDataSet"
        Me.ElectrodomesticosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtClave
        '
        Me.txtClave.Location = New System.Drawing.Point(132, 218)
        Me.txtClave.Name = "txtClave"
        Me.txtClave.Size = New System.Drawing.Size(147, 24)
        Me.txtClave.TabIndex = 5
        '
        'txtUsuarios
        '
        Me.txtUsuarios.Location = New System.Drawing.Point(132, 173)
        Me.txtUsuarios.Name = "txtUsuarios"
        Me.txtUsuarios.Size = New System.Drawing.Size(147, 24)
        Me.txtUsuarios.TabIndex = 6
        '
        'Agregar
        '
        Me.Agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Agregar.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.agregar
        Me.Agregar.Location = New System.Drawing.Point(6, 19)
        Me.Agregar.Name = "Agregar"
        Me.Agregar.Size = New System.Drawing.Size(90, 89)
        Me.Agregar.TabIndex = 8
        Me.Agregar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "DNI Empleado:"
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "Empleados"
        Me.EmpleadosBindingSource.DataSource = Me.ElectrodomesticosDataSet
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtDNI)
        Me.GroupBox2.Controls.Add(Me.TxtNombre)
        Me.GroupBox2.Controls.Add(Me.txtApellido)
        Me.GroupBox2.Controls.Add(Me.LblApellido)
        Me.GroupBox2.Controls.Add(Me.lblNombre)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtUsuarios)
        Me.GroupBox2.Controls.Add(Me.txtClave)
        Me.GroupBox2.Controls.Add(Me.CBTipo)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.lblUsuario)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(296, 309)
        Me.GroupBox2.TabIndex = 16
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Agregar Usuario"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label8.Location = New System.Drawing.Point(124, 14)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(166, 16)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "* Seleccione un empleado"
        '
        'txtDNI
        '
        Me.txtDNI.Location = New System.Drawing.Point(132, 130)
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(147, 24)
        Me.txtDNI.TabIndex = 15
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(132, 85)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(147, 24)
        Me.TxtNombre.TabIndex = 14
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(132, 45)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(147, 24)
        Me.txtApellido.TabIndex = 13
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.Location = New System.Drawing.Point(14, 45)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(63, 18)
        Me.LblApellido.TabIndex = 12
        Me.LblApellido.Text = "Apellido:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(14, 85)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(66, 18)
        Me.lblNombre.TabIndex = 11
        Me.lblNombre.Text = "Nombre:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'BEliminar
        '
        Me.BEliminar.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.eliminar
        Me.BEliminar.Location = New System.Drawing.Point(99, 19)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Size = New System.Drawing.Size(90, 89)
        Me.BEliminar.TabIndex = 11
        Me.BEliminar.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(504, 15)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(205, 39)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "USUARIOS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'UsuariosDataGridView
        '
        Me.UsuariosDataGridView.AllowUserToAddRows = False
        Me.UsuariosDataGridView.AllowUserToDeleteRows = False
        Me.UsuariosDataGridView.AutoGenerateColumns = False
        Me.UsuariosDataGridView.BackgroundColor = System.Drawing.SystemColors.InactiveBorder
        Me.UsuariosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsuariosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DNIempleadoDataGridViewTextBoxColumn, Me.Nombre, Me.apellido, Me.UsuarioDataGridViewTextBoxColumn, Me.ContraseñaDataGridViewTextBoxColumn, Me.Descripcion, Me.EstadousuarioDataGridViewCheckBoxColumn})
        Me.UsuariosDataGridView.DataSource = Me.UsuariosBindingSource
        Me.UsuariosDataGridView.Location = New System.Drawing.Point(314, 57)
        Me.UsuariosDataGridView.Name = "UsuariosDataGridView"
        Me.UsuariosDataGridView.ReadOnly = True
        Me.UsuariosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.UsuariosDataGridView.Size = New System.Drawing.Size(606, 267)
        Me.UsuariosDataGridView.TabIndex = 17
        '
        'DNIempleadoDataGridViewTextBoxColumn
        '
        Me.DNIempleadoDataGridViewTextBoxColumn.DataPropertyName = "DNI_empleado"
        Me.DNIempleadoDataGridViewTextBoxColumn.HeaderText = "DNI Empleado"
        Me.DNIempleadoDataGridViewTextBoxColumn.Name = "DNIempleadoDataGridViewTextBoxColumn"
        Me.DNIempleadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.DNIempleadoDataGridViewTextBoxColumn.Width = 80
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "nombre"
        Me.Nombre.HeaderText = "Nombre Empleado"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 90
        '
        'apellido
        '
        Me.apellido.DataPropertyName = "apellido"
        Me.apellido.HeaderText = "Apellido Empleado"
        Me.apellido.Name = "apellido"
        Me.apellido.ReadOnly = True
        Me.apellido.Width = 90
        '
        'UsuarioDataGridViewTextBoxColumn
        '
        Me.UsuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.HeaderText = "Usuario"
        Me.UsuarioDataGridViewTextBoxColumn.Name = "UsuarioDataGridViewTextBoxColumn"
        Me.UsuarioDataGridViewTextBoxColumn.ReadOnly = True
        Me.UsuarioDataGridViewTextBoxColumn.Width = 75
        '
        'ContraseñaDataGridViewTextBoxColumn
        '
        Me.ContraseñaDataGridViewTextBoxColumn.DataPropertyName = "Contraseña"
        Me.ContraseñaDataGridViewTextBoxColumn.HeaderText = "Contraseña"
        Me.ContraseñaDataGridViewTextBoxColumn.Name = "ContraseñaDataGridViewTextBoxColumn"
        Me.ContraseñaDataGridViewTextBoxColumn.ReadOnly = True
        Me.ContraseñaDataGridViewTextBoxColumn.Width = 70
        '
        'Descripcion
        '
        Me.Descripcion.DataPropertyName = "Descripcion"
        Me.Descripcion.HeaderText = "Tipo Usuario"
        Me.Descripcion.Name = "Descripcion"
        Me.Descripcion.ReadOnly = True
        Me.Descripcion.Width = 75
        '
        'EstadousuarioDataGridViewCheckBoxColumn
        '
        Me.EstadousuarioDataGridViewCheckBoxColumn.DataPropertyName = "estado_usuario"
        Me.EstadousuarioDataGridViewCheckBoxColumn.HeaderText = "Estado del Usuario"
        Me.EstadousuarioDataGridViewCheckBoxColumn.Name = "EstadousuarioDataGridViewCheckBoxColumn"
        Me.EstadousuarioDataGridViewCheckBoxColumn.ReadOnly = True
        Me.EstadousuarioDataGridViewCheckBoxColumn.Width = 90
        '
        'UsuariosBindingSource
        '
        Me.UsuariosBindingSource.DataMember = "Usuarios"
        Me.UsuariosBindingSource.DataSource = Me.ElectrodomesticosDataSet
        '
        'BActivar
        '
        Me.BActivar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BActivar.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.aceptar
        Me.BActivar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BActivar.Location = New System.Drawing.Point(102, 166)
        Me.BActivar.Name = "BActivar"
        Me.BActivar.Size = New System.Drawing.Size(87, 46)
        Me.BActivar.TabIndex = 20
        Me.BActivar.Text = "Dar de" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Alta"
        Me.BActivar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BActivar.UseVisualStyleBackColor = True
        '
        'BEditar
        '
        Me.BEditar.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.editar
        Me.BEditar.Location = New System.Drawing.Point(6, 145)
        Me.BEditar.Name = "BEditar"
        Me.BEditar.Size = New System.Drawing.Size(90, 89)
        Me.BEditar.TabIndex = 21
        Me.BEditar.UseVisualStyleBackColor = True
        '
        'GBotones
        '
        Me.GBotones.BackColor = System.Drawing.Color.Transparent
        Me.GBotones.Controls.Add(Me.BEditar)
        Me.GBotones.Controls.Add(Me.BActivar)
        Me.GBotones.Controls.Add(Me.BEliminar)
        Me.GBotones.Controls.Add(Me.Agregar)
        Me.GBotones.Location = New System.Drawing.Point(12, 385)
        Me.GBotones.Name = "GBotones"
        Me.GBotones.Size = New System.Drawing.Size(202, 245)
        Me.GBotones.TabIndex = 23
        Me.GBotones.TabStop = False
        '
        'BVolver
        '
        Me.BVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BVolver.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.espalda__1_
        Me.BVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BVolver.Location = New System.Drawing.Point(812, 627)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(108, 48)
        Me.BVolver.TabIndex = 24
        Me.BVolver.Text = "Volver"
        Me.BVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BVolver.UseVisualStyleBackColor = True
        '
        'UsuariosTableAdapter
        '
        Me.UsuariosTableAdapter.ClearBeforeFill = True
        '
        'TipoUsuarioTableAdapter
        '
        Me.TipoUsuarioTableAdapter.ClearBeforeFill = True
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'lblEmpleados
        '
        Me.lblEmpleados.AutoSize = True
        Me.lblEmpleados.BackColor = System.Drawing.Color.Transparent
        Me.lblEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpleados.ForeColor = System.Drawing.Color.White
        Me.lblEmpleados.Location = New System.Drawing.Point(468, 352)
        Me.lblEmpleados.Name = "lblEmpleados"
        Me.lblEmpleados.Size = New System.Drawing.Size(241, 39)
        Me.lblEmpleados.TabIndex = 25
        Me.lblEmpleados.Text = "EMPLEADOS"
        '
        'EmpleadosDataGridView
        '
        Me.EmpleadosDataGridView.AllowUserToAddRows = False
        Me.EmpleadosDataGridView.AllowUserToDeleteRows = False
        Me.EmpleadosDataGridView.AutoGenerateColumns = False
        Me.EmpleadosDataGridView.BackgroundColor = System.Drawing.SystemColors.InactiveBorder
        Me.EmpleadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpleadosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DniempleadoDataGridViewTextBoxColumn1, Me.NombreDataGridViewTextBoxColumn, Me.ApellidoDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn, Me.descripción, Me.LocalidadDataGridViewTextBoxColumn, Me.NombreProvinciaDataGridViewTextBoxColumn, Me.TelefonoDataGridViewTextBoxColumn, Me.EstadoempleadoDataGridViewCheckBoxColumn})
        Me.EmpleadosDataGridView.DataSource = Me.EmpleadosBindingSource
        Me.EmpleadosDataGridView.Location = New System.Drawing.Point(220, 392)
        Me.EmpleadosDataGridView.Name = "EmpleadosDataGridView"
        Me.EmpleadosDataGridView.ReadOnly = True
        Me.EmpleadosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.EmpleadosDataGridView.Size = New System.Drawing.Size(700, 238)
        Me.EmpleadosDataGridView.TabIndex = 26
        '
        'DniempleadoDataGridViewTextBoxColumn1
        '
        Me.DniempleadoDataGridViewTextBoxColumn1.DataPropertyName = "dni_empleado"
        Me.DniempleadoDataGridViewTextBoxColumn1.HeaderText = "DNI"
        Me.DniempleadoDataGridViewTextBoxColumn1.Name = "DniempleadoDataGridViewTextBoxColumn1"
        Me.DniempleadoDataGridViewTextBoxColumn1.ReadOnly = True
        Me.DniempleadoDataGridViewTextBoxColumn1.Width = 65
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 70
        '
        'ApellidoDataGridViewTextBoxColumn
        '
        Me.ApellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido"
        Me.ApellidoDataGridViewTextBoxColumn.HeaderText = "Apellido"
        Me.ApellidoDataGridViewTextBoxColumn.Name = "ApellidoDataGridViewTextBoxColumn"
        Me.ApellidoDataGridViewTextBoxColumn.ReadOnly = True
        Me.ApellidoDataGridViewTextBoxColumn.Width = 70
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "Dirección"
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        Me.DireccionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DireccionDataGridViewTextBoxColumn.Width = 80
        '
        'descripción
        '
        Me.descripción.DataPropertyName = "descripción"
        Me.descripción.HeaderText = "TipoEmpleado"
        Me.descripción.Name = "descripción"
        Me.descripción.ReadOnly = True
        Me.descripción.Width = 90
        '
        'LocalidadDataGridViewTextBoxColumn
        '
        Me.LocalidadDataGridViewTextBoxColumn.DataPropertyName = "localidad"
        Me.LocalidadDataGridViewTextBoxColumn.HeaderText = "Localidad"
        Me.LocalidadDataGridViewTextBoxColumn.Name = "LocalidadDataGridViewTextBoxColumn"
        Me.LocalidadDataGridViewTextBoxColumn.ReadOnly = True
        Me.LocalidadDataGridViewTextBoxColumn.Width = 70
        '
        'NombreProvinciaDataGridViewTextBoxColumn
        '
        Me.NombreProvinciaDataGridViewTextBoxColumn.DataPropertyName = "NombreProvincia"
        Me.NombreProvinciaDataGridViewTextBoxColumn.HeaderText = "Provincia"
        Me.NombreProvinciaDataGridViewTextBoxColumn.Name = "NombreProvinciaDataGridViewTextBoxColumn"
        Me.NombreProvinciaDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreProvinciaDataGridViewTextBoxColumn.Width = 70
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Télefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TelefonoDataGridViewTextBoxColumn.Width = 60
        '
        'EstadoempleadoDataGridViewCheckBoxColumn
        '
        Me.EstadoempleadoDataGridViewCheckBoxColumn.DataPropertyName = "estado_empleado"
        Me.EstadoempleadoDataGridViewCheckBoxColumn.HeaderText = "Estado"
        Me.EstadoempleadoDataGridViewCheckBoxColumn.Name = "EstadoempleadoDataGridViewCheckBoxColumn"
        Me.EstadoempleadoDataGridViewCheckBoxColumn.ReadOnly = True
        Me.EstadoempleadoDataGridViewCheckBoxColumn.Width = 90
        '
        'txtApellidoBuscar
        '
        Me.txtApellidoBuscar.Location = New System.Drawing.Point(24, 28)
        Me.txtApellidoBuscar.Name = "txtApellidoBuscar"
        Me.txtApellidoBuscar.Size = New System.Drawing.Size(136, 20)
        Me.txtApellidoBuscar.TabIndex = 27
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(34, 7)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(114, 18)
        Me.Label10.TabIndex = 28
        Me.Label10.Text = "Buscar Apellido:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txtApellidoBuscar)
        Me.GroupBox3.Location = New System.Drawing.Point(752, 324)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(168, 62)
        Me.GroupBox3.TabIndex = 29
        Me.GroupBox3.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.YellowGreen
        Me.Label11.Location = New System.Drawing.Point(751, 38)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(169, 16)
        Me.Label11.TabIndex = 30
        Me.Label11.Text = "* Usuario dado de baja"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.DarkKhaki
        Me.Label12.Location = New System.Drawing.Point(311, 324)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(313, 18)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "(Double Click para modificar un usuario)"
        '
        'ABMUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ElectrodomesticosLMJVA.My.Resources.Resources.fondoclaro
        Me.ClientSize = New System.Drawing.Size(940, 681)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.EmpleadosDataGridView)
        Me.Controls.Add(Me.lblEmpleados)
        Me.Controls.Add(Me.BVolver)
        Me.Controls.Add(Me.GBotones)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.UsuariosDataGridView)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ABMUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar, Dar de baja y Modificar Usuarios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.TipoUsuarioBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElectrodomesticosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.UsuariosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBotones.ResumeLayout(False)
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents CBID_empleado As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents BAgregar As System.Windows.Forms.Button
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtContraseña As System.Windows.Forms.TextBox
    Friend WithEvents CBTipoUsuario As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblUsuario As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CBTipo As System.Windows.Forms.ComboBox
    Friend WithEvents txtClave As System.Windows.Forms.TextBox
    Friend WithEvents txtUsuarios As System.Windows.Forms.TextBox
    Friend WithEvents Agregar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ElectrodomesticosDataSet As ElectrodomesticosLMJVA.ElectrodomesticosDataSet
    Friend WithEvents UsuariosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsuariosTableAdapter As ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.UsuariosTableAdapter
    Friend WithEvents TipoUsuarioTableAdapter As ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.TipoUsuarioTableAdapter
    Friend WithEvents EmpleadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpleadosTableAdapter As ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.EmpleadosTableAdapter

    Friend WithEvents BEliminar As System.Windows.Forms.Button
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label9 As System.Windows.Forms.Label


    Friend WithEvents UsuariosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents BActivar As System.Windows.Forms.Button
    Friend WithEvents BEditar As System.Windows.Forms.Button
    Friend WithEvents GBotones As System.Windows.Forms.GroupBox
    Friend WithEvents BVolver As System.Windows.Forms.Button
    Friend WithEvents TipoUsuarioBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents txtDNI As System.Windows.Forms.TextBox
    Friend WithEvents TxtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents LblApellido As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents lblEmpleados As System.Windows.Forms.Label
    Friend WithEvents EmpleadosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DniempleadoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApellidoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripción As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LocalidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreProvinciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoempleadoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DNIempleadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents UsuarioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContraseñaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadousuarioDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents txtApellidoBuscar As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
End Class
