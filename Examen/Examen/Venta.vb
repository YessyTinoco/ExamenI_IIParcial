Imports System.ComponentModel

Public Class Venta
    Dim conexion As Conexion = New Conexion()
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        conexion.Conectar()
    End Sub

    Private Sub btnCrearProducto_Click(sender As Object, e As EventArgs) Handles btnCrearProducto.Click
        registroProducto.Show()
        Me.Hide()
    End Sub

    Private Sub btnCrearCliente_Click(sender As Object, e As EventArgs) Handles btnCrearCliente.Click
        registroCliente.Show()
        Me.Hide()
    End Sub

    Private Sub btnAgregarVenta_Click(sender As Object, e As EventArgs) Handles btnAgregarVenta.Click
        Try
            If conexion.comprobarExistenciaId(Val(txtIdCliente.Text)) = 1 Then

                If conexion.comprobarExistenciaIdProductos(Val(txtIdProducto.Text)) = 1 Then

                    If conexion.comprobarExistenciaIdVentas(Val(txtIdVenta.Text)) = 2 Then
                        If (conexion.registrarVenta(Val(txtIdVenta.Text), MaskFecha.Text, Val(txtPrecio.Text), Val(txtCantidad.Text), Val(txtIdCliente.Text), Val(txtIdProducto.Text))) Then

                            conexion.Consulta("Select CONCAT(clientes.nombre,' ',clientes.apellido) as 'Nombre Completo', productos.nombreProducto as Producto, ventas.cantidad as Cantidad, ventas.precio as Venta, ventas.fechaVenta as Fecha From ventas inner join clientes ON ventas.idCliente=clientes.idCliente inner join productos ON ventas.idProducto=productos.idProducto Where ventas.idVenta = " & Val(txtIdVenta.Text), "data")
                            DATA.DataSource = conexion.ds.Tables("data")
                            MsgBox("Agregado", vbInformation)
                        Else
                            MsgBox("Error", vbCritical)
                        End If
                    Else
                        MsgBox("Ya existe ID VENTA", vbCritical)
                    End If
                Else
                    MsgBox("Ya existe ID PRODUCTO", vbCritical)
                End If
            Else
                MsgBox("Ya existe ID CLIENTE", vbCritical)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DATA.DataSource = ""
        txtIdVenta.Clear()
        txtCantidad.Clear()
        txtIdCliente.Clear()
        txtIdProducto.Clear()
        txtPrecio.Clear()
        MaskFecha.Clear()


    End Sub

    Private Sub btnMostrar_Click(sender As Object, e As EventArgs) Handles btnMostrar.Click
        conexion.Consulta("Select CONCAT(clientes.nombre,' ',clientes.apellido) as 'Nombre Completo', productos.nombreProducto as Producto, ventas.cantidad as Cantidad, ventas.precio as Venta, ventas.fechaVenta as Fecha From ventas inner join clientes ON ventas.idCliente=clientes.idCliente inner join productos ON ventas.idProducto=productos.idProducto Where ventas.idVenta = " & Val(txtIdVenta.Text), "data")
        DATA.DataSource = conexion.ds.Tables("data")
    End Sub

    Private Sub txtIdVenta_Validating(sender As Object, e As CancelEventArgs) Handles txtIdVenta.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub txtIdVenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdVenta.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrecio_Validating(sender As Object, e As CancelEventArgs) Handles txtPrecio.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub txtPrecio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrecio.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtCantidad_Validating(sender As Object, e As CancelEventArgs) Handles txtCantidad.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub MaskFecha_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaskFecha.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtIdCliente_Validating(sender As Object, e As CancelEventArgs) Handles txtIdCliente.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub txtIdCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdCliente.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtIdProducto_Validating(sender As Object, e As CancelEventArgs) Handles txtIdProducto.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub txtIdProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIdProducto.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub
End Class