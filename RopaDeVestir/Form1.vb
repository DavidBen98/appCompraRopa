Public Class Form1
    Public cant As Integer
    Private Sub CargarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarToolStripMenuItem.Click
        Dim F2 As CargarRopa = New CargarRopa
        CargarRopa.ShowDialog()
    End Sub
    Private Sub ConsultarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultarToolStripMenuItem.Click
        Dim F3 As Detalles_del_pago = New Detalles_del_pago

        Detalles_del_pago.ShowDialog()
    End Sub
    Private Sub BorrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrarToolStripMenuItem.Click
        For i = 1 To cant
            CargarRopa.cliente(i).DNI = vbNull
            CargarRopa.cliente(i).apellidonom = vbNull
            CargarRopa.cliente(i).nroFactura = vbNull
            CargarRopa.cliente(i).importe = vbNull
            CargarRopa.cliente(i).producto = vbNull
            CargarRopa.cliente(i).tarjeta = vbNull
        Next
        CargarRopa.cant = 0
        MsgBox("Se ha eliminado correctamente")
    End Sub
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class