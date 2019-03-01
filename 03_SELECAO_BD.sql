--Listar todos os usu�rios
SELECT * FROM USUARIOS

--Listar todos os est�dios
SELECT * FROM ESTUDIOS

--Listar todos os jogos
SELECT * FROM JOGOS

--Listar todos os jogos e seus respectivos est�dios
SELECT JOGOS.NomeJogo, ESTUDIOS.* FROM 
JOGOS 
INNER JOIN
ESTUDIOS
ON
JOGOS.EstudioId = ESTUDIOS.EstudioId

--Buscar e trazer na lista todos os est�dios, mesmo que eles n�o contenham nenhum jogo de refer�ncia
SELECT ESTUDIOS.EstudioId, ESTUDIOS.NomeEstudio, JOGOS.NomeJogo FROM
ESTUDIOS
LEFT JOIN
JOGOS
ON
ESTUDIOS.EstudioId = JOGOS.JogoId

--Buscar um usu�rio por email e senha
--@EMAIL VARCHAR(250),
--@SENHA VARCHAR(250)
--'cliente@cliente.com', 'cliente'
--'admin@admin.com', 'admin'
SELECT Email, Senha FROM USUARIOS WHERE Email = 'cliente@cliente.com' AND Senha = 'cliente'


--Buscar um jogo por JogoId
SELECT * FROM JOGOS WHERE JogoId = 1

--Buscar um est�dio por EstudioId
SELECT * FROM ESTUDIOS WHERE EstudioId = 1

