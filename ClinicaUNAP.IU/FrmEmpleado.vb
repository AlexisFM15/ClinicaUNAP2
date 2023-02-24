Imports ClinicaUNAP.BLL
Imports ClinicaUNAP.Entity
Imports System.Drawing
Imports System.Windows.Forms

Public Class FrmEmpleado

    ' PRIMER PASO - INICIALIZAR CONTROLES
    Private Sub InicializarControles()

        Me.TxtIdEmpleado.Text = "0"
        Me.TxtNombre.Clear()
        Me.TxtApellido.Clear()
        Me.TxtCedula.Clear()
        Me.TxtTelefono.Clear()
        Me.TxtDireccion.Clear()
        Me.TxtCargo.Clear()
        Me.TxtEdad.Text = "0"
        Me.TxtCedula.Text = "0"
        Me.DgvEmpleado.AutoGenerateColumns = False
        Me.DgvEmpleado.DataSource = EmpleadoBLL.GetAll()
        CargarRecintoyUsuario()
    End Sub

    'Configura el combobox y se carga las categorias
    Private Sub CargarRecintoyUsuario()

        Me.CbbRecinto.ValueMember = "IdRecinto"
        Me.CbbRecinto.DisplayMember = "Nombre"
        Me.CbbRecinto.DataSource = RecintoBLL.GetAll()

        Me.CbbUsuario.ValueMember = "IdUsuario"
        Me.CbbUsuario.DisplayMember = "Nombre"
        Me.CbbUsuario.DataSource = UsuarioBLL.GetAll()
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
    Private Sub DgvEmpleado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvEmpleado.CellClick
        'Decimos que si le dan al encabesado del datagridview se salga

        If e.RowIndex = -1 Then

            Exit Sub

        End If

        'Declaramos una variable row tipo datagridviewrow igualada al datagridview con la propiedad currentrow

        Dim row As DataGridViewRow = Me.DgvEmpleado.CurrentRow

        'Cargamos los datos de la celdas a los controles TexBox

        Me.TxtIdEmpleado.Text = CStr(row.Cells("IdEmpleado").Value)
        Me.CbbRecinto.SelectedValue = row.Cells("Recinto").Value
        Me.CbbUsuario.SelectedValue = row.Cells("Usuario").Value
        Me.TxtNombre.Text = CStr(row.Cells("Nombre").Value)
        Me.TxtApellido.Text = CStr(row.Cells("Apellido").Value)
        Me.TxtCedula.Text = CStr(row.Cells("Cedula").Value)
        Me.TxtTelefono.Text = CStr(row.Cells("Telefono").Value)
        Me.TxtDireccion.Text = CStr(row.Cells("Direccion").Value)
        Me.TxtCargo.Text = CStr(row.Cells("Cargo").Value)
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
        Dim oEmpleado As New EmpleadoEntity

        oEmpleado.IdEmpleado = Convert.ToInt32(Me.TxtIdEmpleado.Text)
        oEmpleado.IdRecinto = Convert.ToInt32(Me.CbbRecinto.SelectedValue)
        oEmpleado.IdUsuario = Convert.ToInt32(Me.CbbUsuario.SelectedValue)
        oEmpleado.Nombre = Me.TxtNombre.Text
        oEmpleado.Apellido = Me.TxtApellido.Text
        oEmpleado.Cedula = Convert.ToInt32(Me.TxtCedula.Text)
        oEmpleado.Telefono = Me.TxtTelefono.Text
        oEmpleado.Direccion = Me.TxtDireccion.Text
        oEmpleado.Cargo = Me.TxtCargo.Text
        oEmpleado.Edad = Convert.ToInt32(Me.TxtEdad.Text)

        '3 Mandamos a guardar el objeto creado a la BD

        Try
            'Guardarlo

            EmpleadoBLL.Save(oEmpleado)

            'Mensaje de que si se guardo

            MessageBox.Show("Empleado Guardado", "Clinica UNAP", MessageBoxButtons.OK, MessageBoxIcon.Information)

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
    Private Sub FrmEmpleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Al entrar al formulario debe estar inicializado los controles

        InicializarControles()

        'Cargamos los datos de la columna combobox del dagridview

        'Dim colRecinto As DataGridViewComboBoxColumn = DgvEmpleado.Columns.Item("Recinto")
        ' Dim colUsuario As DataGridViewComboBoxColumn = DgvEmpleado.Columns.Item("Usuario")
        'Estas tres propiedades son de la entidad principal Rol

        ' colRecinto.DataSource = RecintoBLL.GetAll
        ' colRecinto.DisplayMember = "Nombre"
        'colRecinto.ValueMember = "IdRecinto"
        'OJO esta propiedad es de la entidad secundaria Usuario

        'colRecinto.DataPropertyName = "IdRecinto"

        'Estas tres propiedades son de la entidad principal Rol

        'colUsuario.DataSource = UsuarioBLL.GetAll
        ' colUsuario.DisplayMember = "Nombre"
        'colUsuario.ValueMember = "IdUsuario"
        'OJO esta propiedad es de la entidad secundaria Usuario

        'colUsuario.DataPropertyName = "IdUsuario"

    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click

        FrmMenuAvanzado.Show()

    End Sub

    Private Sub BtnRecinto_Click(sender As Object, e As EventArgs) Handles BtnRecinto.Click
        FrmRecinto.Show()

    End Sub

    Private Sub BtnUsuario_Click(sender As Object, e As EventArgs) Handles BtnUsuario.Click
        FrmUsuario.Show()

    End Sub
End Class

