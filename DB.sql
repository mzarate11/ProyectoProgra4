
CREATE database [PROYECTOPROGRA4]
GO
/*drop data base [PROYECTOPROGRA4]
go*/

USE PROYECTOPROGRA4
GO
CREATE SCHEMA [ADMINISTRATIVO]
GO
CREATE SCHEMA [COMERCIAL]
GO
CREATE TABLE [ADMINISTRATIVO].[TIPO_IDENTIFICACION]
(
[ID_TIPO_IDENTIFICACION]  int NOT NULL,
[NOMBRE]varchar (20) NOT NULL,
CONSTRAINT [PK_ID_TIPO_IDENTIFICACION] PRIMARY KEY CLUSTERED
(
	ID_TIPO_IDENTIFICACION
)
)
GO
CREATE TABLE [ADMINISTRATIVO].[PERSONA]
(
[ID_PERSONA]  INT IDENTITY(1,1) NOT NULL,
[NO_CEDULA] int  NOT NULL,
[NOMBRE] varchar(25) NOT NULL,
[APELLIDO1] varchar(25) NOT NULL,
[APELLIDO2] varchar(25) NOT NULL,
[CORREO_ELECTRONICO] varchar(40) NOT NULL,
[TELEFONO] int  NOT NULL,
[FECHA_NACIMIENTO_CONSTITUCION] datetime NOT NULL,
[APODERADO] varchar (50)  NULL,
[ID_PROVINCIA]  int NOT NULL,
[ID_CANTON]  int NOT NULL,
[ID_DISTRITO]  int NOT NULL,
[ID_GENERO]  int NOT NULL,
[ID_ESTADO_CIVIL]  int NOT NULL,
[ID_TIPO_IDENTIFICACION]  int NOT NULL,
CONSTRAINT [PK_ID_PERSONA] PRIMARY KEY CLUSTERED
(
	ID_PERSONA
)
)
GO
CREATE TABLE [ADMINISTRATIVO].[PROVINCIA]
(
[ID_PROVINCIA]  int NOT NULL,
[NOMBRE] varchar(25),
CONSTRAINT [PK_ID_PROVINCIA] PRIMARY KEY CLUSTERED
(
	ID_PROVINCIA
) 
)
GO
CREATE TABLE [ADMINISTRATIVO].[CANTON]
(
[ID_CANTON]  int NOT NULL,
[NOMBRE] varchar(25),
[ID_PROVINCIA]  int NOT NULL,
CONSTRAINT [PK_ID_CANTON] PRIMARY KEY CLUSTERED
(
	ID_CANTON
)
)
GO
CREATE TABLE [ADMINISTRATIVO].[DISTRITO]
(
[ID_DISTRITO]  int NOT NULL,
[NOMBRE] varchar(25),
[ID_CANTON]  int NOT NULL,
CONSTRAINT [PK_ID_DISTRITO] PRIMARY KEY CLUSTERED
(
	ID_DISTRITO
)
)
GO
CREATE TABLE [ADMINISTRATIVO].[GENERO]
(
[ID_GENERO]  int NOT NULL,
[TIPO] varchar(25),
CONSTRAINT [PK_ID_GENERO] PRIMARY KEY CLUSTERED
(
	ID_GENERO
)
)
GO
CREATE TABLE [ADMINISTRATIVO].[ESTADO_CIVIL]
(
[ID_ESTADO_CIVIL]  int NOT NULL,
[ESTADO] varchar(25),
CONSTRAINT [PK_ID_ESTADO_CIVIL] PRIMARY KEY CLUSTERED
(
	ID_ESTADO_CIVIL
)
)
GO
CREATE TABLE [ADMINISTRATIVO].[USUARIO]
(
[ID_USUARIO]  int IDENTITY(1,1) NOT NULL,
[ID_PERSONA]  INT NOT NULL,
[NOMBRE] varchar(25),
[CONTRASEÑA] varchar(25),
[ROL] int,
CONSTRAINT [PK_ID_USUARIO] PRIMARY KEY CLUSTERED
(
	ID_USUARIO
)
)
GO
CREATE TABLE [COMERCIAL].[POLIZA]
(
[ID_POLIZA]  int IDENTITY(1,1) NOT NULL,
[NOMBRE] varchar(50),
[DESCRIPCION] varchar(25),
[ID_BENEFICIARIO] INT NOT NULL,
[ID_PLAN]  int NOT NULL,
[ID_VENTA]  int NOT NULL,
CONSTRAINT [PK_ID_POLIZA] PRIMARY KEY CLUSTERED
(
	ID_POLIZA
)
)
GO
CREATE TABLE [COMERCIAL].[PLANES]
(
[ID_PLAN]  int NOT NULL,
[NOMBRE] varchar(200),
[COSTO] money,
[ID_COBERTURA]  int NOT NULL,
CONSTRAINT [PK_ID_PLAN] PRIMARY KEY CLUSTERED
(
	ID_PLAN
)
)
GO
CREATE TABLE [COMERCIAL].[COBERTURA]
(
[ID_COBERTURA]  int NOT NULL,
[NOMBRE] varchar(25),
[MONTO] money,
[CANT_EVENTOS] int,
[CANT_BENEFICIARIOS] int,
CONSTRAINT [PK_ID_COBERTURA] PRIMARY KEY CLUSTERED
(
	ID_COBERTURA
)
)
GO
CREATE TABLE [COMERCIAL].[TARJETA_CREDITO_DEBITO]
(
[ID_TARJETA_CREDITO_DEBITO]  int IDENTITY(1,1) NOT NULL,
[NUMERO] int,
[BANCO_EMISOR] varchar(50),
[FECHA_VENCIMIENTO] date,
CONSTRAINT [PK_ID_TARJETA_CREDITO_DEBITO] PRIMARY KEY CLUSTERED
(
	ID_TARJETA_CREDITO_DEBITO
)
)
GO
CREATE TABLE [COMERCIAL].[VENTA]
(
[ID_VENTA]  int IDENTITY(1,1) NOT NULL,
[FECHA_EMISION] DATE NOT NULL,
[ID_TARJETA_CREDITO_DEBITO]  int NOT NULL,
CONSTRAINT [PK_ID_VENTA] PRIMARY KEY CLUSTERED
(
	ID_VENTA
)
)
GO
CREATE TABLE [COMERCIAL].[BENEFICIARIO]
(
[ID_BENEFICIARIO] INT IDENTITY(1,1) NOT NULL,
[PORCENT_PRTICIPACION] INT NOT NULL,
[NOMBRE] VARCHAR(50),
[APELLIDO_1] VARCHAR(50),
[APELLIDO__2] VARCHAR(50),
CONSTRAINT [PK_ID_BENEFICIARIO] PRIMARY KEY CLUSTERED
(
	ID_BENEFICIARIO
)
)
GO
ALTER TABLE [ADMINISTRATIVO].[CANTON]
ADD CONSTRAINT [FK_PROVINCIA_C]
	FOREIGN KEY (ID_PROVINCIA)
	REFERENCES [ADMINISTRATIVO].[PROVINCIA]
