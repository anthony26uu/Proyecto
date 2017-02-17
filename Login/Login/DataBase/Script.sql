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
