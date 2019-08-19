Public Class ReporteClientes

    Private Sub ReporteClientes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ElectrodomesticosDataSetReportes.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.ElectrodomesticosDataSetReportes.Clientes)
        'actualiza el reporte.
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub BVendedor_Click(sender As System.Object, e As System.EventArgs) Handles BVendedor.Click
        'abre el formulario de mejorCliente.
        MejorCliente.Show()
        'cierra el formulario.
        Me.Close()

    End Sub

    Private Sub txtDNICliente_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtDNICliente.KeyPress
        'valida solo numeros.
        validar2.ValidarSoloNumeros(e)
        'permite buscar un cliente por dni, presionando la tecla enter.
        If e.KeyChar = Chr(13) Then
            'verifica que el campo no se encuentre vacio.
            If txtDNICliente.TextLength = 0 Then
                MsgBox("Campos Vacios", MsgBoxStyle.Critical, "Campos Vacios")
            Else

                Dim cliente = txtDNICliente.Text
                'si el dni ingresado no se encuentra registrado muestra un mensaje de cliente inexistente.
                If Me.ClientesTableAdapter.buscarDNI(Me.ElectrodomesticosDataSetReportes.Clientes, cliente) = False Then
                    MsgBox("No existe un cliente con ese DNI", MsgBoxStyle.Critical, "DNI inexistente")

                    Me.ClientesTableAdapter.Fill(Me.ElectrodomesticosDataSetReportes.Clientes)

                End If
                txtDNICliente.Clear()
                'actualiza el reporte.
                Me.ReportViewer1.RefreshReport()
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtVendedor_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtDNICliente.TextChanged
        
    End Sub

    Private Sub txtApellido_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtApellido.KeyPress
        'valida solo letras.
        validar2.ValidarSoloLetras(e)
    End Sub

    Private Sub txtApellido_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtApellido.TextChanged
        'busqueda iterativa de apellido
        Me.ClientesTableAdapter.buscarApellido(Me.ElectrodomesticosDataSetReportes.Clientes, txtApellido.Text)
        'actualiza el reporte.
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        'abre el formulario subMenu
        SubMenu.Show()
        'cierra el formulario.
        Me.Close()
    End Sub

    Private Sub VolverAlMenuDelSupervisorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VolverAlMenuDelSupervisorToolStripMenuItem.Click
        'abre el formulario de menuSupervisor
        MenuSupervisor.Show()
        'cierra el formulario.
        Me.Close()

    End Sub


    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Me.ClientesTableAdapter.Fill(Me.ElectrodomesticosDataSetReportes.Clientes)
        'actualiza el reporte.
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class