Public Class ABMUsuario

    Dim ask As MsgBoxResult
    Dim seleccion As Integer

    Private Sub ABMUsuario_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        Me.EmpleadosTableAdapter.empleadosActivos(Me.ElectrodomesticosDataSet.Empleados, True, 1)
        'TODO: esta línea de código carga datos en la tabla 'ElectrodomesticosDataSet.TipoUsuario' Puede moverla o quitarla según sea necesario.
        Me.TipoUsuarioTableAdapter.Fill(Me.ElectrodomesticosDataSet.TipoUsuario)
        'TODO: esta línea de código carga datos en la tabla 'ElectrodomesticosDataSet.Usuarios' Puede moverla o quitarla según sea necesario.
        Me.UsuariosTableAdapter.Fill(Me.ElectrodomesticosDataSet.Usuarios)

        'Permite que el datagriview no tenga seleccionado ninguna fila
        Me.UsuariosDataGridView.CurrentRow.Selected = False
        Me.EmpleadosDataGridView.CurrentRow.Selected = False

        'desactiva los botones.
        BEliminar.Enabled = False
        BActivar.Enabled = False
        BEditar.Enabled = False

        'desactiva los textbox para que no se pueda ingresar texto.
        txtApellido.Enabled = False
        TxtNombre.Enabled = False
        txtDNI.Enabled = False
        txtUsuarios.Enabled = False
        txtClave.Enabled = False
        CBTipoUsuario.Enabled = False

        'recorre el datagridview y cambia el color en caso que el estado sea igual a FALSE.
        For Each Row As DataGridViewRow In UsuariosDataGridView.Rows

            If Row.Cells(6).Value = "false" Then
                Row.DefaultCellStyle.BackColor = Color.YellowGreen

            End If

        Next
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub UsuariosDataGridView_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles UsuariosDataGridView.CellClick

        'desactiva el boton editar.
        BEditar.Enabled = False

        'activa y desactiva botones segun el estado.
        If Me.UsuariosDataGridView.CurrentRow.Cells.Item(6).Value = False Then
            BActivar.Enabled = True
            ' BEditar.Enabled = True
            BEliminar.Enabled = False

        Else
            BEliminar.Enabled = True

            BActivar.Enabled = False
            'BEditar.Enabled = True



        End If
    End Sub

  

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Agregar.Click

        'guarda en una variable el contenido de los textbox.
        Dim usuario = txtUsuarios.Text
        Dim dni_empleado = txtDNI.Text
        Dim tipoUsuario = CBTipo.SelectedValue

        'verifica que los campos no esten vacios, envia un msj de error en caso de ser asi.
        If txtUsuarios.TextLength = 0 Or txtClave.TextLength = 0 Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.Critical, "Campos vacios")

            'verifica que el dni ya no se encuentre registrado como usuario.
        ElseIf UsuariosTableAdapter.buscarDNI(Me.ElectrodomesticosDataSet.Usuarios, dni_empleado) Then
            MsgBox("El DNI: " & dni_empleado & " ya esta registrado como usuario del sistema, ingrese otro DNI.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Error")
            'limpia los textbox.
            txtApellido.Clear()
            TxtNombre.Clear()
            txtDNI.Clear()
            txtUsuarios.Clear()
            txtClave.Clear()
            'actualiza el datagridview.
            Me.UsuariosTableAdapter.Fill(Me.ElectrodomesticosDataSet.Usuarios)

        Else
            'guarda en una variable los datos(apellido y nombre) del datagridview de empleados.
            Dim apellido = Me.EmpleadosDataGridView.CurrentRow.Cells.Item(2).Value
            Dim nombre = Me.EmpleadosDataGridView.CurrentRow.Cells.Item(1).Value
            'pide mensaje de confirmacion.
            ask = MsgBox("Seguro que desea agregar al empleado : " & apellido & " " & nombre & " como usuario?", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Question, "Confirmar")

            If MsgBoxResult.Yes = ask Then

                'agrega el nuevo usuario.
                Me.UsuariosTableAdapter.agregarUsuario(dni_empleado, txtUsuarios.Text, txtClave.Text, tipoUsuario, True)
                'actualiza el datagridview.
                Me.UsuariosTableAdapter.Fill(Me.ElectrodomesticosDataSet.Usuarios)
                'muestra mensaje de exito.
                MsgBox("El empleado " & apellido & " " & nombre & " se ha agregado correctamente como usuario del sistema. ", MsgBoxStyle.Information, "EXITO")
                For Each Row As DataGridViewRow In UsuariosDataGridView.Rows

                    If Row.Cells(0).Value = dni_empleado Then

                        Row.Selected = True
                    End If


                Next
                'limpia los textbox.
                txtApellido.Clear()
                TxtNombre.Clear()
                txtDNI.Clear()
                txtUsuarios.Clear()
                txtClave.Clear()
            End If

        End If

        'permite que los datagriview no tengan ninguna fila seleccionada.
        Me.UsuariosDataGridView.CurrentRow.Selected = False
        Me.EmpleadosDataGridView.CurrentRow.Selected = False

        'desactiva los botones.
        BEliminar.Enabled = False
        BActivar.Enabled = False
        BEditar.Enabled = False
        For Each Row As DataGridViewRow In UsuariosDataGridView.Rows

            If Row.Cells(6).Value = "false" Then
                Row.DefaultCellStyle.BackColor = Color.YellowGreen

            End If

        Next
    End Sub


    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles BEliminar.Click

        'guarda en una variable los datos del datagridview.
        Dim dni = Me.UsuariosDataGridView.CurrentRow.Cells.Item(0).Value
        Dim apellido = Me.UsuariosDataGridView.CurrentRow.Cells.Item(2).Value
        Dim nombre = Me.UsuariosDataGridView.CurrentRow.Cells.Item(1).Value

        'pide confirmacion de baja.
        ask = MsgBox("¿ Seguro que desea dar de baja al usuario: " & apellido & " " & nombre & " ? ", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Question, "Confirmar Baja")


        If MsgBoxResult.Yes = ask Then

            'guarda en una variable el dni del cliente.
            Dim dni_cliente = Me.UsuariosDataGridView.CurrentRow.Cells.Item(0).Value
            'da la baja del usuario.
            Me.UsuariosTableAdapter.bajaUsuario(False, dni_cliente)
            'Me.UsuariosTableAdapter.Fill(Me.ElectrodomesticosDataSet.Usuarios)
            'actualiza el datagridview.
            Me.UsuariosTableAdapter.Fill(Me.ElectrodomesticosDataSet.Usuarios)
            MsgBox("Usuario dado de baja correctamente", MsgBoxStyle.Exclamation, "Exito")

            'limpia los textbox.
            txtUsuarios.Clear()
            txtClave.Clear()
        End If

        'permite que los datagriview no tengan ninguna fila seleccionada.
        Me.UsuariosDataGridView.CurrentRow.Selected = False
        Me.EmpleadosDataGridView.CurrentRow.Selected = False

        'desactiva los botones.
        BEliminar.Enabled = False
        BActivar.Enabled = False
        BEditar.Enabled = False
        For Each Row As DataGridViewRow In UsuariosDataGridView.Rows

            If Row.Cells(6).Value = "false" Then
                Row.DefaultCellStyle.BackColor = Color.YellowGreen

            End If

        Next
    End Sub

    Private Sub BVolver_Click(sender As System.Object, e As System.EventArgs) Handles BVolver.Click
        Dim formGerente As New MenuSupervisor
        Me.Visible = False
        Me.Hide()
        'abre el formulario del menuSupervisor.
        formGerente.Show()
        'cierra el formulario actual
        Me.Close()
    End Sub

    Private Sub BActivar_Click(sender As System.Object, e As System.EventArgs) Handles BActivar.Click

        'guarda en variable los datos dni, apellido y nombre del datagridview.
        Dim dni = Me.UsuariosDataGridView.CurrentRow.Cells.Item(0).Value
        Dim apellido = Me.UsuariosDataGridView.CurrentRow.Cells.Item(2).Value
        Dim nombre = Me.UsuariosDataGridView.CurrentRow.Cells.Item(1).Value

        ask = MsgBox("¿ Seguro que desea dar de alta al usuario: " & apellido & " " & nombre & " ? ", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Question, "Confirmar Alta")


        If MsgBoxResult.Yes = ask Then

            'verifica si el estado del empleado (que figura como usuario) es activo segun el dni, si es activo guarda en una variable el dni del cliente
            If Me.EmpleadosTableAdapter.verificarEstado(dni) = True Then
                Dim dni_cliente = Me.UsuariosDataGridView.CurrentRow.Cells.Item(0).Value
                'da la baja del empleado como usuario
                Me.UsuariosTableAdapter.bajaUsuario(True, dni_cliente)
                'Me.UsuariosTableAdapter.Fill(Me.ElectrodomesticosDataSet.Usuarios)
                'actualiza el datagridview.
                Me.UsuariosTableAdapter.Fill(Me.ElectrodomesticosDataSet.Usuarios)
                MsgBox("Usuario dado de alta correctamente", MsgBoxStyle.Exclamation, "Exito")
            Else
                MsgBox("Error, el usuario seleccionado ya no figura como un empleado activo", MsgBoxStyle.Critical, "ERROR")
            End If
        End If

        'permite que los datagriview no tengan ninguna fila seleccionada.
        Me.UsuariosDataGridView.CurrentRow.Selected = False
        Me.EmpleadosDataGridView.CurrentRow.Selected = False

        'desactiva los botones.
        BEliminar.Enabled = False
        BActivar.Enabled = False
        BEditar.Enabled = False
        For Each Row As DataGridViewRow In UsuariosDataGridView.Rows

            If Row.Cells(6).Value = "false" Then
                Row.DefaultCellStyle.BackColor = Color.YellowGreen

            End If

        Next
    End Sub

    Private Sub BEditar_Click(sender As System.Object, e As System.EventArgs) Handles BEditar.Click

        'verifica que los campos no se encuentren vacios.
        If txtUsuarios.TextLength = 0 And txtClave.TextLength = 0 Then
            MsgBox("Debe completar los campos para modificar.", MsgBoxStyle.Critical, "Campo vacios")
        Else

            'guarda en una variable los datos necesarios
            Dim dni = Me.UsuariosDataGridView.CurrentRow.Cells.Item(0).Value
            Dim apellido = Me.UsuariosDataGridView.CurrentRow.Cells.Item(2).Value
            Dim nombre = Me.UsuariosDataGridView.CurrentRow.Cells.Item(1).Value
            Dim tipoUsuario = CBTipo.SelectedValue
            Dim estado = Me.UsuariosDataGridView.CurrentRow.Cells.Item(6).Value

            ask = MsgBox("¿ Seguro que desea modificar al usuario: " & apellido & " " & nombre & " ? ", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Question, "Confirmar Modificación")

            'edita los campos
            Me.UsuariosTableAdapter.editarUsuario(txtUsuarios.Text, txtClave.Text, tipoUsuario, estado, dni)
            'actualiza el datagridview.
            Me.UsuariosTableAdapter.Fill(Me.ElectrodomesticosDataSet.Usuarios)
            Me.UsuariosDataGridView.Rows(seleccion).Selected = True
            'limpia los textbox.

            txtDNI.Clear()
            txtApellido.Clear()
            TxtNombre.Clear()
            txtUsuarios.Clear()
            txtClave.Clear()
            Agregar.Enabled = True
            txtDNI.ReadOnly = False
            txtApellido.ReadOnly = False
            TxtNombre.ReadOnly = False
        End If
        'permite que los datagriview no tengan ninguna fila seleccionada.
        Me.UsuariosDataGridView.CurrentRow.Selected = False
        Me.EmpleadosDataGridView.CurrentRow.Selected = False
        'desactiva los botones.
        BEliminar.Enabled = False
        BActivar.Enabled = False
        BEditar.Enabled = False
        For Each Row As DataGridViewRow In UsuariosDataGridView.Rows

            If Row.Cells(6).Value = "false" Then
                Row.DefaultCellStyle.BackColor = Color.YellowGreen

            End If

        Next

    End Sub

    

    Private Sub TBuscar_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
        'validad solo numeros
        validar2.ValidarSoloNumeros(e)
    End Sub

    Private Sub TBuscar_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub


    Private Sub txtApellido_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtApellido.TextChanged

    End Sub

    Private Sub txtUsuarios_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtUsuarios.KeyPress
        'validar solo numeros y letras
        validar2.validarNumerosYLetras(e)
    End Sub

    Private Sub txtUsuarios_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtUsuarios.TextChanged

    End Sub

    Private Sub txtClave_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtClave.KeyPress
        'validar solo numeros y letras.
        validar2.validarNumerosYLetras(e)
    End Sub

    Private Sub txtClave_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtClave.TextChanged

    End Sub

    Private Sub txtApellidoBuscar_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtApellidoBuscar.KeyPress
        'validar numeros y letras.
        validar2.validarNumerosYLetras(e)
    End Sub

    Private Sub txtApellidoBuscar_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtApellidoBuscar.TextChanged
        'busqueda iterativa por apellido de empleado
        Me.EmpleadosTableAdapter.busquedaApellidoEmpleadoActivo(Me.ElectrodomesticosDataSet.Empleados, txtApellidoBuscar.Text, True, 1)
        'permite que el datagridview no tenga ninguna fila seleccionada.
        Me.UsuariosDataGridView.CurrentRow.Selected = False

    End Sub

    Private Sub UsuariosDataGridView_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles UsuariosDataGridView.CellContentClick

    End Sub

    Private Sub UsuariosDataGridView_DoubleClick(sender As Object, e As System.EventArgs) Handles UsuariosDataGridView.DoubleClick
        'guarda en una variable el index del datagridview.
        seleccion = UsuariosDataGridView.CurrentRow.Index

        'activa/ desactiva botones.
        Agregar.Enabled = False

        BEditar.Enabled = True
        BEliminar.Enabled = False
        BActivar.Enabled = False
        txtUsuarios.Enabled = True
        txtClave.Enabled = True

        'asigna a los textbox el contenido del datagridview.
        txtDNI.Text = Me.UsuariosDataGridView.CurrentRow.Cells.Item(0).Value.ToString()

        TxtNombre.Text = Me.UsuariosDataGridView.CurrentRow.Cells.Item(1).Value.ToString()

        txtApellido.Text = Me.UsuariosDataGridView.CurrentRow.Cells.Item(2).Value.ToString()

        txtUsuarios.Text = Me.UsuariosDataGridView.CurrentRow.Cells.Item(3).Value.ToString()
        txtClave.Text = Me.UsuariosDataGridView.CurrentRow.Cells.Item(4).Value.ToString()
        CBTipo.Text = Me.UsuariosDataGridView.CurrentRow.Cells.Item(5).Value.ToString()
    End Sub

    Private Sub EmpleadosDataGridView_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles EmpleadosDataGridView.CellClick
        Agregar.Enabled = True
        BEditar.Enabled = False
        BActivar.Enabled = False
        BEliminar.Enabled = False
        txtUsuarios.Clear()
        txtClave.Clear()
        txtUsuarios.Enabled = True
        txtClave.Enabled = True
        txtDNI.Text = Me.EmpleadosDataGridView.CurrentRow.Cells.Item(0).Value.ToString()

        TxtNombre.Text = Me.EmpleadosDataGridView.CurrentRow.Cells.Item(1).Value.ToString()

        txtApellido.Text = Me.EmpleadosDataGridView.CurrentRow.Cells.Item(2).Value.ToString()

    End Sub

    Private Sub EmpleadosDataGridView_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles EmpleadosDataGridView.CellContentClick

    End Sub
End Class