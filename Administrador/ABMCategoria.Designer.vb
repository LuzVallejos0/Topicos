<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMCategoria
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
        Me.GPMarca = New System.Windows.Forms.GroupBox()
        Me.BAgregar = New System.Windows.Forms.Button()
        Me.TxtCategoría = New System.Windows.Forms.TextBox()
        Me.LblCategoria = New System.Windows.Forms.Label()
        Me.GPEditar = New System.Windows.Forms.GroupBox()
        Me.Bguardar = New System.Windows.Forms.Button()
        Me.TxtNombreEditar = New System.Windows.Forms.TextBox()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.GPBuscarCategoría = New System.Windows.Forms.GroupBox()
        Me.TxtBuscarCategoria = New System.Windows.Forms.TextBox()
        Me.LblCategoriaB = New System.Windows.Forms.Label()
        Me.GPBotones = New System.Windows.Forms.GroupBox()
        Me.BEliminar = New System.Windows.Forms.Button()
        Me.BActivar = New System.Windows.Forms.Button()
        Me.CategoríaDataGridView = New System.Windows.Forms.DataGridView()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadocategoriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CategoriasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ElectrodomesticosDataSet = New ElectrodomesticosLMJVA.ElectrodomesticosDataSet()
        Me.BVolver = New System.Windows.Forms.Button()
        Me.lblNombreCat = New System.Windows.Forms.Label()
        Me.LModificar = New System.Windows.Forms.Label()
        Me.LBaja = New System.Windows.Forms.Label()
        Me.CategoriasTableAdapter = New ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.CategoriasTableAdapter()
        Me.TableAdapterManager = New ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.TableAdapterManager()
        Me.GPMarca.SuspendLayout()
        Me.GPEditar.SuspendLayout()
        Me.GPBuscarCategoría.SuspendLayout()
        Me.GPBotones.SuspendLayout()
        CType(Me.CategoríaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElectrodomesticosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GPMarca
        '
        Me.GPMarca.BackColor = System.Drawing.Color.Transparent
        Me.GPMarca.Controls.Add(Me.BAgregar)
        Me.GPMarca.Controls.Add(Me.TxtCategoría)
        Me.GPMarca.Controls.Add(Me.LblCategoria)
        Me.GPMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GPMarca.ForeColor = System.Drawing.Color.White
        Me.GPMarca.Location = New System.Drawing.Point(140, 47)
        Me.GPMarca.Name = "GPMarca"
        Me.GPMarca.Size = New System.Drawing.Size(355, 108)
        Me.GPMarca.TabIndex = 0
        Me.GPMarca.TabStop = False
        Me.GPMarca.Text = "Agregar Categoría"
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
        'TxtCategoría
        '
        Me.TxtCategoría.Location = New System.Drawing.Point(92, 39)
        Me.TxtCategoría.Name = "TxtCategoría"
        Me.TxtCategoría.Size = New System.Drawing.Size(239, 22)
        Me.TxtCategoría.TabIndex = 1
        '
        'LblCategoria
        '
        Me.LblCategoria.AutoSize = True
        Me.LblCategoria.Location = New System.Drawing.Point(26, 42)
        Me.LblCategoria.Name = "LblCategoria"
        Me.LblCategoria.Size = New System.Drawing.Size(60, 16)
        Me.LblCategoria.TabIndex = 0
        Me.LblCategoria.Text = "Nombre:"
        '
        'GPEditar
        '
        Me.GPEditar.BackColor = System.Drawing.Color.Transparent
        Me.GPEditar.Controls.Add(Me.Bguardar)
        Me.GPEditar.Controls.Add(Me.TxtNombreEditar)
        Me.GPEditar.Controls.Add(Me.LblNombre)
        Me.GPEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GPEditar.ForeColor = System.Drawing.Color.White
        Me.GPEditar.Location = New System.Drawing.Point(140, 198)
        Me.GPEditar.Name = "GPEditar"
        Me.GPEditar.Size = New System.Drawing.Size(355, 106)
        Me.GPEditar.TabIndex = 8
        Me.GPEditar.TabStop = False
        Me.GPEditar.Text = "Editar Categoria"
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
        'GPBuscarCategoría
        '
        Me.GPBuscarCategoría.BackColor = System.Drawing.Color.Transparent
        Me.GPBuscarCategoría.Controls.Add(Me.TxtBuscarCategoria)
        Me.GPBuscarCategoría.Controls.Add(Me.LblCategoriaB)
        Me.GPBuscarCategoría.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GPBuscarCategoría.ForeColor = System.Drawing.Color.White
        Me.GPBuscarCategoría.Location = New System.Drawing.Point(140, 361)
        Me.GPBuscarCategoría.Name = "GPBuscarCategoría"
        Me.GPBuscarCategoría.Size = New System.Drawing.Size(355, 69)
        Me.GPBuscarCategoría.TabIndex = 9
        Me.GPBuscarCategoría.TabStop = False
        Me.GPBuscarCategoría.Text = "Buscar Categoría"
        '
        'TxtBuscarCategoria
        '
        Me.TxtBuscarCategoria.Location = New System.Drawing.Point(90, 32)
        Me.TxtBuscarCategoria.Name = "TxtBuscarCategoria"
        Me.TxtBuscarCategoria.Size = New System.Drawing.Size(242, 22)
        Me.TxtBuscarCategoria.TabIndex = 2
        '
        'LblCategoriaB
        '
        Me.LblCategoriaB.AutoSize = True
        Me.LblCategoriaB.Location = New System.Drawing.Point(24, 35)
        Me.LblCategoriaB.Name = "LblCategoriaB"
        Me.LblCategoriaB.Size = New System.Drawing.Size(60, 16)
        Me.LblCategoriaB.TabIndex = 1
        Me.LblCategoriaB.Text = "Nombre:"
        '
        'GPBotones
        '
        Me.GPBotones.BackColor = System.Drawing.Color.Transparent
        Me.GPBotones.Controls.Add(Me.BEliminar)
        Me.GPBotones.Controls.Add(Me.BActivar)
        Me.GPBotones.Location = New System.Drawing.Point(140, 481)
        Me.GPBotones.Name = "GPBotones"
        Me.GPBotones.Size = New System.Drawing.Size(355, 67)
        Me.GPBotones.TabIndex = 10
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
        Me.BActivar.Size = New System.Drawing.Size(92, 33)
        Me.BActivar.TabIndex = 4
        Me.BActivar.Text = "Activar"
        Me.BActivar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BActivar.UseVisualStyleBackColor = False
        '
        'CategoríaDataGridView
        '
        Me.CategoríaDataGridView.AllowUserToAddRows = False
        Me.CategoríaDataGridView.AllowUserToDeleteRows = False
        Me.CategoríaDataGridView.AutoGenerateColumns = False
        Me.CategoríaDataGridView.BackgroundColor = System.Drawing.SystemColors.InactiveBorder
        Me.CategoríaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CategoríaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreDataGridViewTextBoxColumn, Me.EstadocategoriaDataGridViewTextBoxColumn})
        Me.CategoríaDataGridView.DataSource = Me.CategoriasBindingSource
        Me.CategoríaDataGridView.Location = New System.Drawing.Point(562, 47)
        Me.CategoríaDataGridView.Name = "CategoríaDataGridView"
        Me.CategoríaDataGridView.ReadOnly = True
        Me.CategoríaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.CategoríaDataGridView.Size = New System.Drawing.Size(344, 501)
        Me.CategoríaDataGridView.TabIndex = 11
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre Categoría"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 120
        '
        'EstadocategoriaDataGridViewTextBoxColumn
        '
        Me.EstadocategoriaDataGridViewTextBoxColumn.DataPropertyName = "estado_categoria"
        Me.EstadocategoriaDataGridViewTextBoxColumn.HeaderText = "Estado (Chekeado=""Activo, No Chekeado= ""Dado de Baja"")"
        Me.EstadocategoriaDataGridViewTextBoxColumn.Name = "EstadocategoriaDataGridViewTextBoxColumn"
        Me.EstadocategoriaDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstadocategoriaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EstadocategoriaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.EstadocategoriaDataGridViewTextBoxColumn.Width = 190
        '
        'CategoriasBindingSource
        '
        Me.CategoriasBindingSource.DataMember = "Categorias"
        Me.CategoriasBindingSource.DataSource = Me.ElectrodomesticosDataSet
        '
        'ElectrodomesticosDataSet
        '
        Me.ElectrodomesticosDataSet.DataSetName = "ElectrodomesticosDataSet"
        Me.ElectrodomesticosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BVolver
        '
        Me.BVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BVolver.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.espalda__1_
        Me.BVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BVolver.Location = New System.Drawing.Point(440, 593)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(111, 43)
        Me.BVolver.TabIndex = 12
        Me.BVolver.Text = "Volver"
        Me.BVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BVolver.UseVisualStyleBackColor = True
        '
        'lblNombreCat
        '
        Me.lblNombreCat.AutoSize = True
        Me.lblNombreCat.BackColor = System.Drawing.Color.Transparent
        Me.lblNombreCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombreCat.ForeColor = System.Drawing.Color.White
        Me.lblNombreCat.Location = New System.Drawing.Point(54, 89)
        Me.lblNombreCat.Name = "lblNombreCat"
        Me.lblNombreCat.Size = New System.Drawing.Size(47, 420)
        Me.lblNombreCat.TabIndex = 13
        Me.lblNombreCat.Text = "C" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "A" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "T" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "E" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "G" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "O" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "R" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " Í" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "A" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "S"
        '
        'LModificar
        '
        Me.LModificar.AutoSize = True
        Me.LModificar.BackColor = System.Drawing.Color.Transparent
        Me.LModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LModificar.ForeColor = System.Drawing.Color.RoyalBlue
        Me.LModificar.Location = New System.Drawing.Point(642, 26)
        Me.LModificar.Name = "LModificar"
        Me.LModificar.Size = New System.Drawing.Size(264, 18)
        Me.LModificar.TabIndex = 14
        Me.LModificar.Text = "(Doble click para editar categoría)"
        '
        'LBaja
        '
        Me.LBaja.AutoSize = True
        Me.LBaja.BackColor = System.Drawing.Color.Transparent
        Me.LBaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBaja.ForeColor = System.Drawing.Color.YellowGreen
        Me.LBaja.Location = New System.Drawing.Point(559, 551)
        Me.LBaja.Name = "LBaja"
        Me.LBaja.Size = New System.Drawing.Size(193, 18)
        Me.LBaja.TabIndex = 33
        Me.LBaja.Text = "* Categoría dada de baja"
        '
        'CategoriasTableAdapter
        '
        Me.CategoriasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoriasTableAdapter = Me.CategoriasTableAdapter
        Me.TableAdapterManager.MarcaTableAdapter = Nothing
        Me.TableAdapterManager.ProvinciaTableAdapter = Nothing
        Me.TableAdapterManager.TipoEmpleadoTableAdapter = Nothing
        Me.TableAdapterManager.TipoUsuarioTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ABMCategoria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ElectrodomesticosLMJVA.My.Resources.Resources.fondoclaro
        Me.ClientSize = New System.Drawing.Size(940, 681)
        Me.ControlBox = False
        Me.Controls.Add(Me.LBaja)
        Me.Controls.Add(Me.LModificar)
        Me.Controls.Add(Me.lblNombreCat)
        Me.Controls.Add(Me.BVolver)
        Me.Controls.Add(Me.CategoríaDataGridView)
        Me.Controls.Add(Me.GPBotones)
        Me.Controls.Add(Me.GPBuscarCategoría)
        Me.Controls.Add(Me.GPEditar)
        Me.Controls.Add(Me.GPMarca)
        Me.Name = "ABMCategoria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar, Dar de Baja y Modificar Categorias"
        Me.GPMarca.ResumeLayout(False)
        Me.GPMarca.PerformLayout()
        Me.GPEditar.ResumeLayout(False)
        Me.GPEditar.PerformLayout()
        Me.GPBuscarCategoría.ResumeLayout(False)
        Me.GPBuscarCategoría.PerformLayout()
        Me.GPBotones.ResumeLayout(False)
        CType(Me.CategoríaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElectrodomesticosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GPMarca As System.Windows.Forms.GroupBox
    Friend WithEvents TxtCategoría As System.Windows.Forms.TextBox
    Friend WithEvents LblCategoria As System.Windows.Forms.Label
    Friend WithEvents BAgregar As System.Windows.Forms.Button
    Friend WithEvents GPEditar As System.Windows.Forms.GroupBox
    Friend WithEvents Bguardar As System.Windows.Forms.Button
    Friend WithEvents TxtNombreEditar As System.Windows.Forms.TextBox
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents GPBuscarCategoría As System.Windows.Forms.GroupBox
    Friend WithEvents TxtBuscarCategoria As System.Windows.Forms.TextBox
    Friend WithEvents LblCategoriaB As System.Windows.Forms.Label
    Friend WithEvents GPBotones As System.Windows.Forms.GroupBox
    Friend WithEvents BEliminar As System.Windows.Forms.Button
    Friend WithEvents BActivar As System.Windows.Forms.Button
    Friend WithEvents CategoríaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ElectrodomesticosDataSet As ElectrodomesticosLMJVA.ElectrodomesticosDataSet
    Friend WithEvents CategoriasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoriasTableAdapter As ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.CategoriasTableAdapter
    Friend WithEvents TableAdapterManager As ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents BVolver As System.Windows.Forms.Button
    Friend WithEvents lblNombreCat As System.Windows.Forms.Label
    Friend WithEvents LModificar As System.Windows.Forms.Label
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadocategoriaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents LBaja As System.Windows.Forms.Label
End Class
