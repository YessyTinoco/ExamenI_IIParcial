Imports System.ComponentModel

Public Class registroCliente
    Dim conexion As Conexion = New Conexion()
    Private Sub desactivarControles()
        dataCliente.Visible = True
        btnEliminarCliente.Visible = True
        btnModificarCliente.Visible = True
    End Sub
    Private Sub limpiar()
        txtidCliente.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtDireccion.Clear()
        dataCliente.DataSource = ""
        txtBuscarCliente.Clear()
    End Sub
    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        limpiar()
        Venta.Show()
        Me.Hide()
    End Sub

    Private Sub btnMostrarCliente_Click(sender As Object, e As EventArgs)
        desactivarControles()
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Try
            If conexion.comprobarExistenciaId(Val(txtidCliente.Text)) = 2 Then
                If (conexion.agregarCliente(Val(txtidCliente.Text), txtNombre.Text, txtApellido.Text, txtDireccion.Text)) Then

                    conexion.Consulta("SELECT * FROM clientes WHERE clientes.idCliente = " & Val(txtidCliente.Text), "data")
                    dataCliente.DataSource = conexion.ds.Tables("data")
                    MsgBox("Agregado", vbInformation)
                    desactivarControles()
                Else
                    MsgBox("Error", vbCritical)
                End If
            Else
                MsgBox("Ya hay un numero id igual", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub dataCliente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataCliente.CellContentClick
        Dim dtg As DataGridViewRow = dataCliente.Rows(e.RowIndex)
        txtidCliente.Text = dtg.Cells(0).Value.ToString()
        txtNombre.Text = dtg.Cells(1).Value.ToString()
        txtApellido.Text = dtg.Cells(2).Value.ToString()
        txtDireccion.Text = dtg.Cells(3).Value.ToString()
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        txtidCliente.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtDireccion.Clear()
        dataCliente.DataSource = ""
        txtBuscarCliente.Clear()
    End Sub

    Private Sub btnModificarCliente_Click(sender As Object, e As EventArgs) Handles btnModificarCliente.Click
        Try
            If (conexion.modificarCliente(Val(txtidCliente.Text), txtNombre.Text, txtApellido.Text, txtDireccion.Text)) Then
                conexion.Consulta("SELECT * FROM clientes WHERE clientes.idCliente = '" & txtidCliente.Text & "'", "data")
                dataCliente.DataSource = conexion.ds.Tables("data")
                MsgBox("Modificado", vbInformation)
            Else
                MsgBox("Error", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnEliminarCliente_Click(sender As Object, e As EventArgs) Handles btnEliminarCliente.Click
        Try
            If (conexion.eliminarCliente(Val(txtidCliente.Text))) Then

                MsgBox("Eliminado", vbInformation)
                limpiar()
            Else
                MsgBox("Error", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        Try
            If IsNumeric(txtBuscarCliente.Text) = True Then

                If conexion.comprobarExistenciaIdProductos(txtBuscarCliente.Text) = 1 Then
                    desactivarControles()
                    conexion.Consulta("SELECT * FROM clientes WHERE clientes.idCliente = " & Val(txtBuscarCliente.Text), "data")
                    dataCliente.DataSource = conexion.ds.Tables("data")

                    Dim dtg As DataGridViewRow = dataCliente.Rows(0)
                    txtidCliente.Text = dtg.Cells(0).Value.ToString()
                    txtNombre.Text = dtg.Cells(1).Value.ToString()
                    txtApellido.Text = dtg.Cells(2).Value.ToString()
                    txtDireccion.Text = dtg.Cells(3).Value.ToString()
                Else
                    MsgBox("El ID CLIENTE no existe!", vbCritical)
                End If

            Else
                MsgBox("Revise el ID CLIENTE!", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub txtBuscarCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscarCliente.KeyPress
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

    Private Sub txtidCliente_Validating(sender As Object, e As CancelEventArgs) Handles txtidCliente.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub txtidCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtidCliente.KeyPress
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

    Private Sub txtNombre_Validating(sender As Object, e As CancelEventArgs) Handles txtNombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub txtNombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtApellido_Validating(sender As Object, e As CancelEventArgs) Handles txtApellido.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub txtApellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtApellido.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txtDireccion_Validating(sender As Object, e As CancelEventArgs) Handles txtDireccion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub txtDireccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDireccion.KeyPress
        If Char.IsLetter(e.KeyChar) Then
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