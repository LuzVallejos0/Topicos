Public Class imprimir

    Private Sub imprimir_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ElectrodomesticosDataSetReportes.DetalleFactura' Puede moverla o quitarla según sea necesario.
        'guarda en una variable el valor del textbox del formulario de Ventas
        Dim nro = Ventas.TxtFactura.Text
        Me.DetalleFacturaTableAdapter.verFactura(Me.ElectrodomesticosDataSetReportes.DetalleFactura, nro)
        'actualiza el reporte.
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub VolverToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VolverToolStripMenuItem.Click
        'abre el formulario de menuVendedor
        MenuVendedor.Show()
        'cierra el formulario actual
        Me.Close()
    End Sub
End Class