
/*El sector administrativo de un hotel, necesita asentar datos de clientes, habitaciones y reservas. El
detalle requerido es el siguiente:
CLIENTE: Nombre, apellido, tipo y número de documento, número de CUIT/CUIL, dirección, localidad
HABITACIONES: Número de habitación, capacidad (cant personas), número de camas, ubicación (piso,
saber si da al frente del hotel), detalle, precio
RESERVA: Cliente, habitación, fecha entrada. Fecha salida, total a pagar.*/


drop database  if exists Hotel;
create database Hotel;
use Hotel;
go;

create table Clientes(
idCliente int IDENTITY(1,1) PRIMARY KEY,
Nombre varchar(50),
Apellido varchar(50) ,
Tipo varchar(10),
NumDoc int,
Cuil int,
Direccion varchar(50),
Localidad varchar(50),
);

create table Habitaciones(
iDHabitacion int PRIMARY KEY,
NumHabitacion int,
Capacidad int,
NumCamas float,
Ubicacion int,
Detalle varchar(50),
precio float
)

create table Reserva(
IdReserva int IDENTITY(1,1) PRIMARY KEY,
IdCliente int,
IdHabitacion int, 
fechaEntrada date,
fechaSalida date,
TotalaPagar float
FOREIGN KEY (IdCliente) REFERENCES Clientes(idCliente),
FOREIGN KEY (IdHabitacion) REFERENCES Habitaciones(idHabitacion)
)

-- Insertar registros en la tabla Clientes
INSERT INTO Clientes (Nombre, Apellido, Tipo, NumDoc, Cuil, Direccion, Localidad)
VALUES
  ('Carlos', 'Perez', 'DNI', 123456789, 987654321, 'Calle Principal 123', 'Moreno'),
  ('Juan', 'Belgrano', 'CEDULA', 987654321, 123456789, 'Avenida Central 456', 'Moron'),
  ('Miguel', 'Alvarez', 'CEDULA', 555555555, 444444444, 'Calle Secundaria 789', 'San Justo'),
  ('Laura', 'Acosta', 'DNI', 222222222, 333333333, 'Avenida Norte 101', 'Ciudad D'),
  ('Roberto', 'Romero', 'DNI', 888888888, 999999999, 'Calle Miraflor 777', 'Tapiales');

-- Insertar registros en la tabla Habitaciones
INSERT INTO Habitaciones (idHabitacion, NumHabitacion, Capacidad, NumCamas, Ubicacion, Detalle, precio)
VALUES
  (1, 101, 2, 1.5, 1, 'Vista al mar', 150.0),
  (2, 102, 4, 2.0, 2, 'Vista a la ciudad', 200.0),
  (3, 201, 2, 1.5, 1, 'Vista al jardín', 120.0),
  (4, 202, 3, 2.5, 2, 'Vista a la piscina', 180.0),
  (5, 301, 1, 1.0, 3, 'Vista al patio', 80.0);

-- Insertar registros en la tabla Reserva
INSERT INTO Reserva (IdCliente, IdHabitacion, fechaEntrada, fechaSalida, TotalaPagar)
VALUES
  (1, 1, '2023-07-01', '2023-07-07', 900.0),
  (2, 2, '2023-07-02', '2023-07-05', 600.0),
  (3, 3, '2023-07-03', '2023-07-09', 720.0),
  (4, 4, '2023-07-04', '2023-07-06', 360.0),
  (5, 5, '2023-07-05', '2023-07-08', 240.0);

select * from Clientes
select * from Habitaciones
select * from Reserva

