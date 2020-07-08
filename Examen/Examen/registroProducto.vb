Imports System.ComponentModel

Public Class registroProducto
    Dim conexion As Conexion = New Conexion()
    Private Sub desactivarControles()
        dataProductos.Visible = True
        btnEliminar.Visible = True
        btnModificar.Visible = True
    End Sub
    Private Sub limpiar()
        dataProductos.DataSource = ""
        txtIDProducto.Clear()
        txtnombreProducto.Clear()
        textDescripcion.Clear()
        txtBuscarProducto.Clear()
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        limpiar()
        Venta.Show()
        Me.Hide()
    End Sub

    Private Sub btnMostrarProductos_Click(sender As Object, e As EventArgs)
        desactivarControles()
    End Sub
    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click

        Try
            If conexion.comprobarExistenciaIdProductos(Val(txtIDProducto.Text)) = 2 Then
                If (conexion.agregarProducto(Val(txtIDProducto.Text), txtnombreProducto.Text, textDescripcion.Text)) Then

                    conexion.ConsultaProductos("SELECT * FROM productos WHERE productos.idProducto = " & Val(txtIDProducto.Text), "data")
                    dataProductos.DataSource = conexion.ds.Tables("data")
                    MsgBox("Agregado", vbInformation)
                    desactivarControles()
                Else
                    MsgBox("Error", vbCritical)
                End If
            Else
                MsgBox("Ya hay un numero ID igual", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Try

            If (conexion.modificarProducto(Val(txtIDProducto.Text), txtnombreProducto.Text, textDescripcion.Text)) Then
                conexion.ConsultaProductos("SELECT * FROM productos WHERE productos.idProducto = '" & txtIDProducto.Text & "'", "data")
                dataProductos.DataSource = conexion.ds.Tables("data")
                MsgBox("Modificado", vbInformation)
            Else
                MsgBox("Error", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dataProductos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataProductos.CellContentClick
        Dim dtg As DataGridViewRow = dataProductos.Rows(e.RowIndex)
        txtIDProducto.Text = dtg.Cells(0).Value.ToString()
        txtnombreProducto.Text = dtg.Cells(1).Value.ToString()
        textDescripcion.Text = dtg.Cells(2).Value.ToString()
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Try
            If (conexion.eliminarProducto(Val(txtIDProducto.Text))) Then
                MsgBox("Eliminado", vbInformation)
                limpiar()
            Else
                MsgBox("Error", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Try
            If IsNumeric(txtBuscarProducto.Text) = True Then

                If conexion.comprobarExistenciaIdProductos(txtBuscarProducto.Text) = 1 Then
                    desactivarControles()
                    conexion.Consulta("SELECT * FROM productos WHERE productos.idProducto = " & Val(txtBuscarProducto.Text), "data")
                    dataProductos.DataSource = conexion.ds.Tables("data")

                    Dim dtg As DataGridViewRow = dataProductos.Rows(0)
                    txtIDProducto.Text = dtg.Cells(0).Value.ToString()
                    txtnombreProducto.Text = dtg.Cells(1).Value.ToString()
                    textDescripcion.Text = dtg.Cells(2).Value.ToString()
                Else
                    MsgBox("El ID PRODUCTO no existe!", vbCritical)
                End If

            Else
                MsgBox("Revise el ID PRODUCTO!", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub btnLimpiar_Click_1(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        dataProductos.DataSource = ""
        txtIDProducto.Clear()
        txtnombreProducto.Clear()
        textDescripcion.Clear()
        txtBuscarProducto.Clear()
    End Sub


    Private Sub txtBuscarProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscarProducto.KeyPress
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

    Private Sub txtIDProducto_Validating(sender As Object, e As CancelEventArgs) Handles txtIDProducto.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub txtIDProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtIDProducto.KeyPress
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

    Private Sub txtnombreProducto_Validating(sender As Object, e As CancelEventArgs) Handles txtnombreProducto.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub txtnombreProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombreProducto.KeyPress
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

    Private Sub textDescripcion_Validating(sender As Object, e As CancelEventArgs) Handles textDescripcion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.ErrorProvider.SetError(sender, "")
        Else
            Me.ErrorProvider.SetError(sender, "Campo obligatorio")
        End If
    End Sub

    Private Sub textDescripcion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles textDescripcion.KeyPress
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