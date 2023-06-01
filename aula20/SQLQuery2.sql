USE Academia_Atos;

CREATE TABLE autor
(
	id INTEGER NOT NULL PRIMARY KEY IDENTITY(1,1),
	nome VARCHAR(256) NOT NULL,
	nacionalidade VARCHAR(256) NOT NULL,
);

CREATE TABLE editora
(
	id INTEGER NOT NULL PRIMARY KEY IDENTITY,
	nome VARCHAR(256) NOT NULL,
);

CREATE TABLE categoria
(
	id INTEGER NOT NULL PRIMARY KEY IDENTITY,
	tipo_categoria VARCHAR(256) NOT NULL,
);

CREATE TABLE livro 
(
	id VARCHAR(20) NOT NULL PRIMARY KEY,
	fk_editora INTEGER NOT NULL,
	fk_categoria INTEGER NOT NULL,
	titulo VARCHAR(256) NOT NULL,
	ano_publicacao INT NOT NULL,
	FOREIGN KEY (fk_editora) REFERENCES editora(id),
	FOREIGN KEY (fk_categoria) REFERENCES categoria(id)
);

CREATE TABLE livro_autor 
(
	id INTEGER NOT NULL PRIMARY KEY IDENTITY(1,1),
	fk_livro VARCHAR(20) NOT NULL,
	fk_autor INTEGER NOT NULL,
	FOREIGN KEY (fk_livro) REFERENCES livro(id),
	FOREIGN KEY (fk_autor) REFERENCES autor(id)
);

/*insert*/
insert into CATEGORIA values('Literatura Juvenil');
insert into CATEGORIA values('Ficção Científica');
insert into CATEGORIA values('Humor');
insert into CATEGORIA values('Horror Cósmico');
select * from CATEGORIA;

 

insert into AUTOR values('J.K.Rowling', 'Inglesa');
insert into AUTOR values('Clive Staples Lewis', 'Americano');
insert into AUTOR values('Affonso Solano', 'Brasileiro');
insert into AUTOR values('Marcos Piangers', 'Brasileira');
insert into AUTOR values('Marcos Piangers', 'Brasileira');
insert into AUTOR values('Ciro Botelho - Tiririca', 'Brasileiro');
insert into AUTOR values('Bianca Mól', 'Brasileiro');
select * from AUTOR;

 

insert into EDITORA values('Rocco');
insert into EDITORA values('Wmf Martins Fontes');
insert into EDITORA values('Casa da Palavra');
insert into EDITORA values('Belas Letras');
insert into EDITORA values('Matrix');
select *from EDITORA;

 

insert into LIVRO values('8532511015',1,1,'Harry Potter e A Pedra','2000');
insert into LIVRO values('9788578270698',1,2,'As Crônicas de Nárnia','2009');
insert into LIVRO values('9788577343348',3,3,'O Espadachim de Carvão','2013');
insert into LIVRO values('9788581742458',3,1,'O Papai É Pop','2015');
insert into LIVRO values('9788582302026',4,2,'Pior Que Tá Não Fica','2015');
insert into LIVRO values('9788577345670',2,3,'Garota Desdobrável','2015');
insert into LIVRO values('8532512062',1,1,'Harry Potter e o Prisioneiro de Azkaban','2000');
select *from LIVRO;

 

insert into livro_autor(fk_livro, fk_autor) values('8532511015',1);
insert into livro_autor(fk_livro, fk_autor) values('9788578270698',2);
insert into livro_autor(fk_livro, fk_autor) values('9788577343348',3);
insert into livro_autor(fk_livro, fk_autor) values('9788581742458',4);
insert into livro_autor(fk_livro, fk_autor) values('9788582302026',5);
insert into livro_autor(fk_livro, fk_autor) values('9788577345670',6);
insert into livro_autor(fk_livro, fk_autor) values('8532512062',1);
insert into livro_autor(fk_livro, fk_autor) values('8532512062',2);
select *from livro_autor;

-- 7
SELECT * FROM Livro
ORDER BY titulo;

-- 8
SELECT * FROM livro
INNER JOIN livro_autor
ON livro.id = livro_autor.fk_livro
INNER JOIN autor
ON autor.id = livro_autor.fk_autor
ORDER BY autor.nome;

-- 9
SELECT * FROM Livro
JOIN categoria ON livro.fk_categoria = categoria.id
WHERE categoria.tipo_categoria LIKE '%literatura Juvenil%'
ORDER BY ano_publicacao;

-- 10
SELECT * FROM Livro
LEFT JOIN categoria ON livro.fk_categoria = categoria.id
WHERE Livro.ano_publicacao > 2000 AND Livro.ano_publicacao < 2010
AND categoria.tipo_categoria LIKE '%humor%' OR categoria.tipo_categoria LIKE '%ficção científica%';