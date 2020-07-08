Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms
Public Class Conexion
    Public conexion As SqlConnection = New SqlConnection("Data Source =DESKTOP-S8E2HJV;Initial Catalog=Tienda;Integrated Security=True")
    Private cmb As SqlCommandBuilder
    Public ds As DataSet = New DataSet()
    Public da As SqlDataAdapter
    Public comando As SqlCommand

    Public Sub Conectar()
        Try
            conexion.Open()
            MessageBox.Show("Conectado")

        Catch ex As Exception
            MessageBox.Show("Error al conectar")
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Sub Consulta(ByVal sql As String, ByVal tabla As String)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)
    End Sub

    Public Sub ConsultaProductos(ByVal sql As String, ByVal tabla As String)
        ds.Tables.Clear()
        da = New SqlDataAdapter(sql, conexion)
        cmb = New SqlCommandBuilder(da)
        da.Fill(ds, tabla)
    End Sub
    Function comprobarExistenciaId(ByVal idCliente As String)

        Dim cmd As SqlCommand = conexion.CreateCommand()

        cmd.CommandText = ("SELECT idCliente from clientes WHERE clientes.idCliente = '" & idCliente & "'")

        conexion.Open()

        Dim numReg As Integer = CInt(cmd.ExecuteScalar())

        If numReg > 0 Then
            conexion.Close()
            Return 1

        Else
            conexion.Close()
            Return 2

        End If
    End Function

    Function comprobarExistenciaIdProductos(ByVal idProducto As String)

        Dim cmd As SqlCommand = conexion.CreateCommand()

        cmd.CommandText = ("SELECT idProducto from productos WHERE productos.idProducto = '" & idProducto & "'")

        conexion.Open()

        Dim numReg As Integer = CInt(cmd.ExecuteScalar())

        If numReg > 0 Then
            conexion.Close()
            Return 1

        Else
            conexion.Close()
            Return 2

        End If
    End Function

    Function agregarCliente(ByVal idCliente As Integer, ByVal nombre As String, ByVal apellido As String, ByVal direccion As String)

        Dim sqlComm As SqlCommand = conexion.CreateCommand()

        sqlComm.CommandText = "agregarCliente"
        sqlComm.CommandType = CommandType.StoredProcedure

        sqlComm.Parameters.AddWithValue("@idCliente", idCliente)
        sqlComm.Parameters.AddWithValue("@nombre", nombre)
        sqlComm.Parameters.AddWithValue("@apellido", apellido)
        sqlComm.Parameters.AddWithValue("@direccion", direccion)

        conexion.Open()
        If sqlComm.ExecuteNonQuery() Then

            conexion.Close()
            Return True
        Else
            conexion.Close()
            Return False
        End If

    End Function

    Function modificarCliente(ByVal idCliente As Integer, ByVal nombre As String, ByVal apellido As String, ByVal direccion As String)

        Dim sqlComm As SqlCommand = conexion.CreateCommand()

        sqlComm.CommandText = "modificarCliente"
        sqlComm.CommandType = CommandType.StoredProcedure

        sqlComm.Parameters.AddWithValue("@idCliente", idCliente)
        sqlComm.Parameters.AddWithValue("@nombre", nombre)
        sqlComm.Parameters.AddWithValue("@apellido", apellido)
        sqlComm.Parameters.AddWithValue("@direccion", direccion)

        conexion.Open()
        If sqlComm.ExecuteNonQuery() Then

            conexion.Close()
            Return True
        Else
            conexion.Close()
            Return False
        End If

    End Function

    Function eliminarCliente(ByVal idCliente As Integer)
        Dim sqlComm As SqlCommand = conexion.CreateCommand()

        sqlComm.CommandText = "eliminarCliente"
        sqlComm.CommandType = CommandType.StoredProcedure

        sqlComm.Parameters.AddWithValue("@id", idCliente)
        conexion.Open()
        If sqlComm.ExecuteNonQuery() Then

            conexion.Close()
            Return True
        Else
            conexion.Close()
            Return False
        End If
    End Function

    Function eliminarProducto(ByVal idProducto As Integer)
        Dim sqlComm As SqlCommand = conexion.CreateCommand()

        sqlComm.CommandText = "eliminarProducto"
        sqlComm.CommandType = CommandType.StoredProcedure

        sqlComm.Parameters.AddWithValue("@id", idProducto)

        conexion.Open()
        If sqlComm.ExecuteNonQuery() Then

            conexion.Close()
            Return True
        Else
            conexion.Close()
            Return False
        End If
    End Function



    Function agregarProducto(ByVal idProducto As Integer, ByVal nombreProducto As String, ByVal descripcion As String)

        Dim sqlComm As SqlCommand = conexion.CreateCommand()

        sqlComm.CommandText = "agregarProducto"
        sqlComm.CommandType = CommandType.StoredProcedure

        sqlComm.Parameters.AddWithValue("@idProducto", idProducto)
        sqlComm.Parameters.AddWithValue("@nombreProducto", nombreProducto)
        sqlComm.Parameters.AddWithValue("@descripcion", descripcion)

        conexion.Open()
        If sqlComm.ExecuteNonQuery() Then

            conexion.Close()
            Return True
        Else
            conexion.Close()
            Return False
        End If

    End Function

    Function modificarProducto(ByVal idProducto As Integer, ByVal nombreProducto As String, ByVal descripcion As String)

        Dim sqlComm As SqlCommand = conexion.CreateCommand()

        sqlComm.CommandText = "modificarProducto"
        sqlComm.CommandType = CommandType.StoredProcedure

        sqlComm.Parameters.AddWithValue("@idProducto", idProducto)
        sqlComm.Parameters.AddWithValue("@nombreProducto", nombreProducto)
        sqlComm.Parameters.AddWithValue("@descripcion", descripcion)

        conexion.Open()
        If sqlComm.ExecuteNonQuery() Then

            conexion.Close()
            Return True
        Else
            conexion.Close()
            Return False
        End If

    End Function
    Function registrarVenta(ByVal idVenta As Integer, ByVal fechaVenta As String, ByVal precio As Integer, ByVal cantidad As Integer, ByVal idCliente As Integer, ByVal idProducto As Integer)

        Dim sqlComm As SqlCommand = conexion.CreateCommand()

        sqlComm.CommandText = "agregarCliente"
        sqlComm.CommandType = CommandType.StoredProcedure

        sqlComm.Parameters.AddWithValue("@idVenta", idVenta)
        sqlComm.Parameters.AddWithValue("@fechaVenta", fechaVenta)
        sqlComm.Parameters.AddWithValue("@precio", precio)
        sqlComm.Parameters.AddWithValue("@cantidad", cantidad)
        sqlComm.Parameters.AddWithValue("@idCliente", idCliente)
        sqlComm.Parameters.AddWithValue("@idProducto", idProducto)

        conexion.Open()
        If sqlComm.ExecuteNonQuery() Then

            conexion.Close()
            Return True
        Else
            conexion.Close()
            Return False
        End If

    End Function
    Function comprobarExistenciaIdVentas(ByVal idVenta As String)

        Dim cmd As SqlCommand = conexion.CreateCommand()

        cmd.CommandText = ("SELECT idVenta from Ventas WHERE Ventas.idVenta = '" & idVenta & "'")

        conexion.Open()

        Dim numReg As Integer = CInt(cmd.ExecuteScalar())

        If numReg > 0 Then
            conexion.Close()
            Return 1

        Else
            conexion.Close()
            Return 2

        End If
    End Function

End Class
