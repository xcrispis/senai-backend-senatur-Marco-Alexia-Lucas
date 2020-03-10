CREATE DATABASE Senatur_Manha
USE Senatur_Manha

CREATE TABLE TipoUsuario (IdTipoUsuario INT IDENTITY PRIMARY KEY, Nome varchar(255))

CREATE TABLE Cidades (IdCidade INT IDENTITY PRIMARY KEY, NomeCidade varchar(255))

CREATE TABLE Pacotes (IdPacote INT IDENTITY PRIMARY KEY, NomePacote varchar(255), Descricao varchar(2000), DataIda date, DataVolta date, Valor decimal, IdCidade INT FOREIGN KEY REFERENCES Cidades(IdCidade), Ativo bit DEFAULT(1) NOT NULL)

CREATE TABLE Usuario (IdUsuario INT IDENTITY PRIMARY KEY, Email varchar(255), Senha nvarchar(30), IdTipoUsuario INT FOREIGN KEY REFERENCES TipoUsuario(IdTipoUsuario))
 