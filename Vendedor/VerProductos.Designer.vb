<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VerProductos
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
        Me.ConsultaDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdproductoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoriaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModeloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoproductoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ElectrodomesticosDataSet = New ElectrodomesticosLMJVA.ElectrodomesticosDataSet()
        Me.LblBuscarModelo = New System.Windows.Forms.Label()
        Me.TxtModelo = New System.Windows.Forms.TextBox()
        Me.LblBuscarCategoria = New System.Windows.Forms.Label()
        Me.CBbuscarCategoria = New System.Windows.Forms.ComboBox()
        Me.CategoriasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.GBuscardor = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ProductosTableAdapter = New ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.ProductosTableAdapter()
        Me.CategoriasTableAdapter = New ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.CategoriasTableAdapter()
        Me.LLista = New System.Windows.Forms.Label()
        Me.LBaja = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.ConsultaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElectrodomesticosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBuscardor.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ConsultaDataGridView
        '
        Me.ConsultaDataGridView.AllowUserToAddRows = False
        Me.ConsultaDataGridView.AllowUserToDeleteRows = False
        Me.ConsultaDataGridView.AutoGenerateColumns = False
        Me.ConsultaDataGridView.BackgroundColor = System.Drawing.SystemColors.InactiveBorder
        Me.ConsultaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ConsultaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdproductoDataGridViewTextBoxColumn, Me.CategoriaDataGridViewTextBoxColumn, Me.MarcaDataGridViewTextBoxColumn, Me.ModeloDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.StockDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.EstadoproductoDataGridViewCheckBoxColumn})
        Me.ConsultaDataGridView.DataSource = Me.ProductosBindingSource
        Me.ConsultaDataGridView.Location = New System.Drawing.Point(48, 170)
        Me.ConsultaDataGridView.Name = "ConsultaDataGridView"
        Me.ConsultaDataGridView.ReadOnly = True
        Me.ConsultaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ConsultaDataGridView.Size = New System.Drawing.Size(869, 499)
        Me.ConsultaDataGridView.TabIndex = 32
        '
        'IdproductoDataGridViewTextBoxColumn
        '
        Me.IdproductoDataGridViewTextBoxColumn.DataPropertyName = "id_producto"
        Me.IdproductoDataGridViewTextBoxColumn.HeaderText = "Código del Producto"
        Me.IdproductoDataGridViewTextBoxColumn.Name = "IdproductoDataGridViewTextBoxColumn"
        Me.IdproductoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CategoriaDataGridViewTextBoxColumn
        '
        Me.CategoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria"
        Me.CategoriaDataGridViewTextBoxColumn.HeaderText = "Categoria"
        Me.CategoriaDataGridViewTextBoxColumn.Name = "CategoriaDataGridViewTextBoxColumn"
        Me.CategoriaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MarcaDataGridViewTextBoxColumn
        '
        Me.MarcaDataGridViewTextBoxColumn.DataPropertyName = "Marca"
        Me.MarcaDataGridViewTextBoxColumn.HeaderText = "Marca"
        Me.MarcaDataGridViewTextBoxColumn.Name = "MarcaDataGridViewTextBoxColumn"
        Me.MarcaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ModeloDataGridViewTextBoxColumn
        '
        Me.ModeloDataGridViewTextBoxColumn.DataPropertyName = "modelo"
        Me.ModeloDataGridViewTextBoxColumn.HeaderText = "Modelo"
        Me.ModeloDataGridViewTextBoxColumn.Name = "ModeloDataGridViewTextBoxColumn"
        Me.ModeloDataGridViewTextBoxColumn.ReadOnly = True
        Me.ModeloDataGridViewTextBoxColumn.Width = 110
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripción del Producto"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 120
        '
        'StockDataGridViewTextBoxColumn
        '
        Me.StockDataGridViewTextBoxColumn.DataPropertyName = "stock"
        Me.StockDataGridViewTextBoxColumn.HeaderText = "Stock"
        Me.StockDataGridViewTextBoxColumn.Name = "StockDataGridViewTextBoxColumn"
        Me.StockDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "precio"
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "Precio $"
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        Me.PrecioDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EstadoproductoDataGridViewCheckBoxColumn
        '
        Me.EstadoproductoDataGridViewCheckBoxColumn.DataPropertyName = "estado_producto"
        Me.EstadoproductoDataGridViewCheckBoxColumn.HeaderText = "Estado"
        Me.EstadoproductoDataGridViewCheckBoxColumn.Name = "EstadoproductoDataGridViewCheckBoxColumn"
        Me.EstadoproductoDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.ElectrodomesticosDataSet
        '
        'ElectrodomesticosDataSet
        '
        Me.ElectrodomesticosDataSet.DataSetName = "ElectrodomesticosDataSet"
        Me.ElectrodomesticosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LblBuscarModelo
        '
        Me.LblBuscarModelo.AutoSize = True
        Me.LblBuscarModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBuscarModelo.ForeColor = System.Drawing.Color.White
        Me.LblBuscarModelo.Location = New System.Drawing.Point(302, 31)
        Me.LblBuscarModelo.Name = "LblBuscarModelo"
        Me.LblBuscarModelo.Size = New System.Drawing.Size(93, 20)
        Me.LblBuscarModelo.TabIndex = 9
        Me.LblBuscarModelo.Text = "Por modelo:"
        '
        'TxtModelo
        '
        Me.TxtModelo.Location = New System.Drawing.Point(401, 27)
        Me.TxtModelo.Name = "TxtModelo"
        Me.TxtModelo.Size = New System.Drawing.Size(149, 26)
        Me.TxtModelo.TabIndex = 10
        '
        'LblBuscarCategoria
        '
        Me.LblBuscarCategoria.AutoSize = True
        Me.LblBuscarCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBuscarCategoria.ForeColor = System.Drawing.Color.White
        Me.LblBuscarCategoria.Location = New System.Drawing.Point(571, 31)
        Me.LblBuscarCategoria.Name = "LblBuscarCategoria"
        Me.LblBuscarCategoria.Size = New System.Drawing.Size(107, 20)
        Me.LblBuscarCategoria.TabIndex = 6
        Me.LblBuscarCategoria.Text = "Por categoría:"
        '
        'CBbuscarCategoria
        '
        Me.CBbuscarCategoria.DataSource = Me.CategoriasBindingSource
        Me.CBbuscarCategoria.DisplayMember = "nombre"
        Me.CBbuscarCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBbuscarCategoria.FormattingEnabled = True
        Me.CBbuscarCategoria.Location = New System.Drawing.Point(680, 28)
        Me.CBbuscarCategoria.Name = "CBbuscarCategoria"
        Me.CBbuscarCategoria.Size = New System.Drawing.Size(150, 28)
        Me.CBbuscarCategoria.TabIndex = 16
        Me.CBbuscarCategoria.ValueMember = "id_categoria"
        '
        'CategoriasBindingSource
        '
        Me.CategoriasBindingSource.DataMember = "Categorias"
        Me.CategoriasBindingSource.DataSource = Me.ElectrodomesticosDataSet
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.ForeColor = System.Drawing.Color.White
        Me.lblCodigo.Location = New System.Drawing.Point(6, 29)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(88, 20)
        Me.lblCodigo.TabIndex = 17
        Me.lblCodigo.Text = "Por código:"
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(100, 25)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(137, 26)
        Me.TxtCodigo.TabIndex = 18
        '
        'GBuscardor
        '
        Me.GBuscardor.BackColor = System.Drawing.Color.Transparent
        Me.GBuscardor.Controls.Add(Me.Button1)
        Me.GBuscardor.Controls.Add(Me.TxtCodigo)
        Me.GBuscardor.Controls.Add(Me.lblCodigo)
        Me.GBuscardor.Controls.Add(Me.CBbuscarCategoria)
        Me.GBuscardor.Controls.Add(Me.LblBuscarCategoria)
        Me.GBuscardor.Controls.Add(Me.TxtModelo)
        Me.GBuscardor.Controls.Add(Me.LblBuscarModelo)
        Me.GBuscardor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBuscardor.ForeColor = System.Drawing.Color.White
        Me.GBuscardor.Location = New System.Drawing.Point(48, 84)
        Me.GBuscardor.Name = "GBuscardor"
        Me.GBuscardor.Size = New System.Drawing.Size(869, 65)
        Me.GBuscardor.TabIndex = 33
        Me.GBuscardor.TabStop = False
        Me.GBuscardor.Text = "Buscador de Productos"
        '
        'Button1
        '
        Me.Button1.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.Buscarr
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(836, 25)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(28, 33)
        Me.Button1.TabIndex = 20
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'CategoriasTableAdapter
        '
        Me.CategoriasTableAdapter.ClearBeforeFill = True
        '
        'LLista
        '
        Me.LLista.AutoSize = True
        Me.LLista.BackColor = System.Drawing.Color.Transparent
        Me.LLista.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLista.ForeColor = System.Drawing.Color.White
        Me.LLista.Location = New System.Drawing.Point(312, 39)
        Me.LLista.Name = "LLista"
        Me.LLista.Size = New System.Drawing.Size(346, 42)
        Me.LLista.TabIndex = 35
        Me.LLista.Text = "Lista de Productos"
        '
        'LBaja
        '
        Me.LBaja.AutoSize = True
        Me.LBaja.BackColor = System.Drawing.Color.Transparent
        Me.LBaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBaja.ForeColor = System.Drawing.Color.YellowGreen
        Me.LBaja.Location = New System.Drawing.Point(725, 152)
        Me.LBaja.Name = "LBaja"
        Me.LBaja.Size = New System.Drawing.Size(192, 18)
        Me.LBaja.TabIndex = 36
        Me.LBaja.Text = "* Producto dado de Baja"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(940, 27)
        Me.MenuStrip1.TabIndex = 52
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalirToolStripMenuItem.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.flecha_hacia_la_izquierda
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(222, 23)
        Me.SalirToolStripMenuItem.Text = "Volver al menú del Vendedor"
        '
        'Button2
        '
        Me.Button2.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.refrescar
        Me.Button2.Location = New System.Drawing.Point(869, 44)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(43, 37)
        Me.Button2.TabIndex = 58
        Me.Button2.UseVisualStyleBackColor = True
        '
        'VerProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ElectrodomesticosLMJVA.My.Resources.Resources.fondoclaro
        Me.ClientSize = New System.Drawing.Size(940, 681)
        Me.ControlBox = False
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.LBaja)
        Me.Controls.Add(Me.LLista)
        Me.Controls.Add(Me.GBuscardor)
        Me.Controls.Add(Me.ConsultaDataGridView)
        Me.Name = "VerProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VerProductos"
        CType(Me.ConsultaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElectrodomesticosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBuscardor.ResumeLayout(False)
        Me.GBuscardor.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ConsultaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents LblBuscarModelo As System.Windows.Forms.Label
    Friend WithEvents TxtModelo As System.Windows.Forms.TextBox
    Friend WithEvents LblBuscarCategoria As System.Windows.Forms.Label
    Friend WithEvents CBbuscarCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents GBuscardor As System.Windows.Forms.GroupBox
    Friend WithEvents ElectrodomesticosDataSet As ElectrodomesticosLMJVA.ElectrodomesticosDataSet
    Friend WithEvents ProductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosTableAdapter As ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.ProductosTableAdapter
    Friend WithEvents CategoriasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoriasTableAdapter As ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.CategoriasTableAdapter
    Friend WithEvents LLista As System.Windows.Forms.Label
    Friend WithEvents LBaja As System.Windows.Forms.Label
    Friend WithEvents IdproductoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CategoriaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MarcaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModeloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StockDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoproductoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
