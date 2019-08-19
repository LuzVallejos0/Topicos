Public Class listarProductos
    Private Sub ConsultarProducto_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ElectrodomesticosDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.ProductosActivos(Me.ElectrodomesticosDataSet.Productos, True)
        'TODO: esta línea de código carga datos en la tabla 'ElectrodomesticosDataSet.Marca' Puede moverla o quitarla según sea necesario.
        Me.MarcaTableAdapter.marcasActivas(Me.ElectrodomesticosDataSet.Marca, True)
        'TODO: esta línea de código carga datos en la tabla 'ElectrodomesticosDataSet.Categorias' Puede moverla o quitarla según sea necesario.
        Me.CategoriasTableAdapter.categoriaActiva(Me.ElectrodomesticosDataSet.Categorias, True)

    End Sub


    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Close()
    End Sub



    Private Sub TxtGeneral_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtModelo.TextChanged
        'busqueda interactiva de productos por modelo.
        Me.ProductosTableAdapter.buscarModeloActivo(Me.ElectrodomesticosDataSet.Productos, TxtModelo.Text, True)
    End Sub

    Private Sub BBuscarModelo_Click(sender As System.Object, e As System.EventArgs)

    End Sub


    Private Sub ConsultaDataGridView_DoubleClick(sender As Object, e As System.EventArgs) Handles ConsultaDataGridView.DoubleClick
        'asigna a los textbox del formulario de ventas, el contenido del datagridview de acuerdo a la seleccion que se realizo.
        Ventas.txtCodigo.Text = Me.ConsultaDataGridView.CurrentRow.Cells.Item(0).Value
        Ventas.TxtCategoria.Text = Me.ConsultaDataGridView.CurrentRow.Cells.Item(1).Value
        Ventas.TxtMarca.Text = Me.ConsultaDataGridView.CurrentRow.Cells.Item(2).Value
        Ventas.TxtModelo.Text = Me.ConsultaDataGridView.CurrentRow.Cells.Item(3).Value
        Ventas.txtCantidad.Text = Me.ConsultaDataGridView.CurrentRow.Cells.Item(5).Value
        Ventas.txtPrecio.Text = Me.ConsultaDataGridView.CurrentRow.Cells.Item(6).Value

        Ventas.txtstock.Text = Me.ConsultaDataGridView.CurrentRow.Cells.Item(5).Value
        'habilita el boton agregar del formulario de ventas
        Ventas.BAgregar.Enabled = True
        'desabilita el boton editar del formulario de ventas.
        Ventas.BEditar.Enabled = False
        'cierra el formulario actual.
        Me.Close()
    End Sub

    Private Sub lblCodigo_Click(sender As System.Object, e As System.EventArgs) Handles lblCodigo.Click

    End Sub

    Private Sub TxtCodigo_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodigo.KeyPress
        'validacion para que ingrese solo numeros.
        validar2.ValidarSoloNumeros(e)
        'permite buscar codigo del producto presionando la tecla enter.
        If e.KeyChar = Chr(13) Then
            'verifica que el campo no se encuentre vacio
            If TxtCodigo.TextLength = 0 Then
                MsgBox("Campos Vacios", MsgBoxStyle.Critical, "Campos Vacios")
            Else
                'guarda en una variable el contenido del textbox.
                Dim codigo = TxtCodigo.Text
                'verifica si el codigo ingresado existe, caso contrario muestra un mensaje de error.
                If Me.ProductosTableAdapter.buscarCodigo(Me.ElectrodomesticosDataSet.Productos, codigo) = False Then
                    MsgBox("No hay un producto con ese código", MsgBoxStyle.Critical, "Producto inexistente")

                    Me.ProductosTableAdapter.Fill(Me.ElectrodomesticosDataSet.Productos)

                End If
                'limpia el textbox.
                TxtCodigo.Clear()

                e.Handled = True
            End If
        End If
    End Sub

   
    Private Sub ConsultaDataGridView_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ConsultaDataGridView.CellContentClick

    End Sub

    Private Sub CBbuscarCategoria_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CBbuscarCategoria.SelectedIndexChanged
        
    End Sub

    Private Sub BCat_Click(sender As System.Object, e As System.EventArgs) Handles BCat.Click
        'guarda en una variable la categoria seleccionada.
        Dim categoria = CBbuscarCategoria.SelectedValue

        'si la categoria seleccionada no tiene ningun producto, muestra un mensaje
        If Me.ProductosTableAdapter.buscarCategoria(Me.ElectrodomesticosDataSet.Productos, categoria) = False Then
            MsgBox("No hay productos para esa categoría. ", MsgBoxStyle.Critical, "ERROR")
            'actualiza el datagridview.
            Me.ProductosTableAdapter.productosActivos(Me.ElectrodomesticosDataSet.Productos, True)
            'verifica que la categoria seleccionada se encuentre activa, muestra un mensaje si no esta activa.
        ElseIf Me.ProductosTableAdapter.buscarCategoriaActiva(Me.ElectrodomesticosDataSet.Productos, categoria, True) = False Then
            MsgBox("No existe productos activos para esa categoría . ", MsgBoxStyle.Critical, "ERROR")
            'actualiza el datagridview.
            Me.ProductosTableAdapter.productosActivos(Me.ElectrodomesticosDataSet.Productos, True)

        End If
    End Sub

    Private Sub TxtCodigo_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtCodigo.TextChanged

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.ProductosTableAdapter.productosActivos(Me.ElectrodomesticosDataSet.Productos, True)
        Me.ConsultaDataGridView.CurrentRow.Selected = False
    End Sub
End Class