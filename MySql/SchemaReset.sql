DROP TABLE IF EXISTS users;
DROP TABLE IF EXISTS user_roles;
DROP PROCEDURE IF EXISTS Login;

CREATE TABLE user_roles(
ID int,
RoleName varchar(30),
CONSTRAINT PRIMARY KEY(ID)
);

insert into user_roles values
(120,'Admin'),
(121,'User');

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
VALUES('paganeitor', 'Horacio', 'Pagani', '123456', '5465465', 'ml@jaja.com', '1988-12-30', 121);
