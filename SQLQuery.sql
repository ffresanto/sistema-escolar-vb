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

create proc iniciarSessao
	@Nome varchar(30),
	@Senha varchar(50),
	@Msg varchar(100)output
as
begin
	if(not exists(select * from TBlogin where usuarioLogin=@Nome and senhaLogin=@Senha))
	set
	@Msg ='Dados incorretos'
	else
		begin
		set @Msg='Bem vindo: ' + @Nome
	end
end
go

create table TBaluno(
	cpf varchar(20) primary key,
	nome varchar(30) not null,
	sobrenome varchar(30),
	idade TINYINT,
	sexo char(1) not null check(sexo in ('M', 'F')),
	endereco varchar(100),
	data_nasc date,
)
go