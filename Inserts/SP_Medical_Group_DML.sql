
USE SPMedicalGroup;
GO

INSERT INTO Clinica(nomeClinica,nomeEndereço)
VALUES (1,'Clinica Carijo'),('Rua Alameda Barão de Limeira');
GO


INSERT INTO TipoUsuario(TituloTipoUsuario)
VALUES (1 'Médico'),(2 'Paciente');
GO


INSERT INTO Especialidade(nomeEspecialidade)
VALUES ('Acupuntura'),('Anestesiologia'),('Cardiologia'),('Cirurgia Cardiovascular'),
('Cirurgia Geral'),('Cirurgia Plástica'),
('Dermatolgia'),('Radioterapia'),('Pediatria'),('Psiquiatria');
GO


INSERT INTO Usuario(IdTipoUsuario, Email, Senha)
VALUES (1,'matheus@email.com', '123456'),(1,'lucas@email.com', '654321'),(2,'arthur@email.com','145236'),
(3,2,'sabrina@email.com','215436'),(2,'caio@email.com','564123'),
GO


INSERT INTO Paciente(nomePaciente)
VALUES (1, 2,'Arthur'),(2,2,'Sabrina'),(3,3,'Caio')
GO


INSERT INTO Medico(NomeMedico)
VALUES (1, 1, 6, 1, 'Matheus','54356SP'),
(2, 1, 7, 1,	'Lucas')

GO

GO

INSERT INTO Consulta(numeroConsulta)
VALUES (1, 2, 1, '123'),
(2, 1, 2, '321')
(3, 3, 3, '132')

GO

INSERT INTO Situacao(nomeSituacao)
VALUES (1,'Agendada'),(2,'Realizada'),(3,'Cancelada');
GO


