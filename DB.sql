
USE MASTER
GO
--CREACION DE LA BASE DE DATOS
--DROP DE LA DATABASSE

/*DROP DATABASE [DB_Proyecto_P4]
GO */
--
CREATE DATABASE [DB_Proyecto_P4]
GO

USE [DB_Proyecto_P4]
GO

CREATE SCHEMA PERSON
GO

CREATE SCHEMA SERVICIO
GO

CREATE SCHEMA REGION
GO



--TABLAS DEL ESQUEMA PERSON
CREATE TABLE [PERSON].[Persona]
(
	ID_Persona int IDENTITY (1,1) NOT NULL,
	Num_Cedula int not null,
	Nombre varchar (60) not null,
	Correo_Electronico varchar (50) not null,
	Telefono int not null,
	Pais_Origen varchar (60) not null,
	Direccion varchar (100) not null,
	--Provincia_ID_Provincia int not null,--FK
	--Canton_ID_Canton int not null,--FK
	--Distrito_ID_Distrito int not null--FK
	--Tipo_Identificacion_ID_Identificacion--FK

	


	
	CONSTRAINT [PK_Persona] PRIMARY KEY CLUSTERED
		(
			ID_Persona ASC
			
		)
)
GO

CREATE TABLE [PERSON].[Tipo_Identificacion]
(
	ID_Identificacion bit NOT null,
	Tipo_Identificacion varchar (40) not null

	CONSTRAINT [PK_Tipo_Identificacion] PRIMARY KEY CLUSTERED
	(
		ID_Identificacion ASC	
	)

)


CREATE TABLE [PERSON].[Persona_FiscicaJuridica]
(
	--ID_Persona int not null,FK
	ID_Persona_FisicaJuridica int  NOT  null,
	Apellido1 varchar(15) NOT null,
	Apellido2 varchar(15) NOT null,
	--Genero_ID_Genero bit not null,---FK
	Fecha_Nacimiento DATETIME NOT NULL,
	--EstadoCivil_ID_EstadoCivil int null,--FK
	--Apoderado_ID_Apoderado bit not null,---FK

	CONSTRAINT [PK_Persona_FiscicaJuridica] PRIMARY KEY CLUSTERED
	(
		ID_Persona_FisicaJuridica ASC	
	)
)



CREATE TABLE [PERSON].[EstadoCivil]
(
	ID_EstadoCivil bit not null,
	Estado varchar (25)not null,

	CONSTRAINT [PK_EstadoCivil] PRIMARY KEY CLUSTERED
	(
		ID_EstadoCivil ASC
	)
)
GO

CREATE TABLE [PERSON].[Genero]
(
	ID_Genero bit not null,
	Tipo varchar (15)not null,

	CONSTRAINT [PK_Genero] PRIMARY KEY CLUSTERED
	(
		ID_Genero ASC
	)
)
GO

CREATE TABLE [PERSON].[Asegurado]
(
	--Persona_ID_Persona int not null,--FK
	ID_Asegurado  int IDENTITY (1,1) not null,

	CONSTRAINT [PK_Asegurado] PRIMARY KEY CLUSTERED
	(
		ID_Asegurado ASC
	)
)
GO



CREATE TABLE [PERSON].[Vendedor]
(
	--Persona_ID_Persona int not null,--FK
	ID_Vendedor int IDENTITY (1,1) not null,
	Numero_Vendedor int not null
	CONSTRAINT [PK_Vendedor] PRIMARY KEY CLUSTERED
	(
		ID_Vendedor ASC
	)
)
GO


CREATE TABLE [PERSON].[Apoderado]
(
	--Persona_ID_PersonaFisica int not null,--FK
	ID_Apoderado int  not null

	CONSTRAINT [PK_Apoderado] PRIMARY KEY CLUSTERED
	(
		ID_Apoderado ASC
	)
)
GO


CREATE TABLE [PERSON].[Beneficiario]
(
	ID_Beneficiario int not null,
	--Persona_ID_PersonaFisica int not null,--FK
	PorcentajeParticipacion int not null,
	Parentesco varchar(35) not null

	CONSTRAINT [PK_Beneficiario] PRIMARY KEY CLUSTERED
	(
		ID_Beneficiario ASC
	)
)
GO


