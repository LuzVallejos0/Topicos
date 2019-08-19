<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMEmpleados
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
        Me.BActivarEmpleado = New System.Windows.Forms.Button()
        Me.BLimpiar = New System.Windows.Forms.Button()
        Me.BAgregarEmpleado = New System.Windows.Forms.Button()
        Me.BEliminarEmpleado = New System.Windows.Forms.Button()
        Me.BEditarEmpleado = New System.Windows.Forms.Button()
        Me.DFecha = New System.Windows.Forms.DateTimePicker()
        Me.PicFotoBuscar = New System.Windows.Forms.PictureBox()
        Me.TApellidoEmpleado = New System.Windows.Forms.TextBox()
        Me.LblBuscarApellido = New System.Windows.Forms.Label()
        Me.TDNIEmpleado = New System.Windows.Forms.TextBox()
        Me.LblBuscarDni = New System.Windows.Forms.Label()
        Me.LblBuscador = New System.Windows.Forms.Label()
        Me.GBalta = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CBTipoEmpleado = New System.Windows.Forms.ComboBox()
        Me.TipoEmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ElectrodomesticosDataSet = New ElectrodomesticosLMJVA.ElectrodomesticosDataSet()
        Me.LblCampos = New System.Windows.Forms.Label()
        Me.CBProvincia = New System.Windows.Forms.ComboBox()
        Me.ProvinciaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.BVolver = New System.Windows.Forms.Button()
        Me.LblEmpleados = New System.Windows.Forms.Label()
        Me.EmpleadosDataGridView = New System.Windows.Forms.DataGridView()
        Me.DniempleadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ApellidoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripción = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LocalidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Provincia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefonoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoempleadoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GBuscardor = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ProvinciaTableAdapter = New ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.ProvinciaTableAdapter()
        Me.EmpleadosTableAdapter = New ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.EmpleadosTableAdapter()
        Me.TipoEmpleadoTableAdapter = New ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.TipoEmpleadoTableAdapter()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuariosTableAdapter = New ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.UsuariosTableAdapter()
        Me.TableAdapterManager = New ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.TableAdapterManager()
        Me.LModificar = New System.Windows.Forms.Label()
        Me.LBaja = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PicFotoBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBalta.SuspendLayout()
        CType(Me.TipoEmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElectrodomesticosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProvinciaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBuscardor.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BActivarEmpleado
        '
        Me.BActivarEmpleado.BackColor = System.Drawing.Color.Transparent
        Me.BActivarEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BActivarEmpleado.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.aceptar1
        Me.BActivarEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BActivarEmpleado.Location = New System.Drawing.Point(21, 110)
        Me.BActivarEmpleado.Name = "BActivarEmpleado"
        Me.BActivarEmpleado.Size = New System.Drawing.Size(118, 42)
        Me.BActivarEmpleado.TabIndex = 14
        Me.BActivarEmpleado.Text = "Activar Empleado"
        Me.BActivarEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BActivarEmpleado.UseVisualStyleBackColor = False
        '
        'BLimpiar
        '
        Me.BLimpiar.BackColor = System.Drawing.Color.Transparent
        Me.BLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BLimpiar.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.escoba
        Me.BLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BLimpiar.Location = New System.Drawing.Point(331, 113)
        Me.BLimpiar.Name = "BLimpiar"
        Me.BLimpiar.Size = New System.Drawing.Size(103, 39)
        Me.BLimpiar.TabIndex = 12
        Me.BLimpiar.Text = "Borrar"
        Me.BLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BLimpiar.UseVisualStyleBackColor = False
        '
        'BAgregarEmpleado
        '
        Me.BAgregarEmpleado.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.agregar
        Me.BAgregarEmpleado.Location = New System.Drawing.Point(37, 12)
        Me.BAgregarEmpleado.Name = "BAgregarEmpleado"
        Me.BAgregarEmpleado.Size = New System.Drawing.Size(87, 88)
        Me.BAgregarEmpleado.TabIndex = 2
        Me.BAgregarEmpleado.UseVisualStyleBackColor = True
        '
        'BEliminarEmpleado
        '
        Me.BEliminarEmpleado.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.eliminar
        Me.BEliminarEmpleado.Location = New System.Drawing.Point(342, 12)
        Me.BEliminarEmpleado.Name = "BEliminarEmpleado"
        Me.BEliminarEmpleado.Size = New System.Drawing.Size(87, 89)
        Me.BEliminarEmpleado.TabIndex = 3
        Me.BEliminarEmpleado.UseVisualStyleBackColor = True
        '
        'BEditarEmpleado
        '
        Me.BEditarEmpleado.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.editar
        Me.BEditarEmpleado.Location = New System.Drawing.Point(186, 12)
        Me.BEditarEmpleado.Name = "BEditarEmpleado"
        Me.BEditarEmpleado.Size = New System.Drawing.Size(87, 88)
        Me.BEditarEmpleado.TabIndex = 4
        Me.BEditarEmpleado.UseVisualStyleBackColor = True
        '
        'DFecha
        '
        Me.DFecha.Location = New System.Drawing.Point(6, 15)
        Me.DFecha.Name = "DFecha"
        Me.DFecha.Size = New System.Drawing.Size(438, 22)
        Me.DFecha.TabIndex = 15
        '
        'PicFotoBuscar
        '
        Me.PicFotoBuscar.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.buscarCliente
        Me.PicFotoBuscar.Location = New System.Drawing.Point(306, 96)
        Me.PicFotoBuscar.Name = "PicFotoBuscar"
        Me.PicFotoBuscar.Size = New System.Drawing.Size(128, 130)
        Me.PicFotoBuscar.TabIndex = 12
        Me.PicFotoBuscar.TabStop = False
        '
        'TApellidoEmpleado
        '
        Me.TApellidoEmpleado.Location = New System.Drawing.Point(118, 185)
        Me.TApellidoEmpleado.Name = "TApellidoEmpleado"
        Me.TApellidoEmpleado.Size = New System.Drawing.Size(164, 22)
        Me.TApellidoEmpleado.TabIndex = 10
        '
        'LblBuscarApellido
        '
        Me.LblBuscarApellido.AutoSize = True
        Me.LblBuscarApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBuscarApellido.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.LblBuscarApellido.Location = New System.Drawing.Point(33, 185)
        Me.LblBuscarApellido.Name = "LblBuscarApellido"
        Me.LblBuscarApellido.Size = New System.Drawing.Size(69, 20)
        Me.LblBuscarApellido.TabIndex = 9
        Me.LblBuscarApellido.Text = "Apellido:"
        '
        'TDNIEmpleado
        '
        Me.TDNIEmpleado.Location = New System.Drawing.Point(118, 117)
        Me.TDNIEmpleado.MaxLength = 8
        Me.TDNIEmpleado.Name = "TDNIEmpleado"
        Me.TDNIEmpleado.Size = New System.Drawing.Size(164, 22)
        Me.TDNIEmpleado.TabIndex = 7
        '
        'LblBuscarDni
        '
        Me.LblBuscarDni.AutoSize = True
        Me.LblBuscarDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBuscarDni.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.LblBuscarDni.Location = New System.Drawing.Point(33, 117)
        Me.LblBuscarDni.Name = "LblBuscarDni"
        Me.LblBuscarDni.Size = New System.Drawing.Size(41, 20)
        Me.LblBuscarDni.TabIndex = 6
        Me.LblBuscarDni.Text = "DNI:"
        '
        'LblBuscador
        '
        Me.LblBuscador.AutoSize = True
        Me.LblBuscador.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBuscador.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.LblBuscador.Location = New System.Drawing.Point(94, 51)
        Me.LblBuscador.Name = "LblBuscador"
        Me.LblBuscador.Size = New System.Drawing.Size(267, 25)
        Me.LblBuscador.TabIndex = 5
        Me.LblBuscador.Text = "Buscador de Empleados"
        '
        'GBalta
        '
        Me.GBalta.BackColor = System.Drawing.Color.Transparent
        Me.GBalta.Controls.Add(Me.Label9)
        Me.GBalta.Controls.Add(Me.Label8)
        Me.GBalta.Controls.Add(Me.Label7)
        Me.GBalta.Controls.Add(Me.Label6)
        Me.GBalta.Controls.Add(Me.Label5)
        Me.GBalta.Controls.Add(Me.Label4)
        Me.GBalta.Controls.Add(Me.Label3)
        Me.GBalta.Controls.Add(Me.Label2)
        Me.GBalta.Controls.Add(Me.Label1)
        Me.GBalta.Controls.Add(Me.CBTipoEmpleado)
        Me.GBalta.Controls.Add(Me.LblCampos)
        Me.GBalta.Controls.Add(Me.CBProvincia)
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
        Me.GBalta.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBalta.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.GBalta.Location = New System.Drawing.Point(83, 12)
        Me.GBalta.Name = "GBalta"
        Me.GBalta.Size = New System.Drawing.Size(379, 401)
        Me.GBalta.TabIndex = 13
        Me.GBalta.TabStop = False
        Me.GBalta.Text = "Agregar Empleados"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label9.Location = New System.Drawing.Point(6, 319)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(14, 18)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label8.Location = New System.Drawing.Point(6, 368)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(14, 18)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label7.Location = New System.Drawing.Point(6, 183)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(14, 18)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label6.Location = New System.Drawing.Point(6, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 18)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label5.Location = New System.Drawing.Point(6, 268)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 18)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label4.Location = New System.Drawing.Point(6, 97)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 18)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label3.Location = New System.Drawing.Point(6, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 18)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label2.Location = New System.Drawing.Point(6, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 18)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 227)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 18)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Tipo Empleado:"
        '
        'CBTipoEmpleado
        '
        Me.CBTipoEmpleado.DataSource = Me.TipoEmpleadoBindingSource
        Me.CBTipoEmpleado.DisplayMember = "descripción"
        Me.CBTipoEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBTipoEmpleado.FormattingEnabled = True
        Me.CBTipoEmpleado.Location = New System.Drawing.Point(139, 225)
        Me.CBTipoEmpleado.Name = "CBTipoEmpleado"
        Me.CBTipoEmpleado.Size = New System.Drawing.Size(197, 26)
        Me.CBTipoEmpleado.TabIndex = 17
        Me.CBTipoEmpleado.ValueMember = "id_tipoEmpleado"
        '
        'TipoEmpleadoBindingSource
        '
        Me.TipoEmpleadoBindingSource.DataMember = "TipoEmpleado"
        Me.TipoEmpleadoBindingSource.DataSource = Me.ElectrodomesticosDataSet
        '
        'ElectrodomesticosDataSet
        '
        Me.ElectrodomesticosDataSet.DataSetName = "ElectrodomesticosDataSet"
        Me.ElectrodomesticosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LblCampos
        '
        Me.LblCampos.AutoSize = True
        Me.LblCampos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCampos.ForeColor = System.Drawing.Color.GreenYellow
        Me.LblCampos.Location = New System.Drawing.Point(177, 18)
        Me.LblCampos.Name = "LblCampos"
        Me.LblCampos.Size = New System.Drawing.Size(159, 18)
        Me.LblCampos.TabIndex = 16
        Me.LblCampos.Text = "* Campos Obligatorios"
        '
        'CBProvincia
        '
        Me.CBProvincia.DataSource = Me.ProvinciaBindingSource
        Me.CBProvincia.DisplayMember = "nombre"
        Me.CBProvincia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBProvincia.FormattingEnabled = True
        Me.CBProvincia.Location = New System.Drawing.Point(139, 316)
        Me.CBProvincia.Name = "CBProvincia"
        Me.CBProvincia.Size = New System.Drawing.Size(197, 26)
        Me.CBProvincia.TabIndex = 15
        Me.CBProvincia.ValueMember = "id_provincia"
        '
        'ProvinciaBindingSource
        '
        Me.ProvinciaBindingSource.DataMember = "Provincia"
        Me.ProvinciaBindingSource.DataSource = Me.ElectrodomesticosDataSet
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(139, 365)
        Me.TxtTelefono.MaxLength = 8
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(197, 24)
        Me.TxtTelefono.TabIndex = 14
        '
        'LblTelefono
        '
        Me.LblTelefono.AutoSize = True
        Me.LblTelefono.Location = New System.Drawing.Point(21, 368)
        Me.LblTelefono.Name = "LblTelefono"
        Me.LblTelefono.Size = New System.Drawing.Size(70, 18)
        Me.LblTelefono.TabIndex = 13
        Me.LblTelefono.Text = "Telefono:"
        '
        'TxtLocalidad
        '
        Me.TxtLocalidad.Location = New System.Drawing.Point(139, 269)
        Me.TxtLocalidad.Name = "TxtLocalidad"
        Me.TxtLocalidad.Size = New System.Drawing.Size(197, 24)
        Me.TxtLocalidad.TabIndex = 10
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(139, 181)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(197, 24)
        Me.TxtDireccion.TabIndex = 9
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(139, 136)
        Me.TxtApellido.MaxLength = 100
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(197, 24)
        Me.TxtApellido.TabIndex = 8
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(139, 94)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(197, 24)
        Me.TxtNombre.TabIndex = 7
        '
        'TxtDNI
        '
        Me.TxtDNI.Location = New System.Drawing.Point(139, 52)
        Me.TxtDNI.MaxLength = 8
        Me.TxtDNI.Name = "TxtDNI"
        Me.TxtDNI.Size = New System.Drawing.Size(197, 24)
        Me.TxtDNI.TabIndex = 6
        '
        'LblProvincia
        '
        Me.LblProvincia.AutoSize = True
        Me.LblProvincia.Location = New System.Drawing.Point(20, 318)
        Me.LblProvincia.Name = "LblProvincia"
        Me.LblProvincia.Size = New System.Drawing.Size(73, 18)
        Me.LblProvincia.TabIndex = 5
        Me.LblProvincia.Text = "Provincia:"
        '
        'LblLocalidad
        '
        Me.LblLocalidad.AutoSize = True
        Me.LblLocalidad.Location = New System.Drawing.Point(20, 268)
        Me.LblLocalidad.Name = "LblLocalidad"
        Me.LblLocalidad.Size = New System.Drawing.Size(75, 18)
        Me.LblLocalidad.TabIndex = 4
        Me.LblLocalidad.Text = "Localidad:"
        '
        'LblDireccion
        '
        Me.LblDireccion.AutoSize = True
        Me.LblDireccion.Location = New System.Drawing.Point(22, 183)
        Me.LblDireccion.Name = "LblDireccion"
        Me.LblDireccion.Size = New System.Drawing.Size(75, 18)
        Me.LblDireccion.TabIndex = 3
        Me.LblDireccion.Text = "Direccion:"
        '
        'LblApellido
        '
        Me.LblApellido.AutoSize = True
        Me.LblApellido.Location = New System.Drawing.Point(20, 138)
        Me.LblApellido.Name = "LblApellido"
        Me.LblApellido.Size = New System.Drawing.Size(67, 18)
        Me.LblApellido.TabIndex = 2
        Me.LblApellido.Text = " Apellido:"
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Location = New System.Drawing.Point(20, 99)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(66, 18)
        Me.LblNombre.TabIndex = 1
        Me.LblNombre.Text = "Nombre:"
        '
        'LblDNI
        '
        Me.LblDNI.AutoSize = True
        Me.LblDNI.Location = New System.Drawing.Point(20, 51)
        Me.LblDNI.Name = "LblDNI"
        Me.LblDNI.Size = New System.Drawing.Size(37, 18)
        Me.LblDNI.TabIndex = 0
        Me.LblDNI.Text = "DNI:"
        '
        'BVolver
        '
        Me.BVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BVolver.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.espalda__1_
        Me.BVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BVolver.Location = New System.Drawing.Point(820, 633)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(108, 46)
        Me.BVolver.TabIndex = 19
        Me.BVolver.Text = "Volver"
        Me.BVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BVolver.UseVisualStyleBackColor = True
        '
        'LblEmpleados
        '
        Me.LblEmpleados.AutoSize = True
        Me.LblEmpleados.BackColor = System.Drawing.Color.Transparent
        Me.LblEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 29.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmpleados.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.LblEmpleados.Location = New System.Drawing.Point(25, 20)
        Me.LblEmpleados.Name = "LblEmpleados"
        Me.LblEmpleados.Size = New System.Drawing.Size(52, 396)
        Me.LblEmpleados.TabIndex = 22
        Me.LblEmpleados.Text = "E" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "M" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "P" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "L" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "E" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "A" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "D" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "O" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "S"
        '
        'EmpleadosDataGridView
        '
        Me.EmpleadosDataGridView.AllowUserToAddRows = False
        Me.EmpleadosDataGridView.AllowUserToDeleteRows = False
        Me.EmpleadosDataGridView.AutoGenerateColumns = False
        Me.EmpleadosDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.EmpleadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpleadosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DniempleadoDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.ApellidoDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn, Me.descripción, Me.LocalidadDataGridViewTextBoxColumn, Me.Provincia, Me.TelefonoDataGridViewTextBoxColumn, Me.EstadoempleadoDataGridViewCheckBoxColumn})
        Me.EmpleadosDataGridView.DataSource = Me.EmpleadosBindingSource
        Me.EmpleadosDataGridView.Location = New System.Drawing.Point(33, 438)
        Me.EmpleadosDataGridView.Name = "EmpleadosDataGridView"
        Me.EmpleadosDataGridView.ReadOnly = True
        Me.EmpleadosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.EmpleadosDataGridView.Size = New System.Drawing.Size(895, 196)
        Me.EmpleadosDataGridView.TabIndex = 23
        '
        'DniempleadoDataGridViewTextBoxColumn
        '
        Me.DniempleadoDataGridViewTextBoxColumn.DataPropertyName = "dni_empleado"
        Me.DniempleadoDataGridViewTextBoxColumn.HeaderText = "DNI Empleado"
        Me.DniempleadoDataGridViewTextBoxColumn.Name = "DniempleadoDataGridViewTextBoxColumn"
        Me.DniempleadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.DniempleadoDataGridViewTextBoxColumn.Width = 90
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 90
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
        'descripción
        '
        Me.descripción.DataPropertyName = "descripción"
        Me.descripción.HeaderText = "Tipo De Empleado"
        Me.descripción.Name = "descripción"
        Me.descripción.ReadOnly = True
        Me.descripción.Width = 120
        '
        'LocalidadDataGridViewTextBoxColumn
        '
        Me.LocalidadDataGridViewTextBoxColumn.DataPropertyName = "localidad"
        Me.LocalidadDataGridViewTextBoxColumn.HeaderText = "Localidad"
        Me.LocalidadDataGridViewTextBoxColumn.Name = "LocalidadDataGridViewTextBoxColumn"
        Me.LocalidadDataGridViewTextBoxColumn.ReadOnly = True
        Me.LocalidadDataGridViewTextBoxColumn.Width = 90
        '
        'Provincia
        '
        Me.Provincia.DataPropertyName = "NombreProvincia"
        Me.Provincia.HeaderText = "Provincia"
        Me.Provincia.Name = "Provincia"
        Me.Provincia.ReadOnly = True
        Me.Provincia.Width = 80
        '
        'TelefonoDataGridViewTextBoxColumn
        '
        Me.TelefonoDataGridViewTextBoxColumn.DataPropertyName = "telefono"
        Me.TelefonoDataGridViewTextBoxColumn.HeaderText = "Télefono"
        Me.TelefonoDataGridViewTextBoxColumn.Name = "TelefonoDataGridViewTextBoxColumn"
        Me.TelefonoDataGridViewTextBoxColumn.ReadOnly = True
        Me.TelefonoDataGridViewTextBoxColumn.Width = 70
        '
        'EstadoempleadoDataGridViewCheckBoxColumn
        '
        Me.EstadoempleadoDataGridViewCheckBoxColumn.DataPropertyName = "estado_empleado"
        Me.EstadoempleadoDataGridViewCheckBoxColumn.HeaderText = "Estado (Chekeado=""Activo, No Chekeado= ""Dado de Baja"")"
        Me.EstadoempleadoDataGridViewCheckBoxColumn.Name = "EstadoempleadoDataGridViewCheckBoxColumn"
        Me.EstadoempleadoDataGridViewCheckBoxColumn.ReadOnly = True
        Me.EstadoempleadoDataGridViewCheckBoxColumn.Width = 150
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "Empleados"
        Me.EmpleadosBindingSource.DataSource = Me.ElectrodomesticosDataSet
        '
        'GBuscardor
        '
        Me.GBuscardor.BackColor = System.Drawing.Color.Transparent
        Me.GBuscardor.Controls.Add(Me.Button2)
        Me.GBuscardor.Controls.Add(Me.LblBuscador)
        Me.GBuscardor.Controls.Add(Me.PicFotoBuscar)
        Me.GBuscardor.Controls.Add(Me.LblBuscarDni)
        Me.GBuscardor.Controls.Add(Me.TApellidoEmpleado)
        Me.GBuscardor.Controls.Add(Me.TDNIEmpleado)
        Me.GBuscardor.Controls.Add(Me.DFecha)
        Me.GBuscardor.Controls.Add(Me.LblBuscarApellido)
        Me.GBuscardor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBuscardor.Location = New System.Drawing.Point(484, 12)
        Me.GBuscardor.Name = "GBuscardor"
        Me.GBuscardor.Size = New System.Drawing.Size(444, 243)
        Me.GBuscardor.TabIndex = 24
        Me.GBuscardor.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.BActivarEmpleado)
        Me.GroupBox2.Controls.Add(Me.BLimpiar)
        Me.GroupBox2.Controls.Add(Me.BAgregarEmpleado)
        Me.GroupBox2.Controls.Add(Me.BEliminarEmpleado)
        Me.GroupBox2.Controls.Add(Me.BEditarEmpleado)
        Me.GroupBox2.Location = New System.Drawing.Point(484, 258)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(444, 158)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        '
        'ProvinciaTableAdapter
        '
        Me.ProvinciaTableAdapter.ClearBeforeFill = True
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'TipoEmpleadoTableAdapter
        '
        Me.TipoEmpleadoTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.MarcaTableAdapter = Nothing
        Me.TableAdapterManager.ProvinciaTableAdapter = Me.ProvinciaTableAdapter
        Me.TableAdapterManager.TipoEmpleadoTableAdapter = Me.TipoEmpleadoTableAdapter
        Me.TableAdapterManager.TipoUsuarioTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'LModificar
        '
        Me.LModificar.AutoSize = True
        Me.LModificar.BackColor = System.Drawing.Color.Transparent
        Me.LModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LModificar.ForeColor = System.Drawing.Color.DarkBlue
        Me.LModificar.Location = New System.Drawing.Point(31, 417)
        Me.LModificar.Name = "LModificar"
        Me.LModificar.Size = New System.Drawing.Size(318, 18)
        Me.LModificar.TabIndex = 30
        Me.LModificar.Text = "(Doble click para modificar un empleado)"
        '
        'LBaja
        '
        Me.LBaja.AutoSize = True
        Me.LBaja.BackColor = System.Drawing.Color.Transparent
        Me.LBaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBaja.ForeColor = System.Drawing.Color.YellowGreen
        Me.LBaja.Location = New System.Drawing.Point(30, 640)
        Me.LBaja.Name = "LBaja"
        Me.LBaja.Size = New System.Drawing.Size(212, 20)
        Me.LBaja.TabIndex = 31
        Me.LBaja.Text = "* Empleado dado de Baja"
        '
        'Button2
        '
        Me.Button2.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.refrescar
        Me.Button2.Location = New System.Drawing.Point(391, 43)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(43, 37)
        Me.Button2.TabIndex = 56
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ABMEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Gray
        Me.BackgroundImage = Global.ElectrodomesticosLMJVA.My.Resources.Resources.fondoclaro
        Me.ClientSize = New System.Drawing.Size(940, 681)
        Me.ControlBox = False
        Me.Controls.Add(Me.LBaja)
        Me.Controls.Add(Me.LModificar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GBuscardor)
        Me.Controls.Add(Me.EmpleadosDataGridView)
        Me.Controls.Add(Me.LblEmpleados)
        Me.Controls.Add(Me.BVolver)
        Me.Controls.Add(Me.GBalta)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ABMEmpleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar, Dar de baja y Modificar Empleados"
        CType(Me.PicFotoBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBalta.ResumeLayout(False)
        Me.GBalta.PerformLayout()
        CType(Me.TipoEmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElectrodomesticosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProvinciaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBuscardor.ResumeLayout(False)
        Me.GBuscardor.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BActivarEmpleado As System.Windows.Forms.Button
    Friend WithEvents BLimpiar As System.Windows.Forms.Button
    Friend WithEvents BAgregarEmpleado As System.Windows.Forms.Button
    Friend WithEvents BEliminarEmpleado As System.Windows.Forms.Button
    Friend WithEvents BEditarEmpleado As System.Windows.Forms.Button
    Friend WithEvents DFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents PicFotoBuscar As System.Windows.Forms.PictureBox
    Friend WithEvents TApellidoEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents LblBuscarApellido As System.Windows.Forms.Label
    Friend WithEvents TDNIEmpleado As System.Windows.Forms.TextBox
    Friend WithEvents LblBuscarDni As System.Windows.Forms.Label
    Friend WithEvents LblBuscador As System.Windows.Forms.Label
    Friend WithEvents GBalta As System.Windows.Forms.GroupBox
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
    Friend WithEvents BVolver As System.Windows.Forms.Button
    Friend WithEvents ProvinciaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LblEmpleados As System.Windows.Forms.Label
    Friend WithEvents EmpleadosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents GBuscardor As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents CBProvincia As System.Windows.Forms.ComboBox

    Friend WithEvents LblCampos As System.Windows.Forms.Label
    Friend WithEvents ElectrodomesticosDataSet As ElectrodomesticosLMJVA.ElectrodomesticosDataSet
    Friend WithEvents ProvinciaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProvinciaTableAdapter As ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.ProvinciaTableAdapter
    Friend WithEvents EmpleadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpleadosTableAdapter As ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.EmpleadosTableAdapter
    Friend WithEvents Expr1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CBTipoEmpleado As System.Windows.Forms.ComboBox
    Friend WithEvents TipoEmpleadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TipoEmpleadoTableAdapter As ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.TipoEmpleadoTableAdapter
    Friend WithEvents UsuariosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsuariosTableAdapter As ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.UsuariosTableAdapter
    Friend WithEvents TableAdapterManager As ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents LModificar As System.Windows.Forms.Label
    Friend WithEvents LBaja As System.Windows.Forms.Label
    Friend WithEvents DniempleadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ApellidoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents descripción As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LocalidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Provincia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefonoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoempleadoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