GO
ALTER TABLE [ADMINISTRATIVO].[DISTRITO]
ADD CONSTRAINT [FK_CANTON_P]
	FOREIGN KEY (ID_CANTON)
	REFERENCES [ADMINISTRATIVO].[CANTON]
GO
ALTER TABLE [ADMINISTRATIVO].[PERSONA] WITH NOCHECK
ADD CONSTRAINT [FK_TIPO_IDENTIFICACION]
	FOREIGN KEY (ID_TIPO_IDENTIFICACION)
	REFERENCES [ADMINISTRATIVO].[TIPO_IDENTIFICACION]
GO
ALTER TABLE [ADMINISTRATIVO].[PERSONA] WITH NOCHECK
ADD CONSTRAINT [FK_TIPO_PROVINCIA]
	FOREIGN KEY (ID_PROVINCIA)
	REFERENCES [ADMINISTRATIVO].[PROVINCIA]
GO
ALTER TABLE [ADMINISTRATIVO].[PERSONA] WITH NOCHECK
ADD CONSTRAINT [FK_CANTON]
	FOREIGN KEY (ID_CANTON)
	REFERENCES [ADMINISTRATIVO].[CANTON]
GO
ALTER TABLE [ADMINISTRATIVO].[PERSONA] WITH NOCHECK
ADD CONSTRAINT [FK_DISTRITO]
	FOREIGN KEY (ID_DISTRITO)
	REFERENCES [ADMINISTRATIVO].[DISTRITO]
GO
ALTER TABLE [ADMINISTRATIVO].[PERSONA] WITH NOCHECK
ADD CONSTRAINT [FK_GENERO]
	FOREIGN KEY (ID_GENERO)
	REFERENCES [ADMINISTRATIVO].[GENERO]
GO
ALTER TABLE [ADMINISTRATIVO].[PERSONA] WITH NOCHECK
ADD CONSTRAINT [FK_ESTADO_CIVIL]
	FOREIGN KEY (ID_ESTADO_CIVIL)
	REFERENCES [ADMINISTRATIVO].[ESTADO_CIVIL]
