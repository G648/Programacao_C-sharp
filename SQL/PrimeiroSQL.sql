--Criando um banco de dados;
create database Filmes;

--Acessando banco de dados;
use Filmes;

--Criando tabelas;
create table Generos
(
	idGeneros int primary key identity, 
	Nome varchar(200) not null
);

create table Filmes
(
	idFilmes int primary key identity,
	Nome  varchar (255) not null,
	Sinopse varchar (255),
	idGeneros int foreign key  references Generos (idGeneros)  --conectar com a chave principal da  tabela de origem;
);
--primeiro criar a tabela estrangeira para passar os valores para a tabela principal;

--comandos DML -- linguagem de manipulação de dados
--inserte, alter e delete
--inserir dados em uma tabela
insert into Generos ( Nome) values ('Ação');
insert into Generos ( Nome) values ('Ficção');
insert into Generos ( Nome) values ('Aventura');
insert into Generos ( Nome) values ('Comédia');

--deletar uma informaçãp da tabela
delete from Generos where idGeneros > 0;
delete from Filmes where idGeneros > 0;

-- atualizar dados de uma tabela;
update Generos set  Nome = 'Comédia/drama' where idGeneros = 24;

--resetar identity
DBCC checkident('[Generos]', reseed, 0);
DBCC checkident('[Filmes]', reseed, 0);

--selecionar dados em uma tabela;
select idGeneros, Nome from Generos;

select * from Generos;
select * from Filmes;

--cadastrando Filmes

insert into Filmes (Nome, Sinopse, idGeneros, duracao) Values 
('Tropa de Elite', 'Guerra no Rio de Janeiro', 1, '80 min'),
('Tropa de Elite 2', 'O inimigo agora é outro!', 1, '145 min'),
('Alice', 'Mundo Imaginario', 3, '200 min');

--alterando tabelas;

alter table Filmes add duracao varchar (255);

--juntando dados de duas tabelas (inner join)
select Filmes.Nome, Filmes.Sinopse, Generos.Nome as Genero, Filmes.duracao from Filmes --tabela 1
inner join Generos --tabela 2
on Filmes.idFilmes = Generos.idGeneros; --qual sera a coluna afetada

select F.Nome, F.Sinopse, G.Nome as Genero, F.duracao from Filmes as F --tabela 1
inner join Generos  as G--tabela 2
on F.idFilmes = G.idGeneros; --qual sera a coluna afetada

--inserir duração
-- update Filmes set duracao = '120 min' where idFilmes = 1;
-- update Filmes set duracao = '128 min' where idFilmes = 2; -- atualizar dados dentro de uma linha específica;
