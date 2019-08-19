Public Class ReporteVentas

    Private Sub ventasver_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ElectrodomesticosDataSetReportes.DetalleFactura' Puede moverla o quitarla según sea necesario.
        Me.DetalleFacturaTableAdapter.Fill(Me.ElectrodomesticosDataSetReportes.DetalleFactura)
        'actualiza el reporte.
        Me.ReportViewer1.RefreshReport()
    End Sub



    Private Sub txtDNI_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtDNI.KeyPress
        'validacion para que ingrese solo numeros.
        validar2.ValidarSoloNumeros(e)
        'permite buscar el dni presionando la tecla enter.
        If e.KeyChar = Chr(13) Then
            'verifica que el campo no se encuentre vacio.
            If txtDNI.TextLength = 0 Then
                MsgBox("Campos Vacios", MsgBoxStyle.Critical, "Campos Vacios")
            Else
                'verifica que existan facturas realizadas por el vendedor con el dni ingresado.
                If Me.DetalleFacturaTableAdapter.busquedaPorDni(Me.ElectrodomesticosDataSetReportes.DetalleFactura, txtDNI.Text) = False Then
                    MsgBox("No hay facturas realizadas, correspondientes con ese DNI de vendedor", MsgBoxStyle.Critical, "Error: Facturas inexistentes")
                    Me.DetalleFacturaTableAdapter.Fill(Me.ElectrodomesticosDataSetReportes.DetalleFactura)

                End If
                'limpia el textbox
                txtDNI.Clear()
                'actualiza el reporte.
                Me.ReportViewer1.RefreshReport()
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub txtFactura_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtFactura.KeyPress
        'validacion para que ingrese solo numeros.
        validar2.ValidarSoloNumeros(e)
        'permite buscar una factura presionando la tecla enter.
        If e.KeyChar = Chr(13) Then
            'verifica que el textbox no se encuentre vacio, en caso contrario muestra un msj.
            If txtFactura.TextLength = 0 Then
                MsgBox("Campos Vacios", MsgBoxStyle.Critical, "Campos Vacios")
            Else
                'guarda en una variable el contenido del textbox.
                Dim factura = txtFactura.Text
                'verifica si existe una factura con el numero ingresado, si no es asi muestra un mensaje.
                If Me.DetalleFacturaTableAdapter.busquedaPorFactura(Me.ElectrodomesticosDataSetReportes.DetalleFactura, factura) = False Then
                    MsgBox("No existe una factura con ese codigo", MsgBoxStyle.Critical, "Factura Inexistente")

                    Me.DetalleFacturaTableAdapter.Fill(Me.ElectrodomesticosDataSetReportes.DetalleFactura)

                End If
                'limpia el textbox.
                txtFactura.Clear()
                'actualiza el reporte.
                Me.ReportViewer1.RefreshReport()
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub txtCliente_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtCliente.KeyPress
        'validacion para que ingrese solo numeros.
        validar2.ValidarSoloNumeros(e)
        'permite buscar el dni presionando la tecla enter.
        If e.KeyChar = Chr(13) Then
            'verifica que el campo no se encuentre vacio.
            If txtCliente.TextLength = 0 Then
                MsgBox("Campos Vacios", MsgBoxStyle.Critical, "Campos Vacios")
            Else
                'guarda en una variable el contenido del textbox.
                Dim cliente = txtCliente.Text
                If Me.DetalleFacturaTableAdapter.busquedaCliente(Me.ElectrodomesticosDataSetReportes.DetalleFactura, cliente) = False Then
                    MsgBox("No hay facturas correspondientes a ese Cliente", MsgBoxStyle.Critical, "Factura Inexistente")

                    Me.DetalleFacturaTableAdapter.Fill(Me.ElectrodomesticosDataSetReportes.DetalleFactura)

                End If
                'limpia el textbox.
                txtCliente.Clear()
                'actualiza el reporte.
                Me.ReportViewer1.RefreshReport()
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'verifica que la primer fecha ingresada no sea mayor que la segunda, manda un mensaje en ese caso.
        If DFecha.Value > DHasta.Value Then
            MsgBox("El rango de fecha ingresado es incorrecto", MsgBoxStyle.Critical, "ERROR")
            'actualiza el reporte.
            Me.ReportViewer1.RefreshReport()
        Else
            'verifica que existan facturas en el rango de fecha ingresado, muestra un mensaje si no hay facturas en ese rango.
            If Me.DetalleFacturaTableAdapter.buscarFecha(Me.ElectrodomesticosDataSetReportes.DetalleFactura, DFecha.Value, DHasta.Value) = False Then
                MsgBox("No hay facturas correspondientes con la fecha ingresada", MsgBoxStyle.Critical, "No hay facturas")
                Me.DetalleFacturaTableAdapter.Fill(Me.ElectrodomesticosDataSetReportes.DetalleFactura)
                'actualiza el reporte.
                Me.ReportViewer1.RefreshReport()
            End If

        End If
        'actualiza el reporte.
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        'abre el formulario submenu
        SubMenu.Show()
        'cierra el formulario actual
        Me.Close()

    End Sub

    Private Sub VolverAlMenúDelSupervisorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VolverAlMenúDelSupervisorToolStripMenuItem.Click
        'abre el formulario menuSupervisor.
        MenuSupervisor.Show()
        'cierra el formulario actual
        Me.Close()


    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Me.DetalleFacturaTableAdapter.Fill(Me.ElectrodomesticosDataSetReportes.DetalleFactura)
        'actualiza el reporte.
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class