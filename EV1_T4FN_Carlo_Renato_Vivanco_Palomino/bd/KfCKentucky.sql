create database KFCKentucky
go

use KFCKentucky
go

set datefomat DMY
go

create table Usuario(
	dni_usua int primary key,
	nom_usua varchar(35) not null,
	fecNac_usua datetime,
	email_usua varchar(45) not null,
	tel_usua int
)

select * from Usuario