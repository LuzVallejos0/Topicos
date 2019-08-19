
Public Class listarClientes
    Dim seleccion As Integer
    Dim ask As MsgBoxResult

    Private Sub listarClientes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ElectrodomesticosDataSet.Provincia' Puede moverla o quitarla según sea necesario.
        Me.ProvinciaTableAdapter.Fill(Me.ElectrodomesticosDataSet.Provincia)
        'TODO: esta línea de código carga datos en la tabla 'ElectrodomesticosDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.clientesActivos(Me.ElectrodomesticosDataSet.Clientes, True)
        Me.ClientesDataGridView.CurrentRow.Selected = False
        'activa/desactiva botones
        Bagregar.Enabled = False
        BEditar.Enabled = False
        'desabilida los textbox.
        TxtDNI.Enabled = False
        TxtNombre.Enabled = False
        TxtApellido.Enabled = False
        TxtDireccion.Enabled = False
        TxtLocalidad.Enabled = False
        TxtTelefono.Enabled = False
        TxtEmail.Enabled = False
    End Sub

    Private Sub TDNI_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TDNI.KeyPress
        'validacion para que ingrese solo numeros.
        validar2.ValidarSoloNumeros(e)
        'permite buscar dni presionando la tecla enter.
        If e.KeyChar = Chr(13) Then
            'verifica que el textbox no se encuentre vacio, o que el numero de digitos ingresado sea menor a 8
            If (TDNI.TextLength = 0) Or (TDNI.TextLength < 8) Then
                MsgBox("El numero ingresado no se corresponde con un DNI", MsgBoxStyle.Critical, "Campo Vacio")
                'actualiza el datagridview
                Me.ClientesTableAdapter.clientesActivos(Me.ElectrodomesticosDataSet.Clientes, True)
                'verifica si el dni ingresado existe, si no es asi muestra un mensaje.
            ElseIf Me.ClientesTableAdapter.buscarCliente(Me.ElectrodomesticosDataSet.Clientes, TDNI.Text) = False Then
                MsgBox("DNI inexistente. ", MsgBoxStyle.Critical, "ERROR")
                'actualiza el datagridview
                Me.ClientesTableAdapter.clientesActivos(Me.ElectrodomesticosDataSet.Clientes, True)
                TDNI.Clear()
                'verifica si el dni ingresado se encuentra activo, de no ser asi muestra un mensaje
            ElseIf Me.ClientesTableAdapter.buscarDNIactivo(Me.ElectrodomesticosDataSet.Clientes, TDNI.Text, True) = False Then
                MsgBox("El DNI ingresado no se encuentra activo. ", MsgBoxStyle.Critical, "ERROR")
                'actualiza el datagridview
                Me.ClientesTableAdapter.clientesActivos(Me.ElectrodomesticosDataSet.Clientes, True)
                TDNI.Clear()
            End If
            TDNI.Clear()
            e.Handled = True
            'permite que el datagridview no tenga ninguna fila seleccionada.
            Me.ClientesDataGridView.CurrentRow.Selected = False
        End If
    End Sub


    Private Sub TApellido_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TApellido.KeyPress
        'validacion para que ingrese solo letras.
        validar2.ValidarSoloLetras(e)
    End Sub

    Private Sub TApellido_TextChanged(sender As System.Object, e As System.EventArgs) Handles TApellido.TextChanged
        'busqueda interactiva de apellido.
        Me.ClientesTableAdapter.apellidoActivo(Me.ElectrodomesticosDataSet.Clientes, TApellido.Text, True)
    End Sub

    Private Sub BBuscarDNI_Click(sender As System.Object, e As System.EventArgs)
        If (TDNI.TextLength = 0) Then
            MsgBox("No ha ingresado ningun DNI a buscar", MsgBoxStyle.Critical, "Campo Vacio")
        ElseIf Me.ClientesTableAdapter.buscarCliente(Me.ElectrodomesticosDataSet.Clientes, TDNI.Text) = False Then
            MsgBox("DNI inexistente. ", MsgBoxStyle.Critical, "ERROR")
            Me.ClientesTableAdapter.clientesActivos(Me.ElectrodomesticosDataSet.Clientes, True)
            TDNI.Clear()
        ElseIf Me.ClientesTableAdapter.buscarDNIactivo(Me.ElectrodomesticosDataSet.Clientes, TDNI.Text, True) = False Then
            MsgBox("El DNI ingresado no se encuentra activo. ", MsgBoxStyle.Critical, "ERROR")
            Me.ClientesTableAdapter.clientesActivos(Me.ElectrodomesticosDataSet.Clientes, True)
            TDNI.Clear()
        End If

    End Sub

    Private Sub ClientesDataGridView_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ClientesDataGridView.CellClick
        limpiarCampos()
        BEditar.Enabled = False
        TxtDNI.ReadOnly = False
        Bagregar.Enabled = True
    End Sub


    Private Sub ClientesDataGridView_DoubleClick(sender As Object, e As System.EventArgs) Handles ClientesDataGridView.DoubleClick
        seleccion = ClientesDataGridView.CurrentRow.Index
        Bagregar.Enabled = False
        'habilita los textbox.
        BEditar.Enabled = True
        TxtNombre.Enabled = True
        TxtApellido.Enabled = True
        TxtDireccion.Enabled = True
        TxtLocalidad.Enabled = True
        TxtTelefono.Enabled = True
        TxtEmail.Enabled = True
        'asigna a los textbox el contenido del datagridview de acuerdo a la seleccion que se haya hecho.
        TxtDNI.Text = Me.ClientesDataGridView.CurrentRow.Cells.Item(0).Value.ToString()
        TxtDNI.ReadOnly = True
        TxtNombre.Text = Me.ClientesDataGridView.CurrentRow.Cells.Item(1).Value.ToString()
        TxtApellido.Text = Me.ClientesDataGridView.CurrentRow.Cells.Item(2).Value.ToString()
        TxtDireccion.Text = Me.ClientesDataGridView.CurrentRow.Cells.Item(3).Value.ToString()
        TxtLocalidad.Text = Me.ClientesDataGridView.CurrentRow.Cells.Item(4).Value.ToString()
        CBProvincia.Text = Me.ClientesDataGridView.CurrentRow.Cells.Item(5).Value.ToString()
        TxtTelefono.Text = Me.ClientesDataGridView.CurrentRow.Cells.Item(6).Value.ToString()
        TxtEmail.Text = Me.ClientesDataGridView.CurrentRow.Cells.Item(7).Value.ToString()
    End Sub

    Private Sub TDNI_TextChanged(sender As System.Object, e As System.EventArgs) Handles TDNI.TextChanged

    End Sub

    Private Sub TDNI_Validated(sender As Object, e As System.EventArgs) Handles TDNI.Validated

    End Sub

    Private Sub ClientesDataGridView_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ClientesDataGridView.CellContentClick

    End Sub

    Private Sub limpiarCampos()
        TxtDNI.Clear()
        TxtNombre.Clear()
        TxtApellido.Clear()
        TxtDireccion.Clear()
        TxtLocalidad.Clear()
        TxtTelefono.Clear()
        TxtEmail.Clear()
    End Sub

    Private Sub BEditar_Click(sender As System.Object, e As System.EventArgs) Handles BEditar.Click
        'verifica que ningun textbox se encuentre vacio, muestra un mensaje si alguno se encuentra vacio.
        If (TxtNombre.TextLength = 0) Or (TxtApellido.TextLength = 0) Or (TxtDireccion.TextLength = 0) Or (TxtLocalidad.TextLength = 0) Or (TxtTelefono.TextLength = 0) Or (TxtEmail.TextLength = 0) Then
            MsgBox("Debe completar todos los campos para modificar.", MsgBoxStyle.Critical, "ERROR: Campos vacios")
        Else
            'pide confirmacion para realizar a modificacion
            ask = MsgBox("Se modificará el Cliente: " & TxtApellido.Text & " " & TxtNombre.Text & ", confirmar para seguir.", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Question, "Confirmar Modificación")
            If MsgBoxResult.Yes = ask Then
                'guarda en variables el contenido del datagridview.
                Dim dni = Me.ClientesDataGridView.CurrentRow.Cells.Item(0).Value
                Dim estado = Me.ClientesDataGridView.CurrentRow.Cells.Item(8).Value
                Dim provincia = CBProvincia.SelectedValue
                Me.ClientesTableAdapter.editarCliente(TxtNombre.Text, TxtApellido.Text, TxtDireccion.Text, TxtLocalidad.Text, provincia, TxtTelefono.Text, TxtEmail.Text, estado, dni)

                Me.ClientesTableAdapter.Fill(Me.ElectrodomesticosDataSet.Clientes)

                'asigna a los textbox del formulario de ventas, el valor que contiene las variables que se crearon.
                Ventas.TxtDNICliente.Text = dni
                Ventas.TxtNombreCliente.Text = TxtNombre.Text
                Ventas.TxtApellidoCiente.Text = TxtApellido.Text

                'habilita/desabilida botones y textbox.
                TxtDNI.ReadOnly = False
                Bagregar.Enabled = True
                BEditar.Enabled = False
                TxtDNI.Enabled = False
                TxtNombre.Enabled = False
                TxtApellido.Enabled = False
                TxtDireccion.Enabled = False
                TxtLocalidad.Enabled = False
                TxtTelefono.Enabled = False
                TxtEmail.Enabled = False
                ClientesDataGridView.Enabled = True
            Else
                'asigna a los textbox el contenido del datagridview de acuerdo a la seleccion que se ha hecho.
                TxtDNI.Text = Me.ClientesDataGridView.CurrentRow.Cells.Item(0).Value.ToString()
                TxtDNI.ReadOnly = True
                TxtNombre.Text = Me.ClientesDataGridView.CurrentRow.Cells.Item(1).Value.ToString()
                TxtApellido.Text = Me.ClientesDataGridView.CurrentRow.Cells.Item(2).Value.ToString()
                TxtDireccion.Text = Me.ClientesDataGridView.CurrentRow.Cells.Item(3).Value.ToString()
                TxtLocalidad.Text = Me.ClientesDataGridView.CurrentRow.Cells.Item(4).Value.ToString()
                CBProvincia.Text = Me.ClientesDataGridView.CurrentRow.Cells.Item(5).Value.ToString()
                TxtTelefono.Text = Me.ClientesDataGridView.CurrentRow.Cells.Item(6).Value.ToString()
                TxtEmail.Text = Me.ClientesDataGridView.CurrentRow.Cells.Item(7).Value.ToString()
                Return
            End If
        End If



        limpiarCampos()
        Me.ClientesDataGridView.CurrentRow.Selected = False
        For Each Row As DataGridViewRow In ClientesDataGridView.Rows

            If Row.Cells(8).Value = "false" Then
                Row.DefaultCellStyle.BackColor = Color.YellowGreen

            End If

        Next
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Bagregar.Click
        'asigna a los textbox del formulario de ventas el contenido del datagridview de acuerdo a la seleccion que se realizo.
        Ventas.TxtDNICliente.Text = Me.ClientesDataGridView.CurrentRow.Cells.Item(0).Value
        Ventas.TxtNombreCliente.Text = Me.ClientesDataGridView.CurrentRow.Cells.Item(1).Value
        Ventas.TxtApellidoCiente.Text = Me.ClientesDataGridView.CurrentRow.Cells.Item(2).Value

        'habilita el boton vender del formulario de ventas
        Ventas.BVender.Enabled = True
        'cierra el formulario actual.
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.ClientesTableAdapter.clientesActivos(Me.ElectrodomesticosDataSet.Clientes, True)
        Me.ClientesDataGridView.CurrentRow.Selected = False
    End Sub
End Class