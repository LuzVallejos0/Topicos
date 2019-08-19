Public Class VerProductos

    Private Sub VerProductos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ElectrodomesticosDataSet.Categorias' Puede moverla o quitarla según sea necesario.
        Me.CategoriasTableAdapter.Fill(Me.ElectrodomesticosDataSet.Categorias)
        'TODO: esta línea de código carga datos en la tabla 'ElectrodomesticosDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.ElectrodomesticosDataSet.Productos)
        Me.ConsultaDataGridView.CurrentRow.Selected = False
        For Each Row As DataGridViewRow In ConsultaDataGridView.Rows

            If Row.Cells(7).Value = "false" Then
                Row.DefaultCellStyle.BackColor = Color.YellowGreen

            End If

        Next
    End Sub

    Private Sub BVolver_Click(sender As System.Object, e As System.EventArgs)
        Dim forVendedor As New MenuVendedor
        Me.Hide()
        'abre el formulario de menuVendedor.
        forVendedor.Show()
        'cierra el formulario actual
        Me.Close()
    End Sub

    Private Sub TxtModelo_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtModelo.KeyPress
        'validacion para que ingrese solo numeros y letras.
        validar2.validarNumerosYLetras(e)
    End Sub

  


    Private Sub TxtGeneral_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtModelo.TextChanged
        'busqueda interactiva por modelo.
        Me.ProductosTableAdapter.buscarModelo(Me.ElectrodomesticosDataSet.Productos, TxtModelo.Text)
        For Each Row As DataGridViewRow In ConsultaDataGridView.Rows

            If Row.Cells(7).Value = "false" Then
                Row.DefaultCellStyle.BackColor = Color.YellowGreen

            End If

        Next
    End Sub


    Private Sub TxtCodigo_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCodigo.KeyPress
        'validacion para que ingrese solo numeros
        validar2.ValidarSoloNumeros(e)
        'permite que se busque un codigo presionando la tecla enter.
        If e.KeyChar = Chr(13) Then
            'verifica que el textbox no se encuentre vacio.
            If TxtCodigo.TextLength = 0 Then
                MsgBox("Campos Vacios", MsgBoxStyle.Critical, "Campos Vacios")
            Else
                'guarda en una variable el contenido del textbox.
                Dim codigo = TxtCodigo.Text
                'verifica si existe un producto con el codigo ingresado.
                If Me.ProductosTableAdapter.buscarCodigo(Me.ElectrodomesticosDataSet.Productos, codigo) = False Then
                    MsgBox("No hay un producto con ese código", MsgBoxStyle.Critical, "Producto inexistente")

                    Me.ProductosTableAdapter.Fill(Me.ElectrodomesticosDataSet.Productos)

                End If
                TxtCodigo.Clear()

                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'guarda en una variable la categoria seleccionada.
        Dim categoria = CBbuscarCategoria.SelectedValue
        'si la categoria seleccionada no dispone de productos, se muestra un mensaje
        If Me.ProductosTableAdapter.buscarCategoria(Me.ElectrodomesticosDataSet.Productos, categoria) = False Then
            MsgBox("No hay productos agregados para esa categoría", MsgBoxStyle.Critical, "Categoría Vacia")
            Me.ProductosTableAdapter.Fill(Me.ElectrodomesticosDataSet.Productos)
        End If
        For Each Row As DataGridViewRow In ConsultaDataGridView.Rows

            If Row.Cells(7).Value = "false" Then
                Row.DefaultCellStyle.BackColor = Color.YellowGreen

            End If

        Next
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        'abre el formulario menuVendedor.
        MenuVendedor.Show()
        'cierra el formulario.
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.ProductosTableAdapter.Fill(Me.ElectrodomesticosDataSet.Productos)
        Me.ConsultaDataGridView.CurrentRow.Selected = False
        For Each Row As DataGridViewRow In ConsultaDataGridView.Rows

            If Row.Cells(7).Value = "false" Then
                Row.DefaultCellStyle.BackColor = Color.YellowGreen

            End If

        Next
    End Sub
End Class