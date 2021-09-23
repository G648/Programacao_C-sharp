--Modelo fisico

create database blog;

--usando o banco de dados
use blog;

-- criando as tabelas

create table Usuario
(
	usuario_id int primary key identity,
	Nome varchar (200) not null,
	Email varchar (100) not null,
	Senha varchar (12) not null
);

create table Posts
(
	post_id int primary key identity,
	Conteudo Text  not null,
	Titulo Text not null
);

create table Comentarios
(
	comentarios_id int primary key identity,
	Conteudo Text not null,
	Comentario_data date,
	comentario_hora time (0),
	usuario_id int foreign key references Usuario (usuario_id),
	post_id int foreign key references Posts (post_id)
	
);

insert into Usuario (Nome, Email,Senha) Values
('Guilherme cezar de AMORIM', 'cezarguilherme03@gmail.com','aobaa'),
('Fernando', 'fernandinho', 'salve salve' ),
('Natalia', 'natalinha', 'senhaNat'),
('Milke','Milezinha@bonitinha','MilGrau');

insert into Posts (Titulo,Conteudo) Values	
('Star Wars ','Guerra nas estrelas'),
('Filmes','Historia dos Filmes antigos');

insert into Comentarios (usuario_id, post_id, comentario_hora,Comentario_data, Conteudo) Values
(
	1,
	1,
	'16:25:00',
	'2021-09-23', --data
	'Excelente escolha, star wars é muito bom!!!'
);

--deletando info
delete from Usuario where usuario_id > 0;
DBCC checkident('[Usuario]', reseed, 0);



--vendo as tabelas
select * from Usuario;
select * from Posts;
select * from Comentarios;