--TABLAS DEL ESQUEMA SERVICIO
CREATE TABLE [SERVICIO].[Poliza]
(
	ID_Poliza int IDENTITY (1,1) not null,
	Nombre varchar (25),
	Descripcion varchar(100),
	--Beneficiario_ID_Beneficiario int not null,--FK
	--Planes_ID_Plan int not null,--FK
	--Asegurado_ID_Asegurado int  not null--FK

	CONSTRAINT [PK_Poliza] PRIMARY KEY CLUSTERED
	(
		ID_Poliza ASC
	)
)
GO

CREATE TABLE [SERVICIO].[Venta]
(
	ID_Venta int not null,
	--Vendedor_ID_Vendedor int not null,--FK
	--Poliza_ID_Poliza int not null,--FK
	--MetodoPago_ID_MetodoPago int not null,--FK
	CONSTRAINT [PK_Venta] PRIMARY KEY CLUSTERED
	(
		ID_Venta ASC
	)
)
GO

CREATE TABLE [SERVICIO].[MetodoPago]
(
	ID_MetodoPago int not null,
	NombrePago varchar (50)not null
	CONSTRAINT [PK_MetodoPago] PRIMARY KEY CLUSTERED
	(
		ID_MetodoPago ASC
	)
)
GO

CREATE TABLE [SERVICIO].[Tarjeta_Cred_Deb]
(
	--MetodoPago_ID_MetodoPago int not null,--FK
	ID_Tarjeta_Cred_Deb int not null,
	Numero int not null,
	Banco_Emisor varchar(20)not null,
	Fecha_Vencimiento DATETIME NOT NULL
	CONSTRAINT [PK_Tarjeta_Cred_Deb] PRIMARY KEY CLUSTERED
	(
		ID_Tarjeta_Cred_Deb ASC
	)

)
GO

CREATE TABLE [SERVICIO].[Planes]
(
	ID_Plan int not null,
	NombrePlan varchar (50)not null,
	Costo money not null,
	--Cobertura_ID_Cobertura int not null--FK
	CONSTRAINT [PK_Planes] PRIMARY KEY CLUSTERED
	(
		ID_Plan ASC
	)
)
GO

CREATE TABLE [SERVICIO].[Cobertura]
(
	ID_Cobertura int not null,
	NombreCobertura varchar (50)not null,
	Monto money not null,
	Cant_Eventos int not null,
	Cant_Beneficiarios int not null,
	CONSTRAINT [PK_Cobertura] PRIMARY KEY CLUSTERED
	(
		ID_Cobertura ASC
	)
)
GO







---TABLAS DEL ESQUEMA REGION

CREATE TABLE [REGION].[Provincia]
(
	ID_Provincia bit not null,
	Nombre_Provincia varchar (20) not null

	CONSTRAINT [PK_Provincia] PRIMARY KEY CLUSTERED
		(
			ID_Provincia ASC
		)
)
GO



CREATE TABLE [REGION].[Canton]
(
	ID_Canton bit not null,
	--Provincia_ID_Provincia bit not null,--FK
	Nombre varchar (30) not null

	CONSTRAINT [PK_Canton] PRIMARY KEY CLUSTERED
		(
			ID_Canton ASC
		)
)
GO

CREATE TABLE [REGION].[Distrito]
(
	ID_Distrito int not null,
	--Provincia_ID_Provincia bit not null, --FK
	--Canton_ID_Canton bit not null, --FK
	Nombre varchar (25)not null

	CONSTRAINT [PK_Distrito] PRIMARY KEY CLUSTERED
		(
			ID_Distrito ASC
		)
)
GO



--
---
--CREACION DE FKS
---
----

ALTER TABLE [PERSON].[Persona]
add ID_Identificacion BIT not null 
go

ALTER TABLE [PERSON].[Persona]  WITH NOCHECK ADD  CONSTRAINT FK_Persona_Tipo_Identificacion_ID_Identificacion
FOREIGN KEY(ID_Identificacion)
REFERENCES [PERSON].[Tipo_Identificacion] (ID_Identificacion)

GO

ALTER TABLE [PERSON].[Persona] CHECK CONSTRAINT FK_Persona_Tipo_Identificacion_ID_Identificacion
GO





