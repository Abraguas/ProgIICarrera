create database db_carrera
go 

use db_carrera 
go 

create table carreras
(
    id_carrera int identity(1,1),
    nombre varchar(50),
    titulo varchar(50)
    constraint pk_carrera primary key (id_carrera)
)
create table asignaturas 
(
    id_asignatura int identity(1,1),
    nombre varchar(50)
    constraint pk_asignaturas primary key (id_asignatura)
)
create table detalles_carrera (
    id_detalle int identity(1,1),
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