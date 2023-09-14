﻿DROP DATABASE IF EXISTS academico;

CREATE DATABASE IF NOT EXISTS academico;

USE academico;

CREATE TABLE aluno (

	id			int				NOT NULL AUTO_INCREMENT,
	matricula	varchar(15)		NOT NULL,
	data_nasc	datetime		NOT NULL,
	nome		varchar(100)	NOT NULL,
	endereco	varchar(100)	NOT NULL,
	bairro		varchar(100)	NOT NULL,
	cidade		varchar(100)	NOT NULL,
	estado		varchar(02)		NOT NULL,
	senha		varchar(60)		NOT NULL,
	PRIMARY KEY (id)

);	


CREATE TABLE curso(
	id			int				NOT NULL AUTO_INCREMENT,
	nome		varchar(100)	NOT NULL,
	tipo		varchar(100)	NOT NULL, 
	ano_criacao	int				NOT NULL,
	PRIMARY KEY(id)

);


CREATE TABLE professor(
	id			int				NOT NULL AUTO_INCREMENT,
	matricula	varchar(15)		NOT NULL,
	data_nasc	datetime		NOT NULL,
	nome		varchar(100)	NOT NULL,
	titulacao	varchar(100)	NOT NULL, 
	area_formacao varchar(100)	NOT NULL,
	endereco	varchar(100)	NOT NULL,
	bairro		varchar(100)	NOT NULL,
	cidade		varchar(100)	NOT NULL,
	estado		varchar(02)		NOT NULL,
	PRIMARY KEY (id)


);