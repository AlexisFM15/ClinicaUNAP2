<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBusquedaUsuario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.DgvUsuario = New System.Windows.Forms.DataGridView()
        Me.IdUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rol = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Clave = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DgvUsuario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(455, 52)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 0
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(12, 52)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(437, 20)
        Me.TxtBuscar.TabIndex = 1
        '
        'DgvUsuario
        '
        Me.DgvUsuario.AllowUserToAddRows = False
        Me.DgvUsuario.AllowUserToDeleteRows = False
        Me.DgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvUsuario.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdUsuario, Me.Rol, Me.Nombre, Me.Clave, Me.Estado})
        Me.DgvUsuario.Location = New System.Drawing.Point(12, 97)
        Me.DgvUsuario.Name = "DgvUsuario"
        Me.DgvUsuario.ReadOnly = True
        Me.DgvUsuario.Size = New System.Drawing.Size(544, 224)
        Me.DgvUsuario.TabIndex = 21
        '
        'IdUsuario
        '
        Me.IdUsuario.DataPropertyName = "IdUsuario"
        Me.IdUsuario.HeaderText = "ID"
        Me.IdUsuario.Name = "IdUsuario"
        Me.IdUsuario.ReadOnly = True
        '
        'Rol
        '
        Me.Rol.DataPropertyName = "IdRol"
        Me.Rol.HeaderText = "Rol"
        Me.Rol.Name = "Rol"
        Me.Rol.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Usuario"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Clave
        '
        Me.Clave.DataPropertyName = "Clave"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Clave.DefaultCellStyle = DataGridViewCellStyle1
        Me.Clave.HeaderText = "Clave"
        Me.Clave.Name = "Clave"
        Me.Clave.ReadOnly = True
        '
        'Estado
        '
        Me.Estado.DataPropertyName = "Estado"
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        '
        'FrmBusquedaUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 332)
        Me.Controls.Add(Me.DgvUsuario)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Name = "FrmBusquedaUsuario"
        Me.Text = "FrmBusquedaUsuario"
        CType(Me.DgvUsuario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnBuscar As Windows.Forms.Button
    Friend WithEvents TxtBuscar As Windows.Forms.TextBox
    Friend WithEvents DgvUsuario As Windows.Forms.DataGridView
    Friend WithEvents IdUsuario As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rol As Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Nombre As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Clave As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estado As Windows.Forms.DataGridViewTextBoxColumn
End Class
