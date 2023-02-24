<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMedico
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
        Me.DgvMedico = New System.Windows.Forms.DataGridView()
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.BtnEspecialidad = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.CbbEspecialidad = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TxtEdad = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtTelefono = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TxtDireccion = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
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
        Me.TxtIdMedico = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.IdMedico = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Recinto = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Especialidad = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Cedula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Edad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DgvMedico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DgvMedico
        '
        Me.DgvMedico.AllowUserToAddRows = False
        Me.DgvMedico.AllowUserToDeleteRows = False
        Me.DgvMedico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvMedico.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdMedico, Me.Recinto, Me.Especialidad, Me.Nombre, Me.Apellido, Me.Cedula, Me.Edad, Me.Telefono, Me.Direccion})
        Me.DgvMedico.Location = New System.Drawing.Point(388, 142)
        Me.DgvMedico.Name = "DgvMedico"
        Me.DgvMedico.ReadOnly = True
        Me.DgvMedico.Size = New System.Drawing.Size(628, 266)
        Me.DgvMedico.TabIndex = 80
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(385, 43)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(150, 61)
        Me.BtnBuscar.TabIndex = 79
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'BtnEspecialidad
        '
        Me.BtnEspecialidad.Location = New System.Drawing.Point(201, 126)
        Me.BtnEspecialidad.Name = "BtnEspecialidad"
        Me.BtnEspecialidad.Size = New System.Drawing.Size(28, 21)
        Me.BtnEspecialidad.TabIndex = 78
        Me.BtnEspecialidad.Text = "..."
        Me.BtnEspecialidad.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 127)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 13)
        Me.Label12.TabIndex = 77
        Me.Label12.Text = "Especialidad"
        '
        'CbbEspecialidad
        '
        Me.CbbEspecialidad.FormattingEnabled = True
        Me.CbbEspecialidad.Location = New System.Drawing.Point(74, 126)
        Me.CbbEspecialidad.Name = "CbbEspecialidad"
        Me.CbbEspecialidad.Size = New System.Drawing.Size(121, 21)
        Me.CbbEspecialidad.TabIndex = 76
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 277)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 13)
        Me.Label11.TabIndex = 75
        Me.Label11.Text = "Edad"
        '
        'TxtEdad
        '
        Me.TxtEdad.Location = New System.Drawing.Point(74, 270)
        Me.TxtEdad.Name = "TxtEdad"
        Me.TxtEdad.Size = New System.Drawing.Size(44, 20)
        Me.TxtEdad.TabIndex = 74
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 306)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 73
        Me.Label10.Text = "Telefono"
        '
        'TxtTelefono
        '
        Me.TxtTelefono.Location = New System.Drawing.Point(74, 299)
        Me.TxtTelefono.Name = "TxtTelefono"
        Me.TxtTelefono.Size = New System.Drawing.Size(142, 20)
        Me.TxtTelefono.TabIndex = 72
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 332)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "Direccion"
        '
        'TxtDireccion
        '
        Me.TxtDireccion.Location = New System.Drawing.Point(74, 325)
        Me.TxtDireccion.Name = "TxtDireccion"
        Me.TxtDireccion.Size = New System.Drawing.Size(305, 20)
        Me.TxtDireccion.TabIndex = 70
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(382, 126)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 13)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "Vista Reciente"
        '
        'BtnRecinto
        '
        Me.BtnRecinto.Location = New System.Drawing.Point(201, 100)
        Me.BtnRecinto.Name = "BtnRecinto"
        Me.BtnRecinto.Size = New System.Drawing.Size(28, 21)
        Me.BtnRecinto.TabIndex = 68
        Me.BtnRecinto.Text = "..."
        Me.BtnRecinto.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(3, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "Recinto"
        '
        'CbbRecinto
        '
        Me.CbbRecinto.FormattingEnabled = True
        Me.CbbRecinto.Location = New System.Drawing.Point(74, 100)
        Me.CbbRecinto.Name = "CbbRecinto"
        Me.CbbRecinto.Size = New System.Drawing.Size(121, 21)
        Me.CbbRecinto.TabIndex = 66
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Location = New System.Drawing.Point(857, 43)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(156, 61)
        Me.BtnRegresar.TabIndex = 65
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(541, 43)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(150, 61)
        Me.BtnNuevo.TabIndex = 64
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(697, 43)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(154, 61)
        Me.BtnGuardar.TabIndex = 63
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 251)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Cedula"
        '
        'label30
        '
        Me.label30.AutoSize = True
        Me.label30.Location = New System.Drawing.Point(3, 224)
        Me.label30.Name = "label30"
        Me.label30.Size = New System.Drawing.Size(44, 13)
        Me.label30.TabIndex = 61
        Me.label30.Text = "Apellido"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Nombre"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "ID"
        '
        'TxtApellido
        '
        Me.TxtApellido.Location = New System.Drawing.Point(74, 217)
        Me.TxtApellido.Name = "TxtApellido"
        Me.TxtApellido.Size = New System.Drawing.Size(206, 20)
        Me.TxtApellido.TabIndex = 58
        '
        'TxtCedula
        '
        Me.TxtCedula.Location = New System.Drawing.Point(74, 244)
        Me.TxtCedula.Name = "TxtCedula"
        Me.TxtCedula.Size = New System.Drawing.Size(169, 20)
        Me.TxtCedula.TabIndex = 57
        '
        'TxtNombre
        '
        Me.TxtNombre.Location = New System.Drawing.Point(74, 186)
        Me.TxtNombre.Name = "TxtNombre"
        Me.TxtNombre.Size = New System.Drawing.Size(100, 20)
        Me.TxtNombre.TabIndex = 56
        '
        'TxtIdMedico
        '
        Me.TxtIdMedico.Location = New System.Drawing.Point(74, 60)
        Me.TxtIdMedico.Name = "TxtIdMedico"
        Me.TxtIdMedico.ReadOnly = True
        Me.TxtIdMedico.Size = New System.Drawing.Size(100, 20)
        Me.TxtIdMedico.TabIndex = 55
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'IdMedico
        '
        Me.IdMedico.DataPropertyName = "IdMedico"
        Me.IdMedico.HeaderText = "ID"
        Me.IdMedico.Name = "IdMedico"
        Me.IdMedico.ReadOnly = True
        Me.IdMedico.Width = 50
        '
        'Recinto
        '
        Me.Recinto.HeaderText = "Recinto"
        Me.Recinto.Name = "Recinto"
        Me.Recinto.ReadOnly = True
        '
        'Especialidad
        '
        Me.Especialidad.HeaderText = "Especialidad"
        Me.Especialidad.Name = "Especialidad"
        Me.Especialidad.ReadOnly = True
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
        'FrmMedico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 450)
        Me.Controls.Add(Me.DgvMedico)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Controls.Add(Me.BtnEspecialidad)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.CbbEspecialidad)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TxtEdad)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.TxtTelefono)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TxtDireccion)
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
        Me.Controls.Add(Me.TxtIdMedico)
        Me.Name = "FrmMedico"
        Me.Text = "FrmMedico"
        CType(Me.DgvMedico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DgvMedico As Windows.Forms.DataGridView
    Friend WithEvents BtnBuscar As Windows.Forms.Button
    Friend WithEvents BtnEspecialidad As Windows.Forms.Button
    Friend WithEvents Label12 As Windows.Forms.Label
    Friend WithEvents CbbEspecialidad As Windows.Forms.ComboBox
    Friend WithEvents Label11 As Windows.Forms.Label
    Friend WithEvents TxtEdad As Windows.Forms.TextBox
    Friend WithEvents Label10 As Windows.Forms.Label
    Friend WithEvents TxtTelefono As Windows.Forms.TextBox
    Friend WithEvents Label9 As Windows.Forms.Label
    Friend WithEvents TxtDireccion As Windows.Forms.TextBox
    Friend WithEvents Label6 As Windows.Forms.Label
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
    Friend WithEvents TxtIdMedico As Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As Windows.Forms.ErrorProvider
    Friend WithEvents IdMedico As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Recinto As Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Especialidad As Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents Nombre As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellido As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Cedula As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Edad As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefono As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Direccion As Windows.Forms.DataGridViewTextBoxColumn
End Class
