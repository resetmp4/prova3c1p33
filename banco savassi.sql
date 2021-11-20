create database savassi;
use savassi;
create table login 
(
	id int not null primary key auto_increment,
    usuario varchar(100) not null,
    senha varchar(100) not null
   
    
);
create table jogos (
    id     int not null primary key auto_increment,
    games varchar(50) not null,
    perifericos varchar(50) not null,
    videogames varchar(50) not null
)ENGINE = InnoDB;
insert into login(id, usuario, senha) values (null, 'batata', '123');
