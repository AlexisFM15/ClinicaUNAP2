Imports System.Windows.Forms
Imports ClinicaUNAP.BLL
Imports ClinicaUNAP.Entity


Public Class FrmUsuario


    ' PRIMER PASO - INICIALIZAR CONTROLES
    Private Sub InicializarControles()

        Me.TxtId.Text = "0"
        Me.TxtNombre.Clear()
        Me.TxtClave.Clear()
        Me.TxtEstado.Clear()
        Me.DgvUsuario.AutoGenerateColumns = False
        Me.DgvUsuario.DataSource = UsuarioBLL.GetAll()
        CargarRol()
    End Sub

    'Configura el combobox y se carga las categorias
    Private Sub CargarRol()

        Me.CbbRol.ValueMember = "IdRol"
        Me.CbbRol.DisplayMember = "Nombre"
        Me.CbbRol.DataSource = RolBLL.GetAll()
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

        ElseIf String.IsNullOrEmpty(TxtClave.Text) Then

            ErrorProvider1.SetError(TxtClave, "La Clave es obligatoria")

            resultado = False

        ElseIf String.IsNullOrEmpty(TxtEstado.Text) Then

            ErrorProvider1.SetError(TxtEstado, "El Estado es obligatorio")

            resultado = False

        End If

        Return resultado

    End Function

    'TERCER PASO - CONFIGURAR DATAGRIDVIEW AL HACER DOBLE CLICK EN UN REGISTRO
    'CARGARLOS DATOS A LOS CONTROLES DE TEXTO 
    'VAMOS A LOS EVENTOS DEL MISMO Y BUSCAMOS CELLDOUBLECLICK Y LE DAMOS DOS CLICK  
    Private Sub DgvUsuario_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DgvUsuario.CellClick
        'Decimos que si le dan al encabesado del datagridview se salga

        If e.RowIndex = -1 Then

            Exit Sub

        End If

        'Declaramos una variable row tipo datagridviewrow igualada al datagridview con la propiedad currentrow

        Dim row As DataGridViewRow = Me.DgvUsuario.CurrentRow

        'Cargamos los datos de la celdas a los controles TexBox

        Me.TxtId.Text = row.Cells("IdUsuario").Value
        Me.CbbRol.SelectedValue = row.Cells("Rol").Value
        Me.TxtNombre.Text = row.Cells("Nombre").Value
        Me.TxtClave.Text = row.Cells("Clave").Value
        Me.TxtEstado.Text = row.Cells("Estado").Value
    End Sub

    'CUARTO PASO - BOTON GUARDAR
    Private Sub BtnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click

        '1 Antes de guardar primero hay que llamar ValidadarDatos para validar los datos 

        If Not ValidarDatos() Then

            Exit Sub

        End If

        '2 Pasamos los datos de los controles a un objeto

        'pasamos los objetos de recinto entity a la variable oRecinto
        Dim oUsuario As New UsuarioEntity

        oUsuario.IdUsuario = Convert.ToInt32(Me.TxtId.Text)
        oUsuario.IdRol = Convert.ToInt32(Me.CbbRol.SelectedValue)
        oUsuario.Nombre = Me.TxtNombre.Text
        oUsuario.Clave = Me.TxtClave.Text
        oUsuario.Estado = Me.TxtEstado.Text

        '3 Mandamos a guardar el objeto creado a la BD

        Try
            'Guardarlo

            UsuarioBLL.Save(oUsuario)

            'Mensaje de que si se guardo

            MessageBox.Show("Usuario Guardado", "Clinica UNAP", MessageBoxButtons.OK, MessageBoxIcon.Information)

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
    Private Sub FrmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Al entrar al formulario debe estar inicializado los controles

        InicializarControles()

        'Cargamos los datos de la columna combobox del dagridview

        Dim colRol As DataGridViewComboBoxColumn = DgvUsuario.Columns.Item("Rol")

        'Estas tres propiedades son de la entidad principal Rol

        colRol.DataSource = RolBLL.GetAll
        colRol.DisplayMember = "Nombre"
        colRol.ValueMember = "IdRol"
        'OJO esta propiedad es de la entidad secundaria Usuario

        colRol.DataPropertyName = "IdRol"

    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click

        FrmMenuAvanzado.Show()

    End Sub

    Private Sub BtnRol_Click(sender As Object, e As EventArgs) Handles BtnRol.Click
        FrmRol.Show()

    End Sub
End Class