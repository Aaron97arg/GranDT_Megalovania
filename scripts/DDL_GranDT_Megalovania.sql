-- ==========================================================
-- Script de creación de base de datos: GranDT_Megalovania
-- ==========================================================

DROP DATABASE IF EXISTS GranDT_Megalovania;
CREATE DATABASE GranDT_Megalovania;
USE GranDT_Megalovania;

SELECT 'Creando Tablas' AS 'Estado';

-- ==========================================================
-- Tabla: Tipo_Futbolista
-- ==========================================================
CREATE TABLE Tipo_Futbolista (
	idTipoFutbolista TINYINT UNSIGNED AUTO_INCREMENT,
	tipoFutbolista VARCHAR(45) NOT NULL,
	CONSTRAINT PK_TipoFutbolista PRIMARY KEY (idTipoFutbolista ASC),
	CONSTRAINT UQ_TipoFutbolista_Tipo UNIQUE (tipoFutbolista ASC)
);

-- ==========================================================
-- Tabla: Equipo
-- ==========================================================
CREATE TABLE Equipo (
	idEquipo TINYINT UNSIGNED AUTO_INCREMENT,
	nombre VARCHAR(45) NOT NULL,
	CONSTRAINT PK_Equipo PRIMARY KEY (idEquipo ASC),
	CONSTRAINT UQ_Equipo_Nombre UNIQUE (nombre ASC)
);

-- ==========================================================
-- Tabla: Futbolista
-- ==========================================================
CREATE TABLE Futbolista (
	idFutbolista SMALLINT UNSIGNED AUTO_INCREMENT,
	nombre VARCHAR(45) NOT NULL,
	apellido VARCHAR(45) NOT NULL,
	apodo VARCHAR(45),
	fechaNac DATE,
	cotizacion DECIMAL(11,2),
	idEquipo TINYINT UNSIGNED,
	idTipoFutbolista TINYINT UNSIGNED,
	CONSTRAINT PK_Futbolista PRIMARY KEY (idFutbolista ASC),
	CONSTRAINT FK_Futbolista_Equipo FOREIGN KEY (idEquipo) REFERENCES Equipo (idEquipo) ON DELETE NO ACTION ON UPDATE NO ACTION,
	CONSTRAINT FK_Futbolista_Tipo FOREIGN KEY (idTipoFutbolista) REFERENCES Tipo_Futbolista (idTipoFutbolista) ON DELETE NO ACTION ON UPDATE NO ACTION
);

-- ==========================================================
-- Tabla: Usuario
-- ==========================================================
CREATE TABLE Usuario (
	idUsuario INT UNSIGNED AUTO_INCREMENT,
	nombre VARCHAR(45) NOT NULL,
	apellido VARCHAR(45) NOT NULL,
	email VARCHAR(100) NOT NULL,
	fechaNac DATE,
	contrasena CHAR(64) NOT NULL,
	es_admin TINYINT DEFAULT 0,
	CONSTRAINT PK_Usuario PRIMARY KEY (idUsuario ASC),
	CONSTRAINT UQ_Usuario_Email UNIQUE (email ASC)
);

-- ==========================================================
-- Tabla: Puntuacion
-- ==========================================================
CREATE TABLE Puntuacion (
	idPuntuacion INT UNSIGNED AUTO_INCREMENT,
	idFutbolista SMALLINT UNSIGNED NOT NULL,
	puntuacion FLOAT,
	cantFech SMALLINT,
	CONSTRAINT PK_Puntuacion PRIMARY KEY (idPuntuacion ASC),
	CONSTRAINT FK_Puntuacion_Futbolista FOREIGN KEY (idFutbolista) REFERENCES Futbolista (idFutbolista) ON DELETE NO ACTION ON UPDATE NO ACTION
);

-- ==========================================================
-- Tabla: Plantilla
-- ==========================================================
CREATE TABLE Plantilla (
	idPlantilla INT UNSIGNED AUTO_INCREMENT,
	nombreP VARCHAR(45) NOT NULL,
	cantMaxMonto DECIMAL(11,2),
	cantMaxFutbolista TINYINT,
	idUsuario INT UNSIGNED,
	idPuntuacion INT UNSIGNED,
	CONSTRAINT PK_Plantilla PRIMARY KEY (idPlantilla ASC),
	CONSTRAINT FK_Plantilla_Usuario FOREIGN KEY (idUsuario) REFERENCES Usuario (idUsuario) ON DELETE NO ACTION ON UPDATE NO ACTION,
	CONSTRAINT FK_Plantilla_Puntuacion FOREIGN KEY (idPuntuacion) REFERENCES Puntuacion (idPuntuacion) ON DELETE NO ACTION ON UPDATE NO ACTION
);

-- ==========================================================
-- Tabla: Futbolista_Plantilla
-- ==========================================================
CREATE TABLE Futbolista_Plantilla (
	idFutbolistaPlantilla INT UNSIGNED AUTO_INCREMENT,
	idFutbolista SMALLINT UNSIGNED NOT NULL,
	idPlantilla INT UNSIGNED NOT NULL,
	futbolistaTitular TINYINT DEFAULT 0,
	futbolistaSuplente TINYINT DEFAULT 0,
	validacionP TINYINT DEFAULT 0,
	validacionR TINYINT DEFAULT 0,
	CONSTRAINT PK_Futbolista_Plantilla PRIMARY KEY (idFutbolistaPlantilla ASC),
	CONSTRAINT FK_FP_Futbolista FOREIGN KEY (idFutbolista) REFERENCES Futbolista (idFutbolista) ON DELETE NO ACTION ON UPDATE NO ACTION,
	CONSTRAINT FK_FP_Plantilla FOREIGN KEY (idPlantilla) REFERENCES Plantilla (idPlantilla) ON DELETE NO ACTION ON UPDATE NO ACTION
);

SELECT 'Tablas creadas correctamente' AS 'Estado Final';
