Public Class ABMProductos
    Dim seleccion As Integer
    Dim ask As MsgBoxResult
    Dim editar As Boolean = False

    Public Sub desactivarBotones()
        'desactiva botones.
        BActivar.Enabled = False

        BModificar.Enabled = False

    End Sub

    Public Sub limpiarCampos()
        'limpia los campos.
        TxtModelo.Clear()
        TxtDescripcion.Clear()
        TxtStock.Clear()
        TxtPrecio.Clear()
    End Sub

    Private Sub TxtStock_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtStock.KeyPress
        'validacion para que permita ingresar solo numeros.
        validar2.ValidarSoloNumeros(e)
    End Sub


    Private Sub TxtPrecio_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtPrecio.KeyPress
        'validacion para decimales.
        validar1.validarSoloDecimales(e, TxtPrecio)
    End Sub

    Private Sub TxtPrecio_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtPrecio.TextChanged

    End Sub

    Private Sub ABMProductos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ElectrodomesticosDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.ElectrodomesticosDataSet.Productos)
        'TODO: esta línea de código carga datos en la tabla 'ElectrodomesticosDataSet.Marca' Puede moverla o quitarla según sea necesario.
        Me.MarcaTableAdapter.marcasActivas(Me.ElectrodomesticosDataSet.Marca, True)
        'TODO: esta línea de código carga datos en la tabla 'ElectrodomesticosDataSet.Categorias' Puede moverla o quitarla según sea necesario.
        'agrega solo las cateogiras activas
        Me.CategoriasTableAdapter.categoriaActiva(Me.ElectrodomesticosDataSet.Categorias, True)
        'permite que el datagridview no tenga ninguna fila seleccionada.
        Me.ProductosDataGridView.CurrentRow.Selected = False
        
        desactivarBotones()
        BEliminar.Enabled = False
        'recorre el datagridview y cambia de color la fila dependiendo del estado de la misma.
        For Each Row As DataGridViewRow In ProductosDataGridView.Rows

            If Row.Cells(7).Value = "false" Then
                Row.DefaultCellStyle.BackColor = Color.YellowGreen

            End If

        Next
    End Sub


    Private Sub BAgregar_Click(sender As System.Object, e As System.EventArgs) Handles BAgregar.Click
        'guarda en variables la seleccion que se realizo.
        Dim categoria = CBcategoria.SelectedValue
        Dim marca = CBmarca.SelectedValue
        'guarda en variable el contenido del textbox.
        Dim modelo = TxtModelo.Text
        'verifica que ningun campo se encuentre vacio, antes de agregar un producto.
        If TxtModelo.TextLength = 0 Or TxtDescripcion.TextLength = 0 Or TxtStock.TextLength = 0 Or TxtPrecio.TextLength = 0 Then
            MsgBox(" Debe completar todos los campos ", MsgBoxStyle.Critical, "ERROR: campos vacios")
            'verifica que el producto a agregar ya no se encuentre registrado.
        ElseIf Me.ProductosTableAdapter.buscarPorModelo(Me.ElectrodomesticosDataSet.Productos, modelo) Then
            MsgBox("Ya existe un producto con ese modelo", MsgBoxStyle.Critical, "ERROR: modelo existente")
            'actualiza el datagridview.
            Me.ProductosTableAdapter.Fill(Me.ElectrodomesticosDataSet.Productos)
            'permite que el datagridview no tenga ninguna fila seleccionada.
            Me.ProductosDataGridView.CurrentRow.Selected = False
        Else
            'pide confirmacion para agregar el nuevo producto.
            ask = MsgBox("Se agregará el producto : " & modelo & " confirmar para seguir.", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Question, " Agregar Producto")
            'si la respuesta es si, agrega el nuevo producto.
            If MsgBoxResult.Yes = ask Then
                'agrega el nuevo producto.
                Me.ProductosTableAdapter.agregarProducto(categoria, marca, modelo, TxtDescripcion.Text, TxtStock.Text, CDec(TxtPrecio.Text), True)
                'actualiza el datagridview.
                Me.ProductosTableAdapter.Fill(Me.ElectrodomesticosDataSet.Productos)

                MsgBox("Producto " & modelo & " agregado correctamente", MsgBoxStyle.Information, "Exito")
                'recorre el datagridview para dejar seleccionada la fila que recien se agrego.
                For Each Row As DataGridViewRow In ProductosDataGridView.Rows

                    If Row.Cells(3).Value = modelo Then

                        Row.Selected = True
                    End If


                Next
                limpiarCampos()
                'permite que el datagridview no tenga ninguna fila seleccionada.
                Me.ProductosDataGridView.CurrentRow.Selected = False
            End If


        End If
        'recorre el datagridview y cambia el color de la fila dependiendo del estado de la misma.
        For Each Row As DataGridViewRow In ProductosDataGridView.Rows

            If Row.Cells(7).Value = "false" Then
                Row.DefaultCellStyle.BackColor = Color.YellowGreen

            End If

        Next
    End Sub

    Private Sub BEliminar_Click(sender As System.Object, e As System.EventArgs) Handles BEliminar.Click
        'guarda en una variable el contenido de la seleccion que se realizo en el datagridview.
        Dim modelo = Me.ProductosDataGridView.CurrentRow.Cells.Item(3).Value
        'pide confirmacion para realizar la baja del producto.
        ask = MsgBox("Seguro que desea dar de baja el producto: " & modelo, MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Question, "Confirmar Baja")
        'si la respuesta es si, se realiza la baja.
        If MsgBoxResult.Yes = ask Then
            'realiza la baja.
            Me.ProductosTableAdapter.bajaProducto(False, modelo)
            'actualiza el datagridview.
            Me.ProductosTableAdapter.Fill(Me.ElectrodomesticosDataSet.Productos)

            MsgBox("Producto dado de baja correctamente", MsgBoxStyle.Exclamation, "Exito")
            'permite que el datagridview no tenga ninguna fila seleccionada.
            Me.ProductosDataGridView.CurrentRow.Selected = False
        End If
        'recorre el datagridview y cambia el color de la fila dependiendo del estado de la misma.
        For Each Row As DataGridViewRow In ProductosDataGridView.Rows

            If Row.Cells(7).Value = "false" Then
                Row.DefaultCellStyle.BackColor = Color.YellowGreen

            End If

        Next
    End Sub

   

    Private Sub BActivar_Click(sender As System.Object, e As System.EventArgs) Handles BActivar.Click
        'guarda en una variable el contenido de la seleccion que se realizo en el datagridview.
        Dim modelo = Me.ProductosDataGridView.CurrentRow.Cells.Item(3).Value
        'pide confirmacion para dar de alta al producto.
        ask = MsgBox("Seguro que desea dar de alta el producto: " & modelo, MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Question, "Confirmar Alta")
        'si la respuesta es si, realiza el alta.
        If MsgBoxResult.Yes = ask Then
            'realiza el alta.
            Me.ProductosTableAdapter.bajaProducto(True, modelo)
            'actualiza el datagridview.
            Me.ProductosTableAdapter.Fill(Me.ElectrodomesticosDataSet.Productos)

            MsgBox("Producto dado de alta correctamente", MsgBoxStyle.Exclamation, "Exito")
            'permite que el datagridview no tenga ninguna fila seleccionada.
            Me.ProductosDataGridView.CurrentRow.Selected = False
        End If
        'recorre el datagridview y cambia el color de la fila dependiendo del estado de la misma.
        For Each Row As DataGridViewRow In ProductosDataGridView.Rows

            If Row.Cells(7).Value = "false" Then
                Row.DefaultCellStyle.BackColor = Color.YellowGreen

            End If

        Next
    End Sub


    Private Sub BBuscarModelo_Click(sender As System.Object, e As System.EventArgs) Handles BBuscarModelo.Click
        'guarda en una variable el contenido de la seleccion que se realizo.
        Dim categoria = CBbuscarCategoria.SelectedValue
        'verifica que haya productos para la categoria elegida.
        If Me.ProductosTableAdapter.buscarCategoria(Me.ElectrodomesticosDataSet.Productos, categoria) = False Then
            MsgBox("No hay productos para esa categoría", MsgBoxStyle.Critical, "Categoría Vacia")
            'actualiza el datagridview.
            Me.ProductosTableAdapter.Fill(Me.ElectrodomesticosDataSet.Productos)

        End If
        'recorre el datagridview y cambia el color de la fila dependiendo del estado de la misma.
        For Each Row As DataGridViewRow In ProductosDataGridView.Rows

            If Row.Cells(7).Value = "false" Then
                Row.DefaultCellStyle.BackColor = Color.YellowGreen

            End If

        Next
    End Sub

    Private Sub TxtGeneral_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtGeneral.KeyPress
        'validacion para que ingrese solo numeros y letras.
        validar2.validarNumerosYLetras(e)
    End Sub

    Private Sub TApellidoEmpleado_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtGeneral.TextChanged
        'permite realizar una busqueda interactiva de producto por modelo.
        Me.ProductosTableAdapter.buscarModelo(Me.ElectrodomesticosDataSet.Productos, TxtGeneral.Text)
        'recorre el datagridview y cambia el color de la fila dependiendo del estado de la misma.
        For Each Row As DataGridViewRow In ProductosDataGridView.Rows

            If Row.Cells(7).Value = "false" Then
                Row.DefaultCellStyle.BackColor = Color.YellowGreen

            End If

        Next
    End Sub

    Private Sub BVolver_Click_1(sender As System.Object, e As System.EventArgs) Handles BVolver.Click
        Dim formAdministrador As New MenuAdministrador
        Me.Hide()
        'abre el formulario del menuAdministrador.
        formAdministrador.Show()
        'cierra el formulario actual.
        Me.Close()
    End Sub

    Private Sub ProductosDataGridView_CellClick1(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProductosDataGridView.CellClick
        'activa/desactiva botones dependiendo del estado de la fila.
        If Me.ProductosDataGridView.CurrentRow.Cells.Item(7).Value = True Then
            BActivar.Enabled = False
            BEliminar.Enabled = True
        Else
            BActivar.Enabled = True
            BEliminar.Enabled = False
        End If
    End Sub

    Private Sub ProductosDataGridView_DoubleClick(sender As Object, e As System.EventArgs) Handles ProductosDataGridView.DoubleClick
        'guarda en una variable el index del datagridview.
        seleccion = ProductosDataGridView.CurrentRow.Index
        Me.editar = True
        BModificar.Enabled = True
        BAgregar.Enabled = False

        BEliminar.Enabled = False
        'asigna a los textbox el contenido del datagridview de acuerdo a la seleccion que se realizo.
        CBcategoria.Text = Me.ProductosDataGridView.CurrentRow.Cells.Item(1).Value
        CBmarca.Text = Me.ProductosDataGridView.CurrentRow.Cells.Item(2).Value
        TxtModelo.Text = Me.ProductosDataGridView.CurrentRow.Cells.Item(3).Value
        TxtDescripcion.Text = Me.ProductosDataGridView.CurrentRow.Cells.Item(4).Value
        TxtStock.Text = Me.ProductosDataGridView.CurrentRow.Cells.Item(5).Value
        TxtPrecio.Text = Me.ProductosDataGridView.CurrentRow.Cells.Item(6).Value
    End Sub

    Private Sub BModificar_Click(sender As System.Object, e As System.EventArgs) Handles BModificar.Click
        'verifica que ningun campo se encuentre vacio.
        If (TxtModelo.TextLength = 0) Or (TxtDescripcion.TextLength = 0) Or (TxtStock.TextLength = 0) Or (TxtPrecio.TextLength = 0) Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.Critical, "Campos vacios")
        Else
            'pide confirmacion para realizar la modificacion.
            ask = MsgBox("Se modificará el producto: " & TxtModelo.Text & " confirme si está seguro de hacerlo", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Question, "Confirmar Modificación")
            'si la respuesta es si, realiza la modificacion.
            If MsgBoxResult.Yes = ask Then
                'guarda en variables la seleccion que se realizo.
                Dim categoria = CBcategoria.SelectedValue
                Dim marca = CBmarca.SelectedValue
                'guarda en variables el contenido del datagridview dependiendo de la seleccion que se realizo.
                Dim modelo = Me.ProductosDataGridView.CurrentRow.Cells.Item(3).Value
                Dim estado = Me.ProductosDataGridView.CurrentRow.Cells.Item(7).Value
                'realiza la modificacion
                Me.ProductosTableAdapter.editarProductos(categoria, marca, TxtModelo.Text, TxtDescripcion.Text, TxtStock.Text, TxtPrecio.Text, estado, modelo)
                'actualiza el datagridview.
                Me.ProductosTableAdapter.Fill(Me.ElectrodomesticosDataSet.Productos)

                MsgBox("Modificacion exitosa", MsgBoxStyle.Information, "exito")
                limpiarCampos()
                'permite que el datagridview no tenga ninguna fila seleccionada.
                Me.ProductosDataGridView.CurrentRow.Selected = False
                'mantiene seleccionada la fila que se modifico.
                Me.ProductosDataGridView.Rows(seleccion).Selected = True
                BModificar.Enabled = False

                BAgregar.Enabled = True

                BEliminar.Enabled = True
            End If
        End If
        'recorre el datagridview y cambia el color de la fila dependiendo del estado de la misma.
        For Each Row As DataGridViewRow In ProductosDataGridView.Rows

            If Row.Cells(7).Value = "false" Then
                Row.DefaultCellStyle.BackColor = Color.YellowGreen

            End If

        Next
    End Sub

    Private Sub TxtModelo_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtModelo.KeyPress
        'validacion para que ingrese solo numeros y letras.
        validar2.validarNumerosYLetras(e)
    End Sub

    Private Sub TxtCodigo_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodigo.KeyPress
        'validacion para que ingrese solo numeros.
        validar2.ValidarSoloNumeros(e)

        'permite buscar un codigo presionando la tecla enter
        If e.KeyChar = Chr(13) Then
            'verifica que el campo codigo no se encuentre vacio.
            If TxtCodigo.TextLength = 0 Then
                MsgBox("Campos Vacios", MsgBoxStyle.Critical, "Campos Vacios")
            Else
                'guarda en una variabe el contenido del textbox.
                Dim codigo = TxtCodigo.Text
                'verifica que exista un producto con ese codigo.
                If Me.ProductosTableAdapter.buscarCodigo(Me.ElectrodomesticosDataSet.Productos, codigo) = False Then
                    MsgBox("No hay un producto con ese código", MsgBoxStyle.Critical, "Producto inexistente")
                    'actualiza el datagridview.
                    Me.ProductosTableAdapter.Fill(Me.ElectrodomesticosDataSet.Productos)

                End If
                'limpia el textbox.
                TxtCodigo.Clear()

                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TxtCodigo_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtCodigo.TextChanged

    End Sub

    Private Sub BbuscarCodigo_Click(sender As System.Object, e As System.EventArgs)
        If (TxtCodigo.TextLength = 0) Then
            MsgBox("No ha ingresado ningun codigo a buscar", MsgBoxStyle.Critical, "Campo Vacio")
        ElseIf Me.ProductosTableAdapter.buscarCodigo(Me.ElectrodomesticosDataSet.Productos, TxtCodigo.Text) = False Then
            MsgBox("El codigo: " & TxtCodigo.Text & " no existe", MsgBoxStyle.Critical, "Codigo inexistente")

            Me.ProductosTableAdapter.Fill(Me.ElectrodomesticosDataSet.Productos)

            TxtCodigo.Clear()
        End If
        For Each Row As DataGridViewRow In ProductosDataGridView.Rows

            If Row.Cells(7).Value = "false" Then
                Row.DefaultCellStyle.BackColor = Color.YellowGreen

            End If

        Next
    End Sub

    Private Sub CBbuscarCategoria_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CBbuscarCategoria.SelectedIndexChanged

    End Sub

    Private Sub ProductosDataGridView_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProductosDataGridView.CellContentClick

    End Sub

    Private Sub lblCodigo_Click(sender As System.Object, e As System.EventArgs) Handles lblCodigo.Click

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.ProductosTableAdapter.Fill(Me.ElectrodomesticosDataSet.Productos)
        Me.ProductosDataGridView.CurrentRow.Selected = False
        For Each Row As DataGridViewRow In ProductosDataGridView.Rows

            If Row.Cells(7).Value = "false" Then
                Row.DefaultCellStyle.BackColor = Color.YellowGreen

            End If

        Next
    End Sub
End Class