<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NuevoCliente
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
        Me.GBalta = New System.Windows.Forms.GroupBox()
        Me.BAgregar = New System.Windows.Forms.Button()
        Me.CBProvincia = New System.Windows.Forms.ComboBox()
        Me.ProvinciaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ElectrodomesticosDataSet = New ElectrodomesticosLMJVA.ElectrodomesticosDataSet()
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
        Me.LblBuscador = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ProvinciaTableAdapter = New ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.ProvinciaTableAdapter()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.ClientesTableAdapter()
        Me.TableAdapterManager = New ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.TableAdapterManager()
        Me.GBalta.SuspendLayout()
        CType(Me.ProvinciaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElectrodomesticosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GBalta
        '
        Me.GBalta.BackColor = System.Drawing.Color.Transparent
        Me.GBalta.Controls.Add(Me.BAgregar)
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
        Me.GBalta.Location = New System.Drawing.Point(25, 60)
        Me.GBalta.Name = "GBalta"
        Me.GBalta.Size = New System.Drawing.Size(726, 310)
        Me.GBalta.TabIndex = 1
        Me.GBalta.TabStop = False
        Me.GBalta.Text = "Agregar Clientes"
        '
        'BAgregar
        '
        Me.BAgregar.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.agregar
        Me.BAgregar.Location = New System.Drawing.Point(322, 216)
        Me.BAgregar.Name = "BAgregar"
        Me.BAgregar.Size = New System.Drawing.Size(87, 88)
        Me.BAgregar.TabIndex = 18
        Me.BAgregar.UseVisualStyleBackColor = True
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
        'ElectrodomesticosDataSet
        '
        Me.ElectrodomesticosDataSet.DataSetName = "ElectrodomesticosDataSet"
        Me.ElectrodomesticosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'LblBuscador
        '
        Me.LblBuscador.AutoSize = True
        Me.LblBuscador.BackColor = System.Drawing.Color.Transparent
        Me.LblBuscador.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBuscador.ForeColor = System.Drawing.Color.Black
        Me.LblBuscador.Location = New System.Drawing.Point(30, 9)
        Me.LblBuscador.Name = "LblBuscador"
        Me.LblBuscador.Size = New System.Drawing.Size(229, 37)
        Me.LblBuscador.TabIndex = 6
        Me.LblBuscador.Text = "Nuevo Cliente"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.ag
        Me.PictureBox1.Location = New System.Drawing.Point(265, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(43, 45)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'ProvinciaTableAdapter
        '
        Me.ProvinciaTableAdapter.ClearBeforeFill = True
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.ElectrodomesticosDataSet
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoriasTableAdapter = Nothing
        Me.TableAdapterManager.MarcaTableAdapter = Nothing
        Me.TableAdapterManager.ProvinciaTableAdapter = Me.ProvinciaTableAdapter
        Me.TableAdapterManager.TipoEmpleadoTableAdapter = Nothing
        Me.TableAdapterManager.TipoUsuarioTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'NuevoCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(784, 395)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LblBuscador)
        Me.Controls.Add(Me.GBalta)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "NuevoCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Cliente"
        Me.GBalta.ResumeLayout(False)
        Me.GBalta.PerformLayout()
        CType(Me.ProvinciaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElectrodomesticosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GBalta As System.Windows.Forms.GroupBox
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
    Friend WithEvents LblBuscador As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ElectrodomesticosDataSet As ElectrodomesticosLMJVA.ElectrodomesticosDataSet
    Friend WithEvents ProvinciaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProvinciaTableAdapter As ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.ProvinciaTableAdapter
    Friend WithEvents BAgregar As System.Windows.Forms.Button
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents TableAdapterManager As ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.TableAdapterManager
End Class
