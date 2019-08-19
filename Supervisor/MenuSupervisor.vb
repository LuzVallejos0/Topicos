Public Class MenuSupervisor


    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles BUsuarios.Click
        Dim forUsuario As New ABMUsuario
        Me.Hide()
        'abre el formulario de abmUsuario
        forUsuario.Show()
        'cierra el formulario actual
        Me.Close()

    End Sub

    Private Sub MenuAdministrador_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ElectrodomesticosDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.ElectrodomesticosDataSet.Usuarios)

        'concatena el nombre y apellido del usuario en un textbox.
        LApellidoNombre.Text = DatosEmpleado.MNombre + " " + DatosEmpleado.Mapellido
    End Sub



    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        Dim formularioPaginoInicio As New PaginaInicio
        Me.Hide()
        'abre el formulario de paginaInicio
        formularioPaginoInicio.Show()
        'cierra el formulario
        Me.Close()
    End Sub


    Private Sub BMarcas_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        LFecha.Text = Now.ToLongDateString
        Lhora.Text = Now.ToLongTimeString
    End Sub

    Private Sub BVentas_Click(sender As System.Object, e As System.EventArgs) Handles BVentas.Click
        Dim forBuscarVenta As New buscarVenta
        Me.Hide()
        'abre el formulario de buscarVenta
        forBuscarVenta.Show()
        'cierra el formulario.
        Me.Close()

    End Sub

    Private Sub BBackup_Click(sender As System.Object, e As System.EventArgs)
        Dim forbackup As New Backup
        Me.Hide()
        'abre el formulario de backup
        forbackup.Show()
        'cierra el formulario.
        Me.Close()

    End Sub

    Private Sub Lhora_Click(sender As System.Object, e As System.EventArgs) Handles Lhora.Click

    End Sub

    Private Sub LFecha_Click(sender As System.Object, e As System.EventArgs) Handles LFecha.Click

    End Sub

    Private Sub BReportes_Click(sender As System.Object, e As System.EventArgs) Handles BReportes.Click
        'abre el formulario subMenu
        SubMenu.Show()
        'cierra el formulario.
        Me.Close()
    End Sub
End Class