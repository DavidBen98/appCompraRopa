<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Detalles_del_pago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Detalles_del_pago))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.VISA = New System.Windows.Forms.ListBox()
        Me.MasterCard = New System.Windows.Forms.ListBox()
        Me.AmericanExpress = New System.Windows.Forms.ListBox()
        Me.Producto = New System.Windows.Forms.ListBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.MenuText
        Me.Button1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button1.Location = New System.Drawing.Point(335, 260)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(160, 39)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "CONSULTAR"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.MenuText
        Me.Button2.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Button2.Location = New System.Drawing.Point(512, 260)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(160, 39)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "CANCELAR"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.SystemColors.MenuText
        Me.ComboBox1.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Todos", "Camisa", "Corbata", "Pantalon", "Saco"})
        Me.ComboBox1.Location = New System.Drawing.Point(29, 67)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(29, 143)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(121, 71)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo listado"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(7, 48)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(60, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Sin IVA"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(7, 20)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(64, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Con IVA"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'VISA
        '
        Me.VISA.BackColor = System.Drawing.SystemColors.MenuText
        Me.VISA.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VISA.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.VISA.FormattingEnabled = True
        Me.VISA.ItemHeight = 16
        Me.VISA.Items.AddRange(New Object() {"VISA"})
        Me.VISA.Location = New System.Drawing.Point(383, 67)
        Me.VISA.Name = "VISA"
        Me.VISA.Size = New System.Drawing.Size(112, 100)
        Me.VISA.TabIndex = 5
        '
        'MasterCard
        '
        Me.MasterCard.BackColor = System.Drawing.SystemColors.MenuText
        Me.MasterCard.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MasterCard.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.MasterCard.FormattingEnabled = True
        Me.MasterCard.ItemHeight = 16
        Me.MasterCard.Items.AddRange(New Object() {"MasterCard"})
        Me.MasterCard.Location = New System.Drawing.Point(493, 67)
        Me.MasterCard.Name = "MasterCard"
        Me.MasterCard.Size = New System.Drawing.Size(120, 100)
        Me.MasterCard.TabIndex = 6
        '
        'AmericanExpress
        '
        Me.AmericanExpress.BackColor = System.Drawing.SystemColors.MenuText
        Me.AmericanExpress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AmericanExpress.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.AmericanExpress.FormattingEnabled = True
        Me.AmericanExpress.ItemHeight = 16
        Me.AmericanExpress.Items.AddRange(New Object() {"AmericanExpress"})
        Me.AmericanExpress.Location = New System.Drawing.Point(610, 67)
        Me.AmericanExpress.Name = "AmericanExpress"
        Me.AmericanExpress.Size = New System.Drawing.Size(120, 100)
        Me.AmericanExpress.TabIndex = 7
        '
        'Producto
        '
        Me.Producto.BackColor = System.Drawing.SystemColors.ControlText
        Me.Producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Producto.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.Producto.FormattingEnabled = True
        Me.Producto.ItemHeight = 16
        Me.Producto.Items.AddRange(New Object() {"Producto", "Camisa", "Corbata", "Pantalon", "Saco", "Total"})
        Me.Producto.Location = New System.Drawing.Point(267, 67)
        Me.Producto.Name = "Producto"
        Me.Producto.Size = New System.Drawing.Size(116, 100)
        Me.Producto.TabIndex = 4
        '
        'Detalles_del_pago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(800, 346)
        Me.Controls.Add(Me.AmericanExpress)
        Me.Controls.Add(Me.MasterCard)
        Me.Controls.Add(Me.VISA)
        Me.Controls.Add(Me.Producto)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Detalles_del_pago"
        Me.Text = "Detalle de pago"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents VISA As ListBox
    Friend WithEvents MasterCard As ListBox
    Friend WithEvents AmericanExpress As ListBox
    Friend WithEvents Producto As ListBox
End Class
