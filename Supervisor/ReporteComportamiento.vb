Public Class ReporteComportamiento

    Private Sub ReporteComportamiento_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ElectrodomesticosDataSetReportes.comportamientoProductos' Puede moverla o quitarla según sea necesario.
        Me.comportamientoProductosTableAdapter.Fill(Me.ElectrodomesticosDataSetReportes.comportamientoProductos, 5, 2016)
        Me.ReportViewer1.RefreshReport()
        'TODO: esta línea de código carga datos en la tabla 'ElectrodomesticosDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.ElectrodomesticosDataSet.Productos)
        cbAño.SelectedIndex = 0
        txtCodigo.Enabled = False
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProductosDataGridView.CellClick
        'asigna al textbox el valor que contiene el datagridview en la celda 0 de la fila seleccionada.
        txtCodigo.Text = Me.ProductosDataGridView.CurrentRow.Cells.Item(0).Value
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProductosDataGridView.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'verifica que el textbox no se encuentre vacio, caso contrario manda un msj de error.
        If txtCodigo.Text = "" Then
            MsgBox("No ha ingresado ningun producto", MsgBoxStyle.Critical, "ERROR")
        Else
            'muestra los datos correspodiente al producto elegido
            Me.comportamientoProductosTableAdapter.Fill(Me.ElectrodomesticosDataSetReportes.comportamientoProductos, txtCodigo.Text, cbAño.Text)
            'actualiza el reporte.
            Me.ReportViewer1.RefreshReport()
        End If
    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        'abre el formulario reporteProductos.
        reporteProductos.Show()
        'cierra el formulario
        Me.Close()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtcodigo1.KeyPress
        'validacion para que ingrese solo numeros.
        validar2.ValidarSoloNumeros(e)

        'permite buscar un codigo presionando la tecla enter
        If e.KeyChar = Chr(13) Then
            'verifica que el campo codigo no se encuentre vacio.
            If txtcodigo1.TextLength = 0 Then
                MsgBox("Campos Vacios", MsgBoxStyle.Critical, "Campos Vacios")
            Else
                'guarda en una variabe el contenido del textbox.
                Dim codigo = txtcodigo1.Text
                'verifica que exista un producto con ese codigo.
                If Me.ProductosTableAdapter.buscarCodigo(Me.ElectrodomesticosDataSet.Productos, codigo) = False Then
                    MsgBox("No hay un producto con ese código", MsgBoxStyle.Critical, "Producto inexistente")
                    'actualiza el datagridview.
                    Me.ProductosTableAdapter.Fill(Me.ElectrodomesticosDataSet.Productos)

                End If
                'limpia el textbox.
                txtcodigo1.Clear()

                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtcodigo1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.ProductosTableAdapter.Fill(Me.ElectrodomesticosDataSet.Productos)
    End Sub
End Class