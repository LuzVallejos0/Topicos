Public Class ABMEmpleados

    Dim ask As MsgBoxResult
    Dim seleccion As Integer
    Dim editar As Boolean = False

    Private Sub ABMEmpleados_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ElectrodomesticosDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.ElectrodomesticosDataSet.Usuarios)
        'TODO: esta línea de código carga datos en la tabla 'ElectrodomesticosDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.ElectrodomesticosDataSet.Usuarios)
        'TODO: esta línea de código carga datos en la tabla 'ElectrodomesticosDataSet.TipoEmpleado' Puede moverla o quitarla según sea necesario.
        Me.TipoEmpleadoTableAdapter.TipoActivo(Me.ElectrodomesticosDataSet.TipoEmpleado, True)
        'TODO: esta línea de código carga datos en la tabla 'ElectrodomesticosDataSet.Empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.ElectrodomesticosDataSet.Empleados)
        'TODO: esta línea de código carga datos en la tabla 'ElectrodomesticosDataSet.Provincia' Puede moverla o quitarla según sea necesario.
        Me.ProvinciaTableAdapter.Fill(Me.ElectrodomesticosDataSet.Provincia)
       
        'TODO: esta línea de código carga datos en la tabla 'ElectrodomesticosDataSet.Provincia' Puede moverla o quitarla según sea necesario.
        Me.ProvinciaTableAdapter.Fill(Me.ElectrodomesticosDataSet.Provincia)
        'Permite que el datagridview no tenga seleccionado ninguna fila
        Me.EmpleadosDataGridView.CurrentRow.Selected = False

        desactivarBotones()
        BEliminarEmpleado.Enabled = False
        'recorre el datagridview y cambia el color de la fila en caso que la columna(8) estado este en estado FALSE.
        For Each Row As DataGridViewRow In EmpleadosDataGridView.Rows

            If Row.Cells(8).Value = "false" Then
                Row.DefaultCellStyle.BackColor = Color.YellowGreen

            End If

        Next
    End Sub

    Private Sub desactivarBotones()
        'desactiva botones
        BActivarEmpleado.Enabled = False
        BEditarEmpleado.Enabled = False
    
    End Sub

    Private Sub limpiarCampos()
        'limpia los campos de los textbox.
        TxtDNI.Clear()
        TxtNombre.Clear()
        TxtApellido.Clear()
        TxtDireccion.Clear()
        TxtLocalidad.Clear()

        TxtTelefono.Clear()

    End Sub


    Private Sub BAgregarEmpleado_Click(sender As System.Object, e As System.EventArgs) Handles BAgregarEmpleado.Click
        'verifica que los textbox esten vacios y manda un mensaje de alerta.
        If (TxtDNI.TextLength = 0) Or (TxtNombre.TextLength = 0) Or (TxtApellido.TextLength = 0) Or (TxtDireccion.TextLength = 0) Or (TxtLocalidad.TextLength = 0) Or (TxtTelefono.TextLength = 0) Then
            MsgBox("Debe completar todos los campos para agregar un empleado.", MsgBoxStyle.Critical, "Campos vacios")
        Else
            'guarda en variables los contenidos de los textbox.
            Dim DNI = Convert.ToInt32(TxtDNI.Text)
            Dim nombre = Trim(TxtNombre.Text)
            Dim apellido = Trim(TxtApellido.Text)
            Dim direccion = Trim(TxtDireccion.Text)
            Dim localidad = Trim(TxtLocalidad.Text)
            Dim provincia = CBProvincia.SelectedValue
            Dim telefono = Convert.ToInt64(TxtTelefono.Text)

            'Mensaje de confirmacion para agregar el nuevo empleado.
            ask = MsgBox("Se agregará el empleado : " & apellido & " " & nombre & ",confirmar para seguir.", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Question, "Confirmar Agregar Empleado ")
            'si la respuesta es si, agrega el empleado.
            If MsgBoxResult.Yes = ask Then
                'verifica que el dni del nuevo empleado no este registrado en la tabla de empleados.
                If Me.EmpleadosTableAdapter.buscarDNIEmpleado(Me.ElectrodomesticosDataSet.Empleados, DNI) Then
                    'muestra mensaje que el dni ingresado ya existe.
                    MsgBox("El DNI: " & DNI & " ya existe, ingrese uno distinto.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "ERROR")
                    'actualiza el datagridview.
                    Me.EmpleadosTableAdapter.Fill(Me.ElectrodomesticosDataSet.Empleados)
                Else
                    'guarda en una variable el contenido del combobox.
                    Dim tipoEmpleado = CBTipoEmpleado.SelectedValue
                    'Agrega el nuevo empleado.
                    Me.EmpleadosTableAdapter.agregarEmpleado(DNI, nombre, apellido, direccion, localidad, provincia, telefono, True, tipoEmpleado)
                    'actualiza el datagridview.
                    Me.EmpleadosTableAdapter.Fill(Me.ElectrodomesticosDataSet.Empleados)
                    'Muestra mensaje que el empleado se ha agregado correctamente.
                    MsgBox("El empleado " + TxtApellido.Text + " " + TxtNombre.Text + " ha sido agregado correctamente. ", MsgBoxStyle.Information, "Empleado Agregado")
                    limpiarCampos()
                    'Permite recorrer y seleccionar la fila recién agregada.
                    For Each Row As DataGridViewRow In EmpleadosDataGridView.Rows

                        If Row.Cells(0).Value = DNI Then

                            Row.Selected = True

                        End If


                    Next
                    Me.EmpleadosDataGridView.CurrentRow.Selected = False
                End If
            End If
        End If
        BEliminarEmpleado.Enabled = False
        'recorre el datagridview y cambia el color de la fila en caso que la columna(8) estado este en estado FALSE.
        For Each Row As DataGridViewRow In EmpleadosDataGridView.Rows

            If Row.Cells(8).Value = "false" Then
                Row.DefaultCellStyle.BackColor = Color.YellowGreen

            End If
        Next
    End Sub

    Private Sub TxtDNI_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDNI.KeyPress
        'validacion para que el textbox solo permita numeros.
        validar2.ValidarSoloNumeros(e)
    End Sub

    Private Sub TxtDNI_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtDNI.TextChanged

    End Sub

    Private Sub TxtNombre_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNombre.KeyPress
        'validacion para que el textbox solo permita letras.
        validar2.ValidarSoloLetras(e)
    End Sub

    Private Sub TxtNombre_LostFocus(sender As Object, e As System.EventArgs) Handles TxtNombre.LostFocus
        'Permite colocar en mayuscula la primera letra de cada palabra
        TxtNombre.Text = validar1.PrimeraLetraEnMayuscula(TxtNombre.Text)
    End Sub

    Private Sub TxtNombre_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtNombre.TextChanged

    End Sub

    Private Sub TxtApellido_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtApellido.KeyPress
        'validacion para que el textbox solo permita letras.
        validar2.ValidarSoloLetras(e)
    End Sub

    Private Sub TxtApellido_LostFocus(sender As Object, e As System.EventArgs) Handles TxtApellido.LostFocus
        'Permite colocar en mayuscula la primera letra de cada palabra
        TxtApellido.Text = validar1.PrimeraLetraEnMayuscula(TxtApellido.Text)
    End Sub

    Private Sub TxtApellido_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtApellido.TextChanged

    End Sub

    Private Sub TxtDireccion_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDireccion.KeyPress
        'validacion para que el textbox solo permita letras y numeros.
        validar2.validarNumerosYLetras(e)
    End Sub

    Private Sub TxtDireccion_LostFocus(sender As Object, e As System.EventArgs) Handles TxtDireccion.LostFocus
        'Permite colocar en mayuscula la primera letra de cada palabra
        TxtDireccion.Text = validar1.PrimeraLetraEnMayuscula(TxtDireccion.Text)
    End Sub

    Private Sub TxtDireccion_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtDireccion.TextChanged

    End Sub

    Private Sub TxtLocalidad_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtLocalidad.KeyPress
        'validacion para que el textbox solo permita letras.
        validar2.ValidarSoloLetras(e)
    End Sub

    Private Sub TxtLocalidad_LostFocus(sender As Object, e As System.EventArgs) Handles TxtLocalidad.LostFocus
        'Permite colocar en mayuscula la primera letra de cada palabra
        TxtLocalidad.Text = validar1.PrimeraLetraEnMayuscula(TxtLocalidad.Text)
    End Sub

    Private Sub TxtLocalidad_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtLocalidad.TextChanged

    End Sub

    Private Sub TxtProvincia_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
        'validacion para que el textbox solo permita letras.
        validar2.ValidarSoloLetras(e)
    End Sub


    Private Sub TxtProvincia_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub TxtTelefono_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTelefono.KeyPress
        'validacion para que el textbox solo permita numeros.
        validar2.ValidarSoloNumeros(e)
    End Sub

    Private Sub TxtTelefono_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtTelefono.TextChanged

    End Sub



    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub


    Private Sub TApellidoEmpleado_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TApellidoEmpleado.KeyPress
        'validacion para que el textbox solo permita letras.
        validar2.ValidarSoloLetras(e)
    End Sub

    Private Sub TApellidoEmpleado_TextChanged(sender As System.Object, e As System.EventArgs) Handles TApellidoEmpleado.TextChanged
        'busca apellido de forma interactiva.
        Me.EmpleadosTableAdapter.buscarApellido(Me.ElectrodomesticosDataSet.Empleados, TApellidoEmpleado.Text)
        'Me.EmpleadosDataGridView.CurrentRow.Selected = False
        'recorre el datagridview y cambia el color de la fila en caso que la columna(8) estado este en estado FALSE.
        For Each Row As DataGridViewRow In EmpleadosDataGridView.Rows

            If Row.Cells(8).Value = "false" Then
                Row.DefaultCellStyle.BackColor = Color.YellowGreen

            End If

        Next
    End Sub

    Private Sub BEditarEmpleado_Click(sender As System.Object, e As System.EventArgs) Handles BEditarEmpleado.Click
        'verifica si los textbox estan vacios y manda un mensaje de alerta.
            If (TxtNombre.TextLength = 0) Or (TxtApellido.TextLength = 0) Or (TxtDireccion.TextLength = 0) Or (TxtLocalidad.TextLength = 0) Or (TxtTelefono.TextLength = 0) Then
            MsgBox("Hay campos vacios, complete para seguir.", MsgBoxStyle.Critical, "Campos vacios")
        Else
            'mensaje para confirmar la modificación
            ask = MsgBox("Se modificará el Empleado: " & TxtApellido.Text & " " & TxtNombre.Text & ", confirmar para seguir.", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Exclamation, "Confirmar modifcación de Empleados")
            'si la respuesta es si, realiza la modificación.
            If MsgBoxResult.Yes = ask Then
                'guarda en una variable el contenido del datagridview, correspondiente a la columna dni.
                Dim dni = Me.EmpleadosDataGridView.CurrentRow.Cells.Item(0).Value
                'guarda en una variable el contenido del datagridview, correspondiente a la columna estado.
                Dim estado = Me.EmpleadosDataGridView.CurrentRow.Cells.Item(8).Value
                'guarda en una variable el contenido del combobox.
                Dim provincia = CBProvincia.SelectedValue
                'guarda en una variable el contenido del combobox.
                Dim tipo = CBTipoEmpleado.SelectedValue
                'realiza modificación.
                Me.EmpleadosTableAdapter.editarEmpleados(TxtNombre.Text, TxtApellido.Text, TxtDireccion.Text, TxtLocalidad.Text, provincia, TxtTelefono.Text, estado, tipo, dni)
                'actualiza el datagridview,
                Me.EmpleadosTableAdapter.Fill(Me.ElectrodomesticosDataSet.Empleados)
                'muestra mensaje de que la modificación se realizo con exito.
                MsgBox("La modificacion ha sido exitosa", MsgBoxStyle.Information, "Exito")
                limpiarCampos()
                'habilita nuevamente el textbox DNI.
                TxtDNI.ReadOnly = False
                'mantiene seleccionada la fila que ha sido modificada.
                Me.EmpleadosDataGridView.Rows(seleccion).Selected = True
                'habilida boton agregar y limpiar.
                BAgregarEmpleado.Enabled = True

                BLimpiar.Enabled = True
                'desabilita boton editar y eliminar.
                BEditarEmpleado.Enabled = False
                BEliminarEmpleado.Enabled = False
            End If
        End If
        Me.EmpleadosDataGridView.CurrentRow.Selected = False
        'recorre el datagridview y cambia el color de la fila en caso que la columna(8) estado este en estado FALSE.
        For Each Row As DataGridViewRow In EmpleadosDataGridView.Rows

            If Row.Cells(8).Value = "false" Then
                Row.DefaultCellStyle.BackColor = Color.YellowGreen

            End If
        Next
    End Sub



    Private Sub BEliminarEmpleado_Click(sender As System.Object, e As System.EventArgs) Handles BEliminarEmpleado.Click
        'guarda en variables el contenido del datagridview de acuerdo a la selección realizada.
        Dim dniempleado = Me.EmpleadosDataGridView.CurrentRow.Cells(0).Value
        Dim nombre = Me.EmpleadosDataGridView.CurrentRow.Cells.Item(1).Value
        Dim apellido = Me.EmpleadosDataGridView.CurrentRow.Cells.Item(2).Value
        'verifica si el empleado que ha sido seleccionado figure como usuario del sistema.
        If Me.UsuariosTableAdapter.estadoUsuario(Me.ElectrodomesticosDataSet.Usuarios, dniempleado, True) Then

            'Pide confirmacon para dar de baja al empleado que ha sido seleccionado.
            ask = MsgBox("¿ Seguro que desea dar de baja al empleado " & apellido & " " & nombre & ", que figura como usuario del sistema? : ", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Question, "Confirmar Baja Empleado y de Usuario")
            'si la respuesta es si, realiza la baja de acuerdo a la selección.
            If MsgBoxResult.Yes = ask Then
                'realiza la baja como usuario del sistema.
                Me.UsuariosTableAdapter.bajaUsuario(False, dniempleado)
                Me.UsuariosTableAdapter.Fill(Me.ElectrodomesticosDataSet.Usuarios)
                'realiza la baja como empleado.
                Me.EmpleadosTableAdapter.bajaLogicaEmpleados(False, dniempleado)
                Me.EmpleadosTableAdapter.Fill(Me.ElectrodomesticosDataSet.Empleados)
                'muestra mensaje de exito de la baja.
                MsgBox("El empleado ha sido dado de baja como empleado y como Usuario del sistema", MsgBoxStyle.Exclamation, "Exito")
            End If
        Else
            'Pide confirmacon para dar de baja al empleado que ha sido seleccionado y que solo figura como empleado.
            ask = MsgBox("¿ Seguro que desea dar de baja al empleado : " & apellido & " " & nombre & " ?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Question, "Confirmar Baja Empleado")
            'si la respuesta es si, realiza la baja de acuerdo a la selección.
            If MsgBoxResult.Yes = ask Then
                'realiza la baja
                Me.EmpleadosTableAdapter.bajaLogicaEmpleados(False, dniempleado)
                Me.EmpleadosTableAdapter.Fill(Me.ElectrodomesticosDataSet.Empleados)
                'muestra mensaje de exito de la baja.
                MsgBox("El empleado ha sido dado de baja correctamente", MsgBoxStyle.Exclamation, "Exito: Baja Empleado")
            End If
        End If
        BEliminarEmpleado.Enabled = False
        Me.EmpleadosDataGridView.CurrentRow.Selected = False
        'recorre el datagridview y cambia el color de la fila en caso que la columna(8) estado este en estado FALSE.
        For Each Row As DataGridViewRow In EmpleadosDataGridView.Rows

            If Row.Cells(8).Value = "false" Then
                Row.DefaultCellStyle.BackColor = Color.YellowGreen

            End If

        Next
    End Sub

    Private Sub BLimpiar_Click(sender As System.Object, e As System.EventArgs) Handles BLimpiar.Click
        'verifica que los textbox contenga algo, antes de limpiarlos para evitar error en el funcionamiento.
        If (TxtDNI.TextLength <> 0) Or (TxtNombre.TextLength <> 0) Or (TxtApellido.TextLength <> 0) Or (TxtDireccion.TextLength <> 0) Or (TxtLocalidad.TextLength <> 0) Or (TxtTelefono.TextLength <> 0) Then
            limpiarCampos()
        Else

            MsgBox("No hay campos por borrar", MsgBoxStyle.Critical, "Campos vacios")
        End If
        'desactiva botones.
        TxtDNI.Enabled = True
        TxtDNI.ReadOnly = False
        BAgregarEmpleado.Enabled = True
        BEditarEmpleado.Enabled = False
        'actualiza el datagridview.
        Me.EmpleadosTableAdapter.Fill(Me.ElectrodomesticosDataSet.Empleados)
        Me.EmpleadosDataGridView.CurrentRow.Selected = False
        'recorre el datagridview y cambia el color de la fila en caso que la columna(8) estado este en estado FALSE.
        For Each Row As DataGridViewRow In EmpleadosDataGridView.Rows

            If Row.Cells(8).Value = "false" Then
                Row.DefaultCellStyle.BackColor = Color.YellowGreen

            End If

        Next
    End Sub

    Private Sub TDNIEmpleado_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TDNIEmpleado.KeyPress
        'validar para que en el textbox se ingrese solo numeros.
        validar2.ValidarSoloNumeros(e)
        'Permite buscar un DNI apretando la tecla enter.
        If e.KeyChar = Chr(13) Then
            If TDNIEmpleado.TextLength = 0 Then

                MsgBox("No ha ingresado ningun DNI a buscar. ", MsgBoxStyle.Critical, "Error")
            ElseIf Me.EmpleadosTableAdapter.buscarDNIEmpleado(Me.ElectrodomesticosDataSet.Empleados, TDNIEmpleado.Text) = False Then
                'Si el DNI no se encuentra en la tabla de cliente, muestra un mensaje. 
                MsgBox("No existe un cliente con ese DNI: " & TDNIEmpleado.Text & "", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "ERROR")
                'actualiza el datagridview.
                Me.EmpleadosTableAdapter.Fill(Me.ElectrodomesticosDataSet.Empleados)
            End If
            'limpia el textbox.
            TDNIEmpleado.Clear()

            Me.EmpleadosDataGridView.CurrentRow.Selected = False
            'recorre el datagridview y cambia el color de la fila en caso que la columna(8) estado este en estado FALSE.
            For Each Row As DataGridViewRow In EmpleadosDataGridView.Rows
                BEliminarEmpleado.Enabled = False
                If Row.Cells(8).Value = "false" Then
                    Row.DefaultCellStyle.BackColor = Color.YellowGreen

                End If

            Next
            TDNIEmpleado.Clear()
            e.Handled = True
            'Me.ClientesDataGridView.CurrentRow.Selected = False
        End If
    End Sub


    Private Sub EmpleadosDataGridView_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles EmpleadosDataGridView.CellClick
        BEditarEmpleado.Enabled = False
        'BLimpiar.Enabled = True
        'activa/desactiva botones de acuerdo al contenido del datagridview de la columna estado.
        If Me.EmpleadosDataGridView.CurrentRow.Cells.Item(8).Value = False Then
            BActivarEmpleado.Enabled = True

            BEliminarEmpleado.Enabled = False
            'BLimpiar.Enabled = False

        Else
            BEliminarEmpleado.Enabled = True
            'BLimpiar.BackColor = Color.Lavender
            BActivarEmpleado.Enabled = False



        End If
    End Sub


    Private Sub BActivarEmpleado_Click(sender As System.Object, e As System.EventArgs) Handles BActivarEmpleado.Click
        'guarda en variables el contenido del datagridview de acuerdo a la selección que ha sido realizada.
        Dim dni = Me.EmpleadosDataGridView.CurrentRow.Cells.Item(0).Value
        Dim nombre = Me.EmpleadosDataGridView.CurrentRow.Cells.Item(1).Value
        Dim apellido = Me.EmpleadosDataGridView.CurrentRow.Cells.Item(2).Value

        'pide confirmación para dar de alta el empleado que ha sido seleccionado y figura como dado de baja.
        ask = MsgBox("¿ Seguro que desea dar de alta al Empleado: " & apellido & " " & nombre & " ? ", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Question, "Confirmar Activación de Alta")

        'Si la respuesta es si, realiza el alta.
        If ask = MsgBoxResult.Yes Then

            Me.EmpleadosTableAdapter.bajaLogicaEmpleados(True, dni)
            'actualiza el datagridview.
            Me.EmpleadosTableAdapter.Fill(Me.ElectrodomesticosDataSet.Empleados)

            'muestra mensaje que el alta se realizo con exito.
            ask = MsgBox("El Empleado " & nombre & " " & apellido & " fue activado con éxito.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Information, "Alta Realizada")

        End If
        Me.EmpleadosDataGridView.CurrentRow.Selected = False
        BEliminarEmpleado.Enabled = False
        'recorre el datagridview y cambia el color de la fila en caso que la columna(8) estado este en estado FALSE.
        For Each Row As DataGridViewRow In EmpleadosDataGridView.Rows

            If Row.Cells(8).Value = "false" Then
                Row.DefaultCellStyle.BackColor = Color.YellowGreen

            End If

        Next
    End Sub

    Private Sub BVolver_Click(sender As System.Object, e As System.EventArgs) Handles BVolver.Click

        Dim formAdministrador As New MenuAdministrador
        Me.Hide()
        'abre el formulario MenuAdministrador.
        formAdministrador.Show()
        'cierra el formulario actual.
        Me.Close()

    End Sub

    Private Sub EmpleadosDataGridView_DoubleClick(sender As Object, e As System.EventArgs) Handles EmpleadosDataGridView.DoubleClick
        'guarda en una variable el contenido del datagridview de acuerdo con la selección realizada.
        seleccion = EmpleadosDataGridView.CurrentRow.Index
        'desactiva/activa botones.
        BEliminarEmpleado.Enabled = False
        BLimpiar.Enabled = True
        BAgregarEmpleado.Enabled = False
        BEditarEmpleado.Enabled = True

        'coloca en los textbox correspondientes el contenido del datagriview de acuerdo con la fila que ha sido seleccionada. 
        TxtDNI.Text = Me.EmpleadosDataGridView.CurrentRow.Cells.Item(0).Value.ToString()
        'no habilita el textbox DNI para editar.
        TxtDNI.ReadOnly = True
        TxtNombre.Text = Me.EmpleadosDataGridView.CurrentRow.Cells.Item(1).Value.ToString()
        TxtApellido.Text = Me.EmpleadosDataGridView.CurrentRow.Cells.Item(2).Value.ToString()
        TxtDireccion.Text = Me.EmpleadosDataGridView.CurrentRow.Cells.Item(3).Value.ToString()
        CBTipoEmpleado.Text = Me.EmpleadosDataGridView.CurrentRow.Cells.Item(4).Value.ToString()
        TxtLocalidad.Text = Me.EmpleadosDataGridView.CurrentRow.Cells.Item(5).Value.ToString()
        CBProvincia.Text = Me.EmpleadosDataGridView.CurrentRow.Cells.Item(6).Value.ToString()
        TxtTelefono.Text = Me.EmpleadosDataGridView.CurrentRow.Cells.Item(7).Value.ToString()

    End Sub

    Private Sub EmpleadosDataGridView_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles EmpleadosDataGridView.CellContentClick

    End Sub

    Private Sub EmpleadosDataGridView_CurrentCellDirtyStateChanged(sender As Object, e As System.EventArgs) Handles EmpleadosDataGridView.CurrentCellDirtyStateChanged

    End Sub

    Private Sub TDNIEmpleado_TextChanged(sender As System.Object, e As System.EventArgs) Handles TDNIEmpleado.TextChanged

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.EmpleadosTableAdapter.Fill(Me.ElectrodomesticosDataSet.Empleados)
        Me.EmpleadosDataGridView.CurrentRow.Selected = False
        For Each Row As DataGridViewRow In EmpleadosDataGridView.Rows

            If Row.Cells(8).Value = "false" Then
                Row.DefaultCellStyle.BackColor = Color.YellowGreen

            End If

        Next
    End Sub
End Class