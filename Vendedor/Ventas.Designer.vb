<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventas
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
        Me.LblFactura = New System.Windows.Forms.Label()
        Me.TxtFactura = New System.Windows.Forms.TextBox()
        Me.lblDNIVendedor = New System.Windows.Forms.Label()
        Me.TxtDNIVendedor = New System.Windows.Forms.TextBox()
        Me.LNombreVendedor = New System.Windows.Forms.Label()
        Me.TxtNombreVendedor = New System.Windows.Forms.TextBox()
        Me.LFecha = New System.Windows.Forms.Label()
        Me.GVendedor = New System.Windows.Forms.GroupBox()
        Me.lblFac = New System.Windows.Forms.GroupBox()
        Me.txtFecha = New System.Windows.Forms.TextBox()
        Me.VentaDataGridView = New System.Windows.Forms.DataGridView()
        Me.CodigoArticulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Categoria = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marca = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modelo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stock = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TxtTotal = New System.Windows.Forms.TextBox()
        Me.LTotal = New System.Windows.Forms.Label()
        Me.LblVentas = New System.Windows.Forms.Label()
        Me.TxtNombreCliente = New System.Windows.Forms.TextBox()
        Me.TxtApellidoCiente = New System.Windows.Forms.TextBox()
        Me.LClienteNombre = New System.Windows.Forms.Label()
        Me.LApellidoCliente = New System.Windows.Forms.Label()
        Me.TxtDNICliente = New System.Windows.Forms.TextBox()
        Me.LblDniCliente = New System.Windows.Forms.Label()
        Me.GClientes = New System.Windows.Forms.GroupBox()
        Me.TxtID = New System.Windows.Forms.TextBox()
        Me.BCliente = New System.Windows.Forms.Button()
        Me.BBuscarDNI = New System.Windows.Forms.Button()
        Me.GProductos = New System.Windows.Forms.GroupBox()
        Me.txtstock = New System.Windows.Forms.TextBox()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.TxtMarca = New System.Windows.Forms.TextBox()
        Me.TxtCategoria = New System.Windows.Forms.TextBox()
        Me.BBuscarProducto = New System.Windows.Forms.Button()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.LblPrecio = New System.Windows.Forms.Label()
        Me.LblCantidad = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.TxtModelo = New System.Windows.Forms.TextBox()
        Me.LblModelo = New System.Windows.Forms.Label()
        Me.LblMarca = New System.Windows.Forms.Label()
        Me.LblCategoria = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BCancelar = New System.Windows.Forms.Button()
        Me.BEditar = New System.Windows.Forms.Button()
        Me.BAgregar = New System.Windows.Forms.Button()
        Me.BQuitar = New System.Windows.Forms.Button()
        Me.LModificar = New System.Windows.Forms.Label()
        Me.GTotal = New System.Windows.Forms.GroupBox()
        Me.BVender = New System.Windows.Forms.Button()
        Me.LblHora = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ElectrodomesticosDataSet = New ElectrodomesticosLMJVA.ElectrodomesticosDataSet()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientesTableAdapter = New ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.ClientesTableAdapter()
        Me.TableAdapterManager = New ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.TableAdapterManager()
        Me.FacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FacturaTableAdapter = New ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.FacturaTableAdapter()
        Me.UsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.UsuariosTableAdapter = New ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.UsuariosTableAdapter()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProductosTableAdapter = New ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.ProductosTableAdapter()
        Me.DetalleFacturaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DetalleFacturaTableAdapter = New ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.DetalleFacturaTableAdapter()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.VolverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GVendedor.SuspendLayout()
        Me.lblFac.SuspendLayout()
        CType(Me.VentaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GClientes.SuspendLayout()
        Me.GProductos.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GTotal.SuspendLayout()
        CType(Me.ElectrodomesticosDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetalleFacturaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblFactura
        '
        Me.LblFactura.AutoSize = True
        Me.LblFactura.Location = New System.Drawing.Point(19, 21)
        Me.LblFactura.Name = "LblFactura"
        Me.LblFactura.Size = New System.Drawing.Size(73, 16)
        Me.LblFactura.TabIndex = 0
        Me.LblFactura.Text = "N° Factura:"
        '
        'TxtFactura
        '
        Me.TxtFactura.Enabled = False
        Me.TxtFactura.Location = New System.Drawing.Point(146, 18)
        Me.TxtFactura.Name = "TxtFactura"
        Me.TxtFactura.Size = New System.Drawing.Size(208, 22)
        Me.TxtFactura.TabIndex = 1
        '
        'lblDNIVendedor
        '
        Me.lblDNIVendedor.AutoSize = True
        Me.lblDNIVendedor.Location = New System.Drawing.Point(12, 30)
        Me.lblDNIVendedor.Name = "lblDNIVendedor"
        Me.lblDNIVendedor.Size = New System.Drawing.Size(97, 16)
        Me.lblDNIVendedor.TabIndex = 2
        Me.lblDNIVendedor.Text = "DNI Vendedor:"
        '
        'TxtDNIVendedor
        '
        Me.TxtDNIVendedor.Enabled = False
        Me.TxtDNIVendedor.Location = New System.Drawing.Point(146, 27)
        Me.TxtDNIVendedor.MaxLength = 8
        Me.TxtDNIVendedor.Name = "TxtDNIVendedor"
        Me.TxtDNIVendedor.Size = New System.Drawing.Size(208, 22)
        Me.TxtDNIVendedor.TabIndex = 3
        '
        'LNombreVendedor
        '
        Me.LNombreVendedor.AutoSize = True
        Me.LNombreVendedor.Location = New System.Drawing.Point(409, 27)
        Me.LNombreVendedor.Name = "LNombreVendedor"
        Me.LNombreVendedor.Size = New System.Drawing.Size(123, 16)
        Me.LNombreVendedor.TabIndex = 9
        Me.LNombreVendedor.Text = "Nombre y Apellido:"
        '
        'TxtNombreVendedor
        '
        Me.TxtNombreVendedor.Enabled = False
        Me.TxtNombreVendedor.Location = New System.Drawing.Point(538, 24)
        Me.TxtNombreVendedor.Name = "TxtNombreVendedor"
        Me.TxtNombreVendedor.Size = New System.Drawing.Size(221, 22)
        Me.TxtNombreVendedor.TabIndex = 10
        '
        'LFecha
        '
        Me.LFecha.AutoSize = True
        Me.LFecha.Location = New System.Drawing.Point(409, 21)
        Me.LFecha.Name = "LFecha"
        Me.LFecha.Size = New System.Drawing.Size(106, 16)
        Me.LFecha.TabIndex = 15
        Me.LFecha.Text = "Fecha de Venta:"
        '
        'GVendedor
        '
        Me.GVendedor.BackColor = System.Drawing.Color.DarkGray
        Me.GVendedor.Controls.Add(Me.TxtNombreVendedor)
        Me.GVendedor.Controls.Add(Me.LNombreVendedor)
        Me.GVendedor.Controls.Add(Me.TxtDNIVendedor)
        Me.GVendedor.Controls.Add(Me.lblDNIVendedor)
        Me.GVendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GVendedor.ForeColor = System.Drawing.Color.Black
        Me.GVendedor.Location = New System.Drawing.Point(65, 88)
        Me.GVendedor.Name = "GVendedor"
        Me.GVendedor.Size = New System.Drawing.Size(879, 74)
        Me.GVendedor.TabIndex = 19
        Me.GVendedor.TabStop = False
        Me.GVendedor.Text = "Datos Vendedor"
        '
        'lblFac
        '
        Me.lblFac.BackColor = System.Drawing.Color.DarkGray
        Me.lblFac.Controls.Add(Me.txtFecha)
        Me.lblFac.Controls.Add(Me.LblFactura)
        Me.lblFac.Controls.Add(Me.TxtFactura)
        Me.lblFac.Controls.Add(Me.LFecha)
        Me.lblFac.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFac.ForeColor = System.Drawing.Color.Black
        Me.lblFac.Location = New System.Drawing.Point(65, 36)
        Me.lblFac.Name = "lblFac"
        Me.lblFac.Size = New System.Drawing.Size(716, 46)
        Me.lblFac.TabIndex = 27
        Me.lblFac.TabStop = False
        Me.lblFac.Text = "Factura"
        '
        'txtFecha
        '
        Me.txtFecha.Enabled = False
        Me.txtFecha.Location = New System.Drawing.Point(538, 15)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(167, 22)
        Me.txtFecha.TabIndex = 16
        '
        'VentaDataGridView
        '
        Me.VentaDataGridView.AllowUserToAddRows = False
        Me.VentaDataGridView.AllowUserToDeleteRows = False
        Me.VentaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VentaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodigoArticulo, Me.Categoria, Me.Marca, Me.Modelo, Me.Cantidad, Me.Precio, Me.Subtotal, Me.stock})
        Me.VentaDataGridView.Location = New System.Drawing.Point(64, 413)
        Me.VentaDataGridView.Name = "VentaDataGridView"
        Me.VentaDataGridView.ReadOnly = True
        Me.VentaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.VentaDataGridView.Size = New System.Drawing.Size(733, 198)
        Me.VentaDataGridView.TabIndex = 28
        '
        'CodigoArticulo
        '
        Me.CodigoArticulo.HeaderText = "Codigo"
        Me.CodigoArticulo.Name = "CodigoArticulo"
        Me.CodigoArticulo.ReadOnly = True
        Me.CodigoArticulo.Visible = False
        '
        'Categoria
        '
        Me.Categoria.HeaderText = "Categoría"
        Me.Categoria.Name = "Categoria"
        Me.Categoria.ReadOnly = True
        Me.Categoria.Width = 120
        '
        'Marca
        '
        Me.Marca.HeaderText = "Marca"
        Me.Marca.Name = "Marca"
        Me.Marca.ReadOnly = True
        Me.Marca.Width = 120
        '
        'Modelo
        '
        Me.Modelo.HeaderText = "Modelo"
        Me.Modelo.Name = "Modelo"
        Me.Modelo.ReadOnly = True
        Me.Modelo.Width = 120
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad de Productos"
        Me.Cantidad.Name = "Cantidad"
        Me.Cantidad.ReadOnly = True
        '
        'Precio
        '
        Me.Precio.HeaderText = "Precio $"
        Me.Precio.Name = "Precio"
        Me.Precio.ReadOnly = True
        Me.Precio.Width = 120
        '
        'Subtotal
        '
        Me.Subtotal.HeaderText = "Subtotal $"
        Me.Subtotal.Name = "Subtotal"
        Me.Subtotal.ReadOnly = True
        Me.Subtotal.Width = 110
        '
        'stock
        '
        Me.stock.HeaderText = "stock"
        Me.stock.Name = "stock"
        Me.stock.ReadOnly = True
        Me.stock.Visible = False
        '
        'TxtTotal
        '
        Me.TxtTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTotal.Location = New System.Drawing.Point(564, 14)
        Me.TxtTotal.Name = "TxtTotal"
        Me.TxtTotal.Size = New System.Drawing.Size(157, 38)
        Me.TxtTotal.TabIndex = 29
        '
        'LTotal
        '
        Me.LTotal.AutoSize = True
        Me.LTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LTotal.ForeColor = System.Drawing.Color.Black
        Me.LTotal.Location = New System.Drawing.Point(438, 16)
        Me.LTotal.Name = "LTotal"
        Me.LTotal.Size = New System.Drawing.Size(120, 33)
        Me.LTotal.TabIndex = 30
        Me.LTotal.Text = "Total $:"
        '
        'LblVentas
        '
        Me.LblVentas.AutoSize = True
        Me.LblVentas.BackColor = System.Drawing.Color.Transparent
        Me.LblVentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblVentas.ForeColor = System.Drawing.Color.Black
        Me.LblVentas.Location = New System.Drawing.Point(0, 115)
        Me.LblVentas.Name = "LblVentas"
        Me.LblVentas.Size = New System.Drawing.Size(59, 385)
        Me.LblVentas.TabIndex = 32
        Me.LblVentas.Text = "F" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "A" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "C" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "T" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "U" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "R" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "A"
        '
        'TxtNombreCliente
        '
        Me.TxtNombreCliente.Enabled = False
        Me.TxtNombreCliente.Location = New System.Drawing.Point(146, 69)
        Me.TxtNombreCliente.Name = "TxtNombreCliente"
        Me.TxtNombreCliente.Size = New System.Drawing.Size(208, 22)
        Me.TxtNombreCliente.TabIndex = 12
        '
        'TxtApellidoCiente
        '
        Me.TxtApellidoCiente.Enabled = False
        Me.TxtApellidoCiente.Location = New System.Drawing.Point(146, 109)
        Me.TxtApellidoCiente.Name = "TxtApellidoCiente"
        Me.TxtApellidoCiente.Size = New System.Drawing.Size(208, 22)
        Me.TxtApellidoCiente.TabIndex = 11
        '
        'LClienteNombre
        '
        Me.LClienteNombre.AutoSize = True
        Me.LClienteNombre.Location = New System.Drawing.Point(12, 69)
        Me.LClienteNombre.Name = "LClienteNombre"
        Me.LClienteNombre.Size = New System.Drawing.Size(104, 16)
        Me.LClienteNombre.TabIndex = 8
        Me.LClienteNombre.Text = "Nombre Cliente:"
        '
        'LApellidoCliente
        '
        Me.LApellidoCliente.AutoSize = True
        Me.LApellidoCliente.Location = New System.Drawing.Point(13, 112)
        Me.LApellidoCliente.Name = "LApellidoCliente"
        Me.LApellidoCliente.Size = New System.Drawing.Size(105, 16)
        Me.LApellidoCliente.TabIndex = 7
        Me.LApellidoCliente.Text = "Apellido Cliente:"
        '
        'TxtDNICliente
        '
        Me.TxtDNICliente.Enabled = False
        Me.TxtDNICliente.Location = New System.Drawing.Point(147, 24)
        Me.TxtDNICliente.MaxLength = 8
        Me.TxtDNICliente.Name = "TxtDNICliente"
        Me.TxtDNICliente.Size = New System.Drawing.Size(176, 22)
        Me.TxtDNICliente.TabIndex = 5
        '
        'LblDniCliente
        '
        Me.LblDniCliente.AutoSize = True
        Me.LblDniCliente.Location = New System.Drawing.Point(13, 27)
        Me.LblDniCliente.Name = "LblDniCliente"
        Me.LblDniCliente.Size = New System.Drawing.Size(78, 16)
        Me.LblDniCliente.TabIndex = 4
        Me.LblDniCliente.Text = "DNI Cliente:"
        '
        'GClientes
        '
        Me.GClientes.BackColor = System.Drawing.Color.DarkGray
        Me.GClientes.Controls.Add(Me.TxtID)
        Me.GClientes.Controls.Add(Me.BCliente)
        Me.GClientes.Controls.Add(Me.LblDniCliente)
        Me.GClientes.Controls.Add(Me.TxtDNICliente)
        Me.GClientes.Controls.Add(Me.BBuscarDNI)
        Me.GClientes.Controls.Add(Me.LApellidoCliente)
        Me.GClientes.Controls.Add(Me.LClienteNombre)
        Me.GClientes.Controls.Add(Me.TxtApellidoCiente)
        Me.GClientes.Controls.Add(Me.TxtNombreCliente)
        Me.GClientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GClientes.ForeColor = System.Drawing.Color.Black
        Me.GClientes.Location = New System.Drawing.Point(65, 168)
        Me.GClientes.Name = "GClientes"
        Me.GClientes.Size = New System.Drawing.Size(380, 213)
        Me.GClientes.TabIndex = 26
        Me.GClientes.TabStop = False
        Me.GClientes.Text = "Datos Clientes"
        '
        'TxtID
        '
        Me.TxtID.Enabled = False
        Me.TxtID.Location = New System.Drawing.Point(15, 160)
        Me.TxtID.Name = "TxtID"
        Me.TxtID.Size = New System.Drawing.Size(180, 22)
        Me.TxtID.TabIndex = 28
        '
        'BCliente
        '
        Me.BCliente.ForeColor = System.Drawing.Color.Black
        Me.BCliente.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.ag
        Me.BCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BCliente.Location = New System.Drawing.Point(210, 146)
        Me.BCliente.Name = "BCliente"
        Me.BCliente.Size = New System.Drawing.Size(147, 50)
        Me.BCliente.TabIndex = 26
        Me.BCliente.Text = "Nuevo Cliente"
        Me.BCliente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BCliente.UseVisualStyleBackColor = True
        '
        'BBuscarDNI
        '
        Me.BBuscarDNI.ForeColor = System.Drawing.Color.Black
        Me.BBuscarDNI.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.Buscarr
        Me.BBuscarDNI.Location = New System.Drawing.Point(329, 22)
        Me.BBuscarDNI.Name = "BBuscarDNI"
        Me.BBuscarDNI.Size = New System.Drawing.Size(28, 28)
        Me.BBuscarDNI.TabIndex = 6
        Me.BBuscarDNI.UseVisualStyleBackColor = True
        '
        'GProductos
        '
        Me.GProductos.BackColor = System.Drawing.Color.DarkGray
        Me.GProductos.Controls.Add(Me.txtstock)
        Me.GProductos.Controls.Add(Me.txtCodigo)
        Me.GProductos.Controls.Add(Me.TxtMarca)
        Me.GProductos.Controls.Add(Me.TxtCategoria)
        Me.GProductos.Controls.Add(Me.BBuscarProducto)
        Me.GProductos.Controls.Add(Me.txtPrecio)
        Me.GProductos.Controls.Add(Me.LblPrecio)
        Me.GProductos.Controls.Add(Me.LblCantidad)
        Me.GProductos.Controls.Add(Me.txtCantidad)
        Me.GProductos.Controls.Add(Me.TxtModelo)
        Me.GProductos.Controls.Add(Me.LblModelo)
        Me.GProductos.Controls.Add(Me.LblMarca)
        Me.GProductos.Controls.Add(Me.LblCategoria)
        Me.GProductos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GProductos.ForeColor = System.Drawing.Color.Black
        Me.GProductos.Location = New System.Drawing.Point(456, 168)
        Me.GProductos.Name = "GProductos"
        Me.GProductos.Size = New System.Drawing.Size(487, 213)
        Me.GProductos.TabIndex = 33
        Me.GProductos.TabStop = False
        Me.GProductos.Text = "Buscar Productos"
        '
        'txtstock
        '
        Me.txtstock.Location = New System.Drawing.Point(146, 185)
        Me.txtstock.Name = "txtstock"
        Me.txtstock.Size = New System.Drawing.Size(135, 22)
        Me.txtstock.TabIndex = 30
        '
        'txtCodigo
        '
        Me.txtCodigo.Enabled = False
        Me.txtCodigo.Location = New System.Drawing.Point(20, 185)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(120, 22)
        Me.txtCodigo.TabIndex = 29
        '
        'TxtMarca
        '
        Me.TxtMarca.Enabled = False
        Me.TxtMarca.Location = New System.Drawing.Point(109, 94)
        Me.TxtMarca.Name = "TxtMarca"
        Me.TxtMarca.Size = New System.Drawing.Size(159, 22)
        Me.TxtMarca.TabIndex = 12
        '
        'TxtCategoria
        '
        Me.TxtCategoria.Enabled = False
        Me.TxtCategoria.Location = New System.Drawing.Point(109, 39)
        Me.TxtCategoria.Name = "TxtCategoria"
        Me.TxtCategoria.Size = New System.Drawing.Size(159, 22)
        Me.TxtCategoria.TabIndex = 11
        '
        'BBuscarProducto
        '
        Me.BBuscarProducto.ForeColor = System.Drawing.Color.Black
        Me.BBuscarProducto.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.Buscarr
        Me.BBuscarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BBuscarProducto.Location = New System.Drawing.Point(345, 146)
        Me.BBuscarProducto.Name = "BBuscarProducto"
        Me.BBuscarProducto.Size = New System.Drawing.Size(135, 30)
        Me.BBuscarProducto.TabIndex = 10
        Me.BBuscarProducto.Text = "Buscar Producto"
        Me.BBuscarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BBuscarProducto.UseVisualStyleBackColor = True
        '
        'txtPrecio
        '
        Me.txtPrecio.Enabled = False
        Me.txtPrecio.Location = New System.Drawing.Point(362, 95)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(110, 22)
        Me.txtPrecio.TabIndex = 9
        '
        'LblPrecio
        '
        Me.LblPrecio.AutoSize = True
        Me.LblPrecio.Location = New System.Drawing.Point(291, 98)
        Me.LblPrecio.Name = "LblPrecio"
        Me.LblPrecio.Size = New System.Drawing.Size(50, 16)
        Me.LblPrecio.TabIndex = 8
        Me.LblPrecio.Text = "Precio:"
        '
        'LblCantidad
        '
        Me.LblCantidad.AutoSize = True
        Me.LblCantidad.Location = New System.Drawing.Point(291, 48)
        Me.LblCantidad.Name = "LblCantidad"
        Me.LblCantidad.Size = New System.Drawing.Size(65, 16)
        Me.LblCantidad.TabIndex = 7
        Me.LblCantidad.Text = "Cantidad:"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(362, 45)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(110, 22)
        Me.txtCantidad.TabIndex = 6
        '
        'TxtModelo
        '
        Me.TxtModelo.Enabled = False
        Me.TxtModelo.Location = New System.Drawing.Point(109, 150)
        Me.TxtModelo.Name = "TxtModelo"
        Me.TxtModelo.Size = New System.Drawing.Size(159, 22)
        Me.TxtModelo.TabIndex = 5
        '
        'LblModelo
        '
        Me.LblModelo.AutoSize = True
        Me.LblModelo.Location = New System.Drawing.Point(18, 153)
        Me.LblModelo.Name = "LblModelo"
        Me.LblModelo.Size = New System.Drawing.Size(57, 16)
        Me.LblModelo.TabIndex = 4
        Me.LblModelo.Text = "Modelo:"
        '
        'LblMarca
        '
        Me.LblMarca.AutoSize = True
        Me.LblMarca.Location = New System.Drawing.Point(19, 93)
        Me.LblMarca.Name = "LblMarca"
        Me.LblMarca.Size = New System.Drawing.Size(49, 16)
        Me.LblMarca.TabIndex = 1
        Me.LblMarca.Text = "Marca:"
        '
        'LblCategoria
        '
        Me.LblCategoria.AutoSize = True
        Me.LblCategoria.Location = New System.Drawing.Point(17, 40)
        Me.LblCategoria.Name = "LblCategoria"
        Me.LblCategoria.Size = New System.Drawing.Size(70, 16)
        Me.LblCategoria.TabIndex = 0
        Me.LblCategoria.Text = "Categoría:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox1.Controls.Add(Me.BCancelar)
        Me.GroupBox1.Controls.Add(Me.BEditar)
        Me.GroupBox1.Controls.Add(Me.BAgregar)
        Me.GroupBox1.Controls.Add(Me.BQuitar)
        Me.GroupBox1.Location = New System.Drawing.Point(806, 394)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(142, 286)
        Me.GroupBox1.TabIndex = 35
        Me.GroupBox1.TabStop = False
        '
        'BCancelar
        '
        Me.BCancelar.BackColor = System.Drawing.Color.Transparent
        Me.BCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BCancelar.ForeColor = System.Drawing.Color.Black
        Me.BCancelar.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.Administrador
        Me.BCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BCancelar.Location = New System.Drawing.Point(7, 219)
        Me.BCancelar.Name = "BCancelar"
        Me.BCancelar.Size = New System.Drawing.Size(134, 42)
        Me.BCancelar.TabIndex = 32
        Me.BCancelar.Text = "Cancelar Venta"
        Me.BCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BCancelar.UseVisualStyleBackColor = False
        '
        'BEditar
        '
        Me.BEditar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BEditar.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.editar1
        Me.BEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BEditar.Location = New System.Drawing.Point(8, 156)
        Me.BEditar.Name = "BEditar"
        Me.BEditar.Size = New System.Drawing.Size(128, 42)
        Me.BEditar.TabIndex = 35
        Me.BEditar.Text = "Editar"
        Me.BEditar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BEditar.UseVisualStyleBackColor = True
        '
        'BAgregar
        '
        Me.BAgregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BAgregar.ForeColor = System.Drawing.Color.Black
        Me.BAgregar.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.carrito
        Me.BAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BAgregar.Location = New System.Drawing.Point(6, 19)
        Me.BAgregar.Name = "BAgregar"
        Me.BAgregar.Size = New System.Drawing.Size(128, 51)
        Me.BAgregar.TabIndex = 33
        Me.BAgregar.Text = "Agregar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "al carrito"
        Me.BAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BAgregar.UseVisualStyleBackColor = True
        '
        'BQuitar
        '
        Me.BQuitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BQuitar.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.quitar
        Me.BQuitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BQuitar.Location = New System.Drawing.Point(7, 87)
        Me.BQuitar.Name = "BQuitar"
        Me.BQuitar.Size = New System.Drawing.Size(128, 49)
        Me.BQuitar.TabIndex = 34
        Me.BQuitar.Text = "Quitar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "del carrito"
        Me.BQuitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BQuitar.UseVisualStyleBackColor = True
        '
        'LModificar
        '
        Me.LModificar.AutoSize = True
        Me.LModificar.BackColor = System.Drawing.Color.Transparent
        Me.LModificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LModificar.ForeColor = System.Drawing.Color.Tomato
        Me.LModificar.Location = New System.Drawing.Point(62, 394)
        Me.LModificar.Name = "LModificar"
        Me.LModificar.Size = New System.Drawing.Size(264, 16)
        Me.LModificar.TabIndex = 36
        Me.LModificar.Text = "(Doble click para modificar cantidad)"
        '
        'GTotal
        '
        Me.GTotal.BackColor = System.Drawing.Color.Transparent
        Me.GTotal.Controls.Add(Me.BVender)
        Me.GTotal.Controls.Add(Me.LTotal)
        Me.GTotal.Controls.Add(Me.TxtTotal)
        Me.GTotal.ForeColor = System.Drawing.Color.Transparent
        Me.GTotal.Location = New System.Drawing.Point(65, 613)
        Me.GTotal.Name = "GTotal"
        Me.GTotal.Size = New System.Drawing.Size(732, 67)
        Me.GTotal.TabIndex = 30
        Me.GTotal.TabStop = False
        '
        'BVender
        '
        Me.BVender.BackColor = System.Drawing.Color.White
        Me.BVender.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BVender.ForeColor = System.Drawing.Color.Black
        Me.BVender.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.carrito1
        Me.BVender.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BVender.Location = New System.Drawing.Point(6, 10)
        Me.BVender.Name = "BVender"
        Me.BVender.Size = New System.Drawing.Size(160, 49)
        Me.BVender.TabIndex = 32
        Me.BVender.Text = "Vender"
        Me.BVender.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BVender.UseVisualStyleBackColor = False
        '
        'LblHora
        '
        Me.LblHora.AutoSize = True
        Me.LblHora.BackColor = System.Drawing.Color.Transparent
        Me.LblHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHora.ForeColor = System.Drawing.Color.Black
        Me.LblHora.Location = New System.Drawing.Point(799, 43)
        Me.LblHora.Name = "LblHora"
        Me.LblHora.Size = New System.Drawing.Size(96, 39)
        Me.LblHora.TabIndex = 17
        Me.LblHora.Text = "Hora"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'ElectrodomesticosDataSet
        '
        Me.ElectrodomesticosDataSet.DataSetName = "ElectrodomesticosDataSet"
        Me.ElectrodomesticosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.MarcaTableAdapter = Nothing
        Me.TableAdapterManager.ProvinciaTableAdapter = Nothing
        Me.TableAdapterManager.TipoEmpleadoTableAdapter = Nothing
        Me.TableAdapterManager.TipoUsuarioTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FacturaBindingSource
        '
        Me.FacturaBindingSource.DataMember = "Factura"
        Me.FacturaBindingSource.DataSource = Me.ElectrodomesticosDataSet
        '
        'FacturaTableAdapter
        '
        Me.FacturaTableAdapter.ClearBeforeFill = True
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
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.ElectrodomesticosDataSet
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'DetalleFacturaBindingSource
        '
        Me.DetalleFacturaBindingSource.DataMember = "DetalleFactura"
        Me.DetalleFacturaBindingSource.DataSource = Me.ElectrodomesticosDataSet
        '
        'DetalleFacturaTableAdapter
        '
        Me.DetalleFacturaTableAdapter.ClearBeforeFill = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VolverToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(948, 26)
        Me.MenuStrip1.TabIndex = 37
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'VolverToolStripMenuItem
        '
        Me.VolverToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VolverToolStripMenuItem.Image = Global.ElectrodomesticosLMJVA.My.Resources.Resources.flecha_hacia_la_izquierda
        Me.VolverToolStripMenuItem.Name = "VolverToolStripMenuItem"
        Me.VolverToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.VolverToolStripMenuItem.Text = "Volver al menú del Vendedor"
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(948, 701)
        Me.ControlBox = False
        Me.Controls.Add(Me.LblHora)
        Me.Controls.Add(Me.LModificar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GProductos)
        Me.Controls.Add(Me.LblVentas)
        Me.Controls.Add(Me.GTotal)
        Me.Controls.Add(Me.VentaDataGridView)
        Me.Controls.Add(Me.lblFac)
        Me.Controls.Add(Me.GClientes)
        Me.Controls.Add(Me.GVendedor)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Ventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ventas"
        Me.GVendedor.ResumeLayout(False)
        Me.GVendedor.PerformLayout()
        Me.lblFac.ResumeLayout(False)
        Me.lblFac.PerformLayout()
        CType(Me.VentaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GClientes.ResumeLayout(False)
        Me.GClientes.PerformLayout()
        Me.GProductos.ResumeLayout(False)
        Me.GProductos.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GTotal.ResumeLayout(False)
        Me.GTotal.PerformLayout()
        CType(Me.ElectrodomesticosDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetalleFacturaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LNombreVendedor As System.Windows.Forms.Label
    Friend WithEvents TxtDNIVendedor As System.Windows.Forms.TextBox
    Friend WithEvents lblDNIVendedor As System.Windows.Forms.Label
    Friend WithEvents TxtFactura As System.Windows.Forms.TextBox
    Friend WithEvents LblFactura As System.Windows.Forms.Label
    Friend WithEvents TxtNombreVendedor As System.Windows.Forms.TextBox
    Friend WithEvents LFecha As System.Windows.Forms.Label
    Friend WithEvents GVendedor As System.Windows.Forms.GroupBox
    Friend WithEvents lblFac As System.Windows.Forms.GroupBox
    Friend WithEvents VentaDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents TxtTotal As System.Windows.Forms.TextBox
    Friend WithEvents LTotal As System.Windows.Forms.Label
    Friend WithEvents LblVentas As System.Windows.Forms.Label
    Friend WithEvents TxtNombreCliente As System.Windows.Forms.TextBox
    Friend WithEvents TxtApellidoCiente As System.Windows.Forms.TextBox
    Friend WithEvents LClienteNombre As System.Windows.Forms.Label
    Friend WithEvents LApellidoCliente As System.Windows.Forms.Label
    Friend WithEvents BBuscarDNI As System.Windows.Forms.Button
    Friend WithEvents TxtDNICliente As System.Windows.Forms.TextBox
    Friend WithEvents LblDniCliente As System.Windows.Forms.Label
    Friend WithEvents BCliente As System.Windows.Forms.Button
    Friend WithEvents GClientes As System.Windows.Forms.GroupBox
    Friend WithEvents ElectrodomesticosDataSet As ElectrodomesticosLMJVA.ElectrodomesticosDataSet
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents TableAdapterManager As ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TxtID As System.Windows.Forms.TextBox
    Friend WithEvents GProductos As System.Windows.Forms.GroupBox
    Friend WithEvents LblMarca As System.Windows.Forms.Label
    Friend WithEvents LblCategoria As System.Windows.Forms.Label
    Friend WithEvents FacturaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FacturaTableAdapter As ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.FacturaTableAdapter
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents UsuariosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UsuariosTableAdapter As ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.UsuariosTableAdapter
    Friend WithEvents TxtModelo As System.Windows.Forms.TextBox
    Friend WithEvents LblModelo As System.Windows.Forms.Label
    Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents LblPrecio As System.Windows.Forms.Label
    Friend WithEvents LblCantidad As System.Windows.Forms.Label
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents BAgregar As System.Windows.Forms.Button
    Friend WithEvents BQuitar As System.Windows.Forms.Button
    Friend WithEvents BEditar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BBuscarProducto As System.Windows.Forms.Button
    Friend WithEvents TxtMarca As System.Windows.Forms.TextBox
    Friend WithEvents TxtCategoria As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents ProductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductosTableAdapter As ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.ProductosTableAdapter
    Friend WithEvents txtstock As System.Windows.Forms.TextBox
    Friend WithEvents DetalleFacturaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DetalleFacturaTableAdapter As ElectrodomesticosLMJVA.ElectrodomesticosDataSetTableAdapters.DetalleFacturaTableAdapter
    Friend WithEvents CodigoArticulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Categoria As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Marca As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Modelo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Subtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stock As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LModificar As System.Windows.Forms.Label
    Friend WithEvents GTotal As System.Windows.Forms.GroupBox
    Friend WithEvents LblHora As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BVender As System.Windows.Forms.Button
    Friend WithEvents BCancelar As System.Windows.Forms.Button
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents VolverToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
