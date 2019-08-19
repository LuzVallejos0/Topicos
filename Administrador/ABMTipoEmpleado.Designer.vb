<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMTipoEmpleado
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
        Me.LblEmpleado = New System.Windows.Forms.Label()
        Me.BVolver = New System.Windows.Forms.Button()
        Me.TipoEmpleadoDataGridView = New System.Windows.Forms.DataGridView()
        Me.DescripciónDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TipoEmpleadoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ElectrodomesticosDataSet = New ElectrodomesticosLMJVA.ElectrodomesticosDataSet()
        Me.GPBotones = New System.Windows.Forms.GroupBox()
        Me.BEliminar = New System.Windows.Forms.Button()
        Me.BActivar = New System.Windows.Forms.Button()
        Me.GPBuscarTipoEmpleado = New System.Windows.Forms.GroupBox()
        Me.TxtBuscarTipo = New System.Windows.Forms.TextBox()
        Me.lbltipoEmpleado = New System.Windows.Forms.Label()
        Me.GPEditar = New System.Windows.Forms.GroupBox()
        Me.Bguardar = New System.Windows.Forms.Button()
        Me.TxtNombreEditar = New System.Windows.Forms.TextBox()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.GPTipoEmpleado = New System.Windows.Forms.GroupBox()
        Me.BAgregar = New System.Windows.Forms.Button()
        Me.TxtTipo = New System.Windows.Forms.TextBox()
        Me.LblTipo = New System.Windows.Forms.Label()
        Me.TipoEmpleadoTableAdapter = New ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.TipoEmpleadoTableAdapter()
        Me.TableAdapterManager = New ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.TableAdapterManager()
        Me.LModificar = New System.Windows.Forms.Label()
        Me.LBaja = New System.Windows.Forms.Label()
        CType(Me.TipoEmpleadoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TipoEmpleadoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElectrodomesticosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GPBotones.SuspendLayout()
        Me.GPBuscarTipoEmpleado.SuspendLayout()
        Me.GPEditar.SuspendLayout()
        Me.GPTipoEmpleado.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblEmpleado
        '
        Me.LblEmpleado.AutoSize = True
        Me.LblEmpleado.BackColor = System.Drawing.Color.Transparent
        Me.LblEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEmpleado.ForeColor = System.Drawing.Color.White
        Me.LblEmpleado.Location = New System.Drawing.Point(42, 45)
        Me.LblEmpleado.Name = "LblEmpleado"
        Me.LblEmpleado.Size = New System.Drawing.Size(39, 528)
        Me.LblEmpleado.TabIndex = 19
        Me.LblEmpleado.Text = "T" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " I" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "P" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "O" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "D" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "E" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "E" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "M" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "P" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "L" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "E" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "A" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "D" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "O"
        '
        'BVolver
        '
        Me.BVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BVolver.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.espalda__1_
        Me.BVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BVolver.Location = New System.Drawing.Point(414, 599)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(111, 43)
        Me.BVolver.TabIndex = 18
        Me.BVolver.Text = "Volver"
        Me.BVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BVolver.UseVisualStyleBackColor = True
        '
        'TipoEmpleadoDataGridView
        '
        Me.TipoEmpleadoDataGridView.AllowUserToAddRows = False
        Me.TipoEmpleadoDataGridView.AllowUserToDeleteRows = False
        Me.TipoEmpleadoDataGridView.AutoGenerateColumns = False
        Me.TipoEmpleadoDataGridView.BackgroundColor = System.Drawing.SystemColors.InactiveBorder
        Me.TipoEmpleadoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TipoEmpleadoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DescripciónDataGridViewTextBoxColumn, Me.EstadoDataGridViewCheckBoxColumn})
        Me.TipoEmpleadoDataGridView.DataSource = Me.TipoEmpleadoBindingSource
        Me.TipoEmpleadoDataGridView.Location = New System.Drawing.Point(552, 54)
        Me.TipoEmpleadoDataGridView.Name = "TipoEmpleadoDataGridView"
        Me.TipoEmpleadoDataGridView.ReadOnly = True
        Me.TipoEmpleadoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TipoEmpleadoDataGridView.Size = New System.Drawing.Size(344, 492)
        Me.TipoEmpleadoDataGridView.TabIndex = 17
        '
        'DescripciónDataGridViewTextBoxColumn
        '
        Me.DescripciónDataGridViewTextBoxColumn.DataPropertyName = "descripción"
        Me.DescripciónDataGridViewTextBoxColumn.HeaderText = "Tipo de Empleado"
        Me.DescripciónDataGridViewTextBoxColumn.Name = "DescripciónDataGridViewTextBoxColumn"
        Me.DescripciónDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripciónDataGridViewTextBoxColumn.Width = 130
        '
        'EstadoDataGridViewCheckBoxColumn
        '
        Me.EstadoDataGridViewCheckBoxColumn.DataPropertyName = "estado"
        Me.EstadoDataGridViewCheckBoxColumn.HeaderText = "Estado (Chekeado=""Activo, No Chekeado= ""Dado de Baja"")"
        Me.EstadoDataGridViewCheckBoxColumn.Name = "EstadoDataGridViewCheckBoxColumn"
        Me.EstadoDataGridViewCheckBoxColumn.ReadOnly = True
        Me.EstadoDataGridViewCheckBoxColumn.Width = 170
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
        'GPBotones
        '
        Me.GPBotones.BackColor = System.Drawing.Color.Transparent
        Me.GPBotones.Controls.Add(Me.BEliminar)
        Me.GPBotones.Controls.Add(Me.BActivar)
        Me.GPBotones.Location = New System.Drawing.Point(130, 479)
        Me.GPBotones.Name = "GPBotones"
        Me.GPBotones.Size = New System.Drawing.Size(355, 67)
        Me.GPBotones.TabIndex = 16
        Me.GPBotones.TabStop = False
        '
        'BEliminar
        '
        Me.BEliminar.BackColor = System.Drawing.Color.Transparent
        Me.BEliminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BEliminar.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.cancelar
        Me.BEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BEliminar.Location = New System.Drawing.Point(212, 19)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Size = New System.Drawing.Size(120, 33)
        Me.BEliminar.TabIndex = 3
        Me.BEliminar.Text = "Dar de baja"
        Me.BEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BEliminar.UseVisualStyleBackColor = False
        '
        'BActivar
        '
        Me.BActivar.BackColor = System.Drawing.Color.Transparent
        Me.BActivar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BActivar.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.aceptar
        Me.BActivar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BActivar.Location = New System.Drawing.Point(18, 19)
        Me.BActivar.Name = "BActivar"
        Me.BActivar.Size = New System.Drawing.Size(91, 33)
        Me.BActivar.TabIndex = 4
        Me.BActivar.Text = "Activar"
        Me.BActivar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BActivar.UseVisualStyleBackColor = False
        '
        'GPBuscarTipoEmpleado
        '
        Me.GPBuscarTipoEmpleado.BackColor = System.Drawing.Color.Transparent
        Me.GPBuscarTipoEmpleado.Controls.Add(Me.TxtBuscarTipo)
        Me.GPBuscarTipoEmpleado.Controls.Add(Me.lbltipoEmpleado)
        Me.GPBuscarTipoEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GPBuscarTipoEmpleado.ForeColor = System.Drawing.Color.White
        Me.GPBuscarTipoEmpleado.Location = New System.Drawing.Point(130, 359)
        Me.GPBuscarTipoEmpleado.Name = "GPBuscarTipoEmpleado"
        Me.GPBuscarTipoEmpleado.Size = New System.Drawing.Size(355, 69)
        Me.GPBuscarTipoEmpleado.TabIndex = 15
        Me.GPBuscarTipoEmpleado.TabStop = False
        Me.GPBuscarTipoEmpleado.Text = "Buscar Tipo de Empleado"
        '
        'TxtBuscarTipo
        '
        Me.TxtBuscarTipo.Location = New System.Drawing.Point(90, 32)
        Me.TxtBuscarTipo.Name = "TxtBuscarTipo"
        Me.TxtBuscarTipo.Size = New System.Drawing.Size(242, 22)
        Me.TxtBuscarTipo.TabIndex = 2
        '
        'lbltipoEmpleado
        '
        Me.lbltipoEmpleado.AutoSize = True
        Me.lbltipoEmpleado.Location = New System.Drawing.Point(24, 35)
        Me.lbltipoEmpleado.Name = "lbltipoEmpleado"
        Me.lbltipoEmpleado.Size = New System.Drawing.Size(60, 16)
        Me.lbltipoEmpleado.TabIndex = 1
        Me.lbltipoEmpleado.Text = "Nombre:"
        '
        'GPEditar
        '
        Me.GPEditar.BackColor = System.Drawing.Color.Transparent
        Me.GPEditar.Controls.Add(Me.Bguardar)
        Me.GPEditar.Controls.Add(Me.TxtNombreEditar)
        Me.GPEditar.Controls.Add(Me.LblNombre)
        Me.GPEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GPEditar.ForeColor = System.Drawing.Color.White
        Me.GPEditar.Location = New System.Drawing.Point(130, 196)
        Me.GPEditar.Name = "GPEditar"
        Me.GPEditar.Size = New System.Drawing.Size(355, 106)
        Me.GPEditar.TabIndex = 14
        Me.GPEditar.TabStop = False
        Me.GPEditar.Text = "Editar Tipo de Empleado"
        '
        'Bguardar
        '
        Me.Bguardar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Bguardar.ForeColor = System.Drawing.Color.Black
        Me.Bguardar.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.aceptar1
        Me.Bguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bguardar.Location = New System.Drawing.Point(239, 41)
        Me.Bguardar.Name = "Bguardar"
        Me.Bguardar.Size = New System.Drawing.Size(93, 33)
        Me.Bguardar.TabIndex = 6
        Me.Bguardar.Text = "Guardar"
        Me.Bguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bguardar.UseVisualStyleBackColor = False
        '
        'TxtNombreEditar
        '
        Me.TxtNombreEditar.Location = New System.Drawing.Point(90, 46)
        Me.TxtNombreEditar.Name = "TxtNombreEditar"
        Me.TxtNombreEditar.Size = New System.Drawing.Size(135, 22)
        Me.TxtNombreEditar.TabIndex = 1
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.Location = New System.Drawing.Point(24, 47)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(60, 16)
        Me.LblNombre.TabIndex = 0
        Me.LblNombre.Text = "Nombre:"
        '
        'GPTipoEmpleado
        '
        Me.GPTipoEmpleado.BackColor = System.Drawing.Color.Transparent
        Me.GPTipoEmpleado.Controls.Add(Me.BAgregar)
        Me.GPTipoEmpleado.Controls.Add(Me.TxtTipo)
        Me.GPTipoEmpleado.Controls.Add(Me.LblTipo)
        Me.GPTipoEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GPTipoEmpleado.ForeColor = System.Drawing.Color.White
        Me.GPTipoEmpleado.Location = New System.Drawing.Point(130, 45)
        Me.GPTipoEmpleado.Name = "GPTipoEmpleado"
        Me.GPTipoEmpleado.Size = New System.Drawing.Size(355, 108)
        Me.GPTipoEmpleado.TabIndex = 20
        Me.GPTipoEmpleado.TabStop = False
        Me.GPTipoEmpleado.Text = "Agregar Tipo de Empleado"
        '
        'BAgregar
        '
        Me.BAgregar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BAgregar.ForeColor = System.Drawing.Color.Black
        Me.BAgregar.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.guardar
        Me.BAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BAgregar.Location = New System.Drawing.Point(233, 71)
        Me.BAgregar.Name = "BAgregar"
        Me.BAgregar.Size = New System.Drawing.Size(98, 31)
        Me.BAgregar.TabIndex = 2
        Me.BAgregar.Text = "Agregar"
        Me.BAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BAgregar.UseVisualStyleBackColor = False
        '
        'TxtTipo
        '
        Me.TxtTipo.Location = New System.Drawing.Point(92, 39)
        Me.TxtTipo.Name = "TxtTipo"
        Me.TxtTipo.Size = New System.Drawing.Size(239, 22)
        Me.TxtTipo.TabIndex = 1
        '
        'LblTipo
        '
        Me.LblTipo.AutoSize = True
        Me.LblTipo.Location = New System.Drawing.Point(26, 42)
        Me.LblTipo.Name = "LblTipo"
        Me.LblTipo.Size = New System.Drawing.Size(60, 16)
        Me.LblTipo.TabIndex = 0
        Me.LblTipo.Text = "Nombre:"
        '
        'TipoEmpleadoTableAdapter
        '
        Me.TipoEmpleadoTableAdapter.ClearBeforeFill = True
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
        'LModificar
        '
        Me.LModificar.AutoSize = True
        Me.LModificar.BackColor = System.Drawing.Color.Transparent
        Me.LModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LModificar.ForeColor = System.Drawing.Color.RoyalBlue
        Me.LModificar.Location = New System.Drawing.Point(707, 33)
        Me.LModificar.Name = "LModificar"
        Me.LModificar.Size = New System.Drawing.Size(189, 18)
        Me.LModificar.TabIndex = 21
        Me.LModificar.Text = "(Doble click para editar)"
        '
        'LBaja
        '
        Me.LBaja.AutoSize = True
        Me.LBaja.BackColor = System.Drawing.Color.Transparent
        Me.LBaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBaja.ForeColor = System.Drawing.Color.YellowGreen
        Me.LBaja.Location = New System.Drawing.Point(549, 557)
        Me.LBaja.Name = "LBaja"
        Me.LBaja.Size = New System.Drawing.Size(256, 18)
        Me.LBaja.TabIndex = 34
        Me.LBaja.Text = "* Tipo de Empleado dada de baja"
        '
        'ABMTipoEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ElectrodomesticosLMJVA.My.Resources.Resources.fondoclaro
        Me.ClientSize = New System.Drawing.Size(940, 681)
        Me.ControlBox = False
        Me.Controls.Add(Me.LBaja)
        Me.Controls.Add(Me.LModificar)
        Me.Controls.Add(Me.GPTipoEmpleado)
        Me.Controls.Add(Me.LblEmpleado)
        Me.Controls.Add(Me.BVolver)
        Me.Controls.Add(Me.TipoEmpleadoDataGridView)
        Me.Controls.Add(Me.GPBotones)
        Me.Controls.Add(Me.GPBuscarTipoEmpleado)
        Me.Controls.Add(Me.GPEditar)
        Me.Name = "ABMTipoEmpleado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar, Dar de Baja Y Modificar Tipo de Empleados"
        CType(Me.TipoEmpleadoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TipoEmpleadoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElectrodomesticosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GPBotones.ResumeLayout(False)
        Me.GPBuscarTipoEmpleado.ResumeLayout(False)
        Me.GPBuscarTipoEmpleado.PerformLayout()
        Me.GPEditar.ResumeLayout(False)
        Me.GPEditar.PerformLayout()
        Me.GPTipoEmpleado.ResumeLayout(False)
        Me.GPTipoEmpleado.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblEmpleado As System.Windows.Forms.Label
    Friend WithEvents BVolver As System.Windows.Forms.Button
    Friend WithEvents TipoEmpleadoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents GPBotones As System.Windows.Forms.GroupBox
    Friend WithEvents BEliminar As System.Windows.Forms.Button
    Friend WithEvents BActivar As System.Windows.Forms.Button
    Friend WithEvents GPBuscarTipoEmpleado As System.Windows.Forms.GroupBox
    Friend WithEvents TxtBuscarTipo As System.Windows.Forms.TextBox
    Friend WithEvents lbltipoEmpleado As System.Windows.Forms.Label
    Friend WithEvents GPEditar As System.Windows.Forms.GroupBox
    Friend WithEvents Bguardar As System.Windows.Forms.Button
    Friend WithEvents TxtNombreEditar As System.Windows.Forms.TextBox
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents GPTipoEmpleado As System.Windows.Forms.GroupBox
    Friend WithEvents BAgregar As System.Windows.Forms.Button
    Friend WithEvents TxtTipo As System.Windows.Forms.TextBox
    Friend WithEvents LblTipo As System.Windows.Forms.Label
    Friend WithEvents ElectrodomesticosDataSet As ElectrodomesticosLMJVA.ElectrodomesticosDataSet
    Friend WithEvents TipoEmpleadoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TipoEmpleadoTableAdapter As ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.TipoEmpleadoTableAdapter
    Friend WithEvents TableAdapterManager As ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DescripciónDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents LModificar As System.Windows.Forms.Label
    Friend WithEvents LBaja As System.Windows.Forms.Label
End Class
