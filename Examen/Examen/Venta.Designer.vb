<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Venta
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtIdVenta = New System.Windows.Forms.TextBox()
        Me.txtPrecio = New System.Windows.Forms.TextBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.txtIdCliente = New System.Windows.Forms.TextBox()
        Me.txtIdProducto = New System.Windows.Forms.TextBox()
        Me.DATA = New System.Windows.Forms.DataGridView()
        Me.btnAgregarVenta = New System.Windows.Forms.Button()
        Me.MaskFecha = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnCrearProducto = New System.Windows.Forms.Button()
        Me.btnCrearCliente = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnMostrar = New System.Windows.Forms.Button()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.DATA, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Venta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Fecha de venta"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Precio "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Cantidad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 192)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "ID Cliente"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 231)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(78, 16)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "ID Producto"
        '
        'txtIdVenta
        '
        Me.txtIdVenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdVenta.Location = New System.Drawing.Point(105, 29)
        Me.txtIdVenta.Name = "txtIdVenta"
        Me.txtIdVenta.Size = New System.Drawing.Size(100, 22)
        Me.txtIdVenta.TabIndex = 6
        '
        'txtPrecio
        '
        Me.txtPrecio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecio.Location = New System.Drawing.Point(105, 69)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.Size = New System.Drawing.Size(100, 22)
        Me.txtPrecio.TabIndex = 8
        '
        'txtCantidad
        '
        Me.txtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(105, 109)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 22)
        Me.txtCantidad.TabIndex = 9
        '
        'txtIdCliente
        '
        Me.txtIdCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdCliente.Location = New System.Drawing.Point(105, 189)
        Me.txtIdCliente.Name = "txtIdCliente"
        Me.txtIdCliente.Size = New System.Drawing.Size(100, 22)
        Me.txtIdCliente.TabIndex = 10
        '
        'txtIdProducto
        '
        Me.txtIdProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIdProducto.Location = New System.Drawing.Point(105, 228)
        Me.txtIdProducto.Name = "txtIdProducto"
        Me.txtIdProducto.Size = New System.Drawing.Size(100, 22)
        Me.txtIdProducto.TabIndex = 11
        '
        'DATA
        '
        Me.DATA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DATA.Location = New System.Drawing.Point(13, 369)
        Me.DATA.Name = "DATA"
        Me.DATA.Size = New System.Drawing.Size(549, 144)
        Me.DATA.TabIndex = 12
        '
        'btnAgregarVenta
        '
        Me.btnAgregarVenta.Location = New System.Drawing.Point(436, 201)
        Me.btnAgregarVenta.Name = "btnAgregarVenta"
        Me.btnAgregarVenta.Size = New System.Drawing.Size(115, 40)
        Me.btnAgregarVenta.TabIndex = 14
        Me.btnAgregarVenta.Text = "AGREGAR"
        Me.btnAgregarVenta.UseVisualStyleBackColor = True
        '
        'MaskFecha
        '
        Me.MaskFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MaskFecha.Location = New System.Drawing.Point(137, 146)
        Me.MaskFecha.Mask = "00/00/0000"
        Me.MaskFecha.Name = "MaskFecha"
        Me.MaskFecha.Size = New System.Drawing.Size(68, 22)
        Me.MaskFecha.TabIndex = 18
        Me.MaskFecha.ValidatingType = GetType(Date)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(181, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(207, 20)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "REGISTRO DE VENTAS"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtIdVenta)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtIdCliente)
        Me.GroupBox1.Controls.Add(Me.MaskFecha)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtPrecio)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtCantidad)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtIdProducto)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(172, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(226, 284)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        '
        'btnCrearProducto
        '
        Me.btnCrearProducto.Location = New System.Drawing.Point(13, 29)
        Me.btnCrearProducto.Name = "btnCrearProducto"
        Me.btnCrearProducto.Size = New System.Drawing.Size(86, 34)
        Me.btnCrearProducto.TabIndex = 22
        Me.btnCrearProducto.Text = "Crear registro producto"
        Me.btnCrearProducto.UseVisualStyleBackColor = True
        '
        'btnCrearCliente
        '
        Me.btnCrearCliente.Location = New System.Drawing.Point(13, 75)
        Me.btnCrearCliente.Name = "btnCrearCliente"
        Me.btnCrearCliente.Size = New System.Drawing.Size(86, 34)
        Me.btnCrearCliente.TabIndex = 23
        Me.btnCrearCliente.Text = "Crear registro cliente"
        Me.btnCrearCliente.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(436, 267)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 40)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "LIMPIAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnMostrar
        '
        Me.btnMostrar.Location = New System.Drawing.Point(34, 340)
        Me.btnMostrar.Name = "btnMostrar"
        Me.btnMostrar.Size = New System.Drawing.Size(75, 23)
        Me.btnMostrar.TabIndex = 28
        Me.btnMostrar.Text = "Mostrar"
        Me.btnMostrar.UseVisualStyleBackColor = True
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'Venta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 533)
        Me.Controls.Add(Me.btnMostrar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnCrearCliente)
        Me.Controls.Add(Me.btnCrearProducto)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnAgregarVenta)
        Me.Controls.Add(Me.DATA)
        Me.Name = "Venta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Venta"
        CType(Me.DATA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtIdVenta As TextBox
    Friend WithEvents txtPrecio As TextBox
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents txtIdProducto As TextBox
    Friend WithEvents DATA As DataGridView
    Friend WithEvents btnAgregarVenta As Button
    Friend WithEvents MaskFecha As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnCrearProducto As Button
    Friend WithEvents btnCrearCliente As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnMostrar As Button
    Friend WithEvents ErrorProvider As ErrorProvider
End Class
