Public Class MenuVendedor

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles BClientes.Click
        Dim forClientes As New AMClientes
        Me.Hide()
        'abre el formulario de AMClientes
        forClientes.Show()
        'cierra el formulario actual
        Me.Close()
    End Sub

    Private Sub MenuVendedor_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'concatena en un label el nombre y apellido del empleado.
        LApellidoNombre.Text = DatosEmpleado.MNombre + " " + DatosEmpleado.Mapellido
    End Sub

    Private Sub BVentas_Click(sender As System.Object, e As System.EventArgs) Handles BVentas.Click
        'Dim forventas As New Ventas

        'abre el formulario de ventas
        Ventas.Show()
        'cierra el formulario actual
        Me.Close()
        ' Me.Hide()
        ' Ventas.ShowDialog()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        LFecha.Text = Now.ToLongDateString
        Lhora.Text = Now.ToLongTimeString
    End Sub

    Private Sub BProductos_Click(sender As System.Object, e As System.EventArgs) Handles BProductos.Click
        Dim forProductos As New VerProductos
        Me.Hide()
        'abre el formulario verProductos.
        forProductos.Show()
        'cierra el formulario actual
        Me.Close()
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click


        Dim formularioPaginoInicio As New PaginaInicio
        Me.Hide()
        'abre el formulario de paginaInicio
        formularioPaginoInicio.Show()
        'cierra el formulario actual.
        Me.Close()


    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs)
        Dim forBuscarVenta As New buscarVenta
        Me.Hide()
        'abre el formulario de buscarVenta
        forBuscarVenta.Show()
        'cierra el formulario actual
        Me.Close()
    End Sub
End Class