ALTER TABLE [PERSON].[Persona]
add ID_Provincia bit not null 
go

ALTER TABLE [PERSON].[Persona]  WITH NOCHECK ADD  CONSTRAINT FK_Persona_Provincia_ID_Provincia 
FOREIGN KEY(ID_Provincia)
REFERENCES [REGION].[Provincia] (ID_Provincia)

GO

ALTER TABLE [PERSON].[Persona] CHECK CONSTRAINT FK_Persona_Provincia_ID_Provincia
GO


ALTER TABLE [PERSON].[Persona]
add ID_Canton bit not null 
go

ALTER TABLE [PERSON].[Persona]  WITH NOCHECK ADD  CONSTRAINT FK_Persona_Canton_ID_Canton 
FOREIGN KEY(ID_Canton)
REFERENCES [REGION].[Canton] (ID_Canton)

GO

ALTER TABLE [PERSON].[Persona] CHECK CONSTRAINT FK_Persona_Canton_ID_Canton
GO



ALTER TABLE [PERSON].[Persona]
add ID_Distrito int not null 
go

ALTER TABLE [PERSON].[Persona]  WITH NOCHECK ADD  CONSTRAINT FK_Persona_Distrito_ID_Distrito 
FOREIGN KEY(ID_Distrito)
REFERENCES [REGION].[Distrito] (ID_Distrito)

GO

ALTER TABLE [PERSON].[Persona] CHECK CONSTRAINT FK_Persona_Distrito_ID_Distrito
GO



ALTER TABLE [PERSON].[Persona_FiscicaJuridica]
add ID_Persona int not null 
go


ALTER TABLE [PERSON].[Persona_FiscicaJuridica]  WITH NOCHECK ADD  CONSTRAINT FK_Persona_FiscicaJuridica_Persona_ID_Persona
FOREIGN KEY(ID_Persona)
REFERENCES [PERSON].[Persona] (ID_Persona)

GO

ALTER TABLE [PERSON].[Persona_FiscicaJuridica] CHECK CONSTRAINT FK_Persona_FiscicaJuridica_Persona_ID_Persona
GO




ALTER TABLE [PERSON].[Persona_FiscicaJuridica]
add ID_Apoderado int not null 
go


ALTER TABLE [PERSON].[Persona_FiscicaJuridica]  WITH NOCHECK ADD  CONSTRAINT FK_Persona_FiscicaJuridica_Apoderado_ID_Apoderado
FOREIGN KEY(ID_Apoderado)
REFERENCES [PERSON].[Apoderado] (ID_Apoderado)

GO

ALTER TABLE [PERSON].[Persona_FiscicaJuridica] CHECK CONSTRAINT FK_Persona_FiscicaJuridica_Apoderado_ID_Apoderado
GO


ALTER TABLE [PERSON].[Persona_FiscicaJuridica]
add ID_Genero bit not null 
go

ALTER TABLE [PERSON].[Persona_FiscicaJuridica]  WITH NOCHECK ADD  CONSTRAINT FK_Persona_FiscicaJuridica_Genero_ID_Genero
FOREIGN KEY(ID_Genero)
REFERENCES [PERSON].[Genero] (ID_Genero)

GO

ALTER TABLE [PERSON].[Persona_FiscicaJuridica] CHECK CONSTRAINT FK_Persona_FiscicaJuridica_Genero_ID_Genero
GO



ALTER TABLE [PERSON].[Persona_FiscicaJuridica]
add ID_EstadoCivil bit not null 
go
ALTER TABLE [PERSON].[Persona_FiscicaJuridica]  WITH NOCHECK ADD  CONSTRAINT FK_Persona_FiscicaJuridica_EstadoCivil_ID_EstadoCivil
FOREIGN KEY(ID_EstadoCivil)
REFERENCES [PERSON].[EstadoCivil] (ID_EstadoCivil)

GO

ALTER TABLE [PERSON].[Persona_FiscicaJuridica] CHECK CONSTRAINT FK_Persona_FiscicaJuridica_EstadoCivil_ID_EstadoCivil
GO



ALTER TABLE [PERSON].[Asegurado]
add ID_Persona int not null 
go

