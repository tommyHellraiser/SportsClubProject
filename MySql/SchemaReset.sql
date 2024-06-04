DROP TABLE IF EXISTS users;
DROP TABLE IF EXISTS user_roles;
DROP TABLE IF EXISTS postulants;
DROP TABLE IF EXISTS non_postulants;
DROP TABLE IF EXISTS membership;
DROP PROCEDURE IF EXISTS Login;
DROP PROCEDURE IF EXISTS NewPostulant;

CREATE TABLE user_roles(
	ID int,
	RoleName varchar(30),
	CONSTRAINT PRIMARY KEY(ID)
);

insert into user_roles values
(120,'User'),
(121,'Admin');

create table IF NOT EXISTS postulants(
	ID int AUTO_INCREMENT,
	FirstName varchar(30),
	LastName varchar(40),
	DocumentType varchar(20),
	Document int UNIQUE KEY,
    InscriptionDate date,
    ExpirationDate date,
	IsActive tinyint(3) default 1,
	constraint pk_postulant primary key(ID)
);

create table IF NOT EXISTS non_postulants(
	ID int AUTO_INCREMENT,
	FirstName varchar(30),
	LastName varchar(40),
	DocumentType varchar(20),
	Document int,
    VisitDateTime datetime DEFAULT NOW(),
	constraint pk_non_postulant primary key(ID)
);

create table IF NOT EXISTS payments(
	ID int auto_increment,
    PostulantID int NULL,
	DocumentNumber int,
    Amount float,
    constraint pk_payment primary key(ID),
    constraint fk_PostulantID foreign key(PostulantID) references postulants(ID)
);

CREATE TABLE IF NOT EXISTS users(
	ID int AUTO_INCREMENT,
	Username varchar (20) UNIQUE KEY NOT NULL,
	FirstName VARCHAR (20) NOT NULL,
	LastName varchar (20) NOT NULL,
	Pass varchar (15) NOT NULL,
	Phone varchar (20) DEFAULT NULL,
	Email varchar(15) NOT NULL,
	Birthdate date,
	UserRole INT DEFAULT 121,
	ActiveUser boolean DEFAULT TRUE,
	CONSTRAINT userPK PRIMARY KEY (ID),
	CONSTRAINT userRoleID FOREIGN KEY(UserRole) REFERENCES user_roles(ID)
);

CREATE TABLE IF NOT EXISTS memberships (
	ID INT PRIMARY KEY AUTO_INCREMENT,
	PostulantID int NOT NULL,
	ExpirationDate datetime DEFAULT NULL,
	Amount float DEFAULT 0,
	Paid tinyint(3) DEFAULT 0,
	CONSTRAINT fk_membership_postulant_id FOREIGN KEY (PostulantID) REFERENCES postulants(ID)
);

INSERT INTO users(Username, FirstName, LastName, Pass, Phone, Email, Birthdate, UserRole) 
VALUES
('paganeitor', 'Horacio', 'Pagani', '123456', '5465465', 'ml@jaja.com', '1988-12-30', 121),
('mlopez', 'Mariano', 'Lopez', '22112211', '11213456', 'the_marian@live.com', '1989-12-1', 121),
('tommy', 'Tomas', 'Ponce', '000000', '2615105315', 'hellraiser@this.com', '1994-11-25', 121);

INSERT INTO postulants(FirstName, LastName, DocumentType, Document, InscriptionDate, ExpirationDate)
VALUES('Facundo', 'Villarreal', 'DNI', 39416524, NOW(), DATE_ADD(NOW(), INTERVAL 10 DAY)),
('Tomas', 'Ponce', 'DNI', 38416584, NOW(), DATE_ADD(NOW(), INTERVAL 10 DAY));

INSERT INTO memberships(PostulantID, ExpirationDate, Amount)
VALUES (1, DATE_ADD(NOW(), INTERVAL 10 DAY), 150.0),
(2, DATE_ADD(NOW(), INTERVAL 10 DAY), 180.0);