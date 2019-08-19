Public Class ReporteProductosMenosVendidos

    Private Sub ReporteProductosMenosVendidos_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ElectrodomesticosDataSetReportes.productoSinVentaPorFecha' Puede moverla o quitarla según sea necesario.
        'Me.productoSinVentaPorFechaTableAdapter.Fill(Me.ElectrodomesticosDataSetReportes.productoSinVentaPorFecha)
        'TODO: esta línea de código carga datos en la tabla 'ElectrodomesticosDataSetReportes.productoSinVentaPorFecha' Puede moverla o quitarla según sea necesario.
        Me.productoSinVentaPorFechaTableAdapter.Fill(Me.ElectrodomesticosDataSetReportes.productoSinVentaPorFecha, Now, Now)
        'actualiza el reporte.
        Me.ReportViewer1.RefreshReport()
    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        'verifica que la primera fecha ingresada no sea mayor a la segunda, manda mensaje de error de ser asi.
        If DDesde.Value > DHasta.Value Then
            MsgBox("El rango de fecha ingresado es incorrecto", MsgBoxStyle.Critical, "ERROR")
            'actualiza el reporte.
            Me.ReportViewer1.RefreshReport()
        Else
            'muestra los productos que no han sido vendidos de acuerdo al rango de fecha ingresado.
            Me.productoSinVentaPorFechaTableAdapter.Fill(Me.ElectrodomesticosDataSetReportes.productoSinVentaPorFecha, DDesde.Text, DHasta.Text)
            'actualiza el reporte.
            Me.ReportViewer1.RefreshReport()
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        'abre el formulario de reporteProductos.
        reporteProductos.Show()
        'cierra el formulario actual.
        Me.Close()

    End Sub
End Class