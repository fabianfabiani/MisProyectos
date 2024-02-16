use Laboratorio;
drop database  if exists Laboratorio;
create database Laboratorio;
go;

create table Facturas(
Letra varchar(1),
Numero int ,
ClienteID int,
ArticuloID int,
Fecha date,
Monto float,
PRIMARY KEY(Letra, Numero)
);

create table Articulos(
ArticuloID int primary key,
Nombre varchar(50),
Precio float,
Stock int)

create table Clientes(
ClienteID int primary key,
Nombre varchar(50),
Apellido varchar(50),
Cuit char(16),
Direccion varchar(50),
Comentarios varchar(50)
)

insert into Facturas(Letra, Numero, ClienteID, ArticuloID, Fecha, Monto)
values ('A', 28, 14, 335, '2021-03-18', 1589.50),
		('A', 39, 26, 157, '2021-04-12', 979.75),
		('B', 8, 17, 95, '2021-04-25', 513.35),
		('B', 12, 5, 411, '2021-05-03', 2385.70),
		('B', 19, 50, 157, '2021-05-26', 979.75);

select * from Facturas

insert into Articulos(ArticuloID, Nombre, Precio, Stock)
values (95, 'Webcam con Mocrofono', 513.35, 39),
		(157, 'Apple AirPods Pro', 979.75, 152),
		(335, 'Lavarropas automatico Samsumg', 1589.50, 12),
		(411, 'Gloria Trevi', 2385.70, 2)
select * from Articulos

insert into Clientes(ClienteID, Nombre, Apellido, Cuit, Direccion, Comentarios)
values (5, 'Samtiago', 'Gonzales', 23-24582359-9, 'Uriburu 558 -7ºA', 'VIP'),
		(14, 'Gloria', 'Fernandez', 23-35965852-5, 'Contitucion 323', 'GBA'),
		(17, 'Gonzalo', 'Lopez', 23-33587416-0, 'Arias 2624', 'GBA'),
		(26, 'Carlos','Garcia', 23-42321230-9, 'Pasteur 322 -2ºC', 'VIP'),
		(50, 'Micaela', 'Altieri', 23-22885566-5, 'Santamarina 1255', 'GBA')

select * from Clientes

select *
from Articulos
where Precio > 100

select *
from Articulos
where Precio > 20 and Precio <40

select *
from Articulos
where Precio between 40 and 60

select *
from Articulos
where Precio = 700 and Stock > 30

select *
from Articulos
where Precio = 1220.30

select *
from Articulos
where Precio in (1220.30)

select *
from Articulos
where Precio not in (1220.30)

/*3- Listar los artículos ordenados por precio de mayor a menor, y si hubiera precios iguales deben quedar
ordenados por nombre.*/
select *
from Articulos
order by Precio DESC, Nombre DESC

/*4- Listar todos los artículos incluyendo una columna denominada precio con IVA, la cual deberá tener el monto
con el iva del producto.*/
select ArticuloID, Nombre, Precio, Stock, Precio * 1.21 as Con_IVA
from Articulos

/*5- Listar todos los artículos incluyendo una columna denominada “cantidad de cuotas” y otra “valor de cuota”, la
cantidad es fija y es 3, el valor de cuota corresponde a 1/3 del monto con un 5% de interés.*/
select ArticuloID, Nombre, Precio, Stock, 3 as "Cantidad de cuotas", (Precio / 3)*1.05 as "Valor de cuota"
from Articulos

/* EJERCICIO 4: (Fórmula) precio * 1.21
EJERCICIO 5: (Fórmula) (precio /3)*1.05 */

sp_tables
select * from sys.databases
select * from sys.tables

