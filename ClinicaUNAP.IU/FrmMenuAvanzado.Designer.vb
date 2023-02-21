<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenuAvanzado
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MantenimientoFullToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecintoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuarioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RolToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EspecialidadToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecintoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuarioToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RolToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EspecialidadToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuBasicoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientoFullToolStripMenuItem, Me.ConsultarToolStripMenuItem, Me.MenuBasicoToolStripMenuItem, Me.ReporteToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MantenimientoFullToolStripMenuItem
        '
        Me.MantenimientoFullToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RecintoToolStripMenuItem, Me.UsuarioToolStripMenuItem, Me.RolToolStripMenuItem, Me.EmpleadoToolStripMenuItem, Me.MedicoToolStripMenuItem, Me.EspecialidadToolStripMenuItem})
        Me.MantenimientoFullToolStripMenuItem.Name = "MantenimientoFullToolStripMenuItem"
        Me.MantenimientoFullToolStripMenuItem.Size = New System.Drawing.Size(104, 20)
        Me.MantenimientoFullToolStripMenuItem.Text = "Mantenimiento "
        '
        'RecintoToolStripMenuItem
        '
        Me.RecintoToolStripMenuItem.Name = "RecintoToolStripMenuItem"
        Me.RecintoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RecintoToolStripMenuItem.Text = "Recinto"
        '
        'UsuarioToolStripMenuItem
        '
        Me.UsuarioToolStripMenuItem.Name = "UsuarioToolStripMenuItem"
        Me.UsuarioToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UsuarioToolStripMenuItem.Text = "Usuario"
        '
        'RolToolStripMenuItem
        '
        Me.RolToolStripMenuItem.Name = "RolToolStripMenuItem"
        Me.RolToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RolToolStripMenuItem.Text = "Rol"
        '
        'EmpleadoToolStripMenuItem
        '
        Me.EmpleadoToolStripMenuItem.Name = "EmpleadoToolStripMenuItem"
        Me.EmpleadoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EmpleadoToolStripMenuItem.Text = "Empleado"
        '
        'MedicoToolStripMenuItem
        '
        Me.MedicoToolStripMenuItem.Name = "MedicoToolStripMenuItem"
        Me.MedicoToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MedicoToolStripMenuItem.Text = "Medico"
        '
        'EspecialidadToolStripMenuItem
        '
        Me.EspecialidadToolStripMenuItem.Name = "EspecialidadToolStripMenuItem"
        Me.EspecialidadToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.EspecialidadToolStripMenuItem.Text = "Especialidad"
        '
        'ConsultarToolStripMenuItem
        '
        Me.ConsultarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RecintoToolStripMenuItem1, Me.UsuarioToolStripMenuItem1, Me.RolToolStripMenuItem1, Me.EmpleadoToolStripMenuItem1, Me.MedicoToolStripMenuItem1, Me.EspecialidadToolStripMenuItem1})
        Me.ConsultarToolStripMenuItem.Name = "ConsultarToolStripMenuItem"
        Me.ConsultarToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.ConsultarToolStripMenuItem.Text = "&Consulta "
        '
        'RecintoToolStripMenuItem1
        '
        Me.RecintoToolStripMenuItem1.Name = "RecintoToolStripMenuItem1"
        Me.RecintoToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
        Me.RecintoToolStripMenuItem1.Text = "Recinto"
        '
        'UsuarioToolStripMenuItem1
        '
        Me.UsuarioToolStripMenuItem1.Name = "UsuarioToolStripMenuItem1"
        Me.UsuarioToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
        Me.UsuarioToolStripMenuItem1.Text = "Usuario"
        '
        'RolToolStripMenuItem1
        '
        Me.RolToolStripMenuItem1.Name = "RolToolStripMenuItem1"
        Me.RolToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
        Me.RolToolStripMenuItem1.Text = "Rol"
        '
        'EmpleadoToolStripMenuItem1
        '
        Me.EmpleadoToolStripMenuItem1.Name = "EmpleadoToolStripMenuItem1"
        Me.EmpleadoToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
        Me.EmpleadoToolStripMenuItem1.Text = "Empleado"
        '
        'MedicoToolStripMenuItem1
        '
        Me.MedicoToolStripMenuItem1.Name = "MedicoToolStripMenuItem1"
        Me.MedicoToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
        Me.MedicoToolStripMenuItem1.Text = "Medico"
        '
        'EspecialidadToolStripMenuItem1
        '
        Me.EspecialidadToolStripMenuItem1.Name = "EspecialidadToolStripMenuItem1"
        Me.EspecialidadToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
        Me.EspecialidadToolStripMenuItem1.Text = "Especialidad"
        '
        'MenuBasicoToolStripMenuItem
        '
        Me.MenuBasicoToolStripMenuItem.Name = "MenuBasicoToolStripMenuItem"
        Me.MenuBasicoToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.MenuBasicoToolStripMenuItem.Text = "&Menu Basico"
        '
        'ReporteToolStripMenuItem
        '
        Me.ReporteToolStripMenuItem.Name = "ReporteToolStripMenuItem"
        Me.ReporteToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ReporteToolStripMenuItem.Text = "&Reporte"
        '
        'FrmMenuAvanzado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.Name = "FrmMenuAvanzado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmMenu"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As Windows.Forms.MenuStrip
    Friend WithEvents MantenimientoFullToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecintoToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents RolToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpleadoToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents MedicoToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents EspecialidadToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultarToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecintoToolStripMenuItem1 As Windows.Forms.ToolStripMenuItem
    Friend WithEvents UsuarioToolStripMenuItem1 As Windows.Forms.ToolStripMenuItem
    Friend WithEvents RolToolStripMenuItem1 As Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpleadoToolStripMenuItem1 As Windows.Forms.ToolStripMenuItem
    Friend WithEvents MedicoToolStripMenuItem1 As Windows.Forms.ToolStripMenuItem
    Friend WithEvents EspecialidadToolStripMenuItem1 As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuBasicoToolStripMenuItem As Windows.Forms.ToolStripMenuItem
End Class
