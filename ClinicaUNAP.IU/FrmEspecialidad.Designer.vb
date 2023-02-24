<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEspecialidad
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
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.DgvEspecialidad = New System.Windows.Forms.DataGridView()
        Me.IdEspecialidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnNuevo = New System.Windows.Forms.Button()
        Me.BtnGuardar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtTipo = New System.Windows.Forms.TextBox()
        Me.TxtIdEspecialidad = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.DgvEspecialidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Location = New System.Drawing.Point(148, 223)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(65, 34)
        Me.BtnRegresar.TabIndex = 24
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'DgvEspecialidad
        '
        Me.DgvEspecialidad.AllowUserToAddRows = False
        Me.DgvEspecialidad.AllowUserToDeleteRows = False
        Me.DgvEspecialidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvEspecialidad.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdEspecialidad, Me.Tipo})
        Me.DgvEspecialidad.Location = New System.Drawing.Point(350, 43)
        Me.DgvEspecialidad.Name = "DgvEspecialidad"
        Me.DgvEspecialidad.ReadOnly = True
        Me.DgvEspecialidad.Size = New System.Drawing.Size(195, 223)
        Me.DgvEspecialidad.TabIndex = 23
        '
        'IdEspecialidad
        '
        Me.IdEspecialidad.DataPropertyName = "IdEspecialidad"
        Me.IdEspecialidad.HeaderText = "ID"
        Me.IdEspecialidad.Name = "IdEspecialidad"
        Me.IdEspecialidad.ReadOnly = True
        Me.IdEspecialidad.Width = 50
        '
        'Tipo
        '
        Me.Tipo.DataPropertyName = "Tipo"
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        '
        'BtnNuevo
        '
        Me.BtnNuevo.Location = New System.Drawing.Point(14, 223)
        Me.BtnNuevo.Name = "BtnNuevo"
        Me.BtnNuevo.Size = New System.Drawing.Size(59, 34)
        Me.BtnNuevo.TabIndex = 22
        Me.BtnNuevo.Text = "Nuevo"
        Me.BtnNuevo.UseVisualStyleBackColor = True
        '
        'BtnGuardar
        '
        Me.BtnGuardar.Location = New System.Drawing.Point(79, 223)
        Me.BtnGuardar.Name = "BtnGuardar"
        Me.BtnGuardar.Size = New System.Drawing.Size(63, 34)
        Me.BtnGuardar.TabIndex = 21
        Me.BtnGuardar.Text = "Guardar"
        Me.BtnGuardar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 159)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Tipo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "ID"
        '
        'TxtTipo
        '
        Me.TxtTipo.Location = New System.Drawing.Point(75, 151)
        Me.TxtTipo.Name = "TxtTipo"
        Me.TxtTipo.Size = New System.Drawing.Size(269, 20)
        Me.TxtTipo.TabIndex = 18
        '
        'TxtIdEspecialidad
        '
        Me.TxtIdEspecialidad.Location = New System.Drawing.Point(75, 84)
        Me.TxtIdEspecialidad.Name = "TxtIdEspecialidad"
        Me.TxtIdEspecialidad.Size = New System.Drawing.Size(182, 20)
        Me.TxtIdEspecialidad.TabIndex = 17
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'FrmEspecialidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 271)
        Me.Controls.Add(Me.BtnRegresar)
        Me.Controls.Add(Me.DgvEspecialidad)
        Me.Controls.Add(Me.BtnNuevo)
        Me.Controls.Add(Me.BtnGuardar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTipo)
        Me.Controls.Add(Me.TxtIdEspecialidad)
        Me.Name = "FrmEspecialidad"
        Me.Text = "FrmEspecialidad"
        CType(Me.DgvEspecialidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnRegresar As Windows.Forms.Button
    Friend WithEvents DgvEspecialidad As Windows.Forms.DataGridView
    Friend WithEvents BtnNuevo As Windows.Forms.Button
    Friend WithEvents BtnGuardar As Windows.Forms.Button
    Friend WithEvents Label2 As Windows.Forms.Label
    Friend WithEvents Label1 As Windows.Forms.Label
    Friend WithEvents TxtTipo As Windows.Forms.TextBox
    Friend WithEvents TxtIdEspecialidad As Windows.Forms.TextBox
    Friend WithEvents IdEspecialidad As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Tipo As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ErrorProvider1 As Windows.Forms.ErrorProvider
End Class
