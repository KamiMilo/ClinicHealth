--DQL 

/*Criar script que exiba os seguintes dados:

- Id Consulta
- Data da Consulta
- Horario da Consulta
- Nome da Clinica
- Nome do Paciente
- Nome do Medico
- Especialidade do Medico
- CRM
- Prontuário ou Descricao
- FeedBack(Comentario da consulta)*/

SELECT 
Consulta.IdConsulta,
Consulta.[Data],
Consulta.Horario,
Clinica.Nome AS Clinica,
Paciente.Paciente,
Medico.Medico,
Especialidade.Especialidade,
Medico.CRM,
Prontuario.Descricao,
Feedback.Comentario

FROM
Consulta

LEFT Join
Medico on Consulta.IdMedico=Medico.IdMedico

LEFT Join
Clinica on Consulta.IdMedico = Medico.IdMedico

LEFT Join
Paciente on Consulta.IdPaciente = Paciente.IdPaciente

LEFT Join
Prontuario on Consulta.IdConsulta= Prontuario.IdProntuario

LEFT Join
Especialidade on Consulta.IdMedico= Especialidade.IdEspecialidade

LEFT Join
Feedback on Consulta.IdConsulta=Feedback.IdFeedback


select * from TipoDeUsuario
select * from Usuario
select * from Especialidade
select * from Clinica
select * from Paciente
select * from Medico
select * from Consulta
select * from Prontuario

DELETE FROM TipoDeUsuario Where Id


select * from Clinica inner join Medico on Medico.IdClinica = Clinica.IdClinica