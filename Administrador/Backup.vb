
Imports System.Data.SqlClient

Public Class Backup

    Dim conexion As SqlConnection

    Private Sub Backup_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Asigno al textbox el nombre del servidor
        TxtServidor.Text = "LUZ\SQLEXPRESS"
        'Asigno el nombre de la base de datos
        TxtBase.Text = "Electrodomesticos"

        'Guardo en una variable el formato que tendra el nombre de la copia de seguridad.
        Dim nombreCopia As String = ("Fecha " & Date.Today.Day.ToString & "-" & Date.Today.Month.ToString & "-" & Date.Today.Year.ToString & " Hora " & Date.Now.Hour.ToString & "-" & Date.Now.Minute.ToString & " Copia de Seguridad" + ".bak")
        'Asigno al textbox la variable creada anteriormente
        txtnombre.Text = nombreCopia

    End Sub

    Private Sub BAbrir_Click(sender As System.Object, e As System.EventArgs) Handles BAbrir.Click
        'Permite examinar las carpetas del sistema.
        FolderBrowserDialog1.ShowDialog()
        'Guarda la dirección de la ruta seleccionada en un textbox.
        TxtRuta.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub BBackup_Click(sender As System.Object, e As System.EventArgs) Handles BBackup.Click
        'Guardo en una variable la conexión.
        Dim c As String = "Data Source=LUZ\SQLEXPRESS;Initial Catalog=Electrodomesticos;Integrated Security=True"
        'Guardo en una variable el nombre de la base de datos.
        Dim db As String = "Electrodomesticos"
        'Guardo en una variable el nombre de la ruta y el nombre con el cual se va guardar la copia.
        Dim concatenando As String = Me.TxtRuta.Text + Me.txtnombre.Text
        'verifica que los campos ruta y nombre no se encuentren vacios, mando un mensaje en caso de que esten vacios.
        If Me.TxtRuta.Text = "" Or Me.txtnombre.Text = "" Then
            MsgBox("Hay campos vacios, complete por favor", MsgBoxStyle.Critical, "Campos Vacios")
            Exit Sub
        Else
            Try
                'crea la conexion
                conexion = New SqlConnection(c)
                'crea un comando con el procedimiento almacenado y la conexion.
                Dim comando As SqlCommand = New SqlCommand("BackupBase", conexion)
                'abre la conexión.
                conexion.Open()
                'ejecuta el procedimiento almacenamiento.
                comando.CommandType = CommandType.StoredProcedure
                'pasa al procedimiento almacenado el parametro ruta.
                comando.Parameters.AddWithValue("@ruta", concatenando)
                'pasa al procedimiento almacenado el parametro Base de datos.
                comando.Parameters.AddWithValue("@bd", db)
                'Ejecuta la consulta.
                comando.ExecuteNonQuery()

                MsgBox("Copia de Seguridad creada correctamente", MsgBoxStyle.Information Or MsgBoxStyle.OkOnly, "Backup")

                'abre el menu del supervisor.
                MenuAdministrador.Show()
                'cierra el formulario.
                Me.Close()
            Catch ex As Exception
                'Manda un mensaje de error en caso de que la copia no se haya realizado con exito.
                MsgBox("ERROR DE CONEXIÓN", MsgBoxStyle.Information)
                'muestra el mensaje de error.
                MsgBox(ex.Message)
            End Try
            'cierra la conexion.
            conexion.Close()

        End If

    End Sub

    Private Sub txtnombre_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtnombre.KeyPress
        'validacion para que ingrese solo numeros y letras
        validar2.validarNumerosYLetras(e)
    End Sub

    Private Sub txtnombre_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtnombre.TextChanged

    End Sub

    Private Sub BVolver_Click(sender As System.Object, e As System.EventArgs)
        Dim formGerente As New MenuSupervisor
        Me.Visible = False
        Me.Hide()
        formGerente.Show()
        'cierra el formulari actual
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick

        LFecha.Text = Now.ToLongDateString
        Lhora.Text = Now.ToLongTimeString
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles SalirToolStripMenuItem.Click
        'abre el formulario de menuAdministrador.
        MenuAdministrador.Show()
        Me.Close()

    End Sub
End Class