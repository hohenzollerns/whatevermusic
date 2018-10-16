create table if not exists Estados(
cod int primary key,
nome varchar(50) not null,
sigla varchar(2));

load data local infile 'C:\\Users\\Marcelo\\Desktop\\Base de dados CEP\\estados.cepaberto\\states.csv' into table Estados 
character set utf8
fields terminated by ',';

create table if not exists Cidades(
cod int primary key,
nome varchar(100) not null,
estado int not null,
constraint FK_State foreign key (estado) references Estados (cod));

load data local infile 'C:\\Users\\Marcelo\\Desktop\\Base de dados CEP\\cidades.cepaberto\\cities.csv' into table Cidades 
character set utf8
fields terminated by ',';

create table if not exists Enderecos(
cep int primary key,
rua varchar(250) not null,
bairro varchar(150) null,
fk_cidade int,
fk_estado int,
constraint A foreign key (fk_cidade) references Cidades(cod),
constraint B foreign key (fk_estado) references Estados(cod));

load data local infile 'C:\\Users\\Marcelo\\Desktop\\Base de dados CEP\\sp.cepaberto_parte_1\\sp.cepaberto_parte_1.csv' into table Enderecos 
character set utf8
fields terminated by ','
enclosed by '"';

SELECT cep, rua, bairro, CID.nome, EST.nome, entrega
                         FROM Enderecos ED 
                         INNER JOIN Cidades CID ON CID.cod = ED.fk_cidade
                         INNER JOIN Estados EST ON EST.cod = ED.fk_estado
                         WHERE cep = 06162072;