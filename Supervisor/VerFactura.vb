Public Class VerFactura

    Private Sub VerFactura_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ElectrodomesticosDataSetReportes.Factura' Puede moverla o quitarla según sea necesario.
        Me.FacturaTableAdapter.Fill(Me.ElectrodomesticosDataSetReportes.Factura)
        'TODO: esta línea de código carga datos en la tabla 'ElectrodomesticosDataSetReportes.DetalleFactura' Puede moverla o quitarla según sea necesario.
        Me.DetalleFacturaTableAdapter.Fill(Me.ElectrodomesticosDataSetReportes.DetalleFactura)
        'TODO: esta línea de código carga datos en la tabla 'ElectrodomesticosDataSetReportes.DetalleFactura' Puede moverla o quitarla según sea necesario.
        'guarda en una variable el contenido del textbox y lo convierte a entero.
        Dim factura = CInt(txtFacturaR.Text)
        Me.DetalleFacturaTableAdapter.verFactura(Me.ElectrodomesticosDataSetReportes.DetalleFactura, factura)
        'actualiza el reporte.
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class