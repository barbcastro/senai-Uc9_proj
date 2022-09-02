--cria��o do banco de dados
CREATE DATABASE TesteSegurancaBE7;

--colocar o banco de dados em uso
USE TesteSegurancaBE7;

--Cria��o de uma tabela para armazenar usu�rios
--Sempre que tivar mais uma informa��o abaixo colocar a virgula.

CREATE TABLE Usuarios
(
	Id INT PRIMARY KEY IDENTITY, --torna o campo auto incremental.
	Email VARCHAR(100) UNIQUE NOT NULL, --UNIQUE n�o permite dois cadastros com o mesmo email.
	Senha VARCHAR(50) NOT NULL --VARCHAR � para uso de dados para textos, () tem que indicar o tamanho.
);

--consulta a todos os dados da tabela criada
SELECT*FROM Usuarios;

--cadastrar um usu�rio no banco de dados.
INSERT INTO Usuarios VALUES ('email@email.com', 1234);
INSERT INTO Usuarios VALUES ('barbara@email.com', 'vip12345');

--hasheando dados em uma consulta.
SELECT Id, Email, HASHBYTES('MD2',Senha) FROM Usuarios; --HASHBYTES (recebe dois argumentos 1� tipo de criptografia/algoritmo, 2� campo a criptografar/hashear)

--hasheando dados e filtrando apenas um usu�rio.
SELECT Id, Email, HASHBYTES('MD2',Senha) FROM Usuarios WHERE Id = 2; --WHERE serve para filtrar usuario pelo id.

--hasheando dados e filtrando apenas um usu�rio e dando apelido para coluna hasheada 
SELECT Id, Email, HASHBYTES('MD2',Senha) AS 'Senha Hash' FROM Usuarios WHERE Id = 2; --AS serve pra da nome a coluna.

--utilizando algoritmo MD4(seguindo os �ltimos exemplos de linhas x colunas)
SELECT Id, Email, HASHBYTES('MD4',Senha) AS 'Senha Hash' FROM Usuarios WHERE Id = 2; --AS serve pra da nome a coluna.

--utilizando algoritmo MD5(seguindo os �ltimos exemplos de linhas x colunas)
SELECT Id, Email, HASHBYTES('MD5',Senha) AS 'Senha Hash' FROM Usuarios WHERE Id = 2; --AS serve pra da nome a coluna.

--utilizando algoritmo SHA(seguindo os �ltimos exemplos de linhas x colunas)
SELECT Id, Email, HASHBYTES('SHA',Senha) AS 'Senha Hash' FROM Usuarios WHERE Id = 2; --AS serve pra da nome a coluna.

--utilizando algoritmo SHA1(seguindo os �ltimos exemplos de linhas x colunas)
SELECT Id, Email, HASHBYTES('SHA1',Senha) AS 'Senha Hash' FROM Usuarios WHERE Id = 2; --AS serve pra da nome a coluna.

--utilizando algoritmo SHA2_256(seguindo os �ltimos exemplos de linhas x colunas)
SELECT Id, Email, HASHBYTES('SHA2_256',Senha) AS 'Senha Hash' FROM Usuarios WHERE Id = 2; --AS serve pra da nome a coluna.

--utilizando algoritmo SHA2_512(seguindo os �ltimos exemplos de linhas x colunas)
SELECT Id, Email, HASHBYTES('SHA2_512',Senha) AS 'Senha Hash' FROM Usuarios WHERE Id = 2; --AS serve pra da nome a coluna.

