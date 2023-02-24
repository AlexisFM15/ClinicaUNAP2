<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmBuscarRecinto
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
        Me.BtnBuscar = New System.Windows.Forms.Button()
        Me.TxtBuscar = New System.Windows.Forms.TextBox()
        Me.Dgv = New System.Windows.Forms.DataGridView()
        Me.IdRecinto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ubicacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnBuscar
        '
        Me.BtnBuscar.Location = New System.Drawing.Point(321, 46)
        Me.BtnBuscar.Name = "BtnBuscar"
        Me.BtnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.BtnBuscar.TabIndex = 1
        Me.BtnBuscar.Text = "Buscar"
        Me.BtnBuscar.UseVisualStyleBackColor = True
        '
        'TxtBuscar
        '
        Me.TxtBuscar.Location = New System.Drawing.Point(12, 46)
        Me.TxtBuscar.Name = "TxtBuscar"
        Me.TxtBuscar.Size = New System.Drawing.Size(303, 20)
        Me.TxtBuscar.TabIndex = 2
        '
        'Dgv
        '
        Me.Dgv.AllowUserToAddRows = False
        Me.Dgv.AllowUserToDeleteRows = False
        Me.Dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdRecinto, Me.Nombre, Me.Ubicacion, Me.Direccion})
        Me.Dgv.Location = New System.Drawing.Point(12, 95)
        Me.Dgv.Name = "Dgv"
        Me.Dgv.ReadOnly = True
        Me.Dgv.Size = New System.Drawing.Size(458, 168)
        Me.Dgv.TabIndex = 10
        '
        'IdRecinto
        '
        Me.IdRecinto.DataPropertyName = "IdRecinto"
        Me.IdRecinto.HeaderText = "ID"
        Me.IdRecinto.Name = "IdRecinto"
        Me.IdRecinto.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Ubicacion
        '
        Me.Ubicacion.DataPropertyName = "Ubicacion"
        Me.Ubicacion.HeaderText = "Ubicacion"
        Me.Ubicacion.Name = "Ubicacion"
        Me.Ubicacion.ReadOnly = True
        Me.Ubicacion.Width = 125
        '
        'Direccion
        '
        Me.Direccion.DataPropertyName = "Direccion"
        Me.Direccion.HeaderText = "Direccion"
        Me.Direccion.Name = "Direccion"
        Me.Direccion.ReadOnly = True
        Me.Direccion.Width = 125
        '
        'FrmBuscarRecinto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 417)
        Me.Controls.Add(Me.Dgv)
        Me.Controls.Add(Me.TxtBuscar)
        Me.Controls.Add(Me.BtnBuscar)
        Me.Name = "FrmBuscarRecinto"
        Me.Text = "FrmBuscarRecinto"
        CType(Me.Dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnBuscar As Windows.Forms.Button
    Friend WithEvents TxtBuscar As Windows.Forms.TextBox
    Friend WithEvents Dgv As Windows.Forms.DataGridView
    Friend WithEvents IdRecinto As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ubicacion As Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Direccion As Windows.Forms.DataGridViewTextBoxColumn
End Class
