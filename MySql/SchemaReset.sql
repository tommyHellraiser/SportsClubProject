DROP DATABASE IF EXISTS SportsClub;
CREATE DATABASE SportsClub;
use SportsClub;

DROP TABLE IF EXISTS USER;
DROP TABLE IF EXISTS roles;
DROP PROCEDURE IF EXISTS Login;

create table roles(
RoleUser int,
NameRole varchar(30),
constraint primary key(RoleUser)
);

insert into roles values
(120,'Admin'),
(121,'User');

create table user(
CodUser int auto_increment,
NameUser varchar (20) UNIQUE KEY NOT NULL,
LastName varchar (20),
PassUser varchar (15) NOT NULL,
Phone varchar (20),
Email varchar(15),
Birthday date,
RoleUser int,
ActiveUser boolean default true,
constraint pk_user primary key (CodUser),
constraint fk_user foreign key(RoleUser) references roles(RoleUser)
);

insert into user(CodUser,NameUser,LastName,PassUser,Phone,Email,
Birthday,RoleUser) values
(26,'Horacio','Pagani','123456','5465465','ml@jaja.com','1988-12-30',121);
