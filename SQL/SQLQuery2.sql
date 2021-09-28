--usando a tabela;
use blog;

--mostrando tabelas;
select * from Usuario;
select * from Posts;
select * from Comentarios;

--limpando uma tabela;

delete from Posts where post_id > 0;

delete from Comentarios where comentarios_id > 0;

delete from Usuario where usuario_id > 0;

--resetando a numeração;
DBCC checkident('[Usuario]', reseed, 0);
DBCC checkident ('[Posts]', reseed, 0);
DBCC checkident ('[Comentarios]', reseed, 0);

--criando os dados;
insert into Usuario (Nome, Email,Senha) Values
('Guilherme cezar de AMORIM', 'cezarguilherme03@gmail.com','aobaa'),
('Fernando', 'fernandinho', 'salve salve' ),
('Natalia', 'natalinha', 'senhaNat'),
('Milke','Milezinha@bonitinha','MilGrau');

--alterando dados dentro de uma tabela;
alter table Posts add fk_usuario_id int foreign key references Usuario (usuario_id);

--inserindo dados dentro de uma tabela;
insert into Posts (Conteudo, Titulo, fk_usuario_id) Values
('the revenge of the jedi', 'Star Wars', 1);

insert into Comentarios (Conteudo, Comentario_data, comentario_hora, usuario_id, post_id) Values
(
	'Esse filme é muito bom!!!',
	GETDATE(),
	'14:10',
	1,
	1
);

--listando a quantidade de alguma coisa;
select COUNT (usuar-io_id) as Quantidade_de_user from Usuario;