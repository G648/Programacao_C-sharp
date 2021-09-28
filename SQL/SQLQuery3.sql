--criando uma nova DB
create database Escola;

--usando a DB
use Escola;


--criando as informações da tabela;
create table Professores
(
	Professores_id int primary key identity,
	Professores_Nome Text not null,
	Professores_Email Text not null,
	Professores_Senha varchar (12) not null
);

create table Alunos 
(
	Aluno_id int primary key identity,
	Aluno_RA Text not null,
	Aluno_Email Text not null,
	Aluno_Telefone varchar not null
);

alter table Alunos add Aluno_nome Text not null;

create table Disciplinas
(
	Disciplina_id int primary key identity,
	Disciplina_nome Text not null,
	Disciplina_Carga varchar (255) not null,
	Professores_id int foreign key references Professores (Professores_id),
);

create table matricula_alunos
(
	Matricula_id int primary key identity,
	Aluno_id int foreign key references Alunos (Aluno_id),
	Disciplina_id int foreign key references Disciplinas (Disciplina_id)
);

--verificando a tabela
select * from Alunos;
select * from Professores;
select * from matricula_alunos;
select * from Disciplinas;

delete from Alunos where Aluno_id > 0;
delete from matricula_alunos where Matricula_id = 1;
DBCC checkident('[Alunos]', reseed, 0);

--inserindo os dados dentro de uma tabela
insert into Alunos (Aluno_Nome, Aluno_RA, Aluno_Email, Aluno_Telefone) Values
('Guilherme Cezar', '123456', 'Cezarguilherme03@gmail.com', '11 94819-4502'),
('Camille Alosilla', '456789', 'Cacal03@gmail.com', '11 94587-6325');


insert into Professores (Professores_Nome, Professores_Email, Professores_Senha) Values
('Professor01','professor01@escola.com','professor1'),
('Professor02','professor02@escola.com','professor2');

insert into Disciplinas (Disciplina_Nome, Disciplina_carga, Professores_id) Values
('Matemática','480 horas',1),
('Português','480 horas',2);

insert into matricula_alunos (Aluno_id, Disciplina_id) Values
(1,2),
(2,1);