ALTER TABLE [PERSON].[Asegurado]  WITH NOCHECK ADD  CONSTRAINT FK_Asegurado_Persona_ID_Persona 
FOREIGN KEY(ID_Persona)
REFERENCES [PERSON].[Persona] (ID_Persona)

GO

ALTER TABLE [PERSON].[Asegurado] CHECK CONSTRAINT FK_Asegurado_Persona_ID_Persona
GO


ALTER TABLE [PERSON].[Vendedor]
add ID_Persona int not null 
go

ALTER TABLE [PERSON].[Vendedor]  WITH NOCHECK ADD  CONSTRAINT FK_Vendedor_Persona_ID_Persona 
FOREIGN KEY(ID_Persona)
REFERENCES [PERSON].[Persona] (ID_Persona)

GO

ALTER TABLE [PERSON].[Vendedor] CHECK CONSTRAINT FK_Vendedor_Persona_ID_Persona
GO



ALTER TABLE [PERSON].[Apoderado]
add ID_Persona_FisicaJuridica int not null 
go


ALTER TABLE [PERSON].[Apoderado]  WITH NOCHECK ADD  CONSTRAINT FK_Apoderado_Persona_FisicaJuridica_ID_Persona_FisicaJuridica
FOREIGN KEY(ID_Persona_FisicaJuridica)
REFERENCES [PERSON].[Persona_FiscicaJuridica] (ID_Persona_FisicaJuridica)

GO

ALTER TABLE [PERSON].[Apoderado] CHECK CONSTRAINT FK_Apoderado_Persona_FisicaJuridica_ID_Persona_FisicaJuridica
GO



ALTER TABLE [PERSON].[Beneficiario]
add ID_Persona_FisicaJuridica int not null 
go

ALTER TABLE [PERSON].[Beneficiario]  WITH NOCHECK ADD  CONSTRAINT FK_Beneficiario_Persona_FisicaJuridica_ID_Persona_FisicaJuridica
FOREIGN KEY(ID_Persona_FisicaJuridica)
REFERENCES [PERSON].[Persona_FiscicaJuridica] (ID_Persona_FisicaJuridica)

GO

ALTER TABLE [PERSON].[Beneficiario] CHECK CONSTRAINT FK_Beneficiario_Persona_FisicaJuridica_ID_Persona_FisicaJuridica
GO
--CHECK

ALTER TABLE [SERVICIO].[Poliza]
add ID_Beneficiario int not null 
go

ALTER TABLE [SERVICIO].[Poliza]  WITH NOCHECK ADD  CONSTRAINT FK_Poliza_Beneficiario_ID_Beneficiario 
FOREIGN KEY(ID_Beneficiario)
REFERENCES [PERSON].[Beneficiario] (ID_Beneficiario)

GO

ALTER TABLE [SERVICIO].[Poliza] CHECK CONSTRAINT FK_Poliza_Beneficiario_ID_Beneficiario
GO

--PLANES

ALTER TABLE [SERVICIO].[Poliza]
add ID_Plan int not null 
go

ALTER TABLE [SERVICIO].[Poliza]  WITH NOCHECK ADD  CONSTRAINT FK_Poliza_Planes_ID_Plan
FOREIGN KEY(ID_Plan)
REFERENCES [SERVICIO].[Planes] (ID_Plan)

GO

ALTER TABLE [SERVICIO].[Poliza] CHECK CONSTRAINT FK_Poliza_Planes_ID_Plan
GO



ALTER TABLE [SERVICIO].[Poliza]
add ID_Asegurado int not null 
go

ALTER TABLE [SERVICIO].[Poliza]  WITH NOCHECK ADD  CONSTRAINT FK_Poliza_Asegurado_ID_Asegurado
FOREIGN KEY(ID_Asegurado)
REFERENCES [PERSON].[Asegurado](ID_Asegurado)

GO

ALTER TABLE [SERVICIO].[Poliza] CHECK CONSTRAINT FK_Poliza_Asegurado_ID_Asegurado
GO

--FIN FK's POLIZA

----FK's TABLA VENTA
--VENDEDOR
ALTER TABLE [SERVICIO].[Venta]
add ID_Vendedor int not null 
go

ALTER TABLE [SERVICIO].[Venta]  WITH NOCHECK ADD  CONSTRAINT FK_Venta_Vendedor_ID_Vendedor
FOREIGN KEY(ID_Vendedor)
REFERENCES [PERSON].[Vendedor](ID_Vendedor)

