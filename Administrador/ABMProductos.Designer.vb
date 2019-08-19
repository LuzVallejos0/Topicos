<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ABMProductos
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
        Me.GAgregarProducto = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.LblPrecio = New System.Windows.Forms.Label()
        Me.TxtDescripcion = New System.Windows.Forms.TextBox()
        Me.TxtStock = New System.Windows.Forms.TextBox()
        Me.LblStock = New System.Windows.Forms.Label()
        Me.LblDescripcion = New System.Windows.Forms.Label()
        Me.TxtModelo = New System.Windows.Forms.TextBox()
        Me.LblModelo = New System.Windows.Forms.Label()
        Me.LblCamposO = New System.Windows.Forms.Label()
        Me.CBmarca = New System.Windows.Forms.ComboBox()
        Me.MarcaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ElectrodomesticosDataSet = New ElectrodomesticosLMJVA.ElectrodomesticosDataSet()
        Me.LblMarca = New System.Windows.Forms.Label()
        Me.CBcategoria = New System.Windows.Forms.ComboBox()
        Me.CategoriasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LblCategoria = New System.Windows.Forms.Label()
        Me.LblProducto = New System.Windows.Forms.Label()
        Me.GBuscardor = New System.Windows.Forms.GroupBox()
        Me.TxtCodigo = New System.Windows.Forms.TextBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.CBbuscarCategoria = New System.Windows.Forms.ComboBox()
        Me.LblBuscador = New System.Windows.Forms.Label()
        Me.PicFotoBuscar = New System.Windows.Forms.PictureBox()
        Me.LblBuscarCategoria = New System.Windows.Forms.Label()
        Me.TxtGeneral = New System.Windows.Forms.TextBox()
        Me.DFecha = New System.Windows.Forms.DateTimePicker()
        Me.LblBuscarModelo = New System.Windows.Forms.Label()
        Me.BBuscarModelo = New System.Windows.Forms.Button()
        Me.GBotones = New System.Windows.Forms.GroupBox()
        Me.BActivar = New System.Windows.Forms.Button()
        Me.BEliminar = New System.Windows.Forms.Button()
        Me.BModificar = New System.Windows.Forms.Button()
        Me.BAgregar = New System.Windows.Forms.Button()
        Me.CategoriasTableAdapter = New ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.CategoriasTableAdapter()
        Me.MarcaTableAdapter = New ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.MarcaTableAdapter()
        Me.ProductosDataGridView = New System.Windows.Forms.DataGridView()
        Me.id_producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModeloDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescripcionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoproductoDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BVolver = New System.Windows.Forms.Button()
        Me.ProductosTableAdapter = New ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.ProductosTableAdapter()
        Me.LModificar = New System.Windows.Forms.Label()
        Me.LBaja = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GAgregarProducto.SuspendLayout()
        CType(Me.MarcaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ElectrodomesticosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBuscardor.SuspendLayout()
        CType(Me.PicFotoBuscar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GBotones.SuspendLayout()
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GAgregarProducto
        '
        Me.GAgregarProducto.BackColor = System.Drawing.Color.Transparent
        Me.GAgregarProducto.Controls.Add(Me.Label6)
        Me.GAgregarProducto.Controls.Add(Me.Label5)
        Me.GAgregarProducto.Controls.Add(Me.Label4)
        Me.GAgregarProducto.Controls.Add(Me.Label3)
        Me.GAgregarProducto.Controls.Add(Me.Label1)
        Me.GAgregarProducto.Controls.Add(Me.Label2)
        Me.GAgregarProducto.Controls.Add(Me.TxtPrecio)
        Me.GAgregarProducto.Controls.Add(Me.LblPrecio)
        Me.GAgregarProducto.Controls.Add(Me.TxtDescripcion)
        Me.GAgregarProducto.Controls.Add(Me.TxtStock)
        Me.GAgregarProducto.Controls.Add(Me.LblStock)
        Me.GAgregarProducto.Controls.Add(Me.LblDescripcion)
        Me.GAgregarProducto.Controls.Add(Me.TxtModelo)
        Me.GAgregarProducto.Controls.Add(Me.LblModelo)
        Me.GAgregarProducto.Controls.Add(Me.LblCamposO)
        Me.GAgregarProducto.Controls.Add(Me.CBmarca)
        Me.GAgregarProducto.Controls.Add(Me.LblMarca)
        Me.GAgregarProducto.Controls.Add(Me.CBcategoria)
        Me.GAgregarProducto.Controls.Add(Me.LblCategoria)
        Me.GAgregarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GAgregarProducto.ForeColor = System.Drawing.Color.White
        Me.GAgregarProducto.Location = New System.Drawing.Point(68, 12)
        Me.GAgregarProducto.Name = "GAgregarProducto"
        Me.GAgregarProducto.Size = New System.Drawing.Size(414, 396)
        Me.GAgregarProducto.TabIndex = 1
        Me.GAgregarProducto.TabStop = False
        Me.GAgregarProducto.Text = "Agregar Productos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label6.Location = New System.Drawing.Point(6, 361)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(14, 18)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label5.Location = New System.Drawing.Point(6, 306)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(14, 18)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label4.Location = New System.Drawing.Point(6, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 18)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label3.Location = New System.Drawing.Point(6, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 18)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label1.Location = New System.Drawing.Point(6, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 18)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.GreenYellow
        Me.Label2.Location = New System.Drawing.Point(6, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(14, 18)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "*"
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Location = New System.Drawing.Point(121, 355)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(254, 24)
        Me.TxtPrecio.TabIndex = 13
        '
        'LblPrecio
        '
        Me.LblPrecio.AutoSize = True
        Me.LblPrecio.Location = New System.Drawing.Point(26, 361)
        Me.LblPrecio.Name = "LblPrecio"
        Me.LblPrecio.Size = New System.Drawing.Size(67, 18)
        Me.LblPrecio.TabIndex = 12
        Me.LblPrecio.Text = "Precio $:"
        '
        'TxtDescripcion
        '
        Me.TxtDescripcion.Location = New System.Drawing.Point(122, 195)
        Me.TxtDescripcion.Multiline = True
        Me.TxtDescripcion.Name = "TxtDescripcion"
        Me.TxtDescripcion.Size = New System.Drawing.Size(253, 82)
        Me.TxtDescripcion.TabIndex = 11
        '
        'TxtStock
        '
        Me.TxtStock.Location = New System.Drawing.Point(121, 303)
        Me.TxtStock.Name = "TxtStock"
        Me.TxtStock.Size = New System.Drawing.Size(254, 24)
        Me.TxtStock.TabIndex = 10
        '
        'LblStock
        '
        Me.LblStock.AutoSize = True
        Me.LblStock.Location = New System.Drawing.Point(26, 306)
        Me.LblStock.Name = "LblStock"
        Me.LblStock.Size = New System.Drawing.Size(55, 18)
        Me.LblStock.TabIndex = 9
        Me.LblStock.Text = " Stock:"
        '
        'LblDescripcion
        '
        Me.LblDescripcion.AutoSize = True
        Me.LblDescripcion.Location = New System.Drawing.Point(26, 225)
        Me.LblDescripcion.Name = "LblDescripcion"
        Me.LblDescripcion.Size = New System.Drawing.Size(91, 18)
        Me.LblDescripcion.TabIndex = 7
        Me.LblDescripcion.Text = "Descripción:"
        '
        'TxtModelo
        '
        Me.TxtModelo.Location = New System.Drawing.Point(122, 150)
        Me.TxtModelo.Name = "TxtModelo"
        Me.TxtModelo.Size = New System.Drawing.Size(254, 24)
        Me.TxtModelo.TabIndex = 6
        '
        'LblModelo
        '
        Me.LblModelo.AutoSize = True
        Me.LblModelo.Location = New System.Drawing.Point(26, 156)
        Me.LblModelo.Name = "LblModelo"
        Me.LblModelo.Size = New System.Drawing.Size(62, 18)
        Me.LblModelo.TabIndex = 5
        Me.LblModelo.Text = "Modelo:"
        '
        'LblCamposO
        '
        Me.LblCamposO.AutoSize = True
        Me.LblCamposO.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCamposO.ForeColor = System.Drawing.Color.GreenYellow
        Me.LblCamposO.Location = New System.Drawing.Point(216, 21)
        Me.LblCamposO.Name = "LblCamposO"
        Me.LblCamposO.Size = New System.Drawing.Size(159, 18)
        Me.LblCamposO.TabIndex = 4
        Me.LblCamposO.Text = "* Campos Obligatorios"
        '
        'CBmarca
        '
        Me.CBmarca.DataSource = Me.MarcaBindingSource
        Me.CBmarca.DisplayMember = "nombre"
        Me.CBmarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBmarca.FormattingEnabled = True
        Me.CBmarca.Location = New System.Drawing.Point(122, 102)
        Me.CBmarca.Name = "CBmarca"
        Me.CBmarca.Size = New System.Drawing.Size(254, 26)
        Me.CBmarca.TabIndex = 3
        Me.CBmarca.ValueMember = "id_marca"
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
        'LblMarca
        '
        Me.LblMarca.AutoSize = True
        Me.LblMarca.Location = New System.Drawing.Point(26, 110)
        Me.LblMarca.Name = "LblMarca"
        Me.LblMarca.Size = New System.Drawing.Size(54, 18)
        Me.LblMarca.TabIndex = 2
        Me.LblMarca.Text = "Marca:"
        '
        'CBcategoria
        '
        Me.CBcategoria.DataSource = Me.CategoriasBindingSource
        Me.CBcategoria.DisplayMember = "nombre"
        Me.CBcategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBcategoria.FormattingEnabled = True
        Me.CBcategoria.Location = New System.Drawing.Point(123, 59)
        Me.CBcategoria.Name = "CBcategoria"
        Me.CBcategoria.Size = New System.Drawing.Size(253, 26)
        Me.CBcategoria.TabIndex = 1
        Me.CBcategoria.ValueMember = "id_categoria"
        '
        'CategoriasBindingSource
        '
        Me.CategoriasBindingSource.DataMember = "Categorias"
        Me.CategoriasBindingSource.DataSource = Me.ElectrodomesticosDataSet
        '
        'LblCategoria
        '
        Me.LblCategoria.AutoSize = True
        Me.LblCategoria.Location = New System.Drawing.Point(24, 62)
        Me.LblCategoria.Name = "LblCategoria"
        Me.LblCategoria.Size = New System.Drawing.Size(80, 18)
        Me.LblCategoria.TabIndex = 0
        Me.LblCategoria.Text = " Categoría:"
        '
        'LblProducto
        '
        Me.LblProducto.AutoSize = True
        Me.LblProducto.BackColor = System.Drawing.Color.Transparent
        Me.LblProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 29.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProducto.ForeColor = System.Drawing.Color.White
        Me.LblProducto.Location = New System.Drawing.Point(12, 12)
        Me.LblProducto.Name = "LblProducto"
        Me.LblProducto.Size = New System.Drawing.Size(50, 396)
        Me.LblProducto.TabIndex = 2
        Me.LblProducto.Text = "P" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "R" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "O" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "D" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "U" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "C" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "T" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "O" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "S" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'GBuscardor
        '
        Me.GBuscardor.BackColor = System.Drawing.Color.Transparent
        Me.GBuscardor.Controls.Add(Me.Button2)
        Me.GBuscardor.Controls.Add(Me.TxtCodigo)
        Me.GBuscardor.Controls.Add(Me.lblCodigo)
        Me.GBuscardor.Controls.Add(Me.CBbuscarCategoria)
        Me.GBuscardor.Controls.Add(Me.LblBuscador)
        Me.GBuscardor.Controls.Add(Me.PicFotoBuscar)
        Me.GBuscardor.Controls.Add(Me.LblBuscarCategoria)
        Me.GBuscardor.Controls.Add(Me.TxtGeneral)
        Me.GBuscardor.Controls.Add(Me.DFecha)
        Me.GBuscardor.Controls.Add(Me.LblBuscarModelo)
        Me.GBuscardor.Controls.Add(Me.BBuscarModelo)
        Me.GBuscardor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GBuscardor.Location = New System.Drawing.Point(488, 12)
        Me.GBuscardor.Name = "GBuscardor"
        Me.GBuscardor.Size = New System.Drawing.Size(444, 265)
        Me.GBuscardor.TabIndex = 25
        Me.GBuscardor.TabStop = False
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(117, 96)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(170, 22)
        Me.TxtCodigo.TabIndex = 21
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCodigo.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.lblCodigo.Location = New System.Drawing.Point(11, 96)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(88, 20)
        Me.lblCodigo.TabIndex = 20
        Me.lblCodigo.Text = "Por codigo:"
        '
        'CBbuscarCategoria
        '
        Me.CBbuscarCategoria.DataSource = Me.CategoriasBindingSource
        Me.CBbuscarCategoria.DisplayMember = "nombre"
        Me.CBbuscarCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBbuscarCategoria.FormattingEnabled = True
        Me.CBbuscarCategoria.Location = New System.Drawing.Point(117, 136)
        Me.CBbuscarCategoria.Name = "CBbuscarCategoria"
        Me.CBbuscarCategoria.Size = New System.Drawing.Size(171, 24)
        Me.CBbuscarCategoria.TabIndex = 16
        Me.CBbuscarCategoria.ValueMember = "id_categoria"
        '
        'LblBuscador
        '
        Me.LblBuscador.AutoSize = True
        Me.LblBuscador.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBuscador.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.LblBuscador.Location = New System.Drawing.Point(94, 51)
        Me.LblBuscador.Name = "LblBuscador"
        Me.LblBuscador.Size = New System.Drawing.Size(257, 25)
        Me.LblBuscador.TabIndex = 5
        Me.LblBuscador.Text = "Buscador de Productos"
        '
        'PicFotoBuscar
        '
        Me.PicFotoBuscar.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.productosElectro
        Me.PicFotoBuscar.Location = New System.Drawing.Point(309, 110)
        Me.PicFotoBuscar.Name = "PicFotoBuscar"
        Me.PicFotoBuscar.Size = New System.Drawing.Size(128, 120)
        Me.PicFotoBuscar.TabIndex = 12
        Me.PicFotoBuscar.TabStop = False
        '
        'LblBuscarCategoria
        '
        Me.LblBuscarCategoria.AutoSize = True
        Me.LblBuscarCategoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBuscarCategoria.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.LblBuscarCategoria.Location = New System.Drawing.Point(8, 140)
        Me.LblBuscarCategoria.Name = "LblBuscarCategoria"
        Me.LblBuscarCategoria.Size = New System.Drawing.Size(107, 20)
        Me.LblBuscarCategoria.TabIndex = 6
        Me.LblBuscarCategoria.Text = "Por categoría:"
        '
        'TxtGeneral
        '
        Me.TxtGeneral.Location = New System.Drawing.Point(114, 225)
        Me.TxtGeneral.Name = "TxtGeneral"
        Me.TxtGeneral.Size = New System.Drawing.Size(173, 22)
        Me.TxtGeneral.TabIndex = 10
        '
        'DFecha
        '
        Me.DFecha.Location = New System.Drawing.Point(6, 15)
        Me.DFecha.Name = "DFecha"
        Me.DFecha.Size = New System.Drawing.Size(431, 22)
        Me.DFecha.TabIndex = 15
        '
        'LblBuscarModelo
        '
        Me.LblBuscarModelo.AutoSize = True
        Me.LblBuscarModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBuscarModelo.ForeColor = System.Drawing.SystemColors.InactiveBorder
        Me.LblBuscarModelo.Location = New System.Drawing.Point(8, 225)
        Me.LblBuscarModelo.Name = "LblBuscarModelo"
        Me.LblBuscarModelo.Size = New System.Drawing.Size(93, 20)
        Me.LblBuscarModelo.TabIndex = 9
        Me.LblBuscarModelo.Text = "Por modelo:"
        '
        'BBuscarModelo
        '
        Me.BBuscarModelo.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.Buscarr
        Me.BBuscarModelo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BBuscarModelo.Location = New System.Drawing.Point(151, 178)
        Me.BBuscarModelo.Name = "BBuscarModelo"
        Me.BBuscarModelo.Size = New System.Drawing.Size(139, 25)
        Me.BBuscarModelo.TabIndex = 8
        Me.BBuscarModelo.Text = "Buscar Categoría" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BBuscarModelo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BBuscarModelo.UseVisualStyleBackColor = True
        '
        'GBotones
        '
        Me.GBotones.BackColor = System.Drawing.Color.Transparent
        Me.GBotones.Controls.Add(Me.BActivar)
        Me.GBotones.Controls.Add(Me.BEliminar)
        Me.GBotones.Controls.Add(Me.BModificar)
        Me.GBotones.Controls.Add(Me.BAgregar)
        Me.GBotones.ForeColor = System.Drawing.Color.White
        Me.GBotones.Location = New System.Drawing.Point(488, 283)
        Me.GBotones.Name = "GBotones"
        Me.GBotones.Size = New System.Drawing.Size(444, 125)
        Me.GBotones.TabIndex = 26
        Me.GBotones.TabStop = False
        '
        'BActivar
        '
        Me.BActivar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BActivar.ForeColor = System.Drawing.Color.Black
        Me.BActivar.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.aceptar1
        Me.BActivar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BActivar.Location = New System.Drawing.Point(309, 45)
        Me.BActivar.Name = "BActivar"
        Me.BActivar.Size = New System.Drawing.Size(128, 42)
        Me.BActivar.TabIndex = 4
        Me.BActivar.Text = " Activar Producto"
        Me.BActivar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BActivar.UseVisualStyleBackColor = True
        '
        'BEliminar
        '
        Me.BEliminar.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.eliminar1
        Me.BEliminar.Location = New System.Drawing.Point(200, 11)
        Me.BEliminar.Name = "BEliminar"
        Me.BEliminar.Size = New System.Drawing.Size(87, 108)
        Me.BEliminar.TabIndex = 2
        Me.BEliminar.UseVisualStyleBackColor = True
        '
        'BModificar
        '
        Me.BModificar.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.modificar
        Me.BModificar.Location = New System.Drawing.Point(104, 11)
        Me.BModificar.Name = "BModificar"
        Me.BModificar.Size = New System.Drawing.Size(87, 108)
        Me.BModificar.TabIndex = 1
        Me.BModificar.UseVisualStyleBackColor = True
        '
        'BAgregar
        '
        Me.BAgregar.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.agregar1
        Me.BAgregar.Location = New System.Drawing.Point(11, 11)
        Me.BAgregar.Name = "BAgregar"
        Me.BAgregar.Size = New System.Drawing.Size(87, 108)
        Me.BAgregar.TabIndex = 0
        Me.BAgregar.UseVisualStyleBackColor = True
        '
        'CategoriasTableAdapter
        '
        Me.CategoriasTableAdapter.ClearBeforeFill = True
        '
        'MarcaTableAdapter
        '
        Me.MarcaTableAdapter.ClearBeforeFill = True
        '
        'ProductosDataGridView
        '
        Me.ProductosDataGridView.AllowUserToAddRows = False
        Me.ProductosDataGridView.AllowUserToDeleteRows = False
        Me.ProductosDataGridView.AutoGenerateColumns = False
        Me.ProductosDataGridView.BackgroundColor = System.Drawing.SystemColors.InactiveBorder
        Me.ProductosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_producto, Me.Categoria, Me.Marca, Me.ModeloDataGridViewTextBoxColumn, Me.DescripcionDataGridViewTextBoxColumn, Me.StockDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn, Me.EstadoproductoDataGridViewCheckBoxColumn})
        Me.ProductosDataGridView.DataSource = Me.ProductosBindingSource
        Me.ProductosDataGridView.Location = New System.Drawing.Point(20, 433)
        Me.ProductosDataGridView.Name = "ProductosDataGridView"
        Me.ProductosDataGridView.ReadOnly = True
        Me.ProductosDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.ProductosDataGridView.Size = New System.Drawing.Size(912, 201)
        Me.ProductosDataGridView.TabIndex = 27
        '
        'id_producto
        '
        Me.id_producto.DataPropertyName = "id_producto"
        Me.id_producto.HeaderText = "Codigo Producto"
        Me.id_producto.Name = "id_producto"
        Me.id_producto.ReadOnly = True
        '
        'Categoria
        '
        Me.Categoria.DataPropertyName = "Categoria"
        Me.Categoria.HeaderText = "Categoria del Producto"
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
        'ModeloDataGridViewTextBoxColumn
        '
        Me.ModeloDataGridViewTextBoxColumn.DataPropertyName = "modelo"
        Me.ModeloDataGridViewTextBoxColumn.HeaderText = "Modelo del Producto"
        Me.ModeloDataGridViewTextBoxColumn.Name = "ModeloDataGridViewTextBoxColumn"
        Me.ModeloDataGridViewTextBoxColumn.ReadOnly = True
        Me.ModeloDataGridViewTextBoxColumn.Width = 150
        '
        'DescripcionDataGridViewTextBoxColumn
        '
        Me.DescripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion"
        Me.DescripcionDataGridViewTextBoxColumn.HeaderText = "Descripción del Producto"
        Me.DescripcionDataGridViewTextBoxColumn.Name = "DescripcionDataGridViewTextBoxColumn"
        Me.DescripcionDataGridViewTextBoxColumn.ReadOnly = True
        Me.DescripcionDataGridViewTextBoxColumn.Width = 150
        '
        'StockDataGridViewTextBoxColumn
        '
        Me.StockDataGridViewTextBoxColumn.DataPropertyName = "stock"
        Me.StockDataGridViewTextBoxColumn.HeaderText = "Stock"
        Me.StockDataGridViewTextBoxColumn.Name = "StockDataGridViewTextBoxColumn"
        Me.StockDataGridViewTextBoxColumn.ReadOnly = True
        Me.StockDataGridViewTextBoxColumn.Width = 80
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "precio"
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "Precio $"
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        Me.PrecioDataGridViewTextBoxColumn.ReadOnly = True
        Me.PrecioDataGridViewTextBoxColumn.Width = 90
        '
        'EstadoproductoDataGridViewCheckBoxColumn
        '
        Me.EstadoproductoDataGridViewCheckBoxColumn.DataPropertyName = "estado_producto"
        Me.EstadoproductoDataGridViewCheckBoxColumn.HeaderText = "Estado (Chekeado=""Activo, No Chekeado= ""Dado de Baja"")"
        Me.EstadoproductoDataGridViewCheckBoxColumn.Name = "EstadoproductoDataGridViewCheckBoxColumn"
        Me.EstadoproductoDataGridViewCheckBoxColumn.ReadOnly = True
        Me.EstadoproductoDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.EstadoproductoDataGridViewCheckBoxColumn.Width = 120
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.ElectrodomesticosDataSet
        '
        'BVolver
        '
        Me.BVolver.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BVolver.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.espalda__1_
        Me.BVolver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BVolver.Location = New System.Drawing.Point(824, 632)
        Me.BVolver.Name = "BVolver"
        Me.BVolver.Size = New System.Drawing.Size(108, 50)
        Me.BVolver.TabIndex = 28
        Me.BVolver.Text = "Volver"
        Me.BVolver.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BVolver.UseVisualStyleBackColor = True
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'LModificar
        '
        Me.LModificar.AutoSize = True
        Me.LModificar.BackColor = System.Drawing.Color.Transparent
        Me.LModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LModificar.ForeColor = System.Drawing.Color.DarkBlue
        Me.LModificar.Location = New System.Drawing.Point(28, 412)
        Me.LModificar.Name = "LModificar"
        Me.LModificar.Size = New System.Drawing.Size(312, 18)
        Me.LModificar.TabIndex = 29
        Me.LModificar.Text = "(Doble click para modificar un producto)"
        '
        'LBaja
        '
        Me.LBaja.AutoSize = True
        Me.LBaja.BackColor = System.Drawing.Color.Transparent
        Me.LBaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBaja.ForeColor = System.Drawing.Color.YellowGreen
        Me.LBaja.Location = New System.Drawing.Point(17, 640)
        Me.LBaja.Name = "LBaja"
        Me.LBaja.Size = New System.Drawing.Size(192, 18)
        Me.LBaja.TabIndex = 32
        Me.LBaja.Text = "* Producto dado de Baja"
        '
        'Button2
        '
        Me.Button2.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.refrescar
        Me.Button2.Location = New System.Drawing.Point(394, 40)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(43, 37)
        Me.Button2.TabIndex = 55
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ABMProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ElectrodomesticosLMJVA.My.Resources.Resources.fondoclaro
        Me.ClientSize = New System.Drawing.Size(940, 681)
        Me.ControlBox = False
        Me.Controls.Add(Me.LBaja)
        Me.Controls.Add(Me.LModificar)
        Me.Controls.Add(Me.BVolver)
        Me.Controls.Add(Me.ProductosDataGridView)
        Me.Controls.Add(Me.GBotones)
        Me.Controls.Add(Me.GBuscardor)
        Me.Controls.Add(Me.LblProducto)
        Me.Controls.Add(Me.GAgregarProducto)
        Me.Name = "ABMProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar, Dar de Baja y Modificar Productos"
        Me.GAgregarProducto.ResumeLayout(False)
        Me.GAgregarProducto.PerformLayout()
        CType(Me.MarcaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ElectrodomesticosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CategoriasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBuscardor.ResumeLayout(False)
        Me.GBuscardor.PerformLayout()
        CType(Me.PicFotoBuscar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GBotones.ResumeLayout(False)
        CType(Me.ProductosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GAgregarProducto As System.Windows.Forms.GroupBox
    Friend WithEvents LblProducto As System.Windows.Forms.Label
    Friend WithEvents CBcategoria As System.Windows.Forms.ComboBox
    Friend WithEvents LblCategoria As System.Windows.Forms.Label
    Friend WithEvents LblCamposO As System.Windows.Forms.Label
    Friend WithEvents CBmarca As System.Windows.Forms.ComboBox
    Friend WithEvents LblMarca As System.Windows.Forms.Label
    Friend WithEvents LblModelo As System.Windows.Forms.Label
    Friend WithEvents TxtModelo As System.Windows.Forms.TextBox
    Friend WithEvents LblDescripcion As System.Windows.Forms.Label
    Friend WithEvents TxtStock As System.Windows.Forms.TextBox
    Friend WithEvents LblStock As System.Windows.Forms.Label
    Friend WithEvents TxtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents TxtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents LblPrecio As System.Windows.Forms.Label
    Friend WithEvents GBuscardor As System.Windows.Forms.GroupBox
    Friend WithEvents LblBuscador As System.Windows.Forms.Label
    Friend WithEvents PicFotoBuscar As System.Windows.Forms.PictureBox
    Friend WithEvents LblBuscarCategoria As System.Windows.Forms.Label
    Friend WithEvents TxtGeneral As System.Windows.Forms.TextBox
    Friend WithEvents DFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblBuscarModelo As System.Windows.Forms.Label
    Friend WithEvents BBuscarModelo As System.Windows.Forms.Button
    Friend WithEvents GBotones As System.Windows.Forms.GroupBox
    Friend WithEvents BAgregar As System.Windows.Forms.Button
    Friend WithEvents BModificar As System.Windows.Forms.Button
    Friend WithEvents BEliminar As System.Windows.Forms.Button
    Friend WithEvents BActivar As System.Windows.Forms.Button
    Friend WithEvents CBbuscarCategoria As System.Windows.Forms.ComboBox
    Friend WithEvents ElectrodomesticosDataSet As ElectrodomesticosLMJVA.ElectrodomesticosDataSet
    Friend WithEvents CategoriasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CategoriasTableAdapter As ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.CategoriasTableAdapter
    Friend WithEvents MarcaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MarcaTableAdapter As ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.MarcaTableAdapter
    Friend WithEvents ProductosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents BVolver As System.Windows.Forms.Button
    Friend WithEvents ProductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosTableAdapter As ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.ProductosTableAdapter
    Friend WithEvents NombreCategoriaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NombreMarcaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LModificar As System.Windows.Forms.Label
    Friend WithEvents LBaja As System.Windows.Forms.Label
    Friend WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents lblCodigo As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents id_producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Categoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Marca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ModeloDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DescripcionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StockDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EstadoproductoDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
