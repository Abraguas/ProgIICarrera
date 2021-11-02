create database db_carrera
go 

use db_carrera 
go 

create table carreras
(
    id_carrera int,
    nombre varchar(50),
    titulo varchar(50)
    constraint pk_carrera primary key (id_carrera)
)
create table asignaturas 
(
    id_asignatura int IDENTITY(1,1),
    nombre varchar(50)
    constraint pk_asignaturas primary key (id_asignatura)
)
create table detalles_carrera (
    id_detalle int IDENTITY(1,1),
    id_carrera int,
    anio_cursado tinyint,
    cuatrimestre tinyint,
    id_materia int
    constraint pk_detalles primary key (id_detalle,id_carrera),
    constraint fk_carrera_detalle foreign key (id_carrera)
    references carreras (id_carrera),
    constraint fk_detalle_materia foreign key (id_materia)
    references asignaturas (id_asignatura)
)
go

create procedure insertar_carrera
@id int,
@nombre varchar(50),
@titulo varchar(50)
as
begin 
    insert into carreras values(@id,@nombre,@titulo)
end 
go

create procedure insertar_detalle
@id_carrera int,
@anio int,
@cuatrimestre int,
@id_materia int
as
begin 
    insert into detalles_carrera values(@id_carrera,@anio,@cuatrimestre,@id_materia)
end 
go

create procedure insertar_asignatura
@nombre varchar (50)
as
begin
	insert into asignaturas values (@nombre)
end
go

create procedure consultar_asignatura
as
begin
	select * from asignaturas
end
go

create procedure consultar_carrera_id
@id int
as
begin
	select * from carreras
	where id_carrera = @id
end
go

create procedure consultar_detalles_id
@id int
as
begin
	select d.id_detalle, d.id_carrera, d.anio_cursado, d.cuatrimestre, d.id_materia, a.nombre
	from detalles_carrera d join asignaturas a on a.id_asignatura = d.id_materia
	where d.id_carrera = @id
end
go

create procedure verificar_carrera_id
@id int
as 
begin 
    select count(*)
    from carreras 
    where id_carrera = @id
end
go 

create procedure verificar_asignatura_id
@id int
as 
begin 
    select count(*)
    from asignaturas
    where id_asignatura = @id
end
go 

create procedure verificar_detalle_id
@id_detalle int
as 
begin 
    select count(*)
    from detalles_carrera
    where id_detalle = @id_detalle
end
go 

create procedure borrar_carrera_id
@id int 
as 
begin 
    delete detalles_carrera
    where id_carrera = @id 
    delete carreras 
    where id_carrera =@id
end 
go


create procedure borrar_asignatura_id
@id int 
as 
begin 
    delete detalles_carrera
    where id_materia = @id 
    delete asignaturas
    where id_asignatura = @id 
end 
go

create procedure borrar_detalle_id
@id_detalle int 
as 
begin 
    delete detalles_carrera
    where id_detalle = @id_detalle 
end 
go

create procedure actualizar_carrera
@id int,
@nombre varchar(50),
@titulo varchar(50)
as
begin 
    update carreras 
    set 
        nombre = @nombre,
        titulo = @titulo
    where id_carrera = @id
end 
go

create procedure actualizar_asignatura
@id int,
@nombre varchar(50)
as
begin 
    update asignaturas
    set nombre = @nombre
    where id_asignatura = @id
end 
go

create procedure consultar_carrera
as
begin
	select * from carreras
end
go

create procedure carrera_proximo_id
@next int OUTPUT
as
begin
    set @next = (select max(id_carrera)+1  from carreras);
end
go
