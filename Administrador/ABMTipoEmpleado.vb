Public Class ABMTipoEmpleado
    Dim ask As MsgBoxResult
    Dim seleccion As Integer

    Private Sub ABMTipoEmpleado_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ElectrodomesticosDataSet.TipoEmpleado' Puede moverla o quitarla según sea necesario.
        Me.TipoEmpleadoTableAdapter.Fill(Me.ElectrodomesticosDataSet.TipoEmpleado)
        'desactiva botones.
        BActivar.Enabled = False
        BEliminar.Enabled = False
        'permite que ninguna fila del datagridview se encuentre seleccionada.
        Me.TipoEmpleadoDataGridView.CurrentRow.Selected = False
        'recorre el datagridview y cambia el color de la fila en caso que el estado sea FALSE
        For Each Row As DataGridViewRow In TipoEmpleadoDataGridView.Rows

            If Row.Cells(1).Value = "false" Then
                Row.DefaultCellStyle.BackColor = Color.YellowGreen

            End If

        Next
    End Sub

    Private Sub TxtTipo_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTipo.KeyPress
        'validacion para que ingrese solo letras.
        validar2.ValidarSoloLetras(e)
    End Sub

    Private Sub TxtTipo_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtTipo.TextChanged

    End Sub

    Private Sub TxtNombreEditar_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNombreEditar.KeyPress
        'validacion para que ingrese solo letras.
        validar2.ValidarSoloLetras(e)
    End Sub

    Private Sub TxtNombreEditar_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtNombreEditar.TextChanged

    End Sub

    Private Sub TxtBuscarTipo_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBuscarTipo.KeyPress
        'validacion para que ingrese solo letras.
        validar2.ValidarSoloLetras(e)
    End Sub

    Private Sub TxtBuscarTipo_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtBuscarTipo.TextChanged
        'busqeda interactiva de nombre de tipo de empleado.
        Me.TipoEmpleadoTableAdapter.busquedaIterativaTipo(Me.ElectrodomesticosDataSet.TipoEmpleado, TxtBuscarTipo.Text)
        'desactiva botones
        BActivar.Enabled = False
        BEliminar.Enabled = False
        'permite cambiar el color de una fila del datagridview dependiendo del estado de la misma.
        For Each Row As DataGridViewRow In TipoEmpleadoDataGridView.Rows

            If Row.Cells(1).Value = "false" Then
                Row.DefaultCellStyle.BackColor = Color.YellowGreen

            End If

        Next
    End Sub

    Private Sub BAgregar_Click(sender As System.Object, e As System.EventArgs) Handles BAgregar.Click
        'verifica que el campo nombre no se encuentre vacio, muestra un mensaje de error de ser asi.
        If (TxtTipo.TextLength = 0) Then
            ask = MsgBox("No se ha ingresado ningun tipo de empleado a agregar.", MsgBoxStyle.Critical, "ERROR: CAMPOS VACIOS")
        Else
            If Me.TipoEmpleadoTableAdapter.busquedaPorNombre(Me.ElectrodomesticosDataSet.TipoEmpleado, TxtTipo.Text) Then
                'mando mensaje de error, ya existe el mismo nombre dado de alta
                ask = MsgBox("El tipo de Empleado: " & TxtTipo.Text & " ya existe.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "ERROR: Tipo de Empleado existente")
                'actualiza el datagriview.
                Me.TipoEmpleadoTableAdapter.Fill(Me.ElectrodomesticosDataSet.TipoEmpleado)
                'limpia el textbox.
                TxtTipo.Clear()
            Else
                'pide confirmacion para agregar el tipo de empleado.
                ask = MsgBox("Se agregara el tipo de Empleado: " & TxtTipo.Text & ", confirmar para seguir.", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Question, "Confirmar Agregar Tipo Empleado")
                'si la respuesta es si, agrega el tipo de empleado.
                If MsgBoxResult.Yes = ask Then
                    'guarda en una variable el contenido del textbox.
                    Dim nombre_tipo = TxtTipo.Text
                    'asigna true a la variable estado.
                    Dim estado = True
                    'agrega el nuevo tipo de empleado.
                    Me.TipoEmpleadoTableAdapter.agregarTipo(nombre_tipo, estado)
                    'actualiza el datagridview.
                    Me.TipoEmpleadoTableAdapter.Fill(Me.ElectrodomesticosDataSet.TipoEmpleado)
                    'mensaje de que el tipo de empleado fue agregado correctamente.
                    MsgBox("El tipo de Empleado: " & nombre_tipo & " ha sido agregado correctamente.", MsgBoxStyle.Information, "EXITO")
                    'recorre el datagridview para dejar seleccionada la fila que recien se agrego.
                    For Each Row As DataGridViewRow In TipoEmpleadoDataGridView.Rows

                        If Row.Cells(0).Value = nombre_tipo Then

                            Row.Selected = True
                        End If


                    Next
                    'limpia el campo tipo.
                    TxtTipo.Clear()

                End If
            End If
        End If
        'desactiva botones.
        BActivar.Enabled = False
        BEliminar.Enabled = False
        'permite que ninguna fila del datagridview se encuentre seleccionada.
        Me.TipoEmpleadoDataGridView.CurrentRow.Selected = False
        'recorre el datagridview y cambia de color la fila en caso que el estado sea igual a false.
        For Each Row As DataGridViewRow In TipoEmpleadoDataGridView.Rows

            If Row.Cells(1).Value = "false" Then
                Row.DefaultCellStyle.BackColor = Color.YellowGreen

            End If

        Next
    End Sub

    Private Sub TipoEmpleadoDataGridView_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TipoEmpleadoDataGridView.CellClick
        'activa/desactiva botones segun sea el estado.
        If Me.TipoEmpleadoDataGridView.CurrentRow.Cells.Item(1).Value = False Then
            BActivar.Enabled = True
            BEliminar.Enabled = False

        Else
            BActivar.Enabled = False

            BEliminar.Enabled = True

        End If
    End Sub


    Private Sub TipoEmpleadoDataGridView_DoubleClick(sender As Object, e As System.EventArgs) Handles TipoEmpleadoDataGridView.DoubleClick
        'guarda en una variable el contenido de la seleccion hecha.
        seleccion = TipoEmpleadoDataGridView.CurrentRow.Index
        'asigna al campo nombreEditar el contenido de la seleccion que se realizo.
        TxtNombreEditar.Text = Me.TipoEmpleadoDataGridView.CurrentRow.Cells.Item(0).Value
        'desactiva botones.
        BActivar.Enabled = False
        BEliminar.Enabled = False

    End Sub

    Private Sub Bguardar_Click(sender As System.Object, e As System.EventArgs) Handles Bguardar.Click
        'verifica que el campo nombreEditar no se encuentre vacio, y muestra un mensaje en caso de que sea asi.
        If TxtNombreEditar.TextLength = 0 Then
            MsgBox("Debe completar el campo para modificar.", MsgBoxStyle.Critical, "ERROR: Campos vacios")
        Else
            'guarda en una variable el contenido de la seleccion realizada.
            Dim nombreOriginal = Me.TipoEmpleadoDataGridView.CurrentRow.Cells.Item(0).Value
            'pide confirmacion para realizar la modificacion
            ask = MsgBox("¿ Seguro que desea modificar el tipo de Empleado: " & nombreOriginal & " ? ", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Question, "Confirmar Modificación de Tipo de Empleado")
            'si la respuesta es si, realiza la modificacion
            If ask = MsgBoxResult.Yes Then
                'verifica que el nombre por el cual se realizara la modificacion ya no se encuentre registrado.
                If Me.TipoEmpleadoTableAdapter.busquedaPorNombre(Me.ElectrodomesticosDataSet.TipoEmpleado, TxtNombreEditar.Text) Then
                    MsgBox("Ya existe un tipo de empleado con ese nombre.", MsgBoxStyle.Critical, "Error: Tipo de Empleado existente")
                    'actualiza el datagridview.
                    Me.TipoEmpleadoTableAdapter.Fill(Me.ElectrodomesticosDataSet.TipoEmpleado)
                    'limpia el campo nombreEditar.
                    TxtNombreEditar.Clear()
                Else
                    'realiza la modificacion.
                    Me.TipoEmpleadoTableAdapter.modificarTipo(TxtNombreEditar.Text, nombreOriginal)
                    'actualiza el datagridview.
                    Me.TipoEmpleadoTableAdapter.Fill(Me.ElectrodomesticosDataSet.TipoEmpleado)
                    'muestra mensaje de exito.
                    MsgBox("El tipo de Empleado: " & nombreOriginal & " ha sido modificado con exito", MsgBoxStyle.Information, "EXITO")
                    'limpia el campo nombreEditar.
                    TxtNombreEditar.Clear()
                    'mantiene seleccionada la fila que se modifico.
                    Me.TipoEmpleadoDataGridView.Rows(seleccion).Selected = True
                End If
            End If
        End If
        'desactiva botones.
        BActivar.Enabled = False
        BEliminar.Enabled = False
        'permite que el datagridview no tenga ninguna fila seleccionada.
        Me.TipoEmpleadoDataGridView.CurrentRow.Selected = False
        'recorre el datagridview y cambia de color en caso que el estado sea igual a false.
        For Each Row As DataGridViewRow In TipoEmpleadoDataGridView.Rows

            If Row.Cells(1).Value = "false" Then
                Row.DefaultCellStyle.BackColor = Color.YellowGreen

            End If

        Next
    End Sub

    Private Sub BActivar_Click(sender As System.Object, e As System.EventArgs) Handles BActivar.Click
        'guarda en una variable el contenido de la seleccion realizada en el datagridview.
        Dim nombre = Me.TipoEmpleadoDataGridView.CurrentRow.Cells.Item(0).Value
        'pide confirmacion para realizar el alta de tipo de empleado.
        ask = MsgBox("¿ Seguro que desea dar de alta el tipo de empleado: " & nombre & " ? ", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Question, "Confirmar agregar Tipo de Empleado")
        'si la respuesta es si, realiza el alta.
        If ask = MsgBoxResult.Yes Then
            'realiza el alta de tipo de empleados.
            Me.TipoEmpleadoTableAdapter.bajaTipo(True, nombre)
            'actualiza el datagridview.
            Me.TipoEmpleadoTableAdapter.Fill(Me.ElectrodomesticosDataSet.TipoEmpleado)
            MsgBox("El tipo de empleado: " & nombre & " ha sido dado de alta correctamente. ", MsgBoxStyle.Information, "EXITO")
        End If
        'desactiva botones.
        BActivar.Enabled = False
        BEliminar.Enabled = False
        'permite que el datagridview no tenga ninguna fila seleccionada.
        Me.TipoEmpleadoDataGridView.CurrentRow.Selected = False
        'recorre el datagridview y cambia el color de las filas dependiendo del estado de la misma.
        For Each Row As DataGridViewRow In TipoEmpleadoDataGridView.Rows

            If Row.Cells(1).Value = "false" Then
                Row.DefaultCellStyle.BackColor = Color.YellowGreen

            End If

        Next
    End Sub

    Private Sub BEliminar_Click(sender As System.Object, e As System.EventArgs) Handles BEliminar.Click
        'guarda en una variable el contenido de la seleccion que se ha realizado en el datagridview.
        Dim tipo = Me.TipoEmpleadoDataGridView.CurrentRow.Cells.Item(0).Value
        'pide confirmacion para realizar la baja.
        ask = MsgBox("Se dara de baja el tipo de empleado: " & tipo & ", confirmar para seguir.", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Question, "Confirmar Baja Tipo de Empleado")
        'si la respuesta es si, realiza la baja.
        If MsgBoxResult.Yes = ask Then
            'realiza la baja.
            Me.TipoEmpleadoTableAdapter.bajaTipo(False, tipo)
            'actualiza el datagridview.
            Me.TipoEmpleadoTableAdapter.Fill(Me.ElectrodomesticosDataSet.TipoEmpleado)
            MsgBox("El tipo de Empleado: " & tipo & " ha sido dado de baja correctamente.", MsgBoxStyle.Information, "EXITO")
        End If
        'desactiva botones.
        BActivar.Enabled = False
        BEliminar.Enabled = False
        'permite que el datagridview no tenga ninguna fila seleccionada.
        Me.TipoEmpleadoDataGridView.CurrentRow.Selected = False
        'recorre el datagridview y cambia el color de la fila dependiendo del estado de la misma.
        For Each Row As DataGridViewRow In TipoEmpleadoDataGridView.Rows

            If Row.Cells(1).Value = "false" Then
                Row.DefaultCellStyle.BackColor = Color.YellowGreen

            End If

        Next
    End Sub

    Private Sub BVolver_Click(sender As System.Object, e As System.EventArgs) Handles BVolver.Click
        Dim formAdministrador As New MenuAdministrador
        Me.Hide()
        'abre el formulario de menuAdmisnitrador.
        formAdministrador.Show()
        'cierra el formulario actual.
        Me.Close()
    End Sub
End Class