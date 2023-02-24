Imports System.Windows.Forms
Imports ClinicaUNAP.BLL

Public Class FrmBuscarRecinto
    'Esta propiedad nos sirve para almacenar el id de la fila seleccionado por el usuario

    Private _idRecin As Integer

    Public ReadOnly Property IdRecint() As Integer

        Get
            Return _idRecin
        End Get
    End Property

    Private Sub FrmBuscarRecinto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Este evento se genera cuando el formulario esta cargando

        'Cargamos todos los objetos
        Dgv.AutoGenerateColumns = False
        Dgv.DataSource = RecintoBLL.GetAll

        'Cargamos los datos de la columna combobox del datagridview

        ' Dim colCategoria As DataGridViewComboBoxColumn = Dgv.Columns.Item("Categoria")
        'colCategoria.DataSource = CategoriaBLL.GetAll
        ' colCategoria.DisplayMember = "Nombre"
        ' colCategoria.ValueMember = "ID"

        'Esta propiedad es de la entidad secundaria Articulo
        'colCategoria.DataPropertyName = "IdCategoria"

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles BtnBuscar.Click
        'Llamamos la consulta que nos permite buscar por diversos parametros

        Dgv.DataSource = RecintoBLL.GetByValor(Me.TxtBuscar.Text)
    End Sub

    Private Sub Dgv_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles Dgv.CellDoubleClick
        'Evitar que se seleccione el encabezado del datagridview
        If e.RowIndex = -1 Then
            Return
        End If


        'Obtenemos el ID de la fila seleccionada
        _idRecin = Dgv.CurrentRow.Cells("IdRecinto").Value

        'Indicamos que se selecciono una fila
        Me.DialogResult = DialogResult.OK
        Close()

    End Sub

End Class