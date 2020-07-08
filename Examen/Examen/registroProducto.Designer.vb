<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class registroProducto
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
        Me.txtIDProducto = New System.Windows.Forms.TextBox()
        Me.btnAgregar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtnombreProducto = New System.Windows.Forms.TextBox()
        Me.textDescripcion = New System.Windows.Forms.TextBox()
        Me.dataProductos = New System.Windows.Forms.DataGridView()
        Me.btnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtBuscarProducto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.dataProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(101, 151)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Producto"
        '
        'txtIDProducto
        '
        Me.txtIDProducto.Location = New System.Drawing.Point(246, 148)
        Me.txtIDProducto.Name = "txtIDProducto"
        Me.txtIDProducto.Size = New System.Drawing.Size(118, 20)
        Me.txtIDProducto.TabIndex = 1
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(94, 323)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(115, 40)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "AGREGAR"
        Me.btnAgregar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(101, 197)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Nombre Producto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(101, 247)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Descripción"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(137, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(247, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "REGISTRO DE PRODUCTOS"
        '
        'txtnombreProducto
        '
        Me.txtnombreProducto.Location = New System.Drawing.Point(246, 193)
        Me.txtnombreProducto.Name = "txtnombreProducto"
        Me.txtnombreProducto.Size = New System.Drawing.Size(118, 20)
        Me.txtnombreProducto.TabIndex = 6
        '
        'textDescripcion
        '
        Me.textDescripcion.Location = New System.Drawing.Point(246, 247)
        Me.textDescripcion.Multiline = True
        Me.textDescripcion.Name = "textDescripcion"
        Me.textDescripcion.Size = New System.Drawing.Size(175, 59)
        Me.textDescripcion.TabIndex = 7
        '
        'dataProductos
        '
        Me.dataProductos.BackgroundColor = System.Drawing.Color.DarkGray
        Me.dataProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dataProductos.Location = New System.Drawing.Point(50, 436)
        Me.dataProductos.Name = "dataProductos"
        Me.dataProductos.Size = New System.Drawing.Size(398, 100)
        Me.dataProductos.TabIndex = 19
        Me.dataProductos.Visible = False
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(94, 380)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(115, 40)
        Me.btnModificar.TabIndex = 21
        Me.btnModificar.Text = "MODIFICAR"
        Me.btnModificar.UseVisualStyleBackColor = True
        Me.btnModificar.Visible = False
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(296, 380)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(115, 40)
        Me.btnEliminar.TabIndex = 22
        Me.btnEliminar.Text = "ELIMINAR"
        Me.btnEliminar.UseVisualStyleBackColor = True
        Me.btnEliminar.Visible = False
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(29, 12)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegresar.TabIndex = 23
        Me.btnRegresar.Text = "Regresar"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Location = New System.Drawing.Point(296, 323)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(115, 40)
        Me.btnLimpiar.TabIndex = 27
        Me.btnLimpiar.Text = "LIMPIAR"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.txtBuscarProducto)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(96, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(284, 63)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(169, 16)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(95, 40)
        Me.btnBuscar.TabIndex = 29
        Me.btnBuscar.Text = "BUSCAR"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtBuscarProducto
        '
        Me.txtBuscarProducto.Location = New System.Drawing.Point(91, 28)
        Me.txtBuscarProducto.Name = "txtBuscarProducto"
        Me.txtBuscarProducto.Size = New System.Drawing.Size(72, 20)
        Me.txtBuscarProducto.TabIndex = 30
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 16)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "ID Producto"
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'registroProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(520, 548)
        Me.Controls.Add(Me.txtIDProducto)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnLimpiar)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.dataProductos)
        Me.Controls.Add(Me.textDescripcion)
        Me.Controls.Add(Me.txtnombreProducto)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAgregar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "registroProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "registroProducto"
        CType(Me.dataProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtIDProducto As TextBox
    Friend WithEvents btnAgregar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtnombreProducto As TextBox
    Friend WithEvents textDescripcion As TextBox
    Friend WithEvents dataProductos As DataGridView
    Friend WithEvents btnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents btnRegresar As Button
    Friend WithEvents btnLimpiar As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtBuscarProducto As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ErrorProvider As ErrorProvider
End Class
