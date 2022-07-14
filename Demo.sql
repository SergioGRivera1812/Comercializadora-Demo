create database Demo
use Demo

create table Producto(
IdProducto int identity primary key not null,
Fecha varchar(15) ,
Hora varchar(15),
Peso int,
TProducto varchar(max),
caseta varchar(max)
);

create table Puertos(
IdPuerto int identity primary key not null,
Puerto varchar(8)
)

create table Baudios(
IdBaudio int identity primary key not null,
Baudio varchar(30)
)
drop table Baudios
select * from Baudios
