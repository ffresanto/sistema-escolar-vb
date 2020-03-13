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

create proc iniciarSessao(
@Usuario varchar(30),
@Senha varchar(50),
@Msg varchar(100) output
)
as
begin
if(not exists(select * from TBlogin where 
usuarioLogin=@Usuario and senhaLogin=@Senha)) 
set
@Msg='Dados incorretos'
else 
begin
set @Msg='Bem vindo Sr(a): ' + @Usuario
end
end
go