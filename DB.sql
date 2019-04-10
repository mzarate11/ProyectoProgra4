
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
((1,'SAN JOSE',1),
(2,'El Carmen',1),
(3,'Merced',1),
(4,'Hospital',1),
(5,'Catedral',1),
(6,'Zapote',1),
(7,'San Fco.de Dos Ríos',1),
(8,'Uruca',1),
(9,'Mata Redonda',1),
(10,'Pavas',1),
(11,'Hatillo',1),
(12,'San Sebastián',1),
(13,'Escazú',2),
(14,'San Antonio',2),
(15,'San Rafael',2),
(16,'Desamparados',3),
(17,'San Miguel',3),
(18,'San Juan de Dios',3),
(19,'San Rafael Arriba',3),
(20,'San Antonio',3),
(21,'Frailes',3),
(22,'Patarrá',3),
(23,'San Cristóbal',3),
(24,'Rosario',3),
(25,'Damas',3),
(26,'San Rafael Abajo',3),
(27,'Gravilias',3),
(28,'Santiago',4),
(29,'Mercedes Sur',4),
(30,'Barbacoas',4),
(31,'Grifo Alto',4),
(32,'San Rafael',4),
(33,'Candelarita',4),
(34,'Desamparaditos',4),
(35,'San Antonio',4),
(36,'Chires',4),
(37,'San Marcos',5),
(38,'San Lorenzo',5),
(39,'San Carlos',5),
(40,'Aserrí',6),
(41,'Tarbaca',6),
(42,'Vuelta de Jorco',6),
(43,'San Gabriel',6),
(44,'Legua',6),
(45,'Monterrey',6),
(46,'Salitrillos',6),
(47,'Colón',7),
(48,'Guayabo',7),
(49,'Tabarcia',7),
(50,'Piedras Negras',7),
(51,'Picagres',7),
(52,'Guadalupe',8),
(53,'San Francisco',8),
(54,'Calle Blancos',8),
(55,'Mata de Plátano',8),
(56,'Ipís',8),
(57,'Rancho Redondo',8),
(58,'Purral',8),
(59,'Santa Ana',9),
(60,'Salitral',9),
(61,'Pozos',9),
(62,'Uruca',9),
(63,'Piedades',9),
(64,'Brasil',9),
(65,'Alajuelita',10),
(66,'San Josecito',10),
(67,'San Antonio',10),
(68,'Concepción',10),
(69,'San Felipe',10),
(70,'San Isidro',11),
(71,'San Rafael',11),
(72,'Dulce Nombre de Jesús',11),
(73,'Patalillo',11),
(74,'Cascajal',11),
(75,'San Ignacio',12),
(76,'Guaitíl',12),
(77,'Palmichal',12),
(78,'Cangrejal',12),
(79,'Sabanillas',12),
(80,'San Juan',13),
(81,'Cinco Esquinas',13),
(82,'Anselmo Llorente',13),
(83,'León XIII',13),
(84,'Colima',13),
(85,'San Vicente',14),
(86,'San Jerónimo',14),
(87,'Trinidad',14),
(88,'San Pedro',15),
(89,'Sabanilla',15),
(90,'Mercedes',15),
(91,'San Rafael',15),
(92,'San Pablo',16),
(93,'San Pedro',16),
(94,'San Juan de Mata',16),
(95,'San Luis',16),
(96,'Santa María',17),
(97,'Jardín',17),
(98,'Copey',17),
(99,'Curridabat',18),
(100,'Granadilla',18),
(101,'Sánchez',18),
(102,'Tirrases',18),
(103,'San Isidro de El General',19),
(104,'General',19),
(105,'Daniel Flores',19),
(106,'Rivas',19),
(107,'San Pedro',19),
(108,'Platanares',19),
(109,'Pejibaye',19),
(110,'Cajón',19),
(111,'Barú',19),
(112,'Río Nuevo',19),
(113,'Páramo',19),
(114,'San Pablo',20),
(115,'San Andrés',20),
(116,'Llano Bonito',20),
(117,'San Isidro',20),
(118,'Santa Cruz',20),
(119,'San Antonio',20),
(120,'Alajuela',21),
(121,'San José',21),
(122,'Carrizal',21),
(123,'San Antonio',21),
(124,'Guácima',21),
(125,'San Isidro',21),
(126,'Sabanilla',21),
(127,'San Rafael',21),
(128,'Río Segundo',21),
(129,'Desamparados',21),
(130,'Turrúcares',21),
(131,'Tambor',21),
(132,'La Garita',21),
(133,'Sarapiquí',21),
(134,'San Ramón',22),
(135,'Santiago',22),
(136,'San Juan',22),
(137,'Piedades Norte',22),
(138,'Piedades Sur',22),
(139,'San Rafael',22),
(140,'San Isidro',22),
(141,'Angeles',22),
(142,'Alfaro',22),
(143,'Volio',22),
(144,'Concepción',22),
(145,'Zapotal',22),
(146,'Peñas Blancas',22),
(147,'Grecia',23),
(148,'San Isidro',23),
(149,'San José',23),
(150,'San Roque',23),
(151,'Tacares',23),
(152,'Río Cuarto',23),
(153,'Puente de Piedra',23),
(154,'Bolívar',23),
(155,'San Mateo',24),
(156,'Desmonte',24),
(157,'Jesús María',24),
(158,'Atenas',25),
(159,'Jesús',25),
(160,'Mercedes',25),
(161,'San Isidro',25),
(162,'Concepción',25),
(163,'San José',25),
(164,'Santa Eulalia',25),
(165,'Naranjo',26),
(166,'San Miguel',26),
(167,'San José',26),
(168,'Cirrí Sur',26),
(169,'San Jerónimo',26),
(170,'San Juan',26),
(171,'Rosario',26),
(172,'Palmares',27),
(173,'Zaragoza',27),
(174,'Buenos Aires',27),
(175,'Santiago',27),
(176,'Candelaria',27),
(177,'Esquipulas',27),
(178,'Granja',27),
(179,'San Pedro',28),
(180,'San Juan',28),
(181,'San Rafael',28),
(182,'Carrillos',28),
(183,'Sabana Redonda',28),
(184,'Orotina',29),
(185,'Mastate',29),
(186,'Hacienda Vieja',29),
(187,'Coyolar',29),
(188,'Ceiba',29),
(189,'Quesada',30),
(190,'Florencia',30),
(191,'Buenavista',30),
(192,'Aguas Zarcas',30),
(193,'Venecia',30),
(194,'Pital',30),
(195,'Fortuna',30),
(196,'Tigra',30),
(197,'Palmera',30),
(198,'Venado',30),
(199,'Cutris',30),
(200,'Monterrey',30),
(201,'Pocosol',30),
(202,'Zarcero',31),
(203,'Laguna',31),
(204,'Tapezco',31),
(205,'Guadalupe',31),
(206,'Palmira',31),
(207,'Zapote',31),
(208,'Brisas',31),
(209,'Sarchí Norte',32),
(210,'Sarchí Sur',32),
(211,'Toro Amarillo',32),
(212,'San Pedro',32),
(213,'Rodríguez',32),
(214,'Upala',33),
(215,'Aguas Claras',33),
(216,'San José o Pizote',33),
(217,'Bijagua',33),
(218,'Delicias',33),
(219,'Dos Ríos',33),
(220,'Yolillal',33),
(221,'Los Chiles',34),
(222,'Caño Negro',34),
(223,'El Amparo',34),
(224,'San Jorge',34),
(225,'San Rafael',35),
(226,'Buenavista',35),
(227,'Cote',35),
(228,'Oriental',37),
(229,'Occidental',37),
(230,'Carmen',37),
(231,'San Nicolás',37),
(232,'Aguacaliente  o  San Fco.',37),
(233,'Guadalupe o Arenilla',37),
(234,'Corralillo',37),
(235,'Tierra Blanca',37),
(236,'Dulce Nombre',37),
(237,'Llano Grande',37),
(238,'Quebradilla',37),
(239,'Paraíso',38),
(240,'Santiago',38),
(241,'Orosi',38),
(242,'Cachí',38),
(243,'Tres Ríos',39),
(244,'San Diego',39),
(245,'San Juan',39),
(246,'San Rafael',39),
(247,'Concepción',39),
(248,'Dulce Nombre',39),
(249,'San Ramón',39),
(250,'Río Azul',39),
(251,'JIMENEZ',39),
(252,'Juan Viñas',39),
(253,'Tucurrique',39),
(254,'Pejibaye',39),
(255,'Turrialba',41),
(256,'La Suiza',41),
(257,'Peralta',41),
(258,'Santa Cruz',41),
(259,'Santa Teresita',41),
(260,'Pavones',41),
(261,'Tuis',41),
(262,'Tayutic',41),
(263,'Santa Rosa',41),
(264,'Tres Equis',41),
(265,'Pacayas',42),
(266,'Cervantes',42),
(267,'Capellades',42),
(268,'San Rafael',43),
(269,'Cot',43),
(270,'Potrero Cerrado',43),
(271,'Cipreses',43),
(272,'Santa Rosa',43),
(273,'El Tejar',44),
(274,'San Isidro',44),
(275,'Tobosi',44),
(276,'Patio de Agua',44),
(277,'Heredia',45),
(278,'Mercedes',45),
(279,'San Francisco',45),
(280,'Ulloa',45),
(281,'Vara Blanca',45),
(282,'Barva',46),
(283,'San Pedro',46),
(284,'San Pablo',46),
(285,'San Roque',46),
(286,'Santa Lucía',46),
(287,'San José de La Montaña',46),
(288,'Santo Domingo',47),
(289,'San Vicente',47),
(290,'San Miguel',47),
(291,'Paracito',47),
(292,'Santo Tomás',47),
(293,'Santa Rosa',47),
(294,'Tures',47),
(295,'Pará',47),
(296,'Santa Bárbara',48),
(297,'San Pedro',48),
(298,'San Juan',48),
(299,'Jesús',48),
(300,'Santo Domingo',48),
(301,'Purabá',48),
(302,'San Rafael',49),
(303,'San Josecito',49),
(304,'Santiago',49),
(305,'Angeles',49),
(306,'Concepción',49),
(307,'San Isidro',50),
(308,'San José',50),
(309,'Concepción',50),
(310,'San Francisco',50),
(311,'San Antonio',51),
(312,'Rivera',51),
(313,'Asunción',51),
(314,'San Joaquín',52),
(315,'Barrantes',52),
(316,'Llorente',52),
(317,'San Pablo',53),
(318,'Puerto Viejo',54),
(319,'La Vírgen',54),
(320,'Horquetas',54),
(321,'Llanuras del Gaspar',54),
(322,'Cureña',54),
(323,'Liberia',55),
(324,'Cañas Dulces',55),
(325,'Mayorga',55),
(326,'Nacascolo',55),
(327,'Curubandé',55),
(328,'Nicoya',56),
(329,'Mansión',56),
(330,'San Antonio',56),
(331,'Quebrada Honda',56),
(332,'Sámara',56),
(333,'Nosara',56),
(334,'Belén de Nosarita',56),
(335,'Santa Cruz',57),
(336,'Bolsón',57),
(337,'27 de Abril',57),
(338,'Tempate',57),
(339,'Cartagena',57),
(340,'Cuajiniquil',57),
(341,'Diriá',57),
(342,'Cabo Velas',57),
(343,'Tamarindo',57),
(344,'Bagaces',58),
(345,'Fortuna',58),
(346,'Mogote',58),
(347,'Río Naranjo',58),
(348,'Filadelfia',59),
(349,'Palmira',59),
(350,'Sardinal',59),
(351,'Belén',59),
(352,'Cañas',60),
(353,'Palmira',60),
(354,'San Miguel',60),
(355,'Bebedero',60),
(356,'Porozal',60),
(357,'Juntas',61),
(358,'Sierra',61),
(359,'San Juan',61),
(360,'Colorado',61),
(361,'Tilarán',62),
(362,'Quebrada Grande',62),
(363,'Tronadora',62),
(364,'Santa Rosa',62),
(365,'Líbano',62),
(366,'Tierras Morenas',62),
(367,'Arenal',62),
(368,'Carmona',63),
(369,'Santa Rita',63),
(370,'Zapotal',63),
(371,'San Pablo',63),
(372,'Porvenir',63),
(373,'Bejuco',63),
(374,'La Cruz',64),
(375,'Santa Cecilia',64),
(376,'Garita',64),
(377,'Santa Elena',64),
(378,'Hojancha',65),
(379,'Monte Romo',65),
(380,'Puerto Carrillo',65),
(381,'Huacas',65),
(382,'Puntarenas',66),
(383,'Pitahaya',66),
(384,'Chomes',66),
(385,'Lepanto',66),
(386,'Paquera',66),
(387,'Manzanillo',66),
(388,'Guacimal',66),
(389,'Barranca',66),
(390,'Monteverde',66),
(391,'Cóbano',66),
(392,'Chacarita',66),
(393,'Chira',66),
(394,'Acapulco',66),
(395,'Espíritu Santo',67),
(396,'San Juan Grande',67),
(397,'Macacona',67),
(398,'San Rafael',67),
(399,'San Jerónimo',67),
(400,'Buenos Aires',68),
(401,'Volcán',68),
(402,'Potrero Grande',68),
(403,'Boruca',68),
(404,'Pilas',68),
(405,'Colinas',68),
(406,'Chánguena',68),
(407,'Biolley',68),
(408,'Miramar',69),
(409,'Unión',69),
(410,'San Isidro',69),
(411,'Puerto Cortés',70),
(412,'Palmar',70),
(413,'Sierpe',70),
(414,'Bahía Ballena',70),
(415,'Piedras Blancas',70),
(416,'Quepos',71),
(417,'Savegre',71),
(418,'Naranjito',71),
(419,'Golfito',72),
(420,'Puerto Jiménez',72),
(421,'Guaycará',72),
(422,'Pavón',72),
(423,'San Vito',73),
(424,'Sabalito',73),
(425,'Agua Buena',73),
(426,'Limoncito',73),
(427,'Pittier',73),
(428,'Parrita',74),
(429,'Corredor',75),
(430,'La Cuesta',75),
(431,'Canoas',75),
(432,'Laurel',75),
(433,'Jacó',76),
(434,'Tárcoles',76),
(435,'Limón',77),
(436,'Valle La Estrella',77),
(437,'Río Blanco',77),
(438,'Matama',77),
(439,'Guápiles',78),
(440,'Jiménez',78),
(441,'Rita',78),
(442,'Roxana',78),
(443,'Cariari',78),
(444,'Colorado',78),
(445,'Siquirres',79),
(446,'Pacuarito',79),
(447,'Florida',79),
(448,'Germania',79),
(449,'Cairo',79),
(450,'Alegría',79),
(451,'Bratsi',80),
(452,'Sixaola',80),
(453,'Cahuita',80),
(454,'Matina',81),
(455,'Batán',81),
(456,'Carrandí',81),
(457,'Guácimo',82),
(458,'Mercedes',82),
(459,'Pocora',82),
(460,'Río Jiménez',82),
(461,'Duacarí',82);
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
							      