GO

ALTER TABLE [SERVICIO].[Venta] CHECK CONSTRAINT FK_Venta_Vendedor_ID_Vendedor
GO


--POLIZA
ALTER TABLE [SERVICIO].[Venta]
add ID_Poliza int not null 
go

ALTER TABLE [SERVICIO].[Venta]  WITH NOCHECK ADD  CONSTRAINT FK_Venta_Poliza_ID_Poliza
FOREIGN KEY(ID_Poliza)
REFERENCES [SERVICIO].[Poliza](ID_Poliza)

GO

ALTER TABLE [SERVICIO].[Venta] CHECK CONSTRAINT FK_Venta_Poliza_ID_Poliza
GO

--METODO PAGO
ALTER TABLE [SERVICIO].[Venta]
add ID_MetodoPago int not null 
go

ALTER TABLE [SERVICIO].[Venta]  WITH NOCHECK ADD  CONSTRAINT FK_Venta_MetodoPago_ID_MetodoPago
FOREIGN KEY(ID_MetodoPago)
REFERENCES [SERVICIO].[MetodoPago](ID_MetodoPago)

GO

ALTER TABLE [SERVICIO].[Venta] CHECK CONSTRAINT FK_Venta_MetodoPago_ID_MetodoPago
GO

----FIN FK's Venta


----FK's TABLA TARJETACRED/DEB
ALTER TABLE [SERVICIO].[Tarjeta_Cred_Deb]
add ID_MetodoPago int not null 
go
ALTER TABLE [SERVICIO].[Tarjeta_Cred_Deb]  WITH NOCHECK ADD  CONSTRAINT FK_Tarjeta_Cred_Deb_MetodoPago_ID_MetodoPago
FOREIGN KEY(ID_MetodoPago)
REFERENCES [SERVICIO].[MetodoPago](ID_MetodoPago)

GO

ALTER TABLE [SERVICIO].[Tarjeta_Cred_Deb] CHECK CONSTRAINT FK_Tarjeta_Cred_Deb_MetodoPago_ID_MetodoPago
GO

--FIN FK's TARJETACRED/DEB


---INICIO FK's PLANES
ALTER TABLE [SERVICIO].[Planes]
add ID_Cobertura int not null 
go
ALTER TABLE [SERVICIO].[Planes]  WITH NOCHECK ADD  CONSTRAINT FK_Planes_Cobertura_ID_Cobertura
FOREIGN KEY(ID_Cobertura)
REFERENCES [SERVICIO].[Cobertura](ID_Cobertura)

GO

ALTER TABLE [SERVICIO].[Planes] CHECK CONSTRAINT FK_Planes_Cobertura_ID_Cobertura
GO
--FIN  FK's PLANES




----FK's TABLA CANTON
ALTER TABLE [REGION].[Canton]
add ID_Provincia bit not null 
go

ALTER TABLE [REGION].[Canton]  WITH NOCHECK ADD  CONSTRAINT FK_Canton_Provincia_ID_Provincia
FOREIGN KEY(ID_Provincia)
REFERENCES [REGION].[Provincia](ID_Provincia)

GO

ALTER TABLE [REGION].[Canton] CHECK CONSTRAINT FK_Canton_Provincia_ID_Provincia
GO

--FIN FK's CANTON

----FK's TABLA DISTRITO
ALTER TABLE [REGION].[Distrito]
add ID_Provincia bit not null 
go
ALTER TABLE [REGION].[Distrito]  WITH NOCHECK ADD  CONSTRAINT FK_Distrito_Provincia_ID_Provincia
FOREIGN KEY(ID_Provincia)
REFERENCES [REGION].[Provincia](ID_Provincia)

GO

ALTER TABLE [REGION].[Distrito] CHECK CONSTRAINT FK_Distrito_Provincia_ID_Provincia
GO
----------------
ALTER TABLE [REGION].[Distrito]
add ID_Canton bit not null 
go

ALTER TABLE [REGION].[Distrito]  WITH NOCHECK ADD  CONSTRAINT FK_Distrito_Canton_ID_Canton
FOREIGN KEY(ID_Canton)
REFERENCES [REGION].[Canton](ID_Canton)

