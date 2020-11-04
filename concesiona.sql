use master
create database concesiona


use concesiona

create table Tipo_vehiculo(
	id int primary key,
	nombre varchar(25)
)

create procedure addTipo_vehiculo(
	@id int,
	@nombre varchar(25)
)
as insert into Tipo_vehiculo values (@id,@nombre)

exec addTipo_vehiculo 1,'mazda'

select * from Tipo_vehiculo

create procedure updateTipo_vehiculo(
	@id int,
	@nombre varchar(25)
)
as update Tipo_vehiculo set nombre=@nombre where id=@id

create procedure deleteTipo_vehiculo(
	@id int
)
as delete from Tipo_vehiculo where id=@id
---------------------
---------------------
create table Vehiculo(
  id int primary key,
  marca varchar(25) unique,
  modelo varchar(25) not null,
  placa varchar(6) not null,
  anio int not null,
  id_tv int not null,
  constraint rel_a_tipovehi foreign key (id_tv)
  references Tipo_Vehiculo (id)
)

create procedure addVehiculo(
  @id int ,
  @marca varchar(25),
  @modelo varchar(25),
  @placa varchar(6),
  @anio int,
  @id_tv int
)

as insert into Vehiculo values (@id,@marca,@modelo,@placa,@anio,@id_tv)

exec addVehiculo 1,'chevrolet','2019','651hgj','2020',1

select * from Vehiculo

create procedure update_vehiculo(
  @id int ,
  @marca varchar(25),
  @modelo varchar(25),
  @placa varchar(6),
  @anio int,
  @id_tv int
)
as update Vehiculo set marca=@marca, modelo=@modelo, placa=@placa, anio=@anio, id_tv=@id_tv where id=@id

create procedure delete_vehiculo(
	@id int
)
as delete from Vehiculo where id=@id

--------------------------------
--------------------------------
create table Tipo_conductor(
	id int primary key,
	tipo_persona varchar(25)
)

create procedure addtipo_conductor(
	@id int,
	@tipo_persona varchar(25)
)
as insert into Tipo_conductor values (@id,@tipo_persona)

exec addtipo_conductor 1,'camionero'

select * from Tipo_conductor

create procedure update_tipoconductor(
	@id int,
	@tipo_persona varchar(25)
)
as update Tipo_conductor set tipo_persona=@tipo_persona where id=@id

create procedure delete_tipoconductor(
	@id int
)
as delete from Tipo_conductor where id=@id
-------------------------------------
-------------------------------------

create table Conductor(
	id int primary key,
	nombre varchar(25),
	tipo_licencia varchar(25),
	id_vehiculo int,
	constraint rel_a_vehi foreign key (id_vehiculo) references Vehiculo (id),
	id_tipo_conductor int,
	constraint rel_a_conduc foreign key (id_tipo_conductor) references Tipo_conductor (id)

)

create procedure addconductor(
	@id int,
	@nombre varchar(25),
	@tipo_licencia varchar(25),
	@id_vehiculo int,
	@id_tipo_conductor int
)
as insert into Conductor values(@id,@nombre,@tipo_licencia,@id_vehiculo,@id_tipo_conductor)

exec addconductor 1,'juan','a1',1,1

select * from Conductor

create procedure update_conductor(
	@id int,
	@nombre varchar(25),
	@tipo_licencia varchar(25),
	@id_vehiculo int,
	@id_tipo_conductor int
)
as update Conductor set nombre=@nombre, tipo_licencia=@tipo_licencia, id_vehiculo=@id_vehiculo, id_tipo_conductor=@id_tipo_conductor where id=@id

create procedure delete_conductor(
	@id int
)
as delete from Conductor where id=@id
--------------------------------------
---------------------------------------

create table Contrato(
	id int primary key,
	id_conductor int,
	constraint rel_a_idcon foreign key (id_conductor) references Conductor (id),
	id_vehiculo int
	constraint rel_a_idvehi foreign key (id_vehiculo) references Vehiculo (id)

)

create procedure addcontrato(
	@id int,
	@id_conductor int,
	@id_vehiculo int
)
as insert into Contrato values(@id,@id_conductor,@id_vehiculo)

exec addcontrato 1,1,1

select * from Contrato

create procedure UpdateContrato(
	@id int,
	@id_conductor int,
	@id_vehiculo int
)
as update Contrato set  id_conductor=@id_conductor, id_vehiculo=@id_vehiculo where id=@id

create procedure deleteContrato(
	@id int
)
as delete from Contrato where id=@id

----------------------------------
-------------------------------------

create table Ruta(
	id int primary key,
	estacion varchar(20),
	id_vehiculo int,
	constraint rela_a_vehi foreign key (id_vehiculo) references Vehiculo (id)
)

create procedure addruta(
	@id int,
	@estacion varchar(20),
	@id_vehiculo int
)
as insert into Ruta values (@id,@estacion,@id_vehiculo)

exec addruta 1,'miraflores',1

select * from Ruta

create procedure updateruta(
	@id int,
	@estacion varchar(20),
	@id_vehiculo int
)
as update Ruta set estacion=@estacion, id_vehiculo=@id_vehiculo where id=@id

create procedure deleteruta(
	@id int
)
as delete from Ruta where id=@id