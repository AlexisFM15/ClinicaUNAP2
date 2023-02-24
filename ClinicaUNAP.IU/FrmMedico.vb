Imports ClinicaUNAP.BLL
Imports ClinicaUNAP.Entity
Imports System.Windows.Forms

Public Class FrmMedico
    ' PRIMER PASO - INICIALIZAR CONTROLES
    Private Sub InicializarControles()

        Me.TxtIdMedico.Text = "0"
        Me.TxtNombre.Clear()
        Me.TxtApellido.Clear()
        Me.TxtCedula.Clear()
        Me.TxtTelefono.Clear()
        Me.TxtDireccion.Clear()
        Me.TxtEdad.Text = "0"
        Me.TxtCedula.Text = "0"
        Me.DgvMedico.AutoGenerateColumns = False
        Me.DgvMedico.DataSource = MedicoBLL.GetAll()
        CargarRecintoyEspecialidad()
    End Sub

    'Configura el combobox y se carga las categorias
    Private Sub CargarRecintoyEspecialidad()

        Me.CbbRecinto.ValueMember = "IdRecinto"
        Me.CbbRecinto.DisplayMember = "Nombre"
        Me.CbbRecinto.DataSource = RecintoBLL.GetAll()

        Me.CbbEspecialidad.ValueMember = "IdEspecialidad"
        Me.CbbEspecialidad.DisplayMember = "Tipo"
        Me.CbbEspecialidad.DataSource = EspecialidadBLL.GetAll()
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
        ElseIf String.IsNullOrEmpty(TxtApellido.Text) Then

            ErrorProvider1.SetError(TxtApellido, "El Apellido es obligatorio")

            resultado = False
        ElseIf String.IsNullOrEmpty(TxtCedula.Text) Then

            ErrorProvider1.SetError(TxtCedula, "La Cedula es obligatoria")

            resultado = False

        End If

        Return resultado

    End Function

    'TERCER PASO - CONFIGURAR DATAGRIDVIEW AL HACER DOBLE CLICK EN UN REGISTRO
    'CARGARLOS DATOS A LOS CONTROLES DE TEXTO 
    'VAMOS A LOS EVENTOS DEL MISMO Y BUSCAMOS CELLDOUBLECLICK Y LE DAMOS DOS CLICK  
    Private Sub DgvMedico_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvMedico.CellClick
        'Decimos que si le dan al encabesado del datagridview se salga

        If e.RowIndex = -1 Then

            Exit Sub

        End If

        'Declaramos una variable row tipo datagridviewrow igualada al datagridview con la propiedad currentrow

        Dim row As DataGridViewRow = Me.DgvMedico.CurrentRow

        'Cargamos los datos de la celdas a los controles TexBox

        Me.TxtIdMedico.Text = CStr(row.Cells("IdMedico").Value)
        Me.CbbRecinto.SelectedValue = row.Cells("Recinto").Value
        Me.CbbEspecialidad.SelectedValue = row.Cells("Especialidad").Value
        Me.TxtNombre.Text = CStr(row.Cells("Nombre").Value)
        Me.TxtApellido.Text = CStr(row.Cells("Apellido").Value)
        Me.TxtCedula.Text = CStr(row.Cells("Cedula").Value)
        Me.TxtTelefono.Text = CStr(row.Cells("Telefono").Value)
        Me.TxtDireccion.Text = CStr(row.Cells("Direccion").Value)
        Me.TxtEdad.Text = CStr(row.Cells("Edad").Value)

    End Sub

    'CUARTO PASO - BOTON GUARDAR
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        '1 Antes de guardar primero hay que llamar ValidadarDatos para validar los datos 

        If Not ValidarDatos() Then

            Exit Sub

        End If

        '2 Pasamos los datos de los controles a un objeto

        'pasamos los objetos de recinto entity a la variable oRecinto
        Dim oMedico As New MedicoEntity

        oMedico.IdMedico = Convert.ToInt32(Me.TxtIdMedico.Text)

        oMedico.Nombre = Me.TxtNombre.Text
        oMedico.Apellido = Me.TxtApellido.Text
        oMedico.Cedula = Convert.ToInt32(Me.TxtCedula.Text)
        oMedico.Telefono = Me.TxtTelefono.Text
        oMedico.Direccion = Me.TxtDireccion.Text
        oMedico.Edad = Convert.ToInt32(Me.TxtEdad.Text)
        oMedico.IdRecinto = Convert.ToInt32(Me.CbbRecinto.SelectedValue)
        oMedico.IdEspecialidad = Convert.ToInt32(Me.CbbEspecialidad.SelectedValue)
        '3 Mandamos a guardar el objeto creado a la BD

        Try
            'Guardarlo

            MedicoBLL.Save(oMedico)

            'Mensaje de que si se guardo

            MessageBox.Show("Medico Guardado", "Clinica UNAP", MessageBoxButtons.OK, MessageBoxIcon.Information)

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
    'Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click

    'Es simplemente cerrar el formulario

    'Me.Close()

    'End Sub

    'SEPTIMO PASO Y ULTIMO - AL ABRIR EL FORMULARIO (LOAD)
    Private Sub FrmMedico_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Al entrar al formulario debe estar inicializado los controles

        InicializarControles()

        'Cargamos los datos de la columna combobox del dagridview

        Dim colRecinto As DataGridViewComboBoxColumn = DgvMedico.Columns.Item("Recinto")
        Dim colEspecialidad As DataGridViewComboBoxColumn = DgvMedico.Columns.Item("Especialidad")
        'Estas tres propiedades son de la entidad principal Rol

        colRecinto.DataSource = RecintoBLL.GetAll
        colRecinto.ValueMember = "IdRecinto"
        colRecinto.DisplayMember = "Nombre"
        'OJO esta propiedad es de la entidad secundaria Usuario

        colRecinto.DataPropertyName = "IdRecinto"

        'Estas tres propiedades son de la entidad principal Rol

        colEspecialidad.DataSource = EspecialidadBLL.GetAll
        colEspecialidad.DisplayMember = "Tipo"
        colEspecialidad.ValueMember = "IdEspecialidad"
        'OJO esta propiedad es de la entidad secundaria Usuario

        colEspecialidad.DataPropertyName = "IdEspecialidad"

    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click

        FrmMenuAvanzado.Show()

    End Sub

    Private Sub BtnRecinto_Click(sender As Object, e As EventArgs) Handles BtnRecinto.Click
        FrmRecinto.Show()

    End Sub

    Private Sub BtnEspecialidad_Click(sender As Object, e As EventArgs) Handles BtnEspecialidad.Click
        FrmEspecialidad.Show()

    End Sub
End Class