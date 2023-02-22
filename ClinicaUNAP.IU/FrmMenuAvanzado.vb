Imports System.Windows.Forms

Public Class FrmMenuAvanzado
    Private Sub RecintoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RecintoToolStripMenuItem.Click


        FrmRecinto.Show()

    End Sub

    Private Sub MenuBasicoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MenuBasicoToolStripMenuItem.Click

        Dim frm As New FrmMenuBasico
        frm.MdiParent = Me
        frm.Show()


    End Sub

    Private Sub RolToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RolToolStripMenuItem.Click

        FrmRol.Show()
    End Sub

    Private Sub UsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuarioToolStripMenuItem.Click

        FrmUsuario.Show()
    End Sub
End Class