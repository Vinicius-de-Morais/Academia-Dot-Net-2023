USE Academia_Atos;

create login TESTEUSER with password='.Senha12345678';
create user TESTE from login TESTEUSER;

exec sp_addrolemember 'DB_DATAREADER',  'TESTE';
exec sp_addrolemember 'DB_DATAWRITER',  'TESTE';


CREATE TABLE customer
(
	id INTEGER NOT NULL PRIMARY KEY IDENTITY,
	client_name VARCHAR(256) NOT NULL,
	occupation VARCHAR(256) NOT NULL
);

CREATE TABLE company
(
	id INTEGER NOT NULL PRIMARY KEY IDENTITY,
	company_name VARCHAR(256) NOT NULL,
	localizacao VARCHAR(256) NOT NULL
);

CREATE TABLE product
(
	id INTEGER NOT NULL PRIMARY KEY IDENTITY,
	fk_company INTEGER NOT NULL,
	product_name VARCHAR(256) NOT NULL,
	price VARCHAR(256) NOT NULL,
	description VARCHAR(256) NOT NULL,
	FOREIGN KEY (fk_company) REFERENCES company(id),

);

CREATE TABLE nota
(
	id INTEGER NOT NULL PRIMARY KEY IDENTITY,
	fk_company INTEGER NOT NULL,
	fk_customer INTEGER NOT NULL,
	valor VARCHAR(256) NOT NULL,
	preco VARCHAR(256) NOT NULL,
	buy_date VARCHAR(256) NOT NULL,
	FOREIGN KEY (fk_company) REFERENCES company(id),
	FOREIGN KEY (fk_customer) REFERENCES customer(id),
);
