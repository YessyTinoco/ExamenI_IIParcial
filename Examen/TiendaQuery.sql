DROP DATABASE if exists Tienda
create database Tienda
go

Use Tienda
go

create table clientes (
	idCliente int primary key not null,
	nombre varchar(25),
	apellido varchar(25),
	direccion varchar(50)
);


create table productos(
	idProducto int primary key not null,
	nombreProducto varchar(40),
	descripcion varchar(50)
);

create table Ventas(
	idVenta int primary key not null,
	fechaVenta date,
	precio int,
	cantidad int,
	idCliente int foreign key references clientes(idCliente),
	idProducto int foreign key references productos(idProducto)
	ON UPDATE CASCADE
	ON DELETE CASCADE
);

/*Procedimiento agregar un cliente*/
CREATE PROCEDURE agregarCliente(@idCliente int, @nombre varchar(25), @apellido varchar (25), @direccion varchar(25))
as begin 
INSERT INTO clientes(idCliente, nombre, apellido, direccion) VALUES(@idCliente, @nombre, @apellido, @direccion)
end

/*Insertar*/
execute agregarCliente 1, 'Yessy', 'Tinoco', 'La Esperanza';
execute agregarCliente 2, 'Catherine', 'Joya', 'La Esperanza';
execute agregarCliente 3, 'Lizzie', 'Diaz', 'Tegucigalpa';
select * from clientes;

/*Procedimiento modificar un cliente*/
CREATE PROCEDURE modificarCliente(@idCliente int, @nombre varchar(25), @apellido varchar (25), @direccion varchar(25))
as begin
UPDATE clientes SET idCliente = @idCliente, nombre = @nombre, apellido = @apellido, direccion = @direccion WHERE clientes.idCliente = @idCliente
End

/*Modificar*/
execute modificarCliente 1, 'Danira', 'Tinoco', 'La Esperanza';
select * from clientes;


/*Procedimiento para agregar un producto*/
CREATE PROCEDURE agregarProducto(@idProducto int, @nombreProducto varchar(40), @descripcion varchar(50))
as begin

INSERT INTO productos(idProducto, nombreProducto, descripcion) VALUES(@idProducto, @nombreProducto, @descripcion)
end

/*Insertar*/
execute agregarProducto 1, 'GALLETAS', 'QUEAKER CON AVENA';
execute agregarProducto 2, 'LECHE', 'SULA DE 1 LITRO';
execute agregarProducto 3, 'MALVAVISCOS', 'ANGELITOS MARSHMALLOWS 1 KG';

select * from productos;


/*Procedimiento para modificar un producto*/
CREATE PROCEDURE modificarProducto(@idProducto int, @nombreProducto varchar(40), @descripcion varchar(50))
as begin

UPDATE productos SET idProducto = @idProducto, nombreProducto = @nombreProducto, descripcion = @descripcion WHERE productos.idProducto = @idProducto
end
/*Modificar*/
execute modificarProducto 1, 'GALLETAS', 'QUEAKER CON FRUTOS SECOS';

select * from productos;


/*Procedimiento para resgitrar una venta*/
CREATE PROCEDURE registrarVenta(@idVenta int, @fechaVenta DATE, @precio int, @cantidad int, @idCliente int, @idProducto int)
as begin
INSERT INTO Ventas(idVenta, fechaVenta, precio, cantidad, idCliente, idProducto) VALUES(@idVenta, @fechaVenta, @precio, @cantidad, @idCliente, @idProducto)
end
/*Insertar*/
execute registrarVenta 1, '02/07/2020', 15, 5, 1, 1;
execute registrarVenta 2, '03/07/2020', 25, 10, 2, 2;
execute registrarVenta 3, '03/07/2020', 30, 2, 3, 3;

select * from Ventas;



/*Procedimiento para eliminar un cliente*/

CREATE PROCEDURE eliminarCliente(@id int)
as begin
DELETE FROM Ventas where ventas.idCliente = @id
DELETE FROM clientes WHERE clientes.idCliente = @id
end

/*Eliminar*/
execute eliminarCliente 5;
select * from clientes;


/*Procedimiento para eliminar un producto*/

CREATE PROCEDURE eliminarProducto(@id int)
as begin
DELETE FROM Ventas where ventas.idProducto = @id
DELETE FROM productos WHERE productos.idProducto = @id
end
/*Eliminar*/
execute eliminarProducto 1;
select * from productos;


/*Procedimiento consulta*/
CREATE PROCEDURE Consulta(@id int)
as begin
SELECT * FROM clientes WHERE clientes.idCliente = @id
end
execute Consulta 1;

/*Consulta*/
Select CONCAT(clientes.nombre,' ',clientes.apellido) as 'Nombre Completo', productos.nombreProducto as Producto, ventas.cantidad as Cantidad, ventas.precio as Venta, ventas.fechaVenta as Fecha 
From ventas 
     inner join clientes ON ventas.idCliente=clientes.idCliente
	 inner join productos ON ventas.idProducto=productos.idProducto
	 Where ventas.idVenta =

--/*Consulta*/
CREATE PROCEDURE buscarProducto(@idProducto int)
as begin
SELECT * FROM productos WHERE productos.idProducto = @idProducto
end

execute buscarProducto 1;




CREATE PROCEDURE buscarCliente(@idCliente int)
as begin
SELECT * FROM clientes WHERE clientes.idCliente = @idCliente
end

execute buscarProducto 1;


