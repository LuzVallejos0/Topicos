Public Class MenuAdministrador

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles BEmpleados.Click
        Dim forEmpleado As New ABMEmpleados
        Me.Hide()
        'abre el formulario de ABMEmpleados
        forEmpleado.Show()
        Me.Close()

    End Sub

    Private Sub MenuAdministrador_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ElectrodomesticosDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.ElectrodomesticosDataSet.Usuarios)
        LApellidoNombre.Text = DatosEmpleado.MNombre + " " + DatosEmpleado.Mapellido
    End Sub


    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Dim formularioPaginoInicio As New PaginaInicio
        Me.Hide()
        'abre el formulario de PaginaInicio
        formularioPaginoInicio.Show()
        Me.Close()

    End Sub

    Private Sub BProductos_Click(sender As System.Object, e As System.EventArgs) Handles BProductos.Click
        Dim forProductos As New ABMProductos
        Me.Hide()
        'abre el formulario de ABMProductos
        forProductos.Show()
        'cierra el formulario actual
        Me.Close()

    End Sub

    Private Sub BCategorias_Click(sender As System.Object, e As System.EventArgs) Handles BCategorias.Click
        Dim forCategoria As New ABMCategoria
        Me.Hide()
        'abre el formulario de ABMCategoria
        forCategoria.Show()
        'cierra el formulario actual
        Me.Close()

    End Sub


    Private Sub BMarcas_Click(sender As System.Object, e As System.EventArgs) Handles BMarcas.Click
        Dim forMarca As New ABMmarca
        Me.Hide()
        'abre el formulario de ABMMarca
        forMarca.Show()
        'cierra el formulario actual
        Me.Close()

    End Sub

    Private Sub LApellidoNombre_Click(sender As System.Object, e As System.EventArgs) Handles LApellidoNombre.Click

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        LFecha.Text = Now.ToLongDateString
        Lhora.Text = Now.ToLongTimeString
    End Sub

    Private Sub BTipo_Click(sender As System.Object, e As System.EventArgs) Handles BTipo.Click
        Dim forTipoEmpleado As New ABMTipoEmpleado
        Me.Hide()
        'abre el formulario de ABMTipoEmpleado
        forTipoEmpleado.Show()
        'cierra el formulario actual
        Me.Close()

    End Sub

    Private Sub BClientes_Click(sender As System.Object, e As System.EventArgs) Handles BClientes.Click
        Dim forCliente As New ABMClientes
        Me.Hide()
        'abre el formulario de ABMClientes
        forCliente.Show()
        'cierra el formulario actual
        Me.Close()
    End Sub

    Private Sub BBackup_Click(sender As System.Object, e As System.EventArgs) Handles BBackup.Click
        Dim forbackup As New Backup
        Me.Hide()
        'abre el formulario de Backup
        forbackup.Show()
        'cierra el formulario actual
        Me.Close()
    End Sub
End Class