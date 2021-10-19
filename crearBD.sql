CREATE TABLE Persona(
cedula int(8) NOT NULL,
nombre varchar(30) NOT NULL,
apellido varchar(30) NOT NULL,
passwd varchar(25) NOT NULL,
foto BLOB,
nickname VARCHAR(30),
activo boolean default true,
logueado boolean default false,
PRIMARY KEY(cedula));

CREATE TABLE Alumno(
cedula int(8) NOT NULL,
idGrupo INT(5),
FOREIGN KEY(cedula) REFERENCES Persona(cedula),
PRIMARY KEY(cedula));

CREATE TABLE Administrador(
cedula int(8) NOT NULL,
cargo ENUM('Director/a','Subdirector/a','Adscripto/a','Secretario/a','Otro/a') NOT NULL,
FOREIGN KEY(cedula) REFERENCES Persona(cedula),
PRIMARY KEY(cedula));

CREATE TABLE Docente(
cedula int(8) NOT NULL,
FOREIGN KEY(cedula) REFERENCES Persona(cedula),
PRIMARY KEY(cedula));

CREATE TABLE Materia(
idMateria INT(5) NOT NULL auto_increment,
nombre VARCHAR(30) NOT NULL,
PRIMARY KEY(idMateria));

CREATE TABLE Horario(
ciProfesor INT(8) NOT NULL,
horaIni DATETIME NOT NULL,
horaFin DATETIME NOT NULL,
dia ENUM('Lunes','Martes','Miercoles','Jueves','Viernes','Sabado','Domingo') NOT NULL,
FOREIGN KEY(ciProfesor) REFERENCES Docente(cedula),
PRIMARY KEY (ciProfesor,horaIni,horaFin,dia));

CREATE TABLE Orientacion(
idOrientacion INT(4) NOT NULL auto_increment,
nombre VARCHAR(20),
PRIMARY KEY(idOrientacion));

CREATE TABLE Grupo(
idGrupo INT(5) NOT NULL auto_increment,
nombreGr VARCHAR(10),
año INT(4),
idOrientacion INT(4),
FOREIGN KEY(idOrientacion) REFERENCES Orientacion(idOrientacion),
PRIMARY KEY(idGrupo));

CREATE TABLE Enseña(
idMateria INT(5) NOT NULL,
ciProfesor INT(8) NOT NULL,
idGrupo INT(5) NOT NULL,
FOREIGN KEY(ciProfesor) REFERENCES Docente(cedula),
FOREIGN KEY(idGrupo) REFERENCES Grupo(idGrupo),
PRIMARY KEY(idMateria,ciProfesor));

CREATE TABLE Consulta(
idConsulta INT(20) NOT NULL auto_increment,
ciAlumno INT(8) NOT NULL,
ciProfesor INT(8),
idMateria INT(5),
idGrupo INT(5),
FOREIGN KEY(ciAlumno) REFERENCES Alumno(cedula),
FOREIGN KEY(ciProfesor) REFERENCES Docente(cedula),
FOREIGN KEY(idMateria) REFERENCES Materia(idMateria),
FOREIGN KEY(idGrupo) REFERENCES Grupo(idGrupo),
PRIMARY KEY(idConsulta));

CREATE TABLE Chat(
idChat INT(20) NOT NULL,
horaIni DATETIME,
horaFin DATETIME,
FOREIGN KEY(idChat) REFERENCES Consulta(idConsulta),
PRIMARY KEY(idChat));

CREATE TABLE mensaje(
idMensaje INT NOT NULL auto_increment,
contenido VARCHAR(700) NOT NULL,
hora DATETIME,
idChat INT(20) NOT NULL,
idAutor INT(8) NOT NULL,
FOREIGN KEY(idChat) REFERENCES Chat(idChat),
FOREIGN KEY(idAutor) REFERENCES Persona(cedula),
PRIMARY KEY(idMensaje));

CREATE TABLE Participa(
idChat INT(20) NOT NULL,
ciAlumno INT(8) NOT NULL,
participando BOOL default true,
FOREIGN KEY(idChat) REFERENCES Chat(idChat),
FOREIGN KEY(ciAlumno) REFERENCES Alumno(cedula),
PRIMARY KEY(idChat,ciAlumno));

CREATE TABLE Asincronica(
idAsincronica INT(20) NOT NULL,
estado ENUM('Realizada','Contestada','Recibida') NOT NULL,
consulta VARCHAR(700),
respuesta VARCHAR(700),
FOREIGN KEY(idAsincronica) REFERENCES Consulta(idConsulta),
PRIMARY KEY(idAsincronica));

/* INGRESO DE DATOS DE PRUEBA*/

INSERT INTO Persona(cedula,nombre,apellido,passwd)VALUES(429329192,"Juan","Perez","contra123");
INSERT INTO Persona(cedula,nombre,apellido,passwd)VALUES(413515145,"Roberto","Díaz","Password321");
INSERT INTO Persona(cedula,nombre,apellido,passwd)VALUES(566434567,"Agustina","Ferreira","contraseña");
INSERT INTO docente SELECT cedula from persona;
INSERT INTO Persona(cedula,nombre,apellido,passwd)VALUES(145162774,"Javier","González","javidi102");
INSERT INTO Persona(cedula,nombre,apellido,passwd)VALUES(145632623,"Martín","Fernández","estoesunacontraseña");
INSERT INTO Persona(cedula,nombre,apellido,passwd)VALUES(423643512,"Mariana","Acosta","contraseña");
INSERT INTO Administrador(cedula,cargo)VALUES(423643512,"Otro/a");

INSERT INTO ORIENTACION(nombre) VALUES("Robótica");

INSERT INTO GRUPO (nombreGr,idOrientacion) VALUES ("3°BA",1);

INSERT INTO Materia(nombre) VALUES("Matemática");

INSERT INTO Materia (nombre) VALUES ("Filosofía");

INSERT INTO Enseña (idMateria,ciProfesor,idGrupo) VALUES(1,429329192,1);

INSERT INTO alumno(cedula,idGrupo) values(145632623,1);

/* SELECTS DE TODAS LAS TABLAS*/

SELECT * FROM administrador;
SELECT * FROM alumno;
SELECT * FROM asincronica;
SELECT * FROM chat;
SELECT * FROM consulta;
SELECT * FROM docente;
SELECT * FROM enseña;
SELECT * FROM grupo;
SELECT * FROM horario;
SELECT * FROM materia;
SELECT * FROM mensaje;
SELECT * FROM orientacion;
SELECT * FROM participa;
SELECT * FROM persona;
