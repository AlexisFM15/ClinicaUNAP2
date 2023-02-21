<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMenuBasico
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.MantenimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicamentosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicamentosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeguroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CitaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaBasicaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MedicamentosToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PacienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CitasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReporteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ControlDeCitasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MantenimientoToolStripMenuItem, Me.ConsultaBasicaToolStripMenuItem, Me.ControlDeCitasToolStripMenuItem, Me.ReporteToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'MantenimientoToolStripMenuItem
        '
        Me.MantenimientoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MedicamentosToolStripMenuItem1, Me.MedicamentosToolStripMenuItem, Me.SeguroToolStripMenuItem, Me.ConsultaToolStripMenuItem, Me.CitaToolStripMenuItem})
        Me.MantenimientoToolStripMenuItem.Name = "MantenimientoToolStripMenuItem"
        Me.MantenimientoToolStripMenuItem.Size = New System.Drawing.Size(104, 20)
        Me.MantenimientoToolStripMenuItem.Text = "&Mantenimiento "
        '
        'MedicamentosToolStripMenuItem1
        '
        Me.MedicamentosToolStripMenuItem1.Name = "MedicamentosToolStripMenuItem1"
        Me.MedicamentosToolStripMenuItem1.Size = New System.Drawing.Size(153, 22)
        Me.MedicamentosToolStripMenuItem1.Text = "Medicamentos"
        '
        'MedicamentosToolStripMenuItem
        '
        Me.MedicamentosToolStripMenuItem.Name = "MedicamentosToolStripMenuItem"
        Me.MedicamentosToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.MedicamentosToolStripMenuItem.Text = "Paciente"
        '
        'SeguroToolStripMenuItem
        '
        Me.SeguroToolStripMenuItem.Name = "SeguroToolStripMenuItem"
        Me.SeguroToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.SeguroToolStripMenuItem.Text = "Seguro"
        '
        'ConsultaToolStripMenuItem
        '
        Me.ConsultaToolStripMenuItem.Name = "ConsultaToolStripMenuItem"
        Me.ConsultaToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ConsultaToolStripMenuItem.Text = "Consulta"
        '
        'CitaToolStripMenuItem
        '
        Me.CitaToolStripMenuItem.Name = "CitaToolStripMenuItem"
        Me.CitaToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.CitaToolStripMenuItem.Text = "Cita"
        '
        'ConsultaBasicaToolStripMenuItem
        '
        Me.ConsultaBasicaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MedicamentosToolStripMenuItem2, Me.PacienteToolStripMenuItem, Me.ConsultasToolStripMenuItem, Me.CitasToolStripMenuItem})
        Me.ConsultaBasicaToolStripMenuItem.Name = "ConsultaBasicaToolStripMenuItem"
        Me.ConsultaBasicaToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.ConsultaBasicaToolStripMenuItem.Text = "&Consulta "
        '
        'MedicamentosToolStripMenuItem2
        '
        Me.MedicamentosToolStripMenuItem2.Name = "MedicamentosToolStripMenuItem2"
        Me.MedicamentosToolStripMenuItem2.Size = New System.Drawing.Size(153, 22)
        Me.MedicamentosToolStripMenuItem2.Text = "Medicamentos"
        '
        'PacienteToolStripMenuItem
        '
        Me.PacienteToolStripMenuItem.Name = "PacienteToolStripMenuItem"
        Me.PacienteToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.PacienteToolStripMenuItem.Text = "Paciente"
        '
        'ConsultasToolStripMenuItem
        '
        Me.ConsultasToolStripMenuItem.Name = "ConsultasToolStripMenuItem"
        Me.ConsultasToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ConsultasToolStripMenuItem.Text = "Consultas"
        '
        'CitasToolStripMenuItem
        '
        Me.CitasToolStripMenuItem.Name = "CitasToolStripMenuItem"
        Me.CitasToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.CitasToolStripMenuItem.Text = "Citas"
        '
        'ReporteToolStripMenuItem
        '
        Me.ReporteToolStripMenuItem.Name = "ReporteToolStripMenuItem"
        Me.ReporteToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.ReporteToolStripMenuItem.Text = "Reporte"
        '
        'ControlDeCitasToolStripMenuItem
        '
        Me.ControlDeCitasToolStripMenuItem.Name = "ControlDeCitasToolStripMenuItem"
        Me.ControlDeCitasToolStripMenuItem.Size = New System.Drawing.Size(105, 20)
        Me.ControlDeCitasToolStripMenuItem.Text = "Control De Citas"
        '
        'FrmMenuBasico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "FrmMenuBasico"
        Me.Text = "FrmMenuBasico"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As Windows.Forms.MenuStrip
    Friend WithEvents MantenimientoToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents MedicamentosToolStripMenuItem1 As Windows.Forms.ToolStripMenuItem
    Friend WithEvents MedicamentosToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents SeguroToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents CitaToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaBasicaToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents MedicamentosToolStripMenuItem2 As Windows.Forms.ToolStripMenuItem
    Friend WithEvents PacienteToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultasToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents CitasToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReporteToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ControlDeCitasToolStripMenuItem As Windows.Forms.ToolStripMenuItem
End Class