GO

ALTER TABLE [REGION].[Distrito] CHECK CONSTRAINT FK_Distrito_Canton_ID_Canton
GO

--CHECK


--**************-----SP's
---------------------
---------------------


CREATE PROCEDURE SP_Filtrar_Persona--LEER
@ID_Persona varchar(20)
AS
BEGIN
SELECT	ID_Persona AS [Persona],
		Num_Cedula AS [Numero_Cedula],
		Nombre AS [Name],
		Correo_Electronico AS [Correo],
		Telefono AS [Numero_Telefonico],
		Pais_Origen AS [Pais_Origen],
		Direccion AS [Direccion],
		ID_Identificacion AS [Tipo_Persona]

FROM	[PERSON].[Persona]
WHERE ID_Persona like '%' + @ID_Persona + '%'
END
GO


CREATE PROCEDURE SP_Insert_Persona--INSERT
(
@ID_Persona INT,
@Num_Cedula INT,
@Nombre VARCHAR (60),
@Correo_Electronico varchar (50),
@Telefono int,
@Pais_Origen varchar (60),
@Direccion varchar (100),

@ID_Identificacion bit

)
AS BEGIN
INSERT INTO [PERSON].[Persona] (ID_Persona,Num_Cedula,Nombre,Correo_Electronico,Telefono,Pais_Origen,Direccion,ID_Identificacion)
VALUES (@ID_Persona,@Num_Cedula,@Nombre,@Correo_Electronico,@Telefono,@Pais_Origen,@Direccion,@ID_Identificacion)
END
GO


CREATE PROCEDURE SP_Update_Persona--UPDATE

AS BEGIN
declare @ID_Persona as INT
declare @Num_Cedula as INT
declare @Nombre as VARCHAR (60)
declare @Correo_Electronico as varchar (50)
declare @Telefono as int
declare @Pais_Origen as varchar (60)
declare @Direccion as varchar (100)

declare @ID_Identificacion as bit
declare @Dato as varchar
UPDATE [PERSON].[Persona] set ID_Persona = @Dato
WHERE (ID_Persona = @ID_Persona and Num_Cedula = @Num_Cedula and Nombre = @Nombre and Correo_Electronico = @Correo_Electronico and Telefono = @Telefono and Pais_Origen = @Pais_Origen and Direccion = @Direccion and ID_Identificacion = @ID_Identificacion )
END
GO

CREATE PROCEDURE SP_Delete_Persona--DELETE
as 
begin
declare  @ID_Persona as INT 
delete from [PERSON].[Persona] 
where ID_Persona = @ID_Persona
end

go


--------------Estado Civil Proc------------------
create proc ProcEstCivillist
as 
begin
--Veo que solo habrian unos cuantos no hay necesidad de meter variables
select 
ID_EstadoCivil,
Estado 
from [PERSON].[EstadoCivil]
end
go

create proc ProcEstCivilUp
as
begin
declare @EstID as int
declare @EstEstado as varchar
update [PERSON].[EstadoCivil] set Estado = @EstEstado 
where ID_EstadoCivil = @EstID
end
go

create proc ProcEstCivilDel
as 
begin
declare @EstID as int
delete from [PERSON].[EstadoCivil] 
where ID_EstadoCivil = @EstID
end

go



--------Genero Proc---------------
create proc ProcGenerolist
as 
begin
--Veo que solo habrian unos cuantos no hay necesidad de meter variables
select 
ID_Genero,
Tipo 
from [PERSON].[Genero]
end
go

create proc ProcGeneroUp
as
begin
declare @GenID as int
declare @GenTipo as varchar
update [PERSON].[Genero] set Tipo = @GenTipo 
where ID_Genero = @GenID
end
go

create proc ProcGeneroDel
as 
begin
declare @GenID as int
delete from [PERSON].[Genero]
where ID_Genero = @GenID
end
go

-------------------Asegurado Proc-------------
create proc ProcAseguradolist
as 
begin
--Veo que solo habrian unos cuantos no hay necesidad de meter variables
select 
ID_Asegurado
from [PERSON].[Asegurado]
end
go
---Asegura solo tiene un campo no hay necesidad de hacerle update