GO
ALTER TABLE [ADMINISTRATIVO].[USUARIO]
ADD CONSTRAINT [FK_PERSONA]
	FOREIGN KEY (ID_PERSONA)
	REFERENCES [ADMINISTRATIVO].[PERSONA]
GO
ALTER TABLE [COMERCIAL].[PLANES]
ADD CONSTRAINT [FK_COBERTURA]
	FOREIGN KEY (ID_COBERTURA)
	REFERENCES [COMERCIAL].[COBERTURA]
GO
ALTER TABLE [COMERCIAL].[VENTA]
ADD CONSTRAINT [FK_ID_TARJETA_CREDITO_DEBITO]
	FOREIGN KEY (ID_TARJETA_CREDITO_DEBITO)
	REFERENCES [COMERCIAL].[TARJETA_CREDITO_DEBITO]
GO
ALTER TABLE [COMERCIAL].[POLIZA]
ADD CONSTRAINT [FK_ID_BENEFICIARIO]
	FOREIGN KEY (ID_BENEFICIARIO)
	REFERENCES [COMERCIAL].[BENEFICIARIO]
GO
ALTER TABLE [COMERCIAL].[POLIZA]
ADD CONSTRAINT [FK_VENTA]
	FOREIGN KEY (ID_VENTA)
	REFERENCES [COMERCIAL].[VENTA]
GO
ALTER TABLE [COMERCIAL].[POLIZA]
ADD CONSTRAINT [FK_ID_PLANES]
	FOREIGN KEY (ID_PLAN)
	REFERENCES [COMERCIAL].[PLANES]
GO
INSERT INTO [ADMINISTRATIVO].[TIPO_IDENTIFICACION] (ID_TIPO_IDENTIFICACION,NOMBRE) VALUES
(1,'Cedula'),(2,'Pasaporte'),(3,'Residencia'),(4,'Cedula Juridica'),(5,'Otros')
GO
INSERT INTO [ADMINISTRATIVO].[PROVINCIA] ([ID_PROVINCIA],[NOMBRE]) VALUES
(1, 'San José'),
(2, 'Alajuela'),
(3, 'Cartago'),
(4, 'Heredia'),
(5, 'Guanacaste'),
(6, 'Puntarenas'),
(7, 'Limón');  

GO
INSERT INTO [ADMINISTRATIVO].[CANTON] ([ID_CANTON],[NOMBRE],[ID_PROVINCIA]) VALUES

--SAN JOSE
(1, 'San José',1),
(2, 'Escazú',1),
(3, 'Desamparados',1),
(4, 'Puriscal',1),
(5, 'Tarrazú',1),
(6, 'Aserrí',1),
(7, 'Mora',1),
(8, 'Goicoechea',1),
(9, 'Santa Ana',1),
(10, 'Alajuelita',1),
(11, 'Vasquez de Coronado',1),
(12, 'Acosta',1),
(13, 'Tibas',1),
(14, 'Moravia',1),
(15, 'Montes de Oca',1),
(16, 'Turrubares',1),
(17, 'Dota',1),
(18, 'Curridabat',1),
(19, 'Perez Zeledon',1),
(20, 'Leon Cortez',1),  
--ALAJUELA
(21, 'Alajuela',2),
(22, 'San Ramón',2),
(23, 'Grecia',2),
(24, 'San Mateo',2),
(25, 'Atenas',2),
(26, 'Naranjo',2),
(27, 'Palmares',2),
(28, 'Poás',2),
(29, 'Orotina',2),
(30, 'San Carlos',2),
(31, 'Zarceri',2),
(32, 'Valverde Vega',2),
(33, 'Upala',2),
(34, 'Los Chiles',2),
(35, 'Guatuso',2),
(36, 'Río Cuarto',2),
--CARTAGO
(37, 'Cartago',3),
(38, 'Paraíso',3),
(39, 'La Unión',3),
(40, 'Jiménez',3),
(41, 'Turrialba',3),
(42, 'Alvarado',3),
(43, 'Oreamuno',3),
(44, 'El Guarco',3),
--HEREDIA
(45, 'Heredia',4),
(46, 'Barva',4),
(47, 'Santo Domingo',4),
(48, 'Santa Bárbara',4),
(49, 'San Rafael',4),
(50, 'San Isidro',4),
(51, 'Belén',4),
(52, 'Flores',4),
(53, 'San Pablo',4),
(54, 'Sarapiquí',4),
--GUANACASTE
(55, 'Liberia',5),
(56, 'Nicoya',5),
(57, 'Santa Cruz',5),
(58, 'Bagaces',5),
(59, 'Carrillo',5),
(60, 'Cañas',5),
(61, 'Abangares',5),
(62, 'Tilarán',5),
(63, 'Nandayure',5),
(64, 'La Cruz',5),
(65, 'Hojancha',5),
--PUNTARENAS
(66, 'Puntarenas',6),
(67, 'Esparza',6),
(68, 'Buenos Aires',6),
(69, 'Montes de Oro',6),
(70, 'Osa',6),
(71, 'Quepos',6),
(72, 'Golfito',6),
(73, 'Coto Brus',6),
(74, 'Parrita',6),
(75, 'Corredores',6),
(76, 'Garabito',6),
--LIMON
(77, 'Limón',7),
(78, 'Pococí',7),
(79, 'Siquirres',7),
(80, 'Talamanca',7),
(81, 'Matina',7),
(82, 'Guácimo',7)

