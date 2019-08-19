Public Class SubMenu

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        LFecha.Text = Now.ToLongDateString
        Lhora.Text = Now.ToLongTimeString
    End Sub

    Private Sub BUsuarios_Click(sender As System.Object, e As System.EventArgs) Handles BVentas.Click
        'abre el formulario reporteVentas
        ReporteVentas.Show()
        'cierra el formulario actual
        Me.Close()

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Dim formularioPaginoInicio As New PaginaInicio
        Me.Hide()
        'abre el formulario paginaInicio
        formularioPaginoInicio.Show()
        'cierra el formulario actual
        Me.Close()
    End Sub


    Private Sub VolverAlMenuDelSupervisorToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles VolverAlMenuDelSupervisorToolStripMenuItem.Click
        Dim formGerente As New MenuSupervisor
        Me.Visible = False
        Me.Hide()
        'abre el formulario menuSupervisor.
        formGerente.Show()
        'cierra el formulario actual
        Me.Close()
    End Sub

    Private Sub BVendedores_Click(sender As System.Object, e As System.EventArgs) Handles BVendedores.Click
        'abre el formulario reporteVendedores.
        reporteVendedores.Show()
        'cierra el formulario actual
        Me.Close()

    End Sub

    Private Sub BProductos_Click(sender As System.Object, e As System.EventArgs) Handles BProductos.Click
        'abre el formulario reporteProductos.
        reporteProductos.Show()
        'cierra el formulario actual
        Me.Close()

    End Sub

    Private Sub BClientes_Click(sender As System.Object, e As System.EventArgs) Handles BClientes.Click
        'abre el formulario reporteClientes.
        ReporteClientes.Show()
        'cierra el formulario actual
        Me.Close()

    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub SubMenu_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class