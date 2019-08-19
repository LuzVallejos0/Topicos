Public Class MejorCliente

    Private Sub MejorCliente_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ElectrodomesticosDataSetReportes.mejoresClientes' Puede moverla o quitarla según sea necesario.
        Me.mejoresClientesTableAdapter.Fill(Me.ElectrodomesticosDataSetReportes.mejoresClientes, "01/01/2016", Now)
        'actualiza el reporte.
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub BFecha_Click(sender As System.Object, e As System.EventArgs) Handles BFecha.Click
        'verifica que la primera fecha ingresada no sea mayor que la segunda, caso contrario envia un mensaje.
        If Desde.Value > Hasta.Value Then
            MsgBox("El rango de fecha ingresado es incorrecto", MsgBoxStyle.Critical, "ERROR")
        Else
            'verifica si en ese rango de fechas existen facturas, caso contrario envia un mensaje.
            If Me.mejoresClientesTableAdapter.Fill(Me.ElectrodomesticosDataSetReportes.mejoresClientes, Desde.Text, Hasta.Text) = False Then
                MsgBox("No hay facturas realizadas en ese rango de fechas", MsgBoxStyle.Critical, "ERROR")

                Me.mejoresClientesTableAdapter.Fill(Me.ElectrodomesticosDataSetReportes.mejoresClientes, "01/01/2016", Now)
                'actualiza el reporte.
                Me.ReportViewer1.RefreshReport()
            End If
            'actualiza el reporte.
            Me.ReportViewer1.RefreshReport()
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        'abre el formulario de reporteClientes.
        ReporteClientes.Show()
        'cierra el formulario.
        Me.Close()

    End Sub
End Class