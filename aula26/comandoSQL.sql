USE Academia_Atos;

create login TESTEUSER with password='.Senha12345678';
create user TESTE from login TESTEUSER;

exec sp_addrolemember 'DB_DATAREADER',  'TESTE';
exec sp_addrolemember 'DB_DATAWRITER',  'TESTE';


CREATE TABLE pessoa
(
	id INTEGER NOT NULL PRIMARY KEY IDENTITY,
	nome VARCHAR(256) NOT NULL,
	profissao VARCHAR(256) NOT NULL
);


insert into pessoa values('carlinhos', 'encanador');
insert into pessoa values('romario', 'jogador');

Select * from pessoa

Drop table pessoa;