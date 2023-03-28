CREATE DATABASE Nutrisoft;

USE Nutrisoft;


CREATE TABLE Deportista(
identificacion VARCHAR(11) PRIMARY KEY,
tipoIdentificacion VARCHAR(40),
nombre VARCHAR(40),
apellido VARCHAR(40),
sexo VARCHAR,
fecha_Nacimiento DATE,
telefono VARCHAR(12),
correo VARCHAR(100),
peso FLOAT NULL,
altura FLOAT NULL,
deporte VARCHAR(50),
pesoActual FLOAT NULL,
fechaEgreso DATE,
caloriasDiarias FLOAT NULL,
metabolismoBasal FLOAT NULL,
termogenesisActividadFisica VARCHAR(50) NULL
);

SELECT *FROM Deportista;

CREATE TABLE Alimento (
id VARCHAR(5) PRIMARY KEY,
nombre VARCHAR(50),
caloria FLOAT NULL,
carbohidrato FLOAT NULL,
proteinas FLOAT NULL,
liquidos FLOAT NULL
);

CREATE TABLE Plantilla(
nombrePlantilla VARCHAR(50) PRIMARY KEY,
porcion INT NULL,
categoria VARCHAR(50),
idDieta VARCHAR(5),
idAlimento VARCHAR(5)
);

CREATE TABLE Dieta(
id INT IDENTITY(1,1000) PRIMARY KEY,
diasAplicada VARCHAR(100),
recomendacionAlimentaria VARCHAR(MAX),
recomendacionNutriccional VARCHAR(MAX),
idDeportista VARCHAR(11),
CONSTRAINT PK_DIETA_DEPORTISTA FOREIGN KEY (idDeportista) REFERENCES Deportista(identificacion)
);