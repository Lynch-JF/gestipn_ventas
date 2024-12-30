Create database Respuesto;

use Respuesto;
Create table Usuario(
id int IDENTITY(1,1) PRIMARY KEY,
usuario varchar(255) NOT NULL,
contrasena varchar(20)
)



use Respuesto;
Create table Clientes(
id int IDENTITY(1,1) PRIMARY KEY,
Nombre varchar(255) NOT NULL,
Apellido varchar(255) not null,
Cedula int not null,
Telefono varchar(15) not null,
Direccion varchar(255) not null
)

use Respuesto;
Create table Productos(
id int IDENTITY(1,1) PRIMARY KEY,
Nombre varchar(255) NOT NULL,
Descripcion varchar(255) not null,
Precio float not null,
Stock int not null,
Proveedor varchar(255) not null
)


use Respuesto;
Create table Compras(
id int IDENTITY(1,1) PRIMARY KEY,
Fecha datetime NOT NULL,
Proveedor varchar(255) not null,
Productos varchar(255) not null,
Cantidad int not null,
Precio_total float not null,
Forma_pago varchar(255) not null
)

use Respuesto;
Create table Ingresar_P(
id int IDENTITY(1,1) PRIMARY KEY,
Descripcion varchar(255) NOT NULL,
Canitdad int not null
)

	use Respuesto
	select * from Compras


use Respuesto;
Create table Ventas(
id int IDENTITY(1,1) PRIMARY KEY,
Fecha datetime NOT NULL,
Cliente varchar(255) not null,
Productos varchar(255) not null,
Precio_total float not null,
Forma_pago varchar(255) not null
)


use Respuesto
ALTER TABLE Clientes
ALTER COLUMN Cedula BIGINT;

use Respuesto;
Create table Productos(
id int IDENTITY(1,1) PRIMARY KEY,
Nombre varchar(255) NOT NULL,
Descripcion varchar(255) not null,
Precio float not null,
Stock int not null,
Proveedor varchar(255) not null
)
use Respuesto
Select * from Compras