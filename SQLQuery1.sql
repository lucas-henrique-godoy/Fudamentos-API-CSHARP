--Criando  banco de dados:
CREATE DATABASE Cadastro;

--Dizendo ao SQL Server que eu estou usando o banco chamado Cadastro:
USE Cadastro;

--Criando a tabela de pessoas:
CREATE TABLE Pessoas(
	PES_ID INT PRIMARY KEY IDENTITY(1,1),
	PES_NOME VARCHAR(100),
	PES_IDADE INT,
	PES_CPF VARCHAR(11) UNIQUE,
	PES_EMAIL VARCHAR(100)
);


--Inserindo dados na tabela de pessoas:
INSERT INTO Pessoas
	(PES_NOME,
	PES_IDADE,
	PES_CPF,
	PES_EMAIL)
VALUES('Lucas',
	27,
	'44003132053',
	'lucas@email.com'
);

