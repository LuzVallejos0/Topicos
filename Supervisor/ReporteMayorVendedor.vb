Public Class ReporteMayorVendedor

    Private Sub ReporteMayorVendedor_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ElectrodomesticosDataSetReportes.mejoresVendedor' Puede moverla o quitarla según sea necesario.
        Me.mejoresVendedorTableAdapter.Fill(Me.ElectrodomesticosDataSetReportes.mejoresVendedor, "01/01/2016", Now)
        'TODO: esta línea de código carga datos en la tabla 'ElectrodomesticosDataSetReportes.Factura' Puede moverla o quitarla según sea necesario.
       
        'actualiza el reporte.
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub BFecha_Click(sender As System.Object, e As System.EventArgs) Handles BFecha.Click
        'verifica si la primer fecha que se ingreso es mayor a la segunda y de ser asi muestra un mensaje de intervalos incorrectos.
        If Desde.Value > Hasta.Value Then
            MsgBox("El rango de fechas es incorrecto, intente nuevamente", MsgBoxStyle.Critical, "ERROR")
        Else
            'verifica si en el rango de fechas no hay facturas y muestra un mensaje, caso contrario muestra los datos.
            If Me.mejoresVendedorTableAdapter.Fill(Me.ElectrodomesticosDataSetReportes.mejoresVendedor, Desde.Text, Hasta.Text) = False Then
                MsgBox("No hay facturas realizadas en ese rango de fechas", MsgBoxStyle.Critical, "ERROR")
                'actualiza con los datos predefinidos.
                Me.mejoresVendedorTableAdapter.Fill(Me.ElectrodomesticosDataSetReportes.mejoresVendedor, "01/01/2016", Now)
                'actualiza el reporte.
                Me.ReportViewer1.RefreshReport()
            End If
            'actualiza el reporte.
            Me.ReportViewer1.RefreshReport()
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        'abre el formulario reporteVendedores.
        reporteVendedores.Show()
        'cierra el formulario.
        Me.Close()

    End Sub
End Class