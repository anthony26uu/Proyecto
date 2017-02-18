CREATE TABLE Articulo(IdArticulo int  primary key identity(1, 1),
NombreArticulo varchar(80), 
Existencia int, 
PrecioVenta float, 
PrecioCompra float,
Categoria varchar(80),
CodigoArticulo int,
FechaIngreso DateTime 
 );

create table Usuario(Id int primary key identity(1,1), 
nombreUsuario varchar (50),
PassUsuario varchar(70) 
);


 create table Empleado(IdEmpleado int primary key identity (1,1), 
 NombreEmpleado varchar(80),
 TelefonoEmpleado int ,
 FechaContratacion Datetime,
 Direccion varchar(100),
 Salario varchar(100),
 Cargo varchar(100),
 )
