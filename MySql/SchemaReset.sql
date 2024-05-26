DROP TABLE IF EXISTS users;
DROP TABLE IF EXISTS user_roles;
DROP TABLE IF EXISTS postulants;
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

create table postulants(
	ID int AUTO_INCREMENT,
	FirstName varchar(30),
	LastName varchar(40),
	DocumentType varchar(20),
	Document int,
    InscriptionDate date,
    ExpirationDate date,
	constraint pk_postulant primary key(ID)
);

create table payment(
	ID int auto_increment,
    IdPostulant int,
    amount float default 22000,
    constraint pk_payment primary key(ID),
    constraint fk_IdPostulant foreign key(IdPostulant) references postulants(ID)
);

CREATE TABLE users(
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

INSERT INTO users(Username, FirstName, LastName, Pass, Phone, Email, Birthdate, UserRole) 
VALUES
('paganeitor', 'Horacio', 'Pagani', '123456', '5465465', 'ml@jaja.com', '1988-12-30', 121),
('mlopez', 'Mariano', 'Lopez', '22112211', '11213456', 'the_marian@live.com', '1989-12-1', 121),
('tommy', 'Tomas', 'Ponce', '000000', '2615105315', 'hellraiser@this.com', '1994-11-25', 121);
