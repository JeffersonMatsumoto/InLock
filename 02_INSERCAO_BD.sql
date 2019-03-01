INSERT INTO USUARIOS(Email, Senha, TipoUsuario)
VALUES ('admin@admin.com', 'admin', 'ADMINISTRADOR')
		,('cliente@cliente.com', 'cliente', 'CLIENTE')

INSERT INTO ESTUDIOS(NomeEstudio)
VALUES ('Blizzard'),('Rockstar Studios'),('Square Enix')

INSERT INTO JOGOS(NomeJogo, Descricao, DataLancamento, Valor, EstudioId)
VALUES ('Diablo 3', 'é um jogo que contém bastante ação e é viciante, seja você um novato ou um fã', '2012-05-15', 99.00, 1)
		,('Red Dead Redemption II', 'jogo eletrônico de ação-aventura western', '2018-10-26', 120.00, 2)

