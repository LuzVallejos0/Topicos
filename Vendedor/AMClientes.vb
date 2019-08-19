Public Class AMClientes
    Dim ask As MsgBoxResult
    Dim editar As Boolean = False
    Dim seleccion As Integer
    Private Sub AMClientes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ElectrodomesticosDataSet.Provincia' Puede moverla o quitarla según sea necesario.
        Me.ProvinciaTableAdapter.Fill(Me.ElectrodomesticosDataSet.Provincia)
        'TODO: esta línea de código carga datos en la tabla 'ElectrodomesticosDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.ElectrodomesticosDataSet.Clientes)
        'Permite que el datagridview no tenga seleccionado ninguna fila
        Me.ClientesDataGridView.CurrentRow.Selected = False
        desactivarBotones()
        desactivarBotones()
        'recorre el datagridview y cambia el color de la fila en caso que la columna(8) estado este en estado FALSE.
        For Each Row As DataGridViewRow In ClientesDataGridView.Rows

            If Row.Cells(8).Value = "false" Then
                Row.DefaultCellStyle.BackColor = Color.YellowGreen

            End If

        Next
    End Sub


    Private Sub desactivarBotones()
        BEditar.Enabled = False
    End Sub

    Private Sub activarBotones()
        BAgregar.Enabled = True
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub BAgregar_Click(sender As System.Object, e As System.EventArgs) Handles BAgregar.Click

        'verifica que los textbox esten vacios y manda un mensaje de alerta.
        If (TxtDNI.TextLength = 0) Or (TxtNombre.TextLength = 0) Or (TxtApellido.TextLength = 0) Or (TxtDireccion.TextLength = 0) Or (TxtLocalidad.TextLength = 0) Or (TxtTelefono.TextLength = 0) Or (TxtEmail.TextLength = 0) Then
            MsgBox("Debe completar todos los campos para agregar un cliente.", MsgBoxStyle.Critical, "Campos vacios")
        Else
            'guarda en variables los contenidos de los textbox.
            Dim DNI = Convert.ToInt32(TxtDNI.Text)
            Dim nombre = Trim(TxtNombre.Text)
            Dim apellido = Trim(TxtApellido.Text)
            Dim direccion = Trim(TxtDireccion.Text)
            Dim localidad = Trim(TxtLocalidad.Text)
            Dim provincia = CBProvincia.SelectedValue
            Dim telefono = Convert.ToInt64(TxtTelefono.Text)
            Dim email = Trim(TxtEmail.Text)


            'Mensaje de confirmacion para agregar el nuevo cliente.
            ask = MsgBox("Se agregará el cliente : " & apellido & " " & nombre & ", confirmar para seguir.", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Question, "Confirmar Agregar Cliente")
            'si la respuesta es si, agrega el cliente.
            If MsgBoxResult.Yes = ask Then
                'verifica que el dni del nuevo cliente no este registrado en la tabla de clientes.
                If Me.ClientesTableAdapter.buscarCliente(Me.ElectrodomesticosDataSet.Clientes, DNI) Then
                    'muestra mensaje que el dni ingresado ya existe.
                    MsgBox("El DNI: " & DNI & " ya existe, ingrese otro DNI.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Error")
                    'actualiza el datagridview.
                    Me.ClientesTableAdapter.Fill(Me.ElectrodomesticosDataSet.Clientes)
                Else
                    'guarda en una variable el contenido del combobox.
                    Dim id_provincia = CBProvincia.SelectedValue
                    'Agrega el nuevo cliente.
                    Me.ClientesTableAdapter.agregarCliente(DNI, nombre, apellido, direccion, localidad, id_provincia, telefono, email, True)

                    Me.ClientesTableAdapter.mostrarDatosCliente(Me.ElectrodomesticosDataSet.Clientes)
                    'Muestra mensaje que el cliente se ha agregado correctamente.
                    MsgBox("Cliente " + TxtApellido.Text + " " + TxtNombre.Text + " agregado", MsgBoxStyle.Information, "Cliente Agregado")
                    'Permite recorrer y seleccionar la fila recién agregada.
                    For Each Row As DataGridViewRow In ClientesDataGridView.Rows

                        If Row.Cells(0).Value = DNI Then

                            Row.Selected = True
                        End If


                    Next
                    limpiarCampos()
                    Me.ClientesDataGridView.CurrentRow.Selected = False
                End If
            End If
        End If
        desactivarBotones()
        'recorre el datagridview y cambia el color de la fila en caso que la columna(8) estado este en estado FALSE.
        For Each Row As DataGridViewRow In ClientesDataGridView.Rows

            If Row.Cells(8).Value = "false" Then
                Row.DefaultCellStyle.BackColor = Color.YellowGreen

            End If

        Next
    End Sub


    Private Sub LblBuscador_Click(sender As System.Object, e As System.EventArgs) Handles LblBuscador.Click

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

    Private Sub BLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles BLimpiar.Click
        'verifica que los textbox contenga algo, antes de limpiarlos para evitar error en el funcionamiento.
        If (TxtDNI.TextLength <> 0) Or (TxtNombre.TextLength <> 0) Or (TxtApellido.TextLength <> 0) Or (TxtDireccion.TextLength <> 0) Or (TxtLocalidad.TextLength <> 0) Or (TxtEmail.TextLength <> 0) Then
            limpiarCampos()
        Else

            MsgBox("No hay campos por borrar", MsgBoxStyle.Critical, "Borrar campos")
        End If
        'desactiva botones.
        TxtDNI.Enabled = True
        TxtDNI.ReadOnly = False
        BAgregar.Enabled = True
        BEditar.Enabled = False
        'actualiza el datagridview.
        Me.ClientesTableAdapter.Fill(Me.ElectrodomesticosDataSet.Clientes)
        Me.ClientesDataGridView.CurrentRow.Selected = False
        'recorre el datagridview y cambia el color de la fila en caso que la columna(8) estado este en estado FALSE.
        For Each Row As DataGridViewRow In ClientesDataGridView.Rows

            If Row.Cells(8).Value = "false" Then
                Row.DefaultCellStyle.BackColor = Color.YellowGreen

            End If

        Next
    End Sub

    Private Sub BVolver_Click(sender As System.Object, e As System.EventArgs) Handles BVolver.Click
        Dim forVendedor As New MenuVendedor
        Me.Hide()
        'abre el formulario de menuVendedor.
        forVendedor.Show()
        'cierra el formulario actual.
        Me.Close()
    End Sub

    Private Sub TxtDNI_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDNI.KeyPress
        'validacion para agregar solo numeros
        validar2.ValidarSoloNumeros(e)
    End Sub

    Private Sub TxtDNI_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtDNI.TextChanged

    End Sub

    Private Sub TxtNombre_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNombre.KeyPress
        'validacion para agregar solo letras.
        validar2.ValidarSoloLetras(e)
    End Sub

    Private Sub TxtNombre_LostFocus(sender As Object, e As System.EventArgs) Handles TxtNombre.LostFocus
        'validacion para que coloque en mayuscula la primera letra de cada palabra
        TxtNombre.Text = validar1.PrimeraLetraEnMayuscula(TxtNombre.Text)
    End Sub

    Private Sub TxtNombre_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtNombre.TextChanged

    End Sub

    Private Sub TxtApellido_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtApellido.KeyPress
        'validacion para que ingrese solo letras.
        validar2.ValidarSoloLetras(e)
    End Sub

    Private Sub TxtApellido_LostFocus(sender As Object, e As System.EventArgs) Handles TxtApellido.LostFocus
        'Permite colocar en mayuscula la primera letra de cada palabra
        TxtApellido.Text = validar1.PrimeraLetraEnMayuscula(TxtApellido.Text)
    End Sub

    Private Sub TxtApellido_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtApellido.TextChanged

    End Sub

    Private Sub TxtDireccion_LostFocus(sender As Object, e As System.EventArgs) Handles TxtDireccion.LostFocus
        'Permite colocar en mayuscula la primera letra de cada palabra
        TxtDireccion.Text = validar1.PrimeraLetraEnMayuscula(TxtDireccion.Text)
    End Sub


    Private Sub TxtDireccion_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtDireccion.TextChanged

    End Sub

    Private Sub TxtLocalidad_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtLocalidad.KeyPress
        'Permite que se ingresen solo letras
        validar2.ValidarSoloLetras(e)
    End Sub

    Private Sub TxtLocalidad_LostFocus(sender As Object, e As System.EventArgs) Handles TxtLocalidad.LostFocus
        'Permite colocar en mayuscula la primera letra de cada palabra
        TxtLocalidad.Text = validar1.PrimeraLetraEnMayuscula(TxtLocalidad.Text)
    End Sub

    Private Sub TxtLocalidad_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtLocalidad.TextChanged

    End Sub

    Private Sub TxtProvincia_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
        'permite que se ingresen solo letras.
        validar2.ValidarSoloLetras(e)
    End Sub


    Private Sub TxtProvincia_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub TxtTelefono_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTelefono.KeyPress
        'permite que se ingresen solo numeros.
        validar2.ValidarSoloNumeros(e)
    End Sub

    Private Sub TxtTelefono_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtTelefono.TextChanged

    End Sub




    Private Sub BEditar_Click(sender As System.Object, e As System.EventArgs) Handles BEditar.Click
        'verifica si los textbox estan vacios y manda un mensaje de alerta.
        If (TxtNombre.TextLength = 0) Or (TxtApellido.TextLength = 0) Or (TxtDireccion.TextLength = 0) Or (TxtLocalidad.TextLength = 0) Or (TxtTelefono.TextLength = 0) Or (TxtEmail.TextLength = 0) Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.Critical, "Campos vacios")
        Else
            'mensaje para confirmar la modificación
            ask = MsgBox("Se modificará el Cliente: " & TxtApellido.Text & " " & TxtNombre.Text & ", confirmar para seguir.", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Question, "Confirmar Modificación")
            'si la respuesta es si, realiza la modificación.
            If MsgBoxResult.Yes = ask Then
                'guarda en una variable el contenido del datagridview, correspondiente a la columna dni.
                Dim dni = Me.ClientesDataGridView.CurrentRow.Cells.Item(0).Value
                'guarda en una variable el contenido del datagridview, correspondiente a la columna estado.
                Dim estado = Me.ClientesDataGridView.CurrentRow.Cells.Item(8).Value
                'guarda en una variable el contenido del combobox.
                Dim provincia = CBProvincia.SelectedValue
                'realiza modificación.
                Me.ClientesTableAdapter.editarCliente(TxtNombre.Text, TxtApellido.Text, TxtDireccion.Text, TxtLocalidad.Text, provincia, TxtTelefono.Text, TxtEmail.Text, estado, dni)
                'actualiza el datagridview,
                Me.ClientesTableAdapter.Fill(Me.ElectrodomesticosDataSet.Clientes)
                'muestra mensaje de que la modificación se realizo con exito.
                MsgBox("Modificacion exitosa", MsgBoxStyle.Information, "exito")
                limpiarCampos()
                'mantiene seleccionada la fila que ha sido modificada.
                Me.ClientesDataGridView.Rows(seleccion).Selected = True
                'habilita nuevamente el textbox DNI.
                TxtDNI.ReadOnly = False

                BAgregar.Enabled = True

                BLimpiar.Enabled = True
                BEditar.Enabled = False
            End If
        End If
        Me.ClientesDataGridView.CurrentRow.Selected = False
        'recorre el datagridview y cambia el color de la fila en caso que la columna(8) estado este en estado FALSE.
        For Each Row As DataGridViewRow In ClientesDataGridView.Rows

            If Row.Cells(8).Value = "false" Then
                Row.DefaultCellStyle.BackColor = Color.YellowGreen

            End If

        Next
    End Sub



    Private Sub TDNI_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TDNI.KeyPress
        'validar para que en el textbox se ingrese solo numeros.
        validar2.ValidarSoloNumeros(e)
        'Permite buscar un DNI apretando la tecla enter.
        If e.KeyChar = Chr(13) Then
            'verifica que el textbox este vacio, o que el numero de digitos ingresado sea menor a 8, y muestra un mensaje de alerta.
            If (TDNI.TextLength = 0) Or (TDNI.TextLength < 8) Then
                MsgBox("El numero ingresado es incorrecto", MsgBoxStyle.Critical, "Campo Vacio")
                'actualiza el datagridview.
                Me.ClientesTableAdapter.Fill(Me.ElectrodomesticosDataSet.Clientes)
                'Si el DNI no se encuentra en la tabla de cliente, muestra un mensaje. 
            ElseIf Me.ClientesTableAdapter.buscarCliente(Me.ElectrodomesticosDataSet.Clientes, TDNI.Text) = False Then
                MsgBox("DNI inexistente. ", MsgBoxStyle.Critical, "ERROR")
                'actualiza el datagridview.
                Me.ClientesTableAdapter.Fill(Me.ElectrodomesticosDataSet.Clientes)
                'limpia el textbox.
                TDNI.Clear()
            End If
            TDNI.Clear()
            e.Handled = True
            'Me.ClientesDataGridView.CurrentRow.Selected = False
        End If
    End Sub

    Private Sub TDNI_TextChanged(sender As System.Object, e As System.EventArgs) Handles TDNI.TextChanged

    End Sub

    Private Sub TApellido_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TApellido.KeyPress
        'validacion para que el textbox solo acepte letras.
        validar2.ValidarSoloLetras(e)
    End Sub

    Private Sub TApellido_LostFocus(sender As Object, e As System.EventArgs) Handles TApellido.LostFocus
        'Permite colocar en mayuscula la primera letra de cada palabra
        TApellido.Text = validar1.PrimeraLetraEnMayuscula(TApellido.Text)
    End Sub

    Private Sub TApellido_TextChanged(sender As System.Object, e As System.EventArgs) Handles TApellido.TextChanged
        'busca apellido de forma interactiva.
        Me.ClientesTableAdapter.busquedaApellidoI(Me.ElectrodomesticosDataSet.Clientes, TApellido.Text)
        'recorre el datagridview y cambia el color de la fila en caso que la columna(8) estado este en estado FALSE.
        For Each Row As DataGridViewRow In ClientesDataGridView.Rows

            If Row.Cells(8).Value = "false" Then
                Row.DefaultCellStyle.BackColor = Color.YellowGreen

            End If

        Next
    End Sub

    Private Sub ClientesDataGridView_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub



    Private Sub ClientesDataGridView_DoubleClick(sender As Object, e As System.EventArgs) Handles ClientesDataGridView.DoubleClick
        'guarda en una variable el contenido del datagridview de acuerdo con la selección realizada.
        seleccion = ClientesDataGridView.CurrentRow.Index
        BEditar.Enabled = True
        BLimpiar.Enabled = True

        BAgregar.Enabled = False
        'coloca en los textbox correspondientes el contenido del datagriview de acuerdo con la fila que ha sido seleccionada.
        TxtDNI.Text = Me.ClientesDataGridView.CurrentRow.Cells.Item(0).Value.ToString()
        'no habilita el textbox DNI para editar.
        TxtDNI.ReadOnly = True
        TxtNombre.Text = Me.ClientesDataGridView.CurrentRow.Cells.Item(1).Value.ToString()
        TxtApellido.Text = Me.ClientesDataGridView.CurrentRow.Cells.Item(2).Value.ToString()
        TxtDireccion.Text = Me.ClientesDataGridView.CurrentRow.Cells.Item(3).Value.ToString()
        TxtLocalidad.Text = Me.ClientesDataGridView.CurrentRow.Cells.Item(4).Value.ToString()
        CBProvincia.Text = Me.ClientesDataGridView.CurrentRow.Cells.Item(5).Value.ToString()
        TxtTelefono.Text = Me.ClientesDataGridView.CurrentRow.Cells.Item(6).Value.ToString()
        TxtEmail.Text = Me.ClientesDataGridView.CurrentRow.Cells.Item(7).Value.ToString()
    End Sub

    Private Sub ClientesDataGridView_CellContentClick_1(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ClientesDataGridView.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.ClientesTableAdapter.Fill(Me.ElectrodomesticosDataSet.Clientes)
        'Permite que el datagridview no tenga seleccionado ninguna fila
        Me.ClientesDataGridView.CurrentRow.Selected = False
        For Each Row As DataGridViewRow In ClientesDataGridView.Rows

            If Row.Cells(8).Value = "false" Then
                Row.DefaultCellStyle.BackColor = Color.YellowGreen

            End If

        Next
    End Sub
End Class