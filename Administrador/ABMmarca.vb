Public Class ABMmarca
    Dim seleccion As Integer
    Dim ask As MsgBoxResult

    Private Sub BAgregar_Click(sender As System.Object, e As System.EventArgs) Handles BAgregar.Click
        'Verifica que el textbox este vacio y en caso que lo este muestra un mensaje.
        If (TxtMarca.TextLength = 0) Then

            ask = MsgBox("No se ha ingresado ninguna marca a agregar", MsgBoxStyle.Critical, "Campo Vacio")
        Else
            'Busca si la marca ingresada se encuentra en la tabla de marca.
            If Me.MarcaTableAdapter.busquedaNombre(Me.ElectrodomesticosDataSet.Marca, TxtMarca.Text) Then
                'mando mensaje de error, ya existe el mismo nombre dado de alta.
                ask = MsgBox("La Marca: " & TxtMarca.Text & " ya existe.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "ERROR: Marca existente")

                'actualiza el datagridview.
                Me.MarcaTableAdapter.Fill(Me.ElectrodomesticosDataSet.Marca)
                'Limpia el textbox
                TxtMarca.Clear()
            Else
                'Muestra un mensaje de confirmación antes de agregar la nueva marca.
                ask = MsgBox("Se agregara la marca: " & TxtMarca.Text & ", confirmar para seguir.", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Question, "Confirmar Agregar Marca")
                'Si la confirmación es si agrega a la tabla de marcas.
                If MsgBoxResult.Yes = ask Then
                    'Se guarda en una variable el contenido del textbox.
                    Dim nombre_marca = TxtMarca.Text
                    'Asigna true a la variable estado.
                    Dim estado = True
                    'Agrega la marca ingresada en la tabla de marca.
                    Me.MarcaTableAdapter.agregarMarcas(nombre_marca, estado)
                    'Actualiza el datagridview.
                    Me.MarcaTableAdapter.Fill(Me.ElectrodomesticosDataSet.Marca)
                    'recorre el datagridview y deja seleccionada la fila recien agregada.
                    For Each Row As DataGridViewRow In MarcaDataGridView.Rows

                        If Row.Cells(0).Value = nombre_marca Then

                            Row.Selected = True
                        End If


                    Next
                    'limpia el textbox
                    TxtMarca.Clear()

                End If
            End If
        End If
        'desactiva botones
        BEliminar.Enabled = False
        BActivar.Enabled = False
        Me.MarcaDataGridView.CurrentRow.Selected = False
        'recorre el datagridview y cambia el color de la fila en casa que la columna(1) estado este en estado FALSE.
        For Each Row As DataGridViewRow In MarcaDataGridView.Rows

            If Row.Cells(1).Value = "false" Then
                Row.DefaultCellStyle.BackColor = Color.YellowGreen

            End If

        Next
    End Sub
  

    Private Sub TxtMarca_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtMarca.KeyPress
        'validación para agregar solo letras
        validar2.ValidarSoloLetras(e)
    End Sub

    Private Sub TxtMarca_LostFocus(sender As Object, e As System.EventArgs) Handles TxtMarca.LostFocus
        'validacion para que coloque la primer letra de cada palabra en mayuscula.
        TxtMarca.Text = validar1.PrimeraLetraEnMayuscula(TxtMarca.Text)
    End Sub

    Private Sub TxtMarca_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtMarca.TextChanged

    End Sub

    Private Sub TxtNombreMarca_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNombreMarca.KeyPress
        'validación para agregar solo letras
        validar2.ValidarSoloLetras(e)
    End Sub

    Private Sub TxtNombreMarca_LostFocus(sender As Object, e As System.EventArgs) Handles TxtNombreMarca.LostFocus
        'validacion para que coloque la primer letra de cada palabra en mayuscula.
        TxtNombreMarca.Text = validar1.PrimeraLetraEnMayuscula(TxtNombreMarca.Text)
    End Sub

    Private Sub TxtNombreMarca_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtNombreMarca.TextChanged
        'Busqueda de marca de manera interactiva
        Me.MarcaTableAdapter.busquedaIterativaMarca(Me.ElectrodomesticosDataSet.Marca, TxtNombreMarca.Text)
        BEliminar.Enabled = False
        BActivar.Enabled = False
        'recorre el datagridview y cambia el color de la fila en caso que la columna(1) estado este en estado FALSE.
        For Each Row As DataGridViewRow In MarcaDataGridView.Rows

            If Row.Cells(1).Value = "false" Then
                Row.DefaultCellStyle.BackColor = Color.YellowGreen

            End If

        Next
    End Sub



    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub TxtEstado_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs)
        'validación para agregar solo letras
        validar2.ValidarSoloLetras(e)
    End Sub

    Private Sub TxtEstado_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub MarcaDataGridView_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MarcaDataGridView.CellClick

        'desactiva/activa botones de acuerdo al contenido del datagridview.
        If Me.MarcaDataGridView.CurrentRow.Cells.Item(1).Value = False Then
            BActivar.Enabled = True
            BEliminar.Enabled = False

        Else
            BActivar.Enabled = False

            BEliminar.Enabled = True

        End If
    End Sub

    Private Sub MarcaDataGridView_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MarcaDataGridView.CellContentClick

    End Sub

    Private Sub ABMmarca_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.MarcaTableAdapter.Fill(Me.ElectrodomesticosDataSet.Marca)
        'permite que el datagridview no tengo ninguna fila seleccionada.
        Me.MarcaDataGridView.CurrentRow.Selected = False
        'desactiva los botones.
        BActivar.Enabled = False

        BEliminar.Enabled = False
        'recorre el datagridview y cambia el color de la fila en casa que la columna(1) estado este en estado FALSE.
        For Each Row As DataGridViewRow In MarcaDataGridView.Rows

            If Row.Cells(1).Value = "false" Then
                Row.DefaultCellStyle.BackColor = Color.YellowGreen

            End If

        Next
    End Sub

    Private Sub BBuscarMarca_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub BVolver_Click(sender As System.Object, e As System.EventArgs) Handles BVolver.Click
        Dim formAdministrador As New MenuAdministrador
        Me.Hide()
        'abre el formulario de menuAdministrador.
        formAdministrador.Show()
        'cierra el formulario actual
        Me.Close()
    End Sub

    Private Sub BEliminar_Click(sender As System.Object, e As System.EventArgs) Handles BEliminar.Click
        'guarda en una variable la fila/columna del datagridview de acuerdo a la seleccion realizada.
        Dim marca = Me.MarcaDataGridView.CurrentRow.Cells.Item(0).Value
        'Pide confirmacion de baja .
        ask = MsgBox("Se dara de baja la marca: " & marca & ", confirmar para seguir.", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Question, "Confirmar Baja de Marca")
        'Si la respuesta es si, realiza la baja.
        If MsgBoxResult.Yes = ask Then

            Me.MarcaTableAdapter.darDeBajaMarca(False, marca)
            'actualiza el datagridview.
            Me.MarcaTableAdapter.Fill(Me.ElectrodomesticosDataSet.Marca)

        End If
        'desactiva botones.
        BEliminar.Enabled = False
        BActivar.Enabled = False
        Me.MarcaDataGridView.CurrentRow.Selected = False
        'recorre el datagridview y cambia el color de la fila en casa que la columna(1) estado este en estado FALSE.
        For Each Row As DataGridViewRow In MarcaDataGridView.Rows

            If Row.Cells(1).Value = "false" Then
                Row.DefaultCellStyle.BackColor = Color.YellowGreen

            End If

        Next


    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles BActivar.Click
        'guarda en una variable la fila/columna del datagridview de acuerdo a la seleccion realizada.
        Dim nombre = Me.MarcaDataGridView.CurrentRow.Cells.Item(0).Value
        'muestra mensaje para confirmación de alta.
        ask = MsgBox("¿ Seguro que desea dar de alta la marca: " & nombre & " ? ", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Question, "Confirmar Alta de Marca")
        'Si la respuesta es si, realiza el alta de marca.
        If ask = MsgBoxResult.Yes Then
            Me.MarcaTableAdapter.darDeBajaMarca(True, nombre)
            'actualiza el datagridview.
            Me.MarcaTableAdapter.Fill(Me.ElectrodomesticosDataSet.Marca)

        End If
        'desactiva botones.
        BEliminar.Enabled = False
        BActivar.Enabled = False
        Me.MarcaDataGridView.CurrentRow.Selected = False
        'recorre el datagridview y cambia el color de la fila en casa que la columna(1) estado este en estado FALSE.
        For Each Row As DataGridViewRow In MarcaDataGridView.Rows

            If Row.Cells(1).Value = "false" Then
                Row.DefaultCellStyle.BackColor = Color.YellowGreen

            End If

        Next
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNombreEditar.KeyPress
        'validación para agregar solo letras
        validar2.ValidarSoloLetras(e)
    End Sub

    Private Sub TextBox1_LostFocus(sender As Object, e As System.EventArgs) Handles TxtNombreEditar.LostFocus
        'Permite colocar en mayuscula la primera letra de cada palabra
        TxtNombreEditar.Text = validar1.PrimeraLetraEnMayuscula(TxtNombreEditar.Text)
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtNombreEditar.TextChanged

    End Sub

    Private Sub Bguardar_Click(sender As System.Object, e As System.EventArgs) Handles Bguardar.Click
        'verifica que el textbox este vacio y muestra un mensaje.
        If TxtNombreEditar.TextLength = 0 Then
            MsgBox("Debe completar el campo para modificar.", MsgBoxStyle.Critical, "Campo vacios")
        Else
            'Guarda en una variable el valor contenido del datagridview de acuerdo a la seleccion hecha.
            Dim nombreOriginal = Me.MarcaDataGridView.CurrentRow.Cells.Item(0).Value
            'muestra un mensaje para confirmación de modificación.
            ask = MsgBox("¿ Seguro que desea modificar la marca: " & nombreOriginal & " ? ", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Question, "Confirmar Modificación")
            'si la respuesta es si, realiza modificación.
            If ask = MsgBoxResult.Yes Then
                'verifica que el nombre a modificar ya no se encuentre en la tabla de marcas.
                If Me.MarcaTableAdapter.busquedaNombre(Me.ElectrodomesticosDataSet.Marca, TxtNombreEditar.Text) Then
                    'Muestra mensaje que ya existe marca con ese nombre ingresado.
                    MsgBox("Ya existe una marca con ese nombre, ingrese otro nombre por favor.", MsgBoxStyle.Critical, "ERROR: Marca existente")
                    'actualiza el datagridview
                    Me.MarcaTableAdapter.Fill(Me.ElectrodomesticosDataSet.Marca)
                    'limpia el textbox
                    TxtNombreEditar.Clear()
                Else
                    'realiza la modificación
                    Me.MarcaTableAdapter.modificarMarca(TxtNombreEditar.Text, nombreOriginal)
                    'actualiza el datagridview
                    Me.MarcaTableAdapter.Fill(Me.ElectrodomesticosDataSet.Marca)
                    'muestra mensaje de exito de modificación.
                    MsgBox("La marca: " & nombreOriginal & " ha sido modificada con exito", MsgBoxStyle.Information, "EXITO")
                    'permite dejar seleccionada la fila modificada.
                    Me.MarcaDataGridView.Rows(seleccion).Selected = True
                    'limpia textbox.
                    TxtNombreEditar.Clear()

                End If
            End If
        End If
        'desactiva botones.
        BEliminar.Enabled = False
        BActivar.Enabled = False
        Me.MarcaDataGridView.CurrentRow.Selected = False
        'recorre el datagridview y cambia el color de la fila en casa que la columna(1) estado este en estado FALSE.
        For Each Row As DataGridViewRow In MarcaDataGridView.Rows

            If Row.Cells(1).Value = "false" Then
                Row.DefaultCellStyle.BackColor = Color.YellowGreen

            End If

        Next
    End Sub


    Private Sub MarcaDataGridView_DoubleClick(sender As Object, e As System.EventArgs) Handles MarcaDataGridView.DoubleClick
        'guarda en una variable la selección realizada.
        seleccion = MarcaDataGridView.CurrentRow.Index
        'asigna al texbox el contenido del datagridview de acuerdo a la selección hecha.
        TxtNombreEditar.Text = Me.MarcaDataGridView.CurrentRow.Cells.Item(0).Value
        'desactiva botones.
        BActivar.Enabled = False
        BEliminar.Enabled = False

    End Sub
End Class