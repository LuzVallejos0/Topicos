Public Class reporteVendedores

    Private Sub reporteVendedores_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ElectrodomesticosDataSetReportes.Factura' Puede moverla o quitarla según sea necesario.
        Me.FacturaTableAdapter.Fill(Me.ElectrodomesticosDataSetReportes.Factura)
        'actualiza el reporte.
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub txtCodigo_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtVendedor.KeyPress
        'validacion para que ingrese solo numeros.
        validar2.ValidarSoloNumeros(e)
        'permite buscar el dni del vendedor , presionando la tecla enter.
        If e.KeyChar = Chr(13) Then
            'verifica que el campo no se encuentre vacio.
            If txtVendedor.TextLength = 0 Then
                MsgBox("Campos Vacios", MsgBoxStyle.Critical, "Campos Vacios")
            Else
                'guarda en una variable el contenido del textbox.
                Dim vendedor = txtVendedor.Text
                'verifica si existe un vendedor con el numero de dni ingresado.
                If Me.FacturaTableAdapter.buscarVendedor(Me.ElectrodomesticosDataSetReportes.Factura, vendedor) = False Then
                    MsgBox("No existe un vendedor con ese DNI", MsgBoxStyle.Critical, "Vendedor inexistente")

                    Me.FacturaTableAdapter.Fill(Me.ElectrodomesticosDataSetReportes.Factura)

                End If
                'limpia el textbox.
                txtVendedor.Clear()
                'actualiza el reporte.
                Me.ReportViewer1.RefreshReport()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtCodigo_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtVendedor.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtApellido.TextChanged
        'busqueda interactiva por apellido del vendedor.
        Me.FacturaTableAdapter.buscarApellido(Me.ElectrodomesticosDataSetReportes.Factura, txtApellido.Text)
        'actualiza el reporte.
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub BVendedor_Click(sender As System.Object, e As System.EventArgs) Handles BVendedor.Click
        'abre el formulario de reporteMayorVendedor.
        ReporteMayorVendedor.Show()
        'cierra el formulario actual
        Me.Close()

    End Sub

    Private Sub BFecha_Click(sender As System.Object, e As System.EventArgs) Handles BFecha.Click
        'verifica que la primera fecha ingresada no sea mayor que la segunda, manda un mensaje en caso de que sea asi.
        If Desde.Value > Hasta.Value Then
            MsgBox("El rango de fechas es incorrecto, intente nuevamente", MsgBoxStyle.Critical, "ERROR")
        Else
            'verifica que hayan facturas realizadas de acuerdo al rango de fecha ingresado y muestra si las hay, osino muestra un mensaje.
            If Me.FacturaTableAdapter.buscarMayorVendedorFecha(Me.ElectrodomesticosDataSetReportes.Factura, Desde.Value, Hasta.Value) = False Then
                MsgBox("No hay facturas realizadas en ese rango de fechas", MsgBoxStyle.Critical, "ERROR")
                Me.FacturaTableAdapter.Fill(Me.ElectrodomesticosDataSetReportes.Factura)
                'actualiza el reporte.
                Me.ReportViewer1.RefreshReport()
            End If
            'actualiza el reporte.
            Me.ReportViewer1.RefreshReport()
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        'abre el formulario de submenu
        SubMenu.Show()
        'cierra el formulario actual.
        Me.Close()

    End Sub

    Private Sub VolverAlMenúDelSupervisorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VolverAlMenúDelSupervisorToolStripMenuItem.Click
        'abre el formulario menuSupervisor.
        MenuSupervisor.Show()
        'cierra el formulario actual.
        Me.Close()

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Me.FacturaTableAdapter.Fill(Me.ElectrodomesticosDataSetReportes.Factura)
        'actualiza el reporte.
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class