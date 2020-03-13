create database DBescola
go

use DBescola
go

create table TBlogin(
	idLogin int primary key not null identity(1, 1),
	usuarioLogin varchar(30),
	senhaLogin varchar(50)
)
go

insert into TBlogin values (
'admin',
'1234567'
)

insert into TBlogin values (
'professor',
'1234567'
)

insert into TBlogin values (
'secretaria',
'1234567'
)

