<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registroCliente
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnlimpiar = New System.Windows.Forms.Button()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Dirección = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.txtidCliente = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnEliminarCliente = New System.Windows.Forms.Button()
        Me.btnModificarCliente = New System.Windows.Forms.Button()
        Me.dataCliente = New System.Windows.Forms.DataGridView()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnBuscarCliente = New System.Windows.Forms.Button()
        Me.txtBuscarCliente = New System.Windows.Forms.TextBox()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.dataCliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(168, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(211, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "REGISTRO DE CLIENTE"
        '
        'btnlimpiar
        '
        Me.btnlimpiar.Location = New System.Drawing.Point(126, 310)
        Me.btnlimpiar.Name = "btnlimpiar"
        Me.btnlimpiar.Size = New System.Drawing.Size(115, 40)
        Me.btnlimpiar.TabIndex = 26
        Me.btnlimpiar.Text = "LIMPIAR"
        Me.btnlimpiar.UseVisualStyleBackColor = True
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(285, 208)
        Me.txtApellido.Multiline = True
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(128, 20)
        Me.txtApellido.TabIndex = 25
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(285, 160)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(128, 20)
        Me.txtNombre.TabIndex = 24
        '
        'Dirección
        '
        Me.Dirección.AutoSize = True
        Me.Dirección.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dirección.Location = New System.Drawing.Point(140, 261)
        Me.Dirección.Name = "Dirección"
        Me.Dirección.Size = New System.Drawing.Size(65, 16)
        Me.Dirección.TabIndex = 23
        Me.Dirección.Text = "Dirección"
        Me.Dirección.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(140, 164)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 16)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Nombre "
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(298, 309)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(115, 41)
        Me.btnAgregar.TabIndex = 21
        Me.btnAgregar.Text = "AGREGAR"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'txtidCliente
        '
        Me.txtidCliente.Location = New System.Drawing.Point(285, 121)
        Me.txtidCliente.Name = "txtidCliente"
        Me.txtidCliente.Size = New System.Drawing.Size(128, 20)
        Me.txtidCliente.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(140, 121)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 16)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "ID Cliente"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(285, 257)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(128, 20)
        Me.txtDireccion.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(140, 212)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 16)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Apellido "
        '
        'btnEliminarCliente
        '
        Me.btnEliminarCliente.Location = New System.Drawing.Point(298, 357)
        Me.btnEliminarCliente.Name = "btnEliminarCliente"
        Me.btnEliminarCliente.Size = New System.Drawing.Size(115, 40)
        Me.btnEliminarCliente.TabIndex = 32
        Me.btnEliminarCliente.Text = "ELIMINAR"
        Me.btnEliminarCliente.UseVisualStyleBackColor = True
        Me.btnEliminarCliente.Visible = False
        '
        'btnModificarCliente
        '
        Me.btnModificarCliente.Location = New System.Drawing.Point(126, 356)
        Me.btnModificarCliente.Name = "btnModificarCliente"
        Me.btnModificarCliente.Size = New System.Drawing.Size(115, 41)
        Me.btnModificarCliente.TabIndex = 31
        Me.btnModificarCliente.Text = "MODIFICAR"
        Me.btnModificarCliente.UseVisualStyleBackColor = True
        Me.btnModificarCliente.Visible = False
        '
        'dataCliente
        '
        Me.dataCliente.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dataCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataCliente.Location = New System.Drawing.Point(49, 423)
        Me.dataCliente.Name = "dataCliente"
        Me.dataCliente.Size = New System.Drawing.Size(444, 110)
        Me.dataCliente.TabIndex = 29
        Me.dataCliente.Visible = False
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(31, 17)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegresar.TabIndex = 33
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnBuscarCliente)
        Me.GroupBox1.Controls.Add(Me.txtBuscarCliente)
        Me.GroupBox1.Location = New System.Drawing.Point(135, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(284, 63)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 16)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "ID Cliente"
        '
        'btnBuscarCliente
        '
        Me.btnBuscarCliente.Location = New System.Drawing.Point(169, 16)
        Me.btnBuscarCliente.Name = "btnBuscarCliente"
        Me.btnBuscarCliente.Size = New System.Drawing.Size(95, 40)
        Me.btnBuscarCliente.TabIndex = 29
        Me.btnBuscarCliente.Text = "BUSCAR"
        Me.btnBuscarCliente.UseVisualStyleBackColor = True
        '
        'txtBuscarCliente
        '
        Me.txtBuscarCliente.Location = New System.Drawing.Point(91, 28)
        Me.txtBuscarCliente.Name = "txtBuscarCliente"
        Me.txtBuscarCliente.Size = New System.Drawing.Size(72, 20)
        Me.txtBuscarCliente.TabIndex = 30
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'registroCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 545)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.btnEliminarCliente)
        Me.Controls.Add(Me.btnModificarCliente)
        Me.Controls.Add(Me.dataCliente)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnlimpiar)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Dirección)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.txtidCliente)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "registroCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "registroCliente"
        CType(Me.dataCliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents btnlimpiar As Button
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Dirección As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAgregar As Button
    Friend WithEvents txtidCliente As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnEliminarCliente As Button
    Friend WithEvents btnModificarCliente As Button
    Friend WithEvents dataCliente As DataGridView
    Friend WithEvents btnRegresar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnBuscarCliente As Button
    Friend WithEvents txtBuscarCliente As TextBox
    Friend WithEvents ErrorProvider As ErrorProvider
End Class
