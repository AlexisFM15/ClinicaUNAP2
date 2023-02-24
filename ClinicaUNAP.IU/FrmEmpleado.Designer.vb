<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEmpleado
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
        Me.components = New System.ComponentModel.Container()
        Me.BtnRecinto = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CbbRecinto = New System.Windows.Forms.ComboBox()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.label30 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtApellido = New System.Windows.Forms.TextBox()
        Me.TxtCedula = New System.Windows.Forms.TextBox()
        Me.TxtNombre = New System.Windows.Forms.TextBox()
        Me.TxtIdEmpleado = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TxtCargo = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtEdad = New System.Windows.Forms.TextBox()
        Me.BtnUsuario = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CbbUsuario = New System.Windows.Forms.ComboBox()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.DgvEmpleado = New System.Windows.Forms.DataGridView()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.IdEmpleado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdRecinto = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.IdUsuario = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cedula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Edad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DgvEmpleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnRecinto
        '
        Me.BtnRecinto.Location = New System.Drawing.Point(210, 130)
        Me.BtnRecinto.Name = "BtnRecinto"
        Me.BtnRecinto.Size = New System.Drawing.Size(28, 21)
        Me.BtnRecinto.TabIndex = 38
        Me.BtnRecinto.Text = "..."
        Me.BtnRecinto.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Recinto"
        '
        'CbbRecinto
        '
        Me.CbbRecinto.FormattingEnabled = True
        Me.CbbRecinto.Location = New System.Drawing.Point(83, 130)
        Me.CbbRecinto.Name = "CbbRecinto"
        Me.CbbRecinto.Size = New System.Drawing.Size(121, 21)
        Me.CbbRecinto.TabIndex = 36
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Location = New System.Drawing.Point(866, 73)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(156, 61)
        Me.BtnRegresar.TabIndex = 34
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(550, 73)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(150, 61)
        Me.BtnNuevo.TabIndex = 33
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(706, 73)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(154, 61)
        Me.BtnGuardar.TabIndex = 32
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 281)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Cedula"
        '
        'label30
        '
        Me.label30.AutoSize = True
        Me.label30.Location = New System.Drawing.Point(25, 254)
        Me.label30.Name = "label30"
        Me.label30.Size = New System.Drawing.Size(44, 13)
        Me.label30.TabIndex = 30
        Me.label30.Text = "Apellido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 223)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 97)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "ID"
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(83, 247)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(206, 20)
        Me.TxtApellido.TabIndex = 27
        '
        'TxtCedula
        '
        Me.TxtCedula.Location = New System.Drawing.Point(83, 274)
        Me.TxtCedula.Name = "TxtCedula"
        Me.TxtCedula.Size = New System.Drawing.Size(169, 20)
        Me.TxtCedula.TabIndex = 26
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(83, 216)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(100, 20)
        Me.TxtNombre.TabIndex = 25
        '
        'TxtIdEmpleado
        '
        Me.TxtIdEmpleado.Location = New System.Drawing.Point(83, 90)
        Me.TxtIdEmpleado.Name = "TxtIdEmpleado"
        Me.TxtIdEmpleado.ReadOnly = True
        Me.TxtIdEmpleado.Size = New System.Drawing.Size(100, 20)
        Me.TxtIdEmpleado.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(391, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 39
        Me.Label6.Text = "Vista Reciente"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 388)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 43
        Me.Label8.Text = "Cargo"
        '
        'TxtCargo
        '
        Me.TxtCargo.Location = New System.Drawing.Point(83, 381)
        Me.TxtCargo.Name = "TxtCargo"
        Me.TxtCargo.Size = New System.Drawing.Size(155, 20)
        Me.TxtCargo.TabIndex = 42
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(25, 362)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 45
        Me.Label9.Text = "Direccion"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(83, 355)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(305, 20)
        Me.TxtDireccion.TabIndex = 44
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(25, 336)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 47
        Me.Label10.Text = "Telefono"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(83, 329)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(142, 20)
        Me.TxtTelefono.TabIndex = 46
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(25, 307)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 13)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "Edad"
        '
        'TxtEdad
        '
        Me.TxtEdad.Location = New System.Drawing.Point(83, 300)
        Me.TxtEdad.Name = "TxtEdad"
        Me.TxtEdad.Size = New System.Drawing.Size(44, 20)
        Me.TxtEdad.TabIndex = 48
        '
        'BtnUsuario
        '
        Me.BtnUsuario.Location = New System.Drawing.Point(210, 157)
        Me.BtnUsuario.Name = "BtnUsuario"
        Me.BtnUsuario.Size = New System.Drawing.Size(28, 21)
        Me.BtnUsuario.TabIndex = 52
        Me.BtnUsuario.Text = "..."
        Me.BtnUsuario.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(25, 157)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 13)
        Me.Label12.TabIndex = 51
        Me.Label12.Text = "Usuario"
        '
        'CbbUsuario
        '
        Me.CbbUsuario.FormattingEnabled = True
        Me.CbbUsuario.Location = New System.Drawing.Point(83, 157)
        Me.CbbUsuario.Name = "CbbUsuario"
        Me.CbbUsuario.Size = New System.Drawing.Size(121, 21)
        Me.CbbUsuario.TabIndex = 50
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(394, 73)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(150, 61)
        Me.BtnBuscar.TabIndex = 53
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'DgvEmpleado
        '
        Me.DgvEmpleado.AllowUserToAddRows = False
        Me.DgvEmpleado.AllowUserToDeleteRows = False
        Me.DgvEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEmpleado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdEmpleado, Me.IdRecinto, Me.IdUsuario, Me.Nombre, Me.Apellido, Me.Cedula, Me.Edad, Me.Telefono, Me.Direccion, Me.Cargo})
        Me.DgvEmpleado.Location = New System.Drawing.Point(394, 172)
        Me.DgvEmpleado.Name = "DgvEmpleado"
        Me.DgvEmpleado.ReadOnly = True
        Me.DgvEmpleado.Size = New System.Drawing.Size(628, 266)
        Me.DgvEmpleado.TabIndex = 54
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'IdEmpleado
        '
        Me.IdEmpleado.DataPropertyName = "IdEmpleado"
        Me.IdEmpleado.HeaderText = "ID"
        Me.IdEmpleado.Name = "IdEmpleado"
        Me.IdEmpleado.ReadOnly = True
        Me.IdEmpleado.Width = 50
        '
        'IdRecinto
        '
        Me.IdRecinto.HeaderText = "Recinto"
        Me.IdRecinto.Name = "IdRecinto"
        Me.IdRecinto.ReadOnly = True
        '
        'IdUsuario
        '
        Me.IdUsuario.HeaderText = "Usuario"
        Me.IdUsuario.Name = "IdUsuario"
        Me.IdUsuario.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Apellido
        '
        Me.Apellido.DataPropertyName = "Apellido"
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        Me.Apellido.ReadOnly = True
        '
        'Cedula
        '
        Me.Cedula.DataPropertyName = "Cedula"
        Me.Cedula.HeaderText = "Cedula"
        Me.Cedula.Name = "Cedula"
        Me.Cedula.ReadOnly = True
        '
        'Edad
        '
        Me.Edad.DataPropertyName = "Edad"
        Me.Edad.HeaderText = "Edad"
        Me.Edad.Name = "Edad"
        Me.Edad.ReadOnly = True
        '
        'Telefono
        '
        Me.Telefono.DataPropertyName = "Telefono"
        Me.Telefono.HeaderText = "Telefono"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.ReadOnly = True
        '
        'Direccion
        '
        Me.Direccion.DataPropertyName = "Direccion"
        Me.Direccion.HeaderText = "Direccion"
        Me.Direccion.Name = "Direccion"
        Me.Direccion.ReadOnly = True
        '
        'Cargo
        '
        Me.Cargo.DataPropertyName = "Cargo"
        Me.Cargo.HeaderText = "Cargo"
        Me.Cargo.Name = "Cargo"
        Me.Cargo.ReadOnly = True
        '
        'FrmEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1026, 450)
        Me.Controls.Add(Me.DgvEmpleado)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnUsuario)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.CbbUsuario)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtEdad)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtTelefono)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtDireccion)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TxtCargo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BtnRecinto)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CbbRecinto)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.label30)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtApellido)
        Me.Controls.Add(Me.TxtCedula)
        Me.Controls.Add(Me.TxtNombre)
        Me.Controls.Add(Me.TxtIdEmpleado)
        Me.Name = "FrmEmpleado"
        Me.Text = "FrmEmpleado"
        CType(Me.DgvEmpleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnRecinto As Windows.Forms.Button
    Friend WithEvents Label5 As Windows.Forms.Label
    Friend WithEvents CbbRecinto As Windows.Forms.ComboBox
    Friend WithEvents BtnRegresar As Windows.Forms.Button
    Friend WithEvents BtnNuevo As Windows.Forms.Button
    Friend WithEvents BtnGuardar As Windows.Forms.Button
    Friend WithEvents Label4 As Windows.Forms.Label
    Friend WithEvents label30 As Windows.Forms.Label
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents TxtApellido As Windows.Forms.TextBox
    Friend WithEvents TxtCedula As Windows.Forms.TextBox
    Friend WithEvents TxtNombre As Windows.Forms.TextBox
    Friend WithEvents TxtIdEmpleado As Windows.Forms.TextBox
    Friend WithEvents Label6 As Windows.Forms.Label
    Friend WithEvents Label8 As Windows.Forms.Label
    Friend WithEvents TxtCargo As Windows.Forms.TextBox
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents TxtDireccion As Windows.Forms.TextBox
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents TxtTelefono As Windows.Forms.TextBox
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents TxtEdad As Windows.Forms.TextBox
    Friend WithEvents BtnUsuario As Windows.Forms.Button
    Friend WithEvents Label12 As Windows.Forms.Label
    Friend WithEvents CbbUsuario As Windows.Forms.ComboBox
    Friend WithEvents BtnBuscar As Windows.Forms.Button
    Friend WithEvents DgvEmpleado As Windows.Forms.DataGridView
    Friend WithEvents ErrorProvider1 As Windows.Forms.ErrorProvider
    Friend WithEvents IdEmpleado As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IdRecinto As Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents IdUsuario As Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Nombre As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellido As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cedula As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Edad As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefono As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Direccion As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cargo As Windows.Forms.DataGridViewTextBoxColumn
End Class
