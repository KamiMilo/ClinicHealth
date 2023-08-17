--DDL

CREATE DATABASE HealthClinic_Kamille

USE HealthClinic_Kamille

CREATE TABLE TipoDeUsuario
( IdTipoDeUsuario INT PRIMARY KEY IDENTITY,
Tipo VARCHAR (50)
)

CREATE TABLE Usuario
( IdUsuario INT PRIMARY KEY IDENTITY,
IdTipoDeUsuario INT FOREIGN KEY REFERENCES TipoDeUsuario(IdTipoDeUsuario),
Nome VARCHAR (50),
Email VARCHAR (100),
Senha VARCHAR (50)
)

CREATE TABLE Clinica
( IdClinica INT PRIMARY KEY IDENTITY,
Nome VARCHAR (100),
Endereco VARCHAR (100),
Cep VARCHAR (50),
HorarioAbertura TIME,
HorarioFechamento TIME,
CNPJ VARCHAR (20),
RazaoSocial VARCHAR(50)
)

CREATE TABLE Especialidade
( IdEspecialidade INT PRIMARY KEY IDENTITY,
 Especialidade VARCHAR (100)
)

CREATE TABLE Medico
(IdMedico INT PRIMARY KEY IDENTITY,
IdUsuario INT FOREIGN KEY REFERENCES Usuario(IdUsuario),
IdClinica INT FOREIGN KEY REFERENCES Clinica(IdClinica),
IdEspecialidade INT FOREIGN KEY REFERENCES Especialidade(IdEspecialidade),
Medico VARCHAR (50),
CRM VARCHAR (50)
)

CREATE TABLE Paciente
(IdPaciente INT PRIMARY KEY IDENTITY,
IdUsuario INT FOREIGN KEY REFERENCES Usuario(IdUsuario),
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
(IdConsulta INT PRIMARY KEY IDENTITY,
IdMedico INT FOREIGN KEY REFERENCES Medico(IdMedico),
IdPaciente INT FOREIGN KEY REFERENCES Paciente(IdPaciente),
Horario TIME,
[Data] DATE
)

CREATE TABLE  Feedback
( IdFeedback INT PRIMARY KEY IDENTITY,
IdConsulta INT FOREIGN KEY REFERENCES Consulta(IdConsulta),
Comentario VARCHAR (100)
)

CREATE TABLE Prontuario
( IdProntuario INT PRIMARY KEY IDENTITY,
 IdConsulta INT FOREIGN KEY REFERENCES Consulta(IdConsulta),
 Diagnostico VARCHAR (300),
 Preescricao VARCHAR (500)
)

DROP DATABASE HealthClinic_Kamille
