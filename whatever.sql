CREATE DATABASE whatever;

USE whatever;

create table tb_usuario(
codf int primary key auto_increment,
nome varchar(1000) not null,
email varchar(100) not null,
telefone varchar(11) not null,
cpf char(11) not null,
rg char(9) not null,
sexo varchar(20) not null,
dia varchar(2) not null,
mes varchar(10) not null,
ano char(4) not null,
tipo varchar (12) not null,
cep char(8) not null,
uf char(2) not null,
rua varchar(100) not null,
numero varchar(10) not null,
bairro varchar(50) not null,
cidade varchar(100) not null,
comp varchar(1000),
usuariof varchar (100) not null,
senhaf varchar (50) not null);

CREATE TABLE tb_produtos (
codp Int PRIMARY KEY auto_increment,
preço Varchar(10) not null,
barras Varchar(50) not null);

CREATE TABLE tb_venda (
total Varchar(15) not null,
codv Int PRIMARY KEY auto_increment,
codf Int,
FOREIGN KEY(codf) REFERENCES tb_usuario (codf));

CREATE TABLE tb_vendaXprodutos (
data_venda Varchar(10) not null,
preco_atual Varchar(10) not null,
codp Int,
codv Int,
FOREIGN KEY(codp) REFERENCES tb_produtos (codp),
FOREIGN KEY(codv) REFERENCES tb_venda (codv));


Insert into tb_usuario (nome, email, telefone, cpf, rg, sexo, dia, mes, ano, tipo, cep, uf, rua, numero, bairro, cidade, comp, usuariof, senhaf) 
Values ('Pedro Henrique do Carmo Pires', 'pedro.carmo200247@gmail.com', '11961798213', '46344267810', '570525147', 'Masculino', '6', 'Fevereiro', '2002', 'ADM', '06172220', 'SP', 'José Timóteo da Silva',
'120', 'São Pedro', 'Osasco', 'Bloco 3, Ap 65', 'adm', '123' );

select * from tb_usuario;