Imports System.Windows.Forms
Imports ClinicaUNAP.BLL
Imports ClinicaUNAP.Entity

Public Class FrmUsuario
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles BtnNuevo.Click
        InicializarControles()
    End Sub


    Private Sub InicializarControles()
        Me.TxtId.Text = "0"
        Me.TxtUsuario.Text = String.Empty
        Me.TxtClave.Text = String.Empty
        Me.TxtEstado.Text = String.Empty
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.DataSource = UsuarioBLL.GetAll()
        CargarRol()
    End Sub

    Private Sub CargarRol()
        'Configura el combobox y se carga las categorias
        Me.CbbUsuario.ValueMember = "IdRol"
        Me.CbbUsuario.DisplayMember = "Nombre"
        Me.CbbUsuario.DataSource = RolBLL.GetAll()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles BtnGuardar.Click
        'paso 1 Validar los datos
        If Not ValidarDatos() Then
            Exit Sub
        End If

        'Paso 2 pasar los datos de  los controles a un objetos
        Dim oSuario As New UsuarioEntity

        oSuario.IdUsuario = Me.TxtId.Text
        oSuario.IdRol = Me.CbbUsuario.SelectedValue
        oSuario.UserName = Me.TxtUsuario.Text
        oSuario.Clave = Me.TxtClave.Text
        oSuario.Estado = Me.TxtEstado.Text
        'guardar combobox


        'Paso 3 Mandar a guardar los datos de objetos a la base de datos
        Try
            UsuarioBLL.Save(oSuario)
            MessageBox.Show("Usuario Guardado", "Sistema Gestion Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Information)
            InicializarControles()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Sistema Gestion Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try


    End Sub

    Private Function ValidarDatos() As Boolean
        Dim resultado As Boolean = True

        'Inicializamos los mensajes de las validaciones existentes
        ErrorProvider1.Clear()

        'Verificar que en los campos obligatorio hayan datos
        If String.IsNullOrEmpty(TxtUsuario.Text) Then
            ErrorProvider1.SetError(TxtUsuario, "El Nombre es obligatorio")
            resultado = False
        End If

        If String.IsNullOrEmpty(TxtClave.Text) Then
            ErrorProvider1.SetError(TxtClave, "La clave es obligatoria")
            resultado = False
        End If

        Return resultado
    End Function



    'Private Sub btnAgregarCategoria_Click(sender As Object, e As EventArgs) Handles btnAgregarCategoria.Click
    '    Dim frm As New frmCategoria
    '    frm.ShowDialog()
    '    CargarCategorias()

    'End Sub

    'Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
    '    'Mostramos el formulario de busqueda de articulo
    '    Dim frm As New BusquedaArticulos
    '    If frm.ShowDialog() = DialogResult.OK Then
    '        'Si el el usario selecciono un articulo entonces obtenemos el id
    '        'del articulo seleccionado y lo cargamos desde la base de datos

    '        Dim oArticulo As ArticuloEntity = ArticuloBLL.GetById(frm.IdArticulo)

    '        'Mostramos los datos en los controles
    '        Me.txtId.Text = oArticulo.ID
    '        Me.txtNombre.Text = oArticulo.Nombre
    '        Me.txtDescripcion.Text = oArticulo.Descripcion
    '        Me.txtPrecioCompra.Text = oArticulo.PrecioCompra
    '        Me.txtPrecioVenta.Text = oArticulo.PrecioVenta
    '        Me.txtStock.Text = oArticulo.Stock
    '        Me.cbbCategoria.SelectedValue = oArticulo.IdCategoria
    '    End If
    'End Sub

    Private Sub FrmUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarRol() 'al iniciar el formulario se mostraran las categorias
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        'Decimos que si le dan al encabesado del datagridview se salga

        If e.RowIndex = -1 Then

            Exit Sub

        End If

        'Declaramos una variable row tipo datagridviewrow igualada al datagridview con la propiedad currentrow

        Dim row As DataGridViewRow = Me.DataGridView1.CurrentRow

        'Cargamos los datos de la celdas a los controles TexBox

        Me.TxtId.Text = row.Cells("IdUsuario").Value
        Me.TxtUsuario.Text = row.Cells("UserName").Value
        Me.TxtClave.Text = row.Cells("Clave").Value
        Me.TxtEstado.Text = row.Cells("Estado").Value
        Me.CbbUsuario.SelectedValue = row.Cells("IdRol").Value
        'combobox
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click
        Me.Hide()
        FrmMenuAvanzado.Show()

    End Sub
End Class