GO
INSERT INTO [ADMINISTRATIVO].[DISTRITO]([ID_DISTRITO],[NOMBRE],[ID_CANTON]) VALUES
--Sanjosé
()
GO
INSERT INTO [ADMINISTRATIVO].[GENERO] ([ID_GENERO],[TIPO]) VALUES
(1,'Masculino'), (2, 'Femenino')
GO
INSERT INTO [ADMINISTRATIVO].[ESTADO_CIVIL] ([ID_ESTADO_CIVIL],[ESTADO]) VALUES
(1,'Soltero'),(2,'Casado'),(3,'Separado'),(4,'Divorcio'),(5,'Unión Libre'),(6, 'Viudez')
GO
INSERT INTO [COMERCIAL].[COBERTURA] ([ID_COBERTURA],[NOMBRE],[MONTO],[CANT_EVENTOS],[CANT_BENEFICIARIOS]) VALUES
(1,'Completa',5000000,12,5),(2,'Parcial',2500000,6,3),(3,'Personal',1000000,12,1)
GO
INSERT INTO [COMERCIAL].[PLANES] ([ID_PLAN],[NOMBRE],[COSTO],[ID_COBERTURA]) VALUES
(1,'Poliza de seguro básico (completa)',417000,1),
(2,'Poliza de seguro básico (Parcial)',417000,2),
(3,'Poliza de seguro básico (Personal)',84000,3),
(4,'Seguro grupal de Responsabilidad Civil Profesional (completa)',417000,1),
(5,'Seguro grupal de Responsabilidad Civil Profesional (Parcial)',417000,2),
(6,'Seguro grupal de Responsabilidad Civil Profesional (Personal)',84000,3),
(7,'Poliza de seguro médico voluntario (completa)',417000,1),
(8,'Poliza de seguro médico voluntario (Parcial)',417000,2),
(9,'Poliza de seguro médico voluntario (Personal)',84000,3),
(10,'Poliza de seguro de vida 01-16VIC-299 (completa)',417000,1),
(11,'Poliza de seguro de vida 01-16VIC-299 (Parcial)',417000,2),
(12,'Poliza de seguro de vida 01-16VIC-299 (Personal)',84000,3),
(13,'Reclamos  y solicitud de beneficiarios (completa)',417000,1),
(14,'Reclamos  y solicitud de beneficiarios (Parcial)',417000,2),
(15,'Reclamos  y solicitud de beneficiarios (Personal)',84000,3),
(16,'Medicos pensionados (completa)',417000,1),
(17,'Medicos pensionados (Parcial)',417000,2),
(18,'Medicos pensionados (Personal)',84000,3),
(19,'Seguro de asistencia al Viajero (completa)',417000,1),
(20,'Seguro de asistencia al Viajero (Parcial)',417000,2),
(21,'Seguro de asistencia al Viajero (Personal)',84000,3),
(22,'Poliza Colectiva de vida (completa)',417000,1),
(23,'Poliza Colectiva de vida (Parcial)',417000,2),
(24,'Poliza Colectiva de vida (Personal)',84000,3),
(25,'Formularios del Seguro Básico del Colegio de Medicos (completa)',417000,1),
(26,'Formularios del Seguro Básico del Colegio de Medicos (Parcial)',417000,2),
(27,'Formularios del Seguro Básico del Colegio de Medicos (Perosnal)',84000,3)
GO
							      
		--SP's
 CREATE PROCEDURE [dbo].[SP_Read_Persona]--LEER
