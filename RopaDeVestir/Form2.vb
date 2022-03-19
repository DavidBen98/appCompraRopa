Public Class CargarRopa
    Public cliente(30) As tipo_cliente
    Public cant As Integer
    Structure tipo_cliente
        Public DNI As String
        Public apellidonom As String
        Public nroFactura As Integer
        Public importe As Decimal
        Public producto As String
        Public tarjeta As String
    End Structure
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If Char.IsDigit(e.KeyChar) Or (Asc(e.KeyChar) = 8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If Char.IsLetter(e.KeyChar) Or (Asc(e.KeyChar) = 32) Or (Asc(e.KeyChar) = 8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox3.KeyPress
        If Char.IsDigit(e.KeyChar) Or (Asc(e.KeyChar) = 8) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
    Private Sub TextBox1_Leave(sender As Object, e As EventArgs) Handles TextBox1.Leave
        If TextBox1.Text = "" Then
            MsgBox("DNI vacio")
            TextBox1.Focus()
        End If
    End Sub
    Private Sub TextBox2_Leave(sender As Object, e As EventArgs) Handles TextBox2.Leave
        If TextBox2.Text = "" Then
            MsgBox("ApellidoNombre vacio")
            TextBox2.Focus()
        End If
    End Sub
    Private Sub TextBox3_Leave(sender As Object, e As EventArgs) Handles TextBox3.Leave
        If TextBox3.Text = "" Then
            MsgBox("Nro Factura vacio")
            TextBox3.Focus()
        End If
    End Sub
    Public Sub tarjeta(uno, dos, tres)
        If uno.checked Then
            cliente(cant).tarjeta = uno.text
        ElseIf dos.checked Then
            cliente(cant).tarjeta = dos.text
        Else
            cliente(cant).tarjeta = tres.text
        End If
    End Sub
    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        Dim repetido As Boolean
        Dim factura As Integer
        Dim producto As String

        repetido = False
        i = 0
        factura = TextBox3.Text
        producto = ComboBox1.Text

        Do
            If (factura = cliente(i).nroFactura) And (producto = cliente(i).producto) Then
                repetido = True
            Else
                i = i + 1
            End If
        Loop Until (repetido = True) Or (i = cant)

        If (cant <= 30) And (repetido = False) Then
            cliente(cant).DNI = TextBox1.Text
            cliente(cant).apellidonom = TextBox2.Text
            cliente(cant).nroFactura = TextBox3.Text
            cliente(cant).importe = MaskedTextBox1.Text / 100
            cliente(cant).producto = ComboBox1.Text
            tarjeta(RadioButton1, RadioButton2, RadioButton3)
            cant = cant + 1
            Detalles_del_pago.largo = cant
            Form1.cant = cant
            MsgBox("Se ha guardado correctamente")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            MaskedTextBox1.Text = ""
            ComboBox1.SelectedIndex = -1
            RadioButton1.Checked = False
            RadioButton2.Checked = False
            RadioButton3.Checked = False
        ElseIf cant > 30 Then
            MsgBox("La lista esta llena", vbExclamation)
            Me.Close()
        ElseIf repetido = True Then
            MsgBox("Ya existe este numero de factura para este producto", vbExclamation)
            TextBox3.Text = ""
        End If
        TextBox1.Focus()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub RadioButton1_Click(sender As Object, e As EventArgs) Handles RadioButton1.Click
        Dim visa As String
        visa = "C:\Users\david\Downloads\RopaDeVestir\visa.png"

        PictureBox1.Image = Image.FromFile(visa)
    End Sub
    Private Sub RadioButton2_Click(sender As Object, e As EventArgs) Handles RadioButton2.Click
        Dim master As String

        master = "C:\Users\david\Downloads\RopaDeVestir\mastercard.png"
        PictureBox1.Image = Image.FromFile(master)
    End Sub
    Private Sub RadioButton3_Click(sender As Object, e As EventArgs) Handles RadioButton3.Click
        Dim american As String = ".\american.png"
        PictureBox1.Image = Image.FromFile(american)
    End Sub
    Private Sub CargarRopa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Enabled = False
        cant = 1
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.SelectedIndex = -1
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        MaskedTextBox1.Text = ""
    End Sub
    Private Function activar() As Boolean
        Dim seleccion, habilitar As Boolean
        Dim a = MaskedTextBox1.Text
        Dim b As Single
        Dim esta As Integer
        'HABILITAR BOTON ACEPTAR

        habilitar = False
        seleccion = False

        If ((TextBox1.TextLength > 0) And (TextBox2.TextLength > 0) And (TextBox3.TextLength > 0)) Then
            habilitar = True
        Else
            habilitar = False
        End If

        esta = InStr(a, " ")   'BUSCO SI NO SE COMPLETO EL NUMERO
        If ComboBox1.SelectedIndex <> -1 And esta = 0 Then
            seleccion = True
            b = Val(a)
        Else
            seleccion = False
        End If

        If seleccion And habilitar Then
            If (RadioButton3.Checked = True Or RadioButton2.Checked = True Or RadioButton1.Checked = True) Then
                activar = True
            Else
                activar = False
            End If
        Else
            activar = False
        End If

        If activar = True Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Function
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) _
        Handles TextBox1.TextChanged, TextBox2.TextChanged, TextBox3.TextChanged
        activar()
    End Sub
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged, RadioButton2.CheckedChanged, RadioButton1.CheckedChanged
        activar()
    End Sub
    Private Sub MaskedTextBox1_TextChanged(sender As Object, e As EventArgs) Handles MaskedTextBox1.TextChanged
        activar()
    End Sub
    Private Sub ComboBox1_TextChanged(sender As Object, e As EventArgs) Handles ComboBox1.TextChanged
        activar()
    End Sub
End Class