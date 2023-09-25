--DDL

CREATE DATABASE HealthClinic_manha

USE HealthClinic_manha

CREATE TABLE TipoDeUsuario
( IdTipoDeUsuario UNIQUEIDENTIFIER PRIMARY KEY,
 Tipo VARCHAR (50)
)

CREATE TABLE Usuario
( IdUsuario UNIQUEIDENTIFIER PRIMARY KEY,
IdTipoUsuario UNIQUEIDENTIFIER FOREIGN KEY REFERENCES TipoDeUsuario(IdTipoDeUsuario),
Nome VARCHAR (50),
Email VARCHAR (100),
Senha VARCHAR (50)
)

CREATE TABLE Clinica
( IdClinica UNIQUEIDENTIFIER PRIMARY KEY,
Nome VARCHAR (100),
Endereco VARCHAR (100),
Cep VARCHAR (50),
HorarioAbertura TIME,
HorarioFechamento TIME,
CNPJ VARCHAR (20),
RazaoSocial VARCHAR(50)
)

CREATE TABLE Especialidade
( IdEspecialidade UNIQUEIDENTIFIER PRIMARY KEY,
 Especialidade VARCHAR (100)
)

CREATE TABLE Medico
(IdMedico UNIQUEIDENTIFIER PRIMARY KEY,
IdUsuario UNIQUEIDENTIFIER FOREIGN KEY REFERENCES Usuario(IdUsuario),
IdClinica UNIQUEIDENTIFIER FOREIGN KEY REFERENCES Clinica(IdClinica),
IdEspecialidade UNIQUEIDENTIFIER FOREIGN KEY REFERENCES Especialidade(IdEspecialidade),
Medico VARCHAR (50),
CRM VARCHAR (50)
)

CREATE TABLE Paciente
(IdPaciente UNIQUEIDENTIFIER PRIMARY KEY ,
IdUsuario UNIQUEIDENTIFIER FOREIGN KEY REFERENCES Usuario(IdUsuario),
Paciente VARCHAR (50),
DataDeNascimento VARCHAR (100),
CPF VARCHAR (50),
Sexo VARCHAR (50),
Telefone VARCHAR (50),
Email VARCHAR (100)
)

/*consulta apenas o administrador tera acesso para marcar, o diagnostico da consulta sera 
colocado no prontuario aonde o médico ira adicionar*/
CREATE TABLE Consulta
(IdConsulta UNIQUEIDENTIFIER PRIMARY KEY,
IdMedico UNIQUEIDENTIFIER FOREIGN KEY REFERENCES Medico(IdMedico),
IdPaciente UNIQUEIDENTIFIER FOREIGN KEY REFERENCES Paciente(IdPaciente),
Horario TIME,
[Data] DATE
)

CREATE TABLE  Feedback
( IdFeedback UNIQUEIDENTIFIER PRIMARY KEY,
IdConsulta UNIQUEIDENTIFIER FOREIGN KEY REFERENCES Consulta(IdConsulta),
Comentario VARCHAR (100)
)

CREATE TABLE Prontuario
( IdProntuario UNIQUEIDENTIFIER PRIMARY KEY,
 IdConsulta UNIQUEIDENTIFIER FOREIGN KEY REFERENCES Consulta(IdConsulta),
 Descricao VARCHAR (500)
)

DROP DATABASE HealthClinic_Kamille
