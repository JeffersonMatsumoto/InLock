INSERT INTO USUARIOS(Email, Senha, TipoUsuario)
VALUES ('admin@admin.com', 'admin', 'ADMINISTRADOR')
		,('cliente@cliente.com', 'cliente', 'CLIENTE')

INSERT INTO ESTUDIOS(NomeEstudio)
VALUES ('Blizzard'),('Rockstar Studios'),('Square Enix')

INSERT INTO JOGOS(NomeJogo, Descricao, DataLancamento, Valor, EstudioId)
VALUES ('Diablo 3', '� um jogo que cont�m bastante a��o e � viciante, seja voc� um novato ou um f�', '2012-05-15', 99.00, 1)
		,('Red Dead Redemption II', 'jogo eletr�nico de a��o-aventura western', '2018-10-26', 120.00, 2)

