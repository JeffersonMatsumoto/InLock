--Listar todos os usuários
SELECT * FROM USUARIOS

--Listar todos os estúdios
SELECT * FROM ESTUDIOS

--Listar todos os jogos
SELECT * FROM JOGOS

--Listar todos os jogos e seus respectivos estúdios
SELECT JOGOS.NomeJogo, ESTUDIOS.* FROM 
JOGOS 
INNER JOIN
ESTUDIOS
ON
JOGOS.EstudioId = ESTUDIOS.EstudioId

--Buscar e trazer na lista todos os estúdios, mesmo que eles não contenham nenhum jogo de referência
SELECT ESTUDIOS.EstudioId, ESTUDIOS.NomeEstudio, JOGOS.NomeJogo FROM
ESTUDIOS
LEFT JOIN
JOGOS
ON
ESTUDIOS.EstudioId = JOGOS.JogoId

--Buscar um usuário por email e senha
--@EMAIL VARCHAR(250),
--@SENHA VARCHAR(250)
--'cliente@cliente.com', 'cliente'
--'admin@admin.com', 'admin'
SELECT Email, Senha FROM USUARIOS WHERE Email = 'cliente@cliente.com' AND Senha = 'cliente'


--Buscar um jogo por JogoId
SELECT * FROM JOGOS WHERE JogoId = 1

--Buscar um estúdio por EstudioId
SELECT * FROM ESTUDIOS WHERE EstudioId = 1

