# BeautySaloon

docker run -d -p 3306:3306 --name mysql-docker-container -e MYSQL_DATABASE=BSDB -e MYSQL_USER=admin -e MYSQL_PASSWORD=password -e MYSQL_ALLOW_EMPTY_PASSWORD=YES mysql/mysql-server:latest

docker ps

PAUSE

--------------------

БД

-- BSDB.Clients definition

CREATE TABLE `Clients` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `FirstName` varchar(100) NOT NULL,
  `SurnName` varchar(100) NOT NULL,
  `MiddleName` varchar(100) DEFAULT NULL,
  `PhoneNumber` varchar(20) NOT NULL,
  `BirthDate` date NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- BSDB.Employees definition

CREATE TABLE `Employees` (
  `FirstName` varchar(100) NOT NULL,
  `SurnName` varchar(100) NOT NULL,
  `MiddleName` varchar(100) DEFAULT NULL,
  `Id` int NOT NULL AUTO_INCREMENT,
  `Position` text NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- BSDB.Cares definition

CREATE TABLE `Cares` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `Name` text NOT NULL,
  `Price` float NOT NULL,
  PRIMARY KEY (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- BSDB.Orders definition

CREATE TABLE `Orders` (
  `Id` int NOT NULL AUTO_INCREMENT,
  `IdClient` int NOT NULL,
  `IdEmployee` int NOT NULL,
  `IdCare` int NOT NULL,
  `DateOrder` date NOT NULL,
  `StartTime` time NOT NULL,
  `EndTime` time NOT NULL,
  `Status` varchar(15) CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci NOT NULL,
  PRIMARY KEY (`Id`),
  KEY `Orders_FK` (`IdClient`),
  KEY `Orders_FK_1` (`IdEmployee`),
  KEY `Orders_FK_2` (`IdCare`),
  CONSTRAINT `Orders_FK` FOREIGN KEY (`IdClient`) REFERENCES `Clients` (`Id`),
  CONSTRAINT `Orders_FK_1` FOREIGN KEY (`IdEmployee`) REFERENCES `Employees` (`Id`),
  CONSTRAINT `Orders_FK_2` FOREIGN KEY (`IdCare`) REFERENCES `Cares` (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

-- BSDB.CareToEmployee definition

CREATE TABLE `CareToEmployee` (
  `IdCare` int NOT NULL,
  `IdEmployee` int NOT NULL,
  PRIMARY KEY (`IdCare`,`IdEmployee`),
  KEY `CareToEmployee_FK_1` (`IdEmployee`),
  CONSTRAINT `CareToEmployee_FK` FOREIGN KEY (`IdCare`) REFERENCES `Cares` (`Id`),
  CONSTRAINT `CareToEmployee_FK_1` FOREIGN KEY (`IdEmployee`) REFERENCES `Employees` (`Id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

======================

INSERT INTO BSDB.Employees (FirstName,SurnName,MiddleName,`Position`) VALUES
	 ('Кулачкова','Галина','Петровна','Стажер'),
	 ('Драникова','Мария','Родионовна','Младший мастер'),
	 ('Иванова','Дарья','Андреевна','Мастер'),
	 ('Урюпина','Жанна','Аркадьевна','Мастер'),
	 ('Ежова','Елизавета','Сергеевна','Старший мастер'),
	 ('Стасиковна','Анастасия',NULL,'Мастер');

INSERT INTO BSDB.Cares (Name,Price) VALUES
	 ('Окрашивание волос',2300.0),
	 ('Стрижка волос',1500.0),
	 ('Причёска',900.0),
	 ('Маникюр ',2000.0),
	 ('Педикюр',1455.0),
	 ('Мейкап',999.0),
	 ('Макияж',1000.0),
	 ('Удаление кутикул',1345.0),
	 ('Чистка лица',3211.0);



INSERT INTO BSDB.CareToEmployee (IdEmployee,IdCare) VALUES
	 (1,1),
	 (1,3),
	 (2,1),
	 (2,2),
	 (2,3),
	 (2,4),
	 (3,1),
	 (3,2),
	 (3,3),
	 (3,4);
INSERT INTO BSDB.CareToEmployee (IdEmployee,IdCare) VALUES
	 (3,5),
	 (3,8),
	 (3,9),
	 (4,1),
	 (4,2),
	 (4,3),
	 (4,4),
	 (4,5),
	 (4,8),
	 (4,9);
INSERT INTO BSDB.CareToEmployee (IdEmployee,IdCare) VALUES
	 (5,1),
	 (5,2),
	 (5,3),
	 (5,4),
	 (5,5),
	 (5,6),
	 (5,7),
	 (5,8),
	 (5,9),
	 (6,1);
INSERT INTO BSDB.CareToEmployee (IdEmployee,IdCare) VALUES
	 (6,2),
	 (6,3),
	 (6,4),
	 (6,5),
	 (6,8),
	 (6,9);


INSERT INTO BSDB.Clients (FirstName,SurnName,MiddleName,PhoneNumber,BirthDate) VALUES
	 ('Ахмеджанова','Таисия','Владимирна','79379999999','2003-04-13'),
	 ('Лалкина','Надежда','Миксимовна','79379990000','2007-11-20');


INSERT INTO BSDB.Orders (IdClient,IdEmployee,IdCare,DateOrder,StartTime,EndTime,Status) VALUES
	 (1,1,1,'2023-04-03','13:00:00','14:00:00','completed'),
	 (1,5,6,'2023-04-10','13:00:00','14:00:00','canceled'),
	 (1,5,6,'2023-04-12','13:00:00','14:00:00','completed'),
	 (2,3,9,'2023-04-29','13:00:00','14:00:00','new');
