use dbAlmoxarifado
go
create table escolaridade(
escolaridadeid int identity (1,1) primary key,
nivelescolaridade varchar(100), 
instituição varchar (100), 
datainicio date, 
datatermino date, 
previsaodeconclusao date, 
) 

ALTER TABLE Orders
ADD CONSTRAINT FK_PersonOrder
FOREIGN KEY (PersonID) REFERENCES Persons(PersonID);


select * from escolaridade
insert into escolaridade (nivelescolaridade,instituição,datainicio,datatermino) values ('Médio','SENAI','2007-10-2','2008-03-02')



create table Entrada(
codigo int identity(1,1) primary key,
dataentrada datetime,
produto varchar(100) not null
)

create Table ItensEntrada(
codigo int identity(1,1) primary key,
CodigoEntrada int not null,
CodigoProduto int not null,
Estoque int not null,
entrada_id int not null,
FOREIGN KEY (entrada_id) REFERENCES Entrada(codigo)
)
