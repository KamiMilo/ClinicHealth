--DML 

USE HealthClinic_Kamille

INSERT INTO TipoDeUsuario(Tipo)
VALUES ('Administrador'),('Comum')

INSERT INTO Clinica(Nome,Endereco,Cep,HorarioAbertura,HorarioFechamento,CNPJ,RazaoSocial)
VALUES ('Health','Rua: Antonieta Bairro:Boa Vista /S�o Caetano do Sul-SP','09572-250','08:00','22:00','78.895.892/0001-23','Clinica de Sa�de')

INSERT INTO Usuario(IdTipoDeUsuario,Nome,Email,Senha)
VALUES (2,'Patricia','Pati658@gmail.com','12345'),
       (2,'Julia','Juliaa8@gmail.com','54321'),
	   (1,'Kamille','kamille@gmail.com','0000'),
	   (2,'Gabriel','Gabriel@gmai.com','1111'),
	   (2,'Evelyn','Evelyn@gmai.com','2222'),
	   (2,'Jo�o','joao@gmail.com','33332')
	  
INSERT INTO Especialidade(Especialidade)
VALUES ('Cardiologia'),
       ('oftalmologia'),
	   ('psiquiatria'),
	   ('Ortopedista')

INSERT INTO Medico(IdUsuario,IdClinica,Medico,CRM,IdEspecialidade)
VALUES (1,1,'Dra.Patricia Furtado','2315454',1),
       (2,1,'Dra.Julia Athar','23549964',2),
	   (6,1,'Dr.Jo�o Menezes','32569874','4')


INSERT INTO Paciente(IdUsuario,Paciente,DataDeNascimento,CPF,Sexo,Telefone,Email)
VALUES (4,'Gabriel Junior dos Santos','26/06/1997','462.301.148-87','M','(11)3819-0759','Gabriel@gmai.com'),
       (5,'Evelyn Oliveira Mendes','05/07/2002','340.494.720-74','F','(13)99124-5141','Evelyn@gmai.com')

INSERT INTO Consulta(IdMedico,IdPaciente,Horario,[Data])
VALUES (2,1,'09:30 ','15-09-2023'),
       (1,1,'11:00','08-09-2023'),
	   (3,2,'13:30','11-10-2023')

INSERT INTO Prontuario(IdConsulta,Diagnostico,Preescricao)
VALUES 
(1,'Com base no hist�rico m�dico, hist�rico ocular, exame f�sico e resultados de testes, 
o diagn�stico � de miopia moderada em ambos os olhos.',': Receitados �culos para corre��o da miopia, 
com as seguintes especifica��es: OD -2,00 D / OE -2,00 D.'),
(2,'Com base no hist�rico m�dico, exame f�sico e resultados de exames, o diagn�stico � de Angina Est�vel de Esfor�o.','Ajuste de Medicamentos: Aumento da dose do anti-hipertensivo conforme orienta��o m�dica.
Modifica��o de Estilo de Vida: Incentivar aumento da atividade f�sica, redu��o do consumo de �lcool e acompanhamento com nutricionista para controle do diabetes.')


INSERT INTO Feedback(IdConsulta,Comentario)
VALUES (1,'Excelente Atendimento,Doutora Super atenciosa!!')
	   


select * from TipoDeUsuario
select * from Usuario
select * from Especialidade
select * from Clinica
select * from Paciente
select * from Medico
select * from Consulta
select * from Prontuario


