<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listarProductos
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
        Me.ElectrodomesticosDataSet = New ElectrodomesticosLMJVA.ElectrodomesticosDataSet()
        Me.ConsultaDataGridView = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModeloDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CategoriasTableAdapter = New ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.CategoriasTableAdapter()
        Me.MarcaTableAdapter = New ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.MarcaTableAdapter()
        Me.ProductosTableAdapter = New ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.ProductosTableAdapter()
        Me.GBuscardor = New System.Windows.Forms.GroupBox()
        Me.BCat = New System.Windows.Forms.Button()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.CBbuscarCategoria = New System.Windows.Forms.ComboBox()
        Me.CategoriasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LblBuscador = New System.Windows.Forms.Label()
        Me.PicFotoBuscar = New System.Windows.Forms.PictureBox()
        Me.LblBuscarCategoria = New System.Windows.Forms.Label()
        Me.TxtModelo = New System.Windows.Forms.TextBox()
        Me.LblBuscarModelo = New System.Windows.Forms.Label()
        Me.LModificar = New System.Windows.Forms.Label()
        Me.MarcaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.TableAdapterManager()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.ElectrodomesticosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ConsultaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBuscardor.SuspendLayout()
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicFotoBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarcaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ElectrodomesticosDataSet
        '
        Me.ElectrodomesticosDataSet.DataSetName = "ElectrodomesticosDataSet"
        Me.ElectrodomesticosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ConsultaDataGridView
        '
        Me.ConsultaDataGridView.AllowUserToAddRows = False
        Me.ConsultaDataGridView.AllowUserToDeleteRows = False
        Me.ConsultaDataGridView.AutoGenerateColumns = False
        Me.ConsultaDataGridView.BackgroundColor = System.Drawing.SystemColors.InactiveBorder
        Me.ConsultaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ConsultaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Categoria, Me.Marca, Me.ModeloDataGridViewTextBoxColumn1, Me.DescripcionDataGridViewTextBoxColumn1, Me.StockDataGridViewTextBoxColumn1, Me.PrecioDataGridViewTextBoxColumn1})
        Me.ConsultaDataGridView.DataSource = Me.ProductosBindingSource
        Me.ConsultaDataGridView.Location = New System.Drawing.Point(58, 254)
        Me.ConsultaDataGridView.Name = "ConsultaDataGridView"
        Me.ConsultaDataGridView.ReadOnly = True
        Me.ConsultaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ConsultaDataGridView.Size = New System.Drawing.Size(675, 337)
        Me.ConsultaDataGridView.TabIndex = 3
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "id_producto"
        Me.Column1.HeaderText = "Codigo del Producto"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Categoria
        '
        Me.Categoria.DataPropertyName = "Categoria"
        Me.Categoria.HeaderText = "Categoria"
        Me.Categoria.Name = "Categoria"
        Me.Categoria.ReadOnly = True
        '
        'Marca
        '
        Me.Marca.DataPropertyName = "Marca"
        Me.Marca.HeaderText = "Marca"
        Me.Marca.Name = "Marca"
        Me.Marca.ReadOnly = True
        Me.Marca.Width = 90
        '
        'ModeloDataGridViewTextBoxColumn1
        '
        Me.ModeloDataGridViewTextBoxColumn1.DataPropertyName = "modelo"
        Me.ModeloDataGridViewTextBoxColumn1.HeaderText = "Modelo del Producto"
        Me.ModeloDataGridViewTextBoxColumn1.Name = "ModeloDataGridViewTextBoxColumn1"
        Me.ModeloDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DescripcionDataGridViewTextBoxColumn1
        '
        Me.DescripcionDataGridViewTextBoxColumn1.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn1.HeaderText = "Descripción"
        Me.DescripcionDataGridViewTextBoxColumn1.Name = "DescripcionDataGridViewTextBoxColumn1"
        Me.DescripcionDataGridViewTextBoxColumn1.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn1.Width = 90
        '
        'StockDataGridViewTextBoxColumn1
        '
        Me.StockDataGridViewTextBoxColumn1.DataPropertyName = "stock"
        Me.StockDataGridViewTextBoxColumn1.HeaderText = "Stock"
        Me.StockDataGridViewTextBoxColumn1.Name = "StockDataGridViewTextBoxColumn1"
        Me.StockDataGridViewTextBoxColumn1.ReadOnly = True
        Me.StockDataGridViewTextBoxColumn1.Width = 70
        '
        'PrecioDataGridViewTextBoxColumn1
        '
        Me.PrecioDataGridViewTextBoxColumn1.DataPropertyName = "precio"
        Me.PrecioDataGridViewTextBoxColumn1.HeaderText = "Precio $"
        Me.PrecioDataGridViewTextBoxColumn1.Name = "PrecioDataGridViewTextBoxColumn1"
        Me.PrecioDataGridViewTextBoxColumn1.ReadOnly = True
        Me.PrecioDataGridViewTextBoxColumn1.Width = 80
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.ElectrodomesticosDataSet
        '
        'CategoriasTableAdapter
        '
        Me.CategoriasTableAdapter.ClearBeforeFill = True
        '
        'MarcaTableAdapter
        '
        Me.MarcaTableAdapter.ClearBeforeFill = True
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'GBuscardor
        '
        Me.GBuscardor.BackColor = System.Drawing.Color.Transparent
        Me.GBuscardor.Controls.Add(Me.Button2)
        Me.GBuscardor.Controls.Add(Me.BCat)
        Me.GBuscardor.Controls.Add(Me.TxtCodigo)
        Me.GBuscardor.Controls.Add(Me.lblCodigo)
        Me.GBuscardor.Controls.Add(Me.CBbuscarCategoria)
        Me.GBuscardor.Controls.Add(Me.LblBuscador)
        Me.GBuscardor.Controls.Add(Me.PicFotoBuscar)
        Me.GBuscardor.Controls.Add(Me.LblBuscarCategoria)
        Me.GBuscardor.Controls.Add(Me.TxtModelo)
        Me.GBuscardor.Controls.Add(Me.LblBuscarModelo)
        Me.GBuscardor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBuscardor.Location = New System.Drawing.Point(58, 12)
        Me.GBuscardor.Name = "GBuscardor"
        Me.GBuscardor.Size = New System.Drawing.Size(675, 218)
        Me.GBuscardor.TabIndex = 26
        Me.GBuscardor.TabStop = False
        '
        'BCat
        '
        Me.BCat.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.Buscarr
        Me.BCat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BCat.Location = New System.Drawing.Point(423, 69)
        Me.BCat.Name = "BCat"
        Me.BCat.Size = New System.Drawing.Size(28, 27)
        Me.BCat.TabIndex = 20
        Me.BCat.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BCat.UseVisualStyleBackColor = True
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(210, 130)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(205, 22)
        Me.TxtCodigo.TabIndex = 18
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.ForeColor = System.Drawing.Color.Black
        Me.lblCodigo.Location = New System.Drawing.Point(87, 129)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(88, 20)
        Me.lblCodigo.TabIndex = 17
        Me.lblCodigo.Text = "Por codigo:"
        '
        'CBbuscarCategoria
        '
        Me.CBbuscarCategoria.DataSource = Me.CategoriasBindingSource
        Me.CBbuscarCategoria.DisplayMember = "nombre"
        Me.CBbuscarCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBbuscarCategoria.FormattingEnabled = True
        Me.CBbuscarCategoria.Location = New System.Drawing.Point(210, 71)
        Me.CBbuscarCategoria.Name = "CBbuscarCategoria"
        Me.CBbuscarCategoria.Size = New System.Drawing.Size(205, 24)
        Me.CBbuscarCategoria.TabIndex = 16
        Me.CBbuscarCategoria.ValueMember = "id_categoria"
        '
        'CategoriasBindingSource
        '
        Me.CategoriasBindingSource.DataMember = "Categorias"
        Me.CategoriasBindingSource.DataSource = Me.ElectrodomesticosDataSet
        '
        'LblBuscador
        '
        Me.LblBuscador.AutoSize = True
        Me.LblBuscador.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBuscador.ForeColor = System.Drawing.Color.Black
        Me.LblBuscador.Location = New System.Drawing.Point(186, 18)
        Me.LblBuscador.Name = "LblBuscador"
        Me.LblBuscador.Size = New System.Drawing.Size(317, 31)
        Me.LblBuscador.TabIndex = 5
        Me.LblBuscador.Text = "Buscador de Productos"
        '
        'PicFotoBuscar
        '
        Me.PicFotoBuscar.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.productosElectro
        Me.PicFotoBuscar.Location = New System.Drawing.Point(510, 75)
        Me.PicFotoBuscar.Name = "PicFotoBuscar"
        Me.PicFotoBuscar.Size = New System.Drawing.Size(127, 120)
        Me.PicFotoBuscar.TabIndex = 12
        Me.PicFotoBuscar.TabStop = False
        '
        'LblBuscarCategoria
        '
        Me.LblBuscarCategoria.AutoSize = True
        Me.LblBuscarCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBuscarCategoria.ForeColor = System.Drawing.Color.Black
        Me.LblBuscarCategoria.Location = New System.Drawing.Point(87, 75)
        Me.LblBuscarCategoria.Name = "LblBuscarCategoria"
        Me.LblBuscarCategoria.Size = New System.Drawing.Size(107, 20)
        Me.LblBuscarCategoria.TabIndex = 6
        Me.LblBuscarCategoria.Text = "Por categoría:"
        '
        'TxtModelo
        '
        Me.TxtModelo.Location = New System.Drawing.Point(207, 185)
        Me.TxtModelo.Name = "TxtModelo"
        Me.TxtModelo.Size = New System.Drawing.Size(208, 22)
        Me.TxtModelo.TabIndex = 10
        '
        'LblBuscarModelo
        '
        Me.LblBuscarModelo.AutoSize = True
        Me.LblBuscarModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBuscarModelo.ForeColor = System.Drawing.Color.Black
        Me.LblBuscarModelo.Location = New System.Drawing.Point(87, 185)
        Me.LblBuscarModelo.Name = "LblBuscarModelo"
        Me.LblBuscarModelo.Size = New System.Drawing.Size(93, 20)
        Me.LblBuscarModelo.TabIndex = 9
        Me.LblBuscarModelo.Text = "Por modelo:"
        '
        'LModificar
        '
        Me.LModificar.AutoSize = True
        Me.LModificar.BackColor = System.Drawing.Color.Transparent
        Me.LModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LModificar.ForeColor = System.Drawing.Color.GreenYellow
        Me.LModificar.Location = New System.Drawing.Point(275, 233)
        Me.LModificar.Name = "LModificar"
        Me.LModificar.Size = New System.Drawing.Size(274, 18)
        Me.LModificar.TabIndex = 31
        Me.LModificar.Text = "(Doble click para agregar a Ventas)"
        '
        'MarcaBindingSource
        '
        Me.MarcaBindingSource.DataMember = "Marca"
        Me.MarcaBindingSource.DataSource = Me.ElectrodomesticosDataSet
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
        'Button2
        '
        Me.Button2.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.refrescar
        Me.Button2.Location = New System.Drawing.Point(594, 21)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(43, 37)
        Me.Button2.TabIndex = 56
        Me.Button2.UseVisualStyleBackColor = True
        '
        'listarProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(806, 603)
        Me.Controls.Add(Me.LModificar)
        Me.Controls.Add(Me.GBuscardor)
        Me.Controls.Add(Me.ConsultaDataGridView)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "listarProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lista de Productos"
        CType(Me.ElectrodomesticosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ConsultaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBuscardor.ResumeLayout(False)
        Me.GBuscardor.PerformLayout()
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicFotoBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarcaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ConsultaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents ElectrodomesticosDataSet As ElectrodomesticosLMJVA.ElectrodomesticosDataSet
    Friend WithEvents CategoriasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoriasTableAdapter As ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.CategoriasTableAdapter
    Friend WithEvents MarcaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MarcaTableAdapter As ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.MarcaTableAdapter
    Friend WithEvents ProductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosTableAdapter As ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.ProductosTableAdapter
    Friend WithEvents TableAdapterManager As ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents GBuscardor As System.Windows.Forms.GroupBox
    Friend WithEvents CBbuscarCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents LblBuscador As System.Windows.Forms.Label
    Friend WithEvents PicFotoBuscar As System.Windows.Forms.PictureBox
    Friend WithEvents LblBuscarCategoria As System.Windows.Forms.Label
    Friend WithEvents TxtModelo As System.Windows.Forms.TextBox
    Friend WithEvents LblBuscarModelo As System.Windows.Forms.Label
    Friend WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents NombreCategoriaDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreMarcaDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LModificar As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Categoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Marca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModeloDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StockDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BCat As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
