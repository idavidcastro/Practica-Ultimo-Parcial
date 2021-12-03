
use SimulacroUP;

create table Sede(Codigo nvarchar(15), Nombre nvarchar(20));
create table Producto(Codigo nvarchar(15), Referencia nvarchar(15), Existencia nvarchar(15));
create table InventarioSede(CodigoSede nvarchar(15), CodigoProducto nvarchar(15), Cantidad int);

insert into Sede(Codigo, Nombre) values('S001', 'Sede Norte');
insert into Sede(Codigo, Nombre) values('S002', 'Sede Sur');
insert into Sede(Codigo, Nombre) values('S003', 'Sede Centro');

insert into Producto(Codigo, Referencia, Existencia) values('P001', 'Lavadora', '0');
insert into Producto(Codigo, Referencia, Existencia) values('P002', 'Nevera', '0');
insert into Producto(Codigo, Referencia, Existencia) values('P003', 'Televisor', '0');

