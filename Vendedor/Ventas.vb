Public Class Ventas
    Dim fecha As Date = Date.Today
    Dim totalGeneral As Decimal
    Dim subTotal1 As Decimal
    Dim ask As MsgBoxResult

    Private Function ArticuloEnlistado(ByVal p_codigo As String) As Boolean

        'verifica si un articulo ya se encuentra en el datagridview, sabiendo su codigo
        Dim Todas = Me.VentaDataGridView.Rows

        For Each row As DataGridViewRow In Todas

            If (row.Cells(0).Value) = p_codigo Then
                Return True
            End If
        Next
        Return False
    End Function

    Public Sub desactivarBotones()
        'desabilita los botones
        BAgregar.Enabled = False
        BQuitar.Enabled = False
        BEditar.Enabled = False
        BVender.Enabled = False
        BCancelar.Enabled = False
    End Sub

    Public Sub limpiarCampos()
        'limpia los textbox.
        TxtCategoria.Clear()
        TxtMarca.Clear()
        TxtModelo.Clear()
        txtCantidad.Clear()
        txtPrecio.Clear()
        txtstock.Clear()

    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles BBuscarDNI.Click
        'abre el formulario de listarClientes.
        listarClientes.ShowDialog()
    End Sub

    Private Sub TxtDNICliente_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDNICliente.KeyPress
        'validacion para que ingrese solo numeros.
        validar2.ValidarSoloNumeros(e)
    End Sub


    Private Sub VolverAConsultaProductosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)
        Me.Hide()
        'abre el formulario de listarProductos.
        listarProductos.ShowDialog()
    End Sub

    Private Sub Ventas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ElectrodomesticosDataSet.DetalleFactura' Puede moverla o quitarla según sea necesario.
        Me.DetalleFacturaTableAdapter.Fill(Me.ElectrodomesticosDataSet.DetalleFactura)
        'TODO: esta línea de código carga datos en la tabla 'ElectrodomesticosDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.ElectrodomesticosDataSet.Productos)

        'TODO: esta línea de código carga datos en la tabla 'ElectrodomesticosDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.ElectrodomesticosDataSet.Usuarios)
        'TODO: esta línea de código carga datos en la tabla 'ElectrodomesticosDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.ElectrodomesticosDataSet.Usuarios)
        'TODO: esta línea de código carga datos en la tabla 'ElectrodomesticosDataSet.Factura' Puede moverla o quitarla según sea necesario.
        Me.FacturaTableAdapter.Fill(Me.ElectrodomesticosDataSet.Factura)
        'TODO: esta línea de código carga datos en la tabla 'ElectrodomesticosDataSet.Factura' Puede moverla o quitarla según sea necesario.

        Me.ClientesTableAdapter.Fill(Me.ElectrodomesticosDataSet.Clientes)
        desactivarBotones()

        'asigna al textbox la variable fecha creada globalmente.
        txtFecha.Text = fecha
        'deja oculto el ID, codigo y el stock.
        TxtID.Visible = False
        txtCodigo.Visible = False
        txtstock.Visible = False
        TxtTotal.ReadOnly = True
        'asigna al textbox el valor que contiene la variable DatosEmpleado.Mdni declarada en el modulo DatosEmpleado
        TxtDNIVendedor.Text = DatosEmpleado.Mdni
        'asigna al textbox el valor que contiene la variable DatosEmpleado.nombre y tambien la variable DatosEmpleado.Mapellido  declarada en el modulo DatosEmpleado
        TxtNombreVendedor.Text = DatosEmpleado.MNombre + " " + DatosEmpleado.Mapellido

        'incrementa el valor que contiene la factura en 1.
        TxtFactura.Text = Me.FacturaTableAdapter.mayor() + 1

        'inicializa la variable totalGeneral.
        totalGeneral = 0
    End Sub

    Private Sub BCliente_Click(sender As System.Object, e As System.EventArgs) Handles BCliente.Click
        'abre el formulario nuevoCliente
        NuevoCliente.ShowDialog()
    End Sub


    Private Sub TxtNombreVendedor_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNombreVendedor.KeyPress
        'validacion para que coloque en mayuscula la primer letra de cada palabra.
        TxtNombreVendedor.Text = validar1.PrimeraLetraEnMayuscula(TxtNombreVendedor.Text)
    End Sub


    Private Sub BVolver_Click(sender As System.Object, e As System.EventArgs)
        
    End Sub


    Private Sub BBuscarProducto_Click(sender As System.Object, e As System.EventArgs) Handles BBuscarProducto.Click
        'abre el formulario ListarProductos.
        listarProductos.ShowDialog()
    End Sub

    Private Sub actualizarTotal(ByVal subtotal As Decimal)
        'si el total general no se encuentra vacio, se le asigna el contenido del textbox txtTotal
        If Not (TxtTotal.Text = "") Then
            totalGeneral = CDec(TxtTotal.Text)
        End If

        'actualiza el tota general de ventas
        totalGeneral = CDec(totalGeneral + subtotal)
        TxtTotal.Text = totalGeneral
    End Sub

    Private Sub BAgregar_Click(sender As System.Object, e As System.EventArgs) Handles BAgregar.Click
        'guarda en una variable el contenido del textbox.
        Dim nombre = TxtModelo.Text

        'verifica si el articulo se encuentra en el detalle de ventas y si los textbox no se encuentran vacios.
        If ArticuloEnlistado(txtCodigo.Text) And txtCantidad.TextLength <> 0 And TxtCategoria.TextLength <> 0 And TxtMarca.TextLength <> 0 And TxtModelo.TextLength <> 0 And txtstock.TextLength <> 0 And txtPrecio.TextLength <> 0 And txtCodigo.TextLength <> 0 Then

            'guarda en una variable el contenido del textbox.
            Dim buscar As Integer = txtCodigo.Text
            'recorre el datagridview.
            For Each fila As DataGridViewRow In VentaDataGridView.Rows
                'verifica si el codigo ingresado se corresponde con alguno de los que se encuentra en el detalle de ventas.
                If fila.Cells(0).Value = buscar Then
                    'guarda en una variable la suma de la cantidad que ya tenia el producto mas la nueva cantidad que se quiere agregar.
                    Dim total = fila.Cells(4).Value + CInt(txtCantidad.Text)
                    'verifica si la cantidad que esta en el detalle de ventas es igual al stock, e informa.
                    If fila.Cells(4).Value = CInt(txtstock.Text) Then
                        MsgBox("Ya ha alcanzado el stock suficiente: " & txtstock.Text & ", por favor eliga otro producto. ", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Exclamation, "ERROR: stock insuficiente")
                        limpiarCampos()
                        BAgregar.Enabled = False
                        'verifica si el total de la suma de las cantidad es mayor al stock, e informa.
                    ElseIf total > txtstock.Text Then
                        MsgBox("Agregó más que el stock disponible: " & txtstock.Text & ", por favor modifique la cantidad. ", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Exclamation, "ERROR: stock insuficiente")
                        txtCantidad.Clear()
                    Else
                        'guarda en una variable el subtotal
                        Dim actualizar = fila.Cells(6).Value
                        'descuenta el subtotal del total general.
                        actualizarTotal(-actualizar)
                        'asigna a la celda cantidad el nuevo valor.
                        fila.Cells(4).Value = fila.Cells(4).Value + CInt(txtCantidad.Text)
                        'guarda en una variable el nuevo subtotal
                        Dim subtotal = CInt(fila.Cells(4).Value) * CDec(fila.Cells(5).Value)
                        'asigna a la celda subtotal el nuevo subtotal para esa fila.
                        fila.Cells(6).Value = subtotal
                        'actualiza el total general, con el nuevo subtotal.
                        actualizarTotal(subtotal)
                        limpiarCampos()
                        BAgregar.Enabled = False
                    End If

                End If
            Next
            'verifica si la cantidad es distinta de cero.
        ElseIf txtCantidad.TextLength <> 0 Then
            'guarda en variables el contenido de los textbox y los convierte en entero.
            Dim Stock = CInt(txtstock.Text)
            Dim cantidad = CInt(txtCantidad.Text)
            'verifica si la cantidad es mayor que el stock.
            If cantidad > Stock Then

                'mensaje de error, agregó más cantidad que el stock disponible

                MsgBox("Agregó más que el stock disponible: " & Stock & ", por favor modifique la cantidad ", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Exclamation, "ERROR")

                'verifica si la cantidad es menor o igual a 0
            ElseIf cantidad <= 0 Then


                'mensaje de error, cantidad incorrecta
                ask = MsgBox("Lo siento, es incorrecto la cantidad ingresada", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Exclamation, "ERROR")

            Else

                'calcula el subtotal (cantidad * precio)
                subTotal1 = cantidad * CDec(txtPrecio.Text)
                'actualiza el subtotal.
                actualizarTotal(subTotal1)
                'agrega al detalle de ventas el nuevo producto.
                Me.VentaDataGridView.Rows.Add(txtCodigo.Text, TxtCategoria.Text, TxtMarca.Text, TxtModelo.Text, txtCantidad.Text, txtPrecio.Text, subTotal1, txtstock.Text)

                'habilita/desabilita los botones.
                BAgregar.Enabled = False
                BQuitar.Enabled = True
                BVender.Enabled = True
                BCancelar.Enabled = True
                limpiarCampos()
            End If
            'verifica si la cantidad es igual a 0, y muestra un mensaje.
        ElseIf txtCantidad.TextLength = 0 Then
            MsgBox("El campo cantidad se encuentra vacio. ", MsgBoxStyle.Critical, "Campo Cantidad Vacio")
        Else
            MsgBox("Ingrese un producto, por favor. ", MsgBoxStyle.Critical, "Campos Vacios")
        End If

    End Sub

    Private Sub BQuitar_Click(sender As System.Object, e As System.EventArgs) Handles BQuitar.Click
        'guarda en una variable el producto elegido.
        Dim nombre_art = VentaDataGridView.CurrentRow.Cells(3).Value

        'guarda en una variable el subtotal de ese producto elegido.
        Dim subtotal = VentaDataGridView.CurrentRow.Cells("Subtotal").Value
        'actualiza el subtotal, descontando el subtotal del producto recien eliminado.
        actualizarTotal(-subtotal)

        'elimina el producto elegido del detalle de ventas.
        Me.VentaDataGridView.Rows.Remove(Me.VentaDataGridView.CurrentRow)

        'si el datagridview queda vacio, desactiva los botones.
        If Me.VentaDataGridView.Rows.Count = 0 Then
            desactivarBotones()

        End If


    End Sub

    Private Sub BEditar_Click(sender As System.Object, e As System.EventArgs) Handles BEditar.Click
        'verifica si la cantidad es distinta de cero.
        If txtCantidad.TextLength <> 0 Then
            'verifica si la cantidad es menor o igual a 0, e informa.
            If CInt(txtCantidad.Text) <= 0 Then
                ask = MsgBox("Lo siento, es incorrecto la cantidad ingresada.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Exclamation, "ERROR")
                'limpia el textbox.
                txtCantidad.Clear()

            Else
                'guarda en una variable el producto que ha sido seleccionado del detalle de ventas.
                Dim modelo = Me.VentaDataGridView.CurrentRow.Cells.Item(3).Value
                'guarda en variabes el contenido de los textbox, y los convierte a entero y decimal.
                Dim cantidad = CInt(txtCantidad.Text)
                Dim precio = CDec(txtPrecio.Text)
                Dim Stock = CInt(txtstock.Text)

                'veriica si el stock es menor que la cantidad seleccionada.

                If Stock < cantidad Then

                    'muestra un mensaje de que agrego mas que el stock disponible.
                    ask = MsgBox("Agregó más que el stock disponible: " & Stock & "(unidades)", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Exclamation, "ERROR")
                    limpiarCampos()
                    BEditar.Enabled = False
                    'habilita el boton quitar.
                    If Me.VentaDataGridView.Rows.Count <> 0 Then
                        BQuitar.Enabled = True
                    End If

                Else

                    'guarda en una variable el contenido de la celda subtotal
                    Dim subtotal = Me.VentaDataGridView.CurrentRow.Cells.Item(6).Value
                    'descuenta ese subtotal del total general
                    actualizarTotal(-subtotal)
                    'asigna la nueva cantidad a la celda cantidad.
                    Me.VentaDataGridView.CurrentRow.Cells.Item(4).Value = cantidad
                    'asigna el nuevo subtotal, a la celda subtotal.
                    Me.VentaDataGridView.CurrentRow.Cells.Item(6).Value = precio * cantidad
                    'actualiza el total general.
                    actualizarTotal(precio * cantidad)
                    'MsgBox("Se ha modificado correctamente la cantidad, del producto: " & modelo & "", MsgBoxStyle.Information, "Modificación exitosa")

                    limpiarCampos()
                    BEditar.Enabled = False
                    BQuitar.Enabled = True
                End If

            End If
        Else
            MsgBox("El campo cantidad se encuentra vacio, complete por favor. ", MsgBoxStyle.Critical, "Campo Vacio")
        End If
    End Sub

    Private Sub VentaDataGridView_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles VentaDataGridView.CellClick


    End Sub

    Private Sub VentaDataGridView_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles VentaDataGridView.CellContentClick

    End Sub

    Private Sub VentaDataGridView_DoubleClick(sender As Object, e As System.EventArgs) Handles VentaDataGridView.DoubleClick
        BEditar.Enabled = True
        BQuitar.Enabled = False

        'asigna los textbox el contenido de la fila del detalle de ventas que ha sido seleccionada.
        TxtCategoria.Text = Me.VentaDataGridView.CurrentRow.Cells.Item(1).Value
        TxtMarca.Text = Me.VentaDataGridView.CurrentRow.Cells.Item(2).Value
        TxtModelo.Text = Me.VentaDataGridView.CurrentRow.Cells.Item(3).Value
        txtCantidad.Text = Me.VentaDataGridView.CurrentRow.Cells.Item(4).Value
        txtPrecio.Text = Me.VentaDataGridView.CurrentRow.Cells.Item(5).Value
        'busca el producto que ha sido seleccionado.
        Me.ProductosTableAdapter.buscarPorModelo(Me.ElectrodomesticosDataSet.Productos, TxtModelo.Text)
        'asigna el stock del producto seleccionado.
        txtstock.Text = ElectrodomesticosDataSet.Productos.Rows(0).Item("stock")

    End Sub

    Private Sub BVender_Click(sender As System.Object, e As System.EventArgs) Handles BVender.Click
        'verifica que el detalle de ventas no se encuentre vacio, muestra un mensaje si es asi.
        If VentaDataGridView.Rows.Count = 0 Then
            MsgBox("No se ha agregado ningun producto para vender", MsgBoxStyle.Critical, "Detalle de Ventas Vacio")
        Else
            'verifica que el textbox txtDNICliente no se encuentre vacio, muestra un mensaje de error si es asi.
            If (TxtDNICliente.TextLength = 0) Then
                MsgBox("No se ha agregado ningun cliente para la venta", MsgBoxStyle.Critical, "Cliente Vacio")
            Else
                'guarda en una variable el contenido del textbox.
                Dim dnicliente = TxtDNICliente.Text

                'pide confirmacion  para la venta.
                ask = MsgBox(" Se realizará la venta de los productos, esta seguro de hacerlo? ", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Question, "Confirmación de Venta")

                'si la respuesta es si, realiza la venta.
                If MsgBoxResult.Yes = ask Then

                    'resguardo los valores de los articulos
                    Dim Todas = Me.VentaDataGridView.Rows

                    Dim codProducto As Int64
                    Dim modelo As String
                    Dim cantidad As Integer
                    Dim precio As Decimal



                    'se realiza el control de stock de los articulos antes de realizar la venta
                    For Each row As DataGridViewRow In Todas

                        codProducto = row.Cells(0).Value
                        modelo = row.Cells(3).Value
                        cantidad = row.Cells(4).Value
                        Me.ProductosTableAdapter.buscarCodigo(Me.ElectrodomesticosDataSet.Productos, codProducto)

                        'control de stock de cada uno de los articulos que fueron cargados en el detalle
                        If ElectrodomesticosDataSet.Productos.Rows(0).Item("Stock") < cantidad Then
                            Dim stock = ElectrodomesticosDataSet.Productos.Rows(0).Item("Stock")

                            BAgregar.Enabled = False
                            ask = MsgBox("Lo siento, el producto: " & modelo & " ya no tiene suficiente stock, solo dispone: (" & stock & " unidades), modifique la cantidad por favor. ", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "No hay Stock")

                            Return
                        End If
                    Next

                    'guarda en una variable el contenido del textbox.
                    Dim importeTotal = Convert.ToDecimal(TxtTotal.Text)

                    'agrega en la tabla de factura la nueva venta.
                    FacturaTableAdapter.insertarUnaVenta(DatosEmpleado.Mdni, dnicliente, txtFecha.Text, importeTotal)


                    Me.FacturaTableAdapter.ordenFactura(Me.ElectrodomesticosDataSet.Factura)
                    'recupera el ultimo id de a factura.
                    Dim ultimo_id = Me.ElectrodomesticosDataSet.Factura.Rows(0).Item("id_factura")
                    'asigna al textbox del formulario imprimir el ultimo id, para poder imprimir la factura
                    imprimir.txtfacImp.Text = ultimo_id

                    'guardo los detalles de la venta
                    Dim linea = 1
                    Dim subtotalDetalle As Decimal
                    Dim nuevoStock As Int64
                    For Each row As DataGridViewRow In Todas
                        codProducto = row.Cells(0).Value
                        modelo = row.Cells(3).Value
                        cantidad = row.Cells(4).Value
                        precio = row.Cells(5).Value
                        subtotalDetalle = row.Cells(6).Value
                        Me.DetalleFacturaTableAdapter.insertarDetalle(ultimo_id, codProducto, cantidad, precio, subtotalDetalle)
                        nuevoStock = row.Cells(7).Value - cantidad
                        Me.ProductosTableAdapter.actualizarStock(nuevoStock, modelo)
                    Next

                    ask = MsgBox("La venta se ha realizado con éxito. ", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Information, "EXITO: Venta Realizada")
                    BVender.Enabled = False

                    'pide confirmacion para imprimir la factura
                    ask = MsgBox("¿ Desea imprimir la factura ? ", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Information, "IMPRIMIR FACTURA")
                    'si la respuesta es si abre el formulario imprimir, y cierra el formulario actual
                    If MsgBoxResult.Yes = ask Then
                        imprimir.Show()
                        Me.Close()
                    Else
                        'si la respuesta es no, vuelve al formulario del menuVendedor, y cierra el formulario actual
                        MenuVendedor.Show()
                        Me.Close()
                    End If

                    desactivarBotones()
                    'menu.Show()
                    'Me.Close()
                End If

            End If
        End If
    End Sub

    Private Sub TxtTotal_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtTotal.TextChanged

    End Sub

    Private Sub LblHora_Click(sender As System.Object, e As System.EventArgs) Handles LblHora.Click

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        LblHora.Text = Date.Now.ToLongTimeString
    End Sub


    Private Sub BCancelar_Click(sender As System.Object, e As System.EventArgs) Handles BCancelar.Click
        'pide confirmacion para cancelar la venta.
        ask = MsgBox("¿Seguro que desea cancelar la venta?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Exclamation, "Cancelar Venta")
        'si la respuesta es si, limpia todos los textbox y el detalle de ventas.
        If MsgBoxResult.Yes = ask Then
            TxtDNICliente.Clear()
            TxtNombreCliente.Clear()
            TxtApellidoCiente.Clear()
            TxtID.Clear()
            limpiarCampos()
            Me.VentaDataGridView.Rows.Clear()
            TxtTotal.Text = 0
            desactivarBotones()
        End If
    End Sub

    Private Sub VolverToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VolverToolStripMenuItem.Click
        'pide confirmacion para volver al menu del vendedor, ya que al volver se perderan todos los datos que esten cargados.
        ask = MsgBox("Al volver atrás, se borraran los datos que han sido cargados a la venta. ¿Seguro de hacerlo?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Question, "Salir")
        'si la respuesta es si, vuelve al formulario del menu de vendedor y cierra el formulario actual.
        If MsgBoxResult.Yes = ask Then

            Me.Hide()
            MenuVendedor.Show()
            Me.Close()
        End If
    End Sub
End Class