create proc ProcAseguradoDel
as 
begin
declare @ID_Asegurado as int
delete from [PERSON].[Asegurado]
where ID_Asegurado = @ID_Asegurado
end
go




--Procedures de Listar
CREATE PROCEDURE [Listar_TarjetaCredDeb]
AS

BEGIN

SELECT	[ID_Tarjeta_Cred_deb]
		,[Numero]
		,[Banco_Emisor]
		,[Fecha_Vencimiento]
		,[ID_MetodoPago]
		FROM [SERVICIO].[Tarjeta_Cred_Deb]

END
GO

CREATE PROCEDURE [Listar_Planes]
AS

BEGIN

SELECT   [ID_Plan]
		,[NombrePlan]
		,[Costo]
		,[ID_Cobertura]
		FROM [SERVICIO].[Planes]
END
GO

CREATE PROCEDURE [Listar_Cobertura]
AS

BEGIN

SELECT  [ID_Cobertura]
		,[NombreCobertura]
		,[Monto]
		,[Cant_Eventos]
		,[Cant_Beneficiarios]
		FROM [SERVICIO].[Cobertura]
END
GO

--Procedures de Filtrar

CREATE PROCEDURE [Filtrar_TarjetaCredDeb]
(
		@Numero int,
		@Banco_Emisor varchar(20)
)
AS

BEGIN

SELECT	[ID_Tarjeta_Cred_deb]
		,[Numero]
		,[Banco_Emisor]
		,[Fecha_Vencimiento]
		,[ID_MetodoPago]
		FROM [SERVICIO].[Tarjeta_Cred_Deb]
		WHERE [Numero] like '%' + @Numero + '%'
		OR [Banco_Emisor] like '%' + @Banco_Emisor + '%'
END
GO

CREATE PROCEDURE [Filtrar_PLanes]
(
	@NombrePlan varchar(50)
)
AS
BEGIN

SELECT   [ID_Plan]
		,[NombrePlan]
		,[Costo]
		,[ID_Cobertura]
		FROM [SERVICIO].[Planes]
		WHERE [NombrePlan] like '%' + @NombrePlan + '%'
END
GO

CREATE PROCEDURE [Filtrar_Cobertura]
(
	@NombreCobertura varchar(50)
)
AS

BEGIN

SELECT  [ID_Cobertura]
		,[NombreCobertura]
		,[Monto]
		,[Cant_Eventos]
		,[Cant_Beneficiarios]
		FROM [SERVICIO].[Cobertura]
		WHERE [NombreCobertura] like '%' + @NombreCobertura + '%'
END
GO


--SP Listar
CREATE PROCEDURE [Listar_Provicia]
AS

BEGIN

SELECT	[ID_Provincia]
		,[Nombre_Provincia]
		FROM [REGION].[Provincia]

END
GO

CREATE PROCEDURE [Listar_Canton]
AS

BEGIN

SELECT   [ID_Canton]
		,[Nombre]
		FROM [REGION].[Canton]
END	
GO

CREATE PROCEDURE [Listar_Distrito]
AS

BEGIN

SELECT  [ID_Distrito]
		,[Nombre]
		FROM [REGION].[Distrito]
END
GO

--SP de Filtrar

CREATE PROCEDURE [Filtrar_Provicia]
(
		@NombreProvincia varchar(20)
)
AS

BEGIN

SELECT	[ID_Provincia]
		,[Nombre_Provincia]
		FROM [REGION].[Provincia]
		WHERE [Nombre_Provincia] like '%' + @NombreProvincia + '%'
END
GO

CREATE PROCEDURE [Filtrar_Canton]
(
	@NombreCanton varchar(20)
)
AS
BEGIN

SELECT   [ID_Canton]
		,[Nombre]
		,[ID_Provincia]
		FROM [REGION].[Canton]
		WHERE [Nombre] like '%' + @NombreCanton + '%'
END
GO

CREATE PROCEDURE [Filtrar_Distrito]
(
	@NombreDistrito varchar(20)
)
AS

BEGIN

SELECT  [ID_Distrito]
		,[Nombre]
		,[ID_Provincia]
		,[ID_Canton]
		FROM [REGION].[Distrito]
		WHERE [Nombre] like '%' + @NombreDistrito + '%'
END
GO




--------*****************-------------*************
--************************************************-

