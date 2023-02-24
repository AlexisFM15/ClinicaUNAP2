Imports ClinicaUNAP.BLL
Imports ClinicaUNAP.Entity
Imports System.Windows.Forms

Public Class FrmRol


    ' PRIMER PASO - INICIALIZAR CONTROLES
    Private Sub InicializarControles()

        Me.TxtID.Text = "0"
        Me.TxtNombre.Clear()
        Me.DgvRol.AutoGenerateColumns = False
        Me.DgvRol.DataSource = RolBLL.GetAll()

    End Sub

    'SEGUNDO PASO - VALIDAR DATOS

    Private Function ValidarDatos()
        'Declaramos una valible resultado tipo boolean que este true

        Dim resultado As Boolean = True

        'Agregamos un control en el form (Errorprovider)
        'Lo limpiamos

        ErrorProvider1.Clear()

        'Verificamos que en los campos obligatorios haya datos

        If String.IsNullOrEmpty(TxtNombre.Text) Then

            ErrorProvider1.SetError(TxtNombre, "El Nombre es obligatorio")

            resultado = False

        End If

        Return resultado

    End Function

    'TERCER PASO - CONFIGURAR DATAGRIDVIEW AL HACER DOBLE CLICK EN UN REGISTRO
    'CARGARLOS DATOS A LOS CONTROLES DE TEXTO 
    'VAMOS A LOS EVENTOS DEL MISMO Y BUSCAMOS CELLDOUBLECLICK Y LE DAMOS DOS CLICK  

    Private Sub DgvRol_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvRol.CellClick
        'Decimos que si le dan al encabesado del datagridview se salga

        If e.RowIndex = -1 Then

            Exit Sub

        End If

        'Declaramos una variable row tipo datagridviewrow igualada al datagridview con la propiedad currentrow

        Dim row As DataGridViewRow = Me.DgvRol.CurrentRow

        'Cargamos los datos de la celdas a los controles TexBox

        Me.TxtID.Text = row.Cells("ID").Value
        Me.TxtNombre.Text = row.Cells("Nombre").Value

    End Sub


    'CUARTO PASO - BOTON GUARDAR
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        '1 Antes de guardar primero hay que llamar ValidadarDatos para validar los datos 

        If Not ValidarDatos() Then

            Exit Sub

        End If

        '2 Pasamos los datos de los controles a un objeto

        'pasamos los objetos de recinto entity a la variable oRecinto
        Dim oRol As New RolEntity

        oRol.IdRol = Me.TxtID.Text
        oRol.Nombre = Me.TxtNombre.Text


        '3 Mandamos a guardar el objeto creado a la BD

        Try
            'Guardarlo

            RolBLL.Save(oRol)

            'Mensaje de que si se guardo

            MessageBox.Show("Rol Guardado", "Clinica UNAP", MessageBoxButtons.OK, MessageBoxIcon.Information)

            'Si se guardo entonces inicializamos los controles

            InicializarControles()

        Catch ex As Exception

            'Mensaje en caso de que hay un error

            MessageBox.Show(ex.Message, "Clinica UNAP", MessageBoxButtons.OK, MessageBoxIcon.Error)


        End Try

    End Sub

    'QUINTO PASO - BOTON NUEVO
    Private Sub BtnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click

        'Solo hay que llamar el inicializador de controles

        InicializarControles()

    End Sub

    'SEXTO PASO - BOTON CANCELAR
    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs)

        'Es simplemente cerrar el formulario

        Me.Close()

    End Sub

    'SEPTIMO PASO Y ULTIMO - AL ABRIR EL FORMULARIO (LOAD)
    Private Sub FrmRol_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Al entrar al formulario debe estar inicializado los controles

        InicializarControles()


    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Hide()
        FrmMenuAvanzado.Show()

    End Sub



    'Private Sub BtnEliminar_Click(sender As Object, e As EventArgs) Handles BtnEliminar.Click
    '    Dim oRecinto As New RecintoEntity


    '    RecintoBLL.Eliminar(oRecinto)

    'End Sub
End Class