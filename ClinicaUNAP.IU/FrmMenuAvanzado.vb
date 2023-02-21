Imports System.Windows.Forms

Public Class FrmMenuAvanzado
    Private Sub RecintoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecintoToolStripMenuItem.Click

        Me.Hide()
        FrmRecinto.Show()

    End Sub

    Private Sub MenuBasicoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuBasicoToolStripMenuItem.Click

        Dim frm As New FrmMenuBasico
        frm.MdiParent = Me
        frm.Show()


    End Sub

    Private Sub RolToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RolToolStripMenuItem.Click
        Me.Hide()
        FrmRol.Show()
    End Sub

    Private Sub UsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuarioToolStripMenuItem.Click
        Me.Hide()
        FrmUsuario.Show()
    End Sub
End Class