AS
BEGIN
SELECT

[ID_PERSONA] AS [ID_Persona]
[NO_CEDULA] AS [Numero_Cedula],
[NOMBRE] AS [Name],
[APELLIDO1] AS [PrimerApellido],
[APELLIDO2] AS [SegundoApellido],
[CORREO_ELECTRONICO] AS [Correo],
[TELEFONO] [Numero_Telefonico],
[FECHA_NACIMIENTO_CONSTITUCION] AS [FechaNacimiento],
[APODERADO] AS [Apoderado]
[ID_PROVINCIA]  AS [Provincia]
[ID_CANTON] AS [Canton],
[ID_DISTRITO]  AS [Distrito]
[ID_GENERO]  AS [Genero]
[ID_ESTADO_CIVIL]  AS [Estado_Civil]
[ID_TIPO_IDENTIFICACION] AS [Tipo_Identificacion]
FROM	[ADMINISTRATIVO].[PERSONA]
END
GO



CREATE PROCEDURE [dbo].[SP_Insert_Persona]--INSERT
(
@ID_Persona INT,
@Num_Cedula INT,
@Nombre VARCHAR (25),
@APELLIDO1 varchar(25),
@APELLIDO2 varchar(25),
@Correo_Electronico varchar (40),
@Telefono int,
@FechaNacimiento DATETIME,
@Apoderado varchar (50),
@ID_PROVINCIA int ,
@ID_CANTON int, 
@ID_DISTRITO  int ,
@ID_GENERO  int,
@ID_ESTADO_CIVIL  int,
@Tipo_Identificacion int

)
AS BEGIN
INSERT INTO [ADMINISTRATIVO].[PERSONA] ([ID_PERSONA],[NO_CEDULA],[NOMBRE],[APELLIDO1],[APELLIDO2],
[CORREO_ELECTRONICO],[TELEFONO],[FECHA_NACIMIENTO_CONSTITUCION],[APODERADO],[ID_PROVINCIA],
[ID_CANTON],[ID_DISTRITO],[ID_GENERO],[ID_ESTADO_CIVIL],[ID_TIPO_IDENTIFICACION])

VALUES (@ID_Persona,@Num_Cedula,@Nombre,@APELLIDO1,@APELLIDO2,@Correo_Electronico,
@Telefono,@FechaNacimiento,@Apoderado,@ID_PROVINCIA,@ID_CANTON,@ID_DISTRITO,
@ID_GENERO,@ID_ESTADO_CIVIL,@Tipo_Identificacion)
END
GO

CREATE PROCEDURE [dbo].[SP_Update_Persona]--UPDATE

AS BEGIN

declare @ID_Persona as INT
declare @Num_Cedula as INT
declare @Nombre as VARCHAR (25)
declare @APELLIDO1 as varchar(25)
declare @APELLIDO2 as  varchar(25)
declare @Correo_Electronico as varchar (40)
declare @Telefono as int
declare @FechaNacimiento as DATETIME
declare @Apoderado as varchar (50)
declare @ID_PROVINCIA as int 
declare @ID_CANTON as int 
declare @ID_DISTRITO as int 
declare @ID_GENERO as int
declare @ID_ESTADO_CIVIL as int
declare @Tipo_Identificacion as int
declare @Dato as varchar 

declare @UPDATE as varchar
							 
UPDATE [ADMINISTRATIVO].[PERSONA]  set [ID_PERSONA] = @Dato
WHERE ([ID_PERSONA] = @ID_Persona and 
[NO_CEDULA] = @Num_Cedula and
[NOMBRE] = @Nombre and 
[APELLIDO1] = @Apellido1 and 
[APELLIDO2] = @Apellido2 and 
[CORREO_ELECTRONICO] = @Correo_Electronico and 
[TELEFONO] = @Telefono and 
[FECHA_NACIMIENTO_CONSTITUCION] = @FechaNacimiento and 
[APODERADO] = @Apoderado and
[ID_PROVINCIA] = @ID_PROVINCIA and 
[ID_CANTON] = @ID_CANTON and
[ID_DISTRITO] = @ID_DISTRITO and 
[ID_GENERO] = @ID_GENERO and 
[ID_TIPO_IDENTIFICACION] = @Tipo_Identificacion)
END
GO

CREATE PROCEDURE [dbo].[SP_Delete_Persona]--DELETE
as 
begin
declare  @ID_Persona as INT 
delete from [ADMINISTRATIVO].[PERSONA] 
where ID_Persona = @ID_Persona
end

go
							      
