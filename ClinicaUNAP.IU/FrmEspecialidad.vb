Imports ClinicaUNAP.BLL
Imports ClinicaUNAP.Entity
Imports System.Windows.Forms

Public Class FrmEspecialidad
    ' PRIMER PASO - INICIALIZAR CONTROLES
    Private Sub InicializarControles()

        Me.TxtIdEspecialidad.Text = "0"
        Me.TxtTipo.Clear()
        Me.DgvEspecialidad.AutoGenerateColumns = False
        Me.DgvEspecialidad.DataSource = EspecialidadBLL.GetAll()

    End Sub

    'SEGUNDO PASO - VALIDAR DATOS

    Private Function ValidarDatos()
        'Declaramos una valible resultado tipo boolean que este true

        Dim resultado As Boolean = True

        'Agregamos un control en el form (Errorprovider)
        'Lo limpiamos

        ErrorProvider1.Clear()

        'Verificamos que en los campos obligatorios haya datos

        If String.IsNullOrEmpty(TxtTipo.Text) Then

            ErrorProvider1.SetError(TxtTipo, "El Tipo es obligatorio")

            resultado = False

        End If

        Return resultado

    End Function

    'TERCER PASO - CONFIGURAR DATAGRIDVIEW AL HACER DOBLE CLICK EN UN REGISTRO
    'CARGARLOS DATOS A LOS CONTROLES DE TEXTO 
    'VAMOS A LOS EVENTOS DEL MISMO Y BUSCAMOS CELLDOUBLECLICK Y LE DAMOS DOS CLICK  

    Private Sub DgvEspecialidad_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvEspecialidad.CellClick
        'Decimos que si le dan al encabesado del datagridview se salga

        If e.RowIndex = -1 Then

            Exit Sub

        End If

        'Declaramos una variable row tipo datagridviewrow igualada al datagridview con la propiedad currentrow

        Dim row As DataGridViewRow = Me.DgvEspecialidad.CurrentRow

        'Cargamos los datos de la celdas a los controles TexBox

        Me.TxtIdEspecialidad.Text = row.Cells("IdEspecialidad").Value
        Me.TxtTipo.Text = row.Cells("Tipo").Value

    End Sub


    'CUARTO PASO - BOTON GUARDAR
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        '1 Antes de guardar primero hay que llamar ValidadarDatos para validar los datos 

        If Not ValidarDatos() Then

            Exit Sub

        End If

        '2 Pasamos los datos de los controles a un objeto

        'pasamos los objetos de recinto entity a la variable oRecinto
        Dim oEspecialidad As New EspecialidadEntity

        oEspecialidad.IdEspecialidad = Me.TxtIdEspecialidad.Text
        oEspecialidad.Tipo = Me.TxtTipo.Text


        '3 Mandamos a guardar el objeto creado a la BD

        Try
            'Guardarlo

            EspecialidadBLL.Save(oEspecialidad)

            'Mensaje de que si se guardo

            MessageBox.Show("Especialidad Guardada", "Clinica UNAP", MessageBoxButtons.OK, MessageBoxIcon.Information)

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
    Private Sub FrmEspecialidad_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Al entrar al formulario debe estar inicializado los controles

        InicializarControles()


    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click

        FrmMenuAvanzado.Show()

    End Sub

End Class