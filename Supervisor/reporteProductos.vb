Public Class reporteProductos

    Private Sub reporteProductos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ElectrodomesticosDataSet.Marca' Puede moverla o quitarla según sea necesario.
        Me.MarcaTableAdapter.Fill(Me.ElectrodomesticosDataSet.Marca)
        'TODO: esta línea de código carga datos en la tabla 'ElectrodomesticosDataSet.Categorias' Puede moverla o quitarla según sea necesario.
        Me.CategoriasTableAdapter.Fill(Me.ElectrodomesticosDataSet.Categorias)
        'TODO: esta línea de código carga datos en la tabla 'ElectrodomesticosDataSetReportes.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.ElectrodomesticosDataSetReportes.Productos)

        'actualiza el reporte.
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles BBajoStock.Click
        'visualiza los productos con bajo stock.
        Me.ProductosTableAdapter.productosBajoStock(Me.ElectrodomesticosDataSetReportes.Productos)
        'actualiza el reporte.
        Me.ReportViewer1.RefreshReport()
    End Sub



    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CCategoria.SelectedIndexChanged

    End Sub

    Private Sub BCategoria_Click(sender As System.Object, e As System.EventArgs) Handles BCategoria.Click
        'guarda en una variable la categoria seleccionada.
        Dim categoria = CCategoria.SelectedValue
        'si la categoria seleccionada no tiene productos muestra un mensaje.
        If Me.ProductosTableAdapter.buscarCategoria(Me.ElectrodomesticosDataSetReportes.Productos, categoria) = False Then
            MsgBox("No hay productos para esa categoría", MsgBoxStyle.Critical, "Categoría Vacia")
            Me.ProductosTableAdapter.Fill(Me.ElectrodomesticosDataSetReportes.Productos)

        End If
        'actualiza el reporte.
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub BMarca_Click(sender As System.Object, e As System.EventArgs) Handles BMarca.Click
        'guarda en una variable la marca seleccionada.
        Dim marca = CMarca.SelectedValue
        'si la marca seleccionada no tiene productos muestra un mensaje.
        If Me.ProductosTableAdapter.buscarMarca(Me.ElectrodomesticosDataSetReportes.Productos, marca) = False Then
            MsgBox("No hay productos para esa marca", MsgBoxStyle.Critical, "Marca Vacia")
            Me.ProductosTableAdapter.Fill(Me.ElectrodomesticosDataSetReportes.Productos)

        End If
        'actualiza el reporte.
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCodigo.KeyPress
        'validacion de ingreso solo numeros.
        validar2.ValidarSoloNumeros(e)
        'permite que la busqueda del codigo se realice presionando la tecla enter.
        If e.KeyChar = Chr(13) Then
            'verifica que el textbox no se encuentre vacio.
            If txtCodigo.TextLength = 0 Then
                MsgBox("Campos Vacios", MsgBoxStyle.Critical, "Campos Vacios")
            Else
                'guarda en una variable el codigo ingresado.
                Dim codigo = txtCodigo.Text
                'si no existe un producto con el codigo ingresado muestra un mensaje.
                If Me.ProductosTableAdapter.buscarCodigo(Me.ElectrodomesticosDataSetReportes.Productos, codigo) = False Then
                    MsgBox("No hay un producto con ese código", MsgBoxStyle.Critical, "Producto inexistente")

                    Me.ProductosTableAdapter.Fill(Me.ElectrodomesticosDataSetReportes.Productos)

                End If
                'limpia el textbox
                txtCodigo.Clear()
                'actualiza el reporte.
                Me.ReportViewer1.RefreshReport()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCodigo.TextChanged

    End Sub

    Private Sub txtDescripcion_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDescripcion.TextChanged
        'busqueda interactiva del producto por modelo.
        Me.ProductosTableAdapter.buscarModelo(Me.ElectrodomesticosDataSetReportes.Productos, txtDescripcion.Text)
        'actualiza el reporte
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub BInactivo_Click(sender As System.Object, e As System.EventArgs) Handles BInactivo.Click
        'muestra los productos que se encuentran inactivos(estado = FALSE)
        Me.ProductosTableAdapter.productoInactivo(Me.ElectrodomesticosDataSetReportes.Productos, False)
        'actualiza el reporte.
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub BSinstock_Click(sender As System.Object, e As System.EventArgs) Handles BSinstock.Click
        'muestra los productos sin stock.
        Me.ProductosTableAdapter.productosSinstock(Me.ElectrodomesticosDataSetReportes.Productos)
        'actualiza el reporte.
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'abre el formulario reporteProductoMasVendido.
        ReporteProductoMasVendido.Show()
        'cierra el formulario actual.
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        'abre el formulario reporteProductosMenosVendidos
        ReporteProductosMenosVendidos.Show()
        'cierra el formulario actual.
        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        'abre el formulario reporteComportamiento.
        ReporteComportamiento.Show()
        'cierra el formulario actual.
        Me.Close()

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        'regresa al submenu
        SubMenu.Show()
        'cierra el formulario actual
        Me.Close()

    End Sub

    Private Sub VolverAlMenúDelSupervisorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VolverAlMenúDelSupervisorToolStripMenuItem.Click
        'regresa al menu del supervisor.
        MenuSupervisor.Show()
        'cierra el formulario actual
        Me.Close()

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Me.ProductosTableAdapter.Fill(Me.ElectrodomesticosDataSetReportes.Productos)

        'actualiza el reporte.
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class