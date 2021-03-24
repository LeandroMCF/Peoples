CREATE DATABASE Peoples;
GO

USE Peoples;
GO

CREATE TABLE Funcionarios
(
	IdFuncionarios				INT PRIMARY KEY IDENTITY,
	Nome						VARCHAR(250) NOT NULL,
	Sobrenome					VARCHAR(250) NOT NULL,
);
GO