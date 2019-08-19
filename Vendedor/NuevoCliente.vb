Public Class NuevoCliente
    Dim seleccion As Integer
    Dim ask As MsgBoxResult

    Private Sub NuevoCliente_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'ElectrodomesticosDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.ElectrodomesticosDataSet.Clientes)
        'TODO: esta línea de código carga datos en la tabla 'ElectrodomesticosDataSet.Provincia' Puede moverla o quitarla según sea necesario.
        Me.ProvinciaTableAdapter.Fill(Me.ElectrodomesticosDataSet.Provincia)

       
    End Sub

    Private Sub TxtDNI_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDNI.KeyPress
        'validacion para que ingrese solo numeros.
        validar2.ValidarSoloNumeros(e)
    End Sub

 

    Private Sub TxtLocalidad_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtLocalidad.KeyPress
        'validacion para que ingrese solo letras.
        validar2.ValidarSoloLetras(e)
    End Sub


    Private Sub TxtTelefono_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtTelefono.KeyPress
        'validacion para que ingrese solo numeros.
        validar2.ValidarSoloNumeros(e)
    End Sub

    Private Sub TxtTelefono_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtTelefono.TextChanged

    End Sub

    Private Sub limpiarCampos()
        'limpia los textbox.
        TxtDNI.Clear()
        TxtNombre.Clear()
        TxtApellido.Clear()
        TxtDireccion.Clear()
        TxtLocalidad.Clear()
        TxtTelefono.Clear()
        TxtEmail.Clear()
    End Sub

    Private Sub BAgregar_Click(sender As System.Object, e As System.EventArgs) Handles BAgregar.Click

        'verifica que ningun textbox se encuentre vacio, muestra un mensaje si es asi
        If (TxtDNI.TextLength = 0) Or (TxtNombre.TextLength = 0) Or (TxtApellido.TextLength = 0) Or (TxtDireccion.TextLength = 0) Or (TxtLocalidad.TextLength = 0) Or (TxtTelefono.TextLength = 0) Or (TxtEmail.TextLength = 0) Then
            MsgBox("Debe completar todos los campos", MsgBoxStyle.Critical, "Campos vacios")
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


            'pide confirmacion para agregar un cliente.
            ask = MsgBox("Se agregará el cliente : " & apellido & " " & nombre & ", confirmar para seguir.", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Question, "Confirmar Agregar Cliente")

            If MsgBoxResult.Yes = ask Then
                'verifica si el dni ingresado ya no se encuentra registrado.
                If Me.ClientesTableAdapter.buscarCliente(Me.ElectrodomesticosDataSet.Clientes, DNI) Then

                    MsgBox("El DNI: " & DNI & " ya existe, ingrese otro DNI.", MsgBoxStyle.OkOnly Or MsgBoxStyle.DefaultButton1 Or MsgBoxStyle.Critical, "Error")

                Else
                    Dim id_provincia = CBProvincia.SelectedValue
                    Me.ClientesTableAdapter.agregarCliente(DNI, nombre, apellido, direccion, localidad, id_provincia, telefono, email, True)

                    Me.ClientesTableAdapter.mostrarDatosCliente(Me.ElectrodomesticosDataSet.Clientes)
                    MsgBox("Cliente " + TxtApellido.Text + " " + TxtNombre.Text + " agregado", MsgBoxStyle.Information, "Cliente Agregado")
                    'asigna a los textbox del formulario de ventas el valor dni, nombre, apellido del formulario actual
                    Ventas.TxtDNICliente.Text = DNI
                    Ventas.TxtNombreCliente.Text = nombre
                    Ventas.TxtApellidoCiente.Text = apellido
                    'guarda en un textbox del formulario de ventas el id del cliente.
                    Ventas.TxtID.Text = Me.ElectrodomesticosDataSet.Tables("Clientes").Rows(0).Item("id_cliente").ToString
                    'cierra el formulario actual
                    Me.Close()

                End If
            End If
        End If

    End Sub

    Private Sub TxtNombre_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNombre.KeyPress
        'validacion para que ingrese solo letras.
        validar2.ValidarSoloLetras(e)
    End Sub



    Private Sub TxtApellido_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles TxtApellido.KeyPress
        'validacion para que ingrese solo letras
        validar2.ValidarSoloLetras(e)

    End Sub

    Private Sub TxtNombre_LostFocus(sender As Object, e As System.EventArgs) Handles TxtNombre.LostFocus
        TxtNombre.Text = validar1.PrimeraLetraEnMayuscula(TxtNombre.Text)
    End Sub

    Private Sub TxtNombre_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtNombre.TextChanged

    End Sub

    Private Sub TxtApellido_LostFocus(sender As Object, e As System.EventArgs) Handles TxtApellido.LostFocus
        'validacion para que coloque en mayuscula la primera letra de cada palabra
        TxtApellido.Text = validar1.PrimeraLetraEnMayuscula(TxtApellido.Text)
    End Sub

    Private Sub TxtApellido_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtApellido.TextChanged

    End Sub

    Private Sub TxtDireccion_LostFocus(sender As Object, e As System.EventArgs) Handles TxtDireccion.LostFocus
        'validacion para que coloque en mayuscula la primera letra de cada palabra
        TxtLocalidad.Text = validar1.PrimeraLetraEnMayuscula(TxtLocalidad.Text)
    End Sub

    Private Sub TxtDireccion_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtDireccion.TextChanged

    End Sub

    Private Sub TxtLocalidad_LostFocus(sender As Object, e As System.EventArgs) Handles TxtLocalidad.LostFocus
        'validacion para que coloque en mayuscula la primera letra de cada palabra
        TxtLocalidad.Text = validar1.PrimeraLetraEnMayuscula(TxtLocalidad.Text)
    End Sub

    Private Sub TxtLocalidad_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtLocalidad.TextChanged

    End Sub

    Private Sub TxtDNI_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtDNI.TextChanged

    End Sub

    Private Sub ClientesDataGridView_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub


End Class