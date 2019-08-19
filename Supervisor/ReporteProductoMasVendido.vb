Imports System.Data.SqlClient

Public Class ReporteProductoMasVendido

    Private Sub ReporteProductoMasVendido_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ElectrodomesticosDataSetReportes.productosMasVendidos' Puede moverla o quitarla según sea necesario.
        Me.productosMasVendidosTableAdapter.Fill(Me.ElectrodomesticosDataSetReportes.productosMasVendidos, "01/01/2016", Now)
        'actualiza el reporte.
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub BFecha_Click(sender As System.Object, e As System.EventArgs) Handles BFecha.Click
        'verifica si la primer fecha que se ingreso es mayor a la segunda y de ser asi muestra un mensaje de intervalos incorrectos.
        If Desde.Value > Hasta.Value Then
            MsgBox("El rango de fecha ingresado es incorrecto", MsgBoxStyle.Critical, "ERROR")
        Else
            'verifica si el producto no se vendio en el rango de fechas ingresado, y muestra un mensaje.
            If Me.productosMasVendidosTableAdapter.Fill(Me.ElectrodomesticosDataSetReportes.productosMasVendidos, Desde.Text, Hasta.Text) = False Then
                MsgBox("No hay productos que se hayan vendido en ese rango de fechas", MsgBoxStyle.Critical, "ERROR")
                'actualiza el reporte con los datos predefinos.
                Me.productosMasVendidosTableAdapter.Fill(Me.ElectrodomesticosDataSetReportes.productosMasVendidos, "01/01/2016", Now)
                'actualiza el reporte.
                Me.ReportViewer1.RefreshReport()
            End If
            'actualiza el reporte.
            Me.ReportViewer1.RefreshReport()
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        'abre el formulario reporteProductos
        reporteProductos.Show()
        'cierra el formulario.
        Me.Close()

    End Sub
End Class