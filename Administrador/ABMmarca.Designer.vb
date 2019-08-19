<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMmarca
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GPMarcas = New System.Windows.Forms.GroupBox()
        Me.BAgregar = New System.Windows.Forms.Button()
        Me.TxtMarca = New System.Windows.Forms.TextBox()
        Me.LblMarca = New System.Windows.Forms.Label()
        Me.BEliminar = New System.Windows.Forms.Button()
        Me.GPBuscarMarca = New System.Windows.Forms.GroupBox()
        Me.TxtNombreMarca = New System.Windows.Forms.TextBox()
        Me.LblBuscarMarca = New System.Windows.Forms.Label()
        Me.BVolver = New System.Windows.Forms.Button()
        Me.MarcaDataGridView = New System.Windows.Forms.DataGridView()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadomarcaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MarcaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ElectrodomesticosDataSet = New ElectrodomesticosLMJVA.ElectrodomesticosDataSet()
        Me.MarcaTableAdapter = New ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.MarcaTableAdapter()
        Me.TableAdapterManager = New ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.TableAdapterManager()
        Me.BActivar = New System.Windows.Forms.Button()
        Me.GPBotones = New System.Windows.Forms.GroupBox()
        Me.GPEditar = New System.Windows.Forms.GroupBox()
        Me.Bguardar = New System.Windows.Forms.Button()
        Me.TxtNombreEditar = New System.Windows.Forms.TextBox()
        Me.LblNombre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LEditar = New System.Windows.Forms.Label()
        Me.LBaja = New System.Windows.Forms.Label()
        Me.GPMarcas.SuspendLayout()
        Me.GPBuscarMarca.SuspendLayout()
        CType(Me.MarcaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarcaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElectrodomesticosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GPBotones.SuspendLayout()
        Me.GPEditar.SuspendLayout()
        Me.SuspendLayout()
        '
        'GPMarcas
        '
        Me.GPMarcas.BackColor = System.Drawing.Color.Transparent
        Me.GPMarcas.Controls.Add(Me.BAgregar)
        Me.GPMarcas.Controls.Add(Me.TxtMarca)
        Me.GPMarcas.Controls.Add(Me.LblMarca)
        Me.GPMarcas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GPMarcas.ForeColor = System.Drawing.Color.White
        Me.GPMarcas.Location = New System.Drawing.Point(135, 64)
        Me.GPMarcas.Name = "GPMarcas"
        Me.GPMarcas.Size = New System.Drawing.Size(355, 108)
        Me.GPMarcas.TabIndex = 0
        Me.GPMarcas.TabStop = False
        Me.GPMarcas.Text = "Agregar Marca"
        '
        'BAgregar
        '
        Me.BAgregar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BAgregar.ForeColor = System.Drawing.Color.Black
        Me.BAgregar.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.guardar
        Me.BAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BAgregar.Location = New System.Drawing.Point(234, 67)
        Me.BAgregar.Name = "BAgregar"
        Me.BAgregar.Size = New System.Drawing.Size(98, 31)
        Me.BAgregar.TabIndex = 2
        Me.BAgregar.Text = "Agregar"
        Me.BAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BAgregar.UseVisualStyleBackColor = False
        '
        'TxtMarca
        '
        Me.TxtMarca.Location = New System.Drawing.Point(90, 39)
        Me.TxtMarca.Name = "TxtMarca"
        Me.TxtMarca.Size = New System.Drawing.Size(242, 22)
        Me.TxtMarca.TabIndex = 1
        '
        'LblMarca
        '
        Me.LblMarca.AutoSize = True
        Me.LblMarca.Location = New System.Drawing.Point(24, 42)
        Me.LblMarca.Name = "LblMarca"
        Me.LblMarca.Size = New System.Drawing.Size(60, 16)
        Me.LblMarca.TabIndex = 0
        Me.LblMarca.Text = "Nombre:"
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
        'GPBuscarMarca
        '
        Me.GPBuscarMarca.BackColor = System.Drawing.Color.Transparent
        Me.GPBuscarMarca.Controls.Add(Me.TxtNombreMarca)
        Me.GPBuscarMarca.Controls.Add(Me.LblBuscarMarca)
        Me.GPBuscarMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GPBuscarMarca.ForeColor = System.Drawing.Color.White
        Me.GPBuscarMarca.Location = New System.Drawing.Point(135, 369)
        Me.GPBuscarMarca.Name = "GPBuscarMarca"
        Me.GPBuscarMarca.Size = New System.Drawing.Size(355, 69)
        Me.GPBuscarMarca.TabIndex = 4
        Me.GPBuscarMarca.TabStop = False
        Me.GPBuscarMarca.Text = "Buscar Marca"
        '
        'TxtNombreMarca
        '
        Me.TxtNombreMarca.Location = New System.Drawing.Point(90, 32)
        Me.TxtNombreMarca.Name = "TxtNombreMarca"
        Me.TxtNombreMarca.Size = New System.Drawing.Size(242, 22)
        Me.TxtNombreMarca.TabIndex = 2
        '
        'LblBuscarMarca
        '
        Me.LblBuscarMarca.AutoSize = True
        Me.LblBuscarMarca.Location = New System.Drawing.Point(24, 35)
        Me.LblBuscarMarca.Name = "LblBuscarMarca"
        Me.LblBuscarMarca.Size = New System.Drawing.Size(60, 16)
        Me.LblBuscarMarca.TabIndex = 1
        Me.LblBuscarMarca.Text = "Nombre:"
        '
        'BVolver
        '
        Me.BVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BVolver.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.espalda__1_
        Me.BVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BVolver.Location = New System.Drawing.Point(459, 608)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(111, 43)
        Me.BVolver.TabIndex = 5
        Me.BVolver.Text = "Volver"
        Me.BVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BVolver.UseVisualStyleBackColor = True
        '
        'MarcaDataGridView
        '
        Me.MarcaDataGridView.AllowUserToAddRows = False
        Me.MarcaDataGridView.AllowUserToDeleteRows = False
        Me.MarcaDataGridView.AutoGenerateColumns = False
        Me.MarcaDataGridView.BackgroundColor = System.Drawing.SystemColors.InactiveBorder
        Me.MarcaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MarcaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NombreDataGridViewTextBoxColumn, Me.EstadomarcaDataGridViewTextBoxColumn})
        Me.MarcaDataGridView.DataSource = Me.MarcaBindingSource
        Me.MarcaDataGridView.Location = New System.Drawing.Point(547, 76)
        Me.MarcaDataGridView.Name = "MarcaDataGridView"
        Me.MarcaDataGridView.ReadOnly = True
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.MarcaDataGridView.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.MarcaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.MarcaDataGridView.Size = New System.Drawing.Size(344, 484)
        Me.MarcaDataGridView.TabIndex = 5
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre de Marca"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        Me.NombreDataGridViewTextBoxColumn.ReadOnly = True
        Me.NombreDataGridViewTextBoxColumn.Width = 120
        '
        'EstadomarcaDataGridViewTextBoxColumn
        '
        Me.EstadomarcaDataGridViewTextBoxColumn.DataPropertyName = "estado_marca"
        Me.EstadomarcaDataGridViewTextBoxColumn.HeaderText = "Estado (Chekeado=""Activo, No Chekeado= ""Dado de Baja"")"
        Me.EstadomarcaDataGridViewTextBoxColumn.Name = "EstadomarcaDataGridViewTextBoxColumn"
        Me.EstadomarcaDataGridViewTextBoxColumn.ReadOnly = True
        Me.EstadomarcaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EstadomarcaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.EstadomarcaDataGridViewTextBoxColumn.Width = 190
        '
        'MarcaBindingSource
        '
        Me.MarcaBindingSource.DataMember = "Marca"
        Me.MarcaBindingSource.DataSource = Me.ElectrodomesticosDataSet
        '
        'ElectrodomesticosDataSet
        '
        Me.ElectrodomesticosDataSet.DataSetName = "ElectrodomesticosDataSet"
        Me.ElectrodomesticosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MarcaTableAdapter
        '
        Me.MarcaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CategoriasTableAdapter = Nothing
        Me.TableAdapterManager.MarcaTableAdapter = Me.MarcaTableAdapter
        Me.TableAdapterManager.ProvinciaTableAdapter = Nothing
        Me.TableAdapterManager.TipoEmpleadoTableAdapter = Nothing
        Me.TableAdapterManager.TipoUsuarioTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
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
        'GPBotones
        '
        Me.GPBotones.BackColor = System.Drawing.Color.Transparent
        Me.GPBotones.Controls.Add(Me.BEliminar)
        Me.GPBotones.Controls.Add(Me.BActivar)
        Me.GPBotones.Location = New System.Drawing.Point(135, 493)
        Me.GPBotones.Name = "GPBotones"
        Me.GPBotones.Size = New System.Drawing.Size(355, 67)
        Me.GPBotones.TabIndex = 6
        Me.GPBotones.TabStop = False
        '
        'GPEditar
        '
        Me.GPEditar.BackColor = System.Drawing.Color.Transparent
        Me.GPEditar.Controls.Add(Me.Bguardar)
        Me.GPEditar.Controls.Add(Me.TxtNombreEditar)
        Me.GPEditar.Controls.Add(Me.LblNombre)
        Me.GPEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GPEditar.ForeColor = System.Drawing.Color.White
        Me.GPEditar.Location = New System.Drawing.Point(135, 217)
        Me.GPEditar.Name = "GPEditar"
        Me.GPEditar.Size = New System.Drawing.Size(355, 106)
        Me.GPEditar.TabIndex = 7
        Me.GPEditar.TabStop = False
        Me.GPEditar.Text = "Editar Marca"
        '
        'Bguardar
        '
        Me.Bguardar.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Bguardar.ForeColor = System.Drawing.Color.Black
        Me.Bguardar.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.aceptar1
        Me.Bguardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Bguardar.Location = New System.Drawing.Point(239, 43)
        Me.Bguardar.Name = "Bguardar"
        Me.Bguardar.Size = New System.Drawing.Size(93, 33)
        Me.Bguardar.TabIndex = 6
        Me.Bguardar.Text = "Guardar"
        Me.Bguardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Bguardar.UseVisualStyleBackColor = False
        '
        'TxtNombreEditar
        '
        Me.TxtNombreEditar.Location = New System.Drawing.Point(90, 48)
        Me.TxtNombreEditar.Name = "TxtNombreEditar"
        Me.TxtNombreEditar.Size = New System.Drawing.Size(135, 22)
        Me.TxtNombreEditar.TabIndex = 1
        '
        'LblNombre
        '
        Me.LblNombre.AutoSize = True
        Me.LblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombre.Location = New System.Drawing.Point(24, 51)
        Me.LblNombre.Name = "LblNombre"
        Me.LblNombre.Size = New System.Drawing.Size(60, 16)
        Me.LblNombre.TabIndex = 0
        Me.LblNombre.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(30, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 330)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "M" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "A" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "R" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "C" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "A" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "S" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'LEditar
        '
        Me.LEditar.AutoSize = True
        Me.LEditar.BackColor = System.Drawing.Color.Transparent
        Me.LEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LEditar.ForeColor = System.Drawing.Color.RoyalBlue
        Me.LEditar.Location = New System.Drawing.Point(650, 55)
        Me.LEditar.Name = "LEditar"
        Me.LEditar.Size = New System.Drawing.Size(241, 18)
        Me.LEditar.TabIndex = 9
        Me.LEditar.Text = "(Double clik para editar marca)"
        '
        'LBaja
        '
        Me.LBaja.AutoSize = True
        Me.LBaja.BackColor = System.Drawing.Color.Transparent
        Me.LBaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBaja.ForeColor = System.Drawing.Color.YellowGreen
        Me.LBaja.Location = New System.Drawing.Point(544, 563)
        Me.LBaja.Name = "LBaja"
        Me.LBaja.Size = New System.Drawing.Size(167, 18)
        Me.LBaja.TabIndex = 34
        Me.LBaja.Text = "* Marca dada de baja"
        '
        'ABMmarca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.BackgroundImage = Global.ElectrodomesticosLMJVA.My.Resources.Resources.fondoclaro
        Me.ClientSize = New System.Drawing.Size(940, 681)
        Me.ControlBox = False
        Me.Controls.Add(Me.LBaja)
        Me.Controls.Add(Me.LEditar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GPEditar)
        Me.Controls.Add(Me.GPBotones)
        Me.Controls.Add(Me.MarcaDataGridView)
        Me.Controls.Add(Me.BVolver)
        Me.Controls.Add(Me.GPBuscarMarca)
        Me.Controls.Add(Me.GPMarcas)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ABMmarca"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar, Dar de Baja y Modificar Marcas"
        Me.GPMarcas.ResumeLayout(False)
        Me.GPMarcas.PerformLayout()
        Me.GPBuscarMarca.ResumeLayout(False)
        Me.GPBuscarMarca.PerformLayout()
        CType(Me.MarcaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarcaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElectrodomesticosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GPBotones.ResumeLayout(False)
        Me.GPEditar.ResumeLayout(False)
        Me.GPEditar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GPMarcas As System.Windows.Forms.GroupBox
    Friend WithEvents BAgregar As System.Windows.Forms.Button
    Friend WithEvents TxtMarca As System.Windows.Forms.TextBox
    Friend WithEvents LblMarca As System.Windows.Forms.Label
    Friend WithEvents ElectrodomesticosDataSet As ElectrodomesticosLMJVA.ElectrodomesticosDataSet
    Friend WithEvents MarcaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MarcaTableAdapter As ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.MarcaTableAdapter
    Friend WithEvents TableAdapterManager As ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GPBuscarMarca As System.Windows.Forms.GroupBox
    Friend WithEvents TxtNombreMarca As System.Windows.Forms.TextBox
    Friend WithEvents LblBuscarMarca As System.Windows.Forms.Label
    Friend WithEvents BVolver As System.Windows.Forms.Button
    Friend WithEvents MarcaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents BEliminar As System.Windows.Forms.Button
    Friend WithEvents BActivar As System.Windows.Forms.Button
    Friend WithEvents GPBotones As System.Windows.Forms.GroupBox
    Friend WithEvents GPEditar As System.Windows.Forms.GroupBox
    Friend WithEvents TxtNombreEditar As System.Windows.Forms.TextBox
    Friend WithEvents LblNombre As System.Windows.Forms.Label
    Friend WithEvents Bguardar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LEditar As System.Windows.Forms.Label
    Friend WithEvents NombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadomarcaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents LBaja As System.Windows.Forms.Label
End Class
