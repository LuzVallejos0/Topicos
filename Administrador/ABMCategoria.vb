Public Class ABMCategoria
    Dim seleccion As Integer
    Dim ask As MsgBoxResult


    Private Sub TxtCategoría_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtCategoría.KeyPress
        'validación para agregar solo letras
        validar2.ValidarSoloLetras(e)
    End Sub

    Private Sub TxtCategoría_LostFocus(sender As Object, e As System.EventArgs) Handles TxtCategoría.LostFocus
        'Permite colocar en mayuscula la primera letra de cada palabra
        TxtCategoría.Text = validar1.PrimeraLetraEnMayuscula(TxtCategoría.Text)
    End Sub

    Private Sub TxtNombreEditar_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNombreEditar.KeyPress
        'validación para agregar solo letras
        validar2.ValidarSoloLetras(e)
    End Sub

    Private Sub TxtNombreEditar_LostFocus(sender As Object, e As System.EventArgs) Handles TxtNombreEditar.LostFocus
        'Permite colocar en mayuscula la primera letra de cada palabra
        TxtNombreEditar.Text = validar1.PrimeraLetraEnMayuscula(TxtNombreEditar.Text)
    End Sub

    Private Sub TxtBuscarCategoria_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtBuscarCategoria.KeyPress
        'validación para agregar solo letras
        validar2.ValidarSoloLetras(e)
    End Sub

    Private Sub TxtBuscarCategoria_LostFocus(sender As Object, e As System.EventArgs) Handles TxtBuscarCategoria.LostFocus
        'Permite colocar en mayuscula la primera letra de cada palabra
        TxtBuscarCategoria.Text = validar1.PrimeraLetraEnMayuscula(TxtBuscarCategoria.Text)
    End Sub

    Private Sub TxtBuscarCategoria_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtBuscarCategoria.TextChanged
        'Busca categoria de manera interactiva
        Me.CategoriasTableAdapter.buscarNombreCategoria(Me.ElectrodomesticosDataSet.Categorias, TxtBuscarCategoria.Text)
        BActivar.Enabled = False
        BEliminar.Enabled = False

        'recorre el datagridview y cambia el color de la fila en caso que la columna(1) estado este en estado FALSE.
        For Each Row As DataGridViewRow In CategoríaDataGridView.Rows

            If Row.Cells(1).Value = "false" Then
                Row.DefaultCellStyle.BackColor = Color.YellowGreen

            End If

        Next
    End Sub

    Private Sub ABMCategoria_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ElectrodomesticosDataSet.Categorias' Puede moverla o quitarla según sea necesario.
        Me.CategoriasTableAdapter.Fill(Me.ElectrodomesticosDataSet.Categorias)
        'Permite que el datagridview no tenga seleccionado ninguna fila
        Me.CategoríaDataGridView.CurrentRow.Selected = False
        'recorre el datagridview y cambia el color de la fila en caso que la columna(1) estado este en estado FALSE.
        For Each Row As DataGridViewRow In CategoríaDataGridView.Rows

            If Row.Cells(1).Value = "false" Then
                Row.DefaultCellStyle.BackColor = Color.YellowGreen

            End If

        Next
        'desactiva los botones
        BActivar.Enabled = False
        BEliminar.Enabled = False
    End Sub

    Private Sub BVolver_Click(sender As System.Object, e As System.EventArgs) Handles BVolver.Click

        Dim formAdministrador As New MenuAdministrador
        Me.Hide()
        'Abre el menu del administrador
        formAdministrador.Show()
        'Cierra el formulario actual
        Me.Close()
    End Sub


    Private Sub BAgregar_Click(sender As System.Object, e As System.EventArgs) Handles BAgregar.Click
        'Verifica que el textbox este vacio y en caso que lo este muestra un mensaje.
        If (TxtCategoría.TextLength = 0) Then
            ask = MsgBox("No se ha ingresado ninguna categoría a agregar.", MsgBoxStyle.Critical, "ERROR: CAMPOS VACIOS")
        Else
            'Busca si la categoria ingresada se encuentra en la tabla de categorías.
            If Me.CategoriasTableAdapter.busquedaPornombre(Me.ElectrodomesticosDataSet.Categorias, TxtCategoría.Text) Then
                'mando mensaje de error, ya existe el mismo nombre dado de alta.
                ask = MsgBox("La Categoría: " & TxtCategoría.Text & " ya existe.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "ERROR: Categoría existente")
                'actualiza el datagridview.
                Me.CategoriasTableAdapter.Fill(Me.ElectrodomesticosDataSet.Categorias)
                'Limpia el textbox
                TxtCategoría.Clear()
            Else
                'Muestra un mensaje de confirmación antes de agregar la nueva categoría.
                ask = MsgBox("Se agregara la Categoría: " & TxtCategoría.Text & ", confirmar para seguir.", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Question, "Confirmar Agregar Categoría")
                'Si la confirmación es si agrega a la tabla categoría.
                If MsgBoxResult.Yes = ask Then
                    'Se guarda en una variable el contenido del textbox.
                    Dim nombre_categoria = TxtCategoría.Text
                    'Asigna true a la variable estado.
                    Dim estado = True
                    'Agrega la categoría ingresada en la tabla de Categorías.
                    Me.CategoriasTableAdapter.agregarCategoria(nombre_categoria, estado)
                    'Actualiza el datagridview.
                    Me.CategoriasTableAdapter.Fill(Me.ElectrodomesticosDataSet.Categorias)
                    'Muestra mensaje de que la categoría se agrego correctamente
                    MsgBox("La categoria: " & nombre_categoria & " ha sido agregada correctamente", MsgBoxStyle.Information, "EXITO")
                    'recorre el datagridview y deja seleccionada la fila recien agregada.
                    For Each Row As DataGridViewRow In CategoríaDataGridView.Rows

                        If Row.Cells(0).Value = nombre_categoria Then

                            Row.Selected = True
                        End If


                    Next
                    'limpia el textbox
                    TxtCategoría.Clear()

                End If
            End If
        End If
        'desactiva botones
        BActivar.Enabled = False
        BEliminar.Enabled = False
        Me.CategoríaDataGridView.CurrentRow.Selected = False
        'recorre el datagridview y cambia el color de la fila en casa que la columna(1) estado este en estado FALSE.
        For Each Row As DataGridViewRow In CategoríaDataGridView.Rows

            If Row.Cells(1).Value = "false" Then
                Row.DefaultCellStyle.BackColor = Color.YellowGreen

            End If

        Next
    End Sub

    Private Sub Bguardar_Click(sender As System.Object, e As System.EventArgs) Handles Bguardar.Click
        'verifica que el textbox este vacio y muestra un mensaje.
        If TxtNombreEditar.TextLength = 0 Then
            MsgBox("Debe completar el campo para modificar.", MsgBoxStyle.Critical, "ERROR: Campos vacios")
        Else
            'Guarda en una variable el valor contenido del datagridview de acuerdo a la seleccion hecha.
            Dim nombreOriginal = Me.CategoríaDataGridView.CurrentRow.Cells.Item(0).Value

            'muestra un mensaje para confirmación de modificación.
            ask = MsgBox("¿ Seguro que desea modificar la categoría: " & nombreOriginal & " ? ", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Question, "Confirmar Modificación de Categoría")

            'si la respuesta es si, realiza modificación.
            If ask = MsgBoxResult.Yes Then
                'verifica que el nombre a modificar ya no se encuentre en la tabla de categorías.
                If Me.CategoriasTableAdapter.busquedaPornombre(Me.ElectrodomesticosDataSet.Categorias, TxtNombreEditar.Text) Then
                    'Muestra mensaje que ya existe categoría con ese nombre ingresado.
                    MsgBox("Ya existe una categoría con ese nombre", MsgBoxStyle.Critical, "Error: Categoría existente")
                    'actualiza el datagridview
                    Me.CategoriasTableAdapter.Fill(Me.ElectrodomesticosDataSet.Categorias)
                    'limpia el textbox
                    TxtNombreEditar.Clear()
                Else
                    'realiza la modificación
                    Me.CategoriasTableAdapter.modificarCategoria(TxtNombreEditar.Text, nombreOriginal)
                    'actualiza el datagridview
                    Me.CategoriasTableAdapter.Fill(Me.ElectrodomesticosDataSet.Categorias)
                    'muestra mensaje de exito de modificación.
                    MsgBox("La categoria: " & nombreOriginal & " ha sido modificada con exito", MsgBoxStyle.Information, "EXITO")
                    'permite dejar seleccionada la fila modificada.
                    Me.CategoríaDataGridView.Rows(seleccion).Selected = True
                    'limpia textbox.
                    TxtNombreEditar.Clear()
                End If
            End If
        End If
        'desactiva botones.
        BActivar.Enabled = False
        BEliminar.Enabled = False

        Me.CategoríaDataGridView.CurrentRow.Selected = False
        'recorre el datagridview y cambia el color de la fila en casa que la columna(1) estado este en estado FALSE.
        For Each Row As DataGridViewRow In CategoríaDataGridView.Rows

            If Row.Cells(1).Value = "false" Then
                Row.DefaultCellStyle.BackColor = Color.YellowGreen

            End If

        Next
    End Sub

    Private Sub BActivar_Click(sender As System.Object, e As System.EventArgs) Handles BActivar.Click
        'guarda en una variable la fila/columna del datagridview de acuerdo a la seleccion realizada.
        Dim nombre = Me.CategoríaDataGridView.CurrentRow.Cells.Item(0).Value
        'muestra mensaje para confirmación de alta.
        ask = MsgBox("¿ Seguro que desea dar de alta la categoría: " & nombre & " ? ", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Question, "Confirmar alta de categoría")
        'Si la respuesta es si, realiza el alta de categoría.
        If ask = MsgBoxResult.Yes Then
            Me.CategoriasTableAdapter.bajaLogicaCategoria(True, nombre)
            'actualiza el datagridview.
            Me.CategoriasTableAdapter.Fill(Me.ElectrodomesticosDataSet.Categorias)
            'MsgBox("La categoria: " & nombre & " ha sido dado de alta correctamente.", MsgBoxStyle.Information, "EXITO")
        End If
        'desactiva botones.
        BActivar.Enabled = False
        BEliminar.Enabled = False
        Me.CategoríaDataGridView.CurrentRow.Selected = False
        'recorre el datagridview y cambia el color de la fila en casa que la columna(1) estado este en estado FALSE.
        For Each Row As DataGridViewRow In CategoríaDataGridView.Rows

            If Row.Cells(1).Value = "false" Then
                Row.DefaultCellStyle.BackColor = Color.YellowGreen

            End If

        Next
    End Sub

    Private Sub BEliminar_Click(sender As System.Object, e As System.EventArgs) Handles BEliminar.Click
        'guarda en una variable la fila/columna del datagridview de acuerdo a la seleccion realizada.
        Dim categoria = Me.CategoríaDataGridView.CurrentRow.Cells.Item(0).Value
        'Pide confirmacion de baja .
        ask = MsgBox("Se dara de baja la categoria: " & categoria & ", confirmar para seguir.", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Question, "Confirmar Baja de Categoría")
        'Si la respuesta es si, realiza la baja.
        If MsgBoxResult.Yes = ask Then

            Me.CategoriasTableAdapter.bajaLogicaCategoria(False, categoria)
            'actualiza el datagridview.
            Me.CategoriasTableAdapter.Fill(Me.ElectrodomesticosDataSet.Categorias)
            'muestra mensaje de exito de la baja realizada.
            MsgBox("La categoria: " & categoria & " ha sido dado de baja correctamente.", MsgBoxStyle.Information, "EXITO")
        End If
        'desactiva botones.
        BActivar.Enabled = False
        BEliminar.Enabled = False
        Me.CategoríaDataGridView.CurrentRow.Selected = False
        'recorre el datagridview y cambia el color de la fila en casa que la columna(1) estado este en estado FALSE.
        For Each Row As DataGridViewRow In CategoríaDataGridView.Rows

            If Row.Cells(1).Value = "false" Then
                Row.DefaultCellStyle.BackColor = Color.YellowGreen

            End If

        Next
    End Sub

    Private Sub CategoríaDataGridView_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CategoríaDataGridView.CellClick
        'desactiva/activa botones de acuerdo al contenido del datagridview.
        If Me.CategoríaDataGridView.CurrentRow.Cells.Item(1).Value = False Then
            BActivar.Enabled = True
            BEliminar.Enabled = False

        Else
            BActivar.Enabled = False

            BEliminar.Enabled = True

        End If
    End Sub


    Private Sub CategoríaDataGridView_DoubleClick(sender As Object, e As System.EventArgs) Handles CategoríaDataGridView.DoubleClick
        'guarda en una variable la selección realizada.
        seleccion = CategoríaDataGridView.CurrentRow.Index
        'asigna al texbox el contenido del datagridview de acuerdo a la selección hecha.
        TxtNombreEditar.Text = Me.CategoríaDataGridView.CurrentRow.Cells.Item(0).Value
        'desactiva botones.
        BActivar.Enabled = False
        BEliminar.Enabled = False

    End Sub

End Class