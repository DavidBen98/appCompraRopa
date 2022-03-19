Public Class Detalles_del_pago
    Public persona(30) As tipo_cliente
    Public largo, contador As Integer
    Public total, camisa, corbata, saco, pantalon As Boolean
    Structure tipo_cliente
        Public DNI As String
        Public apellidonom As String
        Public nroFactura As Integer
        Public importe As Decimal
        Public producto As String
        Public tarjeta As String

    End Structure
    Private Sub Detalles_del_pago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 0 To largo
            persona(i).DNI = CargarRopa.cliente(i).DNI
            persona(i).apellidonom = CargarRopa.cliente(i).apellidonom
            persona(i).nroFactura = CargarRopa.cliente(i).nroFactura
            persona(i).importe = CargarRopa.cliente(i).importe
            persona(i).producto = CargarRopa.cliente(i).producto
            persona(i).tarjeta = CargarRopa.cliente(i).tarjeta
        Next
        contador = 0
        ComboBox1.SelectedIndex = -1
        RadioButton1.Checked = False
        RadioButton2.Checked = False
        VISA.Items.Clear()
        MasterCard.Items.Clear()
        AmericanExpress.Items.Clear()
        VISA.Items.Add("VISA") 'LE AGREGO EL TITULO A CADA LISTBOX
        MasterCard.Items.Add("MasterCard")
        AmericanExpress.Items.Add("AmericanExpress")
    End Sub
    Public Sub sumar()
        Dim i, j, vis, master, american As Integer
        'SUMA TOTAL DE CADA TARJETA
        vis = 0
        master = 0
        american = 0
        i = 0
        j = 0
        total = False
        For i = 0 To largo
            If persona(i).tarjeta = "VISA" Then
                vis = vis + persona(i).importe
            ElseIf persona(i).tarjeta = "MasterCard" Then
                master = master + (persona(i).importe)
            Else
                american = american + persona(i).importe
            End If
        Next

        If RadioButton1.Checked Then 'SI ES CON IVA
            For j = 1 To 5
                If j = 5 Then
                    VISA.Items.Insert(5, vis)
                    MasterCard.Items.Insert(5, master)
                    AmericanExpress.Items.Insert(5, american)
                Else
                    VISA.Items.Insert(j, "")
                    MasterCard.Items.Insert(j, "")
                    AmericanExpress.Items.Insert(j, "")
                End If
            Next
        Else   'SI ES SIN IVA
            For j = 1 To 5
                If j = 5 Then
                    VISA.Items.Insert(5, vis / 1.21)
                    MasterCard.Items.Insert(5, master / 1.21)
                    AmericanExpress.Items.Insert(5, american / 1.21)
                Else
                    VISA.Items.Insert(j, "")
                    MasterCard.Items.Insert(j, "")
                    AmericanExpress.Items.Insert(j, "")
                End If
            Next
        End If

        total = True
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Public Sub sumarCam()
        Dim i, suma, sumaDos, sumaTres As Integer
        suma = 0
        sumaDos = 0
        sumaTres = 0
        camisa = False
        For i = 0 To largo
            If persona(i).producto = "Camisa" Then
                If persona(i).tarjeta = "VISA" Then
                    suma = suma + persona(i).importe
                ElseIf persona(i).tarjeta = "MasterCard" Then
                    sumaDos = sumaDos + persona(i).importe
                ElseIf persona(i).tarjeta = "American Express" Then
                    sumaTres = sumaTres + persona(i).importe
                End If
            End If
        Next
        If RadioButton1.Checked = True Then
            VISA.Items.Insert(1, suma)
            MasterCard.Items.Insert(1, sumaDos)
            AmericanExpress.Items.Insert(1, sumaTres)
        Else
            VISA.Items.Insert(1, suma / 1.21)
            MasterCard.Items.Insert(1, sumaDos / 1.21)
            AmericanExpress.Items.Insert(1, sumaTres / 1.21)
            camisa = True
        End If
    End Sub
    Public Sub sumarCor()
        Dim i, j, suma, sumaDos, sumaTres As Integer

        suma = 0
        sumaDos = 0
        sumaTres = 0
        corbata = False
        For i = 0 To largo
            If persona(i).producto = "Corbata" Then
                If persona(i).tarjeta = "VISA" Then
                    suma = suma + persona(i).importe
                ElseIf persona(i).tarjeta = "MasterCard" Then
                    sumaDos = sumaDos + persona(i).importe
                ElseIf persona(i).tarjeta = "American Express" Then
                    sumaTres = sumaTres + persona(i).importe
                End If
            End If
        Next

        If RadioButton1.Checked Then 'SI ES CON IVA
            For j = 1 To 2
                If j = 2 Then
                    VISA.Items.Insert(2, suma)
                    MasterCard.Items.Insert(2, sumaDos)
                    AmericanExpress.Items.Insert(2, sumaTres)
                Else
                    VISA.Items.Insert(j, "")
                    MasterCard.Items.Insert(j, "")
                    AmericanExpress.Items.Insert(j, "")
                End If
            Next
        Else   'SI ES SIN IVA
            For j = 1 To 2
                If j = 2 Then
                    VISA.Items.Insert(2, suma / 1.21)
                    MasterCard.Items.Insert(2, sumaDos / 1.21)
                    AmericanExpress.Items.Insert(2, sumaTres / 1.21)
                Else
                    VISA.Items.Insert(j, "")
                    MasterCard.Items.Insert(j, "")
                    AmericanExpress.Items.Insert(j, "")
                End If
            Next
        End If
        corbata = True
    End Sub
    Public Sub sumarPantalon()
        Dim i, j, suma, sumaDos, sumaTres As Integer

        suma = 0
        sumaDos = 0
        sumaTres = 0
        pantalon = False
        For i = 0 To largo
            If persona(i).producto = "Pantalon" Then
                If persona(i).tarjeta = "VISA" Then
                    suma = suma + persona(i).importe
                ElseIf persona(i).tarjeta = "MasterCard" Then
                    sumaDos = sumaDos + persona(i).importe
                ElseIf persona(i).tarjeta = "American Express" Then
                    sumaTres = sumaTres + persona(i).importe
                End If
            End If
        Next

        If RadioButton1.Checked Then 'SI ES CON IVA
            For j = 1 To 3
                If j = 3 Then
                    VISA.Items.Insert(3, suma)
                    MasterCard.Items.Insert(3, sumaDos)
                    AmericanExpress.Items.Insert(3, sumaTres)
                Else
                    VISA.Items.Insert(j, "")
                    MasterCard.Items.Insert(j, "")
                    AmericanExpress.Items.Insert(j, "")
                End If
            Next
        Else   'SI ES SIN IVA
            For j = 1 To 3
                If j = 3 Then
                    VISA.Items.Insert(3, suma / 1.21)
                    MasterCard.Items.Insert(3, sumaDos / 1.21)
                    AmericanExpress.Items.Insert(3, sumaTres / 1.21)
                Else
                    VISA.Items.Insert(j, "")
                    MasterCard.Items.Insert(j, "")
                    AmericanExpress.Items.Insert(j, "")
                End If
            Next
        End If
        pantalon = True
    End Sub
    Public Sub sumarSaco()
        Dim i, j, suma, sumaDos, sumaTres As Integer

        suma = 0
        sumaDos = 0
        sumaTres = 0
        saco = False
        For i = 0 To largo
            If persona(i).producto = "Pantalon" Then
                If persona(i).tarjeta = "VISA" Then
                    suma = suma + persona(i).importe
                ElseIf persona(i).tarjeta = "MasterCard" Then
                    sumaDos = sumaDos + persona(i).importe
                ElseIf persona(i).tarjeta = "American Express" Then
                    sumaTres = sumaTres + persona(i).importe
                End If
            End If
        Next

        If RadioButton1.Checked Then 'SI ES CON IVA
            For j = 1 To 4
                If j = 4 Then
                    VISA.Items.Insert(4, suma)
                    MasterCard.Items.Insert(4, sumaDos)
                    AmericanExpress.Items.Insert(4, sumaTres)
                Else
                    VISA.Items.Insert(j, "")
                    MasterCard.Items.Insert(j, "")
                    AmericanExpress.Items.Insert(j, "")
                End If
            Next
        Else   'SI ES SIN IVA
            For j = 1 To 4
                If j = 4 Then
                    VISA.Items.Insert(4, suma / 1.21)
                    MasterCard.Items.Insert(4, sumaDos / 1.21)
                    AmericanExpress.Items.Insert(4, sumaTres / 1.21)
                Else
                    VISA.Items.Insert(j, "")
                    MasterCard.Items.Insert(j, "")
                    AmericanExpress.Items.Insert(j, "")
                End If
            Next
        End If
        saco = True
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'APRIETO BOTON CONSULTAR
        If contador > 0 Then   'BORRAR LA ULTIMA CONSULTA, VOLVER EL LISTBOX A "0"
            VISA.Items.Clear()
            MasterCard.Items.Clear()
            AmericanExpress.Items.Clear()
            VISA.Items.Add("VISA") 'LE AGREGO EL TITULO A CADA LISTBOX
            MasterCard.Items.Add("MasterCard")
            AmericanExpress.Items.Add("AmericanExpress")
        End If

        contador = contador + 1
        'SI SE SELECCIONA CON IVA
        If RadioButton1.Checked = True Then
            If ComboBox1.SelectedIndex = -1 Then 'SI NO HAY NINGUN PRODUCTO SELECCIONADO
                MsgBox("No se ha seleccionado ningun producto", vbExclamation)
            ElseIf ComboBox1.SelectedIndex = 0 Then 'SI SE SELECCIONA TODOS
                sumar()
            ElseIf ComboBox1.SelectedIndex = 1 Then 'SI SE SELECCIONA CAMISA
                sumarCam()
            ElseIf ComboBox1.SelectedIndex = 2 Then 'SI SE SELECCIONA CORBATA
                sumarCor()
            ElseIf ComboBox1.SelectedIndex = 3 Then 'SI SE SELECCIONA PANTALON
                sumarPantalon()
            ElseIf ComboBox1.SelectedIndex = 4 Then 'SI SE SELECCIONA SACO
                sumarSaco()
            End If
        ElseIf RadioButton2.Checked Then 'SI SE SELECCIONA SIN IVA
            If ComboBox1.SelectedIndex = -1 Then 'SI NO HAY NINGUN PRODUCTO SELECCIONADO
                MsgBox("No se ha seleccionado ningun producto", vbExclamation)
            ElseIf ComboBox1.SelectedIndex = 0 Then 'SI SE SELECCIONA TODOS
                sumar()
            ElseIf ComboBox1.SelectedIndex = 1 Then 'SI SE SELECCIONA CAMISA
                sumarCam()
            ElseIf ComboBox1.SelectedIndex = 2 Then 'SI SE SELECCIONA CORBATA
                sumarCor()
            ElseIf ComboBox1.SelectedIndex = 3 Then 'SI SE SELECCIONA PANTALON
                sumarPantalon()
            ElseIf ComboBox1.SelectedIndex = 4 Then 'SI SE SELECCIONA SACO
                sumarSaco()
            End If
        ElseIf ComboBox1.SelectedIndex = -1 And (RadioButton1.checked = False And RadioButton2.checked = False) Then
            MsgBox("No se ha seleccionado ni el tipo de listado, ni el producto", vbExclamation)
        Else
            MsgBox("No se ha seleccionado el tipo de listado", vbExclamation)
        End If
    End Sub
End Class