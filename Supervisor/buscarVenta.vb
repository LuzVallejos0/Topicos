Public Class buscarVenta

    Private Sub verVentas_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ElectrodomesticosDataSet.DetalleFactura' Puede moverla o quitarla según sea necesario.
        Me.DetalleFacturaTableAdapter.Fill(Me.ElectrodomesticosDataSet.DetalleFactura)
        'TODO: esta línea de código carga datos en la tabla 'ElectrodomesticosDataSet.DetalleFactura' Puede moverla o quitarla según sea necesario.
        Me.DetalleFacturaTableAdapter.Fill(Me.ElectrodomesticosDataSet.DetalleFactura)
        'TODO: esta línea de código carga datos en la tabla 'ElectrodomesticosDataSet.Factura' Puede moverla o quitarla según sea necesario.
        Me.FacturaTableAdapter.Fill(Me.ElectrodomesticosDataSet.Factura)
        'permite que el datagridview no tenga ninguna fila seleccionada.
        Me.BuscarVentaDataGridView.CurrentRow.Selected = False
    End Sub


    Private Sub BVolver_Click(sender As System.Object, e As System.EventArgs)
        Dim formGerente As New MenuSupervisor
        Me.Hide()
        'abre el formulario del menuSupervisor
        formGerente.Show()
        'cierra el formulario
        Me.Close()
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtDNI.KeyPress
        'valida solo numeros.
        validar2.ValidarSoloNumeros(e)
        'permite buscar dni aprentando la tecla enter.
        If e.KeyChar = Chr(13) Then
            'busca si el dni ingresado tiene facturas asignadas
            If Me.FacturaTableAdapter.buscarDNIEmpleado(Me.ElectrodomesticosDataSet.Factura, txtDNI.Text) = False Then
                MsgBox("No hay facturas realizadas, correspondientes con ese DNI de vendedor", MsgBoxStyle.Critical, "Error: Facturas inexistentes")
                'actualiza el datagridview
                Me.FacturaTableAdapter.Fill(Me.ElectrodomesticosDataSet.Factura)
                Me.BuscarVentaDataGridView.CurrentRow.Selected = False
            End If
            'permite que el datagridview no tenga ninguna fila seleccionada.
            Me.BuscarVentaDataGridView.CurrentRow.Selected = False
            txtDNI.Clear()
            e.Handled = True

        End If
    End Sub

    Private Sub BuscarVentaDataGridView_DoubleClick(sender As Object, e As System.EventArgs) Handles BuscarVentaDataGridView.DoubleClick
        'asigna al formulario VerFactura el valor del datagridview de la celda 0 al textbox txFacturaR
        VerFactura.txtFacturaR.Text = Me.BuscarVentaDataGridView.CurrentRow.Cells.Item(0).Value.ToString
        'abre el formulario verFactura
        VerFactura.ShowDialog()
    End Sub

    Private Sub BuscarVentaDataGridView_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles BuscarVentaDataGridView.CellContentClick

    End Sub

    Private Sub txtFactura_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtFactura.KeyPress
        'valida solo numeros.
        validar2.ValidarSoloNumeros(e)
        'permite buscar una factura presionando la tecla enter.
        If e.KeyChar = Chr(13) Then
            'guarda en una variable el contenido del textbox txtFactura
            Dim factura = txtFactura.Text
            'verifica si el numero de factura que se ingreso existe.
            If Me.FacturaTableAdapter.buscarFactura(Me.ElectrodomesticosDataSet.Factura, factura) = False Then
                'si no existe envia un mensaje de factura inexistente.
                MsgBox("No existe una factura con ese codigo", MsgBoxStyle.Critical, "Factura Inexistente")
                txtFactura.Clear()
                'actualiza el datagridview.
                Me.FacturaTableAdapter.Fill(Me.ElectrodomesticosDataSet.Factura)
                'permite que el datagridview no tenga ninguna fila seleccionada.
                Me.BuscarVentaDataGridView.CurrentRow.Selected = False
            End If
            txtFactura.Clear()
            e.Handled = True

        End If

    End Sub

    Private Sub txtFactura_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtFactura.TextChanged

    End Sub

    Private Sub DFecha_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles DFecha.KeyPress
        'permite buscar una factura por fecha presionando la tecla enter.
        If e.KeyChar = Chr(13) Then
            'verifica que en la fecha ingresada existan facturas.
            If Me.FacturaTableAdapter.buscarFechas(Me.ElectrodomesticosDataSet.Factura, DFecha.Text) = False Then
                MsgBox("No hay facturas realizadas ese dia", MsgBoxStyle.Information, "No hay facturas")
                Me.FacturaTableAdapter.Fill(Me.ElectrodomesticosDataSet.Factura)
                Me.BuscarVentaDataGridView.CurrentRow.Selected = False
            End If
            'permite que el datagridview no tenga ninguna fila seleccionada.
            Me.BuscarVentaDataGridView.CurrentRow.Selected = False
            txtFactura.Clear()
            e.Handled = True

        End If
    End Sub

    Private Sub DFecha_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DFecha.ValueChanged

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        'abre el menu del supervisor
        MenuSupervisor.Show()
        'cierra el formulario
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.FacturaTableAdapter.Fill(Me.ElectrodomesticosDataSet.Factura)
        'permite que el datagridview no tenga ninguna fila seleccionada.
        Me.BuscarVentaDataGridView.CurrentRow.Selected = False
    End Sub
End Class