use db_supermercado;

select * from tb_funcionario;

create table if not exists Estados(
cod int primary key,
nome varchar(50) not null,
sigla varchar(2));

load data infile 'C:\\Users\\Marcelo\\Desktop\\Base de dados CEP\\estados.cepaberto\\states.csv' into table Estados 
character set utf8
fields terminated by ',';

select * from estados;

create table if not exists Cidades(
cod int primary key,
nome varchar(100) not null,
estado int not null,
constraint FK_State foreign key (estado) references Estados (cod));

load data infile 'C:\\Users\\Marcelo\\Desktop\\Base de dados CEP\\cidades.cepaberto\\cities.csv' into table Cidades 
character set utf8
fields terminated by ',';

select * from cidades;

create table if not exists Enderecos(
cep int primary key,
rua varchar(250) not null,
bairro varchar(150) null,
fk_cidade int,
fk_estado int,
constraint A foreign key (fk_cidade) references Cidades(cod),
constraint B foreign key (fk_estado) references Estados(cod));

load data infile 'C:\\Users\\Marcelo\\Desktop\\Base de dados CEP\\sp.cepaberto_parte_1\\sp.cepaberto_parte_1.csv' into table Enderecos 
character set utf8
fields terminated by ','
enclosed by '"';

select * from enderecos where cep = 06162072;