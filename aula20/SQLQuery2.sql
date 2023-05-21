CREATE TABLE autor
(
	id INTEGER NOT NULL PRIMARY KEY IDENTITY,
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
	id INTEGER NOT NULL PRIMARY KEY,
	fk_livro VARCHAR(20) NOT NULL,
	fk_autor INTEGER NOT NULL,
	FOREIGN KEY (fk_livro) REFERENCES livro(id),
	FOREIGN KEY (fk_autor) REFERENCES autor(id)
);

-------- ADICIONANDO VALORES

INSERT INTO autor (nome, nacionalidade) VALUES ('João Silva', 'Brasil');
INSERT INTO autor (nome, nacionalidade) VALUES ('Maria Santos', 'Portugal');
INSERT INTO autor (nome, nacionalidade) VALUES ('John Smith', 'Estados Unidos');

INSERT INTO editora (nome) VALUES ('Editora A');
INSERT INTO editora (nome) VALUES ('Editora B');
INSERT INTO editora (nome) VALUES ('Editora C');

INSERT INTO categoria (tipo_categoria) VALUES ('ficção científica');
INSERT INTO categoria (tipo_categoria) VALUES ('literatura Juvenil');
INSERT INTO categoria (tipo_categoria) VALUES ('humor');

INSERT INTO livro (id, fk_editora, fk_categoria, titulo, ano_publicacao) VALUES (1, 1, 1, 'Livro 1', 2020);
INSERT INTO livro (id, fk_editora, fk_categoria, titulo, ano_publicacao) VALUES (2, 2, 2, 'Livro 2', 2018);
INSERT INTO livro (id, fk_editora, fk_categoria, titulo, ano_publicacao) VALUES (3, 3, 3, 'Livro 3', 2021);

INSERT INTO livro_autor (id, fk_livro, fk_autor) VALUES (1, 1, 1);
INSERT INTO livro_autor (id, fk_livro, fk_autor) VALUES (2, 2, 2);
INSERT INTO livro_autor (id, fk_livro, fk_autor) VALUES (3, 3, 3);


-------- COMANDOS PARA relacionar as tabelas

-- 7
SELECT * FROM Livro
ORDER BY titulo;

-- 8
SELECT * FROM Livro
LEFT JOIN autor
ON livro.id = autor.id
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


