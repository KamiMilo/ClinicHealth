--DML 

USE HealthClinic_Kamille

INSERT INTO TipoDeUsuario(Tipo)
VALUES ('Administrador'),('Comum')

INSERT INTO Clinica(Nome,Endereco,Cep,HorarioAbertura,HorarioFechamento,CNPJ,RazaoSocial)
VALUES ('Health','Rua: Antonieta Bairro:Boa Vista /São Caetano do Sul-SP','09572-250','08:00','22:00','78.895.892/0001-23','Clinica de Saúde')


INSERT INTO Usuario(IdTipoDeUsuario,Nome,Email,Senha)
VALUES (2,'Patricia','Pati658@gmail.com','12345'), 
		(2,'Julia','Julia@gmail.com','4321'),
		(2,'Gabriel','Gabriel@gmail.com','45698'),
		(2,'Evelyn','Evelyn@gmail.com','445878')


	  
INSERT INTO Especialidade(Especialidade)
VALUES ('Cardiologia'),
       ('oftalmologia'),
	   ('psiquiatria'),
	   ('Ortopedista')

INSERT INTO Medico(IdUsuario,IdClinica,Medico,CRM,IdEspecialidade)
VALUES (1,1,'Dra.Patricia Menezes','123587',2),
		(2,1,'Dra.Julia Oliveira','125489',1)


INSERT INTO Paciente(IdUsuario,Paciente,DataDeNascimento,CPF,Sexo,Telefone,Email)
VALUES (3,'Gabriel Junior dos Santos','26/06/1997','462.301.148-87','M','(11)3819-0759','Gabriel@gmai.com'),
       (4,'Evelyn Oliveira Mendes','05/07/2002','340.494.720-74','F','(13)99124-5141','Evelyn@gmai.com')

INSERT INTO Consulta(IdMedico,IdPaciente,Horario,[Data])
VALUES (1,2,'08:30','26-08-2023'),
		(2,1,'13:00','13-05-2023')



INSERT INTO Prontuario(IdConsulta, Descricao)
VALUES 
(1,'Com base no histórico médico, histórico ocular, exame físico e resultados de testes, 
o diagnóstico é de miopia moderada em ambos os olhos.'),

(2,'Com base no histórico médico, exame físico e resultados de exames, o diagnóstico é de Gabriel Estável de Esforço.')


INSERT INTO Feedback(IdConsulta,Comentario)
VALUES 
(1,'Excelente Atendimento'),
(2,'Doutora Super atenciosa!!')
	   


select * from TipoDeUsuario
select * from Usuario
select * from Especialidade
select * from Clinica
select * from Paciente
select * from Medico
select * from Consulta
select * from Prontuario


