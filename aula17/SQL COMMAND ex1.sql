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


----------------DROP TABLES----------------
DROP TABLE livro_autor;

DROP TABLE livro;


DROP TABLE categoria;

DROP TABLE autor;

DROP TABLE editora;


---------------- EXEMPLO 2 ----------------


CREATE TABLE era
(
	id INTEGER NOT NULL PRIMARY KEY IDENTITY,
	inicio INT NOT NULL,
	fim INT NOT NULL,
);

CREATE TABLE descobridor
(
	id INTEGER NOT NULL PRIMARY KEY IDENTITY,
	nome VARCHAR(256) NOT NULL,
);

CREATE TABLE localizacao
(
	id INTEGER NOT NULL PRIMARY KEY IDENTITY,
	pais VARCHAR(256) NOT NULL,
);

CREATE TABLE grupo
(
	id INTEGER NOT NULL PRIMARY KEY IDENTITY,
	nome VARCHAR(256) NOT NULL,
);

CREATE TABLE dinossauro 
(
	id VARCHAR(20) NOT NULL PRIMARY KEY,
	fk_grupo INTEGER NOT NULL,
	fk_descobridor INTEGER NOT NULL,
	fk_era INTEGER NOT NULL,
	fk_pais INTEGER NOT NULL,

	titulo VARCHAR(256) NOT NULL,
	toneladas INT NOT NULL,

	FOREIGN KEY (fk_grupo) REFERENCES grupo(id),
	FOREIGN KEY (fk_descobridor) REFERENCES descobridor(id),
	FOREIGN KEY (fk_era) REFERENCES era(id),
	FOREIGN KEY (fk_pais) REFERENCES localizacao(id)
);

---drop

DROP TABLE dinossauro;

DROP TABLE era;

DROP TABLE descobridor;

DROP TABLE localizacao;

DROP TABLE grupo;


