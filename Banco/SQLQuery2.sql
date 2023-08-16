--DML 

USE HealthClinic_Kamille

INSERT INTO TipoDeUsuario(Tipo)
VALUES ('Administrador'),('Comum')

INSERT INTO Clinica(Nome,Endereco,Cep,HorarioAbertura,HorarioFechamento,CNPJ,RazaoSocial)
VALUES ('Health','Rua: Antonieta Bairro:Boa Vista /São Caetano do Sul-SP','09572-250','08:00','22:00','78.895.892/0001-23','Clinica de Saúde')

INSERT INTO Usuario(IdTipoDeUsuario,Nome,Email,Senha)
VALUES (2,'Patricia','Pati658@gmail.com','12345'),
       (2,'Julia','Juliaa8@gmail.com','54321'),
	   (1,'Kamille','kamille@gmail.com','0000'),
	   (2,'Gabriel','Gabriel@gmai.com','1111'),
	   (2,'Evelyn','Evelyn@gmai.com','2222')
	  
INSERT INTO Especialidade(Especialidade)
VALUES ('Cardiologia'),
       ('oftalmologia'),
	   ('psiquiatria'),
	   ('Ortopedista')

INSERT INTO Medico(IdUsuario,IdClinica,Medico,CRM,IdEspecialidade)
VALUES (1,1,'Patricia Furtado','2315454',3),
       (2,1,'Julia Athar','23549964',1)

INSERT INTO Paciente(IdUsuario,Paciente,Idade,CPF,Sexo,Telefone,Email)
VALUES (4,'Gabriel Coral dos Santos','26','462.301.148-87','M','(11) 3819-0759','Gabriel@gmai.com'),
       (5,'Evelyn Oliveira Mendes','19','340.494.720-74','F','(13) 99124-5141','Evelyn@gmai.com')

INSERT INTO Consulta(IdMedico,IdPaciente,Horario,[Data],Diagnostico)
VALUES (1,2,'09:30:00','15-09-2023','paciente ')

INSERT INTO Feedback(IdConsulta,Comentario)
VALUES (1,'')
	   


select * from TipoDeUsuario
select * from Usuario
select * from especialidade
select * from clinica
select * from Paciente
select * from Consulta



